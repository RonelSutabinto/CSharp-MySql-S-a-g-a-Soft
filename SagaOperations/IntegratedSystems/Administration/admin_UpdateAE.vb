Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class admin_UpdateAE

    Private Sub admin_UpdateAE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         showAEName()
    End Sub

    Sub mg_UpdateAE()
        'MsgBox(LViewList.SelectedItems.Item(0).SubItems(1).Text & " - " & LViewList.SelectedItems.Item(0).SubItems(7).Text)
        IS_SALES_Release_View.cmd_showInvent.Enabled = False
        'On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_UpdateAccountExecutives"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection

        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_brCode.Text)
        cmd.Parameters.AddWithValue("@ParamAccountNumber", txt_AccountNumber.Text)
        cmd.Parameters.AddWithValue("@ParamLedgerSetNumber", txt_LedSet.Text)
        cmd.Parameters.AddWithValue("@ParamAccountExecutives", txt_newAECode.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()

        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs

out:    MsgBox(Err.Description)

        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Sub showAEName()
        cmb_aename.Items.Clear()
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowAccountExecutives"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", MainMenu.statusBrCode.Caption)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        Do While rs.Read()
            cmb_aename.Items.Add(rs.Item("OfficerName").ToString)
        Loop
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:
outs1:

    End Sub

    Sub showAECode()

        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowAccountExecName"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        cmd.Parameters.AddWithValue("@ParamOfficerName", cmb_aename.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        If rs.Read Then
            txt_newAECode.Text = rs.Item("AccountExecutive").ToString()
        End If

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Private Sub cmb_aename_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_aename.SelectedIndexChanged

    End Sub

    Private Sub cmb_aename_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_aename.TextChanged
         showAECode()
    End Sub

    Private Sub showCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showCust.Click
        IS_Sales_ReleaseAccount_List.Text = "UPDATEAE"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Private Sub toolpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpost.Click
         mg_UpdateAE()
    End Sub

End Class