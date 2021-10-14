Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPrinting
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_Reposssesed
        Inherits DevExpress.XtraEditors.XtraForm

        Dim bLoopStop As Boolean

        Public Sub New()
            If Me.xuc_Account_Ledger Is Nothing Then
                Me.xuc_Account_Ledger = New Controls.Information.Account.xuc_Account_Ledger()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Account_Ledger.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)

            BarEditItem_Posting_Date.Enabled = False
            BarEditItem_Reason.Enabled = False
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Releases_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            BarEditItem_Reason.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Reason.Name, String.Empty)

            class_Saga_Procedures.Initialize_Corporation(RepositoryItemLookUpEdit_Corporation)

            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit_Branch)
            class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit_Branch)

            colBranchCode.ColumnEdit = RepositoryItemLookUpEdit_Branch

            btn_Save.Enabled = class_Saga_Variables.isAccounting
            btn_Delete.Enabled = class_Saga_Variables.isAccounting
        End Sub

        Private Sub frm_Releases_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
            If Me.xuc_Settings.Toggle_Auto_Initialize.IsOn Then Me.xuc_Account_Ledger.Control_Initialize()

            If Me.xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Function Form_Close() As Boolean
            bLoopStop = True
            class_Tools.RegKeySet(Me.Name, BarEditItem_Reason.Name, BarEditItem_Reason.EditValue.ToString)
            Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Releases_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Form_Close()
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Account_Ledger.Control_Initialize()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Friend Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.DataRowCount > 0) AndAlso e.Clicks.Equals(2) Then
                Select Case e.Column.Name
                    Case "colAccountNumber"
                        class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, e.CellValue.ToString, Convert.ToInt32(gridView.GetFocusedRowCellValue(colLedgerSetNumber)))

                    Case "colEngineNo"
                        class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                    Case "colTransactedBy"
                        class_Saga_Procedures.Show_User_Activity(e.CellValue.ToString)

                    Case Else
                        If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                End Select
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If (gridView.DataRowCount > 0) Then
                Select Case e.KeyValue
                    Case Keys.Delete
                        If class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM CustLedger WHERE ID LIKE '{gridView.GetFocusedRowCellValue(colLedgerSetNumber)}'", "Delete Ledger", True, gridView.GetFocusedRowCellDisplayText(colTransactedBy)) Then
                            gridView.DeleteSelectedRows()
                        End If
                End Select
            End If
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub Data_Load()
            If barEditItem_Branch.EditValue.ToString.Equals("000") Then
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM view_Ledgers WHERE LedgerType LIKE 'PRIN' AND TransCode LIKE 'CHSTS' AND TransactionDate >= '{class_Saga_Variables.dtStart}' AND TransactionDate <= '{class_Saga_Variables.dtEnd}'", "view_Ledgers")
            Else
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM view_Ledgers WHERE LedgerType LIKE 'PRIN' AND TransCode LIKE 'CHSTS' AND TransactionDate >= '{class_Saga_Variables.dtStart}' AND TransactionDate <= '{class_Saga_Variables.dtEnd}' AND BranchCode LIKE '{barEditItem_Branch.EditValue}'", "view_Ledgers")
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If gridView.DataRowCount > 0 Then
                If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
            End If
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Account_Ledger
                    .SequenceNumber.Text = gridView.GetFocusedRowCellDisplayText(colSequenceNumber)
                    .TransCode.Text = gridView.GetFocusedRowCellDisplayText(colTransCode)
                    .Mnemonic.Text = gridView.GetFocusedRowCellDisplayText(colMnemonic)
                    .ReferenceNumber.Text = gridView.GetFocusedRowCellDisplayText(colReferenceNumber)
                    .ORNumber.Text = gridView.GetFocusedRowCellDisplayText(colORNumber)
                    .BeginningBalance.Value = convert.todecimal(gridView.GetFocusedRowCellValue(colBeginningBalance))
                    .Debit.Value = convert.todecimal(gridView.GetFocusedRowCellValue(colDebit))
                    .Credit.Value = convert.todecimal(gridView.GetFocusedRowCellValue(colCredit))
                    .EndingBalance.Value = convert.todecimal(gridView.GetFocusedRowCellValue(colEndingBalance))
                    .OutsBal.Value = convert.todecimal(gridView.GetFocusedRowCellValue(colOutsBal))
                    .TransactionDate.EditValue = gridView.GetFocusedRowCellValue(colPostingDate)
                    .TransactedBy.EditValue = gridView.GetFocusedRowCellValue(colTransactedBy)
                    .Remarks.Text = gridView.GetFocusedRowCellDisplayText(colRemarks)
                    .Note.Text = gridView.GetFocusedRowCellDisplayText(colNote)
                End With
            End If
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick

        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Delete.ItemClick
            If class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM TransactionCM WHERE ID LIKE '{gridView.GetFocusedRowCellValue(colSequenceNumber)}'", "Delete Repossessed") Then
                gridView.DeleteSelectedRows()
            End If
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
            class_Saga_Variables.bLoopStop = True
        End Sub

        Private Sub btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            class_Database.DBError = False
            With gridView
                If .DataRowCount > 0 Then
                    If BarToggleSwitchItem_Custom_Posting_Date.Checked Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, "You are about to execute selected Repossessed into Journal Entries with Custom Posting Date.", "Custom Posting Date", True)
                        If Not class_Procedures.actionAsk("Custom Posting Date", "Execute selected Repossessed into Journal Entries with Custom Posting Date", "You might execute with wrong Custom Posting Date") Then Return
                    Else
                        If Not class_Procedures.actionAsk("Repossesed", "Execute Repossessed into Journal Entries") Then Return
                    End If

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    If xuc_Settings.Toggle_Select.IsOn Then .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Repossesed Units", "executed", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn,, "Note") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        'Dim sAccountName As String = .GetRowCellDisplayText(iRowHandle, colAccountName)
                        'Dim sAccountNumber As String = $"{ .GetRowCellDisplayText(iRowHandle, colAccountNumber)}-{ .GetRowCellDisplayText(iRowHandle, colLedgerSetNumber)}"

                        If BarToggleSwitchItem_Custom_Posting_Date.Checked Then
                            class_Saga_Database.Journal_Entry_Save("DEPO_TO_REPO", .GetRowCellValue(iRowHandle, colSequenceNumber), BarEditItem_Posting_Date.EditValue, True, BarEditItem_Reason.EditValue)
                        Else
                            class_Saga_Database.Journal_Entry_Save("DEPO_TO_REPO", .GetRowCellValue(iRowHandle, colSequenceNumber), .GetRowCellValue(iRowHandle, colPostingDate))
                        End If

                        'class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Journal Entry [Depo to Repo]:{Environment.NewLine}{sAccountNumber}{Environment.NewLine}{sAccountName}{Environment.NewLine}was successfully executed.")
                    Next

                    class_Saga_Procedures.Show_Journal_Entries_Reference(.GetFocusedRowCellDisplayText(colEngineNo), .GetFocusedRowCellValue(colSequenceNumber))
                End If
            End With
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colEngineNo), gridView.GetFocusedRowCellValue(colSequenceNumber), $"{gridView.GetFocusedRowCellDisplayText(colAccountNumber)}-{gridView.GetFocusedRowCellDisplayText(colLedgerSetNumber)}", gridView.GetFocusedRowCellDisplayText(colAccountName), gridView.GetFocusedRowCellDisplayText(colRemarks))
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    class_Procedures.splash_Show($"updating IsJournal Transactions of the selected Collections")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()


                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Entry Verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, colSequenceNumber)), "DEPO_TO_REPO")
                    Next

                    class_Saga_Procedures.Show_Journal_Entries_Reference(.GetFocusedRowCellDisplayText(colEngineNo), .GetFocusedRowCellValue(colSequenceNumber))
                End If
            End With
        End Sub

        Private Sub BarToggleSwitchItem_Custom_Posting_Date_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles BarToggleSwitchItem_Custom_Posting_Date.CheckedChanged
            BarEditItem_Posting_Date.Enabled = BarToggleSwitchItem_Custom_Posting_Date.Checked
            BarEditItem_Reason.Enabled = BarToggleSwitchItem_Custom_Posting_Date.Checked
        End Sub

    End Class

End Namespace