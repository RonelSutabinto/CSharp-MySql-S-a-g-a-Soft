Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class SPA_ShowDueCustDep
    Sub SPA_ShowCustDepDue()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_BrCode.EditValue),
            New SqlParameter("@ParamDays", txt_NoofDays.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_ShowCustDepDue")
    End Sub

    Private Sub SPA_BranchInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_NoofDays.EditValue = MainMenu.iSPADepoDays
        If class_Saga_Variables.sBranchCode = "000" Then
            txt_BrCode.Enabled = True
            txt_BrCode.EditValue = class_Saga_Variables.sBranchCode
        Else
            txt_BrCode.Enabled = False
            txt_BrCode.EditValue = class_Saga_Variables.sBranchCode
        End If
    End Sub

    Private Sub btn_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Find.ItemClick
        SPA_ShowCustDepDue()
    End Sub

    Private Sub btn_Print_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Print.ItemClick
        Dim report As New xRptBranchInventory()
        ' Obtain a parameter and set its value.
        report.Parameters("branchCode").Value = txt_BrCode.EditValue
        ' MsgBox(Format(dtp_dBegin.EditValue, "MM/dd/yyyy"))
        ' Hide the Parameters' UI from end-users (if you did not hide it at design time).
        For Each param In report.Parameters
            param.Visible = False
        Next
        GridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GridControl
        report.ShowPreview
    End Sub

End Class