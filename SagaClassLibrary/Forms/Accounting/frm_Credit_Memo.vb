Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPrinting
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_Credit_Memo
        Inherits DevExpress.XtraEditors.XtraForm

        Dim bLoopStop As Boolean
        Friend dtPosting As Date
        Friend iTableID As Integer

        Public Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)

            colBranchCode.ColumnEdit = RepositoryItemLookUpEdit_Branch
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Releases_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            BarEditItem_Reason.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Reason.Name, String.Empty)

            Bar_Custom.Visible = class_Saga_Variables.isAccounting
            BarEditItem_Posting_Date.Enabled = class_Saga_Variables.isAccounting
            BarEditItem_Reason.Enabled = class_Saga_Variables.isAccounting

            btn_Delete.Enabled = class_Saga_Variables.isAccounting
            btn_Journal.Enabled = class_Saga_Variables.isAccounting Or class_Saga_Variables.isCashier

            Dim repositoryLookUpEdit_Corporation As New RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Corporation(repositoryLookUpEdit_Corporation)
            colCORP.ColumnEdit = repositoryLookUpEdit_Corporation
        End Sub

        Private Sub frm_Releases_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load(Convert.ToInt32(gridView.GetFocusedRowCellValue("ID")))
            End If
        End Sub

        Private Function Form_Close() As Boolean
            bLoopStop = True
            Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Releases_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            Form_Close()
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick

        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                    New SqlParameter("@Search", sSearch),
                    New SqlParameter("@Action_Type", "LOAD_SEARCH")
                }

                class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Credit_Memo_Procedures", "Credit Memo", True)
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Try
                    Load_Search((CType(sender, BaseEdit)).Text.Trim)
                Catch ex As Exception

                End Try
            End If
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

                    Case "colModel"
                        class_Saga_Procedures.Show_Unit_Model(e.CellValue.ToString)

                    Case "colEngineNo"
                        class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                    Case "colChassisNo"
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
                        Try
                            If class_Variables.isAdministrator AndAlso class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM TransactionCM WHERE ID LIKE '{gridView.GetFocusedRowCellValue(colID)}'", "Delete Credit Memo") Then
                                gridView.DeleteSelectedRows()
                            End If
                        Catch ex As Exception

                        End Try

                End Select
            End If
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            class_Database.DBError = False
            Data_Load(Convert.ToInt32(gridView.GetFocusedRowCellValue("ID")))
        End Sub

        Friend Sub Data_Load(Optional ByVal iTableID As Integer = 0, Optional ByVal sEngine As String = "")
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Action_Type", "LOAD")
            }

            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Credit_Memo_Procedures", "Credit Memo", True)

            If iTableID > 0 Then
                gridView.ClearSelection()
                For i As Integer = 0 To gridView.DataRowCount - 1
                    If Convert.ToInt32(gridView.GetRowCellValue(i, colID)).Equals(iTableID) Or gridView.GetRowCellDisplayText(i, colEngineNo).Equals(sEngine) Then
                        gridView.SelectRow(i)
                        gridView.MakeRowVisible(i)
                        Exit For
                    End If
                Next
            Else
                gridView.MoveLastVisible()
            End If
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Delete.ItemClick
            If class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM TransactionCM WHERE ID LIKE '{gridView.GetFocusedRowCellValue(colID)}'", "Delete Credit Memo") Then
                gridView.DeleteSelectedRows()
            End If
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
            class_Saga_Variables.bLoopStop = True
        End Sub

        Private Sub BarToggleSwitchItem_Custom_Posting_Date_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles BarToggleSwitchItem_Custom_Posting_Date.CheckedChanged
            BarEditItem_Posting_Date.Enabled = BarToggleSwitchItem_Custom_Posting_Date.Checked
            BarEditItem_Reason.Enabled = BarToggleSwitchItem_Custom_Posting_Date.Checked
        End Sub

        Private Sub btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            With gridView
                If .DataRowCount > 0 Then
                    class_Database.DBError = False
                    If BarToggleSwitchItem_Custom_Posting_Date.Checked Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, "You are about to execute selected Credit Memo into Journal Entries with Custom Posting Date.", "Custom Posting Date", True)
                        If Not class_Procedures.actionAsk("Custom Posting Date", "Execute selected Credit Memo into Journal Entries with Custom Posting Date", "You might execute with wrong Custom Posting Date") Then Return
                    Else
                        If Not class_Procedures.actionAsk("Credit Memo", "Execute Credit Memo into Journal Entries") Then Return
                    End If

                    class_Procedures.splash_Show("Executing Journal Entries")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Credit Memo", "executed", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn,, "Note") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If BarToggleSwitchItem_Custom_Posting_Date.Checked Then
                            class_Saga_Database.Journal_Entry_Save("CM", Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), BarEditItem_Posting_Date.EditValue.ToString, True, BarEditItem_Reason.EditValue.ToString.Trim())
                        Else
                            class_Saga_Database.Journal_Entry_Save("CM", Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), .GetRowCellValue(iRowHandle, colPostingDate))
                        End If
                    Next

                    class_Saga_Procedures.Show_Journal_Entries_Reference(.GetFocusedRowCellDisplayText(colEngineNo), Convert.ToInt32(.GetFocusedRowCellValue(colID)))

                    class_Procedures.splash_Close()
                End If
            End With
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colEngineNo), Convert.ToInt32(gridView.GetFocusedRowCellValue(colID)), $"{gridView.GetFocusedRowCellDisplayText(colAccountNumber)}-{gridView.GetFocusedRowCellDisplayText(colLedgerSetNumber)}", gridView.GetFocusedRowCellDisplayText(colAccountName), gridView.GetFocusedRowCellDisplayText(colNote))
        End Sub

        Private Sub btn_Journal_Entries2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries2.ItemClick
            class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.CIF, $"{gridView.GetFocusedRowCellDisplayText(colAccountNumber)}-{gridView.GetFocusedRowCellDisplayText(colLedgerSetNumber)}", gridView.GetFocusedRowCellDisplayText(colAccountName), gridView.GetFocusedRowCellDisplayText(colEngineNo))
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Credit Memo Verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), "CM")
                    Next

                    class_Saga_Procedures.Show_Journal_Entries_Reference(.GetRowCellDisplayText(iRowHandle, colEngineNo), Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)))
                End If
            End With
        End Sub
    End Class

End Namespace