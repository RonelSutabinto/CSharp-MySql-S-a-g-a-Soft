Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Forms

    Public Class frm_SPA_Inventory
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

        Private Sub frm_SPA_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Registry_Values_Get()

            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit_Branch)
            colBranchCode.ColumnEdit = RepositoryItemLookUpEdit_Branch
            colBranchTo.ColumnEdit = RepositoryItemLookUpEdit_Branch
        End Sub

        Private Sub Registry_Values_Get()

        End Sub

        Private Sub Registry_Values_Set()

        End Sub

        Private Function Form_Close() As Boolean
            Registry_Values_Set()
            Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_SPA_Inventory_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            'Xuc_Spare_Part.Control_Initialize()
        End Sub

        Private Sub Data_Load()

            If class_Database.OpenDB(class_Database.SPAConnection) Then
                Dim sqlParameters As SqlParameter() = {New SqlParameter("@BranchCode", barEditItem_Branch.EditValue.ToString),
                                                    New SqlParameter("@DateStart", class_Saga_Variables.dtStart),
                                                    New SqlParameter("@DateEnd", class_Saga_Variables.dtEnd),
                                                    New SqlParameter("@Action_Type", "LOAD")}

                class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_SPA_Inventory_Procedures", "SPA Inventory")
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
            If Me.Xuc_Settings.Toggle_Select.ison Then Data_Show()
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then Data_Show()
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView.MouseDown, gridControl.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Select Case e.Column.Name
                    Case "colPartNumber"
                        Module_Procedures.Show_Spare_Part(e.CellValue.ToString.Trim)

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

                class_Database.Bind_Data(class_Database.SPAConnection, gridControl, gridView, $"SELECT * FROM Spare_Parts_Master WHERE PartsNumber LIKE '%{sSearch}%' OR PartsName LIKE '%{sSearch}%' OR ModelCode LIKE '%{sSearch}%' OR ModelName LIKE '%{sSearch}%' OR Note LIKE '%{sSearch}%' OR Remarks LIKE '%{sSearch}%'", "Spare_Parts_Master")
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Load_Search((CType(sender, BaseEdit)).Text.Trim)
            End If
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick

        End Sub

        Private Sub btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            With gridView
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    If Not class_Procedures.actionAsk("Execute SPA Journal Entries", "take a while") Then Return
                    class_Procedures.splash_Show("Executing SPA Journal Entries")


                    bLoopStop = False
                    .ClearSelection()
                    class_Database.Initialize_Connection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "SPA Transfers Journal", "executed", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If class_Saga_Database.Journal_Entry_Save("TRANSFER_SPA", Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), .GetRowCellValue(iRowHandle, colPostingDate)) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Spare Parts [Transfers]:{Environment.NewLine}{ .GetRowCellDisplayText(iRowHandle, colRefNo)}{Environment.NewLine}was successfully executed.")
                        End If
                    Next
                    class_Saga_Procedures.Show_Journal_Entries_Reference(.GetFocusedRowCellDisplayText(colRefNo), Convert.ToInt32(.GetFocusedRowCellValue(colID)))

                    class_Procedures.splash_Close()
                End If
            End With
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            If gridView.SelectedRowsCount > 0 Then
                class_Database.Initialize_Connection()
                class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colRefNo), Convert.ToInt32(gridView.GetFocusedRowCellValue(colID)))
            End If
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    If Not class_Procedures.actionAsk("Verification", "Verify SPA(s)/Lubricant(s)/etc. Journal Entries", "take a while") Then Return


                    bLoopStop = False
                    .ClearSelection()
                    class_Database.Initialize_Connection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "SPA Sales verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim iTableID As Integer = Convert.ToInt32(.GetRowCellValue(iRowHandle, colID))
                        Dim sReference As String = .GetRowCellDisplayText(iRowHandle, colRefNo)

                        'If class_Saga_Database.Verify_SPA("VERIFY_SPA_INV", iTableID) Then
                        '    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Spare Parts [Verification]:{Environment.NewLine}{sReference}{Environment.NewLine}was successfully verified.")
                        'End If
                    Next
                End If
            End With
        End Sub

    End Class

End Namespace