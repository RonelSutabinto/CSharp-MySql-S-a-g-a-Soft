Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_Detailed_SHistory

    Friend Sub mg_ShowItemInvHist()
        GViewInvHist.Columns.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", txt_quickSearch.EditValue)
        }
        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GCInvHistory, GViewInvHist, "mg_ShowItemInvHist")
    End Sub

    Private sub btn_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Find.ItemClick
        mg_ShowItemInvHist()
    End Sub

End Class