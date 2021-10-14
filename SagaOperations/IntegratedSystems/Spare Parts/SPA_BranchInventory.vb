Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_BranchInventory
    Sub Search_AllBranches_Inventory()
        Dim Parameters As SqlParameter() = {}

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_Show_AllBranch_Inventory")
    End Sub

    Sub SearchPartNumber_ToBranch_Date()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_BrCode.EditValue),
            New SqlParameter("@ParamDateBegin", dtp_dBegin.EditValue),
            New SqlParameter("@ParamDateEnd", dtp_dEnd.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_Show_BranchInventory_Date")
    End Sub

    Sub SPA_Show_BranchInventory_QuickSearch()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_BrCode.EditValue),
            New SqlParameter("@ParamPartsNumber", txt_Search.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_Show_BranchInventory_QuickSearch")
    End Sub

    Private Sub SPA_BranchInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_dBegin.EditValue = Now
        dtp_dEnd.EditValue = Now

        If MainMenu.statusBrCode.Caption = "000" Then
            txt_BrCode.Enabled = True
            txt_BrCode.EditValue = MainMenu.statusBrCode.Caption
        Else
            txt_BrCode.Enabled = False
            txt_BrCode.EditValue = MainMenu.statusBrCode.Caption
        End If

        If txt_Search.EditValue <> String.Empty Then
            SPA_Show_BranchInventory_QuickSearch()
        End If
    End Sub

    Private Sub btn_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Find.ItemClick
        SearchPartNumber_ToBranch_Date()
    End Sub

    Private Sub chkBranches_EditValueChanged(sender As Object, e As EventArgs) Handles chkBranches.EditValueChanged
        If chkBranches.EditValue.ToString = True Then
            Search_AllBranches_Inventory()
            MsgBox(chkBranches.EditValue.ToString)
        Else
            GridView.Columns.Clear()
            MsgBox("No")
        End If
    End Sub

    Private Sub btn_Print_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Print.ItemClick
        Dim report As New xRptBranchInventory()
        ' Obtain a parameter and set its value.
        report.Parameters("DateBegin").Value = Format(dtp_dBegin.EditValue, "MM/dd/yyyy")
        report.Parameters("DateEnd").Value = Format(dtp_dEnd.EditValue, "MM/dd/yyyy")
        report.Parameters("branchName").Value = MainMenu.StatusLevel.Caption
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

    Private Sub txt_Search_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Search.EditValueChanged
        SPA_Show_BranchInventory_QuickSearch()
    End Sub

End Class