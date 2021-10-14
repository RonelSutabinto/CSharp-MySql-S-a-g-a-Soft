Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Controls.Accounting

    Public Class xuc_Journal_Entries
        Public voucherType As eVoucherType

        Private _postingDate As Date
        Public Property PostingDate() As Date
            Get
                Return _postingDate
            End Get
            Set(ByVal value As Date)
                _postingDate = value
            End Set
        End Property

        Private _IdTable As Integer
        Public Property IDTable() As Integer
            Get
                Return _IdTable
            End Get
            Set(ByVal value As Integer)
                _IdTable = value
            End Set
        End Property

        Private _reference As String
        Public Property Reference() As String
            Get
                Return _reference
            End Get
            Set(ByVal value As String)
                _reference = value
            End Set
        End Property

        Private _type As String
        Public Property JournalType() As String
            Get
                Return _type
            End Get
            Set(ByVal value As String)
                _type = value
            End Set
        End Property

        Private _journalProfile As String
        Public Property JournalProfile() As String
            Get
                Return _journalProfile
            End Get
            Set(ByVal value As String)
                _journalProfile = value
            End Set
        End Property

        Private _accountCode As String
        Public Property AccountCode() As String
            Get
                Return _accountCode
            End Get
            Set(ByVal value As String)
                _accountCode = value
            End Set
        End Property

        Private _accountName As String
        Public Property AccountName() As String
            Get
                Return _accountName
            End Get
            Set(ByVal value As String)
                _accountName = value
            End Set
        End Property

        Friend sTitle, sApprover, sBrCode, sCOA, sCheck, sDescription, sDebit As String
        Friend bAccountCodeAsReference, bLoopStop, bAutoCredit, bUnbalanced, bForLiquidation, bLTO As Boolean

        Private bRowInsert, bTemplate As Boolean
        Private sJournalCode, stemplateCOACode As String

        Friend Sub Data_Load(ByVal sReference As String, Optional ByVal iID As Integer = 0, Optional bAsk As Boolean = False, Optional ByVal bAccountCodeAsReference As Boolean = False, Optional ByVal sAccountCode As String = "", Optional ByVal bShowDeleted As Boolean = False)
            Dim sQueryDeleted As String = "IsDeleted <> 1 AND"

            If bShowDeleted Then sQueryDeleted = String.Empty

            If bAsk AndAlso Not class_Procedures.actionAsk("Reload", "Reload Journal Entries", "You might lose unsaved data") Then Return

            If bAccountCodeAsReference Then
                Me.bAccountCodeAsReference = bAccountCodeAsReference
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Account_Code", sAccountCode),
                    New SqlParameter("@Action_Type", "LOAD_ACCOUNT_CODE")
                }
                class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Journal_Procedures", "acc_Journal_Entries")
            Else
                Dim sActionType As String
                If bShowDeleted Then
                    sActionType = "LOAD_REF_DEL"
                Else
                    sActionType = "LOAD_REFERENCE"
                End If

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Journal_Reference", sReference),
                    New SqlParameter("@Action_Type", sActionType)
                }
                class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Journal_Procedures", "acc_Journal_Entries")
            End If

            With gridView
                If .DataRowCount > 0 Then
                    If iID > 0 Then
                        .ClearSelection()

                        For i As Integer = 0 To .DataRowCount - 1
                            If Convert.ToInt32(.GetRowCellValue(i, colTable_ID)).Equals(iID) Then
                                .MakeRowVisible(i)
                                .SelectRow(i)
                                Exit For
                            End If
                        Next
                    End If
                Else
                    Dim sqlParameters As SqlParameter() = {
                        New SqlParameter("@Template_Name", JournalProfile),
                        New SqlParameter("@Action_Type", "RETRIEVE")
                    }
                    Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Journal_Template_Procedures")
                        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                            bTemplate = True
                            myDataReader.Read()
                            Dim sCOACode As String() = myDataReader("Template_COA_Codes").ToString.Split(New Char() {","c})
                            sDescription = myDataReader("Template_Description").ToString

                            For i As Integer = 0 To sCOACode.Length - 1
                                stemplateCOACode = sCOACode(i)
                                .AddNewRow()
                            Next
                            bTemplate = False
                        End If
                    End Using
                End If

                .ClearGrouping()
                .ClearSorting()
                colJournal_Code.SortIndex = 0
            End With
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load(Reference, 0, gridView.Editable)
        End Sub

        Private Sub btn_Initialize_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Initialize.ItemClick

        End Sub

        Private Sub btn_New_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_New.ItemClick
            gridView.AddNewRow()
        End Sub

        Private Sub btn_Regenerate_Codes_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Regenerate_Codes.ItemClick
            Repair_Primary_Keys()
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Save.ItemClick
            Journal_Entries_Save()
        End Sub

        Private Sub btn_Validate_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Validate.ItemClick

        End Sub

        Private Sub repositoryItemLookUpEdit_Branch_EditValueChanged(sender As Object, e As EventArgs) Handles repositoryItemLookUpEdit_Branch.EditValueChanged
            Try
                sBrCode = CType(sender, BaseEdit).EditValue.ToString
            Catch ex As Exception
            End Try
        End Sub

        Private Sub RepositoryItemLookUpEdit_COA_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit_COA.EditValueChanged
            Try
                sCOA = CType(sender, BaseEdit).EditValue.ToString
            Catch ex As Exception
            End Try
        End Sub

        Private Sub RepositoryItemDateEdit_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemDateEdit.EditValueChanged
            Try
                PostingDate = Convert.ToDateTime(CType(sender, BaseEdit).EditValue)
            Catch ex As Exception
            End Try
        End Sub

        Private Sub RepositoryItemPopupContainerEdit_BeforePopup(sender As Object, e As EventArgs) Handles RepositoryItemPopupContainerEdit.BeforePopup
            PopupContainerControl.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Width", 500)
            PopupContainerControl.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Height", 400)
        End Sub

        Private Sub RepositoryItemPopupContainerEdit_Popup(sender As Object, e As EventArgs) Handles RepositoryItemPopupContainerEdit.Popup
            xuc_Account_Search.searchMode = Information.Account.xuc_Account_Search.Search_Mode.searchGlobal
            xuc_Account_Search.Load_Search(gridView.GetFocusedRowCellDisplayText(colAccount_Name))
        End Sub

        Private Sub RepositoryItemPopupContainerEdit_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles RepositoryItemPopupContainerEdit.Closed
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Width", PopupContainerControl.Width)
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Height", PopupContainerControl.Height)

            Get_Searched_Name()
        End Sub

        Private Sub Get_Searched_Name()
            AccountCode = xuc_Account_Search.Code
            AccountName = xuc_Account_Search.AccountName

            gridView.SetFocusedRowCellValue(colAccount_Code, AccountCode)
            gridView.SetFocusedRowCellValue(colAccount_Name, AccountName)
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            'If gridView.RowCount > 0 AndAlso
            If e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            gridView.BestFitColumns()
        End Sub

        Private Sub gridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView.CellValueChanged
            Try
                Select Case e.Column.Name
                    Case "colCOA_Name"
                        'class_Saga_Variables.Initialize_Check(gridView.GetRowCellValue(e.RowHandle, colCOA_Name).ToString)
                        class_Saga_Procedures.Initialize_Check(RepositoryItemLookUpEdit_Check_Numbers, gridView.GetRowCellValue(e.RowHandle, colCOA_Name).ToString)

                    Case "colJournal_Debit"
                        If Convert.ToDecimal(e.Value) > 0 Then
                            gridView.SetRowCellValue(e.RowHandle, colJournal_Credit, 0)
                        End If

                    Case "colJournal_Credit"
                        If Convert.ToDecimal(e.Value) > 0 Then
                            gridView.SetRowCellValue(e.RowHandle, colJournal_Debit, 0)
                        End If

                    Case "colJournal_Description"
                        sDescription = gridView.GetRowCellValue(gridView.FocusedRowHandle, colJournal_Description).ToString
                End Select
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub gridView_InitNewRow(sender As Object, e As Grid.InitNewRowEventArgs) Handles gridView.InitNewRow
            Dim view As Grid.GridView = TryCast(sender, Grid.GridView)
            Dim sJournalPreCode As String

            Select Case voucherType
                Case class_Saga_Variables.eVoucherType.Check
                    sJournalPreCode = "VOUCHER"
                Case Else
                    sJournalPreCode = "JOURNAL"
            End Select

            If bRowInsert Then
                view.SetRowCellValue(e.RowHandle, colJournal_Code, sJournalCode)
            Else
                view.SetRowCellValue(e.RowHandle, colJournal_Code, class_Functions.AutoID(sJournalPreCode))
            End If

            If bTemplate Then
                view.SetRowCellValue(e.RowHandle, colCOA_Name, stemplateCOACode)
            Else
                view.SetRowCellValue(e.RowHandle, colCOA_Name, sCOA)
            End If

            view.SetRowCellValue(e.RowHandle, colTable_ID, IDTable)
            view.SetRowCellValue(e.RowHandle, colCorporation, class_Saga_Variables.sCorporation)
            view.SetRowCellValue(e.RowHandle, colBranch_Code, sBrCode)
            view.SetRowCellValue(e.RowHandle, colJournal_Type, JournalType)
            view.SetRowCellValue(e.RowHandle, colJournal_Profile, JournalProfile)
            view.SetRowCellValue(e.RowHandle, colAccount_Code, AccountCode)
            view.SetRowCellValue(e.RowHandle, colAccount_Name, AccountName)
            view.SetRowCellValue(e.RowHandle, colJournal_Description, sDescription)
            view.SetRowCellValue(e.RowHandle, colPosting_Date, PostingDate)
            view.SetRowCellValue(e.RowHandle, colCheck_Number, 0)

            Dim dResult As Decimal = Convert.ToDecimal(colJournal_Debit.SummaryItem.SummaryValue) - Convert.ToDecimal(colJournal_Credit.SummaryItem.SummaryValue)

            If bAutoCredit Then
                If dResult > 0 Then
                    view.SetRowCellValue(e.RowHandle, colJournal_Credit, dResult)
                Else
                    view.SetRowCellValue(e.RowHandle, colJournal_Debit, Convert.ToDecimal(colJournal_Credit.SummaryItem.SummaryValue) - Convert.ToDecimal(colJournal_Debit.SummaryItem.SummaryValue))
                End If
            End If

            view.BestFitColumns()
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then

                Dim sAccountType As String = gridView.GetFocusedRowCellDisplayText(colJournal_Type)
                Select Case e.Column.Name
                    Case "colID", "colJournal_Code"
                        class_Saga_Procedures.Show_Journal_Entry(gridView.GetFocusedRowCellDisplayText(colID))

                    Case "colTable_ID"
                        Try
                            If sAccountType.Contains("VOUCHER") Then
                                class_Saga_Procedures.Show_Voucher(Reference)
                            ElseIf sAccountType.Contains("RELEASE") Or sAccountType.Contains("ACQUIRED") Or sAccountType.Contains("ASSUME") Then
                                class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.ID, e.CellValue.ToString)
                            ElseIf sAccountType.Contains("PAYMENT") Then
                                class_Saga_Procedures.Show_Account_Payment(False, e.CellValue.ToString)
                            ElseIf sAccountType.Contains("CASHIERING") Then
                                If sAccountType.Contains("IBC") Then
                                    class_Saga_Procedures.Show_Account_Payment(True, e.CellValue.ToString)
                                ElseIf sAccountType.Contains("CM") Then
                                Else
                                End If
                            End If
                        Catch ex As Exception

                        End Try

                    Case "colCOA_Code"
                        class_Saga_Procedures.Show_COA(e.CellValue.ToString)

                    Case "colCheck_Number"
                        class_Saga_Procedures.Show_Check(e.CellValue.ToString)

                    Case "colPosting_Date"
                        colPosting_Date.OptionsColumn.AllowEdit = True

                    Case "colAccount_Code"
                        Dim sAccount As String = gridView.GetFocusedRowCellDisplayText(colAccount_Code)
                        Dim sCodes As String() = sAccount.Split(New Char() {"-"c})
                        Dim sAccountCode As String = sCodes(0).Trim
                        Dim iLedger As Integer

                        If sAccountCode.Contains("NAME") Then
                            class_Saga_Procedures.Show_Account_Name(e.CellValue.ToString)

                        ElseIf sAccountCode.Contains("EMPL") Then
                            'class_Saga_Procedures.Show_Employee(e.CellValue.ToString)

                        ElseIf sAccountType.Contains("RECEIVING") Then
                            class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                        ElseIf sAccountType.Contains("TRANS") Then
                            class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                        ElseIf sAccountType.Contains("RELEASE") Or sAccountType.Contains("DEPOSIT") Or sAccountType.Contains("ASSUME") Or sAccountType.Contains("CASHIERING") Or sAccountType.Contains("PAYMENT") Then
                            Try
                                iLedger = Convert.ToInt32(sCodes(1).Trim)
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

                    Case Else

                End Select
                If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles gridView.KeyDown
            If gridView.SelectedRowsCount > 0 Then
                Select Case e.KeyCode
                    Case Keys.Insert
                        bRowInsert = False
                        gridView.AddNewRow()

                    Case Keys.F2
                        If Convert.ToInt32(gridView.GetFocusedRowCellValue(colID)) > 0 Then
                            class_Saga_Procedures.Show_Journal_Entry(gridView.GetFocusedRowCellDisplayText(colID))
                        End If

                    Case Keys.Delete
                        If class_Saga_Variables.isAccounting Then
                            class_Saga_Database.Transaction_Delete(gridView, "Journal Entry/Entries", "acc_Journal_Procedures", "DELETE")
                        Else
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Deleting Journal Entries is unauthorized.{Environment.NewLine}Please contact Admin or Administrator.", "Unauthorized Access", True)
                        End If
                End Select
            End If
        End Sub

        Friend Sub Repair_Primary_Keys()
            If gridView.DataRowCount > 0 Then
                For i As Integer = 0 To gridView.DataRowCount - 1
                    Try
                        If Convert.ToInt32(gridView.GetRowCellValue(i, colID)) > 0 Then Continue For
                    Catch ex As Exception
                        Dim sJournalPreCode As String
                        Select Case voucherType
                            Case class_Saga_Variables.eVoucherType.Check
                                sJournalPreCode = "VOUCHER"
                            Case Else
                                sJournalPreCode = "JOURNAL"
                        End Select
                        gridView.SetRowCellValue(i, colJournal_Code, class_Functions.AutoID(sJournalPreCode))
                    End Try
                Next
            End If
        End Sub

        Private Function IsValidated() As Boolean
            Dim sBrCode As String
            If gridView.DataRowCount > 0 Then
                For i As Integer = 0 To gridView.DataRowCount - 1
                    Try
                        sBrCode = repositoryItemLookUpEdit_Branch.GetKeyValueByDisplayText(gridView.GetRowCellDisplayText(i, colBranch_Code)).ToString
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "One/Some of the Branches was/were not specified.", "Branch Unspecified", True)
                        Return False
                    End Try
                Next
            End If
            Return True
        End Function

        'Insert new entry next to the selected entry...
        Private Sub btn_Insert_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Insert.ItemClick
            Dim iCount As Integer = class_Functions.Show_Input_Box("How many New Entries to be inserted?", "Inser New Entries", 1)
            Dim iRow As Integer = gridView.FocusedRowHandle

            Try
                For i As Integer = 0 To iCount - 1
                    sJournalCode = class_Functions.Code_Increment(gridView.GetFocusedRowCellDisplayText(colJournal_Code), 3)
                    bRowInsert = True
                    gridView.AddNewRow()
                    bRowInsert = False
                Next
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try

            gridView.MakeRowVisible(iRow)
        End Sub

        Friend Function Journal_Entries_Save() As Boolean
            If gridView.DataRowCount > 0 Then
                If Not IsValidated() Then Return False

                Dim dtPosting As Date
                Try
                    dtPosting = Convert.ToDateTime(gridView.GetRowCellValue(0, colPosting_Date))
                Catch ex As Exception
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"Please delete first Data Row", "Invalid Data Row", True)
                    Return False
                End Try

                If Not class_Database.Data_Save_Ask(Reference) Then Return False

                If Not class_Saga_Functions.IsEqualSummary(colJournal_Debit, colJournal_Credit) And Not bUnbalanced Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"New Journal Entries cannot be saved because Total Debit And Total Credit are not equal!", "Debit/Credit not Equal", True)
                    Return False
                End If

                class_Procedures.splash_Show("Executing Journal Entries")

                If class_Saga_Database.Is_Ceiling_Reached(bForLiquidation, bLTO, Math.Round(Convert.ToDecimal(colJournal_Debit.SummaryItem.SummaryValue), 2)) Then Return False

                For iRowHandle As Integer = 0 To gridView.DataRowCount - 1
                    If Not dtPosting.Equals(Convert.ToDateTime(gridView.GetRowCellValue(iRowHandle, colPosting_Date))) Then
                        gridView.SelectRow(iRowHandle)
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"Some posting dates are not equal", "Posting Dates Error")
                    End If

                    Dim iID As Integer
                    Try
                        iID = Convert.ToInt32(gridView.GetRowCellValue(iRowHandle, colID))
                        If iID >= 0 Then
                            Continue For
                        End If
                    Catch
                        iID = 0
                    End Try

                    Dim sCOACode As String
                    Try
                        sCOACode = gridView.GetRowCellDisplayText(iRowHandle, colCOA_Code)
                    Catch ex As Exception
                        Continue For
                    End Try

                    Dim dDebit As Decimal = 0
                    If gridView.GetRowCellValue(iRowHandle, colJournal_Debit) IsNot Nothing Then
                        dDebit = gridView.GetRowCellValue(iRowHandle, colJournal_Debit)
                    End If

                    Dim dCredit As Decimal = 0
                    If gridView.GetRowCellValue(iRowHandle, colJournal_Credit) IsNot Nothing Then
                        dCredit = gridView.GetRowCellValue(iRowHandle, colJournal_Credit)
                    End If

                    'Dim dbalance As Decimal = RepositoryItemLookUpEdit_COA.GetDisplayValueByKeyValue("Balance_Running")
                    'Dim dLimit As Decimal = RepositoryItemLookUpEdit_COA.GetKeyValueByDisplayText("Balance_Limit")

                    'If sCOACode.Equals("10404") Then
                    '    Dim dBalance As Decimal = convert.todecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COA_Code, Balance_Running FROM acc_Chart_Of_Accounts WHERE COA_Code LIKE '{sCOACode}'", "Balance_Running")
                    '    Dim dLimit As Decimal = convert.todecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COA_Code, Balance_Limit FROM acc_Chart_Of_Accounts WHERE COA_Code LIKE '{sCOACode}'", "Balance_Limit")

                    '    If iID.Equals(0) AndAlso dLimit > 0 AndAlso dDebit + dBalance > dLimit Then
                    '        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Amount Requested has exceeded the maximum limit.{Environment.NewLine}Please contact Administrator for information.", "Debit Error", True)
                    '        Return False
                    '    End If

                    '    class_Saga_Variables.Initialize_COA()
                    '    class_Saga_Variables.Initialize_COA_Summary()
                    '    class_Saga_Variables.Initialize_COA_Detail()
                    'End If

                    Dim sCOASummary As String = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COA_Code, COA_Summary FROM acc_Chart_Of_Accounts WHERE COA_Code LIKE '{sCOACode}'", "COA_Summary")
                    If sCOASummary.Equals("10410") Then
                        Dim dTotalAdvances As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, "SELECT SUM(Balance) AS Balance, COA_Summary FROM acc_Chart_Of_Accounts WHERE COA_Summary LIKE '10410' GROUP BY COA_Summary", "Balance"))
                        If dTotalAdvances > 750000 Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"The requested Employee Cash Advance of {dDebit:N2} has been exceeded the maximum limit of P750k.{Environment.NewLine}The Current Total Cash Advances is P{dTotalAdvances:N2}{Environment.NewLine}Please contact Administrator for information.", "Cash Advance Error", True)
                            Return False
                        End If
                    End If

                    If class_Saga_Database.Journal_Entry_Save(Convert.ToBoolean(iID),
                                                              IDTable,
                                                              gridView.GetRowCellDisplayText(iRowHandle, colJournal_Code),
                                                              class_Saga_Variables.sCorporation,
                                                              gridView.GetRowCellValue(iRowHandle, colBranch_Code),
                                                              sCOACode,
                                                              Reference,
                                                              gridView.GetRowCellDisplayText(iRowHandle, colJournal_Type),
                                                              gridView.GetRowCellDisplayText(iRowHandle, colJournal_Profile),
                                                              gridView.GetRowCellDisplayText(iRowHandle, colAccount_Code),
                                                              gridView.GetRowCellDisplayText(iRowHandle, colAccount_Name),
                                                              dDebit,
                                                              dCredit,
                                                              gridView.GetRowCellDisplayText(iRowHandle, colJournal_Description),
                                                              class_Variables.sUserName,
                                                              Convert.ToDateTime(gridView.GetRowCellValue(iRowHandle, colPosting_Date)),
                                                              gridView.GetRowCellDisplayText(iRowHandle, colNotes)) Then
                        gridView.SetRowCellValue(iRowHandle, colID, iRowHandle.ToString)
                        gridView.FocusedRowHandle = iRowHandle
                        gridView.MakeRowVisible(iRowHandle)
                        Application.DoEvents()
                    Else
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"None/Some Journal Entries were saved due to Server/Network Error.{Environment.NewLine}Please check the connection and click Save again.", "Journal Entries saving Error")
                        Return False
                    End If
                Next

                class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Vouchers SET Voucher_Debit = '{Convert.ToDecimal(colJournal_Debit.SummaryItem.SummaryValue)}', Voucher_Credit = '{Convert.ToDecimal(colJournal_Credit.SummaryItem.SummaryValue)}' WHERE Voucher_Reference LIKE '{Reference}'")

                If bForLiquidation Then
                    class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Liquidations SET Liquidation_Total = '{Convert.ToDecimal(colJournal_Debit.SummaryItem.SummaryValue)}' WHERE Voucher_Reference LIKE '{Reference}'", True)
                End If

                If Not class_Saga_Functions.IsEqualSummary(colJournal_Debit, colJournal_Credit) And bUnbalanced Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"New Journal Entries were saved although Total Debit And Total Credit are not equal!", "Debit/Credit not Equal", True)
                End If

                class_Procedures.splash_Close()

                If class_Database.DBError Then
                    Return False
                Else
                    Data_Load(Reference)
                    Return True
                End If
            End If
            Return False
        End Function

        Friend Sub Journal_Template_Save()
            Dim sTemplateName As String = class_Functions.Show_Input_Box("Input Template Name", "Template Name", JournalProfile)
            Dim sTemplateDescription As String = class_Functions.Show_Input_Box("Input Template Description", "Template Description", sDescription)
            If class_Procedures.actionAsk("Save as Journal Template", $"Save/Update {sTemplateName} as New Template?", "You might save an existing Journal Template", "You can still update/overwrite this template anytime") Then
                Dim sCOACode As String
                Dim sCOACodes As String = String.Empty

                For i As Integer = 0 To gridView.RowCount - 1
                    sCOACode = gridView.GetRowCellDisplayText(i, colCOA_Code)
                    If sCOACode.Length > 0 Then sCOACodes += $"{sCOACode},"
                Next

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Template_Name", sTemplateName),
                    New SqlParameter("@Template_COA_Codes", sCOACodes),
                    New SqlParameter("@Template_Description", sTemplateDescription.Trim),
                    New SqlParameter("@Added_By", class_Variables.sUserName),
                    New SqlParameter("@Modified_By", class_Variables.sUserName),
                    New SqlParameter("@Action_Type", "SAVE")
                }

                class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Journal_Template_Procedures", "Journal Template", sTemplateName)
            End If
        End Sub

        Friend Function Journal_Entries_Update() As Boolean
            If gridView.SelectedRowsCount > 0 Then
                If Not class_Procedures.actionAsk("Overwrite Journal Entries", "Overwrite selected Journal Entries", "Overwrite the wrong Journal Entries") Then Return False

                Dim sReason = class_Functions.Show_Input_Box("Reason why you want to overwrite or update the selected Journal Entries", "Reason to Overwrite/Update", String.Empty)
                If sReason.Equals(String.Empty) Then Return False

                class_Procedures.splash_Show($"Updating Journal Entries")

                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = gridView.GetSelectedRows()


                bLoopStop = False
                gridView.ClearSelection()
                For i As Integer = 0 To selectedRows.Length - 1
                    iRowHandle = selectedRows(i)

                    If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Entries", "updated", bLoopStop) Then
                        iRowHandleOld = iRowHandle
                    Else Return False
                    End If

                    If gridView.GetRowCellDisplayText(iRowHandle, colID).Equals(String.Empty) Then Continue For

                    Dim sCOACode As String
                    Try
                        sCOACode = gridView.GetRowCellValue(iRowHandle, colCOA_Name)
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                        Return False
                    End Try

                    class_Saga_Database.Journal_Entry_Update(Convert.ToInt32(gridView.GetRowCellDisplayText(iRowHandle, colID)),
                                                             Convert.ToInt32(gridView.GetRowCellDisplayText(iRowHandle, colTable_ID)),
                                                             gridView.GetRowCellValue(iRowHandle, colCorporation),
                                                             gridView.GetRowCellValue(iRowHandle, colBranch_Code),
                                                             sCOACode,
                                                             Reference,
                                                             gridView.GetRowCellDisplayText(iRowHandle, colJournal_Type),
                                                             gridView.GetRowCellDisplayText(iRowHandle, colJournal_Profile),
                                                             gridView.GetRowCellDisplayText(iRowHandle, colAccount_Code),
                                                             gridView.GetRowCellDisplayText(iRowHandle, colAccount_Name),
                                                             Convert.ToDecimal(gridView.GetRowCellValue(iRowHandle, colJournal_Debit)),
                                                             Convert.ToDecimal(gridView.GetRowCellValue(iRowHandle, colJournal_Credit)),
                                                             gridView.GetRowCellDisplayText(iRowHandle, colCheck_Number),
                                                             gridView.GetRowCellDisplayText(iRowHandle, colJournal_Description),
                                                             Convert.ToDateTime(gridView.GetRowCellValue(iRowHandle, colPosting_Date)),
                                                             $"{gridView.GetRowCellDisplayText(iRowHandle, colNotes)} Overwrite:{sReason}")
                Next

                gridView.BestFitColumns()
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Selected Journal Entries were updated.")
                class_Procedures.splash_Close()
            End If
            Return False
        End Function

        Private Sub btn_Update_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Update.ItemClick
            Journal_Entries_Update()
        End Sub

        Friend Sub btn_Verify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then

                    If Not class_Procedures.actionAsk("Update IsJournal", "Update IsJournal Transactions", "Update the wrong data") Then Return

                    class_Procedures.splash_Show($"Updating IsJournal Transactions of the selected Journal Entries")

                    Dim iTableID, iTableIDTemp As Integer
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        Try
                            iTableID = Convert.ToInt32(.GetRowCellValue(iRowHandle, colTable_ID))
                        Catch ex As Exception
                            iTableID = 0
                        End Try

                        If iTableID.Equals(0) Then Continue For

                        If iTableIDTemp.Equals(iTableID) Then Continue For

                        'If .GetFocusedRowCellDisplayText(colJournal_Status).Contains("ERROR") Then Continue For

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Entries", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        class_Saga_Database.Journal_Verify(iTableID, "VERIFY_JOURNAL", Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)))
                        iTableIDTemp = iTableID
                    Next

                    btn_Reload_ItemClick(sender, e)

                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"The selected Journal Entries were Verified.", "IsVerified Update")
                End If
            End With
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            class_Saga_Database.Transaction_Delete(gridView, "Journal Entry/Entries", "acc_Journal_Procedures", "DELETE")
        End Sub

        Private Sub btn_Error_Report_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Error_Report.ItemClick
            class_Saga_Database.Journal_Error_Report(gridView, Reference)
        End Sub

        Friend Sub Journal_Entries_Approval()
            If class_Saga_Functions.IsEqualSummary(colJournal_Debit, colJournal_Credit) Then Update_Transaction_Status(gridView, eTransaction.Journal, "Journal_Status", "PENDING", "FOR APPROVAL")
        End Sub

        Friend Sub Journal_Entries_Approve()
            If class_Saga_Functions.IsEqualSummary(colJournal_Debit, colJournal_Credit) Then Update_Transaction_Status(gridView, eTransaction.Journal, "Journal_Status", "FOR APPROVAL", "APPROVED")
        End Sub

        Friend Sub Journal_Entries_Lock()
            If class_Saga_Functions.IsEqualSummary(colJournal_Debit, colJournal_Credit) Then Update_Transaction_Status(gridView, eTransaction.Journal, "Journal_Status", "APPROVED", "LOCKED")
        End Sub

        Private Sub btn_Approval_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Approval.ItemClick
            Journal_Entries_Approval()
        End Sub

        Private Sub btn_Approve_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Approve.ItemClick
            Journal_Entries_Approve()
        End Sub

        Private Sub btn_Lock_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Lock.ItemClick
            Journal_Entries_Lock()
        End Sub

        Private Sub btn_Batch_Transactions_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Batch_Transactions.ItemClick
            class_Saga_Procedures.Show_Batch_Transactions(gridView, repositoryItemLookUpEdit_Branch, Reference)
        End Sub

        Private Sub btn_Ledger_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Ledger.ItemClick
            class_Saga_Procedures.Show_COA_Ledger(gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name))
        End Sub

        Private Sub btn_Journal_Entries2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries2.ItemClick
            Dim sType = gridView.GetFocusedRowCellDisplayText(colJournal_Type)
            If sType.Contains("TRANSFER") Or sType.Contains("ACQUIRED") Or sType.Contains("RELEASE") Or sType.Contains("ASSUME") Or sType.Contains("COLLECTION") Then
                class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.CIF, gridView.GetFocusedRowCellDisplayText(colAccount_Code), gridView.GetFocusedRowCellDisplayText(colAccount_Name), Reference)
            End If
        End Sub

        Private Sub btn_Preview_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Preview.ItemClick
            Print_Voucher()
        End Sub

        Friend Sub Print_Voucher()
            Try
                Dim xRpt = New Reports.Accounting.xrpt_Voucher()

                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 550

                    Select Case voucherType
                        Case class_Saga_Variables.eVoucherType.Check
                            .XrLabel_Title.Text = "CASH/CHECK VOUCHER"
                            .XrL_Name.Text = $"PAYEE: {AccountName}"
                            .XrT_Check.Text = sCheck

                        Case class_Saga_Variables.eVoucherType.Journal
                            .XrLabel_Title.Text = sTitle
                            .XrL_Name.Text = $"{AccountName}"
                            .XrT_Check.Text = "N/A"

                    End Select

                    .XrT_Reference.Text = Reference
                    .xrLRemarks.Text = $"REMARKS: {sDescription}"
                    .xrTApprovedBy.Text = sApprover

                    .xrLNumber_To_Words.Text = class_Functions.AmountToWords(colJournal_Credit.SummaryItem.SummaryValue)

                    If bAccountCodeAsReference Then
                        class_Database.Bind_Report(class_Database.ICSConnection, xRpt, $"SELECT * FROM view_Journal_Entries WHERE IsDeleted <> 1 AND Account_Code LIKE '{Reference}' ORDER BY ID", "view_Journal_Entries")
                    Else
                        class_Database.Bind_Report(class_Database.ICSConnection, xRpt, $"SELECT * FROM view_Journal_Entries WHERE IsDeleted <> 1 AND Journal_Reference LIKE '{Reference}' ORDER BY ID", "view_Journal_Entries")
                    End If

                    class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"Please verify parameters before Printing!{Environment.NewLine}Print Date: {class_Saga_Variables.dtEnd:MMMM dd, yyyy}{Environment.NewLine}Document Title: {xRpt.XrLabel_Title.Text}{Environment.NewLine}Subject: {xRpt.XrL_Name.Text}{Environment.NewLine}{xRpt.xrLRemarks.Text}", "Printing Verification", True)
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Print_Check_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Print_Check.ItemClick
            Print_Check()
        End Sub

        Friend Sub Print_Check()
            If RepositoryItemLookUpEdit_COA.GetKeyValueByDisplayText(gridView.GetFocusedRowCellDisplayText(colCOA_Name)).ToString.Contains("10101") Then
                If Not sCheck.Equals("0") And gridView.GetFocusedRowCellValue(colCheck_Number).Equals("0") Then
                    gridView.SetFocusedRowCellValue(colCheck_Number, sCheck)
                Else
                    Try
                        If Convert.ToInt32(gridView.GetFocusedRowCellValue(colCheck_Number)).Equals(0) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Please input Check Number.", "Invalid Check Number", True)
                            Return
                        End If
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Please input Check Number.", "Invalid Check Number", True)
                        Return
                    End Try
                End If

                Dim dDebit, dCredit As Decimal

                Try
                    dDebit = Convert.ToDecimal(gridView.GetFocusedRowCellValue(colJournal_Debit))
                Catch ex As Exception
                    dDebit = 0
                End Try

                Try
                    dCredit = Convert.ToDecimal(gridView.GetFocusedRowCellValue(colJournal_Credit))
                Catch ex As Exception
                    dCredit = 0
                End Try

                If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET Check_Number = '{gridView.GetFocusedRowCellDisplayText(colCheck_Number)}' WHERE ID LIKE '{gridView.GetFocusedRowCellValue(colID)}'") Then
                    class_Saga_Procedures.Print_Check(gridView.GetFocusedRowCellDisplayText(colCOA_Name), gridView.GetFocusedRowCellDisplayText(colCheck_Number), gridView.GetFocusedRowCellDisplayText(colAccount_Name), dDebit + dCredit, Convert.ToDateTime(gridView.GetFocusedRowCellValue(colPosting_Date)), gridView.GetFocusedRowCellDisplayText(colJournal_Description), gridView.GetFocusedRowCellDisplayText(colNotes))
                End If
            Else
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Please select a Bank Account Entry to print Check.", "Invalid Bank Account", True)
            End If
        End Sub

    End Class

End Namespace