Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class maint_itemgrp

    Private Sub maint_itemgrp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         LoadBrand()
    End Sub

    Sub LoadBrand()
        LViewItemsBrand.Items.Clear()
        mySQLConnection.Open()

        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_itemgrp", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        Do While rs.Read()
            Dim li As ListViewItem = LViewItemsBrand.Items.Add(rs.Item("id").ToString())
            li.SubItems.Add(rs.Item("grpdesc").ToString())
        Loop
        rs.Close()
        mySQLConnection.Close()
    End Sub

    Private Sub LViewItemsBrand_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewItemsBrand.Click
        BrandTextBox.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(1).Text
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
         Save_Brand1()
         LoadBrand()
    End Sub

    Sub Save_Brand()
        mySQLConnection.Open()
        Dim cmd As New SqlCommand
        Dim i As Integer
        With cmd
            .Connection = mySQLConnection
            .CommandText = "INSERT into maint_itemgrp(grpdesc) " _
                                  & "VALUES('" & BrandTextBox.Text & "')"
            i = .ExecuteNonQuery
        End With

        MsgBox("Items Saved", vbInformation, "webSources")
        BrandTextBox.Text = String.Empty
        BrandTextBox.Focus()
        mySQLConnection.Close()
    End Sub

    Sub Save_Brand1()
        mySQLConnection.Open()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_itemgrp where grpdesc LIKE '" & BrandTextBox.Text & "' ", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        'Dim i As Integer
        If rs.Read = True Then
            MsgBox("Group Name is already exist!", vbCritical, "webSources")
            rs.Close()
            mySQLConnection.Close()
            'GoTo out
        Else
            mySQLConnection.Close()
             Save_Brand()
        End If
        'out:    mySQLConnection.close
    End Sub

    Private Sub Dellete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dellete.Click
        Dim ask As MsgBoxResult

        mySQLConnection.Open()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_itemgrp where grpdesc LIKE '" & BrandTextBox.Text & "' ", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        'Dim i As Integer
        If rs.Read = True Then
            rs.Close()
            mySQLConnection.Close()
            ask = MsgBox("Are you sure you want to Dellete this Data", MsgBoxStyle.YesNo, String.Empty)
            If ask = MsgBoxResult.Yes Then
                 del_item_Brand()
                 LoadBrand()
            End If
            'GoTo out
        Else
            rs.Close()
            mySQLConnection.Close()
            MsgBox("Group Name is not exist!", vbCritical, "webSources")
        End If

    End Sub

    Sub del_item_Brand()
        mySQLConnection.Open()
        Dim cmd As New SqlCommand
        Dim i As Integer
        With cmd
            .Connection = mySQLConnection
            .CommandText = " DELETE from maint_itemgrp where grpdesc LIKE '" & BrandTextBox.Text & "'"
            i = .ExecuteNonQuery
        End With
        'If i > 0 Then
        'MsgBox("Items Dellete", vbInformation, "webSources")
        'End If
        mySQLConnection.Close()
        BrandTextBox.Text = String.Empty
        BrandTextBox.Focus()

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

End Class