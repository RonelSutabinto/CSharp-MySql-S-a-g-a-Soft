Public Class IS_Sales_RedeemOrNot

    Private Sub txt_pulloutInv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pulloutInv.CheckedChanged
        If txt_pulloutInv.Checked = True Then
            IS_Sales_Payments.txt_pullout.Text = "PullOut"
        Else
            IS_Sales_Payments.txt_pullout.Text = "NONE"
        End If
    End Sub

    Private Sub cmd_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ok.Click
        Me.Close()
    End Sub
End Class