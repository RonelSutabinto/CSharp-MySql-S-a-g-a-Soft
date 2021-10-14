Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Namespace Reports.Accounting
    Public Class xrpt_FS
        Private Sub xrpt_FS_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            'Corporation.Text = class_Saga_Variables.sCorporation
            'Date_Covered.Text = $"{class_Saga_Variables.dtStart:MMMM dd, yyyy} to {class_Saga_Variables.dtEnd:MMMM dd, yyyy}"

            Prepared_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Prepared_Personnel", String.Empty)
            Prepared_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Prepared_Position", String.Empty)

            Checked_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Checked_Personnel", String.Empty)
            Checked_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Checked_Position", String.Empty)

            Noted_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Noted_Personnel", String.Empty)
            Noted_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Noted_Position", String.Empty)

            Approved_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Approved_Personnel", String.Empty)
            Approved_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Approved_Position", String.Empty)

            Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
        End Sub
    End Class
End Namespace