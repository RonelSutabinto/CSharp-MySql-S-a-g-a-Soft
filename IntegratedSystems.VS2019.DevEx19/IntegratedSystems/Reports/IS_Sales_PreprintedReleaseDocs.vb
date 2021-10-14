Imports MyClassLibrary.Classes
Imports System.Data.SqlClient
Imports SagaClassLibrary.Classes
Imports wSClassLib.myModules

Public Class IS_Sales_PreprintedReleaseDocs

    private sub cmd_vendor_Click(sender As System.Object, e As System.EventArgs) Handles cmd_vendor.Click
        MC_ReleasesDocsMainFrm.ShowDialog()
    End Sub

    private sub showPreprintedReleasesData()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamDateGranted", txt_DateGranted.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedgerSetNumber.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_PreprintedReleasesDocs")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_brCode.Text = myDataReader("BranchCode").ToString()
                txt_AccountNumber.Text = myDataReader("AccountNumber").ToString()
                txt_LedSet.Text = myDataReader("LedgersetNumber").ToString()
                txt_cust.Text = myDataReader("AccountName").ToString()
                txt_address.Text = myDataReader("AccountAddress").ToString()
                receivedDate.Value = myDataReader("DateGranted").ToString()
                firstpaydate.Value = myDataReader("FirstPayDate").ToString()
                maturityDate.Value = myDataReader("MaturityDate").ToString()
                txt_model.Text = myDataReader("model").ToString()
                txt_color.Text = myDataReader("color").ToString()
                txt_brand.Text = myDataReader("brand").ToString()
                txt_descrip.Text = myDataReader("model").ToString() & " " & myDataReader("color").ToString()
                txt_keynumber.Text = myDataReader("KeyNo").ToString()
                txt_EngineNo.Text = myDataReader("EngineNo").ToString()
                txt_ChassisNo.Text = myDataReader("ChassisNo").ToString()
                txt_orno.Text = myDataReader("ORNo").ToString()
                cmb_SalesType.Text = myDataReader("SaleType").ToString()
                txt_aoc.Text = Format(Val(myDataReader.Item("aoc").ToString()), "##,##0.00")
                txt_COD.Text = Format(Val(myDataReader.Item("COD").ToString()), "##,##0.00")
                txt_LCP.Text = Format(Val(myDataReader.Item("LCP").ToString()), "##,##0.00")
                txt_DP.Text = Format(Val(myDataReader.Item("DP").ToString()), "##,##0.00")
                txt_FinancedAmt.Text = Format(Val(myDataReader.Item("FinancedAmt").ToString()), "##,##0.00")
                txt_terms.Text = myDataReader("Terms").ToString()
                txt_intrate.Text = myDataReader("InterestRate").ToString()
                txt_INTRatePerAnum.Text = myDataReader("INTRatePerAnnum").ToString()
                txt_outstandingBAL.Text = Format(Val(myDataReader.Item("OutstandingBalance").ToString()), "##,##0.00")
                txt_prinPMT.Text = myDataReader("PrincipalPMT").ToString()
                txt_INTPMT.Text = myDataReader("InterestPMT").ToString()
                txt_PMT.Text = Format(Val(myDataReader.Item("pmt").ToString()), "##,##0.00")
                txt_ctcClient.Text = myDataReader("ctc").ToString()
                txt_bm.Text = myDataReader("BM").ToString()
                txt_Branch.Text = myDataReader("Branch").ToString()
                txt_BranchAddress.Text = myDataReader("branchaddress").ToString()
                txt_notarialAddress.Text = myDataReader("NotarialAddress").ToString()
                txt_TEMPINT.Text = myDataReader("TempINT").ToString()
                txt_Spouse.Text = myDataReader("SpouseFName").ToString() & " " & myDataReader("SpouseMName").ToString() & " " & myDataReader("SpouseLName").ToString()
            End If
        End Using
    End Sub

    private sub showAmortSched()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedgerSetNumber.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GCAmortSched, GViewAmort, "mg_showClient_AmortSched")
    End Sub

    private sub IS_Sales_PreprintedReleaseDocs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowPreprintedReleasesData()
        showAmortSched()
    End Sub

    private sub txt_FinancedAmt_TextChanged(sender As Object, e As EventArgs) Handles txt_FinancedAmt.TextChanged
        txt_texttowords.Text = class_Functions.AmountToWords(txt_FinancedAmt.Text)
    End Sub

    private sub txt_INTRatePerAnum_TextChanged(sender As Object, e As EventArgs) Handles txt_INTRatePerAnum.TextChanged
        txt_InterestRateWord.Text = MyClassLibrary.Classes.class_Functions.AmountToWords(txt_INTRatePerAnum.Text)
    End Sub

End Class