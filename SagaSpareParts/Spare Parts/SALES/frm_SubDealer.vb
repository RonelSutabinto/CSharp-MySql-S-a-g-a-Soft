Public Class frm_SubDealer

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        Uc_SubDealer.control_Save()
        Uc_SubDealer.control_Clear()
    End Sub

End Class