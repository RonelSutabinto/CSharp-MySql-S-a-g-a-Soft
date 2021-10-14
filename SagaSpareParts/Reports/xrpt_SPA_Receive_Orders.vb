Imports MyClassLibrary.Classes
Public Class xrpt_SPA_Receive_Orders

    Private Sub xrpt_Purchase_Orders_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Prepared_By.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Prepared_By", "Prepared By")
        Prepared_Personnel.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Prepared_Personnel", String.Empty)
        Prepared_Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Prepared_Position", String.Empty)

        Approved_Personnel.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Approved_Personnel", String.Empty)
        Approved_Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Approved_Position", String.Empty)

        Verified_By.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Received_By", "Received By")
        Verified_Personnel.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Verified_Personnel", String.Empty)
        Verified_Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Verified_Position", String.Empty)
    End Sub
End Class
