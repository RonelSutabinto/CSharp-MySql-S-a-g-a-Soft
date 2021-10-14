Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Debit_Memo

    Private Sub Debit_Memo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Debit_Memo_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)
    End Sub

    Private Sub Btn_Account_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Account.ItemClick
         clearfield()

        IS_Sales_ReleaseAccount_List.quickSearch.Focus()
        IS_Sales_ReleaseAccount_List.Text = "DEBITTMEMO"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Sub clearfield()

        txt_branchcode.Text = String.Empty
        txt_acctno.Text = String.Empty
        txt_LedSet.Text = String.Empty

        prinoverride.Text = "0"
        intoverride.Text = "0"
        penoverride.Text = "0"
        aocoverride.Text = "0"
        reboverride.Text = "0"

    End Sub

    Private Sub Btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Update.ItemClick

    End Sub

    Sub PostDebitMemo()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "Post_Debit_Memo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection

        'cmd.Parameters.AddWithValue("@ParamBranchCode", txt_branchcode.Text)
        'cmd.Parameters.AddWithValue("@ParamAccountNumber", txt_acctno.Text)
        'cmd.Parameters.AddWithValue("@ParamPostingDate", postingDate.Value)
        'cmd.Parameters.AddWithValue("@ParamAmountPaid", txt_TotAmtPaid.Text)
        'cmd.Parameters.AddWithValue("@ParamRefNo", txt_refno.Text)
        'cmd.Parameters.AddWithValue("@ParamPrin", prinoverride.Text)
        'cmd.Parameters.AddWithValue("@ParamInt", intoverride.Text)
        'cmd.Parameters.AddWithValue("@Paramaoc", aocoverride.Text)
        'cmd.Parameters.AddWithValue("@Paramsvc", svcoverride.Text)
        'cmd.Parameters.AddWithValue("@Parampen", penoverride.Text)
        'cmd.Parameters.AddWithValue("@Paramdst", dstoverride.Text)
        'cmd.Parameters.AddWithValue("@Paramotc", otcoverride.Text)
        'cmd.Parameters.AddWithValue("@Paramodr", odroverride.Text)
        'cmd.Parameters.AddWithValue("@Paramocr", ocroverride.Text)
        'cmd.Parameters.AddWithValue("@Paramins", insoverride.Text)
        'cmd.Parameters.AddWithValue("@Paramtotal", txt_TotAmtPaid.Text)
        'cmd.Parameters.AddWithValue("@ParamTransactedBy", MainMenu.statusUser.Caption)
        'cmd.Parameters.AddWithValue("@ParamLedgersetNumber", txt_LedSet.Text)
        'cmd.Parameters.AddWithValue("@Paramnote", txt_remarks.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()

        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:
    End Sub

End Class