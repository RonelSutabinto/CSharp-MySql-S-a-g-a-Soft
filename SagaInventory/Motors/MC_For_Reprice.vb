Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Public Class MC_For_Reprice

    Public dt As DataTable
    Dim Ref_Number As String

    Private Sub MC_For_Reprice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize_GridList()
        Ref_Number = $"{DateTime.Now:MMddyyyyhhmmss}"
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)

        class_Saga_Procedures.Initialize_Branch(Branch, RepositoryItemLookUpEdit_Branch)

        'xuc_MC_Reprice.sBranchCode.Equals("000")
        'If class_Saga_Variables.sBranchCode.Equals("000") Then
        '    Branch.Enabled = True
        'Else
        '    Branch.Enabled = False
        'End If
    End Sub

    Private Sub MC_For_Reprice_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Initialize_GridList()
        Toogle_Days_EditValueChanged(sender, e)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub MC_For_Reprice_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Close()
    End Sub

    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
    End Sub

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
        dt.Columns.Add("Principal")
        dt.Columns.Add("Interest")
        dt.Columns.Add("OutstandingBal")
        dt.Columns.Add("DP")
        dt.Columns.Add("PMT")
        dt.Columns.Add("PrevID")

        GridList.DataSource = dt
    End Sub

    Private Sub btn_Send_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
        If class_Procedures.actionAsk("APPROVAL", "Send Depo to Repo for Approval") Then
            Control_Save()
            Control_Save_to_item_Details()
            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "DEPO TO REPO Sent for Approval", "FOR APPROVAL", True)
        End If
        'Dim News As Integer = MessageBox.Show("Are you sure sending this Transactions?", "DEPO TO REPO", MessageBoxButtons.YesNo)
        'If News = DialogResult.No Then
        '    MessageBox.Show("Thanks for not sending the Transactions!", "DEPO TO REPO")
        'Else

        'End If
    End Sub

    Friend Sub Control_Save_to_item_Details()
        For i = 0 To gridView.DataRowCount - 1
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Paramrefno", Ref_Number),
                New SqlParameter("@ParamPOno", Ref_Number),
                New SqlParameter("@Paramtranscode", Ref_Number),
                New SqlParameter("@ParamdateReceived", Date.Now()),
                New SqlParameter("@Paramtransactiondate", Date.Now()),
                New SqlParameter("@ParamApprover", "jsomandam"),
                New SqlParameter("@Paramwhcategory", "REPOSSESSED"),
                New SqlParameter("@Paramwhcode", "REP"),
                New SqlParameter("@ParamTransactedBy", class_Variables.sUserName),
                New SqlParameter("@Paramvendor", class_Saga_Database.get_Branch_Name(Branch.EditValue.ToString())),
                New SqlParameter("@ParamVendorCode", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Parambranchcode", class_Saga_Variables.sBranchCode),
                New SqlParameter("@ParamModelcode", gridView.GetRowCellValue(i, "Code")),
                New SqlParameter("@Parammodel", gridView.GetRowCellValue(i, "Model")),
                New SqlParameter("@Paramdescription", gridView.GetRowCellValue(i, "Description")),
                New SqlParameter("@Paramcolor", gridView.GetRowCellValue(i, "Color")),
                New SqlParameter("@ParamBrand", gridView.GetRowCellValue(i, "Brand")),
                New SqlParameter("@ParamEngineNo", gridView.GetRowCellValue(i, "EngineNo")),
                New SqlParameter("@ParamChassisNo", gridView.GetRowCellValue(i, "ChassisNo")),
                New SqlParameter("@ParamKeyNo", gridView.GetRowCellValue(i, "KeyNo")),
                New SqlParameter("@ParamUnitCost", gridView.GetRowCellValue(i, "UnitCost")),
                New SqlParameter("@ParamVatAmt", gridView.GetRowCellValue(i, "VATAmt")),
                New SqlParameter("@ParamTotalCost", gridView.GetRowCellValue(i, "TotalCost")),
                New SqlParameter("@ParamUnitPrice", gridView.GetRowCellValue(i, "UnitPrice")),
                New SqlParameter("@ParamAccountName", gridView.GetRowCellValue(i, "AccountName")),
                New SqlParameter("@ParamBrCodeAccount", gridView.GetRowCellValue(i, "BrCodeAcct")),
                New SqlParameter("@ParamAccountNumber", gridView.GetRowCellValue(i, "AccountNumber")),
                New SqlParameter("@ParamLedgerSet", gridView.GetRowCellValue(i, "LedgerSet")),
                New SqlParameter("@ParamSpecificNotes", gridView.GetRowCellValue(i, "SpecificNotes"))
            }
            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_Inventory_ReceivingItemDetails", "DEPO TO REPO")
        Next
    End Sub

    Friend Sub Control_Save()
        For i = 0 To gridView.DataRowCount - 1
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Ref_Number", Ref_Number),
                New SqlParameter("@PO_Number", Ref_Number),
                New SqlParameter("@Trans_Code", Ref_Number),
                New SqlParameter("@Posting_Date", Date.Now()),
                New SqlParameter("@COD", "0.00"),
                New SqlParameter("@LCP", "0.00"),
                New SqlParameter("@Approver", "jsomandam"),
                New SqlParameter("@WH_Category", "REPOSSESSED"),
                New SqlParameter("@WH_Code", "REP"),
                New SqlParameter("@Inventory_Status", "For Approval"),
                New SqlParameter("@Transacted_By", class_Variables.sUserName),
                New SqlParameter("@Vendor", class_Saga_Database.get_Branch_Name(Branch.EditValue.ToString())),
                New SqlParameter("@Vendor_Code", Branch.EditValue.ToString()),
                New SqlParameter("@Branch_Code", Branch.EditValue.ToString()),
                New SqlParameter("@Model_code", gridView.GetRowCellValue(i, "Code")),
                New SqlParameter("@Model_Name", gridView.GetRowCellValue(i, "Model")),
                New SqlParameter("@Model_Description", gridView.GetRowCellValue(i, "Description")),
                New SqlParameter("@Model_color", gridView.GetRowCellValue(i, "Color")),
                New SqlParameter("@Brand", gridView.GetRowCellValue(i, "Brand")),
                New SqlParameter("@Engine_Number", gridView.GetRowCellValue(i, "EngineNo")),
                New SqlParameter("@Chassis_Number", gridView.GetRowCellValue(i, "ChassisNo")),
                New SqlParameter("@Key_Number", gridView.GetRowCellValue(i, "KeyNo")),
                New SqlParameter("@Unit_Cost", gridView.GetRowCellValue(i, "UnitCost")),
                New SqlParameter("@Vat_Amount", gridView.GetRowCellValue(i, "VATAmt")),
                New SqlParameter("@Total_Cost", gridView.GetRowCellValue(i, "TotalCost")),
                New SqlParameter("@New_Price", gridView.GetRowCellValue(i, "UnitPrice")),
                New SqlParameter("@Account_Name", gridView.GetRowCellValue(i, "AccountName")),
                New SqlParameter("@Branch_Code_Acct", gridView.GetRowCellValue(i, "BrCodeAcct")),
                New SqlParameter("@Account_Number", gridView.GetRowCellValue(i, "AccountNumber")),
                New SqlParameter("@Ledger_Set_Number", gridView.GetRowCellValue(i, "LedgerSet")),
                New SqlParameter("@Specific_Notes", gridView.GetRowCellValue(i, "SpecificNotes")),
                New SqlParameter("@Outstanding_Balance", gridView.GetRowCellValue(i, "OutstandingBal")),
                New SqlParameter("@Prev_ID", gridView.GetRowCellValue(i, "PrevID")),
                New SqlParameter("@Principal_Balance", gridView.GetRowCellValue(i, "Principal")),
                New SqlParameter("@Interest_Balance", gridView.GetRowCellValue(i, "Interest")),
                New SqlParameter("@DP", gridView.GetRowCellValue(i, "DP")),
                New SqlParameter("@PMT", gridView.GetRowCellValue(i, "PMT")),
                New SqlParameter("@Action_Type", "MCUnitsForRepo")
            }
            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "bj_Inventory_DepUnits", "DEPO TO REPO")
        Next
    End Sub

    Private Sub btn_Import_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Import.ItemClick
        '  out
        If xuc_MC_Reprice.Customer_Name.EditValue = String.Empty Then
            MsgBox("Please select Customer Name!", vbCritical, "DEPO TO REPO")
            Return
        ElseIf xuc_MC_Reprice.Classification.EditValue = String.Empty Then
            MsgBox("Please select Classification!", vbCritical, "DEPO TO REPO")
            Return
        Else
            Inventory_ItemAdd()
        End If
    End Sub

    Sub Inventory_ItemAdd()
        Dim dr As DataRow = dt.NewRow

        dr(0) = xuc_MC_Reprice.ModelCode
        dr(1) = xuc_MC_Reprice.Model.EditValue
        dr(2) = xuc_MC_Reprice.Description.EditValue
        dr(3) = xuc_MC_Reprice.Color.EditValue
        dr(4) = xuc_MC_Reprice.Brand.EditValue
        dr(5) = xuc_MC_Reprice.Engine_Number.EditValue
        dr(6) = xuc_MC_Reprice.Chassis_Number.EditValue
        dr(7) = xuc_MC_Reprice.KeyNo
        dr(8) = xuc_MC_Reprice.Restoration_Cost.EditValue
        dr(9) = "0.00"
        dr(10) = "0.00"
        dr(11) = "0.00"
        dr(12) = xuc_MC_Reprice.Customer_Name.EditValue
        dr(13) = xuc_MC_Reprice.BranchCode
        dr(14) = xuc_MC_Reprice.Account_Number.EditValue
        dr(15) = xuc_MC_Reprice.Ledgerset
        dr(16) = xuc_MC_Reprice.Classification.EditValue
        dr(17) = xuc_MC_Reprice.Principal.EditValue
        dr(18) = xuc_MC_Reprice.Interest.EditValue
        dr(19) = xuc_MC_Reprice.Outstanding_Balance.EditValue
        dr(20) = xuc_MC_Reprice.DP_Equity.EditValue
        dr(21) = xuc_MC_Reprice.MA.EditValue
        dr(22) = xuc_MC_Reprice.PrevID

        dt.Rows.Add(dr)
        GridList.DataSource = dt

        If MsgBox("Item added to table. " & vbCrLf & "Do you want to create another? ", vbYesNo, "SagaSoft") = MsgBoxResult.No Then
            'MC_For_Reprice.DockPanel1.Visible = False
            Return
        End If
    End Sub

    Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            If (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            Dim view As gridView = CType(sender, gridView)
            view.DeleteRow(view.FocusedRowHandle)
        End If
    End Sub

    Private Sub Branch_EditValueChanged(sender As Object, e As EventArgs) Handles Branch.EditValueChanged
        xuc_MC_Reprice.sBranchCode = Branch.EditValue.ToString()
        Toogle_Days_EditValueChanged(sender, e)
    End Sub

    Private Sub Toogle_Days_EditValueChanged(sender As Object, e As EventArgs) Handles Toogle_Days.EditValueChanged
        xuc_MC_Reprice.Load_Deposited(Convert.ToBoolean(Toogle_Days.EditValue))
    End Sub

End Class