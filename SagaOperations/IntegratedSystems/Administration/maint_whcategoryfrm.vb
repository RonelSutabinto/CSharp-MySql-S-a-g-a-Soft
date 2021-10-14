Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class maint_whcategoryfrm

    Sub Loadcategory()
        LViewItemsBrand.Items.Clear()
        mySQLConnection.Open()

        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_whcategory", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        Do While rs.Read()
            Dim li As ListViewItem = LViewItemsBrand.Items.Add(rs.Item("id").ToString())
            li.SubItems.Add(rs.Item("whcategorydesc").ToString())
            li.SubItems.Add(rs.Item("whcategorycode").ToString())

        Loop
        rs.Close()
        mySQLConnection.Close()
    End Sub

    Sub Save_Data()
        mySQLConnection.Open()
        Dim cmd As New SqlCommand
        Dim i As Integer
        With cmd
            .Connection = mySQLConnection
            .CommandText = "INSERT into maint_whcategory(whcategorycode,whcategorydesc) " _
                                  & "VALUES('" & ctcodetxbx.Text & "','" & category_txbx.Text & "')"
            i = .ExecuteNonQuery
        End With

        MsgBox("Items Saved", vbInformation, "webSources")
         clear_item()
        mySQLConnection.Close()
         Loadcategory()
    End Sub

    Sub Save_Item()
        mySQLConnection.Open()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_whcategory where whcategorydesc LIKE '" & category_txbx.Text & "' ", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        If rs.Read = True Then
            MsgBox("Category Name is already exist!", vbCritical, "webSources")
            rs.Close()
            mySQLConnection.Close()
        Else
            mySQLConnection.Close()
             Save_Data()
        End If

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub maint_whcategoryfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         Loadcategory()
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        If category_txbx.Text = String.Empty Then
            MsgBox("Category Name is Empty!", vbInformation, String.Empty)
        Else
            If ctcodetxbx.Text = String.Empty Then
                MsgBox("Category Code is Empty!", vbInformation, String.Empty)
            Else
                 Save_Item()
            End If
        End If
        category_txbx.Focus()
    End Sub

    Private Sub LViewItemsBrand_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewItemsBrand.Click
        category_txbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(1).Text
        ctcodetxbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(2).Text

    End Sub

    Private Sub Dellete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dellete.Click
        Dim ask As MsgBoxResult

        mySQLConnection.Open()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_whcategory where whcategorydesc LIKE '" & category_txbx.Text & "' ", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        'Dim i As Integer
        If rs.Read = True Then
            rs.Close()
            mySQLConnection.Close()
            ask = MsgBox("Are you sure you want to Dellete this Data", MsgBoxStyle.YesNo, String.Empty)
            If ask = MsgBoxResult.Yes Then
                 del_item()
                 Loadcategory()
                 clear_item()
            End If
            'GoTo out
        Else
            rs.Close()
            mySQLConnection.Close()
            MsgBox("Category Name is not exist!", vbCritical, "webSources")
        End If

    End Sub

    Sub del_item()
        mySQLConnection.Open()
        Dim cmd As New SqlCommand
        Dim i As Integer
        With cmd
            .Connection = mySQLConnection
            .CommandText = " DELETE from maint_whcategory where whcategorydesc LIKE '" & category_txbx.Text & "'"
            i = .ExecuteNonQuery
        End With
        mySQLConnection.Close()
    End Sub

    Sub clear_item()
        category_txbx.Text = String.Empty
        ctcodetxbx.Text = String.Empty
        category_txbx.Focus()
    End Sub

    Private Sub newbbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newbbtn.Click
         clear_item()
    End Sub

End Class