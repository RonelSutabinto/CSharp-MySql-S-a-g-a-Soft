Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports wSClassLib.myModules

'(2020-06-07) Adding Sales Freebies Stored Procedures |Sub SPA_SubtractToSales_Freebies()|

Public Class SPA_Sales
    Dim sBrCode, sBrand, sCategory, sPartNumber, sPartName, sType As String
    Dim iQuantity, iCartons, iBatch_Id, iId_Initial As Integer
    Dim dSRP, dRebates, dAmountPaid As Decimal
    Dim dUnitCost As Decimal = 0

    Sub SPA_AccountCode()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmb_TransCategory.Properties.Items.Clear()
        cmd.CommandText = "SPA_AccountCode"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnectSpareParts
        cmd.Parameters.AddWithValue("@ParamIsCommand", Me.Text)

        SPConnectSpareParts.Open()
        rs = cmd.ExecuteReader()
        Do While rs.Read
            cmb_TransCategory.Properties.Items.Add(rs.Item("Transactions").ToString)
        Loop

out:

outs:
outs1:  rs.Close()
        SPConnectSpareParts.Close()
    End Sub

    Sub Load_SIno()

        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "SPA_SalesSINo"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnectSpareParts
        cmd.Parameters.AddWithValue("@ParamTransCategory", cmb_TransCategory.EditValue)
        cmd.Parameters.AddWithValue("@ParamBranchCode", class_Saga_Variables.sBranchCode)

        SPConnectSpareParts.Open()
        rs = cmd.ExecuteReader()
        If rs.Read Then
            txt_SINo.EditValue = rs.Item("Refno").ToString()
        End If

out:

outs:
outs1:  rs.Close()
        SPConnectSpareParts.Close()
    End Sub

    Sub SPA_Find_SINo_Sales()
        'On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs3 As SqlDataReader
        lv_Parts1.Items.Clear()
        cmd.CommandText = "SPA_Find_SINo_Sales"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnectSpareParts
        cmd.Parameters.AddWithValue("@ParamSINo", txt_SINo.Text)
        cmd.Parameters.AddWithValue("@ParamBranchCode", class_Saga_Variables.sBranchCode)

        SPConnectSpareParts.Open()
        rs3 = cmd.ExecuteReader()
        Do While rs3.Read
            Dim li As ListViewItem = lv_Parts1.Items.Add(rs3.Item("BranchCode").ToString())
            li.SubItems.Add(rs3.Item("Quantity").ToString().Trim())
            li.SubItems.Add(rs3.Item("QuantityUnit").ToString().Trim())
            li.SubItems.Add(rs3.Item("Descriptions").ToString().Trim())
            li.SubItems.Add(rs3.Item("UnitPrice").ToString().Trim())
            li.SubItems.Add(rs3.Item("Discounted_SRP").ToString().Trim())
            li.SubItems.Add(rs3.Item("GrossTotal").ToString().Trim())
            li.SubItems.Add(rs3.Item("SalesDiscount").ToString().Trim())
            li.SubItems.Add(rs3.Item("SalesDiscount_PCT").ToString().Trim())
            li.SubItems.Add(rs3.Item("subTotal").ToString().Trim())
            li.SubItems.Add(rs3.Item("Prev_ID").ToString().Trim())
            li.SubItems.Add(rs3.Item("PartsNumber").ToString().Trim())
            li.SubItems.Add(rs3.Item("PartsName").ToString().Trim())

            txt_Custname1.Text = rs3.Item("custName").ToString.Trim()
            txt_Address1.Text = rs3.Item("custAddress").ToString.Trim()
            dtp_Date1.Text = rs3.Item("PostingDate").ToString.Trim()
            lbl_TotalAmount1.Text = rs3.Item("GrandTotal").ToString.Trim()
            lbl_AmountPaid1.Text = rs3.Item("AmountPaid").ToString.Trim()
            lbl_lessVAT.Text = rs3.Item("VAT").ToString.Trim()
            lbl_NetVat.Text = rs3.Item("AmntNetOfVat").ToString.Trim()
            lbl_lessVAT.Text = rs3.Item("VAT").ToString.Trim()
            txt_Note1.Text = rs3.Item("Note").ToString.Trim()

        Loop

out:

outs:
        rs3.Close()
        SPConnectSpareParts.Close()
    End Sub

    Sub SPA_Find_CRNo_CustDep()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "SPA_Find_CRNo_CustDep"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnectSpareParts
        cmd.Parameters.AddWithValue("@ParamCRNo", txt_CRNumber.Text)
        cmd.Parameters.AddWithValue("@ParamBranchCode", class_Saga_Variables.sBranchCode)

        SPConnectSpareParts.Open()
        rs = cmd.ExecuteReader()
        Do While rs.Read
            lbl_CustDep.Text = rs.Item("AmountDue").ToString
            SPA_InputAmount.lbl_CustDepAmount.Text = rs.Item("AmountDue").ToString

        Loop

out:

outs:
outs1:  rs.Close()
        SPConnectSpareParts.Close()
    End Sub

    Sub SPA_Show_LedgerCode()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmb_TransCategory.Properties.Items.Clear()
        cmd.CommandText = "SPA_ShowcustCode_Ledger"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnectSpareParts
        cmd.Parameters.AddWithValue("@ParamBranchCode", class_Saga_Variables.sBranchCode)

        SPConnectSpareParts.Open()
        rs = cmd.ExecuteReader()
        Do While rs.Read
            txt_custCodeLedger.EditValue = rs.Item("SPA_LedgerCode").ToString
        Loop

out:

outs:
outs1:  rs.Close()
        SPConnectSpareParts.Close()
    End Sub

    Sub SPA_ShowSubDealers_Address()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "SPA_ShowSubDealers_Address"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnectSpareParts
        cmd.Parameters.AddWithValue("@ParamSubName", txt_CustName.EditValue)

        SPConnectSpareParts.Open()
        rs = cmd.ExecuteReader()
        Do While rs.Read
            txt_Address.EditValue = rs.Item("SubAddress").ToString
        Loop

out:

outs:
outs1:  rs.Close()
        SPConnectSpareParts.Close()
    End Sub

    Sub SPA_ShowSubDealers()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmb_TransCategory.Properties.Items.Clear()
        cmd.CommandText = "SPA_ShowSubDealers"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnectSpareParts
        cmd.Parameters.AddWithValue("@ParamIsCommand", cmb_SI_Code.EditValue)

        SPConnectSpareParts.Open()
        rs = cmd.ExecuteReader()
        Do While rs.Read
            txt_CustName.Properties.Items.Add(rs.Item("SubName").ToString)
        Loop

out:

outs:
outs1:  rs.Close()
        SPConnectSpareParts.Close()
    End Sub

    Sub Show_InvoicesTransaction()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmb_SI_Code.Properties.Items.Clear()
        cmd.CommandText = "SPA_Show_Invoices"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnectSpareParts
        cmd.Parameters.AddWithValue("@ParamID", txt_ID.EditValue)

        SPConnectSpareParts.Open()
        rs = cmd.ExecuteReader()
        Do While rs.Read
            'MsgBox(rs.Item("Invoices").ToString)
            cmb_SI_Code.Properties.Items.Add(rs.Item("Invoices").ToString)
        Loop
out:
outs:
outs1:  rs.Close()
        SPConnectSpareParts.Close()
    End Sub

    Sub SPA_Show_Mnemonic()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "SPA_Show_Mnemonic"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnectSpareParts
        cmd.Parameters.AddWithValue("@ParamTransactions", cmb_TransCategory.EditValue)

        SPConnectSpareParts.Open()
        rs = cmd.ExecuteReader()
        Do While rs.Read
            txt_TransCode.EditValue = rs.Item("Mnemonic").ToString
            txt_ID.EditValue = rs.Item("TransactionID").ToString
        Loop

out:

outs:
outs1:  rs.Close()
        SPConnectSpareParts.Close()
    End Sub

    Private Sub SPA_Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Procedures.Initialize_GridView(GridView, True, True)
        panelRight.Visible = True
        SPA_Show_LedgerCode()
        dtp_Date.EditValue = DateTime.Today
        SPA_AccountCode()
    End Sub

    Private Sub SPA_Sales_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Load_Items()
    End Sub
    Private Sub GridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        If e.Clicks.Equals(2) AndAlso GridView.DataRowCount > 0 Then
            Select Case e.Column.FieldName
                Case "supplier_code"
                Case Else
                    class_Procedures.Copy_Clipboard(e.CellValue.ToString)
            End Select
        End If
    End Sub
    Private Sub GridView_Items_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles GridView.KeyDown
        With GridView
            Select Case e.KeyCode
                Case Keys.Insert
                    .AddNewRow()

                Case Keys.Delete
                    If (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                    Dim view As GridView = CType(sender, GridView)
                    view.DeleteRow(view.FocusedRowHandle)
            End Select
        End With
    End Sub
    Private Sub RepositoryItemLookUpEdit_PartsNumber_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit_PartsNumber.EditValueChanged
        Try
            sPartNumber = CType(sender, BaseEdit).EditValue.ToString
        Catch ex As Exception
        End Try
    End Sub
    Private Sub RepositoryItemLookUpEdit_PartsNumber_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_PartsNumber.Validating
        Try
            Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)


            sPartNumber = editor.GetColumnValue("PartsNumber").ToString()
            GridView.SetFocusedRowCellValue(colPartsNumber, sPartNumber)

            sPartName = editor.GetColumnValue("PartsName").ToString()
            GridView.SetFocusedRowCellValue(colPartsName, sPartName)

            sCategory = editor.GetColumnValue("Category").ToString()
            GridView.SetFocusedRowCellValue(colCategory, sCategory)

            sBrand = editor.GetColumnValue("Brand").ToString()
            GridView.SetFocusedRowCellValue(colBrand, sBrand)

            dSRP = CDec(editor.GetColumnValue("SRP"))
            GridView.SetFocusedRowCellValue(colSRP, dSRP)

            dUnitCost = CDec(editor.GetColumnValue("SPCostWOVAT"))
            GridView.SetFocusedRowCellValue(colCost, dUnitCost)

            iQuantity = 0
            GridView.SetFocusedRowCellValue(colQuantity, iQuantity)

            iId_Initial = 0
            GridView.SetFocusedRowCellValue(colID2, iId_Initial)

            dRebates = 0
            GridView.SetFocusedRowCellValue(colDiscount_PCT, dRebates)

            dRebates = 0
            GridView.SetFocusedRowCellValue(colDiscount_SRP, dRebates)

            dRebates = 0
            GridView.SetFocusedRowCellValue(colGrossTotal, dRebates)

            dRebates = 0
            GridView.SetFocusedRowCellValue(colSubTotal, dRebates)

            iBatch_Id = Convert.ToInt32(editor.GetColumnValue("id"))
            GridView.SetFocusedRowCellValue(colID, iBatch_Id)


        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub RepositoryItemSpinEdit_Quantity_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemSpinEdit_Quantity.EditValueChanged
        Try
            iQuantity = Convert.ToInt32(CType(sender, BaseEdit).EditValue)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView.CellValueChanged
        Try
            With GridView
                Select Case e.Column.Name
                    Case "colQuantity"
                        Dim dGrossTotal As Decimal = CDec(.GetFocusedRowCellValue(colSRP)) * Convert.ToInt32(.GetFocusedRowCellValue(colQuantity))
                        Dim dSubTotal As Decimal = CDec(.GetFocusedRowCellValue(colDiscount_SRP)) * Convert.ToInt32(.GetFocusedRowCellValue(colQuantity))
                        .SetRowCellValue(e.RowHandle, colGrossTotal, CDbl(dGrossTotal))
                        .SetRowCellValue(e.RowHandle, colSubTotal, CDbl(dSubTotal))
                    Case "colDiscount_PCT"
                        Dim dDiscount As Decimal = CDec(.GetFocusedRowCellValue(colSRP)) * (CDec(.GetFocusedRowCellValue(colDiscount_PCT)) / 100)
                        Dim dTotalDiscount As Decimal = CDec(.GetFocusedRowCellValue(colSRP)) - dDiscount
                        .SetRowCellValue(e.RowHandle, colDiscount_SRP, CDbl(dTotalDiscount))
                    Case "colGrossTotal"
                    Case "colCost"
                        dUnitCost = CDec(.GetFocusedRowCellValue(colCost))
                End Select
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub
    Private Sub Customer_Name_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEdit_Name.EditValueChanged
        If txt_TransCode.EditValue.Equals("SALFRE") Then
            txt_Address.EditValue = LookUpEdit_Name.GetColumnValue("AccountAddress")
        ElseIf cmb_SI_Code.EditValue.Equals("SUB-DEALER") Then
            txt_Address.EditValue = LookUpEdit_Name.GetColumnValue("SubAddress")
        Else
            txt_Address.EditValue = LookUpEdit_Name.GetColumnValue("Address")

        End If
    End Sub
    Sub Total()


    End Sub
    Private Sub btn_Payment_Click(sender As Object, e As EventArgs) Handles btn_Payment.Click
        Dim iReceived As Decimal = CDec(GridView.Columns("GrossTotal").SummaryItem.SummaryValue)
        Dim iRemaining = iQuantity - iReceived
        dAmountPaid = CDec(class_Functions.Show_Input_Box("Input Payment", "Payment", iReceived))

        If dAmountPaid <= 0 OrElse dAmountPaid > iReceived Then
            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Invalid Number.{Environment.NewLine}Please input actual Payment 1 to {iReceived}", "Number Error", True)
            Return
        End If
        lbl_Change.Text = CStr(Math.Round(Val(dAmountPaid), 2) - Math.Round(Val(GridView.Columns("GrossTotal").SummaryItem.SummaryValue), 2))
        If Val(GridView.Columns("GrossTotal").SummaryItem.SummaryValue) <= Val(dAmountPaid) Then
            lbl_AmountPaid.Text = CStr(Math.Round(Val(GridView.Columns("GrossTotal").SummaryItem.SummaryValue), 2))
        Else
            lbl_AmountPaid.Text = CStr(Math.Round(Val(dAmountPaid), 2))
        End If
        lbl_Tendered.Text = CStr(dAmountPaid)
        If lbl_Change.Text < "0" Then
            lbl_Change.Text = "0"
        End If
    End Sub
    Private Sub cmb_SI_Code_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SI_Code.SelectedIndexChanged
        If cmb_SI_Code.EditValue.Equals("SUB-DEALER") And cmb_TransCategory.EditValue.Equals("CHARGE INVOICE") Then
            Initialize_SubDealer()
            Initialize_SubDealer(LookUpEdit_Name)
            txt_CustName.Enabled = True
            btn_Bill.Enabled = False
        ElseIf cmb_SI_Code.EditValue.Equals("SUB-DEALER") And cmb_TransCategory.EditValue.Equals("CASH INVOICE") Then
            Initialize_SubDealer()
            Initialize_SubDealer(LookUpEdit_Name)
            txt_CustName.Enabled = True
            btn_Bill.Enabled = False
        ElseIf txt_TransCode.EditValue.Equals("SALFRE") Then
            Initialize_Customers(class_Saga_Variables.sBranchCode)
            Initialize_Customers(LookUpEdit_Name)
        Else
            Initialize_CIFAccounts(class_Saga_Variables.sBranchCode)
            Initialize_CIFAccounts(LookUpEdit_Name)
        End If
    End Sub
    Private Sub Load_Items()
        Initialize_Parts_Numbers(class_Saga_Variables.sBranchCode)
        Initialize_Parts_Numbers(RepositoryItemLookUpEdit_PartsNumber)
        class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_PartsNumber, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)
        class_Database.Bind_Data(class_Database.SPAConnection, gridControl, GridView, $"SELECT * FROM Transaction_Collection WHERE SINo LIKE 'AMBOT12345' ORDER BY PartsNumber", "Transaction_Collection")
        class_Procedures.Initialize_GridView(GridView, True, True)
    End Sub

    '    Sub SPA_SubtractToSales_Cash()

    '        For x = 0 To lv_Parts.Items.Count - 1
    '            'IS_SALES_Release_View.cmd_showInvent.Enabled = False
    '            On Error GoTo out

    '            Dim cmd As New SqlCommand
    '            Dim rs2 As SqlDataReader

    '            cmd.CommandText = "SPA_SubtractToSales_Cash"
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Connection = SPConnectSpareParts
    '            ' SPConnectSpareParts.Open()
    '            cmd.Parameters.AddWithValue("@Paramtrans_Category", cmb_TransCategory.EditValue)
    '            cmd.Parameters.AddWithValue("@Paramtrans_Code", txt_TransCode.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamPostingDate", dtp_Date.Text)
    '            cmd.Parameters.AddWithValue("@ParamcustName", txt_CustName.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamcustAddress", txt_Address.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamSINo", txt_SINo.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamSI_Code", cmb_SI_Code.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamNote", txt_Note.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamTerms", cmb_Terms.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamPricing", cmb_Pricing.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamGrandTotal", lbl_Total.Text)
    '            cmd.Parameters.AddWithValue("@ParamAmountPaid", lbl_AmountPaid.Text)
    '            cmd.Parameters.AddWithValue("@ParamCustCode", txt_custCodeLedger.Text)
    '            cmd.Parameters.AddWithValue("@ParamCRNumber", txt_CRNumber.Text)
    '            cmd.Parameters.AddWithValue("@ParamtransactedBy", class_Variables.sUserName)
    '            cmd.Parameters.AddWithValue("@ParamAccountNumber", lbl_AccountNumber.Text)
    '            cmd.Parameters.AddWithValue("@ParamLedgerSetNumber", lbl_LedgerSetNumber.Text)

    '            cmd.Parameters.AddWithValue("@ParambranchCode", lv_Parts.Items(x).SubItems(0).Text)
    '            cmd.Parameters.AddWithValue("@ParamQuantity", lv_Parts.Items(x).SubItems(1).Text)
    '            cmd.Parameters.AddWithValue("@ParamquantityUnit", lv_Parts.Items(x).SubItems(2).Text)
    '            cmd.Parameters.AddWithValue("@ParamDescriptions", lv_Parts.Items(x).SubItems(3).Text)
    '            cmd.Parameters.AddWithValue("@ParamUnitPrice", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(4).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamGrossTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(5).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamSalesDiscount", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(6).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamSalesDiscount_PCT", lv_Parts.Items(x).SubItems(7).Text)
    '            cmd.Parameters.AddWithValue("@ParamDiscounted_SRP", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(8).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamSubTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(9).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamPrev_ID", lv_Parts.Items(x).SubItems(10).Text)
    '            cmd.Parameters.AddWithValue("@ParampartsNumber", lv_Parts.Items(x).SubItems(11).Text)
    '            cmd.Parameters.AddWithValue("@ParampartsName", lv_Parts.Items(x).SubItems(12).Text)

    '            SPConnectSpareParts.Open()

    '            rs2 = cmd.ExecuteReader()

    '            If rs2.Read Then
    '                'MsgBox(rs.Item("Message"), vbCritical, Application.CompanyName)
    '            End If
    '            rs2.Close()
    '            SPConnectSpareParts.Close()
    '        Next
    '        MsgBox("Spare Parts Posted!", vbInformation, Application.CompanyName)
    '        GoTo outs

    'out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

    '        GoTo outs1
    '        SPConnectSpareParts.Close()

    'outs:
    'outs1:
    '    End Sub

    '    Sub SPA_SubtractToSales_Charge()

    '        For x = 0 To lv_Parts.Items.Count - 1
    '            'IS_SALES_Release_View.cmd_showInvent.Enabled = False
    '            On Error GoTo out

    '            Dim cmd As New SqlCommand
    '            Dim rs2 As SqlDataReader

    '            cmd.CommandText = "SPA_SubtractToSales_Charge"
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Connection = SPConnectSpareParts

    '            cmd.Parameters.AddWithValue("@Paramtrans_Category", cmb_TransCategory.EditValue)
    '            cmd.Parameters.AddWithValue("@Paramtrans_Code", txt_TransCode.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamPostingDate", dtp_Date.Text)
    '            cmd.Parameters.AddWithValue("@ParamcustName", txt_CustName.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamcustAddress", txt_Address.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamSINo", txt_SINo.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamSI_Code", cmb_SI_Code.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamNote", txt_Note.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamTerms", cmb_Terms.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamPricing", cmb_Pricing.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamGrandTotal", lbl_Total.Text)
    '            cmd.Parameters.AddWithValue("@ParamAmountPaid", lbl_AmountPaid.Text)
    '            cmd.Parameters.AddWithValue("@ParamCustCode", txt_custCodeLedger.Text)
    '            cmd.Parameters.AddWithValue("@ParamCRNumber", txt_CRNumber.Text)
    '            cmd.Parameters.AddWithValue("@ParamtransactedBy", class_Variables.sUserName)

    '            cmd.Parameters.AddWithValue("@ParambranchCode", lv_Parts.Items(x).SubItems(0).Text)
    '            cmd.Parameters.AddWithValue("@ParamQuantity", lv_Parts.Items(x).SubItems(1).Text)
    '            cmd.Parameters.AddWithValue("@ParamquantityUnit", lv_Parts.Items(x).SubItems(2).Text)
    '            cmd.Parameters.AddWithValue("@ParamDescriptions", lv_Parts.Items(x).SubItems(3).Text)
    '            cmd.Parameters.AddWithValue("@ParamUnitPrice", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(4).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamGrossTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(5).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamSalesDiscount", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(6).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamSalesDiscount_PCT", lv_Parts.Items(x).SubItems(7).Text)
    '            cmd.Parameters.AddWithValue("@ParamDiscounted_SRP", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(8).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamSubTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(9).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamPrev_ID", lv_Parts.Items(x).SubItems(10).Text)
    '            cmd.Parameters.AddWithValue("@ParampartsNumber", lv_Parts.Items(x).SubItems(11).Text)
    '            cmd.Parameters.AddWithValue("@ParampartsName", lv_Parts.Items(x).SubItems(12).Text)

    '            SPConnectSpareParts.Open()

    '            rs2 = cmd.ExecuteReader()

    '            If rs2.Read Then
    '                ' MsgBox(rs.Item("Message"), vbCritical, Application.CompanyName)
    '            End If
    '            rs2.Close()
    '            SPConnectSpareParts.Close()
    '        Next
    '        MsgBox("Spare Parts Posted!", vbInformation, Application.CompanyName)
    '        GoTo outs

    'out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

    '        GoTo outs1
    '        SPConnectSpareParts.Close()
    'outs:
    'outs1:
    '    End Sub

    '    Sub SPA_SubtractToSales_NonVAT()

    '        For x = 0 To lv_Parts.Items.Count - 1
    '            'IS_SALES_Release_View.cmd_showInvent.Enabled = False
    '            On Error GoTo out

    '            Dim cmd As New SqlCommand
    '            Dim rs2 As SqlDataReader

    '            cmd.CommandText = "SPA_SubtractToSales_NonVAT"
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Connection = SPConnectSpareParts

    '            cmd.Parameters.AddWithValue("@Paramtrans_Category", cmb_TransCategory.EditValue)
    '            cmd.Parameters.AddWithValue("@Paramtrans_Code", txt_TransCode.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamPostingDate", dtp_Date.Text)
    '            cmd.Parameters.AddWithValue("@ParamcustName", txt_CustName.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamcustAddress", txt_Address.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamSINo", txt_SINo.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamSI_Code", cmb_SI_Code.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamNote", txt_Note.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamTerms", cmb_Terms.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamPricing", cmb_Pricing.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamGrandTotal", lbl_Total.Text)
    '            cmd.Parameters.AddWithValue("@ParamAmountPaid", lbl_AmountPaid.Text)
    '            cmd.Parameters.AddWithValue("@ParamCustCode", txt_custCodeLedger.Text)
    '            cmd.Parameters.AddWithValue("@ParamCRNumber", txt_CRNumber.Text)
    '            cmd.Parameters.AddWithValue("@ParamtransactedBy", class_Variables.sUserName)
    '            cmd.Parameters.AddWithValue("@ParamAccountNumber", lbl_AccountNumber.Text)
    '            cmd.Parameters.AddWithValue("@ParamLedgerSetNumber", lbl_LedgerSetNumber.Text)

    '            cmd.Parameters.AddWithValue("@ParambranchCode", lv_Parts.Items(x).SubItems(0).Text)
    '            cmd.Parameters.AddWithValue("@ParamQuantity", lv_Parts.Items(x).SubItems(1).Text)
    '            cmd.Parameters.AddWithValue("@ParamquantityUnit", lv_Parts.Items(x).SubItems(2).Text)
    '            cmd.Parameters.AddWithValue("@ParamDescriptions", lv_Parts.Items(x).SubItems(3).Text)
    '            cmd.Parameters.AddWithValue("@ParamUnitPrice", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(4).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamGrossTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(5).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamSalesDiscount", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(6).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamSalesDiscount_PCT", lv_Parts.Items(x).SubItems(7).Text)
    '            cmd.Parameters.AddWithValue("@ParamDiscounted_SRP", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(8).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamSubTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(9).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamPrev_ID", lv_Parts.Items(x).SubItems(10).Text)
    '            cmd.Parameters.AddWithValue("@ParampartsNumber", lv_Parts.Items(x).SubItems(11).Text)
    '            cmd.Parameters.AddWithValue("@ParampartsName", lv_Parts.Items(x).SubItems(12).Text)

    '            SPConnectSpareParts.Open()

    '            rs2 = cmd.ExecuteReader()

    '            If rs2.Read Then
    '                'MsgBox(rs.Item("Message"), vbCritical, Application.CompanyName)
    '            End If
    '            rs2.Close()
    '            SPConnectSpareParts.Close()
    '        Next
    '        MsgBox("Spare Parts Posted!", vbInformation, Application.CompanyName)
    '        GoTo outs

    'out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

    '        GoTo outs1
    '        SPConnectSpareParts.Close()

    'outs:
    'outs1:
    '    End Sub

    '    Sub SPA_SubtractToSales_Freebies()

    '        For x = 0 To lv_Parts.Items.Count - 1
    '            'IS_SALES_Release_View.cmd_showInvent.Enabled = False
    '            On Error GoTo out

    '            Dim cmd As New SqlCommand
    '            Dim rs2 As SqlDataReader

    '            cmd.CommandText = "SPA_SubtractToSales_Freebies"
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Connection = SPConnectSpareParts
    '            ' SPConnectSpareParts.Open()
    '            cmd.Parameters.AddWithValue("@Paramtrans_Category", cmb_TransCategory.EditValue)
    '            cmd.Parameters.AddWithValue("@Paramtrans_Code", txt_TransCode.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamPostingDate", dtp_Date.Text)
    '            cmd.Parameters.AddWithValue("@ParamcustName", txt_CustName.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamcustAddress", txt_Address.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamSINo", txt_SINo.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamSI_Code", cmb_SI_Code.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamNote", txt_Note.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamTerms", cmb_Terms.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamPricing", cmb_Pricing.EditValue)
    '            cmd.Parameters.AddWithValue("@ParamGrandTotal", lbl_Total.Text)
    '            cmd.Parameters.AddWithValue("@ParamAmountPaid", lbl_AmountPaid.Text)
    '            cmd.Parameters.AddWithValue("@ParamCustCode", txt_custCodeLedger.Text)
    '            cmd.Parameters.AddWithValue("@ParamCRNumber", txt_CRNumber.Text)
    '            cmd.Parameters.AddWithValue("@ParamtransactedBy", class_Variables.sUserName)
    '            cmd.Parameters.AddWithValue("@ParamAccountNumber", lbl_AccountNumber.Text)
    '            cmd.Parameters.AddWithValue("@ParamLedgerSetNumber", lbl_LedgerSetNumber.Text)

    '            cmd.Parameters.AddWithValue("@ParambranchCode", lv_Parts.Items(x).SubItems(0).Text)
    '            cmd.Parameters.AddWithValue("@ParamQuantity", lv_Parts.Items(x).SubItems(1).Text)
    '            cmd.Parameters.AddWithValue("@ParamquantityUnit", lv_Parts.Items(x).SubItems(2).Text)
    '            cmd.Parameters.AddWithValue("@ParamDescriptions", lv_Parts.Items(x).SubItems(3).Text)
    '            cmd.Parameters.AddWithValue("@ParamUnitPrice", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(4).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamGrossTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(5).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamSalesDiscount", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(6).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamSalesDiscount_PCT", lv_Parts.Items(x).SubItems(7).Text)
    '            cmd.Parameters.AddWithValue("@ParamDiscounted_SRP", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(8).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamSubTotal", Math.Round(Decimal.Parse(lv_Parts.Items(x).SubItems(9).Text), 2))
    '            cmd.Parameters.AddWithValue("@ParamPrev_ID", lv_Parts.Items(x).SubItems(10).Text)
    '            cmd.Parameters.AddWithValue("@ParampartsNumber", lv_Parts.Items(x).SubItems(11).Text)
    '            cmd.Parameters.AddWithValue("@ParampartsName", lv_Parts.Items(x).SubItems(12).Text)

    '            SPConnectSpareParts.Open()

    '            rs2 = cmd.ExecuteReader()

    '            If rs2.Read Then
    '                'MsgBox(rs.Item("Message"), vbCritical, Application.CompanyName)
    '            End If
    '            rs2.Close()
    '            SPConnectSpareParts.Close()
    '        Next
    '        MsgBox("Spare Parts Posted!", vbInformation, Application.CompanyName)
    '        GoTo outs

    'out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

    '        GoTo outs1
    '        SPConnectSpareParts.Close()

    'outs:
    'outs1:
    '    End Sub

    '    Private Sub lv_Parts_DoubleClick(sender As Object, e As EventArgs)
    '        lv_Parts.Items.RemoveAt(lv_Parts.SelectedIndices(0))
    '        LV_PARTS_Total()
    '    End Sub

    '    Sub LV_PARTS_Total()
    '        Dim TotalSum As Double = 0
    '        Dim Sum As ListViewItem

    '        For Each Sum In lv_Parts.Items
    '            TotalSum += CDbl(Sum.SubItems.Item(9).Text)
    '        Next
    '        lbl_Total.Text = CStr(TotalSum)
    '    End Sub

    Private Sub btn_Bill_Click(sender As Object, e As EventArgs) Handles btn_Bill.Click
        If txt_TransCode.Text = "SALFRE" Then
            SPA_Customer_Freebie.ShowDialog()

        Else

            SPA_Search_CIF.lbl_Type.Text = Me.Text
            SPA_Search_CIF.ShowDialog()
        End If
    End Sub

    Private Sub toolSave_Click(sender As Object, e As EventArgs) Handles btn_Save.ItemClick
        'MsgBox("he")
        Searching_For_Duplication()

    End Sub

    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'If cmb_TransCategory.Text = "CUST DEP" And cmb_SI_Code.Text = "CUST DEP" Then
            '    SPA_Search_Sales_Master.Show()
            '    SPA_Search_Sales_Master.txt_Search.Text = txt_Search.Text
            '    SPA_Search_Sales_Master.Show_SPA_Find_InventoryforSales_Master()
            'Else
            SPA_Search_Sales.Show()
            SPA_Search_Sales.Show_SPA_Find_InventoryforSales()
        End If
    End Sub

    Private Sub cmb_TransCategory_EditValueChanged(sender As Object, e As EventArgs) Handles cmb_TransCategory.EditValueChanged
        Call SPA_Show_Mnemonic()
        Call Show_InvoicesTransaction()

        If cmb_TransCategory.EditValue.Equals("CHARGE INVOICE") Then
            cmb_Terms.Enabled = True
        ElseIf cmb_TransCategory.EditValue.Equals("ADS & PROMOS") Then
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
        cmb_TransCategory.Text = ""
        txt_TransCode.Text = ""
        txt_CustName.Text = ""
        txt_Address.Text = ""
        txt_SINo.Text = ""
        cmb_SI_Code.Text = ""
        txt_Note.Text = ""
        txt_partsNumber.Text = ""
        txt_partsName.Text = ""
        cmb_Terms.Text = "0"
        cmb_Pricing.Text = "1"
        lbl_Tendered.Text = "0.00"
        lbl_AmountPaid.Text = "0.00"
        lbl_Change.Text = "0.00"
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
            'e.Graphics.DrawString(Itm.SubItems(1).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 22, H) '80
            'e.Graphics.DrawString(Itm.SubItems(2).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 20, H)
            'e.Graphics.DrawString(Itm.SubItems(3).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 42, H)
            'e.Graphics.DrawString(Itm.SubItems(5).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 320, H)
            'e.Graphics.DrawString(Itm.SubItems(9).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 380, H)
            'e.Graphics.DrawString(Itm.SubItems(6).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 600, H)
            'e.Graphics.DrawString(Itm.SubItems(7).Text, New Drawing.Font("Calibri", 10), Brushes.Black, 700, H)
            H += 17
        Next
        H += 13
        e.Graphics.DrawString("TOTAL AMT PAID ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(CStr(Math.Round(Val(lbl_AmountPaid1.Text), 2)), BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("CUSTOMER DEPOSIT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(CStr(Math.Round(Val(lbl_CustDep.Text), 2)), BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("LESS VAT ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(CStr(Math.Round(Val(lbl_lessVAT.Text), 2)), BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("AMT NET OF VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(CStr(Math.Round(Val(lbl_NetVat.Text), 2)), BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
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
        e.Graphics.DrawString(CStr(Math.Round(Val(lbl_lessVAT.Text), 2)), BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
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
        e.Graphics.DrawString(class_Variables.sUserName, TitleFont, Brushes.Black, 90, H)
        e.Graphics.DrawString("Printed Date: ", TitleFont, Brushes.Black, 260, H)
        e.Graphics.DrawString(CStr(Form_Main.barEditItem_Date_End.EditValue), TitleFont, Brushes.Black, 340, H)

    End Sub

    Sub Print()
        If txt_SINo.Text = "" Then
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

    Private Sub toolPrint_Click(sender As Object, e As EventArgs) Handles btn_Print.ItemClick
        Print()
    End Sub

    Private Sub toolNew_Click(sender As Object, e As EventArgs) Handles btn_New.ItemClick
        Clear_txt()
    End Sub

    Sub Searching_For_Duplication()
        'On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs1 As SqlDataReader

        cmd.CommandText = "SPA_Find_SINo_avoid_Dup"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnectSpareParts
        cmd.Parameters.AddWithValue("@ParamSINo", txt_SINo.Text)
        cmd.Parameters.AddWithValue("@ParamBranchCode", class_Saga_Variables.sBranchCode)

        SPConnectSpareParts.Open()
        rs1 = cmd.ExecuteReader()
        If rs1.Read Then
            If rs1.Item("Status").ToString() = "0" Then
                If cmb_TransCategory.Text = "" Or txt_TransCode.Text = "" Or txt_CustName.Text = "" Or txt_Address.Text = "" Or
            txt_SINo.Text = "" Or cmb_SI_Code.Text = "" Or txt_Note.Text = "" Then
                    MsgBox("SOME FIELDS ARE EMPTY, PLEASE FILL UP THEM.", vbCritical, Application.CompanyName)
                ElseIf cmb_TransCategory.Text = "CASH INVOICE" And (lbl_AmountPaid.Text = "0.00" Or lbl_AmountPaid.Text = "0") Then
                    MsgBox("PLEASE INPUT PAYMENT BEFORE 'POSTING'.", vbCritical, Application.CompanyName)
                    SPA_InputAmount.Show()
                    SPA_InputAmount.txt_AmountDue.Text = CStr(Val(GridView.Columns("GrossTotal").SummaryItem.SummaryValue.ToString()))
                    SPA_InputAmount.lbl_CustDepAmount.Text = CStr(Val(lbl_CustDep.Text))
                    SPA_InputAmount.txt_Tendered.Focus()
                    SPA_InputAmount.txt_Type.EditValue = Me.Text
                ElseIf cmb_TransCategory.Text = "CASH INVOICE" And lbl_AmountPaid.Text < GridView.Columns("GrossTotal").SummaryItem.SummaryValue.ToString() Then
                    MsgBox("AMOUNT PAID IS LESSER THAN TOTAL AMOUNT DUE.", vbCritical, Application.CompanyName)
                    SPA_InputAmount.Show()
                    SPA_InputAmount.txt_AmountDue.Text = GridView.Columns("GrossTotal").SummaryItem.SummaryValue.ToString()
                    SPA_InputAmount.txt_AmountPaid.Text = lbl_AmountPaid.Text
                    SPA_InputAmount.txt_Tendered.Text = lbl_Tendered.Text
                    SPA_InputAmount.txt_Tendered.Focus()
                    SPA_InputAmount.txt_Type.EditValue = Me.Text
                ElseIf txt_SINo.Text = "Already Exists!" Then
                    MsgBox("S.I. Number Already Exists!")
                Else
                    If cmb_TransCategory.EditValue.Equals("CHARGE INVOICE") And chkVAT.Checked = True Then
                        SPConnectSpareParts.Close()

                        rs1.Close()
                        'SPA_SubtractToSales_Charge()
                        btn_Print.Enabled = True
                    ElseIf cmb_TransCategory.EditValue.Equals("CHARGE INVOICE") And cmb_SI_Code.EditValue.Equals("SUB-DEALER") And chkNonVAT.Checked Or cmb_TransCategory.EditValue.Equals("CHARGE INVOICE") And cmb_SI_Code.EditValue.Equals("AP EMPLOYEES") And chkNonVAT.Checked = True Then
                        SPConnectSpareParts.Close()

                        rs1.Close()
                        'SPA_SubtractToSales_NonVAT()
                        btn_Print.Enabled = True
                    ElseIf txt_TransCode.EditValue.Equals("SALFRE") Then
                        SPConnectSpareParts.Close()

                        rs1.Close()
                        'SPA_SubtractToSales_Cash()
                        'SPA_SubtractToSales_Freebies()
                        btn_Print.Enabled = True
                    Else
                        SPConnectSpareParts.Close()

                        rs1.Close()
                        'SPA_SubtractToSales_Cash()
                        btn_Print.Enabled = True

                    End If
                    SPConnectSpareParts.Close()

                    rs1.Close()
                    Print()
                    'txt_SINo.Text = "Already Exists!"
                    'MsgBox("Does not Exists!")

                End If

            ElseIf rs1.Item("status").ToString() = "1" Then
                MsgBox(rs1.Item("Message"))
                SPConnectSpareParts.Close()
                Return
            End If
        End If
        SPConnectSpareParts.Close()

        rs1.Close()
    End Sub

    Private Sub txt_SINo_LostFocus(sender As Object, e As EventArgs) Handles txt_SINo.LostFocus
        ' Searching_For_Duplication()
    End Sub

    Private Sub txt_ID_EditValueChanged(sender As Object, e As EventArgs) Handles txt_ID.EditValueChanged
        Call Show_InvoicesTransaction()
    End Sub

    Private Sub txt_CustName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_CustName.SelectedIndexChanged
        SPA_ShowSubDealers_Address()
    End Sub


    Private Sub lbl_Total_TextChanged(sender As Object, e As EventArgs)
        SPA_InputAmount.txt_AmountDue.Text = GridView.Columns("GrossTotal").SummaryItem.SummaryValue.ToString()
    End Sub

    Private Sub chkVAT_CheckedChanged(sender As Object, e As EventArgs) Handles chkVAT.CheckedChanged
        If chkVAT.Checked = True Then
            ' lbl_Tamount.Text = CStr(Math.Round(Val(GridView.Columns("GrossTotal").SummaryItem.SummaryValue.ToString()), 2))
            lbl_totalLess.Text = CStr(Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2))
            lbl_TotalLess1.Text = CStr(Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2))
            lbl_NetVat.Text = CStr(Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2))
            lbl_lessVAT.Text = CStr(Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2))
        ElseIf chkVAT.Checked = True Then
            ' lbl_Tamount.Text = CStr(Math.Round(Val(GridView.Columns("GrossTotal").SummaryItem.SummaryValue.ToString()), 2))
            lbl_NetVat.Text = "0"
            lbl_lessVAT.Text = "0"
        End If
    End Sub

    Private Sub chkNonVAT_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonVAT.CheckedChanged
        If chkNonVAT.Checked = True Then
            lbl_Tamount.Text = CStr(Math.Round(Val(GridView.Columns("GrossTotal").SummaryItem.SummaryValue.ToString()), 2))
            lbl_NetVat.Text = "0"
            lbl_lessVAT.Text = "0"
        ElseIf chkNonVAT.Checked = True Then
            lbl_Tamount.Text = CStr(Math.Round(Val(GridView.Columns("GrossTotal").SummaryItem.SummaryValue.ToString()), 2))
            lbl_totalLess.Text = CStr(Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2))
            lbl_TotalLess1.Text = CStr(Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2))
            lbl_NetVat.Text = CStr(Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2))
            lbl_lessVAT.Text = CStr(Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2))
        End If
    End Sub

    Private Sub lbl_AmountPaid_TextChanged(sender As Object, e As EventArgs) Handles lbl_AmountPaid.TextChanged
        lbl_Tamount.Text = CStr(Math.Round(Val(lbl_AmountPaid.Text), 2))
        lbl_totalLess.Text = CStr(Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2))
        lbl_TotalLess1.Text = CStr(Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2))
        lbl_NetVat.Text = CStr(Math.Round(Val(lbl_Tamount.Text) / Val(lbl_VAT1.Text), 2))
        lbl_lessVAT.Text = CStr(Math.Round(Val(lbl_totalLess.Text) * Val(lbl_VAT2.Text), 2))
    End Sub

    Private Sub cmb_TransCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_TransCategory.SelectedIndexChanged
        If cmb_TransCategory.EditValue.Equals("CUST DEP") Then
            cmb_Terms.EditValue = "10"
        End If
    End Sub

    Private Sub txt_CRNumber_EditValueChanged(sender As Object, e As EventArgs) Handles txt_CRNumber.EditValueChanged
        SPA_Find_CRNo_CustDep()
    End Sub

End Class