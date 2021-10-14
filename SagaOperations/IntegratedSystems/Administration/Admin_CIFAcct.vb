Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_CIFAcct

    Sub mg_ShowCIFKey()

        lvCIF.Items.Clear()
        Dim cmd As New SqlCommand

        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowCIFAccounts_Quick_find"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamQuickText", txtFullName.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        Do While rs.Read()
            Dim li As ListViewItem = lvCIF.Items.Add(rs.Item("BranchCode").ToString())
            li.SubItems.Add(rs.Item("FullName").ToString())
            li.SubItems.Add(rs.Item("CIFKey").ToString())
        Loop
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Sub DelCIFKey()

        lvCIF.Items.Clear()
        On Error GoTo out

        Dim cmd As New SqlCommand

        Dim rs As SqlDataReader

        cmd.CommandText = "DELETE_CIFKey"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection

        cmd.Parameters.AddWithValue("@ParamCIFKey", lblcifKey.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        If rs.Read Then
            MsgBox(rs.Item("Message").ToString(), vbInformation, Application.CompanyName)
        End If
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)

        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Private Sub txtFullName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFullName.KeyDown
        If e.KeyCode = Keys.Enter Then
             mg_ShowCIFKey()
        End If
    End Sub

    Private Sub lvCIF_DoubleClick(sender As Object, e As EventArgs) Handles lvCIF.DoubleClick
        lblcifKey.Text = lvCIF.SelectedItems.Item(0).SubItems(2).Text()
         DelCIFKey()
         mg_ShowCIFKey()
    End Sub

    Private Sub txtFullName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFullName.TextChanged

    End Sub

    Private Sub Admin_CIFAcct_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Admin_CIFAcct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class