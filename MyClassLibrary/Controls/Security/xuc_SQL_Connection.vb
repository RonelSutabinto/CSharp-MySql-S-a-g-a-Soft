Imports MyClassLibrary.Classes
Imports System.IO
Imports System.Net

Namespace Controls.Security

    Public Class Xuc_SQL_Connection
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Function connect_Server_Test() As Boolean

            class_Procedures.splash_Show("verifying connection parameters", "Establishing Connection", True)
            If class_Database.OpenDB($"Data Source={name_Server.Text.Trim}; Initial Catalog={name_Database.Text.Trim}; Persist Security Info=True; Connect Timeout={timeOut.Text.Trim}; User ID={name_User.Text.Trim}; Password={password.Text.Trim}") Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "The connection to the server was successfully tested.")
                class_Procedures.splash_Close(True)
                Return True
            Else
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "The connection to the server was not successful. Please review and verify the connection parameters.", "Connection Error")
                class_Procedures.splash_Close(True)
                name_Server.Select()
                Return False
            End If
        End Function

        Public Function connect_Server() As Boolean

            class_Procedures.splash_Show("saving connection parameters", "Establishing Connection", True)
            Registry_Save()
            class_Database.Initialize_Connection()
            If class_Database.OpenDB(class_Database.ICSConnection) Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, class_Database.ICSConnectionTemp)
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "The connection parameters were applied and successfully connected to the server.")
                class_Procedures.splash_Close(True)
                Return True
            Else
                class_Procedures.Set_Message(class_Procedures.MsgMode.Sql, $"Server connection was not successful.{Environment.NewLine}Please review the connection parameters and test the connection again.")
                class_Procedures.splash_Close(True)
                Return False
            End If
        End Function

        Public Sub registry_Load()
            class_Database.Initialize_Connection()

            Try
                Server_Type.Text = class_Tools.RegKeyGet("Server Connection", "Type", "LOCAL MACHINE")
                password_Remember.Checked = class_Tools.RegKeyGet("Server Connection", "Remember", False)

                name_Server.Text = class_Database.SqlServer
                name_Database.Text = class_Database.SqlDatabase
                name_User.Text = class_Database.SqlUser
                password.Text = class_Database.SqlPassword
                timeOut.EditValue = class_Database.SqlTimeOut
                connection_String.Text = class_Database.ICSConnectionTemp
                update_Link.Text = class_Database.sUpdateLink
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Private Sub Registry_Save()
            Select Case Server_Type.Text
                Case "LOCAL MACHINE"
                    class_Database.bIsLocal = True
                    class_Tools.RegKeySet("Server Connection", "isLocal", True)
                Case "BACKUP SERVER"
                    class_Database.bIsLocal = False
                    class_Tools.RegKeySet("Server Connection", "isLocal", False)
                    class_Tools.RegKeySet("Server Connection", "Backup", class_Tools.Encrypt(name_Server.Text))
                Case "LOCAL NETWORK"
                    class_Database.bIsLocal = False
                    class_Tools.RegKeySet("Server Connection", "isLocal", False)
                    class_Tools.RegKeySet("Server Connection", "Local", class_Tools.Encrypt(name_Server.Text))
                Case "REMOTE IP"
                    class_Database.bIsLocal = False
                    class_Tools.RegKeySet("Server Connection", "isLocal", False)
                    class_Tools.RegKeySet("Server Connection", "Remote", class_Tools.Encrypt(name_Server.Text))
            End Select

            class_Tools.RegKeySet("Server Connection", "Type", Server_Type.Text)
            class_Tools.RegKeySet("Server Connection", "Server", class_Tools.Encrypt(name_Server.Text.Trim))
            class_Tools.RegKeySet("Server Connection", "Database", class_Tools.Encrypt(name_Database.Text.Trim))
            class_Tools.RegKeySet("Server Connection", "User Name", class_Tools.Encrypt(name_User.Text.Trim))
            class_Tools.RegKeySet("Server Connection", "Password", class_Tools.Encrypt(password.Text.Trim))
            class_Tools.RegKeySet("Server Connection", "Timeout", CInt(timeOut.Value))
            class_Tools.RegKeySet("Server Connection", "Remember", password_Remember.Checked)
            class_Tools.RegKeySet("Server Connection", "Update", update_Link.Text.Trim)
        End Sub

        Private Sub name_Server_Properties_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles name_Server.ButtonClick
            Select Case e.Button.Index
                Case 0
                    class_Connections.ping_Host(name_Server.Text, False)
                Case 1
                    class_Connections.ping_Host(name_Server.Text, True)
            End Select
        End Sub

        Private Sub Btn_Download_Click(sender As Object, e As EventArgs) Handles Btn_Download.Click
            'Create a WebClient.
            Dim request As New WebClient()

            ' Confirm the Network credentials based on the user name and password passed in.
            request.Credentials = New NetworkCredential(class_Database.SqlUser, class_Database.SqlPassword)

            Try
                class_Procedures.splash_Show("downloading Update",, True)
                'Read the file data into a Byte array
                Dim sFile As String = $"{update_Link.Text}/{Application.ProductName}.zip"
                Dim bytes() As Byte = request.DownloadData(sFile)

                '  Create a FileStream to read the file into
                Dim DownloadStream As FileStream = New FileStream(Application.StartupPath, FileMode.Create, FileAccess.Write)
                'Dim DownloadStream As FileStream = IO.File.Create(Application.StartupPath)
                '  Stream this data into the file
                DownloadStream.Write(bytes, 0, bytes.Length)
                '  Close the FileStream
                DownloadStream.Close()
            Catch Ex As DirectoryNotFoundException
                class_Procedures.Show_Error(Ex)
            Catch Ex As System.UnauthorizedAccessException
                class_Procedures.Show_Error(Ex)
            Catch Ex As System.Net.WebException
                class_Procedures.Show_Error(Ex)
            Finally
                class_Procedures.splash_Close(True)
            End Try
        End Sub

        Private Sub Server_Type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Server_Type.SelectedIndexChanged
            Select Case Server_Type.Text
                Case "LOCAL MACHINE"
                    class_Database.bIsLocal = True
                    name_Server.Text = Environment.MachineName
                Case "BACKUP SERVER"
                    class_Database.bIsLocal = False
                    name_Server.Text = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Backup", "127.0.0.1"), "127.0.0.1")
                Case "LOCAL NETWORK"
                    class_Database.bIsLocal = False
                    name_Server.Text = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Local", "localhost"), "localhost")
                Case "REMOTE IP"
                    class_Database.bIsLocal = False
                    name_Server.Text = class_Tools.Decrypt(class_Tools.RegKeyGet("Server Connection", "Remote", "127.0.0.1"), "127.0.0.1")
            End Select

            connection_String.Text = $"Data Source={class_Functions.maskString(name_Server.Text.Trim, 2, 2)};{Environment.NewLine} Initial Catalog={class_Functions.maskString(name_Database.Text.Trim, 0, 0)};{Environment.NewLine} Persist Security Info=True;{Environment.NewLine} Connect Timeout={timeOut.Value};{Environment.NewLine} User ID={class_Functions.maskString(name_User.Text.Trim, 0, 0)};{Environment.NewLine} Password={class_Functions.maskString(password.Text.Trim, 0, 0)};"

        End Sub

    End Class

End Namespace