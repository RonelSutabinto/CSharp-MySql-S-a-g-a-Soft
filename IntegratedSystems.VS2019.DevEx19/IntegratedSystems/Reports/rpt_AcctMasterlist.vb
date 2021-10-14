Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Public Class rpt_AcctMasterlist
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

    Private Sub rpt_AcctMasterlist_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub rpt_AcctMasterlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rpt_AcctMasterlist_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub cmd_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode),
            New SqlParameter("@ParamTransactedBy", class_Variables.sUserName)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowBranchDetails", True)
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                sPreparedBy = myDataReader("Maker").ToString()
                sCheckedBy = myDataReader("BM").ToString()
                sBranchName = myDataReader("BranchName").ToString()
                sBranchAddress = myDataReader("BranchAddress").ToString()
            End If
        End Using
    End Sub


    Private Sub cmd_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        ' Create a report instance.
        Dim report As New RPT_ActualCollectionPrintPreview()
        gridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = gridControl
        'Obtain a parameter And set its value.
        report.Parameters("AeCode").Value = txt_AeCode.EditValue

        report.Parameters("BranchCode").Value = class_Saga_Variables.sBranchCode
        report.Parameters("BranchName").Value = sBranchName
        report.Parameters("BranchAddress").Value = sBranchAddress
        report.Parameters("DateBegin").Value = Format(Posting_Date.EditValue, "MMM dd, yyyy")
        report.Parameters("Preparedby").Value = sPreparedBy
        report.Parameters("CheckedBy").Value = sCheckedBy
        report.Parameters("ReportTitle").Value = "MC ACCOUNT MASTERLIST"
        report.XrLabel7.Text = String.Empty

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub
End Class