Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Public Class xrpt_Trial_Balance

    Private Sub xr_Journal_Group_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        XrTableCell_Corporation.Text = class_Saga_Variables.sCorporation

        XrTableCell_Prepared_By.Text = class_Tools.RegKeyGet("Printing Details", "Prepared By", String.Empty)
        XrTableCell_Checked_By.Text = class_Tools.RegKeyGet("Printing Details", "Checked By", String.Empty)
        XrTableCell_Approved_By.Text = class_Tools.RegKeyGet("Printing Details", "Approved By", String.Empty)

        Product_Version.Text = $"{Application.ProductName} - {Application.ProductVersion}"
    End Sub

End Class