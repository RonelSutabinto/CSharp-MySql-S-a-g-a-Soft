Imports DevExpress.XtraGrid.Views
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports SagaSpareParts.Controls
Imports System.Data.SqlClient

Namespace SagaSpareParts
    Public Class frm_SPA_Transfers
        Dim sPartNumber, sBrand, sPartName, sCategory, sDescription, sNotes As String
        Dim iQuantity, iQuantity2, iID, iQuantity_Order As Integer
        Dim dUnitCost, dSRP As Decimal

        Public Sub New()
            If Me.Xuc_SPA_Transfer Is Nothing Then
                Me.Xuc_SPA_Transfer = New xuc_SPA_Transfer()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            Try
                class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, Xuc_Settings)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Function Form_Close() As Boolean
            gridView_SKU_Orders.SaveLayoutToRegistry(gridView_SKU_Orders.Name)
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
            class_Procedures.Initialize_gridView(gridView_SKU_Orders, True, True)
            class_Procedures.Initialize_gridView(gridView_SKU_Items)
            gridView_SKU_Orders.RestoreLayoutFromRegistry(gridView_SKU_Orders.Name)
            gridView_SKU_Items.RestoreLayoutFromRegistry(gridView_SKU_Items.Name)
        End Sub

        Private Sub Frm_Purchase_Orders_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If Xuc_Settings.Toggle_Auto_Initialize.ison Then Xuc_SPA_Transfer.Control_Initialize()
            If Xuc_Settings.Toggle_Auto_Reload.ison Then Data_Load("LOAD")
            BarEditItem_Date_Start.EditValue = Date.Today()
            BarEditItem_Date_End.EditValue = Date.Today()
        End Sub

        Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            Me.Xuc_SPA_Transfer.Control_Initialize()
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
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try

            Dim sOrderCode As String
            Try
                sOrderCode = CStr(Xuc_Receive_Order.Order_Code.EditValue)
            Catch Ex As Exception
                sOrderCode = String.Empty
            End Try

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Date_Start", dtStart),
                New SqlParameter("@Date_End", dtEnd),
                New SqlParameter("@Order_Code", sOrderCode),
                New SqlParameter("@Action_Type", sActionType)
            }

            class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, gridView, "spa_Receive_Transfer_Procedures", "Transfer Units")

            gridView.ClearSorting()
            colID.SortIndex = 0
            colID.SortOrder = DevExpress.Data.ColumnSortOrder.Descending

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
            Me.Xuc_SPA_Transfer.Control_New(Xuc_Settings.Toggle_Clear_On_Action.ison)
            gridControl_SKU_Orders.DataSource = Nothing
            gridControl_SKU_Items.DataSource = Nothing
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If Me.Xuc_SPA_Transfer.Control_Save() Then
                gridView_SKU_Items.SelectAll()
                btn_Save_Unit_Items_ItemClick(sender, e)
                If Xuc_Settings.Toggle_Auto_Reload.ison Then
                    Data_Load("LOAD")
                End If
            End If
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            Me.Xuc_SPA_Transfer.Control_Delete()
        End Sub

        Private Sub Data_Show(Optional ByVal bReloadItems As Boolean = True)
            With Xuc_SPA_Transfer
                .ID.EditValue = gridView.GetFocusedRowCellValue(colID)
                .Transaction_Code.Text = gridView.GetFocusedRowCellDisplayText(colTransaction_Code)
                .SRF.EditValue = gridView.GetFocusedRowCellDisplayText(colOrder_Code)
                .Transaction_Type.Text = gridView.GetFocusedRowCellDisplayText(colTransaction_Type)
                If .Transaction_Type.Text.Equals("RECEIVING") Then
                    Dim sSuplierName As String = gridView.GetFocusedRowCellDisplayText(colSupplier)
                    .Branch_From.Text = get_Branch_Name(class_Saga_Variables.sBranchCode)
                Else
                    .Branch_From.Text = get_Branch_Name(class_Saga_Variables.sBranchCode)
                End If
                .Transaction_Date.EditValue = gridView.GetFocusedRowCellValue(colDispatched_Date)
                .Branch_C0de.EditValue = gridView.GetFocusedRowCellValue(colBranch_Code)
                .Status.EditValue = gridView.GetFocusedRowCellDisplayText(colUnit_Status)
                .SKU_Description.Text = gridView.GetFocusedRowCellDisplayText(colDescription)
                .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
            End With
            If bReloadItems Then
                Load_Order_Items()
                Load_Unit_Items()
            End If
        End Sub

        Private Sub Load_Order_Items()
            If Xuc_SPA_Transfer.Transaction_Type.EditValue.Equals("RETAIL") Then
                class_Database.Bind_Data(class_Database.SPAConnection, gridControl_SKU_Orders, gridView_SKU_Orders, $"SELECT * FROM Spare_Parts_Request_Items WHERE Reference LIKE '{Xuc_SPA_Transfer.SRF.Text}' ORDER BY ID", "Spare_Parts_Request_Items")
            Else
                class_Database.Bind_Data(class_Database.SPAConnection, gridControl_SKU_Orders, gridView_SKU_Orders, $"SELECT * FROM SPA_Inventory WHERE PONo LIKE '{Xuc_SPA_Transfer.SRF.Text}' ORDER BY ID", "SPA_Inventory")
            End If
        End Sub

        Private Sub Load_Unit_Items()
            class_Database.Bind_Data(class_Database.SPAConnection, gridControl_SKU_Items, gridView_SKU_Items, $"SELECT * FROM SPA_Inventory WHERE refNo LIKE '{Xuc_SPA_Transfer.SRF.Text}' AND PONo LIKE '{Xuc_SPA_Transfer.Transaction_Code.EditValue}'", "SPA_Inventory")
            class_Procedures.Initialize_gridView(gridView_SKU_Items)
        End Sub

        Private Sub btn_Reload_Unit_Orders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Unit_Orders.ItemClick
            Load_Order_Items()
        End Sub

        Private Sub btn_Reload_Unit_Items_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Unit_Items.ItemClick, btn_Reload_Unit_Orders.ItemClick
            Load_Unit_Items()
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If Xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If (gridView.DataRowCount > 0) Then
                Select Case e.KeyValue
                    Case Keys.Delete
                        If Xuc_SPA_Transfer.Control_Delete Then
                            Try
                                gridView.DeleteSelectedRows()
                            Catch Ex As Exception
                                class_Procedures.Show_Error(Ex)
                            End Try
                        End If
                End Select
            End If
        End Sub

        Private Sub gridView_SKU_Orders_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView_SKU_Orders.FocusedRowChanged
            gridView_SKU_Orders.BestFitColumns()
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                Load_Order_Items()
                Load_Unit_Items()
                Dim sTatus As String = gridView.GetFocusedRowCellDisplayText(colStatus)
                btn_Intransit.Enabled = sTatus.Equals("FOR APPROVAL")
                btn_Approval.Enabled = sTatus.Equals("PENDING")
                btn_Receive.Enabled = sTatus.Equals("INTRANSIT")
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_SKU_Orders_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView_SKU_Orders.MouseDown
            If gridView_SKU_Orders.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu_Unit_Orders.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_SKU_Items_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView_SKU_Items.MouseDown
            If gridView_SKU_Items.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu_Unit_Items.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If e.Clicks.Equals(2) AndAlso gridView.DataRowCount > 0 Then
                Select Case e.Column.FieldName
                    Case Else
                        class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                        Dim sStatus As String = gridView_SKU_Items.GetFocusedRowCellDisplayText(colParts_Name2)
                        gridView_SKU_Items.OptionsBehavior.Editable = sStatus.Equals("PENDING")
                        Data_Show()
                End Select
            End If
        End Sub


        Private Sub gridView_SKU_Orders_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView_SKU_Orders.RowCellClick
            If e.Clicks.Equals(2) AndAlso gridView_SKU_Orders.DataRowCount > 0 Then
                Select Case e.Column.FieldName
                    Case "PartsNumber"
                        class_Saga_Procedures.Show_Unit_Model(e.CellValue.ToString)

                    Case Else
                        class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                        Data_Show(False)
                End Select
            End If
        End Sub

        Private Sub Delete_Unit_Items()
            With gridView_SKU_Items
                If .SelectedRowsCount > 0 Then
                    If Not class_Procedures.actionAsk("Delete SKU Items", "Delete selected SKU items", "You might delete wrong SKU items") Then Return

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView_SKU_Items, iRowHandleOld, iRowHandle, "SKU Item Delete", "deleted") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim iID As Integer
                        Try
                            Try
                                iID = Convert.ToInt32(.GetRowCellValue(iRowHandle, colID_SKU_Item))
                            Catch ex As Exception
                                Continue For
                            End Try

                            Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                            New SqlParameter("@Action_Type", "SKU_DELETE")}

                            class_Database.Procedure_Execute(class_Database.SPAConnection, sqlParameters, "spa_Receive_Transfer_Procedures", "Delete SKU Item")
                        Catch Ex As Exception
                            class_Procedures.Show_Error(Ex)
                        End Try
                    Next
                    .DeleteSelectedRows()
                End If
            End With
        End Sub
        Private Sub gridView_Unit_Items_InitNewRow(sender As Object, e As Grid.InitNewRowEventArgs) Handles gridView_SKU_Items.InitNewRow
            Dim view As Grid.gridView = TryCast(sender, Grid.gridView)

            view.SetRowCellValue(e.RowHandle, colCategory2, sCategory)
            view.SetRowCellValue(e.RowHandle, colParts_Number2, sPartNumber)
            view.SetRowCellValue(e.RowHandle, colParts_Name2, sPartName)
            view.SetRowCellValue(e.RowHandle, colBatch_Id, iID)
            view.SetRowCellValue(e.RowHandle, colQuantity, iQuantity2)
            view.SetRowCellValue(e.RowHandle, colBrand2, sBrand)
            view.SetRowCellValue(e.RowHandle, colQuantity_Order2, iQuantity)
            view.SetRowCellValue(e.RowHandle, colCost2, Math.Round(dUnitCost, 2))
            view.SetRowCellValue(e.RowHandle, colSRP2, Math.Round(dSRP, 2))

            view.BestFitColumns()
        End Sub

        Private Sub btn_Total_Received_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Total_Received.ItemClick

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Parts_Number", gridView_SKU_Orders.GetFocusedRowCellValue(colParts_Number)),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            iID = Convert.ToInt32(gridView_SKU_Orders.GetFocusedRowCellValue(colBatch_Id1))
            sPartNumber = gridView_SKU_Orders.GetFocusedRowCellDisplayText(colParts_Number)
            sPartName = gridView_SKU_Orders.GetFocusedRowCellDisplayText(colParts_Name)
            sCategory = gridView_SKU_Orders.GetFocusedRowCellDisplayText(colCategory)
            sBrand = gridView_SKU_Orders.GetFocusedRowCellDisplayText(colBrand)
            dSRP = CDec(gridView_SKU_Orders.GetFocusedRowCellValue(colSRP))
            dUnitCost = CDec(gridView_SKU_Orders.GetFocusedRowCellValue(colCost))
            iQuantity = Convert.ToInt32(gridView_SKU_Orders.GetFocusedRowCellValue(colQuantity_Order))
            Dim iReceived As Integer = Convert.ToInt32(gridView_SKU_Orders.GetFocusedRowCellValue(colQuantity_Received))
            Dim iRemaining As Integer = iQuantity - iReceived

            iQuantity2 = Convert.ToInt32(class_Functions.Show_Input_Box("Input number of Items to Receive", "Receive Item", iRemaining))

            With gridView_SKU_Items
                .AddNewRow()
            End With
        End Sub

        Private Sub btn_Save_Unit_Items_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Unit_Items.ItemClick
            class_Database.DBError = False

            With gridView_SKU_Items
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()
                    Dim sType As String = Xuc_SPA_Transfer.Transaction_Type.Text

                    If Xuc_Settings.Toggle_Clear_Selection.IsOn Then .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView_SKU_Items, iRowHandleOld, iRowHandle, "SKU Item update", "updated") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim iID As Integer
                        Try
                            Try
                                iID = Convert.ToInt32(.GetRowCellValue(iRowHandle, colID2))
                            Catch ex As Exception
                                iID = 0
                            End Try

                            If class_Functions.gridView_Loop(gridView_SKU_Items, iRowHandleOld, iRowHandle, "SKU Items update", "updated") Then
                                iRowHandleOld = iRowHandle
                            Else Return
                            End If

                            Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                                New SqlParameter("@batch_ID", .GetRowCellDisplayText(iRowHandle, colBatch_Id)),
                                                                New SqlParameter("@PartsNumber", .GetRowCellDisplayText(iRowHandle, colParts_Number2)),
                                                                New SqlParameter("@PartsName", .GetRowCellDisplayText(iRowHandle, colParts_Name2)),
                                                                New SqlParameter("@Brand", .GetRowCellDisplayText(iRowHandle, colBrand2)),
                                                                New SqlParameter("@SRP", .GetRowCellValue(iRowHandle, colSRP2)),
                                                                New SqlParameter("@Notes", .GetRowCellDisplayText(iRowHandle, colNotes3)),
                                                                New SqlParameter("@TransactedBy", class_Variables.sUserName),
                                                                New SqlParameter("@Transaction_Date", Xuc_SPA_Transfer.Transaction_Date.EditValue),
                                                                New SqlParameter("@Quantity", .GetRowCellValue(iRowHandle, colQuantity)),
                                                                New SqlParameter("@PONo", Xuc_SPA_Transfer.Transaction_Code.Text),
                                                                New SqlParameter("@RefNo", Xuc_SPA_Transfer.SRF.Text),
                                                                New SqlParameter("@whCode", Xuc_SPA_Transfer.Status.EditValue),
                                                                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                                                                New SqlParameter("@SPCostWOVAT", .GetRowCellValue(iRowHandle, colCost2)),
                                                                New SqlParameter("@Checker", class_Variables.sUserName),
                                                                New SqlParameter("CurrentApprover", class_Variables.sUserName),
                                                                New SqlParameter("@SourceEvent", Xuc_SPA_Transfer.Transaction_Type.Text),
                                                                New SqlParameter("@ReceivingBranch", Xuc_SPA_Transfer.Branch_C0de.EditValue),
                                                                New SqlParameter("@Sales_Remarks", .GetRowCellDisplayText(iRowHandle, colSKU_Description2)),
                                                                New SqlParameter("@Category", .GetRowCellDisplayText(iRowHandle, colCategory2)),
                                                                New SqlParameter("@Transaction_Code", Xuc_SPA_Transfer.Transaction_Code.EditValue),
                                                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                                New SqlParameter("@Action_Type", "TRANSFER")}
                            class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Receive_Transfer_Procedures", "Receive Unit Item")
                        Catch Ex As Exception
                            class_Procedures.Show_Error(Ex)
                        End Try
                    Next
                End If
            End With
        End Sub

        Private Sub btn_Delete_Unit_Items_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete_Unit_Items.ItemClick
            Delete_Unit_Items()
        End Sub

        Private Sub btn_Preview_Unit_Items_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Transfers_Report.ItemClick
            If class_Procedures.isEmpty(Xuc_SPA_Transfer.SRF) Then Return

            Dim xRpt As New xrpt_SPA_Transfers()
            class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM spa_Inventory WHERE RefNo LIKE '{Xuc_SPA_Transfer.SRF.EditValue}' AND Transaction_Code LIKE '{Xuc_SPA_Transfer.Transaction_Code.EditValue}' ORDER BY PartsNumber", "spa_Inventory")

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1100

                    .XrTableCell_Branch_From.Text = CStr(Xuc_SPA_Transfer.Branch_From.Text)
                    .XrTableCell_Branch_To.Text = CStr(Xuc_SPA_Transfer.Branch_C0de.Text)

                    .XrTableCell_Transaction_Code.Text = Xuc_SPA_Transfer.Transaction_Code.Text
                    .XrTableCell_Purchase_Order_Code.Text = Xuc_SPA_Transfer.SRF.EditValue.ToString
                    .XrTableCell_Transaction_Date.Text = Xuc_SPA_Transfer.Transaction_Date.Text

                    .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
                End With
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub
        'Private Sub btn_Order_Slip_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Order_Slip.ItemClick
        '    If class_Procedures.isEmpty(Xuc_SPA_Transfer.SRF) Then Return

        '    Dim xRpt As New xrpt_SPA_Order_Slip()
        '    class_Database.BindData(class_Database.SPAConnection, xRpt, $"SELECT * FROM spa_Inventory WHERE RefNo LIKE '{Xuc_SPA_Transfer.SRF.EditValue}' AND Transaction_Code LIKE '{Xuc_SPA_Transfer.Transaction_Code.EditValue}' ORDER BY PartsNumber", "spa_Inventory")

        '    Try
        '        With xRpt
        '            .PaperKind = System.Drawing.Printing.PaperKind.Custom
        '            .PageWidth = 850
        '            .PageHeight = 1100

        '            .XrTableCell_Branch_From.Text = CStr(Xuc_SPA_Transfer.Branch_From.Text)
        '            .XrTableCell_Branch_To.Text = CStr(Xuc_SPA_Transfer.Branch_C0de.Text)

        '            .XrTableCell_Transaction_Code.Text = Xuc_SPA_Transfer.Transaction_Code.Text
        '            .XrTableCell_Purchase_Order_Code.Text = Xuc_SPA_Transfer.SRF.EditValue.ToString
        '            .XrTableCell_Transaction_Date.Text = Xuc_SPA_Transfer.Transaction_Date.Text

        '            .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
        '        End With
        '    Catch Ex As Exception
        '        class_Procedures.Show_Error(Ex)
        '    End Try
        'End Sub

        Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
            Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", gridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Batch_Id", gridView_SKU_Items.GetFocusedRowCellValue(colBatch_Id)),
                                                New SqlParameter("@Quantity", gridView_SKU_Items.GetFocusedRowCellValue(colQuantity)),
                                                New SqlParameter("@Transaction_Code", gridView.GetFocusedRowCellValue(colTransaction_Code)),
                                                New SqlParameter("@Reference", gridView.GetFocusedRowCellValue(colReference)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "TRANSPORT")}
            If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Receive_Transfer_Procedures", "For Approval Receive Order", Xuc_SPA_Transfer.SRF.EditValue.ToString) Then
                If Xuc_Settings.Toggle_Auto_Reload.ison Then Data_Load("LOAD ALL")
            End If
        End Sub
        Private Sub btn_Intransit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Intransit.ItemClick
            Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", gridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Batch_Id", gridView_SKU_Items.GetFocusedRowCellValue(colBatch_Id)),
                                                New SqlParameter("@Quantity", gridView_SKU_Items.GetFocusedRowCellValue(colQuantity)),
                                                New SqlParameter("@Transaction_Code", gridView.GetFocusedRowCellValue(colTransaction_Code)),
                                                New SqlParameter("@Reference", gridView.GetFocusedRowCellValue(colReference)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "INTRANSIT")}
            If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Receive_Transfer_Procedures", "For Approval Receive Order", Xuc_SPA_Transfer.SRF.EditValue.ToString) Then
                If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD ALL")
            End If
        End Sub
        Private Sub btn_Receive_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Receive.ItemClick
            Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", gridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Batch_Id", gridView_SKU_Items.GetFocusedRowCellValue(colBatch_Id)),
                                                New SqlParameter("@Quantity", gridView_SKU_Items.GetFocusedRowCellValue(colQuantity)),
                                                New SqlParameter("@Transaction_Code", gridView.GetFocusedRowCellValue(colTransaction_Code)),
                                                New SqlParameter("@Reference", gridView.GetFocusedRowCellValue(colReference)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "APPROVED")}
            If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Receive_Transfer_Procedures", "Approve Receive Order", Xuc_SPA_Transfer.SRF.EditValue.ToString) Then
                If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD ALL")
            End If
        End Sub
    End Class
End Namespace