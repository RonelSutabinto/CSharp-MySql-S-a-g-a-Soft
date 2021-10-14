Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class userConfig

    Private Sub userConfig_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'MISConnection.Close()
    End Sub

    Private Sub userConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MISConnection.Open()
    End Sub

    Sub ChangePass()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_UpdateUserPass"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamUsername", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamOldPass", Encrypt(txt_oldpass.Text))
        cmd.Parameters.AddWithValue("@ParamNewPass", Encrypt(txt_newpass.Text))
        cmd.Parameters.AddWithValue("@ParamRetypeNewPass", Encrypt(txt_re_newpass.Text))

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        'If txt_newpass.Text <> txt_re_newpass.Text Then
        '    MsgBox("New password mismatch. Please retype again.")
        'Else
        '     FindUsername()
        'End If
         ChangePass()
    End Sub

End Class