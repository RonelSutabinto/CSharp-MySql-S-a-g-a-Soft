Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class rpt_PettyCashList

    Private Sub rpt_PettyCashList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rpt_PettyCashList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(BarManager1)
        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit1)

        If MainMenu.statusBrCode.Caption = "000" Then
            BarEditItem_Branch.Enabled = True
            BarEditItem_Branch.EditValue = MainMenu.statusBrCode.Caption
        Else
            BarEditItem_Branch.Enabled = False
            BarEditItem_Branch.EditValue = MainMenu.statusBrCode.Caption
        End If

        mg_ShowPettyCashSummary()
    End Sub

    Sub mg_ShowPettyCashSummary()
        On Error GoTo out

        GridView.Columns.Clear()
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowPettyCashSummary"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 500
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", BarEditItem_Branch.EditValue)
        cmd.Parameters.AddWithValue("@ParamDateBegin", BarEditItem_Date_Start.EditValue)
        cmd.Parameters.AddWithValue("@ParamDateEnd", BarEditItem_Date_End.EditValue)
        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()

        'If Not rs.Read Then
        '    GoTo out
        'End If

        GridControl.DataSource = (rs)
        GridView.BestFitColumns(True)

        GridView.Columns("AmountPaid").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        GridView.Columns("AmountPaid").SummaryItem.DisplayFormat = "Total: {0}"

        GridView.Columns("AccountName").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        GridView.Columns("AccountName").SummaryItem.DisplayFormat = "Record Count: {0}"

        GridView.Columns("TransStatus").GroupIndex = 1

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1
out:    'MsgBox(Err.Description)
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:
    End Sub

    Private Sub Btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        splash_Show("Generating Report")
        mg_ShowPettyCashSummary()
        splash_Close()
    End Sub

    Sub Post_PettyCashForLiquidation()
        On Error GoTo out

        'GridView.Columns.Clear()
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "Post_PettyCashForLiquidation"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 500
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()

        If rs.Read Then
            MsgBox(rs.Item("Status").ToString() & " - " & rs.Item("Message").ToString())
        End If

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1
out:    MsgBox(Err.Description)
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:
    End Sub

    Private Sub Btn_Liquidate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Liquidate.ItemClick
        Post_PettyCashForLiquidation()
    End Sub

    Private Sub Btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick

        Dim report As New RPT_ActualCollectionPrintPreview()
        GridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GridControl
        'report.Parameters("AeCode").Value = ""
        report.Parameters("BranchAddress").Value = "Dipolog City"
        report.Parameters("BranchCode").Value = BarEditItem_Branch.EditValue
        report.Parameters("BranchName").Value = "Main Branch"
        report.Parameters("CheckedBy").Value = String.Empty

        report.Parameters("Preparedby").Value = String.Empty
        report.Parameters("ReportTitle").Value = "SUMMARY OF TRANSACTIONS"
        report.XrLabel7.Text = String.Empty
        report.XrLabel6.Text = String.Empty
        report.Parameters("DateBegin").Value = String.Empty

        report.XrLabel7.Text = String.Empty
        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

End Class