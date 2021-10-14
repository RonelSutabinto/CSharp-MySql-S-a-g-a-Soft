Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Public Class frm_Summaries

    private sub IS_FirstLoadSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormLoad()
    End Sub

    private sub FormLoad()
        txt_DEPRepLabel.Text = $"DEP > 45 Days = {cntDeptoRep}"
        txt_REPHOLabel.Text = $"REP > 60 Days = {cntRepAged}"
        mcForDep.Text = $"MC For Depo = {cntMCForDep}"

        txt_SPA_CustDepDueLabel.Text = $"CUSTOMERS DEPOSIT DUE = {cntSPACustDepDue} Accounts"

        txt_CurMCAcct.Text = cntMCCurrAcct
        txt_MCOverdueAcct.Text = cntMCOverAcct
        txt_TotOvCurAcct.Text = cntTotCurOver
        txt_DepAcct.Text = cntMCDEPAcct
    End Sub

    private sub btn_Refresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Refresh.ItemClick
        CountAllTransactions()
        FormLoad()
    End Sub

    private sub txt_SPA_CustDepDueLabel_Click_1(sender As Object, e As EventArgs) Handles txt_SPA_CustDepDueLabel.Click
        Me.IsMdiContainer = True
        'SPA_ShowDueCustDep.MdiParent = MainMenu
        'SPA_ShowDueCustDep.Show()
        'SPA_ShowDueCustDep.Focus()
        Me.Close()
    End Sub

    private sub txt_DEPRepLabel_Click(sender As Object, e As EventArgs) Handles txt_DEPRepLabel.Click
        Me.IsMdiContainer = True
        Using frm = New rpt_DEPtoREP With {
            .MdiParent = MainMenu,
            .Text = "DEPOSITED TO REPOSSESSED REPORT"
        }
            frm.Unit_Status.EditValue = "DEP"
            frm.Days.EditValue = 45
            frm.Show_DEP_To_REP()
            frm.Show()
            frm.Focus()
        End Using
        Me.Close()
    End Sub

    private sub txt_REPHOLabel_Click(sender As Object, e As EventArgs) Handles txt_REPHOLabel.Click
        Me.IsMdiContainer = True
        Using frm = New rpt_DEPtoREP With {
            .MdiParent = MainMenu,
            .Text = "REPOSSESSED TO HO REPORT"
        }
            frm.Unit_Status.EditValue = "REP"
            frm.Days.EditValue = 60
            frm.Show_DEP_To_REP()
            frm.Show()
            frm.Focus()
        End Using
        Me.Close()
    End Sub

    private sub txt_CurMCAcct_Click(sender As Object, e As EventArgs) Handles txt_CurMCAcct.Click, mSummary.Click, dCollection_Efficiency.Click, dInstallment.Click, dCash.Click
        IS_FirstLoadSummaryTabular.ShowDialog()
    End Sub

    private sub txt_MCOverdueAcct_Click(sender As Object, e As EventArgs) Handles txt_MCOverdueAcct.Click
        IS_FirstLoadSummaryTabular.ShowDialog()
    End Sub

    private sub txt_TotOvCurAcct_Click(sender As Object, e As EventArgs) Handles txt_TotOvCurAcct.Click
        IS_FirstLoadSummaryTabular.ShowDialog()
    End Sub

    private sub txt_DepAcct_Click(sender As Object, e As EventArgs) Handles txt_DepAcct.Click
        IS_FirstLoadSummaryTabular.ShowDialog()
    End Sub

    private sub IS_FirstLoadSummary_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged

    End Sub

    private sub IS_FirstLoadSummary_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    private sub IS_FirstLoadSummary_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        dCash.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DateGranted, Count(SaleType) AS dCash FROM CustAccount WHERE SaleType LIKE 'COD' AND DateGranted >= '{Date.Today}' OR DateGranted <= '{Date.Today}'  GROUP BY DateGranted", "dCash")
        dInstallment.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT DateGranted, Count(SaleType) AS dCash FROM CustAccount WHERE SaleType NOT LIKE 'COD' AND Tag NOT LIKE 'ASM'  AND DateGranted >= '{Date.Today}' OR DateGranted <= '{Date.Today}' GROUP BY DateGranted", "dCash")
        mSummary.Text = Date.Today.ToString("MMMM dd, yyyy")
        class_Procedures.splash_Close()
    End Sub

    private sub mcForDep_Click(sender As Object, e As EventArgs) Handles mcForDep.Click
        Me.IsMdiContainer = True
        Dim formVariable = New rpt_MCForDepo() With {.MdiParent = MainMenu}
        formVariable.barEditItem_Branch.EditValue = class_saga_variables.sbranchcode
        formVariable.BarEditItem_CutOff.EditValue = Now
        formVariable.showList()
        formVariable.Show()
        formVariable.Focus()
        Me.Close()
    End Sub

End Class