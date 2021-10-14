Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient
Imports wSClassLib.myModules

Public Class IS_Inventory_Receiving
    Private Sub IS_Inventory_Receiving_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub IS_Inventory_Receiving_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "RECEIVING" Then
            clearItems()
        End If

        txt_TransCode.Text = Now.ToString("MM") & Now.ToString("dd") & Now.ToString("yyyy") & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
        searchApprover()
        DockItems.Visible = False
    End Sub

    Sub searchApprover()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM Makers WHERE username LIKE '" & MainMenu.App_User_Name.Caption & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_approver.Text = myDataReader("approver").ToString()
            End If
        End Using
    End Sub

    Sub del_item_Master()
        class_Database.Query_Execute(class_Database.ICSConnection, "DELETE FROM item_master WHERE refno LIKE '" & txt_refno.Text & "' AND pono LIKE '" & txt_pono.Text & "'", True, "Delete", "Delete Item Master")
    End Sub

    Sub del_item_Details()
        class_Database.Query_Execute(class_Database.ICSConnection, "DELETE FROM item_details WHERE refno LIKE '" & txt_refno.Text & "' AND pono LIKE '" & txt_pono.Text & "'", True, "Delete", "Delete Item Detail")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_list.Click
        IS_Inventory_List.ShowDialog()
    End Sub

    Sub clearItems()
        lbl_vendor.Text = String.Empty
        txt_refno.Text = String.Empty
        txt_pono.Text = String.Empty
        eventform.Text = String.Empty
        txt_remarks.Text = String.Empty
        txt_notes.Text = String.Empty
    End Sub

    Sub mg_Inventory_ReceivingForApproval()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@Paramrefno", txt_refno.Text),
            New SqlParameter("@Paramvendor", lbl_vendor.Text),
            New SqlParameter("@Paramtranscode", txt_TransCode.Text),
            New SqlParameter("@ParaminventoryStatus", txt_invenStat.Text),
            New SqlParameter("@ParamdateReceived", receivedDate.DateTime),
            New SqlParameter("@ParamPOno", txt_pono.Text),
            New SqlParameter("@Paramwhcategory", txt_whcode.Text),
            New SqlParameter("@Paramwhcode", txt_whcode.EditValue),
            New SqlParameter("@Paramtransactedby", MainMenu.App_User_Name.Caption),
            New SqlParameter("@Parambranchcode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@Paramapprover", txt_approver.Text),
            New SqlParameter("@Paramtransactiondate", receivedDate.EditValue),
            New SqlParameter("@Paramdateapproved", String.Empty),
            New SqlParameter("@Paramtotalunitcost", GridView.Columns("UnitCost").SummaryItem.SummaryValue),
            New SqlParameter("@Paramtotalvatamt", GridView.Columns("VATAmt").SummaryItem.SummaryValue),
            New SqlParameter("@ParamGrandTotalUnitCost", GridView.Columns("TotalCost").SummaryItem.SummaryValue),
            New SqlParameter("@Paramtotalunitprice", GridView.Columns("UnitPrice").SummaryItem.SummaryValue),
            New SqlParameter("@Paramitemcnt", GridView.Columns("ChassisNo").SummaryItem.SummaryValue),
            New SqlParameter("@Paramremarks", txt_remarks.Text),
            New SqlParameter("@Paramnote", txt_notes.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_Inventory_ReceivingForApproval", "Approved Items", txt_refno.Text)
    End Sub

    Sub mg_Inventory_ReceivingItemDetails()
        For i = 0 To GridView.DataRowCount - 1
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Paramrefno", txt_refno.Text),
                New SqlParameter("@Paramvendor", lbl_vendor.Text),
                New SqlParameter("@Paramtranscode", txt_TransCode.Text),
                New SqlParameter("@ParamdateReceived", receivedDate.EditValue),
                New SqlParameter("@ParamPOno", txt_pono.Text),
                New SqlParameter("@Paramwhcategory", txt_whcode.Text),
                New SqlParameter("@Paramwhcode", txt_whcode.EditValue),
                New SqlParameter("@Parambranchcode", MainMenu.statusBrCode.Caption),
                New SqlParameter("@Paramtransactiondate", receivedDate.EditValue),
                New SqlParameter("@ParamApprover", txt_approver.Text),
                New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption),
                New SqlParameter("@ParamVendorCode", lbl_vendor.EditValue),
                New SqlParameter("@ParamModelcode", GridView.GetRowCellValue(i, "Code")),
                New SqlParameter("@Parammodel", GridView.GetRowCellValue(i, "Model")),
                New SqlParameter("@Paramdescription", GridView.GetRowCellValue(i, "Description")),
                New SqlParameter("@Paramcolor", GridView.GetRowCellValue(i, "Color")),
                New SqlParameter("@ParamBrand", GridView.GetRowCellValue(i, "Brand")),
                New SqlParameter("@ParamEngineNo", GridView.GetRowCellValue(i, "EngineNo")),
                New SqlParameter("@ParamChassisNo", GridView.GetRowCellValue(i, "ChassisNo")),
                New SqlParameter("@ParamKeyNo", GridView.GetRowCellValue(i, "KeyNo")),
                New SqlParameter("@ParamUnitCost", GridView.GetRowCellValue(i, "UnitCost")),
                New SqlParameter("@ParamVatAmt", GridView.GetRowCellValue(i, "VATAmt")),
                New SqlParameter("@ParamTotalCost", GridView.GetRowCellValue(i, "TotalCost")),
                New SqlParameter("@ParamUnitPrice", GridView.GetRowCellValue(i, "UnitPrice")),
                New SqlParameter("@ParamAccountName", GridView.GetRowCellValue(i, "AccountName")),
                New SqlParameter("@ParasBranchCodeAccount", GridView.GetRowCellValue(i, "BrCodeAcct")),
                New SqlParameter("@ParamAccountNumber", GridView.GetRowCellValue(i, "AccountNumber")),
                New SqlParameter("@ParamLedgerSet", GridView.GetRowCellValue(i, "LedgerSet")),
                New SqlParameter("@ParamSpecificNotes", GridView.GetRowCellValue(i, "SpecificNotes"))
            }

            class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_Inventory_ReceivingItemDetails", "Receiving Unit Item")
        Next
        MsgBox("Sent ForApproval. Please inform your approver.", vbInformation)
    End Sub

    Private Sub IS_Inventory_Receiving_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Me.Text = "Disapproved" Then
            DockItems.Visible = False
        End If
        If Me.Text = "RECEIVING" Then
            receivedDate.EditValue = Now
            lbl_vendor.Text = String.Empty
            txt_whcode.Text = String.Empty
            Initialize_GridList()
            Initialize_mToolBars()
        End If
    End Sub

    Sub Initialize_mToolBars()
        Initialize_Button(FrmBtn_Export_to_Grid)

        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)
        Initialize_Supplier()
        Initialize_Supplier(lbl_vendor)
        Initialize_whcode()
        Initialize_whcode(txt_whcode)

        Initialize_Color()
        Initialize_Color(txt_color)
    End Sub

    Private Sub Btn_Generate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Generate.ItemClick
        If lbl_vendor.Text = "[EditValue is null]" Then
            MsgBox("Please select vendor!", vbCritical, "webSources")

        End If
        If txt_refno.Text = String.Empty Then
            MsgBox("Please input Reference Number!", vbCritical, "webSources")

        End If
        If txt_pono.Text = String.Empty Then
            MsgBox("Please input PO Number!", vbCritical, "webSources")

        End If
        If txt_whcode.Text = "[EditValue is null]" Then
            MsgBox("Please select warehouse category!", vbCritical, "webSources")

        End If
        If eventform.Text = "Disapproved" Then
            IS_Inventory_item_add.eventForm.Text = "RECEIVING"
            IS_Inventory_item_find.Show()
        Else
            If Me.Text = "Disapproved" Then
                IS_Inventory_item_add.eventForm.Text = "RECEIVING"
                Initialize_mToolBars()

                DockItems.Visible = True
            Else
                Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_master WHERE refno LIKE '" & txt_refno.Text & "' AND pono LIKE '" & txt_pono.Text & "'")
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        MsgBox("Reference Number and PO number already exist in the system!", vbCritical, "webSources")
                    End If
                End Using

                DockItems.Visible = True
            End If
        End If
    End Sub

    Private dt As DataTable

    Sub Initialize_GridList()
        dt = New DataTable
        dt.Columns.Add("Code")
        dt.Columns.Add("Model")
        dt.Columns.Add("Description")
        dt.Columns.Add("Color")
        dt.Columns.Add("Brand")
        dt.Columns.Add("EngineNo")
        dt.Columns.Add("ChassisNo")
        dt.Columns.Add("KeyNo")
        dt.Columns.Add("UnitCost")
        dt.Columns.Add("VATAmt")
        dt.Columns.Add("TotalCost")
        dt.Columns.Add("UnitPrice")
        dt.Columns.Add("AccountName")
        dt.Columns.Add("BrCodeAcct")
        dt.Columns.Add("AccountNumber")
        dt.Columns.Add("LedgerSet")
        dt.Columns.Add("SpecificNotes")

        GridList.DataSource = dt
    End Sub

    Sub Inventory_ItemAdd()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamEngineNo", txt_engineNo.Text),
            New SqlParameter("@ParamChassisNo", txt_chassisNo.Text),
            New SqlParameter("@ParamWHCode", txt_whcode.EditValue),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamBranchCodeAcct", txt_BrCode.Text),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamAccountName", txt_note.EditValue),
            New SqlParameter("@ParamSpecNotes", txt_SpecNotes.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_Inventory_ItemAdd")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MsgBox(myDataReader.Item("Message").ToString())
            Else
                If MsgBox("Item added to table. " & vbCrLf & "Do you want to create another? ", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then

                    Dim dr As DataRow = dt.NewRow
                    dr(0) = txt_ModelLookup.EditValue
                    dr(1) = txt_ModelLookup.Text
                    dr(2) = txt_descrip.Text
                    dr(3) = txt_color.Text
                    dr(4) = txt_brand.Text
                    dr(5) = txt_engineNo.Text
                    dr(6) = txt_chassisNo.Text
                    dr(7) = txt_keynumber.Text
                    dr(8) = txt_unitcost.EditValue
                    dr(9) = txt_vatamount.EditValue
                    dr(10) = txt_totcost.EditValue
                    dr(11) = txt_uniPrice.EditValue
                    dr(12) = txt_note.EditValue
                    dr(13) = txt_BrCode.Text
                    dr(14) = txt_AccountNumber.Text
                    dr(15) = txt_LedSet.Text
                    dr(16) = txt_SpecNotes.Text

                    dt.Rows.Add(dr)
                    GridList.DataSource = dt
                Else

                    Dim dr As DataRow = dt.NewRow
                    dr(0) = txt_ModelLookup.EditValue
                    dr(1) = txt_ModelLookup.Text
                    dr(2) = txt_descrip.Text
                    dr(3) = txt_color.Text
                    dr(4) = txt_brand.Text
                    dr(5) = txt_engineNo.Text
                    dr(6) = txt_chassisNo.Text
                    dr(7) = txt_keynumber.Text
                    dr(8) = txt_unitcost.EditValue
                    dr(9) = txt_vatamount.EditValue
                    dr(10) = txt_totcost.EditValue
                    dr(11) = txt_uniPrice.EditValue
                    dr(12) = txt_note.EditValue
                    dr(13) = txt_BrCode.Text
                    dr(14) = txt_AccountNumber.Text
                    dr(15) = txt_LedSet.Text
                    dr(16) = txt_SpecNotes.Text
                    dt.Rows.Add(dr)
                    GridList.DataSource = dt

                    DockItems.Visible = False
                End If
            End If
        End Using
    End Sub

    Sub Inventory_ItemAdd_Disapproved()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamEngineNo", txt_engineNo.Text),
            New SqlParameter("@ParamChassisNo", txt_chassisNo.Text),
            New SqlParameter("@ParamWHCode", txt_whcode.EditValue),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamBranchCodeAcct", txt_BrCode.Text),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamAccountName", txt_note.EditValue),
            New SqlParameter("@ParamSpecNotes", txt_SpecNotes.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_Inventory_ItemAdd")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MsgBox(myDataReader.Item("Message").ToString())
            Else
                If MsgBox("Item added to table. " & vbCrLf & "Do you want to create another? ", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then

                    Dim dr As DataRow = IS_Inventory_List.dt_Receiving.NewRow
                    dr(0) = txt_ModelLookup.EditValue
                    dr(1) = txt_ModelLookup.Text
                    dr(2) = txt_descrip.Text
                    dr(3) = txt_color.Text
                    dr(4) = txt_brand.Text
                    dr(5) = txt_engineNo.Text
                    dr(6) = txt_chassisNo.Text
                    dr(7) = txt_keynumber.Text
                    dr(8) = txt_unitcost.EditValue
                    dr(9) = txt_vatamount.EditValue
                    dr(10) = txt_totcost.EditValue
                    dr(11) = txt_uniPrice.EditValue
                    dr(12) = txt_note.EditValue
                    dr(13) = txt_BrCode.Text
                    dr(14) = txt_AccountNumber.Text
                    dr(15) = txt_LedSet.Text
                    dr(16) = txt_SpecNotes.Text
                    IS_Inventory_List.dt_Receiving.Rows.Add(dr)
                    GridList.DataSource = IS_Inventory_List.dt_Receiving
                Else

                    Dim dr As DataRow = IS_Inventory_List.dt_Receiving.NewRow
                    dr(0) = txt_ModelLookup.EditValue
                    dr(1) = txt_ModelLookup.Text
                    dr(2) = txt_descrip.Text
                    dr(3) = txt_color.Text
                    dr(4) = txt_brand.Text
                    dr(5) = txt_engineNo.Text
                    dr(6) = txt_chassisNo.Text
                    dr(7) = txt_keynumber.Text
                    dr(8) = txt_unitcost.EditValue
                    dr(9) = txt_vatamount.EditValue
                    dr(10) = txt_totcost.EditValue
                    dr(11) = txt_uniPrice.EditValue
                    dr(12) = txt_note.EditValue
                    dr(13) = txt_BrCode.Text
                    dr(14) = txt_AccountNumber.Text
                    dr(15) = txt_LedSet.Text
                    dr(16) = txt_SpecNotes.Text
                    IS_Inventory_List.dt_Receiving.Rows.Add(dr)
                    GridList.DataSource = IS_Inventory_List.dt_Receiving

                    DockItems.Visible = False
                End If
            End If
        End Using
    End Sub

    Private Sub Btn_Link_Click(sender As Object, e As EventArgs) Handles FrmBtn_Export_to_Grid.Click
        If Me.Text = "Disapproved" Then
            Inventory_ItemAdd_Disapproved()
        Else
            Inventory_ItemAdd()
        End If
    End Sub

    Sub ComputeTotalCost()
        txt_vatamount.Text = Format((Val(txt_unitcost.Text) * Val(num_vat.Value)) / 100, "####.##")
        txt_totcost.Text = Format(Val(txt_unitcost.Text) + txt_vatamount.Text, "####.##")
    End Sub

    Private Sub txt_unitcost_EditValueChanged(sender As Object, e As EventArgs) Handles txt_unitcost.EditValueChanged
        ComputeTotalCost()
    End Sub

    Private Sub num_vat_EditValueChanged(sender As Object, e As EventArgs) Handles num_vat.EditValueChanged
        ComputeTotalCost()
    End Sub

    Private Sub txt_unitcost_TextChanged(sender As Object, e As EventArgs) Handles txt_unitcost.TextChanged
        If txt_unitcost.Text = String.Empty Then
        Else
            txt_vatamount.Text = Format((Val(txt_unitcost.Text) * Val(num_vat.Value)) / 100, "####.##")
            txt_totcost.Text = Format(Val(txt_unitcost.Text) + txt_vatamount.Text, "####.##")
        End If
    End Sub

    Private Sub txt_vatamount_TextChanged(sender As Object, e As EventArgs) Handles txt_vatamount.TextChanged
        If txt_vatamount.Text = String.Empty Then
            txt_vatamount.Text = "0"
        End If
    End Sub

    Private Sub txt_totcost_TextChanged(sender As Object, e As EventArgs) Handles txt_totcost.TextChanged
        If txt_totcost.Text = String.Empty Then
            txt_totcost.Text = "0"
        End If
    End Sub

    Private Sub Btn_Account_Click(sender As Object, e As EventArgs) Handles Btn_Account.Click
        IS_Sales_ReleaseAccount_List.Text = "ACCTDEP"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Private Sub txt_SpecNotes_DoubleClick(sender As Object, e As EventArgs) Handles txt_SpecNotes.DoubleClick
        txt_SpecNotes.Text = String.Empty
    End Sub

    Private Sub txt_refno_EditValueChanged(sender As Object, e As EventArgs) Handles txt_refno.EditValueChanged
        txt_pono.EditValue = txt_refno.EditValue
    End Sub

    Private Sub txt_brand_EditValueChanged(sender As Object, e As EventArgs) Handles txt_brand.EditValueChanged
        Initialize_Model(txt_brand.EditValue)
        Initialize_Model(txt_ModelLookup, txt_brand.EditValue)
    End Sub

    Private Sub txt_ModelLookup_EditValueChanged(sender As Object, e As EventArgs) Handles txt_ModelLookup.EditValueChanged
        txt_descrip.EditValue = txt_ModelLookup.Text & " - " & txt_color.Text
    End Sub

    Private Sub txt_color_EditValueChanged(sender As Object, e As EventArgs) Handles txt_color.EditValueChanged
        txt_descrip.EditValue = txt_ModelLookup.Text & " - " & txt_color.Text
    End Sub

    Private Sub Btn_Send_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Send.ItemClick
        statuserror.Text = "0"
        ' 
        If lbl_vendor.Text = String.Empty Then
            MsgBox("Please select vendor!", vbCritical, "webSources")
            Return
        End If
        If txt_refno.Text = String.Empty Then
            MsgBox("Please input Reference Number!", vbCritical, "webSources")
            Return
        End If
        If txt_pono.Text = String.Empty Then
            MsgBox("Please input PO Number!", vbCritical, "webSources")
            Return
        End If
        If txt_whcode.Text = String.Empty Then
            MsgBox("Please select warehouse category!", vbCritical, "webSources")
            Return
        End If
        mg_Inventory_ReceivingForApproval()
        If statuserror.Text = "0" Then
            mg_Inventory_ReceivingItemDetails()
            clearItems()
        End If
    End Sub

    Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Dim view As GridView = CType(sender, GridView)
            view.DeleteRow(view.FocusedRowHandle)
        End If
    End Sub

    Private Sub LayoutControlItem9_DoubleClick(sender As Object, e As EventArgs) Handles LayoutControlItem9.DoubleClick
        MsgBox(txt_whcode.Text & txt_whcode.EditValue)
    End Sub

End Class