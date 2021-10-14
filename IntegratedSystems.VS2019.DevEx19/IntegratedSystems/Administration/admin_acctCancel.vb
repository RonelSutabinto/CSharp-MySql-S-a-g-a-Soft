Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class admin_acctCancel

    Private Sub admin_acctCancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mg_AdminAccountCancel()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamDateGranted", releasedDate.Text),
            New SqlParameter("@ParamTransactedBy", class_Variables.sUserName)
        }

        If class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "mg_AdminAccountCancel", "Account Cancel", True) Then
            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "Account successfully Cancelled", "Cancel Account", True)
        End If
    End Sub

    Private Sub toolpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpost.Click
        mg_AdminAccountCancel()
    End Sub

    Private Sub informationtool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles informationtool.Click
        IS_Sales_ReleaseAccount_List.Text = "CANCELACCT"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Private Sub toolexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolexit.Click
        Me.Close()
    End Sub

End Class