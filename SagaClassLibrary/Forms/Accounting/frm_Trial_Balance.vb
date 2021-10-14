Imports DevExpress.XtraPrinting
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_Trial_Balance
        Inherits DevExpress.XtraEditors.XtraForm

        Friend eDateType As eLoad_Type

        Dim bLoaded, bLoopStop As Boolean

        Public Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(xuc_Account_Summary, xuc_Account_Summary.BarManager)
            class_Saga_Procedures.Initialize_BarManager(xuc_Trial_Balance_Tree, xuc_Trial_Balance_Tree.barManager)
            class_Saga_Procedures.Initialize_BarManager(xuc_Balance_Import, xuc_Balance_Import.BarManager)

            class_Procedures.Initialize_gridView(xuc_Account_Summary, xuc_Account_Summary.gridView)
            class_Procedures.Initialize_gridView(xuc_Balance_Import, xuc_Balance_Import.gridView)

            class_Procedures.Initialize_TreeList(xuc_Trial_Balance_Tree.treeList, "COA_Summary", "COA_Code")
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Trial_Balance_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit_Branch)
            class_Saga_Procedures.Initialize_Branch(xuc_Account_Summary.RepositoryItemLookUpEdit_Branch)

            class_Saga_Procedures.Initialize_COA(RepositoryItemLookUpEdit_COA, eCOA_Type.COA_All)
            'class_Saga_Procedures.Initialize_COA(xuc_Trial_Balance_Tree.RepositoryItemLookUpEdit, eCOA_Type.COA_All)
            class_Saga_Procedures.Initialize_COA(xuc_Account_Summary.RepositoryItemLookUpEdit_COA, eCOA_Type.COA_All)

            colBranch_Code.ColumnEdit = RepositoryItemLookUpEdit_Branch
            xuc_Trial_Balance_Tree.colCOA_Summary.ColumnEdit = repositoryItemLookUpEdit_COA

            If Not class_Saga_Variables.dtStart.Month.Equals(1) Then Check_Close_Entries.Enabled = False

            btn_Generate.Enabled = class_Saga_Variables.isAccounting
            btn_Delete.Enabled = class_Saga_Variables.isAccounting
            btn_Update.Enabled = class_Saga_Variables.isAccounting
        End Sub

        Private Sub frm_Trial_Balance_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            BarEditItem_Date_Type.EditValue = class_Tools.RegKeyGet(Name, BarEditItem_Date_Type.Name, "MONTHLY")

            Check_Edit_Balances.Checked = class_Tools.RegKeyGet(Name, Check_Edit_Balances.Name, False)
            toggle_Balance_Type.Checked = class_Tools.RegKeyGet(Name, toggle_Balance_Type.Name, False)
            toggle_Mode_Zero.IsOn = class_Tools.RegKeyGet(Name, toggle_Mode_Zero.Name, False)
            checkEdit_Beginning_Balance_Next_Month.Checked = class_Tools.RegKeyGet(Name, checkEdit_Beginning_Balance_Next_Month.Name, False)

            If xuc_Settings.Check_Save_Restore_Layout.Checked Then
                xuc_Trial_Balance_Tree.treeList.RestoreLayoutFromRegistry($"{xuc_Trial_Balance_Tree.Name}")
                xuc_Account_Summary.gridView.RestoreLayoutFromRegistry($"{Me.xuc_Account_Summary.Name}")
            End If

            BarEditItem_Date_Type_EditValueChanged(sender, e)

            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()

            bLoaded = True
        End Sub

        Private Function Form_Close() As Boolean
            class_Tools.RegKeySet(Name, BarEditItem_Date_Type.Name, BarEditItem_Date_Type.EditValue)

            class_Tools.RegKeySet(Name, Check_Edit_Balances.Name, Check_Edit_Balances.Checked)
            class_Tools.RegKeySet(Name, toggle_Balance_Type.Name, toggle_Balance_Type.Checked)
            class_Tools.RegKeySet(Name, toggle_Mode_Zero.Name, toggle_Mode_Zero.IsOn)
            class_Tools.RegKeySet(Name, checkEdit_Beginning_Balance_Next_Month.Name, checkEdit_Beginning_Balance_Next_Month.Checked)

            If xuc_Settings.Check_Save_Restore_Layout.Checked Then
                xuc_Trial_Balance_Tree.treeList.SaveLayoutToRegistry(xuc_Trial_Balance_Tree.Name)
                xuc_Account_Summary.gridView.SaveLayoutToRegistry(xuc_Account_Summary.Name)
            End If

            Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub frm_Trial_Balance_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Function Data_Load() As Boolean
            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0
                    With xuc_Account_Summary
                        .sBrCode = barEditItem_Branch.EditValue.ToString
                        Return .Control_Data_Load()
                    End With

                Case 1
                    Dim sqlParameters As SqlParameter() = {
                        New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                        New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue),
                        New SqlParameter("@Balance_Type", class_Saga_Variables.balanceType.ToString.ToUpper),
                        New SqlParameter("@Date_Type", BarEditItem_Date_Type.EditValue),
                        New SqlParameter("@Date_Range_Start", class_Saga_Variables.dtStart),
                        New SqlParameter("@Date_Range_End", class_Saga_Variables.dtEnd),
                        New SqlParameter("@Added_By", class_Variables.sUserName),
                        New SqlParameter("@Modified_By", class_Variables.sUserName),
                        New SqlParameter("@Action_Type", "LOAD_TRIAL_BALANCE")
                    }
                    Return class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Balance_Procedures", "acc_Balances")

                Case 2
                    Dim TLparameters As SqlParameter() = {
                        New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                        New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue),
                        New SqlParameter("@Balance_Type", class_Saga_Variables.balanceType.ToString.ToUpper),
                        New SqlParameter("@Date_Type", BarEditItem_Date_Type.EditValue),
                        New SqlParameter("@Date_Range_Start", class_Saga_Variables.dtStart),
                        New SqlParameter("@Date_Range_End", class_Saga_Variables.dtEnd),
                        New SqlParameter("@Added_By", class_Variables.sUserName),
                        New SqlParameter("@Modified_By", class_Variables.sUserName),
                        New SqlParameter("@Action_Type", "LOAD_TRIAL_BALANCE")
                    }
                    Return class_Database.Procedure_BindData(class_Database.ICSConnection, TLparameters, xuc_Trial_Balance_Tree.treeList, "acc_Balance_Procedures", "acc_Balances")
            End Select
            Return False
        End Function

        Private Sub gridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles gridView.CustomColumnDisplayText
            'Select Case e.Column.FieldName
            '    Case "Beginning_Balance_Debit", "Beginning_Balance_Credit", "Total_Debit", "Total_Credit", "Ending_Balance_Debit", "Ending_Balance_Credit"
            '        Try
            '            If Convert.ToDecimal(e.Value).Equals(0) Then
            '                e.DisplayText = String.Empty
            '            End If
            '        Catch ex As Exception
            '            class_Procedures.Show_Error(ex)
            '        End Try
            'End Select
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Function Record_Delete(ByVal ID As String) As Boolean
            Return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM acc_Balances WHERE ID LIKE '{ID}'", $"COA Balance: {gridView.GetFocusedRowCellDisplayText(colCOA_Name)}")
        End Function

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            Record_Delete(gridView.GetFocusedRowCellDisplayText(colID))
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            If XtraTabControl.SelectedTabPage.Name.Equals(XtraTabPage_TreeList.Name) Then
                xuc_Trial_Balance_Tree.preview_Trial_Balance()
            ElseIf XtraTabControl.SelectedTabPage.Name.Equals(XtraTabPage_gridView.Name) Then
                gridView.ShowRibbonPrintPreview()
            End If
        End Sub

        Private Sub btn_Preview_Balance_Sheet_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview_Balance_Sheet.ItemClick
            xuc_Trial_Balance_Tree.preview_Balance_Sheet()
        End Sub

        Private Sub btn_Preview_Income_Statement_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview_Income_Statement.ItemClick
            xuc_Trial_Balance_Tree.preview_Income_Statement()
        End Sub

        Private Sub btn_Financial_Position_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Financial_Position.ItemClick
            xuc_Trial_Balance_Tree.preview_Financial_Position()
        End Sub

        Private Sub btn_Financial_Performance_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Financial_Performance.ItemClick
            xuc_Trial_Balance_Tree.preview_Financial_Performance()
        End Sub

        Private Sub gridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView.CellValueChanged
            'Calculate_Balance(e.RowHandle, e.Column.Name)
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If (gridView.RowCount > 0) AndAlso e.Button.Equals(MouseButtons.Right) Then
                Dim sStatus As String = gridView.GetFocusedRowCellDisplayText(colBalance_Status)
                btn_Approval.Enabled = sStatus.Contains("PENDING") Or sStatus.Contains("DISAPPROVED")
                btn_DisApprove.Enabled = sStatus.Contains("APPROVAL")
                btn_Approve.Enabled = sStatus.Contains("APPROVAL")
                btn_Lock.Enabled = sStatus.Equals("APPROVED")
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            With gridView
                If .SelectedRowsCount > 0 Then
                    Select Case e.KeyCode
                        Case Keys.F2
                            class_Saga_Procedures.Show_COA(.GetFocusedRowCellDisplayText(colCOA_Code))

                        Case Keys.F7
                            class_Saga_Procedures.Show_COA_Ledger(.GetFocusedRowCellDisplayText(colCOA_Code), .GetFocusedRowCellDisplayText(colCOA_Name))

                        Case Keys.Enter
                            Select Case .FocusedColumn.Name
                                Case "colBeginning_Balance_Debit"
                                    Update_Balance(colBeginning_Balance_Debit)

                                Case "colBeginning_Balance_Credit"
                                    Update_Balance(colBeginning_Balance_Credit)
                            End Select

                        Case Keys.Delete
                            If Not class_Procedures.actionAsk("Delete Trial Balance(s)", "Delete selected Trial Balance(s)", "This will remove/delete selected Trial Balance Account(s)") Then Return
                            class_Procedures.splash_Show("Deleting Trial Balance(s)")

                            Dim sID As String
                            Dim iRowHandle, iRowHandleOld As Integer
                            Dim selectedRows As Integer() = .GetSelectedRows()

                            bLoopStop = False
                            class_Database.DBError = False

                            For i As Integer = 0 To selectedRows.Length - 1
                                iRowHandle = selectedRows(i)

                                If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Trial Balances", "deleted", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn, True) Then
                                    iRowHandleOld = iRowHandle
                                Else Return
                                End If

                                sID = .GetRowCellDisplayText(iRowHandle, colID)

                                Try
                                    If Convert.ToInt32(sID) > 0 Then
                                        class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM acc_Balances WHERE ID LIKE '{sID}'", True, "Added_By")
                                    End If
                                Catch ex As Exception
                                    Continue For
                                End Try
                            Next

                            Try
                                .DeleteSelectedRows()
                            Catch ex As Exception

                            End Try
                            class_Procedures.splash_Close()
                    End Select
                End If
            End With
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Select Case e.Column.Name
                    Case "colCOA_Code"
                        class_Saga_Procedures.Show_COA(e.CellValue.ToString)

                    Case "colCOA_Name"
                        If gridView.GetFocusedRowCellDisplayText(colCOA_Type).Equals("SUMMARY") Then
                            class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, $"{gridView.GetFocusedRowCellDisplayText(colCOA_Code)}%", gridView.GetFocusedRowCellDisplayText(colCOA_Name),, False)
                        Else
                            class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name),, False)
                        End If

                    Case "colCOA_Summary"
                        class_Saga_Procedures.Show_COA(e.CellValue.ToString)

                    Case "colBeginning_Balance_Debit"
                        If Check_Edit_Balances.Checked Then
                            Update_Balance(colBeginning_Balance_Debit)
                        Else
                            class_Saga_Procedures.Show_COA_Balances(gridView.GetFocusedRowCellDisplayText(colCOA_Code), True)
                        End If

                    Case "colBeginning_Balance_Credit"
                        If Check_Edit_Balances.Checked Then
                            Update_Balance(colBeginning_Balance_Credit)
                        Else
                            class_Saga_Procedures.Show_COA_Balances(gridView.GetFocusedRowCellDisplayText(colCOA_Code), True)
                        End If

                    Case "colTotal_Debit"
                        If Check_Edit_Balances.Checked Then
                            Update_Balance(colTotal_Debit)
                        Else
                            If Convert.ToDecimal(gridView.GetFocusedRowCellValue(colTotal_Debit)) > 0 Then
                                If gridView.GetFocusedRowCellDisplayText(colCOA_Type).Equals("SUMMARY") Then
                                    class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, $"{gridView.GetFocusedRowCellDisplayText(colCOA_Code)}%", gridView.GetFocusedRowCellDisplayText(colCOA_Name),,, barEditItem_Branch.EditValue.ToString)
                                Else
                                    class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name),,, barEditItem_Branch.EditValue.ToString)
                                End If
                            Else
                                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Debit must be greater than zero.")
                            End If
                        End If

                    Case "colTotal_Credit"
                        If Check_Edit_Balances.Checked Then
                            Update_Balance(colTotal_Debit)
                        Else
                            If Convert.ToDecimal(gridView.GetFocusedRowCellValue(colTotal_Credit)) > 0 Then
                                If gridView.GetFocusedRowCellDisplayText(colCOA_Type).Equals("SUMMARY") Then
                                    class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, $"{gridView.GetFocusedRowCellDisplayText(colCOA_Code)}%", gridView.GetFocusedRowCellDisplayText(colCOA_Name),,, barEditItem_Branch.EditValue.ToString)
                                Else
                                    class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.Balance, gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name),,, barEditItem_Branch.EditValue.ToString)
                                End If
                            Else
                                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Debit must be greater than zero.")
                            End If
                        End If

                    Case "colNotes"
                        gridView.SetFocusedRowCellValue(colNotes, class_Saga_Database.Balance_Notes_Save(Convert.ToInt32(gridView.GetFocusedRowCellDisplayText(colID)), class_Functions.Show_Input_Box($"Set Note(s) for this Balance", "Set Note(s)", e.CellValue.ToString)))
                        colNotes.BestFit()

                    Case Else
                        If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub Update_Balance(ByVal gvColumn As DevExpress.XtraGrid.Columns.GridColumn)
            Dim sBalanceField As String = gvColumn.FieldName
            Dim dDETAIL, dBalance As Decimal
            Try
                dDETAIL = Convert.ToDecimal(gridView.GetFocusedRowCellValue(gvColumn))
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
                dDETAIL = 0
            End Try

            Try
                dBalance = Convert.ToDecimal(class_Functions.Show_Input_Box($"Set {gvColumn.Caption} for {class_Saga_Variables.dtStart.ToLongDateString}", sBalanceField, dDETAIL))
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
                dBalance = 0
            End Try

            gridView.SetFocusedRowCellValue(gvColumn, class_Saga_Database.Balance_Save(gridView.GetFocusedRowCellDisplayText(colID), sBalanceField, dDETAIL, dBalance))
        End Sub

        Private Sub Check_Edit_Balance_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Edit_Balances.CheckedChanged
            xuc_Trial_Balance_Tree.bEditBalance = Check_Edit_Balances.Checked
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
            class_Saga_Database.bLoopStop = True
            xuc_Account_Summary.bLoopStop = True
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            With gridView
                If .SelectedRowsCount > 0 Then
                    If Not class_Procedures.actionAsk("Initializing Trial Balance", "Initialize Trial Balances into ZERO(0) Beginning Balance") Then Return
                    class_Procedures.splash_Show("Generating Trial Balances")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Trial Balances", "initialized", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim dBeginningBalanceDebit, dBeginningBalanceCredit As Decimal

                        If checkEdit_Reset_On_Initialize.Checked Then
                            dBeginningBalanceDebit = 0
                            dBeginningBalanceCredit = 0

                            .SetRowCellValue(iRowHandle, colBeginning_Balance_Debit, 0)
                            .SetRowCellValue(iRowHandle, colBeginning_Balance_Credit, 0)
                        Else
                            Try
                                dBeginningBalanceDebit = .GetRowCellValue(iRowHandle, colBeginning_Balance_Debit)
                            Catch ex As Exception
                                dBeginningBalanceDebit = 0
                            End Try

                            Try
                                dBeginningBalanceCredit = .GetRowCellValue(iRowHandle, colBeginning_Balance_Credit)
                            Catch ex As Exception
                                dBeginningBalanceCredit = 0
                            End Try
                        End If

                        'Dim sCOACode As String = .GetRowCellDisplayText(iRowHandle, colCOA_Code)
                        ''Dim sNotes As String = "Total Debit and Credit has been initialized into ZERO(0)"

                        'If class_Saga_Database.Balance_Save("UPDATE_TOTAL", class_Saga_Variables.balanceType.ToString.ToUpper, eDateType, barEditItem_Branch.EditValue, sCOACode, class_Saga_Variables.dtStart) Then
                        '    .SetRowCellValue(iRowHandle, colTotal_Debit, 0)
                        '    .SetRowCellValue(iRowHandle, colTotal_Credit, 0)
                        '    '.SetRowCellValue(iRowHandle, colNotes, sNotes)
                        'End If
                    Next

                    .BestFitColumns()

                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "Trial Balances has been successfully initialized.")
                    class_Procedures.splash_Close()
                End If
            End With
        End Sub

        Private Sub btn_Generate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Generate.ItemClick
            class_Database.DBError = False
            Select Case eDateType
                Case class_Saga_Variables.eLoad_Type.Daily
                    If Not class_Saga_Variables.dtStart.Equals(class_Saga_Variables.dtEnd) Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Date Range cannot be set as Daily", "Date Range Error", True)
                        Return
                    End If

                Case class_Saga_Variables.eLoad_Type.Monthly, class_Saga_Variables.eLoad_Type.Range
                    If class_Saga_Variables.dtStart.Equals(class_Saga_Variables.dtEnd) OrElse class_Saga_Variables.dtStart > class_Saga_Variables.dtEnd Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Date Range should not be equal or Date Start is not greater than Date End", "Date Range Error", True)
                        Return
                    End If
            End Select

            If class_Procedures.actionAsk("Generate Trial Balance", "Generate Trial Balances for the current Month", "This might take longer time to execute", "You can still Generate Trial Balances anytime") Then
                StepProgressBar.UnselectAll()

                toggle_Balance_Type.Checked = False
                If Generate_Trial_Balance(False) 
                    StepProgressBarItem_Trial_Balance_Detail.State = DevExpress.XtraEditors.StepProgressBarItemState.Active
                Else
                    Return
                End If

                toggle_Balance_Type.Checked = True
                If Generate_Trial_Balance(True) Then
                    StepProgressBarItem_Trial_Balance_Summary.State = DevExpress.XtraEditors.StepProgressBarItemState.Active
                Else
                    Return
                End If

                xuc_Trial_Balance_Tree.preview_Financial_Performance()
                xuc_Trial_Balance_Tree.preview_Financial_Position()
                StepProgressBarItem_Finished.State = DevExpress.XtraEditors.StepProgressBarItemState.Active
            End If
        End Sub

        Private Function Generate_Trial_Balance(ByVal bSummary As Boolean) As Boolean
            Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                    New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue),
                    New SqlParameter("@Balance_Type", class_Saga_Variables.balanceType.ToString.ToUpper),
                    New SqlParameter("@Date_Type", BarEditItem_Date_Type.EditValue.ToString),
                    New SqlParameter("@Balance_Date", class_Saga_Variables.dtStart),
                    New SqlParameter("@Date_Range_Start", class_Saga_Variables.dtStart),
                    New SqlParameter("@Date_Range_End", class_Saga_Variables.dtEnd),
                    New SqlParameter("@Added_By", class_Variables.sUserName),
                    New SqlParameter("@Modified_By", class_Variables.sUserName),
                    New SqlParameter("@Action_Type", "GENERATE_BALANCES")
                }
            If class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Balance_Procedures", "Trial Balances Generation") Then
                StepProgressBarItem_Initialize.State = DevExpress.XtraEditors.StepProgressBarItemState.Active
            Else
                Return False
            End If

            XtraTabControl.SelectedTabPageIndex = 0
            If Not bSummary Then
                With xuc_Account_Summary
                    If Not bLoopStop AndAlso .Control_Data_Load() Then
                        StepProgressBarItem_Summary_Accounts.State = DevExpress.XtraEditors.StepProgressBarItemState.Active
                    Else
                        Return False
                    End If

                    .gridView.ClearGrouping()
                    .gridView.ClearColumnsFilter()
                    .gridView.ClearSorting()
                    .colCOA_Code.SortIndex = 0
                    .gridView.SelectAll()
                    .Summary_To_Trial_Balance(xuc_Settings.Toggle_Live_Looping.IsOn)
                    StepProgressBarItem_Summary_Trial_Balance.State = DevExpress.XtraEditors.StepProgressBarItemState.Active
                End With
            End If

            XtraTabControl.SelectedTabPageIndex = 1
            If Not bLoopStop AndAlso Not Data_Load() Then
                Return False
            End If

            gridView.ClearGrouping()
            gridView.ClearColumnsFilter()
            gridView.ClearSorting()
            colCOA_Level.SortIndex = 0
            colCOA_Level.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
            gridView.SelectAll()
            Trial_Balance_Update(bSummary)

            XtraTabControl.SelectedTabPageIndex = 2
            Data_Load()
            Return True
        End Function

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            Trial_Balance_Update(toggle_Balance_Type.Checked)
        End Sub

        Private Sub Trial_Balance_Update(ByVal bSummary As Boolean)
            With gridView
                If .SelectedRowsCount > 0 Then

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    class_Database.DBError = False
                    If xuc_Settings.Toggle_Clear_Selection.IsOn Then .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Trial Balances", "updated", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If bSummary Then
                            Dim sqlParameters As SqlParameter() = {
                                New SqlParameter("@COA_Code", .GetRowCellDisplayText(iRowHandle, colCOA_Code)),
                                New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                                New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue.ToString),
                                New SqlParameter("@Date_Type", BarEditItem_Date_Type.EditValue.ToString),
                                New SqlParameter("@Date_Range_Start", class_Saga_Variables.dtStart),
                                New SqlParameter("@Date_Range_End", class_Saga_Variables.dtEnd),
                                New SqlParameter("Action_Type", "UPDATE_SUMMARY")
                            }
                            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Balance_Procedures", "Balance Update")
                        Else
                            Dim sCOACode As String = gridView.GetRowCellDisplayText(iRowHandle, colCOA_Code)

                            If Not toggle_Mode_Zero.IsOn Then
                                Select Case class_Saga_Variables.balanceType
                                    Case eBalanceType.SUMMARY
                                        class_Saga_Database.Balance_Save("UPDATE_BALANCE", class_Saga_Variables.balanceType.ToString.ToUpper, eDateType, barEditItem_Branch.EditValue.ToString, sCOACode, class_Saga_Variables.dtStart)

                                    Case eBalanceType.DETAIL
                                        If class_Saga_Database.Balance_Save("ENDING_BALANCE", class_Saga_Variables.balanceType.ToString.ToUpper, eDateType, barEditItem_Branch.EditValue.ToString, sCOACode, class_Saga_Variables.dtStart, Check_Close_Entries.Checked) Then
                                            gridView.SetRowCellValue(iRowHandle, colNotes, "Saving Total Debit/Credit [OK]")
                                        Else
                                            gridView.SetRowCellValue(iRowHandle, colNotes, "Total Debit/Credit [not Saved]")
                                        End If
                                End Select
                            Else
                                class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM acc_Balances WHERE ID LIKE '{gridView.GetRowCellValue(iRowHandle, colID)}'")
                            End If
                        End If

                        If checkEdit_Beginning_Balance_Next_Month.Checked Then
                            Dim sCOACode As String = gridView.GetRowCellDisplayText(iRowHandle, colCOA_Code)

                            Dim dBeginningBalanceDebit As Decimal
                            Try
                                dBeginningBalanceDebit = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colEnding_Balance_Debit))
                            Catch ex As Exception
                                dBeginningBalanceDebit = 0
                            End Try

                            Dim dBeginningBalanceCredit As Decimal
                            Try
                                dBeginningBalanceCredit = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colEnding_Balance_Credit))
                            Catch ex As Exception
                                dBeginningBalanceCredit = 0
                            End Try

                            Dim dtBalance As Date = class_Functions.FirstDayOfMonth(class_Saga_Variables.dtStart.AddMonths(1))

                            class_Saga_Database.Balance_Save("BEGINNING_BALANCE", class_Saga_Variables.balanceType.ToString.ToUpper, eDateType, barEditItem_Branch.EditValue.ToString, sCOACode, dtBalance, False, dBeginningBalanceDebit, dBeginningBalanceCredit) ', 0, 0, 0, 0, "Beginning Balance generated from previous month")
                        End If
                    Next

                    .BestFitColumns()
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "Trial Balances has been successfully updated.")
                End If
            End With
        End Sub

        Private Sub btn_Ledger_Beginning_Balance_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Ledger_Beginning_Balance.ItemClick
            Select Case XtraTabControl.SelectedTabPageIndex
                Case 1
                    With gridView
                        If .SelectedRowsCount > 0 Then
                            If Not class_Procedures.actionAsk("Ledger Beginning Balance", "Set as Ledger Beginning Balances", "You might set the wrong Ledger Beginning Balance") Then Return

                            Dim iRowHandle, iRowHandleOld As Integer
                            Dim selectedRows As Integer() = .GetSelectedRows()
                            Dim sCOACode As String = String.Empty

                            bLoopStop = False
                            class_Database.DBError = False
                            If xuc_Settings.Toggle_Clear_Selection.IsOn Then .ClearSelection()

                            For i As Integer = 0 To selectedRows.Length - 1
                                iRowHandle = selectedRows(i)

                                If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Entries", "verified", bLoopStop) Then
                                    iRowHandleOld = iRowHandle
                                Else Return
                                End If

                                sCOACode = .GetRowCellValue(iRowHandle, colCOA_Code)

                                Select Case .GetRowCellDisplayText(iRowHandle, colCOA_Normal)
                                    Case "DEBIT"
                                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Chart_Of_Accounts Set Balance = '{ .GetRowCellValue(iRowHandle, colBeginning_Balance_Debit)}', Balance_Date = '{Convert.ToDateTime(.GetRowCellValue(iRowHandle, colDate_Range_Start))}' WHERE COA_Code LIKE '{ sCOACode}'")

                                    Case "CREDIT"
                                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Chart_Of_Accounts Set Balance = '{ .GetRowCellValue(iRowHandle, colBeginning_Balance_Credit)}', Balance_Date = '{Convert.ToDateTime(.GetRowCellValue(iRowHandle, colDate_Range_Start))}' WHERE COA_Code LIKE '{ sCOACode}'")
                                End Select

                                Dim frm As frm_COA_Ledger = New frm_COA_Ledger() With {
                                    .sCOACode = sCOACode,
                                    .bVirtual = True
                                }
                                frm.Data_Load()
                                frm.btn_Generate_ItemClick(sender, e)
                                frm.gridView.SelectAll()
                                frm.btn_Update_ItemClick(sender, e)
                            Next

                            class_Saga_Procedures.Show_COA_Ledger(sCOACode)

                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"The selected Beginning Balances were Set as Ledger Beginning Balances.", "Ledger Beginning Balance")
                        End If
                    End With

                Case 2
                    'If class_Database.Data_Save_Ask("Set as Ledger Beginning Balance") Then
                    With xuc_Trial_Balance_Tree
                        Select Case xuc_Trial_Balance_Tree.treeList.GetFocusedRowCellDisplayText(xuc_Trial_Balance_Tree.colCOA_Normal)
                            Case "DEBIT"
                                class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Chart_Of_Accounts Set Balance = '{ .treeList.GetFocusedRowCellValue(.colBeginning_Balance_Debit)}', Balance_Date = '{Convert.ToDateTime(.treeList.GetFocusedRowCellValue(.colBalance_Date))}' WHERE COA_Code LIKE '{ .treeList.GetFocusedRowCellValue(.colCOA_Code)}'", True)

                            Case "CREDIT"
                                class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Chart_Of_Accounts Set Balance = '{ .treeList.GetFocusedRowCellValue(.colBeginning_Balance_Credit)}', Balance_Date = '{Convert.ToDateTime(.treeList.GetFocusedRowCellValue(.colBalance_Date))}' WHERE COA_Code LIKE '{ .treeList.GetFocusedRowCellValue(.colCOA_Code)}'", True)
                        End Select

                        Dim frm As frm_COA_Ledger = New frm_COA_Ledger() With {.sCOACode = xuc_Trial_Balance_Tree.treeList.GetFocusedRowCellDisplayText(xuc_Trial_Balance_Tree.colCOA_Code)}
                        frm.Data_Load()
                        frm.btn_Generate_ItemClick(sender, e)
                        If frm.gridView.DataRowCount <= 100 Then
                            frm.btn_Update_ItemClick(sender, e)
                        End If
                    End With
                    'End If
            End Select
        End Sub

        Private Sub btn_COA_Ledger_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_COA_Ledger.ItemClick
            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0
                    class_Saga_Procedures.Show_COA_Ledger(xuc_Account_Summary.gridView.GetFocusedRowCellDisplayText(xuc_Account_Summary.colCOA_Code), xuc_Account_Summary.gridView.GetFocusedRowCellDisplayText(xuc_Account_Summary.colCOA_Name))
                Case 1
                    class_Saga_Procedures.Show_COA_Ledger(gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name))
                Case 2
                    class_Saga_Procedures.Show_COA_Ledger(xuc_Trial_Balance_Tree.treeList.GetFocusedRowCellDisplayText(xuc_Trial_Balance_Tree.colCOA_Code), xuc_Trial_Balance_Tree.treeList.GetFocusedRowCellDisplayText(xuc_Trial_Balance_Tree.colCOA_Name))
            End Select
        End Sub

        Private Sub btn_COA_Balances_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_COA_Balances.ItemClick
            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0
                    class_Saga_Procedures.Show_COA_Balances(xuc_Account_Summary.gridView.GetFocusedRowCellDisplayText(xuc_Account_Summary.colCOA_Code))
                Case 1
                    class_Saga_Procedures.Show_COA_Balances(gridView.GetFocusedRowCellDisplayText(colCOA_Code))
                Case 2
                    class_Saga_Procedures.Show_COA_Balances(xuc_Trial_Balance_Tree.treeList.GetFocusedRowCellDisplayText(xuc_Trial_Balance_Tree.colCOA_Code))
            End Select
        End Sub

        Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
            If gridView.GetFocusedRowCellDisplayText(colBalance_Status).Equals("PENDING") Then
                class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Balance, "Balance_Status", "PENDING", "FOR APPROVAL", xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Select.IsOn)
            Else
                class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Balance, "Balance_Status", "DISAPPROVED", "FOR APPROVAL", xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Select.IsOn)
            End If
        End Sub

        Private Sub btn_DisApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DisApprove.ItemClick
            'If Total_Balance_IsEqual() Then
            class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Balance, "Balance_Status", "FOR APPROVAL", "DISAPPROVED", xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Select.IsOn)
            'End If
        End Sub

        Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
            class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Balance, "Balance_Status", "FOR APPROVAL", "APPROVED", xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Select.IsOn)
        End Sub

        Private Sub btn_Lock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Lock.ItemClick
            class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Balance, "Balance_Status", "APPROVED", "LOCKED", xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Select.IsOn)
        End Sub

        Private Sub barEditItem_Branch_EditValueChanged(sender As Object, e As EventArgs) Handles barEditItem_Branch.EditValueChanged
            xuc_Account_Summary.sBrCode = barEditItem_Branch.EditValue.ToString
            xuc_Trial_Balance_Tree.sBrCode = barEditItem_Branch.EditValue.ToString
            If bLoaded Then Data_Load()
        End Sub

        Private Sub toggle_Balance_Type_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles toggle_Balance_Type.CheckedChanged
            If toggle_Balance_Type.Checked Then
                class_Saga_Variables.balanceType = eBalanceType.SUMMARY
            Else
                class_Saga_Variables.balanceType = eBalanceType.DETAIL
            End If

            With xuc_Trial_Balance_Tree
                .colBeginning_Balance_Debit.AllNodesSummary = Not toggle_Balance_Type.Checked
                .colBeginning_Balance_Credit.AllNodesSummary = Not toggle_Balance_Type.Checked
                .colTotal_Debit.AllNodesSummary = Not toggle_Balance_Type.Checked
                .colTotal_Credit.AllNodesSummary = Not toggle_Balance_Type.Checked
                .colEnding_Balance_Debit.AllNodesSummary = Not toggle_Balance_Type.Checked
                .colEnding_Balance_Credit.AllNodesSummary = Not toggle_Balance_Type.Checked
                .colBalance_Sheet.AllNodesSummary = Not toggle_Balance_Type.Checked
                .colIncome_Statement.AllNodesSummary = Not toggle_Balance_Type.Checked
            End With

            If Not XtraTabControl.SelectedTabPageIndex.Equals(0) Then
                Data_Load()
            End If
        End Sub

        Private Sub BarEditItem_Date_Type_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItem_Date_Type.EditValueChanged
            Select Case BarEditItem_Date_Type.EditValue
                Case "DAILY"
                    eDateType = class_Saga_Variables.eLoad_Type.Daily
                    xuc_Account_Summary.eDateType = class_Saga_Variables.eLoad_Type.Daily
                    xuc_Trial_Balance_Tree.eDateType = class_Saga_Variables.eLoad_Type.Daily
                    xuc_Balance_Import.eDateType = class_Saga_Variables.eLoad_Type.Daily
                Case "MONTHLY"
                    eDateType = class_Saga_Variables.eLoad_Type.Monthly
                    xuc_Account_Summary.eDateType = class_Saga_Variables.eLoad_Type.Monthly
                    xuc_Trial_Balance_Tree.eDateType = class_Saga_Variables.eLoad_Type.Monthly
                    xuc_Balance_Import.eDateType = class_Saga_Variables.eLoad_Type.Monthly
                Case "RANGE"
                    eDateType = class_Saga_Variables.eLoad_Type.Range
                    xuc_Account_Summary.eDateType = class_Saga_Variables.eLoad_Type.Range
                    xuc_Trial_Balance_Tree.eDateType = class_Saga_Variables.eLoad_Type.Range
                    xuc_Balance_Import.eDateType = class_Saga_Variables.eLoad_Type.Range
            End Select
        End Sub

    End Class

End Namespace