Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Petty_Cash

    Public Class xuc_Petty_Cash_Profile

        Friend Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Branch(Branch_Code)

            'class_Saga_Variables.Initialize_Journal_Profiles()
            class_Saga_Procedures.Initialize_Journal_Profile(Profile_Code)

            Profile_Code.Select()
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = false)
            If bask AndAlso Not class_Procedures.actionAsk("New Petty Cash Profile", "Create New Petty Cash Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bAsk)
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Petty_Cash_Code, "acc_Petty_Cash_Profiles", "Petty_Cash_Code", "PETTY-CASH-")
            Profile_Code.SelectAll()
        End Sub

        Friend Function Control_Retrieve(ByVal sCode As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Petty_Cash_Code", sCode),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Profile_Procedures")
                Try
                    Petty_Cash_Code.EditValue = sCode
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        ID.EditValue = myDataReader("ID").ToString
                        Petty_Cash_Code.Text = myDataReader("Petty_Cash_Code").ToString
                        Branch_Code.EditValue = myDataReader("Branch_Code").ToString
                        Profile_Code.Text = myDataReader("Profile_Code").ToString
                        Category_Ceiling.Value = Convert.ToDecimal(myDataReader("Category_Ceiling"))
                        Notes.Text = myDataReader("Notes").ToString
                    End If
                Catch ex As Exception
                    Return class_Procedures.Show_Error(ex)
                End Try
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Petty_Cash_Code) Then Return False
            If class_Procedures.isEmpty(Profile_Code) Then Return False

            If ID.EditValue.Equals(0) Then
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Petty_Cash_Code, "acc_Petty_Cash_Profiles", "Petty_Cash_Code", "PETTY-CASH-")
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Petty_Cash_Code", Petty_Cash_Code.Text.Trim),
                New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                New SqlParameter("@Profile_Code", Profile_Code.EditValue),
                New SqlParameter("@Category_Ceiling", Category_Ceiling.Value),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Profile_Procedures", "Petty Cash Profile", Petty_Cash_Code.Text.Trim)
        End Function

        Friend Function Control_Delete() As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "DELETE")
            }
            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Profile_Procedures", "Delete Petty Cash Profile", True))
        End Function

        Private Sub Profile_Code_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Profile_Code.ButtonClick
            Select Case e.Button.Index
                Case 1
                    class_Saga_Procedures.Show_Journal_Profile(Profile_Code.EditValue.ToString)
            End Select
        End Sub

    End Class

End Namespace