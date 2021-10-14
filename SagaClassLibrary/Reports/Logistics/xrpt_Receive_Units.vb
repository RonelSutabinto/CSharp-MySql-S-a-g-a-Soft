﻿Imports MyClassLibrary.Classes

Namespace Reports.Logistics

    Public Class xrpt_Receive_Units

        Private Sub xrpt_Receive_Units_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            Prepared_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Prepared_Personnel", String.Empty)
            Prepared_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Prepared_Position", String.Empty)

            Approved_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Approved_Personnel", String.Empty)
            Approved_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Approved_Position", String.Empty)

            Verified_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Verified_Personnel", String.Empty)
            Verified_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Verified_Position", String.Empty)

            'Checked_Personnel.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Checked_Personnel", String.Empty)
            'Checked_Position.Text = class_Tools.RegKeyGet("xuc_Printing_Detail", "Checked_Position", String.Empty)

            Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
        End Sub
    End Class
End Namespace