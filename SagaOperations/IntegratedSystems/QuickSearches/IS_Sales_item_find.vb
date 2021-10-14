Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Sales_item_find
    Private Sub IS_Sales_item_find_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        searchInventory()
    End Sub

    Sub searchInventory()
        LViewItemsOutgoing.Items.Clear()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamwhCode", IS_SALES_Release.cmb_warehouse.Text),
            New SqlParameter("@ParamModelCode", IS_SALES_Release.txt_modelCode.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_IS_Sales_item_find")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItemsOutgoing.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("model").ToString())
                    li.SubItems.Add(myDataReader.Item("description").ToString())
                    li.SubItems.Add(myDataReader.Item("color").ToString())
                    li.SubItems.Add(myDataReader.Item("brand").ToString())
                    li.SubItems.Add(myDataReader.Item("engineno").ToString())
                    li.SubItems.Add(myDataReader.Item("chassisno").ToString())
                    li.SubItems.Add(myDataReader.Item("unitcost").ToString())
                    li.SubItems.Add(myDataReader.Item("vatamt").ToString())
                    li.SubItems.Add(myDataReader.Item("totalcost").ToString())
                    li.SubItems.Add(myDataReader.Item("unitprice").ToString())
                    li.SubItems.Add(myDataReader.Item("keyno").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub QuicksearchInventory()
        LViewItemsOutgoing.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamwhCode", IS_SALES_Release.cmb_warehouse.Text),
            New SqlParameter("@ParamQuickText", quickSearch.Text),
            New SqlParameter("@ParamModel", IS_SALES_Release.cmb_model.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_IS_Sales_item_Quick_find")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItemsOutgoing.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("code").ToString())
                    li.SubItems.Add(myDataReader.Item("model").ToString())
                    li.SubItems.Add(myDataReader.Item("description").ToString())
                    li.SubItems.Add(myDataReader.Item("color").ToString())
                    li.SubItems.Add(myDataReader.Item("brand").ToString())
                    li.SubItems.Add(myDataReader.Item("engineno").ToString())
                    li.SubItems.Add(myDataReader.Item("chassisno").ToString())
                    li.SubItems.Add(myDataReader.Item("unitcost").ToString())
                    li.SubItems.Add(myDataReader.Item("vatamt").ToString())
                    li.SubItems.Add(myDataReader.Item("totalcost").ToString())
                    li.SubItems.Add(myDataReader.Item("unitprice").ToString())
                    li.SubItems.Add(myDataReader.Item("keyno").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub ShowodelPrice()
        LViewItemsOutgoing.Items.Clear()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@Paramid", lbl_id.Text),
            New SqlParameter("@ParamTotalDP", IS_SALES_Release.txt_DP.Text),
            New SqlParameter("@ParamSalesType", IS_SALES_Release.cmb_SalesType.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowModelPrice")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                IS_SALES_Release.txt_code.Text = myDataReader("code").ToString()
                IS_SALES_Release.txt_model.Text = myDataReader("model").ToString()
                IS_SALES_Release.txt_descrip.Text = myDataReader("description").ToString()
                IS_SALES_Release.txt_color.Text = myDataReader("color").ToString()
                IS_SALES_Release.txt_brand.Text = myDataReader("brand").ToString()
                IS_SALES_Release.txt_engineNo.Text = myDataReader("engineno").ToString()
                IS_SALES_Release.txt_chassisNo.Text = myDataReader("chassisno").ToString()
                IS_SALES_Release.txt_keynumber.Text = myDataReader("keyno").ToString()
                IS_SALES_Release.txt_id.Text = myDataReader("id").ToString()
                IS_SALES_Release.txt_COD.Text = Format(Val(myDataReader.Item("cod").ToString()), "###0.00")
                IS_SALES_Release.txt_LCP.Text = Format(Val(myDataReader.Item("lcp").ToString()), "##0.00")
                IS_SALES_Release.txt_FinancedAmt.Text = Format(Val(myDataReader.Item("FinancedAmt").ToString()), "##0.00")
                IS_SALES_Release.txt_rebates.Text = Format(Val(myDataReader.Item("Rebates").ToString()), "##0.00")
                IS_SALES_Release.txt_aoc.Text = Format(Val(myDataReader.Item("aoc").ToString()), "##0.00")
            End If
        End Using
    End Sub

    Private Sub quickSearch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles quickSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            QuicksearchInventory()
        End If
    End Sub

    Private Sub LViewItemsOutgoing_DoubleClick(sender As Object, e As System.EventArgs) Handles LViewItemsOutgoing.DoubleClick
        lbl_id.Text = LViewItemsOutgoing.SelectedItems.Item(0).SubItems(0).Text
        ShowodelPrice()
        Me.Close()
    End Sub
End Class