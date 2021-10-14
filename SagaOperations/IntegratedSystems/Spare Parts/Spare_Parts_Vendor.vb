Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Spare_Parts_Vendor

    Sub Show_Branch()
        lv_Vendor.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", txt_Search.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_BranchParameter")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_Branch.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("Branch").ToString())
                    li.SubItems.Add(myDataReader.Item("ZipCode").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub Show_Vendor()
        lv_Vendor.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "mg_ShowVendorWithParam")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_Vendor.Items.Add(myDataReader.Item("Vendordesc").ToString())
                    li.SubItems.Add(myDataReader.Item("Address").ToString())
                    li.SubItems.Add(myDataReader.Item("contactno").ToString())
                    li.SubItems.Add(myDataReader.Item("dateregistered").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(myDataReader.Item("branchCode").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub Spare_Parts_Vendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_Vendor()
    End Sub

    Private Sub lv_Vendor_DoubleClick(sender As Object, e As EventArgs) Handles lv_Vendor.DoubleClick
        SPA_Receiving.txt_Vendor.Text = lv_Vendor.SelectedItems.Item(0).SubItems(0).Text()
        SPA_Receiving.Show()
        SPA_Receiving.txt_Vendor.Focus()
        Me.Hide()
    End Sub

    Private Sub lv_Branch_DoubleClick(sender As Object, e As EventArgs) Handles lv_Branch.DoubleClick
        SPA_Outgoing.txt_BrCode.Text = lv_Branch.SelectedItems.Item(0).SubItems(0).Text()
        SPA_Outgoing.txt_RBranch.Text = lv_Branch.SelectedItems.Item(0).SubItems(1).Text()
        SPA_Outgoing.Show()
        Me.Hide()
    End Sub
End Class