Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Sales_ReleaseAccount_List

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

    Private Sub mg_ShowReleasedAccountByEngCha()
        LViewList.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", SearchByEC.Text),
            New SqlParameter("@paramBranchCode", class_saga_variables.sbranchcode)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowReleasedAccountByEngCha")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountName").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MMM dd, yyyy"))
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

    Private Sub mg_ShowAccountCreditMemo()
        LViewList.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Credit_Memo.prinoverride.Text = Format(Val(myDataReader.Item("PrincipalBalance").ToString()), "##0.00")
                Credit_Memo.intoverride.Text = Format(Val(myDataReader.Item("InterestBalance").ToString()), "##0.00")
                Credit_Memo.txt_TotAmtPaid.Text = Format(Val(myDataReader.Item("OutstandingBalance").ToString()), "##0.00")
            End If
        End Using
    End Sub

    Private Sub mg_ShowReleasedAccountsQuickSearch()
        LViewList.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", quickSearch.Text),
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamSearchAll", Me.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowReleasedAccountQuickSearch")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountName").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MMM dd, yyyy"))
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

    Private Sub mg_ShowReleasedAccountsStatus()
        LViewList.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountStatus", txt_AccountStatus.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowReleasedAccountStatus")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountName").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MMM dd, yyyy"))
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

    Private Sub ShowDuesFullPayment()
        LViewList.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", MC_Collection.txt_acctno.Text),
            New SqlParameter("@ParamBranchCode", MC_Collection.txt_branchcode.Text),
            New SqlParameter("@ParamPostingDate", MC_Collection.postingDate.Value),
            New SqlParameter("@ParamLedgersetNumber", MC_Collection.txt_LedSet.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowDueFull")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MC_Collection.prindue.Text = Format(Val(myDataReader.Item("Principal").ToString()), "##0.00")
                MC_Collection.prinoverride.Text = Format(Val(myDataReader.Item("Principal").ToString()), "##0.00")
                MC_Collection.intdue.Text = Format(Val(myDataReader.Item("Interest").ToString()), "###0.00")
                MC_Collection.intoverride.Text = Format(Val(myDataReader.Item("Interest").ToString()), "###0.00")
                MC_Collection.pendue.Text = Format(Val(myDataReader.Item("Penalty").ToString()), "###0.00")
                MC_Collection.penoverride.Text = Format(Val(myDataReader.Item("Penalty").ToString()), "###0.00")
            End If
        End Using

        Showtotaldue()
    End Sub

    Private Sub ShowDuesfortheday()
        LViewList.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", MC_Collection.txt_acctno.Text),
            New SqlParameter("@ParamBranchCode", MC_Collection.txt_branchcode.Text),
            New SqlParameter("@ParamPostingDate", MC_Collection.postingDate.Value),
            New SqlParameter("@ParamLedgersetNumber", MC_Collection.txt_LedSet.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowDue")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MC_Collection.prindue.Text = Format(Val(myDataReader.Item("Principal").ToString()), "##0.00")
                MC_Collection.prinoverride.Text = Format(Val(myDataReader.Item("Principal").ToString()), "##0.00")

                MC_Collection.intdue.Text = Format(Val(myDataReader.Item("Interest").ToString()), "###0.00")
                MC_Collection.intoverride.Text = Format(Val(myDataReader.Item("Interest").ToString()), "###0.00")

                MC_Collection.pendue.Text = Format(Val(myDataReader.Item("Penalty").ToString()), "###0.00")
                MC_Collection.penoverride.Text = Format(Val(myDataReader.Item("Penalty").ToString()), "###0.00")

                MC_Collection.rebdue.Text = "0"
                MC_Collection.reboverride.Text = "0"
                MC_Collection.txt_amort.Text = Decimal.Round(Val(MC_Collection.txt_amort.Text), 0, MidpointRounding.AwayFromZero)
            End If
        End Using

        Showtotaldue()
    End Sub

    Private Sub Showtotaldue()
        MC_Collection.totaldue.Text = Val(MC_Collection.prindue.Text) + Val(MC_Collection.intdue.Text) + Val(MC_Collection.pendue.Text) + Val(MC_Collection.dstdue.Text) + Val(MC_Collection.otcdue.Text) + Val(MC_Collection.odrdue.Text) + Val(MC_Collection.ocrdue.Text) + Val(MC_Collection.insdue.Text) + Val(MC_Collection.aocdue.Text) - Val(MC_Collection.rebdue.Text) + Val(MC_Collection.svcdue.Text)
        MC_Collection.totaloverride.Text = Val(MC_Collection.prinoverride.Text) + Val(MC_Collection.intoverride.Text) + Val(MC_Collection.penoverride.Text) + Val(MC_Collection.dstoverride.Text) + Val(MC_Collection.otcoverride.Text) + Val(MC_Collection.odroverride.Text) + Val(MC_Collection.ocroverride.Text) + Val(MC_Collection.insoverride.Text) + Val(MC_Collection.aocoverride.Text) + Val(MC_Collection.svcoverride.Text) - Val(MC_Collection.reboverride.Text)
    End Sub

    Private Sub mg_ShowAccountPaymentModule()
        IS_SALES_Release_View.cmd_showInvent.Enabled = False
        LViewList.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MC_Collection.txt_acctno.Text = myDataReader("AccountNumber").ToString()
                MC_Collection.txt_cust.Text = myDataReader("AccountName").ToString()
                MC_Collection.receivedDate.Value = myDataReader("DateGranted").ToString()
                MC_Collection.txt_branchcode.Text = myDataReader("branchcode").ToString()
                MC_Collection.txt_LedSet.Text = myDataReader("LedgerSetNumber").ToString()
                MC_Collection.txt_whcode.Text = myDataReader("AccountStatus").ToString()
                MC_Collection.txt_amort.Text = myDataReader("pmt").ToString()
            End If
        End Using
    End Sub

    Private Sub mg_ShowAccountToUpdate()
        IS_SALES_Release_View.cmd_showInvent.Enabled = False

        LViewList.Items.Clear()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccount")
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
                maint_CustAccount.txt_ID.text = myDataReader("id").ToString()
                maint_CustAccount.txt_model.Text = myDataReader("model").ToString()
                maint_CustAccount.txt_color.Text = myDataReader("color").ToString()
                maint_CustAccount.txt_brand.Text = myDataReader("brand").ToString()
                maint_CustAccount.txt_descrip.Text = myDataReader("model").ToString() & " " & myDataReader("color").ToString()
                maint_CustAccount.txt_keynumber.Text = myDataReader("KeyNo").ToString()
                maint_CustAccount.txt_EngineNo.Text = myDataReader("EngineNo").ToString()
                maint_CustAccount.txt_ChassisNo.Text = myDataReader("ChassisNo").ToString()
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
                maint_CustAccount.dategranted.Text = Format(myDataReader.Item("DateGranted"), "MMM dd, yyyy")
                maint_CustAccount.firstpayment.Text = Format(myDataReader.Item("FirstPayDate"), "MMM dd, yyyy")
                maint_CustAccount.maturity.Text = Format(myDataReader.Item("MaturityDate"), "MMM dd, yyyy")

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

    Friend Sub mg_UpdateAccount()
        LViewList.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Admin_UpdateAccount.txt_brCode.Text = myDataReader("BranchCode").ToString()
                Admin_UpdateAccount.txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                Admin_UpdateAccount.txt_LedSet.Text = myDataReader("LedgersetNumber").ToString()
                Admin_UpdateAccount.txt_cust.Text = myDataReader("AccountName").ToString()
                Admin_UpdateAccount.txt_address.Text = myDataReader("AccountAddress").ToString()
                Admin_UpdateAccount.txt_cifKey.Text = myDataReader("cifKey").ToString()

                Admin_UpdateAccount.txt_code.Text = myDataReader("code").ToString()
                Admin_UpdateAccount.txt_ID.text = myDataReader("id").ToString()
                Admin_UpdateAccount.txt_model.Text = myDataReader("model").ToString()
                Admin_UpdateAccount.txt_color.Text = myDataReader("color").ToString()
                Admin_UpdateAccount.txt_brand.Text = myDataReader("brand").ToString()
                Admin_UpdateAccount.txt_descrip.Text = myDataReader("model").ToString() & " " & myDataReader("color").ToString()
                Admin_UpdateAccount.txt_keynumber.Text = myDataReader("KeyNo").ToString()
                Admin_UpdateAccount.txt_EngineNo.Text = myDataReader("EngineNo").ToString()
                Admin_UpdateAccount.txt_ChassisNo.Text = myDataReader("ChassisNo").ToString()
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
                Admin_UpdateAccount.dategranted.Text = Format(myDataReader.Item("DateGranted"), "MMM dd, yyyy")
                Admin_UpdateAccount.firstpayment.Text = Format(myDataReader.Item("FirstPayDate"), "MMM dd, yyyy")
                Admin_UpdateAccount.maturity.Text = Format(myDataReader.Item("MaturityDate"), "MMM dd, yyyy")

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

    Private Sub mg_ShowAccountReClassStatus()
        LViewList.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Admin_ReclassStatus.txt_brCode.Text = myDataReader("BranchCode").ToString()
                Admin_ReclassStatus.txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                Admin_ReclassStatus.txt_LedSet.Text = myDataReader("LedgersetNumber").ToString()
                Admin_ReclassStatus.txt_cust.Text = myDataReader("AccountName").ToString()
                Admin_ReclassStatus.txt_address.Text = myDataReader("AccountAddress").ToString()
                Admin_ReclassStatus.txt_cifKey.Text = myDataReader("cifKey").ToString()

                Admin_ReclassStatus.txt_code.Text = myDataReader("code").ToString()
                Admin_ReclassStatus.txt_ID.text = myDataReader("id").ToString()
                Admin_ReclassStatus.txt_model.Text = myDataReader("model").ToString()
                Admin_ReclassStatus.txt_color.Text = myDataReader("color").ToString()
                Admin_ReclassStatus.txt_brand.Text = myDataReader("brand").ToString()
                Admin_ReclassStatus.txt_descrip.Text = myDataReader("model").ToString() & " " & myDataReader("color").ToString()
                Admin_ReclassStatus.txt_keynumber.Text = myDataReader("KeyNo").ToString()
                Admin_ReclassStatus.txt_EngineNo.Text = myDataReader("EngineNo").ToString()
                Admin_ReclassStatus.txt_ChassisNo.Text = myDataReader("ChassisNo").ToString()
                Admin_ReclassStatus.txt_whcode.Text = myDataReader("whCode").ToString()

                Admin_ReclassStatus.cmb_SalesType.Text = myDataReader("SaleType").ToString()
                Admin_ReclassStatus.txt_terms.Text = myDataReader("Terms").ToString()
                Admin_ReclassStatus.txt_intrate.Text = myDataReader("InterestRate").ToString()
                Admin_ReclassStatus.txt_accountStatus.Text = myDataReader("AccountStatus").ToString()
                Admin_ReclassStatus.dategranted.Text = Format(myDataReader.Item("DateGranted"), "MMM dd, yyyy")
                Admin_ReclassStatus.firstpayment.Text = Format(myDataReader.Item("FirstPayDate"), "MMM dd, yyyy")
                Admin_ReclassStatus.maturity.Text = Format(myDataReader.Item("MaturityDate"), "MMM dd, yyyy")

                Admin_ReclassStatus.txt_prinbal.Text = Format(Val(myDataReader.Item("PrincipalBalance").ToString()), "##0.00")
                Admin_ReclassStatus.txt_intbal.Text = Format(Val(myDataReader.Item("InterestBalance").ToString()), "##0.00")
                Admin_ReclassStatus.txt_outstandingbal.Text = Format(Val(myDataReader.Item("OutstandingBalance").ToString()), "##0.00")

                Admin_ReclassStatus.cmb_SalesType.Text = myDataReader("SaleType").ToString()
                Admin_ReclassStatus.CurrStatus.Text = myDataReader("AccountStatus").ToString()
            End If
        End Using
    End Sub

    Private Sub mg_ShowAccount()
        IS_SALES_Release_View.cmd_showInvent.Enabled = False

        LViewList.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                IS_Sales_Inquiry.txt_brCode.Text = myDataReader("BranchCode").ToString()
                IS_Sales_Inquiry.txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                IS_Sales_Inquiry.txt_LedSet.Text = myDataReader("LedgersetNumber").ToString()
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
                IS_Sales_Inquiry.txt_EngineNo.Text = myDataReader("EngineNo").ToString()
                IS_Sales_Inquiry.txt_ChassisNo.Text = myDataReader("ChassisNo").ToString()
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
                IS_Sales_Inquiry.txt_BirthDate.Text = myDataReader("BirthDate")
                IS_Sales_Inquiry.txt_SpaIncharge.Text = myDataReader("SPA_Incharge").ToString
                IS_Sales_Inquiry.txt_SPAInchargeDesignation.Text = myDataReader("SPA_InchargeDesignation").ToString
            End If
        End Using
    End Sub

    Private Sub showAmortSched()
        IS_Sales_Inquiry.LViewAmortSched.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
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
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
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

    Private Sub mg_ShowLedgerFreebie()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text)
        }

        If class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCFreebie, IS_Sales_Inquiry.GView, "mg_ShowLedgerFreebie") Then
            IS_Sales_Inquiry.GView.LoadingPanelVisible = False
        End If
    End Sub

    Private Sub mg_ShowLedgerFreebieForPrinting()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text)
        }

        If class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCFreebiePrint, IS_Sales_Inquiry.GViewSimple, "mg_ShowLedgerFreebie") Then
            IS_Sales_Inquiry.GView.LoadingPanelVisible = False
        End If
    End Sub

    Private Sub showLedgerPrin()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCPrin, IS_Sales_Inquiry.GViewPrin, "mg_ShowLedgerPRIN")
    End Sub

    Friend Sub showAmortSchedAcctMgmt()
        Admin_UpdateAccount.LViewAmortSched.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAmortSched")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = Admin_UpdateAccount.LViewAmortSched.Items.Add(myDataReader.Item("InstallNo").ToString())
                    li.SubItems.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNo").ToString())
                    li.SubItems.Add(myDataReader.Item("LedgerSetNumber").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DueDate"), "MMM dd, yyyy"))

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

    Friend Sub showLedgerPrinAcctMgmt()
        Admin_UpdateAccount.LViewLedgerPrin.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowLedgerPRIN")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = Admin_UpdateAccount.LViewLedgerPrin.Items.Add(Format(myDataReader.Item("PostingDate"), "MMM dd, yyyy"))
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

    Private Sub showLedgerINT()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCInt, IS_Sales_Inquiry.GViewInt, "mg_ShowLedgerINT")
    End Sub

    Friend Sub showLedgerINTAcctMgmt()
        Admin_UpdateAccount.LViewLedgerINT.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowLedgerINT")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = Admin_UpdateAccount.LViewLedgerINT.Items.Add(Format(myDataReader.Item("PostingDate"), "MMM dd, yyyy"))
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

    Private Sub showLedgerAOC()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCAOC, IS_Sales_Inquiry.GViewAOC, "mg_ShowLedgerAOC")
    End Sub

    Private Sub showLedgerREB()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCReb, IS_Sales_Inquiry.GViewReb, "mg_ShowLedgerREB")
    End Sub

    Friend Sub showLedgerREBAcctMgmt()
        Admin_UpdateAccount.LViewLedgerREB.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowLedgerREB")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = Admin_UpdateAccount.LViewLedgerREB.Items.Add(Format(myDataReader.Item("PostingDate"), "MMM dd, yyyy"))
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

    Private Sub showLedgerPEN()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCPen, IS_Sales_Inquiry.GViewPen, "mg_ShowLedgerPEN")
    End Sub

    Friend Sub showLedgerPENAcctMgmt()
        Admin_UpdateAccount.LViewLedgerPEN.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_ledset.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowLedgerPEN")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = Admin_UpdateAccount.LViewLedgerPEN.Items.Add(Format(myDataReader.Item("PostingDate"), "MMM dd, yyyy"))
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

    Private Sub showPreprintedReleasesData()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", txt_dategranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_PreprintedReleasesDocs")
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
                IS_Sales_PreprintedReleaseDocs.txt_EngineNo.Text = myDataReader("EngineNo").ToString()
                IS_Sales_PreprintedReleaseDocs.txt_ChassisNo.Text = myDataReader("ChassisNo").ToString()
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
            If MC_Collection.duebtn.Checked = True Then
                ShowDuesfortheday()
            Else
                ShowDuesFullPayment()
            End If
            Me.Visible = False

            If MC_Collection.txt_whcode.Text Like "DEP*" Then
                MC_Collection.lbl_whcode.Visible = True
                MC_Collection.txt_whcode.Visible = True
                'txt_pulloutInv.Visible = True

                Redeem_Option.Visible = True
            Else
                Redeem_Option.Visible = False
                ' txt_pulloutInv.Visible = False

                MC_Collection.lbl_whcode.Visible = False
                MC_Collection.txt_whcode.Visible = False
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
            Error_Correct_Collection.txt_branchcode.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            Error_Correct_Collection.txt_acctno.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            Error_Correct_Collection.txt_LedSet.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            Error_Correct_Collection.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            Error_Correct_Collection.releasedDate.Value = LViewList.SelectedItems.Item(0).SubItems(4).Text
            Error_Correct_Collection.Visible = True
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
            Error_Correct_Collection.txt_branchcode.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            Error_Correct_Collection.txt_acctno.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            Error_Correct_Collection.txt_LedSet.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            Error_Correct_Collection.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            Error_Correct_Collection.releasedDate.Value = LViewList.SelectedItems.Item(0).SubItems(4).Text
            Error_Correct_Collection.Visible = True
            Me.Visible = False

        ElseIf Me.Text = "CREDITMEMO" Then
            Credit_Memo.txt_branchcode.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            Credit_Memo.txt_acctno.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            Credit_Memo.txt_LedSet.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            Credit_Memo.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            mg_ShowAccountCreditMemo()
            Me.Visible = False

        ElseIf Me.Text = "SEARCH PREVIOUS" Then
            IS_SALES_Release.txt_PrevBranchCode.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            IS_SALES_Release.txt_PrevAccountNumber.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            IS_SALES_Release.txt_LedgerSetNumber.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            IS_SALES_Release.txt_PrevOwner.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            Me.Visible = False

        ElseIf Me.Text = "INTPAY" Then
            Cashiering_Transaction.txt_BranchCodeCust.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            Cashiering_Transaction.txt_AccountNumberCust.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            Cashiering_Transaction.txt_LedsetCust.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            Cashiering_Transaction.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            Cashiering_Transaction.txt_cifkey.Text = LViewList.SelectedItems.Item(0).SubItems(11).Text
            Cashiering_Transaction.txt_address.Text = LViewList.SelectedItems.Item(0).SubItems(13).Text
            Me.Visible = False

        ElseIf Me.Text = "SFC PAYABLE-RELEASE" Then
            Cashiering_Transaction.txt_BranchCodeCust.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            Cashiering_Transaction.txt_AccountNumberCust.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            Cashiering_Transaction.txt_LedsetCust.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            Cashiering_Transaction.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            Cashiering_Transaction.txt_cifkey.Text = LViewList.SelectedItems.Item(0).SubItems(11).Text
            Cashiering_Transaction.txt_address.Text = LViewList.SelectedItems.Item(0).SubItems(13).Text
            Me.Visible = False

        ElseIf Me.Text = "FSC" Then
            Cashiering_Transaction.txt_BranchCodeCust.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
            Cashiering_Transaction.txt_AccountNumberCust.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
            Cashiering_Transaction.txt_LedsetCust.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
            Cashiering_Transaction.txt_cust.Text = LViewList.SelectedItems.Item(0).SubItems(3).Text
            Cashiering_Transaction.txt_cifkey.Text = LViewList.SelectedItems.Item(0).SubItems(11).Text
            Cashiering_Transaction.txt_address.Text = LViewList.SelectedItems.Item(0).SubItems(13).Text
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

    Private Sub LViewList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LViewList.SelectedIndexChanged

    End Sub
End Class