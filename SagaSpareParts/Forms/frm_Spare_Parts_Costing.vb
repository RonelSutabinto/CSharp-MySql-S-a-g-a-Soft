Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Namespace Forms

    Public Class frm_Spare_Parts_Costing

        Public Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, BtnCancel)
            class_Saga_Procedures.Initialize_BarManager(Me, barManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Spare_Parts_Costing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Registry_Values_Get()

            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit_Branch)
            colBranchCode.ColumnEdit = RepositoryItemLookUpEdit_Branch
        End Sub

        Private Sub Registry_Values_Get()

        End Sub

        Private Sub Registry_Values_Set()

        End Sub

        Private Function Form_Close() As Boolean
            Registry_Values_Set()
            Return class_Procedures.Form_Close(Me, barManager, DockManager, gridView, True)
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

        Private Sub Data_Load()
            If check_Load_All.Checked Or barEditItem_Branch.EditValue.ToString.Equals("000") Then
                'class_Database.BindData(class_database.SPAConnection, gridControl, gridView, "SELECT * FROM SPA_Inventory", "SPA_Inventory", True, "Spare_Parts")
            Else
                'class_Database.BindData(class_database.SPAConnection, gridControl, gridView, $"SELECT * FROM SPA_Inventory WHERE BranchCode LIKE '{barEditItem_Branch.EditValue}'", "SPA_Inventory", True, "Spare_Parts")
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

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Select Case e.Column.Name
                    Case "colcustCode"
                        class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.CIF, e.CellValue.ToString)

                    Case "colPartsNumber"
                        Module_Procedures.Show_Spare_Part(e.CellValue.ToString.Trim)

                    Case Else
                        If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If check_Select_Show.Checked Then Data_Show()
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then Data_Show()
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

    End Class

End Namespace