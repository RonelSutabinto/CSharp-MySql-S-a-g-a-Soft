Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Public Class frm_SPA_Purchase_Orders
    Dim sBrCode, sModelCode, sModelName, sColor As String
    Dim iQuantity As Integer
    Dim dUnitCost As Decimal
    Dim dFreight As Decimal = 0

    Public Sub New()
        If Me.Xuc_SPA_Purchase_Orders Is Nothing Then
            Me.Xuc_SPA_Purchase_Orders = New Xuc_SPA_Purchase_Orders()
        End If

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, GridView, BtnCancel, Xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Function Form_Close() As Boolean
        GridView_Items.SaveLayoutToRegistry(GridView_Items.Name)

        class_Tools.RegKeySet(Me.Name, Xuc_SPA_Purchase_Orders.Order_Date.Name, Xuc_SPA_Purchase_Orders.Order_Date.EditValue)

        Return class_Procedures.Form_Close(Me, BarManager, DockManager, GridView, Xuc_Settings, True)
    End Function

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub Frm_Purchase_Orders_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub Btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub Frm_Purchase_Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Procedures.Initialize_GridView(GridView_Items, True, True)

        GridView_Items.RestoreLayoutFromRegistry(GridView_Items.Name)
    End Sub

    Private Sub Frm_Purchase_Orders_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Xuc_Settings.Check_Auto_Initialize.Checked Then Xuc_SPA_Purchase_Orders.Control_Initialize()
        If Xuc_Settings.Check_Auto_Reload.Checked Then Data_Load("LOAD")

        Xuc_SPA_Purchase_Orders.Order_Date.EditValue = class_Tools.RegKeyGet(Me.Name, Xuc_SPA_Purchase_Orders.Order_Date.Name, Date.Today)

        class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit_Branch)
        class_Saga_Procedures.Initialize_Brand(RepositoryItemLookUpEdit_Brand_Code)
        class_Saga_Procedures.Initialize_Model_Color(RepositoryItemLookUpEdit_Category)
    End Sub

    Private Sub Btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Initialize.ItemClick
        Me.Xuc_SPA_Purchase_Orders.Control_Initialize()

        class_Saga_Variables.Initialize_MC_Models(Xuc_SPA_Purchase_Orders.Brand.Text.Trim, True)
        class_Saga_Procedures.Initialize_MC_Model(RepositoryItemLookUpEdit_Parts_Number, "Model_Code")
        class_Saga_Procedures.Initialize_MC_Model(RepositoryItemLookUpEdit_Category, "modeldesc")
    End Sub

    Private Sub Data_Load(ByVal sActionType As String)
        Dim Parameters As SqlParameter() = {New SqlParameter("@Action_Type", sActionType)}
        class_Database.Procedure_Retrieve(class_Database.ICSConnection, GridControl, GridView, "Spare_Parts_Purchase_Order", Parameters, "Purchase Orders")
    End Sub

    Private Sub Btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        Data_Load("LOAD")
    End Sub

    'Private Sub Btn_Reload_All_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload_All.ItemClick
    '    Data_Load("LOAD_ALL")
    'End Sub

    'Private Sub Btn_Reload_Modified_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload_Modified.ItemClick
    '    Data_Load("LOAD_MODIFIED")
    'End Sub

    'Private Sub Btn_Reload_Deleted_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload_Deleted.ItemClick
    '    Data_Load("LOAD_DELETED")
    'End Sub

    Private Sub GridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView.PrintInitialize
        class_Procedures.Initialize_Printing(e)
    End Sub

    Private Sub Btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick
        GridView.ShowRibbonPrintPreview()
    End Sub

    Private Sub Btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_New.ItemClick
        Me.Xuc_SPA_Purchase_Orders.Control_New(Xuc_Settings.Check_Clear_New.Checked)
        GridControl_Items.DataSource = Nothing
    End Sub

    Private Sub Btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Save.ItemClick
        If Me.Xuc_SPA_Purchase_Orders.Control_Save() Then
            Save_Item_List()

            If Xuc_Settings.Check_Auto_Reload.Checked Then
                Data_Load("LOAD")
            Else
                'Update_Data_Row()
            End If
        End If
    End Sub

    Private Sub Btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Delete.ItemClick
        Me.Xuc_SPA_Purchase_Orders.Control_Delete()
    End Sub

    Private Sub Data_Show()
        With Xuc_SPA_Purchase_Orders
            .ID.Text = GridView.GetFocusedRowCellDisplayText(colID)
            .Order_Code.Text = GridView.GetFocusedRowCellValue(colOrder_Code)
            .Brand.EditValue = GridView.GetFocusedRowCellValue(colBrand_Code)
            .Order_Date.EditValue = GridView.GetFocusedRowCellValue(colOrder_Date)
            '.Freight_Cost.EditValue = GridView.GetFocusedRowCellValue(colFreight_Cost)
            .Description.Text = GridView.GetFocusedRowCellDisplayText(colOrder_Description)
            .Notes.Text = GridView.GetFocusedRowCellDisplayText(colNotes)
        End With
        Load_Items()
    End Sub

    Private Sub Load_Items()
        class_Saga_Variables.Initialize_MC_Models(Xuc_SPA_Purchase_Orders.Brand.Text.Trim, True)
        class_Saga_Procedures.Initialize_MC_Model(RepositoryItemLookUpEdit_Category, "Model_Code")
        class_Saga_Procedures.Initialize_MC_Model(RepositoryItemLookUpEdit_Parts_Number, "modeldesc")

        class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_Category, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)
        class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_Category, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)
        class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_Parts_Number, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)

        class_Database.BindData(class_Database.ICSConnection, GridControl_Items, GridView_Items, $"Select * FROM Spare_Parts_Purchase_Order WHERE Order_Code LIKE '{Xuc_SPA_Purchase_Orders.Order_Code.EditValue}' ORDER BY ID", "acc_Purchase_Order_Units")
    End Sub

    Private Sub GridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView.FocusedRowChanged
        If Xuc_Settings.Check_Auto_Show.Checked Then Data_Show()
    End Sub

    Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView.KeyDown
        If (GridView.DataRowCount > 0) Then
            Select Case e.KeyValue
                Case Keys.Delete
                    If Xuc_SPA_Purchase_Orders.Control_Delete Then
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
                    'Classes.class_Local_Procedures.Show_Ticket(e.CellValue.ToString)
                Case Else
                    class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                    Data_Show()
            End Select
        End If
    End Sub

    Private Sub GridView_Items_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridView_Items.KeyDown
        With GridView_Items
            Select Case e.KeyCode
                Case Keys.Insert
                    .AddNewRow()

                Case Keys.Delete
                    'class_Saga_Database.Transaction_Delete(GridView, "Journal Entry/Entries", "acc_Journal_Procedures", "DELETE")
            End Select
        End With
    End Sub

    Private Sub RepositoryItemLookUpEdit_Branch_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit_Branch.EditValueChanged
        Try
            sBrCode = CType(sender, BaseEdit).EditValue.ToString
        Catch Ex As Exception
        End Try
    End Sub

    Private Sub RepositoryItemLookUpEdit_Model_Code_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit_Category.EditValueChanged
        Try
            sModelCode = CType(sender, BaseEdit).EditValue.ToString
        Catch Ex As Exception
        End Try
    End Sub

    Private Sub RepositoryItemLookUpEdit_Model_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit_Category.EditValueChanged
        Try
            sModelName = CType(sender, BaseEdit).EditValue.ToString
        Catch Ex As Exception
        End Try
    End Sub

    Private Sub RepositoryItemLookUpEdit_Model_Code_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_Category.Validating
        Try
            Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
            sModelName = editor.GetColumnValue("Model_Name")
            GridView_Items.SetFocusedRowCellValue(colParts_Number, sModelCode)

            sColor = editor.GetColumnValue("Color")
            GridView_Items.SetFocusedRowCellValue(colCategory, sColor)

            dUnitCost = CDec(editor.GetColumnValue("Unit_Cost"))
            GridView_Items.SetFocusedRowCellValue(colUnit_Cost, dUnitCost)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepositoryItemSpinEdit_Quantity_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemSpinEdit_Quantity.EditValueChanged
        Try
            iQuantity = CType(sender, BaseEdit).EditValue
        Catch Ex As Exception
        End Try
    End Sub

    'Private Sub RepositoryItemCalcEdit_Freight_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemCalcEdit_Freight.EditValueChanged
    '    Try
    '        dFreight = CType(sender, BaseEdit).EditValue
    '    Catch Ex As Exception
    '    End Try
    'End Sub

    Private Sub GridView_Items_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView_Items.CellValueChanged
        Try
            With GridView_Items
                Select Case e.Column.Name
                    Case "colQuantity", "colFreight_Cost2"
                        'Dim dTotalCost As Decimal = .GetFocusedRowCellValue(colUnit_Cost) * .GetFocusedRowCellValue(colQuantity)
                        'Dim dGrandTotal As Decimal = (.GetFocusedRowCellValue(colUnit_Cost) + .GetFocusedRowCellValue(colFreight_Cost2)) * .GetFocusedRowCellValue(colQuantity)
                        '.SetRowCellValue(e.RowHandle, colTotal_Cost2, dTotalCost)
                        '.SetRowCellValue(e.RowHandle, colGrand_Total2, dGrandTotal)

                    Case "colUnit_Cost"
                        dUnitCost = .GetFocusedRowCellValue(colUnit_Cost)
                End Select
            End With
        Catch Ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub

    Private Sub GridView_Items_InitNewRow(sender As Object, e As Grid.InitNewRowEventArgs) Handles GridView_Items.InitNewRow
        Dim view As Grid.GridView = TryCast(sender, Grid.GridView)

        'view.SetRowCellValue(e.RowHandle, colBranch_Code, sBrCode)
        'view.SetRowCellValue(e.RowHandle, colModel_Code, sModelCode)
        'view.SetRowCellValue(e.RowHandle, colModel_Name, sModelCode)
        'view.SetRowCellValue(e.RowHandle, colUnit_Color, sColor)
        'view.SetRowCellValue(e.RowHandle, colUnit_Cost, dUnitCost)
        'view.SetRowCellValue(e.RowHandle, colFreight_Cost2, dFreight)

        view.BestFitColumns()
    End Sub

    Private Sub GridView_Items_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView_Items.FocusedRowChanged
        GridView_Items.BestFitColumns()
    End Sub

    Private Sub Btn_Unit_Order_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Unit_Order_Reload.ItemClick
        Load_Items()
    End Sub

    Private Sub Btn_Unit_Order_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Unit_Order_Add.ItemClick
        GridView_Items.AddNewRow()
    End Sub

    Private Sub Save_Item_List()
        With GridView_Items
            If .DataRowCount > 0 Then
                For i As Integer = 0 To .DataRowCount - 1
                    Dim iID As Integer
                    Try
                        If .GetRowCellValue(i, colID).Equals(Nothing) Then Return
                        Try
                            iID = .GetRowCellValue(i, colID)
                        Catch ex As Exception
                            iID = 0
                        End Try

                        Dim UnitParameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                                New SqlParameter("@Order_Code", Xuc_SPA_Purchase_Orders.Order_Code.Text),
                                                                New SqlParameter("@Unit_Cost", .GetRowCellValue(i, colUnit_Cost)),
                                                                New SqlParameter("@Quantity", .GetRowCellValue(i, colQuantity)),
                                                                New SqlParameter("@Unit_Description", .GetRowCellDisplayText(i, colUnit_Description)),
                                                                New SqlParameter("@Notes", .GetRowCellDisplayText(i, colNotes2)),
                                                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                                New SqlParameter("@Action_Type", "SAVE_ITEM")}
                        class_Database.Procedure_Save(class_Database.ICSConnection, "Purchase Item Unit", "acc_Purchase_Order_Procedures", UnitParameters)
                    Catch Ex As Exception
                        class_Procedures.Show_Error(Ex)
                    End Try
                Next

                Dim Parameters As SqlParameter() = {New SqlParameter("@Order_Code", Xuc_SPA_Purchase_Orders.Order_Code.EditValue),
                                                    New SqlParameter("@Action_Type", "UPDATE")}
                class_Database.Procedure_Save(class_Database.ICSConnection, "Update Purchase Order Profile", "acc_Purchase_Order_Procedures", Parameters)
            End If
        End With
    End Sub

    'Private Sub Btn_Unit_Order_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Unit_Order_Preview.ItemClick
    '    If class_Procedures.isEmpty(Xuc_Purchase_Order.Order_Code) Then Return

    '    Dim xRpt As New Reports.Logistics.xrpt_Purchase_Orders()
    '    class_Database.BindData(class_Database.ICSConnection, xRpt, $"SELECT * FROM view_Purchase_Orders WHERE Order_Code LIKE '{Xuc_Purchase_Order.Order_Code.EditValue}' ORDER BY Model_Name", "TransactionPettyCash")

    '    Try
    '        With xRpt
    '            .PaperKind = System.Drawing.Printing.PaperKind.Custom
    '            .PageWidth = 850
    '            .PageHeight = 1300

    '            .XrTableCell_Brand.Text = Xuc_Purchase_Order.Brand_Code.Text
    '            .XrTableCell_Dealer.Text = Xuc_Purchase_Order.Supplier_Name.Text
    '            .XrTableCell_Address.Text = Xuc_Purchase_Order.Brand_Code.GetColumnValue("Account_Address")

    '            .XrTableCell_Purchase_Order_Code.Text = Xuc_Purchase_Order.Order_Code.EditValue.ToString
    '            .XrTableCell_Order_Date.Text = Xuc_Purchase_Order.Order_Date.Text

    '            .XrL_Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
    '        End With
    '    Catch Ex As Exception
    '        class_Procedures.Show_Error(Ex)
    '    End Try
    'End Sub

    'Private Sub Btn_Modify_Orders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Modify_Orders.ItemClick
    '    If Xuc_SPA_Purchase_Order.Control_Modify(GridView.GetFocusedRowCellValue(colID)) Then
    '        Xuc_SPA_Purchase_Order.Control_New(Xuc_Settings.Check_Clear_New.Checked, True)
    '    End If
    'End Sub

    'Private Sub Btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Approve.ItemClick
    '    Dim Parameters As SqlParameter() = {New SqlParameter("@ID", GridView.GetFocusedRowCellValue(colID)),
    '                                        New SqlParameter("@Modified_By", class_Variables.sUserName),
    '                                        New SqlParameter("@Action_Type", "APPROVE")}
    '    class_Database.Procedure_Save(class_Database.ICSConnection, "Approve Purchase Order", "acc_Purchase_Order_Procedures", Parameters, Xuc_Purchase_Order.Order_Code.EditValue.ToString)

    '    If Xuc_Settings.Check_Auto_Reload.Checked Then Data_Load("LOAD")
    'End Sub
End Class

