Imports MyClassLibrary.Classes

Namespace Controls.Persons

    Public Class xuc_Printing_Detail

        Private Sub xuc_Printing_Detail_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
            Prepared_Personnel.Text = class_Tools.RegKeyGet(Me.Name, "Prepared_Personnel", String.Empty)
            Prepared_Position.Text = class_Tools.RegKeyGet(Me.Name, "Prepared_Position", String.Empty)

            Checked_Personnel.Text = class_Tools.RegKeyGet(Me.Name, "Checked_Personnel", String.Empty)
            Checked_Position.Text = class_Tools.RegKeyGet(Me.Name, "Checked_Position", String.Empty)

            Verified_Personnel.Text = class_Tools.RegKeyGet(Me.Name, "Verified_Personnel", String.Empty)
            Verified_Position.Text = class_Tools.RegKeyGet(Me.Name, "Verified_Position", String.Empty)

            Noted_Personnel.Text = class_Tools.RegKeyGet(Me.Name, "Noted_Personnel", String.Empty)
            Noted_Position.Text = class_Tools.RegKeyGet(Me.Name, "Noted_Position", String.Empty)

            Recommended_Personnel.Text = class_Tools.RegKeyGet(Me.Name, "Recommended_Personnel", String.Empty)
            Recommended_Position.Text = class_Tools.RegKeyGet(Me.Name, "Recommended_Position", String.Empty)

            Approved_Personnel.Text = class_Tools.RegKeyGet(Me.Name, "Approved_Personnel", String.Empty)
            Approved_Position.Text = class_Tools.RegKeyGet(Me.Name, "Approved_Position", String.Empty)

            Remarks.Text = class_Tools.RegKeyGet(Me.Name, Remarks.Name, String.Empty)
        End Sub

        Private Sub Prepared_Personnel_EditValueChanged(sender As Object, e As System.EventArgs) Handles Prepared_Personnel.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Prepared_Personnel", Prepared_Personnel.Text.ToUpper)
        End Sub

        Private Sub Prepared_Position_EditValueChanged(sender As Object, e As System.EventArgs) Handles Prepared_Position.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Prepared_Position", Prepared_Position.Text)
        End Sub

        Private Sub Checked_Personnel_EditValueChanged(sender As Object, e As System.EventArgs) Handles Checked_Personnel.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Checked_Personnel", Checked_Personnel.Text.ToUpper)
        End Sub

        Private Sub Checked_Position_EditValueChanged(sender As Object, e As System.EventArgs) Handles Checked_Position.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Checked_Position", Checked_Position.Text)
        End Sub

        Private Sub Verified_Personnel_EditValueChanged(sender As Object, e As System.EventArgs) Handles Verified_Personnel.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Verified_Personnel", Verified_Personnel.Text.ToUpper)
        End Sub

        Private Sub Verified_Position_EditValueChanged(sender As Object, e As System.EventArgs) Handles Verified_Position.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Verified_Position", Verified_Position.Text)
        End Sub

        Private Sub Noted_Personnel_EditValueChanged(sender As Object, e As System.EventArgs) Handles Noted_Personnel.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Noted_Personnel", Noted_Personnel.Text.ToUpper)
        End Sub

        Private Sub Noted_Position_EditValueChanged(sender As Object, e As System.EventArgs) Handles Noted_Position.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Noted_Position", Noted_Position.Text)
        End Sub

        Private Sub Recommended_Personnel_EditValueChanged(sender As Object, e As System.EventArgs) Handles Recommended_Personnel.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Recommended_Personnel", Recommended_Personnel.Text.ToUpper)
        End Sub

        Private Sub Recommended_Position_EditValueChanged(sender As Object, e As System.EventArgs) Handles Recommended_Position.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Recommended_Position", Recommended_Position.Text)
        End Sub

        Private Sub Approved_Personnel_EditValueChanged(sender As Object, e As System.EventArgs) Handles Approved_Personnel.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Approved_Personnel", Approved_Personnel.Text.ToUpper)
        End Sub

        Private Sub Approved_Position_EditValueChanged(sender As Object, e As System.EventArgs) Handles Approved_Position.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Approved_Position", Approved_Position.Text)
        End Sub

        Private Sub Remarks_EditValueChanged(sender As Object, e As System.EventArgs) Handles Remarks.EditValueChanged
            class_Tools.RegKeySet(Me.Name, Remarks.Name, Remarks.Text)
        End Sub

    End Class

End Namespace