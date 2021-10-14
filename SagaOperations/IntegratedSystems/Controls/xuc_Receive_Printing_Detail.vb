Imports MyClassLibrary.Classes
Namespace Controls

    Public Class xuc_Receive_Printing_Detail

        Private Sub Xuc_Printing_Detail_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
            Prepared_By.Text = class_Tools.RegKeyGet(Me.Name, "Prepared_By", "Prepared By")
            Prepared_Personnel.Text = class_Tools.RegKeyGet(Me.Name, "Prepared_Personnel", String.Empty)
            Prepared_Position.Text = class_Tools.RegKeyGet(Me.Name, "Prepared_Position", String.Empty)

            Received_By.Text = class_Tools.RegKeyGet(Me.Name, "Verified_By", "Verified By")
            Received_Personnel.Text = class_Tools.RegKeyGet(Me.Name, "Verified_Personnel", String.Empty)
            Received_Position.Text = class_Tools.RegKeyGet(Me.Name, "Verified_Position", String.Empty)

            Approved_By.Text = class_Tools.RegKeyGet(Me.Name, "Approved_By", "Approved By")
            Approved_Personnel.Text = class_Tools.RegKeyGet(Me.Name, "Approved_Personnel", String.Empty)
            Approved_Position.Text = class_Tools.RegKeyGet(Me.Name, "Approved_Position", String.Empty)

            Remarks.Text = class_Tools.RegKeyGet(Me.Name, Remarks.Name, String.Empty)
        End Sub

        Private Sub Prepared_By_EditValueChanged(sender As Object, e As System.EventArgs) Handles Prepared_By.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Prepared_By", Prepared_By.Text)
        End Sub

        Private Sub Prepared_Personnel_EditValueChanged(sender As Object, e As System.EventArgs) Handles Prepared_Personnel.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Prepared_Personnel", Prepared_Personnel.Text.ToUpper)
        End Sub

        Private Sub Prepared_Position_EditValueChanged(sender As Object, e As System.EventArgs) Handles Prepared_Position.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Prepared_Position", Prepared_Position.Text)
        End Sub

        Private Sub Received_By_EditValueChanged(sender As Object, e As System.EventArgs) Handles Received_By.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Received_By", Received_By.Text)
        End Sub

        Private Sub Received_Personnel_EditValueChanged(sender As Object, e As System.EventArgs) Handles Received_Personnel.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Received_Personnel", Received_Personnel.Text.ToUpper)
        End Sub

        Private Sub Received_Position_EditValueChanged(sender As Object, e As System.EventArgs) Handles Received_Position.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Received_Position", Received_Position.Text)
        End Sub

        Private Sub Approved_By_EditValueChanged(sender As Object, e As System.EventArgs) Handles Approved_By.EditValueChanged
            class_Tools.RegKeySet(Me.Name, "Approved_By", Approved_By.Text)
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