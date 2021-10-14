Namespace Forms

    Public Class WaitForm1

        Sub New()
            InitializeComponent()
            Me.progressPanel.AutoHeight = True
        End Sub

        Public Overrides Sub SetCaption(ByVal caption As String)
            MyBase.SetCaption(caption)
            Me.progressPanel.Caption = caption
        End Sub

        Public Overrides Sub SetDescription(ByVal description As String)
            MyBase.SetDescription(description)
            Me.progressPanel.Description = description
        End Sub

        Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
            MyBase.ProcessCommand(cmd, arg)
        End Sub

    End Class

End Namespace