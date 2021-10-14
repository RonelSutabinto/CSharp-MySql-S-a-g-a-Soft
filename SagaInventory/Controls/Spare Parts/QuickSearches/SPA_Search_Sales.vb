Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class SPA_Search_Sales
    Sub Show_SPA_Find_InventoryforSales()
        lv_Parts.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", txt_Search.Text),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "SPA_Find_InventoryforSales")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_Parts.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsName").ToString())
                    li.SubItems.Add(myDataReader.Item("quantity").ToString())
                    li.SubItems.Add(myDataReader.Item("Brand").ToString())
                    li.SubItems.Add(myDataReader.Item("srp").ToString())
                    li.SubItems.Add(myDataReader.Item("priceWOVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("spCostWovat").ToString())
                    li.SubItems.Add(myDataReader.Item("spCostWvat").ToString())
                    li.SubItems.Add(myDataReader.Item("modelCode").ToString())
                    li.SubItems.Add(myDataReader.Item("modelName").ToString())
                    li.SubItems.Add(myDataReader.Item("ReceivingBranch").ToString())
                    li.SubItems.Add(myDataReader.Item("ID").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Show_SPA_Find_InventoryforSales()
        End If
    End Sub

    Private Sub lv_Parts_DoubleClick(sender As Object, e As EventArgs) Handles lv_Parts.DoubleClick
        If txt_Quantity.Text = "0" Then
            MsgBox("DILI PWEDE MA-ADD ANG SPARE PARTS, KAY ZERO(0) ANG QUANTITY.", vbCritical)
        Else
            SPA_InputQuantity.txt_ID.Text = lv_Parts.SelectedItems.Item(0).SubItems(0).Text()
            SPA_InputQuantity.txt_TotalAmount.Text = lv_Parts.SelectedItems.Item(0).SubItems(5).Text()
            SPA_InputQuantity.Find_Spare_Parts()
            SPA_InputQuantity.Total()
            SPA_InputQuantity.Show()
            SPA_InputQuantity.txt_Discount.Focus.Equals(True)
            SPA_InputQuantity.txt_Quantity1.Enabled.Equals(False)
        End If

    End Sub

    Private Sub lv_Parts_Click(sender As Object, e As EventArgs) Handles lv_Parts.Click
        txt_ID.Text = lv_Parts.SelectedItems.Item(0).SubItems(0).Text()
        txt_Quantity1.Text = lv_Parts.SelectedItems.Item(0).SubItems(3).Text()

        If txt_Quantity1.Text = "0" Then
            Cleartxt()
        End If
    End Sub

    Sub Cleartxt()
        txt_PartsNumber.Text = String.Empty
        txt_PartsName.Text = String.Empty
        txt_Quantity.Text = String.Empty
        txt_BrCode.Text = String.Empty
        txt_Price.Text = String.Empty
        txt_prevID.Text = String.Empty
        txt_ID.Text = String.Empty
    End Sub

    Sub Find_Spare_Parts()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamID", txt_ID.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "SPA_Find_PartsNumber")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_PartsNumber.Text = myDataReader("PartsNumber").ToString()
                txt_PartsName.Text = myDataReader("PartsName").ToString()
                txt_Quantity.Text = myDataReader("Quantity").ToString()
                txt_BrCode.Text = myDataReader("ReceivingBranch").ToString()
                If SPA_Sales.cmb_Pricing.Text = "1" Then
                    txt_Price.Text = myDataReader("srp").ToString()
                ElseIf SPA_Sales.cmb_Pricing.Text = "2" Then
                    txt_Price.Text = myDataReader("PriceWOVAT").ToString()
                ElseIf SPA_Sales.cmb_Pricing.Text = "3" Then
                    txt_Price.Text = myDataReader("spCostWOVAT").ToString()
                ElseIf SPA_Sales.cmb_Pricing.Text = "4" Then
                    txt_Price.Text = myDataReader("spCostWVAT").ToString()
                End If
                txt_prevID.Text = myDataReader("ID").ToString()
            End If
        End Using
    End Sub

    Sub Total()
        If txt_Quantity.Text = String.Empty Then
            txt_Quantity.Text = "0"
        End If
        txt_SubTotal.Text = Val(txt_Price.Text) * Val(txt_Quantity.Text)
    End Sub

    Private Sub txt_ID_TextChanged(sender As Object, e As EventArgs) Handles txt_ID.TextChanged
        Find_Spare_Parts()
        Total()
    End Sub
End Class