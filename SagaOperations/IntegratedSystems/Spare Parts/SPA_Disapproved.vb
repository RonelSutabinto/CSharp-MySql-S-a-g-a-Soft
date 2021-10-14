Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Disapproved

    Sub SPA_Show_Disapproved_Inventory()
        lvDisapproved.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamApprover", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Show_Disapproved_Inventory")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lvDisapproved.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(myDataReader.Item("InventoryStatus").ToString())
                    li.SubItems.Add(myDataReader.Item("SourceEvent").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub Show_SPA_Inventory_Receiving()
        SPA_Receiving.lvParts.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@Paramrefno", txt_Refno.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_RefNo")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = SPA_Receiving.lvParts.Items.Add(myDataReader.Item("PartsNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsName").ToString())
                    li.SubItems.Add(myDataReader.Item("Brand").ToString())
                    li.SubItems.Add(myDataReader.Item("SC_SpareParts").ToString())
                    li.SubItems.Add(myDataReader.Item("SRP").ToString())
                    li.SubItems.Add(myDataReader.Item("Quantity").ToString())
                    li.SubItems.Add(myDataReader.Item("SPCostWVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("SPCostWOVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("DiscountPCT").ToString())
                    li.SubItems.Add(myDataReader.Item("DiscountAMT").ToString())
                    li.SubItems.Add(myDataReader.Item("PriceWVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("priceWOVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("ModelCode").ToString())
                    li.SubItems.Add(myDataReader.Item("ModelName").ToString())
                    li.SubItems.Add(myDataReader.Item("subTotal").ToString())
                    li.SubItems.Add(myDataReader.Item("Category").ToString())
                    li.SubItems.Add(myDataReader.Item("BinBox").ToString())
                Loop

                SPA_Receiving.txt_Vendor.Text = myDataReader("Vendor").ToString()
                SPA_Receiving.txt_RefNo.Text = myDataReader("Refno").ToString()
                SPA_Receiving.txt_POno.Text = myDataReader("PONo").ToString()
                SPA_Receiving.cmb_WhCategory.Text = myDataReader("whCategory").ToString()
                SPA_Receiving.txt_WhCode.Text = myDataReader("whCode").ToString()
                SPA_Receiving.txt_Note.Text = myDataReader("Note").ToString()
                SPA_Receiving.txt_Status.Text = myDataReader("InventoryStatus").ToString()
                SPA_Receiving.txt_Checker.Text = myDataReader("Checker").ToString()
                SPA_Receiving.txt_Approver.Text = myDataReader("Approver").ToString()
                SPA_Receiving.txt_Remarks.Text = myDataReader("Remarks").ToString()
            End If
        End Using
    End Sub

    Sub Show_SPA_Inventory_Outgoing()
        SPA_Outgoing.lvParts.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@Paramrefno", txt_Refno.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_RefNo")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = SPA_Outgoing.lvParts.Items.Add(myDataReader.Item("PartsNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsName").ToString())
                    li.SubItems.Add(myDataReader.Item("Brand").ToString())
                    li.SubItems.Add(myDataReader.Item("SC_SpareParts").ToString())
                    li.SubItems.Add(myDataReader.Item("SRP").ToString())
                    li.SubItems.Add(myDataReader.Item("Quantity").ToString())
                    li.SubItems.Add(myDataReader.Item("SPCostWOVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("SPCostWVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("DiscountPCT").ToString())
                    li.SubItems.Add(myDataReader.Item("DiscountAMT").ToString())
                    li.SubItems.Add(myDataReader.Item("PriceWVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("priceWOVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("ModelCode").ToString())
                    li.SubItems.Add(myDataReader.Item("ModelName").ToString())
                    li.SubItems.Add(myDataReader.Item("branchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("TransactedBy").ToString())
                    li.SubItems.Add(myDataReader.Item("prev_ID").ToString())
                    li.SubItems.Add(myDataReader.Item("SubTotal").ToString())
                    li.SubItems.Add(myDataReader.Item("Category").ToString())
                    li.SubItems.Add(myDataReader.Item("BinBox").ToString())
                Loop
                SPA_Outgoing.txt_RBranch.Text = myDataReader("Vendor").ToString()
                SPA_Outgoing.txt_BrCode.Text = myDataReader("ReceivingBranch").ToString()
                SPA_Outgoing.txt_RefNo.Text = myDataReader("Refno").ToString()
                SPA_Outgoing.txt_PONo.Text = myDataReader("PONo").ToString()
                SPA_Outgoing.cmb_WHCategory.Text = myDataReader("whCategory").ToString()
                SPA_Outgoing.txt_WHCode.Text = myDataReader("whCode").ToString()
                SPA_Outgoing.txt_Note.Text = myDataReader("Note").ToString()
                SPA_Outgoing.txt_Status.Text = myDataReader("InventoryStatus").ToString()
                SPA_Outgoing.cmb_Partsman.Text = myDataReader("Checker").ToString()
                SPA_Outgoing.txt_Approver.Text = myDataReader("Approver").ToString()
                SPA_Outgoing.txt_Remarks.Text = myDataReader("Remarks").ToString()
            End If
        End Using
    End Sub

    Private Sub lvDisapproved_DoubleClick(sender As Object, e As EventArgs) Handles lvDisapproved.DoubleClick
        If txt_Source.Text = "RECEIVING" Then
            txt_Refno.Text = lvDisapproved.SelectedItems.Item(0).SubItems(0).Text()
            SPA_Show_Disapproved_Inventory()
            lvDisapproved.Items.Clear()
            Show_SPA_Inventory_Receiving()
            SPA_Receiving.TotalParts()
            Me.Close()
            SPA_Receiving.ShowDialog()
        Else
            txt_Refno.Text = lvDisapproved.SelectedItems.Item(0).SubItems(0).Text()
            SPA_Show_Disapproved_Inventory()
            lvDisapproved.Items.Clear()
            Show_SPA_Inventory_Outgoing()
            SPA_Outgoing.TotalParts()
            Me.Close()
            SPA_Outgoing.ShowDialog()
        End If

    End Sub

    Private Sub SPA_Disapproved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPA_Show_Disapproved_Inventory()
    End Sub

    Private Sub lvDisapproved_Click(sender As Object, e As EventArgs) Handles lvDisapproved.Click
        txt_Source.Text = lvDisapproved.SelectedItems.Item(0).SubItems(4).Text()
        SPA_Outgoing.txt_Status.Text = lvDisapproved.SelectedItems.Item(0).SubItems(3).Text()
    End Sub
End Class