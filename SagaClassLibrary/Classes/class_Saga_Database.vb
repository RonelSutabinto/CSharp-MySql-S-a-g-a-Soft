Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
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

        Public Function get_Corporation_Name(ByVal sCorporation As String) As String
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Action_Type", "GET_CORP_FULL_NAME"),
                New SqlParameter("@Corporation", sCorporation)
            }
            Return class_Database.Procedure_Get(class_Database.ICSConnection, sqlParameters, "app_Global_Procedures", "Full_Name")
        End Function

        Public Function get_Branch_Name(ByVal sBrCode As String) As String
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, Branch FROM BranchParameters WHERE BranchCode LIKE '{sBrCode}'", "Branch")
        End Function

        Public Function get_Branch_Date(ByVal sBrCode As String) As Date
            Return Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, DatabaseDate FROM BranchParameters WHERE BranchCode LIKE '{sBrCode}'", "DatabaseDate"))
        End Function

        Public Function get_Branch_Address(ByVal sBrCode As String) As String
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, Address FROM BranchParameters WHERE BranchCode LIKE '{sBrCode}'", "Address")
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
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT FROM {sTable} WHERE IsJournal NOT LIKE 1 AND {sDateField} >= CONVERT(VARCHAR(10), '{class_Functions.FirstDayOfMonth(class_Saga_Variables.dtStart)}', 23) AND {sDateField} <= CONVERT(VARCHAR(10), '{class_Functions.LastDayOfMonth(class_Saga_Variables.dtEnd)}', 23)", "COUNT")
        End Function

        Public Function get_IBC_Errors() As Integer
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT FROM view_Payment_Transactions WHERE Remarks LIKE 'APAY' AND Mnemonic NOT LIKE 'INTPAY' AND PostingDate >= CONVERT(VARCHAR(10), '{class_Functions.FirstDayOfMonth(class_Saga_Variables.dtStart)}', 23) AND PostingDate <= CONVERT(VARCHAR(10), '{class_Functions.LastDayOfMonth(class_Saga_Variables.dtEnd)}', 23)", "COUNT")
        End Function

        Public Function get_Multiple_Existing_Inventory() As Integer
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT EngineNo, IfExist, COUNT(EngineNo) AS COUNT FROM item_Details WHERE IfExist LIKE 1 GROUP BY EngineNo, IfExist HAVING COUNT(EngineNo) > 1", "COUNT")
        End Function

        Public Function Reference_Exist(ByVal sReference As String) As Boolean
            Return class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT Journal_Reference FROM acc_Journal_Entries WHERE Journal_Reference LIKE '{sReference}'")
        End Function

        Public Function Is_Branch_Date_Equal_Server(ByVal sBrCode As String, ByVal dtPostingDate As Date) As Boolean
            Dim dtBranchDate As Date = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, DatabaseDate FROM BranchParameters WHERE BranchCode LIKE '{sBrCode}'", "DatabaseDate"))
            If dtPostingDate < dtBranchDate Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Your Branch Date was locked to {dtBranchDate:D}{Environment.NewLine}Contact Accounting or IT Department for more information.", "Backdating Error", True)
                Return False
            Else
                Return True
            End If
        End Function

        Public Sub Get_User_Privileges(ByVal sUserName As String)
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                New SqlParameter("@UserName", sUserName),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_User_Procedures")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    Try
                        class_Variables.sUserName = sUserName
                        class_Variables.sUserFullName = myDataReader("fullname").ToString
                        class_Variables.sPosition = myDataReader("designation").ToString
                        class_Variables.isAdministrator = Convert.ToBoolean(myDataReader("IsSuperUser"))

                        class_Saga_Variables.sCorporation = myDataReader("Corporation").ToString
                        'class_Saga_Variables.sBranchCode = myDataReader("branchcode").ToString

                        class_Saga_Variables.isMaintenance = Convert.ToBoolean(myDataReader("IsMaintenance"))

                        class_Saga_Variables.isApprover = Convert.ToBoolean(myDataReader("IsApprover"))

                        class_Saga_Variables.isAccounting = Convert.ToBoolean(myDataReader("IsAccounting"))
                        class_Saga_Variables.isCashier = Convert.ToBoolean(myDataReader("IsCashier"))
                        class_Saga_Variables.isAudit = Convert.ToBoolean(myDataReader("IsAudit"))
                        class_Saga_Variables.isLogistics = Convert.ToBoolean(myDataReader("IsLogistics"))
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
        End Sub

        Public Function Reset_Pass(ByVal sUserName As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
               New SqlParameter("@Username", sUserName),
               New SqlParameter("@Action_Type", "PASSWORD_RESET")
           }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_User_Procedures", "reset User Password", sUserName)
        End Function

        Private Function Journal_Cut_Off_Date_Above(ByVal sBrCode As String, ByVal objPostingDate As Object) As Boolean
            Try
                Dim dtPostingDate As Date = Convert.ToDateTime(objPostingDate)
                Dim dtCutOffDate As Date = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT BranchCode, Cut_Off_Date FROM BranchParameters WHERE BranchCode LIKE '{sBrCode}'", "Cut_Off_Date"))

                If dtPostingDate <= dtCutOffDate Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Journal entry posting date was locked.{Environment.NewLine}Please contact Accounting Administrator.", "Journal Cut Off Date")
                    Return False
                ElseIf dtPostingDate > Date.Today Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Journal entry posting eate error.{Environment.NewLine}You cannot post journal entries in advance.", "Journal Posting Date Error")
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Return class_Procedures.Show_Error(ex, sTitle:="Date Error", sPostMessage:="Posting or Cut-Off Date is Null or No Value")
            End Try
        End Function

        'Batch Journal Entry
        Public Function Journal_Entry_Save(ByVal sProcedureType As String, ByVal iTableID As Integer, ByVal objPostingDate As Object, Optional ByVal bCustomPosting As Boolean = False, Optional ByVal sReason As String = "") As Boolean
            Dim dtPostingDate As Date = Convert.ToDateTime(objPostingDate)

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Table_ID", iTableID),
                New SqlParameter("@Custom_Posting", bCustomPosting),
                New SqlParameter("@Custom_Posting_Date", dtPostingDate),
                New SqlParameter("@Reason", sReason),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", sProcedureType)
            }
            Return Journal_Cut_Off_Date_Above(class_Saga_Variables.sBranchCode, dtPostingDate) AndAlso class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Journal_Batch_Entry", $"{iTableID}")
        End Function

        Public Function Journal_Verify(ByVal iTableID As Integer, ByVal sAction As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Table_ID", iTableID),
                New SqlParameter("@Verified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", sAction)
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Verification_Procedures", $"{iTableID}")
        End Function

        Public Function Journal_Verify(ByVal iTableID As Integer, ByVal sAction As String, ByVal iID As Integer) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Table_ID", iTableID),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@ID", iID),
                New SqlParameter("@Action_Type", sAction)
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Journal_Procedures", $"{iTableID}")
        End Function

        'System Generated i.e. Unit transfers, Sales and Releases / Journal Entry Group
        Public Function Journal_Entry_Save(ByVal bMayExist As Boolean, ByVal iTableID As Integer, ByVal sJournalCode As String, ByVal sCorporation As String, ByVal sBrCode As String, ByVal sCOACode As String, ByVal sReference As String, ByVal sJournalType As String, ByVal sJournalProfile As String, ByVal sAccountCode As String, ByVal sAccountName As String, ByVal dDebit As Decimal, ByVal dCredit As Decimal, ByVal sDescription As String, ByVal sPostedBy As String, ByVal dtPostingDate As Date, Optional ByVal sNotes As String = "") As Boolean
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

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Table_ID", iTableID),
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
                New SqlParameter("@Posting_Date", dtPostingDate),
                New SqlParameter("@Transacted_By", sPostedBy),
                New SqlParameter("@Transaction_Date", dtPostingDate),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Notes", sNotes.Trim),
                New SqlParameter("@Action_Type", sActionType)
            }
            Return Journal_Cut_Off_Date_Above(sBrCode, dtPostingDate) AndAlso class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Journal_Procedures", $"{sJournalCode}")
        End Function

        'System Generated i.e. Payment Collections and Cashiering
        'The difference is posting date with transaction date
        Public Function Journal_Entry_Save(ByVal bMayExist As Boolean, ByVal iTableID As Integer, ByVal sJournalCode As String, ByVal sCorporation As String, ByVal sBrCode As String, ByVal sCOACode As String, ByVal sReference As String, ByVal sJournalType As String, ByVal sJournalProfile As String, ByVal sAccountCode As String, ByVal sAccountName As String, ByVal dDebit As Decimal, ByVal dCredit As Decimal, ByVal sDescription As String, ByVal sPostedBy As String, ByVal dtPostingDate As Date, ByVal sTransactedBy As String, ByVal dtTransaction As DateTime, Optional ByVal sNotes As String = "") As Boolean
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

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Table_ID", iTableID),
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
                New SqlParameter("@Posting_Date", dtPostingDate),
                New SqlParameter("@Transacted_By", sTransactedBy),
                New SqlParameter("@Transaction_Date", dtTransaction),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Notes", sNotes.Trim),
                New SqlParameter("@Action_Type", sActionType)
            }
            Return Journal_Cut_Off_Date_Above(sBrCode, dtPostingDate) AndAlso class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Journal_Procedures", $"{sJournalCode}")
        End Function

        'Journal Entry Update
        Public Function Journal_Entry_Update(ByVal iID As Integer, ByVal iTableID As Integer, ByVal sCorporation As String, ByVal sBrCode As String, ByVal sCOACode As String, ByVal sReference As String, ByVal sType As String, ByVal sProfile As String, ByVal sAccountCode As String, ByVal sAccountName As String, ByVal dDebit As Decimal, ByVal dCredit As Decimal, ByVal sCheckNumber As String, ByVal sDescription As String, ByVal dtPostingDate As Date, ByVal sNotes As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", iID),
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
                New SqlParameter("@Posting_Date", dtPostingDate),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Notes", sNotes.Trim),
                New SqlParameter("@Action_Type", "UPDATE")
            }
            Return Journal_Cut_Off_Date_Above(sBrCode, dtPostingDate) AndAlso class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Journal_Procedures", "Journal Entry Update")
        End Function

        Public Function Change_Status_Journal(ByVal iID As Integer, ByVal sSTatus As String, Optional ByVal sNotes As String = "") As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", iID),
                New SqlParameter("@Journal_Status", sSTatus),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Notes", sNotes.Trim),
                New SqlParameter("@Action_Type", "STATUS")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Journal_Procedures", "Journal Status")
        End Function

        Public Function Change_Status_Balance(ByVal iID As Integer, ByVal sSTatus As String, Optional ByVal sNotes As String = "") As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", iID),
                New SqlParameter("@Balance_Status", sSTatus),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Notes", sNotes.Trim),
                New SqlParameter("@Action_Type", "STATUS")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Balance_Procedures", "Balance Status")
        End Function

        Public Function Change_Status_Petty_Cash(ByVal iID As Integer, ByVal sNewStatus As String, Optional ByVal sReference As String = "", Optional ByVal sNotes As String = "") As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", iID),
                New SqlParameter("@Reference", sReference),
                New SqlParameter("@Status", sNewStatus),
                New SqlParameter("@Notes", sNotes),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "STATUS")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Procedures", "Petty Cash Status")
        End Function

        Public Function Liquidation(ByVal bLiquidated As Boolean, ByVal sVoucherReference As String, ByVal sJournalReference As String, ByVal dtLiquidation As Date, ByVal sDescription As String, ByVal sJustification As String, ByVal sNotes As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Journal_Reference", sJournalReference),
                New SqlParameter("@Voucher_Reference", sVoucherReference),
                New SqlParameter("@IsLiquidated", bLiquidated),
                New SqlParameter("@Liquidated_By", class_Variables.sUserName),
                New SqlParameter("@Justification", sJustification),
                New SqlParameter("@Journal_Description", sDescription),
                New SqlParameter("@Notes", sNotes),
                New SqlParameter("@Action_Type", "LIQUIDATION")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Liquidation_Procedures", "Voucher/Journal Liquidation")
        End Function

        Public Function Update_Transaction_Status(ByVal sProcedureName As String, ByVal sActionType As String, ByVal iID As Integer, ByVal sCodeParameter As String, ByVal sCodeValue As String, ByVal sDescription As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", iID),
                New SqlParameter(sCodeParameter, sCodeValue),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", sActionType)
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, sProcedureName, sDescription, sCodeValue)
        End Function

        Public Sub Update_Transaction_Status(ByVal gridView As gridView, ByVal modeTransaction As eTransaction, ByVal sStatusFieldName As String, ByVal sPrevStatus As String, ByVal sNewStatus As String, Optional ByVal bLoopLive As Boolean = True, Optional ByVal bClearSelection As Boolean = True, Optional sReference As String = "")
            With gridView
                If .SelectedRowsCount > 0 Then
                    If class_Saga_Variables.isAccounting Or class_Saga_Variables.isCashier Then
                        If Not class_Procedures.actionAsk("Update Transaction Status", $"send selected {sPrevStatus} {modeTransaction} to {sNewStatus}") Then Return
                        class_Procedures.splash_Show($"Sending {modeTransaction} for {sNewStatus}", , True)

                        Dim iID, iRowHandle, iRowHandleOld As Integer
                        Dim selectedRows As Integer() = .GetSelectedRows()

                        class_Database.DBError = False
                        bLoopStop = False
                        If bClearSelection Then .ClearSelection()

                        For i As Integer = 0 To selectedRows.Length - 1
                            iRowHandle = selectedRows(i)

                            If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, sStatusFieldName, "updated", bLoopStop, bLoopLive) Then
                                iRowHandleOld = iRowHandle
                            Else Return
                            End If

                            Try
                                iID = Convert.ToInt32(.GetRowCellValue(iRowHandle, "ID"))
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                                Return
                            Finally
                                class_Procedures.splash_Close()
                            End Try

                            Try
                                If .GetRowCellDisplayText(iRowHandle, sStatusFieldName).Equals(sPrevStatus) Then
                                    Select Case modeTransaction
                                        Case eTransaction.Journal
                                            class_Saga_Database.Change_Status_Journal(iID, sNewStatus, .GetRowCellDisplayText(iRowHandle, "Notes"))

                                        Case eTransaction.Balance
                                            class_Saga_Database.Change_Status_Balance(iID, sNewStatus, .GetRowCellDisplayText(iRowHandle, "Notes"))

                                        Case eTransaction.Petty_Cash
                                            class_Saga_Database.Change_Status_Petty_Cash(iID, sNewStatus, sReference, .GetRowCellDisplayText(iRowHandle, "Notes"))
                                    End Select

                                    .SetRowCellValue(iRowHandle, sStatusFieldName, sNewStatus)

                                    Select Case sNewStatus
                                        Case "FOR APPROVAL"
                                            .SetRowCellValue(iRowHandle, "Modified_By", class_Variables.sUserName)
                                            .SetRowCellValue(iRowHandle, "Modified_Date", DateTime.Now)

                                        Case "DISAPPROVED"
                                            .SetRowCellValue(iRowHandle, "Modified_By", class_Variables.sUserName)
                                            .SetRowCellValue(iRowHandle, "Modified_Date", DateTime.Now)

                                        Case "APPROVED"
                                            .SetRowCellValue(iRowHandle, "Approved_By", class_Variables.sUserName)
                                            .SetRowCellValue(iRowHandle, "Approved_Date", DateTime.Now)

                                        Case "FOR LIQUIDATION"
                                            .SetRowCellValue(iRowHandle, "Modified_By", class_Variables.sUserName)
                                            .SetRowCellValue(iRowHandle, "Modified_Date", DateTime.Now)

                                        Case "LOCKED"
                                            .SetRowCellValue(iRowHandle, "IsLocked", 1)
                                            .SetRowCellValue(iRowHandle, "Locked_By", class_Variables.sUserName)
                                            .SetRowCellValue(iRowHandle, "Locked_Date", DateTime.Now)

                                    End Select
                                End If
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                                class_Procedures.splash_Close(True)
                            End Try
                        Next

                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Selected Journal Entries were being forwarded to {sNewStatus}.", sNewStatus)
                        class_Procedures.splash_Close(True)
                    Else
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Approval/Approving Journal Entries is unauthorized.{Environment.NewLine}Please contact Accounting Administrator.", "Unauthorized Access", True)
                    End If
                End If
            End With
        End Sub

        Public Function Balance_Notes_Save(ByVal iID As Integer, ByVal sNotes As String) As String
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", iID),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Notes", sNotes.Trim),
                New SqlParameter("@Action_Type", "NOTES")
            }
            If class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Balance_Procedures", "Trial Balance Notes") Then
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
                    MyCommand.Parameters.Add("@Modified_Date", SqlDbType.VarChar).Value = Date.Today

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
        Public Function Balance_Save(ByVal sActionType As String, ByVal sBalanceType As String, ByVal eDateType As eLoad_Type, ByVal sBrCode As String, ByVal sCOACode As String, ByVal dtBalance As Date, Optional ByVal bCloseEntry As Boolean = False, Optional ByVal dBeginningBalanceDebit As Decimal = 0, Optional ByVal dBeginningBalanceCredit As Decimal = 0, Optional ByVal dTotalDebit As Decimal = 0, Optional ByVal dTotalCredit As Decimal = 0, Optional ByVal dBalanceEndDebit As Decimal = 0, Optional ByVal dBalanceEndCredit As Decimal = 0, Optional dBalanceSheet As Decimal = 0, Optional dIncomeStatement As Decimal = 0, Optional sNotes As String = "") As Boolean
            Dim dtBalanceStart, dtBalanceEnd As Date
            Select Case eDateType
                Case class_Saga_Variables.eLoad_Type.Daily
                    dtBalance = dtBalance
                    dtBalanceStart = dtBalance
                    dtBalanceEnd = dtBalance
                Case class_Saga_Variables.eLoad_Type.Monthly
                    dtBalance = class_Functions.FirstDayOfMonth(dtBalance)
                    dtBalanceStart = class_Functions.FirstDayOfMonth(dtBalance)
                    dtBalanceEnd = class_Functions.LastDayOfMonth(dtBalance)
                Case class_Saga_Variables.eLoad_Type.Range
                    dtBalance = class_Saga_Variables.dtStart
                    dtBalanceStart = class_Saga_Variables.dtStart
                    dtBalanceEnd = class_Saga_Variables.dtEnd
            End Select

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
                New SqlParameter("@Branch_Code", sBrCode),
                New SqlParameter("@Balance_Type", sBalanceType),
                New SqlParameter("@Balance_Date", dtBalance),
                New SqlParameter("@Date_Type", eDateType.ToString.ToUpper),
                New SqlParameter("@COA_Code", sCOACode),
                New SqlParameter("@Close_Entry", bCloseEntry),
                New SqlParameter("@Beginning_Balance_Debit", dBeginningBalanceDebit),
                New SqlParameter("@Beginning_Balance_Credit", dBeginningBalanceCredit),
                New SqlParameter("@Date_Range_Start", dtBalanceStart),
                New SqlParameter("@Date_Range_End", dtBalanceEnd),
                New SqlParameter("@Total_Debit", dTotalDebit),
                New SqlParameter("@Total_Credit", dTotalCredit),
                New SqlParameter("@Ending_Balance_Debit", dBalanceEndDebit),
                New SqlParameter("@Ending_Balance_Credit", dBalanceEndCredit),
                New SqlParameter("@Balance_Sheet", dBalanceSheet),
                New SqlParameter("@Income_Statement", dIncomeStatement),
                New SqlParameter("@Balance_Status", "PENDING"),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Notes", sNotes),
                New SqlParameter("@Action_Type", sActionType)
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Balance_Procedures", "Trial Balance Debit/Credit Update")
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

        Public Sub Verify_Transaction(ByVal sTable As String, ByVal gridView As gridView, ByVal colNotes As GridColumn, ByVal iRowhandle As Integer, ByVal iTableID As Integer, ByVal sReference As String, Optional ByVal dTotalDebitCredit As Decimal = 0, Optional ByVal sIDFieldName As String = "ID", Optional ByVal bAccountCodeAsReference As Boolean = False)
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

        Public Function Transaction_Delete(ByVal gridView As gridView, ByVal sTransaction As String, ByVal sProcedureName As String, ByVal sActionType As String, Optional ByVal bLoopLive As Boolean = True) As Boolean
            With gridView
                class_Database.DBError = False

                Dim sReason As String = class_Functions.Show_Input_Box("Input reason for delete", $"Delete {sTransaction} Transaction(s)", String.Empty)

                If sReason.Length.Equals(0) OrElse Not class_Procedures.actionAsk($"Delete {sTransaction} Transaction(s)", $"delete selected {sTransaction} Transaction(s)", $"You might delete wrong {sTransaction} Transaction(s)") Then Return False

                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = .GetSelectedRows()

                bLoopStop = False

                For i As Integer = 0 To selectedRows.Length - 1
                    iRowHandle = selectedRows(i)

                    If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, $"Delete {sTransaction} transactions", "deleted", bLoopStop, bLoopLive, True) Then
                        iRowHandleOld = iRowHandle
                    Else Return False
                    End If

                    Dim sqlParameters As SqlParameter() = {
                        New SqlParameter("@ID", .GetRowCellValue(iRowHandle, "ID")),
                        New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                        New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                        New SqlParameter("@Modified_By", class_Variables.sUserName),
                        New SqlParameter("@Notes", sReason),
                        New SqlParameter("@Action_Type", sActionType)
                    }
                    class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, sProcedureName, $"Delete {sTransaction} Transaction")
                Next

                Try
                    .DeleteSelectedRows()
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
                Return True
            End With
        End Function

        Public Function Journal_Error_Report(ByVal gridView As gridView, ByVal sReference As String, Optional ByVal bLoopLive As Boolean = True) As Boolean
            With gridView
                Dim sReason As String = class_Functions.Show_Input_Box("Input reason for Error Report", "Error Report Journal Entry/Entries", String.Empty)

                If sReason.Length.Equals(0) OrElse Not class_Procedures.actionAsk("Error Report Journal Transaction(s)", "make an Error Report", "You might report wrong Journal Transactions") Then Return False

                class_Procedures.splash_Show("Error Reporting Journal Transaction(s)")

                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = .GetSelectedRows()


                bLoopStop = False

                For i As Integer = 0 To selectedRows.Length - 1
                    iRowHandle = selectedRows(i)

                    If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal(s) Error Report", "error reported", bLoopStop, bLoopLive, True) Then
                        iRowHandleOld = iRowHandle
                    Else Return False
                    End If

                    Dim sBrCode As String = .GetRowCellValue(iRowHandle, "Branch_Code")

                    Dim sqlParameters As SqlParameter() = {
                        New SqlParameter("@ID", 0),
                        New SqlParameter("@Branch_Code", sBrCode),
                        New SqlParameter("@Error_Type", "JOURNAL"),
                        New SqlParameter("@Transaction_Reference", sReference),
                        New SqlParameter("@Transacted_By", .GetRowCellDisplayText(iRowHandle, "Posted_By")),
                        New SqlParameter("@Transaction_Date", .GetRowCellValue(iRowHandle, "Posting_Date")),
                        New SqlParameter("@Error_Description", sReason),
                        New SqlParameter("@Added_By", class_Variables.sUserName),
                        New SqlParameter("@Notes", .GetRowCellDisplayText(iRowHandle, "Notes")),
                        New SqlParameter("@Action_Type", "SAVE")
                    }
                    class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Error_Report_Procedures", "Error Report")
                Next
                class_Procedures.splash_Close()
                Return True
            End With
        End Function

        Public Function Filter_Save(ByVal gridView As gridView, ByVal sGroup As String, ByVal sFilter As String) As Boolean
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

        Public Function get_Journal_Unbalanced() As Integer
            Dim gv = New Controls.Accounting.xuc_Grid_Journal_References
            gv.Control_Data_Load()
            Return gv.Control_Validate_Journal_Entries()
        End Function

        Public Function get_Journal_Cancelled() As Integer
            Return class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT(*) AS COUNT FROM acc_Journal_Entries WHERE Journal_Status LIKE '%CANCELLED%' AND Corporation LIKE '{class_Saga_Variables.sCorporation}'", "COUNT")
        End Function

        Public Function get_Trial_Unbalanced() As Integer
            Dim iCount As Integer = 0

            Dim dTotalBeginningDebit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DISTINCT Corporation, Balance_Type, SUM(Beginning_Balance_Debit) As Beginning_Balance_Debit FROM acc_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Balance_Type LIKE 'DETAIL' AND Balance_Date = '{class_Saga_Variables.dtStart}' GROUP BY Corporation, Balance_Type", "Beginning_Balance_Debit"))
            Dim dTotalBeginningCredit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DISTINCT Corporation, Balance_Type, SUM(Beginning_Balance_Credit) As Beginning_Balance_Credit FROM acc_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Balance_Type LIKE 'DETAIL' AND Balance_Date = '{class_Saga_Variables.dtStart}' GROUP BY Corporation, Balance_Type", "Beginning_Balance_Credit"))
            If Not dTotalBeginningDebit.Equals(dTotalBeginningCredit) Then iCount += 1

            Dim dTotalDebit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DISTINCT Corporation, Balance_Type, SUM(Total_Debit) As Total_Debit FROM acc_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Balance_Type LIKE 'DETAIL' AND Balance_Date = '{class_Saga_Variables.dtStart}' GROUP BY Corporation, Balance_Type", "Total_Debit"))
            Dim dTotalCredit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DISTINCT Corporation, Balance_Type, SUM(Total_Credit) As Total_Credit FROM acc_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Balance_Type LIKE 'DETAIL' AND Balance_Date = '{class_Saga_Variables.dtStart}' GROUP BY Corporation, Balance_Type", "Total_Credit"))
            If Not dTotalDebit.Equals(dTotalCredit) Then iCount += 1

            Dim dTotalEndingDebit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DISTINCT Corporation, Balance_Type, SUM(Ending_Balance_Debit) As Ending_Balance_Debit FROM acc_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Balance_Type LIKE 'DETAIL' AND Balance_Date = '{class_Saga_Variables.dtStart}' GROUP BY Corporation, Balance_Type", "Ending_Balance_Debit"))
            Dim dTotalEndingCredit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DISTINCT Corporation, Balance_Type, SUM(Ending_Balance_Credit) As Ending_Balance_Credit FROM acc_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Balance_Type LIKE 'DETAIL' AND Balance_Date = '{class_Saga_Variables.dtStart}' GROUP BY Corporation, Balance_Type", "Ending_Balance_Credit"))
            If Not dTotalEndingDebit.Equals(dTotalEndingCredit) Then iCount += 1

            Return iCount
        End Function

        Public Function Is_Ceiling_Reached(ByVal bForLiquidation As Boolean, ByVal bLTO As Boolean, Optional ByVal dTotal As Decimal = 0) As Boolean
            If bForLiquidation Then
                If bLTO Then
                    Dim dTotalLTO As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT SUM(Liquidation_Total) AS Liquidation_Total FROM view_Vouchers WHERE IsForLiquidation = 1 AND IsLTO = 1 AND IsLiquidated <> 1", "Liquidation_Total"))
                    If (dTotal + dTotalLTO) > 1500000 Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Cash Advance for LTO Registration has reached the maximum limit.{Environment.NewLine}Please contact Accounting Administrator for information", "Ceiling Amount reached", True)
                        Return True
                    End If
                Else
                    Dim dTotalLiquidation As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT SUM(Liquidation_Total) AS Liquidation_Total FROM view_Vouchers WHERE IsForLiquidation = 1 AND IsLTO <> 1 AND IsLiquidated <> 1", "Liquidation_Total"))
                    If (dTotal + dTotalLiquidation) > 750000 Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Cash Advance for Employees (SFC and SMC {dTotalLiquidation:N2}){Environment.NewLine}has reached the maximum limit (750,000.00).{Environment.NewLine}Please contact Accounting Administrator for information", "Ceiling Amount reached", True)
                        Return True
                    End If
                End If
            End If
            Return False
        End Function

        Friend Function Add_To_PO(ByVal sOrderCode As String, ByVal sBranchCode As String, ByVal sModelCode As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                 New SqlParameter("@Order_Code", sOrderCode),
                 New SqlParameter("@Branch_Code", sBranchCode),
                 New SqlParameter("@Model_Code", sModelCode),
                 New SqlParameter("@Added_By", class_Variables.sUserName),
                 New SqlParameter("@Action_Type", "ADD_EMPTY_PO")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Purchase_Order_Procedures", "Add Empty PO", sModelCode)
        End Function

    End Module
End Namespace