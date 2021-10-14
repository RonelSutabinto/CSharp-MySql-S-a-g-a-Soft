﻿Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports wSClassLib.myModules

Public Class IS_Inventory_Outgoing
    Private Sub IS_Inventory_Outgoing_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "OUTGOING" Then
            searchApprover()
            txt_TransCode.Text = Now.ToString("MM") & Now.ToString("dd") & Now.ToString("yyyy") & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
            txt_TransCode.EditValue = Now.ToString("MM") & Now.ToString("dd") & Now.ToString("yyyy") & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
        End If
    End Sub

    Private sub searchApprover()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM Makers WHERE username LIKE '" & class_Variables.sUserName & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_approver.Text = myDataReader("approver").ToString()
            End If
        End Using
    End Sub

    private sub del_item_Master()
        class_Database.Query_Execute(class_Database.ICSConnection, "DELETE FROM item_master WHERE refno LIKE '" & txt_refno.Text & "' AND pono LIKE '" & txt_pono.Text & "'", True, "Delete", "Delete Item Master")
    End Sub

    private sub del_item_Details()
        class_Database.Query_Execute(class_Database.ICSConnection, "DELETE FROM item_details WHERE refno LIKE '" & txt_refno.Text & "' AND pono LIKE '" & txt_pono.Text & "'", True, "Delete", "Delete Item Detail")
    End Sub

    private sub Save_item_Details()
        For i = 0 To gridView.DataRowCount - 1
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Paramrefno", txt_refno.Text),
                New SqlParameter("@Paramvendor", lbl_vendor.Text),
                New SqlParameter("@ParamVendorCode", lbl_vendor.EditValue),
                New SqlParameter("@Paramtranscode", txt_TransCode.Text),
                New SqlParameter("@ParamdateReceived", Format(receivedDate.EditValue, "MMM dd, yyyy")),
                New SqlParameter("@ParamPOno", txt_pono.Text),
                New SqlParameter("@Paramwhcategory", cmb_warehouse.Text),
                New SqlParameter("@Paramwhcode", cmb_warehouse.EditValue),
                New SqlParameter("@Parambranchcode", class_saga_variables.sbranchcode),
                New SqlParameter("@ParamTransactedby", class_Variables.sUserName),
                New SqlParameter("@paramcode", gridView.GetRowCellValue(i, "Code")),
                New SqlParameter("@Parammodel", gridView.GetRowCellValue(i, "Model")),
                New SqlParameter("@Paramdescription", gridView.GetRowCellValue(i, "Description")),
                New SqlParameter("@Paramcolor", gridView.GetRowCellValue(i, "Color")),
                New SqlParameter("@ParamBrand", gridView.GetRowCellValue(i, "Brand")),
                New SqlParameter("@ParamChassisNo", gridView.GetRowCellValue(i, "ChassisNo")),
                New SqlParameter("@ParamEngineNo", gridView.GetRowCellValue(i, "EngineNo")),
                New SqlParameter("@ParamUnitCost", gridView.GetRowCellValue(i, "UnitCost")),
                New SqlParameter("@ParamVatAmt", gridView.GetRowCellValue(i, "VATAmt")),
                New SqlParameter("@ParamTotalCost", gridView.GetRowCellValue(i, "TotalCost")),
                New SqlParameter("@ParamUnitPrice", gridView.GetRowCellValue(i, "UnitPrice")),
                New SqlParameter("@ParamKeyNo", gridView.GetRowCellValue(i, "KeyNo")),
                New SqlParameter("@ParamprevID", gridView.GetRowCellValue(i, "id")),
                New SqlParameter("@Paramtransactiondate", Now),
                New SqlParameter("@ParaminventoryStatus", txt_invenStat.Text),
                New SqlParameter("@ParamAccountName", gridView.GetRowCellValue(i, "AccountName")),
                New SqlParameter("@ParasBranchCodeAccount", gridView.GetRowCellValue(i, "BrCodeAcct")),
                New SqlParameter("@ParamAccountNumber", gridView.GetRowCellValue(i, "AccountNumber")),
                New SqlParameter("@ParamLedgerSet", gridView.GetRowCellValue(i, "LedgerSet")),
                New SqlParameter("@ParamSpecificNotes", gridView.GetRowCellValue(i, "SpecificNotes"))
            }

            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_Inventory_OutgoingItemDetails", "Item Detail")
        Next

        MsgBox("Sent ForApproval. Please inform your approver.", vbInformation)
    End Sub

    private sub Save_item_Master()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@Paramrefno", txt_refno.Text),
            New SqlParameter("@Paramvendor", lbl_vendor.Text),
            New SqlParameter("@Paramtranscode", txt_TransCode.Text),
            New SqlParameter("@ParaminventoryStatus", txt_invenStat.Text),
            New SqlParameter("@ParamdateReceived", Format(receivedDate.EditValue, "MMM dd, yyyy")),
            New SqlParameter("@ParamPOno", txt_pono.Text),
            New SqlParameter("@Paramwhcategory", cmb_warehouse.Text),
            New SqlParameter("@Paramwhcode", cmb_warehouse.EditValue),
            New SqlParameter("@Paramtransactedby", class_Variables.sUserName),
            New SqlParameter("@Parambranchcode", class_saga_variables.sbranchcode),
            New SqlParameter("@Paramapprover", txt_approver.Text),
            New SqlParameter("@Paramtransactiondate", Format(receivedDate.EditValue, "MMM dd, yyyy")),
            New SqlParameter("@Paramdateapproved", Format(receivedDate.EditValue, "MMM dd, yyyy")),
            New SqlParameter("@Paramtotalunitcost", gridView.Columns("UnitCost").SummaryItem.SummaryValue),
            New SqlParameter("@Paramtotalvatamt", gridView.Columns("VATAmt").SummaryItem.SummaryValue),
            New SqlParameter("@ParamGrandTotalUnitCost", gridView.Columns("TotalCost").SummaryItem.SummaryValue),
            New SqlParameter("@Paramtotalunitprice", gridView.Columns("UnitPrice").SummaryItem.SummaryValue),
            New SqlParameter("@Paramitemcnt", gridView.Columns("ChassisNo").SummaryItem.SummaryValue),
            New SqlParameter("@ParamVendorCode", lbl_vendor.EditValue),
            New SqlParameter("@ParamSourceEvent", txt_notes.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_Inventory_OutgoingForApproval", "Item Master", txt_refno.Text)
    End Sub

    private sub lbl_vendorCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.Text = "OUTGOING" Then
        ElseIf Me.Text = "DISAPPROVED" Then
        End If
    End Sub

    private sub clearItems()
        lbl_vendor.Text = String.Empty

        ' LViewItems.Items.Clear()
        txt_refno.Text = String.Empty
        txt_pono.Text = String.Empty
        '  txt_receiver.Text = String.Empty
        txt_receiverUsername.Text = String.Empty
    End Sub

    private sub cmd_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_list.Click
        'IS_Inventory_List.ShowDialog()
    End Sub

    private sub txt_receiver_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_receiver.TextChanged
        If Me.Text = "OUTGOING" Then
            '  Findusername()
        ElseIf Me.Text = "Disapproved" Then

        End If
    End Sub

    private sub lbl_tot_unit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If lbl_tot_unit.Text = String.Empty Then
            lbl_tot_unit.Text = "0.00"
        End If
    End Sub

    private sub lbl_totVatAmt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If lbl_totVatAmt.Text = String.Empty Then
            lbl_totVatAmt.Text = "0.00"
        End If
    End Sub

    private sub lbl_grandTotal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If lbl_grandTotal.Text = String.Empty Then
            lbl_grandTotal.Text = "0.00"
        End If
    End Sub

    private sub lbl_totUnitPrice_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If lbl_totUnitPrice.Text = String.Empty Then
            lbl_totUnitPrice.Text = "0.00"
        End If
    End Sub

    private sub IS_Inventory_Outgoing_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        receivedDate.EditValue = Now
        Initialize_IntransitBranch()
        Initialize_IntransitBranch(lbl_vendor)

        Initialize_whcodeOutgoing()
        Initialize_whcodeOutgoing(cmb_warehouse)

        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)

        If Me.Text = "DISAPPROVED" Then
        Else
            IS_Inventory_Outgoing_item_find.Initialize_GridList_outgoing()
        End If

    End Sub

    private sub btn_Send_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Send.ItemClick
        statuserror.Text = "0"
        If lbl_vendor.Text = String.Empty Then
            MsgBox("Please select vendor!", vbCritical, "webSources")

        End If
        If txt_refno.Text = String.Empty Then
            MsgBox("Please input Reference Number!", vbCritical, "webSources")

        End If
        If txt_pono.Text = String.Empty Then
            MsgBox("Please input PO Number!", vbCritical, "webSources")

        End If
        If cmb_warehouse.Text = String.Empty Then
            MsgBox("Please select warehouse category!", vbCritical, "webSources")

        End If

        Save_item_Master()

        If statuserror.Text <> "1" Then
            Save_item_Details()
            clearItems()

            IS_Inventory_Outgoing_item_find.Initialize_GridList_outgoing()

        End If
    End Sub

    private sub btn_Generate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Generate.ItemClick
        If lbl_vendor.Text = "[EditValue is null]" Then
            MsgBox("Please select vendor!", vbCritical, "webSources")

        End If
        If txt_refno.Text = String.Empty Then
            MsgBox("Please input Reference Number!", vbCritical, "webSources")

        End If
        If txt_pono.Text = String.Empty Then
            MsgBox("Please input PO Number!", vbCritical, "webSources")

        End If
        If cmb_warehouse.Text = "[EditValue is null]" Then
            MsgBox("Please select warehouse category!", vbCritical, "webSources")

        End If

        If Me.Text = "OUTGOING" Then
            Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_master WHERE refno LIKE '" & txt_refno.Text & "' AND pono LIKE '" & txt_pono.Text & "'")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    MsgBox("Reference Number and PO number already exist in the system!", vbCritical, "webSources")
                End If
            End Using
        Else
            IS_Inventory_Outgoing_item_find.Text = "OUTGOING"
            IS_Inventory_Outgoing_item_find.ShowDialog()
        End If

        If Me.Text = "DISAPPROVED" Then
            IS_Inventory_Outgoing_item_find.Text = "DISAPPROVED"
            IS_Inventory_Outgoing_item_find.ShowDialog()
        End If
    End Sub

    private sub txt_refno_EditValueChanged(sender As Object, e As EventArgs) Handles txt_refno.EditValueChanged
        txt_pono.Text = txt_refno.Text
    End Sub

    private sub lbl_vendor_EditValueChanged(sender As Object, e As EventArgs) Handles lbl_vendor.EditValueChanged
        mVendorCode = lbl_vendor.EditValue
        Initialize_InvOutReceiver()
        Initialize_InvOutReceiver(txt_receiver)

        If Me.Text = "DISAPPROVED" Then
        Else
            txt_refno.Text = lbl_vendor.EditValue & "-" & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
            txt_refno.EditValue = lbl_vendor.EditValue & "-" & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
            txt_pono.Text = lbl_vendor.EditValue & "-" & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
            txt_pono.EditValue = lbl_vendor.EditValue & "-" & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
        End If

    End Sub

    private sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Dim view As gridView = CType(sender, gridView)
            view.DeleteRow(view.FocusedRowHandle)
        End If
    End Sub

End Class