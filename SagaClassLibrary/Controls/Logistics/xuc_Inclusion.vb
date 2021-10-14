Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Controls.Logistics
    Public Class xuc_Inclusion
        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Database.Fill_Edit(class_Database.ICSConnection, Inclusion_Type, "inv_Inclusions", "Inclusion_Type")
            Inclusion_Type.Select()
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = False, Optional ByVal bOrderModify As Boolean = False)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Inclusion Item", "Initialize new Inclusion Item", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bAsk)
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Inclusion_Code, "inv_Inclusions", "Inclusion_Code", "INCLUSION-")
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Inclusion_Procedures")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Inclusion_Code.Text = myDataReader("Inclusion_Code").ToString
                        Inclusion_Type.Text = myDataReader("Inclusion_Type").ToString
                        Inclusion_Name.Text = myDataReader("Inclusion_Name").ToString
                        Description.Text = myDataReader("Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                        Return True
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Inclusion_Code) Then Return False
            If class_Procedures.isEmpty(Inclusion_Type) Then Return False

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Inclusion_Code", Inclusion_Code.Text),
                New SqlParameter("@Inclusion_Type", Inclusion_Type.Text.Trim),
                New SqlParameter("@Inclusion_Name", Inclusion_Name.Text.Trim),
                New SqlParameter("@Description", Description.Text.Trim),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Inclusion_Procedures", "Inclusion Item", Inclusion_Name.Text)
        End Function

        Friend Function Control_Delete() As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "DELETE")
            }

            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Inclusion_Procedures", "Delete Inclusion Item", True))
        End Function
    End Class
End Namespace