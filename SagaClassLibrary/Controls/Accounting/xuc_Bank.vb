Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Controls.Accounting

    Public Class xuc_Bank

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Corporation(Corporation)
            class_Saga_Procedures.Initialize_COA(COA_Code, eCOA_Type.COA_Bank)
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = False)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Bank Profile", "Initialize new Bank Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bAsk)
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Bank_Code, "acc_Banks", "Bank_Code", "BANK-")
            Bank_Account.Select()
        End Sub

        Friend Function Control_Ready() As Boolean
            If class_Procedures.isEmpty(Bank_Code) Then Return False
            If class_Procedures.isEmpty(Bank_Account) Then Return False
            If class_Procedures.isEmpty(Bank_Name) Then Return False
            Return True
        End Function

        Friend Function Control_Save() As Boolean
            If Not Control_Ready() Or Not class_Database.Data_Save_Ask("Bank Profile") Then Return False
            class_Procedures.splash_Show("Saving Bank Profile")
            Try
                Using context As New AccEntities
                    If ID.EditValue.Equals(0) Then
                        Dim bank As New acc_Banks With {
                        .Bank_Code = Bank_Code.Text.Trim,
                        .Corporation = Corporation.Text,
                        .Bank_Account = Bank_Account.Text.Trim,
                        .Account_Name = Account_Name.Text.Trim,
                        .Bank_Name = Bank_Name.Text.Trim,
                        .COA_Code = COA_Code.EditValue.ToString,
                        .Bank_BRSTN = Bank_BRSTN.Text.Trim,
                        .Bank_Manager = Bank_Manager.Text.Trim,
                        .Bank_Address = Bank_Address.Text.Trim,
                        .Bank_Tel_Number = Bank_Tel_Number.Text.Trim,
                        .Bank_Description = Bank_Description.Text.Trim,
                        .Notes = Notes.Text.Trim,
                        .Added_By = class_Variables.sUserName,
                        .Added_Date = Date.Today
                    }
                        context.acc_Banks.Add(bank)
                        context.SaveChanges()
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Save, $"New Bank Account", "Bank Account")
                    Else
                        If context.Database.ExecuteSqlCommand($"UPDATE acc_Banks 
                            SET Bank_Account = @Bank_Account,
                            Corporation = @Corporation,
                            Account_Name = @Account_Name,
                            Bank_Name = @Bank_Name,
                            COA_Code = @COA_Code,
                            Bank_BRSTN = @Bank_BRSTN,
                            Bank_Manager = @Bank_Manager,
                            Bank_Address = @Bank_Address,
                            Bank_Tel_Number = @Bank_Tel_Number,
                            Bank_Description = @Bank_Description,
                            Notes = @Notes,
                            Modified_By = @Modified_By,
                            Modified_Date = @Modified_Date
                            WHERE ID LIKE '{ID.EditValue}'",
                            New SqlParameter("@Bank_Account", Bank_Account.Text.Trim),
                            New SqlParameter("@Corporation", Corporation.Text),
                            New SqlParameter("@Account_Name", Account_Name.Text.Trim),
                            New SqlParameter("@Bank_Name", Bank_Name.Text.Trim),
                            New SqlParameter("@COA_Code", COA_Code.EditValue.ToString),
                            New SqlParameter("@Bank_BRSTN", Bank_BRSTN.Text.Trim),
                            New SqlParameter("@Bank_Manager", Bank_Manager.Text.Trim),
                            New SqlParameter("@Bank_Address", Bank_Address.Text.Trim),
                            New SqlParameter("@Bank_Tel_Number", Bank_Tel_Number.Text.Trim),
                            New SqlParameter("@Bank_Description", Bank_Description.Text.Trim),
                            New SqlParameter("@Notes", Notes.Text.Trim),
                            New SqlParameter("@Modified_By", class_Variables.sUserName),
                            New SqlParameter("@Modified_Date", DateTime.Now)) > 0 Then

                            context.SaveChanges()
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Update, $"Bank Account", "Bank Account")
                        End If
                    End If
                End Using
                Return True
            Catch ex As Exception
                Return class_Procedures.Show_Error(ex)
            Finally
                class_Procedures.splash_Close()
            End Try
            Return False
        End Function

        Friend Function Control_Retrieve(ByVal sBankAccount As String) As Boolean
            Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT * FROM acc_Banks WHERE Bank_Account LIKE '{sBankAccount}'")
                Bank_Account.Text = sBankAccount
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        ID.EditValue = myDataReader("ID").ToString
                        Bank_Code.Text = myDataReader("Bank_Code").ToString
                        Corporation.EditValue = myDataReader("Corporation").ToString
                        Account_Name.Text = myDataReader("Account_Name").ToString
                        Bank_Name.Text = myDataReader("Bank_Name").ToString
                        COA_Code.EditValue = myDataReader("COA_Code").ToString
                        Bank_BRSTN.Text = myDataReader("Bank_BRSTN").ToString
                        Bank_Manager.Text = myDataReader("Bank_Manager").ToString
                        Bank_Address.Text = myDataReader("Bank_Address").ToString
                        Bank_Tel_Number.Text = myDataReader("Bank_Tel_Number").ToString
                        Bank_Description.Text = myDataReader("Bank_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

    End Class

End Namespace