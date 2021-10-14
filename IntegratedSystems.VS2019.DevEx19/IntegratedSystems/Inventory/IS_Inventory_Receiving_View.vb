Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_Receiving_View
    private sub IS_Inventory_Receiving_View_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        cmd_approved.Visible = False
        cmd_disapproved.Visible = False
    End Sub

    private sub IS_Inventory_Receiving_View_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    private sub Approveditems()
        If class_Database.Data_Update(class_Database.ICSConnection, "UPDATE item_Master set inventoryStatus='Approved',branchCode = '" & class_saga_variables.sbranchcode & "',OriginatingMaker='" & txt_sender.Text & "',OriginatingBranch='" & txt_originatingBranch.Text & "',transactedby='" & class_Variables.sUserName & "',remarks='APPROVED' WHERE refno LIKE '" & txt_refno.Text & "' AND pono LIKE '" & txt_pono.Text & "' AND inventoryStatus LIKE '" & txt_invenStat.Text & "'") AndAlso
        class_Database.Data_Update(class_Database.ICSConnection, "UPDATE item_Details set IfExist='1',branchCode='" & class_saga_variables.sbranchcode & "',inventoryStatus='Approved' WHERE refno LIKE '" & txt_refno.Text & "' AND pono LIKE '" & txt_pono.Text & "'") Then
            MsgBox("The item/s has been approved!", vbInformation, "webSources")
        End If
    End Sub

    private sub ApproveditemsSameBranch()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamRefNo", txt_refno.Text),
            New SqlParameter("@ParamPONo", txt_pono.Text),
            New SqlParameter("@ParamInventoryStatus", txt_invenStat.Text),
            New SqlParameter("@ParamOriginatingBranch", txt_originatingBranch.Text),
            New SqlParameter("@ParamOriginatingMaker", txt_sender.Text),
            New SqlParameter("@ParamSourceEvent", "RECEIVING"),
            New SqlParameter("@ParamApprover", class_Variables.sUserName),
            New SqlParameter("@ParamTransactedby", class_Variables.sUserName),
            New SqlParameter("@ParamWHCode", txt_whcode.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_Inventory_ItemApproval", "Received Items Approved")
    End Sub

    private sub DisApproveditems()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamRefNo", txt_refno.Text),
            New SqlParameter("@ParamPONo", txt_pono.Text),
            New SqlParameter("@ParamInventoryStatus", txt_invenStat.Text),
            New SqlParameter("@ParamSourceEvent", "RECEIVING"),
            New SqlParameter("@ParamRemarks", txt_disappr_remarks.Text),
            New SqlParameter("@ParamTransactedby", class_Variables.sUserName),
            New SqlParameter("@ParamApprover", class_Variables.sUserName)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_Inventory_ItemDisapproved", "Received Units Disapproved")
    End Sub

    private sub cmd_approved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_approved.Click
        If txt_invenStat.Text = "For Approval" Then
            ApproveditemsSameBranch()
        ElseIf txt_invenStat.Text = "For Transport" Then
            Approveditems()
        End If
    End Sub

    private sub cmd_disapproved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_disapproved.Click
        grp_remarks.Visible = True
    End Sub

    private sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        LoadIntransitMCMaster()
        LoadIntransitMCDetails()
        ShowReport()
    End Sub

    private sub LoadIntransitMCMaster()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamRefNo", txt_refno.Text),
            New SqlParameter("@ParamPoNo", txt_pono.Text),
            New SqlParameter("@ParamWhCode", txt_whcode.Text),
            New SqlParameter("@ParamTitle", txt_rptTitle.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowInMCInventoryMasterDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                txt_BranchCode.Text = myDataReader("branchcode").ToString()
                txt_BranchName.Text = myDataReader("BranchName").ToString()
                txt_BranchAddress.Text = myDataReader("BranchAddress").ToString()
                txt_phoneNo.Text = myDataReader("BranchPhoneNumber").ToString()
                txt_vendor.Text = myDataReader("vendor").ToString()

                txt_Date.Text = Format(myDataReader.Item("dateReceived"), "MMMM d,yyyy")
                txt_Warehouse.Text = myDataReader("whcategory").ToString()
                txt_Count.Text = myDataReader("itemcnt").ToString()

                txt_UnitCostTot.EditValue = myDataReader("totalUnitCost").ToString()
                txt_VatTotal.EditValue = myDataReader("totalVATAmt").ToString()
                txt_GrandTotal.EditValue = myDataReader("GrandTotalUnitCost").ToString()
                txt_UnitPriceTotal.EditValue = myDataReader("TotalUnitPrice").ToString()

                txt_TransactedBy.Text = myDataReader("TransactedbyFull").ToString()
                txt_ApprovedBy.Text = myDataReader("ApproverFull").ToString()

                txt_ValidatedBy.Text = myDataReader("ValidatedByFull").ToString()

                txt_ReceivedBy.Text = myDataReader("BranchReceiverFull").ToString()
                txt_ConfirmedBy.Text = myDataReader("BMReceiver").ToString()
            End If
        End Using
    End Sub

    private sub LoadIntransitMCDetails()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamRefNo", txt_refno.Text),
            New SqlParameter("@ParamPoNo", txt_pono.Text),
            New SqlParameter("@ParamWhCode", txt_whcode.Text),
            New SqlParameter("@ParamTitle", txt_rptTitle.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GCInTransitMC, GViewMCIntransit, "mg_ShowInMCInventoryMasterDetails")
    End Sub

    private sub ShowReport()
        Dim report As New rpt_inv_Inventory_ReceivingReport()
        GViewMCIntransit.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GCInTransitMC

        report.txt_Title.Text = txt_rptTitle.Text
        report.txt_Branch.Text = txt_BranchName.Text
        report.txt_BranchAddress.Text = txt_BranchAddress.Text
        report.txt_Number.Text = txt_phoneNo.Text

        report.txt_Vendor.Text = txt_vendor.Text
        report.txt_Date.Text = txt_Date.Text
        report.txt_Warehouse.Text = txt_Warehouse.Text

        report.txt_Refno.Text = txt_refno.Text
        report.txt_PONo.Text = txt_pono.Text

        report.txt_Count.Text = txt_Count.Text

        report.txt_CostTotal.Text = txt_UnitCostTot.Text
        report.txt_VatTotal.Text = txt_VatTotal.Text
        report.txt_GrandTotal.Text = txt_GrandTotal.Text
        report.txt_UnitPriceTotal.Text = txt_UnitPriceTotal.Text

        report.txt_Transactedby.Text = txt_TransactedBy.Text
        report.txt_approved.Text = txt_ApprovedBy.Text

        report.txt_validated.Text = txt_ValidatedBy.Text

        report.txt_ReceivedBy.Text = String.Empty
        report.txt_ReceiverBM.Text = String.Empty

        report.ShowPreview
    End Sub

    private sub cmb_disapp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_disapp.Click
        DisApproveditems()
        grp_remarks.Visible = False
    End Sub
End Class