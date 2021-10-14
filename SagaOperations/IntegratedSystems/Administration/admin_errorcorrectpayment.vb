Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class admin_errorcorrectpayment
    Private Sub informationtool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles informationtool.Click
        IS_Sales_ReleaseAccount_List.Text = "ERRORCORRECT"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Private Sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        mg_AdminPaymentCancel()
    End Sub

    Sub mg_AdminPaymentCancel()
        If MsgBox("Do you want to delete this Data??", vbYesNo, Application.CompanyName) = vbYes Then
            Dim Parameters As SqlParameter() =
            {
                New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
                New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
                New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
                New SqlParameter("@ParamPostingDate", releasedDate.Value),
                New SqlParameter("@ParamRefNo", txt_refno.Text)
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_AdminPaymentCancel")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    MsgBox(myDataReader.Item("Message").ToString())
                End If
            End Using
        End If
    End Sub

    Sub mg_ShowAccount()
        Dim Parameters As SqlParameter() =
        {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", releasedDate.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAccount")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                IS_Sales_Inquiry.txt_brCode.Text = myDataReader("BranchCode").ToString()
                IS_Sales_Inquiry.txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                IS_Sales_Inquiry.txt_LedSet.Text = myDataReader("Ledgersetnumber").ToString()
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
            End If
        End Using
    End Sub

    Sub showAmortSched()
        Dim Parameters As SqlParameter() =
        {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        IS_Sales_Inquiry.LViewAmortSched.Items.Clear()
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

    Sub showLedgerPrin()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, IS_Sales_Inquiry.GCPrin, IS_Sales_Inquiry.GViewPrin, Parameters, "mg_ShowLedgerPRIN")
    End Sub

    Sub showLedgerINT()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, IS_Sales_Inquiry.GCInt, IS_Sales_Inquiry.GViewInt, Parameters, "mg_ShowLedgerINT")
    End Sub

    Sub showLedgerAOC()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, IS_Sales_Inquiry.GCAOC, IS_Sales_Inquiry.GViewAOC, Parameters, "mg_ShowLedgerAOC")
    End Sub

    Sub showLedgerREB()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, IS_Sales_Inquiry.GCReb, IS_Sales_Inquiry.GViewReb, Parameters, "mg_ShowLedgerREB")
    End Sub

    Sub showLedgerPEN()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, IS_Sales_Inquiry.GCPen, IS_Sales_Inquiry.GViewPen, Parameters, "mg_ShowLedgerPEN")
    End Sub

    Private Sub infoTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles infoTool.Click
        mg_ShowAccount()
        ShowLedgerPrin()
        ShowLedgerAOC()
        ShowLedgerINT()
        ShowAmortSched()
        ShowLedgerREB()
        ShowLedgerPEN()
        IS_Sales_Inquiry.MdiParent = MainMenu
        IS_Sales_Inquiry.Show()
        IS_Sales_Inquiry.Focus()
    End Sub
End Class