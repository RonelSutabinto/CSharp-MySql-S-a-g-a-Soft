Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class rpt_ActualCollections
    Dim ActualColReport As New RPT_ActualCollectionPrintPreview
    Dim LUEAECode As LookUpEdit = New LookUpEdit()

    Private Sub rpt_ActualCollections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(txt_brCode, RepositoryItemTextEdit1)
        If MainMenu.statusBrCode.Caption = "000" Then
            txt_brCode.Enabled = True
            txt_brCode.EditValue = MainMenu.statusBrCode.Caption
        Else
            txt_brCode.Enabled = False
            txt_brCode.EditValue = MainMenu.statusBrCode.Caption
        End If

        mg_ShowBranchDetails()
        ShowCorp()

        txt_StartDate.EditValue = DateTime.Now.ToString("MM/dd/yyyy")
        txt_EndDate.EditValue = DateTime.Now.ToString("MM/dd/yyyy")
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

    Sub showCorp()
        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowCORP")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    CType(txt_Corp.Edit, RepositoryItemComboBox).Items.Add(myDataReader.Item("CorpCode").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub showActualCollection()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_brCode.EditValue.ToString),
            New SqlParameter("@ParamStartdate", txt_StartDate.EditValue),
            New SqlParameter("@ParamEndDate", txt_EndDate.EditValue),
            New SqlParameter("@ParamAECode", txt_aecode.EditValue.ToString),
            New SqlParameter("@ParamCorp", txt_Corp.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GridControl, GridView, "rpt_Actual_Collection")
    End Sub

    Private Sub cmb_print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick
        'GridControl.ShowRibbonPrintPreview()
        ' Create a report instance.
        Dim report As New RPT_ActualCollectionPrintPreview()
        GridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GridControl
        'Obtain a parameter And set its value.
        report.Parameters("AeCode").Value = txt_aecode.EditValue
        report.Parameters("BranchAddress").Value = BranchAddress.Text
        report.Parameters("BranchCode").Value = txt_brCode.EditValue
        report.Parameters("BranchName").Value = BranchName.Text
        report.Parameters("CheckedBy").Value = CheckedBy.Text
        report.Parameters("DateBegin").Value = Format(txt_StartDate.EditValue, "MM/dd/yyyy")
        report.Parameters("DateEnd").Value = Format(txt_EndDate.EditValue, "MM/dd/yyyy")
        report.Parameters("Preparedby").Value = PreparedBy.Text
        report.Parameters("ReportTitle").Value = "ACTUAL COLLECTIONS" & " - " & txt_Corp.EditValue

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Private Sub BtnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        GridView.SelectAll()
    End Sub

    Sub fromGridControl1()
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = GridView.Columns.ColumnByFieldName("AccountNumber")
        If Col Is Nothing Then Exit Sub
        Dim DataRowCount As Integer = GridView.DataRowCount

        Dim I As Integer
        For I = 0 To DataRowCount - 1
            MsgBox(GridView.GetRowCellValue(I, "AccountNumber").ToString())
        Next

    End Sub

    Sub fromGridControl2()
        For i As Integer = 0 To GridView.DataRowCount - 1
            MsgBox(GridView.GetRowCellValue(i, "AccountNumber").ToString())
        Next
    End Sub

    Private Sub GridView_ValidatingEditor(sender As Object, e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GridView.ValidatingEditor
        If (GridView.FocusedColumn.FieldName = "BranchCode") Then
            e.ErrorText = "sdfdf"
        End If
    End Sub

    Private Sub gridView_CustomDrawFooter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles GridView.CustomDrawFooter
        Dim brush As Brush = e.Cache.GetGradientBrush(e.Bounds, Color.Cornsilk, Color.DarkKhaki, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
        e.Graphics.FillRectangle(brush, e.Bounds)
        ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
        'Prevent default painting
        e.Handled = True
    End Sub

    Private Sub txt_brCode_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles txt_brCode.ItemClick

    End Sub

    Private Sub txt_brCode_EditValueChanged(sender As Object, e As EventArgs) Handles txt_brCode.EditValueChanged
        class_Saga_Variables.Initialize_AE(txt_brCode.EditValue.ToString)
        'RepositoryItemTextEdit2.DropDownRows =
        class_Saga_Procedures.Initialize_AE(RepositoryItemTextEdit2)
    End Sub

    Private Sub BarStaticItem2_ItemDoubleClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarStaticItem2.ItemDoubleClick
        txt_aecode.EditValue = String.Empty
    End Sub

    Private Sub GridView_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView.RowCellClick
        If e.Clicks > 1 Then
            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
        End If
    End Sub

    Private Sub cmd_show_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        class_Procedures.splash_Show("Loading Collection List")
        showActualCollection()
        class_Procedures.splash_Close()
    End Sub

    Private Sub rpt_ActualCollections_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)
    End Sub
End Class