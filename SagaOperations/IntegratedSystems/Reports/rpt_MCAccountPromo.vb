Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class rpt_MCAccountPromo
    Private Sub rpt_MCAccountPromo_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit1)

        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)

        barEditItem_Branch.EditValue = Now
        barEditItem_Date_End.EditValue = Now

        If MainMenu.statusBrCode.Caption = "000" Then
            barEditItem_Branch.Enabled = True
            barEditItem_Branch.EditValue = MainMenu.statusBrCode.Caption
        Else
            barEditItem_Branch.Enabled = False
            barEditItem_Branch.EditValue = MainMenu.statusBrCode.Caption
        End If

        mg_ShowBranchDetails()
    End Sub

    Sub mg_ShowBranchDetails()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowBranchDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                PreparedBy.Text = myDataReader("Maker").ToString()
                CheckedBy.Text = myDataReader("BM").ToString()
                BranchName.Text = myDataReader("BranchName").ToString()
                BranchAddress.Text = myDataReader("BranchAddress").ToString()
            End If
        End Using
    End Sub

    Private Sub Btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick
        Dim report As New RPT_ActualCollectionPrintPreview()
        GridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GridControl

        report.Parameters("AeCode").Value = String.Empty
        report.Parameters("BranchAddress").Value = BranchAddress.Text
        report.Parameters("BranchCode").Value = barEditItem_Branch.EditValue
        report.Parameters("BranchName").Value = BranchName.Text
        report.Parameters("CheckedBy").Value = CheckedBy.Text
        report.Parameters("DateBegin").Value = Format(barEditItem_Branch.EditValue, "MM/dd/yyyy")
        report.Parameters("DateEnd").Value = Format(barEditItem_Date_End.EditValue, "MM/dd/yyyy")
        report.Parameters("Preparedby").Value = PreparedBy.Text
        report.Parameters("ReportTitle").Value = "MC ACCOUNT RELEASES WITH PROMO DETAILS LISTING"

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Private Sub Btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        ShowList()
    End Sub

    Sub ShowList()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", barEditItem_Branch.EditValue),
            New SqlParameter("@ParamDateBegin", barEditItem_Branch.EditValue),
            New SqlParameter("@ParamDateEnd", barEditItem_Date_End.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GridControl, GridView, "mg_ShowAccountWPromo")
        GridView.Columns("PromoDesc").GroupIndex = 0
    End Sub

End Class