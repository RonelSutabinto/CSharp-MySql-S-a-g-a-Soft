Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_RegAECode

    Private Sub frmShowAE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         ShowBranchCode()
    End Sub

    Sub mg_ShowAE()

        lvShowAE.Items.Clear()
        Dim cmd As New SqlCommand

        Dim rs As SqlDataReader

        cmd.CommandText = "bj_ShowAccountExecutive"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_brCode.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        Do While rs.Read()
            Dim li As ListViewItem = lvShowAE.Items.Add(rs.Item("OfficerName").ToString())
            li.SubItems.Add(rs.Item("AccountExecutive").ToString())
        Loop
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:
outs1:
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

    Sub RegisterAECode()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminRegisterAEcode"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_brCode.Text)
        cmd.Parameters.AddWithValue("@ParamAECode", txt_aecode.Text)
        cmd.Parameters.AddWithValue("@ParamOfficerName", txt_aeName.Text)
        cmd.Parameters.AddWithValue("@ParamShortName", txt_shortName.Text)
        cmd.Parameters.AddWithValue("@ParamSupervisor", txt_Supervisor.Text)
        cmd.Parameters.AddWithValue("@ParamSupervisorName", txt_SupervisorName.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Sub ModifyAECode()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminModifyAEcode"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_brCode.Text)
        cmd.Parameters.AddWithValue("@ParamAECode", txt_aecode.Text)
        cmd.Parameters.AddWithValue("@ParamOfficerName", txt_aeName.Text)
        cmd.Parameters.AddWithValue("@ParamShortName", txt_shortName.Text)
        cmd.Parameters.AddWithValue("@ParamSupervisor", txt_Supervisor.Text)
        cmd.Parameters.AddWithValue("@ParamSupervisorName", txt_SupervisorName.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            MsgBox(rs.Item("Message").ToString(), MsgBoxStyle.OkOnly, Application.CompanyName)
        End If
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Private Sub toolregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolregister.Click
         RegisterAECode()
        clear_txt()
        mg_ShowAE()
    End Sub

    Sub FindAE()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminFindAECode"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamAECode", txt_aecode.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            If rs.Item("Status").ToString() = "0" Then
                MsgBox(rs.Item("Message").ToString())
                txt_brCode.Text = rs.Item("BranchCode").ToString()
                txt_aeName.Text = rs.Item("OfficerName").ToString()
                txt_shortName.Text = rs.Item("ShortName").ToString()
                txt_Supervisor.Text = rs.Item("Supervisor").ToString()
                txt_SupervisorName.Text = rs.Item("SupervisorName").ToString()
            Else
                MsgBox(rs.Item("Message").ToString())

            End If

        End If

        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Sub DelAECode()

        lvShowAE.Items.Clear()
        ' On Error GoTo out
        'Dim connection As New SqlConnection("Server= '" & My.Settings.ServerName & "'; Database = ICS; Integrated Security = true")
        Dim cmd As New SqlCommand

        Dim rs As SqlDataReader

        cmd.CommandText = "Delete_AccountExecutive"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection

        cmd.Parameters.AddWithValue("@ParamAccountExecutive", txt_aecode.Text)
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_brCode.Text)

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

    Private Sub toolFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolFind.Click
         FindAE()
    End Sub

    Private Sub toolmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolmodify.Click

        Dim update As Integer = MessageBox.Show("Are you sure Modifying this AE - " + txt_aeName.Text, Application.CompanyName, MessageBoxButtons.YesNo)
        If update = DialogResult.No Then
            MessageBox.Show("Cancel Modifying " + txt_aeName.Text + " - AE", Application.CompanyName)
        Else
             ModifyAECode()
            clear_txt()
            mg_ShowAE()

            toolmodify.Enabled = False
            toolDelete.Enabled = False
            toolFind.Enabled = True
            toolregister.Enabled = True
        End If
    End Sub

    Sub clear_txt()
        txt_aecode.Text = String.Empty
        txt_aeName.Text = String.Empty
        txt_shortName.Text = String.Empty
        txt_Supervisor.Text = String.Empty
        txt_SupervisorName.Text = String.Empty
        txt_aecode.Focus()
    End Sub

    Private Sub toolNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolNew.Click
        Dim news As Integer = MessageBox.Show("Are you sure ?", Application.CompanyName, MessageBoxButtons.YesNo)
        If news = DialogResult.No Then
            MessageBox.Show("Failed making data", Application.CompanyName)
        Else
             clear_txt()

            toolmodify.Enabled = False
            toolDelete.Enabled = False
            toolFind.Enabled = True
            toolregister.Enabled = True
        End If
    End Sub

    Private Sub cmb_Branch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Branch.SelectedIndexChanged
         ShowBranchName()
         mg_ShowAE()
    End Sub

    Private Sub lvShowAE_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvShowAE.DoubleClick
        txt_aeName.Text = lvShowAE.SelectedItems.Item(0).SubItems(0).Text()
        txt_aecode.Text = lvShowAE.SelectedItems.Item(0).SubItems(1).Text()

        toolDelete.Enabled = True
        toolFind.Enabled = False
        toolmodify.Enabled = True
        toolNew.Enabled = True
        toolregister.Enabled = False
    End Sub

    Private Sub txt_aecode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_aecode.TextChanged
         mg_ShowAE()
    End Sub

    Private Sub toolDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolDelete.Click

        Dim delete As Integer = MessageBox.Show("Are you sure Deleting this AE - " + txt_aeName.Text, Application.CompanyName, MessageBoxButtons.YesNo)
        If delete = DialogResult.No Then
            MessageBox.Show("Cancel Deleting " + txt_aeName.Text + " - AE", Application.CompanyName)
        Else
             DelAECode()
             mg_ShowAE()
             clear_txt()

            toolmodify.Enabled = False
            toolDelete.Enabled = False
            toolFind.Enabled = True
            toolregister.Enabled = True
        End If

    End Sub

    Private Sub txt_brCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_brCode.TextChanged

    End Sub

End Class