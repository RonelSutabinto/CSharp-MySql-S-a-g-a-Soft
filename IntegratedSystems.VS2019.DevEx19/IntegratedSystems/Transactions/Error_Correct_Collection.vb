Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Error_Correct_Collection
    private sub informationtool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles informationtool.Click
        IS_Sales_ReleaseAccount_List.Text = "ERRORCORRECT"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    private sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        mg_AdminPaymentCancel()
    End Sub

    private sub mg_AdminPaymentCancel()
        If MsgBox("Do you want to delete this Data??", vbYesNo, Application.CompanyName) = vbYes Then
            Dim sqlParameters As SqlParameter() =
            {
                New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
                New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
                New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
                New SqlParameter("@ParamPostingDate", releasedDate.Value),
                New SqlParameter("@ParamRefNo", txt_refno.Text)
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_AdminPaymentCancel")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    Dim sMessage As String = myDataReader("Message").ToString
                    If sMessage.Contains("Corrected") Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, sMessage, "Error Correction", True)
                    Else
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, sMessage, "Transaction Error", True)
                    End If
                End If
            End Using
        End If
    End Sub

    private sub mg_ShowAccount()
        Dim sqlParameters As SqlParameter() =
        {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamDateGranted", releasedDate.Text),
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
                IS_Sales_Inquiry.txt_EngineNo.Text = myDataReader("EngineNo").ToString()
                IS_Sales_Inquiry.txt_ChassisNo.Text = myDataReader("ChassisNo").ToString()
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
            End If
        End Using
    End Sub

    private sub showAmortSched()
        Dim sqlParameters As SqlParameter() =
        {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        IS_Sales_Inquiry.LViewAmortSched.Items.Clear()
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

    private sub showLedgerPrin()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCPrin, IS_Sales_Inquiry.GViewPrin, "mg_ShowLedgerPRIN")
    End Sub

    private sub showLedgerINT()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCInt, IS_Sales_Inquiry.GViewInt, "mg_ShowLedgerINT")
    End Sub

    private sub showLedgerAOC()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCAOC, IS_Sales_Inquiry.GViewAOC, "mg_ShowLedgerAOC")
    End Sub

    private sub showLedgerREB()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCReb, IS_Sales_Inquiry.GViewReb, "mg_ShowLedgerREB")
    End Sub

    private sub showLedgerPEN()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, IS_Sales_Inquiry.GCPen, IS_Sales_Inquiry.GViewPen, "mg_ShowLedgerPEN")
    End Sub

    private sub infoTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles infoTool.Click
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