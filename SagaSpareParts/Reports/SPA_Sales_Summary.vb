Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Sales_Summary
    Sub SPA_Sales_Report()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamDateBegin", dtp_DateBegin.EditValue),
            New SqlParameter("@ParamDateEnd", dtp_DateEnd.EditValue),
            New SqlParameter("@ParamBranchCode", txt_BrCode.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, gridView, "SPA_Sales_Report")
    End Sub

    Private Sub SPA_Sales_Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_BrCode.EditValue = class_Saga_Variables.sBranchCode
        dtp_DateBegin.EditValue = Now
        dtp_DateEnd.EditValue = Now

        If class_Saga_Variables.sBranchCode = "000" Then
            txt_BrCode.Enabled = True
            txt_BrCode.EditValue = class_Saga_Variables.sBranchCode
        Else
            txt_BrCode.Enabled = False
            txt_BrCode.EditValue = class_Saga_Variables.sBranchCode
        End If
    End Sub

    Private Sub btn_Print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print.ItemClick
        Dim report As New xRptSales_Summary()
        ' Obtain a parameter and set its value.
        'report.Parameters("DateTrans").Value = Main.dateStatus.Caption
        report.Parameters("DateBegin").Value = dtp_DateBegin.EditValue
        report.Parameters("DateEnd").Value = dtp_DateEnd.EditValue
        report.Parameters("branchCode").Value = class_Saga_Variables.sBranchCode
        report.Parameters("branchName").Value = class_Saga_Database.get_Branch_Name(class_Saga_Variables.sBranchCode)
        report.Parameters("PreparedBy").Value = class_Variables.sUserName
        'report.Parameters("BranchTo").Value = txt_BrCode.EditValue
        'report.Parameters("BranchFrom").Value = Main.statusBrCode.Caption
        ' Hide the Parameters' UI from end-users (if you did not hide it at design time).
        For Each param In report.Parameters
            param.Visible = False
        Next
        gridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = gridControl
        ' report.ShowPreview
    End Sub

    Private Sub btn_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Find.ItemClick
        SPA_Sales_Report()
    End Sub

End Class