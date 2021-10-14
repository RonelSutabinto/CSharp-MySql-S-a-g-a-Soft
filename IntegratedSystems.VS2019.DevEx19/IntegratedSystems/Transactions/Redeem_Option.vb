Public Class Redeem_Option

    private sub txt_pulloutInv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pulloutInv.CheckedChanged
        If txt_pulloutInv.Checked = True Then
            MC_Collection.txt_pullout.Text = "PullOut"
        Else
            MC_Collection.txt_pullout.Text = "NONE"
        End If
    End Sub

    private sub cmd_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ok.Click
        Me.Close()
    End Sub
End Class