Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPrinting
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Accounting
    Public Class frm_Journal_Entries
        Inherits XtraForm

        Public eLoadType As eLoad_Type

        Public bInitialize, bAccountLoad As Boolean
        Friend sAccountCode, sEngine, sQuery As String
        Friend bLoaded, bLoopStop As Boolean

        Public Sub New()
            If Me.xuc_Journal_Entry Is Nothing Then
                Me.xuc_Journal_Entry = New Controls.Accounting.xuc_Journal_Entry()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, xuc_Journal_Entry.LayoutControl, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Journal_Entries_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Registry_Values_Get()

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(Me.xuc_Account_Summary, Me.xuc_Account_Summary.BarManager)
            class_Saga_Procedures.Initialize_BarManager(Me.xuc_Grid_Journal_References, Me.xuc_Grid_Journal_References.BarManager)

            class_Saga_Procedures.Initialize_Corporation(RepositoryItemLookUpEdit_Corporation)
            class_Saga_Procedures.Initialize_Branch(xuc_Journal_Entry.Journal_Branch)
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, repositoryItemLookUpEdit_Branch)
            class_Saga_Procedures.Initialize_Branch(repositoryItemLookUpEdit_Branch)
            class_Saga_Procedures.Initialize_Branch(xuc_Grid_Journal_References.RepositoryItemLookUpEdit_Branch)

            class_Saga_Procedures.Initialize_COA(RepositoryItemLookUpEdit_COA, eCOA_Type.COA_All)
            class_Saga_Procedures.Initialize_COA(xuc_Account_Summary.RepositoryItemLookUpEdit_COA, eCOA_Type.COA_All)

            class_Procedures.Initialize_gridView(Me.xuc_Account_Summary, Me.xuc_Account_Summary.gridView)
            Me.xuc_Account_Summary.eDateType = class_Saga_Variables.eLoad_Type.Range
            class_Procedures.Initialize_gridView(Me.xuc_Grid_Journal_References, Me.xuc_Grid_Journal_References.gridView)

            btn_Save.Enabled = class_Saga_Variables.isAccounting
            btn_Delete.Enabled = class_Saga_Variables.isAccounting
            btn_Approve.Enabled = class_Saga_Variables.isAccounting
            btn_Lock.Enabled = class_Saga_Variables.isAccounting
            btn_Trial_Balance.Enabled = class_Saga_Variables.isAccounting
            btn_Unverify.Enabled = class_Saga_Variables.isAccounting
        End Sub

        Private Sub frm_Journal_Entries_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            class_Saga_Procedures.Initialize_Branch(xuc_Account_Summary.RepositoryItemLookUpEdit_Branch)

            'If bInitialize AndAlso xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Journal_Entry.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Journal_Entry.Control_Initialize()

            If Not bAccountLoad AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load(False)

            class_Database.Fill_Edit(class_Database.ICSConnection, RepositoryItemComboBox_Type, "acc_Journal_Entries", "Journal_Type")

            bLoaded = True
        End Sub

        Private Sub Registry_Values_Get()
            check_Group_Entry.Checked = class_Tools.RegKeyGet(Me.Name, check_Group_Entry.Name, False)
            BarEditItem_Filter.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Filter.Name, "Default")
        End Sub

        Private Sub Registry_Values_Set()
            Me.gridView.SaveLayoutToRegistry(Me.xuc_Account_Summary.Name)
            Me.gridView.SaveLayoutToRegistry(Me.xuc_Grid_Journal_References.Name)

            class_Tools.RegKeySet(Me.Name, check_Group_Entry.Name, check_Group_Entry.Checked)
            class_Tools.RegKeySet(Me.Name, BarEditItem_Filter.Name, BarEditItem_Filter.EditValue.ToString)
        End Sub

        Private Function Form_Close() As Boolean
            class_Saga_Database.bLoopStop = True

            Registry_Values_Set()

            If xuc_Settings.Check_Save_Restore_Layout.Checked Then
                xuc_Grid_Journal_References.gridView.SaveLayoutToRegistry(xuc_Grid_Journal_References.Name)
                xuc_Account_Summary.gridView.SaveLayoutToRegistry($"{xuc_Account_Summary.Name}")
            End If

            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, xuc_Journal_Entry.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Journal_Entries_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Journal_Entry.Control_Initialize()
            class_Database.Bind_Data(class_Database.ICSConnection, RepositoryItemLookUpEdit_Profiles, "SELECT * FROM view_Journal_Profiles", "view_Journal_Profiles")
            'class_Database.Fill_Edit(class_Database.ICSConnection, RepositoryItemComboBox_Filter, "acc_Grid_Filters", "Filter_Group", "Filter_Name", Me.Name, $"AND Filter_User LIKE '{class_Variables.sUserName}'")
        End Sub

        Private Sub RepositoryItemComboBox_Filter_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles RepositoryItemComboBox_Filter.Closed
            If xuc_Settings.Toggle_Live_Looping.IsOn Then Filter_Load()
        End Sub

        Private Sub Filter_Load()
            Dim sFilter As String = BarEditItem_Filter.EditValue.ToString.Trim
            Try
                gridView.RestoreLayoutFromXml(sFilter)
            Catch Ex As System.IO.FileNotFoundException
                class_Procedures.Show_Error(ex)
            Finally
                gridView.BestFitColumns()
            End Try
        End Sub

        Private Sub btn_Filter_Load_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Filter_Load.ItemClick
            Filter_Load()
        End Sub

        Private Sub btn_Filter_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Filter_Save.ItemClick
            class_Saga_Database.Filter_Save(gridView, Me.Name, BarEditItem_Filter.EditValue.ToString)
        End Sub

        Private Sub btn_Filter_Remove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Filter_Delete.ItemClick
            Dim sFilter As String = BarEditItem_Filter.EditValue.ToString.Trim
            class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM acc_Grid_Filters WHERE Filter_Name LIKE '{sFilter}'", $"Grid Filter: sFilter")
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
            class_Saga_Database.bLoopStop = True
            xuc_Account_Summary.bLoopStop = True
            xuc_Grid_Journal_References.bLoopStop = True
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            bLoopStop = True
            Form_Reload(True)
        End Sub

        Private Sub Form_Reload(ByVal bAsk As Boolean)
            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0, 3
                    Select Case eLoadType
                        Case class_Saga_Variables.eLoad_Type.Range
                            Data_Load(bAsk)

                        Case class_Saga_Variables.eLoad_Type.CIF
                            Data_Load_Account(sAccountCode, sEngine)

                        Case class_Saga_Variables.eLoad_Type.Balance
                            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, sQuery, "view_Journal_Entries")
                    End Select

                Case 1
                    If class_Saga_Variables.dtStart.Equals(class_Saga_Variables.dtEnd) Then
                        xuc_Account_Summary.eDateType = class_Saga_Variables.eLoad_Type.Daily
                    Else
                        xuc_Account_Summary.eDateType = class_Saga_Variables.eLoad_Type.Range
                    End If
                    xuc_Account_Summary.Control_Data_Load()

                Case 2
                    xuc_Grid_Journal_References.Control_Data_Load()
            End Select
        End Sub

        Private Function Data_Load(ByVal bAsk As Boolean) As Boolean
            If class_Saga_Variables.dtEnd.Subtract(class_Saga_Variables.dtStart).Days > 30 Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"Displaying Journal Entries with more than 30 days will take some time and will cause this Application unresponsive.
                    {Environment.NewLine}Don't worry as this is normal due to large volume of Server-Client data downloading.
                    {Environment.NewLine}However, if data downloading took more time than usual - Data Error might occurred or call IT Support for assistance.
                    {Environment.NewLine}Please continue if you are certain.", "Reminder", True)
            End If

            If bAsk AndAlso Not class_Procedures.actionAsk("Download Journal Entries", $"Download Journal Entries between {class_Saga_Variables.dtStart:MMM dd, yyyy} to {class_Saga_Variables.dtEnd:MMM dd, yyyy}", "Data Error might occur Or Application will become unresposive", "adjust your Date range To decrease loading time") Then Return False

            Return Data_Load("LOAD")
        End Function

        Friend Sub Data_Load_Account(ByVal sAccountNumber As String, ByVal sEngine As String)
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Account_Code", sAccountNumber),
                New SqlParameter("@Journal_Reference", sEngine),
                New SqlParameter("@Action_Type", "LOAD_ACCOUNT")
            }

            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Journal_Procedures", "acc_Journal_Entries")
        End Sub

        Private Function Data_Load(ByVal sAction As String, Optional sType As String = "") As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue.ToString),
                New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Journal_Type", sType),
                New SqlParameter("@Action_Type", sAction)
            }

            Return class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Journal_Procedures", "acc_Journal_Entries")
        End Function

        Private Sub btn_Load_Type_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Load_Type.ItemClick
            Data_Load("LOAD_TYPE", BarEditItem_Type.EditValue.ToString)
        End Sub

        Private Sub btn_Liquidations_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Liquidations.ItemClick
            Data_Load("LOAD_LIQUIDATIONS")
        End Sub

        Private Sub btn_Unverified_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Unverified.ItemClick
            Data_Load("LOAD_UNVERIFIED")
        End Sub

        Private Sub btn_Error_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Error.ItemClick
            Data_Load("LOAD_ERROR")
        End Sub

        Private Sub btn_Deleted_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Deleted.ItemClick
            Data_Load("LOAD_DELETED")
        End Sub

        Private Sub btn_Branch_Transactions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Branch_Transactions.ItemClick
            If barEditItem_Branch.EditValue.ToString.Equals("000") Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Please specify Branch", "Branch Error", True)
                barEditItem_Branch.Links(0).Focus()
                Return
            Else
                Data_Load("LOAD_BRANCH")
            End If
        End Sub

        Friend Sub Data_Load(ByVal sCOACode As String, ByVal sBrCode As String, Optional ByVal bDateFilter As Boolean = False, Optional sQueryAdd As String = "")
            If sBrCode.Equals("000") Then
                If bDateFilter Then
                    sQuery = $"SELECT * FROM view_Journal_Entries WHERE IsDeleted <> 1 AND Corporation LIKE '{class_Saga_Variables.sCorporation}' AND COA_Code LIKE '{sCOACode}' {sQueryAdd} AND Posting_Date >= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtStart}', 23) AND Posting_Date <= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtEnd}', 23)"
                Else
                    sQuery = $"SELECT * FROM view_Journal_Entries WHERE IsDeleted <> 1 AND Corporation LIKE '{class_Saga_Variables.sCorporation}' AND COA_Code LIKE '{sCOACode}' {sQueryAdd}"
                End If
            Else
                If bDateFilter Then
                    sQuery = $"SELECT * FROM view_Journal_Entries WHERE IsDeleted <> 1 AND Corporation LIKE '{class_Saga_Variables.sCorporation}' AND COA_Code LIKE '{sCOACode}' {sQueryAdd} AND Branch_Code LIKE '{sBrCode}' AND Posting_Date >= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtStart}', 23) AND Posting_Date <= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtEnd}', 23)"
                Else
                    sQuery = $"SELECT * FROM view_Journal_Entries WHERE IsDeleted <> 1 AND Corporation LIKE '{class_Saga_Variables.sCorporation}' AND COA_Code LIKE '{sCOACode}' {sQueryAdd} AND Branch_Code LIKE '{sBrCode}'"
                End If
            End If

            'This needs recoding due to slow loading
            'If Not Me.xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Journal_Entry.Control_Initialize()
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, sQuery, "view_Journal_Entries")
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Search", sSearch),
                    New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                    New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                    New SqlParameter("@Action_Type", "SEARCH")
                }

                class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Journal_Procedures", "acc_Journal_Entries")
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

        Private Sub btn_Custom1_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Custom1.ItemClick
            If Not class_Procedures.actionAsk($"Add Journal Entry", "Add add wrong Journal Entry") Then Return

            With gridView
                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = .GetSelectedRows()

                bLoopStop = False

                .ClearSelection()

                For i As Integer = 0 To selectedRows.Length - 1
                    iRowHandle = selectedRows(i)

                    If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Check Update", "updated", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
                        iRowHandleOld = iRowHandle
                    Else Return
                    End If

                    Dim dCredit As Decimal = .GetRowCellValue(iRowHandle, colJournal_Credit)

                    Dim sqlParameters As SqlParameter() = {
                        New SqlParameter("@Check_Number", .GetRowCellDisplayText(iRowHandle, colCheck_Number)),
                        New SqlParameter("@Check_Amount", dCredit),
                        New SqlParameter("@Check_Amount_Words", class_Functions.AmountToWords(dCredit)),
                        New SqlParameter("@Modified_By", class_Variables.sUserName),
                        New SqlParameter("@Action_Type", "UPDATE_AMOUNT")
                    }

                    class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Check_Procedures", "Cash/Check Voucher")
                Next
            End With
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            If XtraTabControl.SelectedTabPageIndex.Equals(2) Then
                xuc_Grid_Journal_References.Control_Verify()
            Else
                With gridView
                    If .SelectedRowsCount > 0 Then
                        If Not class_Procedures.actionAsk("Update IsJournal", "Update IsJournal Transactions", "Update the wrong data") Then Return

                        class_Procedures.splash_Show($"Updating IsJournal Transactions of the selected Journal Entries")

                        Dim iTableID, iTableIDTemp As Integer
                        Dim iRowHandle, iRowHandleOld As Integer
                        Dim selectedRows As Integer() = .GetSelectedRows()

                        bLoopStop = False

                        If xuc_Settings.Toggle_Select.IsOn Then .ClearSelection()

                        For i As Integer = 0 To selectedRows.Length - 1
                            iRowHandle = selectedRows(i)

                            Try
                                Select Case RadioGroup_Mode.SelectedIndex
                                    Case 1
                                        If Not Convert.ToBoolean(.GetRowCellValue(iRowHandle, colIsVerified)) Then Continue For
                                    Case 2
                                        If Convert.ToBoolean(.GetRowCellValue(iRowHandle, colIsVerified)) Then Continue For
                                    Case Else
                                End Select
                            Catch ex As Exception
                            Finally
                            End Try

                            Try
                                iTableID = Convert.ToInt32(.GetRowCellValue(iRowHandle, colTable_ID))
                            Catch ex As Exception
                                iTableID = 0
                            End Try

                            If iTableID.Equals(0) Then Continue For

                            If iTableIDTemp.Equals(iTableID) Then Continue For

                            'If .GetFocusedRowCellDisplayText(colJournal_Status).Contains("ERROR") Then Continue For

                            If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Entries", "verified", bLoopStop, Me.xuc_Settings.Toggle_Live_Looping.IsOn) Then
                                iRowHandleOld = iRowHandle
                            Else Return
                            End If

                            class_Saga_Database.Journal_Verify(iTableID, "VERIFY_JOURNAL", Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)))
                            iTableIDTemp = iTableID
                        Next

                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"The selected Journal Entries were Verified.", "IsVerified Update")
                        class_Procedures.splash_Close()
                    End If
                End With
            End If
        End Sub

        Private Sub btn_Unverify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Unverify.ItemClick
            If XtraTabControl.SelectedTabPageIndex.Equals(0) Then
                With gridView
                    If .SelectedRowsCount > 0 Then
                        If Not class_Procedures.actionAsk("Un verify IsJournal", "Un verify IsJournal Transactions", "Update the wrong data") Then Return

                        class_Procedures.splash_Show($"Un verifying IsJournal Transactions of the selected Journal Entries")

                        Dim iRowHandle, iRowHandleOld As Integer
                        Dim selectedRows As Integer() = .GetSelectedRows()


                        bLoopStop = False
                        If Me.xuc_Settings.Toggle_Select.IsOn Then .ClearSelection()

                        For i As Integer = 0 To selectedRows.Length - 1
                            iRowHandle = selectedRows(i)

                            If Not Convert.ToBoolean(.GetRowCellValue(iRowHandle, colIsVerified)) Then Continue For

                            If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Entries", "unverified", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
                                iRowHandleOld = iRowHandle
                            Else Return
                            End If

                            Dim sqlParameters As SqlParameter() = {
                                New SqlParameter("@ID", .GetRowCellValue(iRowHandle, colID)),
                                New SqlParameter("@Action_Type", "UNVERIFY")
                            }

                            class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Journal_Procedures", "Un verify Journal Entries")
                            .SetRowCellValue(iRowHandle, colIsVerified, 0)
                        Next
                    End If
                End With
            End If
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            If gridView.RowCount > 0 Then
                gridView.ShowRibbonPrintPreview()
            End If
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Journal_Entry.Control_Initialize()
            xuc_Journal_Entry.Control_New(barEditItem_Branch.EditValue.ToString, xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            Form_Save()
        End Sub

        Private Sub Form_Save()
            If xuc_Journal_Entry.Control_Save() Then Update_Data_Row()
            If check_Group_Entry.Checked Then Show_Journal_Entries()
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            class_Saga_Database.Transaction_Delete(gridView, "Journal Entry/Entries", "acc_Journal_Procedures", "DELETE", Me.xuc_Settings.Toggle_Live_Looping.IsOn)
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If gridView.DataRowCount > 0 And gridView.SelectedRowsCount > 0 Then
                Select Case e.KeyValue
                    Case Keys.Enter
                        Data_Show()

                    Case Keys.F2
                        class_Saga_Procedures.Show_Journal_Entry(gridView.GetFocusedRowCellDisplayText(colID))

                    Case Keys.F6
                        Data_Show()
                        Show_Journal_Entries()

                    Case Keys.Delete
                        class_Saga_Database.Transaction_Delete(gridView, "Journal Entry/Entries", "acc_Journal_Procedures", "DELETE", Me.xuc_Settings.Toggle_Live_Looping.IsOn)

                End Select
            End If
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Journal_Entry
                    .ID.EditValue = gridView.GetFocusedRowCellValue(colID)
                    .Journal_Code.Text = gridView.GetFocusedRowCellDisplayText(colJournal_Code)
                    .Corporation.EditValue = gridView.GetFocusedRowCellValue(colCorporation)
                    .Table_ID.EditValue = gridView.GetFocusedRowCellDisplayText(colTable_ID)
                    .Journal_Branch.EditValue = gridView.GetFocusedRowCellValue(colBranch_Code)
                    .COA_Code.EditValue = gridView.GetFocusedRowCellValue(colCOA_Code)
                    .Journal_Reference.Text = gridView.GetFocusedRowCellDisplayText(colJournal_Reference)
                    .Journal_Type.Text = gridView.GetFocusedRowCellDisplayText(colJournal_Type)
                    .Journal_Profile.Text = gridView.GetFocusedRowCellDisplayText(colJournal_Profile)
                    .sProfile = .Journal_Profile.Text
                    .Account_Code.Text = gridView.GetFocusedRowCellDisplayText(colAccount_Code)
                    .Account_Name.Text = gridView.GetFocusedRowCellDisplayText(colAccount_Name)
                    .Journal_Description.Text = gridView.GetFocusedRowCellDisplayText(colJournal_Description)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                    .Journal_Debit.EditValue = gridView.GetFocusedRowCellValue(colJournal_Debit)
                    .Journal_Credit.EditValue = gridView.GetFocusedRowCellValue(colJournal_Credit)
                    .Posting_Date.EditValue = gridView.GetFocusedRowCellValue(colPosting_Date)
                    .Voucher_Reference.EditValue = gridView.GetFocusedRowCellValue(colVoucher_Reference)

                    Try
                        .toggle_Liquidated.IsOn = gridView.GetFocusedRowCellValue(colIsLiquidated)
                        .Liquidation_Justification.Text = gridView.GetFocusedRowCellDisplayText(colJustification)
                    Catch ex As Exception
                        .toggle_Liquidated.EditValue = False
                        .Liquidation_Justification.ResetText()
                    End Try

                    .Check_Number.Text = gridView.GetFocusedRowCellDisplayText(colCheck_Number)
                    If .Check_Number.Text.Length > 0 Then
                        .Initialize_Check()
                    End If
                End With
            End If
        End Sub

        Private Sub Update_Data_Row()
            If gridView.RowCount > 0 Then
                With gridView
                    .SetFocusedRowCellValue(colCorporation, xuc_Journal_Entry.Corporation.Text)
                    .SetFocusedRowCellValue(colTable_ID, xuc_Journal_Entry.Table_ID.EditValue)
                    .SetFocusedRowCellValue(colBranch_Code, xuc_Journal_Entry.Journal_Branch.EditValue)
                    .SetFocusedRowCellValue(colCOA_Code, xuc_Journal_Entry.COA_Code.EditValue)
                    .SetFocusedRowCellValue(colCOA_Name, xuc_Journal_Entry.COA_Code.Text)
                    .SetFocusedRowCellValue(colJournal_Reference, xuc_Journal_Entry.Journal_Reference.Text)
                    .SetFocusedRowCellValue(colJournal_Type, xuc_Journal_Entry.Journal_Type.Text)
                    .SetFocusedRowCellValue(colJournal_Profile, xuc_Journal_Entry.Journal_Profile.Text)
                    .SetFocusedRowCellValue(colAccount_Code, xuc_Journal_Entry.Account_Code.Text)
                    .SetFocusedRowCellValue(colCheck_Number, xuc_Journal_Entry.Check_Number.EditValue)
                    .SetFocusedRowCellValue(colAccount_Name, xuc_Journal_Entry.Account_Name.Text)
                    .SetFocusedRowCellValue(colJournal_Description, xuc_Journal_Entry.Journal_Description.Text)
                    .SetFocusedRowCellValue(colJournal_Debit, xuc_Journal_Entry.Journal_Debit.Text)
                    .SetFocusedRowCellValue(colJournal_Credit, xuc_Journal_Entry.Journal_Credit.Text)
                    .SetFocusedRowCellValue(colCheck_Number, xuc_Journal_Entry.Check_Number.Text)
                    .SetFocusedRowCellValue(colPosting_Date, xuc_Journal_Entry.Posting_Date.EditValue)
                    .SetFocusedRowCellValue(colVoucher_Reference, xuc_Journal_Entry.Voucher_Reference.EditValue)
                    .SetFocusedRowCellValue(colNotes, xuc_Journal_Entry.Notes.Text)
                End With
            End If
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                popupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Dim sAccount As String = gridView.GetFocusedRowCellDisplayText(colAccount_Code)
                Dim sCodes As String() = sAccount.Split(New Char() {"-"c})
                Dim sAccountCode As String = sCodes(0)
                Dim iLedger As Integer

                Dim sAccountType As String = gridView.GetFocusedRowCellDisplayText(colJournal_Type)

                Select Case e.Column.Name
                    Case "colID", "colJournal_Code"
                        class_Saga_Procedures.Show_Journal_Entry(gridView.GetFocusedRowCellDisplayText(colID))

                    Case "colCOA_Code"
                        class_Saga_Procedures.Show_COA(e.CellValue.ToString)

                    Case "colCOA_Name"
                        class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.CIF, gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name))

                    Case "colJournal_Reference"
                        Data_Show()
                        Show_Journal_Entries()

                    Case "colAccount_Code"
                        If sAccountType.Contains("RECEIVING") Then
                            class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                        ElseIf sAccountType.Contains("TRANS") Then
                            class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                        ElseIf sAccountType.Contains("RELEASE") Or sAccountType.Contains("ASSUME") Or sAccountType.Contains("CASHIERING") Or sAccountType.Contains("PAYMENT") Then
                            Try
                                iLedger = Convert.ToInt32(sCodes(1))
                                class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, sAccountCode, iLedger)
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                            End Try

                        ElseIf sAccountType.Contains("ACQUIRED") Then
                            Try
                                iLedger = Convert.ToInt32(sCodes(1))
                                class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, sAccountCode, iLedger)
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                            End Try
                        End If

                    Case "colCheck_Number"
                        class_Saga_Procedures.Show_Check(e.CellValue.ToString)

                    Case "colVoucher_Reference"
                        class_Saga_Procedures.Show_Voucher(e.CellValue.ToString)

                    Case "colTransacted_By", "colAdded_By", "colModified_By", "colApproved_By"
                        class_Saga_Procedures.Show_User_Activity(e.CellValue.ToString)

                    Case Else
                        Data_Show()
                End Select

                If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)
            End If
        End Sub

        Private Sub Show_Journal_Entries()
            With gridView
                Try
                    class_Saga_Procedures.Show_Journal_Entries_Reference(.GetFocusedRowCellValue(colID),
                                                                         .GetFocusedRowCellValue(colTable_ID),
                                                                         .GetFocusedRowCellDisplayText(colJournal_Reference),
                                                                         .GetFocusedRowCellValue(colBranch_Code),
                                                                         .GetFocusedRowCellDisplayText(colJournal_Type),
                                                                         .GetFocusedRowCellDisplayText(colJournal_Profile),
                                                                         .GetFocusedRowCellDisplayText(colAccount_Code),
                                                                         .GetFocusedRowCellDisplayText(colAccount_Name),
                                                                         .GetFocusedRowCellValue(colPosting_Date),
                                                                         class_Saga_Functions.Approver,
                                                                         .GetFocusedRowCellValue(colCOA_Code),
                                                                         .GetFocusedRowCellValue(colCheck_Number),
                                                                         .GetFocusedRowCellDisplayText(colJournal_Description))
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                    Me.xuc_Journal_Entry.Journal_Branch.Select()
                End Try
            End With
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            Show_Journal_Entries()
        End Sub

        Private Sub btn_Journal_Entries2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries2.ItemClick
            Dim sType = gridView.GetFocusedRowCellDisplayText(colJournal_Type)
            If sType.Contains("TRANSFER") Or sType.Contains("ACQUIRED") Or sType.Contains("RELEASE") Or sType.Contains("ASSUME") Or sType.Contains("COLLECTION") Then
                class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.CIF, gridView.GetFocusedRowCellDisplayText(colAccount_Code), gridView.GetFocusedRowCellDisplayText(colAccount_Name), gridView.GetFocusedRowCellDisplayText(colJournal_Reference))
            End If
        End Sub

        Private Sub btn_Batch_Transactions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Batch_Transactions.ItemClick
            class_Saga_Procedures.Show_Batch_Transactions(gridView, repositoryItemLookUpEdit_Branch, gridView.GetFocusedRowCellDisplayText(colJournal_Reference))
        End Sub

        Private Sub btn_Ledger_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Ledger.ItemClick
            class_Saga_Procedures.Show_COA_Ledger(gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name))
        End Sub

        Private Sub btn_Validation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Validate.ItemClick
            Dim dDebit, dCredit As Decimal

            If gridView.DataRowCount > 0 Then
                class_Procedures.splash_Show("Validating Journal Entries")
                bLoopStop = False
                Dim iGroupRow As Integer

                For i As Integer = 0 To gridView.DataRowCount
                    If bLoopStop Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"The user stopped the validation process.")
                        Exit For
                    End If

                    iGroupRow = gridView.GetParentRowHandle(gridView.GetRowHandle(i))

                    Try
                        'This needs to be reprogrammed as suddenly shows error when it's working fine before
                        dDebit = Math.Round(Convert.ToDecimal(gridView.GetGroupSummaryValue(iGroupRow, TryCast(gridView.GroupSummary(0), GridGroupSummaryItem))), 2)
                        dCredit = Math.Round(Convert.ToDecimal(gridView.GetGroupSummaryValue(iGroupRow, TryCast(gridView.GroupSummary(1), GridGroupSummaryItem))), 2)
                    Catch Ex As ArgumentOutOfRangeException

                    End Try

                    If dDebit.Equals(dCredit) Then
                        gridView.CollapseGroupRow(iGroupRow)
                    Else
                        gridView.ExpandGroupRow(iGroupRow)
                    End If

                    If xuc_Settings.Toggle_Live_Looping.IsOn Then
                        gridView.FocusedRowHandle = i
                        gridView.MakeRowVisible(i)
                        Application.DoEvents()
                    End If
                Next
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"The Journal Entries were Validated.", "IsJournal Update")
                class_Procedures.splash_Close()
            End If
        End Sub

        Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
            class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Journal, "Journal_Status", "PENDING", "FOR APPROVAL", xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Select.IsOn)
            xuc_Settings.Toggle_Live_Looping.IsOn = True
        End Sub

        Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
            If class_Saga_Variables.isAccounting Then
                class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Journal, "Journal_Status", "FOR APPROVAL", "APPROVED", xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Select.IsOn)
                xuc_Settings.Toggle_Live_Looping.IsOn = True
            Else
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Approving Journal Entries is unauthorized.{Environment.NewLine}Please contact Admin or Administrator.", "Unauthorized Access", True)
            End If
        End Sub

        Private Sub btn_Lock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Lock.ItemClick
            If class_Variables.isAdministrator Then
                class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Journal, "Journal_Status", "APPROVED", "LOCKED", xuc_Settings.Toggle_Live_Looping.IsOn, xuc_Settings.Toggle_Select.IsOn)
                xuc_Settings.Toggle_Live_Looping.IsOn = True
            Else
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Locking Journal Entries is unauthorized.{Environment.NewLine}Please contact Admin or Administrator.", "Unauthorized Access", True)
            End If
        End Sub

        Private Sub btn_Dashboard_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Dashboard.ItemClick

        End Sub

        Private Sub btn_Proof_Sheet_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Proof_Sheet.ItemClick
            If gridView.RowCount > 0 Then
                Dim xRpt As Reports.Accounting.xrpt_Proof_Sheet = New Reports.Accounting.xrpt_Proof_Sheet()

                Try
                    With xRpt
                        .PaperKind = System.Drawing.Printing.PaperKind.Custom
                        .PageWidth = 850
                        .PageHeight = 1300

                        .XrLabel_Corporation.Text = class_Saga_Database.get_Corporation_Name(class_Saga_Variables.sCorporation)

                        .Product_Version.Text = $"{$"{Application.ProductName} {Application.ProductVersion}™ {Date.Now.Year}"} - IT Department"

                        .Branch_Name.Text = repositoryItemLookUpEdit_Branch.GetDisplayValueByKeyValue(barEditItem_Branch.EditValue).ToString
                        .Transaction_Date.Text = $"{class_Saga_Variables.dtStart:MMM dd, yyyy} - {class_Saga_Variables.dtEnd:MMM dd, yyyy}"

                        Dim sActionType As String = Nothing
                        If Toggle_Branch_HO.Checked Then
                            sActionType = "PROOF_SHEET_ALL"
                        Else
                            sActionType = "PROOF_SHEET"
                        End If

                        Dim sqlParameters As SqlParameter() = {
                            New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                            New SqlParameter("@Branch_Code", barEditItem_Branch.EditValue.ToString),
                            New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                            New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                            New SqlParameter("@Action_Type", sActionType)
                        }

                        class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "acc_Journal_Procedures", "acc_Journal_Entries")
                    End With
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                Finally

                End Try
            End If
        End Sub

        Private Sub btn_Trial_Balance_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Trial_Balance.ItemClick
            'With gridView
            '    If .SelectedRowsCount > 0 Then
            '        If Not class_Procedures.actionAsk("Update Trial Balances", "Update Trial Balances") Then Return

            '        class_Procedures.splash_Show("Updating Trial Balances")

            '        Dim iRowHandle, iRowHandleOld As Integer
            '        Dim selectedRows As Integer() = .GetSelectedRows()

            '        
            '        bLoopStop = False
            '        .ClearSelection()

            '        For i As Integer = 0 To selectedRows.Length - 1
            '            iRowHandle = selectedRows(i)

            '            If class_Functions.gridView_Loop(1gridView, iRowHandleOld, iRowHandle, "Trial Balance", "updated", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
            '                iRowHandleOld = iRowHandle
            '            Else
            '                Return
            '            End If

            '            If class_Saga_Database.Balance_Save(1.GetRowCellDisplayText(iRowHandle, colCOA_Code), class_Functions.FirstDayOfMonth(class_Saga_Variables.dtStart)) Then
            '                .SetRowCellValue(iRowHandle, colNotes, "Trial Balance Updated")
            '            End If
            '        Next

            '        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"The selected Trial Balances were Updated.", "Trial Balance Update")
            '        class_Procedures.splash_Close()
            '    End If
            'End With
        End Sub

        Private Sub barEditItem_Branch_EditValueChanged(sender As Object, e As EventArgs) Handles barEditItem_Branch.EditValueChanged
            Me.xuc_Account_Summary.sBrCode = barEditItem_Branch.EditValue.ToString
        End Sub

        Private Sub RadioGroup_Verification_Mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup_Verification_Mode.SelectedIndexChanged
            Select Case RadioGroup_Verification_Mode.SelectedIndex
                Case 0
                    xuc_Grid_Journal_References.eVerification = SagaClassLibrary.Controls.Accounting.xuc_Grid_Journal_References.VerifyMode.TableID
                Case 1
                    xuc_Grid_Journal_References.eVerification = SagaClassLibrary.Controls.Accounting.xuc_Grid_Journal_References.VerifyMode.Reference
            End Select
        End Sub

    End Class

End Namespace