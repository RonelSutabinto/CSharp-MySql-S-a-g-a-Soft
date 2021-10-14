Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class maint_vendorfrm

    Private Sub maint_brandfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         LoadVendor()
    End Sub

    Sub LoadVendor()
        LViewItemsBrand.Items.Clear()
        mySQLConnection.Open()

        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_vendor", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        Do While rs.Read()
            Dim li As ListViewItem = LViewItemsBrand.Items.Add(rs.Item("id").ToString())
            li.SubItems.Add(rs.Item("vendordesc").ToString())
            li.SubItems.Add(rs.Item("address").ToString())
            li.SubItems.Add(rs.Item("contactno").ToString())
            li.SubItems.Add(rs.Item("dateregistered").ToString())
            li.SubItems.Add(rs.Item("type").ToString())
            li.SubItems.Add(rs.Item("branchCode").ToString())
        Loop
        rs.Close()
        mySQLConnection.Close()
        'date_txtbx.Text = Now

    End Sub

    Private Sub LViewItemsBrand_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewItemsBrand.Click
        vendor_txtbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(1).Text
        address_txtbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(2).Text
        contact_txtbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(3).Text
        date_txtbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(4).Text
        type_txtbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(5).Text
        branch_txtbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(6).Text

    End Sub

    Sub Save_Data()
        mySQLConnection.Open()
        Dim cmd As New SqlCommand
        Dim i As Integer
        With cmd
            .Connection = mySQLConnection
            .CommandText = "INSERT into maint_vendor(vendordesc,address,contactno,dateregistered,type,branchCode) " _
                                  & "VALUES('" & vendor_txtbx.Text & "','" & address_txtbx.Text & "','" & contact_txtbx.Text & "','" & date_txtbx.Text & "','" & type_txtbx.Text & "','" & branch_txtbx.Text & "')"
            i = .ExecuteNonQuery
        End With

        MsgBox("Items Saved", vbInformation, "webSources")
        mySQLConnection.Close()
         LoadVendor()
         clear_item()
    End Sub

    Sub Save_Item()
        mySQLConnection.Open()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_vendor where vendordesc LIKE '" & vendor_txtbx.Text & "' ", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        If rs.Read = True Then
            MsgBox("Vendor Name is already exist!", vbCritical, "webSources")
            rs.Close()
            mySQLConnection.Close()
        Else
            mySQLConnection.Close()
             Save_Data()
        End If

    End Sub

    Private Sub Dellete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dellete.Click
        Dim ask As MsgBoxResult

        mySQLConnection.Open()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_vendor where vendordesc LIKE '" & vendor_txtbx.Text & "' ", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        'Dim i As Integer
        If rs.Read = True Then
            rs.Close()
            mySQLConnection.Close()
            ask = MsgBox("Are you sure you want to Dellete this Data?", MsgBoxStyle.YesNo, String.Empty)
            If ask = MsgBoxResult.Yes Then
                 del_item_vedor()
                 LoadVendor()
            End If
            'GoTo out
        Else
            rs.Close()
            mySQLConnection.Close()
            MsgBox("vendor Name is not exist!", vbCritical, "webSources")
        End If

    End Sub

    Sub del_item_vedor()
        mySQLConnection.Open()
        Dim cmd As New SqlCommand
        Dim i As Integer
        With cmd
            .Connection = mySQLConnection
            .CommandText = " DELETE from maint_vendor where vendordesc LIKE '" & vendor_txtbx.Text & "'"
            i = .ExecuteNonQuery
        End With
        mySQLConnection.Close()
         clear_item()

    End Sub

    Sub clear_item()
        vendor_txtbx.Text = String.Empty
        address_txtbx.Text = String.Empty
        contact_txtbx.Text = String.Empty
        type_txtbx.Text = String.Empty
        branch_txtbx.Text = String.Empty
        date_txtbx.Text = Now
    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub newbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newbtn.Click
         clear_item()
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click

        If vendor_txtbx.Text = String.Empty Then
            MsgBox("Vendors Name is Empty!", vbInformation, String.Empty)
        Else
            If address_txtbx.Text = String.Empty Then
                MsgBox("Address is Empty!", vbInformation, String.Empty)
            Else
                If contact_txtbx.Text = String.Empty Then
                    MsgBox("Contact No. is Empty!", vbInformation, String.Empty)
                Else
                    If type_txtbx.Text = String.Empty Then
                        MsgBox("Type is Empty!", vbInformation, String.Empty)
                    Else
                        If branch_txtbx.Text = String.Empty Then
                            MsgBox("Branch Code is Empty!", vbInformation, String.Empty)
                        Else
                             Save_Item()
                        End If
                    End If
                End If
            End If
        End If

    End Sub

End Class