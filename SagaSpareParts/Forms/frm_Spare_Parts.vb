Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes

Namespace Forms

    Partial Public Class frm_Spare_Parts
        Inherits DevExpress.XtraEditors.XtraForm

        Private Shared bImport As Boolean = False

        Public Sub New()
            If Me.Xuc_Spare_Part Is Nothing Then
                Me.Xuc_Spare_Part = New SagaSpareParts.Controls.Xuc_Spare_Part()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, Xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(Me, barManager, Xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Spare_Parts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub frm_Spare_Parts_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If Xuc_Settings.Toggle_Auto_Initialize.IsOn Then Xuc_Spare_Part.Control_Initialize()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, Me.Xuc_Settings, True)
        End Function

        Private Sub frm_Spare_Parts_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            Xuc_Spare_Part.Control_Initialize()
        End Sub

        Private Sub Data_Load()

            If class_Procedures.isEmpty(Xuc_Spare_Part.part_Brand) Then Return
            If class_Procedures.isEmpty(Xuc_Spare_Part.part_Category) Then Return
            If Xuc_Settings.Toggle_Load_All.IsOn Then
                'If Xuc_Spare_Part.part_Category.Text.Trim.Equals("SPARE PARTS") Then
                'If Not class_Procedures.isEmpty(Xuc_Spare_Part.part_Brand) Then
                class_Database.Bind_Data(class_Database.SPAConnection, gridControl, gridView, $"SELECT * FROM Spare_Parts_Master WHERE Category LIKE '{Xuc_Spare_Part.part_Category.Text.Trim}' AND Brand LIKE '{Xuc_Spare_Part.part_Brand.Text.Trim}'", "Spare_Parts_Master")
                'End If
                'Else
                '    class_Database.BindData(class_database.SPAConnection, gridControl, gridView, $"SELECT * FROM Spare_Parts_Master WHERE Category LIKE '{Xuc_Spare_Part.part_Category.Text.Trim}'", "Spare_Parts_Master")
                'End If
            Else
                'If Not class_Procedures.isEmpty(Xuc_Spare_Part.part_Brand) Then
                class_Database.Bind_Data(class_Database.SPAConnection, gridControl, gridView, $"SELECT * FROM Spare_Parts_Master WHERE Category LIKE '{Xuc_Spare_Part.part_Category.Text.Trim}' AND Brand LIKE '{Xuc_Spare_Part.part_Brand.Text.Trim}'", "Spare_Parts_Master")
                'End If
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With Xuc_Spare_Part
                    .part_ID.Text = gridView.GetFocusedRowCellDisplayText(colid)
                    .part_Category.Text = gridView.GetFocusedRowCellDisplayText(colCategory)
                    .part_Brand.Text = gridView.GetFocusedRowCellDisplayText(colBrand)
                    .part_Price.Text = gridView.GetFocusedRowCellDisplayText(colSRP)
                    .part_Number.Text = gridView.GetFocusedRowCellDisplayText(colPartsNumber)
                    .part_Name.Text = gridView.GetFocusedRowCellDisplayText(colPartsName)
                    .part_Model_Code.Text = gridView.GetFocusedRowCellDisplayText(colModelCode)
                    .part_Model_Name.Text = gridView.GetFocusedRowCellDisplayText(colModelName)
                    .part_Notes.Text = gridView.GetFocusedRowCellDisplayText(colNote)
                End With
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If Xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then Data_Show()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            Xuc_Spare_Part.Control_New(Xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            Xuc_Spare_Part.Control_Save(True)
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

        Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
            If gridView1.RowCount > 0 Then
                With Xuc_Spare_Part
                    .part_Category.Text = gridView1.GetFocusedRowCellDisplayText(colBrand)
                    .part_Number.Text = gridView1.GetFocusedRowCellDisplayText(colPARTNUMBER)
                    .part_Name.Text = gridView1.GetFocusedRowCellDisplayText(colPARTNAME)
                    .part_Model_Code.Text = gridView1.GetFocusedRowCellDisplayText(colMODEL)
                    .part_Model_Name.Text = gridView1.GetFocusedRowCellDisplayText(colMODELNAME1)
                    .part_Price.Text = gridView1.GetFocusedRowCellDisplayText(colSRP1)
                End With
            End If
        End Sub

        Private Sub btn_Generate_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Generate.ItemClick
            class_Procedures.splash_Show("loading Spare Parts")

            gridView1.BestFitColumns()
            class_Procedures.splash_Close()
        End Sub

        Private Sub btn_Import_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Import.ItemClick
            If gridView1.RowCount > 0 Then
                bImport = True
                Dim i As Integer = 0

                While i <= gridView1.RowCount AndAlso bImport
                    gridView1.SelectRow(i)
                    gridView1.FocusedRowHandle = i
                    gridView1.RefreshRow(i)

                    With Xuc_Spare_Part
                        .part_Category.Text = gridView1.GetRowCellDisplayText(i, colBrand)
                        .part_Number.Text = gridView1.GetRowCellDisplayText(i, colPARTNUMBER)
                        .part_Name.Text = gridView1.GetRowCellDisplayText(i, colPARTNAME)
                        .part_Model_Code.Text = gridView1.GetRowCellDisplayText(i, colMODEL)
                        .part_Model_Name.Text = gridView1.GetRowCellDisplayText(i, colMODELNAME1)
                        .part_Price.Text = gridView1.GetRowCellDisplayText(i, colSRP1)
                        .Control_Save(False)
                    End With
                    i += 1
                End While
            End If
        End Sub

        Private Sub btn_Stop_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bImport = False
            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "Spare Parts imported has been stopped!")
        End Sub

    End Class

End Namespace