Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class maint_model_SP

    Private Sub ToolReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolReg.Click

        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "Spare_Parts_Save"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamPartsNumber", txt_PartsNumber.Text)
        cmd.Parameters.AddWithValue("@ParamPartsName", txt_PartsName.Text)
        cmd.Parameters.AddWithValue("@ParamCategory", txt_Category.Text)
        cmd.Parameters.AddWithValue("@ParamSRP", txt_SRP.Text)
        cmd.Parameters.AddWithValue("@ParamDiscountPct", txt_DiscPct.Text)
        cmd.Parameters.AddWithValue("@ParamDiscountAMT", txt_DiscAmt.Text)
        cmd.Parameters.AddWithValue("@ParamPriceWVAT", txt_PriceWVat.Text)
        cmd.Parameters.AddWithValue("@ParamPriceWOVAT", txt_PriceWOVAT.Text)
        cmd.Parameters.AddWithValue("@ParamModelCode", txt_ModelCode.Text)
        cmd.Parameters.AddWithValue("@ParamModelName", txt_ModelName.Text)
        cmd.Parameters.AddWithValue("@ParamNote", txt_Note.Text)
        cmd.Parameters.AddWithValue("@ParamRemarks", txt_Remarks.Text)
        cmd.Parameters.AddWithValue("@ParamQuantity", txt_quantity.Value)
        cmd.Parameters.AddWithValue("@ParamCostWVAT", txt_CostWVAT.Text)
        cmd.Parameters.AddWithValue("@ParamCostWoVAT", txt_CostWoVAT.Text)

        cmd.Parameters.AddWithValue("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        cmd.Parameters.AddWithValue("@ParamTransactionDate", Now)
        cmd.Parameters.AddWithValue("@ParamPostingDate", Now)
        cmd.Parameters.AddWithValue("@ParamBranchCode", MainMenu.statusBrCode.Caption)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If
        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)
        Return
outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
         LoadSP()
    End Sub

    Private Sub maint_model_SP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
         LoadSP()
        quickSearch.Text = String.Empty
        LViewItems.Items.Clear()
    End Sub

    Sub LViewRowCnt()
        Dim TotalCount As Integer

        TotalCount = 0
        Dim TempNode As ListViewItem
        ' Dim TempUnitCost, TempVATAmt, TempUnitPrice, TempGrandTotal As Double

        '  If IS_Inventory_item_add.eventForm.Text = "Receiving" Then
        For Each TempNode In LViewItems.Items
            TotalCount = TotalCount + 1
        Next

        txt_rows.Text = TotalCount
    End Sub

    Sub Spare_Parts_FindITEM()
        'LViewItems.Items.Clear()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "Spare_Parts_FindITEM"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamPartsNumber", txt_PartsNumber.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            txt_Category.Text = rs.Item("category").ToString()
            txt_DiscPct.Text = rs.Item("discountpct").ToString()
            txt_DiscAmt.Text = rs.Item("discountAMT").ToString()
            txt_PriceWVat.Text = rs.Item("PriceWVAT").ToString()
            txt_PriceWOVAT.Text = rs.Item("PriceWOVAT").ToString()
            txt_ModelCode.Text = rs.Item("ModelCode").ToString()
            txt_ModelName.Text = rs.Item("ModelName").ToString()
            txt_Note.Text = rs.Item("note").ToString()
        End If

        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)
        Return
outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
         LViewRowCnt()
    End Sub

    Sub LoadSP()
        LViewItems.Items.Clear()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "sp_Load"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        cmd.Parameters.AddWithValue("@ParamQuickText", quickSearch.Text)

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        Do While rs.Read
            Dim li As ListViewItem = LViewItems.Items.Add(rs.Item("PartsNumber").ToString())
            li.SubItems.Add(rs.Item("PartsName").ToString())
            li.SubItems.Add(rs.Item("srp").ToString())
            li.SubItems.Add(rs.Item("Quantity").ToString())
            li.SubItems.Add(rs.Item("ID").ToString())

        Loop

        GoTo outs1
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)
        Return
outs:
outs1:  rs.Close()
        class_Database.mySQLConnection.Close()
         LViewRowCnt()
    End Sub

    Private Sub LViewItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewItems.DoubleClick
        On Error GoTo out

        txt_PartsName.Text = LViewItems.SelectedItems.Item(0).SubItems(1).Text
        txt_SRP.Text = LViewItems.SelectedItems.Item(0).SubItems(2).Text
        txt_quantity.Value = LViewItems.SelectedItems.Item(0).SubItems(3).Text
        txt_ID.Text = LViewItems.SelectedItems.Item(0).SubItems(4).Text
        txt_PartsNumber.Text = LViewItems.SelectedItems.Item(0).SubItems(0).Text

        'txt_Category.Text = LViewItems.SelectedItems.Item(0).SubItems(3).Text
        'txt_DiscPct.Text = LViewItems.SelectedItems.Item(0).SubItems(5).Text
        'txt_DiscAmt.Text = LViewItems.SelectedItems.Item(0).SubItems(6).Text
        'txt_PriceWVat.Text = LViewItems.SelectedItems.Item(0).SubItems(7).Text
        'txt_PriceWOVAT.Text = LViewItems.SelectedItems.Item(0).SubItems(8).Text
        GoTo outs
out:    MsgBox(Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)
outs:
    End Sub

    Private Sub LViewItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LViewItems.SelectedIndexChanged

    End Sub

    Private Sub quickSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles quickSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
             LoadSP()
        End If
    End Sub

    Private Sub quickSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quickSearch.TextChanged

    End Sub

    Private Sub txt_PartsNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PartsNumber.TextChanged
         Spare_Parts_FindITEM()
    End Sub

    Private Sub txt_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ID.TextChanged

    End Sub

End Class