Imports DevExpress.XtraGrid.Views
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports SagaSpareParts.Controls
Imports System.Data.SqlClient

Namespace SagaSpareParts
    Public Class frm_SPA_Receiving_Orders_Costing
        Dim sPartNumber, sPartName, sCategory, sDescription, sNotes As String
        Dim iQuantity, iQuantity2, iID, iQuantity_Bal As Integer
        Dim dUnitCost, dSRP, dDiscount, dcostWoVat, dTotalDiscount As Decimal

        Public Sub New()
            If Me.Xuc_SPA_Receive_Order Is Nothing Then
                Me.Xuc_SPA_Receive_Order = New xuc_SPA_Receive_Order()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, GridView, BtnCancel, Xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Function Form_Close() As Boolean
            gridView_SKU_Items.SaveLayoutToRegistry(gridView_SKU_Items.Name)

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
            class_Procedures.Initialize_gridView(gridView_SKU_Items, True, True)
            gridView_SKU_Items.RestoreLayoutFromRegistry(gridView_SKU_Items.Name)
            BarEditItem_Date_Start.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Date_Start.Name, DateTime.Today.ToString("MMM dd, yyyy"))
            BarEditItem_Date_End.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Date_End.Name, DateTime.Today.ToString("MMM dd, yyyy"))
        End Sub

        Private Sub Frm_Purchase_Orders_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If Xuc_Settings.Toggle_Auto_Initialize.ison Then xuc_SPA_Receive_Order.Control_Initialize()
            If Xuc_Settings.Toggle_Auto_Reload.ison Then Data_Load("LOAD")

        End Sub

        Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            Me.Xuc_SPA_Receive_Order.Control_Initialize()
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
                class_Procedures.Show_Error(ex)
            End Try

            Dim sOrderCode As String
            Try
                sOrderCode = CStr(Xuc_Receive_Order.Order_Code.EditValue)
            Catch ex As Exception
                sOrderCode = String.Empty
            End Try

            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Start", dtStart),
                New SqlParameter("@Date_End", dtEnd),
                New SqlParameter("@Order_Code", sOrderCode),
                New SqlParameter("@Action_Type", sActionType)
            }

            class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "spa_Receive_Transfer_Procedures", "Transfer Units")

            GridView.ClearSorting()
            colID.SortIndex = 0
            colID.SortOrder = DevExpress.Data.ColumnSortOrder.Descending

            'Dim Parameters As SqlParameter() = {New SqlParameter("@Date_Start", BarEditItem_Date_Start.EditValue),
            '                                New SqlParameter("@Date_End", BarEditItem_Date_End.EditValue),
            '                                New SqlParameter("@Action_Type", sActionType)}
            'class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "spa_Receive_Transfer_Procedures", "Receive Orders")
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

        Private Sub GridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            GridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            Me.Xuc_SPA_Receive_Order.Control_New(Xuc_Settings.Toggle_Clear_On_Action.IsOn)
            GridControl_SKU_Items.DataSource = Nothing
            GridView_SKU_Items.Columns.Clear()
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If Me.Xuc_SPA_Receive_Order.Control_Save() Then
                gridView_SKU_Items.SelectAll()
                btn_Save_Unit_Items_ItemClick(sender, e)
            End If
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            Me.Xuc_SPA_Receive_Order.Control_Delete()
        End Sub

        Private Sub Data_Show(Optional ByVal bReloadItems As Boolean = True)
            With xuc_SPA_Receive_Order
                .ID.EditValue = GridView.GetFocusedRowCellValue(colID)
                .Transaction_Code.Text = GridView.GetFocusedRowCellDisplayText(colTransaction_Code)
                .Reference.Text = GridView.GetFocusedRowCellDisplayText(colReference)
                .Order_Code.EditValue = GridView.GetFocusedRowCellDisplayText(colOrder_Code)
                .Transaction_Type.Text = GridView.GetFocusedRowCellDisplayText(colTransaction_Type)
                'If .Transaction_Type.Text.Equals("OUTGOING") Then
                '    Dim sSuplierName As String = GridView.GetFocusedRowCellDisplayText(colSupplier)
                '    .Branch_From.Text = GridView.GetFocusedRowCellDisplayText(colSupplier)
                'Else
                .Branch_From.Text = GridView.GetFocusedRowCellDisplayText(colSupplier)
                'End If
                .Transaction_Date.EditValue = GridView.GetFocusedRowCellValue(colAdded_Date)
                .Received_Date.EditValue = GridView.GetFocusedRowCellValue(colDispatched_Date)
                .Branch_Code.EditValue = GridView.GetFocusedRowCellValue(colBranch_Code)
                .SKU_Status.EditValue = GridView.GetFocusedRowCellDisplayText(colUnit_Status)
                .SKU_Description.Text = GridView.GetFocusedRowCellDisplayText(colDescription)
                .Notes.Text = GridView.GetFocusedRowCellDisplayText(colNotes)
            End With
            If bReloadItems Then
                Load_Unit_Items()
            End If
        End Sub
        Private Sub Load_Unit_Items()
            class_Database.Bind_Data(class_Database.SPAConnection, GridControl_SKU_Items, gridView_SKU_Items, $"SELECT * FROM SPA_Inventory WHERE RefNo LIKE '{Xuc_SPA_Receive_Order.Reference.EditValue}' AND ReceivingBranch = '{class_Saga_Variables.sBranchCode}'", "SPA_Inventory")
            class_Procedures.Initialize_gridView(gridView_SKU_Items, True, True)
        End Sub

        Private Sub btn_Reload_Unit_Items_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Unit_Items.ItemClick, btn_Reload_Unit_Orders.ItemClick
            Load_Unit_Items()
        End Sub

        Private Sub GridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView.FocusedRowChanged
            If Xuc_Settings.Toggle_Select.ison Then Data_Show()
        End Sub

        Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView.KeyDown
            If (GridView.DataRowCount > 0) Then
                Select Case e.KeyValue
                    Case Keys.Delete
                        If xuc_SPA_Receive_Order.Control_Delete Then
                            Try
                                GridView.DeleteSelectedRows()
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                            End Try
                        End If
                End Select
            End If
        End Sub

        Private Sub GridView_MouseDown(sender As Object, e As MouseEventArgs) Handles GridView.MouseDown
            If GridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                Load_Unit_Items()
                Dim sTatus As String = GridView.GetFocusedRowCellDisplayText(colStatus)
                btn_Approval.Enabled = sTatus.Equals("PENDING") Or sTatus.Equals("DISAPPROVED")
                btn_DisApprove.Enabled = sTatus.Equals("FOR APPROVAL")
                btn_Approve.Enabled = sTatus.Equals("FOR APPROVAL")
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub


        Private Sub GridView_SKU_Items_MouseDown(sender As Object, e As MouseEventArgs) Handles GridView_SKU_Items.MouseDown
            If GridView_SKU_Items.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                Dim sTatus As String = GridView.GetFocusedRowCellDisplayText(colStatus)
                btn_Delete_Unit_Items.Enabled = sTatus.Equals("FOR APPROVAL") Or sTatus.Equals("PENDING") Or sTatus.Equals("DISAPPROVED")
                PopupMenu_Unit_Items.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub GridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
            If e.Clicks.Equals(2) AndAlso GridView.DataRowCount > 0 Then
                Select Case e.Column.FieldName

                    Case Else
                        class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                        Data_Show()
                End Select
            End If
        End Sub

        Private Sub Delete_Unit_Items()
            With GridView_SKU_Items
                If .SelectedRowsCount > 0 Then
                    If Not class_Procedures.actionAsk("Delete SKU Items", "Delete selected SKU items", "You might delete wrong SKU items") Then Return

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(GridView_SKU_Items, iRowHandleOld, iRowHandle, "SKU Item Delete", "deleted") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim iID As Integer
                        Dim sPartsNumber1 As String
                        Try
                            Try
                                iID = Convert.ToInt32(.GetRowCellValue(iRowHandle, colID_SKU_Item))
                                sPartsNumber1 = CStr(.GetRowCellValue(iRowHandle, colParts_Number2))
                            Catch ex As Exception
                                Continue For
                            End Try

                            Dim Parameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                                New SqlParameter("@PartsNumber", sPartsNumber1),
                                                                New SqlParameter("@PONo", xuc_SPA_Receive_Order.Order_Code.Text),
                                                                New SqlParameter("@RefNo", xuc_SPA_Receive_Order.Reference.Text),
                                                                New SqlParameter("@Action_Type", "SKU_DELETE")}

                            class_Database.Procedure_Execute(class_Database.SPAConnection, Parameters, "spa_Receive_Transfer_Procedures", "Delete SKU Item")
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        End Try
                    Next
                    .DeleteSelectedRows()
                End If
            End With
        End Sub
        Private Sub GridView_Unit_Items_InitNewRow(sender As Object, e As Grid.InitNewRowEventArgs) Handles GridView_SKU_Items.InitNewRow
            Dim view As Grid.GridView = TryCast(sender, Grid.GridView)

            view.SetRowCellValue(e.RowHandle, colCategory2, sCategory)
            view.SetRowCellValue(e.RowHandle, colParts_Number2, sPartNumber)
            view.SetRowCellValue(e.RowHandle, colParts_Name2, sPartName)
            'view.SetRowCellValue(e.RowHandle, colID2, iID)
            view.SetRowCellValue(e.RowHandle, colQuantity, iQuantity2)
            view.SetRowCellValue(e.RowHandle, colPrev_Quantity, iQuantity2)
            view.SetRowCellValue(e.RowHandle, colCost2, Math.Round(dUnitCost, 2))
            view.SetRowCellValue(e.RowHandle, colSRP2, Math.Round(dSRP, 2))

            view.BestFitColumns()
        End Sub

        Private Sub GridView_SKU_Items_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView_SKU_Items.CellValueChanged
            Try
                With gridView_SKU_Items
                    Select Case e.Column.Name
                        Case "colDiscountPCT"
                            Dim dDiscounts As Decimal = CDec(.GetFocusedRowCellValue(colSRP2)) * CDec(.GetFocusedRowCellValue(colDiscountPCT))
                            'MsgBox(dDiscounts)
                            dDiscount = Math.Round(dDiscounts, 2)
                            .SetRowCellValue(e.RowHandle, colDiscountAMT, CDec(dDiscount))
                            Dim dcostDiscount As Decimal = Math.Round(CDec(.GetFocusedRowCellValue(colSRP2)) - CDec(dDiscount), 2)
                            dcostWoVat = Math.Round(CDec(dcostDiscount / 1.12), 2)
                            .SetRowCellValue(e.RowHandle, colCost2, CDbl(dcostWoVat))
                        Case "colCost2"
                            Dim dTotalCost As Decimal = CDec(.GetFocusedRowCellValue(colCost2)) * Convert.ToInt32(.GetFocusedRowCellValue(colPrev_Quantity))
                            .SetRowCellValue(e.RowHandle, colTotalCost, CDbl(dTotalCost))
                    End Select

                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub


        Private Sub btn_Save_Unit_Items_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Unit_Items.ItemClick
            class_Database.DBError = False
            With GridView_SKU_Items
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()
                    Dim sType As String = xuc_SPA_Receive_Order.Transaction_Type.Text

                    If Xuc_Settings.Toggle_Clear_Selection.IsOn Then .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(GridView_SKU_Items, iRowHandleOld, iRowHandle, "SKU Item update", "updated") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim iID As Integer
                        Try
                            Try
                                iID = Convert.ToInt32(.GetRowCellValue(iRowHandle, colID_SKU_Item))
                            Catch ex As Exception
                                iID = 0
                            End Try
                            Dim UnitParameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                                    New SqlParameter("@PartsNumber", .GetRowCellDisplayText(iRowHandle, colParts_Number2)),
                                                                    New SqlParameter("@PartsName", .GetRowCellDisplayText(iRowHandle, colParts_Name2)),
                                                                    New SqlParameter("@Brand", xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Brand")),
                                                                    New SqlParameter("@SRP", .GetRowCellValue(iRowHandle, colSRP2)),
                                                                    New SqlParameter("@Quantity", .GetRowCellValue(iRowHandle, colQuantity)),
                                                                    New SqlParameter("@PONo", xuc_SPA_Receive_Order.Order_Code.Text),
                                                                    New SqlParameter("@RefNo", xuc_SPA_Receive_Order.Reference.Text),
                                                                    New SqlParameter("@whCode", xuc_SPA_Receive_Order.SKU_Status.EditValue),
                                                                    New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                                                                    New SqlParameter("@DiscountAMT", .GetRowCellValue(iRowHandle, colDiscountAMT)),
                                                                    New SqlParameter("@DiscountPCT", .GetRowCellValue(iRowHandle, colDiscountPCT)),
                                                                    New SqlParameter("@SPCostWOVAT", .GetRowCellValue(iRowHandle, colCost2)),
                                                                    New SqlParameter("@ReceivingBranch", class_Saga_Variables.sBranchCode),
                                                                    New SqlParameter("@Sales_Remarks", .GetRowCellDisplayText(iRowHandle, colSKU_Description2)),
                                                                    New SqlParameter("@Prev_Quantity", .GetRowCellDisplayText(iRowHandle, colPrev_Quantity)),
                                                                    New SqlParameter("@Category", .GetRowCellDisplayText(iRowHandle, colCategory2)),
                                                                    New SqlParameter("@Transaction_Code", xuc_SPA_Receive_Order.Transaction_Code.EditValue),
                                                                    New SqlParameter("@Action_Type", "COSTING")}
                            class_Database.Procedure_Save(class_Database.SPAConnection, UnitParameters, "spa_Receive_Transfer_Procedures", "Receive Unit Item")
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        End Try
                    Next

                End If
            End With
        End Sub

        Private Sub btn_Delete_Unit_Items_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete_Unit_Items.ItemClick
            Delete_Unit_Items()
        End Sub

        Private Sub btn_Preview_Unit_Items_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview_Unit_Items.ItemClick
            If class_Procedures.isEmpty(xuc_SPA_Receive_Order.Order_Code) Then Return

            Dim xRpt As New xrpt_SPA_Receive_Orders()
            class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM SPA_Inventory WHERE Refno LIKE '{xuc_SPA_Receive_Order.Reference.EditValue}' ORDER BY PARTSNUMBER", "SPA_Inventory") ' -----ADDITIONAL------- AND PONo LIKE '{Xuc_SPA_Receive_Order.Order_Code.Text}' AND Transaction_Code LIKE '{Xuc_SPA_Receive_Order.Transaction_Code.EditValue}'

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1300

                    .XrTableCell_Brand.Text = CStr(xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Brand"))
                    .XrTableCell_Dealer.Text = CStr(xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Supplier_Name"))

                    .XrTableCell_Transaction_Code.Text = xuc_SPA_Receive_Order.Transaction_Code.Text
                    .XrTableCell_Transaction_Date.Text = xuc_SPA_Receive_Order.Transaction_Date.Text
                    .XrTableCell_Received_Date.Text = xuc_SPA_Receive_Order.Received_Date.Text
                    .XrTableCell_Reference.Text = xuc_SPA_Receive_Order.Reference.Text

                    .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub
        Private Sub btn_Costing_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Costing.ItemClick
            If class_Procedures.isEmpty(xuc_SPA_Receive_Order.Order_Code) Then Return

            Dim xRpt As New xrpt_SPA_Receive_Orders_Accounting_Yamaha()
            class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM SPA_Inventory WHERE Refno LIKE '{xuc_SPA_Receive_Order.Reference.EditValue}' ORDER BY PARTSNUMBER", "SPA_Inventory") ' -----ADDITIONAL------- AND PONo LIKE '{Xuc_SPA_Receive_Order.Order_Code.Text}' AND Transaction_Code LIKE '{Xuc_SPA_Receive_Order.Transaction_Code.EditValue}'

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1300

                    .XrTableCell_Brand.Text = CStr(xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Brand"))
                    .XrTableCell_Dealer.Text = CStr(xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Supplier_Name"))

                    .XrTableCell_Transaction_Code.Text = xuc_SPA_Receive_Order.Transaction_Code.Text
                    .XrTableCell_Purchase_Order_Code.Text = xuc_SPA_Receive_Order.Order_Code.EditValue.ToString
                    .XrTableCell_Transaction_Date.Text = xuc_SPA_Receive_Order.Transaction_Date.Text
                    .XrTableCell_Received_Date.Text = xuc_SPA_Receive_Order.Received_Date.Text
                    .XrTableCell_Reference.Text = xuc_SPA_Receive_Order.Reference.Text

                    .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub
        Private Sub btn_Honda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Honda.ItemClick
            If class_Procedures.isEmpty(xuc_SPA_Receive_Order.Order_Code) Then Return

            Dim xRpt As New xrpt_SPA_Receive_Orders_Accounting_Honda()
            class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM SPA_Inventory WHERE Refno LIKE '{xuc_SPA_Receive_Order.Reference.EditValue}' ORDER BY PARTSNUMBER", "SPA_Inventory") ' -----ADDITIONAL------- AND PONo LIKE '{Xuc_SPA_Receive_Order.Order_Code.Text}' AND Transaction_Code LIKE '{Xuc_SPA_Receive_Order.Transaction_Code.EditValue}'

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1300

                    .XrTableCell_Brand.Text = CStr(xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Brand"))
                    .XrTableCell_Dealer.Text = CStr(xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Supplier_Name"))

                    .XrTableCell_Transaction_Code.Text = xuc_SPA_Receive_Order.Transaction_Code.Text
                    .XrTableCell_Purchase_Order_Code.Text = xuc_SPA_Receive_Order.Order_Code.EditValue.ToString
                    .XrTableCell_Transaction_Date.Text = xuc_SPA_Receive_Order.Transaction_Date.Text
                    .XrTableCell_Received_Date.Text = xuc_SPA_Receive_Order.Received_Date.Text
                    .XrTableCell_Reference.Text = xuc_SPA_Receive_Order.Reference.Text

                    .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Kawasaki_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Kawasaki.ItemClick
            If class_Procedures.isEmpty(xuc_SPA_Receive_Order.Order_Code) Then Return

            Dim xRpt As New xrpt_SPA_Receive_Orders_Accounting_Kawasaki()
            class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM SPA_Inventory WHERE Refno LIKE '{xuc_SPA_Receive_Order.Reference.EditValue}' ORDER BY PARTSNUMBER", "SPA_Inventory") ' -----ADDITIONAL------- AND PONo LIKE '{Xuc_SPA_Receive_Order.Order_Code.Text}' AND Transaction_Code LIKE '{Xuc_SPA_Receive_Order.Transaction_Code.EditValue}'

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1300

                    .XrTableCell_Brand.Text = CStr(xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Brand"))
                    .XrTableCell_Dealer.Text = CStr(xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Supplier_Name"))

                    .XrTableCell_Transaction_Code.Text = xuc_SPA_Receive_Order.Transaction_Code.Text
                    .XrTableCell_Purchase_Order_Code.Text = xuc_SPA_Receive_Order.Order_Code.EditValue.ToString
                    .XrTableCell_Transaction_Date.Text = xuc_SPA_Receive_Order.Transaction_Date.Text
                    .XrTableCell_Received_Date.Text = xuc_SPA_Receive_Order.Received_Date.Text
                    .XrTableCell_Reference.Text = xuc_SPA_Receive_Order.Reference.Text

                    .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Suzuki_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Suzuki.ItemClick
            If class_Procedures.isEmpty(xuc_SPA_Receive_Order.Order_Code) Then Return

            Dim xRpt As New xrpt_SPA_Receive_Orders_Accounting_Suzuki()
            class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM SPA_Inventory WHERE Refno LIKE '{xuc_SPA_Receive_Order.Reference.EditValue}' ORDER BY PARTSNUMBER", "SPA_Inventory") ' -----ADDITIONAL------- AND PONo LIKE '{Xuc_SPA_Receive_Order.Order_Code.Text}' AND Transaction_Code LIKE '{Xuc_SPA_Receive_Order.Transaction_Code.EditValue}'

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1300

                    .XrTableCell_Brand.Text = CStr(xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Brand"))
                    .XrTableCell_Dealer.Text = CStr(xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Supplier_Name"))

                    .XrTableCell_Transaction_Code.Text = xuc_SPA_Receive_Order.Transaction_Code.Text
                    .XrTableCell_Purchase_Order_Code.Text = xuc_SPA_Receive_Order.Order_Code.EditValue.ToString
                    .XrTableCell_Transaction_Date.Text = xuc_SPA_Receive_Order.Transaction_Date.Text
                    .XrTableCell_Received_Date.Text = xuc_SPA_Receive_Order.Received_Date.Text
                    .XrTableCell_Reference.Text = xuc_SPA_Receive_Order.Reference.Text

                    .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Recount_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Recount.ItemClick
            class_Database.DBError = False
            With GridView_SKU_Items
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()
                    Dim sType As String = xuc_SPA_Receive_Order.Transaction_Type.Text

                    If Xuc_Settings.Toggle_Clear_Selection.IsOn Then .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(GridView_SKU_Items, iRowHandleOld, iRowHandle, "SKU Item update", "updated") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim iID As Integer
                        Try
                            Try
                                iID = Convert.ToInt32(.GetRowCellValue(iRowHandle, colID_SKU_Item))
                            Catch ex As Exception
                                iID = 0
                            End Try
                            Dim UnitParameters As SqlParameter() = {New SqlParameter("@PartsNumber", .GetRowCellDisplayText(iRowHandle, colParts_Number2)),
                                                                    New SqlParameter("@Reference", xuc_SPA_Receive_Order.Reference.Text),
                                                                    New SqlParameter("@Transaction_Code", xuc_SPA_Receive_Order.Transaction_Code.EditValue),
                                                                    New SqlParameter("@Order_Code", xuc_SPA_Receive_Order.Order_Code.Text),
                                                                    New SqlParameter("@Action_Type", "RECOUNT")}
                            class_Database.Procedure_Save(class_Database.SPAConnection, UnitParameters, "spa_Receive_Transfer_Procedures", "Receive Unit Item")
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        End Try
                    Next

                End If
            End With
        End Sub
        Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
            Dim Parameters As SqlParameter() = {New SqlParameter("@ID", GridView.GetFocusedRowCellValue(colID)),
                                            New SqlParameter("@Transaction_Code", GridView.GetFocusedRowCellValue(colTransaction_Code)),
                                            New SqlParameter("@Reference", GridView.GetFocusedRowCellValue(colReference)),
                                            New SqlParameter("@Modified_By", class_Variables.sUserName),
                                            New SqlParameter("@Action_Type", "APPROVAL")}
            If class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "spa_Receive_Transfer_Procedures", "Received Units for Approval", xuc_SPA_Receive_Order.Reference.EditValue.ToString) Then
                If Xuc_Settings.Toggle_Auto_Reload.ison Then Data_Load("LOAD")
            End If
        End Sub

        Private Sub btn_DisApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DisApprove.ItemClick
            Dim sNotes As String = class_Functions.Show_Input_Box("Input reason for disapproval", "Disapprove", String.Empty)
            Dim Parameters As SqlParameter() = {New SqlParameter("@ID", GridView.GetFocusedRowCellValue(colID)),
                                            New SqlParameter("@Transaction_Code", GridView.GetFocusedRowCellValue(colTransaction_Code)),
                                            New SqlParameter("@Notes", sNotes),
                                            New SqlParameter("@Reference", GridView.GetFocusedRowCellValue(colReference)),
                                            New SqlParameter("@Modified_By", class_Variables.sUserName),
                                            New SqlParameter("@Action_Type", "DISAPPROVE")}
            If class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "spa_Receive_Transfer_Procedures", "Disapprove/Reject Received Units", xuc_SPA_Receive_Order.Reference.EditValue.ToString) Then
                If Xuc_Settings.Toggle_Auto_Reload.ison Then Data_Load("LOAD")
            End If
        End Sub

        Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
            Dim Parameters As SqlParameter() = {New SqlParameter("@ID", GridView.GetFocusedRowCellValue(colID)),
                                            New SqlParameter("@Transaction_Code", GridView.GetFocusedRowCellValue(colTransaction_Code)),
                                            New SqlParameter("@Reference", GridView.GetFocusedRowCellValue(colReference)),
                                            New SqlParameter("@Approver", class_Variables.sUserName),
                                            New SqlParameter("@Action_Type", "APPROVE")}
            If class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "spa_Receive_Transfer_Procedures", "Approve Receive Order", xuc_SPA_Receive_Order.Reference.EditValue.ToString) Then
                If Xuc_Settings.Toggle_Auto_Reload.ison Then Data_Load("LOAD")
            End If
        End Sub
    End Class
End Namespace