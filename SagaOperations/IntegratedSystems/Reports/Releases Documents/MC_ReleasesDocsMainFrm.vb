Imports DevExpress.XtraReports.UI

Public Class MC_ReleasesDocsMainFrm

    Private Sub PullOutReceipt_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles PullOutReceipt.ItemClick
        Dim report As New rpt_rd_pulloutreceipt()

        report.txt_Branch.Text = IS_Sales_PreprintedReleaseDocs.txt_Branch.Text
        report.txt_BranchAddress.Text = IS_Sales_PreprintedReleaseDocs.txt_BranchAddress.Text
        report.txt_Brand.Text = IS_Sales_PreprintedReleaseDocs.txt_brand.Text
        report.txt_Model.Text = IS_Sales_PreprintedReleaseDocs.txt_model.Text
        report.txt_Engineno.Text = IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text
        report.txt_chassisno.Text = IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text
        report.txt_Color.Text = IS_Sales_PreprintedReleaseDocs.txt_color.Text
        report.txt_BM.Text = IS_Sales_PreprintedReleaseDocs.txt_bm.Text
        report.txt_AccountName.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_witness1.Text = IS_Sales_PreprintedReleaseDocs.txt_witness1.Text
        report.txt_witness2.Text = IS_Sales_PreprintedReleaseDocs.txt_witness2.Text

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Private Sub Certification_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles Certification.ItemClick
        Dim report As New rpt_rd_Certification()
        report.txt_Brand.Text = IS_Sales_PreprintedReleaseDocs.txt_brand.Text
        report.txt_Model.Text = IS_Sales_PreprintedReleaseDocs.txt_model.Text
        report.txt_Engineno.Text = IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text
        report.txt_Chassisno.Text = IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text
        report.txt_Color.Text = IS_Sales_PreprintedReleaseDocs.txt_color.Text
        report.txt_BM.Text = IS_Sales_PreprintedReleaseDocs.txt_bm.Text
        report.txt_AccountName.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text

        report.txt_Date.Text = IS_Sales_PreprintedReleaseDocs.receivedDate.Value
        report.txt_Day.Text = IS_Sales_PreprintedReleaseDocs.txt_day.Text
        report.txt_Month.Text = IS_Sales_PreprintedReleaseDocs.txt_month.Text
        report.txt_Year.Text = IS_Sales_PreprintedReleaseDocs.txt_year.Text

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Private Sub ComputationSlip_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles ComputationSlip.ItemClick
        Dim report As New rpt_rd_Computation()

        report.txt_Branch.Text = IS_Sales_PreprintedReleaseDocs.txt_Branch.Text
        report.txt_BranchAddress.Text = IS_Sales_PreprintedReleaseDocs.txt_BranchAddress.Text
        report.txt_AccountName.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_Address.Text = IS_Sales_PreprintedReleaseDocs.txt_address.Text
        report.txt_Brand.Text = IS_Sales_PreprintedReleaseDocs.txt_brand.Text
        report.txt_Model.Text = IS_Sales_PreprintedReleaseDocs.txt_model.Text
        report.txt_Engineno.Text = IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text
        report.txt_Chassisno.Text = IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text
        report.txt_Color.Text = IS_Sales_PreprintedReleaseDocs.txt_color.Text
        report.txt_Terms.Text = IS_Sales_PreprintedReleaseDocs.txt_terms.Text
        report.txt_DP.Text = IS_Sales_PreprintedReleaseDocs.txt_DP.Text
        report.txt_AOC.Text = IS_Sales_PreprintedReleaseDocs.txt_aoc.Text
        report.txt_LCP.Text = IS_Sales_PreprintedReleaseDocs.txt_LCP.Text
        report.txt_AmountFin.Text = IS_Sales_PreprintedReleaseDocs.txt_FinancedAmt.Text
        report.txt_TotalFin.Text = IS_Sales_PreprintedReleaseDocs.txt_TEMPINT.Text
        report.txt_Refno.Text = IS_Sales_PreprintedReleaseDocs.txt_orno.Text
        report.OutstandingBalance.Text = IS_Sales_PreprintedReleaseDocs.txt_outstandingBAL.Text
        report.txt_MonthlyAmort.Text = IS_Sales_PreprintedReleaseDocs.txt_PMT.Text
        report.txt_FirstPayment.Text = IS_Sales_PreprintedReleaseDocs.firstpaydate.Value
        report.txt_MaturityDate.Text = IS_Sales_PreprintedReleaseDocs.maturityDate.Value
        report.txt_DateGranted.Text = IS_Sales_PreprintedReleaseDocs.receivedDate.Value

        report.ShowPreview
    End Sub

    Private Sub MC_ReleasesDocsMainfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AmortizationSchedule_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles AmortizationSchedule.ItemClick
        Dim report As New rpt_rd_AmortSched()

        IS_Sales_PreprintedReleaseDocs.GViewAmort.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = IS_Sales_PreprintedReleaseDocs.GCAmortSched

        report.txt_Branch.Text = IS_Sales_PreprintedReleaseDocs.txt_Branch.Text
        report.txt_BranchAddress.Text = IS_Sales_PreprintedReleaseDocs.txt_BranchAddress.Text

        report.txt_AccountName.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_AccountName2.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_AccountNo.Text = IS_Sales_PreprintedReleaseDocs.txt_brCode.Text & " - " & IS_Sales_PreprintedReleaseDocs.txt_AccountNumber.Text & " - " & IS_Sales_PreprintedReleaseDocs.txt_LedgerSetNumber.Text
        report.txt_Model.Text = IS_Sales_PreprintedReleaseDocs.txt_model.Text
        report.txt_Engineno.Text = IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text
        report.txt_Chassisno.Text = IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text
        report.txt_Keyno.Text = IS_Sales_PreprintedReleaseDocs.txt_keynumber.Text
        report.txt_TotalBal.Text = Format(Val(IS_Sales_PreprintedReleaseDocs.txt_PMT.Text * IS_Sales_PreprintedReleaseDocs.txt_terms.Text), "#,##0.00")

        report.txt_DateGranted.Text = IS_Sales_PreprintedReleaseDocs.receivedDate.Value
        report.txt_BM.Text = IS_Sales_PreprintedReleaseDocs.txt_bm.Text

        report.txt_MaturityDate.Text = IS_Sales_PreprintedReleaseDocs.maturityDate.Value

        report.ShowPreview
    End Sub

    Private Sub MC_ReleasesDocsMainfrm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        IS_Sales_PreprintedReleaseDocs.Close()
    End Sub

    Private Sub ChattMort_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles ChattMort.ItemClick
        Dim report As New rpt_rd_ChattelM()

        report.txt_Day.Text = IS_Sales_PreprintedReleaseDocs.txt_day.Text
        report.txt_Month.Text = IS_Sales_PreprintedReleaseDocs.txt_month.Text
        report.txt_Year.Text = IS_Sales_PreprintedReleaseDocs.txt_year.Text
        report.txt_AccountName.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_BM.Text = IS_Sales_PreprintedReleaseDocs.txt_bm.Text
        report.txt_AccountAddress.Text = IS_Sales_PreprintedReleaseDocs.txt_address.Text
        report.txt_BranchAddress.Text = IS_Sales_PreprintedReleaseDocs.txt_BranchAddress.Text
        report.txt_AccountAddress2.Text = IS_Sales_PreprintedReleaseDocs.txt_address.Text
        report.txt_Brand.Text = IS_Sales_PreprintedReleaseDocs.txt_brand.Text
        report.txt_Model.Text = IS_Sales_PreprintedReleaseDocs.txt_model.Text
        report.txt_Engineno.Text = IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text
        report.txt_Chassisno.Text = IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text
        report.txt_Color.Text = IS_Sales_PreprintedReleaseDocs.txt_color.Text
        report.txt_AmtFinance.Text = IS_Sales_PreprintedReleaseDocs.txt_FinancedAmt.Text
        report.txt_IntRatePerAnnum.Text = IS_Sales_PreprintedReleaseDocs.txt_INTRatePerAnum.Text
        report.txt_Day1.Text = IS_Sales_PreprintedReleaseDocs.txt_day.Text
        report.txt_Month1.Text = IS_Sales_PreprintedReleaseDocs.txt_month.Text
        report.txt_Year1.Text = IS_Sales_PreprintedReleaseDocs.txt_year.Text
        report.txt_BranchAddress1.Text = IS_Sales_PreprintedReleaseDocs.txt_BranchAddress.Text
        report.txt_Spouse.Text = String.Empty
        report.txt_witness1.Text = IS_Sales_PreprintedReleaseDocs.txt_witness1.Text
        report.txt_witness2.Text = IS_Sales_PreprintedReleaseDocs.txt_witness2.Text

        report.txt_AccountName1.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_BM1.Text = IS_Sales_PreprintedReleaseDocs.txt_bm.Text

        report.txt_AccountName2.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_BM2.Text = IS_Sales_PreprintedReleaseDocs.txt_bm.Text

        report.txt_AccountName3.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_CTCClient.Text = IS_Sales_PreprintedReleaseDocs.txt_ctcClient.Text
        report.txt_CTCClientWhere.Text = IS_Sales_PreprintedReleaseDocs.txt_ctcclientissuedat.Text

        report.txt_BM3.Text = IS_Sales_PreprintedReleaseDocs.txt_bm.Text
        report.txt_CTCBM.Text = IS_Sales_PreprintedReleaseDocs.txt_ctcnobm.Text
        report.txt_CTCBMWhere.Text = IS_Sales_PreprintedReleaseDocs.txt_ctcissuedatbm.Text

        report.txt_FinAmtWord.Text = IS_Sales_PreprintedReleaseDocs.txt_texttowords.Text
        report.txt_IntRatePAWord.Text = IS_Sales_PreprintedReleaseDocs.txt_InterestRateWord.Text

        report.ShowPreview
    End Sub

    Private Sub DOReconvey_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles DOReconvey.ItemClick
        Dim report As New rpt_rd_deedofreconveyance()

        report.txt_AccountName.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_AccountName1.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_AccountAddress.Text = IS_Sales_PreprintedReleaseDocs.txt_address.Text
        report.txt_Brand.Text = IS_Sales_PreprintedReleaseDocs.txt_brand.Text
        report.txt_Model.Text = IS_Sales_PreprintedReleaseDocs.txt_model.Text
        report.txt_Engineno.Text = IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text
        report.txt_Chassisno.Text = IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text
        report.txt_Color.Text = IS_Sales_PreprintedReleaseDocs.txt_color.Text
        report.txt_DateGranted.Text = Format(IS_Sales_PreprintedReleaseDocs.receivedDate.Value, "MMMM d,yyyy")
        report.txt_BranchAddress.Text = IS_Sales_PreprintedReleaseDocs.txt_BranchAddress.Text
        report.txt_Witness1.Text = IS_Sales_PreprintedReleaseDocs.txt_witness1.Text
        report.txt_Witness2.Text = IS_Sales_PreprintedReleaseDocs.txt_witness2.Text

        report.txt_ResCert.Text = IS_Sales_PreprintedReleaseDocs.txt_ctcClient.Text
        report.txt_ResCertWhen.Text = Format(IS_Sales_PreprintedReleaseDocs.ctcClientIssuedOn.Value, "MMMM d,yyyy")
        report.txt_ResCertWhere.Text = IS_Sales_PreprintedReleaseDocs.txt_ctcclientissuedat.Text
        report.ShowPreview
    End Sub

    Private Sub DOSwAoM_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles DOSwAoM.ItemClick
        Dim report As New rpt_rd_deedofsalewaom()

        report.txt_AccountName.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_AccountAddress.Text = IS_Sales_PreprintedReleaseDocs.txt_address.Text
        report.txt_Brand.Text = IS_Sales_PreprintedReleaseDocs.txt_brand.Text
        report.txt_Model.Text = IS_Sales_PreprintedReleaseDocs.txt_model.Text
        report.txt_Engineno.Text = IS_Sales_PreprintedReleaseDocs.txt_engineNo.Text
        report.txt_Chassisno.Text = IS_Sales_PreprintedReleaseDocs.txt_chassisNo.Text
        report.txt_Color.Text = IS_Sales_PreprintedReleaseDocs.txt_color.Text
        report.txt_AccountName1.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_BranchBM.Text = IS_Sales_PreprintedReleaseDocs.txt_bm.Text
        report.txt_witness1.Text = IS_Sales_PreprintedReleaseDocs.txt_witness1.Text
        report.txt_witness2.Text = IS_Sales_PreprintedReleaseDocs.txt_witness2.Text
        report.txt_AccountName2.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_CTCClient.Text = IS_Sales_PreprintedReleaseDocs.txt_ctcClient.Text
        report.txt_CTCClientIssuedWhere.Text = IS_Sales_PreprintedReleaseDocs.txt_ctcclientissuedat.Text

        report.ShowPreview
    End Sub

    Private Sub DisclosureStatement_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles DisclosureStatement.ItemClick
        Dim report As New rpt_rd_disclosurestatementolct()

        report.txt_AccountName.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_AccountAddress.Text = IS_Sales_PreprintedReleaseDocs.txt_address.Text
        report.txt_AmountFin.Text = IS_Sales_PreprintedReleaseDocs.txt_FinancedAmt.Text
        report.txt_AmountFin1.Text = IS_Sales_PreprintedReleaseDocs.txt_FinancedAmt.Text
        report.txt_AmountFin2.Text = IS_Sales_PreprintedReleaseDocs.txt_FinancedAmt.Text
        report.txt_IntRateperAnnum.Text = IS_Sales_PreprintedReleaseDocs.txt_INTRatePerAnum.Text
        report.txt_1stPay.Text = IS_Sales_PreprintedReleaseDocs.firstpaydate.Text
        report.txt_MaturityDate.Text = IS_Sales_PreprintedReleaseDocs.maturityDate.Text
        report.txt_Interest.Text = IS_Sales_PreprintedReleaseDocs.txt_TEMPINT.Text
        report.txt_Interest1.Text = IS_Sales_PreprintedReleaseDocs.txt_TEMPINT.Text
        report.txt_IntRate.Text = IS_Sales_PreprintedReleaseDocs.txt_intrate.Text
        report.txt_IntRate1.Text = IS_Sales_PreprintedReleaseDocs.txt_intrate.Text
        report.txt_Terms.Text = IS_Sales_PreprintedReleaseDocs.txt_terms.Text
        report.txt_MA.Text = IS_Sales_PreprintedReleaseDocs.txt_PMT.Text
        report.txt_BM.Text = IS_Sales_PreprintedReleaseDocs.txt_bm.Text
        report.txt_AccountName1.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text

        report.ShowPreview
    End Sub

    Private Sub Waiver_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles Waiver.ItemClick
        Dim report As New rpt_rd_waiver()

        report.txt_AccountName.Text = IS_Sales_PreprintedReleaseDocs.txt_cust.Text
        report.txt_BM.Text = IS_Sales_PreprintedReleaseDocs.txt_bm.Text
        report.txt_DateGranted.Text = IS_Sales_PreprintedReleaseDocs.receivedDate.Text

        report.ShowPreview
    End Sub

End Class