Namespace Forms

    Public Class XtraForm1

        Private Sub AlertControl_AlertClick(sender As Object, e As DevExpress.XtraBars.Alerter.AlertClickEventArgs) Handles AlertControl.AlertClick
            Classes.class_Procedures.Copy_Clipboard(e.Info.Text)
        End Sub

    End Class

End Namespace