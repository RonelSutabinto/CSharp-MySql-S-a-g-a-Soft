Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Accounting
    Public Class frm_Vouchers
        Public voucherType As eVoucherType

        Friend bLoopStop As Boolean

        Public Sub New()
            If Me.xuc_Voucher Is Nothing Then
                Me.xuc_Voucher = New Controls.Accounting.xuc_Voucher()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Voucher.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub frm_Journal_Entries_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            checkEdit_Unclosed_Advances.EditValue = class_Tools.RegKeyGet(Me.Name, checkEdit_Unclosed_Advances.Name, True)
            Check_Display_All_Checks.EditValue = class_Tools.RegKeyGet(Me.Name, Check_Display_All_Checks.Name, True)
            check_New_Data_Row.Checked = class_Tools.RegKeyGet(Me.Name, check_New_Data_Row.Name, False)
            check_Save_Journal_Entries.Checked = class_Tools.RegKeyGet(Me.Name, check_Save_Journal_Entries.Name, False)

            check_Auto_Expire.Checked = class_Tools.RegKeyGet(Me.Name, check_Auto_Expire.Name, True)
            Days_Expiry.Value = class_Tools.RegKeyGet(Me.Name, Days_Expiry.Name, 30)
            Me.xuc_Voucher.iExpiryDays = Convert.ToInt32(Days_Expiry.EditValue)
            Me.xuc_Voucher.Liquidation_Days.Value = Convert.ToInt32(Days_Expiry.EditValue)

            check_Generate_Cash_Advances.Checked = class_Tools.RegKeyGet(Me.Name, check_Generate_Cash_Advances.Name, True)

            xuc_Voucher.xuc_Account_Search.gridView.RestoreLayoutFromRegistry(xuc_Voucher.xuc_Account_Search.Name)
            Me.xuc_Journal_Entries.gridView.RestoreLayoutFromRegistry(xuc_Journal_Entries.Name)

            DockPanel3.Visible = False

            btn_Close_Voucher.Enabled = class_Saga_Variables.isAccounting
            btn_Delete.Enabled = class_Saga_Variables.isAccounting
            btn_Lock_Unlock.Enabled = class_Saga_Variables.isAccounting
            btn_Cancel.Enabled = class_Saga_Variables.isAccounting
        End Sub

        Private Sub frm_Vouchers_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            class_Saga_Procedures.Initialize_Corporation(RepositoryItemLookUpEdit_Corporation)
            class_Saga_Procedures.Initialize_Branch(xuc_Voucher.Voucher_Branch)
            class_Saga_Procedures.Initialize_Branch(repositoryItemLookUpEdit_Branch)
            class_Saga_Procedures.Initialize_COA(xuc_Voucher.COA_Code, eCOA_Type.COA_Bank)
            class_Saga_Procedures.Initialize_COA(RepositoryItemLookUpEdit_COA, eCOA_Type.COA_Bank)

            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then
                xuc_Voucher.Control_Initialize()
            End If

            If checkEdit_Unclosed_Advances.Checked AndAlso XtraMessageBox.Show($"There are {class_Saga_Database.get_Unliquidated} pending, unclosed or unsettled voucher(s)/expense(s).{Environment.NewLine}Please verify and close the transactions.{Environment.NewLine}{Environment.NewLine}Do you want to load these transactions?", "Unclosed/Unsettled Voucher(s)/Expense(s)", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Data_Load("UNLIQUIDATED")
            ElseIf xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load("ALL")
            End If
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            bLoopStop = True

            class_Tools.RegKeySet(Me.Name, checkEdit_Unclosed_Advances.Name, checkEdit_Unclosed_Advances.Checked)
            class_Tools.RegKeySet(Me.Name, Check_Display_All_Checks.Name, Check_Display_All_Checks.Checked)
            class_Tools.RegKeySet(Me.Name, check_New_Data_Row.Name, check_New_Data_Row.Checked)
            class_Tools.RegKeySet(Me.Name, check_Save_Journal_Entries.Name, check_Save_Journal_Entries.Checked)

            class_Tools.RegKeySet(Me.Name, check_Auto_Expire.Name, check_Auto_Expire.Checked)
            class_Tools.RegKeySet(Me.Name, Days_Expiry.Name, Convert.ToInt32(Days_Expiry.Value))

            class_Tools.RegKeySet(Me.Name, check_Generate_Cash_Advances.Name, check_Generate_Cash_Advances.Checked)

            xuc_Voucher.xuc_Account_Search.gridView.SaveLayoutToRegistry(xuc_Voucher.xuc_Account_Search.Name)
            Me.xuc_Journal_Entries.gridView.SaveLayoutToRegistry(xuc_Journal_Entries.Name)

            Return class_Procedures.Form_Close(Me, barManager, DockManager, gridView, xuc_Voucher.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Journal_Entries_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            class_Saga_Procedures.Initialize_Branch(repositoryItemLookUpEdit_Branch)
            xuc_Voucher.Control_Initialize()
        End Sub

        Private Sub btn_Pending_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Pending.ItemClick

        End Sub

        Private Sub gridView_AsyncCompleted(sender As Object, e As EventArgs) Handles gridView.AsyncCompleted
            gridView.BestFitColumns()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick

            Data_Load("ALL")
        End Sub

        Private Sub btn_Cash_Advances_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Cash_Advances.ItemClick
            Data_Load("ADVANCES")
        End Sub

        Private Sub btn_Reload_Liquidated_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Liquidated.ItemClick
            Data_Load("LIQUIDATED")
        End Sub

        Private Sub btn_Reload_UnLiquidated_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_UnLiquidated.ItemClick
            Data_Load("UNLIQUIDATED")
        End Sub

        Public Sub Data_Load(ByVal sLoadType As String)
            Dim sqlParameters As SqlParameter()

            Select Case sLoadType
                Case "ALL"
                    If xuc_Settings.Toggle_Load_All.IsOn Then
                        sLoadType = "LOAD_ALL"
                    Else
                        sLoadType = "LOAD_RANGE"
                    End If

                    sqlParameters = {
                        New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                        New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                        New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                        New SqlParameter("@Action_Type", sLoadType)
                    }

                    class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Voucher_Procedures", "Cash/Check Vouchers")

                Case "ADVANCES"
                    sqlParameters = {New SqlParameter("@Action_Type", "LOAD_ADVANCES")}
                    class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Voucher_Procedures", "Cash/Check Vouchers - Cash Advances")

                Case "LIQUIDATED"
                    sqlParameters = {New SqlParameter("@Action_Type", "LOAD_LIQUIDATED")}
                    class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Voucher_Procedures", "Cash/Check Vouchers - Cash Advances [Liquidated]")

                Case "UNLIQUIDATED"
                    sqlParameters = {New SqlParameter("@Action_Type", "LOAD_UNLIQUIDATED")}
                    class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Voucher_Procedures", "Cash/Check Vouchers - Cash Advances [Un-Liquidated]")
            End Select
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Search", sSearch),
                    New SqlParameter("@Action_Type", "SEARCH")
                }

                class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Voucher_Procedures", "Voucher Information Search")
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Try
                    Load_Search((CType(sender, BaseEdit)).Text.Trim)
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            If gridView.RowCount > 0 Then gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            If check_New_Wizard.Checked Then
                Dim wf = New wzf_Voucher
                wf.Show()
                wf.xuc_Voucher.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn, voucherType)
            Else
                xuc_Voucher.Control_New(check_New_Data_Row.Checked)

                If check_New_Data_Row.Checked AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then
                    Data_Load("ALL")
                End If
            End If
        End Sub

        Private Sub btn_New_Wizard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New_Wizard.ItemClick
            Dim wzform As New Forms.Accounting.wzFrm_Cash_Check_Voucher()

            With wzform
                .Show()
            End With
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            'Do not auto reload to avoid data loss upon saving Voucher
            If xuc_Voucher.control_Save(voucherType) Then
                If check_Save_Journal_Entries.Checked Then
                    Show_Journal_Entries(Convert.ToBoolean(xuc_Voucher.IsForLiquidation.EditValue), Convert.ToBoolean(xuc_Voucher.IsLTO.EditValue))

                ElseIf xuc_Settings.Toggle_Auto_Reload.IsOn Then
                    xuc_Settings.Toggle_Select.IsOn = False
                    btn_Reload_ItemClick(sender, e)
                End If
            End If
        End Sub

        Private Sub Show_Journal_Entries(ByVal bForLiquidation As Boolean, ByVal bLTO As Boolean)
            With xuc_Voucher
                Dim iTableID As Integer = .ID.EditValue
                Dim sReference As String = .Voucher_Reference.EditValue.ToString.Trim
                Dim sBrCode As String = .Voucher_Branch.EditValue
                Dim sProfile As String = .Voucher_Profile.EditValue.ToString.Trim
                Dim sAccountCode As String = .Account_Code.EditValue
                Dim sAccountName As String = .Account_Name.EditValue.ToString.Trim
                Dim dtPosted As Date = .Voucher_Date_Posted.EditValue
                Dim sApprover As String = .Voucher_Approver.EditValue.ToString.Trim
                Dim sDescription As String = .Voucher_Description.EditValue.ToString.Trim

                Dim sCOACode As String = String.Empty
                Try
                    sCOACode = .COA_Code.EditValue
                Catch ex As Exception

                End Try

                Dim sCheck As String = String.Empty
                Try
                    sCheck = .Voucher_Check.EditValue.ToString.Trim()
                Catch ex As Exception

                End Try

                class_Saga_Procedures.Show_Journal_Entries_Reference(0, iTableID, sReference, sBrCode, "CASH_CHECK", sProfile, sAccountCode, sAccountName, dtPosted, sApprover, sCOACode, sCheck, sDescription, bForLiquidation, bLTO)
            End With
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            Show_Journal_Entries(Convert.ToBoolean(xuc_Voucher.IsForLiquidation.EditValue), Convert.ToBoolean(xuc_Voucher.IsLTO.EditValue))
        End Sub

        Private Sub btn_COA_Ledger_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_COA_Ledger.ItemClick
            class_Saga_Procedures.Show_COA_Ledger(gridView.GetFocusedRowCellDisplayText(colCOA_Code))

        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            If xuc_Voucher.Control_Delete Then gridView.DeleteRow(gridView.FocusedRowHandle)
        End Sub

        Private Sub btn_Cancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Cancel.ItemClick
            If Not class_Procedures.actionAsk("Cancel Voucher", "Cancel Voucher and Delete Journal Entries", "Cancel the wrong Voucher and delete the wrong Journal Entries") Then Return

            class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM acc_Journal_Entries WHERE Journal_Reference LIKE '{xuc_Voucher.Voucher_Reference.Text}'")
            class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Vouchers SET Voucher_Debit = 0, Voucher_Credit = 0 WHERE Voucher_Reference LIKE '{xuc_Voucher.Voucher_Reference.Text}'")

            class_Procedures.Set_Message(class_Procedures.MsgMode.Delete, "Voucher has been cancelled", "Cancel Voucher")

            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("ALL")
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Voucher
                    .Voucher_Check.EditValue = Nothing
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                    .Corporation.EditValue = gridView.GetFocusedRowCellValue(colCorporation)
                    .sVoucherCodeOld = gridView.GetFocusedRowCellDisplayText(colVoucher_Code)
                    .Voucher_Code.Text = gridView.GetFocusedRowCellDisplayText(colVoucher_Code)
                    .Voucher_Reference.Text = gridView.GetFocusedRowCellDisplayText(colVoucher_Reference)
                    .Voucher_Branch.Text = gridView.GetFocusedRowCellDisplayText(colVoucher_Branch)
                    .Voucher_Profile.Text = gridView.GetFocusedRowCellDisplayText(colVoucher_Profile)
                    .Journal_Reference.EditValue = gridView.GetFocusedRowCellDisplayText(colJournal_Reference)
                    .Account_Code.Text = gridView.GetFocusedRowCellDisplayText(colAccount_Code)
                    .Account_Name.Text = gridView.GetFocusedRowCellDisplayText(colAccount_Name)
                    .Voucher_Approver.Text = gridView.GetFocusedRowCellDisplayText(colVoucher_Approver)
                    .Voucher_Date_Posted.EditValue = Convert.ToDateTime(gridView.GetFocusedRowCellValue(colVoucher_Date_Posted))
                    .Voucher_Description.Text = gridView.GetFocusedRowCellDisplayText(colVoucher_Description)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)

                    Try
                        .Voucher_Debit.Value = Convert.ToDecimal(gridView.GetFocusedRowCellValue(colVoucher_Debit))
                    Catch ex As Exception
                        .Voucher_Debit.Value = 0
                    End Try

                    Try
                        .Voucher_Credit.Value = Convert.ToDecimal(gridView.GetFocusedRowCellValue(colVoucher_Credit))
                    Catch ex As Exception
                        .Voucher_Credit.Value = 0
                    End Try

                    Try
                        .COA_Code.EditValue = gridView.GetFocusedRowCellValue(colCOA_Code)
                        .Set_Check_Token(gridView.GetFocusedRowCellDisplayText(colVoucher_Check))
                    Catch ex As Exception
                        .COA_Code.EditValue = Nothing
                    End Try

                    .IsForLiquidation.EditValue = False
                    .IsLiquidated.EditValue = False

                    If Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsForLiquidation)) Then
                        .IsForLiquidation.EditValue = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsForLiquidation))
                        .IsLTO.EditValue = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsLTO))
                        .Expense_Type.EditValue = gridView.GetFocusedRowCellDisplayText(colExpense_Type)
                        .Liquidation_Days.Value = Convert.ToInt32(gridView.GetFocusedRowCellValue(colLiquidation_Days))
                        .Liquidation_Date_Return.EditValue = Convert.ToDateTime(gridView.GetFocusedRowCellValue(colLiquidation_Date_Return))
                        .Liquidation_Date_Expiry.EditValue = Convert.ToDateTime(gridView.GetFocusedRowCellValue(colLiquidation_Date_Expiry))

                        If gridView.GetFocusedRowCellValue(colIsLiquidated) IsNot Nothing Then
                            .IsLiquidated.EditValue = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsLiquidated))
                            .Journal_Reference.EditValue = gridView.GetFocusedRowCellValue(colJournal_Reference)

                            Try
                                .Liquidation_Date.EditValue = Convert.ToDateTime(gridView.GetFocusedRowCellValue(colLiquidation_Date))
                            Catch ex As Exception
                                .Liquidation_Date.EditValue = Nothing
                            End Try
                        End If
                    Else
                        .Expense_Type.EditValue = Nothing
                        .Liquidation_Days.Value = 0
                        .Liquidation_Date_Expiry.EditValue = Nothing
                        .Liquidation_Date.EditValue = Nothing
                    End If

                    Try
                        .IsBudget.EditValue = Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsBudget))
                        .Budget_Code.Text = gridView.GetFocusedRowCellDisplayText(colBudget_Name)
                        .dAmount = Convert.ToDecimal(gridView.GetFocusedRowCellValue(colVoucher_Credit))
                    Catch ex As Exception
                        .IsBudget.EditValue = False
                        .Budget_Code.EditValue = Nothing
                    End Try
                End With
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If gridView.DataRowCount > 0 AndAlso xuc_Settings.Toggle_Select.IsOn Then
                Data_Show()
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            With gridView
                If .DataRowCount > 0 And .SelectedRowsCount > 0 Then
                    Select Case e.KeyValue
                        Case Keys.Enter
                            Select Case .FocusedColumn.Name
                                Case "colVoucher_Reference"
                                    If xuc_Settings.Toggle_Select.IsOn Then
                                        Show_Journal_Entries(Convert.ToBoolean(xuc_Voucher.IsForLiquidation.EditValue), Convert.ToBoolean(xuc_Voucher.IsLTO.EditValue))
                                    End If

                                Case Else
                                    Data_Show()

                            End Select

                        Case Keys.F2
                            Me.xuc_Voucher.Select()

                        Case Keys.Delete
                            class_Database.DBError = False
                            If Not class_Procedures.actionAsk("Delete Voucher and Jounal Entries", "Delete Check Vouchers and its Journal Entries", "You may delete wrong Check Vouchers and Journal Entries") Then Return

                            Dim iRowHandle, iRowHandleOld As Integer
                            Dim selectedRows As Integer() = .GetSelectedRows()

                            For i As Integer = 0 To selectedRows.Length - 1
                                iRowHandle = selectedRows(i)

                                If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Delete Voucher", "deleted", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn, True) Then
                                    iRowHandleOld = iRowHandle
                                Else Return
                                End If

                                class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM acc_Journal_Entries WHERE Journal_Reference LIKE '{ .GetRowCellDisplayText(iRowHandle, colVoucher_Reference)}'", True, "Added_By")
                                class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM acc_Vouchers WHERE Voucher_Reference LIKE '{ .GetRowCellDisplayText(iRowHandle, colVoucher_Reference)}'")
                            Next
                    End Select
                End If
            End With
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Data_Show()
                Select Case e.Column.Name
                    Case "colID", "colVoucher_Code"
                        If check_New_Wizard.Checked Then
                            Dim iIDTable As Integer = Convert.ToInt32(gridView.GetFocusedRowCellValue(colID))
                            Dim sReference As String = gridView.GetFocusedRowCellDisplayText(colVoucher_Reference)
                            Dim sCode As String = gridView.GetFocusedRowCellDisplayText(colAccount_Code)
                            Dim sName As String = gridView.GetFocusedRowCellDisplayText(colAccount_Name)
                            Dim sCheck As String = gridView.GetFocusedRowCellDisplayText(colNotes)
                            Dim sType As String = gridView.GetFocusedRowCellDisplayText(colExpense_Type)
                            Dim sProfile As String = gridView.GetFocusedRowCellDisplayText(colVoucher_Profile)
                            Dim sDescription As String = gridView.GetFocusedRowCellDisplayText(colVoucher_Description)
                            Dim dtPostingDate As Date = Convert.ToDateTime(gridView.GetFocusedRowCellValue(colVoucher_Date_Posted))

                            Dim wzf As wzf_Voucher = New wzf_Voucher() With {
                                .Text = $"Voucher and Journal Entries: Reference:{sReference} Account-{sName}",
                                .sReference = sReference,
                                .sCode = sCode,
                                .sName = sName,
                                .sCheck = sCheck
                            }
                            wzf.Show()
                            wzf.xuc_Voucher.Control_Retrieve(gridView.GetFocusedRowCellDisplayText(colVoucher_Reference))

                            With wzf.xuc_Journal_Entries
                                .IDTable = iIDTable
                                .Reference = sReference
                                .AccountCode = sCode
                                .AccountName = sName
                                .sCheck = sCheck
                                .sBrCode = sBranchCode
                                .JournalType = sType
                                .JournalProfile = sProfile
                                .sDescription = sDescription
                                .PostingDate = dtPostingDate

                                .Data_Load(sReference)
                            End With

                            class_Procedures.splash_Close()
                        Else
                            class_Saga_Procedures.Show_Voucher(gridView.GetFocusedRowCellDisplayText(colVoucher_Code))
                        End If

                    Case "colVoucher_Check"
                        class_Saga_Procedures.Show_Check(e.CellValue.ToString)

                    Case "colVoucher_Reference"
                        If xuc_Settings.Toggle_Select.IsOn Then
                            Show_Journal_Entries(Convert.ToBoolean(xuc_Voucher.IsForLiquidation.EditValue), Convert.ToBoolean(xuc_Voucher.IsLTO.EditValue))
                        End If

                    Case "colJournal_Reference"
                        class_Saga_Procedures.Show_Journal_Entries_Reference(e.CellValue.ToString, gridView.GetFocusedRowCellValue(colID))

                    Case "colAccount_Code"
                        If e.CellValue.ToString.Contains("NAME") Then
                            class_Saga_Procedures.Show_Account_Name(e.CellValue.ToString)

                        ElseIf e.CellValue.ToString.Contains("EMPL") Then
                            'class_Saga_Procedures.Show_Employee(e.CellValue.ToString)
                        Else
                            class_Saga_Procedures.Show_Customer(e.CellValue.ToString)
                        End If
                    Case "colAccount_Name"
                        class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, class_Saga_Database.get_COA_Code(e.CellValue.ToString), gridView.GetFocusedRowCellDisplayText(colAccount_Name))

                    Case Else
                        Data_Show()
                        If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
            class_Saga_Variables.bLoopStop = True
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            With gridView
                If .DataRowCount > 0 Then
                    If Not class_Procedures.actionAsk("Update Cash/Check Voucher(s)", "Update Cash/Check Voucher(s)") Then Return

                    class_Procedures.splash_Show("updating Cash/Check Voucher(s)")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()
                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Cash/Check Voucher(s)", "validated", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Try
                            Dim sqlParameters As SqlParameter() = {
                                New SqlParameter("@Voucher_Reference", .GetRowCellDisplayText(iRowHandle, colVoucher_Reference)),
                                New SqlParameter("@Action_Type", "UPDATE_LIQUIDATION")
                            }

                            class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Voucher_Procedures", "Update Cash/Check Vouchers")
                        Catch ex As Exception
                            Continue For
                        End Try
                    Next

                    xuc_Settings.Toggle_Live_Looping.IsOn = True
                    class_Procedures.splash_Close()
                End If
            End With
        End Sub

        Private Sub btn_Lock_Unlock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Lock_Unlock.ItemClick
            With gridView
                If .DataRowCount > 0 Then
                    If Not class_Procedures.actionAsk("Lock/Unlock Cash/Check Voucher(s)", "Lock/Unlock Cash/Check Voucher(s)") Then Return

                    class_Procedures.splash_Show("Locking/Unlocking Cash/Check Voucher(s)")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()


                    bLoopStop = False
                    .ClearSelection()
                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Check Vouchers", "locked/unlocked", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Try
                            Dim bLocked = Convert.ToBoolean(.GetRowCellValue(iRowHandle, colIsLocked))

                            Dim sqlParameters As SqlParameter() = {
                                New SqlParameter("@ID", Convert.ToInt32(.GetRowCellDisplayText(iRowHandle, colID))),
                                New SqlParameter("@IsLocked", Not bLocked),
                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                New SqlParameter("@Action_Type", "LOCK")
                            }

                            class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Voucher_Procedures", "Lock/Unlock Cash/Check Voucher(s)")
                        Catch ex As Exception
                            Continue For
                        End Try
                    Next

                    xuc_Settings.Toggle_Live_Looping.IsOn = True
                    class_Procedures.splash_Close()
                End If
            End With
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    class_Procedures.splash_Show($"Verifying IsJournal Transactions of the selected Cash/Check Vouchers")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Cash/Check Verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If .GetRowCellDisplayText(iRowHandle, colVoucher_Reference).Contains("VOUCHER") Then
                            class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), "CASH_CHECK")
                        ElseIf .GetRowCellDisplayText(iRowHandle, colVoucher_Reference).Contains("EXPENSE") Then
                            class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), "VOUCHER_EXPENSE")
                        End If
                    Next

                    If xuc_Settings.Toggle_Select.IsOn Then
                        Show_Journal_Entries(Convert.ToBoolean(xuc_Voucher.IsForLiquidation.EditValue), Convert.ToBoolean(xuc_Voucher.IsLTO.EditValue))
                    End If
                End If
            End With
        End Sub

        Private Sub Check_Display_All_Checks_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Display_All_Checks.CheckedChanged
            'Me.xuc_Voucher.bAllChecks(Check_Display_All_Checks.Checked)
        End Sub

        Private Sub Days_Expiry_EditValueChanged(sender As Object, e As EventArgs) Handles Days_Expiry.EditValueChanged
            Me.xuc_Voucher.iExpiryDays = Convert.ToInt32(Days_Expiry.Value)
        End Sub

        Private Sub check_Auto_Expire_CheckedChanged(sender As Object, e As EventArgs) Handles check_Auto_Expire.CheckedChanged
            Me.xuc_Voucher.bAutoExpire = check_Auto_Expire.Checked
        End Sub

        Private Sub btn_Close_Voucher_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close_Voucher.ItemClick
            'Me.xuc_Voucher.Control_Liquidation_Update()
        End Sub

        Private Sub Generate_Cash_Advances()
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Action_Type", "UPDATE_LIQUIDATIONS")
                    }
            class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Voucher_Procedures", "Cash Advances")
        End Sub

        Private Sub btn_Generate_Cash_Advances_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Generate_Cash_Advances.ItemClick
            Generate_Cash_Advances()
        End Sub

        Private Sub btn_Unliquidated_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unliquidated.ItemClick
            Liquidation_Report("UNLIQUIDATED CASH ADVANCES - ALL", False, True)
        End Sub

        Private Sub btn_UnLiquidated_Employee_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_UnLiquidated_Employee.ItemClick
            Liquidation_Report("UNLIQUIDATED CASH ADVANCES - EMPLOYEES", False)
        End Sub

        Private Sub btn_UnLiquidated_LTO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_UnLiquidated_LTO.ItemClick
            Liquidation_Report("UNLIQUIDATED CASH ADVANCES - LTO", True)
        End Sub

        Private Sub Liquidation_Report(ByVal sTitle As String, ByVal bLTO As Boolean, Optional ByVal bAll As Boolean = False)
            If check_Generate_Cash_Advances.Checked Then
                Generate_Cash_Advances()
            End If
            Dim xRpt As Reports.Accounting.xrpt_Liquidation = New Reports.Accounting.xrpt_Liquidation()
            Try
                With xRpt
                    .Landscape = True
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 1300
                    .PageHeight = 850

                    .Document_Title.Text = sTitle
                    .Document_Corporation.Text = class_Saga_Database.get_Corporation_Name(class_Saga_Variables.sCorporation)
                    .Corporation.Text = class_Saga_Database.get_Corporation_Name(class_Saga_Variables.sCorporation)

                    .Inquiry_Date.Text = class_Saga_Variables.dtStart.ToString("MMMM dd, yyyy")

                    Dim sActionType As String
                    If bAll Then
                        sActionType = "PREVIEW_UNLIQ_ALL"
                    Else
                        sActionType = "PREVIEW_UNLIQUIDATED"
                    End If

                    Dim sqlParameters As SqlParameter() = {
                        New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                        New SqlParameter("@IsLTO", bLTO),
                        New SqlParameter("@Action_Type", sActionType)
                    }
                    class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "acc_Voucher_Procedures", "acc_Vouchers")
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

    End Class

End Namespace