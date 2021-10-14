Imports System.Net

Public Class splashes
    Dim i As Double = 0.01
    Dim iFadeOut As Double = 5

    private sub tmrFadeIn_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFadeIn.Tick
        i += 0.05
        If i >= 1.5 Then
            Me.Opacity = 1
            tmrFadeIn.Enabled = False
            tmrFadeOut.Enabled = True
            Return
        End If
        Me.Opacity = i
    End Sub

    private sub tmrFadeOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFadeOut.Tick

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

    private sub splashes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Opacity = 0
        tmrFadeIn.Enabled = True
        tmrFadeOut.Enabled = False
        'Login.ipaddress.Text = GetIP()
    End Sub

    Function GetIP() As String

        Dim IP As New WebClient

        Return IP.DownloadString("http://bot.whatismyipaddress.com")
        'serverStatus.Text = "ONLINE"

        MsgBox("Please check your internet Connection!", vbCritical, Application.CompanyName)
        ' serverStatus.Text = "OFFLINE"
        '



    End Function

End Class