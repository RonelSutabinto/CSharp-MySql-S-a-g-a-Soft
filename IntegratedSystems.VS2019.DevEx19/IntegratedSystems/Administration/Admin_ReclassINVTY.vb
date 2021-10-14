﻿Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_ReclassINVTY
    private sub Admin_ReclassINVTY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showWh()
        showMaintModel()
        showMaintColor()
        showMaintBrand()
    End Sub

    private sub CreateDescription()
        txt_descrip.Text = txt_model.Text & " - " & txt_color.Text
    End Sub

    private sub showWh()
        txt_whcode.Items.Clear()

        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowWhCode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_whcode.Items.Add(myDataReader.Item("whcategorycode").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub showWhDescriprtion()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamWHCode", txt_whcode.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowWhDescription")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_whdesc.Text = myDataReader("whcategorydesc").ToString()
            End If
        End Using
    End Sub

    private sub showMaintModel()
        txt_model.Items.Clear()

        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowMaintModel")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_model.Items.Add(myDataReader.Item("modeldesc").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub showMaintModelCode()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamModelDesc", txt_model.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowMaintModelCode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_code.Text = myDataReader("id").ToString()
            End If
        End Using
    End Sub

    private sub showMaintColor()
        txt_color.Items.Clear()

        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowItemColor")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_color.Items.Add(myDataReader.Item("colordesc").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub showMaintBrand()
        txt_brand.Items.Clear()

        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowBrand")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_brand.Items.Add(myDataReader.Item("branddesc").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub mg_ShowInventoryDetails()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamID", txt_id.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowInventoryDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_code.Text = myDataReader("code").ToString()
                txt_BranchCode.Text = myDataReader("branchcode").ToString()
                txt_BranchName.Text = myDataReader("vendor").ToString()
                txt_InventoryStatus.Text = myDataReader("inventorystatus").ToString()
                receivedDate.Value = myDataReader("datereceived").ToString()
                txt_itemgroup.Text = myDataReader("item_grp").ToString()
                txt_model.Text = myDataReader("model").ToString()
                txt_color.Text = myDataReader("color").ToString()
                txt_brand.Text = myDataReader("brand").ToString()
                txt_descrip.Text = myDataReader("description").ToString()
                txt_keynumber.Text = myDataReader("keyno").ToString()
                txt_EngineNo.Text = myDataReader("EngineNo").ToString()
                txt_ChassisNo.Text = myDataReader("ChassisNo").ToString()
                txt_IfExist.Text = myDataReader("IfExist").ToString()
                txt_CustName.Text = myDataReader("note").ToString()
                txt_Remarks.Text = myDataReader("remarks").ToString()
                txt_code.Text = myDataReader("code").ToString()
                txt_whdesc.Text = myDataReader("whcategory").ToString()
                txt_whcode.Text = myDataReader("whcode").ToString()
                txt_PrevID.Text = myDataReader("PrevID").ToString()
            End If
        End Using
    End Sub

    Private Sub mg_AdminReclassInventory()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@Paramid", txt_id.Text),
            New SqlParameter("@Paramvendor", txt_BranchName.Text),
            New SqlParameter("@ParamdateReceived", receivedDate.Text),
            New SqlParameter("@Paramwhcategory", txt_whdesc.Text),
            New SqlParameter("@ParamwhCode", txt_whcode.Text),
            New SqlParameter("@ParaminventoryStatus", txt_InventoryStatus.Text),
            New SqlParameter("@ParamIfExist", txt_IfExist.Text),
            New SqlParameter("@ParamCode", txt_code.Text),
            New SqlParameter("@Parammodel", txt_model.Text),
            New SqlParameter("@Paramcolor", txt_color.Text),
            New SqlParameter("@Paramdescription", txt_descrip.Text),
            New SqlParameter("@Parambrand", txt_brand.Text),
            New SqlParameter("@ParamEngineNo", txt_EngineNo.Text),
            New SqlParameter("@ParamChassisNo", txt_ChassisNo.Text),
            New SqlParameter("@Paramkeyno", txt_keynumber.Text),
            New SqlParameter("@Paramtransactedby", class_Variables.sUserName),
            New SqlParameter("@Paramtransactiondate", receivedDate.Text),
            New SqlParameter("@Parambranchcode", txt_BranchCode.Text),
            New SqlParameter("@Paramitem_grp", txt_itemgroup.Text),
            New SqlParameter("@ParamRemarks", txt_Remarks.Text),
            New SqlParameter("@ParamPrevID", txt_PrevID.Text),
            New SqlParameter("@ParamSourceEvent", "Admin_ReclassINVTY"),
            New SqlParameter("@Paramnote", txt_CustName.Text),
            New SqlParameter("@ParasBranchCodeAccount", String.Empty),
            New SqlParameter("@ParamAccountNumber", String.Empty),
            New SqlParameter("@ParamLedgerSetNumber", String.Empty),
            New SqlParameter("@ParamSpecNotes", String.Empty),
            New SqlParameter("@ParamDetailedRemarks", String.Empty)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_AdminReclassInventory", "Inventory Reclassification", txt_EngineNo.Text)
    End Sub

    Private Sub txt_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_id.TextChanged
        mg_ShowInventoryDetails()
    End Sub

    Private Sub txt_whcode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_whcode.TextChanged
        showWhDescriprtion()
    End Sub

    Private Sub txt_model_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_model.TextChanged
        showMaintModelCode()
        CreateDescription()
    End Sub

    Private Sub txt_color_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_color.TextChanged
        CreateDescription()
    End Sub

    Private Sub toolUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolUPDATE.Click
        mg_AdminReclassInventory()
    End Sub

    Private Sub toolFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolFindItem.Click
        IS_Inventory_Outgoing_item_find.Text = "InvtyReclass"
        IS_Inventory_Outgoing_item_find.ShowDialog()
    End Sub

    Private Sub toolnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolnew.Click
        txt_id.Text = String.Empty
        txt_code.Text = String.Empty
        txt_BranchCode.Text = String.Empty
        txt_BranchName.Text = String.Empty
        txt_InventoryStatus.Text = String.Empty
        receivedDate.Value = Now
        txt_itemgroup.Text = String.Empty
        txt_model.Text = String.Empty
        txt_color.Text = String.Empty
        txt_brand.Text = String.Empty
        txt_descrip.Text = String.Empty
        txt_keynumber.Text = String.Empty
        txt_EngineNo.Text = String.Empty
        txt_ChassisNo.Text = String.Empty
        txt_IfExist.Text = String.Empty
        txt_CustName.Text = String.Empty
        txt_Remarks.Text = String.Empty
        txt_code.Text = String.Empty
        txt_whdesc.Text = String.Empty
        txt_whcode.Text = String.Empty
    End Sub
End Class