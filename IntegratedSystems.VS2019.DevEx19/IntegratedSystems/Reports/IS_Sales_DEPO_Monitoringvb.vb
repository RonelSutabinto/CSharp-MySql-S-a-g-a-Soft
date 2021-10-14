Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Sales_DEPO_Monitoringvb

    private sub ShowDepoAccts()
        cmb_transactions.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", "001"),
            New SqlParameter("@ParamPostingDate", "03/31/2018"),
            New SqlParameter("@ParamAECode", String.Empty),
            New SqlParameter("@ParamAcctStatus", "Overdue")
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_Generate_Aging")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItems.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountName").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountStatus").ToString())
                    li.SubItems.Add(myDataReader.Item("DateofReleased").ToString())
                    li.SubItems.Add(myDataReader.Item("OutstandingBalance").ToString())
                    li.SubItems.Add(myDataReader.Item("AdvPayment").ToString())
                    li.SubItems.Add(myDataReader.Item("MA").ToString())
                    li.SubItems.Add(myDataReader.Item("Overdue").ToString())
                    li.SubItems.Add(myDataReader.Item("Penalty").ToString())
                    li.SubItems.Add(myDataReader.Item("NumberOfMonths").ToString())
                    li.SubItems.Add(myDataReader.Item("LastPaymentDate").ToString())
                Loop
            End If
        End Using
    End Sub
    private sub cmd_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_show.Click
        ShowDepoAccts()
    End Sub

End Class