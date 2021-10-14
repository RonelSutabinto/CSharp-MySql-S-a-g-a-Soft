Imports DevExpress.XtraBars
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Information.Item

    Public Class frm_Brands
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If Me.xuc_Brand Is Nothing Then
                Me.xuc_Brand = New Controls.Information.Item.xuc_Brand()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Brand.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Brands_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Brand(RepositoryItemLookUpEdit_Brand_Supplier, "Account_Code", "Account_Name")
        End Sub

        Private Sub frm_Brands_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Brand.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, DockManager, gridView, xuc_Brand.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Brands_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub Data_Load()
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Action_Type", "LOAD_ALL")
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Brand_Procedures", "Brand Descriptions")
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Brand.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Brand
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colid)
                    .Brand_Code.Text = $"Brand-{ .ID.EditValue}"
                    '.Account_Code.EditValue = gridView.GetFocusedRowCellValue(colAccount_Code)
                    .Brand_Name.Text = gridView.GetFocusedRowCellDisplayText(colBrand_Name)
                    .Account_Code.EditValue = gridView.GetFocusedRowCellValue(colAccount_Code)
                    .Brand_Description.Text = gridView.GetFocusedRowCellDisplayText(colBrand_Description)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                End With
            End If
        End Sub

        Private Sub Data_Row_Update()
            If gridView.RowCount > 0 Then
                With gridView
                    .SetFocusedRowCellValue(colid, xuc_Brand.ID.EditValue)
                    .SetFocusedRowCellValue(colBrand_Code, xuc_Brand.Brand_Code.Text)
                    .SetFocusedRowCellValue(colBrand_Name, xuc_Brand.Brand_Name.Text)
                    .SetFocusedRowCellValue(colAccount_Code, xuc_Brand.Account_Code.Text)
                    .SetFocusedRowCellValue(colBrand_Description, xuc_Brand.Brand_Description.Text)
                    .SetFocusedRowCellValue(colNotes, xuc_Brand.Notes.Text)
                End With
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown

        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Brand.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Brand.Control_Save() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load()
            Else
                Data_Row_Update()
            End If
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Delete.ItemClick
            If xuc_Brand.Control_Delete() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

    End Class

End Namespace