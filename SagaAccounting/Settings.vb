Partial Friend NotInheritable Class Settings

    Friend Sub New()
    End Sub

    Private Sub SettingChangingEventHandler(ByVal sender As Object, ByVal e As System.Configuration.SettingChangingEventArgs) Handles Me.SettingChanging

    End Sub

    Private Sub SettingsSavingEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.SettingsSaving

    End Sub

End Class