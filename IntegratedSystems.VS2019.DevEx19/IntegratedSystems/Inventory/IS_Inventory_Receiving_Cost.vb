Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_Receiving_Cost

    Private sub LViewItems_DoubleClick(sender As Object, e As System.EventArgs) Handles LViewItems.DoubleClick
        IS_Inventory_Receiving_Cost_ADDCOST.txt_code.Text = LViewItems.SelectedItems.Item(0).SubItems(0).Text
        IS_Inventory_Receiving_Cost_ADDCOST.txt_model.Text = LViewItems.SelectedItems.Item(0).SubItems(1).Text
        IS_Inventory_Receiving_Cost_ADDCOST.txt_descrip.Text = LViewItems.SelectedItems.Item(0).SubItems(2).Text
        IS_Inventory_Receiving_Cost_ADDCOST.txt_color.Text = LViewItems.SelectedItems.Item(0).SubItems(3).Text
        IS_Inventory_Receiving_Cost_ADDCOST.txt_brand.Text = LViewItems.SelectedItems.Item(0).SubItems(4).Text
        IS_Inventory_Receiving_Cost_ADDCOST.txt_ChassisNo.Text = LViewItems.SelectedItems.Item(0).SubItems(5).Text
        IS_Inventory_Receiving_Cost_ADDCOST.txt_EngineNo.Text = LViewItems.SelectedItems.Item(0).SubItems(6).Text
        IS_Inventory_Receiving_Cost_ADDCOST.txt_unitcost.Text = LViewItems.SelectedItems.Item(0).SubItems(7).Text
        IS_Inventory_Receiving_Cost_ADDCOST.txt_vatamount.Text = LViewItems.SelectedItems.Item(0).SubItems(8).Text
        IS_Inventory_Receiving_Cost_ADDCOST.txt_totcost.Text = LViewItems.SelectedItems.Item(0).SubItems(9).Text
        IS_Inventory_Receiving_Cost_ADDCOST.txt_uniPrice.Text = LViewItems.SelectedItems.Item(0).SubItems(10).Text
        IS_Inventory_Receiving_Cost_ADDCOST.txt_keynumber.Text = LViewItems.SelectedItems.Item(0).SubItems(11).Text
        IS_Inventory_Receiving_Cost_ADDCOST.txt_note.Text = LViewItems.SelectedItems.Item(0).SubItems(12).Text
        IS_Inventory_Receiving_Cost_ADDCOST.Text = LViewItems.SelectedItems.Item(0).SubItems(0).Text
        IS_Inventory_Receiving_Cost_ADDCOST.ShowDialog()
    End Sub

    private sub cmd_vendor_Click(sender As System.Object, e As System.EventArgs) Handles cmd_vendor.Click
        IS_Inventory_Receiving_Cost_ShowSI.ShowDialog()
    End Sub

    private sub cmd_print_Click(sender As System.Object, e As System.EventArgs) Handles cmd_print.Click
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

End Class