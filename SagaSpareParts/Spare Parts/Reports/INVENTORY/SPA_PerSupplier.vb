Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_PerSupplier
    Sub Search_AllBranches_Inventory()
        Dim Parameters As SqlParameter() = {}

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_Show_AllBranch_Inventory")
    End Sub

    Sub SPA_Reports_PerSupplier()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamCategory", cmb_Category.EditValue),
            New SqlParameter("@ParamDateBegin", dtp_dBegin.EditValue),
            New SqlParameter("@ParamDateEnd", dtp_dEnd.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_Reports_PerSupplier")
    End Sub
    Private Sub SPA_InventoryAging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp_dBegin.EditValue = Now
        dtp_dEnd.EditValue = Now
    End Sub

    Private Sub btn_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Find.ItemClick
        SPA_Reports_PerSupplier()
    End Sub

End Class