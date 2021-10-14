Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Information.Account

    Public Class xuc_Account_Payment
        Inherits DevExpress.XtraEditors.XtraUserControl

        Dim sOldORNumber As String

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()

            class_Database.Fill_Edit(class_Database.ICSConnection, Payment_Type, "TransactionOtherCash", "Mnemonic", False)
            class_Database.Fill_Edit(class_Database.ICSConnection, Payment_Type, "TransactionPayments", "Remarks", False)
        End Sub

        Friend Function Control_Retrieve(ByVal isIB As Boolean, ByVal sID As String) As Boolean

            class_Saga_Procedures.Initialize_Branch(BranchCode)
            ID.EditValue = sID
            Try
                If isIB Then
                    Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT ID, BranchCode, Mnemonic, ReferenceNumber, ORNumber, AmountDue, VAT, AmntNetOfVat, AccountName, PostingDate, TransactionDate, Description, TransactedBy FROM TransactionOtherCash WHERE ID LIKE '{sID}'")
                        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                            myDataReader.Read()
                            BranchCode.EditValue = myDataReader("BranchCode").ToString
                            Payment_Type.Text = myDataReader("Mnemonic").ToString
                            OR_Number.Text = myDataReader("ORNumber").ToString
                            sOldORNumber = OR_Number.Text
                            Amount_Paid.Value = convert.todecimal(myDataReader("AmountDue"))
                            PostingDate.EditValue = convert.todatetime(myDataReader("PostingDate"))
                            TransactionDate.EditValue = convert.todatetime(myDataReader("TransactionDate"))
                            Note.Text = myDataReader("Description").ToString
                            TransactedBy.Text = myDataReader("TransactedBy").ToString
                            AccountName.Text = myDataReader("AccountName").ToString
                            VAT.Value = convert.todecimal(myDataReader("VAT"))
                            No_VAT.Value = convert.todecimal(myDataReader("AmntNetOfVat"))
                            Return True
                        End If
                    End Using
                Else
                    Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT ID, BranchCode, Remarks, ReferenceNumber, ORNumber, PEN, AmountPaid, VAT, AmntNetOfVat, PostingDate, TransactionDate, Note, TransactedBy, AccountName FROM view_Payment_Transactions WHERE ID LIKE '{sID}'") 'FROM TransactionPayments WHERE ID LIKE '{sID}'")'
                        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                            myDataReader.Read()
                            BranchCode.EditValue = myDataReader("BranchCode").ToString
                            Payment_Type.Text = myDataReader("Remarks").ToString
                            OR_Number.Text = myDataReader("ORNumber").ToString
                            sOldORNumber = OR_Number.Text
                            Penalty.Value = convert.todecimal(myDataReader("PEN"))
                            Amount_Paid.Value = convert.todecimal(myDataReader("AmountPaid"))
                            PostingDate.EditValue = convert.todatetime(myDataReader("PostingDate"))
                            TransactionDate.EditValue = convert.todatetime(myDataReader("TransactionDate"))
                            Note.Text = myDataReader("Note").ToString
                            TransactedBy.Text = myDataReader("TransactedBy").ToString
                            AccountName.Text = myDataReader("AccountName").ToString
                            No_VAT.Value = convert.todecimal(myDataReader("AmntNetOfVat"))
                            VAT.Value = convert.todecimal(myDataReader("VAT"))
                            Return True
                        End If
                    End Using
                End If
            Catch ex As Exception
                Return class_Procedures.Show_Error(ex)
            End Try
            Return False
        End Function

        Friend Function control_Save(ByVal isIBC As Boolean) As Boolean

            If class_Procedures.isEmpty(Payment_Type) Then Return False
            If class_Procedures.isEmpty(OR_Number) Then Return False
            If class_Procedures.isEmpty(VAT) Then Return False
            If class_Procedures.isEmpty(No_VAT) Then Return False

            If Not class_Database.Data_Save_Ask(OR_Number.Text) Then Return False

            class_Procedures.splash_Show("Saving Customer Payment")

            Dim sQuery As String

            If isIBC Then
                sQuery = $"SELECT ID FROM TransactionOtherCash WHERE ID LIKE '{ID.EditValue}'"
            Else
                sQuery = $"SELECT ID FROM TransactionPayments WHERE ID LIKE '{ID.EditValue}'"
            End If

            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)

                    With MyCommand.Parameters
                        If isIBC Then
                            MyCommand.CommandText = $"UPDATE TransactionOtherCash SET Mnemonic = @Mnemonic, ORNumber = @ORNumber, ReferenceNumber = @ORNumber, AccountName = @AccountName, AmountDue = @AmountDue, VAT = @VAT, AmntNetOfVat = @AmntNetOfVat, PostingDate = @PostingDate, Description = @Description WHERE ID LIKE '{ID.EditValue}'"
                            .Add("@Mnemonic", SqlDbType.VarChar).Value = Payment_Type.Text.Trim
                            .Add("@AmountDue", SqlDbType.Money).Value = Amount_Paid.Value
                            .Add("@AccountName", SqlDbType.VarChar).Value = AccountName.Text.Trim
                            .Add("@Description", SqlDbType.VarChar).Value = Note.Text.Trim
                        Else
                            MyCommand.CommandText = $"UPDATE TransactionPayments SET Remarks = @Remarks, ORNumber = @ORNumber, ReferenceNumber = @ORNumber, AmountPaid = @AmountPaid, VAT = @VAT, AmntNetOfVat = @AmntNetOfVat, PEN = @PEN, PostingDate = @PostingDate, Note = @Note WHERE ID LIKE '{ID.EditValue}'"
                            .Add("@Remarks", SqlDbType.VarChar).Value = Payment_Type.Text.Trim
                            .Add("@PEN", SqlDbType.Money).Value = Penalty.Value
                            .Add("@AmountPaid", SqlDbType.Money).Value = Amount_Paid.Value
                            .Add("@Note", SqlDbType.VarChar).Value = Note.Text.Trim
                        End If

                        .Add("@ID", SqlDbType.BigInt).Value = ID.EditValue
                        .Add("@ReferenceNumber", SqlDbType.VarChar).Value = OR_Number.Text.Trim
                        .Add("@ORNumber", SqlDbType.VarChar).Value = OR_Number.Text.Trim
                        .Add("@VAT", SqlDbType.Money).Value = VAT.Value
                        .Add("@AmntNetOfVat", SqlDbType.Money).Value = No_VAT.Value
                        .Add("@PostingDate", SqlDbType.Date).Value = convert.todatetime(PostingDate.EditValue)
                    End With

                    Try
                        If Not sOldORNumber.Equals(OR_Number.Text.Trim) Then
                            class_Database.Query_Execute(class_Database.ICSConnection, $"UPDATE CustLedger SET ReferenceNumber = '{OR_Number.Text.Trim}', ORNumber = '{OR_Number.Text.Trim}' WHERE ORNumber LIKE '{sOldORNumber}'", True, "Update OR Number", "Ledger")
                            class_Database.Query_Execute(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET Journal_Reference = '{OR_Number.Text.Trim}' WHERE Table_ID LIKE '{ID.EditValue}' AND Journal_Reference LIKE '{sOldORNumber}'", , "Update Reference", "Journal")
                        End If

                        MySQLConnection.Open()
                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
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

        Private Sub AccountName_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles AccountName.ButtonClick
            class_Saga_Procedures.Show_Account_Searched_Names(AccountName.Text)
        End Sub

        Private Sub labelNote_DoubleClick(sender As Object, e As EventArgs) Handles labelNote.DoubleClick
            Dim sNote As String = Note.Text
            Note.Text = $"Branch: {BranchCode.Text}{Environment.NewLine}Customer: {AccountName.Text}{Environment.NewLine}OR Code: {OR_Number.Text}{Environment.NewLine}Paid: {Amount_PaID.EditValue}{Environment.NewLine}Date: {PostingDate.Text}{Environment.NewLine}Remarks: {sNote}"
            class_Procedures.Copy_Clipboard(Note.Text)
        End Sub

        Private Sub TransactedBy_Click(sender As Object, e As EventArgs) Handles TransactedBy.DoubleClick
            class_Saga_Procedures.Show_User_Activity(TransactedBy.Text)
        End Sub

    End Class

End Namespace