Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

'(2020-06-07) Adding Sales Freebies Stored Procedures |Sub SPA_SubtractToSales_Freebies()|

Public Class SPA_Sales
    Sub SPA_AccountCode()
        cmb_TransCategory.Properties.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamIsCommand", Me.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_AccountCode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_TransCategory.Properties.Items.Add(myDataReader.Item("Transactions").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub Load_SIno()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamTransCategory", cmb_TransCategory.EditValue),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_SalesSINo")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_SINo.EditValue = myDataReader("Refno").ToString()
            End If
        End Using
    End Sub

    Sub SPA_Find_SINo_Sales()
        lv_Parts1.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamSINo", txt_SINo.Text),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_SINo_Sales")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read
                    Dim li As ListViewItem = lv_Parts1.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("Quantity").ToString().Trim())
                    li.SubItems.Add(myDataReader.Item("QuantityUnit").ToString().Trim())
                    li.SubItems.Add(myDataReader.Item("Descriptions").ToString().Trim())
                    li.SubItems.Add(myDataReader.Item("UnitPrice").ToString().Trim())
                    li.SubItems.Add(myDataReader.Item("Discounted_SRP").ToString().Trim())
                    li.SubItems.Add(myDataReader.Item("GrossTotal").ToString().Trim())
                    li.SubItems.Add(myDataReader.Item("SalesDiscount").ToString().Trim())
                    li.SubItems.Add(myDataReader.Item("SalesDiscount_PCT").ToString().Trim())
                    li.SubItems.Add(myDataReader.Item("subTotal").ToString().Trim())
                    li.SubItems.Add(myDataReader.Item("Prev_ID").ToString().Trim())
                    li.SubItems.Add(myDataReader.Item("PartsNumber").ToString().Trim())
                    li.SubItems.Add(myDataReader.Item("PartsName").ToString().Trim())
                Loop

                txt_Custname1.Text = myDataReader.Item("custName").ToString.Trim()
                txt_Address1.Text = myDataReader.Item("custAddress").ToString.Trim()
                dtp_Date1.Text = myDataReader.Item("PostingDate").ToString.Trim()
                lbl_TotalAmount1.Text = myDataReader.Item("GrandTotal").ToString.Trim()
                lbl_AmountPaid1.Text = myDataReader.Item("AmountPaid").ToString.Trim()
                lbl_lessVAT.Text = myDataReader.Item("VAT").ToString.Trim()
                lbl_NetVat.Text = myDataReader.Item("AmntNetOfVat").ToString.Trim()
                lbl_lessVAT.Text = myDataReader.Item("VAT").ToString.Trim()
                txt_Note1.Text = myDataReader.Item("Note").ToString.Trim()
            End If
        End Using
    End Sub

    Sub SPA_Find_CRNo_CustDep()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamCRNo", txt_CRNumber.Text),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_CRNo_CustDep")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                lbl_CustDep.Text = myDataReader("AmountDue").ToString
                SPA_InputAmount.lbl_CustDepAmount.Text = myDataReader("AmountDue").ToString
            End If
        End Using
    End Sub

    Sub SPA_Show_LedgerCode()
        cmb_TransCategory.Properties.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_ShowcustCode_Ledger")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_custCodeLedger.EditValue = myDataReader("SPA_LedgerCode").ToString
            End If
        End Using
    End Sub

    Sub SPA_ShowSubDealers_Address()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamSubName", txt_CustName.EditValue)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_ShowSubDealers_Address")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_Address.EditValue = myDataReader("SubAddress").ToString
            End If
        End Using
    End Sub

    Sub SPA_ShowSubDealers()
        cmb_TransCategory.Properties.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamIsCommand", cmb_SI_Code.EditValue)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_ShowSubDealers")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_CustName.Properties.Items.Add(myDataReader.Item("SubName").ToString)
            End If
        End Using
    End Sub

    Sub Show_InvoicesTransaction()
        cmb_SI_Code.Properties.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamID", txt_ID.EditValue)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Show_Invoices")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_SI_Code.Properties.Items.Add(myDataReader.Item("Invoices").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub SPA_Show_Mnemonic()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamTransactions", cmb_TransCategory.EditValue)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Show_Mnemonic")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_TransCode.EditValue = myDataReader("Mnemonic").ToString
                txt_ID.EditValue = myDataReader("TransactionID").ToString
            End If
        End Using
    End Sub

    Private Sub SPA_Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelRight.Visible = True
        SPA_Show_LedgerCode()
        dtp_Date.EditValue = DateTime.Today
        SPA_AccountCode()
    End Sub

    Private Sub btn_Payment_Click(sender As Object, e As EventArgs) Handles btn_Payment.Click
        SPA_InputAmount.Show()
        SPA_InputAmount.txt_AmountDue.Text = Val(lbl_Total.Text)
        SPA_InputAmount.lbl_CustDepAmount.Text = Val(lbl_CustDep.Text)
        SPA_InputAmount.txt_Type.EditValue = Me.Text
    End Sub

    Sub SPA_SubtractToSales_Cash()
        For x = 0 To lv_Parts.Items.Count - 1
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Paramtrans_Category", cmb_TransCategory.EditValue),
                New SqlParameter("@Paramtrans_Code", txt_TransCode.EditValue),
                New SqlParameter("@ParamPostingDate", dtp_Date.Text),
                New SqlParameter("@ParamcustName", txt_CustName.EditValue),
                New SqlParameter("@ParamcustAddress", txt_Address.EditValue),
                New SqlParameter("@ParamSINo", txt_SINo.EditValue),
                New SqlParameter("@ParamSI_Code", cmb_SI_Code.EditValue),
                New SqlParameter("@ParamNote", txt_Note.EditValue),
                New SqlParameter("@ParamTerms", cmb_Terms.EditValue),
                New SqlParameter("@ParamPricing", cmb_Pricing.EditValue),
                New SqlParameter("@ParamGrandTotal", lbl_Total.Text),
                New SqlParameter("@ParamAmountPaid", lbl_AmountPaid.Text),
                New SqlParameter("@ParamCustCode", txt_custCodeLedger.Text),
                New SqlParameter("@ParamCRNumber", txt_CRNumber.Text),
                New SqlParameter("@ParamtransactedBy", MainMenu.App_User_Name.Caption),
                New SqlParameter("@ParamAccountNumber", lbl_AccountNumber.Text),
                New SqlParameter("@ParamLedgerSetNumber", lbl_LedgerSetNumber.Text),
                New SqlParameter("@ParambranchCode", lv_Parts.Items(x).SubItems(0).Text),
                New SqlParameter("@ParamQuantity", lv_Parts.Items(x).SubItems(1).Text),
                New SqlParameter("@ParamquantityUnit", lv_Parts.Items(x).SubItems(2).Text),
                New SqlParameter("@ParamDescriptions", lv_Parts.Items(x).SubItems(3).Text),
                New SqlParameter("@ParamUnitPrice", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(4).Text), 2)),
                New SqlParameter("@ParamGrossTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(5).Text), 2)),
                New SqlParameter("@ParamSalesDiscount", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(6).Text), 2)),
                New SqlParameter("@ParamSalesDiscount_PCT", lv_Parts.Items(x).SubItems(7).Text),
                New SqlParameter("@ParamDiscounted_SRP", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(8).Text), 2)),
                New SqlParameter("@ParamSubTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(9).Text), 2)),
                New SqlParameter("@ParamPrev_ID", lv_Parts.Items(x).SubItems(10).Text),
                New SqlParameter("@ParampartsNumber", lv_Parts.Items(x).SubItems(11).Text),
                New SqlParameter("@ParampartsName", lv_Parts.Items(x).SubItems(12).Text)
            }

            class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "SPA_SubtractToSales_Cash", "SPA Sales")
        Next
        MsgBox("Spare Parts Posted!", vbInformation, Application.CompanyName)
    End Sub

    Sub SPA_SubtractToSales_Charge()
        For x = 0 To lv_Parts.Items.Count - 1
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Paramtrans_Category", cmb_TransCategory.EditValue),
                New SqlParameter("@Paramtrans_Code", txt_TransCode.EditValue),
                New SqlParameter("@ParamPostingDate", dtp_Date.Text),
                New SqlParameter("@ParamcustName", txt_CustName.EditValue),
                New SqlParameter("@ParamcustAddress", txt_Address.EditValue),
                New SqlParameter("@ParamSINo", txt_SINo.EditValue),
                New SqlParameter("@ParamSI_Code", cmb_SI_Code.EditValue),
                New SqlParameter("@ParamNote", txt_Note.EditValue),
                New SqlParameter("@ParamTerms", cmb_Terms.EditValue),
                New SqlParameter("@ParamPricing", cmb_Pricing.EditValue),
                New SqlParameter("@ParamGrandTotal", lbl_Total.Text),
                New SqlParameter("@ParamAmountPaid", lbl_AmountPaid.Text),
                New SqlParameter("@ParamCustCode", txt_custCodeLedger.Text),
                New SqlParameter("@ParamCRNumber", txt_CRNumber.Text),
                New SqlParameter("@ParamtransactedBy", MainMenu.App_User_Name.Caption),
                New SqlParameter("@ParambranchCode", lv_Parts.Items(x).SubItems(0).Text),
                New SqlParameter("@ParamQuantity", lv_Parts.Items(x).SubItems(1).Text),
                New SqlParameter("@ParamquantityUnit", lv_Parts.Items(x).SubItems(2).Text),
                New SqlParameter("@ParamDescriptions", lv_Parts.Items(x).SubItems(3).Text),
                New SqlParameter("@ParamUnitPrice", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(4).Text), 2)),
                New SqlParameter("@ParamGrossTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(5).Text), 2)),
                New SqlParameter("@ParamSalesDiscount", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(6).Text), 2)),
                New SqlParameter("@ParamSalesDiscount_PCT", lv_Parts.Items(x).SubItems(7).Text),
                New SqlParameter("@ParamDiscounted_SRP", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(8).Text), 2)),
                New SqlParameter("@ParamSubTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(9).Text), 2)),
                New SqlParameter("@ParamPrev_ID", lv_Parts.Items(x).SubItems(10).Text),
                New SqlParameter("@ParampartsNumber", lv_Parts.Items(x).SubItems(11).Text),
                New SqlParameter("@ParampartsName", lv_Parts.Items(x).SubItems(12).Text)
            }

            class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "SPA_SubtractToSales_Charge", "SPA Sales")
        Next
        MsgBox("Spare Parts Posted!", vbInformation, Application.CompanyName)
    End Sub

    Sub SPA_SubtractToSales_NonVAT()
        For x = 0 To lv_Parts.Items.Count - 1
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Paramtrans_Category", cmb_TransCategory.EditValue),
                New SqlParameter("@Paramtrans_Code", txt_TransCode.EditValue),
                New SqlParameter("@ParamPostingDate", dtp_Date.Text),
                New SqlParameter("@ParamcustName", txt_CustName.EditValue),
                New SqlParameter("@ParamcustAddress", txt_Address.EditValue),
                New SqlParameter("@ParamSINo", txt_SINo.EditValue),
                New SqlParameter("@ParamSI_Code", cmb_SI_Code.EditValue),
                New SqlParameter("@ParamNote", txt_Note.EditValue),
                New SqlParameter("@ParamTerms", cmb_Terms.EditValue),
                New SqlParameter("@ParamPricing", cmb_Pricing.EditValue),
                New SqlParameter("@ParamGrandTotal", lbl_Total.Text),
                New SqlParameter("@ParamAmountPaid", lbl_AmountPaid.Text),
                New SqlParameter("@ParamCustCode", txt_custCodeLedger.Text),
                New SqlParameter("@ParamCRNumber", txt_CRNumber.Text),
                New SqlParameter("@ParamtransactedBy", MainMenu.App_User_Name.Caption),
                New SqlParameter("@ParamAccountNumber", lbl_AccountNumber.Text),
                New SqlParameter("@ParamLedgerSetNumber", lbl_LedgerSetNumber.Text),
                New SqlParameter("@ParambranchCode", lv_Parts.Items(x).SubItems(0).Text),
                New SqlParameter("@ParamQuantity", lv_Parts.Items(x).SubItems(1).Text),
                New SqlParameter("@ParamquantityUnit", lv_Parts.Items(x).SubItems(2).Text),
                New SqlParameter("@ParamDescriptions", lv_Parts.Items(x).SubItems(3).Text),
                New SqlParameter("@ParamUnitPrice", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(4).Text), 2)),
                New SqlParameter("@ParamGrossTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(5).Text), 2)),
                New SqlParameter("@ParamSalesDiscount", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(6).Text), 2)),
                New SqlParameter("@ParamSalesDiscount_PCT", lv_Parts.Items(x).SubItems(7).Text),
                New SqlParameter("@ParamDiscounted_SRP", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(8).Text), 2)),
                New SqlParameter("@ParamSubTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(9).Text), 2)),
                New SqlParameter("@ParamPrev_ID", lv_Parts.Items(x).SubItems(10).Text),
                New SqlParameter("@ParampartsNumber", lv_Parts.Items(x).SubItems(11).Text),
                New SqlParameter("@ParampartsName", lv_Parts.Items(x).SubItems(12).Text)
            }

            class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "SPA_SubtractToSales_NonVAT", "SPA Sales")
        Next
        MsgBox("Spare Parts Posted!", vbInformation, Application.CompanyName)
    End Sub

    Sub SPA_SubtractToSales_Freebies()
        For x = 0 To lv_Parts.Items.Count - 1
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Paramtrans_Category", cmb_TransCategory.EditValue),
                New SqlParameter("@Paramtrans_Code", txt_TransCode.EditValue),
                New SqlParameter("@ParamPostingDate", dtp_Date.Text),
                New SqlParameter("@ParamcustName", txt_CustName.EditValue),
                New SqlParameter("@ParamcustAddress", txt_Address.EditValue),
                New SqlParameter("@ParamSINo", txt_SINo.EditValue),
                New SqlParameter("@ParamSI_Code", cmb_SI_Code.EditValue),
                New SqlParameter("@ParamNote", txt_Note.EditValue),
                New SqlParameter("@ParamTerms", cmb_Terms.EditValue),
                New SqlParameter("@ParamPricing", cmb_Pricing.EditValue),
                New SqlParameter("@ParamGrandTotal", lbl_Total.Text),
                New SqlParameter("@ParamAmountPaid", lbl_AmountPaid.Text),
                New SqlParameter("@ParamCustCode", txt_custCodeLedger.Text),
                New SqlParameter("@ParamCRNumber", txt_CRNumber.Text),
                New SqlParameter("@ParamtransactedBy", MainMenu.App_User_Name.Caption),
                New SqlParameter("@ParamAccountNumber", lbl_AccountNumber.Text),
                New SqlParameter("@ParamLedgerSetNumber", lbl_LedgerSetNumber.Text),
                New SqlParameter("@ParambranchCode", lv_Parts.Items(x).SubItems(0).Text),
                New SqlParameter("@ParamQuantity", lv_Parts.Items(x).SubItems(1).Text),
                New SqlParameter("@ParamquantityUnit", lv_Parts.Items(x).SubItems(2).Text),
                New SqlParameter("@ParamDescriptions", lv_Parts.Items(x).SubItems(3).Text),
                New SqlParameter("@ParamUnitPrice", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(4).Text), 2)),
                New SqlParameter("@ParamGrossTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(5).Text), 2)),
                New SqlParameter("@ParamSalesDiscount", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(6).Text), 2)),
                New SqlParameter("@ParamSalesDiscount_PCT", lv_Parts.Items(x).SubItems(7).Text),
                New SqlParameter("@ParamDiscounted_SRP", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(8).Text), 2)),
                New SqlParameter("@ParamSubTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(9).Text), 2)),
                New SqlParameter("@ParamPrev_ID", lv_Parts.Items(x).SubItems(10).Text),
                New SqlParameter("@ParampartsNumber", lv_Parts.Items(x).SubItems(11).Text),
                New SqlParameter("@ParampartsName", lv_Parts.Items(x).SubItems(12).Text)
            }

            class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_SubtractToSales_Freebies", "Sales Freebies")
        Next
        MsgBox("Spare Parts Posted!", vbInformation, Application.CompanyName)
    End Sub

    Private Sub lv_Parts_DoubleClick(sender As Object, e As EventArgs) Handles lv_Parts.DoubleClick
        lv_Parts.Items.RemoveAt(lv_Parts.SelectedIndices(0))
        LV_PARTS_Total()
    End Sub

    Sub LV_PARTS_Total()
        Dim TotalSum As Double = 0
        Dim Sum As ListViewItem

        For Each Sum In lv_Parts.Items
            TotalSum += CDbl(Sum.SubItems.Item(9).Text)
        Next
        lbl_Total.Text = TotalSum
    End Sub

    Private Sub btn_Bill_Click(sender As Object, e As EventArgs) Handles btn_Bill.Click
        If txt_TransCode.Text = "SALFRE" Then
            SPA_Customer_Freebie.ShowDialog()
        Else
            SPA_Search_CIF.lbl_Type.Text = Me.Text
            SPA_Search_CIF.ShowDialog()
        End If
    End Sub

    Private Sub toolSave_Click(sender As Object, e As EventArgs) Handles toolSave.Click
        Searching_For_Duplication()
    End Sub

    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            SPA_Search_Sales.Show()
            SPA_Search_Sales.txt_Search.Text = txt_Search.Text
            SPA_Search_Sales.Show_SPA_Find_InventoryforSales()
        End If
    End Sub

    Private Sub cmb_TransCategory_EditValueChanged(sender As Object, e As EventArgs) Handles cmb_TransCategory.EditValueChanged
        SPA_Show_Mnemonic()
        Show_InvoicesTransaction()

        If cmb_TransCategory.EditValue = "CHARGE INVOICE" Then
            cmb_Terms.Enabled = True
        ElseIf cmb_TransCategory.EditValue = "ADS & PROMOS" Then
            txt_CustName.EditValue = "SAGA MOTORS CORP."
            txt_CustName.Width = 774
            btn_Bill.Visible = False
            cmb_Terms.Enabled = False
            txt_Address.ReadOnly = False
            cmb_Terms.Enabled = False
            cmb_Terms.Text = "0"
            btn_Bill.Visible = True
            txt_CustName.Width = 726
        Else
            cmb_Terms.Enabled = False
        End If
    End Sub

    Sub Clear_txt()
        cmb_TransCategory.Text = String.Empty
        txt_TransCode.Text = String.Empty
        txt_CustName.Text = String.Empty
        txt_Address.Text = String.Empty
        txt_SINo.Text = String.Empty
        cmb_SI_Code.Text = String.Empty
        txt_Note.Text = String.Empty
        txt_partsNumber.Text = String.Empty
        txt_partsName.Text = String.Empty
        cmb_Terms.Text = "0"
        cmb_Pricing.Text = "1"
        lbl_Tendered.Text = "0.00"
        lbl_AmountPaid.Text = "0.00"
        lbl_Total.Text = "0.00"
        lbl_Change.Text = "0.00"
        lv_Parts.Items.Clear()
        lbl_CustDep.Text = "0.00"
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim TitleFont As New Font("calibri", 10, FontStyle.Bold)
        Dim BodyFont As New Font("calibri", 10, FontStyle.Regular)
        Dim NameFont As New Font("calibri", 12, FontStyle.Regular)
        Dim BodyFont2 As New Font("calibri", 14, FontStyle.Bold)
        Dim BodyFontAMT As New Font("calibri", 10, FontStyle.Regular)
        Dim format As New StringFormat(StringFormatFlags.DirectionRightToLeft)
        Dim Money As String = FormatNumber(lbl_TotalAmount1.Text, 2, , , TriState.True)

        Dim FirstColAmt As Integer = 200
        Dim SecondColAmt As Integer = 410
        Dim H As Integer = 0
        H = 55
        'e.Graphics.DrawString("Full Feb. 2500 Full march 2500 Full April 2500 Full may 2500 Par. June 250", BodyFont, Brushes.Black, New Rectangle(15, H, e.Graphics.VisibleClipBounds.Width - 610, e.Graphics.VisibleClipBounds.Height - 140))
        ' e.Graphics.DrawString("D/P", NameFont, Brushes.Black, 35, H)
        e.Graphics.DrawString(dtp_Date1.Text, BodyFont, Brushes.Black, 360, H)
        H += 35

        e.Graphics.DrawString(txt_Custname1.Text, NameFont, Brushes.Black, 50, H)
        H += 35

        e.Graphics.DrawString(txt_Address1.Text, NameFont, Brushes.Black, 50, H)
        H += 50

        'e.Graphics.DrawString("Bon Jovie P. Belonghilot", NameFont, Brushes.Black, 115, H)
        'H += 25

        For Each Itm As ListViewItem In lv_Parts1.Items
            'e.Graphics.DrawString(Itm.Text, New Drawing.Font("Calibri", 10), Brushes.Black, 50, H)
            e.Graphics.DrawString(Itm.SubItems(1).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 22, H) '80
            e.Graphics.DrawString(Itm.SubItems(2).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 20, H)
            e.Graphics.DrawString(Itm.SubItems(3).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 42, H)
            e.Graphics.DrawString(Itm.SubItems(5).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 320, H)
            e.Graphics.DrawString(Itm.SubItems(9).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 380, H)
            'e.Graphics.DrawString(Itm.SubItems(6).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 600, H)
            'e.Graphics.DrawString(Itm.SubItems(7).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 700, H)
            H += 17
        Next
        H += 13
        e.Graphics.DrawString("TOTAL AMT PAID ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(Math.Round(Val(lbl_AmountPaid1.Text), 2), BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("CUSTOMER DEPOSIT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(Math.Round(Val(lbl_CustDep.Text), 2), BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("LESS VAT ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(Math.Round(Val(lbl_lessVAT.Text), 2), BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("AMT NET OF VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(Math.Round(Val(lbl_NetVat.Text), 2), BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
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
        e.Graphics.DrawString(Math.Round(Val(lbl_lessVAT.Text), 2), BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("ADD VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(lbl_AddVAT.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("Amount Due ", TitleFont, Brushes.Black, 40, H)
        e.Graphics.DrawString(Money, TitleFont, Brushes.Black, 380, H, format)
        H += 20 '

        e.Graphics.DrawString("Note: ", TitleFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_Note1.Text, TitleFont, Brushes.Black, 90, H)
        H += 20 '

        e.Graphics.DrawString("Transaction Category: ", TitleFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(cmb_TransCategory.Text, TitleFont, Brushes.Black, 220, H)
        H += 20 '

        e.Graphics.DrawString("Printed by: ", TitleFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(MainMenu.App_Full_Name.Caption, TitleFont, Brushes.Black, 90, H)
        e.Graphics.DrawString("Printed Date: ", TitleFont, Brushes.Black, 260, H)
        e.Graphics.DrawString(MainMenu.dateStatus.Caption, TitleFont, Brushes.Black, 340, H)

    End Sub

    Sub Print()
        If txt_SINo.Text = String.Empty Then
            MsgBox("Please Supply S.I. Number Before Printing.", vbExclamation, Application.CompanyName)
        Else
            SPA_Find_SINo_Sales()
        End If

        With PrintDocument1
            .DefaultPageSettings.Landscape = False
        End With

        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        With PrintPreviewDialog1
            .PrintPreviewControl.Width = FormWindowState.Maximized
            .PrintPreviewControl.AutoZoom = True
            .ShowDialog()
        End With
    End Sub

    Private Sub toolPrint_Click(sender As Object, e As EventArgs) Handles toolPrint.Click
        Print()
    End Sub

    Private Sub toolNew_Click(sender As Object, e As EventArgs) Handles toolNew.Click
        Clear_txt()
    End Sub

    Sub Searching_For_Duplication()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamSINo", txt_SINo.Text),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_SINo_avoid_Dup")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                If myDataReader.Item("Status").ToString() = "0" Then
                    If cmb_TransCategory.Text = String.Empty Or txt_TransCode.Text = String.Empty Or txt_CustName.Text = String.Empty Or txt_Address.Text = String.Empty Or
                    txt_SINo.Text = String.Empty Or cmb_SI_Code.Text = String.Empty Or txt_Note.Text = String.Empty Then
                        MsgBox("SOME FIELDS ARE EMPTY, PLEASE FILL UP THEM.", vbCritical, Application.CompanyName)
                    ElseIf cmb_TransCategory.Text = "CASH INVOICE" And (lbl_AmountPaid.Text = "0.00" Or lbl_AmountPaid.Text = "0") Then
                        MsgBox("PLEASE INPUT PAYMENT BEFORE 'POSTING'.", vbCritical, Application.CompanyName)
                        SPA_InputAmount.Show()
                        SPA_InputAmount.txt_AmountDue.Text = Val(lbl_Total.Text)
                        SPA_InputAmount.lbl_CustDepAmount.Text = Val(lbl_CustDep.Text)
                        SPA_InputAmount.txt_Tendered.Focus()
                        SPA_InputAmount.txt_Type.EditValue = Me.Text
                    ElseIf cmb_TransCategory.Text = "CASH INVOICE" And lbl_AmountPaid.Text < lbl_Total.Text Then
                        MsgBox("AMOUNT PAID IS LESSER THAN TOTAL AMOUNT DUE.", vbCritical, Application.CompanyName)
                        SPA_InputAmount.Show()
                        SPA_InputAmount.txt_AmountDue.Text = lbl_Total.Text
                        SPA_InputAmount.txt_AmountPaid.Text = lbl_AmountPaid.Text
                        SPA_InputAmount.txt_Tendered.Text = lbl_Tendered.Text
                        SPA_InputAmount.txt_Tendered.Focus()
                        SPA_InputAmount.txt_Type.EditValue = Me.Text
                    ElseIf txt_SINo.Text = "Already Exists!" Then
                        MsgBox("S.I. Number Already Exists!")
                    Else
                        If cmb_TransCategory.EditValue = "CHARGE INVOICE" And chkVAT.Checked = True Then
                            SPA_SubtractToSales_Charge()
                            toolPrint.Enabled = True

                        ElseIf cmb_TransCategory.EditValue = "CHARGE INVOICE" And cmb_SI_Code.EditValue = "SUB-DEALER" And chkNonVAT.Checked Or cmb_TransCategory.EditValue = "CHARGE INVOICE" And cmb_SI_Code.EditValue = "AP EMPLOYEES" And chkNonVAT.Checked = True Then
                            SPA_SubtractToSales_NonVAT()
                            toolPrint.Enabled = True

                        ElseIf txt_TransCode.EditValue = "SALFRE" Then
                            SPA_SubtractToSales_Cash()
                            SPA_SubtractToSales_Freebies()
                            toolPrint.Enabled = True
                        Else
                            SPA_SubtractToSales_Cash()
                            toolPrint.Enabled = True
                        End If
                    End If
                End If
            End If
        End Using
        Print()
    End Sub

    Private Sub txt_ID_EditValueChanged(sender As Object, e As EventArgs) Handles txt_ID.EditValueChanged
        Show_InvoicesTransaction()
    End Sub

    Private Sub txt_CustName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_CustName.SelectedIndexChanged
        SPA_ShowSubDealers_Address()
    End Sub

    Private Sub cmb_SI_Code_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SI_Code.SelectedIndexChanged
        If cmb_SI_Code.EditValue = "SUB-DEALER" And cmb_TransCategory.EditValue = "CHARGE INVOICE" Then
            SPA_ShowSubDealers()
            txt_CustName.Enabled = True
            btn_Bill.Enabled = False
        ElseIf cmb_SI_Code.EditValue = "SUB-DEALER" And cmb_TransCategory.EditValue = "CASH INVOICE" Then
            SPA_ShowSubDealers()
            txt_CustName.Enabled = True
            btn_Bill.Enabled = False
        Else
            txt_CustName.Enabled = False
            btn_Bill.Enabled = True
        End If
    End Sub

    Private Sub lbl_Total_TextChanged(sender As Object, e As EventArgs) Handles lbl_Total.TextChanged
        SPA_InputAmount.txt_AmountDue.Text = lbl_Total.Text
    End Sub

    Private Sub chkVAT_CheckedChanged(sender As Object, e As EventArgs) Handles chkVAT.CheckedChanged
        If chkVAT.Checked = True Then
            lbl_Tamount.Text = Math.Round(Val(lbl_Total.Text), 2)
            lbl_totalLess.Text = Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2)
            lbl_TotalLess1.Text = Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2)
            lbl_NetVat.Text = Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2)
            lbl_lessVAT.Text = Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2)
        ElseIf chkVAT.Checked = True Then
            lbl_Tamount.Text = Math.Round(Val(lbl_Total.Text), 2)
            lbl_NetVat.Text = "0"
            lbl_lessVAT.Text = "0"
        End If
    End Sub

    Private Sub chkNonVAT_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonVAT.CheckedChanged
        If chkNonVAT.Checked = True Then
            lbl_Tamount.Text = Math.Round(Val(lbl_Total.Text), 2)
            lbl_NetVat.Text = "0"
            lbl_lessVAT.Text = "0"
        ElseIf chkNonVAT.Checked = True Then
            lbl_Tamount.Text = Math.Round(Val(lbl_Total.Text), 2)
            lbl_totalLess.Text = Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2)
            lbl_TotalLess1.Text = Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2)
            lbl_NetVat.Text = Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2)
            lbl_lessVAT.Text = Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2)
        End If
    End Sub

    Private Sub lbl_AmountPaid_TextChanged(sender As Object, e As EventArgs) Handles lbl_AmountPaid.TextChanged
        lbl_Tamount.Text = Math.Round(Val(lbl_AmountPaid.Text), 2)
        lbl_totalLess.Text = Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2)
        lbl_TotalLess1.Text = Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2)
        lbl_NetVat.Text = Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2)
        lbl_lessVAT.Text = Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2)
    End Sub

    Private Sub cmb_TransCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_TransCategory.SelectedIndexChanged
        If cmb_TransCategory.EditValue = "CUST DEP" Then
            cmb_Terms.EditValue = "10"
        End If
    End Sub

    Private Sub txt_CRNumber_EditValueChanged(sender As Object, e As EventArgs) Handles txt_CRNumber.EditValueChanged
        SPA_Find_CRNo_CustDep()
    End Sub

End Class