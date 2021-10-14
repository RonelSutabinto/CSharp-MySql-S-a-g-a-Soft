Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_BranchParameter

    Private Sub Admin_BranchParameter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         ShowBranchParameters()
    End Sub

    Sub ShowBranchParameters()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        lvBranchParam.Items.Clear()

        cmd.CommandText = "mg_ShowBranchParameters"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        'cmd.Parameters.AddWithValue("@ParamIsCommand", Me.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        Do While rs.Read()
            Dim li As ListViewItem = lvBranchParam.Items.Add(rs.Item("BranchCode").ToString())
            li.SubItems.Add(rs.Item("Pre_Code").ToString())
            li.SubItems.Add(rs.Item("Branch").ToString())
            li.SubItems.Add(rs.Item("Address").ToString())
            li.SubItems.Add(rs.Item("BM").ToString())
            li.SubItems.Add(rs.Item("DatabaseDate").ToString())
            li.SubItems.Add(rs.Item("Zipcode").ToString())
            li.SubItems.Add(rs.Item("LTO_Payable").ToString())
            li.SubItems.Add(rs.Item("Insurance").ToString())
            li.SubItems.Add(rs.Item("Notarial_Fee").ToString())
            li.SubItems.Add(rs.Item("Notes").ToString())
        Loop

out:

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Private Sub lvBranchParam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvBranchParam.SelectedIndexChanged

    End Sub

    Private Sub lvBranchParam_DoubleClick(sender As Object, e As EventArgs) Handles lvBranchParam.DoubleClick
        txt_BranchCode.Text = lvBranchParam.SelectedItems.Item(0).SubItems(0).Text()
        txt_PreCode.Text = lvBranchParam.SelectedItems.Item(0).SubItems(1).Text()
        txt_BranchName.Text = lvBranchParam.SelectedItems.Item(0).SubItems(2).Text()
        txt_Address.Text = lvBranchParam.SelectedItems.Item(0).SubItems(3).Text()
        txt_BM.Text = lvBranchParam.SelectedItems.Item(0).SubItems(4).Text()
        txt_DatabaseDate.Value = lvBranchParam.SelectedItems.Item(0).SubItems(5).Text()
        txt_ZipCode.Text = lvBranchParam.SelectedItems.Item(0).SubItems(6).Text()
        txt_LTOPayable.Text = lvBranchParam.SelectedItems.Item(0).SubItems(7).Text()
        txt_Insurance.Text = lvBranchParam.SelectedItems.Item(0).SubItems(8).Text()
        txt_NotarialFee.Text = lvBranchParam.SelectedItems.Item(0).SubItems(9).Text()
        txt_Notes.Text = lvBranchParam.SelectedItems.Item(0).SubItems(10).Text()
    End Sub

    Private Sub toolregister_Click(sender As Object, e As EventArgs) Handles toolregister.Click
         mg_ShowBranchParametersRegister()
         ShowBranchParameters()
    End Sub

    Sub ModifyBranchParam()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowBranchParametersModify"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_BranchCode.Text)
        cmd.Parameters.AddWithValue("@ParamBranch", txt_BranchName.Text)
        cmd.Parameters.AddWithValue("@ParamBM", txt_BM.Text)
        cmd.Parameters.AddWithValue("@ParamDatabaseDate", txt_DatabaseDate.Text)
        cmd.Parameters.AddWithValue("@ParamZipCode", txt_ZipCode.Text)
        cmd.Parameters.AddWithValue("@ParamLTOPayable", txt_LTOPayable.Text)
        cmd.Parameters.AddWithValue("@ParamInsurance", txt_Insurance.Text)
        cmd.Parameters.AddWithValue("@ParamNotarialFee", txt_NotarialFee.Text)
        cmd.Parameters.AddWithValue("@ParamNotes", txt_Notes.Text)
        cmd.Parameters.AddWithValue("@ParamAddress", txt_Address.Text)
        cmd.Parameters.AddWithValue("@ParamPreCode", txt_PreCode.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Sub mg_ShowBranchParametersDelete()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowBranchParametersDelete"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_BranchCode.Text)
        cmd.Parameters.AddWithValue("@ParamBranch", txt_BranchName.Text)
        cmd.Parameters.AddWithValue("@ParamBM", txt_BM.Text)
        cmd.Parameters.AddWithValue("@ParamDatabaseDate", txt_DatabaseDate.Text)
        cmd.Parameters.AddWithValue("@ParamZipCode", txt_ZipCode.Text)
        cmd.Parameters.AddWithValue("@ParamLTOPayable", txt_LTOPayable.Text)
        cmd.Parameters.AddWithValue("@ParamInsurance", txt_Insurance.Text)
        cmd.Parameters.AddWithValue("@ParamNotarialFee", txt_NotarialFee.Text)
        cmd.Parameters.AddWithValue("@ParamNotes", txt_Notes.Text)
        cmd.Parameters.AddWithValue("@ParamAddress", txt_Address.Text)
        cmd.Parameters.AddWithValue("@ParamPreCode", txt_PreCode.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Sub mg_ShowBranchParametersRegister()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowBranchParametersRegister"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", txt_BranchCode.Text)
        cmd.Parameters.AddWithValue("@ParamBranch", txt_BranchName.Text)
        cmd.Parameters.AddWithValue("@ParamBM", txt_BM.Text)
        cmd.Parameters.AddWithValue("@ParamDatabaseDate", txt_DatabaseDate.Text)
        cmd.Parameters.AddWithValue("@ParamZipCode", txt_ZipCode.Text)
        cmd.Parameters.AddWithValue("@ParamLTOPayable", txt_LTOPayable.Text)
        cmd.Parameters.AddWithValue("@ParamInsurance", txt_Insurance.Text)
        cmd.Parameters.AddWithValue("@ParamNotarialFee", txt_NotarialFee.Text)
        cmd.Parameters.AddWithValue("@ParamNotes", txt_Notes.Text)
        cmd.Parameters.AddWithValue("@ParamAddress", txt_Address.Text)
        cmd.Parameters.AddWithValue("@ParamPreCode", txt_PreCode.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)

outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
    End Sub

    Private Sub toolmodify_Click(sender As Object, e As EventArgs) Handles toolmodify.Click
         ModifyBranchParam()
         ShowBranchParameters()
    End Sub

    Private Sub toolDelete_Click(sender As Object, e As EventArgs) Handles toolDelete.Click
         mg_ShowBranchParametersDelete()
         ShowBranchParameters()
    End Sub

End Class