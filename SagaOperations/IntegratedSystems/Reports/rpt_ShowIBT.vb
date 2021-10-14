Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class rpt_ShowIBT
    Private Sub rpt_ShowIBT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MainMenu.statusBrCode.Caption = "000" Then
            BranchCode.Enabled = True
            BranchCode.EditValue = MainMenu.statusBrCode.Caption
        Else
            BranchCode.Enabled = False
            BranchCode.EditValue = MainMenu.statusBrCode.Caption
        End If

        mg_ShowBranchDetails()

        DateBegin.EditValue = Now
        DateEnd.EditValue = Now
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

    Private Sub cmd_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        class_Procedures.splash_Show("Loading Interbranch Payment List")
        showActualCollection()
        class_Procedures.splash_Close()
    End Sub

    Sub showActualCollection()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", BranchCode.EditValue),
            New SqlParameter("@ParamDateBegin", DateBegin.EditValue),
            New SqlParameter("@ParamDateEnd", DateEnd.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCIBT, GridView, "rpt_ShowIBT")
    End Sub

    Private Sub cmd_Print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick
        Dim report As New RPT_ActualCollectionPrintPreview()
        GridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GCIBT

        report.Parameters("AeCode").Value = String.Empty
        report.Parameters("BranchAddress").Value = BranchAddress.Text
        report.Parameters("BranchCode").Value = BranchCode.EditValue
        report.Parameters("BranchName").Value = BranchName.Text
        report.Parameters("CheckedBy").Value = CheckedBy.Text
        report.Parameters("DateBegin").Value = Format(DateBegin.EditValue, "MM/dd/yyyy")
        report.Parameters("DateEnd").Value = Format(DateEnd.EditValue, "MM/dd/yyyy")
        report.Parameters("Preparedby").Value = PreparedBy.Text
        report.Parameters("ReportTitle").Value = "INTERBRANCH PAYMENT REPORT"

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Private Sub GridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        If e.Clicks > 1 Then
            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
        End If
    End Sub

    Private Sub rpt_ShowIBT_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)
    End Sub

End Class