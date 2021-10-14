Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes

Namespace Reports.Accounting

    Public Class xrpt_Voucher

        Private Sub xr_Journal_Group_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            XrLabel_Corporation.Text = class_Saga_Database.get_Corporation_Name(class_Saga_Variables.sCorporation)

            XrTC_Date.Text = class_Saga_Variables.dtEnd.ToString("MMMM dd, yyyy")

            Prepared_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Prepared_Personnel", String.Empty)

            Checked_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Checked_Personnel", String.Empty)

            Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
        End Sub

    End Class

End Namespace