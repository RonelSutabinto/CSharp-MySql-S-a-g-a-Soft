Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Public Class rpt_InsuranceRpt
    Public Sub New()
        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, gridView, BtnCancel)

        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me, gridView, True)
    End Function

    Private Sub rpt_InsuranceRpt_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub rpt_InsuranceRpt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rpt_InsuranceRpt_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Dim sqlParameters As SqlParameter() = {0New SqlParameter("@ParamRptID", RptID.Text)}

        'Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ReportDetails")
        '    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
        '        myDataReader.Read()
        '        RptDesc1.Text = myDataReader("RptDesc1").ToString()
        '        RptDesc2.Text = myDataReader("RptDesc2").ToString()
        '        OffOwner.Text = myDataReader("OffOwner").ToString()
        '        Checked.Text = myDataReader("Checked").ToString()
        '        CheckedbyPos.Text = myDataReader("CheckedbyPos").ToString()
        '        CertifiedCorr.Text = myDataReader("CertifiedCorr").ToString()
        '        CertifiedCorrPos.Text = myDataReader("CertifiedCorrPos").ToString()
        '        Verified.Text = myDataReader("Verified").ToString()
        '        VerifiedPos.Text = myDataReader("VerifiedPos").ToString()
        '        Approved.Text = myDataReader("Approved").ToString()
        '        ApprovedPos.Text = myDataReader("ApprovedPos").ToString()
        '    End If
        'End Using
    End Sub

    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode),
            New SqlParameter("@ParamStartdate", class_Saga_Variables.dtStart),
            New SqlParameter("@ParamEndDate", class_Saga_Variables.dtEnd)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GInsurance, gridView, "rpt_InsuranceRpt", "Insurance Report", True)
    End Sub

    Private Sub btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        ' Create a report instance.
        Dim report As New RPT_LTORegExpenses()
        gridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GInsurance
        'Obtain a parameter And set its value.
        'report.Parameters("BranchName").Value = BranchName.Text
        'report.Parameters("BranchAddress").Value = BranchAddress.Text
        'report.Parameters("Title1").Value = "SCHEDULE OF ESTIMATED LTO REGISTRATION EXPENSES"
        'report.Parameters("Title2").Value = "CASH / INSTALLMENT SALES (BRAND NEW)"
        'report.Parameters("PrintedDate").Value = Format(Now, "dddd, MMMM dd, yyyy")
        'report.Parameters("Prepared").Value = PreparedBy.Text
        'report.Parameters("PreparedPos").Value = MakerPos.Text
        'report.Parameters("Checked").Value = Checked.Text
        'report.Parameters("CheckedbyPos").Value = CheckedbyPos.Text
        'report.Parameters("Noted").Value = CheckedBy.Text
        'report.Parameters("NotedPos").Value = "BRANCH MANAGER"
        'report.Parameters("CertifiedCorrect").Value = CertifiedCorr.Text
        'report.Parameters("CertifiedCorrPos").Value = CertifiedCorrPos.Text
        'report.Parameters("Verified").Value = Verified.Text
        'report.Parameters("VerifiedPos").Value = VerifiedPos.Text
        'report.Parameters("Approved").Value = Approved.Text
        'report.Parameters("ApprovedPos").Value = ApprovedPos.Text

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
        If e.Clicks > 1 Then
            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
        End If
    End Sub

End Class