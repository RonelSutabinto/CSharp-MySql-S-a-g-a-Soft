Public Class splashes
    Dim i As Double = 0.01
    Dim iFadeOut As Double = 5

    Private Sub tmrFadeIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFadeIn.Tick
        i += 0.05
        If i >= 1.5 Then
            Me.Opacity = 1
            tmrFadeIn.Enabled = False
            tmrFadeOut.Enabled = True
            Return
        End If
        Me.Opacity = i
    End Sub

    Private Sub tmrFadeOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFadeOut.Tick

        iFadeOut -= 1
        If iFadeOut <= 0.01 Then
            Me.Opacity = 0.0
            ' tmrFadeIn.Enabled = True
            tmrFadeOut.Enabled = False
            ' MsgBox(Me.Opacity.ToString)
            'Return
        End If
        Me.Opacity = iFadeOut

    End Sub

    Private Sub splashes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        tmrFadeIn.Enabled = True
        tmrFadeOut.Enabled = False
        'Login.ipaddress.Text = GetIP()
    End Sub

End Class