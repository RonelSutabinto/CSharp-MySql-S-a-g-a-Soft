Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Sales_Inquiry
    Private Sub SPA_Sales_Inquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Total.Text = CStr(Val(txt_Balance.EditValue))
        ColorChanged()
        SPA_Show_Ledger()
        If txt_Balance.EditValue Is "0.00" Then
            btn_Print.Enabled = False
        Else
            btn_Print.Enabled = True
        End If
    End Sub

    Sub ColorChanged()
        If txt_Balance1.EditValue Is "0.00" Then
            txt_Status.EditValue = "CLOSED"
            txt_Status1.EditValue = "CLOSED"
        End If
        If txt_Status.EditValue Is "OVERDUE" Or txt_Status.Text Is "overdue" Or txt_Status.Text Is "overdue " Or txt_Status.Text Is " overdue" Or txt_Status.Text Is "OVERDUE " Or txt_Status.Text Is "Overdue" Then
            txt_Status.ForeColor = Color.Red
            Me.BackColor = Color.Red
            tab_Details.BackColor = Color.Red
            tab_Ledger.BackColor = Color.Red

        ElseIf txt_Status.Text Like "CURRENT" Then
            txt_Status.ForeColor = Color.Black
            Me.BackColor = Color.Teal
            tab_Details.BackColor = Color.Teal
            tab_Ledger.BackColor = Color.Teal

        ElseIf txt_Status.Text Like "CLOSED" Then
            Me.BackColor = Color.Black
            tab_Details.BackColor = Color.Black
            tab_Ledger.BackColor = Color.Black
        End If

    End Sub

    Sub SPA_AddtoLedger()
        lv_Ledger.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamcustName", txt_CustName1.EditValue),
            New SqlParameter("@ParamcustAddress", txt_Address1.EditValue),
            New SqlParameter("@ParamAmountPaid", lbl_AmountPaid.Text),
            New SqlParameter("@ParamSalesBalance", Math.Round(Val(txt_Balance.EditValue) - Val(lbl_AmountPaid.Text), 2)),
            New SqlParameter("@ParamGrandTotal", txt_AmountDue.EditValue),
            New SqlParameter("@ParamBranchCode", txt_BranchCode.EditValue),
            New SqlParameter("@ParamSINo", txt_SINo1.EditValue),
            New SqlParameter("@ParamSaleStatus", txt_Status1.EditValue),
            New SqlParameter("@ParamCustCode", txt_custCode.EditValue),
            New SqlParameter("@ParamCRNumber", txt_CRNumber.EditValue),
            New SqlParameter("@ParamPostingDate", Format(Date.Today, "MM/dd/yyyy"))
        }

        class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "SPA_AddtoLedger", "Update Ledger")
    End Sub

    Sub SPA_ModifySales_Collection()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamTrans_Category", cmb_TransCategory1.EditValue),
            New SqlParameter("@ParamTrans_Code", txt_TransCode1.EditValue),
            New SqlParameter("@ParamPostingDate", dtp_Date.EditValue),
            New SqlParameter("@ParamBranchCode", txt_BranchCode.EditValue),
            New SqlParameter("@ParamcustName", txt_CustName.EditValue),
            New SqlParameter("@ParamcustAddress", txt_Address.EditValue),
            New SqlParameter("@ParamSINo", txt_SINo.EditValue),
            New SqlParameter("@ParamSI_Code", cmb_SI_Code.EditValue),
            New SqlParameter("@ParamAmountPaid", lbl_AmountPaid.Text),
            New SqlParameter("@ParamSaleStatus", txt_Status1.EditValue),
            New SqlParameter("@ParamSalesBalance", Math.Round(Val(txt_Balance1.EditValue) - Val(lbl_AmountPaid.Text), 2)),
            New SqlParameter("@ParamCustCode", txt_custCode.EditValue),
            New SqlParameter("@ParamCRNumber", txt_CRNumber.EditValue),
            New SqlParameter("@ParamGrandTotal", txt_AmountDue.EditValue),
            New SqlParameter("@ParamtransactedBy", class_Variables.sUserName)
        }

        If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "SPA_ModifySales_Collection", "Sale Collection") Then
            MsgBox("Spare Parts Posted!", vbInformation, Application.CompanyName)
        End If
    End Sub

    Sub SPA_Find_SINo_Sales()
        lv_Parts.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamSINo", txt_SINo.Text),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, "SPA_Find_SINo_Sales")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_Parts.Items.Add(myDataReader.Item("branchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("Quantity").ToString())
                    li.SubItems.Add(myDataReader.Item("quantityUnit").ToString())
                    li.SubItems.Add(myDataReader.Item("Descriptions").ToString())
                    li.SubItems.Add(myDataReader.Item("UnitPrice").ToString())
                    li.SubItems.Add(myDataReader.Item("subTotal").ToString())
                    li.SubItems.Add(myDataReader.Item("prev_ID").ToString())
                    li.SubItems.Add(myDataReader.Item("ID").ToString())
                    li.SubItems.Add(myDataReader.Item("partsNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("partsName").ToString())
                Loop

                cmb_Terms.Text = myDataReader("Terms").ToString()
                dtp_Maturity.Text = myDataReader("MaturityDate").ToString()
                cmb_TransCategory.Text = myDataReader("trans_Category").ToString()
                txt_TransCode.Text = myDataReader("trans_Code").ToString()
                dtp_Date.Text = myDataReader("postingDate").ToString()
                txt_CustName.Text = myDataReader("custName").ToString()
                txt_Address.Text = myDataReader("custAddress").ToString()
                txt_CRNumber.Text = myDataReader("CRNumber").ToString()
                txt_SINo.Text = myDataReader("SINo").ToString()
                cmb_SI_Code.Text = myDataReader("SI_Code").ToString()
                txt_Note.Text = myDataReader("Note").ToString()
                txt_Status.Text = myDataReader("SaleStatus").ToString()
                txt_GTotal.Text = myDataReader("GrandTotal").ToString()
                txt_Balance.Text = myDataReader("SalesBalance").ToString()
                txt_BranchCode.Text = myDataReader("BranchCode").ToString()
                txt_AmountDue.Text = myDataReader("GrandTotal").ToString()
                txt_custCode.Text = myDataReader("custCode").ToString()

                '-------------------------Pause-------------------'

                cmb_Terms1.Text = myDataReader("Terms").ToString()
                dtp_Maturity1.Text = myDataReader("MaturityDate").ToString()
                cmb_TransCategory1.Text = myDataReader("trans_Category").ToString()
                txt_TransCode1.Text = myDataReader("trans_Code").ToString()
                dtp_Date1.Text = myDataReader("postingDate").ToString()
                txt_CustName1.Text = myDataReader("custName").ToString()
                txt_Address1.Text = myDataReader("custAddress").ToString()
                txt_SINo1.Text = myDataReader("SINo").ToString()
                cmb_SI_Code1.Text = myDataReader("SI_Code").ToString()
                txt_Note1.Text = myDataReader("Note").ToString()
                txt_Status1.Text = myDataReader("SaleStatus").ToString()
                txt_Credit1.Text = myDataReader("AmountPaid").ToString()
                txt_Balance1.Text = myDataReader("SalesBalance").ToString()
                txt_BranchCode1.Text = myDataReader("BranchCode").ToString()
                txt_CRNumber1.Text = myDataReader("CRNumber").ToString()
                txt_AmountDue1.Text = myDataReader("GrandTotal").ToString()
            End If
        End Using
    End Sub

    Sub SPA_Find_SINo_Sales_Collection()
        lv_Parts.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamSINo", txt_SINo.Text),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, "SPA_Find_SINo_Sales_Collection")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_Credit.Text = myDataReader("AmountPaid").ToString()

                '-------------------------Pause-------------------'

                txt_Credit1.Text = myDataReader("AmountPaid").ToString()
            End If
        End Using
    End Sub

    Sub SPA_Show_Ledger()
        lv_Ledger.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode),
            New SqlParameter("@ParamcustName", txt_CustName1.Text),
            New SqlParameter("@ParamSINo", txt_SINo1.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, "SPA_Show_Ledger")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_Ledger.Items.Add(myDataReader.Item("branchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("Credit").ToString())
                    li.SubItems.Add(myDataReader.Item("Balance").ToString())
                    li.SubItems.Add(myDataReader.Item("AmountDue").ToString())
                    li.SubItems.Add(myDataReader.Item("SaleStatus").ToString())
                    li.SubItems.Add(myDataReader.Item("PostingDate").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub toolPost_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Payment_Click(sender As Object, e As EventArgs) Handles btn_Payment.Click
        SPA_CRNo_Input.ShowDialog()
        SPA_InputAmount.Show()
        SPA_InputAmount.txt_AmountDue.EditValue = txt_Balance.EditValue
        SPA_InputAmount.txt_Type.EditValue = Me.Text
    End Sub

    Private Sub lbl_AmountPaid_TextChanged(sender As Object, e As EventArgs) Handles lbl_AmountPaid.TextChanged
        If Val(txt_Balance1.Text) = Val(lbl_AmountPaid.Text) Then
            txt_Status.EditValue = "CLOSED"
            txt_Status1.EditValue = "CLOSED"
        ElseIf Val(txt_Balance1.Text) > Val(lbl_AmountPaid.Text) Then
            txt_Status.EditValue = "CURRENT"
            txt_Status1.EditValue = "CURRENT"
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim TitleFont As New Font("calibri", 10, FontStyle.Bold)
        Dim BodyFont As New Font("calibri", 10, FontStyle.Regular)
        Dim NameFont As New Font("calibri", 12, FontStyle.Regular)
        Dim BodyFont2 As New Font("calibri", 14, FontStyle.Bold)
        Dim BodyFontAMT As New Font("calibri", 10, FontStyle.Regular)
        Dim format As New StringFormat(StringFormatFlags.DirectionRightToLeft)
        Dim Money As String = FormatNumber(lbl_Total.Text, 2, , , TriState.True)

        Dim FirstColAmt As Integer = 200
        Dim SecondColAmt As Integer = 410
        Dim H As Integer = 0
        H = 75
        'e.Graphics.DrawString("Full Feb. 2500 Full march 2500 Full April 2500 Full may 2500 Par. June 250", BodyFont, Brushes.Black, New Rectangle(15, H, e.Graphics.VisibleClipBounds.Width - 610, e.Graphics.VisibleClipBounds.Height - 140))
        ' e.Graphics.DrawString("D/P", NameFont, Brushes.Black, 35, H)
        e.Graphics.DrawString(dtp_Date.Text, BodyFont, Brushes.Black, 360, H)
        H += 35

        e.Graphics.DrawString(txt_CustName.Text, NameFont, Brushes.Black, 50, H)
        H += 35

        e.Graphics.DrawString(txt_Address.Text, NameFont, Brushes.Black, 50, H)
        H += 50

        'e.Graphics.DrawString("Bon Jovie P. Belonghilot", NameFont, Brushes.Black, 115, H)
        'H += 25

        For Each Itm As ListViewItem In lv_Parts.Items
            'e.Graphics.DrawString(Itm.Text, New Drawing.Font("Calibri", 10), Brushes.Black, 50, H)
            e.Graphics.DrawString(Itm.SubItems(1).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 22, H) '80
            e.Graphics.DrawString(Itm.SubItems(2).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 20, H)
            e.Graphics.DrawString(Itm.SubItems(3).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 42, H)
            e.Graphics.DrawString(Itm.SubItems(4).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 320, H)
            e.Graphics.DrawString(Itm.SubItems(5).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 380, H)
            'e.Graphics.DrawString(Itm.SubItems(6).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 600, H)
            'e.Graphics.DrawString(Itm.SubItems(7).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 700, H)
            H += 17
        Next
        H += 13
        e.Graphics.DrawString("TOTAL AMT PAID ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(lbl_AmountPaid.Text, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("LESS VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(lbl_lessVAT.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("VATABLE SALES ", BodyFont, Brushes.Black, 22, H)
        'e.Graphics.DrawString(txt_vatablesales.Text, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("AMT NET OF VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(lbl_NetVat.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("VAT EXEMPT SALES ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("Less: SC/PWD Discount ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(lbl_PWD.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("ZERO RATED SALES ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("AMOUNT DUE ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("VAT AMOUNT ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(lbl_lessVAT.Text, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("ADD VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(lbl_AddVAT.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("Amount Due ", TitleFont, Brushes.Black, 40, H)
        e.Graphics.DrawString(Money, TitleFont, Brushes.Black, 380, H, format)
        H += 40 '
        e.Graphics.DrawString("Printed by: ", TitleFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(class_Variables.sUserName, TitleFont, Brushes.Black, 90, H)
        e.Graphics.DrawString("Printed Date: ", TitleFont, Brushes.Black, 260, H)
        e.Graphics.DrawString(CStr(Date.Now()), TitleFont, Brushes.Black, 340, H)
    End Sub

    Private Sub lbl_Total_TextChanged(sender As Object, e As EventArgs)
        lbl_Tamount.Text = CStr(Math.Round(Val(lbl_Total.Text), 2))
        lbl_totalLess.Text = CStr(Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2))
        lbl_TotalLess1.Text = CStr(Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2))
        lbl_NetVat.Text = CStr(Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2))
        lbl_lessVAT.Text = CStr(Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2))
    End Sub

    Private Sub txt_Balance_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Balance.EditValueChanged
        If txt_Balance.EditValue Is "0.00" Then
            btn_Print.Enabled = False
        Else
            btn_Print.Enabled = True
        End If
    End Sub

    Private Sub chkVAT_CheckedChanged(sender As Object, e As EventArgs) Handles chkVAT.CheckedChanged
        If chkVAT.Checked = True Then
            lbl_Tamount.Text = CStr(Math.Round(Val(lbl_Total.Text), 2))
            lbl_totalLess.Text = CStr(Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2))
            lbl_TotalLess1.Text = CStr(Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2))
            lbl_NetVat.Text = CStr(Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2))
            lbl_lessVAT.Text = CStr(Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2))
        ElseIf chkVAT.Checked = True Then
            lbl_Tamount.Text = CStr(Math.Round(Val(lbl_Total.Text), 2))
            lbl_NetVat.Text = "0"
            lbl_lessVAT.Text = "0"
        End If
    End Sub

    Private Sub chkNonVAT_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonVAT.CheckedChanged
        If chkNonVAT.Checked = True Then
            lbl_Tamount.Text = CStr(Math.Round(Val(lbl_Total.Text), 2))
            lbl_NetVat.Text = "0"
            lbl_lessVAT.Text = "0"
        ElseIf chkNonVAT.Checked = True Then
            lbl_Tamount.Text = CStr(Math.Round(Val(lbl_Total.Text), 2))
            lbl_totalLess.Text = CStr(Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2))
            lbl_TotalLess1.Text = CStr(Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2))
            lbl_NetVat.Text = CStr(Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2))
            lbl_lessVAT.Text = CStr(Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2))
        End If
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        If txt_CRNumber.EditValue Is "0" Or txt_CRNumber.Text = String.Empty Then
            MsgBox("Please Supply CR Number", vbExclamation, Application.CompanyName)
            Return
            Exit Sub
        End If
        Dim news As Integer = MsgBox("Proceed to Transaction?", vbYesNo, Application.CompanyName)
        If news = DialogResult.No Then
            MsgBox("Failed Posting data", vbExclamation, Application.CompanyName)
            Me.Close()
        Else
            ColorChanged()
            SPA_ModifySales_Collection()
            SPA_AddtoLedger()
            SPA_Find_SINo_Sales()
            SPA_Find_SINo_Sales_Collection()
            SPA_Show_Ledger()
            Me.Close()
        End If
    End Sub

    Private Sub btn_Print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print.ItemClick
        With PrintDocument1
            .DefaultPageSettings.Landscape = False
        End With

        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        With PrintPreviewDialog1
            .PrintPreviewControl.Width = FormWindowState.Maximized
            .PrintPreviewControl.AutoZoom = True
            .ShowDialog()
        End With
        btn_Print.Enabled = False
    End Sub

    Private Sub btn_Error_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Error.ItemClick
        SPA_ErrorCorrect_Sales.txt_custName1.Text = txt_CustName.Text
        SPA_ErrorCorrect_Sales.ShowDialog()
    End Sub
End Class