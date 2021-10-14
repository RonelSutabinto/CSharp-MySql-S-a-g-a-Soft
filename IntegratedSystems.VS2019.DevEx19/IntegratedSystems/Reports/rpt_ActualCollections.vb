Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Public Class rpt_ActualCollections
    Dim ActualColReport As New RPT_ActualCollectionPrintPreview

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

    Private Sub rpt_ActualCollections_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub rpt_ActualCollections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Saga_Variables.Initialize_AE(class_Saga_Variables.sBranchCode)
        class_Saga_Procedures.Initialize_AE(Account_Executive, RepositoryItemLookUpEdit_AE)
    End Sub

    Private Sub rpt_ActualCollections_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
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

    Private Sub cmd_show_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamCorp", Corporation.EditValue),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode),
            New SqlParameter("@ParamAECode", Account_Executive.EditValue),
            New SqlParameter("@ParamStartdate", class_Saga_Variables.dtStart),
            New SqlParameter("@ParamEndDate", class_Saga_Variables.dtEnd)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "rpt_Actual_Collection", "Collections List", True)
    End Sub

    Private Sub cmb_print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        'gridControl.ShowRibbonPrintPreview()
        ' Create a report instance.
        Dim report As New RPT_ActualCollectionPrintPreview()
        gridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = gridControl
        'Obtain a parameter And set its value.
        report.Parameters("ReportTitle").Value = $"ACTUAL COLLECTIONS {Corporation.EditValue}"
        report.Parameters("BranchCode").Value = class_Saga_Variables.sBranchCode
        report.Parameters("BranchAddress").Value = sBranchAddress
        report.Parameters("BranchName").Value = sBranchName
        report.Parameters("AeCode").Value = Account_Executive.EditValue
        report.Parameters("DateBegin").Value = Format(class_Saga_Variables.dtStart, "MMM dd, yyyy")
        report.Parameters("DateEnd").Value = Format(class_Saga_Variables.dtEnd, "MMM dd, yyyy")
        report.Parameters("Preparedby").Value = sPreparedBy
        report.Parameters("CheckedBy").Value = sCheckedBy

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Private Sub BtnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        gridView.SelectAll()
    End Sub

    Private Sub fromgridControl1()
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = gridView.Columns.ColumnByFieldName("AccountNumber")
        If Col Is Nothing Then Exit Sub
        Dim DataRowCount As Integer = gridView.DataRowCount

        Dim I As Integer
        For I = 0 To DataRowCount - 1
            MsgBox(gridView.GetRowCellValue(I, "AccountNumber").ToString())
        Next

    End Sub

    Private Sub fromgridControl2()
        For i As Integer = 0 To gridView.DataRowCount - 1
            MsgBox(gridView.GetRowCellValue(i, "AccountNumber").ToString())
        Next
    End Sub

    Private Sub RepositoryItemLookUpEdit_AE_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemLookUpEdit_AE.ButtonClick
        If e.Button.Index.Equals(1) Then Account_Executive.EditValue = String.Empty
    End Sub

    Private Sub gridView_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gridView.ValidatingEditor
        If (gridView.FocusedColumn.FieldName = "BranchCode") Then
            e.ErrorText = "sdfdf"
        End If
    End Sub

    Private Sub gridView_CustomDrawFooter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView.CustomDrawFooter
        'Dim brush As Brush = e.Cache.GetGradientBrush(e.Bounds, Color.Cornsilk, Color.DarkKhaki, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
        'e.Graphics.FillRectangle(brush, e.Bounds)
        'ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
        'Prevent default painting
        e.Handled = True
    End Sub

    Private Sub gridView_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gridView.RowCellClick
        If e.Clicks > 1 Then
            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
        End If
    End Sub


End Class