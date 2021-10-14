Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Logistics
    Public Class xuc_Inclusion_Inventory
        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Inclusions(Inclusion_Code)
            'class_Saga_Variables.Initialize_Engine_Received()
            class_Saga_Procedures.Initialize_Engine_Received(Engine)
            Inventory_Code.Select()
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = False, Optional ByVal bOrderModify As Boolean = False)
            If bAsk AndAlso Not class_Procedures.actionAsk("New Inclusion Inventory", "Initialize new Inclusion Inventory", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bAsk)
            Inventory_Code.Select()
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "RETRIEVE_INC_INV")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Inclusion_Procedures")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Inclusion_Code.Text = myDataReader("Inclusion_Code").ToString
                        Inventory_Code.Text = myDataReader("Inventory_Code").ToString
                        Engine.Text = myDataReader("Engine").ToString
                        Notes.Text = myDataReader("Notes").ToString
                        Return True
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Receive() As Boolean
            If class_Procedures.isEmpty(Inclusion_Code) Then Return False
            If class_Procedures.isEmpty(Inventory_Code) Then Return False

            Dim iQuantity As Integer = class_Functions.Show_Input_Box("Input Inclusions Quantity", "Inclusions Quantity", 0)
            If iQuantity < 1 Then Return False
            If Not class_Procedures.actionAsk("Receive Inclusion Inventory", $"Receive {iQuantity} inclusion inventories", "You might receive wrong Inclusion Inventory quantity") Then Return False

            For i As Integer = 0 To iQuantity - 1
                If Control_Save(0) Then
                    Continue For
                Else Return False
                End If
            Next
            Return True
        End Function

        Friend Function Control_Save(ByVal iID As Integer) As Boolean
            If class_Procedures.isEmpty(Inclusion_Code) Then Return False
            If class_Procedures.isEmpty(Inventory_Code) Then Return False

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", iID),
                New SqlParameter("@Inclusion_Code", Inclusion_Code.EditValue),
                New SqlParameter("@Inventory_Code", Inventory_Code.Text.ToUpper.Trim),
                New SqlParameter("@Engine", Engine.EditValue),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE_INC_INV")
            }

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Inclusion_Procedures", "Inclusion Inventory")
        End Function

        Friend Function Control_Delete() As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "DELETE_INC_INV")
            }

            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Inclusion_Procedures", "Delete Inclusion Inventory", True))
        End Function
    End Class
End Namespace