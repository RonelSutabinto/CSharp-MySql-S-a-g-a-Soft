Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class rpt_ClosedAcct
    Private Sub rpt_ClosedAcct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MainMenu.statusBrCode.Caption = "000" Then
            txt_brCode.Enabled = True
            txt_brCode.EditValue = MainMenu.statusBrCode.Caption
        Else
            txt_brCode.Enabled = False
            txt_brCode.EditValue = MainMenu.statusBrCode.Caption
        End If

    End Sub

    Private Sub rpt_ClosedAcct_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(txt_brCode, RepositoryItemLookUpEdit1)

        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)

        txt_StartDate.EditValue = Now
        txt_EndDate.EditValue = Now
    End Sub

    Sub ClosedAccount()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_brCode.EditValue.ToString),
            New SqlParameter("@ParamStartdate", txt_StartDate.EditValue),
            New SqlParameter("@ParamEndDate", txt_EndDate.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GridList, GridView, "rpt_ClosedAccount")
    End Sub

    Private Sub Btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        class_Procedures.splash_Show("Loading Closed Account List")
        ClosedAccount()
        class_Procedures.splash_Close()
    End Sub

    Private Sub GridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        If e.Clicks > 1 Then
            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
        End If
    End Sub

End Class