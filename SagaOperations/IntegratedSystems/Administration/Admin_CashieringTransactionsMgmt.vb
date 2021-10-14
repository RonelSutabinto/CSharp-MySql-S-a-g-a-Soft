Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_CashieringTransactionsMgmt

    Private Sub Admin_CashieringTransactionsMgmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub mg_ShowCashieringTransactions()

        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowAccountCode"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 80
        cmd.Connection = class_Database.mySQLConnection

        'cmd.Parameters.AddWithValue("@ParamBranchCode", txt_branchcode.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()

        GCCashieringTrans.DataSource = (rs)
        GViewCashieringTrans.BestFitColumns(True)

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1
out:    MsgBox(Err.Description)
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:
    End Sub

    Sub mg_ShowCashieringInvoices()
        If txt_TID.Text = String.Empty Then
            Return
        ElseIf txt_TID.Text <> String.Empty Then
            '  On Error GoTo out

            Dim cmd As New SqlCommand
            Dim rs As SqlDataReader

            cmd.CommandText = "mg_ShowInvoiceswithParam"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandTimeout = 80
            cmd.Connection = class_Database.mySQLConnection

            cmd.Parameters.AddWithValue("@ParamTID", txt_TID.Text)

            class_Database.OpenDB(ICSConnection)
            rs = cmd.ExecuteReader()
            'If rs.Read Then
            GCInvoices.DataSource = (rs)
            GViewInvoices.BestFitColumns(True)
            'End If

            rs.Close()
            class_Database.mySQLConnection.Close()
            GoTo outs1
out:        MsgBox(Err.Description)
            class_Database.mySQLConnection.Close()
            GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:

        End If
    End Sub

    Sub TransactionMgmt()

        ' On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminCashieringTransMgmt"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 80
        cmd.Connection = class_Database.mySQLConnection

        cmd.Parameters.AddWithValue("@ParamTID", txt_TID.Text)
        cmd.Parameters.AddWithValue("@ParamTransactions", txt_TransDesc.Text)
        cmd.Parameters.AddWithValue("@ParamIsCommand", txt_IsCommand.Text)
        cmd.Parameters.AddWithValue("@ParamMnemonic", txt_Mnemonic.Text)
        cmd.Parameters.AddWithValue("@ParamTargetForm", txt_TargetFrm.Text)
        cmd.Parameters.AddWithValue("@ParamFrmText", txt_FrmTxt.Text)
        cmd.Parameters.AddWithValue("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamDateAdded", Now)
        cmd.Parameters.AddWithValue("@ParamDateUpdated", Now)
        cmd.Parameters.AddWithValue("@ParamEvent", "trSAVE")

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()

        'If rs.Read Then
        '    MsgBox(rs.Item("Status").ToString & " - " & rs.Item("Message").ToString)
        'End If
        If rs.Read() Then
            MsgBox(rs.Item("Message").ToString())
        End If

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)
        class_Database.mySQLConnection.Close()

outs:   'MsgBox("Successful Updating")
outs1:
    End Sub

    Private Sub cmd_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmd_Reload.ItemClick
        mg_ShowCashieringTransactions()
    End Sub

    Private Sub GCCashieringTrans_Click(sender As Object, e As EventArgs) Handles GCCashieringTrans.Click

    End Sub

    Private Sub GViewCashieringTrans_Click(sender As Object, e As EventArgs) Handles GViewCashieringTrans.Click
        If GViewCashieringTrans.RowCount > 0 Then
            txt_TID.Text = GViewCashieringTrans.GetFocusedRowCellDisplayText("TransactionID")

            txt_TransDesc.Text = GViewCashieringTrans.GetFocusedRowCellDisplayText("Transactions")
            txt_Mnemonic.Text = GViewCashieringTrans.GetFocusedRowCellDisplayText("Mnemonic")
            txt_TargetFrm.Text = GViewCashieringTrans.GetFocusedRowCellDisplayText("TargetForm")
            txt_IsCommand.Text = GViewCashieringTrans.GetFocusedRowCellDisplayText("IsCommand")
            txt_FrmTxt.Text = GViewCashieringTrans.GetFocusedRowCellDisplayText("FrmText")
            txt_TransactedBy.Text = GViewCashieringTrans.GetFocusedRowCellDisplayText("TransactedBy")
            txt_DateAdded.Text = GViewCashieringTrans.GetFocusedRowCellDisplayText("DateAdded")
            txt_DateUpdated.Text = GViewCashieringTrans.GetFocusedRowCellDisplayText("DateUpdated")

            txt_TID2.Text = GViewCashieringTrans.GetFocusedRowCellDisplayText("TransactionID")
            txt_Invoice.Text = String.Empty
            txt_TransactedBy2.Text = String.Empty
            txt_TransactionDate.Text = String.Empty

        End If
        TransactionsDockPane.Show()
        mg_ShowCashieringInvoices()
    End Sub

    Private Sub txt_TID_EditValueChanged(sender As Object, e As EventArgs) Handles txt_TID.EditValueChanged
        'MsgBox(txt_TID.Text)

    End Sub

    Private Sub GViewInvoices_Click(sender As Object, e As EventArgs) Handles GViewInvoices.Click, GCInvoices.Click
        If GViewInvoices.RowCount > 0 Then
            'txt_InvoiceID.Text = GViewInvoices.GetFocusedRowCellDisplayText("id")
            txt_Invoice.Text = GViewInvoices.GetFocusedRowCellDisplayText("InvoiceDesc")

            txt_TransactedBy2.Text = GViewInvoices.GetFocusedRowCellDisplayText("TransactedBy")
            txt_TransactionDate.Text = GViewInvoices.GetFocusedRowCellDisplayText("TransactionDate")
        End If
        InvoicesPane.Show()
    End Sub

    Private Sub btn_SAVE_Tr_Click(sender As Object, e As EventArgs) Handles btn_SAVE_Tr.Click
         TransactionMgmt()
        ' MsgBox(txt_TransDesc.Text)
    End Sub

    Private Sub btn_NEW_Tr_Click(sender As Object, e As EventArgs) Handles btn_NEW_Tr.Click
        txt_TID.Text = String.Empty
        txt_TransDesc.Text = String.Empty
        txt_Mnemonic.Text = String.Empty
        txt_TargetFrm.Text = String.Empty
        txt_IsCommand.Text = String.Empty
        txt_FrmTxt.Text = String.Empty
        txt_TransactedBy.Text = String.Empty
        txt_DateAdded.Text = String.Empty
        txt_DateUpdated.Text = String.Empty
    End Sub

    Private Sub btn_Mod_Tr_Click(sender As Object, e As EventArgs) Handles btn_Mod_Tr.Click

        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminCashieringTransMgmt"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 80
        cmd.Connection = class_Database.mySQLConnection

        cmd.Parameters.AddWithValue("@ParamTID", txt_TID.Text)
        cmd.Parameters.AddWithValue("@ParamTransactions", txt_TransDesc.Text)
        cmd.Parameters.AddWithValue("@ParamIsCommand", txt_IsCommand.Text)
        cmd.Parameters.AddWithValue("@ParamMnemonic", txt_Mnemonic.Text)
        cmd.Parameters.AddWithValue("@ParamTargetForm", txt_TargetFrm.Text)
        cmd.Parameters.AddWithValue("@ParamFrmText", txt_FrmTxt.Text)
        cmd.Parameters.AddWithValue("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamDateAdded", Now)
        cmd.Parameters.AddWithValue("@ParamDateUpdated", Now)
        cmd.Parameters.AddWithValue("@ParamEvent", "trMOD")

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()

        'If rs.Read Then
        '    MsgBox(rs.Item("Status").ToString & " - " & rs.Item("Message").ToString)
        'End If
        If rs.Read() Then
            MsgBox(rs.Item("Message").ToString())
        End If

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)
        class_Database.mySQLConnection.Close()

outs:   'MsgBox("Successful Updating")
outs1:

    End Sub

    Private Sub btn_Del_Tr_Click(sender As Object, e As EventArgs) Handles btn_Del_Tr.Click
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminCashieringTransMgmt"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 80
        cmd.Connection = class_Database.mySQLConnection

        cmd.Parameters.AddWithValue("@ParamTID", txt_TID.Text)
        cmd.Parameters.AddWithValue("@ParamTransactions", txt_TransDesc.Text)
        cmd.Parameters.AddWithValue("@ParamIsCommand", txt_IsCommand.Text)
        cmd.Parameters.AddWithValue("@ParamMnemonic", txt_Mnemonic.Text)
        cmd.Parameters.AddWithValue("@ParamTargetForm", txt_TargetFrm.Text)
        cmd.Parameters.AddWithValue("@ParamFrmText", txt_FrmTxt.Text)
        cmd.Parameters.AddWithValue("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamDateAdded", Now)
        cmd.Parameters.AddWithValue("@ParamDateUpdated", Now)
        cmd.Parameters.AddWithValue("@ParamEvent", "trDEL")

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()

        'If rs.Read Then
        '    MsgBox(rs.Item("Status").ToString & " - " & rs.Item("Message").ToString)
        'End If
        If rs.Read() Then
            MsgBox(rs.Item("Message").ToString())
        End If

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)
        class_Database.mySQLConnection.Close()

outs:   'MsgBox("Successful Updating")
outs1:
    End Sub

    Private Sub GViewCashieringTrans_DoubleClick(sender As Object, e As EventArgs) Handles GViewCashieringTrans.DoubleClick

    End Sub

    Private Sub btn_Save_In_Click(sender As Object, e As EventArgs) Handles btn_Save_In.Click
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminCashieringInvoicesMgmt"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 80
        cmd.Connection = class_Database.mySQLConnection

        cmd.Parameters.AddWithValue("@ParamTID", txt_TID2.Text)
        cmd.Parameters.AddWithValue("@ParamInvoiceDesc", txt_Invoice.Text)
        cmd.Parameters.AddWithValue("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamTransactionDate", Now)
        cmd.Parameters.AddWithValue("@ParamInId", txt_InvoiceID.Text)
        cmd.Parameters.AddWithValue("@ParamEvent", "InSAVE")

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()

        'If rs.Read Then
        '    MsgBox(rs.Item("Status").ToString & " - " & rs.Item("Message").ToString)
        'End If
        If rs.Read() Then
            MsgBox(rs.Item("Message").ToString())
        End If

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)
        class_Database.mySQLConnection.Close()

outs:   'MsgBox("Successful Updating")
outs1:
    End Sub

End Class