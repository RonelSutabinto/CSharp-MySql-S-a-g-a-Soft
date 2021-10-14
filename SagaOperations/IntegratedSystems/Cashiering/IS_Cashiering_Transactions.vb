Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient
Imports wSClassLib.myModules

Public Class IS_Cashiering_Transactions
    ReadOnly Crystal_ReportORCashiering As New ReportDocument

    Private Sub IS_Cashiering_Transactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowAccountCodes()
        'ShowInvoices()
    End Sub

    Sub PrintOR()
        Dim CrTable As Table
        Dim CrTables As Tables
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim reportPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Rpt_ORCashiering.rpt")
        Crystal_ReportORCashiering.Load(reportPath)
        Dim crParameterValue As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        With crConnectionInfo
            .ServerName = class_Tools.Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", String.Empty))
            .DatabaseName = class_Tools.Decrypt(class_Tools.RegKeyGet("Dbase", "DataBaseName", String.Empty))
            .UserID = class_Tools.Decrypt(class_Tools.RegKeyGet("DBaseUname", "DataBaseUserName", String.Empty))
            .Password = class_Tools.Decrypt(class_Tools.RegKeyGet("DBasePassword", "DataBasePassWord", String.Empty))

        End With
        CrTables = Crystal_ReportORCashiering.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next

        Crystal_ReportORCashiering.SetParameterValue("AccountName", txt_cust2.Text)
        Crystal_ReportORCashiering.SetParameterValue("Address", txt_address2.Text)
        Crystal_ReportORCashiering.SetParameterValue("PostingDate", postingDate2.Value)
        Crystal_ReportORCashiering.SetParameterValue("transaction", cmb_transactions2.Text)
        Crystal_ReportORCashiering.SetParameterValue("mnemonic", txt_acctcodeMne2.Text)
        Crystal_ReportORCashiering.SetParameterValue("description", txt_description2.Text)
        Crystal_ReportORCashiering.SetParameterValue("amountdue", txt_amt2.Text)
        Crystal_ReportORCashiering.SetParameterValue("discount", txt_discnt2.Text)
        Crystal_ReportORCashiering.SetParameterValue("netgross", txt_netgross2.Text)
        Crystal_ReportORCashiering.SetParameterValue("vat", txt_vatamt.Text)
        Crystal_ReportORCashiering.SetParameterValue("netofvat", txt_amtNetOfVat.Text)
        Crystal_ReportORCashiering.SetParameterValue("transactedby", MainMenu.App_User_Name.Caption)

        rpt_Receipt.cr_Receipt.ReportSource = Crystal_ReportORCashiering
        rpt_Receipt.cr_Receipt.Zoom(75)
        rpt_Receipt.cr_Receipt.Refresh()

        MsgBox("OR - " & Err.Description, vbCritical, Application.CompanyName)

        rpt_Receipt.ShowDialog()
    End Sub

    Sub CLearFields()
        txt_BranchCodeCust.Text = String.Empty
        txt_AccountNumberCust.Text = String.Empty
        txt_LedsetCust.Text = String.Empty
        txt_cust.Text = String.Empty
        txt_cifkey.Text = String.Empty
        txt_address.Text = String.Empty
        txt_refno.Text = String.Empty
    End Sub

    Sub ShowAccountCodes()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamIsCommand", Me.Text)}

        cmb_transactions.Items.Clear()

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_AccountCodes")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_transactions.Items.Add(myDataReader.Item("Transactions").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub ShowAccountCodeMnemo()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamTransaction", cmb_transactions.Text)}

        cmb_invoices.Items.Clear()
        cmb_invoices.Text = String.Empty

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAccountCodeMnemo")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_acctcodeMne.Text = myDataReader("Mnemonic").ToString()
                cmb_invoices.Items.Add(myDataReader.Item("invoicedesc").ToString)
                txt_TransID.Text = myDataReader("TransactionID").ToString()
                txt_TargetFrm.Text = myDataReader("TargetFrm").ToString()
                txt_FrmText.Text = myDataReader("FrmText").ToString()
            End If
        End Using
    End Sub

    Sub PostTransactions()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamAccountName", txt_cust.Text),
            New SqlParameter("@ParamAccountAddress", txt_address.Text),
            New SqlParameter("@ParamCIFNo", txt_cifkey.Text),
            New SqlParameter("@ParamTransaction", cmb_transactions.Text),
            New SqlParameter("@ParamMnemonic", txt_acctcodeMne.Text),
            New SqlParameter("@ParamInvoices", cmb_invoices.Text),
            New SqlParameter("@ParamDescription", txt_description.Text),
            New SqlParameter("@ParamPostingDate", postingDate.Text),
            New SqlParameter("@ParamReferenceNumber", txt_refno.Text),
            New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamAmountDue", txt_amt.Text),
            New SqlParameter("@ParamVatNonVat", vat.Checked),
            New SqlParameter("@ParamDiscount", txt_discnt.Text),
            New SqlParameter("@ParamBranchCodeCust", txt_BranchCodeCust.Text),
            New SqlParameter("@ParamAccountNumberCust", txt_AccountNumberCust.Text),
            New SqlParameter("@ParamLedSetCust", txt_LedsetCust.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "Insert_TransactionOthers", "Post Transaction", txt_refno.Text)
    End Sub

    Sub ShowTransactions()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamCIFNumber", txt_cifkey.Text),
            New SqlParameter("@ParamRefNo", txt_refno.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowORCashiering")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                cmb_transactions2.Text = myDataReader("transaction").ToString()
                txt_acctcodeMne2.Text = myDataReader("Mnemonic").ToString()
                cmb_invoices2.Text = myDataReader("Invoices").ToString()
                postingDate2.Value = myDataReader("postingdate").ToString()
                txt_cust2.Text = myDataReader("AccountName").ToString()
                txt_cifkey2.Text = myDataReader("cifno").ToString()
                txt_address2.Text = myDataReader("accountaddress").ToString()
                txt_refno2.Text = myDataReader("ReferenceNumber").ToString()
                txt_description2.Text = myDataReader("Description").ToString()
                txt_amt2.Text = Format(myDataReader.Item("AmountDue"), "#,##0.00")
                txt_vatamt.Text = Format(myDataReader.Item("vat"), "#,##0.00")
                txt_amtNetOfVat.Text = Format(myDataReader.Item("AmntNetOfVat"), "#,##0.00")
                txt_discnt2.Text = Format(myDataReader.Item("discnt"), "#,##0.00")
                txt_netgross2.Text = Format(myDataReader.Item("netgross"), "#,##0.00")
            End If
        End Using
    End Sub

    Sub ShowInvoices()
        Dim Parameters As SqlParameter() = {}

        cmb_invoices.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowInvoices")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_invoices.Items.Add(myDataReader.Item("invoicedesc").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub ShowCashieringTransBillToTarget()
        cmb_invoices.Items.Clear()
        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowInvoices")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_invoices.Items.Add(myDataReader.Item("invoicedesc").ToString)
                Loop
            End If
        End Using
    End Sub

    Private Sub show_Account_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles show_Account.Click
        If txt_TargetFrm.Text = "ACCTINQ" Then
            IS_Sales_ReleaseAccount_List.Text = txt_FrmText.Text
            IS_Sales_ReleaseAccount_List.ShowDialog()
        ElseIf txt_TargetFrm.Text = "CIFINQ" Then
            IS_Sales_FindCust.Text = txt_FrmText.Text
            IS_Sales_FindCust.ShowDialog()
        End If
    End Sub

    Private Sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        If MsgBox("Bill to: " & txt_cust.Text & vbCrLf & "Transaction: " & cmb_transactions.Text & vbCrLf &
                    "Invoices: " & cmb_invoices.Text & vbCrLf & "Description: " & txt_description.Text & vbCrLf & "Amount Due: " & Format(Val(txt_amt.Text), "#,##0.00") & vbCrLf & vbCrLf &
                    "Do you want to proceed transaction?", vbYesNo, MessageBoxIcon.Warning) = vbYes Then
            class_Procedures.splash_Show("Transaction on process!")
            PostTransactions()
            If txt_ErrNo.Text = "0" Then
                PrintReceipt()
            End If
        Else
            MsgBox("Transaction unsuccessful", vbCritical, Application.CompanyName)
        End If
        class_Procedures.splash_Close()
    End Sub

    Private Sub cmb_transactions_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_transactions.TextChanged
        ShowAccountCodeMnemo()
        CLearFields()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim TitleFont As New Font("calibri", 10, FontStyle.Bold)
        Dim BodyFont As New Font("calibri", 10, FontStyle.Regular)
        Dim BodyFont2 As New Font("calibri", 10)
        Dim BodyFontAMT As New Font("calibri", 10, FontStyle.Regular, Alignment.RightAlign)
        Dim format As New StringFormat(StringFormatFlags.DirectionRightToLeft)

        Dim FirstColAmt As Integer = 200
        Dim SecondColAmt As Integer = 410
        Dim H As Integer = 65
        e.Graphics.DrawString(postingDate2.Text, BodyFont, Brushes.Black, 300, H)
        H += 35 '100
        e.Graphics.DrawString(txt_cust.Text, TitleFont, Brushes.Black, 100, H)
        H += 20 '120
        e.Graphics.DrawString(txt_address2.Text, BodyFont, Brushes.Black, 100, H)
        H += 20 '140
        e.Graphics.DrawString(txt_numtoword.Text, BodyFont2, Brushes.Black, 100, H)
        H += 20 '160
        e.Graphics.DrawString(txt_amt2.Text, BodyFont2, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_description2.Text, BodyFont, Brushes.Black, 180, H)

        H += 30 '180
        e.Graphics.DrawString("REFERENCE: ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_refno.Text, BodyFont, Brushes.Black, 160, H)
        H += 20 '
        e.Graphics.DrawString("TOTAL AMT PAID ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_amt2.Text, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("LESS VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(txt_vatamt.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("VATABLE SALES ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_vatamt.Text, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("AMT NET OF VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(txt_amtNetOfVat.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("VAT EXEMPT SALES ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("Less: SC/PWD Discount ", BodyFont, Brushes.Black, 220, H)
        H += 20 '
        e.Graphics.DrawString("OUTSTANDING BALANCE ", TitleFont, Brushes.Black, 40, H)
        H += 40 '
        e.Graphics.DrawString("Printed by: ", TitleFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(MainMenu.App_Full_Name.Caption, TitleFont, Brushes.Black, 90, H)
        e.Graphics.DrawString("Printed Date: ", TitleFont, Brushes.Black, 260, H)
        e.Graphics.DrawString(MainMenu.dateStatus.Caption, TitleFont, Brushes.Black, 340, H)
    End Sub

    Private Sub toolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolPrint.Click
        PrintReceipt()
    End Sub

    Sub PrintReceipt()
        ShowTransactions()

        With PrintDocument1
            .DefaultPageSettings.Landscape = False
        End With

        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        With PrintPreviewDialog1
            .PrintPreviewControl.Width = FormWindowState.Maximized
            .PrintPreviewControl.Zoom = 1.5
            .ShowDialog()
        End With
    End Sub

    Private Sub txt_amt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_amt2.TextChanged
        txt_numtoword.Text = AmountInWords(txt_amt2.Text)
    End Sub

    Private Sub cmb_invoices_TextChanged(sender As Object, e As EventArgs) Handles cmb_invoices.TextChanged
        CLearFields()
    End Sub

End Class