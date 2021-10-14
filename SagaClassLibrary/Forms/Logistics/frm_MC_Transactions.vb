Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Logistics
    Public Class frm_MC_Transactions
        Dim bLoopStop As Boolean

        Public Sub New()
            If Me.xuc_MC_Transaction Is Nothing Then
                Me.xuc_MC_Transaction = New Controls.Logistics.xuc_MC_Transaction()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_MC_Transaction.layoutControl, xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Function Form_Close() As Boolean
            If xuc_Settings.Check_Save_Restore_Layout.Checked Then
                gridView_Invoices.SaveLayoutToRegistry(gridView_Invoices.Name)
                xuc_Purchase_Order_Units.gridView.SaveLayoutToRegistry(xuc_Purchase_Order_Units.Name)
                xuc_MC_Transaction_Units.gridView.SaveLayoutToRegistry(xuc_MC_Transaction_Units.Name)
                xuc_MC_Transaction_Units.BarManager.SaveLayoutToRegistry(xuc_MC_Transaction_Units.Name)
            End If

            Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_MC_Transaction.layoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_MC_Transactions_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub frm_MC_Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            barEditItem_Branch.EditValue = class_Saga_Variables.sBranchCode
            barEditItem_Branch.Enabled = class_Saga_Variables.isLogistics

            btn_Delete.Enabled = class_Saga_Variables.isLogistics
            btn_Save_Unit_Items.Enabled = class_Saga_Variables.isLogistics Or class_Saga_Variables.isInventory
            btn_Delete_Unit_Items.Enabled = class_Saga_Variables.isLogistics

            btn_Preview_Unit_Costing.Enabled = class_Saga_Variables.isAccounting
        End Sub

        Private Sub frm_MC_Transactions_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit_Branch)
            colBranch_From.ColumnEdit = RepositoryItemLookUpEdit_Branch
            colBranch_Code.ColumnEdit = RepositoryItemLookUpEdit_Branch

            class_Procedures.Initialize_gridView(gridView_Invoices)

            xuc_MC_Transaction_Units.Control_Initialize()

            If xuc_Settings.Check_Save_Restore_Layout.Checked Then
                gridView_Invoices.RestoreLayoutFromRegistry(gridView_Invoices.Name)
                xuc_Purchase_Order_Units.gridView.RestoreLayoutFromRegistry(xuc_Purchase_Order_Units.Name)
                xuc_MC_Transaction_Units.gridView.RestoreLayoutFromRegistry(xuc_MC_Transaction_Units.Name)
            End If

            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_MC_Transaction.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD")

            Initialize_Inclusions()
        End Sub

        Private Sub Initialize_Inclusions()
            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand($"SELECT * FROM inv_Inclusions", MySQLConnection)
                    Try
                        class_Procedures.splash_Show("loading Unit Inclusions")

                        'MySQLConnection.Open()
                        'Using myDataReader As SqlDataReader = MyCommand.ExecuteReader()
                        '    RepositoryItemTokenEdit_Inclusions.BeginUpdate()
                        '    RepositoryItemTokenEdit_Inclusions.Tokens.Clear()

                        '    If myDataReader.HasRows Then
                        '        While myDataReader.Read()
                        '            RepositoryItemTokenEdit_Inclusions.Tokens.AddToken(($"{myDataReader("Inclusion_Name")}").Trim, myDataReader("Inclusion_Code"))
                        '        End While
                        '        RepositoryItemTokenEdit_Inclusions.EndUpdate()
                        '    End If
                        'End Using
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    Finally
                        class_Procedures.splash_Close(True)
                    End Try
                End Using
            End Using
        End Sub

        Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            Try
                xuc_MC_Transaction.Control_Initialize()
                Initialize_Inclusions()

                xuc_MC_Transaction_Units.Initialize_MC_Units(gridView.GetFocusedRowCellValue(colBranch_From))
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub Load_Invoices()
            If gridView.GetFocusedRowCellDisplayText(colStatus).Equals("PENDING") Then
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Invoice_Status", "PENDING"),
                    New SqlParameter("@Action_Type", "LOAD_STATUS")
                }
                class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl_Invoices, gridView_Invoices, "inv_Unit_Invoice_Procedures", "inv_Unit_Invoices")
            End If
        End Sub

        Private Sub Data_Load(ByVal sActionType As String, Optional sSearch As String = "")
            Dim sOrderCode As String
            Try
                sOrderCode = xuc_MC_Transaction.Order_Code.EditValue
            Catch ex As Exception
                sOrderCode = String.Empty
            End Try

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue),
                New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Order_Code", sOrderCode),
                New SqlParameter("@Search", sSearch),
                New SqlParameter("@Action_Type", sActionType)
            }
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Receive_Transfer_Procedures", "item_Master")

            Try
                gridView.ClearSorting()
                colID.SortIndex = 0
                colID.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Friend Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                Data_Load("SEARCH", sSearch)
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Load_Search((CType(sender, BaseEdit)).Text.Trim)
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Try
                Dim sSearch As String = BarEditItem_Search.EditValue.ToString
                If sSearch.Length > 0 Then
                    Data_Load("SEARCH", BarEditItem_Search.EditValue.ToString)
                    Return
                End If
            Catch ex As Exception

            End Try

            If xuc_Settings.Toggle_Load_All.IsOn Then
                Data_Load("LOAD_ALL")
            Else
                Data_Load("LOAD")
            End If
        End Sub

        Private Sub btn_Load_All_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Load_All.ItemClick
            Data_Load("LOAD_ALL")
        End Sub

        Private Sub btn_Reload_Purchase_Order_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Purchase_Order.ItemClick
            Data_Load("LOAD_PO")
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            btn_Save.Enabled = xuc_MC_Transaction.Control_New(True, xuc_Settings.Toggle_Clear_On_Action.IsOn)

            xuc_Purchase_Order_Units.gridControl.DataSource = Nothing
            xuc_MC_Transaction_Units.gridControl.DataSource = Nothing

            If xuc_MC_Transaction.Transaction_Type.Text.Equals("RECEIVING") Then
                Load_Invoices()
            End If
        End Sub

        Private Sub btn_New_Wizard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New_Wizard.ItemClick
            Dim wzform As New Forms.Logistics.wzFrm_MC_Transaction

            With wzform
                .Show()
            End With
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_MC_Transaction.Control_Save() Then
                xuc_MC_Transaction_Units.Save_MC_Units()
                If xuc_Settings.Toggle_Auto_Reload.IsOn Then
                    Try
                        If BarEditItem_Search.EditValue.ToString.Length > 0 Then
                            Data_Load("SEARCH", BarEditItem_Search.EditValue.ToString)
                        Else
                            Data_Load("LOAD")
                        End If
                    Catch ex As Exception
                        Data_Load("LOAD")
                        class_Procedures.Show_Error(ex)
                    End Try
                End If
            End If
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            Me.xuc_MC_Transaction.Control_Delete()
        End Sub

        Private Sub Data_Show()
            Dim sTransactionType As String = gridView.GetFocusedRowCellDisplayText(colTransaction_Type)
            Dim sOrderCode As String = gridView.GetFocusedRowCellDisplayText(colOrder_Code)
            Dim sStatus As String = gridView.GetFocusedRowCellDisplayText(colStatus)

            btn_Save.Enabled = sStatus.Equals("PENDING") Or sStatus.Equals("DISAPPROVED")
            btn_Delete.Enabled = sStatus.Equals("PENDING") Or sStatus.Equals("DISAPPROVED")

            btn_New_Row.Enabled = sStatus.Equals("PENDING") Or sStatus.Equals("DISAPPROVED")
            btn_Save_Unit_Items.Enabled = sStatus.Equals("PENDING") Or sStatus.Equals("DISAPPROVED")

            StepProgressBar.UnselectAll()

            Select Case sStatus
                Case "FOR APPROVAL"
                    StepProgressBarItemApproval.State = StepProgressBarItemState.Active

                Case "FOR TRANSPORT"
                    StepProgressBarItemTransport.State = StepProgressBarItemState.Active

                Case "RECEIVED"
                    StepProgressBarItemReceived.State = StepProgressBarItemState.Active

                Case "APPROVED"
                    StepProgressBarItemConfirmed.State = StepProgressBarItemState.Active

                Case Else
                    StepProgressBar.UnselectAll()
            End Select

            With xuc_MC_Transaction
                .ID.EditValue = gridView.GetFocusedRowCellValue(colID)
                .Transaction_Type.Text = sTransactionType
                .Transaction_Code.Text = gridView.GetFocusedRowCellDisplayText(colTransaction_Code)
                Select Case .Transaction_Type.Text
                    Case "RECEIVING"
                        .Branch_From.Text = gridView.GetFocusedRowCellDisplayText(colSupplier)
                    Case Else
                        .Branch_From.EditValue = gridView.GetFocusedRowCellValue(colBranch_From)
                        .Order_Code.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
                End Select
                .Order_Code.EditValue = sOrderCode
                .Reference.Text = gridView.GetFocusedRowCellDisplayText(colReference)
                .Freight_Cost.Value = gridView.GetFocusedRowCellValue(colFreight_Cost)
                .Due_Date.EditValue = gridView.GetFocusedRowCellValue(colDue_Date)
                .Transaction_Date.EditValue = gridView.GetFocusedRowCellValue(colTransaction_Date)
                .Received_Date.EditValue = gridView.GetFocusedRowCellValue(colReceived_Date)
                .Branch_Code.EditValue = gridView.GetFocusedRowCellValue(colBranch_Code)
                .WHCode.EditValue = gridView.GetFocusedRowCellValue(colUnit_Status)
                .Description.Text = gridView.GetFocusedRowCellDisplayText(colDescription)
                .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
            End With

            With xuc_MC_Transaction_Units
                Try
                    .TransactionCode = gridView.GetFocusedRowCellDisplayText(colTransaction_Code)
                    .TransactionType = sTransactionType
                    .OrderCode = sOrderCode
                    .Reference = gridView.GetFocusedRowCellDisplayText(colReference)

                    .BranchTo = gridView.GetFocusedRowCellValue(colBranch_Code)
                    .BranchToName = gridView.GetFocusedRowCellDisplayText(colBranch_Code)

                    .TransactionDate = gridView.GetFocusedRowCellValue(colTransaction_Date)
                    .ReceivedDate = gridView.GetFocusedRowCellValue(colReceived_Date)
                    .Status = sStatus
                    .WHCode = gridView.GetFocusedRowCellValue(colUnit_Status)
                    .WHCategory = gridView.GetFocusedRowCellDisplayText(colWHCategory)

                    Select Case sTransactionType
                        Case "RECEIVING"
                            If Not sStatus.Equals("APPROVED") Then
                                Dim sBrand() = gridView.GetFocusedRowCellDisplayText(colSupplier).Split(" ")
                                .Brand = sBrand(0)
                                'class_Saga_Variables.Initialize_MC_Models(False, sBrand(0), True)
                                'class_Saga_Procedures.Initialize_MC_Model(xuc_MC_Transaction_Units.RepositoryItemLookUpEdit_Model_Code)
                            End If
                    End Select

                    .Load_MC_Units()
                    .Initialize_MC_Units(gridView.GetFocusedRowCellValue(colBranch_From))

                    .BranchFrom = gridView.GetFocusedRowCellValue(colBranch_From)
                    .BranchFromName = gridView.GetFocusedRowCellDisplayText(colSupplier)
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End With

            With xuc_Purchase_Order_Units
                If sStatus.Equals("PENDING") Or sStatus.Equals("DISAPPROVED") Then 'sTransactionType.Equals("RECEIVING") AndAlso
                    .OrderCode = sOrderCode
                    .Status = "APPROVED"
                    .Load_MC_Orders()
                Else
                    .gridControl.DataSource = Nothing
                End If
            End With

            'Load_Invoices()
        End Sub

        Private Sub btn_MC_Units_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MC_Units.ItemClick
            Dim sTransactionType As String = gridView.GetFocusedRowCellDisplayText(colTransaction_Type)
            Dim sTransactionCode As String = gridView.GetFocusedRowCellDisplayText(colTransaction_Code)
            Dim sOrderCode As String = gridView.GetFocusedRowCellDisplayText(colOrder_Code)
            Dim sReference As String = gridView.GetFocusedRowCellDisplayText(colReference)
            Dim sBranchFrom As String = gridView.GetFocusedRowCellValue(colBranch_From)
            Dim sBranchFromName As String = gridView.GetFocusedRowCellDisplayText(colBranch_From)
            Dim sBranchTo As String = gridView.GetFocusedRowCellValue(colBranch_Code)
            Dim sWHCode As String = gridView.GetFocusedRowCellValue(colUnit_Status)
            Dim dtTransactionDate As Date = gridView.GetFocusedRowCellValue(colTransaction_Date)
            Dim sStatus As String = gridView.GetFocusedRowCellDisplayText(colStatus)
            class_Saga_Procedures.Show_MC_Transfer_Units(sTransactionType, sTransactionCode, sOrderCode, sReference, sBranchFrom, sBranchFromName, sBranchTo, sWHCode, dtTransactionDate, sStatus)
        End Sub

        Private Sub btn_New_Row_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_New_Row.ItemClick
            xuc_MC_Transaction_Units.gridView.AddNewRow()
        End Sub

        Private Sub btn_Save_Unit_Items_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Save_Unit_Items.ItemClick
            xuc_MC_Transaction_Units.Save_MC_Units()
        End Sub

        Private Sub btn_Reload_Unit_Orders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Unit_Orders.ItemClick
            xuc_Purchase_Order_Units.Load_MC_Orders()
        End Sub

        Private Sub btn_Reload_Unit_Items_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Unit_Items.ItemClick, btn_Reload_Unit_Orders.ItemClick
            xuc_MC_Transaction_Units.Load_MC_Units()
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then
                Data_Show()
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If (gridView.DataRowCount > 0) Then
                Select Case e.KeyValue
                    Case Keys.Delete
                        If xuc_MC_Transaction.Control_Delete Then
                            Try
                                gridView.DeleteSelectedRows()
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                            End Try
                        End If
                End Select
            End If
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                Dim sType As String = gridView.GetFocusedRowCellDisplayText(colTransaction_Type)
                Dim sTatus As String = gridView.GetFocusedRowCellDisplayText(colStatus)

                btn_Delete.Enabled = class_Saga_Variables.isLogistics AndAlso Not gridView.GetFocusedRowCellDisplayText(colStatus).Contains("APPROV")

                btn_Preview_Units.Caption = $"Preview MC UNIT {sType}"
                btn_Preview_Units.Enabled = sTatus.Equals("APPROVED") Or sTatus.Equals("FOR TRANSPORT")
                btn_Preview_Unit_Costing.Enabled = sTatus.Equals("APPROVED")

                btn_Journal_Entries.Enabled = class_Saga_Variables.isAccounting
                btn_Journal.Enabled = class_Saga_Variables.isAccounting
                btn_Verify.Enabled = class_Saga_Variables.isAccounting
                btn_Stop.Enabled = class_Saga_Variables.isAccounting

                btn_Transport.Enabled = False
                btn_Receive.Enabled = False
                btn_Confirm.Enabled = False

                Select Case sType
                    Case "TRANSFER"
                        btn_Approve.Enabled = False
                        btn_Approval.Enabled = sTatus.Equals("PENDING") OrElse sTatus.Equals("DISAPPROVED")
                        btn_Transport.Enabled = sTatus.Equals("FOR APPROVAL")
                        btn_Receive.Enabled = sTatus.Equals("FOR TRANSPORT")
                        btn_Confirm.Enabled = sTatus.Equals("RECEIVED")
                        btn_DisApprove.Enabled = sTatus.Equals("FOR APPROVAL") OrElse sTatus.Equals("FOR TRANSPORT") OrElse sTatus.Equals("RECEIVED")

                        'Case "RECEIVING", "DEPOSIT"
                    Case Else
                        btn_Approval.Enabled = sTatus.Equals("PENDING") OrElse sTatus.Equals("DISAPPROVED")
                        btn_Approve.Enabled = sTatus.Equals("FOR APPROVAL")
                        btn_DisApprove.Enabled = sTatus.Equals("FOR APPROVAL")
                End Select

                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            With gridView
                If e.Clicks.Equals(2) AndAlso .DataRowCount > 0 Then
                    Select Case e.Column.FieldName
                        Case "Transcode", "PoNo"
                            class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString,, class_Saga_Variables.isLogistics)

                        Case "RefNo"
                            class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString, True, class_Saga_Variables.isLogistics)

                        Case "ItemCnt"
                            Dim sTransactionCode As String = .GetFocusedRowCellDisplayText(colTransaction_Code)
                            Dim sOrderCode As String = .GetFocusedRowCellDisplayText(colOrder_Code)
                            Dim sReference As String = .GetFocusedRowCellDisplayText(colReference)
                            class_Saga_Procedures.Show_Unit_Inventory($"SELECT * FROM item_Details WHERE Transcode LIKE '{sTransactionCode}' AND PoNo LIKE '{sOrderCode}' AND RefNo LIKE '{sReference}'", $"Transaction:{sTransactionCode} Order Code:{sOrderCode} Reference:{sReference}")

                        Case Else
                            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                            Data_Show()
                    End Select
                End If
            End With
        End Sub

        Private Sub gridView_Invoices_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView_Invoices.RowCellClick
            If e.Clicks.Equals(2) AndAlso gridView_Invoices.DataRowCount > 0 Then
                Select Case e.Column.FieldName
                    Case "Invoice_Number", "Order_Code_Invoice"
                        If gridView.GetFocusedRowCellDisplayText(colStatus).Equals("PENDING") Then
                            xuc_MC_Transaction.Order_Code.EditValue = gridView_Invoices.GetFocusedRowCellDisplayText(colOrder_Code_Invoice)
                            xuc_MC_Transaction.Reference.Text = gridView_Invoices.GetFocusedRowCellDisplayText(colInvoice_Number)
                        End If

                    Case Else
                        class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub btn_Generate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Generate.ItemClick
            With xuc_Purchase_Order_Units
                xuc_MC_Transaction_Units.Generate_MC_Units(.gridView.GetFocusedRowCellValue(.colModel_Code), .gridView.GetFocusedRowCellValue(.colQuantity), .gridView.GetFocusedRowCellValue(.colUnit_Received))
            End With
        End Sub

        Private Sub btn_Recount_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Recount.ItemClick
            xuc_Purchase_Order_Units.MC_Order_Recount()
        End Sub

        Private Sub btn_Preview_Units_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview_Units.ItemClick
            If class_Procedures.isEmpty(xuc_MC_Transaction.Order_Code) Then Return
            xuc_MC_Transaction_Units.Control_Preview_Units()
        End Sub

        Private Sub btn_Preview_Unit_Costing_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview_Unit_Costing.ItemClick
            xuc_MC_Transaction_Units.Control_Preview_Costing()
        End Sub

        Private Sub btn_Update_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    If Not class_Procedures.actionAsk("Update Transport transactions", "have some warnings and errors.") Then Return

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        Dim sStatus As String = .GetRowCellValue(iRowHandle, colStatus).Equals("Disapproved") Or .GetRowCellValue(iRowHandle, colStatus).Equals("DISAPPROVED")

                        If sStatus Then Continue For

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Logistics Transport(s)", "updated", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn,, "note") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sqlParameters As SqlParameter() = {
                            New SqlParameter("@Transaction_Code", .GetRowCellDisplayText(iRowHandle, colTransaction_Code)),
                            New SqlParameter("@Reference", .GetRowCellDisplayText(iRowHandle, colReference)),
                            New SqlParameter("@Action_Type", "UPDATE_TOTAL")
                        }
                        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Receive_Transfer_Procedures", "Update Total")
                    Next

                    If xuc_Settings.Toggle_Auto_Reload.IsOn Then
                        btn_Reload_ItemClick(sender, e)
                        .BestFitColumns()
                    End If
                End If
            End With
        End Sub

        Private Sub btn_Journal_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    'If BarToggleSwitchItem_Custom_Posting_Date.Checked Then
                    '    class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, "You are about to execute selected Logistics Transports into Journal Entries with Custom Posting Date.", "Custom Posting Date", True)
                    '    If Not class_Procedures.actionAsk("Custom Posting Date", "Execute selected Logistics Transports into Journal Entries with Custom Posting Date", "You might execute with wrong Custom Posting Date") Then Return
                    'Else
                    If Not class_Procedures.actionAsk("Logistics Transports", "Execute Logistics Transports into Journal Entries") Then Return
                    'End If

                    Dim bUpdated As Boolean

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Receiving/Transfer Journal", "executed", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn,, "note") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sStatus As String = .GetRowCellDisplayText(i, colStatus)
                        If sStatus.Equals("DISAPPROVED") Or sStatus.Equals("Disapproved") Then Continue For

                        Try
                            bUpdated = Convert.ToBoolean(.GetRowCellValue(iRowHandle, colisUpdated))
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        End Try

                        If Not bUpdated Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"Unable to execute Journal because the Transport transaction is not updated.")
                            .SetRowCellValue(iRowHandle, colNotes, "Not Updated")
                            Continue For
                        End If

                        Dim sReference As String = .GetRowCellDisplayText(iRowHandle, colReference)

                        Dim frm As frm_Unit_Inventory = New frm_Unit_Inventory
                        With frm
                            class_Saga_Procedures.Initialize_Branch(frm.RepositoryItemLookUpEditBranch)
                            class_Saga_Procedures.Initialize_Branch(frm.barEditItem_Branch, frm.repositoryItemLookUpEdit_Branch)

                            .barEditItem_Branch.EditValue = "000"
                            .BarEditItem_Search.EditValue = sReference
                            .Load_Search(sReference, True)

                            If .gridView.DataRowCount > 0 Then
                                .gridView.SelectAll()
                                .Journal_Execute(False, False)
                            End If
                        End With
                    Next

                    .BestFitColumns()

                    class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colReference), gridView.GetFocusedRowCellValue(colID), gridView.GetFocusedRowCellValue(colReference),,,, True)

                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "Journal Entries were successfully added.")
                End If
            End With
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colReference), gridView.GetFocusedRowCellValue(colID), gridView.GetFocusedRowCellValue(colReference), gridView.GetFocusedRowCellDisplayText(colSupplier),,, True)
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    class_Procedures.splash_Show($"updating IsJournal Transactions of the selected Collections")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Entry Verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If
                        class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), "RECEIVING")
                    Next

                    class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colReference), gridView.GetFocusedRowCellValue(colID), gridView.GetFocusedRowCellValue(colReference),,,, True)
                End If
            End With
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
            class_Saga_Variables.bLoopStop = True
        End Sub

        Private Sub Unit_Item_Actions(ByVal sActionType As String, ByVal sDescription As String, Optional ByVal sNotes As String = "")
            Dim sTransationType As String = gridView.GetFocusedRowCellDisplayText(colTransaction_Type)

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", gridView.GetFocusedRowCellValue(colID)),
                New SqlParameter("@Transaction_Code", gridView.GetFocusedRowCellDisplayText(colTransaction_Code)),
                New SqlParameter("@Reference", gridView.GetFocusedRowCellValue(colReference)),
                New SqlParameter("@Notes", sNotes),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", sActionType)
            }

            If class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Receive_Transfer_Procedures", sDescription, gridView.GetFocusedRowCellValue(colReference)) Then
                Select Case sActionType
                    Case "APPROVE"
                        Select Case sTransationType
                            Case "CONVERT", "DEPOSIT"
                                xuc_MC_Transaction_Units.MC_Unit_Actions("DEPOSIT_MC_UNIT")
                        End Select

                    Case "CONFIRM"
                        xuc_MC_Transaction_Units.MC_Unit_Actions("UPDATE_EXIST")
                End Select

                If xuc_Settings.Toggle_Auto_Reload.IsOn Then
                    Data_Load("LOAD")
                Else
                    gridView.SetFocusedRowCellValue(colStatus, sActionType)
                End If
                xuc_MC_Transaction_Units.Load_MC_Units()
            End If
        End Sub

        Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
            Unit_Item_Actions("APPROVAL", "Received Units for Approval")
        End Sub

        Private Sub btn_DisApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DisApprove.ItemClick
            Dim sNotes As String = class_Functions.Show_Input_Box("Input reason for disapproval", "Disapprove", String.Empty)
            Unit_Item_Actions("DISAPPROVE", "Disapprove/Reject Received Units", sNotes)
        End Sub

        Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
            Unit_Item_Actions("APPROVE", "Approve Received Orders")
        End Sub

        Private Sub btn_Transport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Transport.ItemClick
            Unit_Item_Actions("TRANSPORT", "Send Units for Transport")
        End Sub

        Private Sub btn_Receive_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Receive.ItemClick
            Unit_Item_Actions("RECEIVE", "Receive Units from Transport")
        End Sub

        Private Sub btn_Confirm_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Confirm.ItemClick
            Unit_Item_Actions("CONFIRM", "Approve and Confirm Received Units")
        End Sub

    End Class
End Namespace