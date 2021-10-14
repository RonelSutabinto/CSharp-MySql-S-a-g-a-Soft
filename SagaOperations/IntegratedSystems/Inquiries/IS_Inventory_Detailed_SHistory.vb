Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_Detailed_SHistory

    Sub mg_ShowItemInvHist()
        GViewInvHist.Columns.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamQuickSearch", txt_quickSearch.EditValue)}

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCInvHistory, GViewInvHist, "mg_ShowItemInvHist")
    End Sub

    Private Sub btn_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Find.ItemClick
        mg_ShowItemInvHist()
    End Sub

End Class