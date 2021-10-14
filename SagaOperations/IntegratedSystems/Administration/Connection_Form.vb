Public Class Connection_Form

    Private Sub Connection_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSaveConnection_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveConnection.Click
        'If newCheckConnection(txtServer.Text, txtDatabaseName.Text, txtUserName.Text, txtPassword.Text) Then

        '    Login.User_Name.Text = Decrypt(RegKeyGet("Username", "Username", String.Empty))

        '    RegKeySet("HostServer", "HostServer", Encrypt(txtServer.Text))
        '    RegKeySet("Dbase", "DataBaseName", Encrypt(txtDatabaseName.Text))
        '    RegKeySet("DBaseUname", "DataBaseUserName", Encrypt(txtUserName.Text))
        '    RegKeySet("DBasePassword", "DataBasePassWord", Encrypt(txtPassword.Text))

        '    MsgBox("Connection successfull!", vbInformation, "webSources")
        '     Login.InitiliazeLogin()
        '    Login.Show()
        '    Me.Close()
        'Else
        '    MsgBox("Connection failed!", vbCritical, "webSources")
        'End If
    End Sub

    Private Sub cmd_showmasked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_showmasked.Click
        If txtServer.PasswordChar = String.Empty Or txtDatabaseName.PasswordChar = String.Empty Or txtUserName.PasswordChar = String.Empty Or txtPassword.PasswordChar = String.Empty Then
            txtServer.PasswordChar = "*"
            txtDatabaseName.PasswordChar = "*"
            txtUserName.PasswordChar = "*"
            txtPassword.PasswordChar = "*"
        Else
            txtServer.PasswordChar = String.Empty
            txtDatabaseName.PasswordChar = String.Empty
            txtUserName.PasswordChar = String.Empty
            txtPassword.PasswordChar = String.Empty
        End If

    End Sub

    Private Sub txtUserName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUserName.KeyDown
        If e.KeyCode = Keys.PageDown Then
            txtServer.Visible = True
        End If
    End Sub

    Private Sub ServerList_TextChanged(sender As Object, e As EventArgs) Handles ServerList.TextChanged
        If ServerList.Text = "Public.Network.1" Then
            txtServer.Text = "122.3.54.38"
        ElseIf ServerList.Text = "Public.Network.2" Then
            txtServer.Text = "124.107.148.186"
        ElseIf ServerList.Text = "(local)" Then
            txtServer.Text = "(local)"
        ElseIf ServerList.Text = "Private.Network" Then
            txtServer.Text = "192.168.13.15"
        End If
    End Sub

End Class