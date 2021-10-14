Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_Receiving_Cost_ADDCOST
    Private Sub cmb_save_Click(sender As System.Object, e As System.EventArgs) Handles cmb_save.Click

        mg_ModifyCost()

        mg_ShowApprovedSIDetails()
        LViewEvent()
        mg_ModifyCostMaster()
        Me.Close()
    End Sub

    Sub LViewEvent()
        Dim TotalunitCost As Double = 0
        Dim TotalVATAmt As Double = 0
        Dim GrandTotal As Double = 0
        Dim TotalUnitPrice As Double
        Dim TotalCount As Double = 0

        Dim TempNode As ListViewItem
        Dim TempUnitCost, TempVATAmt, TempUnitPrice, TempGrandTotal As Double

        For Each TempNode In IS_Inventory_Receiving_Cost.LViewItems.Items
            If Double.TryParse(TempNode.SubItems.Item(7).Text, TempUnitCost) Then
                TotalunitCost += TempUnitCost
            End If
            If Double.TryParse(TempNode.SubItems.Item(8).Text, TempVATAmt) Then
                TotalVATAmt += TempVATAmt
            End If
            If Double.TryParse(TempNode.SubItems.Item(9).Text, TempGrandTotal) Then
                GrandTotal += TempGrandTotal
            End If
            If Double.TryParse(TempNode.SubItems.Item(10).Text, TempUnitPrice) Then
                TotalUnitPrice += TempUnitPrice
            End If
            TotalCount = TotalCount + 1
        Next
        IS_Inventory_Receiving_Cost.lbl_tot_unit.Text = Format(TotalunitCost, "#,##0.00")
        IS_Inventory_Receiving_Cost.lbl_totVatAmt.Text = Format(TotalVATAmt, "#,##0.00")
        IS_Inventory_Receiving_Cost.lbl_grandTotal.Text = Format(GrandTotal, "#,##0.00")
        IS_Inventory_Receiving_Cost.lbl_totUnitPrice.Text = Format(TotalUnitPrice, "#,##0.00")
        IS_Inventory_Receiving_Cost.lbl_count.Text = TotalCount
    End Sub

    Sub mg_ShowApprovedSIDetails()
        IS_Inventory_Receiving_Cost.LViewItems.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@Paramrefno", IS_Inventory_Receiving_Cost.txt_refno.Text),
            New SqlParameter("@Paramdatereceived", IS_Inventory_Receiving_Cost.receivedDate.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowApprovedSIDetails"
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = IS_Inventory_Receiving_Cost.LViewItems.Items.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(mydatareader.Item("model").ToString())
                    li.SubItems.Add(mydatareader.Item("description").ToString())
                    li.SubItems.Add(mydatareader.Item("color").ToString())
                    li.SubItems.Add(mydatareader.Item("brand").ToString())
                    li.SubItems.Add(mydatareader.Item("chassisno").ToString())
                    li.SubItems.Add(mydatareader.Item("engineno").ToString())
                    li.SubItems.Add(mydatareader.Item("unitcost").ToString())
                    li.SubItems.Add(mydatareader.Item("vatamt").ToString())
                    li.SubItems.Add(mydatareader.Item("totalcost").ToString())
                    li.SubItems.Add(mydatareader.Item("unitprice").ToString())
                    li.SubItems.Add(mydatareader.Item("keyno").ToString())
                    li.SubItems.Add(mydatareader.Item("note").ToString())
                    IS_Inventory_Receiving_Cost.lbl_vendor.Text = myDataReader("vendor").ToString()
                    IS_Inventory_Receiving_Cost.txt_refno.Text = myDataReader("refno").ToString()
                    IS_Inventory_Receiving_Cost.txt_pono.Text = myDataReader("pono").ToString()
                    IS_Inventory_Receiving_Cost.txt_notes.Text = myDataReader("note").ToString()
                    IS_Inventory_Receiving_Cost.txt_remarks.Text = myDataReader("remarks").ToString()
                    IS_Inventory_Receiving_Cost.txt_invenStat.Text = myDataReader("inventorystatus").ToString()
                    IS_Inventory_Receiving_Cost.txt_approver.Text = myDataReader("approver").ToString()
                    IS_Inventory_Receiving_Cost.txt_TransCode.Text = myDataReader("transcode").ToString()
                    IS_Inventory_Receiving_Cost.receivedDate.Value = myDataReader("datereceived").ToString()
                    IS_Inventory_Receiving_Cost.txt_whcode.Text = myDataReader("whcode").ToString()
                    IS_Inventory_Receiving_Cost.cmb_warehouse.Text = myDataReader("whcategory").ToString()
                Loop
            End If
        End Using
    End Sub

    Sub mg_ModifyCost()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamEngineNo", txt_engineNo.Text),
            New SqlParameter("@ParamChassisNo", txt_chassisNo.Text),
            New SqlParameter("@ParamUnitCost", txt_unitcost.Text),
            New SqlParameter("@ParamVATPrctg", num_vat.Text),
            New SqlParameter("@ParamVATAmt", txt_vatamount.Text),
            New SqlParameter("@ParamTotalCost", txt_totcost.Text),
            New SqlParameter("@ParamUnitPrice", txt_uniPrice.Text),
            New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_ModifyCost", "Modify Unit Cost", txt_engineNo.Text)
    End Sub

    Sub mg_ModifyCostMaster()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamRefno", IS_Inventory_Receiving_Cost.txt_refno.Text),
            New SqlParameter("@ParamPono", IS_Inventory_Receiving_Cost.txt_pono.Text),
            New SqlParameter("@ParamUnitcost", CDec(IS_Inventory_Receiving_Cost.lbl_tot_unit.Text)),
            New SqlParameter("@ParamVatamt", CDec(IS_Inventory_Receiving_Cost.lbl_totVatAmt.Text)),
            New SqlParameter("@ParamTotalcost", CDec(IS_Inventory_Receiving_Cost.lbl_grandTotal.Text)),
            New SqlParameter("@ParamUnitprice", CDec(IS_Inventory_Receiving_Cost.lbl_totUnitPrice.Text)),
            New SqlParameter("@ParamUnitCount", IS_Inventory_Receiving_Cost.lbl_count.Text),
            New SqlParameter("@Paramtransactedby", MainMenu.App_User_Name.Caption)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_ModifyCostMaster", "Modify Total Cost", IS_Inventory_Receiving_Cost.txt_refno.Text)
    End Sub

    Private Sub txt_unitcost_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_unitcost.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_unitcost.Text = String.Empty Then
            Else
                ComputeTotalCost()
            End If
        End If
    End Sub

    Private Sub txt_unitcost_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_unitcost.TextChanged

    End Sub

    Sub ComputeTotalCost()
        txt_vatamount.Text = Format((Val(txt_unitcost.Text) * Val(num_vat.Value)) / 100, "####.##")
        txt_totcost.Text = Format(Val(txt_unitcost.Text) + txt_vatamount.Text, "####.##")
    End Sub
End Class