Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Controls.Information.Account

    Public Class xuc_Account_Ledger
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()

            class_Database.Fill_Edit(class_Database.ICSConnection, TransCode, "CustLedger", "TransCode")
            class_Database.Fill_Edit(class_Database.ICSConnection, Mnemonic, "CustLedger", "Mnemonic")
            class_Database.Fill_Edit(class_Database.ICSConnection, Remarks, "CustLedger", "Remarks")
            TransCode.Select()
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean

            Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT * FROM CustLedger WHERE SequenceNumber LIKE '{sID}'")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        SequenceNumber.Text = sID
                        TransCode.Text = myDataReader("TransCode").ToString
                        Mnemonic.Text = myDataReader("Mnemonic").ToString
                        ReferenceNumber.Text = myDataReader("ReferenceNumber").ToString
                        ORNumber.Text = myDataReader("ORNumber").ToString
                        BeginningBalance.Value = convert.todecimal(myDataReader("BeginningBalance"))
                        Debit.Value = convert.todecimal(myDataReader("Debit"))
                        Credit.Value = convert.todecimal(myDataReader("Credit"))
                        EndingBalance.Value = convert.todecimal(myDataReader("EndingBalance"))
                        OutsBal.Value = convert.todecimal(myDataReader("OutsBal"))
                        TransactedBy.Text = myDataReader("TransactedBy").ToString
                        TransactionDate.EditValue = convert.todatetime(myDataReader("PostingDate"))
                        Remarks.Text = myDataReader("Remarks").ToString
                        Note.Text = myDataReader("Note").ToString
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean

            If class_Procedures.isEmpty(TransCode) Then Return False
            If class_Procedures.isEmpty(Mnemonic) Then Return False
            If class_Procedures.isEmpty(ReferenceNumber) Then Return False
            If class_Procedures.isEmpty(ORNumber) Then Return False

            If Not class_Database.Data_Save_Ask(SequenceNumber.Text) Then Return False
            class_Procedures.splash_Show("Saving Account Ledger")

            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand($"UPDATE CustLedger SET TransCode = @TransCode, Mnemonic = @Mnemonic, ReferenceNumber = @ReferenceNumber, ORNumber = @ORNumber, BeginningBalance = @BeginningBalance, Debit = @Debit, Credit = @Credit, EndingBalance = @EndingBalance, OutsBal = @OutsBal, PostingDate = @PostingDate, Remarks = @Remarks, Note = @Note WHERE SequenceNumber LIKE '{SequenceNumber.Text}'", MySQLConnection)

                    With MyCommand.Parameters
                        .Add("@TransCode", SqlDbType.VarChar).Value = TransCode.Text
                        .Add("@Mnemonic", SqlDbType.VarChar).Value = Mnemonic.Text
                        .Add("@ReferenceNumber", SqlDbType.VarChar).Value = ReferenceNumber.Text
                        .Add("@ORNumber", SqlDbType.VarChar).Value = ORNumber.Text
                        .Add("@BeginningBalance", SqlDbType.Money).Value = BeginningBalance.Value
                        .Add("@Debit", SqlDbType.Money).Value = Debit.Value
                        .Add("@Credit", SqlDbType.Money).Value = Credit.Value
                        .Add("@EndingBalance", SqlDbType.Money).Value = EndingBalance.Value
                        .Add("@OutsBal", SqlDbType.Money).Value = OutsBal.Value
                        .Add("@PostingDate", SqlDbType.DateTime).Value = TransactionDate.EditValue
                        .Add("@Remarks", SqlDbType.VarChar).Value = Remarks.Text
                        .Add("@Note", SqlDbType.VarChar).Value = Note.Text
                    End With
                    Try
                        MySQLConnection.Open()
                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Update, "Account Ledger")
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

        Friend Function Control_Delete() As Boolean

            Return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM CustLedger WHERE SequenceNumber LIKE '{SequenceNumber.Text}'", $"Account Ledger ID: {SequenceNumber.Text}")
        End Function

        Private Sub ItemForEndingBalance_DoubleClick(sender As Object, e As EventArgs) Handles ItemForEndingBalance.DoubleClick
            EndingBalance.Value = BeginningBalance.Value - (Debit.Value + Credit.Value)
        End Sub

    End Class

End Namespace