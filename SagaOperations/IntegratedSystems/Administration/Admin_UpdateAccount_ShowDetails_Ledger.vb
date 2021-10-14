Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_UpdateAccount_ShowDetails_Ledger

    Sub mg_AdminUpdateLedgerDetails()
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminUpdateLedgerDetails"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_BrCode.Text)
        cmd.Parameters.AddWithValue("@ParamAccountnumber", txt_AcctNo.Text)
        cmd.Parameters.AddWithValue("@ParamLedgerSetNumber", txt_LedSetNo.Text)
        cmd.Parameters.AddWithValue("@ParamSequenceNumber", txt_SeqNo.Text)
        cmd.Parameters.AddWithValue("@ParamPostingDate", txt_PostingDate.Text)
        cmd.Parameters.AddWithValue("@ParamReferenceNumber", txt_RefNo.Text)
        cmd.Parameters.AddWithValue("@ParamLedgerType", txt_LedgerType.Text)
        cmd.Parameters.AddWithValue("@ParamInitiatingBranch", txt_InitiatingBranch.Text)
        cmd.Parameters.AddWithValue("@ParamMnemonic", txt_Mnemonic.Text)
        cmd.Parameters.AddWithValue("@ParamTranscode", txt_Transcode.Text)
        cmd.Parameters.AddWithValue("@ParamBegBal", txt_BegBal.Text)
        cmd.Parameters.AddWithValue("@ParamDebit", txt_Debit.Text)
        cmd.Parameters.AddWithValue("@ParamCredit", txt_Credit.Text)
        cmd.Parameters.AddWithValue("@ParamEndBal", txt_EndBal.Text)
        cmd.Parameters.AddWithValue("@ParamTotalAmtPaid", txt_TotAmtPaid.Text)
        cmd.Parameters.AddWithValue("@ParamOB", txt_OutsBal.Text)
        cmd.Parameters.AddWithValue("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamAccountStatus", txt_AcctStatus.Text)
        cmd.Parameters.AddWithValue("@ParamErrorCorrectTag", txt_ErrorCorrectTag.Text)
        cmd.Parameters.AddWithValue("@ParamAccountExecutive", txt_AccountExecutive.Text)
        cmd.Parameters.AddWithValue("@PAramNotes", txt_Note.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        If rs.Read() Then
            MsgBox(rs.Item("Status").ToString() & " - " & rs.Item("Message").ToString(), vbInformation, Application.CompanyName)
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

    Sub mg_ShowLedgerTypeDetails()
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowLedgerTypeDetails"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamSeqNo", txt_SeqNo.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        If rs.Read() Then
            txt_BrCode.Text = rs.Item("BranchCode").ToString()
            txt_AcctNo.Text = rs.Item("AccountNumber").ToString()
            txt_LedSetNo.Text = rs.Item("LedgerSetNumber").ToString()
            txt_PostingDate.Text = rs.Item("PostingDate").ToString()
            txt_RefNo.Text = rs.Item("ReferenceNumber").ToString()
            txt_LedgerType.Text = rs.Item("LedgerType").ToString()
            txt_InitiatingBranch.Text = rs.Item("InitiatingBranch").ToString()
            txt_Mnemonic.Text = rs.Item("Mnemonic").ToString()
            txt_Transcode.Text = rs.Item("TransCode").ToString()
            txt_BegBal.Text = rs.Item("BeginningBalance").ToString()
            txt_Debit.Text = rs.Item("Debit").ToString()
            txt_Credit.Text = rs.Item("Credit").ToString()
            txt_EndBal.Text = rs.Item("EndingBalance").ToString()
            txt_TotAmtPaid.Text = rs.Item("TotalAmount").ToString()
            txt_OutsBal.Text = rs.Item("OutsBal").ToString()
            txt_TransactedBy.Text = rs.Item("TransactedBy").ToString()
            txt_AcctStatus.Text = rs.Item("AccountStatus").ToString()
            txt_ErrorCorrectTag.Text = rs.Item("ErrorCorrectTag").ToString()
            txt_Note.Text = rs.Item("Note").ToString()
            txt_AccountExecutive.Text = rs.Item("AccountExecutive").ToString()

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

    Sub mg_AdminDeleteLedgerDetails()

        If MsgBox("Do you want to delete this Data??", vbYesNo, Application.CompanyName) = vbYes Then
            On Error GoTo out

            Dim cmd As New SqlCommand
            Dim rs As SqlDataReader

            cmd.CommandText = "mg_AdminDeleteLedgerDetails"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = class_Database.mySQLConnection
            cmd.Parameters.AddWithValue("@ParamBranchCode", txt_BrCode.Text)
            cmd.Parameters.AddWithValue("@ParamAccountnumber", txt_AcctNo.Text)
            cmd.Parameters.AddWithValue("@ParamLedgerSetNumber", txt_LedSetNo.Text)
            cmd.Parameters.AddWithValue("@ParamSequenceNumber", txt_SeqNo.Text)
            cmd.Parameters.AddWithValue("@ParamPostingDate", txt_PostingDate.Text)
            cmd.Parameters.AddWithValue("@ParamReferenceNumber", txt_RefNo.Text)
            cmd.Parameters.AddWithValue("@ParamLedgerType", txt_LedgerType.Text)
            cmd.Parameters.AddWithValue("@ParamInitiatingBranch", txt_InitiatingBranch.Text)
            cmd.Parameters.AddWithValue("@ParamMnemonic", txt_Mnemonic.Text)
            cmd.Parameters.AddWithValue("@ParamTranscode", txt_Transcode.Text)
            cmd.Parameters.AddWithValue("@ParamBegBal", txt_BegBal.Text)
            cmd.Parameters.AddWithValue("@ParamDebit", txt_Debit.Text)
            cmd.Parameters.AddWithValue("@ParamCredit", txt_Credit.Text)
            cmd.Parameters.AddWithValue("@ParamEndBal", txt_EndBal.Text)
            cmd.Parameters.AddWithValue("@ParamTotalAmtPaid", txt_TotAmtPaid.Text)
            cmd.Parameters.AddWithValue("@ParamOB", txt_OutsBal.Text)
            cmd.Parameters.AddWithValue("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
            cmd.Parameters.AddWithValue("@ParamAccountStatus", txt_AcctStatus.Text)
            cmd.Parameters.AddWithValue("@ParamErrorCorrectTag", txt_ErrorCorrectTag.Text)
            cmd.Parameters.AddWithValue("@ParamAccountExecutive", txt_AccountExecutive.Text)
            cmd.Parameters.AddWithValue("@PAramNotes", txt_Note.Text)

            class_Database.OpenDB(ICSConnection)
            rs = cmd.ExecuteReader()
            ' Data is accessible through the DataReader object here.
            If rs.Read() Then
                MsgBox(rs.Item("Status").ToString() & " - " & rs.Item("Message").ToString(), vbInformation, Application.CompanyName)
            End If

            rs.Close()
            class_Database.mySQLConnection.Close()
            GoTo outs1

out:        MsgBox(Err.Description)
            'rs.Close()
            class_Database.mySQLConnection.Close()
            GoTo outs1

outs:
outs1:
        End If

    End Sub

    Private Sub txt_SeqNo_TextChanged(sender As Object, e As EventArgs) Handles txt_SeqNo.TextChanged
        mg_ShowLedgerTypeDetails()
    End Sub

    Private Sub cmd_Post_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmd_Post.ItemClick
        mg_AdminUpdateLedgerDetails()
        ClearDAta()

         IS_Sales_ReleaseAccount_List.showLedgerPrinAcctMgmt()
         IS_Sales_ReleaseAccount_List.showLedgerINTAcctMgmt()
         IS_Sales_ReleaseAccount_List.showLedgerREBAcctMgmt()
         IS_Sales_ReleaseAccount_List.showLedgerPENAcctMgmt()

        Me.Close()
    End Sub

    Private Sub cmd_Del_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmd_Del.ItemClick
        If MsgBox("Do you want to proceed for deletion of the data? This will not be retrieved if continued.", vbYesNo, Application.CompanyName) = MsgBoxResult.Yes Then
            mg_AdminDeleteLedgerDetails()
            'MsgBox("YES")
            ClearDAta()
            Me.Close()
        Else
            Return
        End If

    End Sub

    Sub ClearDAta()
        txt_SeqNo.Text = String.Empty
        txt_BrCode.Text = String.Empty
        txt_AcctNo.Text = String.Empty
        txt_LedSetNo.Text = String.Empty
        txt_PostingDate.Text = String.Empty
        txt_RefNo.Text = String.Empty
        txt_LedgerType.Text = String.Empty
        txt_InitiatingBranch.Text = String.Empty
        txt_Mnemonic.Text = String.Empty
        txt_Transcode.Text = String.Empty
        txt_BegBal.Text = String.Empty
        txt_Debit.Text = String.Empty
        txt_Credit.Text = String.Empty
        txt_EndBal.Text = String.Empty
        txt_TotAmtPaid.Text = String.Empty
        txt_OutsBal.Text = String.Empty
        txt_TransactedBy.Text = String.Empty
        txt_AcctStatus.Text = String.Empty
        txt_ErrorCorrectTag.Text = String.Empty
        txt_Note.Text = String.Empty
        txt_AccountExecutive.Text = String.Empty
    End Sub

    Private Sub LayoutControl1_Click(sender As Object, e As EventArgs) Handles LayoutControl1.Click

    End Sub

    Private Sub Admin_UpdateAccount_ShowDetails_Ledger_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_SeqNo_EditValueChanged(sender As Object, e As EventArgs) Handles txt_SeqNo.EditValueChanged

    End Sub

End Class