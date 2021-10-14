Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_MC_Promotions
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If xuc_MC_Promo Is Nothing Then
                Me.xuc_MC_Promo = New Controls.Accounting.xuc_MC_Promo()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, xuc_MC_Promo.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Payment_Promos_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim repositoryCOA As New Repository.RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_COA(repositoryCOA, eCOA_Type.COA_All)
            colCOA_Code.ColumnEdit = repositoryCOA
        End Sub

        Private Sub frm_Payment_Promos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_MC_Promo.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, xuc_MC_Promo.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Payment_Promos_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_MC_Promo.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM acc_MC_Promotions WHERE Promo_Name LIKE '%{sSearch}%' OR Promo_Description LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%'", "acc_MC_Promotions")
            End If
        End Sub

        Private Sub Data_Load()
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Action_Type", "LOAD")
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Promotion_Procedures", "Promotional and Discounts")
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Try
                    Load_Search((CType(sender, BaseEdit)).Text.Trim)
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_MC_Promo
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                    .Promo_Code.Text = gridView.GetFocusedRowCellDisplayText(colPromo_Code)
                    .Promo_Type.Text = gridView.GetFocusedRowCellDisplayText(colPromo_Type)
                    .Promo_Name.Text = gridView.GetFocusedRowCellDisplayText(colPromo_Name)
                    .Promo_Description.Text = gridView.GetFocusedRowCellDisplayText(colPromo_Description)
                    .COA_Code.EditValue = gridView.GetFocusedRowCellValue(colCOA_Code)
                    .Discount.Value = gridView.GetFocusedRowCellValue(colDiscount)
                    .Promo_Start.EditValue = gridView.GetFocusedRowCellValue(colPromo_Date_Start)
                    .Promo_End.EditValue = gridView.GetFocusedRowCellValue(colPromo_Date_End)
                    .Brand.Text = gridView.GetFocusedRowCellDisplayText(colBrand)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                End With
            End If
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If gridView.DataRowCount > 0 AndAlso e.Clicks.Equals(2) Then
                Data_Show()
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then Data_Show()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_MC_Promo.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_MC_Promo.Control_Save() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
            'Dim xRpt As New Reports.Accounting.xrpt_Payment_Promo()
            'class_Database.BindData(class_Database.ICSConnection, xRpt, $"SELECT * FROM acc_MC_Promotions WHERE Promo_Code LIKE '{gridView.GetFocusedRowCellDisplayText(colPromo_Code)}'", "acc_MC_Promotions")

            'Try
            '    With xRpt
            '        .PaperKind = System.Drawing.Printing.PaperKind.Custom
            '        .PageWidth = 850
            '        .PageHeight = 550

            '        .Branch_Name.Text = class_Saga_Database.get_Branch_Name(gridView.GetFocusedRowCellValue(colCOA_Code))
            '        .XrTableCell_Promo_Start.Text = gridView.GetFocusedRowCellDisplayText(colPromo_Start)

            '        .XrTableCell_Promo_Name.Text = gridView.GetFocusedRowCellDisplayText(colPromo_Name)
            '        .XrTableCell_Promo_Address.Text = gridView.GetFocusedRowCellDisplayText(colPromo_Address)

            '        .XrTableCell_Discount.Text = gridView.GetFocusedRowCellDisplayText(colDiscount)

            '        .XrTableCell_Promo_Description.Text = gridView.GetFocusedRowCellDisplayText(colPromo_Description)

            '        .XrTableCell_Promo_Start.Text = Date.Today.ToString("MMMM dd, yyyy")
            '    End With
            'Catch ex As Exception
            '    class_Procedures.Show_Error(ex)
            'End Try
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            'If xuc_MC_Promo.Control_Delete() Then
            '    gridView.DeleteRow(gridView.FocusedRowHandle)
            'End If
        End Sub
    End Class

End Namespace