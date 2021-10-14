Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class rpt_InsuranceRpt
    Private Sub cmd_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_BranchCode.EditValue),
            New SqlParameter("@ParamStartdate", DateBegin.EditValue),
            New SqlParameter("@ParamEndDate", DateEnd.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GInsurance, GridView, "rpt_InsuranceRpt")
    End Sub

    Private Sub cmd_Print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick
        ' Create a report instance.
        Dim report As New RPT_LTORegExpenses()
        GridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GInsurance
        'Obtain a parameter And set its value.
        report.Parameters("BranchName").Value = BranchName.Text
        report.Parameters("BranchAddress").Value = BranchAddress.Text
        report.Parameters("Title1").Value = "SCHEDULE OF ESTIMATED LTO REGISTRATION EXPENSES"
        report.Parameters("Title2").Value = "CASH / INSTALLMENT SALES (BRAND NEW)"
        report.Parameters("PrintedDate").Value = Format(Now, "dddd, MMMM dd, yyyy")
        report.Parameters("Prepared").Value = PreparedBy.Text
        report.Parameters("PreparedPos").Value = MakerPos.Text
        report.Parameters("Checked").Value = Checked.Text
        report.Parameters("CheckedbyPos").Value = CheckedbyPos.Text
        report.Parameters("Noted").Value = CheckedBy.Text
        report.Parameters("NotedPos").Value = "BRANCH MANAGER"
        report.Parameters("CertifiedCorrect").Value = CertifiedCorr.Text
        report.Parameters("CertifiedCorrPos").Value = CertifiedCorrPos.Text
        report.Parameters("Verified").Value = Verified.Text
        report.Parameters("VerifiedPos").Value = VerifiedPos.Text
        report.Parameters("Approved").Value = Approved.Text
        report.Parameters("ApprovedPos").Value = ApprovedPos.Text

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Private Sub rpt_InsuranceRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MainMenu.statusBrCode.Caption = "000" Then
            txt_BranchCode.Enabled = True
            txt_BranchCode.EditValue = MainMenu.statusBrCode.Caption
        Else
            txt_BranchCode.Enabled = False
            txt_BranchCode.EditValue = MainMenu.statusBrCode.Caption
        End If

        DateBegin.EditValue = Now
        DateEnd.EditValue = Now

        mg_ShowBranchDetails()
        mg_ReportDetails()
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
                MakerPos.Text = myDataReader("MakerPos").ToString()
            End If
        End Using
    End Sub

    Sub mg_ReportDetails()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamRptID", RptID.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ReportDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                RptDesc1.Text = myDataReader("RptDesc1").ToString()
                RptDesc2.Text = myDataReader("RptDesc2").ToString()
                OffOwner.Text = myDataReader("OffOwner").ToString()
                Checked.Text = myDataReader("Checked").ToString()
                CheckedbyPos.Text = myDataReader("CheckedbyPos").ToString()
                CertifiedCorr.Text = myDataReader("CertifiedCorr").ToString()
                CertifiedCorrPos.Text = myDataReader("CertifiedCorrPos").ToString()
                Verified.Text = myDataReader("Verified").ToString()
                VerifiedPos.Text = myDataReader("VerifiedPos").ToString()
                Approved.Text = myDataReader("Approved").ToString()
                ApprovedPos.Text = myDataReader("ApprovedPos").ToString()
            End If
        End Using
    End Sub

    Private Sub GridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        If e.Clicks > 1 Then
            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
        End If
    End Sub

    Private Sub rpt_InsuranceRpt_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)
    End Sub

End Class