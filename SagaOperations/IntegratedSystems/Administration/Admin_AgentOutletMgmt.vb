Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_AgentOutletMgmt

    Private Sub frmShowAgent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         ShowBranchCode()
         ShowSellerType()
    End Sub

    Sub mg_ShowAgent()

        lvAgent.Items.Clear()
        Dim cmd As New SqlCommand

        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowAgent"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_brCode.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        Do While rs.Read()
            Dim li As ListViewItem = lvAgent.Items.Add(rs.Item("AgentCode").ToString())
            li.SubItems.Add(rs.Item("AgentName").ToString())
            li.SubItems.Add(rs.Item("InfoOutletType").ToString())
            li.SubItems.Add(rs.Item("AgentAddress").ToString())
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

    Sub ShowSellerType()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmb_SellerType.Items.Clear()
        cmd.CommandText = "mg_ShowSellerType"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        'cmd.Parameters.AddWithValue("@ParamIsCommand", Me.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        Do While rs.Read
            cmb_SellerType.Items.Add(rs.Item("SellerType").ToString)
        Loop

out:

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Sub RegisterReseller()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminRegisterReseller"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_brCode.Text)
        cmd.Parameters.AddWithValue("@ParamAgentCode", txt_AgentCode.Text)
        cmd.Parameters.AddWithValue("@ParamAgentName", txt_AgentName.Text)
        cmd.Parameters.AddWithValue("@ParamSellerType", cmb_SellerType.Text)
        cmd.Parameters.AddWithValue("@ParamAgentAddress", txt_SellerAddress.Text)

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

    Sub ModifyReseller()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminModifyReseller"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_brCode.Text)
        cmd.Parameters.AddWithValue("@ParamAgentCode", txt_AgentCode.Text)
        cmd.Parameters.AddWithValue("@ParamAgentName", txt_AgentName.Text)
        cmd.Parameters.AddWithValue("@ParamSellerType", cmb_SellerType.Text)
        cmd.Parameters.AddWithValue("@ParamAgentAddress", txt_SellerAddress.Text)

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

    Sub DelAgentCode()

        lvAgent.Items.Clear()
        ' On Error GoTo out
        'Dim connection As New SqlConnection("Server= '" & My.Settings.ServerName & "'; Database = ICS; Integrated Security = true")
        Dim cmd As New SqlCommand

        Dim rs As SqlDataReader

        cmd.CommandText = "Delete_Agent"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection

        cmd.Parameters.AddWithValue("@ParamAgentCode", txt_AgentCode.Text)
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

    Sub FindAGENT()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminFindReseller"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamAgentCode", txt_AgentCode.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            If rs.Item("Status").ToString() = "0" Then
                MsgBox(rs.Item("Message").ToString())
                txt_brCode.Text = rs.Item("BranchCode").ToString()
                txt_AgentCode.Text = rs.Item("AgentCode").ToString()
                txt_AgentName.Text = rs.Item("AgentName").ToString()
                txt_SellerAddress.Text = rs.Item("AgentAddress").ToString()
                cmb_SellerType.Text = rs.Item("InfoOutletType").ToString()
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

    Private Sub cmb_Branch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Branch.SelectedIndexChanged
         ShowBranchName()
         mg_ShowAgent()
    End Sub

    Private Sub lvAgent_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvAgent.DoubleClick
        txt_AgentName.Text = lvAgent.SelectedItems.Item(0).SubItems(1).Text()
        txt_AgentCode.Text = lvAgent.SelectedItems.Item(0).SubItems(0).Text()
        cmb_SellerType.Text = lvAgent.SelectedItems.Item(0).SubItems(2).Text()
        txt_SellerAddress.Text = lvAgent.SelectedItems.Item(0).SubItems(3).Text()

        toolmodify.Enabled = True
        toolDelete.Enabled = True
        toolFind.Enabled = False
        toolregister.Enabled = False
    End Sub

    Sub clear_txt()
        txt_AgentName.Text = String.Empty
        txt_AgentCode.Text = String.Empty
        cmb_SellerType.Text = String.Empty
        txt_SellerAddress.Text = String.Empty
        txt_AgentName.Focus()
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

    Private Sub toolregister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolregister.Click
         RegisterReseller()
        toolmodify.Enabled = True
        toolDelete.Enabled = True
        toolFind.Enabled = False
        toolregister.Enabled = False
         clear_txt()
         mg_ShowAgent()
    End Sub

    Private Sub toolFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolFind.Click
         FindAGENT()
    End Sub

    Private Sub toolmodify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolmodify.Click

        Dim update As Integer = MessageBox.Show("Are you sure Modifying this AE - " + txt_AgentName.Text, Application.CompanyName, MessageBoxButtons.YesNo)
        If update = DialogResult.No Then
            MessageBox.Show("Cancel Modifying " + txt_AgentName.Text + " - AE", Application.CompanyName)
        Else
             ModifyReseller()

            toolmodify.Enabled = False
            toolDelete.Enabled = False
            toolFind.Enabled = True
            toolregister.Enabled = True
             clear_txt()
             mg_ShowAgent()
        End If
    End Sub

    Private Sub toolDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolDelete.Click

        Dim delete As Integer = MessageBox.Show("Are you sure Deleting this AGENT - " + txt_AgentName.Text, Application.CompanyName, MessageBoxButtons.YesNo)
        If delete = DialogResult.No Then
            MessageBox.Show("Cancel Deleting " + txt_AgentName.Text + " - AGENT", Application.CompanyName)
        Else
             DelAgentCode()

            toolmodify.Enabled = False
            toolDelete.Enabled = False
            toolFind.Enabled = True
            toolregister.Enabled = True
             clear_txt()
             mg_ShowAgent()
        End If
    End Sub

    Private Sub lvAgent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvAgent.SelectedIndexChanged

    End Sub

End Class