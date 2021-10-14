Imports MyClassLibrary.Classes

Public Class frm_Summaries

    Private Sub IS_FirstLoadSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    Sub FormLoad()
        txt_DEPRepLabel.Text = $"DEP > 45 Days = {cntDeptoRep}"
        txt_REPHOLabel.Text = $"REP > 60 Days = {cntRepAged}"
        mcForDep.Text = $"MC For Depo = {cntMCForDep}"

        txt_SPA_CustDepDueLabel.Text = $"CUSTOMERS DEPOSIT DUE = {cntSPACustDepDue} Accounts"

        txt_CurMCAcct.Text = cntMCCurrAcct
        txt_MCOverdueAcct.Text = cntMCOverAcct
        txt_TotOvCurAcct.Text = cntTotCurOver
        txt_DepAcct.Text = cntMCDEPAcct
    End Sub

    Private Sub Btn_Refresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Refresh.ItemClick
        CountAllTransactions()
        FormLoad()
    End Sub

    Private Sub txt_SPACustDepDue_Click(sender As Object, e As EventArgs)
        Me.IsMdiContainer = True
        SPA_ShowDueCustDep.MdiParent = Me
        SPA_ShowDueCustDep.Show()
        SPA_ShowDueCustDep.Focus()
    End Sub

    Private Sub txt_SPA_CustDepDueLabel_Click_1(sender As Object, e As EventArgs) Handles txt_SPA_CustDepDueLabel.Click
        Me.IsMdiContainer = True
        SPA_ShowDueCustDep.MdiParent = MainMenu
        SPA_ShowDueCustDep.Show()
        SPA_ShowDueCustDep.Focus()
        Me.Close()
    End Sub

    Private Sub txt_DEPRepLabel_Click(sender As Object, e As EventArgs) Handles txt_DEPRepLabel.Click
        Me.IsMdiContainer = True
        Dim formVariable = New rpt_DEPtoREP()
        formVariable.MdiParent = MainMenu
        formVariable.Text = "DEPOSITED TO REPOSSESSED REPORT"
        formVariable.txt_NoofDays.EditValue = 45
        formVariable.txt_whcode.EditValue = "DEP"
        formVariable.showDEPtoREP()
        formVariable.Show()
        formVariable.Focus()
        Me.Close()
    End Sub

    Private Sub txt_REPHOLabel_Click(sender As Object, e As EventArgs) Handles txt_REPHOLabel.Click
        Me.IsMdiContainer = True
        Dim formVariable = New rpt_DEPtoREP()
        formVariable.MdiParent = MainMenu
        formVariable.Text = "REPOSSESSED TO HO REPORT"
        formVariable.txt_whcode.EditValue = "REP"
        formVariable.txt_NoofDays.EditValue = 60
        formVariable.showDEPtoREP()
        formVariable.Show()
        formVariable.Focus()
        Me.Close()
    End Sub

    Private Sub txt_CurMCAcct_Click(sender As Object, e As EventArgs) Handles txt_CurMCAcct.Click, mSummary.Click, dCollection_Efficiency.Click, dInstallment.Click, dCash.Click
        IS_FirstLoadSummaryTabular.ShowDialog()
    End Sub

    Private Sub txt_MCOverdueAcct_Click(sender As Object, e As EventArgs) Handles txt_MCOverdueAcct.Click
        IS_FirstLoadSummaryTabular.ShowDialog()
    End Sub

    Private Sub txt_TotOvCurAcct_Click(sender As Object, e As EventArgs) Handles txt_TotOvCurAcct.Click
        IS_FirstLoadSummaryTabular.ShowDialog()
    End Sub

    Private Sub txt_DepAcct_Click(sender As Object, e As EventArgs) Handles txt_DepAcct.Click
        IS_FirstLoadSummaryTabular.ShowDialog()
    End Sub

    Private Sub IS_FirstLoadSummary_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

    End Sub

    Private Sub IS_FirstLoadSummary_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub IS_FirstLoadSummary_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dCash.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DateGranted, Count(SaleType) AS dCash FROM CustAccount WHERE SaleType LIKE 'COD' AND DateGranted >= '{Date.Today}' OR DateGranted <= '{Date.Today}'  GROUP BY DateGranted", "dCash")
        dInstallment.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DateGranted, Count(SaleType) AS dCash FROM CustAccount WHERE SaleType NOT LIKE 'COD' AND Tag NOT LIKE 'ASM'  AND DateGranted >= '{Date.Today}' OR DateGranted <= '{Date.Today}' GROUP BY DateGranted", "dCash")
        mSummary.Text = Date.Today.ToString("MMMM dd, yyyy")
        class_Procedures.splash_Close()
    End Sub

    Private Sub mcForDep_Click(sender As Object, e As EventArgs) Handles mcForDep.Click
        Me.IsMdiContainer = True
        Dim formVariable = New rpt_MCForDepo()
        formVariable.MdiParent = MainMenu
        formVariable.barEditItem_Branch.EditValue = MainMenu.statusBrCode.Caption
        formVariable.BarEditItem_CutOff.EditValue = Now
        formVariable.showList()
        formVariable.Show()
        formVariable.Focus()
        Me.Close()
    End Sub

End Class