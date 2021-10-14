Imports MyClassLibrary.Classes
Namespace SagaSpareParts

    Public Class xrpt_SPA_Request

        Private Sub xrpt_SPA_Request_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            Prepared_By.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Prepared_By", "Prepared By")
            Prepared_Personnel.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Prepared_Personnel", String.Empty)
            Prepared_Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Prepared_Position", String.Empty)

            Approved_By.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Approved_By", "Approved By")
            Approved_Personnel.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Approved_Personnel", String.Empty)
            Approved_Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Approved_Position", String.Empty)
        End Sub
    End Class
End Namespace
