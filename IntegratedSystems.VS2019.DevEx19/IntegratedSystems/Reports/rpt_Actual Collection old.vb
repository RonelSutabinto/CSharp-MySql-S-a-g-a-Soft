Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class rpt_Actual_Collectionold

    private sub rpt_Actual_Collection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_brCode.Caption = class_saga_variables.sbranchcode
        If txt_brCode.Caption = "000" Then
            txt_brCode.Enabled = True
        End If
    End Sub

    private sub showActualCollection()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_brCode.EditValue),
            New SqlParameter("@ParamStartdate", txt_StartDate.EditValue),
            New SqlParameter("@ParamEndDate", txt_EndDate.EditValue),
            New SqlParameter("@ParamAECode", txt_aecode.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "rpt_Actual_Collection")
    End Sub

    private sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim H As Integer = 0
        H = 40
        e.Graphics.DrawString("ACTUAL COLLECTION", New Drawing.Font("Calibri", 14), Brushes.Black, 50, H)
        H += 30
        e.Graphics.DrawString("BRANCH CODE:", New Drawing.Font("Calibri", 12), Brushes.Black, 50, H)
        e.Graphics.DrawString(txt_brCode.Caption, New Drawing.Font("Calibri", 12), Brushes.Black, 200, H)
        H += 20
        e.Graphics.DrawString("DATE FROM:", New Drawing.Font("Calibri", 12), Brushes.Black, 50, H)
        e.Graphics.DrawString(txt_StartDate.Caption, New Drawing.Font("Calibri", 12), Brushes.Black, 200, H)
        H += 20
        e.Graphics.DrawString("DATE TO:", New Drawing.Font("Calibri", 12), Brushes.Black, 50, H)
        e.Graphics.DrawString(txt_EndDate.Caption, New Drawing.Font("Calibri", 12), Brushes.Black, 200, H)
        H += 30
        e.Graphics.DrawString("BR", New Drawing.Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 50, H)
        e.Graphics.DrawString("ACCOUNTNUMBER", New Drawing.Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 80, H)
        e.Graphics.DrawString("LED", New Drawing.Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 210, H)
        e.Graphics.DrawString("ACCOUNT NAME", New Drawing.Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 240, H)
        e.Graphics.DrawString("POSTING DATE", New Drawing.Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 400, H)
        e.Graphics.DrawString("REFERENCE", New Drawing.Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 500, H)
        e.Graphics.DrawString("REBATE", New Drawing.Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 600, H)
        e.Graphics.DrawString("AMOUNT PAID", New Drawing.Font("Calibri", 10, FontStyle.Bold), Brushes.Black, 700, H)
        H += 20
    End Sub

    private sub rpt_Actual_Collection_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        gridView.SaveLayoutToRegistry("ActualCollectionRPT")
    End Sub

    private sub cmd_show_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmd_show.ItemClick
        gridControl.Visible = True

        If txt_aecode.EditValue = String.Empty Then
            txt_aecode.EditValue = " "
        End If
        ShowActualCollection()
        gridView.RestoreLayoutFromRegistry("ActualCollectionRPT")
    End Sub

    private sub cmb_print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmb_print.ItemClick
        gridControl.Visible = False
        PrintableComponentLink1.CreateDocument()
    End Sub

    private sub BtnExport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnExport.ItemClick
        rpt_ActualCollections.ShowDialog()
    End Sub

    private sub gridView_CustomDrawFooter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView.CustomDrawFooter
        'Dim brush As Brush = e.Cache.GetGradientBrush(e.Bounds, Color.Cornsilk, Color.DarkKhaki, System.Drawing.Drawing2D.LinearGradientMode.Vertical)
        'e.Graphics.FillRectangle(brush, e.Bounds)
        'ControlPaint.DrawBorder3D(e.Graphics, e.Bounds, Border3DStyle.RaisedInner)
        'Prevent default painting
        e.Handled = True
    End Sub

End Class