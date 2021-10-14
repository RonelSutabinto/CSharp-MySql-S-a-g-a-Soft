
Imports MyClassLibrary.Classes

Namespace SagaSpareParts

    Public Class xrpt_SPA_Purchase_Orders

        Private Sub xrpt_SPA_Purchase_Orders_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            Prepared_By.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Prepared_By", "Prepared By")
            Prepared_Personnel.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Prepared_Personnel", String.Empty)
            Prepared_Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Prepared_Position", String.Empty)

            Checked_Personnel.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Checked_Personnel", String.Empty)
            Checked_Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Checked_Position", String.Empty)

            Approved_By.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Approved_By", "Approved By")
            Approved_Personnel.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Approved_Personnel", String.Empty)
            Approved_Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Approved_Position", String.Empty)

            'Recommend.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Recommended_Personnel", String.Empty)
            'Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Recommended_Position", String.Empty)

            Verified_By.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Verified_By", "Verified By")
            Verified_Personnel.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Verified_Personnel", String.Empty)
            Verified_Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Verified_Position", String.Empty)
        End Sub
    End Class
End Namespace
