Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Information.Account

    Public Class xuc_Account_Application
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()

            class_Saga_Procedures.Initialize_Branch(acount_Branch)
            class_Database.Fill_Edit(class_Database.ICSConnection, acount_Approver, "CustAccountApplications", "Approver")
            class_Database.Fill_Edit(class_Database.ICSConnection, acount_Status, "CustAccountApplications", "Status")
            acount_Approver.Select()
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = false)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Account Application", "Initialize new Account Application", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bask)
        End Sub

        Friend Sub Control_Retrieve()

        End Sub

        Friend Sub Control_Save()

            If class_Procedures.isEmpty(ID_Code) Then Return
            If class_Procedures.isEmpty(acount_Status) Then Return
            If class_Procedures.isEmpty(acount_Approver) Then Return
            If Not class_Database.Data_Save_Ask(ID_Code.Text) Then Return
            class_Procedures.splash_Show("Saving Account Application Profile")

            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand($"UPDATE CustAccountApplications SET Approver = @Approver, Remarks = @Remarks WHERE id LIKE '{ID_Code.Text}'", MySQLConnection)
                    MyCommand.Parameters.Add("@Approver", SqlDbType.VarChar).Value = acount_Approver.Text
                    MyCommand.Parameters.Add("@Remarks", SqlDbType.VarChar).Value = Notes.Text

                    Try
                        MySQLConnection.Open()
                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Update, "Account Application Profile")
                        End If
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    Finally
                        class_Procedures.splash_Close()
                    End Try
                End Using
            End Using
        End Sub

        Friend Function Control_Delete() As Boolean

            Return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM CustAccountApplications WHERE id LIKE '{ID_Code.Text}'", $"Account Application ID: {ID_Code.Text}")
        End Function

    End Class

End Namespace