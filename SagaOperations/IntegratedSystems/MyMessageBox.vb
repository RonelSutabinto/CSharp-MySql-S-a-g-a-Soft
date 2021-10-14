
Public Class MyMessagebox

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub MyMessagebox_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub OK_Button_Click(sender As System.Object, e As System.EventArgs) Handles OK_Button.Click
        Me.Close()
        ' Me.DialogResult = System.Windows.Forms.DialogResult.OK
        'class_Database.mySQLConnection.Close()

        ' IS_Inventory_List.ShowDialog()

    End Sub

End Class