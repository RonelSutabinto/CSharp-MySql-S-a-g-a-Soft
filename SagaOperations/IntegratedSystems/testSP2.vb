Imports System.Data.SqlClient 'Import SQL Capabilities

Public Class frmSPEx

    Private strConn As String = "Data Source=HANNES;Initial Catalog=Master;Integrated Security=True"
    Private sqlCon As SqlConnection

    Private Sub LoadData()

        Dim strQuery As String

        strQuery = "SELECT * FROM tblSPExample"

        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)

            Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)

            sqlCon.Open()

            Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()

            If sqlReader.HasRows Then

                While (sqlReader.Read())

                    txtName.Text = sqlReader.GetString(1)
                    txtSurname.Text = sqlReader.GetString(2)
                    txtAge.Text = sqlReader.GetValue(3)

                End While


            End If

            sqlReader.Close()

        End Using

    End Sub

    Private Sub InsertNewRecord()

        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)

            Dim sqlComm As New SqlCommand()

            sqlComm.Connection = sqlCon

            sqlComm.CommandText = "InsertDataIntoTable"
            sqlComm.CommandType = CommandType.StoredProcedure

            sqlComm.Parameters.AddWithValue("FirstName", txtName.Text)
            sqlComm.Parameters.AddWithValue("Surname", txtSurname.Text)
            sqlComm.Parameters.AddWithValue("Age", Integer.Parse(txtAge.Text))

            sqlCon.Open()

            sqlComm.ExecuteNonQuery()

        End Using


        LoadData()

    End Sub

    Private Sub UpdateRecord()

        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)

            Dim sqlComm As New SqlCommand

            sqlComm.Connection = sqlCon


            sqlComm.CommandText = "UpdateDataInsideTable"
            sqlComm.CommandType = CommandType.StoredProcedure

            sqlComm.Parameters.AddWithValue("Name", txtName.Text)
            sqlComm.Parameters.AddWithValue("Surname", txtSurname.Text)
            sqlComm.Parameters.AddWithValue("Age", Integer.Parse(txtAge.Text))

            sqlCon.Open()

            sqlComm.ExecuteNonQuery()

        End Using

        LoadData()

    End Sub

    Private Sub DeleteRecord()

        sqlCon = New SqlConnection(strConn)


        Using (sqlCon)

            Dim sqlComm As New SqlCommand

            sqlComm.Connection = sqlCon

            sqlComm.CommandText = "DeleteDataFromTable"
            sqlComm.CommandType = CommandType.StoredProcedure

            sqlComm.Parameters.AddWithValue("StudentID", Integer.Parse(txtSearch.Text))


            sqlCon.Open()

            sqlComm.ExecuteNonQuery()

        End Using

        LoadData()

    End Sub

    Private Sub CreateTable()

        sqlCon = New SqlConnection(strConn)


        Using (sqlCon)

            Dim sqlComm As New SqlCommand

            sqlComm.Connection = sqlCon

            sqlComm.CommandText = "CreateTable"
            sqlComm.CommandType = CommandType.StoredProcedure


            sqlCon.Open()

            sqlComm.ExecuteNonQuery()

        End Using

    End Sub

    Private Sub DropTable()

        sqlCon = New SqlConnection(strConn)


        Using (sqlCon)

            Dim sqlComm As New SqlCommand

            sqlComm.Connection = sqlCon

            sqlComm.CommandText = "DropTable"
            sqlComm.CommandType = CommandType.StoredProcedure


            sqlCon.Open()

            sqlComm.ExecuteNonQuery()

        End Using

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        sqlCon = New SqlConnection(strConn)


        Using (sqlCon)

            Dim sqlComm As New SqlCommand

            sqlComm.Connection = sqlCon

            sqlComm.CommandText = "SELECT * FROM tblSPExample WHERE StudentID = " & Integer.Parse(txtSearch.Text)
            sqlComm.CommandType = CommandType.Text


            sqlCon.Open()

            sqlComm.ExecuteNonQuery()

        End Using

    End Sub

    Private Sub btnCreateTable_Click(sender As Object, e As EventArgs) Handles btnCreateTable.Click

        CreateTable()

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        InsertNewRecord()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        UpdateRecord()

    End Sub

    Private Sub Button4btnDelete_Click(sender As Object, e As EventArgs) Handles Button4btnDelete.Click

        DeleteRecord()

    End Sub


End Class
