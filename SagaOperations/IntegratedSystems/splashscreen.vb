Public Class splashes

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs)
        End
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs)
        MsgBox("Contact Melvin!", vbInformation, "")
    End Sub

    Private Sub tmrFadeIn_Tick(sender As System.Object, e As System.EventArgs) Handles tmrFadeIn.Tick
        Me.Opacity = Me.Opacity + 0.01
        If Me.Opacity = 1 Then
            tmrFadeIn.Enabled = False
            tmrWait.Enabled = True
        End If
    End Sub

    Private Sub tmrWait_Tick(sender As System.Object, e As System.EventArgs) Handles tmrWait.Tick
        tmrFadeOut.Enabled = True
        tmrFadeIn.Enabled = False
    End Sub

    Private Sub tmrFadeOut_Tick(sender As System.Object, e As System.EventArgs) Handles tmrFadeOut.Tick
        'Me.Opacity = Me.Opacity - 0.01
        'If Me.Opacity < 0.01 Then
        '    End
        'End If
    End Sub
End Class