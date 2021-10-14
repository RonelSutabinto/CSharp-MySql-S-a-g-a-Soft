Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports BranchAccounting.Modules
Imports DevExpress.XtraBars
Imports wSClassLib.myModules

Namespace Forms
    Public Class XtraForm_Spare_Part
        Private bLoopStop As Boolean

        Public Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            Modules.Initialize_Form(Me, GridView, BtnCancel)
            Modules.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub XtraForm_Spare_Part_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Modules.Initialize_Branch()
            Modules.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit_Branch)
            colBranchCode.ColumnEdit = RepositoryItemLookUpEdit_Branch

            BarEditItem_Corporation.EditValue = Module_Tools.RegKeyGet(Me.Name, BarEditItem_Corporation.Name, "SMC")

            BarEditItem_Branch.EditValue = mBrCode
            BarEditItem_Branch.Enabled = False

            BarEditItem_Start.EditValue = CDate(Module_Tools.RegKeyGet(Me.Name, BarEditItem_Start.Name, Today.ToLongDateString))
            BarEditItem_End.EditValue = CDate(Module_Tools.RegKeyGet(Me.Name, BarEditItem_End.Name, Today.ToLongDateString))

            GridView.RestoreLayoutFromRegistry(Me.Name)
        End Sub

        Private Function Form_Close() As Boolean
            bLoopStop = True
            Modules.Module_Data.bLoopStop = True

            Module_Tools.RegKeySet(Me.Name, BarEditItem_Corporation.Name, BarEditItem_Corporation.EditValue.ToString)

            Module_Tools.RegKeySet(Me.Name, BarEditItem_Start.Name, BarEditItem_Start.EditValue.ToString)
            Module_Tools.RegKeySet(Me.Name, BarEditItem_End.Name, BarEditItem_End.EditValue.ToString)

            Return Modules.Form_Close(Me, BarManager, GridView, True)
        End Function

        Private Sub Frm_Spare_Parts_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub Btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub Data_Load()
            Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", BarEditItem_Branch.EditValue.ToString),
                                                New SqlParameter("@ParamDateBegin", CDate(BarEditItem_Start.EditValue)),
                                                New SqlParameter("@ParamDateEnd", CDate(BarEditItem_End.EditValue)),
                                                New SqlParameter("@Action_Type", "ACCOUNTING")}

           Modules.Procedure_Retrieve(connectSPareParts, GridControl, GridView, "SPA_Sales_Report", Parameters)
        End Sub

        Private Sub Btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub GridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridView.MouseDown
            If GridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub GridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
            If (GridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Select Case e.Column.Name
                    Case "colPartNumber"
                        'SagaSpareParts.Modules.Show_Spare_Part(e.CellValue.ToString.Trim)

                    Case Else
                        If e.CellValue Is Nothing Then Return Else Modules.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub GridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView.PrintInitialize
            Modules.Initialize_Printing(e)
        End Sub

        Private Sub Btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick
            GridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
               Modules.BindData(connectSPareParts, GridControl, GridView, $"SELECT * FROM Spare_Parts_Master WHERE PartsNumber LIKE '%{sSearch}%' OR PartsName LIKE '%{sSearch}%' OR ModelCode LIKE '%{sSearch}%' OR ModelName LIKE '%{sSearch}%' OR Note LIKE '%{sSearch}%' OR Remarks LIKE '%{sSearch}%'", "Spare_Parts_Master")
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Load_Search((CType(sender, BaseEdit)).Text.Trim)
            End If
        End Sub

        Private Sub BarEditItem_Start_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItem_Start.ItemDoubleClick
            BarEditItem_Start.EditValue = Modules.Next_Working_Date(CDate(BarEditItem_Start.EditValue), My.Computer.Keyboard.ShiftKeyDown)
            BarEditItem_End.EditValue = BarEditItem_Start.EditValue
        End Sub

        Private Sub BarEditItem_End_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItem_End.ItemDoubleClick
            BarEditItem_End.EditValue = BarEditItem_Start.EditValue
        End Sub

        Private Sub Btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Stop.ItemClick
            bLoopStop = True
        End Sub

        Private Sub Btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Journal_Entries.ItemClick
            If GridView.SelectedRowsCount > 0 Then
                Module_Forms.Show_Journal_Entries(GridView.GetRowCellDisplayText(GridView.FocusedRowHandle, colReference))
            End If
        End Sub

        Private Sub Btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Journal.ItemClick
            With GridView
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    If Not Modules.actionAsk("Journal Execution", "Execute SPA(s)/Lubricant(s)/etc. Journal Entries", "take a while") Then Return

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If Not Modules.GridView_Loop(GridView, iRowHandle, "Spare Parts Sale Journal", "executed", bLoopStop) Then Return

                        Dim iTableID As Integer = CInt(.GetRowCellValue(iRowHandle, colID))
                        Dim sReference As String = .GetRowCellDisplayText(iRowHandle, colReference)

                        If Modules.Journal_Entry_Save(connectSP, "SPA_SALE", iTableID) Then
                            Modules.Set_Message(Modules.MsgMode.Info, $"Spare Parts [Sales]:{Environment.NewLine}{sReference}{Environment.NewLine}was successfully executed.")
                        End If

                        If selectedRows.Length.Equals(1) Then
                            Module_Forms.Show_Journal_Entries(sReference)
                        End If
                    Next
                End If
            End With
        End Sub

        Private Sub Btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Verify.ItemClick
            With GridView
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    If Not Modules.actionAsk("Verification", "Verify SPA(s)/Lubricant(s)/etc. Journal Entries", "take a while") Then Return

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If Not Modules.GridView_Loop(GridView, iRowHandle, "SPA Sales verification", "verified", bLoopStop) Then Return

                        If Modules.Journal_Verify(connectSP, CInt(.GetRowCellValue(iRowHandle, colID)), "SPA_SALE") Then
                            Modules.Set_Message(Modules.MsgMode.Info, $"Spare Parts [Verification]:{Environment.NewLine}{ .GetRowCellDisplayText(iRowHandle, colReference)}{Environment.NewLine}was successfully verified.")
                        End If
                    Next

                    Module_Forms.Show_Journal_Entries(GridView.GetFocusedRowCellDisplayText(colReference))
                    Btn_Reload_ItemClick(sender, e)
                End If
            End With
        End Sub
    End Class
End Namespace