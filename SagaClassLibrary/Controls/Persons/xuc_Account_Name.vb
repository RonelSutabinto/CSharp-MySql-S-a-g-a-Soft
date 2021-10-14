Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Controls.Persons

    Public Class xuc_Account_Name

        Friend Sub Control_Initialize()
            class_Database.Fill_Edit(class_Database.ICSConnection, Account_Type, "acc_Account_Names", "Account_Type")
        End Sub

        Friend Sub Control_New(ByVal bNew As Boolean)
            class_Procedures.Initialize_Controls(Me, bNew)
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Account_Code, "acc_Account_Names", "Account_Code", "NAME-")
            Account_Name.Select()
        End Sub

        Friend Function control_Save() As Boolean
            If class_Procedures.isEmpty(Account_Code) Then Return False
            If class_Procedures.isEmpty(Account_Type) Then Return False
            If class_Procedures.isEmpty(Account_Name) Then Return False
            If class_Procedures.isEmpty(Account_Address) Then Return False

            If ID.EditValue.Equals("0") Then
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Account_Code, "acc_Account_Names", "Account_Code", "NAME-")
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Account_Code", Account_Code.Text.Trim),
                New SqlParameter("@Account_Type", Account_Type.Text.Trim.ToUpper),
                New SqlParameter("@Account_Name", Account_Name.Text.Trim.ToUpper),
                New SqlParameter("@Account_Address", Account_Address.Text.Trim),
                New SqlParameter("@Account_Mobile", Account_Mobile.Text.Trim),
                New SqlParameter("@Account_Description", Account_Description.Text.Trim),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Account_Name_Procedures", "Account Name", Account_Code.Text.Trim)
        End Function

        Friend Function Control_Retrieve(ByVal sCode As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Account_Code", sCode),
                New SqlParameter("@Action_Type", "GETCODE")
            }
            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Account_Name_Procedures")
                Try
                    Account_Code.Text = sCode
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        ID.EditValue = myDataReader("ID").ToString
                        Account_Type.Text = myDataReader("Account_Type").ToString
                        Account_Code.Text = myDataReader("Account_Code").ToString
                        Account_Name.Text = myDataReader("Account_Name").ToString
                        Account_Address.Text = myDataReader("Account_Address").ToString
                        Account_Mobile.Text = myDataReader("Account_Mobile").ToString
                        Account_Description.Text = myDataReader("Account_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                    End If
                Catch ex As Exception
                    Return class_Procedures.Show_Error(ex)
                End Try
            End Using
            Return False
        End Function

        Friend Function Control_Delete(ByVal sCode As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Account_Code", sCode),
                New SqlParameter("@Action_Type", "DELETE")
            }
            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Account_Name_Procedures", "Delete Account Name", True))
        End Function

    End Class

End Namespace