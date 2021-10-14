Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class TestSP

    Private Sub TestSP_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub SaveRec()

        Dim connection As New SqlConnection("Server= (local); Database = ICS; Integrated Security = true")

        Dim params(1) As SqlParameter

        params(0) = New SqlParameter("@ParamUsername", SqlDbType.VarChar)
        params(0).Value = TextBox1.Text

        'sqlComm.Parameters.AddWithValue("FirstName", txtName.Text)

        params(1) = New SqlParameter("@ParamPass", SqlDbType.VarChar)
        params(1).Value = TextBox2.Text

        Dim command As New SqlCommand()
        command.Connection = mySQLConnection
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "testSP"

        command.Parameters.AddRange(params)

        mySQLConnection.Open()

        'MsgBox(.ToString)
        command.ExecuteNonQuery()

        mySQLConnection.Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
         SaveRec()
    End Sub

End Class