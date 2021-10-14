﻿Imports MyClassLibrary.Classes
Imports System.Data.SqlClient
Imports wSClassLib.myModules

Public Class IS_Inventory_DetailedSCategoryFindvb

    Private Sub IS_Inventory_DetailedSCategoryFindvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeData.Initialize_Brand()
        InitializeData.Initialize_Brand(txt_CategFind, RepositoryItemLookUpEdit1)
    End Sub

    Private Sub txt_CategFind_EditValueChanged(sender As Object, e As EventArgs) Handles txt_CategFind.EditValueChanged
        InitializeData.Initialize_Model(txt_CategFind.EditValue.ToString)
        InitializeData.Initialize_Model(txt_ValFind, RepositoryItemLookUpEdit2, txt_CategFind.EditValue.ToString)
    End Sub

    Private Sub btn_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Find.ItemClick
        mg_ShowInterBranchItemPerModel()
    End Sub

    Sub mg_ShowInterBranchItemPerModel()
        GViewInvList.Columns.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamModelID", txt_ValFind.EditValue)}

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCInvList, GViewInvList, "mg_ShowInterBranchItemPerModel")
    End Sub
End Class