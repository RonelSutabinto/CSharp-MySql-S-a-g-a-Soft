Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Petty_Cash

    Public Class frm_Petty_Cash_Transactions
        Dim bLoopStop As Boolean

        Sub New()
            If Me.xuc_Expense Is Nothing Then
                Me.xuc_Expense = New Controls.Petty_Cash.xuc_Expense()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Expense.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            bLoopStop = True

            class_Tools.RegKeySet(Me.Name, toggle_For_Approval_Show_Mode.Name, toggle_For_Approval_Show_Mode.IsOn)
            class_Tools.RegKeySet(Me.Name, toggle_Load_Reference.Name, toggle_Load_Reference.IsOn)

            Return class_Procedures.Form_Close(Me, barManager, DockManager, gridView, xuc_Expense.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Petty_Cash_Transactions_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub frm_Petty_Cash_Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            barEditItem_Branch.EditValue = class_Saga_Variables.sBranchCode
            xuc_Expense.Branch_Code.EditValue = class_Saga_Variables.sBranchCode

            btn_Save.Enabled = class_Saga_Variables.isAccounting AndAlso class_Saga_Variables.isApprover
            btn_Update.Enabled = class_Saga_Variables.isAccounting AndAlso class_Saga_Variables.isApprover

            barEditItem_Branch.Enabled = class_Saga_Variables.isAccounting
            btn_Approve.Enabled = class_Saga_Variables.isAccounting
            btn_DisApprove.Enabled = class_Saga_Variables.isAccounting AndAlso class_Saga_Variables.isApprover
            btn_Liquidate.Enabled = class_Saga_Variables.isAccounting
            btn_Journal.Enabled = class_Saga_Variables.isAccounting
            btn_Replenish.Enabled = class_Saga_Variables.isAccounting

            toggle_For_Approval_Show_Mode.Enabled = class_Saga_Variables.isAccounting AndAlso class_Saga_Variables.isApprover

            toggle_For_Approval_Show_Mode.IsOn = class_Tools.RegKeyGet(Me.Name, toggle_For_Approval_Show_Mode.Name, False)
            toggle_Load_Reference.IsOn = class_Tools.RegKeyGet(Me.Name, toggle_Load_Reference.Name, False)
        End Sub

        Private Sub frm_Petty_Cash_Transactions_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            class_Saga_Procedures.Initialize_Corporation(RepositoryItemLookUpEdit_Corporation)
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit_Branch)
            colBranch_Code.ColumnEdit = RepositoryItemLookUpEdit_Branch

            Load_Voucher_References(barEditItem_Branch.EditValue)

            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Expense.Control_Initialize()

            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()

            If toggle_For_Approval_Show_Mode.IsOn Then Show_For_Approval_Forms()
        End Sub

        Private Sub Load_Voucher_References(ByVal sBrCode As String)
            With RepositoryItemLookUpEdit_Voucher_Reference
                .BestFit()
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.Descending),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Voucher_Code", "Code"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Voucher_Reference", "Reference"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Check_Amount", "Replenished", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Far),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Voucher_Description", "Description")})

                .DisplayMember = "Voucher_Description"
                .ValueMember = "Voucher_Reference"
                .NullValuePrompt = "Select Voucher..."
            End With

            class_Database.Bind_Data(class_Database.ICSConnection, RepositoryItemLookUpEdit_Voucher_Reference, $"SELECT * FROM acc_Vouchers WHERE Voucher_Type LIKE 'PETTY_CASH' AND Voucher_Branch LIKE '{sBrCode}'", "acc_Vouchers")
            class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_Voucher_Reference, DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor)
        End Sub

        Private Sub barEditItem_Branch_EditValueChanged(sender As Object, e As EventArgs) Handles barEditItem_Branch.EditValueChanged
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue),
                New SqlParameter("@Action_Type", "GET_CEILING_BRANCH")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Procedures")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    btn_Liquidation_For.Enabled = Convert.ToBoolean(myDataReader("IsLiquidationReady"))
                End If
            End Using

            Load_Voucher_References(barEditItem_Branch.EditValue)
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            Load_Voucher_References(barEditItem_Branch.EditValue)
            xuc_Expense.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub Data_Load()
            Dim sActionType As String
            If xuc_Settings.Toggle_Load_All.IsOn Then
                sActionType = "LOAD_EXPENSES_ALL"
            Else
                sActionType = "LOAD_EXPENSES"
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue.ToString),
                New SqlParameter("@Action_Type", sActionType)
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Petty_Cash_Procedures", "Expense Summary")

        End Sub

        Private Sub btn_Load_All_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Load_All.ItemClick
            Try
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue),
                    New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                    New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                    New SqlParameter("@Action_Type", "LOAD_ALL")
                }
                class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Petty_Cash_Procedures", "All Expenses")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub Load_Reference()
            Try
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Reference", Voucher_Reference.EditValue.ToString),
                    New SqlParameter("@Action_Type", "LOAD_REFERENCE")
                }
                class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Petty_Cash_Procedures", "Expense Summary")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Load_Reference_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Load_Reference.ItemClick
            Load_Reference()
        End Sub

        Private Sub btn_Reload_Engine_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Load_Engine.ItemClick
            Try
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue.ToString),
                    New SqlParameter("@Action_Type", "LOAD_ENGINE")
                }
                class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Petty_Cash_Procedures", "Expenses with Engine Information")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
            Dim sActionType As String
            If xuc_Settings.Toggle_Load_All.IsOn Then
                sActionType = "LOAD_APPROVAL_ALL"
            Else
                sActionType = "LOAD_APPROVAL"
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue.ToString),
                New SqlParameter("@Action_Type", sActionType)
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Petty_Cash_Procedures", "Expense Summary - For Approval")

            Show_For_Approval_Forms()
        End Sub

        Private Sub Show_For_Approval_Forms()
            If class_Saga_Variables.isAccounting AndAlso toggle_For_Approval_Show_Mode.IsOn Then
                With gridView
                    If .DataRowCount > 0 Then
                        Dim iRowHandle As Integer

                        bLoopStop = False

                        For i As Integer = 0 To .DataRowCount - 1
                            iRowHandle = i

                            If .GetRowCellDisplayText(iRowHandle, colStatus).Equals("FOR APPROVAL") Then
                                class_Saga_Procedures.Show_Expense(.GetRowCellValue(iRowHandle, colBranch_Code), .GetRowCellValue(iRowHandle, colID))
                            End If
                        Next
                    End If
                End With
            End If
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

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue.ToString),
                    New SqlParameter("@Search", sSearch),
                    New SqlParameter("@Action_Type", "SEARCH")
                }
                class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Petty_Cash_Procedures", "Search List")
            End If
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Expense
                    Try
                        Dim sBrCode As String = gridView.GetFocusedRowCellValue(colBranch_Code)
                        If Not .Branch_Code.Equals(sBrCode) Then
                            .Branch_Code.EditValue = sBrCode
                        End If
                        .ID.EditValue = gridView.GetFocusedRowCellValue(colID)
                        .sTatus = gridView.GetFocusedRowCellDisplayText(colStatus)
                        .Expense_Category.EditValue = gridView.GetFocusedRowCellValue(colProfile_Code)
                        .Category_Corporation.Text = gridView.GetFocusedRowCellDisplayText(colCorporation)
                        .Posting_Date.EditValue = gridView.GetFocusedRowCellDisplayText(colPostingDate)
                        .Particulars.Text = gridView.GetFocusedRowCellDisplayText(colDescription)
                        .Account_Name.Text = gridView.GetFocusedRowCellDisplayText(colAccountName)
                        .Recipient.Text = gridView.GetFocusedRowCellDisplayText(colRecipient)
                        .Amount_Paid.Value = gridView.GetFocusedRowCellDisplayText(colAmount)
                        .Vendor.Text = gridView.GetFocusedRowCellDisplayText(colVendor)
                        .Official_Receipt.Text = gridView.GetFocusedRowCellDisplayText(colReceipt)
                        .VAT.Value = gridView.GetFocusedRowCellDisplayText(colVAT)
                        .No_VAT.Value = gridView.GetFocusedRowCellDisplayText(colNoVAT)
                        .Engine.EditValue = gridView.GetFocusedRowCellDisplayText(colEngineNo)
                        .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    End Try
                End With
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                Dim bEnabled As Boolean = Voucher_Reference.EditValue IsNot Nothing AndAlso Voucher_Reference.EditValue.ToString.Length > 0
                Dim sStatus As String = gridView.GetFocusedRowCellDisplayText(colStatus)

                btn_Liquidate.Enabled = bEnabled
                btn_Replenish.Enabled = bEnabled

                btn_Journal.Enabled = bEnabled
                btn_Journal_Entries.Enabled = bEnabled

                btn_Approve.Enabled = sStatus.Contains("APPROVAL")
                btn_DisApprove.Enabled = Not Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsReplenished))

                btn_Delete.Enabled = Not Convert.ToBoolean(gridView.GetFocusedRowCellValue(colIsReplenished))

                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If e.Clicks.Equals(2) AndAlso gridView.DataRowCount > 0 Then
                Select Case e.Column.FieldName
                    Case "Model_Code"
                        class_Saga_Procedures.Show_Unit_Model(e.CellValue.ToString)

                    Case "EngineNo", "ChassisNo"
                        class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString,, class_Saga_Variables.isLogistics)

                    Case Else
                        Data_Show()
                        class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                End Select
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If gridView.DataRowCount > 0 And gridView.SelectedRowsCount > 0 Then
                Select Case e.KeyValue
                    Case Keys.F6
                        class_Saga_Procedures.Show_Journal_Entries_Reference(Voucher_Reference.EditValue.ToString)

                    Case Keys.Enter
                        Data_Show()

                    Case Keys.Delete
                        class_Saga_Database.Transaction_Delete(gridView, "Petty Cash", "acc_Petty_Cash_Procedures", "DELETE_TRANSACTION", xuc_Settings.Toggle_Live_Looping.IsOn)

                End Select
            End If
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Save.ItemClick
            xuc_Expense.Control_Save()
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Update.ItemClick
            'With gridView
            '    If .SelectedRowsCount > 0 Then
            '        Dim iRowHandle, iRowHandleOld As Integer
            '        Dim selectedRows As Integer() = .GetSelectedRows()

            '        bLoopStop = False
            '        If xuc_Settings.Toggle_Select.IsOn Then .ClearSelection()

            '        For i As Integer = 0 To selectedRows.Length - 1
            '            iRowHandle = selectedRows(i)

            '            If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Petty Cash Expense Verification", "verified", bLoopStop) Then
            '                iRowHandleOld = iRowHandle
            '            Else Return
            '            End If

            '            Dim sqlParameters As SqlParameter() = {
            '                New SqlParameter("@Engine", .GetRowCellDisplayText(iRowHandle, colEngineNo)),
            '                New SqlParameter("@Branch_Code", .GetRowCellValue(iRowHandle, colBranch_Code)),
            '                New SqlParameter("@Action_Type", "UPDATE")
            '            }

            '            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Procedures", "Update Engine Date")
            '        Next
            '    End If
            'End With
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Preview_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview_Approval.ItemClick
            class_Saga_Procedures.Show_Expense_Summary(barEditItem_Branch.EditValue.ToString, $"SELECT * FROM TransactionPettyCash WHERE BranchCode LIKE '{barEditItem_Branch.EditValue}' AND IsDeleted <> 1 AND TransStatus LIKE 'FOR APPROVAL' ORDER BY PostingDate", "Petty Cash Expenses - For Approval")
        End Sub

        Private Sub btn_Expense_Pending_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Expense_Pending.ItemClick
            class_Saga_Procedures.Show_Expense_Summary(barEditItem_Branch.EditValue.ToString, $"SELECT * FROM TransactionPettyCash WHERE BranchCode LIKE '{barEditItem_Branch.EditValue}' AND IsDeleted <> 1 AND IsReplenished <> 1 AND TransStatus NOT LIKE 'FOR APPROVAL' ORDER BY PostingDate", "Petty Cash - Expense Summary")
        End Sub

        Private Sub btn_Expense_Reference_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Expense_Reference.ItemClick
            class_Saga_Procedures.Show_Expense_Summary(barEditItem_Branch.EditValue.ToString, $"SELECT * FROM TransactionPettyCash WHERE BranchCode LIKE '{barEditItem_Branch.EditValue}' AND IsDeleted <> 1 AND Reference LIKE '{Voucher_Reference.EditValue}' ORDER BY PostingDate", "Petty Cash - Expense Summary", Voucher_Reference.EditValue.ToString)
        End Sub

        Private Sub btn_Payment_Request_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Payment_Request.ItemClick
            class_Saga_Procedures.Show_Payment_Request(barEditItem_Branch.EditValue.ToString, $"SELECT * FROM TransactionPettyCash WHERE BranchCode LIKE '{barEditItem_Branch.EditValue}' AND IsDeleted <> 1 AND Reference LIKE '{Voucher_Reference.EditValue}' ORDER BY PostingDate", "Petty Cash Expenses - Payment Request", Voucher_Reference.EditValue.ToString)
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            If barEditItem_Branch.EditValue IsNot Nothing Then
                class_Saga_Procedures.Show_Expense(barEditItem_Branch.EditValue, 0)
            End If
        End Sub

        Private Sub btn_Approve_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
            'Assign as APPROVED but it is actually FOR LIQUIDATION on Stored Procedure
            class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Petty_Cash, "TransStatus", "FOR APPROVAL", "APPROVED", xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Select.IsOn)
            btn_Approval_ItemClick(sender, e)
        End Sub

        Private Sub btn_DisApprove_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DisApprove.ItemClick
            xuc_Expense.Control_DisApprove()
        End Sub

        Private Sub btn_Liquidation_For_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Liquidation_For.ItemClick
            class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Petty_Cash, "TransStatus", "PENDING", "FOR LIQUIDATION", xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Select.IsOn)
            Data_Load()
        End Sub

        Private Sub btn_Liquidate_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Liquidate.ItemClick
            If Voucher_Reference.EditValue Is Nothing Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Please select Expense Voucher Reference", "Journal Not Allowed", True)
                Return
            Else
                class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Petty_Cash, "TransStatus", "FOR LIQUIDATION", "LIQUIDATED", xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Select.IsOn, Voucher_Reference.EditValue.ToString)
                Data_Load()
            End If
        End Sub

        Private Sub btn_Replenish_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Replenish.ItemClick
            class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Petty_Cash, "TransStatus", "LIQUIDATED", "REPLENISHED", xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Select.IsOn, Voucher_Reference.EditValue.ToString)
            btn_Load_Reference_ItemClick(sender, e)
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            If class_Saga_Database.Transaction_Delete(gridView, "Petty Cash", "acc_Petty_Cash_Procedures", "DELETE_TRANSACTION", xuc_Settings.Toggle_Live_Looping.IsOn) Then
                btn_Reload_ItemClick(sender, e)
            End If
        End Sub

        Private Sub RepositoryItemLookUpEdit_Voucher_Reference_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemLookUpEdit_Voucher_Reference.ButtonClick
            Select Case e.Button.Index
                Case 1
                    If class_Saga_Variables.isAccounting Then
                        class_Saga_Procedures.Show_Voucher(Voucher_Reference.EditValue, , eVoucherType.Expense, barEditItem_Branch.EditValue)
                    End If

                Case 2
                    If class_Saga_Variables.isAccounting AndAlso class_Procedures.actionAsk("Petty Cash Voucher", "Add New Petty Cash Voucher") Then
                        Dim dtStart, dtEnd As Date
                        Dim sqlParameters As SqlParameter() = {
                            New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue),
                            New SqlParameter("@Action_Type", "GET_MIN_MAX_DATE")
                        }

                        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Procedures")
                            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                                myDataReader.Read()
                                dtStart = Convert.ToDateTime(myDataReader("Date_Min"))
                                dtEnd = Convert.ToDateTime(myDataReader("Date_Max"))
                            End If
                        End Using

                        Dim sDescription As String = $"{class_Saga_Database.get_Branch_Name(barEditItem_Branch.EditValue)} PETTY CASH - EXPENSE FOR THE PERIOD COVERED {dtStart:MMMM dd, yyyy} - {dtEnd:MMMM dd, yyyy}"

                        class_Saga_Procedures.Show_Voucher(String.Empty, True, class_Saga_Variables.eVoucherType.Expense, barEditItem_Branch.EditValue.ToString, sDescription)

                        Load_Voucher_References(barEditItem_Branch.EditValue)
                    End If

                Case 3
                    Load_Voucher_References(barEditItem_Branch.EditValue)

            End Select
        End Sub

        Private Sub btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            class_Database.DBError = False
            With gridView
                If .DataRowCount > 0 Then
                    class_Procedures.splash_Show("Executing Journal Entries")

                    gridView.ClearGrouping()
                    gridView.ClearSorting()

                    gridView.Columns("Corp").GroupIndex = 0
                    gridView.Columns("Profile_Code").SortIndex = 0

                    Dim iRowHandle, iRowHandleOld As Integer

                    Dim sCode As String = String.Empty
                    Dim sCodeTemp As String = String.Empty

                    bLoopStop = False

                    For i As Integer = 0 To .DataRowCount - 1
                        iRowHandle = i

                        sCode = .GetRowCellValue(iRowHandle, "Payment_Code")

                        If sCode Is Nothing Then Continue For
                        If sCodeTemp.Equals(sCode) Then Continue For

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Petty Cash Expense", "executed", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        class_Saga_Database.Journal_Entry_Save("EXPENSE", Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), .GetRowCellValue(iRowHandle, colPostingDate))
                        sCodeTemp = sCode
                    Next

                    Dim sqlParameters As SqlParameter() = {
                        New SqlParameter("@Voucher_Reference", Voucher_Reference.EditValue),
                        New SqlParameter("@Action_Type", "UPDATE_LIQUIDATION")
                    }
                    class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Voucher_Procedures", "Update Cash/Check Vouchers")

                    class_Saga_Procedures.Show_Journal_Entries_Reference(Voucher_Reference.EditValue.ToString, .GetFocusedRowCellValue(colID))

                    class_Procedures.splash_Close()
                End If
            End With
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            Dim sBrCode As String = barEditItem_Branch.EditValue
            Dim sDescription As String = RepositoryItemLookUpEdit_Voucher_Reference.GetDisplayValueByKeyValue(Voucher_Reference.EditValue)
            class_Saga_Procedures.Show_Journal_Entries_Reference(Voucher_Reference.EditValue.ToString,, class_Saga_Database.get_Admin_Cashier_Code(sBrCode), class_Saga_Database.get_Admin_Cashier(sBrCode), sDescription)
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    If class_Saga_Database.Journal_Verify(.GetFocusedRowCellValue(colID), "EXPENSE") Then
                        class_Saga_Procedures.Show_Journal_Entries_Reference(Voucher_Reference.EditValue.ToString)
                    End If

                End If
            End With
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
        End Sub

        Private Sub Voucher_Reference_EditValueChanged(sender As Object, e As EventArgs) Handles Voucher_Reference.EditValueChanged
            If toggle_Load_Reference.IsOn Then
                Load_Reference()
            End If
        End Sub
    End Class

End Namespace