Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_DetailedSummary
    Sub searchInventoryHoAllItem()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamQuickSearch", quickSearch.EditValue.ToString)}

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCInvList, GViewInvList, "mg_searchInventoryHoAllItem")
    End Sub

    Sub searchInventoryHo()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamquickSearch", quickSearch.EditValue.ToString)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCInvList, GViewInvList, "mg_ShowItem")

        IS_Inventory_List.LViewEvent()
    End Sub

    Sub searchInventoryLocalBranch()
        GViewInvList.Columns.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamquickSearch", quickSearch.EditValue),
            New SqlParameter("@ParamIfExist", IfExist.Checked)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCInvList, GViewInvList, "mg_ShowItem")
    End Sub

    Private Sub Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Find.ItemClick
        If quickSearch.EditValue = String.Empty Then
            MsgBox("Please supply quicksearch value!")
        Else
            searchInventoryLocalBranch()
        End If

    End Sub

    Dim sValue As String

    Private Sub GViewInvList_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GViewInvList.RowCellClick
        sValue = e.CellValue.ToString
    End Sub

    Private Sub GCInvList_MouseDown(sender As Object, e As MouseEventArgs) Handles GCInvList.MouseDown
        If e.Button = MouseButtons.Right Then
            GridPopUp.ShowPopup(MousePosition)
        End If
    End Sub

    Private Sub BtnHist_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnHist.ItemClick
        IS_Inventory_Detailed_SHistory.txt_quickSearch.EditValue = sValue
        IS_Inventory_Detailed_SHistory.mg_ShowItemInvHist()
        MainMenu.IsMdiContainer = True
        IS_Inventory_Detailed_SHistory.MdiParent = MainMenu
        IS_Inventory_Detailed_SHistory.Show()
        IS_Inventory_Detailed_SHistory.Focus()
    End Sub

    Private Sub Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Preview.ItemClick
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