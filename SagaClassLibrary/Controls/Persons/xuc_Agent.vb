Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Persons

    Public Class xuc_Agent
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()

            class_Saga_Procedures.Initialize_Branch(Branch_Code)
            class_Database.Fill_Edit(class_Database.ICSConnection, Agent_Type, "Agent", "InfoOutletType")
            Agent_Code.Select()
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Agent_Procedures")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Agent_Code.Text = myDataReader("AgentCode").ToString
                        Branch_Code.EditValue = myDataReader("BranchCode").ToString
                        Agent_Type.Text = myDataReader("InfoOutletType").ToString
                        Agent_Name.Text = myDataReader("AgentName").ToString
                        Agent_Address.Text = myDataReader("AgentAddress").ToString
                        IsActive.IsOn = Convert.ToBoolean(myDataReader("IsActive"))
                        Agent_Description.Text = myDataReader("Agent_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = false)
            If bask AndAlso Not class_Procedures.actionAsk("New Agent Profile", "Initialize new Agent Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bask)
            Agent_Code.Select()
        End Sub

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Branch_Code) Then Return False
            If class_Procedures.isEmpty(Agent_Code) Then Return False
            If class_Procedures.isEmpty(Agent_Name) Then Return False

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Agent_Code", Agent_Code.Text.Trim),
                New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                New SqlParameter("@Agent_Type", Agent_Type.Text.Trim),
                New SqlParameter("@Agent_Name", Agent_Name.Text.Trim),
                New SqlParameter("@Agent_Address", Agent_Address.Text.Trim),
                New SqlParameter("@Agent_Description", Agent_Description.Text.Trim),
                New SqlParameter("@IsACtive", IsActive.IsOn),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Agent_Procedures", "Agent Profile", Agent_Name.Text.Trim)
        End Function

        Friend Function Control_Activate(ByVal sID As String) As Boolean
            If class_Procedures.isEmpty(ID) Then Return False
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", sID),
                New SqlParameter("@IsACtive", Not IsActive.IsOn),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "ACTIVATE")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Agent_Procedures", "Agent Profile", Agent_Name.Text.Trim)
        End Function

        'Friend Function Control_Delete() As Boolean
        '    Return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM Agent WHERE AgentCode LIKE '{Agent_Code.Text}'", $"Agent Profile: {Agent_Name.Text}")
        'End Function

    End Class

End Namespace