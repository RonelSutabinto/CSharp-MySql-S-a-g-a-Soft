Imports BranchAccounting.Modules
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Forms
    Public Class frm_Cashiering
        Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)

            Dim repositoryBranch = New RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Branch(repositoryBranch)
            colBranch_Code.ColumnEdit = repositoryBranch
            colIBP_Branch_Code.ColumnEdit = repositoryBranch
        End Sub

        Friend bLoopStop As Boolean

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            bLoopStop = True
            class_Saga_Database.bLoopStop = True

            class_Tools.RegKeySet(Me.Name, BarEditItem_Corporation.Name, BarEditItem_Corporation.EditValue.ToString)

            Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            BarEditItem_Corporation.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Corporation.Name, "SMC")

            btn_Journal.Enabled = class_Saga_Variables.isCashier
        End Sub

        Private Sub frm_Cashiering_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Load_Data()
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If gridView.SelectedRowsCount > 0 Then
                Select Case e.KeyCode
                    Case Keys.F2

                    Case Keys.F6
                        Module_Forms.Show_Journal_Entries(gridView.GetFocusedRowCellDisplayText(colOR_Code))

                End Select
            End If
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                    New SqlParameter("@Search", sSearch),
                    New SqlParameter("@Action_Type", "LOAD_SEARCH")
                }
                class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Cashiering_Procedures", "TransactionOtherCash")
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

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso e.Clicks.Equals(2) Then
                class_Procedures.Copy_Clipboard(e.CellValue.ToString)
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Load_Data()
        End Sub

        Private Sub Load_Data()
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Corporation", BarEditItem_Corporation.EditValue.ToString),
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Action_Type", "LOAD")
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Cashiering_Procedures", "Cashiering Transaction", True)
        End Sub

        Private Sub btn_Stop_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
            class_Saga_Database.bLoopStop = True
        End Sub

        Private Sub btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            class_Database.DBError = False
            Execute_Cashiering_Journal(True)
        End Sub

        Friend Sub Execute_Cashiering_Journal(ByVal bConfirm As Boolean)
            With gridView
                If .DataRowCount > 0 Then
                    If Not class_Procedures.actionAsk("Execute Journal Entries", "Execute Journal Entries [Payments]") Then Return

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Cashiering Journal", "executed", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        class_Saga_Database.Journal_Entry_Save("CASHIERING", Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), .GetRowCellValue(iRowHandle, colPosting_Date))
                    Next

                    Show_Journal_Entries()
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Journal Entry [Payments]{Environment.NewLine}Between Date Range were successfully executed.")
                End If
            End With
        End Sub

        Private Sub Show_Journal_Entries()
            Module_Forms.Show_Journal_Entries(gridView.GetFocusedRowCellDisplayText(colOR_Code))
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            If gridView.SelectedRowsCount > 0 Then
                Show_Journal_Entries()
            End If
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .DataRowCount > 0 Then

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Cashiering Journal verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), "CASHIERING") Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Cashiering Transaction [Verification]:{Environment.NewLine}{ .GetRowCellDisplayText(iRowHandle, colReference)}{Environment.NewLine}was successfully verified.")
                        End If
                    Next

                    Show_Journal_Entries()
                    btn_Reload_ItemClick(sender, e)
                End If
            End With
        End Sub

    End Class

End Namespace