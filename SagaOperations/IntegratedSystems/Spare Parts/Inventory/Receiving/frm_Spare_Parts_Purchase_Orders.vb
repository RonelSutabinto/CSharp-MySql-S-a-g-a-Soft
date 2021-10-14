Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports SagaOperations.Classes
Imports System.Data.SqlClient

Public Class frm_Spare_Parts_Purchase_Orders

    Public Sub New()
        If Me.Xuc_Spare_Parts_Purchase_Order Is Nothing Then
            Me.Xuc_Spare_Parts_Purchase_Order = New Xuc_Spare_Parts_Purchase_Order()
        End If

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, GridView, BtnCancel, Xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Function Form_Close() As Boolean
        GridView_Items.SaveLayoutToRegistry(GridView_Items.Name)

        class_Tools.RegKeySet(Me.Name, Xuc_Spare_Parts_Purchase_Order.Order_Date.Name, Xuc_Spare_Parts_Purchase_Order.Order_Date.EditValue)

        Return class_Procedures.Form_Close(Me, BarManager, DockManager, GridView, Xuc_Settings, True)
    End Function

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Purchase_Orders_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub Btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub frm_Purchase_Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Procedures.Initialize_GridView(GridView_Items, True, True)

        GridView_Items.RestoreLayoutFromRegistry(GridView_Items.Name)
    End Sub

    Private Sub frm_Spare_Parts_Purchase_Orders_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Xuc_Settings.Check_Auto_Initialize.Checked Then Xuc_Spare_Parts_Purchase_Order.Control_Initialize()
        If Xuc_Settings.Check_Auto_Reload.Checked Then Data_Load()

        Xuc_Spare_Parts_Purchase_Order.Order_Date.EditValue = class_Tools.RegKeyGet(Me.Name, Xuc_Spare_Parts_Purchase_Order.Order_Date.Name, Date.Today)
        class_Saga_Procedures.Initialize_Brand(RepositoryItemLookUpEdit_Brand_Code)

        class_Saga_Procedures.Initialize_Model_Color(RepositoryItemLookUpEdit_Category)
    End Sub

    Private Sub Data_Load()

        Dim Parameters As SqlParameter() = {New SqlParameter("@Action_Type", "LOAD_ALL")}
        class_Database.Procedure_Retrieve(class_Database.ICSConnection, GridControl, GridView, "inv_Purchase_Order_Procedures", Parameters, "Purchase Orders")
    End Sub

    Private Sub Btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        Xuc_Spare_Parts_Purchase_Order.Control_Initialize()
        Data_Load()
    End Sub

    Private Sub Btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_New.ItemClick
        Me.Xuc_Spare_Parts_Purchase_Order.Control_New(Xuc_Settings.Check_Clear_New.Checked)
    End Sub

    Private Sub Btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Save.ItemClick
        If Me.Xuc_Spare_Parts_Purchase_Order.Control_Save() AndAlso Xuc_Settings.Check_Auto_Reload.Checked Then
            Data_Load()
        Else
            Update_Data_Row()
        End If
    End Sub

    Private Sub Btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Delete.ItemClick
        Me.Xuc_Spare_Parts_Purchase_Order.Control_Delete()
    End Sub

    Private Sub Data_Show()
        With Xuc_Spare_Parts_Purchase_Order
            .ID.Text = GridView.GetFocusedRowCellDisplayText(colID)
            .Order_Code.Text = GridView.GetFocusedRowCellValue(colOrder_Code)
            .Brand_Code.EditValue = GridView.GetFocusedRowCellValue(colBrand_Code)
            .Order_Date.EditValue = GridView.GetFocusedRowCellDisplayText(colOrder_Date)
            .Description.Text = GridView.GetFocusedRowCellDisplayText(colOrder_Description)
            .Notes.Text = GridView.GetFocusedRowCellDisplayText(colNotes)
        End With
        Load_Items()
    End Sub

    Private Sub Load_Items()
        class_Saga_Variables.Initialize_MC_Models(Xuc_Spare_Parts_Purchase_Order.Brand_Code.Text.Trim)
        class_Saga_Procedures.Initialize_PartsNumber(RepositoryItemLookUpEdit_PartsNumber)
        class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_PartsNumber, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)
        class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_Category, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)

        class_Database.BindData(class_Database.ICSConnection, GridControl_Items, GridView_Items, $"SELECT * FROM inv_Purchase_Order_Items WHERE Order_Code LIKE '{Xuc_Spare_Parts_Purchase_Order.Order_Code.EditValue}' ORDER BY ID", "inv_Purchase_Order_Items")
    End Sub

    Private Sub Update_Data_Row()
        If GridView.RowCount > 0 Then
            With GridView
                .SetFocusedRowCellValue(colOrder_Code, Xuc_Spare_Parts_Purchase_Order.Order_Code.EditValue)
                .SetFocusedRowCellValue(colBrand_Code, Xuc_Spare_Parts_Purchase_Order.Brand_Code.Text)
                .SetFocusedRowCellValue(colOrder_Date, Xuc_Spare_Parts_Purchase_Order.Order_Date.Text)
                .SetFocusedRowCellValue(colOrder_Description, Xuc_Spare_Parts_Purchase_Order.Description.Text)
                .SetFocusedRowCellValue(colNotes, Xuc_Spare_Parts_Purchase_Order.Notes.Text)
            End With
        End If
    End Sub

    Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView.KeyDown
        If (GridView.DataRowCount > 0) Then
            Select Case e.KeyValue
                Case Keys.Delete
                    If Xuc_Spare_Parts_Purchase_Order.Control_Delete Then
                        Try
                            GridView.DeleteSelectedRows()
                        Catch Ex As Exception
                            class_Procedures.Show_Error(Ex)
                        End Try
                    End If
            End Select
        End If
    End Sub

    Private Sub GridView_MouseDown(sender As Object, e As MouseEventArgs) Handles GridView.MouseDown
        If GridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
            PopupMenu.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub GridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        If e.Clicks.Equals(2) AndAlso GridView.DataRowCount > 0 Then
            Select Case e.Column.FieldName
                Case "supplier_code"
                Case Else
                    class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                    Data_Show()
            End Select
        End If
    End Sub

End Class