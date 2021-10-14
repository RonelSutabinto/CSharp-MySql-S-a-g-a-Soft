Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports wSClassLib.myModules

Public Class Admin_UserManagement

    Private Sub frmShowUsers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  ShowBranchCode()
        ' mg_ShowAUsers()

        class_Saga_Variables.Initialize_Users()
        class_Saga_Procedures.Initialize_User(txt_username)
    End Sub

    Sub mg_ShowAUsers()
        '        lvUsers.Items.Clear()
        '        Dim cmd As New SqlCommand
        '        Dim rs As SqlDataReader

        '        cmd.CommandText = "bj_ShowUsers"
        '        cmd.CommandType = CommandType.StoredProcedure
        '        cmd.Connection = class_Database.MySQLConnection
        '        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_brCode.Text)

        '        class_Database.OpenDB(ICSConnection)

        '        rs = cmd.ExecuteReader()
        '        ' Data is accessible through the DataReader object here.
        '        Do While rs.Read()
        '            Dim li As ListViewItem = lvUsers.Items.Add(rs.Item("fullname").ToString())
        '            li.SubItems.Add(rs.Item("designation").ToString())
        '            li.SubItems.Add(rs.Item("username").ToString())
        '        Loop
        '        'rs.Close()
        '        class_Database.MySQLConnection.close()
        '        GoTo outs1

        'out:    MsgBox(Err.Description)
        '        'rs.Close()
        '        class_Database.MySQLConnection.close()
        '        GoTo outs1

        'outs:
        'outs1:
    End Sub

    Private Sub checkShow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Sub FindUser()
        'On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminFindUser"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamUsername", txt_username.EditValue)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            cmb_Branch.EditValue = rs.Item("branchcode").ToString()
            cmb_Branch.Text = rs.Item("branchcode").ToString
            txt_username.EditValue = rs.Item("username").ToString()
            txt_FName.Text = rs.Item("fname").ToString()
            txt_MI.Text = rs.Item("mi").ToString()
            txt_LName.Text = rs.Item("lname").ToString()
            txt_Designation.Text = rs.Item("designation").ToString()
            CheckIsApprover.Checked = rs.Item("IsApprover").ToString()
            CheckIsAdmin.Checked = rs.Item("IsAdmin").ToString()
            CheckIsAccounting.Checked = rs.Item("IsAccounting").ToString()
            CheckIsAudit.Checked = rs.Item("IsAudit").ToString()
            CheckIsMaintenance.Checked = rs.Item("IsMaintenance").ToString()
            CheckIsBookkeeper.Checked = rs.Item("IsBookkeeper").ToString()
            CheckIsNewAccounts.Checked = rs.Item("IsNewAccounts").ToString()
            CheckIsRelease.Checked = rs.Item("IsRelease").ToString()
            CheckIsCollection.Checked = rs.Item("IsCollection").ToString()
            CheckIsInventory.Checked = rs.Item("IsInventory").ToString()
            CheckIsCashier.Checked = rs.Item("IsCashier").ToString()
            CheckIsReceptionist.Checked = rs.Item("IsReceptionist").ToString()
            CheckIsLogistics.Checked = rs.Item("IsLogistics").ToString()

            CheckIsSpareParts.Checked = rs.Item("IsInventorySP").ToString()
            CheckIsSuperUser.Checked = rs.Item("IsSuperUser").ToString()

            CheckIsAllowedBackDate.Checked = rs.Item("IsAllowedBackDate").ToString()
            CheckIsReports.Checked = rs.Item("IsReports").ToString()
        End If
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Sub FindUserPass()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_FindUserPass"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamUsername", txt_username.EditValue)
        cmd.Parameters.AddWithValue("@ParamLoggedUser", MainMenu.App_User_Name.Caption)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            txt_pass.Text = Decrypt(rs.Item("PassDecrypted").ToString())
        End If
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Sub RegisterUser()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminRegisterUser"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", cmb_Branch.EditValue)
        cmd.Parameters.AddWithValue("@ParamUsername", txt_username.EditValue)
        cmd.Parameters.AddWithValue("@Parampassword", Encrypt(txt_pass.Text))
        cmd.Parameters.AddWithValue("@ParamFirstName", txt_FName.Text)
        cmd.Parameters.AddWithValue("@ParamMI", txt_MI.Text)
        cmd.Parameters.AddWithValue("@ParamLastName", txt_LName.Text)
        cmd.Parameters.AddWithValue("@ParamDesignation", txt_Designation.Text)
        cmd.Parameters.AddWithValue("@ParamIsApprover", CheckIsApprover.Checked)
        cmd.Parameters.AddWithValue("@ParamIsAdmin", CheckIsAdmin.Checked)
        cmd.Parameters.AddWithValue("@ParamIsAccounting", CheckIsAccounting.Checked)
        cmd.Parameters.AddWithValue("@ParamIsAudit", CheckIsAudit.Checked)
        cmd.Parameters.AddWithValue("@ParamIsMaintenance", CheckIsMaintenance.Checked)
        cmd.Parameters.AddWithValue("@ParamIsBookkeeper", CheckIsBookkeeper.Checked)
        cmd.Parameters.AddWithValue("@ParamIsNewAccounts", CheckIsNewAccounts.Checked)
        cmd.Parameters.AddWithValue("@ParamIsRelease", CheckIsRelease.Checked)
        cmd.Parameters.AddWithValue("@ParamIsCollection", CheckIsCollection.Checked)
        cmd.Parameters.AddWithValue("@ParamIsInventory", CheckIsInventory.Checked)
        cmd.Parameters.AddWithValue("@ParamIsCashier", CheckIsCashier.Checked)
        cmd.Parameters.AddWithValue("@ParamIsReceptionist", CheckIsReceptionist.Checked)
        cmd.Parameters.AddWithValue("@ParamIsLogistics", CheckIsLogistics.Checked)

        cmd.Parameters.AddWithValue("@ParamIsSuperUser", CheckIsSuperUser.Checked)
        cmd.Parameters.AddWithValue("@ParamIsInventorySP", CheckIsSpareParts.Checked)

        cmd.Parameters.AddWithValue("@ParamIsAllowedBackDate", CheckIsAllowedBackDate.Checked)
        cmd.Parameters.AddWithValue("@ParamIsReports", CheckIsReports.Checked)

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

    Sub ModifyUser()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminModifyUser"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", cmb_Branch.EditValue)
        cmd.Parameters.AddWithValue("@ParamUsername", txt_username.EditValue)
        cmd.Parameters.AddWithValue("@Parampassword", Encrypt(txt_pass.Text))
        cmd.Parameters.AddWithValue("@ParamFirstName", txt_FName.Text)
        cmd.Parameters.AddWithValue("@ParamMI", txt_MI.Text)
        cmd.Parameters.AddWithValue("@ParamLastName", txt_LName.Text)
        cmd.Parameters.AddWithValue("@ParamDesignation", txt_Designation.Text)
        cmd.Parameters.AddWithValue("@ParamIsApprover", CheckIsApprover.Checked)
        cmd.Parameters.AddWithValue("@ParamIsAdmin", CheckIsAdmin.Checked)
        cmd.Parameters.AddWithValue("@ParamIsAccounting", CheckIsAccounting.Checked)
        cmd.Parameters.AddWithValue("@ParamIsAudit", CheckIsAudit.Checked)
        cmd.Parameters.AddWithValue("@ParamIsMaintenance", CheckIsMaintenance.Checked)
        cmd.Parameters.AddWithValue("@ParamIsBookkeeper", CheckIsBookkeeper.Checked)
        cmd.Parameters.AddWithValue("@ParamIsNewAccounts", CheckIsNewAccounts.Checked)
        cmd.Parameters.AddWithValue("@ParamIsRelease", CheckIsRelease.Checked)
        cmd.Parameters.AddWithValue("@ParamIsCollection", CheckIsCollection.Checked)
        cmd.Parameters.AddWithValue("@ParamIsInventory", CheckIsInventory.Checked)
        cmd.Parameters.AddWithValue("@ParamIsCashier", CheckIsCashier.Checked)
        cmd.Parameters.AddWithValue("@ParamIsReceptionist", CheckIsReceptionist.Checked)
        cmd.Parameters.AddWithValue("@ParamIsLogistics", CheckIsLogistics.Checked)

        cmd.Parameters.AddWithValue("@ParamIsSuperUser", CheckIsSuperUser.Checked)
        cmd.Parameters.AddWithValue("@ParamIsInventorySP", CheckIsSpareParts.Checked)

        cmd.Parameters.AddWithValue("@ParamPassUpdate", PassUpdate.Checked)
        cmd.Parameters.AddWithValue("@ParamLoggedUser", MainMenu.App_User_Name.Caption)

        cmd.Parameters.AddWithValue("@ParamIsAllowedBackDate", CheckIsAllowedBackDate.Checked)
        cmd.Parameters.AddWithValue("@ParamIsReports", CheckIsReports.Checked)

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

    Private Sub cmb_Branch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Branch.TextChanged
         mg_ShowAUsers()
    End Sub

    Sub clear_txt()
        txt_username.Text = String.Empty
        txt_pass.Text = String.Empty
        txt_FName.Text = String.Empty
        txt_MI.Text = String.Empty
        txt_LName.Text = String.Empty
        txt_Designation.Text = String.Empty
        CheckIsApprover.Checked = False
        CheckIsAdmin.Checked = False
        CheckIsAccounting.Checked = False
        CheckIsAudit.Checked = False
        CheckIsMaintenance.Checked = False
        CheckIsBookkeeper.Checked = False
        CheckIsNewAccounts.Checked = False
        CheckIsRelease.Checked = False
        CheckIsCollection.Checked = False
        CheckIsInventory.Checked = False
        CheckIsCashier.Checked = False
        CheckIsReceptionist.Checked = False
        CheckIsLogistics.Checked = False
        CheckIsSuperUser.Checked = False
        CheckIsSpareParts.Checked = False
        CheckIsAllowedBackDate.Checked = False
        CheckIsReports.Checked = False
    End Sub

    Private Sub toolNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_New.ItemClick
         clear_txt()
        Btn_Update.Enabled = False
        Btn_New.Enabled = True
    End Sub

    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged
        ' FindUser()

        'Btn_Update.Enabled = True
        'Btn_New.Enabled = False
    End Sub

    Private Sub txt_username_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_username.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '     FindUser()
        '    Btn_Update.Enabled = True
        'End If
    End Sub

    Private Sub cmd_ResetAll_Click(sender As Object, e As EventArgs) Handles cmd_ResetAll.Click
         ShowAllUsers()

    End Sub

    Sub ShowAllUsers()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminShowAllUser"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        Do While rs.Read
            txt_username2Reset.Text = rs.Item("username").ToString

            ' MsgBox(txt_username2Reset.Text)
        Loop

out:

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Sub mg_AdminShowAllModPass()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs2 As SqlDataReader

        cmd.CommandText = "mg_AdminShowAllModPass"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamUsername", txt_username2Reset.Text)
        cmd.Parameters.AddWithValue("@ParamPassword", txt_Pass2Reset.Text)

        class_Database.mySQLConnection.Open()
        rs2 = cmd.ExecuteReader()
        If rs2.Read Then

        End If
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

outs:
outs1:  rs2.Close()
        class_Database.mySQLConnection.Close()

    End Sub

    Private Sub txt_username2Reset_TextChanged(sender As Object, e As EventArgs) Handles txt_username2Reset.TextChanged
        txt_Pass2Reset.Text = Encrypt(txt_username2Reset.Text)
         mg_AdminShowAllModPass()

    End Sub

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged

    End Sub

    Private Sub txt_pass_DoubleClick(sender As Object, e As EventArgs) Handles txt_pass.DoubleClick
        If txt_pass.Properties.PasswordChar = "*" Then
            txt_pass.Properties.PasswordChar = String.Empty
             FindUserPass()
        Else
            txt_pass.Properties.PasswordChar = "*"
        End If
    End Sub

    Private Sub Admin_UserManagement_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)

        Initialize_IntransitBranch()
        Initialize_IntransitBranch(cmb_Branch)

    End Sub

    Private Sub Btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Update.ItemClick
         ModifyUser()

         clear_txt()
        Btn_Update.Enabled = False
        Btn_Save.Enabled = True
    End Sub

    Private Sub Btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Save.ItemClick
         RegisterUser()

         clear_txt()
        Btn_Update.Enabled = True
        Btn_Save.Enabled = False
    End Sub

    Private Sub txt_username_EditValueChanged(sender As Object, e As EventArgs) Handles txt_username.EditValueChanged
        FindUser()
    End Sub

End Class