Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Public Class PriceList_Summary
    Dim sStatus As String
    Private Sub PriceList_Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, gridView, BtnCancel)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub MC_For_Reprice_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Close()
    End Sub

    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, gridView, True)
    End Sub

    Sub Data_Load(ByVal actionType As String)
        Try
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", Branch.EditValue.ToString()),
                New SqlParameter("@Action_Type", actionType)
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GridControlMain, gridView, "bj_Show_PriceListSummarry", "TABLES")
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub

    Private Sub PriceList_Summary_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_Branch(Branch, RepositoryItemLookUpEdit_Branch)
        Data_Load("Class")
    End Sub

    Private Sub Branch_EditValueChanged(sender As Object, e As EventArgs) Handles Branch.EditValueChanged
        Data_Load("Class")
    End Sub

    Private Sub BarButtonItem_Repo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_Repo.ItemClick
        Data_Load("Class")
    End Sub

    Private Sub BarButtonItem_iRepo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_iRepo.ItemClick
        Data_Load("IREP")
    End Sub

    Private Sub btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        Dim report As New XRpt_Repo_PriceList()
        report.Parameters("Branch").Value = class_Saga_Database.get_Branch_Name(class_Saga_Variables.sBranchCode)
        report.Parameters("DatePrinted").Value = $"As of {Date.Now:MMMM dd, yyyy}"
        For Each param In report.Parameters
            param.Visible = False
        Next
        gridView.SelectAll()
        report.PrintableComponentContainer.PrintableComponent = GridControlMain
        report.ShowPreview
    End Sub
End Class