Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_ReclassStatus
    Private Sub Admin_ReclassStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showAccountStatus()
    End Sub

    Private Sub showCust_Click(sender As Object, e As EventArgs) Handles showCust.Click
        IS_Sales_ReleaseAccount_List.Text = "ReclassStatus"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Sub showAccountStatus()
        cmb_status.Items.Clear()
        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowDistinctAcctStatus")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_status.Items.Add(myDataReader.Item("AccountStatus").ToString)
                Loop
            End If
        End Using
    End Sub

    Private Sub toolpost_Click(sender As Object, e As EventArgs) Handles toolpost.Click
        mg_AdminReclassStatus()
    End Sub

    Sub mg_AdminReclassStatus()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_brCode.Text),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamPostingDate", MainMenu.dateStatus.Caption),
            New SqlParameter("@ParamNewStatus", cmb_status.Text),
            New SqlParameter("@ParamTransactedby", MainMenu.App_User_Name.Caption)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_AdminReclassStatus", "Account Status Reclassification", $"{txt_AccountNumber.Text}-{txt_LedSet.Text}")
    End Sub

End Class