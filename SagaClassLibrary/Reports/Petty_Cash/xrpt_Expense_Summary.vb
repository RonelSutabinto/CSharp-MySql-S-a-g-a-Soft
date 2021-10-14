
Imports MyClassLibrary.Classes

Namespace Reports.Petty_Cash

    Public Class xrpt_Expense_Summary
        Private Sub xrpt_Expense_Summary_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
            Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
        End Sub
    End Class

End Namespace