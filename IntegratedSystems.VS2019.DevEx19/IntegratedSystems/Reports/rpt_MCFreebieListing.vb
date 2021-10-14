Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Public Class rpt_MCFreebieListing
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

    Private Sub rpt_MCFreebieListing_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub rpt_MCFreebieListing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rpt_MCFreebieListing_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim sqlParameters As SqlParameter() = {
           New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
           New SqlParameter("@ParamTransactedBy", class_Variables.sUserName)
       }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowBranchDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                sPreparedBy = myDataReader("Maker").ToString()
                sCheckedBy = myDataReader("BM").ToString()
                sBranchName = myDataReader("BranchName").ToString()
                sBranchAddress = myDataReader("BranchAddress").ToString()
            End If
        End Using
    End Sub

    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode),
            New SqlParameter("@ParamDateBegin", class_Saga_Variables.dtStart),
            New SqlParameter("@ParamDateEnd", class_Saga_Variables.dtEnd)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "mg_ShowAccountWFreebie")
        gridView.Columns("AccountName").GroupIndex = 0
        gridView.Columns("PartsNumber").GroupIndex = 1
    End Sub

    Private Sub btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        Dim report As New RPT_ActualCollectionPrintPreview()
        gridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = gridControl

        report.Parameters("AeCode").Value = String.Empty
        report.Parameters("ReportTitle").Value = "MC FREEBIE LISTING"
        report.Parameters("BranchCode").Value = class_Saga_Variables.sBranchCode
        report.Parameters("BranchName").Value = sBranchName
        report.Parameters("BranchAddress").Value = sBranchAddress
        report.Parameters("DateBegin").Value = Format(class_Saga_Variables.dtStart, "MMM dd, yyyy")
        report.Parameters("DateEnd").Value = Format(class_Saga_Variables.dtEnd, "MMM dd, yyyy")
        report.Parameters("Preparedby").Value = sPreparedBy
        report.Parameters("CheckedBy").Value = sCheckedBy

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub
End Class