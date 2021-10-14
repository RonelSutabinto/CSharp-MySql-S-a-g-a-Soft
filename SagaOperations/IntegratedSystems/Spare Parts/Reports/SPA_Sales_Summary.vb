Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Sales_Summary
    Sub SPA_Sales_Report()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamDateBegin", dtp_DateBegin.EditValue),
            New SqlParameter("@ParamDateEnd", dtp_DateEnd.EditValue),
            New SqlParameter("@ParamBranchCode", txt_BrCode.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_Sales_Report")
    End Sub

    Private Sub SPA_Sales_Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_BrCode.EditValue = MainMenu.statusBrCode.Caption
        dtp_DateBegin.EditValue = Now
        dtp_DateEnd.EditValue = Now

        If MainMenu.statusBrCode.Caption = "000" Then
            txt_BrCode.Enabled = True
            txt_BrCode.EditValue = MainMenu.statusBrCode.Caption
        Else
            txt_BrCode.Enabled = False
            txt_BrCode.EditValue = MainMenu.statusBrCode.Caption
        End If
    End Sub

    Private Sub btn_Print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print.ItemClick
        Dim report As New xRptSales_Summary()
        ' Obtain a parameter and set its value.
        'report.Parameters("DateTrans").Value = Main.dateStatus.Caption
        report.Parameters("DateBegin").Value = dtp_DateBegin.EditValue
        report.Parameters("DateEnd").Value = dtp_DateEnd.EditValue
        report.Parameters("branchCode").Value = MainMenu.statusBrCode.Caption
        report.Parameters("branchName").Value = MainMenu.StatusLevel.Caption
        report.Parameters("PreparedBy").Value = MainMenu.App_Full_Name.Caption
        'report.Parameters("BranchTo").Value = txt_BrCode.EditValue
        'report.Parameters("BranchFrom").Value = Main.statusBrCode.Caption
        ' Hide the Parameters' UI from end-users (if you did not hide it at design time).
        For Each param In report.Parameters
            param.Visible = False
        Next
        GridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GridControl
        report.ShowPreview
    End Sub

    Private Sub btn_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Find.ItemClick
        SPA_Sales_Report()
    End Sub

End Class