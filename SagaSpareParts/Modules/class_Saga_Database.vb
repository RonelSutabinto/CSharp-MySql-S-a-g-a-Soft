Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaSpareParts.Modules
Imports System.Data.SqlClient

Namespace Classes
    Public Module class_Saga_Database
        Public bLoopStop As Boolean

        Public Enum eTransaction
            Journal
            Balance
            Petty_Cash
        End Enum

        Public Mode_Transaction As eTransaction

        Public Function get_Branch_Name(ByVal sBrCode As String) As String
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, Branch, BM FROM BranchParameters WHERE BranchCode LIKE '{sBrCode}'", "Branch")
        End Function

        Public Function get_Admin_Cashier_Code(ByVal sBrCode As String) As String
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, Branch_Admin FROM BranchParameters WHERE BranchCode LIKE '{sBrCode}'", "Branch_Admin")
        End Function

        Public Function get_Employee_Name(ByVal sEmployeeCode As String) As String
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT Employee_Code, Employee_Name FROM acc_Employees WHERE Employee_Code LIKE '{sEmployeeCode}'", "Employee_Name")
        End Function

        Public Function get_Admin_Cashier(ByVal sBrCode As String) As String
            Dim sEmpCode As String = get_Admin_Cashier_Code(sBrCode)
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT Employee_Code, Employee_Name FROM acc_Employees WHERE Employee_Code LIKE '{sEmpCode}'", "Employee_Name")
        End Function

        Public Function get_Branch_Manager(ByVal sBrCode As String) As String
            Dim sEmpCode As String = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, Branch_Manager FROM BranchParameters WHERE BranchCode LIKE '{sBrCode}'", "Branch_Manager")
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT Employee_Code, Employee_Name FROM acc_Employees WHERE Employee_Code LIKE '{sEmpCode}'", "Employee_Name")
        End Function

        Public Function get_COA_Code(ByVal sCOAName As String) As String
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COA_Code, COA_Name FROM acc_Chart_Of_Accounts WHERE COA_Name LIKE '{sCOAName}'", "COA_Code")
        End Function

        Public Function get_COA_Name(ByVal sCOACode As String) As String
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COA_Code, COA_Name FROM acc_Chart_Of_Accounts WHERE COA_Code LIKE '{sCOACode}'", "COA_Name")
        End Function

        Public Function get_Account_Errors() As Integer
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT FROM CustAccount WHERE AccountStatus LIKE 'Closed' AND OutstandingBalance > 0", "COUNT")
        End Function

        Public Function get_Blank_Names() As Integer
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT FROM acc_Account_Names WHERE Account_Type LIKE '%BLANK%' OR Account_Name LIKE '%BLANK%' OR Account_Address LIKE ''", "COUNT")
        End Function

        Public Function get_Check_Errors() As Integer
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT FROM acc_Checks WHERE IsIssued LIKE '1' AND (IsCancelled = 1 OR Check_Amount < 1)", "COUNT")
        End Function

        Public Function get_Expense_Status_Count(ByVal sTatus As String) As Integer
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT FROM TransactionPettyCash WHERE TransStatus LIKE '{sTatus}'", "COUNT")
        End Function

        Public Function get_Unliquidated() As Integer
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT FROM view_Vouchers WHERE (IsForLiquidation LIKE '1' AND IsLiquidated NOT LIKE '1' AND Liquidation_Date_Expiry <= CONVERT(VARCHAR(10), '{Date.Now}', 23))", "COUNT")
        End Function

        Public Function get_UnJounaled_Transactions(ByVal sTable As String, ByVal sDateField As String) As Integer
            'Return class_Database.RecordCount(class_Database.ICSConnection, $"SELECT IsJournal, {sDateField} FROM {sTable} WHERE IsJournal NOT LIKE 1 AND {sDateField} >= CONVERT(VARCHAR(10), '{class_Functions.FirstDayOfMonth(class_Saga_Variables.dtStart)}', 23) AND {sDateField} <= CONVERT(VARCHAR(10), '{class_Functions.LastDayOfMonth(class_Saga_Variables.dtEnd)}', 23)")
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT FROM {sTable} WHERE IsJournal NOT LIKE 1 AND {sDateField} >= CONVERT(VARCHAR(10), '{class_Functions.FirstDayOfMonth(class_Saga_Variables.dtStart)}', 23) AND {sDateField} <= CONVERT(VARCHAR(10), '{class_Functions.LastDayOfMonth(class_Saga_Variables.dtEnd)}', 23)", "COUNT")
        End Function

        Public Function get_IBC_Errors() As Integer
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT FROM view_Payment_Transactions WHERE Remarks LIKE 'APAY' AND Mnemonic NOT LIKE 'INTPAY' AND PostingDate >= CONVERT(VARCHAR(10), '{class_Functions.FirstDayOfMonth(class_Saga_Variables.dtStart)}', 23) AND PostingDate <= CONVERT(VARCHAR(10), '{class_Functions.LastDayOfMonth(class_Saga_Variables.dtEnd)}', 23)", "COUNT")
        End Function

        Public Function get_Multiple_Existing_Inventory() As Integer
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT engineno, IfExist, COUNT(engineno) AS COUNT FROM item_Details WHERE IfExist LIKE 1 GROUP BY engineno, IfExist HAVING COUNT(engineno) > 1", "COUNT")
        End Function

        Public Function Reference_Exist(ByVal sReference As String) As Boolean
            Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT Journal_Reference FROM acc_Journal_Entries WHERE Journal_Reference LIKE '{sReference}'")
            'class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"There are already Journal Entries with this Reference.{Environment.NewLine}Please edit your Reference.", "Reference Exist", True)
        End Function

        Public Sub Get_User_Privileges(ByVal sUserName As String)
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                New SqlParameter("@UserName", sUserName),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "acc_User_Procedures")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    Try
                        class_Variables.sUserName = sUserName
                        class_Variables.sPosition = myDataReader("designation").ToString
                        class_Variables.isAdministrator = Convert.ToBoolean(myDataReader("IsSuperUser"))

                        class_Saga_Variables.sCorporation = myDataReader("Corporation").ToString
                        class_Saga_Variables.sBranchCode = myDataReader("branchcode").ToString

                        class_Saga_Variables.isAccounting = Convert.ToBoolean(myDataReader("IsAccounting"))
                        class_Saga_Variables.isAudit = Convert.ToBoolean(myDataReader("IsAudit"))
                        class_Saga_Variables.isLogistics = Convert.ToBoolean(myDataReader("IsLogistics"))
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
        End Sub

        Public Function Reset_Pass(ByVal sCorporation As String, ByVal sUserName As String, ByVal iResetValue As Integer) As Boolean
            Return class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE Users SET Reset_Pass = {iResetValue} WHERE Corporation LIKE '{sCorporation}' AND username LIKE '{sUserName}'")
        End Function

        'Batch Journal Entry
        Public Function Journal_Entry_Save(ByVal sProcedureType As String, ByVal iTableID As Integer, Optional ByVal bCustomPosting As Boolean = False, Optional ByVal dtPostingDate As String = "", Optional ByVal sReason As String = "") As Boolean
            If dtPostingDate.Equals("") Then dtPostingDate = Date.Today.ToString
            Dim Parameters As SqlParameter() = {New SqlParameter("@Table_ID", iTableID),
                                                New SqlParameter("@Custom_Posting", bCustomPosting),
                                                New SqlParameter("@Custom_Posting_Date", Convert.ToDateTime(dtPostingDate)),
                                                New SqlParameter("@Reason", sReason),
                                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", sProcedureType)}
            Return class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "acc_Journal_Batch_Entry", $"{iTableID}")
        End Function

        Public Function Journal_Verify(ByVal iTableID As Integer, ByVal sAction As String) As Boolean
            Dim Parameters As SqlParameter() = {New SqlParameter("@Table_ID", iTableID),
                                                New SqlParameter("@Verified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", sAction)}

            Return class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "acc_Verification_Procedures", $"{iTableID}")
        End Function

        Public Function Journal_Verify(ByVal iTableID As Integer, ByVal sAction As String, ByVal iID As Integer) As Boolean
            Dim Parameters As SqlParameter() = {New SqlParameter("@Table_ID", iTableID),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@ID", iID),
                                                New SqlParameter("@Action_Type", sAction)}

            Return class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "acc_Journal_Procedures", $"{iTableID}")
        End Function

        'System Generated i.e. Unit transfers, Sales and Releases / Journal Entry Group
        Public Function Journal_Entry_Save(ByVal bMayExist As Boolean, ByVal iTableID As Integer, ByVal sJournalCode As String, ByVal sCorporation As String, ByVal sBrCode As String, ByVal sCOACode As String, ByVal sReference As String, ByVal sJournalType As String, ByVal sJournalProfile As String, ByVal sAccountCode As String, ByVal sAccountName As String, ByVal dDebit As Decimal, ByVal dCredit As Decimal, ByVal sDescription As String, ByVal sPostedBy As String, ByVal dtPosting As DateTime, Optional ByVal sNotes As String = "") As Boolean
            If sCOACode.Equals(String.Empty) OrElse (dDebit <= 0 And dCredit <= 0) Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"ID:{iTableID} Name:{sAccountName}{Environment.NewLine}Journal Entry with No Account or Zero(0)/Negative(-) Debit {dDebit} and Credit {dCredit} are not valid.")
                Return True
            End If

            Dim sActionType As String
            If bMayExist Then
                sActionType = "SAVE"
            Else
                sActionType = "INSERT"
            End If

            Dim Parameters As SqlParameter() = {New SqlParameter("@Table_ID", iTableID),
                                                New SqlParameter("@Journal_Code", sJournalCode),
                                                New SqlParameter("@Corporation", sCorporation),
                                                New SqlParameter("@Branch_Code", sBrCode),
                                                New SqlParameter("@COA_Code", sCOACode),
                                                New SqlParameter("@Journal_Reference", sReference.Trim.ToUpper),
                                                New SqlParameter("@Journal_Type", sJournalType.Trim.ToUpper),
                                                New SqlParameter("@Journal_Profile", sJournalProfile.Trim.ToUpper),
                                                New SqlParameter("@Account_Code", sAccountCode.Trim),
                                                New SqlParameter("@Account_Name", sAccountName.Trim),
                                                New SqlParameter("@Journal_Debit", Math.Round(dDebit, 2)),
                                                New SqlParameter("@Journal_Credit", Math.Round(dCredit, 2)),
                                                New SqlParameter("@Check_Number", 0),
                                                New SqlParameter("@Journal_Description", sDescription.Trim),
                                                New SqlParameter("@Journal_Status", "PENDING"),
                                                New SqlParameter("@Posted_By", sPostedBy),
                                                New SqlParameter("@Posting_Date", dtPosting),
                                                New SqlParameter("@Transacted_By", sPostedBy),
                                                New SqlParameter("@Transaction_Date", dtPosting),
                                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Notes", sNotes.Trim),
                                                New SqlParameter("@Action_Type", sActionType)}

            Return class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "acc_Journal_Procedures", $"{sJournalCode}")
        End Function

        'System Generated i.e. Payment Collections and Cashiering
        'The difference is posting date with transaction date
        Public Function Journal_Entry_Save(ByVal bMayExist As Boolean, ByVal iTableID As Integer, ByVal sJournalCode As String, ByVal sCorporation As String, ByVal sBrCode As String, ByVal sCOACode As String, ByVal sReference As String, ByVal sJournalType As String, ByVal sJournalProfile As String, ByVal sAccountCode As String, ByVal sAccountName As String, ByVal dDebit As Decimal, ByVal dCredit As Decimal, ByVal sDescription As String, ByVal sPostedBy As String, ByVal dtPosting As DateTime, ByVal sTransactedBy As String, ByVal dtTransaction As DateTime, Optional ByVal sNotes As String = "") As Boolean
            If sCOACode.Equals(String.Empty) OrElse (dDebit <= 0 And dCredit <= 0) Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"ID:{iTableID} Name:{sAccountName}{Environment.NewLine}Journal Entry with No Account or Zero(0)/Negative(-) Debit {dDebit} and Credit {dCredit} are not valid.")
                Return False
            End If

            Dim sActionType As String
            If bMayExist Then
                sActionType = "SAVE"
            Else
                sActionType = "INSERT"
            End If

            Dim Parameters As SqlParameter() = {New SqlParameter("@Table_ID", iTableID),
                                                New SqlParameter("@Journal_Code", sJournalCode),
                                                New SqlParameter("@Corporation", sCorporation),
                                                New SqlParameter("@Branch_Code", sBrCode),
                                                New SqlParameter("@COA_Code", sCOACode),
                                                New SqlParameter("@Journal_Reference", sReference.Trim.ToUpper),
                                                New SqlParameter("@Journal_Type", sJournalType.Trim.ToUpper),
                                                New SqlParameter("@Journal_Profile", sJournalProfile.Trim.ToUpper),
                                                New SqlParameter("@Account_Code", sAccountCode.Trim),
                                                New SqlParameter("@Account_Name", sAccountName.Trim),
                                                New SqlParameter("@Journal_Debit", Math.Round(dDebit, 2)),
                                                New SqlParameter("@Journal_Credit", Math.Round(dCredit, 2)),
                                                New SqlParameter("@Check_Number", 0),
                                                New SqlParameter("@Journal_Description", sDescription.Trim),
                                                New SqlParameter("@Journal_Status", "PENDING"),
                                                New SqlParameter("@Posted_By", sPostedBy),
                                                New SqlParameter("@Posting_Date", dtPosting),
                                                New SqlParameter("@Transacted_By", sTransactedBy),
                                                New SqlParameter("@Transaction_Date", dtTransaction),
                                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Notes", sNotes.Trim),
                                                New SqlParameter("@Action_Type", sActionType)}
            Return class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "acc_Journal_Procedures", $"{sJournalCode}")
        End Function

        'Journal Entry Update
        Public Function Journal_Entry_Update(ByVal iID As Integer, ByVal iTableID As Integer, ByVal sCorporation As String, ByVal sBrCode As String, ByVal sCOACode As String, ByVal sReference As String, ByVal sType As String, ByVal sProfile As String, ByVal sAccountCode As String, ByVal sAccountName As String, ByVal dDebit As Decimal, ByVal dCredit As Decimal, ByVal sCheckNumber As String, ByVal sDescription As String, ByVal dtPosted As Date, ByVal sNotes As String) As Boolean
            Dim Parameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                New SqlParameter("@Table_ID", iTableID),
                                                New SqlParameter("@Corporation", sCorporation),
                                                New SqlParameter("@Branch_Code", sBrCode),
                                                New SqlParameter("@COA_Code", sCOACode),
                                                New SqlParameter("@Journal_Reference", sReference.Trim.ToUpper),
                                                New SqlParameter("@Journal_Type", sType.Trim.ToUpper),
                                                New SqlParameter("@Journal_Profile", sProfile.Trim.ToUpper),
                                                New SqlParameter("@Account_Code", sAccountCode.Trim),
                                                New SqlParameter("@Account_Name", sAccountName.Trim),
                                                New SqlParameter("@Journal_Debit", Math.Round(dDebit, 2)),
                                                New SqlParameter("@Journal_Credit", Math.Round(dCredit, 2)),
                                                New SqlParameter("@Check_Number", sCheckNumber.Trim),
                                                New SqlParameter("@Journal_Description", sDescription.Trim),
                                                New SqlParameter("@Posting_Date", dtPosted),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Notes", sNotes.Trim),
                                                New SqlParameter("@Action_Type", "UPDATE")}
            Return class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "acc_Journal_Procedures", "Journal Entry Update")
        End Function

        Public Function Change_Status_Journal(ByVal iID As Integer, ByVal sSTatus As String, Optional ByVal sNotes As String = "") As Boolean
            Dim Parameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                New SqlParameter("@Journal_Status", sSTatus),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Notes", sNotes.Trim),
                                                New SqlParameter("@Action_Type", "STATUS")}
            Return class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "acc_Journal_Procedures", "Journal Status")
        End Function

        Public Function Change_Status_Balance(ByVal iID As Integer, ByVal sSTatus As String, Optional ByVal sNotes As String = "") As Boolean
            Dim Parameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                New SqlParameter("@Balance_Status", sSTatus),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Notes", sNotes.Trim),
                                                New SqlParameter("@Action_Type", "STATUS")}
            Return class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "acc_Balance_Procedures", "Balance Status")
        End Function

        Public Function Change_Status_Petty_Cash(ByVal iID As Integer, ByVal sNewStatus As String, Optional ByVal sReference As String = "", Optional ByVal sNotes As String = "") As Boolean
            Dim Parameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                New SqlParameter("@Reference", sReference),
                                                New SqlParameter("@Status", sNewStatus),
                                                New SqlParameter("@Notes", sNotes),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "STATUS")}
            Return class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "acc_Petty_Cash_Procedures", "Petty Cash Status")
        End Function

        Public Function Liquidation(ByVal bLiquidated As Boolean, ByVal sVoucherReference As String, ByVal sJournalReference As String, ByVal dtLiquidation As Date, ByVal sDescription As String, ByVal sJustification As String, ByVal sNotes As String) As Boolean
            Dim Parameters As SqlParameter() = {New SqlParameter("@Journal_Reference", sJournalReference),
                                                New SqlParameter("@Voucher_Reference", sVoucherReference),
                                                New SqlParameter("@IsLiquidated", bLiquidated),
                                                New SqlParameter("@Liquidated_By", class_Variables.sUserName),
                                                New SqlParameter("@Justification", sJustification),
                                                New SqlParameter("@Journal_Description", sDescription),
                                                New SqlParameter("@Notes", sNotes),
                                                New SqlParameter("@Action_Type", "LIQUIDATION")}

            Return class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "acc_Liquidation_Procedures", "Voucher/Journal Liquidation")
        End Function

        Public Sub Update_Transaction_Status(ByVal gridView As GridView, ByVal modeTransaction As eTransaction, ByVal sStatusFieldName As String, ByVal sPrevStatus As String, ByVal sNewStatus As String, Optional ByVal bLoopLive As Boolean = True, Optional ByVal bClearSelection As Boolean = True, Optional sReference As String = "")
            With gridView
                If .SelectedRowsCount > 0 Then
                End If
            End With
        End Sub

        Public Function Balance_Notes_Save(ByVal iID As Integer, ByVal sNotes As String) As String
            Dim Parameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Notes", sNotes.Trim),
                                                New SqlParameter("@Action_Type", "NOTES")}
            If class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "acc_Balance_Procedures", "Trial Balance Notes") Then
                Return sNotes
            Else
                Return String.Empty
            End If
        End Function

        Public Function Balance_Save(ByVal iID As Integer, ByVal sBalanceField As String, ByVal dBalanceOld As Decimal, ByVal dBalanceNew As Decimal) As Decimal
            If Not class_Database.Data_Save_Ask($"{iID} {sBalanceField}") Then Return dBalanceOld
            class_Procedures.splash_Show("Saving Beginning Balance")
            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand($"UPDATE acc_Balances SET {sBalanceField} = @{sBalanceField}, Modified_By = @Modified_By, Modified_Date = @Modified_Date WHERE ID LIKE '{iID}'", MySQLConnection)
                    MyCommand.Parameters.Add($"@{sBalanceField}", SqlDbType.Money).Value = dBalanceNew
                    MyCommand.Parameters.Add("@Modified_By", SqlDbType.VarChar).Value = class_Variables.sUserName
                    MyCommand.Parameters.Add("@Modified_Date", SqlDbType.VarChar).Value = DateTime.Now

                    Try
                        MySQLConnection.Open()
                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                            If class_Variables.bNotifications Then class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"[{iID}] has been successfully updated.")
                            Return dBalanceNew
                        End If
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                        Return 0
                    Finally
                        class_Procedures.splash_Close()
                    End Try
                End Using
            End Using
            Return 0
        End Function

        'Add New/Update
        Public Function Balance_Save(ByVal eBalanceType As eLoad_Type, ByVal sType As String, ByVal sBrCode As String, ByVal sCOACode As String, ByVal dBalanceBeginningDebit As Decimal, ByVal dBalanceBeginningCredit As Decimal, ByVal dTotalDebit As Decimal, ByVal dTotalCredit As Decimal, ByVal dBalanceEndDebit As Decimal, ByVal dBalanceEndCredit As Decimal, ByVal dBalanceSheetDebit As Decimal, ByVal dBalanceSheetCredit As Decimal, ByVal dIncomeStatementDebit As Decimal, ByVal dIncomeStatementCredit As Decimal, Optional ByVal sNotes As String = "") As Boolean
            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand("acc_Balance_Procedures", MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                    Dim dtBalance As Date
                    Select Case eBalanceType
                        Case eLoad_Type.Daily
                            dtBalance = class_Saga_Variables.dtStart
                            MyCommand.Parameters.Add("@Date_Range_Start", SqlDbType.Date).Value = dtBalance
                            MyCommand.Parameters.Add("@Date_Range_End", SqlDbType.Date).Value = dtBalance
                        Case eLoad_Type.Monthly
                            dtBalance = class_Functions.FirstDayOfMonth(class_Saga_Variables.dtStart)
                            MyCommand.Parameters.Add("@Date_Range_Start", SqlDbType.Date).Value = class_Functions.FirstDayOfMonth(dtBalance)
                            MyCommand.Parameters.Add("@Date_Range_End", SqlDbType.Date).Value = class_Functions.LastDayOfMonth(dtBalance)
                        Case eLoad_Type.Range
                            dtBalance = class_Saga_Variables.dtStart
                            MyCommand.Parameters.Add("@Date_Range_Start", SqlDbType.Date).Value = class_Saga_Variables.dtStart
                            MyCommand.Parameters.Add("@Date_Range_End", SqlDbType.Date).Value = class_Saga_Variables.dtEnd
                    End Select

                    MyCommand.Parameters.Add("@Balance_Date", SqlDbType.Date).Value = dtBalance
                    MyCommand.Parameters.Add("@Date_Type", SqlDbType.VarChar).Value = eBalanceType.ToString.ToUpper
                    MyCommand.Parameters.Add("@Corporation", SqlDbType.VarChar).Value = class_Saga_Variables.sCorporation
                    MyCommand.Parameters.Add("@Branch_Code", SqlDbType.VarChar).Value = sBrCode
                    MyCommand.Parameters.Add("@Balance_Type", SqlDbType.VarChar).Value = sType
                    MyCommand.Parameters.Add("@COA_Code", SqlDbType.VarChar).Value = sCOACode
                    MyCommand.Parameters.Add("@Beginning_Balance_Debit", SqlDbType.Money).Value = dBalanceBeginningDebit
                    MyCommand.Parameters.Add("@Beginning_Balance_Credit", SqlDbType.Money).Value = dBalanceBeginningCredit
                    MyCommand.Parameters.Add("@Total_Debit", SqlDbType.Money).Value = dTotalDebit
                    MyCommand.Parameters.Add("@Total_Credit", SqlDbType.Money).Value = dTotalCredit
                    MyCommand.Parameters.Add("@Ending_Balance_Debit", SqlDbType.Money).Value = dBalanceEndDebit
                    MyCommand.Parameters.Add("@Ending_Balance_Credit", SqlDbType.Money).Value = dBalanceEndCredit
                    MyCommand.Parameters.Add("@Balance_Sheet_Debit", SqlDbType.Money).Value = dBalanceSheetDebit
                    MyCommand.Parameters.Add("@Balance_Sheet_Credit", SqlDbType.Money).Value = dBalanceSheetCredit
                    MyCommand.Parameters.Add("@Income_Statement_Debit", SqlDbType.Money).Value = dIncomeStatementDebit
                    MyCommand.Parameters.Add("@Income_Statement_Credit", SqlDbType.Money).Value = dIncomeStatementCredit
                    MyCommand.Parameters.Add("@Balance_Status", SqlDbType.VarChar).Value = "PENDING"

                    MyCommand.Parameters.Add("@Added_By", SqlDbType.VarChar).Value = class_Variables.sUserName
                    MyCommand.Parameters.Add("@Modified_By", SqlDbType.VarChar).Value = class_Variables.sUserName

                    MyCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = sNotes
                    MyCommand.Parameters.Add("@Action_Type", SqlDbType.VarChar).Value = "UPDATE"

                    Try
                        MySQLConnection.Open()
                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                            If class_Variables.bNotifications Then class_Procedures.Set_Message(class_Procedures.MsgMode.Save, $"[{sCOACode}] Trial Balance")
                            Return True
                        End If
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex, $"COA:{sCOACode}")
                    End Try
                End Using
            End Using
            Return False
        End Function

        'Update Total Debit/Credit
        Public Function Balance_Save(ByVal eBalanceType As eLoad_Type, ByVal sType As String, ByVal sBrCode As String, ByVal sCOACode As String, ByVal dTotalDebit As Decimal, ByVal dTotalCredit As Decimal) As Boolean
            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand("acc_Balance_Procedures", MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                    Dim dtBalance As Date
                    Select Case eBalanceType
                        Case eLoad_Type.Daily
                            dtBalance = class_Saga_Variables.dtStart
                            MyCommand.Parameters.Add("@Date_Range_Start", SqlDbType.Date).Value = dtBalance
                            MyCommand.Parameters.Add("@Date_Range_End", SqlDbType.Date).Value = dtBalance
                        Case eLoad_Type.Monthly
                            dtBalance = class_Functions.FirstDayOfMonth(class_Saga_Variables.dtStart)
                            MyCommand.Parameters.Add("@Date_Range_Start", SqlDbType.Date).Value = class_Functions.FirstDayOfMonth(dtBalance)
                            MyCommand.Parameters.Add("@Date_Range_End", SqlDbType.Date).Value = class_Functions.LastDayOfMonth(dtBalance)
                        Case eLoad_Type.Range
                            dtBalance = class_Saga_Variables.dtStart
                            MyCommand.Parameters.Add("@Date_Range_Start", SqlDbType.Date).Value = class_Saga_Variables.dtStart
                            MyCommand.Parameters.Add("@Date_Range_End", SqlDbType.Date).Value = class_Saga_Variables.dtEnd
                    End Select

                    MyCommand.Parameters.Add("@Date_Type", SqlDbType.VarChar).Value = eBalanceType.ToString.ToUpper
                    MyCommand.Parameters.Add("@Balance_Date", SqlDbType.Date).Value = dtBalance
                    MyCommand.Parameters.Add("@Corporation", SqlDbType.VarChar).Value = class_Saga_Variables.sCorporation
                    MyCommand.Parameters.Add("@Branch_Code", SqlDbType.VarChar).Value = sBrCode
                    MyCommand.Parameters.Add("@Balance_Type", SqlDbType.VarChar).Value = sType
                    MyCommand.Parameters.Add("@COA_Code", SqlDbType.VarChar).Value = sCOACode
                    MyCommand.Parameters.Add("@Total_Debit", SqlDbType.Money).Value = dTotalDebit
                    MyCommand.Parameters.Add("@Total_Credit", SqlDbType.Money).Value = dTotalCredit
                    MyCommand.Parameters.Add("@Added_By", SqlDbType.VarChar).Value = class_Variables.sUserName
                    MyCommand.Parameters.Add("@Modified_By", SqlDbType.VarChar).Value = class_Variables.sUserName
                    MyCommand.Parameters.Add("@Action_Type", SqlDbType.VarChar).Value = "TOTAL"

                    Try
                        MySQLConnection.Open()
                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                            If class_Variables.bNotifications Then class_Procedures.Set_Message(class_Procedures.MsgMode.Save, $"[{sCOACode}] Trial Balance")
                            Return True
                        End If
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex, $"COA:{sCOACode}")
                    End Try
                End Using
            End Using
            Return False
        End Function

        'Update Next Beginning Balances
        Public Function Balance_Save(ByVal dBalanceBeginningDebit As Decimal, ByVal dBalanceBeginningCredit As Decimal, ByVal eBalanceType As eLoad_Type, ByVal sType As String, ByVal sBrCode As String, ByVal sCOACode As String) As Boolean
            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand("acc_Balance_Procedures", MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                    Dim dtBalance As Date
                    Select Case eBalanceType
                        Case eLoad_Type.Daily
                            dtBalance = class_Functions.Next_Working_Date(class_Saga_Variables.dtStart)
                            MyCommand.Parameters.Add("@Date_Range_Start", SqlDbType.Date).Value = dtBalance
                            MyCommand.Parameters.Add("@Date_Range_End", SqlDbType.Date).Value = dtBalance
                        Case eLoad_Type.Monthly
                            dtBalance = class_Functions.FirstDayOfMonth(class_Saga_Variables.dtStart.AddMonths(1))
                            MyCommand.Parameters.Add("@Date_Range_Start", SqlDbType.Date).Value = class_Functions.FirstDayOfMonth(dtBalance)
                            MyCommand.Parameters.Add("@Date_Range_End", SqlDbType.Date).Value = class_Functions.LastDayOfMonth(dtBalance)
                        Case eLoad_Type.Range
                            dtBalance = class_Saga_Variables.dtStart
                            MyCommand.Parameters.Add("@Date_Range_Start", SqlDbType.Date).Value = dtBalance
                            MyCommand.Parameters.Add("@Date_Range_End", SqlDbType.Date).Value = class_Saga_Variables.dtEnd
                    End Select

                    MyCommand.Parameters.Add("@Date_Type", SqlDbType.VarChar).Value = eBalanceType.ToString.ToUpper
                    MyCommand.Parameters.Add("@Balance_Date", SqlDbType.Date).Value = dtBalance
                    MyCommand.Parameters.Add("@Corporation", SqlDbType.VarChar).Value = class_Saga_Variables.sCorporation
                    MyCommand.Parameters.Add("@Branch_Code", SqlDbType.VarChar).Value = sBrCode
                    MyCommand.Parameters.Add("@Balance_Type", SqlDbType.VarChar).Value = sType
                    MyCommand.Parameters.Add("@COA_Code", SqlDbType.VarChar).Value = sCOACode

                    MyCommand.Parameters.Add("@Beginning_Balance_Debit", SqlDbType.Money).Value = dBalanceBeginningDebit
                    MyCommand.Parameters.Add("@Beginning_Balance_Credit", SqlDbType.Money).Value = dBalanceBeginningCredit
                    MyCommand.Parameters.Add("@Added_By", SqlDbType.VarChar).Value = class_Variables.sUserName
                    MyCommand.Parameters.Add("@Modified_By", SqlDbType.VarChar).Value = class_Variables.sUserName
                    MyCommand.Parameters.Add("@Action_Type", SqlDbType.VarChar).Value = "BEGINNING"

                    Try
                        MySQLConnection.Open()
                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                            If class_Variables.bNotifications Then class_Procedures.Set_Message(class_Procedures.MsgMode.Save, $"[{sCOACode}] Trial Balance")
                            Return True
                        End If
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex, $"COA:{sCOACode}")
                    End Try
                End Using
            End Using
            Return False
        End Function

        Public Function Journal_Entries_Balanced(ByVal iTableID As Integer, ByVal sReference As String, Optional ByVal dTotalDebitCredit As Decimal = 0, Optional ByVal bAccountCodeAsReference As Boolean = False) As Boolean
            Dim dDebit, dCredit As Decimal

            If bAccountCodeAsReference Then
                dDebit = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT Account_Code, SUM(Journal_Debit) AS Journal_Debit FROM acc_Journal_Entries WHERE Account_Code LIKE '{sReference}' AND IsDeleted <> 1 GROUP BY Account_Code", "Journal_Debit"))
            Else
                dDebit = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT Journal_Reference, SUM(Journal_Debit) AS Journal_Debit FROM acc_Journal_Entries WHERE Table_ID LIKE '{iTableID}' AND Journal_Reference LIKE '{sReference}' AND IsDeleted <> 1 GROUP BY Journal_Reference", "Journal_Debit"))
            End If

            If dTotalDebitCredit > 0 AndAlso dTotalDebitCredit.Equals(dDebit) Then
                Return class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET IsVerified = 1 WHERE Table_ID LIKE '{iTableID}' AND Journal_Reference LIKE '{sReference}'")

            ElseIf dDebit > 0 Then
                If bAccountCodeAsReference Then
                    dCredit = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT Account_Code, SUM(Journal_Credit) AS Journal_Credit FROM acc_Journal_Entries WHERE Account_Code LIKE '{sReference}' GROUP BY Account_Code", "Journal_Credit"))
                Else
                    dCredit = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT Journal_Reference, SUM(Journal_Credit) AS Journal_Credit FROM acc_Journal_Entries WHERE Table_ID LIKE '{iTableID}' AND Journal_Reference LIKE '{sReference}' GROUP BY Journal_Reference", "Journal_Credit"))
                End If

                If dCredit > 0 AndAlso dDebit.Equals(dCredit) Then
                    Return class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET IsVerified = 1 WHERE Table_ID LIKE '{iTableID}' AND Journal_Reference LIKE '{sReference}'")
                Else
                    Return False
                End If
            End If
            Return False
        End Function

        Public Sub Verify_Transaction(ByVal sTable As String, ByVal gridView As GridView, ByVal colNotes As GridColumn, ByVal iRowhandle As Integer, ByVal iTableID As Integer, ByVal sReference As String, Optional ByVal dTotalDebitCredit As Decimal = 0, Optional ByVal sIDFieldName As String = "ID", Optional ByVal bAccountCodeAsReference As Boolean = False)
            With gridView
                If class_Saga_Database.Journal_Entries_Balanced(iTableID, sReference, dTotalDebitCredit, bAccountCodeAsReference) Then
                    If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE {sTable} SET IsJournal = 1 WHERE {sIDFieldName} LIKE '{iTableID}'") Then
                        .SetRowCellValue(iRowhandle, "IsJournal", 1)
                        .SetRowCellValue(iRowhandle, colNotes, "Verified")
                    End If
                Else
                    If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE {sTable} SET IsJournal = 0 WHERE {sIDFieldName} LIKE '{iTableID}'") Then
                        .SetRowCellValue(iRowhandle, "IsJournal", 0)
                        .SetRowCellValue(iRowhandle, colNotes, "No Journal Entries or Not Balanced")
                    End If
                End If
            End With
        End Sub

        Public Function Root_Data_Exist(ByVal sType As String, ByVal iTableID As Integer) As Boolean
            If iTableID > 0 Then
                If sType.Contains("VOUCHER") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT ID FROM acc_Vouchers WHERE ID LIKE '{iTableID}'")
                If sType.Contains("RECEIVING") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT id FROM item_Master WHERE id LIKE '{iTableID}'")
                If sType.Contains("TRANSFER") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT id FROM item_Details WHERE id LIKE '{iTableID}'")
                If sType.Contains("RELEASE") Or sType.Contains("ACQUIRED") Or sType.Contains("ASSUME") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT sequenceNo FROM CustAccount WHERE sequenceNo LIKE '{iTableID}'")
                If sType.Contains("PAYMENT") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT ID FROM TransactionPayments WHERE ID LIKE '{iTableID}' AND ErrorTag NOT LIKE 1")
                If sType.Contains("CASHIERING") Then
                    If sType.Contains("BRANCH") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT ID FROM TransactionOtherCash WHERE ID LIKE '{iTableID}' AND ErrorTag NOT LIKE 1")
                    If sType.Contains("CM") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT ID FROM TransactionCM WHERE ID LIKE '{iTableID}' AND ErrorTag NOT LIKE 1")
                End If
            End If
            Return False
        End Function

        Public Function Root_Data_Exist(ByVal sType As String, ByVal sReference As String) As Boolean
            If sType.Contains("VOUCHER") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT Voucher_Reference FROM acc_Vouchers WHERE Voucher_Reference LIKE '{sReference}'")
            If sType.Contains("RECEIVING") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT refno FROM item_Master WHERE refno LIKE '{sReference}'")
            If sType.Contains("TRANSFER") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT engineno FROM item_Details WHERE engineno LIKE '{sReference}'")
            If sType.Contains("RELEASE") Or sType.Contains("ACQUIRED") Or sType.Contains("ASSUME") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT EngineNo FROM CustAccount WHERE EngineNo LIKE '{sReference}'")
            If sType.Contains("PAYMENT") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT ORNumber FROM TransactionPayments WHERE ORNumber LIKE '{sReference}'  AND ErrorTag NOT LIKE 1")
            If sType.Contains("CASHIERING") Then
                If sType.Contains("BRANCH") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT ORNumber FROM TransactionOtherCash WHERE ORNumber LIKE '{sReference}' AND ErrorTag NOT LIKE 1")
                If sType.Contains("CM") Then Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT ORNumber FROM TransactionCM WHERE ORNumber LIKE '{sReference}'")
            End If
            Return False
        End Function

        Public Function Root_Data_Verify(ByVal sType As String, ByVal iTableID As Integer, ByVal iJournal As Integer) As Boolean
            If iTableID > 0 Then
                If sType.Contains("VOUCHER") Then Return True
                If sType.Contains("RECEIVING") Then Return class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Master SET IsJournal = {iJournal} WHERE id LIKE '{iTableID}'")
                If sType.Contains("TRANSFER") Then Return class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET IsJournal = {iJournal} WHERE id LIKE '{iTableID}'")
                If sType.Contains("RELEASE") Or sType.Contains("ACQUIRED") Or sType.Contains("ASSUME") Then Return class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE CustAccount SET IsJournal = {iJournal} WHERE sequenceNo LIKE '{iTableID}'")
                If sType.Contains("PAYMENT") Then Return class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE TransactionPayments SET IsJournal = {iJournal} WHERE ID LIKE '{iTableID}' AND ErrorTag NOT LIKE 1")
                If sType.Contains("CASHIERING") Then
                    If sType.Contains("IBC") Then Return class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE TransactionOtherCash SET IsJournal = {iJournal} WHERE ID LIKE '{iTableID}' AND ErrorTag NOT LIKE 1")
                    If sType.Contains("CM") Then
                        Return class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE TransactionCM SET IsJournal = {iJournal} WHERE ID LIKE '{iTableID}' AND ErrorTag NOT LIKE 1")
                    Else
                        Return class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE TransactionPayments SET IsJournal = {iJournal} WHERE ID LIKE '{iTableID}' AND ErrorTag NOT LIKE 1")
                    End If
                End If
            End If
            Return False
        End Function

        Public Function Transaction_Delete(ByVal gridView As GridView, ByVal sTransaction As String, ByVal sProcedureName As String, ByVal sActionType As String, Optional ByVal bLoopLive As Boolean = True) As Boolean
            With gridView
                Dim sReason As String = class_Functions.Show_Input_Box("Input reason for delete", $"Delete {sTransaction} Transaction(s)", String.Empty)

                If sReason.Length.Equals(0) OrElse Not class_Procedures.actionAsk($"Delete {sTransaction} Transaction(s)", $"delete selected {sTransaction} Transaction(s)", $"You might delete wrong {sTransaction} Transaction(s)") Then Return False

                class_Procedures.splash_Show($"Deleting {sTransaction} Transaction(s)")

                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = .GetSelectedRows()

                bLoopStop = False

                For i As Integer = 0 To selectedRows.Length - 1
                    iRowHandle = selectedRows(i)

                    If class_Functions.GridView_Loop(gridView, iRowHandleOld, iRowHandle, $"Delete {sTransaction} transactions", "deleted", bLoopStop, bLoopLive, True) Then
                        iRowHandleOld = iRowHandle
                    Else Return False
                    End If

                    Dim Parameters As SqlParameter() = {New SqlParameter("@ID", .GetRowCellDisplayText(iRowHandle, "ID")),
                                                        New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                        New SqlParameter("@Notes", sReason),
                                                        New SqlParameter("@Action_Type", sActionType)}

                    class_Database.Procedure_Execute(class_Database.ICSConnection, Parameters, sProcedureName, $"Delete {sTransaction} Transaction")
                Next

                Try
                    .DeleteSelectedRows()
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                Finally
                    class_Procedures.splash_Close()
                End Try
                Return True
            End With
        End Function

        Public Function Journal_Error_Report(ByVal gridView As GridView, ByVal sReference As String, Optional ByVal bLoopLive As Boolean = True) As Boolean
            With gridView
                Dim sReason As String = class_Functions.Show_Input_Box("Input reason for Error Report", "Error Report Journal Entry/Entries", String.Empty)

                If sReason.Length.Equals(0) OrElse Not class_Procedures.actionAsk("Error Report Journal Transaction(s)", "make an Error Report", "You might report wrong Journal Transactions") Then Return False

                class_Procedures.splash_Show("Error Reporting Journal Transaction(s)")

                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = .GetSelectedRows()


                bLoopStop = False

                For i As Integer = 0 To selectedRows.Length - 1
                    iRowHandle = selectedRows(i)

                    If class_Functions.GridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal(s) Error Report", "error reported", bLoopStop, bLoopLive, True) Then
                        iRowHandleOld = iRowHandle
                    Else Return False
                    End If

                    Dim sBrCode As String = .GetRowCellValue(iRowHandle, "Branch_Code")

                    Dim Parameters As SqlParameter() = {New SqlParameter("@ID", 0),
                                                    New SqlParameter("@Branch_Code", sBrCode),
                                                    New SqlParameter("@Error_Type", "JOURNAL"),
                                                    New SqlParameter("@Transaction_Reference", sReference),
                                                    New SqlParameter("@Transacted_By", .GetRowCellDisplayText(iRowHandle, "Posted_By")),
                                                    New SqlParameter("@Transaction_Date", .GetRowCellValue(iRowHandle, "Posting_Date")),
                                                    New SqlParameter("@Error_Description", sReason),
                                                    New SqlParameter("@Added_By", class_Variables.sUserName),
                                                    New SqlParameter("@Notes", .GetRowCellDisplayText(iRowHandle, "Notes")),
                                                    New SqlParameter("@Action_Type", "SAVE")}

                    class_Database.Procedure_Execute(class_Database.ICSConnection, Parameters, "acc_Error_Report_Procedures", "Error Report")
                Next
                class_Procedures.splash_Close()
                Return True
            End With
        End Function

        Public Function Filter_Save(ByVal gridView As GridView, ByVal sGroup As String, ByVal sFilter As String) As Boolean
            If sFilter.Equals(Nothing) Then Return False
            If Not class_Procedures.actionAsk("Save/Update Filter", $"Save/Update Filter {sGroup} {sFilter}", "You might overwrite existing filter") Then Return False

            class_Procedures.splash_Show("Saving filter Profile")
            Dim sQuery As String = $"SELECT Filter_Group, Filter_Name FROM acc_Grid_Filters WHERE Filter_Group LIKE '{sGroup}' AND Filter_Name LIKE '{sFilter}'"


            If Not class_Database.IsDataExist(class_Database.ICSConnection, sQuery) Then
                Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                    Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection) With {.CommandText = "INSERT INTO acc_Grid_Filters (Filter_Group, Filter_User, Filter_Name) VALUES (@Filter_Group, @Filter_User, @Filter_Name)"}

                        MyCommand.Parameters.Add("@Filter_Group", SqlDbType.VarChar).Value = sGroup
                        MyCommand.Parameters.Add("@Filter_User", SqlDbType.VarChar).Value = class_Variables.sUserName
                        MyCommand.Parameters.Add("@Filter_Name", SqlDbType.VarChar).Value = sFilter

                        Try
                            MySQLConnection.Open()
                            If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                                class_Procedures.Set_Message(class_Procedures.MsgMode.Save, "Filter Profile")
                                Return True
                            End If
                        Catch ex As Exception
                            Return class_Procedures.Show_Error(ex)
                        Finally
                            gridView.SaveLayoutToXml($"{sGroup} {sFilter}")
                            class_Procedures.splash_Close()
                        End Try
                    End Using
                End Using
            End If
            Return False
        End Function

        Public Function get_Journal_Cancelled() As Integer
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT FROM acc_Journal_Entries WHERE Journal_Status LIKE '%CANCELLED%' AND Corporation LIKE '{class_Saga_Variables.sCorporation}'", "COUNT")
        End Function

        Public Function get_Trial_Unbalanced() As Integer
            Dim iCount As Integer = 0

            Dim dTotalBeginningDebit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DISTINCT Corporation, Balance_Type, SUM(Beginning_Balance_Debit) As Beginning_Balance_Debit FROM acc_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Balance_Type LIKE 'DETAIL' AND Balance_Date = '{class_Saga_Variables.dtStart}' GROUP BY Corporation, Balance_Type", "Beginning_Balance_Debit"))
            Dim dTotalBeginningCredit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DISTINCT Corporation, Balance_Type, SUM(Beginning_Balance_Credit) As Beginning_Balance_Credit FROM acc_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Balance_Type LIKE 'DETAIL' AND Balance_Date = '{class_Saga_Variables.dtStart}' GROUP BY Corporation, Balance_Type", "Beginning_Balance_Credit"))
            If Not dTotalBeginningDebit.Equals(dTotalBeginningDebit) Then iCount += 1

            Dim dTotalDebit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DISTINCT Corporation, Balance_Type, SUM(Total_Debit) As Total_Debit FROM acc_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Balance_Type LIKE 'DETAIL' AND Balance_Date = '{class_Saga_Variables.dtStart}' GROUP BY Corporation, Balance_Type", "Total_Debit"))
            Dim dTotalCredit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DISTINCT Corporation, Balance_Type, SUM(Total_Credit) As Total_Credit FROM acc_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Balance_Type LIKE 'DETAIL' AND Balance_Date = '{class_Saga_Variables.dtStart}' GROUP BY Corporation, Balance_Type", "Total_Credit"))
            If Not dTotalDebit.Equals(dTotalCredit) Then iCount += 1

            Dim dTotalEndingDebit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DISTINCT Corporation, Balance_Type, SUM(Ending_Balance_Debit) As Ending_Balance_Debit FROM acc_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Balance_Type LIKE 'DETAIL' AND Balance_Date = '{class_Saga_Variables.dtStart}' GROUP BY Corporation, Balance_Type", "Ending_Balance_Debit"))
            Dim dTotalEndingCredit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DISTINCT Corporation, Balance_Type, SUM(Ending_Balance_Credit) As Ending_Balance_Credit FROM acc_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Balance_Type LIKE 'DETAIL' AND Balance_Date = '{class_Saga_Variables.dtStart}' GROUP BY Corporation, Balance_Type", "Ending_Balance_Credit"))
            If Not dTotalDebit.Equals(dTotalCredit) Then iCount += 1

            Return iCount
        End Function

        Public Function Is_Ceiling_Reached(ByVal bForLiquidation As Boolean, ByVal bLTO As Boolean, Optional ByVal dTotal As Decimal = 0) As Boolean
            If bForLiquidation Then
                If bLTO Then
                    Dim dTotalLTO As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT SUM(Liquidation_Total) AS Liquidation_Total FROM view_Vouchers WHERE IsForLiquidation = 1 AND IsLTO = 1 AND IsLiquidated <> 1", "Liquidation_Total"))
                    If (dTotal + dTotalLTO) > 1500000 Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Cash Advance for LTO Registration has reached the maximum limit.{Environment.NewLine}Please contact Accounting Administrator for information", "Ceiling Amount reached", True)
                        Return False
                    End If
                Else
                    Dim dTotalLiquidation As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT SUM(Liquidation_Total) AS Liquidation_Total FROM view_Vouchers WHERE IsForLiquidation = 1 AND IsLTO <> 1 AND IsLiquidated <> 1", "Liquidation_Total"))
                    If (dTotal + dTotalLiquidation) > 750000 Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Cash Advance for Employees has reached the maximum limit.{Environment.NewLine}Please contact Accounting Administrator for information", "Ceiling Amount reached", True)
                        Return True
                    End If
                End If
            End If
            Return False
        End Function

    End Module
End Namespace