Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPrinting
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Logistics

    Public Class frm_Unit_Invoices
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, Xuc_Unit_Invoice.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Unit_Invoices_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, Xuc_Unit_Invoice.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub frm_Unit_Invoices_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub frm_Unit_Invoices_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
            Dim repositoryBrand As New RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Brand(repositoryBrand)
            colBrand_Code.ColumnEdit = repositoryBrand

            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then
                Xuc_Unit_Invoice.Control_Initialize()
            End If

            If xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load()
            End If
        End Sub

        Private Sub Data_Load(Optional ByVal sSearch As String = "")
            Dim sAction As String

            If sSearch.Length > 2 Then
                sAction = "SEARCH"
            Else
                If xuc_Settings.Toggle_Load_All.IsOn Then
                    sAction = "LOAD_ALL"
                Else
                    sAction = "LOAD"
                End If
            End If

            Dim sqlParameters As SqlParameter() = {
               New SqlParameter("@Brand_Code", Xuc_Unit_Invoice.Brand_Code.EditValue),
               New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
               New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
               New SqlParameter("@Search", sSearch),
               New SqlParameter("@Action_Type", sAction)
           }

            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Unit_Invoice_Procedures", "inv_Unit_Invoices")
        End Sub

        Private Sub Data_Show()
            With Xuc_Unit_Invoice
                .ID.EditValue = gridView.GetFocusedRowCellValue(colID)
                .Invoice_Code.Text = gridView.GetFocusedRowCellDisplayText(colInvoice_Code)
                .Brand_Code.EditValue = gridView.GetFocusedRowCellValue(colBrand_Code)
                .Order_Code.Text = gridView.GetFocusedRowCellDisplayText(colOrder_Code)
                .Invoice_Number.Text = gridView.GetFocusedRowCellDisplayText(colInvoice_Number)
                .Due_Date.EditValue = gridView.GetFocusedRowCellValue(colDue_Date)
                .Due_Date.EditValue = gridView.GetFocusedRowCellValue(colDue_Date)
                .Model_Code.EditValue = gridView.GetFocusedRowCellValue(colModel_Code)
                .Model_Name.EditValue = gridView.GetFocusedRowCellDisplayText(colModel_Name)
                .Model_Color.EditValue = gridView.GetFocusedRowCellDisplayText(colModel_Color)
                .Quantity.Value = gridView.GetFocusedRowCellValue(colQuantity)
                .Invoice_Amount.Value = gridView.GetFocusedRowCellValue(colInvoice_Amount)
                .Remaining_Balance.Value = gridView.GetFocusedRowCellValue(colRemaining_Balance)
                .Freight_Cost.Value = gridView.GetFocusedRowCellValue(colFreight_Cost)
                .Invoice_Description.Text = gridView.GetFocusedRowCellDisplayText(colInvoice_Description)
                .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
            End With
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Data_Load((CType(sender, BaseEdit)).Text.Trim)
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Select Case e.Column.Name
                    Case Else
                        Data_Show()
                        If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView.MouseDown
            If (gridView.RowCount > 0) AndAlso e.Button.Equals(MouseButtons.Right) Then popupMenu.ShowPopup(Control.MousePosition)
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            Xuc_Unit_Invoice.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If Xuc_Unit_Invoice.Control_Save() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load()
            End If
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            If Xuc_Unit_Invoice.Control_Delete() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load()
            End If
        End Sub

    End Class

End Namespace