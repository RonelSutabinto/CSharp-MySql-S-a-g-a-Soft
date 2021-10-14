Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_Outgoing_item_find
    Private Sub IS_Inventory_Outgoing_item_find_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            MsgBox("F2")
        End If
    End Sub

    Private Sub IS_Inventory_Outgoing_item_find_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If IS_Inventory_Outgoing.Text = "DISAPPROVED" Then
            searchInventory()
        Else
            searchInventory()
        End If
    End Sub

    Sub searchInventoryWHReclass()
        LViewItemsOutgoing.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamquickSearch", quickSearch.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_IS_Inventory_Outgoing_item_find")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItemsOutgoing.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("PrevID").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateReceived"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("IfExist").ToString())
                    li.SubItems.Add(myDataReader.Item("whcode").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("model").ToString())
                    li.SubItems.Add(myDataReader.Item("color").ToString())
                    li.SubItems.Add(myDataReader.Item("brand").ToString())
                    li.SubItems.Add(myDataReader.Item("engineno").ToString())
                    li.SubItems.Add(myDataReader.Item("chassisno").ToString())
                    li.SubItems.Add(myDataReader.Item("unitcost").ToString())
                    li.SubItems.Add(myDataReader.Item("vatamt").ToString())
                    li.SubItems.Add(myDataReader.Item("totalcost").ToString())
                    li.SubItems.Add(myDataReader.Item("unitprice").ToString())
                    li.SubItems.Add(myDataReader.Item("keyno").ToString())
                    li.SubItems.Add(myDataReader.Item("description").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub searchInventory()
        LViewItemsOutgoing.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamIfExist", "1"),
            New SqlParameter("@ParamWHCode", IS_Inventory_Outgoing.cmb_warehouse.EditValue)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowMCInvPerBrPerWH")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItemsOutgoing.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("PrevID").ToString())
                    li.SubItems.Add(myDataReader.Item("DateReceived").ToString())
                    li.SubItems.Add(myDataReader.Item("IfExist").ToString())
                    li.SubItems.Add(myDataReader.Item("whcode").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("model").ToString())
                    li.SubItems.Add(myDataReader.Item("color").ToString())
                    li.SubItems.Add(myDataReader.Item("brand").ToString())
                    li.SubItems.Add(myDataReader.Item("engineno").ToString())
                    li.SubItems.Add(myDataReader.Item("chassisno").ToString())
                    li.SubItems.Add(myDataReader.Item("unitcost").ToString())
                    li.SubItems.Add(myDataReader.Item("vatamt").ToString())
                    li.SubItems.Add(myDataReader.Item("totalcost").ToString())
                    li.SubItems.Add(myDataReader.Item("unitprice").ToString())
                    li.SubItems.Add(myDataReader.Item("keyno").ToString())
                    li.SubItems.Add(myDataReader.Item("description").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("BrCodeAccount").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("LedgerSetNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("SpecNotes").ToString())
                    li.SubItems.Add(myDataReader.Item("note").ToString())
                Loop
            End If
        End Using
    End Sub

    Private dt_Outgoing As DataTable

    Private Sub LViewItemsOutgoing_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewItemsOutgoing.DoubleClick
        If Me.Text = "InvtyReclass" Then
            Admin_ReclassINVTY.txt_id.Text = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(0).Text
            Me.Close()

        ElseIf Me.Text = "OUTGOING" Then
            Dim dr As DataRow = dt_Outgoing.NewRow
            dr(0) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(0).Text 'id
            dr(1) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(17).Text ' code
            dr(2) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(6).Text 'model
            dr(3) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(6).Text & " - " & LViewItemsOutgoing.SelectedItems.Item(0).SubItems(7).Text 'description
            dr(4) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(7).Text ' color
            dr(5) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(8).Text ' brand
            dr(6) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(9).Text ' engineno
            dr(7) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(10).Text ' chassisno
            dr(8) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(15).Text 'keyno
            dr(9) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(11).Text ' unitcost
            dr(10) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(12).Text ' vatamt
            dr(11) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(13).Text ' totalcost
            dr(12) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(14).Text 'unitprice
            dr(13) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(22).Text ' Accountname
            dr(14) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(18).Text ' BrCodeAcct
            dr(15) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(19).Text ' Accountnumber
            dr(16) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(20).Text ' ledgerset
            dr(17) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(21).Text ' spec
            dr(18) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(1).Text ' previd

            dt_Outgoing.Rows.Add(dr)
            IS_Inventory_Outgoing.GridControl.DataSource = dt_Outgoing

            LViewItemsOutgoing.Items.RemoveAt(LViewItemsOutgoing.SelectedIndices(0))

        ElseIf Me.Text = "DISAPPROVED" Then
            Dim dr As DataRow = IS_Inventory_List.dt_Outgoing.NewRow
            dr(0) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(0).Text 'id
            dr(1) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(17).Text ' code
            dr(2) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(6).Text 'model
            dr(3) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(6).Text & " - " & LViewItemsOutgoing.SelectedItems.Item(0).SubItems(7).Text 'description
            dr(4) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(7).Text ' color
            dr(5) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(8).Text ' brand
            dr(6) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(9).Text ' engineno
            dr(7) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(10).Text ' chassisno
            dr(8) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(15).Text 'keyno
            dr(9) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(11).Text ' unitcost
            dr(10) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(12).Text ' vatamt
            dr(11) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(13).Text ' totalcost
            dr(12) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(14).Text 'unitprice
            dr(13) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(22).Text ' Accountname
            dr(14) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(18).Text ' BrCodeAcct
            dr(15) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(19).Text ' Accountnumber
            dr(16) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(20).Text ' ledgerset
            dr(17) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(21).Text ' spec
            dr(18) = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(1).Text ' previd

            IS_Inventory_List.dt_Outgoing.Rows.Add(dr)
            IS_Inventory_Outgoing.GridControl.DataSource = IS_Inventory_List.dt_Outgoing
            LViewItemsOutgoing.Items.RemoveAt(LViewItemsOutgoing.SelectedIndices(0))
        End If
    End Sub

    Sub Initialize_GridList_outgoing()
        dt_Outgoing = New DataTable
        dt_Outgoing.Columns.Add("id")
        dt_Outgoing.Columns.Add("Code")
        dt_Outgoing.Columns.Add("Model")
        dt_Outgoing.Columns.Add("Description")
        dt_Outgoing.Columns.Add("Color")
        dt_Outgoing.Columns.Add("Brand")
        dt_Outgoing.Columns.Add("EngineNo")
        dt_Outgoing.Columns.Add("ChassisNo")
        dt_Outgoing.Columns.Add("KeyNo")
        dt_Outgoing.Columns.Add("UnitCost")
        dt_Outgoing.Columns.Add("VATAmt")
        dt_Outgoing.Columns.Add("TotalCost")
        dt_Outgoing.Columns.Add("UnitPrice")
        dt_Outgoing.Columns.Add("AccountName")
        dt_Outgoing.Columns.Add("BrCodeAcct")
        dt_Outgoing.Columns.Add("AccountNumber")
        dt_Outgoing.Columns.Add("LedgerSet")
        dt_Outgoing.Columns.Add("SpecificNotes")
        dt_Outgoing.Columns.Add("PrevID")

        IS_Inventory_Outgoing.GridControl.DataSource = dt_Outgoing
    End Sub

    Private Sub quickSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quickSearch.TextChanged
        If quickSearch.Text.Length > 4 Then
            If Me.Text = "InvtyReclass" Then
                searchInventoryWHReclass()
            Else
                QuicksearchInventory()
            End If
        End If
    End Sub

    Sub QuicksearchInventory()
        LViewItemsOutgoing.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamQuickSearch", quickSearch.Text),
            New SqlParameter("@ParamIfExist", "1")
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowItem")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItemsOutgoing.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("PrevID").ToString())
                    li.SubItems.Add(myDataReader.Item("DateReceived").ToString())
                    li.SubItems.Add(myDataReader.Item("IfExist").ToString())
                    li.SubItems.Add(myDataReader.Item("whcode").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("model").ToString())
                    li.SubItems.Add(myDataReader.Item("color").ToString())
                    li.SubItems.Add(myDataReader.Item("brand").ToString())
                    li.SubItems.Add(myDataReader.Item("engineno").ToString())
                    li.SubItems.Add(myDataReader.Item("chassisno").ToString())
                    li.SubItems.Add(myDataReader.Item("unitcost").ToString())
                    li.SubItems.Add(myDataReader.Item("vatamt").ToString())
                    li.SubItems.Add(myDataReader.Item("totalcost").ToString())
                    li.SubItems.Add(myDataReader.Item("unitprice").ToString())
                    li.SubItems.Add(myDataReader.Item("keyno").ToString())
                    li.SubItems.Add(myDataReader.Item("description").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("BrCodeAccount").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("LedgerSetNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("SpecNotes").ToString())
                    li.SubItems.Add(myDataReader.Item("note").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub quickSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles quickSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If quickSearch.Text.Length > 3 Then
                If Me.Text = "InvtyReclass" Then
                    searchInventoryWHReclass()
                Else
                    QuicksearchInventory()
                End If
            End If
        End If

    End Sub
End Class