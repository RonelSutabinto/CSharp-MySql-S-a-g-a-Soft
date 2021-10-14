Imports MyClassLibrary.Classes
Public Class xrpt_SPA_Receive_Orders_Accounting_Yamaha

    Private Sub xrpt_Purchase_Orders_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Prepared_By.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Prepared_By", "Prepared By")
        Prepared_Personnel.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Prepared_Personnel", String.Empty)
        Prepared_Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Prepared_Position", String.Empty)

        Checked_Personnel.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Checked_Personnel", String.Empty)
        Checked_Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Checked_Position", String.Empty)

        Noted_By.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Noted_By", "Noted By")
        Noted_Personnel.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Noted_Personnel", String.Empty)
        Noted_Position.Text = class_Tools.RegKeyGet("Xuc_Printing_Detail", "Noted_Position", String.Empty)
    End Sub
End Class
