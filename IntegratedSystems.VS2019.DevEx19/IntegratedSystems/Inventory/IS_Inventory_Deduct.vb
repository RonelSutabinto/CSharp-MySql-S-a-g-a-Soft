Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_Deduct
    private sub IS_Inventory_Deduct_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "DEDUCT" Then
            clearItems()
            searchwareHouse()
        End If
    End Sub

    private sub clearItems()
        txt_code.Text = String.Empty
        txt_ID.text = String.Empty
        txt_model.Text = String.Empty
        txt_color.Text = String.Empty
        txt_brand.Text = String.Empty
        txt_descrip.Text = String.Empty
        txt_keynumber.Text = String.Empty
        txt_ChassisNo.Text = String.Empty
        txt_EngineNo.Text = String.Empty
        txt_uniPrice.Text = String.Empty
    End Sub

    private sub searchwareHousecode()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM maint_whcategory WHERE whcategorydesc LIKE '" & cmb_warehouse.Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_whcode.Text = myDataReader("whcategorycode").ToString()
            End If
        End Using
    End Sub

    private sub searchwareHouse()
        cmb_warehouse.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM maint_whcategory")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_warehouse.Items.Add(myDataReader.Item("whcategorydesc").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub cmd_vendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_vendor.Click
        'IS_vendor_add.eventFrom.Text = "Deduct"
        'IS_vendor_add.ShowDialog()
    End Sub

    private sub cmd_showInvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_showInvent.Click
        If lbl_vendor.Text = String.Empty Then
            MsgBox("Please select Branch!", vbCritical, "webSources")
        End If

        If txt_whcode.Text = String.Empty Then
            MsgBox("Please select warehouse category!", vbCritical, "webSources")
        End If

        searchInventory()
    End Sub

    private sub cmb_warehouse_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_warehouse.TextChanged
        If Me.Text = "DEDUCT" Then
            searchwareHousecode()
        ElseIf Me.Text = "DISAPPROVED" Then
        End If
    End Sub

    private sub searchInventory()
        LViewItems4Deduct.Items.Clear()

        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_details WHERE branchcode LIKE '" & lbl_vendorCode.Text & "' AND IfExist = '1' AND whCode LIKE '" & txt_whcode.Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItems4Deduct.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("ChassisNo").ToString())
                    li.SubItems.Add(myDataReader.Item("EngineNo").ToString())
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

    private sub LViewItems4Deduct_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewItems4Deduct.DoubleClick
        txt_ID.text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(0).Text
        txt_code.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(1).Text
        txt_model.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(4).Text
        txt_color.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(6).Text
        txt_brand.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(7).Text
        txt_descrip.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(5).Text
        txt_keynumber.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(12).Text
        txt_EngineNo.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(3).Text
        txt_ChassisNo.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(2).Text
        txt_uniPrice.Text = LViewItems4Deduct.SelectedItems.Item(0).SubItems(11).Text
    End Sub

    private sub quickSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quickSearch.TextChanged
        QuicksearchInventory()
    End Sub

    private sub QuicksearchInventory()
        LViewItems4Deduct.Items.Clear()

        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_details WHERE (refno LIKE '%" & quickSearch.Text & "%' or ChassisNo LIKE '%" & quickSearch.Text & "%' or EngineNo LIKE '%" & quickSearch.Text & "%' or pono LIKE '%" & quickSearch.Text & "%' or description LIKE '%" & quickSearch.Text & "%') and IfExist LIKE '1' AND branchcode LIKE '" & lbl_vendorCode.Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItems4Deduct.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("ChassisNo").ToString())
                    li.SubItems.Add(myDataReader.Item("EngineNo").ToString())
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

    friend sub LViewEventOutgoing()
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
            TotalCount += 1
        Next
        'IS_Inventory_Outgoing.lbl_tot_unit.Text = Format(TotalunitCost, "###.##")
        'IS_Inventory_Outgoing.lbl_totVatAmt.Text = Format(TotalVATAmt, "###.##")
        'IS_Inventory_Outgoing.lbl_grandTotal.Text = Format(GrandTotal, "###.##")
        'IS_Inventory_Outgoing.lbl_totUnitPrice.Text = Format(TotalUnitPrice, "###.##")
        lbl_count.Text = TotalCount
    End Sub

    private sub cmb_cod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_cod.Click
        If MsgBox("Please review and press OK to proceed. " & vbCrLf & "Press No to cancel transaction.", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then
            SoldViaCOD()
            searchInventory()
            clearItems()
        Else
            MsgBox("Transaction Cancelled", vbInformation, "webSources")
        End If
    End Sub

    private sub SoldViaCOD()
        'Dim sqlParameters As SqlParameter() = {}
        'Dim i As Integer
        'With cmd
        '    .Connection = class_Database.mySQLConnection
        '    .CommandText = "INSERT INTO TransactionReleases(refno,Branch,transcode,TransactionDate,POno,whcategory,whcode,code,id,model,description,color,brand,ChassisNo,EngineNo,keyno,inventoryStatus,unitcost,vatamt,totalcost,unitprice,branchcode,IfExist,transactedby) " _
        '                          & "VALUES('','" & lbl_vendor.Text & "','','" & receivedDate.Text & "',' ','" & cmb_warehouse.Text & "','" & txt_whcode.Text & "','" & txt_code.Text & "','" & txt_ID.text & "','" & txt_model.Text & "','" & txt_descrip.Text & "','" & txt_color.Text & "','" & txt_brand.Text & "','" & txt_ChassisNo.Text & "','" & txt_EngineNo.Text & "','" & txt_keynumber.Text & "','COD','0.00','0.00','0.00','" & txt_uniPrice.Text & "','" & lbl_vendorCode.Text & "','0','" & class_Variables.sUserName & "')"
        '    i = .ExecuteNonQuery
        '    .CommandText = "UPDATE item_Details set IfExist='0',inventoryStatus='COD',transactiondate='" & receivedDate.Text & "' WHERE code LIKE '" & txt_code.Text & "' AND id LIKE '" & txt_ID.text & "'"
        '    i = .ExecuteNonQuery
        'End With
        'If i > 0 Then
        '    MsgBox("Command completed successfully!", vbInformation, "webSources")
        'End If
    End Sub

    private sub SoldViaFinancing()
        'Dim sqlParameters As SqlParameter() = {}
        'Dim i As Integer
        'With cmd
        '    .Connection = class_Database.mySQLConnection
        '    .CommandText = "INSERT INTO TransactionReleases(refno,Branch,transcode,TransactionDate,POno,whcategory,whcode,code,id,model,description,color,brand,ChassisNo,EngineNo,keyno,inventoryStatus,unitcost,vatamt,totalcost,unitprice,branchcode,IfExist,transactedby) " _
        '                          & "VALUES('','" & lbl_vendor.Text & "','','" & receivedDate.Text & "',' ','" & cmb_warehouse.Text & "','" & txt_whcode.Text & "','" & txt_code.Text & "','" & txt_ID.text & "','" & txt_model.Text & "','" & txt_descrip.Text & "','" & txt_color.Text & "','" & txt_brand.Text & "','" & txt_ChassisNo.Text & "','" & txt_EngineNo.Text & "','" & txt_keynumber.Text & "','FIN','0.00','0.00','0.00','" & txt_uniPrice.Text & "','" & lbl_vendorCode.Text & "','0','" & class_Variables.sUserName & "')"
        '    i = .ExecuteNonQuery
        '    .CommandText = "UPDATE item_Details set IfExist='0',inventoryStatus='FIN',transactiondate='" & receivedDate.Text & "' WHERE code LIKE '" & txt_code.Text & "' AND id LIKE '" & txt_ID.text & "'"
        '    i = .ExecuteNonQuery
        'End With
        'If i > 0 Then
        '    MsgBox("Command completed successfully!", vbInformation, "webSources")
        'End If
    End Sub

    private sub SoldViaRedeemption()
        'Dim sqlParameters As SqlParameter() = {}
        'Dim i As Integer
        'With cmd
        '    .Connection = class_Database.mySQLConnection
        '    .CommandText = "INSERT INTO TransactionReleases(refno,Branch,transcode,TransactionDate,POno,whcategory,whcode,code,id,model,description,color,brand,ChassisNo,EngineNo,keyno,inventoryStatus,unitcost,vatamt,totalcost,unitprice,branchcode,IfExist,transactedby) " _
        '                          & "VALUES('','" & lbl_vendor.Text & "','','" & receivedDate.Text & "',' ','" & cmb_warehouse.Text & "','" & txt_whcode.Text & "','" & txt_code.Text & "','" & txt_ID.text & "','" & txt_model.Text & "','" & txt_descrip.Text & "','" & txt_color.Text & "','" & txt_brand.Text & "','" & txt_ChassisNo.Text & "','" & txt_EngineNo.Text & "','" & txt_keynumber.Text & "','RED','0.00','0.00','0.00','" & txt_uniPrice.Text & "','" & lbl_vendorCode.Text & "','0','" & class_Variables.sUserName & "')"
        '    i = .ExecuteNonQuery
        '    .CommandText = "UPDATE item_Details set IfExist='0',inventoryStatus='RED',transactiondate='" & receivedDate.Text & "' WHERE code LIKE '" & txt_code.Text & "' AND id LIKE '" & txt_ID.text & "'"
        '    i = .ExecuteNonQuery
        'End With
        'If i > 0 Then
        '    MsgBox("Command completed successfully!", vbInformation, "webSources")
        'End If
    End Sub

    private sub SoldViaAssumption()
        'Dim sqlParameters As SqlParameter() = {}
        'Dim i As Integer
        'With cmd
        '    .Connection = class_Database.mySQLConnection
        '    .CommandText = "INSERT INTO TransactionReleases(refno,Branch,transcode,TransactionDate,POno,whcategory,whcode,code,id,model,description,color,brand,ChassisNo,EngineNo,keyno,inventoryStatus,unitcost,vatamt,totalcost,unitprice,branchcode,IfExist,transactedby) " _
        '                          & "VALUES('','" & lbl_vendor.Text & "','','" & receivedDate.Text & "',' ','" & cmb_warehouse.Text & "','" & txt_whcode.Text & "','" & txt_code.Text & "','" & txt_ID.text & "','" & txt_model.Text & "','" & txt_descrip.Text & "','" & txt_color.Text & "','" & txt_brand.Text & "','" & txt_ChassisNo.Text & "','" & txt_EngineNo.Text & "','" & txt_keynumber.Text & "','ASM','0.00','0.00','0.00','" & txt_uniPrice.Text & "','" & lbl_vendorCode.Text & "','0','" & class_Variables.sUserName & "')"
        '    i = .ExecuteNonQuery
        '    .CommandText = "UPDATE item_Details set IfExist='0',inventoryStatus='ASM',transactiondate='" & receivedDate.Text & "' WHERE code LIKE '" & txt_code.Text & "' AND id LIKE '" & txt_ID.text & "'"
        '    i = .ExecuteNonQuery
        'End With
        'If i > 0 Then
        '    MsgBox("Command completed successfully!", vbInformation, "webSources")
        'End If
    End Sub

    private sub SoldViaLotSale()
        'Dim sqlParameters As SqlParameter() = {}
        'Dim i As Integer
        'With cmd
        '    .Connection = class_Database.mySQLConnection
        '    .CommandText = "INSERT INTO TransactionReleases(refno,Branch,transcode,TransactionDate,POno,whcategory,whcode,code,id,model,description,color,brand,ChassisNo,EngineNo,keyno,inventoryStatus,unitcost,vatamt,totalcost,unitprice,branchcode,IfExist,transactedby) " _
        '                          & "VALUES('','" & lbl_vendor.Text & "','','" & receivedDate.Text & "',' ','" & cmb_warehouse.Text & "','" & txt_whcode.Text & "','" & txt_code.Text & "','" & txt_ID.text & "','" & txt_model.Text & "','" & txt_descrip.Text & "','" & txt_color.Text & "','" & txt_brand.Text & "','" & txt_ChassisNo.Text & "','" & txt_EngineNo.Text & "','" & txt_keynumber.Text & "','LSA','0.00','0.00','0.00','" & txt_uniPrice.Text & "','" & lbl_vendorCode.Text & "','0','" & class_Variables.sUserName & "')"
        '    i = .ExecuteNonQuery
        '    .CommandText = "UPDATE item_Details set IfExist='0',inventoryStatus='LSA',transactiondate='" & receivedDate.Text & "' WHERE code LIKE '" & txt_code.Text & "' AND id LIKE '" & txt_ID.text & "'"
        '    i = .ExecuteNonQuery
        'End With
        'If i > 0 Then
        '    MsgBox("Command completed successfully!", vbInformation, "webSources")
        'End If
    End Sub

    private sub cmb_financed_Click(sender As System.Object, e As System.EventArgs) Handles cmb_financed.Click
        If MsgBox("Please review and press OK to proceed. " & vbCrLf & "Press No to cancel transaction.", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then
            SoldViaFinancing()
            searchInventory()
            clearItems()
        Else
            MsgBox("Transaction Cancelled", vbInformation, "webSources")
        End If
    End Sub

    private sub cmd_redeem_Click(sender As System.Object, e As System.EventArgs) Handles cmd_redeem.Click
        If MsgBox("Please review and press OK to proceed. " & vbCrLf & "Press No to cancel transaction.", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then
            SoldViaRedeemption()
            searchInventory()
            clearItems()
        Else
            MsgBox("Transaction Cancelled", vbInformation, "webSources")
        End If
    End Sub

    private sub cmd_assump_Click(sender As System.Object, e As System.EventArgs) Handles cmd_assump.Click
        If MsgBox("Please review and press OK to proceed. " & vbCrLf & "Press No to cancel transaction.", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then
            SoldViaAssumption()
            searchInventory()
            clearItems()
        Else
            MsgBox("Transaction Cancelled", vbInformation, "webSources")
        End If
    End Sub

    private sub cmd_LotSale_Click(sender As System.Object, e As System.EventArgs) Handles cmd_LotSale.Click
        If MsgBox("Please review and press OK to proceed. " & vbCrLf & "Press No to cancel transaction.", vbYesNo, "webMharjun") = MsgBoxResult.Yes Then
            SoldViaLotSale()
            searchInventory()
            clearItems()
        Else
            MsgBox("Transaction Cancelled", vbInformation, "webSources")
        End If
    End Sub

End Class