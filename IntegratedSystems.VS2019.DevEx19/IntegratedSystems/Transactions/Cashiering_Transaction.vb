Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Cashiering_Transaction

    Private sub IS_Cashiering_Transactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowAccountCodes()
        ShowInvoices()
    End Sub

    private sub CLearFields()
        txt_BranchCodeCust.Text = String.Empty
        txt_AccountNumberCust.Text = String.Empty
        txt_LedsetCust.Text = String.Empty
        txt_cust.Text = String.Empty
        txt_cifkey.Text = String.Empty
        txt_address.Text = String.Empty
        txt_refno.Text = String.Empty
    End Sub

    private sub ShowAccountCodes()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamIsCommand", Me.Text)
        }
        cmb_transactions.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_AccountCodes")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_transactions.Items.Add(myDataReader.Item("Transactions").ToString)
                Loop
            End If
        End Using
    End Sub

    private sub ShowAccountCodeMnemo()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamTransaction", cmb_transactions.Text)
        }
        cmb_invoices.Items.Clear()
        cmb_invoices.Text = String.Empty

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccountCodeMnemo")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_acctcodeMne.Text = myDataReader("Mnemonic").ToString()
                    cmb_invoices.Items.Add(myDataReader.Item("invoicedesc").ToString)
                    txt_TransID.Text = myDataReader("TransactionID").ToString()
                    txt_TargetFrm.Text = myDataReader("TargetFrm").ToString()
                    txt_FrmText.Text = myDataReader("FrmText").ToString()
                Loop
            End If
        End Using
    End Sub

    private sub PostTransactions()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode),
            New SqlParameter("@ParamAccountName", txt_cust.Text),
            New SqlParameter("@ParamAccountAddress", txt_address.Text),
            New SqlParameter("@ParamCIFNo", txt_cifkey.Text),
            New SqlParameter("@ParamTransaction", cmb_transactions.Text),
            New SqlParameter("@ParamMnemonic", txt_acctcodeMne.Text),
            New SqlParameter("@ParamInvoices", cmb_invoices.Text),
            New SqlParameter("@ParamDescription", txt_description.Text),
            New SqlParameter("@ParamPostingDate", postingDate.Text),
            New SqlParameter("@ParamReferenceNumber", txt_refno.Text),
            New SqlParameter("@ParamTransactedBy", class_Variables.sUserName),
            New SqlParameter("@ParamAmountDue", txt_amt.Text),
            New SqlParameter("@ParamVatNonVat", vat.Checked),
            New SqlParameter("@ParamDiscount", txt_discnt.Text),
            New SqlParameter("@ParamBranchCodeCust", txt_BranchCodeCust.Text),
            New SqlParameter("@ParamAccountNumberCust", txt_AccountNumberCust.Text),
            New SqlParameter("@ParamLedSetCust", txt_LedsetCust.Text),
            New SqlParameter("@Application", Application.ProductName)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "Insert_TransactionOthers", True)
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Dim sMessage As String = myDataReader("Message").ToString
                If sMessage.Contains("POSTED") Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, sMessage, "Transaction Information", True)
                Else
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, sMessage, "Transaction Error", True)
                End If
            End If
        End Using
    End Sub

    private sub ShowTransactions()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode),
            New SqlParameter("@ParamCIFNumber", txt_cifkey.Text),
            New SqlParameter("@ParamRefNo", txt_refno.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowORCashiering")
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

    private sub ShowInvoices()
        Dim sqlParameters As SqlParameter() = {}

        cmb_invoices.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowInvoices")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_invoices.Items.Add(myDataReader.Item("invoicedesc").ToString)
                Loop
            End If
        End Using
    End Sub

    private sub show_Account_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles show_Account.Click
        If txt_TargetFrm.Text = "ACCTINQ" Then
            IS_Sales_ReleaseAccount_List.Text = txt_FrmText.Text
            IS_Sales_ReleaseAccount_List.ShowDialog()
        ElseIf txt_TargetFrm.Text = "CIFINQ" Then
            IS_Sales_FindCust.Text = txt_FrmText.Text
            IS_Sales_FindCust.ShowDialog()
        End If
    End Sub

    private sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
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

    private sub cmb_transactions_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_transactions.TextChanged
        ShowAccountCodeMnemo()
        CLearFields()
    End Sub

    private sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim TitleFont As New Font("calibri", 10, FontStyle.Bold)
        Dim BodyFont As New Font("calibri", 10, FontStyle.Regular)
        Dim BodyFont2 As New Font("calibri", 10)
        Dim BodyFontAMT As New Font("calibri", 10, FontStyle.Regular)
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
        e.Graphics.DrawString(MainMenu.User_Full_Name.Caption, TitleFont, Brushes.Black, 90, H)
        e.Graphics.DrawString("Printed Date: ", TitleFont, Brushes.Black, 260, H)
        e.Graphics.DrawString($"{Date.Today:d}", TitleFont, Brushes.Black, 340, H)
    End Sub

    private sub toolPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolPrint.Click
        'PrintReceipt()
        Dim xRpt As New SagaClassLibrary.Reports.Transactions.xrpt_Cashiering_Receipt
        Dim rpTool = New DevExpress.XtraReports.UI.ReportPrintTool(xRpt)
        Try
            With xRpt
                .Posting_Date.Text = $"{Convert.ToDateTime(postingDate.Value):MMM dd, yyyy}"
                .Customer_Name.Text = txt_cust.Text
                .Customer_Address.Text = txt_address.Text
                .Amount_Received.Text = Convert.ToDecimal(txt_amt.Text).ToString("N2")

                .Reference.Text = txt_refno.Text.Trim.ToUpper
                .Amount_Paid.Text = Convert.ToDecimal(txt_amt.Text.Trim).ToString("N2")

                If vat.Checked Then
                    .Vatable_Sales.Text = .Amount_Paid.Text
                    .VAT.Text = class_Functions.calculate_VAT(Convert.ToDecimal(txt_amt.Text.Trim)).ToString("N2")
                    .NoVAT.Text = class_Functions.calculate_no_VAT(Convert.ToDecimal(txt_amt.Text.Trim)).ToString("N2")
                End If

                .Total.Text = $"PHP {Convert.ToDecimal(txt_amt.Text):N2}"

                .Notes.Text = txt_description.Text.Trim.ToUpper
                .Printed_By.Text = class_Variables.sUserFullName
                .Printed_Date.Text = $"{Date.Now:F}"

                .Amount_Words.Text = class_Functions.AmountToWords(txt_amt.Text).ToUpper
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        Finally
            rpTool.ShowRibbonPreview()
        End Try
    End Sub

    private sub PrintReceipt()
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

    private sub txt_amt2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_amt2.TextChanged
        txt_numtoword.Text = class_Functions.AmountToWords(txt_amt2.Text)
    End Sub

    private sub cmb_invoices_TextChanged(sender As Object, e As EventArgs) Handles cmb_invoices.TextChanged
        CLearFields()
    End Sub

End Class