Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_UpdateAmortSched

    Sub mg_AdminUpdateAmortSched()

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminUpdateAmortSched"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamInstallNo", txt_InstallNo.Text)
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_BranchCode.Text)
        cmd.Parameters.AddWithValue("@ParamAccountnumber", txt_AcctNumber.Text)
        cmd.Parameters.AddWithValue("@ParamLedgerSetNumber", txt_LedgsetNo.Text)
        cmd.Parameters.AddWithValue("@ParamDueDate", txt_DueDate.Text)
        cmd.Parameters.AddWithValue("@ParamPrinBegBal", txt_PrinBegBal.Text)
        cmd.Parameters.AddWithValue("@ParamPrincipal", txt_Principal.Text)
        cmd.Parameters.AddWithValue("@ParamPrinEndBal", txt_PrinEndBal.Text)
        cmd.Parameters.AddWithValue("@ParamIntBegBal", txt_IntBegBal.Text)
        cmd.Parameters.AddWithValue("@ParamInterest", txt_Interest.Text)
        cmd.Parameters.AddWithValue("@ParamIntEndBal", txt_IntEndBal.Text)
        cmd.Parameters.AddWithValue("@ParamMonAmort", txt_MA.Text)
        cmd.Parameters.AddWithValue("@ParamTransactedby", MainMenu.App_User_Name.Caption)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()
        If rs.Read() Then
            MsgBox(rs.Item("Message").ToString())
        End If
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Private Sub Admin_UpdateAmortSched_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ClearDAta()
        txt_InstallNo.Text = String.Empty
        txt_BranchCode.Text = String.Empty
        txt_AcctNumber.Text = String.Empty
        txt_LedgsetNo.Text = String.Empty
        txt_DueDate.Text = String.Empty
        txt_MA.Text = String.Empty
        txt_PrinBegBal.Text = String.Empty
        txt_Principal.Text = String.Empty
        txt_PrinEndBal.Text = String.Empty
        txt_IntBegBal.Text = String.Empty
        txt_Interest.Text = String.Empty
        txt_IntEndBal.Text = String.Empty
    End Sub

    Private Sub cmd_Modify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmd_Modify.ItemClick
        mg_AdminUpdateAmortSched()
        ClearDAta()
         IS_Sales_ReleaseAccount_List.showAmortSchedAcctMgmt()
        Me.Close()
    End Sub

End Class