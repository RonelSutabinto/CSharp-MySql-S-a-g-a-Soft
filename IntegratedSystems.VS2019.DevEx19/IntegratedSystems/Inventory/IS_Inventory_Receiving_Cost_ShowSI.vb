Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_Receiving_Cost_ShowSI
    private sub IS_Inventory_Receiving_Cost_ShowSI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        mg_ShowApprovedSI()
    End Sub

    private sub mg_ShowApprovedSIQuickSearch()
        LViewList.Items.Clear()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", QuickSearch.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowSIQuickSearch")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno"))
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString)
                    li.SubItems.Add(myDataReader.Item("InventoryStatus").ToString)
                    li.SubItems.Add(myDataReader.Item("SourceEvent").ToString)
                    li.SubItems.Add(Format(myDataReader.Item("datereceived"), "MMM dd, yyyy"))
                Loop
            End If
        End Using
    End Sub

    private sub mg_ShowApprovedSI()
        LViewList.Items.Clear()
        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowSI")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno"))
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString)
                    li.SubItems.Add(myDataReader.Item("InventoryStatus").ToString)
                    li.SubItems.Add(myDataReader.Item("SourceEvent").ToString)
                    li.SubItems.Add(Format(myDataReader.Item("datereceived"), "MMM dd, yyyy"))
                Loop
            End If
        End Using
    End Sub

    private sub LViewList_DoubleClick(sender As Object, e As System.EventArgs) Handles LViewList.DoubleClick
        txt_accountno.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
        dateGrant.Value = LViewList.SelectedItems.Item(0).SubItems(5).Text
        mg_ShowApprovedSIDetails()
        LViewEvent()
        Me.Close()
    End Sub

    private sub mg_ShowApprovedSIDetails()
        LViewList.Items.Clear()
        IS_Inventory_Receiving_Cost.LViewItems.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@Paramrefno", txt_accountno.Text),
            New SqlParameter("@Paramdatereceived", dateGrant.Value)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowApprovedSIDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = IS_Inventory_Receiving_Cost.LViewItems.Items.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("model").ToString())
                    li.SubItems.Add(myDataReader.Item("description").ToString())
                    li.SubItems.Add(myDataReader.Item("color").ToString())
                    li.SubItems.Add(myDataReader.Item("brand").ToString())
                    li.SubItems.Add(myDataReader.Item("ChassisNo").ToString())
                    li.SubItems.Add(myDataReader.Item("EngineNo").ToString())
                    li.SubItems.Add(myDataReader.Item("unitcost").ToString())
                    li.SubItems.Add(myDataReader.Item("vatamt").ToString())
                    li.SubItems.Add(myDataReader.Item("totalcost").ToString())
                    li.SubItems.Add(myDataReader.Item("unitprice").ToString())
                    li.SubItems.Add(myDataReader.Item("keyno").ToString())
                    li.SubItems.Add(myDataReader.Item("note").ToString())

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

    private sub LViewEvent()
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

    private sub QuickSearch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles QuickSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            mg_ShowApprovedSIQuickSearch()
        End If
    End Sub
End Class