Imports System.Data.SqlClient

Public Class Admin_ReclassWH

    Private Sub cmd_vendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Admin_ReclassWH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SPConnect2.Open()
        Call showWh()
        Call showMaintModel()
        Call showMaintColor()
        Call showMaintBrand()
    End Sub

    Sub CreateDescription()
        txt_descrip.Text = txt_model.Text & " - " & txt_color.Text
    End Sub
    Sub showWh()

        txt_whcode.Items.Clear()
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowWhCode"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnect

        SPConnect.Open()

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        Do While rs.Read()
            txt_whcode.Items.Add(rs.Item("whcategorycode").ToString())
        Loop
        rs.Close()
        SPConnect.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        SPConnect.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Sub showWhDescriprtion()

        On Error GoTo out

        Dim cmd2 As New SqlCommand
        Dim rs2 As SqlDataReader

        cmd2.CommandText = "mg_ShowWhDescription"
        cmd2.CommandType = CommandType.StoredProcedure
        cmd2.Connection = SPConnect2
        cmd2.Parameters.AddWithValue("@ParamWHCode", txt_whcode.Text)
        SPConnect2.Open()

        rs2 = cmd2.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        If rs2.Read() Then
            txt_whdesc.Text = rs2.Item("whcategorydesc").ToString()
        End If


        rs2.Close()
        SPConnect2.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs2.Close()
        SPConnect2.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Sub showMaintModel()

        txt_model.Items.Clear()
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowMaintModel"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnect

        SPConnect.Open()

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        Do While rs.Read()
            txt_model.Items.Add(rs.Item("modeldesc").ToString())
        Loop
        rs.Close()
        SPConnect.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        SPConnect.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Sub showMaintModelCode()

        On Error GoTo out

        Dim cmd2 As New SqlCommand
        Dim rs2 As SqlDataReader

        cmd2.CommandText = "mg_ShowMaintModelCode"
        cmd2.CommandType = CommandType.StoredProcedure
        cmd2.Connection = SPConnect2
        cmd2.Parameters.AddWithValue("@ParamModelDesc", txt_model.Text)
        SPConnect2.Open()

        rs2 = cmd2.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        If rs2.Read() Then
            txt_code.Text = rs2.Item("id").ToString()
        End If


        rs2.Close()
        SPConnect2.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs2.Close()
        SPConnect2.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Sub showMaintColor()

        txt_color.Items.Clear()
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowItemColor"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnect

        SPConnect.Open()

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        Do While rs.Read()
            txt_color.Items.Add(rs.Item("colordesc").ToString())
        Loop
        rs.Close()
        SPConnect.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        SPConnect.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Sub showMaintBrand()

        txt_brand.Items.Clear()
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowBrand"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnect

        SPConnect.Open()

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        Do While rs.Read()
            txt_brand.Items.Add(rs.Item("branddesc").ToString())
        Loop
        rs.Close()
        SPConnect.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        SPConnect.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Sub mg_ShowInventoryDetails()

        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowInventoryDetails"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnect

        cmd.Parameters.AddWithValue("@ParamID", txt_id.Text)


        SPConnect.Open()
        rs = cmd.ExecuteReader()

        If rs.Read Then
            txt_code.Text = rs.Item("code").ToString()
            txt_BranchCode.Text = rs.Item("branchcode").ToString()
            txt_BranchName.Text = rs.Item("vendor").ToString()
            txt_InventoryStatus.Text = rs.Item("inventorystatus").ToString()
            receivedDate.Value = rs.Item("datereceived").ToString()
            txt_itemgroup.Text = rs.Item("item_grp").ToString()
            txt_model.Text = rs.Item("model").ToString()
            txt_color.Text = rs.Item("color").ToString()
            txt_brand.Text = rs.Item("brand").ToString()
            txt_descrip.Text = rs.Item("description").ToString()
            txt_keynumber.Text = rs.Item("keyno").ToString()
            txt_engineNo.Text = rs.Item("engineno").ToString()
            txt_chassisNo.Text = rs.Item("chassisno").ToString()
            txt_IfExist.Text = rs.Item("IfExist").ToString()

            txt_CustName.Text = rs.Item("note").ToString()
            txt_Remarks.Text = rs.Item("remarks").ToString()
            txt_code.Text = rs.Item("code").ToString()
            txt_whdesc.Text = rs.Item("whcategory").ToString()
            txt_whcode.Text = rs.Item("whcode").ToString()
            txt_PrevID.Text = rs.Item("PrevID").ToString()

        End If

        rs.Close()
        SPConnect.Close()
        GoTo outs

out:    MsgBox(Err.Description & " - " & Err.Number, vbCritical)

        SPConnect.Close()
        GoTo outs

outs:
    End Sub

    Sub mg_AdminReclassInventory()

        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_AdminReclassInventory"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = SPConnect

        cmd.Parameters.AddWithValue("@Paramid", txt_id.Text)
        cmd.Parameters.AddWithValue("@Paramvendor", txt_BranchName.Text)
        cmd.Parameters.AddWithValue("@ParamdateReceived", receivedDate.Text)
        cmd.Parameters.AddWithValue("@Paramwhcategory", txt_whdesc.Text)
        cmd.Parameters.AddWithValue("@ParamwhCode", txt_whcode.Text)
        cmd.Parameters.AddWithValue("@ParaminventoryStatus", txt_InventoryStatus.Text)
        cmd.Parameters.AddWithValue("@ParamIfExist", txt_IfExist.Text)
        cmd.Parameters.AddWithValue("@ParamCode", txt_code.Text)
        cmd.Parameters.AddWithValue("@Parammodel", txt_model.Text)
        cmd.Parameters.AddWithValue("@Paramcolor", txt_color.Text)
        cmd.Parameters.AddWithValue("@Paramdescription", txt_descrip.Text)
        cmd.Parameters.AddWithValue("@Parambrand", txt_brand.Text)
        cmd.Parameters.AddWithValue("@Paramengineno", txt_engineNo.Text)
        cmd.Parameters.AddWithValue("@Paramchassisno", txt_chassisNo.Text)
        cmd.Parameters.AddWithValue("@Paramkeyno", txt_keynumber.Text)
        cmd.Parameters.AddWithValue("@Paramtransactedby", MainMenu.statusUser.Caption)
        cmd.Parameters.AddWithValue("@Paramtransactiondate", receivedDate.Text)
        cmd.Parameters.AddWithValue("@Parambranchcode", txt_BranchCode.Text)
        cmd.Parameters.AddWithValue("@Paramnote", txt_CustName.Text)
        cmd.Parameters.AddWithValue("@Paramitem_grp", txt_itemgroup.Text)
        cmd.Parameters.AddWithValue("@ParamRemarks", txt_Remarks.Text)
        cmd.Parameters.AddWithValue("@ParamPrevID", txt_PrevID.Text)

        SPConnect.Open()

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        If rs.Read() Then
            MsgBox(rs.Item("Message").ToString())
        End If


        rs.Close()
        SPConnect.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        SPConnect.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Private Sub txt_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_id.TextChanged
        Call mg_ShowInventoryDetails()
    End Sub

    Private Sub txt_whcode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_whcode.TextChanged
        Call showWhDescriprtion()
    End Sub

    Private Sub txt_model_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_model.TextChanged
        Call showMaintModelCode()
        Call CreateDescription()
    End Sub

    Private Sub txt_color_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_color.TextChanged
        Call CreateDescription()
    End Sub

    Private Sub toolUPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolUPDATE.Click
        Call mg_AdminReclassInventory()
    End Sub

    Private Sub toolFindItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolFindItem.Click
        IS_Inventory_Outgoing_item_find.Text = "InvtyReclass"
        IS_Inventory_Outgoing_item_find.ShowDialog()
    End Sub

    Private Sub toolnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolnew.Click
        txt_id.Text = ""
        txt_code.Text = ""
        txt_BranchCode.Text = ""
        txt_BranchName.Text = ""
        txt_InventoryStatus.Text = ""
        receivedDate.Value = Now
        txt_itemgroup.Text = ""
        txt_model.Text = ""
        txt_color.Text = ""
        txt_brand.Text = ""
        txt_descrip.Text = ""
        txt_keynumber.Text = ""
        txt_engineNo.Text = ""
        txt_chassisNo.Text = ""
        txt_IfExist.Text = ""
        txt_CustName.Text = ""
        txt_Remarks.Text = ""
        txt_code.Text = ""
        txt_whdesc.Text = ""
        txt_whcode.Text = ""
    End Sub

End Class