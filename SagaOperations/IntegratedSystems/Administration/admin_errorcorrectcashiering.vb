Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class admin_errorcorrectcashiering
    Private Sub informationtool_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles informationtool.Click
        IS_Sales_FindCust.Text = "ERRORCORRECT-CASHIERING"
        IS_Sales_FindCust.ShowDialog()
    End Sub

    Sub mg_AdminCashieringCancel()
        If MsgBox("Do you want to delete this Data??", vbYesNo, Application.CompanyName) = vbYes Then
            Dim Parameters As SqlParameter() =
            {
                New SqlParameter("@ParamCIFKey", txt_cifkey.Text),
                New SqlParameter("@ParamPostingDate", releasedDate.Value),
                New SqlParameter("@ParamRefNo", txt_refno.Text),
                New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_AdminCashieringCancel")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    MsgBox(myDataReader.Item("Message").ToString())
                End If
            End Using
        End If
    End Sub

    Private Sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        If txt_refno.Text = String.Empty Then
            MsgBox("Please input Reference / OR Number", vbInformation, Application.CompanyName)
            Return
        End If
        mg_AdminCashieringCancel()
    End Sub
End Class