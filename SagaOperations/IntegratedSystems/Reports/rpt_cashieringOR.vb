Public Class rpt_cashieringOR
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim H As Integer = 0
        H = 40
        e.Graphics.DrawString("ACTUAL COLLECTION", New Drawing.Font("Calibri", 14), Brushes.Black, 50, H)
        H += 30
        e.Graphics.DrawString("BRANCH CODE:", New Drawing.Font("Calibri", 12), Brushes.Black, 50, H)
    End Sub

End Class