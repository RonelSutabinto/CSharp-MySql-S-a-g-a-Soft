Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_ReclassStatus
    private sub Admin_ReclassStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showAccountStatus()
    End Sub

    private sub showCust_Click(sender As Object, e As EventArgs) Handles showCust.Click
        IS_Sales_ReleaseAccount_List.Text = "ReclassStatus"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    private sub showAccountStatus()
        cmb_status.Items.Clear()
        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowDistinctAcctStatus")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_status.Items.Add(myDataReader.Item("AccountStatus").ToString)
                Loop
            End If
        End Using
    End Sub

    private sub toolpost_Click(sender As Object, e As EventArgs) Handles toolpost.Click
        mg_AdminReclassStatus()
    End Sub

    private sub mg_AdminReclassStatus()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_brCode.Text),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamPostingDate", Date.Today),
            New SqlParameter("@ParamNewStatus", cmb_status.Text),
            New SqlParameter("@ParamTransactedby", class_Variables.sUserName)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_AdminReclassStatus", "Account Status Reclassification", $"{txt_AccountNumber.Text}-{txt_LedSet.Text}")
    End Sub

End Class