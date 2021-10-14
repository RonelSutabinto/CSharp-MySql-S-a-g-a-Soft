Public Class FrmSplash
    Sub New
        InitializeComponent()
        Me.labelCopyright.Text = "Copyright © 2018-" & DateTime.Now.Year.ToString()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub FrmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
