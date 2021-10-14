Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class admin_UpdateCorp

    Private Sub showCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showCust.Click
        IS_Sales_ReleaseAccount_List.Text = "UPDATECORP"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Private Sub admin_UpdateCorp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         showCorpDesc()
    End Sub

    Sub showCorpDesc()
        cmb_CorpName.Items.Clear()
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowCORP"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        'cmd.Parameters.AddWithValue("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        'cmd.Parameters.AddWithValue("@ParamOfficerName", cmb_aename.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        Do While rs.Read
            cmb_CorpName.Items.Add(rs.Item("CorpDesc").ToString())
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

    Sub showCorpcode()

        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowCORPDesc"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamCorpDesc", cmb_CorpName.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        If rs.Read Then
            txt_newcorpcode.Text = rs.Item("CorpCode").ToString
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

    Sub UpdateCorp()

        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_UpdateCORP"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_brCode.Text)
        cmd.Parameters.AddWithValue("@ParamAccountNumber ", txt_AccountNumber.Text)
        cmd.Parameters.AddWithValue("@ParamLedgerSetNumber", txt_LedSet.Text)
        cmd.Parameters.AddWithValue("@ParamCORP", txt_newcorpcode.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
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

outs:
outs1:

    End Sub

    Private Sub cmb_CorpName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CorpName.SelectedIndexChanged

    End Sub

    Private Sub cmb_CorpName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_CorpName.TextChanged
         showCorpcode()
    End Sub

    Private Sub toolpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpost.Click
         UpdateCorp()
    End Sub

End Class