Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class maint_modelfrm

    Private Sub maint_brandfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         mg_ShowMaintModel()

    End Sub

    Sub mg_ShowMaintModel()
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        LViewItemsBrand.Items.Clear()
        cmd.CommandText = "mg_ShowMaintModel"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.CommandTimeout = 100

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()

        Do While rs.Read

            Dim li As ListViewItem = LViewItemsBrand.Items.Add(rs.Item("id").ToString())
            li.SubItems.Add(rs.Item("modeldesc").ToString())
            li.SubItems.Add(rs.Item("itemgrp").ToString())
            li.SubItems.Add(rs.Item("branddesc").ToString())

        Loop

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:
    End Sub

    Sub Loadmodel()
        ' LViewItemsBrand.Items.Clear()
        mySQLConnection.Open()

        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_model order by modeldesc", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        Do While rs.Read()
            Dim li As ListViewItem = LViewItemsBrand.Items.Add(rs.Item("id").ToString())
            li.SubItems.Add(rs.Item("modeldesc").ToString())
            li.SubItems.Add(rs.Item("itemgrp").ToString())
            li.SubItems.Add(rs.Item("branddesc").ToString())
        Loop
        rs.Close()
        mySQLConnection.Close()
    End Sub

    'Sub LoadGroup()
    '    mySQLConnection.open
    '    Group_cmb.Text = ""
    '    Group_cmb.Items.Clear()
    '    Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_itemgrp", mySQLConnection)
    '    Dim rs As SqlDataReader = select_cmd.ExecuteReader()
    '    Do While rs.Read()
    '        Group_cmb.Items.Add(rs.Item("grpdesc").ToString())
    '    Loop
    '    rs.Close()
    '    mySQLConnection.close
    'End Sub
    'Sub Loadbrand()
    '    mySQLConnection.open
    '    Brand_cmb.Text = ""
    '    Brand_cmb.Items.Clear()
    '    Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_brand", mySQLConnection)
    '    Dim rs As SqlDataReader = select_cmd.ExecuteReader()
    '    Do While rs.Read()
    '        Brand_cmb.Items.Add(rs.Item("branddesc").ToString())
    '    Loop
    '    rs.Close()
    '    mySQLConnection.close
    'End Sub

    Private Sub LViewItemsBrand_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewItemsBrand.Click

        txt_ID.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(0).Text()
        model_txtbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(1).Text
        Group_cmb.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(2).Text
        Brand_cmb.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(3).Text

    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        ' LViewItemsBrand.Items.Clear()
        cmd.CommandText = "mg_AdminRegisterModel"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.CommandTimeout = 100
        cmd.Parameters.AddWithValue("@ParamID", txt_ID.Text)
        cmd.Parameters.AddWithValue("@ParamBrand", Brand_cmb.Text)
        cmd.Parameters.AddWithValue("@ParamModelDesc", model_txtbx.Text)
        cmd.Parameters.AddWithValue("@Paramitemgrp", Group_cmb.Text)
        cmd.Parameters.AddWithValue("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamUpdatedBy", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamCOD", COD.Text)
        cmd.Parameters.AddWithValue("@ParamLCP", LCP.Text)
        cmd.Parameters.AddWithValue("@ParamAOC", AOC.Text)
        cmd.Parameters.AddWithValue("@ParamRebates", Rebates.Text)
        cmd.Parameters.AddWithValue("@ParamDP", DP.Text)
        cmd.Parameters.AddWithValue("@ParamNote", Notes.Text)
        cmd.Parameters.AddWithValue("@ParamEvent", Save.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()

        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:
outs1:   mg_ShowMaintModel()

    End Sub

    Sub Save_Data()
        mySQLConnection.Open()
        Dim cmd As New SqlCommand
        Dim i As Integer
        With cmd
            .Connection = mySQLConnection
            .CommandText = "INSERT into maint_model(modeldesc,itemgrp,branddesc) " _
                                  & "VALUES('" & model_txtbx.Text & "','" & Group_cmb.Text & "','" & Brand_cmb.Text & "')"
            i = .ExecuteNonQuery
        End With

        MsgBox("Items Saved", vbInformation, "webSources")
        mySQLConnection.Close()
    End Sub

    Sub Save_Item()
        mySQLConnection.Open()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_model where branddesc LIKE '" & model_txtbx.Text & "' ", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        If rs.Read = True Then
            MsgBox("Model Name is already exist!", vbCritical, "webSources")
            rs.Close()
            mySQLConnection.Close()
        Else
            mySQLConnection.Close()
             Save_Data()
        End If

    End Sub

    Private Sub Dellete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dellete.Click
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        ' LViewItemsBrand.Items.Clear()
        cmd.CommandText = "mg_AdminRegisterModel"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.CommandTimeout = 100
        cmd.Parameters.AddWithValue("@ParamID", txt_ID.Text)
        cmd.Parameters.AddWithValue("@ParamBrand", Brand_cmb.Text)
        cmd.Parameters.AddWithValue("@ParamModelDesc", model_txtbx.Text)
        cmd.Parameters.AddWithValue("@Paramitemgrp", Group_cmb.Text)
        cmd.Parameters.AddWithValue("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamUpdatedBy", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamCOD", COD.Text)
        cmd.Parameters.AddWithValue("@ParamLCP", LCP.Text)
        cmd.Parameters.AddWithValue("@ParamAOC", AOC.Text)
        cmd.Parameters.AddWithValue("@ParamRebates", Rebates.Text)
        cmd.Parameters.AddWithValue("@ParamDP", DP.Text)
        cmd.Parameters.AddWithValue("@ParamNote", Notes.Text)
        cmd.Parameters.AddWithValue("@ParamEvent", Dellete.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()

        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:   mg_ShowMaintModel()
    End Sub

    Sub del_item_model()
        mySQLConnection.Open()
        Dim cmd As New SqlCommand
        Dim i As Integer
        With cmd
            .Connection = mySQLConnection
            .CommandText = " DELETE from maint_model where modeldesc LIKE '" & model_txtbx.Text & "'"
            i = .ExecuteNonQuery
        End With
        mySQLConnection.Close()
         clear_item()

    End Sub

    Private Sub newbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newbtn.Click
         clear_item()
    End Sub

    Sub clear_item()
        model_txtbx.Text = String.Empty
        Group_cmb.Text = String.Empty
        Brand_cmb.Text = String.Empty
        model_txtbx.Focus()
    End Sub

    Sub mg_ShowMaintModelperID()
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowModelID"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.CommandTimeout = 100
        cmd.Parameters.AddWithValue("@ParamID", txt_ID.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()

        If rs.Read Then
            dateCreated.Value = rs.Item("DateCreated").ToString()
            dateUpdated.Value = rs.Item("DateUpdated").ToString()
            DP.Text = rs.Item("DownPayment").ToString()
            AOC.Text = rs.Item("aoc").ToString()
            COD.Text = rs.Item("COD").ToString()
            LCP.Text = rs.Item("lcp").ToString()
            Rebates.Text = rs.Item("Rebates").ToString()
            Notes.Text = rs.Item("notes").ToString()
        End If
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:  If DP.Text = String.Empty Then
            DP.Text = "0.00"
        End If
        If AOC.Text = String.Empty Then
            AOC.Text = "0.00"
        End If
        If COD.Text = String.Empty Then
            COD.Text = "0.00"
        End If
        If LCP.Text = String.Empty Then
            LCP.Text = "0.00"
        End If
        If Rebates.Text = String.Empty Then
            Rebates.Text = "0.00"
        End If
    End Sub

    Private Sub txt_ID_TextChanged(sender As Object, e As EventArgs) Handles txt_ID.TextChanged
        mg_ShowMaintModelperID()
    End Sub

    Private Sub ModifyBtn_Click(sender As Object, e As EventArgs) Handles ModifyBtn.Click
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        ' LViewItemsBrand.Items.Clear()
        cmd.CommandText = "mg_AdminRegisterModel"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.CommandTimeout = 100
        cmd.Parameters.AddWithValue("@ParamID", txt_ID.Text)
        cmd.Parameters.AddWithValue("@ParamBrand", Brand_cmb.Text)
        cmd.Parameters.AddWithValue("@ParamModelDesc", model_txtbx.Text)
        cmd.Parameters.AddWithValue("@Paramitemgrp", Group_cmb.Text)
        cmd.Parameters.AddWithValue("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamUpdatedBy", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamCOD", COD.Text)
        cmd.Parameters.AddWithValue("@ParamLCP", LCP.Text)
        cmd.Parameters.AddWithValue("@ParamAOC", AOC.Text)
        cmd.Parameters.AddWithValue("@ParamRebates", Rebates.Text)
        cmd.Parameters.AddWithValue("@ParamDP", DP.Text)
        cmd.Parameters.AddWithValue("@ParamNote", Notes.Text)
        cmd.Parameters.AddWithValue("@ParamEvent", ModifyBtn.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()

        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:
outs1:   mg_ShowMaintModel()
    End Sub

    Private Sub txt_Event_TextChanged(sender As Object, e As EventArgs)
        ' mg_AdminRegisterModel()
    End Sub

End Class