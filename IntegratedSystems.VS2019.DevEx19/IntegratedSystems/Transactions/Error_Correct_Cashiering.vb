Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Error_Correct_Cashiering
    private sub informationtool_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles informationtool.Click
        IS_Sales_FindCust.Text = "ERRORCORRECT-CASHIERING"
        IS_Sales_FindCust.ShowDialog()
    End Sub

    private sub mg_AdminCashieringCancel()
        If MsgBox("Do you want to delete this Data??", vbYesNo, Application.CompanyName) = vbYes Then
            Dim sqlParameters As SqlParameter() =
            {
                New SqlParameter("@ParamCIFKey", txt_cifkey.Text),
                New SqlParameter("@ParamPostingDate", releasedDate.Value),
                New SqlParameter("@ParamRefNo", txt_refno.Text),
                New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode)
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_AdminCashieringCancel")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    MsgBox(myDataReader.Item("Message").ToString())
                End If
            End Using
        End If
    End Sub

    private sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        If txt_refno.Text = String.Empty Then
            MsgBox("Please input Reference / OR Number", vbInformation, Application.CompanyName)
            Return
        End If
        mg_AdminCashieringCancel()
    End Sub
End Class