Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_vendor_add

    Private Sub IS_vendor_add_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        ' mySQLConnection.close
        'MsgBox(ICSConnection.State)
    End Sub

    Private Sub IS_vendor_add_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' MsgBox(ICSConnection.State)
        ' mySQLConnection.open
         searchDivision()
    End Sub

    Sub mg_ShowVendorWithParam()
        LViewVendor.Items.Clear()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader
        cmd.CommandText = "mg_ShowVendorWithParam"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        Do While rs.Read()
            Dim li As ListViewItem = LViewVendor.Items.Add(rs.Item("vendordesc").ToString())
            li.SubItems.Add(rs.Item("address").ToString())
            li.SubItems.Add(rs.Item("contactno").ToString())
            li.SubItems.Add(rs.Item("dateregistered").ToString())
            li.SubItems.Add(rs.Item("type").ToString())
            li.SubItems.Add(rs.Item("branchCode").ToString())
        Loop
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs
out:    MsgBox(Err.Description)
        class_Database.mySQLConnection.Close()
outs:
    End Sub

    Sub searchDivision()

        If eventFrom.Text = "Receiving" Then

            'Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_vendor order by branchcode asc", mySQLConnection)
            'Dim rs As SqlDataReader = select_cmd.ExecuteReader()
            'Do While rs.Read()
            '    Dim li As ListViewItem = LViewVendor.Items.Add(rs.Item("vendordesc").ToString())
            '    li.SubItems.Add(rs.Item("address").ToString())
            '    li.SubItems.Add(rs.Item("contactno").ToString())
            '    li.SubItems.Add(rs.Item("dateregistered").ToString())
            '    li.SubItems.Add(rs.Item("type").ToString())
            '    li.SubItems.Add(rs.Item("branchCode").ToString())
            'Loop
            'rs.Close()
            'mySQLConnection.close
             mg_ShowVendorWithParam()

        ElseIf eventFrom.Text = "Outgoing" Then
            mySQLConnection.Open()
            LViewVendor.Items.Clear()
            Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_vendor where type LIKE 'branch' order by branchcode asc ", mySQLConnection)
            Dim rs As SqlDataReader = select_cmd.ExecuteReader()
            Do While rs.Read()
                Dim li As ListViewItem = LViewVendor.Items.Add(rs.Item("vendordesc").ToString())
                li.SubItems.Add(rs.Item("address").ToString())
                li.SubItems.Add(rs.Item("contactno").ToString())
                li.SubItems.Add(rs.Item("dateregistered").ToString())
                li.SubItems.Add(rs.Item("type").ToString())
                li.SubItems.Add(rs.Item("branchCode").ToString())
            Loop
            rs.Close()
            mySQLConnection.Close()
        ElseIf eventFrom.Text = "Deduct" Then
            mySQLConnection.Open()
            LViewVendor.Items.Clear()
            Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_vendor where type LIKE 'branch' ", mySQLConnection)
            Dim rs As SqlDataReader = select_cmd.ExecuteReader()
            Do While rs.Read()
                Dim li As ListViewItem = LViewVendor.Items.Add(rs.Item("vendordesc").ToString())
                li.SubItems.Add(rs.Item("address").ToString())
                li.SubItems.Add(rs.Item("contactno").ToString())
                li.SubItems.Add(rs.Item("dateregistered").ToString())
                li.SubItems.Add(rs.Item("type").ToString())
                li.SubItems.Add(rs.Item("branchCode").ToString())
            Loop
            rs.Close()
            mySQLConnection.Close()
        ElseIf eventFrom.Text = "WHReclass" Then
            mySQLConnection.Open()
            LViewVendor.Items.Clear()
            Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_vendor where type LIKE 'branch' order by branchcode asc ", mySQLConnection)
            Dim rs As SqlDataReader = select_cmd.ExecuteReader()
            Do While rs.Read()
                Dim li As ListViewItem = LViewVendor.Items.Add(rs.Item("vendordesc").ToString())
                li.SubItems.Add(rs.Item("address").ToString())
                li.SubItems.Add(rs.Item("contactno").ToString())
                li.SubItems.Add(rs.Item("dateregistered").ToString())
                li.SubItems.Add(rs.Item("type").ToString())
                li.SubItems.Add(rs.Item("branchCode").ToString())
            Loop
            rs.Close()
            mySQLConnection.Close()
        End If
    End Sub

    Private Sub LViewVendor_DoubleClick(sender As Object, e As System.EventArgs) Handles LViewVendor.DoubleClick
        mySQLConnection.Close()

        If eventFrom.Text = "Receiving" Then
            IS_Inventory_Receiving.lbl_vendor.Text = LViewVendor.SelectedItems.Item(0).SubItems(0).Text

        ElseIf eventFrom.Text = "Outgoing" Then
            IS_Inventory_Outgoing.lbl_vendor.Text = LViewVendor.SelectedItems.Item(0).SubItems(0).Text
            IS_Inventory_Outgoing.lbl_vendor.EditValue = LViewVendor.SelectedItems.Item(0).SubItems(5).Text
            IS_Inventory_Outgoing.txt_refno.Text = LViewVendor.SelectedItems.Item(0).SubItems(5).Text & "-" & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
            IS_Inventory_Outgoing.txt_pono.Text = LViewVendor.SelectedItems.Item(0).SubItems(5).Text & "-" & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
        ElseIf eventFrom.Text = "Deduct" Then
            IS_Inventory_Deduct.lbl_vendor.Text = LViewVendor.SelectedItems.Item(0).SubItems(0).Text
            IS_Inventory_Deduct.lbl_vendorCode.Text = LViewVendor.SelectedItems.Item(0).SubItems(5).Text
        ElseIf eventFrom.Text = "WHReclass" Then
            'Admin_ReclassWH.lbl_vendor.Text = LViewVendor.SelectedItems.Item(0).SubItems(0).Text
            'Admin_ReclassWH.lbl_vendorCode.Text = LViewVendor.SelectedItems.Item(0).SubItems(5).Text
        End If

        Me.Close()
    End Sub

    Private Sub LViewVendor_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles LViewVendor.SelectedIndexChanged

    End Sub

End Class