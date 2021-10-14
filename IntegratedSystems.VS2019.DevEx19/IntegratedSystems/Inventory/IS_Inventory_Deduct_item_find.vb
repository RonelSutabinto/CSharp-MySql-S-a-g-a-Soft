Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_Deduct_item_find
    private sub IS_Inventory_Deduct_item_find_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        searchInventory()
    End Sub

    private sub searchInventory()
        LViewItems4Deduct.Items.Clear()

        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_details WHERE branchcode LIKE '" & class_saga_variables.sbranchcode & "' AND IfExist = '1'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItems4Deduct.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("model").ToString())
                    li.SubItems.Add(myDataReader.Item("description").ToString())
                    li.SubItems.Add(myDataReader.Item("color").ToString())
                    li.SubItems.Add(myDataReader.Item("brand").ToString())
                    li.SubItems.Add(myDataReader.Item("ChassisNo").ToString())
                    li.SubItems.Add(myDataReader.Item("EngineNo").ToString())
                    li.SubItems.Add(myDataReader.Item("unitcost").ToString())
                    li.SubItems.Add(myDataReader.Item("vatamt").ToString())
                    li.SubItems.Add(myDataReader.Item("totalcost").ToString())
                    li.SubItems.Add(myDataReader.Item("unitprice").ToString())
                    li.SubItems.Add(myDataReader.Item("keyno").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub quickSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quickSearch.TextChanged
        QuicksearchInventory()
    End Sub

    private sub QuicksearchInventory()
        LViewItems4Deduct.Items.Clear()

        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_details WHERE branchcode LIKE '" & class_saga_variables.sbranchcode & "' AND IfExist = '1' AND (ChassisNo LIKE '%" & quickSearch.Text & "%' or EngineNo LIKE '%" & quickSearch.Text & "%')")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItems4Deduct.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("model").ToString())
                    li.SubItems.Add(myDataReader.Item("description").ToString())
                    li.SubItems.Add(myDataReader.Item("color").ToString())
                    li.SubItems.Add(myDataReader.Item("brand").ToString())
                    li.SubItems.Add(myDataReader.Item("ChassisNo").ToString())
                    li.SubItems.Add(myDataReader.Item("EngineNo").ToString())
                    li.SubItems.Add(myDataReader.Item("unitcost").ToString())
                    li.SubItems.Add(myDataReader.Item("vatamt").ToString())
                    li.SubItems.Add(myDataReader.Item("totalcost").ToString())
                    li.SubItems.Add(myDataReader.Item("unitprice").ToString())
                    li.SubItems.Add(myDataReader.Item("keyno").ToString())
                Loop
            End If
        End Using
    End Sub

End Class