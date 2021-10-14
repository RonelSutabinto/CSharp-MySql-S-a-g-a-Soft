Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Forms.Security

    Public Class frm_Password_Change
        Friend sCorporation, sUserName As String
        Friend bNeedOldPassword As Boolean

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btn_Close_Click(sender As Object, e As System.EventArgs) Handles btn_Close.Click
            Dispose()
        End Sub

        Private Sub frm_Password_Change_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Password_Old.Enabled = bNeedOldPassword
        End Sub

        Private Function save_New_Password() As Boolean
            If bNeedOldPassword AndAlso class_Procedures.isEmpty(Password_Old) Then Return False
            If class_Procedures.isEmpty(Password_New) Then Return False

            If Not Password_New.Text.Equals(Password_Confirm.Text) Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "New password was not successfully confirmed.", "Confirmation Error", True)
                Password_New.Select()
                Return False
            End If

            Dim sActionType As String
            If bNeedOldPassword Then
                sActionType = "CHANGE"
                If Not class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT username, mypassword FROM Users WHERE username LIKE '{sUserName}' AND mypassword LIKE '{class_Tools.Encrypt(Password_Old.Text.Trim)}'") Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Please input your Old Password.", "Password Error", True)
                    Password_Old.SelectAll()
                    Return False
                End If
            Else
                sActionType = "RESET"
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Corporation", sCorporation),
                New SqlParameter("@Username", sUserName),
                New SqlParameter("@Password", class_Tools.Encrypt(Password_Old.Text.Trim)),
                New SqlParameter("@PasswordNew", class_Tools.Encrypt(Password_New.Text.Trim)),
                New SqlParameter("@Action_Type", sActionType)
            }

            If class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_User_Procedures", "Update User Password", sUserName) Then
                If Not bNeedOldPassword Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"User Password has been successfully Reset.{Environment.NewLine}Please don't forget your new password or contact IT Department for further information.", "Change Password", True)
                Else
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "New user password has been successfully changed", "Password Changed", True)
                End If
                Dispose()
                Return True
            End If
            Return False
        End Function

        Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
            If save_New_Password() Then
                class_Procedures.Form_Close(Me)
            End If
        End Sub

    End Class

End Namespace