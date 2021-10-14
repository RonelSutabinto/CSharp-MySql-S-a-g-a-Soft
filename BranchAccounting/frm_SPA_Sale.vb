Imports BranchAccounting.Modules
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Forms

    Public Class frm_SPA_Sale
        Private bLoopStop As Boolean

        Private repositoryItemLookUpEdit_Branch As New RepositoryItemLookUpEdit()

        Public Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, gridView, BtnCancel)

            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_SPA_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            btn_Journal.Enabled = class_Saga_Variables.isCashier Or class_Saga_Variables.isAccounting

            class_Saga_Procedures.Initialize_Branch(repositoryItemLookUpEdit_Branch)
        End Sub

        Private Sub frm_SPA_Sale_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        End Sub

        Private Function Form_Close() As Boolean
            bLoopStop = True
            class_Saga_Database.bLoopStop = True

            Return class_Procedures.Form_Close(Me, BarManager, gridView, True)
        End Function

        Private Sub frm_Spare_Parts_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub Data_Load()
            If class_Database.OpenDB(class_Database.SPAConnection) Then
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode),
                    New SqlParameter("@ParamDateBegin", class_Saga_Variables.dtStart),
                    New SqlParameter("@ParamDateEnd", class_Saga_Variables.dtEnd),
                    New SqlParameter("@Action_Type", "ACCOUNTING")
                }
                class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, gridView, "SPA_Sales_Report", "SPA Sales", True)

                If gridView.DataRowCount > 0 Then
                    gridView.Columns("BranchCode").ColumnEdit = repositoryItemLookUpEdit_Branch
                    class_Procedures.Initialize_gridView(gridView)
                    gridView.BestFitColumns()
                End If
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView.MouseDown, gridControl.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            Select Case e.KeyCode
                Case Keys.F6
                    Journal_Entries()

            End Select
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Select Case e.Column.FieldName
                    Case "Reference"
                        class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText("Reference"), Convert.ToInt32(gridView.GetFocusedRowCellValue("ID")))

                    Case "Receipt"
                        If gridView.GetFocusedRowCellDisplayText("Receipt").Length > 0 Then
                            class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText("Receipt"), Convert.ToInt32(gridView.GetFocusedRowCellValue("ID")))
                        End If

                    Case Else
                        If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                class_Database.Bind_Data(class_Database.SPAConnection, gridControl, gridView, $"SELECT * FROM Spare_Parts_Master WHERE PartsNumber LIKE '%{sSearch}%' OR PartsName LIKE '%{sSearch}%' OR ModelCode LIKE '%{sSearch}%' OR ModelName LIKE '%{sSearch}%' OR Note LIKE '%{sSearch}%' OR Remarks LIKE '%{sSearch}%'", "Spare_Parts_Master")
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Load_Search((CType(sender, BaseEdit)).Text.Trim)
            End If
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            Journal_Entries()
        End Sub

        Private Sub Journal_Entries()
            With gridView
                Try
                    If .GetFocusedRowCellDisplayText("Receipt").Length > 0 Then
                        class_Saga_Procedures.Show_Journal_Entries_Reference(.GetFocusedRowCellDisplayText("Receipt"), Convert.ToInt32(.GetFocusedRowCellValue("ID")))
                    Else
                        class_Saga_Procedures.Show_Journal_Entries_Reference(.GetFocusedRowCellDisplayText("Reference"), Convert.ToInt32(.GetFocusedRowCellValue("ID")))
                    End If
                Catch ex As Exception
                    class_Saga_Procedures.Show_Journal_Entries_Reference(.GetFocusedRowCellDisplayText("Reference"), Convert.ToInt32(.GetFocusedRowCellValue("ID")))
                End Try
            End With
        End Sub

        Private Sub btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    If Not class_Procedures.actionAsk("Journal Execution", "Execute SPA(s)/Lubricant(s)/etc. Journal Entries", "take a while") Then Return

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Spare Parts Sale Journal", "executed", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim iTableID As Integer = Convert.ToInt32(.GetRowCellValue(iRowHandle, "ID"))
                        Dim sReference As String = .GetRowCellDisplayText(iRowHandle, "Reference")
                        Dim dtPostingDate As Date = Convert.ToDateTime(.GetRowCellValue(iRowHandle, "PostingDate"))

                        If class_Saga_Database.Journal_Entry_Save("SPA_SALE", iTableID, dtPostingDate) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Spare Parts [Sales]:{Environment.NewLine}{sReference}{Environment.NewLine}was successfully executed.")
                        End If
                    Next

                    Journal_Entries()
                End If
            End With
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    If Not class_Procedures.actionAsk("Verification", "Verify SPA(s)/Lubricant(s)/etc. Journal Entries", "take a while") Then Return

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "SPA Sales verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, "ID")), "SPA_SALE") Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Spare Parts [Verification]:{Environment.NewLine}{ .GetRowCellDisplayText(iRowHandle, "Reference")}{Environment.NewLine}was successfully verified.")
                        End If
                    Next

                    Module_Forms.Show_Journal_Entries(gridView.GetFocusedRowCellDisplayText("Reference"))
                    Data_Load()
                End If
            End With
        End Sub

    End Class

End Namespace