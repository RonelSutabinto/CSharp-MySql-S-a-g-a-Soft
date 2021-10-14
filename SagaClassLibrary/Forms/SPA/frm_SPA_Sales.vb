Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.SPA
    Public Class frm_SPA_Sales
        Private bLoopStop As Boolean

        Public Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, Xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(Me, barManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_SPA_Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit_Branch)
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Spare_Parts_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            'Xuc_Spare_Part.Control_Initialize()
        End Sub

        Public Sub Data_Load()
            If class_Database.OpenDB(class_Database.SPAConnection) Then
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@ParamBranchCode", barEditItem_Branch.EditValue.ToString),
                    New SqlParameter("@ParamDateBegin", class_Saga_Variables.dtStart),
                    New SqlParameter("@ParamDateEnd", class_Saga_Variables.dtEnd),
                    New SqlParameter("@Action_Type", "ACCOUNTING")
                }
                class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, gridView, "SPA_Sales_Report", "SPA Sales")
                class_Procedures.Initialize_gridView(gridView)
                Try
                    'gridView.Columns("BranchCode").ColumnEdit = RepositoryItemLookUpEdit_Branch
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
                If Xuc_Settings.Check_Save_Restore_Layout.Checked Then gridView.RestoreLayoutFromRegistry(Me.Name)
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                'Xuc_Spare_Part.part_ID.Text = gridView.GetFocusedRowCellDisplayText(colID)
                'Xuc_Spare_Part.part_Category.Text = gridView.GetFocusedRowCellDisplayText(colCategory)
                'Xuc_Spare_Part.part_Number.Text = gridView.GetFocusedRowCellDisplayText(colPartsNumber)
                'Xuc_Spare_Part.part_Name.Text = gridView.GetFocusedRowCellDisplayText(colPartsName)
                'Xuc_Spare_Part.part_Model_Code.Text = gridView.GetFocusedRowCellDisplayText(colModelCode)
                'Xuc_Spare_Part.part_Model_Name.Text = gridView.GetFocusedRowCellDisplayText(colModelName)
                'Xuc_Spare_Part.part_Price.Text = gridView.GetFocusedRowCellDisplayText(colSRP)
                'Xuc_Spare_Part.part_Notes.Text = gridView.GetFocusedRowCellDisplayText(colNote)
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If Me.Xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView.MouseDown, gridControl.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            Select Case e.KeyCode
                Case Keys.F6
                    Try
                        If gridView.GetFocusedRowCellDisplayText("Receipt").Length > 0 Then
                            class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText("Receipt"), Convert.ToInt32(gridView.GetFocusedRowCellValue("ID")))
                        Else
                            class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText("Reference"), Convert.ToInt32(gridView.GetFocusedRowCellValue("ID")))
                        End If
                    Catch ex As Exception
                        class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText("Reference"), Convert.ToInt32(gridView.GetFocusedRowCellValue("ID")))
                    End Try
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

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            'Xuc_Spare_Part.Control_New()
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            'Xuc_Spare_Part.Control_Save(True)
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick

        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                class_Database.Bind_Data(class_Database.SPAConnection, gridControl, gridView, $"SELECT * FROM Transaction_Collection WHERE SINo LIKE '%{sSearch}%' OR PartsNumber LIKE '%{sSearch}%' OR PartsName LIKE '%{sSearch}%' OR custName LIKE '%{sSearch}%' OR Descriptions LIKE '%{sSearch}%' OR Remarks LIKE '%{sSearch}%'", "Transaction_Collection")
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Load_Search((CType(sender, BaseEdit)).Text.Trim)
            End If
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            Dim sOldORNumber As String = gridView.GetFocusedRowCellDisplayText("Reference")
            Dim sNewORNumber As String = class_Functions.Show_Input_Box("Input new OR Number", "New OR Number", sOldORNumber).ToUpper
            If class_Procedures.actionAsk("SPA Sale", "SPA Sales Update", "You might update a wrong SPA Sale") Then
                class_Database.Data_Update(class_Database.SPAConnection, $"UPDATE Transaction_Collection SET SINo = '{sNewORNumber}' WHERE SINo LIKE '{sOldORNumber}'", True)
                class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET Journal_Reference = '{sNewORNumber}' WHERE Journal_Reference LIKE '{sOldORNumber}'", True)
            End If
        End Sub

        Private Sub btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            With gridView
                If .SelectedRowsCount > 0 Then
                    class_Database.DBError = False

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    If Not class_Procedures.actionAsk("Journal Execution", "Execute SPA(s)/Lubricant(s)/etc. Journal Entries", "take a while") Then Return

                    bLoopStop = False
                    .ClearSelection()
                    class_Database.Initialize_Connection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "SPA Sales Journal", "executed", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If class_Saga_Database.Journal_Entry_Save("SPA_SALE", Convert.ToInt32(.GetRowCellValue(iRowHandle, "ID")), .GetRowCellValue(iRowHandle, "PostingDate")) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Spare Parts [Sales]:{Environment.NewLine}{ .GetRowCellDisplayText(iRowHandle, "Reference")}{Environment.NewLine}was successfully executed.")
                        End If
                    Next
                    btn_Journal_Entries_ItemClick(sender, e)
                End If
            End With
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            With gridView
                If .SelectedRowsCount > 0 Then
                    class_Database.Initialize_Connection()
                    If .GetFocusedRowCellDisplayText("Receipt").Length > 0 Then
                        class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText("Receipt"), Convert.ToInt32(gridView.GetFocusedRowCellValue("ID")))
                    Else
                        class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText("Reference"), Convert.ToInt32(gridView.GetFocusedRowCellValue("ID")))
                    End If
                End If
            End With
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()
                    Dim sReference As String
                    Dim sRefTemp As String = String.Empty

                    If Not class_Procedures.actionAsk("Verification", "Verify SPA(s)/Lubricant(s)/etc. Journal Entries", "take a while") Then Return

                    bLoopStop = False
                    .ClearSelection()
                    class_Database.Initialize_Connection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        sReference = .GetRowCellDisplayText(iRowHandle, "Reference")

                        If sReference.Equals(sRefTemp) Then Continue For

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "SPA Sales verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, "ID")), "SPA_SALE") Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Spare Parts [Verification]:{Environment.NewLine}{ .GetRowCellDisplayText(iRowHandle, "Reference")}{Environment.NewLine}was successfully verified.")
                        End If
                        sRefTemp = sReference
                    Next
                    btn_Journal_Entries_ItemClick(sender, e)
                End If
            End With
        End Sub

    End Class

End Namespace