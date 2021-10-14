Imports DevExpress.XtraEditors.Repository
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Windows.Forms

Namespace Controls.Information.Account

    Public Class xuc_Account_Search
        Private iID As Integer
        Private dAmount As Decimal
        Private sType, sCode, sCode2, sName, sOthers As String

        Public Property ID() As Integer
            Get
                Return iID
            End Get

            Set(value As Integer)
                iID = value
            End Set
        End Property

        Public Property Type() As String
            Get
                Return sType
            End Get

            Set(value As String)
                sType = value
            End Set
        End Property

        Public Property Code() As String
            Get
                Return sCode
            End Get

            Set(value As String)
                sCode = value
            End Set
        End Property

        Public Property Code2() As String
            Get
                Return sCode2
            End Get

            Set(value As String)
                sCode2 = value
            End Set
        End Property

        Public Property Amount() As Decimal
            Get
                Return dAmount
            End Get

            Set(value As Decimal)
                dAmount = value
            End Set
        End Property

        Public Property AccountName() As String
            Get
                Return sName
            End Get

            Set(value As String)
                sName = value
            End Set
        End Property

        Public Property Others() As String
            Get
                Return sOthers
            End Get

            Set(value As String)
                sOthers = value
            End Set
        End Property

        Public Enum Search_Mode
            searchGlobal
            searchAccounts
            searchCustomer
            searchEmployees
        End Enum

        Private _searchMode As Search_Mode

        Public Property searchMode() As Search_Mode
            Get
                Return _searchMode
            End Get

            Set(value As Search_Mode)
                _searchMode = value
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub Control_Initialize()
            Dim branchRepositoryItemLookUpEdit As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit()
            class_Saga_Procedures.Initialize_Branch(branchRepositoryItemLookUpEdit)
            colBranchCode.ColumnEdit = branchRepositoryItemLookUpEdit
        End Sub

        Private Sub SearchControl_Accounts_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles SearchControl_Accounts.ButtonClick
            Select Case e.Button.Index
                Case 0
                    If class_Saga_Variables.isAccounting Then
                        class_Saga_Procedures.Show_Account_Name_New(SearchControl_Accounts.Text.Trim.ToUpper())
                    End If
            End Select
        End Sub

        Private Sub SearchControl_Accounts_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles SearchControl_Accounts.KeyDown
            Select Case e.KeyCode
                Case Keys.F2
                    SearchControl_Accounts.ResetText()

                Case Keys.Enter
                    Load_Search(SearchControl_Accounts.Text.Trim, sBranchCode)

            End Select
        End Sub

        Public Sub Load_Search(ByVal sSearch As String, Optional ByVal sBrCode As String = "000", Optional ByVal bShowZeroAmount As Boolean = True)
            If sSearch.Length > 2 Then
                SearchControl_Accounts.Text = sSearch

                Dim sQuery As String = String.Empty
                Dim sQueryAmount As String = String.Empty

                Dim sQueryAccountTitles, sQueryNames, sQueryUsers, sQueryEmployees, sQueryCIF, sQueryAccounts, sQueryInventory, sQueryVouchers, sQueryChecks, sQueryPayments, sQueryCashiering As String

                sQueryAccountTitles = $"SELECT ID, 'ACCOUNT TITLE' AS Type, '000' AS BranchCode, COA_Code AS Code1, COA_Summary AS Code2, COA_Summary_Name + ' - ' + COA_Name AS Name, '0.00' AS Amount, Added_Date AS Date, COA_Desc AS Others, Notes FROM view_Chart_Of_Accounts"
                sQueryUsers = $"SELECT ID, 'USER' AS Type, branchcode AS BranchCode, username AS Code1, Employee_Code AS Code2, fullname AS Name, '0.00' AS Amount, Last_Login AS Date, designation AS Others, '' AS Notes FROM users"
                sQueryEmployees = $"SELECT ID, 'EMPLOYEE' AS Type, Employee_Branch AS BranchCode, Employee_Code AS Code1, Engine AS Code2, Employee_Name AS Name, '0.00' AS Amount, Employee_Date_Birth AS Date, Employee_Position AS Others, Notes FROM acc_Employees"
                sQueryNames = $"SELECT ID, 'NAME' AS Type, '000' AS BranchCode, Account_Code AS Code1, Account_Mobile AS Code2, Account_Name AS Name, '0.00' AS Amount, Added_Date AS Date, Account_Address AS Others, Notes FROM acc_Account_Names"
                sQueryCIF = $"SELECT SeqID AS ID, 'CUSTOMER' AS Type, BranchCode, CIFKey AS Code1, ContactNumber AS Code2, FullName AS Name, '0.00' AS Amount, Bday AS Date, Address AS Others, '' AS Notes FROM CIFAccounts"
                sQueryAccounts = $"SELECT sequenceNo AS ID, 'ACCOUNT' AS Type, BranchCode, CONVERT(NVARCHAR(50), AccountNumber) + '-' + CONVERT(NVARCHAR(2), LedgerSetNumber) AS Code1, EngineNo AS Code2, AccountName AS Name, OutstandingBalance AS Amount, DateGranted AS Date, Model AS Others, 'Inventory ID: ' + CONVERT(NVARCHAR(10), ID) + ' Status: '+ AccountStatus + ' Remarks: ' + Remarks AS Notes FROM CustAccount"
                sQueryInventory = $"SELECT id, 'INVENTORY' AS Type, branchcode AS BranchCode, EngineNo AS Code1, ChassisNo AS Code2, model AS Name, totalcost AS Amount, transactiondate AS Date, description AS Others, Remarks AS Notes FROM item_Details"
                sQueryChecks = $"SELECT ID, 'CHECK' AS Type, '000' AS BranchCode, Check_Number AS Code1, Reference AS Code2, Check_Payee AS Name, Check_Amount AS Amount, Issued_Date AS Date, Check_Description AS Others, Notes FROM acc_Checks"
                sQueryVouchers = $"SELECT ID, 'VOUCHER' AS Type, Voucher_Branch AS BranchCode, Voucher_Code AS Code1, Voucher_Reference AS Code2, Account_Name AS Name, Voucher_Debit AS Amount, Voucher_Date_Posted AS Date, Voucher_Description AS Others, Notes FROM acc_Vouchers"
                sQueryPayments = $"SELECT ID, 'PAYMENT' AS Type, BranchCode, ReferenceNumber AS Code1, ORNumber AS Code2, AccountName AS Name, AmountPaid AS Amount, PostingDate AS Date, Remarks AS Others, Note AS Notes FROM view_Payment_Transactions WHERE ErrorTag NOT LIKE 1"
                sQueryCashiering = $"SELECT ID, 'CASHIERING' AS Type, BranchCode, ReferenceNumber AS Code1, ORNumber AS Code2, AccountName AS Name, AmountDue AS Amount, PostingDate AS Date, Description AS Others, Remarks AS Notes FROM view_Payment_Cashiering WHERE ErrorTag NOT LIKE 1"

                If Not bShowZeroAmount Then
                    sQueryAmount = " AND Amount > 0 "
                End If

                Select Case searchMode
                    Case Search_Mode.searchGlobal
                        sQuery = $"SELECT TOP 100 * FROM ({sQueryAccountTitles} UNION ALL {sQueryUsers} UNION ALL {sQueryEmployees} UNION ALL {sQueryNames} UNION ALL {sQueryCIF} UNION ALL {sQueryAccounts} UNION ALL {sQueryInventory} UNION ALL {sQueryVouchers} UNION ALL {sQueryChecks} UNION ALL {sQueryPayments} UNION ALL {sQueryCashiering}) AS Query WHERE Code1 LIKE '%{sSearch}%' OR Code2 LIKE '%{sSearch}%' OR Name LIKE '%{sSearch}%' OR Others LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%' ORDER BY ID"

                    Case Search_Mode.searchCustomer
                        If sBrCode.Equals("000") Then
                            sQuery = $"SELECT TOP 100 * FROM ({sQueryCIF}) AS Query WHERE (Code1 LIKE '%{sSearch}%' OR Code2 LIKE '%{sSearch}%' OR Name LIKE '%{sSearch}%' OR Others LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%') ORDER BY ID"
                        Else
                            sQuery = $"SELECT TOP 100 * FROM ({sQueryCIF}) AS Query WHERE (Code1 LIKE '%{sSearch}%' OR Code2 LIKE '%{sSearch}%' OR Name LIKE '%{sSearch}%' OR Others LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%') AND BranchCode LIKE '{sBrCode}' ORDER BY ID"
                        End If

                    Case Search_Mode.searchAccounts
                        If sBrCode.Equals("000") Then
                            sQuery = $"SELECT TOP 100 * FROM ({sQueryEmployees} UNION ALL {sQueryAccounts} UNION ALL {sQueryNames}) AS Query WHERE Code1 LIKE '%{sSearch}%' OR Code2 LIKE '%{sSearch}%' OR Name LIKE '%{sSearch}%' OR Others LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%' ORDER BY ID"
                        Else
                            sQuery = $"SELECT TOP 100 * FROM ({sQueryAccounts}) AS Query WHERE BranchCode LIKE '{sBrCode}' AND (Code1 LIKE '%{sSearch}%' OR Code2 LIKE '%{sSearch}%' OR Name LIKE '%{sSearch}%' OR Others LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%') {sQueryAmount} ORDER BY ID"
                        End If

                End Select

                Control_Initialize()
                class_Procedures.Initialize_gridView(gridView)
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, sQuery, False)
                SearchControl_Accounts.Select()
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            Try
                iID = Convert.ToInt32(gridView.GetFocusedRowCellValue(colID))
                sType = gridView.GetFocusedRowCellDisplayText(colType)
                sCode = gridView.GetFocusedRowCellDisplayText(colCode1)
                sCode2 = gridView.GetFocusedRowCellDisplayText(colCode2)
                sName = gridView.GetFocusedRowCellDisplayText(colName)
                sOthers = gridView.GetFocusedRowCellDisplayText(colOthers)
                dAmount = gridView.GetFocusedRowCellDisplayText(colAmount)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub Show_Account(ByVal sColumnName As String, ByVal sID As String, ByVal sType As String, ByVal sCode1 As String, ByVal sCode2 As String, ByVal sName As String)
            If searchMode.Equals(Search_Mode.searchGlobal) Then
                Select Case sColumnName
                    Case "colID", "colCode1"
                        Select Case sType
                            Case "ACCOUNT"
                                Dim sCodes As String() = sCode1.Split(New Char() {"-"c})
                                Dim sAccountCode As String = sCodes(0)
                                Dim iLedger As Integer
                                Try
                                    iLedger = Convert.ToInt32(sCodes(1))
                                    class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, sAccountCode, iLedger, sName, True)
                                Catch ex As Exception
                                    class_Procedures.Show_Error(ex)
                                End Try

                            Case "ACCOUNT TITLE"
                                class_Saga_Procedures.Show_COA(sCode1)

                            Case "CUSTOMER"
                                class_Saga_Procedures.Show_Customer(sCode1)

                            Case "NAME"
                                class_Saga_Procedures.Show_Account_Name(sCode1)

                            Case "EMPLOYEE"
                            'class_Saga_Procedures.Show_Employee(sCode1)

                            Case "VOUCHER"
                                class_Saga_Procedures.Show_Voucher(sCode1)

                            Case "CHECK"
                                class_Saga_Procedures.Show_Check(sCode1)

                            Case "PAYMENT"
                                class_Saga_Procedures.Show_Account_Payment(False, sID)

                            Case "CASHIERING"
                                class_Saga_Procedures.Show_Account_Payment(True, sID)

                            Case "INVENTORY"
                                class_Saga_Procedures.Show_Unit_Inventory(sCode1)

                        End Select

                    Case "colCode2"
                        Select Case sType
                            Case "ACCOUNT TITLE"
                                class_Saga_Procedures.Show_COA(sCode2)

                            Case "ACCOUNT"
                                class_Saga_Procedures.Show_Unit_Inventory(sCode2,,, gridView.GetFocusedRowCellDisplayText(colName))

                            Case "INVENTORY"
                                class_Saga_Procedures.Show_Unit_Inventory(sCode2)

                            Case "VOUCHER"
                                class_Saga_Procedures.Show_Journal_Entries_Reference(sCode2, 0)

                            Case "CHECK"
                                class_Saga_Procedures.Show_Voucher(sCode1)
                        End Select

                    Case "colName"
                        class_Procedures.Copy_Clipboard(sName)
                End Select
            End If
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Show_Account(e.Column.Name, gridView.GetFocusedRowCellDisplayText(colID), gridView.GetFocusedRowCellDisplayText(colType), gridView.GetFocusedRowCellDisplayText(colCode1), gridView.GetFocusedRowCellDisplayText(colCode2), gridView.GetFocusedRowCellDisplayText(colName))
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            Select Case e.KeyCode
                Case Keys.Enter
                    Show_Account(gridView.FocusedColumn.Name, gridView.GetFocusedRowCellDisplayText(colID), gridView.GetFocusedRowCellDisplayText(colType), gridView.GetFocusedRowCellDisplayText(colCode1), gridView.GetFocusedRowCellDisplayText(colCode2), gridView.GetFocusedRowCellDisplayText(colName))

            End Select
        End Sub

    End Class

End Namespace