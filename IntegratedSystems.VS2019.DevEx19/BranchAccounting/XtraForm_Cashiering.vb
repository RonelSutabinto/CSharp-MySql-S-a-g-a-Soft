Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports BranchAccounting.Modules
Imports wSClassLib.myModules

Namespace Forms
    Public Class XtraForm_Cashiering

        Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            Modules.Initialize_Form(Me, GridView, BtnCancel)
            Modules.Initialize_BarManager(Me, BarManager)
        End Sub

        Friend bLoopStop As Boolean

        Private Sub XtraForm_Collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            colBranchCode.ColumnEdit = RepositoryItemLookUpEdit_Branch
        End Sub

        Private Sub XtraForm_Cashiering_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Modules.Initialize_Branch()
            Modules.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit_Branch)

            BarEditItem_Corporation.EditValue = Module_Tools.RegKeyGet(Me.Name, BarEditItem_Corporation.Name, "SMC")

            BarEditItem_Branch.EditValue = mBrCode
            BarEditItem_Branch.Enabled = False

            BarEditItem_Start.EditValue = CDate(Module_Tools.RegKeyGet(Me.Name, BarEditItem_Start.Name, Today.ToLongDateString))
            BarEditItem_End.EditValue = CDate(Module_Tools.RegKeyGet(Me.Name, BarEditItem_End.Name, Today.ToLongDateString))

            GridView.RestoreLayoutFromRegistry(Me.Name)
        End Sub

        Private Sub Btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            bLoopStop = True
            Modules.Module_Data.bLoopStop = True

            Module_Tools.RegKeySet(Me.Name, BarEditItem_Corporation.Name, BarEditItem_Corporation.EditValue.ToString)

            Module_Tools.RegKeySet(Me.Name, BarEditItem_Start.Name, BarEditItem_Start.EditValue.ToString)
            Module_Tools.RegKeySet(Me.Name, BarEditItem_End.Name, BarEditItem_End.EditValue.ToString)

            Return Modules.Form_Close(Me, BarManager, GridView, True)
        End Function

        Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView.KeyDown
            If GridView.SelectedRowsCount > 0 Then
                Select Case e.KeyCode
                    Case Keys.F2

                    Case Keys.F6
                        Module_Forms.Show_Journal_Entries(GridView.GetFocusedRowCellDisplayText(colORNumber))

                End Select
            End If
        End Sub

        Private Sub GridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridView.MouseDown, GridControl.MouseDown
            If GridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                Dim Parameters As SqlParameter() = {New SqlParameter("@Branch_Code", BarEditItem_Branch.EditValue.ToString),
                                                New SqlParameter("@Search", sSearch),
                                                New SqlParameter("@Action_Type", "LOAD_SEARCH")}

                Modules.Procedure_Retrieve(connectSP, GridControl, GridView, "acc_Cashiering_Procedures", Parameters)
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Try
                    Load_Search((CType(sender, BaseEdit)).Text.Trim)
                Catch Ex As NullReferenceException

                End Try
            End If
        End Sub

        Private Sub BarEditItem_Start_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItem_Start.ItemDoubleClick
            BarEditItem_Start.EditValue = Modules.Next_Working_Date(CDate(BarEditItem_Start.EditValue), My.Computer.Keyboard.ShiftKeyDown)
            BarEditItem_End.EditValue = BarEditItem_Start.EditValue
        End Sub

        Private Sub BarEditItem_End_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItem_End.ItemDoubleClick
            BarEditItem_End.EditValue = BarEditItem_Start.EditValue
        End Sub

        Private Sub GridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView.PrintInitialize
            Modules.Initialize_Printing(e)
        End Sub

        Private Sub Btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick
            GridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub GridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
            If (GridView.RowCount > 0) AndAlso e.Clicks.Equals(2) Then
                Modules.Copy_Clipboard(e.CellValue.ToString)
            End If
        End Sub

        Private Sub Btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
            Dim Parameters As SqlParameter() = {New SqlParameter("@Corporation", BarEditItem_Corporation.EditValue.ToString),
                                                New SqlParameter("@Branch_Code", BarEditItem_Branch.EditValue.ToString),
                                                New SqlParameter("@Date_Start", CDate(BarEditItem_Start.EditValue)),
                                                New SqlParameter("@Date_End", CDate(BarEditItem_End.EditValue)),
                                                New SqlParameter("@Action_Type", "LOAD_BRANCH")}

            Modules.Procedure_Retrieve(connectSP, GridControl, GridView, "acc_Cashiering_Procedures", Parameters)
        End Sub

        Private Sub Btn_Stop_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Stop.ItemClick
            bLoopStop = True
            Modules.Module_Data.bLoopStop = True
        End Sub

        Private Sub Btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Journal.ItemClick
            Execute_Cashiering_Journal(True)
        End Sub

        Friend Sub Execute_Cashiering_Journal(ByVal bConfirm As Boolean)
            With GridView
                If .DataRowCount > 0 Then
                    If Not Modules.actionAsk("Execute Journal Entries", "Execute Journal Entries [Payments]") Then Return

                    Dim iRowHandle As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If Not Modules.GridView_Loop(GridView, iRowHandle, "Cashiering Journal", "executed", bLoopStop) Then Return
                        Modules.Journal_Entry_Save(connectSP, "CASHIERING", CInt(.GetRowCellValue(iRowHandle, colID)))
                    Next

                    Show_Journal_Entries()
                    Modules.Set_Message(Modules.MsgMode.Info, $"Journal Entry [Payments]{Environment.NewLine}Between Date Range were successfully executed.")
                End If
            End With
        End Sub

        Private Sub Show_Journal_Entries()
            Module_Forms.Show_Journal_Entries(GridView.GetFocusedRowCellDisplayText(colORNumber))
        End Sub

        Private Sub Btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Journal_Entries.ItemClick
            If GridView.SelectedRowsCount > 0 Then
                Show_Journal_Entries()
            End If
        End Sub

        Private Sub Btn_Verify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Verify.ItemClick
            With GridView
                If .DataRowCount > 0 Then

                    Dim iRowHandle As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If Not Modules.GridView_Loop(GridView, iRowHandle, "Cashiering Journal verification", "verified", bLoopStop) Then Return

                        Modules.Journal_Verify(connectSP, CInt(.GetRowCellValue(iRowHandle, colID)), "CASHIERING")
                    Next

                    Show_Journal_Entries()
                    Btn_Reload_ItemClick(sender, e)
                End If
            End With
        End Sub
    End Class
End Namespace