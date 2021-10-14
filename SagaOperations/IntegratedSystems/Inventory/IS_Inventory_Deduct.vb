Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_Deduct
    Private Sub IS_Inventory_Deduct_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "DEDUCT" Then
            clearItems()
            searchwareHouse()
        End If
    End Sub

    Sub clearItems()
        txt_code.Text = String.Empty
        txt_id.Text = String.Empty
        txt_model.Text = String.Empty
        txt_color.Text = String.Empty
        txt_brand.Text = String.Empty
        txt_descrip.Text = String.Empty
        txt_keynumber.Text = String.Empty
        txt_chassisNo.Text = String.Empty
        txt_engineNo.Text = String.Empty
        txt_uniPrice.Text = String.Empty
    End Sub

    Sub searchwareHousecode()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM maint_whcategory WHERE whcategorydesc LIKE '" & cmb_warehouse.Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_whcode.Text = myDataReader("whcategorycode").ToString()
            End If
        End Using
    End Sub

    Sub searchwareHouse()
        cmb_warehouse.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM maint_whcategory")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_warehouse.Items.Add(myDataReader.Item("whcategorydesc").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub cmd_vendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_vendor.Click
        IS_vendor_add.eventFrom.Text = "Deduct"
        IS_vendor_add.ShowDialog()
    End Sub

    Private Sub cmd_showInvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_showInvent.Click
        If lbl_vendor.Text = String.Empty Then
            MsgBox("Please select Branch!", vbCritical, "webSources")
        End If

        If txt_whcode.Text = String.Empty Then
            MsgBox("Please select warehouse category!", vbCritical, "webSources")
        End If

        searchInventory()
    End Sub

    Private Sub cmb_warehouse_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_warehouse.TextChanged
        If Me.Text = "DEDUCT" Then
            searchwareHousecode()
        ElseIf Me.Text = "DISAPPROVED" Then
        End If
    End Sub

    Sub searchInventory()
        LViewItems4Deduct.Items.Clear()

        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_details WHERE branchcode LIKE '" & lbl_vendorCode.Text & "' AND IfExist = '1' AND whCode LIKE '" & txt_whcode.Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItems4Deduct.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("chassisno").ToString())
                    li.SubItems.Add(myDataReader.Item("engineno").ToString())
                    li.SubItems.Add(myDataReader.Item("model").ToString())
                    li.SubItems.Add(myDataReader.Item("description").ToString())
                    li.SubItems.Add(myDataReader.Item("color").ToString())
                    li.SubItems.Add(myDataReader.Item("brand").ToString())
                    li.SubItems.Add(myDataReader.Item("unitcost").ToString())
                    li.SubItems.Add(myDataReader.Item("vatamt").ToString())
                    li.SubItems.Add(myDataReader.Item("totalcost").ToString())
                    li.SubItems.Add(myDataReader.Item("unitprice").ToString())
                    li.SubItems.Add(myDataReader.Item("keyno").ToString())
                Loop
            End If
        End Using
        LViewEventOutgoing()
    End Sub

    Private Sub LViewItems4Deduct_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewItems4Deduct.DoubleClick
        txt_id.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(0).Text
        txt_code.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(1).Text
        txt_model.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(4).Text
        txt_color.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(6).Text
        txt_brand.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(7).Text
        txt_descrip.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(5).Text
        txt_keynumber.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(12).Text
        txt_engineNo.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(3).Text
        txt_chassisNo.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(2).Text
        txt_uniPrice.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(11).Text
    End Sub

    Private Sub quickSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quickSearch.TextChanged
        QuicksearchInventory()
    End Sub

    Sub QuicksearchInventory()
        LViewItems4Deduct.Items.Clear()

        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_details WHERE (refno LIKE '%" & quickSearch.Text & "%' or chassisno LIKE '%" & quickSearch.Text & "%' or engineno LIKE '%" & quickSearch.Text & "%' or pono LIKE '%" & quickSearch.Text & "%' or description LIKE '%" & quickSearch.Text & "%') and IfExist LIKE '1' AND branchcode LIKE '" & lbl_vendorCode.Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItems4Deduct.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("chassisno").ToString())
                    li.SubItems.Add(myDataReader.Item("engineno").ToString())
                    li.SubItems.Add(myDataReader.Item("model").ToString())
                    li.SubItems.Add(myDataReader.Item("description").ToString())
                    li.SubItems.Add(myDataReader.Item("color").ToString())
                    li.SubItems.Add(myDataReader.Item("brand").ToString())
                    li.SubItems.Add(myDataReader.Item("unitcost").ToString())
                    li.SubItems.Add(myDataReader.Item("vatamt").ToString())
                    li.SubItems.Add(myDataReader.Item("totalcost").ToString())
                    li.SubItems.Add(myDataReader.Item("unitprice").ToString())
                    li.SubItems.Add(myDataReader.Item("keyno").ToString())
                Loop
            End If
        End Using
        LViewEventOutgoing()
    End Sub

    Public Sub LViewEventOutgoing()
        Dim TotalunitCost As Double = 0
        Dim TotalVATAmt As Double = 0
        Dim GrandTotal As Double = 0
        Dim TotalCount As Double = 0

        Dim TempNode As ListViewItem
        'Dim TempUnitCost, TempVATAmt, TempUnitPrice, TempGrandTotal As Double

        For Each TempNode In LViewItems4Deduct.Items
            'If Double.TryParse(TempNode.SubItems.Item(8).Text, TempUnitCost) Then
            '    TotalunitCost += TempUnitCost
            'End If
            'If Double.TryParse(TempNode.SubItems.Item(9).Text, TempVATAmt) Then
            '    TotalVATAmt += TempVATAmt
            'End If
            'If Double.TryParse(TempNode.SubItems.Item(10).Text, TempGrandTotal) Then
            '    GrandTotal += TempGrandTotal
            'End If
            'If Double.TryParse(TempNode.SubItems.Item(11).Text, TempUnitPrice) Then
            '    TotalUnitPrice += TempUnitPrice
            'End If
            TotalCount = TotalCount + 1
        Next
        'IS_Inventory_Outgoing.lbl_tot_unit.Text = Format(TotalunitCost, "###.##")
        'IS_Inventory_Outgoing.lbl_totVatAmt.Text = Format(TotalVATAmt, "###.##")
        'IS_Inventory_Outgoing.lbl_grandTotal.Text = Format(GrandTotal, "###.##")
        'IS_Inventory_Outgoing.lbl_totUnitPrice.Text = Format(TotalUnitPrice, "###.##")
        lbl_count.Text = TotalCount
    End Sub

    Private Sub cmb_cod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cod.Click
        If MsgBox("Please review and press OK to proceed. " & vbCrLf & "Press No to cancel transaction.", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then
            SoldViaCOD()
            searchInventory()
            clearItems()
        Else
            MsgBox("Transaction Cancelled", vbInformation, "webSources")
        End If
    End Sub

    Sub SoldViaCOD()
        'Dim Parameters As SqlParameter() = {}
        'Dim i As Integer
        'With cmd
        '    .Connection = class_Database.mySQLConnection
        '    .CommandText = "INSERT INTO TransactionReleases(refno,Branch,transcode,TransactionDate,POno,whcategory,whcode,code,id,model,description,color,brand,chassisno,engineno,keyno,inventoryStatus,unitcost,vatamt,totalcost,unitprice,branchcode,IfExist,transactedby) " _
        '                          & "VALUES('','" & lbl_vendor.Text & "','','" & receivedDate.Text & "',' ','" & cmb_warehouse.Text & "','" & txt_whcode.Text & "','" & txt_code.Text & "','" & txt_id.Text & "','" & txt_model.Text & "','" & txt_descrip.Text & "','" & txt_color.Text & "','" & txt_brand.Text & "','" & txt_chassisNo.Text & "','" & txt_engineNo.Text & "','" & txt_keynumber.Text & "','COD','0.00','0.00','0.00','" & txt_uniPrice.Text & "','" & lbl_vendorCode.Text & "','0','" & MainMenu.App_User_Name.Caption & "')"
        '    i = .ExecuteNonQuery
        '    .CommandText = "UPDATE item_Details set IfExist='0',inventoryStatus='COD',transactiondate='" & receivedDate.Text & "' WHERE code LIKE '" & txt_code.Text & "' AND id LIKE '" & txt_id.Text & "'"
        '    i = .ExecuteNonQuery
        'End With
        'If i > 0 Then
        '    MsgBox("Command completed successfully!", vbInformation, "webSources")
        'End If
    End Sub

    Sub SoldViaFinancing()
        'Dim Parameters As SqlParameter() = {}
        'Dim i As Integer
        'With cmd
        '    .Connection = class_Database.mySQLConnection
        '    .CommandText = "INSERT INTO TransactionReleases(refno,Branch,transcode,TransactionDate,POno,whcategory,whcode,code,id,model,description,color,brand,chassisno,engineno,keyno,inventoryStatus,unitcost,vatamt,totalcost,unitprice,branchcode,IfExist,transactedby) " _
        '                          & "VALUES('','" & lbl_vendor.Text & "','','" & receivedDate.Text & "',' ','" & cmb_warehouse.Text & "','" & txt_whcode.Text & "','" & txt_code.Text & "','" & txt_id.Text & "','" & txt_model.Text & "','" & txt_descrip.Text & "','" & txt_color.Text & "','" & txt_brand.Text & "','" & txt_chassisNo.Text & "','" & txt_engineNo.Text & "','" & txt_keynumber.Text & "','FIN','0.00','0.00','0.00','" & txt_uniPrice.Text & "','" & lbl_vendorCode.Text & "','0','" & MainMenu.App_User_Name.Caption & "')"
        '    i = .ExecuteNonQuery
        '    .CommandText = "UPDATE item_Details set IfExist='0',inventoryStatus='FIN',transactiondate='" & receivedDate.Text & "' WHERE code LIKE '" & txt_code.Text & "' AND id LIKE '" & txt_id.Text & "'"
        '    i = .ExecuteNonQuery
        'End With
        'If i > 0 Then
        '    MsgBox("Command completed successfully!", vbInformation, "webSources")
        'End If
    End Sub

    Sub SoldViaRedeemption()
        'Dim Parameters As SqlParameter() = {}
        'Dim i As Integer
        'With cmd
        '    .Connection = class_Database.mySQLConnection
        '    .CommandText = "INSERT INTO TransactionReleases(refno,Branch,transcode,TransactionDate,POno,whcategory,whcode,code,id,model,description,color,brand,chassisno,engineno,keyno,inventoryStatus,unitcost,vatamt,totalcost,unitprice,branchcode,IfExist,transactedby) " _
        '                          & "VALUES('','" & lbl_vendor.Text & "','','" & receivedDate.Text & "',' ','" & cmb_warehouse.Text & "','" & txt_whcode.Text & "','" & txt_code.Text & "','" & txt_id.Text & "','" & txt_model.Text & "','" & txt_descrip.Text & "','" & txt_color.Text & "','" & txt_brand.Text & "','" & txt_chassisNo.Text & "','" & txt_engineNo.Text & "','" & txt_keynumber.Text & "','RED','0.00','0.00','0.00','" & txt_uniPrice.Text & "','" & lbl_vendorCode.Text & "','0','" & MainMenu.App_User_Name.Caption & "')"
        '    i = .ExecuteNonQuery
        '    .CommandText = "UPDATE item_Details set IfExist='0',inventoryStatus='RED',transactiondate='" & receivedDate.Text & "' WHERE code LIKE '" & txt_code.Text & "' AND id LIKE '" & txt_id.Text & "'"
        '    i = .ExecuteNonQuery
        'End With
        'If i > 0 Then
        '    MsgBox("Command completed successfully!", vbInformation, "webSources")
        'End If
    End Sub

    Sub SoldViaAssumption()
        'Dim Parameters As SqlParameter() = {}
        'Dim i As Integer
        'With cmd
        '    .Connection = class_Database.mySQLConnection
        '    .CommandText = "INSERT INTO TransactionReleases(refno,Branch,transcode,TransactionDate,POno,whcategory,whcode,code,id,model,description,color,brand,chassisno,engineno,keyno,inventoryStatus,unitcost,vatamt,totalcost,unitprice,branchcode,IfExist,transactedby) " _
        '                          & "VALUES('','" & lbl_vendor.Text & "','','" & receivedDate.Text & "',' ','" & cmb_warehouse.Text & "','" & txt_whcode.Text & "','" & txt_code.Text & "','" & txt_id.Text & "','" & txt_model.Text & "','" & txt_descrip.Text & "','" & txt_color.Text & "','" & txt_brand.Text & "','" & txt_chassisNo.Text & "','" & txt_engineNo.Text & "','" & txt_keynumber.Text & "','ASM','0.00','0.00','0.00','" & txt_uniPrice.Text & "','" & lbl_vendorCode.Text & "','0','" & MainMenu.App_User_Name.Caption & "')"
        '    i = .ExecuteNonQuery
        '    .CommandText = "UPDATE item_Details set IfExist='0',inventoryStatus='ASM',transactiondate='" & receivedDate.Text & "' WHERE code LIKE '" & txt_code.Text & "' AND id LIKE '" & txt_id.Text & "'"
        '    i = .ExecuteNonQuery
        'End With
        'If i > 0 Then
        '    MsgBox("Command completed successfully!", vbInformation, "webSources")
        'End If
    End Sub

    Sub SoldViaLotSale()
        'Dim Parameters As SqlParameter() = {}
        'Dim i As Integer
        'With cmd
        '    .Connection = class_Database.mySQLConnection
        '    .CommandText = "INSERT INTO TransactionReleases(refno,Branch,transcode,TransactionDate,POno,whcategory,whcode,code,id,model,description,color,brand,chassisno,engineno,keyno,inventoryStatus,unitcost,vatamt,totalcost,unitprice,branchcode,IfExist,transactedby) " _
        '                          & "VALUES('','" & lbl_vendor.Text & "','','" & receivedDate.Text & "',' ','" & cmb_warehouse.Text & "','" & txt_whcode.Text & "','" & txt_code.Text & "','" & txt_id.Text & "','" & txt_model.Text & "','" & txt_descrip.Text & "','" & txt_color.Text & "','" & txt_brand.Text & "','" & txt_chassisNo.Text & "','" & txt_engineNo.Text & "','" & txt_keynumber.Text & "','LSA','0.00','0.00','0.00','" & txt_uniPrice.Text & "','" & lbl_vendorCode.Text & "','0','" & MainMenu.App_User_Name.Caption & "')"
        '    i = .ExecuteNonQuery
        '    .CommandText = "UPDATE item_Details set IfExist='0',inventoryStatus='LSA',transactiondate='" & receivedDate.Text & "' WHERE code LIKE '" & txt_code.Text & "' AND id LIKE '" & txt_id.Text & "'"
        '    i = .ExecuteNonQuery
        'End With
        'If i > 0 Then
        '    MsgBox("Command completed successfully!", vbInformation, "webSources")
        'End If
    End Sub

    Private Sub cmb_financed_Click(sender As System.Object, e As System.EventArgs) Handles cmb_financed.Click
        If MsgBox("Please review and press OK to proceed. " & vbCrLf & "Press No to cancel transaction.", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then
            SoldViaFinancing()
            searchInventory()
            clearItems()
        Else
            MsgBox("Transaction Cancelled", vbInformation, "webSources")
        End If
    End Sub

    Private Sub cmd_redeem_Click(sender As System.Object, e As System.EventArgs) Handles cmd_redeem.Click
        If MsgBox("Please review and press OK to proceed. " & vbCrLf & "Press No to cancel transaction.", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then
            SoldViaRedeemption()
            searchInventory()
            clearItems()
        Else
            MsgBox("Transaction Cancelled", vbInformation, "webSources")
        End If
    End Sub

    Private Sub cmd_assump_Click(sender As System.Object, e As System.EventArgs) Handles cmd_assump.Click
        If MsgBox("Please review and press OK to proceed. " & vbCrLf & "Press No to cancel transaction.", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then
            SoldViaAssumption()
            searchInventory()
            clearItems()
        Else
            MsgBox("Transaction Cancelled", vbInformation, "webSources")
        End If
    End Sub

    Private Sub cmd_LotSale_Click(sender As System.Object, e As System.EventArgs) Handles cmd_LotSale.Click
        If MsgBox("Please review and press OK to proceed. " & vbCrLf & "Press No to cancel transaction.", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then
            SoldViaLotSale()
            searchInventory()
            clearItems()
        Else
            MsgBox("Transaction Cancelled", vbInformation, "webSources")
        End If
    End Sub

End Class