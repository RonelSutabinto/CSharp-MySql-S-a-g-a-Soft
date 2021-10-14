Imports System.Data.SqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports MyClassLibrary.Classes.class_Procedures
Imports SagaClassLibrary.Classes

Public Class frm_Sales
    Dim sBrCode, sCategory, sPartNumber, sPartName, sType, sBrand As String
    Dim iQuantity, iCartons As Integer
    Dim dSRP, dRebates As Decimal
    Dim dUnitCost As Decimal = 0
    Dim bLoopStop As Boolean
    Friend sBalanceType As String
    Private Sub Show_Form(ByVal xFrm As XtraForm, ByVal sTitle As String, Optional ByVal bChild As Boolean = True)
        class_Procedures.splash_Show(sTitle, , True, xFormMode.xForm)
        Try
            xFrm.Icon = Me.Icon
            xFrm.Text = sTitle
            If bChild Then xFrm.MdiParent = Me
            xFrm.Show()
        Catch ex As Exception

        End Try
        class_Procedures.splash_Close(True)
    End Sub
    Private Sub frm_Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton

        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, Xuc_Settings)
        BarEditItem_Date_Start.EditValue = CStr(Date.Now())
        BarEditItem_Date_End.EditValue = CStr(Date.Now())
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
    End Sub
    Private Sub frm_Sales_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Close()
    End Sub

    Private Sub Frm_Purchase_Orders_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Xuc_Settings.Toggle_Auto_Initialize.ison Then Xuc_Sales.Control_Initialize()
        If Xuc_Settings.Toggle_Auto_Reload.ison Then Data_Load("LOAD")

    End Sub

    Private Sub Data_Load(ByVal sActionType As String)
        Dim dtStart, dtEnd As Date

        Try
            If class_Saga_Variables.sBranchCode.Equals("000") Then
                dtStart = CDate(BarEditItem_Date_Start.EditValue)
                dtEnd = CDate(BarEditItem_Date_End.EditValue)
            Else
                dtStart = CDate(BarEditItem_Date_Start.EditValue)
                dtEnd = CDate(BarEditItem_Date_End.EditValue)
            End If
        Catch ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try

        Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Start", dtStart),
                New SqlParameter("@Date_End", dtEnd),
                New SqlParameter("@Action_Type", sActionType)
            }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, gridView, "spa_Transaction_Sales", "Transaction Sales")

        gridView.ClearSorting()
        colID.SortIndex = 0
        colID.SortOrder = DevExpress.Data.ColumnSortOrder.Descending

    End Sub
    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Data_Load("LOAD")
    End Sub
    Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
        class_Procedures.Initialize_Printing(e)
    End Sub
    Private Sub btn_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Add.ItemClick
        Dim xxfrm = New frm_Sales_New
        Show_Form(xxfrm, "New Spare Parts Sales", False)
    End Sub
    Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
        Me.Xuc_Sales.Control_New(Xuc_Settings.Toggle_Clear_On_Action.ison)
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        If Me.Xuc_Sales.Control_Save() Then

            If Xuc_Settings.Toggle_Auto_Reload.ison Then
                Data_Load("LOAD")
            Else
                'Update_Data_Row()
            End If
        End If
    End Sub

    Private Sub Data_Show()
        With Xuc_Sales
            .ID.Text = gridView.GetFocusedRowCellDisplayText(colID)
            .Transaction_Category.Text = gridView.GetFocusedRowCellDisplayText(colTrans_Category)
            .Invoices.Text = CStr(gridView.GetFocusedRowCellValue(colInvoices))
            .Customer_Name.EditValue = gridView.GetFocusedRowCellValue(colCustomer_Name)
            .Address.EditValue = gridView.GetFocusedRowCellValue(colAddress)
            .SI_Number.Text = gridView.GetFocusedRowCellDisplayText(colSI_Number)
            .Terms.Text = gridView.GetFocusedRowCellDisplayText(colTerms)
            .Posting_Date.Text = gridView.GetFocusedRowCellDisplayText(colPostingDate)
            .Pricing.Text = gridView.GetFocusedRowCellDisplayText(colPricing)
            .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
        End With
        Load_Items()
    End Sub

    Private Sub RepositoryItemLookUpEdit_PartNumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_PartNumber.Validating
        Try
            Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
            sPartNumber = editor.GetColumnValue("PartsNumber").ToString()
            gridView_List.SetFocusedRowCellValue(colPartsNumber, sPartNumber)

            sPartName = editor.GetColumnValue("PartsName").ToString()
            gridView_List.SetFocusedRowCellValue(colPartsName, sPartName)

            sCategory = editor.GetColumnValue("Category").ToString
            gridView_List.SetFocusedRowCellValue(colCategory, sCategory)

            sBrand = editor.GetColumnValue("Brand").ToString
            gridView_List.SetFocusedRowCellValue(colBrand, sBrand)

            dSRP = CDec(editor.GetColumnValue("SRP"))
            gridView_List.SetFocusedRowCellValue(colSRP, dSRP)

            iQuantity = 0
            gridView_List.SetFocusedRowCellValue(colQuantity, iQuantity)

            dUnitCost = CDec(editor.GetColumnValue("SPCostWOVAT"))
            gridView_List.SetFocusedRowCellValue(colCost, dUnitCost)

            'Dim iSalesdDays = Date.Today.AddDays(-60)
            'Dim iSalesCount, iInventory As Integer
            'iSalesCount = Convert.ToInt32(class_Database.Get_Data(class_Database.SPAConnection, $"SELECT SUM(Quantity) AS Quantity FROM Transaction_Collection WHERE PartsNumber LIKE '{sPartNumber}' AND PostingDate >= '{iSalesdDays}' AND ErrorCorrectTag <> 1", "Quantity"))
            'gridView_Items.SetFocusedRowCellValue(colSalesSum, iSalesCount)
            'iInventory = Convert.ToInt32(class_Database.Get_Data(class_Database.SPAConnection, $"SELECT SUM(Quantity) AS Quantity FROM SPA_Inventory WHERE PartsNumber LIKE '{sPartNumber}'", "Quantity"))
            'gridView_Items.SetFocusedRowCellValue(colInventory, iInventory)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Load_Items()
        Initialize_Parts_Numbers(class_Saga_Variables.sBranchCode)
        Initialize_Parts_Numbers1(RepositoryItemLookUpEdit_PartNumber)
        class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_PartNumber, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)
        'class_Database.BindData(class_Database.SPAConnection, gridControl_List, gridControl_List, $"SELECT * FROM Transaction_Collection WHERE Order_Code LIKE '{Xuc_Sales.SI_Number.EditValue}' ORDER BY ID", "Spare_Parts_Purchase_Order_Items")
        class_Procedures.Initialize_gridView(gridView_List, True, True)
    End Sub

    Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        If Xuc_Settings.Toggle_Select.ison Then Data_Show()
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

    Private Sub gridView_Items_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        With gridView_List
            Select Case e.KeyCode
                Case Keys.Insert
                    .AddNewRow()

                Case Keys.Delete
            End Select
        End With
    End Sub



    'Private Sub RepositoryItemLookUpEdit_Parts_Number_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit_Parts_Number.EditValueChanged
    '    Try
    '        sPartNumber = CType(sender, BaseEdit).EditValue.ToString
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub RepositoryItemLookUpEdit_Parts_Number_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_Parts_Number.Validating
    '    Try
    '        Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
    '        sPartName = editor.GetColumnValue("PartsName").ToString()
    '        gridView_Items.SetFocusedRowCellValue(colParts_Name, sPartName)

    '        sCategory = editor.GetColumnValue("Category").ToString
    '        gridView_Items.SetFocusedRowCellValue(colCategory, sCategory)

    '        dSRP = CDec(editor.GetColumnValue("SRP"))
    '        gridView_Items.SetFocusedRowCellValue(colSRP, dSRP)

    '        iQuantity = 0
    '        gridView_Items.SetFocusedRowCellValue(colQuantity_Order, iQuantity)

    '        dRebates = 0
    '        gridView_Items.SetFocusedRowCellValue(colRebates, dRebates)

    '        dUnitCost = CDec(editor.GetColumnValue("PriceWOVAT"))
    '        gridView_Items.SetFocusedRowCellValue(colUnit_Cost, dUnitCost)

    '        Dim iSalesdDays = Date.Today.AddDays(-60)
    '        Dim iSalesCount, iInventory As Integer
    '        iSalesCount = Convert.ToInt32(class_Database.Get_Data(class_Database.SPAConnection, $"SELECT SUM(Quantity) AS Quantity FROM Transaction_Collection WHERE PartsNumber LIKE '{sPartNumber}' AND PostingDate >= '{iSalesdDays}' AND ErrorCorrectTag <> 1", "Quantity"))
    '        gridView_Items.SetFocusedRowCellValue(colSalesSum, iSalesCount)
    '        iInventory = Convert.ToInt32(class_Database.Get_Data(class_Database.SPAConnection, $"SELECT SUM(Quantity) AS Quantity FROM SPA_Inventory WHERE PartsNumber LIKE '{sPartNumber}'", "Quantity"))
    '        gridView_Items.SetFocusedRowCellValue(colInventory, iInventory)
    '    Catch ex As Exception
    '        XtraMessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub RepositoryItemSpinEdit_Quantity_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemSpinEdit_Quantity.EditValueChanged
    '    Try
    '        iQuantity = Convert.ToInt32(CType(sender, BaseEdit).EditValue)
    '    Catch ex As Exception
    '    End Try
    'End Sub

    'Private Sub gridView_Items_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView_Items.CellValueChanged
    '    Try
    '        With gridView_Items
    '            Select Case e.Column.Name
    '                Case "colQuantity_Order", "colRebates"
    '                    Dim dTotalCost As Decimal = CDec(.GetFocusedRowCellValue(colUnit_Cost)) * Convert.ToInt32(.GetFocusedRowCellValue(colQuantity_Order))
    '                    Dim dTotalSRP As Decimal = CDec(.GetFocusedRowCellValue(colSRP)) * Convert.ToInt32(.GetFocusedRowCellValue(colQuantity_Order))
    '                    Dim dTotalRebates As Decimal = CDec(.GetFocusedRowCellValue(colRebates)) * Convert.ToInt32(.GetFocusedRowCellValue(colQuantity_Order))
    '                    Dim dNetProfit As Decimal = dTotalSRP - dTotalCost + dTotalRebates
    '                    .SetRowCellValue(e.RowHandle, colTotal_Cost2, CDbl(dTotalCost))
    '                    .SetRowCellValue(e.RowHandle, colTotal_SRP, CDbl(dTotalSRP))
    '                    .SetRowCellValue(e.RowHandle, colTotal_Rebates, CDbl(dTotalRebates))
    '                    .SetRowCellValue(e.RowHandle, colNet_Profit, CDbl(dNetProfit))
    '                Case "colUnit_Cost"
    '                    dUnitCost = CDec(.GetFocusedRowCellValue(colUnit_Cost))
    '            End Select
    '        End With
    '    Catch ex As Exception
    '        class_Procedures.Show_Error(Ex)
    '    End Try
    'End Sub

    'Private Sub gridView_Items_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
    '    gridView_Items.BestFitColumns()
    'End Sub

    'Private Sub btn_Unit_Order_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unit_Order_Reload.ItemClick
    '    Load_Items()
    'End Sub

    'Private Sub btn_Unit_Order_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unit_Order_Add.ItemClick
    '    gridView_Items.AddNewRow()
    'End Sub

    'Private Sub Save_Item_List()
    '    With gridView_Items
    '        If .DataRowCount > 0 Then
    '            For i As Integer = 0 To .DataRowCount - 1
    '                Dim iID As Integer
    '                Try
    '                    If .GetRowCellValue(i, colID).Equals(Nothing) Then Return
    '                    Try
    '                        iID = Convert.ToInt32(.GetRowCellValue(i, colID))
    '                    Catch ex As Exception
    '                        iID = 0
    '                    End Try
    '                    Dim UnitParameters As SqlParameter() = {New SqlParameter("@ID", iID),
    '                                                            New SqlParameter("@Order_Type", Xuc_SPA_Purchase_Orders.Order_Type.Text),
    '                                                            New SqlParameter("@Category", .GetRowCellDisplayText(i, colCategory)),
    '                                                            New SqlParameter("@Parts_Number", .GetRowCellDisplayText(i, colParts_Number)),
    '                                                            New SqlParameter("@Parts_Name", .GetRowCellDisplayText(i, colParts_Name)),
    '                                                            New SqlParameter("@Order_Code", Xuc_SPA_Purchase_Orders.Order_Code.Text),
    '                                                            New SqlParameter("@Brand_Code", Xuc_SPA_Purchase_Orders.Brand.EditValue),
    '                                                            New SqlParameter("@Quantity", .GetRowCellValue(i, colQuantity_Order)),
    '                                                            New SqlParameter("@Unit_Cost", .GetRowCellValue(i, colUnit_Cost)),
    '                                                            New SqlParameter("@SRP", .GetRowCellValue(i, colSRP)),
    '                                                            New SqlParameter("@Rebates", .GetRowCellValue(i, colRebates)),
    '                                                            New SqlParameter("@Net_Profit", .GetRowCellValue(i, colNet_Profit)),
    '                                                            New SqlParameter("@Remaining_Inventory", .GetRowCellValue(i, colInventory)),
    '                                                            New SqlParameter("@Sales_Summary", .GetRowCellValue(i, colSalesSum)),
    '                                                            New SqlParameter("@Order_Description", .GetRowCellDisplayText(i, colUnit_Description)),
    '                                                            New SqlParameter("@Notes", .GetRowCellDisplayText(i, colNotes2)),
    '                                                            New SqlParameter("@Added_By", class_Variables.sUserName),
    '                                                            New SqlParameter("@Modified_By", class_Variables.sUserName),
    '                                                            New SqlParameter("@Action_Type", "SAVE_ITEM")}
    '                    class_Database.Procedure_Save(class_Database.SPAConnection, UnitParameters, "spa_Purchase_Order_Procedures", "Purchase Item Unit")
    '                Catch ex As Exception
    '                End Try
    '            Next

    '            Dim sqlParameters As SqlParameter() = {New SqlParameter("@Order_Code", Xuc_SPA_Purchase_Orders.Order_Code.EditValue),
    '                                                New SqlParameter("@Action_Type", "UPDATE")}
    '            class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Update Purchase Order Profile")
    '        End If
    '    End With
    'End Sub

    'Private Sub btn_Unit_Order_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unit_Order_Preview.ItemClick
    '    If class_Procedures.isEmpty(Xuc_SPA_Purchase_Orders.Order_Code) Then Return

    '    Dim xRpt As New SagaSpareParts.xrpt_SPA_Purchase_Orders()
    '    class_Database.BindData(class_Database.SPAConnection, xRpt, $"SELECT * FROM Spare_Parts_Purchase_Order_Items WHERE Order_Code LIKE '{Xuc_SPA_Purchase_Orders.Order_Code.EditValue}' ORDER BY Parts_Number", "Spare_Parts_Purchase_Order_Items")

    '    Try
    '        With xRpt
    '            .PaperKind = System.Drawing.Printing.PaperKind.Custom
    '            .PageWidth = 1300
    '            .PageHeight = 850

    '            .XrTableCell_Brand.Text = Xuc_SPA_Purchase_Orders.Brand.Text
    '            .XrTableCell_Dealer.Text = Xuc_SPA_Purchase_Orders.Supplier_Name.Text
    '            .XrTableCell_Address.Text = CStr(Xuc_SPA_Purchase_Orders.Brand.GetColumnValue("Account_Address"))

    '            .XrTableCell_Purchase_Order_Code.Text = Xuc_SPA_Purchase_Orders.Order_Code.EditValue.ToString
    '            .XrTableCell_Order_Date.Text = Xuc_SPA_Purchase_Orders.Order_Date.Text

    '            .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
    '        End With
    '    Catch ex As Exception
    '        class_Procedures.Show_Error(Ex)
    '    End Try
    'End Sub

    'Private Sub btn_Modify_Orders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Modify_Orders.ItemClick
    '    If Xuc_SPA_Purchase_Orders.Control_Modify(Convert.ToInt32(gridView.GetFocusedRowCellValue(colID))) Then
    '        Xuc_SPA_Purchase_Orders.Control_New(Xuc_Settings.Toggle_Clear_On_Action.ison, True)
    '    End If
    'End Sub
    'Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
    '    Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", gridView.GetFocusedRowCellValue(colID)),
    '                                            New SqlParameter("@Modified_By", class_Variables.sUserName),
    '                                            New SqlParameter("@Action_Type", "VERIFY")}
    '    If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Send Purchase Orders For Verification", Xuc_SPA_Purchase_Orders.Order_Code.EditValue.ToString) Then
    '        If Xuc_Settings.Toggle_Auto_Reload.ison Then Data_Load("LOAD")
    '    End If
    'End Sub
    'Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Endorse.ItemClick
    '    Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", gridView.GetFocusedRowCellValue(colID)),
    '                                            New SqlParameter("@Modified_By", class_Variables.sUserName),
    '                                            New SqlParameter("@Action_Type", "ENDORSE")}
    '    If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Send Purchase Orders For Endorsement", Xuc_SPA_Purchase_Orders.Order_Code.EditValue.ToString) Then
    '        If Xuc_Settings.Toggle_Auto_Reload.ison Then Data_Load("LOAD")
    '    End If
    'End Sub

    'Private Sub btn_DisApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Disapprove.ItemClick
    '    Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", gridView.GetFocusedRowCellValue(colID)),
    '                                            New SqlParameter("@Modified_By", class_Variables.sUserName),
    '                                            New SqlParameter("@Action_Type", "DISAPPROVE")}
    '    If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Disapprove/Reject Purchase Orders", Xuc_SPA_Purchase_Orders.Order_Code.EditValue.ToString) Then
    '        If Xuc_Settings.Toggle_Auto_Reload.ison Then Data_Load("LOAD")
    '    End If
    'End Sub

    'Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
    '    Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", gridView.GetFocusedRowCellValue(colID)),
    '                                            New SqlParameter("@Modified_By", class_Variables.sUserName),
    '                                            New SqlParameter("@Action_Type", "APPROVE")}
    '    If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Purchase_Order_Procedures", "Approve Purchase Orders", Xuc_SPA_Purchase_Orders.Order_Code.EditValue.ToString) Then
    '        If Xuc_Settings.Toggle_Auto_Reload.ison Then Data_Load("LOAD")
    '    End If
    'End Sub

End Class