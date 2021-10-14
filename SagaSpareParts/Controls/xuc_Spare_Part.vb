Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Namespace SagaSpareParts.Controls

    Public Class Xuc_Spare_Part
        Inherits DevExpress.XtraEditors.XtraUserControl

        Friend Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()

            class_Database.Fill_Edit(class_Database.SPAConnection, part_Category, "Spare_Parts_Master", "Category")
            class_Database.Fill_Edit(class_Database.SPAConnection, part_Brand, "Spare_Parts_Master", "Brand")
            part_Number.Select()
        End Sub

        Friend Sub Control_New(Optional ByVal bClear As Boolean = False)
            If bClear AndAlso Not class_Procedures.actionAsk("New Spare Part Profile", "Initialize new Spare Part Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bClear)
            part_Number.Select()
        End Sub

        Friend Sub Control_Import()
            class_Procedures.splash_Show($"Saving Spare Part {part_Number.Text} Profile")


            Using MySQLConnection = New SqlConnection(class_Database.SPAConnection)
                Using MyCommand As SqlCommand = New SqlCommand("INSERT INTO Spare_Parts_Master (Category, Brand, PartsNumber, PartsName, ModelCode, ModelName, SRP, Note, TransactedBy, TransactionDate) VALUES (@Category, @Brand, @PartsNumber, @PartsName, @ModelCode, @ModelName, @SRP, @Note, @TransactedBy, @TransactionDate)", MySQLConnection)
                    With MyCommand
                        .Parameters.Add("@Category", SqlDbType.VarChar).Value = part_Category.Text.Trim
                        .Parameters.Add("@Brand", SqlDbType.VarChar).Value = part_Brand.Text.Trim
                        .Parameters.Add("@PartsNumber", SqlDbType.VarChar).Value = part_Number.Text.Trim
                        .Parameters.Add("@PartsName", SqlDbType.VarChar).Value = part_Name.Text.Trim
                        .Parameters.Add("@ModelCode", SqlDbType.VarChar).Value = part_Model_Code.Text.Trim
                        .Parameters.Add("@ModelName", SqlDbType.VarChar).Value = part_Model_Name.Text.Trim
                        .Parameters.Add("@SRP", SqlDbType.Money).Value = convert.todecimal(part_Price.Value)
                        .Parameters.Add("@Note", SqlDbType.VarChar).Value = part_Notes.Text.Trim
                        .Parameters.Add("@TransactedBy", SqlDbType.VarChar).Value = class_Variables.sUserName
                        .Parameters.Add("@TransactionDate", SqlDbType.VarChar).Value = DateTime.Now
                        Try
                            MySQLConnection.Open()
                            If Convert.ToBoolean(.ExecuteNonQuery()) Then
                                class_Procedures.Set_Message(class_Procedures.MsgMode.Save, $"Spare Part {part_Number.Text} Profile")
                            End If
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        Finally
                            class_Procedures.splash_Close()
                        End Try
                    End With
                End Using
            End Using
        End Sub

        Friend Function Control_Retrieve(ByVal sCode As String) As Boolean

            class_Procedures.splash_Show($"Retrieving Spare Part {part_Number.Text} Profile")
            part_Number.EditValue = sCode.Trim
            Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.SPAConnection, $"SELECT * FROM Spare_Parts_Master WHERE PartsNumber LIKE '{sCode.Trim}'")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        part_ID.Text = myDataReader("id").ToString
                        part_Category.Text = myDataReader("Category").ToString
                        part_Brand.Text = myDataReader("Brand").ToString
                        part_Name.Text = myDataReader("PartsName").ToString
                        part_Model_Code.Text = myDataReader("ModelCode").ToString
                        part_Model_Name.Text = myDataReader("ModelName").ToString
                        part_Price.Value = convert.todecimal(myDataReader("SRP"))
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Save(ByVal bAsk As Boolean) As Boolean
            If class_Procedures.isEmpty(part_Number) Then Return False
            If class_Procedures.isEmpty(part_Name) Then Return False
            If class_Procedures.isEmpty(part_Price) Then Return False

            If bAsk Then
                If Not class_Database.Data_Save_Ask(part_Number.Text) Then Return False
            End If

            class_Procedures.splash_Show($"Saving Spare Part {part_Number.Text} Profile")
            Dim sQuery As String = $"SELECT PartsNumber FROM Spare_Parts_Master WHERE PartsNumber LIKE '{part_Number.Text}'"


            Using MySQLConnection = New SqlConnection(class_Database.SPAConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    With MyCommand
                        If class_Database.IsDataExist(class_Database.SPAConnection, sQuery) Then
                            .CommandText = $"UPDATE Spare_Parts_Master SET Category = @Category, Brand = @Brand, PartsName = @PartsName, ModelCode = @ModelCode, ModelName = @ModelName, SRP = @SRP WHERE PartsNumber LIKE '{part_Number.Text}'"
                        Else
                            .CommandText = "INSERT INTO Spare_Parts_Master (Category, Brand, PartsNumber, PartsName, ModelCode, ModelName, SRP, Note, TransactedBy, TransactionDate) VALUES (@Category, @Brand, @PartsNumber, @PartsName, @ModelCode, @ModelName, @SRP, @Note, @TransactedBy, @TransactionDate)"
                        End If

                        .Parameters.Add("@Category", SqlDbType.VarChar).Value = part_Category.Text.Trim
                        .Parameters.Add("@Brand", SqlDbType.VarChar).Value = part_Brand.Text.Trim
                        .Parameters.Add("@PartsNumber", SqlDbType.VarChar).Value = part_Number.Text.Trim
                        .Parameters.Add("@PartsName", SqlDbType.VarChar).Value = part_Name.Text.Trim
                        .Parameters.Add("@ModelCode", SqlDbType.VarChar).Value = part_Model_Code.Text.Trim
                        .Parameters.Add("@ModelName", SqlDbType.VarChar).Value = part_Model_Name.Text.Trim
                        .Parameters.Add("@SRP", SqlDbType.Money).Value = convert.todecimal(part_Price.Value)
                        .Parameters.Add("@Note", SqlDbType.VarChar).Value = part_Notes.Text.Trim
                        .Parameters.Add("@TransactedBy", SqlDbType.VarChar).Value = class_Variables.sUserName
                        .Parameters.Add("@TransactionDate", SqlDbType.VarChar).Value = DateTime.Now
                        Try
                            MySQLConnection.Open()
                            If Convert.ToBoolean(.ExecuteNonQuery()) Then
                                class_Procedures.Set_Message(class_Procedures.MsgMode.Save, $"Spare Part {part_Number.Text} Profile")
                                Return True
                            End If
                        Catch ex As Exception
                            Return class_Procedures.Show_Error(ex)
                        Finally
                            class_Procedures.splash_Close()
                        End Try
                    End With
                End Using
            End Using
            Return False
        End Function

        Friend Sub Control_Delete()
            class_Database.Data_Delete_Ask(class_Database.SPAConnection, $"SELECT part_Number FROM Spare_Parts_Master WHERE PartsNumber LIKE '{part_Number.Text}'", $"Spare Part: {part_Number.Text}")
        End Sub

        Private Sub part_Number_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles part_Number.KeyDown
            If e.KeyCode = Keys.Enter Then
                Control_Retrieve(part_Number.Text.Trim)
            End If
        End Sub

    End Class

End Namespace