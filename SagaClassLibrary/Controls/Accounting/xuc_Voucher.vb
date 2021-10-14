Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Controls.Accounting

    Public Class xuc_Voucher
        Friend dAmount As Decimal
        Friend bAutoExpire As Boolean
        Friend iExpiryDays As Integer

        Private sVoucherType As String
        Friend sVoucherCodeOld As String

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Branch(Voucher_Branch)
            class_Saga_Procedures.Initialize_Corporation(Corporation)
            class_Saga_Procedures.Initialize_COA(COA_Code, eCOA_Type.COA_Bank)

            class_Database.Fill_Edit(class_Database.ICSConnection, Voucher_Profile, "acc_Vouchers", "Voucher_Profile")
            class_Database.Fill_Edit(class_Database.ICSConnection, Voucher_Approver, "acc_Vouchers", "Voucher_Approver")

            Load_Liquidation_Types()
            class_Saga_Procedures.Initialize_Budget(Budget_Code)
            'class_Saga_Procedures.Initialize_Liquidation(Journal_Reference, SearchLookUpEditView)

            Voucher_Date_Posted.EditValue = Date.Today
            Liquidation_Date_Return.EditValue = Date.Today
            Liquidation_Date_Expiry.EditValue = Date.Today

            Voucher_Approver.Text = class_Tools.RegKeyGet(Me.Name, Voucher_Approver.Name, String.Empty)
            journal_Profile.Text = class_Tools.RegKeyGet(Me.Name, journal_Profile.Name, String.Empty)
        End Sub

        Public Function Get_Code(ByVal voucherType As eVoucherType) As String
            Dim sPreCode As String = String.Empty
            Select Case voucherType
                Case class_Saga_Variables.eVoucherType.Check
                    sPreCode = $"CVHO{class_Saga_Variables.sCorporation.Substring(1, 1)}"

                Case class_Saga_Variables.eVoucherType.Expense
                    sPreCode = $"JVHO{class_Saga_Variables.sCorporation.Substring(1, 1)}"

                Case class_Saga_Variables.eVoucherType.Journal
                    sPreCode = $"EVHO{class_Saga_Variables.sCorporation.Substring(1, 1)}"

            End Select

            Return class_Database.Get_Last_ID(class_Database.ICSConnection, "acc_Vouchers", "Voucher_Code", $"{sPreCode}{class_Saga_Variables.dtStart:yy}-", 8)
        End Function

        Private Function Get_Reference(ByVal voucherType As eVoucherType) As String
            Select Case voucherType
                Case class_Saga_Variables.eVoucherType.Check
                    Return $"VOUCHER-{Voucher_Code.Text}"

                Case class_Saga_Variables.eVoucherType.Expense
                    Return $"EXPENSE-{Voucher_Code.Text}"

                Case class_Saga_Variables.eVoucherType.Journal
                    Return $"JOURNAL-{Voucher_Code.Text}"

            End Select
            Return String.Empty
        End Function

        Friend Sub Load_Checks(ByVal checks As TokenEdit, ByVal sCOACode As String, Optional ByVal sShowMode As String = "INFO")
            If sCOACode Is Nothing OrElse sCOACode.Equals(String.Empty) Then Return

            Dim sQuery As String = Nothing
            Select Case sShowMode
                Case "INFO"
                    sQuery = $"SELECT Check_Number, Corporation, Bank_Account, Voucher_Code, Reference, COA_Code FROM view_Checks WHERE Check_Number LIKE '{sCOACode}'"

                Case "ISSUED"
                    sQuery = $"SELECT Check_Number, Corporation, Bank_Account, Voucher_Code, Reference, COA_Code FROM view_Checks WHERE COA_Code LIKE '{sCOACode}' AND IsIssued = 1 ORDER BY Check_Number"

                Case "NOT_ISSUED"
                    sQuery = $"SELECT Check_Number, Corporation, Bank_Account, Voucher_Code, Reference, COA_Code FROM view_Checks WHERE COA_Code LIKE '{sCOACode}' AND IsIssued <> 1 ORDER BY Check_Number"

                Case "ALL"
                    sQuery = $"SELECT Check_Number, Corporation, Bank_Account, Voucher_Code, Reference, COA_Code FROM view_Checks WHERE COA_Code LIKE '{sCOACode}' ORDER BY Check_Number" ' OR Voucher_Code LIKE '{sCOACode}' OR Reference LIKE '{sCOACode}'
            End Select

            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        class_Procedures.splash_Show("loading Check Numbers",, True)

                        MySQLConnection.Open()
                        Using myDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            checks.Properties.BeginUpdate()
                            checks.Properties.Tokens.Clear()

                            If myDataReader.HasRows Then
                                While myDataReader.Read()
                                    checks.Properties.Tokens.AddToken(($"{myDataReader("Check_Number")} [{myDataReader("Bank_Account")}] {myDataReader("Reference")}").Trim, myDataReader("Check_Number"))
                                End While
                                checks.Properties.EndUpdate()
                            End If
                        End Using
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    Finally
                        class_Procedures.splash_Close(True)
                    End Try
                End Using
            End Using
        End Sub

        Friend Sub Control_New(Optional ByVal bNew As Boolean = False, Optional ByVal voucherType As eVoucherType = class_Saga_Variables.eVoucherType.Check, Optional ByVal sBrCode As String = "000", Optional ByVal sDescription As String = "")
            If bNew AndAlso Not class_Procedures.actionAsk("New Cash/Check/Journal Voucher", "Create New Cash/Check/Journal Voucher", "You might lose unsaved data") Then Return

            class_Procedures.Initialize_Controls(Me, bNew)

            Corporation.EditValue = class_Saga_Variables.sCorporation
            Voucher_Code.Text = Get_Code(voucherType)
            Voucher_Reference.Text = Get_Reference(voucherType)
            Voucher_Branch.EditValue = sBrCode
            IsForLiquidation.IsOn = False
            IsLiquidated.IsOn = False

            Select Case voucherType
                Case class_Saga_Variables.eVoucherType.Check
                    sVoucherType = "CASH_CHECK"
                    Voucher_Profile.Text = "VOUCHER_"
                    Voucher_Approver.Text = class_Saga_Functions.Approver

                Case class_Saga_Variables.eVoucherType.Expense
                    sVoucherType = "PETTY_CASH"
                    Voucher_Profile.Text = "PETTY_CASH_EXPENSE"
                    Account_Code.Text = class_Saga_Database.get_Admin_Cashier_Code(sBrCode)
                    Account_Name.Text = class_Saga_Database.get_Admin_Cashier(sBrCode)
                    Voucher_Approver.Text = class_Saga_Functions.Approver
                    Voucher_Description.Text = sDescription

                Case class_Saga_Variables.eVoucherType.Journal
                    sVoucherType = "JOURNAL"
                    Voucher_Profile.Text = "JOURNAL_"
            End Select

            Voucher_Branch.Select()
        End Sub

        Private Sub Get_Searched_Name()
            Account_Code.Text = xuc_Account_Search.Code
            Account_Name.Text = xuc_Account_Search.AccountName
            Account_Name.Select()
        End Sub

        Private Sub Voucher_Name_BeforePopup(sender As Object, e As EventArgs) Handles Account_Name.BeforePopup
            PopupContainerControl.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Width", 500)
            PopupContainerControl.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Height", 400)
        End Sub

        Private Sub Account_Name_Popup(sender As Object, e As EventArgs) Handles Account_Name.Popup
            xuc_Account_Search.searchMode = Information.Account.xuc_Account_Search.Search_Mode.searchAccounts
            xuc_Account_Search.Load_Search(Account_Name.Text.Trim)
        End Sub

        Private Sub Account_Name_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles Account_Name.Closed
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Width", PopupContainerControl.Width)
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Height", PopupContainerControl.Height)

            Get_Searched_Name()
        End Sub

        Friend Sub Set_Check_Token(ByVal sCheck As String)
            Voucher_Check.Properties.BeginUpdate()
            Voucher_Check.Properties.Tokens.Clear()
            Voucher_Check.Properties.Tokens.AddToken(sCheck, sCheck)
            Voucher_Check.Properties.EndUpdate()
            Voucher_Check.EditValue = sCheck
        End Sub

        Friend Function Control_Retrieve(ByVal sCode As String) As Boolean
            'Dim sqlParameters As SqlParameter() = {
            '    New SqlParameter("@Voucher_Code", sCode),
            '    New SqlParameter("@Voucher_Reference", sCode),
            '    New SqlParameter("@Action_Type", "RETRIEVE")
            '}

            Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT * FROM view_Vouchers WHERE Voucher_Code LIKE '{sCode}' OR Voucher_Reference LIKE '{sCode}'")
                Try
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        ID.EditValue = myDataReader("ID").ToString
                        Corporation.EditValue = myDataReader("Corporation").ToString
                        Voucher_Code.Text = myDataReader("Voucher_Code").ToString
                        Voucher_Reference.Text = myDataReader("Voucher_Reference").ToString
                        Voucher_Branch.EditValue = myDataReader("Voucher_Branch").ToString
                        Voucher_Profile.Text = myDataReader("Voucher_Profile").ToString
                        Account_Code.Text = myDataReader("Account_Code").ToString
                        Account_Name.Text = myDataReader("Account_Name").ToString
                        Voucher_Description.Text = myDataReader("Voucher_Description").ToString
                        Voucher_Approver.Text = myDataReader("Voucher_Approver").ToString
                        Voucher_Date_Posted.EditValue = Convert.ToDateTime(myDataReader("Voucher_Date_Posted"))
                        Notes.Text = myDataReader("Notes").ToString

                        If Not IsDBNull(myDataReader("Voucher_Debit")) Then
                            Voucher_Debit.Value = Convert.ToDecimal(myDataReader("Voucher_Debit"))
                        End If

                        If Not IsDBNull(myDataReader("Voucher_Credit")) Then
                            Voucher_Credit.Value = Convert.ToDecimal(myDataReader("Voucher_Credit"))
                        End If

                        If Not IsDBNull(myDataReader("IsBudget")) Then
                            IsBudget.EditValue = Convert.ToBoolean(myDataReader("IsBudget"))
                            Budget_Code.EditValue = myDataReader("Budget_Code").ToString
                        End If

                        If Not IsDBNull(myDataReader("IsForLiquidation")) Then
                            IsForLiquidation.IsOn = Convert.ToBoolean(myDataReader("IsForLiquidation"))

                            If Not IsDBNull(myDataReader("IsLTO")) Then
                                IsLTO.EditValue = Convert.ToBoolean(myDataReader("IsLTO"))
                            End If

                            Journal_Reference.EditValue = myDataReader("Journal_Reference").ToString
                            Expense_Type.Text = myDataReader("Expense_Type").ToString

                            If Not IsDBNull(myDataReader("Liquidation_Date_Return")) Then
                                Liquidation_Date_Return.EditValue = Convert.ToDateTime(myDataReader("Liquidation_Date_Return"))
                                Liquidation_Days.EditValue = Convert.ToInt32(myDataReader("Liquidation_Days"))
                                Liquidation_Date_Expiry.EditValue = Convert.ToDateTime(myDataReader("Liquidation_Date_Expiry"))
                                IsLiquidated.IsOn = Convert.ToBoolean(myDataReader("IsLiquidated"))
                                Liquidation_Date.EditValue = Convert.ToDateTime(myDataReader("Liquidation_Date"))
                            End If
                        End If

                        COA_Code.EditValue = myDataReader("COA_Code").ToString
                        Set_Check_Token(myDataReader("Voucher_Check").ToString)
                    End If
                Catch ex As Exception
                    Return class_Procedures.Show_Error(ex)
                End Try
            End Using
            Return False
        End Function

        Friend Function Control_Ready(ByVal voucherType As eVoucherType) As Boolean
            If class_Procedures.isEmpty(Voucher_Reference) Then Return False
            If class_Procedures.isEmpty(Voucher_Branch) Then Return False
            If class_Procedures.isEmpty(Voucher_Date_Posted) Then Return False
            If class_Procedures.isEmpty(Voucher_Profile) Then Return False
            If class_Procedures.isEmpty(Account_Code) Then Return False
            If class_Procedures.isEmpty(Account_Name) Then Return False
            If class_Procedures.isEmpty(Voucher_Approver) Then Return False

            Select Case voucherType
                Case class_Saga_Variables.eVoucherType.Check
                    If class_Procedures.isEmpty(Voucher_Approver) Then Return False
            End Select
            Return True
        End Function

        Friend Function Liquidation_Save() As Boolean
            If IsForLiquidation.IsOn Then
                Dim LiquidationParameters As SqlParameter() = {
                    New SqlParameter("@Voucher_Reference", Voucher_Reference.Text.Trim),
                        New SqlParameter("@IsLTO", Convert.ToBoolean(IsLTO.EditValue)),
                        New SqlParameter("@Expense_Type", Expense_Type.EditValue.ToString),
                        New SqlParameter("@Liquidation_Date_Posted", Convert.ToDateTime(Voucher_Date_Posted.EditValue)),
                        New SqlParameter("@Liquidation_Date_Return", Convert.ToDateTime(Liquidation_Date_Return.EditValue)),
                        New SqlParameter("@Liquidation_Days", Liquidation_Days.Value),
                        New SqlParameter("@Liquidation_Date_Expiry", Convert.ToDateTime(Liquidation_Date_Expiry.EditValue)),
                        New SqlParameter("@Voucher_Description", Voucher_Description.Text.Trim),
                        New SqlParameter("@Notes", Notes.Text.Trim),
                        New SqlParameter("@Added_By", class_Variables.sUserName),
                        New SqlParameter("@Modified_By", class_Variables.sUserName),
                        New SqlParameter("@Action_Type", "SAVE")
                }
                Return class_Database.Procedure_Save(class_Database.ICSConnection, LiquidationParameters, "acc_Liquidation_Procedures", "Liquidation")
            Else
                Return False
            End If
        End Function

        Friend Function control_Save(ByVal voucherType As eVoucherType) As Boolean
            If Not Control_Ready(voucherType) Then Return False

            If IsForLiquidation.IsOn AndAlso class_Procedures.isEmpty(Expense_Type) Then Return False

            If Not class_Saga_Database.Is_Ceiling_Reached(IsForLiquidation.IsOn, Convert.ToBoolean(IsLTO.EditValue)) Then
                If IsDBNull(COA_Code.EditValue) Then COA_Code.EditValue = "0"
                If IsDBNull(Voucher_Check.EditValue) Then Voucher_Check.EditValue = Nothing
                If IsDBNull(IsBudget.EditValue) Then IsBudget.EditValue = False
                If IsDBNull(Budget_Code.EditValue) Then Budget_Code.EditValue = String.Empty

                If ID.EditValue.Equals(0) Then
                    Voucher_Code.Text = Get_Code(voucherType)
                    Voucher_Reference.Text = Get_Reference(voucherType)
                End If

                Select Case voucherType
                    Case eVoucherType.Check
                        sVoucherType = "CASH_CHECK"

                    Case eVoucherType.Expense
                        sVoucherType = "PETTY_CASH"

                    Case eVoucherType.Journal
                        sVoucherType = "JOURNAL"
                End Select

                Dim VoucherParameters As SqlParameter() = {
                    New SqlParameter("@ID", ID.EditValue),
                    New SqlParameter("@Corporation", Corporation.EditValue),
                    New SqlParameter("@Voucher_Code", Voucher_Code.Text.Trim),
                    New SqlParameter("@Voucher_Reference", Voucher_Reference.Text.Trim),
                    New SqlParameter("@Voucher_Branch", Voucher_Branch.EditValue),
                    New SqlParameter("@Voucher_Type", sVoucherType),
                    New SqlParameter("@Voucher_Profile", Voucher_Profile.Text.Trim),
                    New SqlParameter("@Account_Code", Account_Code.Text.Trim),
                    New SqlParameter("@Account_Name", Account_Name.Text.Trim),
                    New SqlParameter("@Voucher_Description", Voucher_Description.Text.Trim),
                    New SqlParameter("@Voucher_Approver", Voucher_Approver.Text.Trim),
                    New SqlParameter("@Voucher_Date_Posted", Convert.ToDateTime(Voucher_Date_Posted.EditValue)),
                    New SqlParameter("@COA_Code", COA_Code.EditValue),
                    New SqlParameter("@Voucher_Check", Voucher_Check.EditValue),
                    New SqlParameter("@IsForLiquidation", IsForLiquidation.IsOn),
                    New SqlParameter("@IsBudget", IsBudget.EditValue),
                    New SqlParameter("@Budget_Code", Budget_Code.EditValue),
                    New SqlParameter("@Notes", Notes.Text.Trim),
                    New SqlParameter("@Added_By", class_Variables.sUserName),
                    New SqlParameter("@Modified_By", class_Variables.sUserName),
                    New SqlParameter("@Action_Type", "SAVE")
                }

                Check_Update()
                Liquidation_Type_Update(False, Liquidation_Days.Value, Voucher_Description.Text.Trim)

                If IsForLiquidation.IsOn Then
                    Liquidation_Save()
                    Return class_Database.Procedure_Save(class_Database.ICSConnection, VoucherParameters, "acc_Voucher_Procedures", "Check/Voucher", Voucher_Reference.Text.Trim)
                Else
                    Return class_Database.Procedure_Save(class_Database.ICSConnection, VoucherParameters, "acc_Voucher_Procedures", "Check/Voucher", Voucher_Reference.Text.Trim)
                End If
            End If
            Return False
        End Function

        Friend Function Control_Update(ByVal bAsk As Boolean) As Boolean
            'Dim sReferenceOld As String = Voucher_Reference.Text

            'If class_saga_Variables.sCorporation.Equals("SFC") Then
            '    Voucher_Code.Text = $"CVHOF-{ID.EditValue}"
            'Else
            '    Voucher_Code.Text = $"CVHOM-{ID.EditValue}"
            'End If

            Voucher_Reference.Text = $"VOUCHER-{Voucher_Code.Text}"

            If bAsk AndAlso Not class_Procedures.actionAsk("Update Voucher Reference", "Update Voucher Reference", "You might update the wrong Voucher Reference") Then Return False

            'If class_Database.Data_Update(class_database.ICSConnection, $"UPDATE acc_Vouchers SET Voucher_Code = '{Voucher_Code.Text}', Voucher_Reference = '{Voucher_Reference.Text}' WHERE ID LIKE '{ID.EditValue}'") And class_Database.Data_Update(class_database.ICSConnection, $"UPDATE acc_Journal_Entries SET Table_ID = '{ID.EditValue}', Journal_Reference = '{Voucher_Reference.Text}' WHERE Journal_Reference LIKE '{sReferenceOld}'") Then
            If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET Notes = '{Voucher_Check.EditValue}' WHERE Journal_Reference LIKE '{Voucher_Reference.Text}'") Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Sub Check_Update()
            If Voucher_Check.Properties.SelectedItems.Count > 0 Then
                For i As Integer = 0 To Voucher_Check.Properties.SelectedItems.Count - 1
                    Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                        Using MyCommand As SqlCommand = New SqlCommand($"UPDATE acc_Checks SET Reference = @Reference, Check_Payee = @Check_Payee, Issued_Date = @Issued_Date, Check_Description = @Check_Description, IsIssued = @IsIssued, Modified_By = @Modified_By, Modified_Date = @Modified_Date WHERE Check_Number LIKE '{Voucher_Check.Properties.SelectedItems.Item(i).Value}'", MySQLConnection)

                            With MyCommand.Parameters
                                .Add("@Reference", SqlDbType.VarChar).Value = Voucher_Reference.Text
                                .Add("@Check_Payee", SqlDbType.VarChar).Value = Account_Name.Text
                                .Add("@Issued_Date", SqlDbType.Date).Value = Voucher_Date_Posted.EditValue
                                .Add("@Check_Description", SqlDbType.VarChar).Value = Voucher_Description.Text.Trim
                                .Add("@IsIssued", SqlDbType.Bit).Value = 1
                                .Add("@Modified_By", SqlDbType.VarChar).Value = class_Variables.sUserName
                                .Add("@Modified_Date", SqlDbType.VarChar).Value = Date.Today
                            End With

                            Try
                                MySQLConnection.Open()
                                If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                                    class_Procedures.Set_Message(class_Procedures.MsgMode.Update, "Check Profile")
                                End If
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                            Finally
                                class_Procedures.splash_Close()
                            End Try
                        End Using
                    End Using
                Next
            End If
        End Sub

        Friend Function Control_Delete() As Boolean
            If class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM acc_Vouchers WHERE Voucher_Reference LIKE '{Voucher_Reference.Text}'", $"Voucher Entry: {Account_Name.Text}", True, "Added_By") Then
                Return class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM acc_Journal_Entries WHERE Journal_Reference LIKE '{Voucher_Reference}'", True, "Added_By")
            Else
                Return False
            End If
        End Function

        Private Sub DaysExpire()
            If IsForLiquidation.IsOn Then 'AndAlso bAutoExpire Then
                'Liquidation_Days.Value = iExpiryDays
                Liquidation_Date_Expiry.EditValue = class_Functions.WorkingDays(Convert.ToDateTime(Liquidation_Date_Return.EditValue), Convert.ToInt32(Liquidation_Days.Value))
            Else
                Liquidation_Days.Value = 0
            End If
        End Sub

        Private Sub IsForLiquidation_Toggled(sender As Object, e As EventArgs) Handles IsForLiquidation.Toggled
            Expense_Type.Enabled = IsForLiquidation.IsOn
            If IsForLiquidation.IsOn AndAlso Expense_Type.EditValue Is Nothing Then
                Liquidation_Date_Return.EditValue = Voucher_Date_Posted.EditValue
            End If
            Liquidation_Date_Return.Enabled = IsForLiquidation.IsOn
            Liquidation_Days.Enabled = IsForLiquidation.IsOn
            Liquidation_Date_Expiry.Enabled = IsForLiquidation.IsOn
            IsLTO.Enabled = IsForLiquidation.IsOn
            IsLiquidated.Enabled = IsForLiquidation.IsOn
            DaysExpire()
        End Sub

        Private Sub Voucher_Date_Posted_EditValueChanged(sender As Object, e As EventArgs) Handles Voucher_Date_Posted.EditValueChanged
            DaysExpire()
        End Sub

        Private Sub Liquidation_Date_Return_EditValueChanged(sender As Object, e As EventArgs) Handles Liquidation_Date_Return.EditValueChanged
            DaysExpire()
        End Sub

        Private Sub Liquidation_Days_EditValueChanged(sender As Object, e As EventArgs) Handles Liquidation_Days.EditValueChanged
            DaysExpire()
        End Sub

        Private Sub Voucher_Check_Properties_TokenDoubleClick(sender As Object, e As DevExpress.XtraEditors.TokenEditTokenClickEventArgs) Handles Voucher_Check.Properties.TokenDoubleClick
            class_Saga_Procedures.Show_Check(e.Value.ToString)
        End Sub

        Private Sub toggle_Reference_Toggled(sender As Object, e As EventArgs) Handles toggle_Reference.Toggled
            Voucher_Codeitem.Enabled = Convert.ToBoolean(toggle_Reference.EditValue)
            Voucher_Referenceitem.Enabled = Convert.ToBoolean(toggle_Reference.EditValue)
            LayoutControlItem_Corporation.Enabled = Convert.ToBoolean(toggle_Reference.EditValue)
            LayoutControlItem_Liquidation_Date.Enabled = Convert.ToBoolean(toggle_Reference.EditValue)
            Liquidation_Days.Enabled = Convert.ToBoolean(toggle_Reference.EditValue)
        End Sub

        Private Sub Voucher_Reference_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Voucher_Reference.ButtonClick
            Dim sPreCode1 As String = Voucher_Code.Text.Substring(0, 6)
            Dim sPreCode2 As String = Voucher_Reference.Text.Substring(0, 14)

            Dim sLast1 As String = Voucher_Code.Text.Substring(6)
            Dim sLast2 As String = Voucher_Reference.Text.Substring(14)

            Select Case e.Button.Index
                Case 0
                    Try
                        Voucher_Code.Text = $"{sPreCode1}{Convert.ToInt32(sLast1) - 1}"
                    Catch ex As Exception

                    End Try
                    Voucher_Reference.Text = $"{sPreCode2}{Convert.ToInt32(sLast2) - 1}"

                Case 1
                    Try
                        Voucher_Code.Text = $"{sPreCode1}{Convert.ToInt32(sLast1) + 1}"
                    Catch ex As Exception

                    End Try
                    Voucher_Reference.Text = $"{sPreCode2}{Convert.ToInt32(sLast2) + 1}"

                Case 2
                    If class_Procedures.actionAsk("Voucher Reference", "Update Journal Reference") Then
                        'Dim sNewVOucherReference As String = class_Functions.Show_Input_Box("Input new Voucher Reference", "New Voucher Reerence", Voucher_Reference.EditValue.ToString)
                        'If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Vouchers SET Voucher_Reference = '{sNewVOucherReference}', Corporation = '{Corporation.EditValue}' WHERE Voucher_Reference LIKE '{Voucher_Reference.EditValue}'") Then
                        '    class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET Journal_Reference = '{sNewVOucherReference}', Corporation = '{Corporation.EditValue}' WHERE Journal_Reference LIKE '{Voucher_Reference.EditValue}'")
                        'End If
                    End If
            End Select

            class_Saga_Database.Reference_Exist(Voucher_Reference.Text.Trim)
        End Sub

        Private Sub Voucher_Profile_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Voucher_Profile.ButtonClick
            If class_Variables.isAdministrator AndAlso e.Button.Index.Equals(1) Then
                Dim sProfileOld As String = Voucher_Profile.Text.Trim
                Dim sProfileNew As String = class_Functions.Show_Input_Box("New Voucher Profile", "New Voucher Profile", sProfileOld)

                If class_Database.Data_Replace(class_Database.ICSConnection, "Voucher Profile", "acc_Vouchers", "Voucher_Profile", Voucher_Profile.Text.Trim, sProfileNew) Then
                    class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET Journal_Profile = '{sProfileNew}' WHERE Journal_Profile LIKE '{sProfileOld}'", True)
                    Voucher_Profile.Text = sProfileNew
                End If
            End If
        End Sub

        Private Sub Voucher_Approver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Voucher_Approver.SelectedIndexChanged
            class_Tools.RegKeySet(Me.Name, Voucher_Approver.Name, Voucher_Approver.Text)
        End Sub

        Friend Sub Load_Liquidation_Types(Optional ByVal sLiquidation As String = "")
            class_Database.Bind_Data(class_Database.ICSConnection, Expense_Type, "SELECT * FROM acc_Liquidation_Types", "acc_Liquidation_Types")
            Journal_Reference.EditValue = sLiquidation
        End Sub

        Private Sub Liquidation_Type_Update(ByVal bForceUpdate As Boolean, Optional ByVal iExpiryDays As Integer = 0, Optional ByVal sDescription As String = "")
            If IsForLiquidation.IsOn Then
                If bForceUpdate Or Not class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT Liquidation_Type FROM acc_Liquidation_Types WHERE Liquidation_Type LIKE '{Expense_Type.Text.Trim.ToUpper}'") Then
                    Dim sqlParameters As SqlParameter() = {
                        New SqlParameter("@Liquidation_Type", Expense_Type.Text.ToUpper.Trim),
                        New SqlParameter("@Liquidation_Days", iExpiryDays),
                        New SqlParameter("@Liquidation_Description", sDescription.Trim),
                        New SqlParameter("@Added_By", class_Variables.sUserName),
                        New SqlParameter("@Modified_By", class_Variables.sUserName),
                        New SqlParameter("@Action_Type", "SAVE_TYPE")
                    }

                    If class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Liquidation_Procedures", "Liquidation Type", Expense_Type.Text) Then
                        Load_Liquidation_Types(Expense_Type.Text)
                    End If
                End If
            End If
        End Sub

        Private Sub Expense_Type_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Expense_Type.ButtonClick
            Select Case e.Button.Index
                Case 1
                    If Expense_Type.Text.Length > 0 Then
                        class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM acc_Liquidation_Types WHERE Liquidation_Name LIKE '{Expense_Type.Text}'", "Delete Liquidation Type")
                    End If

                Case 2
                    If Expense_Type.Text.Length > 0 Then
                        Dim iExpiryDays As Integer = class_Functions.Show_Input_Box("Input Expiry Days", "Expiry Days", Liquidation_Days.Value)
                        Dim sDescription As String = class_Functions.Show_Input_Box("Input Liquidation Description", "Liquidation Description", Voucher_Description.Text.Trim)

                        Liquidation_Type_Update(True, iExpiryDays, sDescription)
                    End If
            End Select
        End Sub

        Private Sub Expense_Type_EditValueChanged(sender As Object, e As EventArgs) Handles Expense_Type.EditValueChanged
            Dim iExpiryDays As Integer = Convert.ToInt32(Expense_Type.GetColumnValue("Liquidation_Days"))
            Liquidation_Days.EditValue = iExpiryDays
        End Sub

        Private Sub COA_Code_Validated(sender As Object, e As EventArgs) Handles COA_Code.Validated
            'Load_Checks(COA_Code.EditValue.ToString, "NOT_ISSUED")
        End Sub

        Private Sub COA_Code_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles COA_Code.ButtonClick
            Select Case e.Button.Index
                Case 1
                    If COA_Code.EditValue IsNot Nothing Then
                        Load_Checks(Voucher_Check, COA_Code.EditValue.ToString, "ALL")
                    End If

                Case 2
                    COA_Code.EditValue = String.Empty
                    Voucher_Check.EditValue = String.Empty
            End Select
        End Sub

        Private Sub Journal_Reference_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Journal_Reference.Properties.ButtonClick
            If Journal_Reference.EditValue.ToString.Length > 0 Then
                Select Case e.Button.Index
                    Case 0
                        class_Saga_Procedures.Show_Journal_Entries_Reference(Journal_Reference.EditValue.ToString, ID.EditValue)

                End Select
            End If
        End Sub

        Private Sub LayoutControlItem_Return_DoubleClick(sender As Object, e As EventArgs) Handles LayoutControlItem_Return.DoubleClick
            Liquidation_Date_Return.EditValue = Voucher_Date_Posted.EditValue
        End Sub

        Private Sub btn_Add_Credit_Click(sender As Object, e As EventArgs) Handles btn_Add_Credit.Click
            Dim xucudget As New Controls.Accounting.xuc_Budget
            If Budget_Code.EditValue IsNot Nothing Then
                Dim dVoucherCredit As Decimal = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT SUM(Journal_Credit) AS Journal_Credit FROM acc_Journal_Entries WHERE Journal_Reference LIKE '{Voucher_Reference.Text.Trim}'", "Journal_Credit"))
                If dVoucherCredit <= Budget_Code.GetColumnValue("Budget_Balance") Then
                    xucudget.Add_Credit(Budget_Code.EditValue.ToString, Voucher_Code.EditValue.ToString, Voucher_Reference.EditValue.ToString, Voucher_Description.Text.Trim)
                    'class_Saga_Variables.Initialize_Budgets()
                Else
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Problem: Budget Balance is insuffecient.{Environment.NewLine}{Environment.NewLine}Solution: Add/Increase Budget Debit.", "Insuffecient Budget Balance", True)
                End If
            End If
        End Sub

        Private Sub IsBudget_Toggled(sender As Object, e As EventArgs) Handles IsBudget.Toggled
            Budget_Code.ReadOnly = Not IsBudget.IsOn
            btn_Add_Credit.Enabled = IsBudget.IsOn
        End Sub

        Private Sub Voucher_Descriptionitem_DoubleClick(sender As Object, e As EventArgs) Handles Voucher_Descriptionitem.DoubleClick
            If Voucher_Reference.EditValue.Contains("JVHO") Or Voucher_Reference.EditValue.Contains("EVHO") Then
                Dim dtStart, dtEnd As Date
                Dim sqlParameters As SqlParameter() = {
                                New SqlParameter("@Branch_Code", Voucher_Branch.EditValue),
                                New SqlParameter("@Reference", Voucher_Reference.EditValue),
                                New SqlParameter("@Action_Type", "GET_MIN_MAX_DATE")
                            }

                Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Procedures")
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        Try
                            dtStart = Convert.ToDateTime(myDataReader("Date_Min"))
                            dtEnd = Convert.ToDateTime(myDataReader("Date_Max"))
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        End Try

                    End If
                End Using

                Voucher_Description.Text = $"{class_Saga_Database.get_Branch_Name(Voucher_Branch.EditValue)} PETTY CASH - EXPENSE FOR THE PERIOD COVERED {dtStart:MMMM dd, yyyy} - {dtEnd:MMMM dd, yyyy}".ToUpper
            End If
        End Sub


    End Class

End Namespace