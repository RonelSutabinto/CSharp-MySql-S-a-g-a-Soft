Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class rpt_Actual_Releases

    Private Sub rpt_Actual_Releases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(txt_BranchCode, RepositoryItemTextEdit1)

        If MainMenu.statusBrCode.Caption = "000" Then
            txt_BranchCode.Enabled = True
            txt_BranchCode.EditValue = MainMenu.statusBrCode.Caption
        Else
            txt_BranchCode.Enabled = False
            txt_BranchCode.EditValue = MainMenu.statusBrCode.Caption
        End If

        mg_ShowBranchDetails()

        DateBegin.EditValue = DateTime.Now.ToString("MM/dd/yyyy")
        DateEnd.EditValue = DateTime.Now.ToString("MM/dd/yyyy")
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

    Private Sub cmd_find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        class_Procedures.splash_Show("Loading Releases")
        showActualCollection()
        class_Procedures.splash_Close()
    End Sub

    Sub showActualCollection()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_BranchCode.EditValue.ToString),
            New SqlParameter("@ParamStartdate", DateBegin.EditValue),
            New SqlParameter("@ParamEndDate", DateEnd.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GReleases, GridView, "rpt_Release_Register")
    End Sub

    Private Sub cmd_print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick
        Dim report As New RPT_ActualCollectionPrintPreview()
        GridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GReleases

        report.Parameters("AeCode").Value = String.Empty
        report.Parameters("BranchAddress").Value = BranchAddress.Text
        report.Parameters("BranchCode").Value = txt_BranchCode.EditValue
        report.Parameters("BranchName").Value = BranchName.Text
        report.Parameters("CheckedBy").Value = CheckedBy.Text
        report.Parameters("DateBegin").Value = Format(DateBegin.EditValue, "MM/dd/yyyy")
        report.Parameters("DateEnd").Value = Format(DateEnd.EditValue, "MM/dd/yyyy")
        report.Parameters("Preparedby").Value = PreparedBy.Text
        report.Parameters("ReportTitle").Value = "Releases Monitoring"

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Private Sub gridView_CustomDrawFooter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GridView.CustomDrawFooter
        Dim brush As Brush = e.Cache.GetGradientBrush(e.Bounds, Color.Cornsilk, Color.DarkKhaki, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(brush, e.Bounds)
        ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
        'Prevent default painting
        e.Handled = True
    End Sub

    Private Sub GridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        If e.Clicks > 1 Then
            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
        End If
    End Sub

    Private Sub rpt_Actual_Releases_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)
    End Sub

    Private Sub rpt_Actual_Releases_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'GridView.SaveLayoutToRegistry("ReleasesTable")
    End Sub

End Class