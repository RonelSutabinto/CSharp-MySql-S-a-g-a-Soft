Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_Item_Inquiry
    private sub IS_Inventory_Item_Inquiry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        searchInventory()
    End Sub

    private sub LViewEvent()
        Dim TotalCount As Double = 0

        Dim TempNode As ListViewItem

        For Each TempNode In LViewItemsOutgoing.Items
            TotalCount = TotalCount + 1
        Next
        lbl_cnt.Text = TotalCount
    End Sub

    private sub searchSales()
        LViewItemsOutgoing.Items.Clear()

        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM TransactionReleases WHERE (EngineNo LIKE '%" & quickSearch.Text & "%' or ChassisNo LIKE '%" & quickSearch.Text & "%' or description LIKE '%" & quickSearch.Text & "%' or branchcode LIKE '%" & quickSearch.Text & "%') ORDER BY TransactionDate desc, branchcode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItemsOutgoing.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("TransactionDate").ToString())
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
                    li.SubItems.Add(myDataReader.Item("inventoryStatus").ToString())
                Loop
            End If
        End Using
        LViewEvent()
    End Sub

    private sub searchInventory()
        LViewItemsOutgoing.Items.Clear()

        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM TransactionReleases WHERE branchcode LIKE '" & class_saga_variables.sbranchcode & "' ORDER BY TransactionDate desc, branchcode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItemsOutgoing.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("TransactionDate").ToString())
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
                    li.SubItems.Add(myDataReader.Item("inventoryStatus").ToString())
                Loop
            End If
        End Using
        LViewEvent()
    End Sub

    private sub LViewItemsOutgoing_DoubleClick(sender As Object, e As System.EventArgs) Handles LViewItemsOutgoing.DoubleClick
        txt_code.Text = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(1).Text()
        txt_model.Text = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(4).Text()
        txt_color.Text = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(6).Text()
        txt_descrip.Text = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(5).Text()
        txt_brand.Text = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(5).Text()
        txt_keynumber.Text = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(14).Text()
        txt_ChassisNo.Text = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(8).Text()
        txt_EngineNo.Text = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(9).Text()
        txt_uniPrice.Text = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(13).Text()
        txt_inventStatus.Text = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(15).Text()
    End Sub

    private sub quickSearch_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles quickSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            searchSales()
        End If
    End Sub
End Class