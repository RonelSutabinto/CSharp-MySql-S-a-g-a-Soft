Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class rpt_Credit_Memo
    Private sBranchName, sBranchAddress, sPreparedBy, sCheckedBy As String

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

    Private Sub rpt_Credit_Memo_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub rpt_Credit_Memo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim repositoryBranchCode As New RepositoryItemLookUpEdit
        class_Saga_Procedures.Initialize_Branch(repositoryBranchCode)
        BranchCode.ColumnEdit = repositoryBranchCode
    End Sub

    Private Sub rpt_Credit_Memo_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode),
            New SqlParameter("@ParamTransactedBy", class_Variables.sUserName)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowBranchDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                sBranchName = myDataReader("BranchName").ToString()
                sBranchAddress = myDataReader("BranchAddress").ToString()
                sPreparedBy = myDataReader("Maker").ToString()
                sCheckedBy = myDataReader("BM").ToString()
            End If
        End Using
    End Sub

    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        class_Procedures.splash_Show("Loading Credit Memo Transaction List")
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode),
            New SqlParameter("@ParamDateBegin", class_Saga_Variables.dtStart),
            New SqlParameter("@ParamDateEnd", class_Saga_Variables.dtEnd)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GCCreditMemo, gridView, "rpt_CreditMemo", "Credit Memo Transactions", True)
    End Sub

    Private Sub btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        Dim report As New RPT_ActualCollectionPrintPreview()
        gridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GCCreditMemo

        report.Parameters("ReportTitle").Value = "Credit Memo Report"
        report.Parameters("BranchCode").Value = class_Saga_Variables.sBranchCode
        report.Parameters("BranchName").Value = sBranchName
        report.Parameters("BranchAddress").Value = sBranchAddress
        report.Parameters("AeCode").Value = String.Empty
        report.Parameters("DateBegin").Value = Format(class_Saga_Variables.dtStart, "MMM dd, yyyy")
        report.Parameters("DateEnd").Value = Format(class_Saga_Variables.dtEnd, "MMM dd, yyyy")
        report.Parameters("Preparedby").Value = sPreparedBy
        report.Parameters("CheckedBy").Value = sCheckedBy

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Private Sub gridView_CustomDrawFooter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView.CustomDrawFooter
        'Dim brush As Brush = e.Cache.GetGradientBrush(e.Bounds, Color.Cornsilk, Color.DarkKhaki, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
        'e.Graphics.FillRectangle(brush, e.Bounds)
        'ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
        'Prevent default painting
        e.Handled = True
    End Sub

End Class