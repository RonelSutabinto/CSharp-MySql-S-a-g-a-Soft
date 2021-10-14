Public Class SplashScreen1

    Sub New()
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Private Sub SplashScreen1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        label_ProductVersion.Text = $"{Application.ProductName} {Application.ProductVersion}"
    End Sub

End Class