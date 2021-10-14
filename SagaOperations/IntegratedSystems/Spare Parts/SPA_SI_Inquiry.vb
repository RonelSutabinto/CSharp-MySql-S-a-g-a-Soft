Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_SI_Inquiry
    Sub Search_AllBranches_Inventory()
        Dim Parameters As SqlParameter() = {}

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_Show_AllBranch_Inventory")
    End Sub

    Sub SPA_Find_RefNo_AllBranches()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamQuickSearch", txt_Search.EditValue)}

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_Find_RefNo_AllBranches")
    End Sub

    Private Sub btn_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Find.ItemClick
        SPA_Find_RefNo_AllBranches()
    End Sub

End Class