Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class MC_Collection
    Private Sub cmd_vendor_Click(sender As System.Object, e As System.EventArgs) Handles cmd_vendor.Click
        FindCust()
    End Sub

    Private Sub FindCust()
        clearfield()
        txt_notif.Text = "0"
        txt_pulloutInv.Checked = False
        txt_pullout.Text = "NONE"
        IS_Sales_ReleaseAccount_List.quickSearch.Focus()
        IS_Sales_ReleaseAccount_List.Text = "PAYMENT"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Private Sub IS_Sales_Payments_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
        If e.KeyCode = Keys.F AndAlso e.Modifiers = Keys.Control Then
            FindCust()
        End If
        If e.KeyCode = Keys.I AndAlso e.Modifiers = Keys.Control Then
            ShowAccountInfo()
        End If
        If e.KeyCode = Keys.P AndAlso e.Modifiers = Keys.Control Then
            PrintReceipt()
        End If
        If e.KeyCode = Keys.N AndAlso e.Modifiers = Keys.Control Then
            NewTrans()
        End If

    End Sub

    Private Sub IS_Sales_Payments_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txt_notif.Text = "0"
        txt_pulloutInv.Checked = False
        clearfield()
    End Sub

    Private Sub Showtotaldue()
        totaldue.Text = Val(prindue.Text) + Val(intdue.Text) + Val(pendue.Text) + Val(dstdue.Text) + Val(otcdue.Text) + Val(odrdue.Text) + Val(ocrdue.Text) + Val(insdue.Text) + Val(aocdue.Text) - Val(rebdue.Text) + Val(svcdue.Text)
        totaloverride.Text = Val(prinoverride.Text) + Val(intoverride.Text) + Val(penoverride.Text) + Val(dstoverride.Text) + Val(otcoverride.Text) + Val(odroverride.Text) + Val(ocroverride.Text) + Val(insoverride.Text) + Val(aocoverride.Text) + Val(svcoverride.Text) - Val(reboverride.Text)
    End Sub

    Private Sub ShowTotalOverride()
        totaloverride.Text = Val(prinoverride.Text) + Val(intoverride.Text) + Val(penoverride.Text) + Val(dstoverride.Text) + Val(otcoverride.Text) + Val(odroverride.Text) + Val(ocroverride.Text) + Val(insoverride.Text) + Val(aocoverride.Text) + Val(svcoverride.Text) - Val(reboverride.Text)
    End Sub

    Private Sub mg_ShowAccount()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", receivedDate.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                IS_Sales_Inquiry.txt_brCode.Text = myDataReader("BranchCode").ToString()
                IS_Sales_Inquiry.txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                IS_Sales_Inquiry.txt_LedSet.Text = myDataReader("Ledgersetnumber").ToString()
                IS_Sales_Inquiry.txt_cust.Text = myDataReader("AccountName").ToString()
                IS_Sales_Inquiry.txt_address.Text = myDataReader("AccountAddress").ToString()
                IS_Sales_Inquiry.txt_cifKey.Text = myDataReader("cifKey").ToString()

                IS_Sales_Inquiry.txt_code.Text = myDataReader("code").ToString()
                IS_Sales_Inquiry.txt_ID.text = myDataReader("id").ToString()
                IS_Sales_Inquiry.txt_model.Text = myDataReader("model").ToString()
                IS_Sales_Inquiry.txt_color.Text = myDataReader("color").ToString()
                IS_Sales_Inquiry.txt_brand.Text = myDataReader("brand").ToString()
                IS_Sales_Inquiry.txt_descrip.Text = myDataReader("model").ToString() & " " & myDataReader("color").ToString()
                IS_Sales_Inquiry.txt_keynumber.Text = myDataReader("KeyNo").ToString()
                IS_Sales_Inquiry.txt_engineNo.Text = myDataReader("engineno").ToString()
                IS_Sales_Inquiry.txt_chassisNo.Text = myDataReader("chassisno").ToString()
                IS_Sales_Inquiry.txt_orno.Text = myDataReader("ORNo").ToString()
                IS_Sales_Inquiry.txt_orno2.Text = myDataReader("CRNo").ToString()

                IS_Sales_Inquiry.cmb_SalesType.Text = myDataReader("SaleType").ToString()
                IS_Sales_Inquiry.txt_COD.Text = Format(Val(myDataReader.Item("COD").ToString()), "##,##0.00")
                IS_Sales_Inquiry.txt_LCP.Text = Format(Val(myDataReader.Item("LCP").ToString()), "##,##0.00")
                IS_Sales_Inquiry.txt_DP.Text = Format(Val(myDataReader.Item("DP").ToString()), "##,##0.00")
                IS_Sales_Inquiry.txt_FinancedAmt.Text = Format(Val(myDataReader.Item("FinancedAmt").ToString()), "##,##0.00")

                IS_Sales_Inquiry.txt_terms.Text = myDataReader("Terms").ToString()
                IS_Sales_Inquiry.txt_intrate.Text = myDataReader("InterestRate").ToString()

                IS_Sales_Inquiry.txt_prinbal.Text = Format(Val(myDataReader.Item("PrincipalBalance").ToString()), "##,##0.00")
                IS_Sales_Inquiry.txt_intbal.Text = Format(Val(myDataReader.Item("InterestBalance").ToString()), "##,##0.00")
                IS_Sales_Inquiry.txt_outstandingbal.Text = Format(Val(myDataReader.Item("OutstandingBalance").ToString()), "##,##0.00")

                IS_Sales_Inquiry.txt_prinpmt.Text = Format(Val(myDataReader.Item("PrincipalPMT").ToString()), "##,##0.00")
                IS_Sales_Inquiry.txt_intpmt.Text = Format(Val(myDataReader.Item("InterestPMT").ToString()), "##,##0.00")
                IS_Sales_Inquiry.txt_pmt.Text = Format(Val(myDataReader.Item("pmt").ToString()), "##,##0.00")

                IS_Sales_Inquiry.txt_aecode.Text = myDataReader("AccountExecutive").ToString()
                IS_Sales_Inquiry.txt_aename.Text = myDataReader("OfficerName").ToString()

                IS_Sales_Inquiry.dategranted.Text = Format(myDataReader.Item("DateGranted"), "MMM dd, yyyy")
                IS_Sales_Inquiry.firstpayment.Text = Format(myDataReader.Item("FirstPayDate"), "MMM dd, yyyy")
                IS_Sales_Inquiry.maturity.Text = Format(myDataReader.Item("MaturityDate"), "MMM dd, yyyy")

                IS_Sales_Inquiry.txt_accountStatus.Text = myDataReader("AccountStatus").ToString()

                IS_Sales_Inquiry.txt_rebates.Text = Format(Val(myDataReader.Item("Rebates").ToString()), "##,##0.00")
                IS_Sales_Inquiry.txt_lstmvmtdate.Text = Format(myDataReader.Item("LastMvmtDate"), "MMM dd, yyyy")

                IS_Sales_Inquiry.txt_agent.Text = myDataReader("AgentName").ToString()
                IS_Sales_Inquiry.grp_agent.Text = myDataReader("InfoOutletType").ToString()

                IS_Sales_Inquiry.txt_whcode.Text = myDataReader("whCode").ToString()
                IS_Sales_Inquiry.txt_aoc.Text = myDataReader("aoc").ToString()

                IS_Sales_Inquiry.txt_corp.Text = myDataReader("corp").ToString()
                IS_Sales_Inquiry.branchName.Text = myDataReader("BranchName").ToString()
                IS_Sales_Inquiry.branchAddress.Text = myDataReader("BranchAddress").ToString()
                IS_Sales_Inquiry.txt_BM.Text = myDataReader("BM").ToString()
                IS_Sales_Inquiry.txt_Tag.Text = myDataReader("Tag").ToString()

                IS_Sales_Inquiry.txt_PrevOwner.Text = myDataReader("PrevAccountName").ToString()
                IS_Sales_Inquiry.txt_PrevBranchCode.Text = myDataReader("PrevBranchCode").ToString()
                IS_Sales_Inquiry.txt_PrevAccountNumber.Text = myDataReader("PrevAccountNumber").ToString()
                IS_Sales_Inquiry.txt_LedgerSetNumber.Text = myDataReader("PrevLedgerSetNumber").ToString()
                IS_Sales_Inquiry.txt_SFCPayableBal.Text = Format(Val(myDataReader.Item("SFCPayableBalance").ToString()), "##,##0.00")
                IS_Sales_Inquiry.txt_SFCPayableLastMvmt.Text = myDataReader("SFCLastMvmtDate")

                IS_Sales_Inquiry.txt_SalesDisc.Text = myDataReader("DiscAmt").ToString

                IS_Sales_Inquiry.txt_MobileNo.Text = myDataReader("MobileNo").ToString
                IS_Sales_Inquiry.txt_BirthDate.Text = myDataReader("BirthDate").ToString
                IS_Sales_Inquiry.txt_SpaIncharge.Text = myDataReader("SPA_Incharge").ToString
                IS_Sales_Inquiry.txt_SPAInchargeDesignation.Text = myDataReader("SPA_InchargeDesignation").ToString
            End If
        End Using
    End Sub

    Private Sub showAmortSched()
        IS_Sales_Inquiry.LViewAmortSched.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAmortSched")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = IS_Sales_Inquiry.LViewAmortSched.Items.Add(myDataReader.Item("InstallNo").ToString)
                    li.SubItems.Add(Format(myDataReader.Item("DueDate"), "MMM dd, yyyy"))
                    li.SubItems.Add(Format(Val(myDataReader.Item("BeginningBalance").ToString), "##,##0.00"))
                    li.SubItems.Add(Format(Val(myDataReader.Item("Principal").ToString), "##,##0.00"))
                    li.SubItems.Add(Format(Val(myDataReader.Item("Interest").ToString), "##,##0.00"))
                    li.SubItems.Add(Format(Val(myDataReader.Item("Charges").ToString), "##,##0.00"))
                    li.SubItems.Add(Format(Val(myDataReader.Item("DST").ToString), "##,##0.00"))
                    li.SubItems.Add(Format(Val(myDataReader.Item("mri").ToString), "##,##0.00"))
                    li.SubItems.Add(Format(Val(myDataReader.Item("MonAmort").ToString), "##,##0.00"))
                    li.SubItems.Add(Format(Val(myDataReader.Item("OutsBalance").ToString), "##,##0.00"))
                Loop
            End If
        End Using
    End Sub

    Private Sub showLedgerSFCPayable()
        IS_Sales_Inquiry.sfcLedger.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowLedgerSFC")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = IS_Sales_Inquiry.sfcLedger.Items.Add(Format(myDataReader.Item("PostingDate"), "MMM dd, yyyy"))
                    li.SubItems.Add(myDataReader.Item("Refno").ToString())
                    li.SubItems.Add(myDataReader.Item("Mnemonic").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("Beginning"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("Debit"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("Credit"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("EndingBalance"), "##,##0.00"))
                    li.SubItems.Add(myDataReader.Item("Remarks").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub showLedgerPrin()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCPrin, IS_Sales_Inquiry.GViewPrin, "mg_ShowLedgerPRIN")
    End Sub

    Private Sub showLedgerINT()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCInt, IS_Sales_Inquiry.GViewInt, "mg_ShowLedgerINT")
    End Sub

    Private Sub showLedgerAOC()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCAOC, IS_Sales_Inquiry.GViewAOC, "mg_ShowLedgerAOC")
    End Sub

    Private Sub showLedgerREB()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCReb, IS_Sales_Inquiry.GViewReb, "mg_ShowLedgerREB")
    End Sub

    Private Sub showLedgerPEN()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCPen, IS_Sales_Inquiry.GViewPen, "mg_ShowLedgerPEN")
    End Sub

    Private Sub ShowAccountInfo()
        mg_ShowAccount()
        showLedgerPrin()
        showLedgerAOC()
        showLedgerINT()
        showAmortSched()
        showLedgerREB()
        showLedgerPEN()
        showLedgerSFCPayable()
        IS_Sales_Inquiry.Text = "LEDGER INQUIRY"

        IS_Sales_Inquiry.MdiParent = MainMenu
        IS_Sales_Inquiry.Show()
        IS_Sales_Inquiry.Focus()

    End Sub

    Private Sub informationtool_Click(sender As System.Object, e As System.EventArgs) Handles informationtool.Click
        ShowAccountInfo()
    End Sub

    Private Sub prindue_TextChanged(sender As Object, e As System.EventArgs) Handles prindue.TextChanged
        Showtotaldue()
        ShowTotalOverride()
    End Sub

    Private Sub intdue_TextChanged(sender As Object, e As System.EventArgs) Handles intdue.TextChanged
        Showtotaldue()
        ShowTotalOverride()
    End Sub

    Private Sub aocdue_TextChanged(sender As Object, e As System.EventArgs) Handles aocdue.TextChanged
        Showtotaldue()
        ShowTotalOverride()
    End Sub

    Private Sub rebdue_TextChanged(sender As Object, e As System.EventArgs) Handles rebdue.TextChanged
        Showtotaldue()
        ShowTotalOverride()
    End Sub

    Private Sub svcdue_TextChanged(sender As Object, e As System.EventArgs) Handles svcdue.TextChanged
        Showtotaldue()
        ShowTotalOverride()
    End Sub

    Private Sub pendue_TextChanged(sender As Object, e As System.EventArgs) Handles pendue.TextChanged
        Showtotaldue()
        ShowTotalOverride()
    End Sub

    Private Sub dstdue_Click(sender As System.Object, e As System.EventArgs) Handles dstdue.Click

    End Sub

    Private Sub dstdue_TextChanged(sender As Object, e As System.EventArgs) Handles dstdue.TextChanged
        Showtotaldue()
        ShowTotalOverride()
    End Sub

    Private Sub otcdue_TextChanged(sender As Object, e As System.EventArgs) Handles otcdue.TextChanged
        Showtotaldue()
        ShowTotalOverride()
    End Sub

    Private Sub odrdue_TextChanged(sender As Object, e As System.EventArgs) Handles odrdue.TextChanged
        Showtotaldue()
        ShowTotalOverride()
    End Sub

    Private Sub txt_TotAmtPaid_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_TotAmtPaid.KeyDown
        If e.KeyCode = Keys.Enter Then
            If fullpaybtn.Checked = True Then
                txt_notif.Text = "1"
                Return
            Else
                showPaymentDistribution()
                txt_notif.Text = "1"
                Showtotaldue()
            End If

        End If
    End Sub

    Private Sub showPaymentDistribution()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
            New SqlParameter("@ParamPostingDate", postingDate.Value),
            New SqlParameter("@ParamAmountPaid", txt_TotAmtPaID.text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowPaymentDistribution")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                prindue.Text = Format(Val(myDataReader.Item("Prinpaid").ToString()), "##0.00")
                prinoverride.Text = Format(Val(myDataReader.Item("Prinpaid").ToString()), "##0.00")

                intdue.Text = Format(Val(myDataReader.Item("IntPaid").ToString()), "###0.00")
                intoverride.Text = Format(Val(myDataReader.Item("IntPaid").ToString()), "###0.00")

                pendue.Text = Format(Val(myDataReader.Item("Penpaid").ToString()), "###0.00")
                penoverride.Text = Format(Val(myDataReader.Item("Penpaid").ToString()), "###0.00")

                rebdue.Text = Format(Val(myDataReader.Item("Rebates").ToString()), "###0.00")
                reboverride.Text = Format(Val(myDataReader.Item("Rebates").ToString()), "###0.00")
            End If
        End Using
    End Sub

    Private Sub toolpostpayment_Click(sender As System.Object, e As System.EventArgs) Handles toolpostpayment.Click
        If txt_refno.Text = String.Empty Then
            MsgBox("Please input Reference/OR Number!", vbCritical, Application.CompanyName)
            Return
        End If
        If txt_TotAmtPaid.Text = String.Empty Then
            MsgBox("Please input Amount Paid!", vbCritical, Application.CompanyName)
            Return
        End If
        If txt_notif.Text = "0" Then
            MsgBox("Please HIT ENTER after you type AMOUNT PAID!", vbCritical, Application.CompanyName)
            txt_TotAmtPaid.Focus()
            Return
        End If
        If MsgBox("Reference Number: " & txt_refno.Text & vbCrLf &
                  "Remarks: " & txt_remarks.Text & vbCrLf & "Total Due : " & Format(Val(totaloverride.Text), "#,##0.00") & vbCrLf & vbCrLf &
                  "Do you want to proceed transaction?" & vbCrLf, vbYesNo, MessageBoxIcon.Warning) = vbYes Then
            class_Procedures.splash_Show("Transaction on process!")
            PostPaymentUpdate()
            If txt_errNo.Text = "0" Then
                PrintReceipt()
            End If

            class_Procedures.splash_Close()
        Else
            MsgBox("Transaction unsuccessful", vbCritical, Application.CompanyName)
        End If

    End Sub

    Private Sub clearfield()
        txt_refno.Text = String.Empty
        txt_remarks.Text = String.Empty

        prindue.Text = "0"
        intdue.Text = "0"
        pendue.Text = "0"
        dstdue.Text = "0"
        otcdue.Text = "0"
        odrdue.Text = "0"
        ocrdue.Text = "0"
        insdue.Text = "0"
        aocdue.Text = "0"
        rebdue.Text = "0"
        svcdue.Text = "0"

        prinoverride.Text = "0"
        intoverride.Text = "0"
        penoverride.Text = "0"
        dstoverride.Text = "0"
        otcoverride.Text = "0"
        odroverride.Text = "0"
        ocroverride.Text = "0"
        insoverride.Text = "0"
        aocoverride.Text = "0"
        svcoverride.Text = "0"
        reboverride.Text = "0"
        totaloverride.Text = "0"

        txt_notif.Text = "0"
        txt_pulloutInv.Checked = False
        txt_pullout.Text = "NONE"

    End Sub

    Private Sub ShowVATOR()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamRefNo", txt_refno.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowVatOR")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_amort.Text = Format(myDataReader.Item("MonAmort"), "#,##0.00")
                txt_addpen.Text = Format(myDataReader.Item("penalty"), "#,##0.00")
                txt_lessrebate.Text = Format(myDataReader.Item("rebates"), "#,##0.00")
                txt_downpayment.Text = Format(myDataReader.Item("DP"), "#,##0.00")
                txt_totalamtpaid.Text = Format(myDataReader.Item("AmountPaid"), "#,##0.00")
                txt_vatablesales.Text = Format(myDataReader.Item("Interest"), "#,##0.00")
                txt_zeroratedsales.Text = "0.00"
                txt_vatamt.Text = Format(myDataReader.Item("vat"), "#,##0.00")
                txt_totalsalesvat.Text = Format(myDataReader.Item("Interest"), "#,##0.00")
                txt_lessvat.Text = Format(myDataReader.Item("vat"), "#,##0.00")
                txt_amtnetofvat.Text = Format(myDataReader.Item("netvat"), "#,##0.00")
                txt_scpwd.Text = "0.00"
                txt_amtdue.Text = "0.00"
                txt_addvat.Text = "0.00"
                txt_outstandingBal.Text = Format(myDataReader.Item("OutstandingBalance"), "#,##0.00")
                postingdate2.Text = Format(myDataReader.Item("TransactionDate"), "MMM dd, yyyy")
                txt_acctaddress.Text = myDataReader("AccountAddress").ToString()
                txt_note2.Text = myDataReader("note").ToString()
            End If
        End Using
    End Sub

    Private Function PostPaymentUpdate() As Boolean
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamPostingDate", postingDate.Value),
            New SqlParameter("@ParamAmountPaid", txt_TotAmtPaID.text),
            New SqlParameter("@ParamRefNo", txt_refno.Text),
            New SqlParameter("@ParamPrin", prinoverride.Text),
            New SqlParameter("@ParamInt", intoverride.Text),
            New SqlParameter("@Paramaoc", aocoverride.Text),
            New SqlParameter("@Paramreb", reboverride.Text),
            New SqlParameter("@Paramsvc", svcoverride.Text),
            New SqlParameter("@Parampen", penoverride.Text),
            New SqlParameter("@Paramdst", dstoverride.Text),
            New SqlParameter("@Paramotc", otcoverride.Text),
            New SqlParameter("@Paramodr", odroverride.Text),
            New SqlParameter("@Paramocr", ocroverride.Text),
            New SqlParameter("@Paramins", insoverride.Text),
            New SqlParameter("@Paramtotal", totaloverride.Text),
            New SqlParameter("@ParamTransactedBy", class_Variables.sUserName),
            New SqlParameter("@ParamPULLOUT", txt_pullout.Text),
            New SqlParameter("@ParamPaymentType", txt_paymenttype.Text),
            New SqlParameter("@ParamTotalDue", totaldue.Text),
            New SqlParameter("@Paramnote", txt_remarks.Text),
            New SqlParameter("@ParamIBP", checkIBP.Checked),
            New SqlParameter("@Application", Application.ProductName)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "Post_Payment_Update", True)
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Dim sError As String = myDataReader("Message").ToString
                If sError.Contains("POSTED") Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, sError, "Transaction Information", True)
                    Return True
                Else
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, sError, "Transaction Error", True)
                    Return False
                End If
            End If
        End Using
        Return False
    End Function

    Private Sub prinoverride_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles prinoverride.KeyDown, txt_totalsalesvat.KeyDown, txt_vatamt.KeyDown, txt_zeroratedsales.KeyDown, txt_vatablesales.KeyDown, txt_totalamtpaid.KeyDown, txt_downpayment.KeyDown, txt_lessrebate.KeyDown, txt_addpen.KeyDown, txt_outstandingBal.KeyDown, txt_addvat.KeyDown, txt_amtdue.KeyDown, txt_scpwd.KeyDown, txt_amtnetofvat.KeyDown, txt_lessvat.KeyDown, txt_amort.KeyDown, txt_acctaddress.KeyDown, txt_numtoword.KeyDown, txt_amtpaid2.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowTotalOverride()
        End If
    End Sub

    Private Sub intoverride_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles intoverride.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowTotalOverride()
        End If
    End Sub

    Private Sub reboverride_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles reboverride.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowTotalOverride()
        End If
    End Sub

    Private Sub penoverride_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles penoverride.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowTotalOverride()
        End If
    End Sub

    Private Sub txt_pulloutInv_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pulloutInv.CheckedChanged
        If txt_pulloutInv.CheckState = CheckState.Checked Then
            txt_pullout.Text = "PULLOUT"
        Else
            txt_pullout.Text = "NONE"
        End If
    End Sub

    Private Sub fullpaybtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fullpaybtn.CheckedChanged
        txt_notif.Text = "1"
        If fullpaybtn.Checked = True Then
            txt_paymenttype.Text = "FULLPAYMENT"
        Else
            txt_paymenttype.Text = "NORMAL"
        End If
    End Sub

    Private Sub duebtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles duebtn.CheckedChanged
        If duebtn.Checked = True Then
            txt_paymenttype.Text = "NORMAL"
        Else
            txt_paymenttype.Text = "FULLPAYMENT"
        End If
    End Sub

    Private Sub PrintReceipt()
        ShowVATOR()

        With PrintDocument
            .DefaultPageSettings.Landscape = False
        End With
        DirectCast(PrintPreviewDialog, Form).WindowState = FormWindowState.Maximized
        With PrintPreviewDialog
            .PrintPreviewControl.Width = FormWindowState.Maximized
            .PrintPreviewControl.Zoom = 1.5
            .ShowDialog()
        End With
    End Sub

    Private Sub newtool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newtool.Click
        NewTrans()
    End Sub

    Private Sub NewTrans()
        txt_branchcode.Text = String.Empty
        txt_acctno.Text = String.Empty
        txt_LedSet.Text = String.Empty
        txt_cust.Text = String.Empty

        clearfield()
    End Sub

    Private Sub aocoverride_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles aocoverride.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowTotalOverride()
        End If
    End Sub

    Private Sub svcoverride_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles svcoverride.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowTotalOverride()
        End If
    End Sub

    Private Sub dstoverride_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dstoverride.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowTotalOverride()
        End If
    End Sub

    Private Sub otcoverride_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles otcoverride.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowTotalOverride()
        End If
    End Sub

    Private Sub odroverride_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles odroverride.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowTotalOverride()
        End If
    End Sub

    Private Sub ocroverride_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ocroverride.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowTotalOverride()
        End If
    End Sub

    Private Sub insoverride_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles insoverride.KeyDown
        If e.KeyCode = Keys.Enter Then
            ShowTotalOverride()
        End If
    End Sub

    Private Sub prinoverride_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prinoverride.TextChanged
        ShowTotalOverride()
    End Sub

    Private Sub intoverride_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles intoverride.TextChanged
        ShowTotalOverride()
    End Sub

    Private Sub aocoverride_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aocoverride.TextChanged
        ShowTotalOverride()
    End Sub

    Private Sub reboverride_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reboverride.TextChanged
        ShowTotalOverride()
    End Sub

    Private Sub svcoverride_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles svcoverride.TextChanged
        ShowTotalOverride()
    End Sub

    Private Sub penoverride_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles penoverride.TextChanged
        ShowTotalOverride()
    End Sub

    Private Sub dstoverride_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dstoverride.TextChanged
        ShowTotalOverride()
    End Sub

    Private Sub otcoverride_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles otcoverride.TextChanged
        ShowTotalOverride()
    End Sub

    Private Sub odroverride_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles odroverride.TextChanged
        ShowTotalOverride()
    End Sub

    Private Sub ocroverride_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ocroverride.TextChanged
        ShowTotalOverride()
    End Sub

    Private Sub insoverride_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insoverride.TextChanged
        ShowTotalOverride()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
        Dim TitleFont As New Font("calibri", 10, FontStyle.Bold)
        Dim BodyFont As New Font("calibri", 10, FontStyle.Regular)
        Dim BodyFont2 As New Font("calibri", 10)
        Dim BodyFontAMT As New Font("calibri", 10, FontStyle.Regular)
        Dim format As New StringFormat(StringFormatFlags.DirectionRightToLeft)

        Dim FirstColAmt As Integer = 200
        Dim SecondColAmt As Integer = 410
        Dim H As Integer = 0
        H = 65
        e.Graphics.DrawString(postingdate2.Text, BodyFont, Brushes.Black, 300, H)
        H += 35 '100
        e.Graphics.DrawString(txt_cust.Text, TitleFont, Brushes.Black, 100, H)
        H += 20 '120
        e.Graphics.DrawString(txt_acctaddress.Text, BodyFont, Brushes.Black, 100, H)
        H += 20 '140
        e.Graphics.DrawString(txt_numtoword.Text, BodyFont2, Brushes.Black, 100, H)
        H += 20 '160
        e.Graphics.DrawString(txt_totalamtpaid.Text, BodyFont2, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_note2.Text, BodyFont, Brushes.Black, 180, H)

        H += 30 '180
        e.Graphics.DrawString("REFERENCE: ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_refno.Text, BodyFont, Brushes.Black, 160, H)
        H += 20 '
        e.Graphics.DrawString("AMORTIZATION ", BodyFont, Brushes.Black, 32, H)
        e.Graphics.DrawString(txt_amort.Text, BodyFontAMT, Brushes.Black, 260, H, format)
        H += 20 '
        e.Graphics.DrawString("ADD: Penalty ", BodyFont, Brushes.Black, 32, H)
        e.Graphics.DrawString(txt_addpen.Text, BodyFontAMT, Brushes.Black, 260, H, format)
        H += 20 '
        e.Graphics.DrawString("LESS: Rebates ", BodyFont, Brushes.Black, 32, H)
        e.Graphics.DrawString(txt_lessrebate.Text, BodyFontAMT, Brushes.Black, 160, H)

        H += 20 '
        e.Graphics.DrawString("DOWNPAYMENT ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_downpayment.Text, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("TOTAL SALES VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(txt_totalsalesvat.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("TOTAL AMT PAID ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_totalamtpaid.Text, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("LESS VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(txt_lessvat.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("VATABLE SALES ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_vatablesales.Text, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("AMT NET OF VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(txt_amtnetofvat.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("VAT EXEMPT SALES ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("Less: SC/PWD Discount ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(txt_scpwd.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("ZERO RATED SALES ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("AMOUNT DUE ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("VAT AMOUNT ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_vatamt.Text, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("ADD VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(txt_addvat.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("OUTSTANDING BALANCE ", TitleFont, Brushes.Black, 40, H)
        e.Graphics.DrawString(txt_outstandingBal.Text, TitleFont, Brushes.Black, 300, H, format)
        H += 40 '
        e.Graphics.DrawString("Printed by: ", TitleFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(MainMenu.User_Full_Name.Caption, TitleFont, Brushes.Black, 90, H)
        e.Graphics.DrawString("Printed Date: ", TitleFont, Brushes.Black, 260, H)
        e.Graphics.DrawString($"{Date.Today:d}", TitleFont, Brushes.Black, 340, H)
        H += 10
        e.Graphics.DrawString(Now.ToString("hh mm ss"), TitleFont, Brushes.Black, 340, H)
    End Sub

    Private Sub txt_totalamtpaid_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_totalamtpaid.TextChanged
        txt_numtoword.Text = class_Functions.AmountToWords(txt_totalamtpaid.Text)
    End Sub

    Private Sub checkIBP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkIBP.CheckedChanged
        MsgBox("Inter Branch Payment = " & checkIBP.Checked, vbInformation, Application.CompanyName)
    End Sub

    Private Sub toolCALC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolCALC.Click
        Process.Start("calc.exe")
    End Sub

    Private Sub PrintRece_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintRece.Click
        PrintReceipt()
    End Sub

    Private Sub txt_amort_TextChanged(sender As Object, e As EventArgs) Handles txt_amort.TextChanged
        txt_amort2.Text = txt_amort.Text
    End Sub

    Private Sub txt_amort2_TextChanged(sender As Object, e As EventArgs) Handles txt_amort2.TextChanged
        txt_Partial.Text = Decimal.Round(Val(txt_amort2.Text) - Val(totaloverride.Text), 2, MidpointRounding.AwayFromZero)
    End Sub
End Class