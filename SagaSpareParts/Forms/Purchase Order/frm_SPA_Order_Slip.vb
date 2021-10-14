Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.DataAccess.Excel
Imports DevExpress.SpreadsheetSource

Public Class frm_SPA_Order_Slip
    Dim sBrCode, sBrand, sCategory, sPartNumber, sPartName, sType As String
    Dim iQuantity, iCartons, iBatch_Id, iId_Initial As Integer
    Dim dSRP, dRebates As Decimal
    Dim dUnitCost As Decimal = 0

    Public Sub New()
        If Me.Xuc_Order_Slip Is Nothing Then
            Me.Xuc_Order_Slip = Xuc_Order_Slip()
        End If

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, GridView, BtnCancel, Xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Function Form_Close() As Boolean
        GridView_Items.SaveLayoutToRegistry(GridView_Items.Name)
        Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
    End Function

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub Frm_Purchase_Orders_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub Frm_Purchase_Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Procedures.Initialize_GridView(GridView_Items, True, True)

        GridView_Items.RestoreLayoutFromRegistry(GridView_Items.Name)
    End Sub

    Private Sub Frm_Purchase_Orders_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Xuc_Settings.Toggle_Auto_Initialize.IsOn Then Xuc_Order_Slip.Control_Initialize()
        If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD", class_Saga_Variables.sBranchCode)

        Xuc_Order_Slip.Order_Date.EditValue = class_Tools.RegKeyGet(Me.Name, Xuc_Order_Slip.Order_Date.Name, CStr(Date.Now()))

    End Sub

    Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
        Xuc_Order_Slip.Control_Initialize()
        'Load_Items()
    End Sub

    Private Sub Data_Load(ByVal sActionType As String, ByVal sBranchCode As String)
        Dim Parameters As SqlParameter() = {New SqlParameter("@Action_Type", sActionType),
                                            New SqlParameter("@Branch_Code", sBranchCode)}
        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, gridControl, GridView, "spa_Spare_Parts_Order_Slip_Procedures", "Stock Replenishment Form")
    End Sub

    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Data_Load("LOAD", class_Saga_Variables.sBranchCode)
    End Sub

    Private Sub btn_Reload_All_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_All.ItemClick
        Data_Load("LOAD_ALL", class_Saga_Variables.sBranchCode)
    End Sub

    Private Sub btn_Reload_Modified_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Modified.ItemClick
        Data_Load("LOAD_MODIFIED", class_Saga_Variables.sBranchCode)
    End Sub

    Private Sub btn_Reload_Deleted_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Deleted.ItemClick
        Data_Load("LOAD_DELETED", class_Saga_Variables.sBranchCode)
    End Sub

    Private Sub GridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView.PrintInitialize
        class_Procedures.Initialize_Printing(e)
    End Sub

    Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        GridView.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
        Me.Xuc_Order_Slip.Control_New(Xuc_Settings.Toggle_Clear_On_Action.IsOn)
        gridControl_Items.DataSource = Nothing
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        If Me.Xuc_Order_Slip.Control_Save() Then
            Save_Item_List()

            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load("LOAD", class_Saga_Variables.sBranchCode)
            Else
                'Update_Data_Row()
            End If
        End If
    End Sub

    Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
        Me.Xuc_Order_Slip.Control_Delete()
    End Sub

    Private Sub Data_Show()
        With Xuc_Order_Slip
            .ID.Text = GridView.GetFocusedRowCellDisplayText(colID)
            .Requested_Branch.Text = CStr(GridView.GetFocusedRowCellValue(colBranch_From))
            .Brand.Text = CStr(GridView.GetFocusedRowCellValue(colBrand1))
            .Order_C0de.Text = CStr(GridView.GetFocusedRowCellValue(colReference))
            .Order_Date.EditValue = GridView.GetFocusedRowCellValue(colTransaction_Date)
            .Description.Text = GridView.GetFocusedRowCellDisplayText(colSKU_Description)
            .Notes.Text = GridView.GetFocusedRowCellDisplayText(colNotes)
        End With
        Load_Items()
    End Sub

    Private Sub Load_Items()
        Initialize_Part_Number(Xuc_Order_Slip.Brand.GetColumnValue("branddesc").ToString)
        Initialize_Part_Number(RepositoryItemLookUpEdit_Parts_Number)
        class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_Parts_Number, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)
        class_Database.Bind_Data(class_Database.SPAConnection, gridControl_Items, GridView_Items, $"SELECT * FROM Spare_Parts_Order_Slip_Items WHERE Order_Code LIKE '{Xuc_Order_Slip.Order_C0de.EditValue}' ORDER BY Itemid", "Spare_Parts_Order_Slip_Items")
        class_Procedures.Initialize_GridView(GridView_Items, True, True)
    End Sub

    Private Sub GridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView.FocusedRowChanged
        If Xuc_Settings.Toggle_Select.IsOn Then Data_Show()
    End Sub

    Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView.KeyDown
        If (GridView.DataRowCount > 0) Then
            Select Case e.KeyValue
                Case Keys.Delete
                    If Xuc_Order_Slip.Control_Delete Then
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
            Dim sTatus As String = GridView.GetFocusedRowCellDisplayText(colStatus)
            btn_Approval.Enabled = sTatus.Equals("PENDING") Or sTatus.Equals("DISAPPROVED")
            btn_Disapprove.Enabled = sTatus.Equals("FOR APPROVAL")
            btn_Approve.Enabled = sTatus.Equals("FOR APPROVAL")
            PopupMenu.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub GridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        If e.Clicks.Equals(2) AndAlso GridView.DataRowCount > 0 Then
            Select Case e.Column.FieldName
                Case "supplier_code"
                Case Else
                    'class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                    Data_Show()
                    Load_Items()
            End Select
        End If
    End Sub
    Private Sub GridView_Items_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        With GridView_Items
            Select Case e.KeyCode
                Case Keys.Insert
                    .AddNewRow()

                Case Keys.Delete
                    If (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                    Dim view As GridView = CType(sender, GridView)
                    view.DeleteRow(view.FocusedRowHandle)
            End Select
        End With
    End Sub

    Private Sub RepositoryItemLookUpEdit_Parts_Number_EditValueChanged(sender As Object, e As EventArgs)
        Try
            sPartNumber = CType(sender, BaseEdit).EditValue.ToString
        Catch Ex As Exception
        End Try
    End Sub

    Private Sub RepositoryItemLookUpEdit_Parts_Number_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_Parts_Number.Validating
        Try
            Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)

            sPartName = editor.GetColumnValue("PartsName").ToString()
            GridView_Items.SetFocusedRowCellValue(colParts_Name, sPartName)

            sCategory = editor.GetColumnValue("Category_Code").ToString
            GridView_Items.SetFocusedRowCellValue(colCategory, sCategory)

            dSRP = CDec(editor.GetColumnValue("SRP"))
            GridView_Items.SetFocusedRowCellValue(colSRP, dSRP)

            iQuantity = 0
            GridView_Items.SetFocusedRowCellValue(colQuantity_Order, iQuantity)

            dRebates = 0
            GridView_Items.SetFocusedRowCellValue(colRebates, dRebates)

            dUnitCost = CDec(editor.GetColumnValue("PriceWOVAT"))
            GridView_Items.SetFocusedRowCellValue(colUnit_Cost, dUnitCost)

            iId_Initial = 0
            GridView_Items.SetFocusedRowCellValue(colID2, iId_Initial)

            Dim iSalesdDays = Date.Today.AddDays(-60)
            Dim iSalesCount, iInventory As Integer
            iSalesCount = Convert.ToInt32(class_Database.Get_Data(class_Database.SPAConnection, $"SELECT SUM(Quantity) AS Quantity FROM Transaction_Collection WHERE PartsNumber LIKE '{sPartNumber}' AND PostingDate >= '{iSalesdDays}' AND ErrorCorrectTag <> 1", "Quantity"))
            GridView_Items.SetFocusedRowCellValue(colSalesSum, iSalesCount)

            iInventory = Convert.ToInt32(class_Database.Get_Data(class_Database.SPAConnection, $"SELECT SUM(Quantity) AS Quantity FROM SPA_Inventory WHERE PartsNumber LIKE '{sPartNumber}' and ReceivingBranch LIKE '{class_Saga_Variables.sBranchCode}'", "Quantity"))
            GridView_Items.SetFocusedRowCellValue(colInventory, iInventory)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepositoryItemSpinEdit_Quantity_EditValueChanged(sender As Object, e As EventArgs)
        Try
            iQuantity = Convert.ToInt32(CType(sender, BaseEdit).EditValue)
        Catch Ex As Exception
        End Try
    End Sub

    Private Sub GridView_Items_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView_Items.CellValueChanged
        Try
            With GridView_Items
                Select Case e.Column.Name
                    Case "colQuantity_Order", "colRebates"
                        Dim dTotalCost As Decimal = CDec(.GetFocusedRowCellValue(colUnit_Cost)) * Convert.ToInt32(.GetFocusedRowCellValue(colQuantity_Order))
                        Dim dTotalSRP As Decimal = CDec(.GetFocusedRowCellValue(colSRP)) * Convert.ToInt32(.GetFocusedRowCellValue(colQuantity_Order))
                        Dim dTotalRebates As Decimal = CDec(.GetFocusedRowCellValue(colRebates)) * Convert.ToInt32(.GetFocusedRowCellValue(colQuantity_Order))
                        Dim dNetProfit As Decimal = dTotalSRP - dTotalCost + dTotalRebates
                        .SetRowCellValue(e.RowHandle, colTotal_Cost2, CDbl(dTotalCost))
                        .SetRowCellValue(e.RowHandle, colTotal_SRP, CDbl(dTotalSRP))
                        .SetRowCellValue(e.RowHandle, colTotal_Rebates, CDbl(dTotalRebates))
                        .SetRowCellValue(e.RowHandle, colNet_Profit, CDbl(dNetProfit))
                    Case "colUnit_Cost"
                        dUnitCost = CDec(.GetFocusedRowCellValue(colUnit_Cost))
                End Select
            End With
        Catch Ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub

    Private Sub GridView_Items_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        GridView_Items.BestFitColumns()
    End Sub

    Private Function GetExcelDataSource(ByVal sFileName As String) As ExcelDataSource
        Try
            Dim ds As New ExcelDataSource With {.FileName = sFileName}
            Dim excelSourceOptions As New ExcelSourceOptions()
            Dim excelWorksheetSettings As New ExcelWorksheetSettings With {
                    .WorksheetName = GetWorkSheetNameByIndex(sFileName, XtraInputBox.Show("Input sheet number", "Import Beginning Balances", 0))
                }
            excelSourceOptions.ImportSettings = excelWorksheetSettings

            Dim fieldID2 As FieldInfo = New FieldInfo With {
                    .Name = "Itemid",
                    .Type = GetType(String)
                }
            Dim fieldParts_Number As FieldInfo = New FieldInfo With {
                    .Name = "Parts_Number",
                    .Type = GetType(String)
                }
            Dim fieldParts_Name As FieldInfo = New FieldInfo With {
                    .Name = "Parts_Name",
                    .Type = GetType(String)
                }
            Dim fieldCategory As FieldInfo = New FieldInfo With {
                    .Name = "Category",
                    .Type = GetType(String)
                }
            Dim fieldQuantity_Order As FieldInfo = New FieldInfo With {
                    .Name = "Quantity_Order",
                    .Type = GetType(Integer)
                }
            Dim fieldSalesSum As FieldInfo = New FieldInfo With {
                    .Name = "Sales_Summary",
                    .Type = GetType(Integer)
                }
            Dim fieldInventory As FieldInfo = New FieldInfo With {
                    .Name = "Remaining_Inventory",
                    .Type = GetType(Integer)
                }
            Dim fieldRebates As FieldInfo = New FieldInfo With {
                    .Name = "Rebates",
                    .Type = GetType(Double)
                }
            Dim fieldUnit_Cost As FieldInfo = New FieldInfo With {
                    .Name = "Cost",
                    .Type = GetType(Double)
                }
            Dim fieldSRP As FieldInfo = New FieldInfo With {
                    .Name = "SRP",
                    .Type = GetType(Double)
                }
            Dim fieldNet_Profit As FieldInfo = New FieldInfo With {
                    .Name = "Net_Profit",
                    .Type = GetType(Double)
                }
            Dim fieldTotal_Cost2 As FieldInfo = New FieldInfo With {
                    .Name = "Total_Cost",
                    .Type = GetType(Double)
                }
            Dim fieldcolTotal_SRP As FieldInfo = New FieldInfo With {
                    .Name = "Total_SRP",
                    .Type = GetType(Double)
                }
            Dim fieldTotal_Rebates As FieldInfo = New FieldInfo With {
                    .Name = "Total_Rebates",
                    .Type = GetType(Double)
                }
            Dim fieldUnit_Description As FieldInfo = New FieldInfo With {
                    .Name = "Unit_Description",
                    .Type = GetType(String)
                }
            Dim fieldNotes2 As FieldInfo = New FieldInfo With {
                    .Name = "Notes",
                    .Type = GetType(String)
                }
            Dim fieldAdded_By2 As FieldInfo = New FieldInfo With {
                    .Name = "Added_By",
                    .Type = GetType(String)
                }

            ds.Schema.AddRange(New FieldInfo() {fieldID2, fieldParts_Number, fieldParts_Name, fieldParts_Name, fieldCategory,
                                                fieldQuantity_Order, fieldSalesSum, fieldInventory, fieldRebates, fieldUnit_Cost,
                                                fieldSRP, fieldNet_Profit, fieldTotal_Cost2, fieldcolTotal_SRP, fieldTotal_Rebates,
                                                fieldUnit_Description, fieldNotes2, fieldAdded_By2})
            ds.SourceOptions = excelSourceOptions
            ds.Fill()
            Return ds
        Catch Ex As System.IO.IOException
            class_Procedures.Show_Error(Ex)
        End Try
        Return Nothing
    End Function

    Private Function GetWorkSheetNameByIndex(ByVal sFileName As String, ByVal p As Integer) As String
        Try
            Using spreadsheetSource As ISpreadsheetSource = SpreadsheetSourceFactory.CreateSource(sFileName)
                Dim worksheetCollection As IWorksheetCollection = spreadsheetSource.Worksheets
                Return worksheetCollection(p).Name
            End Using
        Catch Ex As System.IO.IOException
            class_Procedures.Show_Error(Ex)
        Catch Ex As ArgumentOutOfRangeException
            class_Procedures.Show_Error(Ex)
        End Try
        Return Nothing
    End Function
    Private Sub btn_Unit_Order_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unit_Order_Add.ItemClick
        Dim openFileDialog As New OpenFileDialog With {
       .RestoreDirectory = True,
       .Filter = "SKU Imports (xlsx)|*.xlsx|SKU Imports (xls)|*.xls"
       }
        If openFileDialog.ShowDialog().Equals(DialogResult.OK) Then
            Try
                gridControl_Items.DataSource = GetExcelDataSource(openFileDialog.FileName)
            Catch Ex As IO.FileNotFoundException
                class_Procedures.Show_Error(Ex)
            Finally
                GridView.BestFitColumns()
            End Try
        End If
    End Sub

    Private Sub Save_Item_List()
        With GridView_Items
            If .DataRowCount > 0 Then
                For i As Integer = 0 To .DataRowCount - 1
                    Dim iID As Integer
                    Try
                        If .GetRowCellValue(i, colID2).Equals(Nothing) Then Return
                        Try
                            iID = Convert.ToInt32(.GetRowCellValue(i, colID2))
                        Catch ex As Exception
                            iID = 0
                        End Try
                        Dim UnitParameters As SqlParameter() = {New SqlParameter("@Itemid", .GetRowCellValue(i, colID2)),
                                                                New SqlParameter("@Order_Code", Xuc_Order_Slip.Order_C0de.EditValue),
                                                                New SqlParameter("@SubDealer_Code", Xuc_Order_Slip.SubDealer_Name.GetColumnValue("SubDealer_Code")),
                                                                New SqlParameter("@Order_Date", Xuc_Order_Slip.Order_Date.EditValue),
                                                                New SqlParameter("@Parts_Number", .GetRowCellValue(i, colParts_Number)),
                                                                New SqlParameter("@Parts_Name", .GetRowCellValue(i, colParts_Name)),
                                                                New SqlParameter("@Brand", Xuc_Order_Slip.Brand.EditValue),
                                                                New SqlParameter("@Category_Code", .GetRowCellValue(i, colCategory)),
                                                                New SqlParameter("@Quantity_Order", .GetRowCellValue(i, colQuantity_Order)),
                                                                New SqlParameter("@Sales_Summary", .GetRowCellValue(i, colSalesSum)),
                                                                New SqlParameter("@Inventory_Count", .GetRowCellValue(i, colInventory)),
                                                                New SqlParameter("@Rebates", .GetRowCellValue(i, colRebates)),
                                                                New SqlParameter("@SRP", .GetRowCellValue(i, colSRP)),
                                                                New SqlParameter("@Cost", .GetRowCellValue(i, colUnit_Cost)),
                                                                New SqlParameter("@Net_Profit", .GetRowCellValue(i, colNet_Profit)),
                                                                New SqlParameter("@Order_Description", .GetRowCellValue(i, colUnit_Description)),
                                                                New SqlParameter("@Notes", .GetRowCellValue(i, colNotes2)),
                                                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                                New SqlParameter("@Action_Type", "SAVE_ITEM")}
                        class_Database.Procedure_Save(class_Database.SPAConnection, UnitParameters, "spa_Spare_Parts_Order_Slip_Procedures", "Purchase Item Unit")
                    Catch Ex As Exception
                    End Try
                Next

                Dim Parameters As SqlParameter() = {New SqlParameter("@Reference", Xuc_Order_Slip.Order_C0de.EditValue),
                                                    New SqlParameter("@Action_Type", "UPDATE")}
                class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "spa_Spare_Parts_Order_Slip_Procedures", "Update Purchase Order Profile")
            End If
        End With
    End Sub

    Private Sub btn_Unit_Order_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        If class_Procedures.isEmpty(Xuc_Order_Slip.Order_C0de) Then Return

        Dim xRpt As New SagaSpareParts.xrpt_SPA_Order_Slip()
        class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM Spare_Parts_Order_Slip_Items WHERE Order_Code LIKE '{Xuc_Order_Slip.Order_C0de.EditValue}' ORDER BY Parts_Number", "Spare_Parts_Order_Slip_Items")

        Try
            With xRpt
                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 850
                .PageHeight = 1100

                .XrTableCell_Branch.Text = class_Saga_Database.get_Branch_Name(class_Saga_Variables.sBranchCode)
                .XrTableCell_Address.Text = get_Branch_Address(class_Saga_Variables.sBranchCode)

                .XrTableCell_Reference.Text = Xuc_Order_Slip.Order_C0de.EditValue.ToString
                .XrTableCell_Transaction_Date.Text = Xuc_Order_Slip.Order_Date.Text

                .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
            End With
        Catch Ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub

    Private Sub btn_Modify_Orders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Modify_Orders.ItemClick
        If Xuc_Order_Slip.Control_Modify(Convert.ToInt32(GridView.GetFocusedRowCellValue(colID))) Then
            Xuc_Order_Slip.Control_New(Xuc_Settings.Toggle_Clear_On_Action.IsOn, True)
        End If
    End Sub
    Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
        Dim Parameters As SqlParameter() = {New SqlParameter("@orderid", GridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "APPROVAL")}
        If class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "spa_Spare_Parts_Order_Slip_Procedures", "Send Stock Replenishment Form For Approval", Xuc_Order_Slip.Order_C0de.EditValue.ToString) Then
            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD", class_Saga_Variables.sBranchCode)
        End If
    End Sub

    Private Sub btn_DisApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Disapprove.ItemClick
        Dim Parameters As SqlParameter() = {New SqlParameter("@orderid", GridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "DISAPPROVE")}
        If class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "spa_Spare_Parts_Order_Slip_Procedures", "Disapprove/Reject Stock Replenishment Form", Xuc_Order_Slip.Order_C0de.EditValue.ToString) Then
            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD", class_Saga_Variables.sBranchCode)
        End If
    End Sub

    Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
        Dim Parameters As SqlParameter() = {New SqlParameter("@orderid", GridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "APPROVE")}
        If class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "spa_Spare_Parts_Order_Slip_Procedures", "Approve Stock Replenishment Form", Xuc_Order_Slip.Order_C0de.EditValue.ToString) Then
            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD", class_Saga_Variables.sBranchCode)
        End If
    End Sub
End Class
