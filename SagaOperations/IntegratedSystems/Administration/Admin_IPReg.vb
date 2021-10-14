Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_IPReg

    Private Sub Admin_IPReg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         ShowBranchCode()
    End Sub

    Sub ShowBranchCode()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmb_Branch.Items.Clear()
        cmd.CommandText = "mg_ShowBranchCode"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        'cmd.Parameters.AddWithValue("@ParamIsCommand", Me.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        Do While rs.Read
            cmb_Branch.Items.Add(rs.Item("Branch").ToString)
        Loop

out:

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Sub ShowBranchName()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowBranchName"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchName", cmb_Branch.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        Do While rs.Read
            txt_brCode.Text = rs.Item("BranchCode").ToString
        Loop

out:

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Sub RegisterIP()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_RegisterIP"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_brCode.Text)
        cmd.Parameters.AddWithValue("@ParamIPAddress", txt_ipadd.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If

out:

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Private Sub cmb_Branch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Branch.TextChanged
         ShowBranchName()
    End Sub

    Sub ClearField()
        txt_ipadd.Text = String.Empty
    End Sub

    Private Sub cmd_reg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_reg.Click
         RegisterIP()
         ClearField()
    End Sub

    Private Sub cmb_Branch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Branch.SelectedIndexChanged

    End Sub

End Class