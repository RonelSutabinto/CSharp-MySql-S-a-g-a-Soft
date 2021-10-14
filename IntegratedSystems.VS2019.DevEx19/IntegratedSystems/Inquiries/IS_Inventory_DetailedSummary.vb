Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_DetailedSummary
    Friend Sub searchInventoryLocalBranch()
        GViewInvList.Columns.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamquickSearch", quickSearch.EditValue),
            New SqlParameter("@ParamIfExist", IfExist.Checked)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GCInvList, GViewInvList, "mg_ShowItem")
    End Sub

    Private sub Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Find.ItemClick
        If quickSearch.EditValue = String.Empty Then
            MsgBox("Please supply quicksearch value!")
        Else
            searchInventoryLocalBranch()
        End If

    End Sub

    Dim sValue As String

    private sub GViewInvList_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GViewInvList.RowCellClick
        sValue = e.CellValue.ToString
    End Sub

    private sub GCInvList_MouseDown(sender As Object, e As MouseEventArgs) Handles GCInvList.MouseDown
        If e.Button = MouseButtons.Right Then
            GridPopUp.ShowPopup(MousePosition)
        End If
    End Sub

    private sub BtnHist_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnHist.ItemClick
        IS_Inventory_Detailed_SHistory.txt_quickSearch.EditValue = sValue
        IS_Inventory_Detailed_SHistory.mg_ShowItemInvHist()
        MainMenu.IsMdiContainer = True
        IS_Inventory_Detailed_SHistory.MdiParent = MainMenu
        IS_Inventory_Detailed_SHistory.Show()
        IS_Inventory_Detailed_SHistory.Focus()
    End Sub

    private sub Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Preview.ItemClick
        Dim report As New Blank_rpt()
        GViewInvList.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GCInvList
        report.txt_Company.Text = "SAGA Motors Corporation"
        report.txt_title.Text = "Inventory List - " & quickSearch.EditValue.ToString()
        report.PaperKind = Printing.PaperKind.Legal
        report.Landscape = True

        report.ShowPreview
    End Sub
End Class