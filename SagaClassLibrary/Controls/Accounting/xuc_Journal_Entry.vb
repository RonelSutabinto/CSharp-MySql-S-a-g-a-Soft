Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Controls.Accounting

    Public Class xuc_Journal_Entry
        Inherits DevExpress.XtraEditors.XtraUserControl

        Friend sCode As String
        Private dDebit, dCredit As Decimal
        Friend sProfile As String = String.Empty

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize(Optional ByVal bFillEdits As Boolean = True)

            class_Saga_Procedures.Initialize_Corporation(Corporation)

            class_Saga_Procedures.Initialize_Branch(Journal_Branch)

            class_Saga_Procedures.Initialize_COA(RepositoryItemLookUpEdit_COA, eCOA_Type.COA_All)
            COA_Code.Properties.DataSource = class_Saga_Variables.coaAll.Properties.DataSource

            class_Saga_Variables.Initialize_For_Liquidation()
            class_Saga_Procedures.Initialize_For_Liquidation(Voucher_Reference, SearchLookUpEditView)

            class_Saga_Procedures.Initialize_Budget(Budget_Code)

            If bFillEdits Then
                class_Database.Fill_Edit(class_Database.ICSConnection, Journal_Type, "acc_Journal_Entries", "Journal_Type")
                class_Database.Fill_Edit(class_Database.ICSConnection, Journal_Profile, "acc_Journal_Templates", "Template_Name")
                class_Database.Fill_Edit(class_Database.ICSConnection, Journal_Profile, "acc_Journal_Entries", "Journal_Profile",, False)
            End If
        End Sub

        Friend Sub Control_New(ByVal sBrCode As String, Optional bClear As Boolean = True)
            class_Procedures.splash_Show("Creating New Journal Entry")
            class_Procedures.Initialize_Controls(Me, bClear)
            Table_ID.EditValue = 0

            toggle_New_Reference.EditValue = True

            Journal_Code.Text = class_Functions.AutoID("JOURNAL")

            Corporation.EditValue = class_Saga_Variables.sCorporation
            Journal_Branch.EditValue = sBrCode
            Journal_Reference.Text = class_Saga_Functions.New_Journal_Reference()
            Journal_Type.Text = "JOURNAL_ENTRY"

            class_Procedures.splash_Close()
            Journal_Profile.Select()
        End Sub

        Friend Function Control_Ready() As Boolean
            If class_Procedures.isEmpty(Journal_Code) Then Return False
            If class_Procedures.isEmpty(Journal_Branch) Then Return False
            If class_Procedures.isEmpty(Journal_Reference) Then Return False
            If class_Procedures.isEmpty(Journal_Type) Then Return False
            If class_Procedures.isEmpty(Account_Code) Then Return False
            If class_Procedures.isEmpty(Account_Name) Then Return False
            If class_Procedures.isEmpty(COA_Code) Then Return False
            If class_Procedures.isEmpty(Journal_Debit) And class_Procedures.isEmpty(Journal_Credit) Then Return False
            Return True
        End Function

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            ID.EditValue = sID

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", sID),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Journal_Procedures")
                Try
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        Table_ID.EditValue = myDataReader("Table_ID").ToString
                        Journal_Code.Text = myDataReader("Journal_Code").ToString
                        Corporation.EditValue = myDataReader("Corporation").ToString
                        Journal_Branch.EditValue = myDataReader("Branch_Code").ToString
                        COA_Code.EditValue = myDataReader("COA_Code").ToString
                        Journal_Reference.Text = myDataReader("Journal_Reference").ToString
                        Voucher_Reference.Text = myDataReader("Voucher_Reference").ToString
                        Journal_Type.Text = myDataReader("Journal_Type").ToString
                        Journal_Profile.Text = myDataReader("Journal_Profile").ToString
                        sProfile = Journal_Profile.Text
                        Account_Code.Text = myDataReader("Account_Code").ToString
                        Account_Name.Text = myDataReader("Account_Name").ToString

                        Journal_Debit.Value = convert.todecimal(myDataReader("Journal_Debit"))
                        dDebit = Journal_Debit.Value
                        Journal_Credit.Value = convert.todecimal(myDataReader("Journal_Credit"))
                        dCredit = Journal_Credit.Value
                        Balance_Running.Value = convert.todecimal(myDataReader("Balance"))

                        Journal_Description.Text = myDataReader("Journal_Description").ToString
                        Check_Number.Text = myDataReader("Check_Number").ToString
                        Posting_Date.EditValue = convert.todatetime(myDataReader("Posting_Date"))
                        Voucher_Reference.EditValue = myDataReader("Voucher_Reference").ToString
                        toggle_Liquidated.EditValue = myDataReader("Voucher_Reference").ToString
                        Notes.Text = myDataReader("Notes").ToString

                        Transacted.Text = $"Transacted {myDataReader("Transacted_By")} {convert.todatetime(myDataReader("Transaction_Date")):MMMM dd, yyyy hh:mm:ss}"
                        Added.Text = $"Added {myDataReader("Added_By")} {convert.todatetime(myDataReader("Added_Date")):MMMM dd, yyyy hh:mm:ss}"
                        Modified.Text = $"Modified {myDataReader("Modified_By")} {convert.todatetime(myDataReader("Modified_Date")):MMMM dd, yyyy hh:mm:ss}"
                        Approved.Text = $"Approved {myDataReader("Approved_By")} {convert.todatetime(myDataReader("Approved_Date")):MMMM dd, yyyy hh:mm:ss}"
                        Deleted.Text = $"Deleted {myDataReader("Deleted_By")} {convert.todatetime(myDataReader("Deleted_Date")):MMMM dd, yyyy hh:mm:ss}"
                        Verified.Text = $"Verified {myDataReader("Verified_By")} {convert.todatetime(myDataReader("Verified_Date")):MMMM dd, yyyy hh:mm:ss}"
                        Modification.Text = $"Modification {myDataReader("Modification")}"

                    End If
                Catch ex As Exception
                    Return class_Procedures.Show_Error(ex)
                Finally
                    Initialize_Check()
                End Try
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If Not Control_Ready() Or Not class_Database.Data_Save_Ask("Journal Entry") Then Return False

            If Convert.ToBoolean(toggle_New_Reference.EditValue) AndAlso class_Database.Data_Save_Ask("Journal Entry with New Reference") Then
                Control_New(Journal_Branch.EditValue.ToString, False)
            End If

            Dim bError As Boolean = False

            toggle_New_Reference.EditValue = False

            Try
                If Convert.ToInt32(Check_Number.EditValue) > 0 Then
                    Using xuc_Check As New xuc_Check
                        xuc_Check.Control_Check_Update(Check_Number.EditValue.ToString, Journal_Reference.Text, Account_Name.Text, Journal_Debit.Value + Journal_Credit.Value, Journal_Description.Text, Notes.Text)
                    End Using
                End If
            Catch ex As Exception
                Check_Number.EditValue = 0
            End Try

            If Convert.ToInt32(ID.EditValue) > 0 Then
                Return class_Saga_Database.Journal_Entry_Update(Convert.ToInt32(ID.EditValue), Convert.ToInt32(Table_ID.EditValue), Corporation.EditValue.ToString, Journal_Branch.EditValue.ToString, COA_Code.EditValue.ToString, Journal_Reference.Text.Trim, Journal_Type.Text.Trim, Journal_Profile.Text.Trim, Account_Code.Text.Trim, Account_Name.Text.Trim, Journal_Debit.Value, Journal_Credit.Value, Check_Number.EditValue.ToString, Journal_Description.Text.Trim, convert.todatetime(Posting_Date.EditValue), Notes.Text.Trim)
            Else
                Return class_Saga_Database.Journal_Entry_Save(True, Convert.ToInt32(Table_ID.EditValue), Journal_Code.Text, Corporation.EditValue.ToString, Journal_Branch.EditValue.ToString, COA_Code.EditValue.ToString, Journal_Reference.Text.Trim, Journal_Type.Text.Trim, Journal_Profile.Text.Trim, Account_Code.Text.Trim, Account_Name.Text.Trim, Journal_Debit.Value, Journal_Credit.Value, Journal_Description.Text.Trim, class_Variables.sUserName, convert.todatetime(Posting_Date.EditValue), Notes.Text.Trim)
            End If

            class_Procedures.Set_Message(class_Procedures.MsgMode.Save, $"Journal Entry {COA_Code.Text}", "Journal Entry", bError)
            Return False
        End Function

        Friend Function Control_Update() As Boolean

            If Not Control_Ready() Or Not class_Database.Data_Save_Ask("Journal Entry") Then Return False
            If class_Procedures.isEmpty(Account_Code) Then Return False
            If class_Procedures.isEmpty(Account_Name) Then Return False

            Try
                If Convert.ToInt32(Check_Number.EditValue) > 0 Then
                    Using xuc_Check As New xuc_Check
                        xuc_Check.Control_Check_Update(Check_Number.Text, Journal_Reference.Text, Account_Name.Text, Journal_Debit.Value + Journal_Credit.Value, Journal_Description.Text, Notes.Text)
                    End Using
                End If
            Catch ex As Exception
                Check_Number.EditValue = 0
            End Try

            Return class_Saga_Database.Journal_Entry_Update(Convert.ToInt32(ID.EditValue), Convert.ToInt32(Table_ID.EditValue), Corporation.EditValue.ToString, Journal_Branch.EditValue.ToString, COA_Code.EditValue.ToString, Journal_Reference.Text.Trim, Journal_Type.Text.Trim, Journal_Profile.Text.Trim, Account_Code.Text.Trim, Account_Name.Text.Trim, Journal_Debit.Value, Journal_Credit.Value, Check_Number.Text, Journal_Description.Text.Trim, convert.todatetime(Posting_Date.EditValue), Notes.Text.Trim)
        End Function

        Private Sub Journal_Type_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Journal_Type.ButtonClick
            Select Case e.Button.Index
                Case 1
                    Dim sFieldValueNew As String = class_Functions.Show_Input_Box("Input new Journal Type", "New Journal Type", Journal_Type.Text.Trim)
                    If class_Database.Data_Replace(class_Database.ICSConnection, "Journal Type", "acc_Journal_Entries", "Journal_Type", Journal_Type.Text.Trim, sFieldValueNew) Then
                        Journal_Type.Text = sFieldValueNew
                    End If
            End Select
        End Sub

        Private Sub Journal_Profile_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Journal_Profile.ButtonClick
            Select Case e.Button.Index
                Case 1
                    Dim sFieldValueNew As String = class_Functions.Show_Input_Box("Input new Journal Profile", "New Journal Profile", Journal_Profile.Text.Trim)
                    If class_Database.Data_Replace(class_Database.ICSConnection, "Journal Profile", "acc_Journal_Entries", "Journal_Profile", Journal_Profile.Text.Trim, sFieldValueNew) Then
                        Journal_Profile.Text = sFieldValueNew
                    End If
            End Select
        End Sub

        Private Sub Account_Name_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Account_Name.KeyDown
            Select Case e.KeyValue
                Case Keys.F4
                    Account_Name.ShowPopup()
            End Select
        End Sub

        Private Sub Account_Name_BeforePopup(sender As Object, e As EventArgs) Handles Account_Name.BeforePopup
            PopupContainerControl.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Width", 500)
            PopupContainerControl.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Height", 400)
        End Sub

        Private Sub Account_Name_Popup(sender As Object, e As EventArgs) Handles Account_Name.Popup
            xuc_Account_Search.searchMode = Information.Account.xuc_Account_Search.Search_Mode.searchGlobal
            xuc_Account_Search.Load_Search(Account_Name.Text)
        End Sub

        Private Sub Account_Name_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles Account_Name.Closed
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Width", PopupContainerControl.Width)
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Height", PopupContainerControl.Height)

            Get_Searched_Name()
        End Sub

        Private Sub Get_Searched_Name()
            Account_Code.Text = xuc_Account_Search.Code
            Account_Name.Text = xuc_Account_Search.AccountName
            Account_Name.Select()
        End Sub

        Private Sub toggle_Reference_Toggled(sender As Object, e As EventArgs) Handles toggle_Reference.Toggled
            Table_IDitem.Enabled = Convert.ToBoolean(toggle_Reference.EditValue)
            LayoutControlItem_Corporation.Enabled = Convert.ToBoolean(toggle_Reference.EditValue)
            Journal_Referenceitem.Enabled = Convert.ToBoolean(toggle_Reference.EditValue)
            toggle_New_Reference.Enabled = Convert.ToBoolean(toggle_Reference.EditValue)
        End Sub

        Private Sub Journal_Reference_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Journal_Reference.ButtonClick
            Dim sPreCode As String = Journal_Reference.Text.Substring(0, 6)
            Dim sLast As String = Journal_Reference.Text.Substring(6)

            Try
                Select Case e.Button.Index
                    Case 0
                        Journal_Reference.Text = $"{sPreCode}{Convert.ToInt32(sLast) - 1}"

                    Case 1
                        Journal_Reference.Text = $"{sPreCode}{Convert.ToInt32(sLast) + 1}"

                End Select
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            Finally
                toggle_New_Reference.EditValue = False
                If Reference_Exist(Journal_Reference.Text.Trim) Then
                    Journal_Reference.ForeColor = Drawing.Color.Red
                Else
                    Journal_Reference.ForeColor = Drawing.SystemColors.HotTrack
                End If
            End Try
        End Sub

        Private Sub Journal_Debit_EditValueChanged(sender As Object, e As EventArgs) Handles Journal_Debit.EditValueChanged
            If Journal_Debit.Value > 0 Then Journal_Credit.Value = 0
        End Sub

        Private Sub Journal_Credit_EditValueChanged(sender As Object, e As EventArgs) Handles Journal_Credit.EditValueChanged
            If Journal_Credit.Value > 0 Then Journal_Debit.Value = 0
        End Sub

        Private Sub COA_Code_Validated(sender As Object, e As EventArgs) Handles COA_Code.Validated
            Initialize_Check()
        End Sub

        Friend Sub Initialize_Check()
            Try
                'class_Saga_Variables.Initialize_Check(COA_Code.EditValue.ToString)
                class_Saga_Procedures.Initialize_Check(Check_Number, COA_Code.EditValue.ToString)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub Voucher_Reference_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Voucher_Reference.Properties.ButtonClick
            Select Case e.Button.Index
                Case 1
                    If Not Voucher_Reference.EditValue Is Nothing Then
                        class_Saga_Procedures.Show_Voucher(Voucher_Reference.EditValue.ToString)
                    End If
            End Select
        End Sub

        Private Sub btn_Liquidate_Click(sender As Object, e As EventArgs) Handles btn_Liquidate.Click
            If Not Voucher_Reference.EditValue Is Nothing AndAlso class_Procedures.actionAsk("Liquidation", "Update Liquidation", "This will update Cash Advance Voucher(s)", "You might update the wrong Cash Advance Voucher.") Then
                Dim view As DevExpress.XtraGrid.Views.Grid.GridView = Voucher_Reference.Properties.View
                Dim dtExpiry As Date = view.GetRowCellValue(view.FocusedRowHandle, "Liquidation_Date_Expiry")
                If convert.todatetime(Posting_Date.EditValue) > dtExpiry Then
                    If class_Procedures.isEmpty(Liquidation_Justification) Then
                        Liquidation_Justification.Select()
                        Return
                    Else
                        If Liquidated() Then class_Procedures.Set_Message(class_Procedures.MsgMode.Save, "Cash Advance has been partially/successfully Liquidated with some Justifications.", "Liquidation", True)
                    End If
                Else
                    If Liquidated() Then class_Procedures.Set_Message(class_Procedures.MsgMode.Save, "Cash Advance has been partially/successfully Liquidated.", "Liquidation", True)
                End If
            End If
        End Sub

        Private Function Liquidated() As Boolean
            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand($"SELECT * FROM acc_Liquidations WHERE Voucher_Reference = '{Voucher_Reference.EditValue}'", MySQLConnection)
                    With MyCommand.Parameters
                        MyCommand.CommandText = $"UPDATE acc_Liquidations SET IsLiquidated = @IsLiquidated, Journal_Reference = @Journal_Reference, Liquidation_Date = @Liquidation_Date, Liquidated_By = @Liquidated_By, Justification = @Justification, Journal_Description = @Journal_Description, Notes = @Notes WHERE Voucher_Reference = '{Voucher_Reference.EditValue}'"

                        .Add("@IsLiquidated", SqlDbType.Bit).Value = Convert.ToBoolean(toggle_Liquidated.EditValue)
                        .Add("@Journal_Reference", SqlDbType.VarChar).Value = Journal_Reference.Text
                        .Add("@Liquidation_Date", SqlDbType.Date).Value = convert.todatetime(Posting_Date.EditValue)
                        .Add("@Liquidated_By", SqlDbType.VarChar).Value = class_Variables.sUserName
                        .Add("@Justification", SqlDbType.VarChar).Value = Liquidation_Justification.Text
                        .Add("@Journal_Description", SqlDbType.VarChar).Value = Journal_Description.Text
                        .Add("@Notes", SqlDbType.VarChar).Value = Notes.Text
                    End With

                    Try
                        MySQLConnection.Open()
                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                            class_Database.Data_Update(class_Database.ICSConnection, $"Update acc_Journal_Entries SET Voucher_Reference = '{Voucher_Reference.EditValue.ToString.Trim}' WHERE Journal_Reference = '{Journal_Reference.EditValue.ToString.Trim}'")
                            class_Saga_Variables.Initialize_For_Liquidation()
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Update, "Customer Payment")
                            Return True
                        End If
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    Finally
                        class_Procedures.splash_Close()
                    End Try
                End Using
            End Using
            Return False
        End Function

        Private Sub Journal_Descriptionitem_DoubleClick(sender As Object, e As EventArgs) Handles Journal_Descriptionitem.DoubleClick
            Dim sDescription = class_Functions.Show_Input_Box("Input new Journal Description", "Update Journal Description", Journal_Description.Text)
            If class_Procedures.actionAsk("Journal Description", "Update Journal Description", "You might update wrong Journal Description") Then
                class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET Journal_Description = '{sDescription}' WHERE Journal_Reference LIKE '{Journal_Reference.Text}'", True)
            End If
        End Sub

        Private Sub toggle_Is_Liquidation_Toggled(sender As Object, e As EventArgs) Handles toggle_Is_Liquidation.Toggled
            If toggle_Is_Liquidation.IsOn Then
                Journal_Profile.Text = "JOURNAL_LIQUIDATION"
            Else
                Journal_Profile.Text = sProfile
            End If
            Voucher_Reference.ReadOnly = Not toggle_Is_Liquidation.IsOn
            toggle_Liquidated.ReadOnly = Not toggle_Is_Liquidation.IsOn
            Liquidation_Justification.ReadOnly = Not toggle_Is_Liquidation.IsOn
        End Sub

    End Class

End Namespace