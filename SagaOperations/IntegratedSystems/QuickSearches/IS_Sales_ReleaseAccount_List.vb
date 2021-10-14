Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Sales_ReleaseAccount_List
    Dim Crystal_ReportChattel As New ReportDocument
    Dim Crystal_ReportDeedOR As New ReportDocument
    Dim Crystal_ReportDiscState As New ReportDocument
    Dim Crystal_ReportAmort As New ReportDocument
    Dim Crystal_ReportPullOutRec As New ReportDocument
    Dim Crystal_ReportDeedofSaleWAOM As New ReportDocument
    Dim Crystal_ReportCompSlip As New ReportDocument
    Dim Crystal_ReportCert As New ReportDocument
    Dim Crystal_ReportWaiver As New ReportDocument

    Private Sub IS_Sales_ReleaseAccount_List_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub IS_Sales_ReleaseAccount_List_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LViewList.Items.Clear()

        If Me.Text = "SEARCH DETAILS" Then
            SearchByEC.Select()
            quickSearch.Text = String.Empty
            mg_ShowReleasedAccountByEngCha()
        ElseIf Me.Text = "SEARCH CONTROL" Or Me.Text = "IB-MC ACCOUNT" Then
            mg_ShowReleasedAccountsQuickSearch()
        ElseIf Me.Text = "preprintrelease" Then
            mg_ShowReleasedAccountsQuickSearch()
        ElseIf Me.Text = "ACCT_MGMT" Then
            mg_ShowReleasedAccountsQuickSearch()
        Else
            quickSearch.Select()

            acctStatON.Checked = False
            quickSearch.Text = String.Empty
            SearchByEC.Text = String.Empty
        End If
    End Sub

    Sub mg_ShowReleasedAccountByEngCha()
        LViewList.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", SearchByEC.Text),
            New SqlParameter("@paramBranchCode", MainMenu.statusBrCode.Caption)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowReleasedAccountByEngCha")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountName").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("ORNo").ToString())
                    li.SubItems.Add(Format(Val(myDataReader.Item("FinancedAmt").ToString()), "###0.00"))
                    li.SubItems.Add(myDataReader.Item("EngineNo").ToString())
                    li.SubItems.Add(myDataReader.Item("ChassisNo").ToString())
                    li.SubItems.Add(myDataReader.Item("Model").ToString())
                    li.SubItems.Add(myDataReader.Item("Color").ToString())
                    li.SubItems.Add(myDataReader.Item("CIFKey").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountExecutive").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountAddress").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub mg_ShowAccountCreditMemo()
        LViewList.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Admin_CreditMemo.prinoverride.Text = Format(Val(myDataReader.Item("PrincipalBalance").ToString()), "##0.00")
                Admin_CreditMemo.intoverride.Text = Format(Val(myDataReader.Item("InterestBalance").ToString()), "##0.00")
                Admin_CreditMemo.txt_TotAmtPaid.Text = Format(Val(myDataReader.Item("OutstandingBalance").ToString()), "##0.00")
            End If
        End Using
    End Sub

    Sub mg_ShowReleasedAccountsQuickSearch()
        LViewList.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", quickSearch.Text),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamSearchAll", Me.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowReleasedAccountQuickSearch")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountName").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("ORNo").ToString())
                    li.SubItems.Add(Format(Val(myDataReader.Item("FinancedAmt").ToString()), "###0.00"))
                    li.SubItems.Add(myDataReader.Item("EngineNo").ToString())
                    li.SubItems.Add(myDataReader.Item("ChassisNo").ToString())
                    li.SubItems.Add(myDataReader.Item("Model").ToString())
                    li.SubItems.Add(myDataReader.Item("Color").ToString())
                    li.SubItems.Add(myDataReader.Item("CIFKey").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountExecutive").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountAddress").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub mg_ShowReleasedAccountsStatus()
        LViewList.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamAccountStatus", txt_AccountStatus.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowReleasedAccountStatus")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountName").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("ORNo").ToString())
                    li.SubItems.Add(Format(Val(myDataReader.Item("FinancedAmt").ToString()), "###0.00"))
                    li.SubItems.Add(myDataReader.Item("EngineNo").ToString())
                    li.SubItems.Add(myDataReader.Item("ChassisNo").ToString())
                    li.SubItems.Add(myDataReader.Item("Model").ToString())
                    li.SubItems.Add(myDataReader.Item("Color").ToString())
                    li.SubItems.Add(myDataReader.Item("CIFKey").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountExecutive").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountAddress").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub mg_ShowReleasedAccounts()
        LViewList.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowReleasedAccounts")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountName").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("ORNo").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub ShowDuesFullPayment()
        LViewList.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", IS_Sales_Payments.txt_acctno.Text),
            New SqlParameter("@ParamBranchCode", IS_Sales_Payments.txt_branchcode.Text),
            New SqlParameter("@ParamPostingDate", IS_Sales_Payments.postingDate.Value),
            New SqlParameter("@ParamLedgersetNumber", IS_Sales_Payments.txt_LedSet.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowDueFull")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                IS_Sales_Payments.prindue.Text = Format(Val(myDataReader.Item("Principal").ToString()), "##0.00")
                IS_Sales_Payments.prinoverride.Text = Format(Val(myDataReader.Item("Principal").ToString()), "##0.00")
                IS_Sales_Payments.intdue.Text = Format(Val(myDataReader.Item("Interest").ToString()), "###0.00")
                IS_Sales_Payments.intoverride.Text = Format(Val(myDataReader.Item("Interest").ToString()), "###0.00")
                IS_Sales_Payments.pendue.Text = Format(Val(myDataReader.Item("Penalty").ToString()), "###0.00")
                IS_Sales_Payments.penoverride.Text = Format(Val(myDataReader.Item("Penalty").ToString()), "###0.00")
            End If
        End Using

        Showtotaldue()
    End Sub

    Sub ShowDuesfortheday()
        LViewList.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", IS_Sales_Payments.txt_acctno.Text),
            New SqlParameter("@ParamBranchCode", IS_Sales_Payments.txt_branchcode.Text),
            New SqlParameter("@ParamPostingDate", IS_Sales_Payments.postingDate.Value),
            New SqlParameter("@ParamLedgersetNumber", IS_Sales_Payments.txt_LedSet.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowDue")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                IS_Sales_Payments.prindue.Text = Format(Val(myDataReader.Item("Principal").ToString()), "##0.00")
                IS_Sales_Payments.prinoverride.Text = Format(Val(myDataReader.Item("Principal").ToString()), "##0.00")

                IS_Sales_Payments.intdue.Text = Format(Val(myDataReader.Item("Interest").ToString()), "###0.00")
                IS_Sales_Payments.intoverride.Text = Format(Val(myDataReader.Item("Interest").ToString()), "###0.00")

                IS_Sales_Payments.pendue.Text = Format(Val(myDataReader.Item("Penalty").ToString()), "###0.00")
                IS_Sales_Payments.penoverride.Text = Format(Val(myDataReader.Item("Penalty").ToString()), "###0.00")

                IS_Sales_Payments.rebdue.Text = "0"
                IS_Sales_Payments.reboverride.Text = "0"
                IS_Sales_Payments.txt_amort.Text = Decimal.Round(Val(IS_Sales_Payments.txt_amort.Text), 0, MidpointRounding.AwayFromZero)
            End If
        End Using

        Showtotaldue()
    End Sub

    Sub Showtotaldue()
        IS_Sales_Payments.totaldue.Text = Val(IS_Sales_Payments.prindue.Text) + Val(IS_Sales_Payments.intdue.Text) + Val(IS_Sales_Payments.pendue.Text) + Val(IS_Sales_Payments.dstdue.Text) + Val(IS_Sales_Payments.otcdue.Text) + Val(IS_Sales_Payments.odrdue.Text) + Val(IS_Sales_Payments.ocrdue.Text) + Val(IS_Sales_Payments.insdue.Text) + Val(IS_Sales_Payments.aocdue.Text) - Val(IS_Sales_Payments.rebdue.Text) + Val(IS_Sales_Payments.svcdue.Text)
        IS_Sales_Payments.totaloverride.Text = Val(IS_Sales_Payments.prinoverride.Text) + Val(IS_Sales_Payments.intoverride.Text) + Val(IS_Sales_Payments.penoverride.Text) + Val(IS_Sales_Payments.dstoverride.Text) + Val(IS_Sales_Payments.otcoverride.Text) + Val(IS_Sales_Payments.odroverride.Text) + Val(IS_Sales_Payments.ocroverride.Text) + Val(IS_Sales_Payments.insoverride.Text) + Val(IS_Sales_Payments.aocoverride.Text) + Val(IS_Sales_Payments.svcoverride.Text) - Val(IS_Sales_Payments.reboverride.Text)
    End Sub

    Sub mg_ShowAccountPaymentModule()
        IS_SALES_Release_View.cmd_showInvent.Enabled = False
        LViewList.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                IS_Sales_Payments.txt_acctno.Text = myDataReader("AccountNumber").ToString()
                IS_Sales_Payments.txt_cust.Text = myDataReader("AccountName").ToString()
                IS_Sales_Payments.receivedDate.Value = myDataReader("DateGranted").ToString()
                IS_Sales_Payments.txt_branchcode.Text = myDataReader("branchcode").ToString()
                IS_Sales_Payments.txt_LedSet.Text = myDataReader("LedgerSetNumber").ToString()
                IS_Sales_Payments.txt_whcode.Text = myDataReader("AccountStatus").ToString()
                IS_Sales_Payments.txt_amort.Text = myDataReader("pmt").ToString()
            End If
        End Using
    End Sub

    Sub mg_ShowAccountToUpdate()
        IS_SALES_Release_View.cmd_showInvent.Enabled = False

        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                maint_CustAccount.txt_brCode.Text = myDataReader("BranchCode").ToString()
                maint_CustAccount.txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                maint_CustAccount.txt_LedSet.Text = myDataReader("LedgersetNumber").ToString()
                maint_CustAccount.txt_cust.Text = myDataReader("AccountName").ToString()
                maint_CustAccount.txt_address.Text = myDataReader("AccountAddress").ToString()
                maint_CustAccount.txt_cifKey.Text = myDataReader("cifKey").ToString()
                maint_CustAccount.receivedDate.Value = myDataReader("DateGranted").ToString()

                maint_CustAccount.txt_code.Text = myDataReader("code").ToString()
                maint_CustAccount.txt_id.Text = myDataReader("id").ToString()
                maint_CustAccount.txt_model.Text = myDataReader("model").ToString()
                maint_CustAccount.txt_color.Text = myDataReader("color").ToString()
                maint_CustAccount.txt_brand.Text = myDataReader("brand").ToString()
                maint_CustAccount.txt_descrip.Text = myDataReader("model").ToString() & " " & myDataReader("color").ToString()
                maint_CustAccount.txt_keynumber.Text = myDataReader("KeyNo").ToString()
                maint_CustAccount.txt_engineNo.Text = myDataReader("engineno").ToString()
                maint_CustAccount.txt_chassisNo.Text = myDataReader("chassisno").ToString()
                maint_CustAccount.txt_whcode.Text = myDataReader("whCode").ToString()
                maint_CustAccount.txt_COD.Text = Format(Val(myDataReader.Item("COD").ToString()), "##0.00")
                maint_CustAccount.txt_LCP.Text = Format(Val(myDataReader.Item("LCP").ToString()), "##0.00")
                maint_CustAccount.txt_DP.Text = Format(Val(myDataReader.Item("DP").ToString()), "##0.00")
                maint_CustAccount.txt_FinancedAmt.Text = Format(Val(myDataReader.Item("FinancedAmt").ToString()), "##0.00")
                maint_CustAccount.txt_rebates.Text = Format(Val(myDataReader.Item("Rebates").ToString()), "##0.00")
                maint_CustAccount.txt_aoc.Text = myDataReader("aoc").ToString()

                maint_CustAccount.txt_orno.Text = myDataReader("ORNo").ToString()

                maint_CustAccount.cmb_SalesType.Text = myDataReader("SaleType").ToString()
                maint_CustAccount.txt_terms.Text = myDataReader("Terms").ToString()
                maint_CustAccount.txt_intrate.Text = myDataReader("InterestRate").ToString()
                maint_CustAccount.txt_accountStatus.Text = myDataReader("AccountStatus").ToString()
                maint_CustAccount.dategranted.Text = Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy")
                maint_CustAccount.firstpayment.Text = Format(myDataReader.Item("FirstPayDate"), "MM/dd/yyyy")
                maint_CustAccount.maturity.Text = Format(myDataReader.Item("MaturityDate"), "MM/dd/yyyy")

                maint_CustAccount.txt_prinpmt.Text = Format(Val(myDataReader.Item("PrincipalPMT").ToString()), "##0.00")
                maint_CustAccount.txt_intpmt.Text = Format(Val(myDataReader.Item("InterestPMT").ToString()), "##0.00")
                maint_CustAccount.txt_pmt.Text = Format(Val(myDataReader.Item("pmt").ToString()), "##0.00")

                maint_CustAccount.txt_prinbal.Text = Format(Val(myDataReader.Item("PrincipalBalance").ToString()), "##0.00")
                maint_CustAccount.txt_intbal.Text = Format(Val(myDataReader.Item("InterestBalance").ToString()), "##0.00")
                maint_CustAccount.txt_outstandingbal.Text = Format(Val(myDataReader.Item("OutstandingBalance").ToString()), "##0.00")

                maint_CustAccount.txt_prinBegBal.Text = Format(Val(myDataReader.Item("TempPrin").ToString()), "##0.00")
                maint_CustAccount.txt_INTBegBal.Text = Format(Val(myDataReader.Item("TempInt").ToString()), "##0.00")
            End If
        End Using
    End Sub

    Sub mg_UpdateAccount()
        LViewList.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Admin_UpdateAccount.txt_brCode.Text = myDataReader("BranchCode").ToString()
                Admin_UpdateAccount.txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                Admin_UpdateAccount.txt_LedSet.Text = myDataReader("LedgersetNumber").ToString()
                Admin_UpdateAccount.txt_cust.Text = myDataReader("AccountName").ToString()
                Admin_UpdateAccount.txt_address.Text = myDataReader("AccountAddress").ToString()
                Admin_UpdateAccount.txt_cifKey.Text = myDataReader("cifKey").ToString()

                Admin_UpdateAccount.txt_code.Text = myDataReader("code").ToString()
                Admin_UpdateAccount.txt_id.Text = myDataReader("id").ToString()
                Admin_UpdateAccount.txt_model.Text = myDataReader("model").ToString()
                Admin_UpdateAccount.txt_color.Text = myDataReader("color").ToString()
                Admin_UpdateAccount.txt_brand.Text = myDataReader("brand").ToString()
                Admin_UpdateAccount.txt_descrip.Text = myDataReader("model").ToString() & " " & myDataReader("color").ToString()
                Admin_UpdateAccount.txt_keynumber.Text = myDataReader("KeyNo").ToString()
                Admin_UpdateAccount.txt_engineNo.Text = myDataReader("engineno").ToString()
                Admin_UpdateAccount.txt_chassisNo.Text = myDataReader("chassisno").ToString()
                Admin_UpdateAccount.txt_whcode.Text = myDataReader("whCode").ToString()
                Admin_UpdateAccount.txt_COD.Text = Format(Val(myDataReader.Item("COD").ToString()), "##0.00")
                Admin_UpdateAccount.txt_LCP.Text = Format(Val(myDataReader.Item("LCP").ToString()), "##0.00")
                Admin_UpdateAccount.txt_DP.Text = Format(Val(myDataReader.Item("DP").ToString()), "##0.00")
                Admin_UpdateAccount.txt_FinancedAmt.Text = Format(Val(myDataReader.Item("FinancedAmt").ToString()), "##0.00")
                Admin_UpdateAccount.txt_rebates.Text = Format(Val(myDataReader.Item("Rebates").ToString()), "##0.00")
                Admin_UpdateAccount.txt_aoc.Text = myDataReader("aoc").ToString()

                Admin_UpdateAccount.cmb_SalesType.Text = myDataReader("SaleType").ToString()
                Admin_UpdateAccount.txt_terms.Text = myDataReader("Terms").ToString()
                Admin_UpdateAccount.txt_intrate.Text = myDataReader("InterestRate").ToString()
                Admin_UpdateAccount.txt_accountStatus.Text = myDataReader("AccountStatus").ToString()
                Admin_UpdateAccount.dategranted.Text = Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy")
                Admin_UpdateAccount.firstpayment.Text = Format(myDataReader.Item("FirstPayDate"), "MM/dd/yyyy")
                Admin_UpdateAccount.maturity.Text = Format(myDataReader.Item("MaturityDate"), "MM/dd/yyyy")

                Admin_UpdateAccount.txt_aename.Text = myDataReader("OfficerName").ToString()
                Admin_UpdateAccount.txt_aecode.Text = myDataReader("AccountExecutive").ToString()
                Admin_UpdateAccount.txt_SellerName.Text = myDataReader("AgentName").ToString()
                Admin_UpdateAccount.txt_SellerCode.Text = myDataReader("AgentCode").ToString()

                Admin_UpdateAccount.txt_PrinOB.Text = myDataReader("PrincipalBalance").ToString()
                Admin_UpdateAccount.txt_IntOB.Text = myDataReader("InterestBalance").ToString()
                Admin_UpdateAccount.txt_TotalOB.Text = myDataReader("OutstandingBalance").ToString()
                Admin_UpdateAccount.txt_cifKey.Text = myDataReader("CIFKey").ToString()
            End If
        End Using
    End Sub

    Sub mg_ShowAccountReClassStatus()
        LViewList.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Admin_ReclassStatus.txt_brCode.Text = myDataReader("BranchCode").ToString()
                Admin_ReclassStatus.txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                Admin_ReclassStatus.txt_LedSet.Text = myDataReader("LedgersetNumber").ToString()
                Admin_ReclassStatus.txt_cust.Text = myDataReader("AccountName").ToString()
                Admin_ReclassStatus.txt_address.Text = myDataReader("AccountAddress").ToString()
                Admin_ReclassStatus.txt_cifKey.Text = myDataReader("cifKey").ToString()

                Admin_ReclassStatus.txt_code.Text = myDataReader("code").ToString()
                Admin_ReclassStatus.txt_id.Text = myDataReader("id").ToString()
                Admin_ReclassStatus.txt_model.Text = myDataReader("model").ToString()
                Admin_ReclassStatus.txt_color.Text = myDataReader("color").ToString()
                Admin_ReclassStatus.txt_brand.Text = myDataReader("brand").ToString()
                Admin_ReclassStatus.txt_descrip.Text = myDataReader("model").ToString() & " " & myDataReader("color").ToString()
                Admin_ReclassStatus.txt_keynumber.Text = myDataReader("KeyNo").ToString()
                Admin_ReclassStatus.txt_engineNo.Text = myDataReader("engineno").ToString()
                Admin_ReclassStatus.txt_chassisNo.Text = myDataReader("chassisno").ToString()
                Admin_ReclassStatus.txt_whcode.Text = myDataReader("whCode").ToString()

                Admin_ReclassStatus.cmb_SalesType.Text = myDataReader("SaleType").ToString()
                Admin_ReclassStatus.txt_terms.Text = myDataReader("Terms").ToString()
                Admin_ReclassStatus.txt_intrate.Text = myDataReader("InterestRate").ToString()
                Admin_ReclassStatus.txt_accountStatus.Text = myDataReader("AccountStatus").ToString()
                Admin_ReclassStatus.dategranted.Text = Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy")
                Admin_ReclassStatus.firstpayment.Text = Format(myDataReader.Item("FirstPayDate"), "MM/dd/yyyy")
                Admin_ReclassStatus.maturity.Text = Format(myDataReader.Item("MaturityDate"), "MM/dd/yyyy")

                Admin_ReclassStatus.txt_prinbal.Text = Format(Val(myDataReader.Item("PrincipalBalance").ToString()), "##0.00")
                Admin_ReclassStatus.txt_intbal.Text = Format(Val(myDataReader.Item("InterestBalance").ToString()), "##0.00")
                Admin_ReclassStatus.txt_outstandingbal.Text = Format(Val(myDataReader.Item("OutstandingBalance").ToString()), "##0.00")

                Admin_ReclassStatus.cmb_SalesType.Text = myDataReader("SaleType").ToString()
                Admin_ReclassStatus.CurrStatus.Text = myDataReader("AccountStatus").ToString()
            End If
        End Using
    End Sub

    Sub mg_ShowAccount()
        IS_SALES_Release_View.cmd_showInvent.Enabled = False

        LViewList.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                IS_Sales_Inquiry.txt_brCode.Text = myDataReader("BranchCode").ToString()
                IS_Sales_Inquiry.txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                IS_Sales_Inquiry.txt_LedSet.Text = myDataReader("LedgersetNumber").ToString()
                IS_Sales_Inquiry.txt_cust.Text = myDataReader("AccountName").ToString()
                IS_Sales_Inquiry.txt_address.Text = myDataReader("AccountAddress").ToString()
                IS_Sales_Inquiry.txt_cifKey.Text = myDataReader("cifKey").ToString()

                IS_Sales_Inquiry.txt_code.Text = myDataReader("code").ToString()
                IS_Sales_Inquiry.txt_id.Text = myDataReader("id").ToString()
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
                IS_Sales_Inquiry.txt_DP.Text = myDataReader("DP").ToString()
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

                IS_Sales_Inquiry.dategranted.Text = Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy")
                IS_Sales_Inquiry.firstpayment.Text = Format(myDataReader.Item("FirstPayDate"), "MM/dd/yyyy")
                IS_Sales_Inquiry.maturity.Text = Format(myDataReader.Item("MaturityDate"), "MM/dd/yyyy")
                IS_Sales_Inquiry.txt_accountStatus.Text = myDataReader("AccountStatus").ToString()

                IS_Sales_Inquiry.txt_rebates.Text = Format(Val(myDataReader.Item("Rebates").ToString()), "##,##0.00")
                IS_Sales_Inquiry.txt_lstmvmtdate.Text = Format(myDataReader.Item("LastMvmtDate"), "MM/dd/yyyy")

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
                IS_Sales_Inquiry.txt_BirthDate.Text = myDataReader("BirthDate")
                IS_Sales_Inquiry.txt_SpaIncharge.Text = myDataReader("SPA_Incharge").ToString
                IS_Sales_Inquiry.txt_SPAInchargeDesignation.Text = myDataReader("SPA_InchargeDesignation").ToString
            End If
        End Using
    End Sub

    Sub showAmortSched()
        IS_Sales_Inquiry.LViewAmortSched.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAmortSched")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = IS_Sales_Inquiry.LViewAmortSched.Items.Add(myDataReader.Item("InstallNo").ToString)
                    li.SubItems.Add(Format(myDataReader.Item("DueDate"), "MM/dd/yyyy"))
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

    Sub showLedgerSFCPayable()
        IS_Sales_Inquiry.sfcLedger.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowLedgerSFC")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = IS_Sales_Inquiry.sfcLedger.Items.Add(Format(myDataReader.Item("PostingDate"), "MM/dd/yyyy"))
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

    Sub mg_ShowLedgerFreebie()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text)
        }

        If class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, IS_Sales_Inquiry.GCFreebie, IS_Sales_Inquiry.GView, "mg_ShowLedgerFreebie") Then
            IS_Sales_Inquiry.GView.LoadingPanelVisible = False
        End If
    End Sub

    Sub mg_ShowLedgerFreebieForPrinting()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text)
        }

        If class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, IS_Sales_Inquiry.GCFreebiePrint, IS_Sales_Inquiry.GViewSimple, "mg_ShowLedgerFreebie") Then
            IS_Sales_Inquiry.GView.LoadingPanelVisible = False
        End If
    End Sub

    Sub showLedgerPrin()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, IS_Sales_Inquiry.GCPrin, IS_Sales_Inquiry.GViewPrin, "mg_ShowLedgerPRIN")
    End Sub

    Sub showAmortSchedAcctMgmt()
        Admin_UpdateAccount.LViewAmortSched.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAmortSched")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = Admin_UpdateAccount.LViewAmortSched.Items.Add(myDataReader.Item("InstallNo").ToString())
                    li.SubItems.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNo").ToString())
                    li.SubItems.Add(myDataReader.Item("LedgerSetNumber").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DueDate"), "MM/dd/yyyy"))

                    li.SubItems.Add(Format(myDataReader.Item("MonAmort"), "##0.00"))

                    li.SubItems.Add(Format(myDataReader.Item("BeginningBalance"), "##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("Principal"), "##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("OutsBalance"), "##0.00"))

                    li.SubItems.Add(Format(myDataReader.Item("IntBeginningBalance"), "##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("Interest"), "##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("IntOutsBalance"), "##0.00"))
                Loop
            End If
        End Using
    End Sub

    Sub showLedgerPrinAcctMgmt()
        Admin_UpdateAccount.LViewLedgerPrin.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowLedgerPRIN")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = Admin_UpdateAccount.LViewLedgerPrin.Items.Add(Format(myDataReader.Item("PostingDate"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("ReferenceNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("Mnemonic").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("BeginningBalance"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("Debit"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("Credit"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("EndingBalance"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("TotalAmount"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("OutsBal"), "##,##0.00"))
                    li.SubItems.Add(myDataReader.Item("TransactedBy").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountExecutive").ToString())
                    li.SubItems.Add(myDataReader.Item("note").ToString())
                    li.SubItems.Add(myDataReader.Item("SequenceNumber").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub showLedgerINT()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, IS_Sales_Inquiry.GCInt, IS_Sales_Inquiry.GViewInt, "mg_ShowLedgerINT")
    End Sub

    Sub showLedgerINTAcctMgmt()
        Admin_UpdateAccount.LViewLedgerINT.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowLedgerINT")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = Admin_UpdateAccount.LViewLedgerINT.Items.Add(Format(myDataReader.Item("PostingDate"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("ReferenceNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("Mnemonic").ToString())
                    li.SubItems.Add(myDataReader.Item("BeginningBalance"))
                    li.SubItems.Add(myDataReader.Item("Debit"))
                    li.SubItems.Add(myDataReader.Item("Credit"))
                    li.SubItems.Add(myDataReader.Item("EndingBalance"))
                    li.SubItems.Add(myDataReader.Item("TotalAmount"))
                    li.SubItems.Add(myDataReader.Item("OutsBal").ToString())
                    li.SubItems.Add(myDataReader.Item("TransactedBy").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountExecutive").ToString())
                    li.SubItems.Add(myDataReader.Item("note").ToString())
                    li.SubItems.Add(myDataReader.Item("SequenceNumber").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub showLedgerAOC()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, IS_Sales_Inquiry.GCAOC, IS_Sales_Inquiry.GViewAOC, "mg_ShowLedgerAOC")
    End Sub

    Sub showLedgerREB()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, IS_Sales_Inquiry.GCReb, IS_Sales_Inquiry.GViewReb, "mg_ShowLedgerREB")
    End Sub

    Sub showLedgerREBAcctMgmt()
        Admin_UpdateAccount.LViewLedgerREB.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowLedgerREB")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = Admin_UpdateAccount.LViewLedgerREB.Items.Add(Format(myDataReader.Item("PostingDate"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("ReferenceNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("Mnemonic").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("BeginningBalance"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("Debit"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("Credit"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("EndingBalance"), "##,##0.00"))
                    li.SubItems.Add(myDataReader.Item("SequenceNumber").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub showLedgerPEN()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, IS_Sales_Inquiry.GCPen, IS_Sales_Inquiry.GViewPen, "mg_ShowLedgerPEN")
    End Sub

    Sub showLedgerPENAcctMgmt()
        Admin_UpdateAccount.LViewLedgerPEN.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowLedgerPEN")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = Admin_UpdateAccount.LViewLedgerPEN.Items.Add(Format(myDataReader.Item("PostingDate"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("ReferenceNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("Mnemonic").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("BeginningBalance"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("Debit"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("Credit"), "##,##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("EndingBalance"), "##,##0.00"))
                    li.SubItems.Add(myDataReader.Item("SequenceNumber").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub showPreprintedReleasesData()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text)
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text)
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text)    
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_PreprintedReleasesDocs")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                IS_Sales_PreprintedReleaseDocs.txt_brCode.Text = myDataReader("BranchCode").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_LedSet.Text = myDataReader("LedgersetNumber").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_cust.Text = myDataReader("AccountName").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_address.Text = myDataReader("AccountAddress").ToString()
                IS_Sales_PreprintedReleaseDocs.receivedDate.Value = myDataReader("DateGranted").ToString()
                IS_Sales_PreprintedReleaseDocs.firstpaydate.Value = myDataReader("FirstPayDate").ToString()
                IS_Sales_PreprintedReleaseDocs.maturityDate.Value = myDataReader("MaturityDate").ToString()

                IS_Sales_PreprintedReleaseDocs.txt_model.Text = myDataReader("model").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_color.Text = myDataReader("color").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_brand.Text = myDataReader("brand").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_descrip.Text = myDataReader("model").ToString() & " " & myDataReader("color").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_keynumber.Text = myDataReader("KeyNo").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text = myDataReader("engineno").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text = myDataReader("chassisno").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_orno.Text = myDataReader("ORNo").ToString()
                IS_Sales_PreprintedReleaseDocs.cmb_SalesType.Text = myDataReader("SaleType").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_aoc.Text = Format(Val(myDataReader.Item("aoc").ToString()), "##,##0.00")
                IS_Sales_PreprintedReleaseDocs.txt_COD.Text = Format(Val(myDataReader.Item("COD").ToString()), "##,##0.00")
                IS_Sales_PreprintedReleaseDocs.txt_LCP.Text = Format(Val(myDataReader.Item("LCP").ToString()), "##,##0.00")
                IS_Sales_PreprintedReleaseDocs.txt_DP.Text = Format(Val(myDataReader.Item("DP").ToString()), "##,##0.00")
                IS_Sales_PreprintedReleaseDocs.txt_FinancedAmt.Text = Format(Val(myDataReader.Item("FinancedAmt").ToString()), "##,##0.00")

                IS_Sales_PreprintedReleaseDocs.txt_terms.Text = myDataReader("Terms").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_intrate.Text = myDataReader("InterestRate").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_INTRatePerAnum.Text = myDataReader("INTRatePerAnnum").ToString()

                IS_Sales_PreprintedReleaseDocs.txt_outstandingBAL.Text = Format(Val(myDataReader.Item("OutstandingBalance").ToString()), "##,##0.00")

                IS_Sales_PreprintedReleaseDocs.txt_prinPMT.Text = myDataReader("PrincipalPMT").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_INTPMT.Text = myDataReader("InterestPMT").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_PMT.Text = Format(Val(myDataReader.Item("pmt").ToString()), "##,##0.00")
                IS_Sales_PreprintedReleaseDocs.txt_ctcClient.Text = myDataReader("ctc").ToString()

                IS_Sales_PreprintedReleaseDocs.txt_bm.Text = myDataReader("BM").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_Branch.Text = myDataReader("Branch").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_BranchAddress.Text = myDataReader("branchaddress").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_notarialAddress.Text = myDataReader("NotarialAddress").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_TEMPINT.Text = myDataReader("TempINT").ToString()
            End If
        End Using
    End Sub

    Private Sub LViewList_DoubleClick(sender As Object, e As System.EventArgs) Handles LViewList.DoubleClick
        txt_branchcode.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
        txt_acctno.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
        txt_ledset.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
        txt_dategranted.Text = LViewList.SelectedItems.Item(0).SubItems(4).Text
        txt_orno.Text = LViewList.SelectedItems.Item(0).SubItems(5).Text

        If Me.Text = "PAYMENT" Then
            mg_ShowAccountPaymentModule()
            If IS_Sales_Payments.duebtn.Checked = True Then
                ShowDuesfortheday()
            Else
                ShowDuesFullPayment()

            End If
            Me.Visible = False

            If IS_Sales_Payments.txt_whcode.Text Like "DEP*" Then
                IS_Sales_Payments.lbl_whcode.Visible = True
                IS_Sales_Payments.txt_whcode.Visible = True
                'txt_pulloutInv.Visible = True

                IS_Sales_RedeemOrNot.Visible = True
            Else
                IS_Sales_RedeemOrNot.Visible = False
                ' txt_pulloutInv.Visible = False

                IS_Sales_Payments.lbl_whcode.Visible = False
                IS_Sales_Payments.txt_whcode.Visible = False
            End If

        ElseIf Me.Text = "RELEASE" Or Me.Text = "SEARCH DETAILS" Or Me.Text = "SEARCH CONTROL" Or Me.Text = "IB-MC ACCOUNT" Then

            mg_ShowAccount()
            showLedgerPrin()
            showLedgerAOC()
            showLedgerINT()
            showAmortSched()
            showLedgerREB()
            showLedgerPEN()
            showLedgerSFCPayable()
            mg_ShowLedgerFreebie()
            mg_ShowLedgerFreebieForPrinting()
            Me.Visible = False

            IS_Sales_Inquiry.MdiParent = MainMenu
            IS_Sales_Inquiry.Show()
            IS_Sales_Inquiry.Focus()

        ElseIf Me.Text = "preprintrelease" Then
            IS_Sales_PreprintedReleaseDocs.txt_AccountNumber.Text = txt_acctno.Text
            IS_Sales_PreprintedReleaseDocs.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            IS_Sales_PreprintedReleaseDocs.receivedDate.Value = LViewList.SelectedItems.Item(0).SubItems(4).Text
            IS_Sales_PreprintedReleaseDocs.txt_LedgerSetNumber.Text = txt_ledset.Text
            txt_orno.Text = LViewList.SelectedItems.Item(0).SubItems(5).Text

            showPreprintedReleasesData()
            MC_ReleasesDocsMainFrm.ShowDialog()
            Me.Visible = False
        ElseIf Me.Text = "CANCELACCT" Then

            admin_acctCancel.txt_branchcode.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            admin_acctCancel.txt_acctno.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            admin_acctCancel.txt_LedSet.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            admin_acctCancel.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            admin_acctCancel.releasedDate.Value = LViewList.SelectedItems.Item(0).SubItems(4).Text
            admin_acctCancel.Visible = True
            Me.Visible = False

        ElseIf Me.Text = "ERRORCORRECT" Then

            admin_errorcorrectpayment.txt_branchcode.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            admin_errorcorrectpayment.txt_acctno.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            admin_errorcorrectpayment.txt_LedSet.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            admin_errorcorrectpayment.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            admin_errorcorrectpayment.releasedDate.Value = LViewList.SelectedItems.Item(0).SubItems(4).Text
            admin_errorcorrectpayment.Visible = True
            Me.Visible = False

        ElseIf Me.Text = "UPDATEACCTS" Then
            mg_ShowAccountToUpdate()
            maint_CustAccount.Visible = True
            Me.Visible = False

        ElseIf Me.Text = "ACCT_MGMT" Then
            mg_UpdateAccount()
            showLedgerPrinAcctMgmt()
            showLedgerINTAcctMgmt()
            showLedgerREBAcctMgmt()
            showLedgerPENAcctMgmt()
            showAmortSchedAcctMgmt()
            Admin_UpdateAccount.Visible = True
            Me.Visible = False

        ElseIf Me.Text = "ReclassStatus" Then
            mg_ShowAccountReClassStatus()
            Admin_ReclassStatus.Visible = True
            Me.Visible = False

        ElseIf Me.Text = "ERRORCORRECT-CASHIERING" Then

            admin_errorcorrectpayment.txt_branchcode.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            admin_errorcorrectpayment.txt_acctno.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            admin_errorcorrectpayment.txt_LedSet.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            admin_errorcorrectpayment.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            admin_errorcorrectpayment.releasedDate.Value = LViewList.SelectedItems.Item(0).SubItems(4).Text
            admin_errorcorrectpayment.Visible = True
            Me.Visible = False

        ElseIf Me.Text = "CREDITMEMO" Then
            Admin_CreditMemo.txt_branchcode.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            Admin_CreditMemo.txt_acctno.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            Admin_CreditMemo.txt_LedSet.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            Admin_CreditMemo.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            mg_ShowAccountCreditMemo()
            Me.Visible = False

        ElseIf Me.Text = "SEARCH PREVIOUS" Then
            IS_SALES_Release.txt_PrevBranchCode.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            IS_SALES_Release.txt_PrevAccountNumber.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            IS_SALES_Release.txt_LedgerSetNumber.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            IS_SALES_Release.txt_PrevOwner.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            Me.Visible = False

        ElseIf Me.Text = "INTPAY" Then
            IS_Cashiering_Transactions.txt_BranchCodeCust.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            IS_Cashiering_Transactions.txt_AccountNumberCust.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            IS_Cashiering_Transactions.txt_LedsetCust.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            IS_Cashiering_Transactions.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            IS_Cashiering_Transactions.txt_cifkey.Text = LViewList.SelectedItems.Item(0).SubItems(11).Text
            IS_Cashiering_Transactions.txt_address.Text = LViewList.SelectedItems.Item(0).SubItems(13).Text
            Me.Visible = False

        ElseIf Me.Text = "SFC PAYABLE-RELEASE" Then
            IS_Cashiering_Transactions.txt_BranchCodeCust.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            IS_Cashiering_Transactions.txt_AccountNumberCust.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            IS_Cashiering_Transactions.txt_LedsetCust.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            IS_Cashiering_Transactions.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            IS_Cashiering_Transactions.txt_cifkey.Text = LViewList.SelectedItems.Item(0).SubItems(11).Text
            IS_Cashiering_Transactions.txt_address.Text = LViewList.SelectedItems.Item(0).SubItems(13).Text
            Me.Visible = False

        ElseIf Me.Text = "FSC" Then
            IS_Cashiering_Transactions.txt_BranchCodeCust.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            IS_Cashiering_Transactions.txt_AccountNumberCust.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            IS_Cashiering_Transactions.txt_LedsetCust.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            IS_Cashiering_Transactions.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            IS_Cashiering_Transactions.txt_cifkey.Text = LViewList.SelectedItems.Item(0).SubItems(11).Text
            IS_Cashiering_Transactions.txt_address.Text = LViewList.SelectedItems.Item(0).SubItems(13).Text
            Me.Visible = False

        ElseIf Me.Text = "ACCTDEP" Then
            IS_Inventory_Receiving.txt_BrCode.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            IS_Inventory_Receiving.txt_AccountNumber.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            IS_Inventory_Receiving.txt_LedSet.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            IS_Inventory_Receiving.txt_note.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            Me.Visible = False

        ElseIf Me.Text = "INVDETREMARKS" Then
            rpt_Inventory_DetailsRemarks.txt_AcctBrCode.Text = txt_branchcode.Text
            rpt_Inventory_DetailsRemarks.txt_AccountNumber.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            rpt_Inventory_DetailsRemarks.txt_Ledset.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            rpt_Inventory_DetailsRemarks.txt_AccountName.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            Me.Visible = False
        End If
    End Sub

    Sub rptchattel()
        Dim CrTable As Table
        Dim CrTables As Tables
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim reportPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Rpt_RchattelM.rpt")
        Crystal_ReportChattel.Load(reportPath)
        Dim crParameterValue As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        With crConnectionInfo
            .ServerName = class_Tools.Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", String.Empty))
            .DatabaseName = class_Tools.Decrypt(class_Tools.RegKeyGet("Dbase", "DataBaseName", String.Empty))
            .UserID = class_Tools.Decrypt(class_Tools.RegKeyGet("DBaseUname", "DataBaseUserName", String.Empty))
            .Password = class_Tools.Decrypt(class_Tools.RegKeyGet("DBasePassword", "DataBasePassWord", String.Empty))
        End With
        CrTables = Crystal_ReportChattel.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next

        Crystal_ReportChattel.SetParameterValue("DateGranted", IS_Sales_PreprintedReleaseDocs.receivedDate.Value)
        Crystal_ReportChattel.SetParameterValue("AccountName", IS_Sales_PreprintedReleaseDocs.txt_cust.Text)
        Crystal_ReportChattel.SetParameterValue("Address", IS_Sales_PreprintedReleaseDocs.txt_address.Text)
        Crystal_ReportChattel.SetParameterValue("Branch", IS_Sales_PreprintedReleaseDocs.txt_Branch.Text)
        Crystal_ReportChattel.SetParameterValue("BranchAddress", IS_Sales_PreprintedReleaseDocs.txt_BranchAddress.Text)
        Crystal_ReportChattel.SetParameterValue("BM", IS_Sales_PreprintedReleaseDocs.txt_bm.Text)
        Crystal_ReportChattel.SetParameterValue("Brand", IS_Sales_PreprintedReleaseDocs.txt_brand.Text)
        Crystal_ReportChattel.SetParameterValue("Model", IS_Sales_PreprintedReleaseDocs.txt_model.Text)
        Crystal_ReportChattel.SetParameterValue("EngineNo", IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text)
        Crystal_ReportChattel.SetParameterValue("ChassisNo", IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text)
        Crystal_ReportChattel.SetParameterValue("Color", IS_Sales_PreprintedReleaseDocs.txt_color.Text)
        Crystal_ReportChattel.SetParameterValue("FinancedAmt", IS_Sales_PreprintedReleaseDocs.txt_FinancedAmt.Text)
        Crystal_ReportChattel.SetParameterValue("INTRatePerAnnum", IS_Sales_PreprintedReleaseDocs.txt_INTRatePerAnum.Text)
        Crystal_ReportChattel.SetParameterValue("ctcClient", IS_Sales_PreprintedReleaseDocs.txt_ctcClient.Text)
        Crystal_ReportChattel.SetParameterValue("Receptionist", IS_Sales_PreprintedReleaseDocs.txt_witness1.Text)
        Crystal_ReportChattel.SetParameterValue("CSR", IS_Sales_PreprintedReleaseDocs.txt_witness2.Text)
        Crystal_ReportChattel.SetParameterValue("ctcBM", IS_Sales_PreprintedReleaseDocs.txt_ctcnobm.Text)
        Crystal_ReportChattel.SetParameterValue("ctcissuedatclient", IS_Sales_PreprintedReleaseDocs.txt_ctcclientissuedat.Text)
        Crystal_ReportChattel.SetParameterValue("ctcissuedatBM", IS_Sales_PreprintedReleaseDocs.txt_ctcissuedatbm.Text)

        MsgBox("Chattel - " & Err.Description, vbCritical, Application.CompanyName)
    End Sub

    Sub rptdeedofreconvey()
        Dim CrTable As Table
        Dim CrTables As Tables
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim reportPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Rpt_RDeedofReconveyance.rpt")
        Crystal_ReportDeedOR.Load(reportPath)
        Dim crParameterValue As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        With crConnectionInfo
            .ServerName = class_Tools.Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", String.Empty))
            .DatabaseName = class_Tools.Decrypt(class_Tools.RegKeyGet("Dbase", "DataBaseName", String.Empty))
            .UserID = class_Tools.Decrypt(class_Tools.RegKeyGet("DBaseUname", "DataBaseUserName", String.Empty))
            .Password = class_Tools.Decrypt(class_Tools.RegKeyGet("DBasePassword", "DataBasePassWord", String.Empty))
        End With
        CrTables = Crystal_ReportDeedOR.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next

        Crystal_ReportDeedOR.SetParameterValue("Receptionist", IS_Sales_PreprintedReleaseDocs.txt_witness1.Text)
        Crystal_ReportDeedOR.SetParameterValue("AccountName", IS_Sales_PreprintedReleaseDocs.txt_cust.Text)
        Crystal_ReportDeedOR.SetParameterValue("Address", IS_Sales_PreprintedReleaseDocs.txt_address.Text)
        Crystal_ReportDeedOR.SetParameterValue("Brand", IS_Sales_PreprintedReleaseDocs.txt_brand.Text)
        Crystal_ReportDeedOR.SetParameterValue("Model", IS_Sales_PreprintedReleaseDocs.txt_model.Text)
        Crystal_ReportDeedOR.SetParameterValue("EngineNo", IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text)
        Crystal_ReportDeedOR.SetParameterValue("ChassisNo", IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text)
        Crystal_ReportDeedOR.SetParameterValue("Color", IS_Sales_PreprintedReleaseDocs.txt_color.Text)
        Crystal_ReportDeedOR.SetParameterValue("DateGranted", IS_Sales_PreprintedReleaseDocs.receivedDate.Value)
        Crystal_ReportDeedOR.SetParameterValue("BranchAddress", IS_Sales_PreprintedReleaseDocs.txt_BranchAddress.Text)
        Crystal_ReportDeedOR.SetParameterValue("BM", IS_Sales_PreprintedReleaseDocs.txt_bm.Text)
        Crystal_ReportDeedOR.SetParameterValue("NotaryAddress", IS_Sales_PreprintedReleaseDocs.txt_notarialAddress.Text)
        Crystal_ReportDeedOR.SetParameterValue("ctcClient", IS_Sales_PreprintedReleaseDocs.txt_ctcClient.Text)
        Crystal_ReportDeedOR.SetParameterValue("ctcClientIssuedAt", IS_Sales_PreprintedReleaseDocs.txt_ctcclientissuedat.Text)
        Crystal_ReportDeedOR.SetParameterValue("ctcClietIssuedOn", IS_Sales_PreprintedReleaseDocs.ctcClientIssuedOn.Value)

        MsgBox("DeedofReconvey - " & Err.Description, vbCritical, Application.CompanyName)
    End Sub

    Sub rptdisclosure()
        Dim CrTable As Table
        Dim CrTables As Tables
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim reportPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Rpt_RDisclosureStatementOLCT.rpt")
        Crystal_ReportDiscState.Load(reportPath)
        Dim crParameterValue As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        With crConnectionInfo
            .ServerName = class_Tools.Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", String.Empty))
            .DatabaseName = class_Tools.Decrypt(class_Tools.RegKeyGet("Dbase", "DataBaseName", String.Empty))
            .UserID = class_Tools.Decrypt(class_Tools.RegKeyGet("DBaseUname", "DataBaseUserName", String.Empty))
            .Password = class_Tools.Decrypt(class_Tools.RegKeyGet("DBasePassword", "DataBasePassWord", String.Empty))
        End With
        CrTables = Crystal_ReportDiscState.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        Crystal_ReportDiscState.SetParameterValue("AccountName", IS_Sales_PreprintedReleaseDocs.txt_cust.Text)
        Crystal_ReportDiscState.SetParameterValue("Address", IS_Sales_PreprintedReleaseDocs.txt_address.Text)
        Crystal_ReportDiscState.SetParameterValue("FinancedAmount", IS_Sales_PreprintedReleaseDocs.txt_FinancedAmt.Text)
        Crystal_ReportDiscState.SetParameterValue("INTRatePerAnnum", IS_Sales_PreprintedReleaseDocs.txt_INTRatePerAnum.Text)
        Crystal_ReportDiscState.SetParameterValue("FirstPayDate", IS_Sales_PreprintedReleaseDocs.firstpaydate.Value)
        Crystal_ReportDiscState.SetParameterValue("MaturityDate", IS_Sales_PreprintedReleaseDocs.maturityDate.Value)
        Crystal_ReportDiscState.SetParameterValue("TempINT", IS_Sales_PreprintedReleaseDocs.txt_TEMPINT.Text)
        Crystal_ReportDiscState.SetParameterValue("EffectiveINTRate", IS_Sales_PreprintedReleaseDocs.txt_intrate.Text)
        Crystal_ReportDiscState.SetParameterValue("Terms", IS_Sales_PreprintedReleaseDocs.txt_terms.Text)
        Crystal_ReportDiscState.SetParameterValue("PMT", IS_Sales_PreprintedReleaseDocs.txt_PMT.Text)
        Crystal_ReportDiscState.SetParameterValue("BM", IS_Sales_PreprintedReleaseDocs.txt_bm.Text)
    End Sub

    Sub rptAmortSched()
        Dim CrTable As Table
        Dim CrTables As Tables
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim reportPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Rpt_RAmortSched.rpt")
        Crystal_ReportAmort.Load(reportPath)
        Dim crParameterValue As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        With crConnectionInfo
            .ServerName = class_Tools.Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", String.Empty))
            .DatabaseName = class_Tools.Decrypt(class_Tools.RegKeyGet("Dbase", "DataBaseName", String.Empty))
            .UserID = class_Tools.Decrypt(class_Tools.RegKeyGet("DBaseUname", "DataBaseUserName", String.Empty))
            .Password = class_Tools.Decrypt(class_Tools.RegKeyGet("DBasePassword", "DataBasePassWord", String.Empty))
        End With
        CrTables = Crystal_ReportAmort.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        Crystal_ReportAmort.SetParameterValue("@ParamAccountNumber", IS_Sales_PreprintedReleaseDocs.txt_AccountNumber.Text)
        Crystal_ReportAmort.SetParameterValue("@ParamBranchCode", txt_branchcode.Text)
        Crystal_ReportAmort.SetParameterValue("@ParamLedgerSetNumber", txt_ledset.Text)
    End Sub

    Sub rptPullOutReceipt()
        Dim CrTable As Table
        Dim CrTables As Tables
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim reportPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Rpt_RPullOutReceipt.rpt")
        Crystal_ReportPullOutRec.Load(reportPath)
        Dim crParameterValue As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        With crConnectionInfo
            .ServerName = class_Tools.Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", String.Empty))
            .DatabaseName = class_Tools.Decrypt(class_Tools.RegKeyGet("Dbase", "DataBaseName", String.Empty))
            .UserID = class_Tools.Decrypt(class_Tools.RegKeyGet("DBaseUname", "DataBaseUserName", String.Empty))
            .Password = class_Tools.Decrypt(class_Tools.RegKeyGet("DBasePassword", "DataBasePassWord", String.Empty))
        End With
        CrTables = Crystal_ReportPullOutRec.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        Crystal_ReportPullOutRec.SetParameterValue("AccountName", IS_Sales_PreprintedReleaseDocs.txt_cust.Text)
        Crystal_ReportPullOutRec.SetParameterValue("BranchAddress", IS_Sales_PreprintedReleaseDocs.txt_BranchAddress.Text)
        Crystal_ReportPullOutRec.SetParameterValue("Brand", IS_Sales_PreprintedReleaseDocs.txt_brand.Text)
        Crystal_ReportPullOutRec.SetParameterValue("Receptionist", IS_Sales_PreprintedReleaseDocs.txt_witness1.Text)
        Crystal_ReportPullOutRec.SetParameterValue("CSR", IS_Sales_PreprintedReleaseDocs.txt_witness2.Text)

        Crystal_ReportPullOutRec.SetParameterValue("Model", IS_Sales_PreprintedReleaseDocs.txt_model.Text)
        Crystal_ReportPullOutRec.SetParameterValue("EngineNo", IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text)
        Crystal_ReportPullOutRec.SetParameterValue("ChassisNo", IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text)
        Crystal_ReportPullOutRec.SetParameterValue("Color", IS_Sales_PreprintedReleaseDocs.txt_color.Text)
        Crystal_ReportPullOutRec.SetParameterValue("BM", IS_Sales_PreprintedReleaseDocs.txt_bm.Text)
    End Sub

    Sub rptDeedofSaleWAOM()
        Dim CrTable As Table
        Dim CrTables As Tables
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim reportPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Rpt_RDeedofSaleWAOM.rpt")
        Crystal_ReportDeedofSaleWAOM.Load(reportPath)
        Dim crParameterValue As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        With crConnectionInfo
            .ServerName = class_Tools.Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", String.Empty))
            .DatabaseName = class_Tools.Decrypt(class_Tools.RegKeyGet("Dbase", "DataBaseName", String.Empty))
            .UserID = class_Tools.Decrypt(class_Tools.RegKeyGet("DBaseUname", "DataBaseUserName", String.Empty))
            .Password = class_Tools.Decrypt(class_Tools.RegKeyGet("DBasePassword", "DataBasePassWord", String.Empty))
        End With
        CrTables = Crystal_ReportDeedofSaleWAOM.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        Crystal_ReportDeedofSaleWAOM.SetParameterValue("AccountName", IS_Sales_PreprintedReleaseDocs.txt_cust.Text)
        Crystal_ReportDeedofSaleWAOM.SetParameterValue("AccountAddress", IS_Sales_PreprintedReleaseDocs.txt_address.Text)
        Crystal_ReportDeedofSaleWAOM.SetParameterValue("Model", IS_Sales_PreprintedReleaseDocs.txt_model.Text)
        Crystal_ReportDeedofSaleWAOM.SetParameterValue("Receptionist", IS_Sales_PreprintedReleaseDocs.txt_witness1.Text)
        Crystal_ReportDeedofSaleWAOM.SetParameterValue("CSR", IS_Sales_PreprintedReleaseDocs.txt_witness2.Text)
        Crystal_ReportDeedofSaleWAOM.SetParameterValue("ctcissuedatClient", IS_Sales_PreprintedReleaseDocs.txt_ctcclientissuedat.Text)

        Crystal_ReportDeedofSaleWAOM.SetParameterValue("EngineNo", IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text)
        Crystal_ReportDeedofSaleWAOM.SetParameterValue("ChassisNo", IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text)
        Crystal_ReportDeedofSaleWAOM.SetParameterValue("Color", IS_Sales_PreprintedReleaseDocs.txt_color.Text)
        Crystal_ReportDeedofSaleWAOM.SetParameterValue("BM", IS_Sales_PreprintedReleaseDocs.txt_bm.Text)
        Crystal_ReportDeedofSaleWAOM.SetParameterValue("ctc", IS_Sales_PreprintedReleaseDocs.txt_ctcClient.Text)

        Crystal_ReportDeedofSaleWAOM.SetParameterValue("DateGranted", IS_Sales_PreprintedReleaseDocs.receivedDate.Text)
        Crystal_ReportDeedofSaleWAOM.SetParameterValue("BranchAddress", IS_Sales_PreprintedReleaseDocs.txt_BranchAddress.Text)
    End Sub

    Sub rptComputationSlip()
        Dim CrTable As Table
        Dim CrTables As Tables
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim reportPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Rpt_Computation.rpt")
        Crystal_ReportCompSlip.Load(reportPath)
        Dim crParameterValue As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        With crConnectionInfo
            .ServerName = class_Tools.Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", String.Empty))
            .DatabaseName = class_Tools.Decrypt(class_Tools.RegKeyGet("Dbase", "DataBaseName", String.Empty))
            .UserID = class_Tools.Decrypt(class_Tools.RegKeyGet("DBaseUname", "DataBaseUserName", String.Empty))
            .Password = class_Tools.Decrypt(class_Tools.RegKeyGet("DBasePassword", "DataBasePassWord", String.Empty))
        End With
        CrTables = Crystal_ReportCompSlip.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        Crystal_ReportCompSlip.SetParameterValue("BranchName", IS_Sales_PreprintedReleaseDocs.txt_Branch.Text)
        Crystal_ReportCompSlip.SetParameterValue("RefNo", IS_Sales_PreprintedReleaseDocs.txt_orno.Text)
        Crystal_ReportCompSlip.SetParameterValue("AccountName", IS_Sales_PreprintedReleaseDocs.txt_cust.Text)
        Crystal_ReportCompSlip.SetParameterValue("AccountAddress", IS_Sales_PreprintedReleaseDocs.txt_address.Text)

        Crystal_ReportCompSlip.SetParameterValue("Brand", IS_Sales_PreprintedReleaseDocs.txt_brand.Text)
        Crystal_ReportCompSlip.SetParameterValue("Model", IS_Sales_PreprintedReleaseDocs.txt_model.Text)
        Crystal_ReportCompSlip.SetParameterValue("EngineNo", IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text)
        Crystal_ReportCompSlip.SetParameterValue("ChassisNo", IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text)
        Crystal_ReportCompSlip.SetParameterValue("Color", IS_Sales_PreprintedReleaseDocs.txt_color.Text)
        Crystal_ReportCompSlip.SetParameterValue("Terms", IS_Sales_PreprintedReleaseDocs.txt_terms.Text)
        Crystal_ReportCompSlip.SetParameterValue("AmountPaid", IS_Sales_PreprintedReleaseDocs.txt_DP.Text)
        Crystal_ReportCompSlip.SetParameterValue("AOC", IS_Sales_PreprintedReleaseDocs.txt_aoc.Text)
        Crystal_ReportCompSlip.SetParameterValue("LCP", IS_Sales_PreprintedReleaseDocs.txt_LCP.Text)
        Crystal_ReportCompSlip.SetParameterValue("TotalInterest", IS_Sales_PreprintedReleaseDocs.txt_TEMPINT.Text)
        Crystal_ReportCompSlip.SetParameterValue("OutstandingBalance", IS_Sales_PreprintedReleaseDocs.txt_outstandingBAL.Text)
        Crystal_ReportCompSlip.SetParameterValue("PMT", IS_Sales_PreprintedReleaseDocs.txt_PMT.Text)
        Crystal_ReportCompSlip.SetParameterValue("MaturityDate", IS_Sales_PreprintedReleaseDocs.maturityDate.Value)
        Crystal_ReportCompSlip.SetParameterValue("FirstPaymentDate", IS_Sales_PreprintedReleaseDocs.firstpaydate.Value)
        Crystal_ReportCompSlip.SetParameterValue("FinancedAmount", IS_Sales_PreprintedReleaseDocs.txt_FinancedAmt.Text)
        Crystal_ReportCompSlip.SetParameterValue("DateGranted", IS_Sales_PreprintedReleaseDocs.receivedDate.Value)
    End Sub

    Sub rptCertification()
        Dim CrTable As Table
        Dim CrTables As Tables
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim reportPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Rpt_Certification.rpt")
        Crystal_ReportCert.Load(reportPath)
        Dim crParameterValue As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        CrTables = Crystal_ReportCert.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        Crystal_ReportCert.SetParameterValue("AccountName", IS_Sales_PreprintedReleaseDocs.txt_cust.Text)
        Crystal_ReportCert.SetParameterValue("Brand", IS_Sales_PreprintedReleaseDocs.txt_brand.Text)
        Crystal_ReportCert.SetParameterValue("Model", IS_Sales_PreprintedReleaseDocs.txt_model.Text)
        Crystal_ReportCert.SetParameterValue("EngineNo", IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text)
        Crystal_ReportCert.SetParameterValue("ChassisNo", IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text)
        Crystal_ReportCert.SetParameterValue("Color", IS_Sales_PreprintedReleaseDocs.txt_color.Text)
        Crystal_ReportCert.SetParameterValue("BM", IS_Sales_PreprintedReleaseDocs.txt_bm.Text)
        Crystal_ReportCert.SetParameterValue("DateGranted", IS_Sales_PreprintedReleaseDocs.receivedDate.Value)
    End Sub

    Sub rptWaiver()
        Dim CrTable As Table
        Dim CrTables As Tables
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim reportPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Rpt_Waiver.rpt")
        Crystal_ReportWaiver.Load(reportPath)
        Dim crParameterValue As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        CrTables = Crystal_ReportWaiver.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        Crystal_ReportWaiver.SetParameterValue("AccountName", IS_Sales_PreprintedReleaseDocs.txt_cust.Text)
        Crystal_ReportWaiver.SetParameterValue("BM", IS_Sales_PreprintedReleaseDocs.txt_bm.Text)
    End Sub

    Private Sub quickSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles quickSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            mg_ShowReleasedAccountsQuickSearch()
        End If
    End Sub

    Private Sub acctStatON_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acctStatON.CheckedChanged
        If acctStatON.Checked = True Then
            txt_AccountStatus.Text = "ALL"
            mg_ShowReleasedAccountsStatus()
        Else
            txt_AccountStatus.Text = "NOT"
        End If
    End Sub

    Private Sub SearchByEC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SearchByEC.KeyDown
        If e.KeyCode = Keys.Enter Then
            mg_ShowReleasedAccountByEngCha()
        End If
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        mg_ShowReleasedAccountsQuickSearch()
    End Sub

End Class