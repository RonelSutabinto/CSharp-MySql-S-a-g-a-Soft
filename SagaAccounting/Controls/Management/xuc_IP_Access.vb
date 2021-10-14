Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System
Imports System.Data
Imports System.Data.SqlClient

Namespace Controls.Management

    Public Class xuc_IP_Access
        Inherits DevExpress.XtraEditors.XtraUserControl

        Friend Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Branch(ip_Branch)
        End Sub

        Friend Sub Control_New()
            If Not class_Procedures.actionAsk("New IP Address", "Initialize new IP Address", "You might lose unsaved data") Then Return
            ip_Address.EditValue = "0.0.0.0"
            ip_Branch.Select()
        End Sub

        Friend Function Control_Save() As Boolean

            If class_Procedures.isEmpty(ip_Branch) Then Return False
            If class_Procedures.isEmpty(ip_Address) Then Return False

            If Not class_Database.Data_Save_Ask(ip_Address.Text) Then Return False

            class_Procedures.splash_Show("Saving IP Address")

            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand("mg_RegisterIP", MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                    MyCommand.Parameters.Add("@ParamBranchCode", SqlDbType.VarChar).Value = ip_Branch.EditValue
                    MyCommand.Parameters.Add("@ParamIPAddress", SqlDbType.Text).Value = ip_Address.Text.Trim

                    Try
                        MySQLConnection.Open()
                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Save, $"IP Address {ip_Address.Text}")
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

        Friend Function Control_Delete(ByVal sIP As String) As Boolean

            Return class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM IPAddresses WHERE IPAddress LIKE '{sIP}'", $"IP Address: {sIP}")
        End Function

        Private Sub ip_Address_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles ip_Address.Enter
            ip_Address.SelectAll()
        End Sub

        Private Sub ip_Address_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles ip_Address.Leave
            IP_Location.Text = class_Connections.get_IP_GEO(ip_Address.Text)
        End Sub

    End Class

End Namespace