Imports DevExpress.DataAccess.Excel
Imports DevExpress.SpreadsheetSource
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class frm_SPA_Purchase_Orders
    Dim iQuantity, iCartons As Integer
    Dim dSRP, dRebates As Decimal
    Dim dUnitCost As Decimal = 0
    Friend sBalanceType As String

    Dim sCategory, sPartNumber, sPartName As String

    Private Function GetExcelDataSource(ByVal sFileName As String) As ExcelDataSource
        Try
            Dim ds As New ExcelDataSource With {.FileName = sFileName}
            Dim excelSourceOptions As New ExcelSourceOptions()
            Dim excelWorksheetSettings As New ExcelWorksheetSettings With {
                    .WorksheetName = GetWorkSheetNameByIndex(sFileName, XtraInputBox.Show("Input sheet number", "Import Beginning Balances", 0))
                }
            excelSourceOptions.ImportSettings = excelWorksheetSettings

            Dim fieldID2 As FieldInfo = New FieldInfo With {
                    .Name = "ID",
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
    Private Sub btn_Import_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Import.ItemClick
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

    Private Sub gridView_Items_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView_Items.MouseDown
        If e.Button.Equals(MouseButtons.Right) Then
            PopupMenu.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub gridView_Items_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView_Items.RowCellClick
        If (gridView_Items.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
            If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)
        End If
    End Sub
    Public Sub New()
        If Me.Xuc_SPA_Purchase_Orders Is Nothing Then
            Me.Xuc_SPA_Purchase_Orders = Xuc_SPA_Purchase_Orders()
        End If

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, gridView_Items, BtnCancel, Xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Function Form_Close() As Boolean
        gridView.SaveLayoutToRegistry(gridView.Name)
        gridView_Items.RestoreLayoutFromRegistry(gridView_Items.Name)

        'class_Tools.RegKeySet(Me.Name,
        '                      Xuc_SPA_Purchase_Orders.Order_Date.Name,
        '                      Xuc_SPA_Purchase_Orders.Order_Date.EditValue)

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
        class_Procedures.Initialize_gridView(gridView_Items, True, True)

        gridView_Items.RestoreLayoutFromRegistry(gridView_Items.Name)
    End Sub

    Private Sub Frm_Purchase_Orders_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        class_Procedures.Initialize_gridView(gridView)
        If Xuc_Settings.Toggle_Auto_Initialize.ison Then Xuc_SPA_Purchase_Orders.Control_Initialize()
        If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD")

        Xuc_SPA_Purchase_Orders.Order_Date.EditValue = class_Tools.RegKeyGet(Me.Name, Xuc_SPA_Purchase_Orders.Order_Date.Name, CStr(Date.Today))

        class_Saga_Procedures.Initialize_Brand(RepositoryItemLookUpEdit_Brand_Code)
    End Sub

    Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
        Xuc_SPA_Purchase_Orders.Control_Initialize()
        Load_Items()
    End Sub

    Private Sub Data_Load(ByVal sActionType As String)
        Dim sqlParameters As SqlParameter() = {New SqlParameter("@Action_Type", sActionType)}
        class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, gridView, "spa_Purchase_Order_Procedures", "Purchase Orders")
    End Sub

    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Data_Load("LOAD")
    End Sub

    Private Sub btn_Reload_All_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_All.ItemClick
        Data_Load("LOAD_ALL")
    End Sub

    Private Sub btn_Reload_Modified_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Modified.ItemClick
        Data_Load("LOAD_MODIFIED")
    End Sub

    Private Sub btn_Reload_Deleted_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Deleted.ItemClick
        Data_Load("LOAD_DELETED")
    End Sub

    Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
        class_Procedures.Initialize_Printing(e)
    End Sub

    Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        gridView.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
        Me.Xuc_SPA_Purchase_Orders.Control_New(Xuc_Settings.Toggle_Clear_On_Action.IsOn)
        gridControl_Items.DataSource = Nothing
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        If Me.Xuc_SPA_Purchase_Orders.Control_Save() Then
            Save_Item_List()

            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load("LOAD")
            Else
                'Update_Data_Row()
            End If
        End If
    End Sub

    Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
        Me.Xuc_SPA_Purchase_Orders.Control_Delete()
    End Sub

    Private Sub Data_Show()
        With Xuc_SPA_Purchase_Orders
            .ID.Text = gridView.GetFocusedRowCellDisplayText(colID)
            .Order_Type.Text = gridView.GetFocusedRowCellDisplayText(colOrder_Type)
            .Order_C0de.Text = CStr(gridView.GetFocusedRowCellValue(colOrder_Code))
            .Brand.EditValue = gridView.GetFocusedRowCellValue(colBrand_Code)
            .Order_Date.EditValue = gridView.GetFocusedRowCellValue(colOrder_Date)
            .Description.Text = gridView.GetFocusedRowCellDisplayText(colOrder_Description)
            .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
        End With
        Load_Items()
    End Sub

    Private Sub Load_Items()
        Initialize_Part_Number(Xuc_SPA_Purchase_Orders.Brand.Text)
        Initialize_Part_Number(RepositoryItemLookUpEdit_Parts_Number)
        class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_Parts_Number, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)

        Dim sTatus As String = gridView.GetFocusedRowCellDisplayText(colOrder_Status)
        Dim Type As String = gridView.GetFocusedRowCellDisplayText(colOrder_Type)
        If sTatus.Equals("FOR ENDORSEMENT") Or sTatus.Equals("FOR ENDORSEMENT") Or sTatus.Equals("APPROVED") Then
            class_Procedures.Initialize_gridView(gridView_Items, False, False)
        Else
            class_Procedures.Initialize_gridView(gridView_Items, True, True)
        End If
        If Type.Equals("SUB-DEALER") Then
            Load_Order()
        Else
            Load_Retail()
        End If

    End Sub
    Private Sub Load_Order()
        Dim sTatus As String = gridView.GetFocusedRowCellDisplayText(colOrder_Status)
        If sTatus.Equals("PENDING") Then
            class_Database.Bind_Data(class_Database.SPAConnection, gridControl_Items, gridView_Items, $"SELECT * FROM Spare_Parts_Order_Slip_Items WHERE Order_Code LIKE '{Xuc_SPA_Purchase_Orders.Order_C0de.EditValue}' ORDER BY Itemid", "Spare_Parts_Order_Slip_Items")
        Else
            class_Database.Bind_Data(class_Database.SPAConnection, gridControl_Items, gridView_Items, $"SELECT * FROM Spare_Parts_Purchase_Order_Items WHERE Order_Code LIKE '{Xuc_SPA_Purchase_Orders.Order_C0de.EditValue}' ORDER BY ID", "Spare_Parts_Purchase_Order_Items")
        End If
    End Sub
    Private Sub Load_Retail()
        Dim sTatus As String = gridView.GetFocusedRowCellDisplayText(colOrder_Status)
        If sTatus.Equals("PENDING") Then
            class_Database.Bind_Data(class_Database.SPAConnection, gridControl_Items, gridView_Items, $"SELECT * FROM Spare_Parts_Request_Items WHERE Reference LIKE '{Xuc_SPA_Purchase_Orders.Order_C0de.EditValue}' ORDER BY ID", "Spare_Parts_Request_Items")
        Else
            class_Database.Bind_Data(class_Database.SPAConnection, gridControl_Items, gridView_Items, $"SELECT * FROM Spare_Parts_Purchase_Order_Items WHERE Order_Code LIKE '{Xuc_SPA_Purchase_Orders.Order_C0de.EditValue}' ORDER BY ID", "Spare_Parts_Purchase_Order_Items")
        End If
    End Sub

    Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        If Xuc_Settings.Toggle_Select.IsOn Then Data_Show()
    End Sub

    Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If (gridView.DataRowCount > 0) Then
            Select Case e.KeyValue
                Case Keys.Delete
                    If Xuc_SPA_Purchase_Orders.Control_Delete Then
                        Try
                            gridView.DeleteSelectedRows()
                        Catch ex As Exception
                            class_Procedures.Show_Error(Ex)
                        End Try
                    End If
            End Select
        End If
    End Sub

    Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
        If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
            Dim sTatus As String = gridView.GetFocusedRowCellDisplayText(colOrder_Status)
            btn_Verify.Enabled = sTatus.Equals("PENDING") Or sTatus.Equals("DISAPPROVED")
            btn_Endorse.Enabled = sTatus.Equals("FOR VERIFICATION")
            btn_Disapprove.Enabled = sTatus.Equals("FOR APPROVAL") Or sTatus.Equals("FOR ENDORSEMENT") Or sTatus.Equals("FOR VERIFICATION")
            btn_Approve.Enabled = sTatus.Equals("FOR ENDORSEMENT")
            PopupMenu.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
        If e.Clicks.Equals(2) AndAlso gridView.DataRowCount > 0 Then
            Select Case e.Column.FieldName
                Case "supplier_code"
                Case Else
                    class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                    Data_Show()
            End Select
        End If
    End Sub

    Private Sub RepositoryItemLookUpEdit_Parts_Number_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit_Parts_Number.EditValueChanged
        Try
            sPartNumber = CType(sender, BaseEdit).EditValue.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RepositoryItemLookUpEdit_Parts_Number_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_Parts_Number.Validating
        Try
            Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
            sPartName = editor.GetColumnValue("PartsName").ToString()
            gridView_Items.SetFocusedRowCellValue(colParts_Name, sPartName)

            sCategory = editor.GetColumnValue("Category").ToString
            gridView_Items.SetFocusedRowCellValue(colCategory, sCategory)

            dSRP = CDec(editor.GetColumnValue("SRP"))
            gridView_Items.SetFocusedRowCellValue(colSRP, dSRP)

            iQuantity = 0
            gridView_Items.SetFocusedRowCellValue(colQuantity_Order, iQuantity)

            dRebates = 0
            gridView_Items.SetFocusedRowCellValue(colRebates, dRebates)

            dUnitCost = CDec(editor.GetColumnValue("PriceWOVAT"))
            gridView_Items.SetFocusedRowCellValue(colUnit_Cost, dUnitCost)

            Dim iSalesdDays = Date.Today.AddDays(-60)
            Dim iSalesCount, iInventory As Integer
            iSalesCount = Convert.ToInt32(class_Database.Get_Data(class_Database.SPAConnection, $"SELECT SUM(Quantity) AS Quantity FROM Transaction_Collection WHERE PartsNumber LIKE '{sPartNumber}' AND PostingDate >= '{iSalesdDays}' AND ErrorCorrectTag <> 1", "Quantity"))
            gridView_Items.SetFocusedRowCellValue(colSalesSum, iSalesCount)
            iInventory = Convert.ToInt32(class_Database.Get_Data(class_Database.SPAConnection, $"SELECT SUM(Quantity) AS Quantity FROM SPA_Inventory WHERE PartsNumber LIKE '{sPartNumber}'", "Quantity"))
            gridView_Items.SetFocusedRowCellValue(colInventory, iInventory)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepositoryItemSpinEdit_Quantity_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemSpinEdit_Quantity.EditValueChanged
        Try
            iQuantity = Convert.ToInt32(CType(sender, BaseEdit).EditValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gridView_Items_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView_Items.CellValueChanged
        Try
            With gridView_Items
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
        Catch ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub

    Private Sub btn_Unit_Order_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unit_Order_Reload.ItemClick
        Load_Items()
    End Sub

    Private Sub btn_Unit_Order_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unit_Order_Add.ItemClick
        gridView_Items.AddNewRow()
    End Sub

    Private Sub Save_Item_List()
        With gridView_Items
            If .DataRowCount > 0 Then
                For i As Integer = 0 To .DataRowCount - 1
                    Dim iID As Integer
                    Try
                        If .GetRowCellValue(i, colID).Equals(Nothing) Then Return
                        Try
                            iID = Convert.ToInt32(.GetRowCellValue(i, colID))
                        Catch ex As Exception
                            iID = 0
                        End Try
                        Dim UnitParameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                                New SqlParameter("@Order_Type", Xuc_SPA_Purchase_Orders.Order_Type.Text),
                                                                New SqlParameter("@Category", .GetRowCellDisplayText(i, colCategory)),
                                                                New SqlParameter("@Parts_Number", .GetRowCellDisplayText(i, colParts_Number)),
                                                                New SqlParameter("@Parts_Name", .GetRowCellDisplayText(i, colParts_Name)),
                                                                New SqlParameter("@Order_Code", Xuc_SPA_Purchase_Orders.Order_C0de.Text),
                                                                New SqlParameter("@Brand_Code", Xuc_SPA_Purchase_Orders.Brand.EditValue),
                                                                New SqlParameter("@Quantity", .GetRowCellValue(i, colQuantity_Order)),
                                                                New SqlParameter("@Unit_Cost", .GetRowCellValue(i, colUnit_Cost)),
                                                                New SqlParameter("@SRP", .GetRowCellValue(i, colSRP)),
                                                                New SqlParameter("@Rebates", .GetRowCellValue(i, colRebates)),
                                                                New SqlParameter("@Net_Profit", .GetRowCellValue(i, colNet_Profit)),
                                                                New SqlParameter("@Remaining_Inventory", .GetRowCellValue(i, colInventory)),
                                                                New SqlParameter("@Sales_Summary", .GetRowCellValue(i, colSalesSum)),
                                                                New SqlParameter("@Order_Description", .GetRowCellDisplayText(i, colUnit_Description)),
                                                                New SqlParameter("@Notes", .GetRowCellDisplayText(i, colNotes2)),
                                                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                                New SqlParameter("@Action_Type", "SAVE_ITEM")}
                        class_Database.Procedure_Save(class_Database.SPAConnection, UnitParameters, "spa_Purchase_Order_Procedures", "Purchase Item Unit")
                    Catch ex As Exception
                    End Try
                Next

                Dim sqlParameters As SqlParameter() = {New SqlParameter("@Order_Code", Xuc_SPA_Purchase_Orders.Order_C0de.EditValue),
                                                    New SqlParameter("@Action_Type", "UPDATE")}
                class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Update Purchase Order Profile")
            End If
        End With
    End Sub


    Private Sub btn_Unit_Order_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unit_Order_Preview.ItemClick
        If class_Procedures.isEmpty(Xuc_SPA_Purchase_Orders.Order_C0de) Then Return

        Dim xRpt As New SagaSpareParts.xrpt_SPA_Purchase_Orders()
        class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM Spare_Parts_Purchase_Order_Items WHERE Order_Code LIKE '{Xuc_SPA_Purchase_Orders.Order_C0de.EditValue}' ORDER BY Parts_Number", "Spare_Parts_Purchase_Order_Items")

        Try
            With xRpt
                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 1300
                .PageHeight = 850

                .XrTableCell_Brand.Text = Xuc_SPA_Purchase_Orders.Brand.Text
                .XrTableCell_Dealer.Text = Xuc_SPA_Purchase_Orders.Supplier_Name.Text
                .XrTableCell_Address.Text = CStr(Xuc_SPA_Purchase_Orders.Brand.GetColumnValue("Account_Address"))

                .XrTableCell_Purchase_Order_Code.Text = Xuc_SPA_Purchase_Orders.Order_C0de.EditValue.ToString
                .XrTableCell_Order_Date.Text = Xuc_SPA_Purchase_Orders.Order_Date.Text

                .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub

    Private Sub btn_President_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_President.ItemClick
        If class_Procedures.isEmpty(Xuc_SPA_Purchase_Orders.Order_C0de) Then Return

        Dim xRpt As New SagaSpareParts.xrpt_SPA_Purchase_Orders_MKFHR()
        class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM Spare_Parts_Purchase_Order_Items WHERE Order_Code LIKE '{Xuc_SPA_Purchase_Orders.Order_C0de.EditValue}' ORDER BY Parts_Number", "Spare_Parts_Purchase_Order_Items")

        Try
            With xRpt
                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 1300
                .PageHeight = 850

                .XrTableCell_Brand.Text = Xuc_SPA_Purchase_Orders.Brand.Text
                .XrTableCell_Dealer.Text = Xuc_SPA_Purchase_Orders.Supplier_Name.Text
                .XrTableCell_Address.Text = CStr(Xuc_SPA_Purchase_Orders.Brand.GetColumnValue("Account_Address"))

                .XrTableCell_Purchase_Order_Code.Text = Xuc_SPA_Purchase_Orders.Order_C0de.EditValue.ToString
                .XrTableCell_Order_Date.Text = Xuc_SPA_Purchase_Orders.Order_Date.Text

                .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub

    Private Sub btn_Supplier_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Supplier.ItemClick
        If class_Procedures.isEmpty(Xuc_SPA_Purchase_Orders.Order_C0de) Then Return

        Dim xRpt As New SagaSpareParts.xrpt_SPA_Purchase_Orders_Supplier()
        class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM Spare_Parts_Purchase_Order_Items WHERE Order_Code LIKE '{Xuc_SPA_Purchase_Orders.Order_C0de.EditValue}' ORDER BY Parts_Number", "Spare_Parts_Purchase_Order_Items")

        Try
            With xRpt
                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 850
                .PageHeight = 1300

                .XrTableCell_Brand.Text = Xuc_SPA_Purchase_Orders.Brand.Text
                .XrTableCell_Dealer.Text = Xuc_SPA_Purchase_Orders.Supplier_Name.Text
                .XrTableCell_Address.Text = CStr(Xuc_SPA_Purchase_Orders.Brand.GetColumnValue("Account_Address"))

                .XrTableCell_Purchase_Order_Code.Text = Xuc_SPA_Purchase_Orders.Order_C0de.EditValue.ToString
                .XrTableCell_Order_Date.Text = CStr(Date.Today)

                .XrTableCell_Description.Text = Xuc_SPA_Purchase_Orders.Description.EditValue.ToString.ToUpper
                .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub
    Private Sub btn_Overall_PO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Overall_PO.ItemClick
        If class_Procedures.isEmpty(Xuc_SPA_Purchase_Orders.Order_C0de) Then Return

        Dim xRpt As New SagaSpareParts.xrpt_SPA_Purchase_Orders_Overall_Summary()

        Try
            With xRpt
                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 1300
                .PageHeight = 850

                .XrTableCell_Brand.Text = Xuc_SPA_Purchase_Orders.Brand.Text
                .XrTableCell_Dealer.Text = Xuc_SPA_Purchase_Orders.Supplier_Name.Text
                .XrTableCell_Address.Text = CStr(Xuc_SPA_Purchase_Orders.Brand.GetColumnValue("Account_Address"))

                .XrTableCell_Order_Date.Text = Xuc_SPA_Purchase_Orders.Order_Date.Text
            End With

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Action_Type", "LOAD_SUMMARY")
            }

            class_Database.Procedure_Bind_Report(class_Database.SPAConnection, sqlParameters, xRpt, "spa_Purchase_Order_Procedures", "Spare_Parts_Purchase_Order_Items")
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub
    Private Sub btn_Modify_Orders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Modify_Orders.ItemClick
        If Xuc_SPA_Purchase_Orders.Control_Modify(Convert.ToInt32(gridView.GetFocusedRowCellValue(colID))) Then
            Xuc_SPA_Purchase_Orders.Control_New(Xuc_Settings.Toggle_Clear_On_Action.IsOn, True)
        End If
    End Sub


    Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
        Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", gridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "VERIFY")}
        If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Send Purchase Orders For Verification", Xuc_SPA_Purchase_Orders.Order_C0de.EditValue.ToString) Then
            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD")
        End If
    End Sub
    Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Endorse.ItemClick
        Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", gridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "ENDORSE")}
        If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Send Purchase Orders For Endorsement", Xuc_SPA_Purchase_Orders.Order_C0de.EditValue.ToString) Then
            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD")
        End If
    End Sub

    Private Sub btn_DisApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Disapprove.ItemClick
        Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", gridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "DISAPPROVE")}
        If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Disapprove/Reject Purchase Orders", Xuc_SPA_Purchase_Orders.Order_C0de.EditValue.ToString) Then
            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD")
        End If
    End Sub

    Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
        Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", gridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "APPROVE")}
        If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Approve Purchase Orders", Xuc_SPA_Purchase_Orders.Order_C0de.EditValue.ToString) Then
            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD")
        End If
    End Sub
End Class
