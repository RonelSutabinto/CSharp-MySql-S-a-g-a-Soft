Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Sales_ShowFreebie

    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Show_SPA_Find_InventoryforSales()
        End If
    End Sub

    Sub Show_SPA_Find_InventoryforSales()
        lv_Parts.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", txt_Search.Text),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "SPA_Find_Freebies")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_Parts.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(mydatareader.Item("PartsNumber").ToString())
                    li.SubItems.Add(mydatareader.Item("PartsName").ToString())
                    li.SubItems.Add(mydatareader.Item("quantity").ToString())
                    li.SubItems.Add(mydatareader.Item("Brand").ToString())
                    li.SubItems.Add(mydatareader.Item("srp").ToString())
                    li.SubItems.Add(mydatareader.Item("priceWOVAT").ToString())
                    li.SubItems.Add(mydatareader.Item("spCostWovat").ToString())
                    li.SubItems.Add(mydatareader.Item("spCostWvat").ToString())
                    li.SubItems.Add(mydatareader.Item("modelCode").ToString())
                    li.SubItems.Add(mydatareader.Item("modelName").ToString())
                    li.SubItems.Add(mydatareader.Item("ReceivingBranch").ToString())
                    li.SubItems.Add(mydatareader.Item("ID").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub lv_Parts_DoubleClick(sender As Object, e As EventArgs) Handles lv_Parts.DoubleClick
        txt_ID.Text = lv_Parts.SelectedItems.Item(0).SubItems(0).Text
        txt_PartsNumber.Text = lv_Parts.SelectedItems.Item(0).SubItems(1).Text
        txt_PartsName.Text = lv_Parts.SelectedItems.Item(0).SubItems(2).Text
        txt_Quantity.Value = "1"
    End Sub

    Private Sub savebtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles savebtn.ItemClick
        If MsgBox("Do you want to add another Frebbie?", vbYesNo, Application.CompanyName) = MsgBoxResult.No Then
            Dim lii As ListViewItem = IS_SALES_Release.lv_Freebie.Items.Add(txt_ID.Text)
            lii.SubItems.Add(txt_PartsNumber.Text)
            lii.SubItems.Add(txt_PartsName.Text)
            lii.SubItems.Add(txt_Quantity.Value)
            Me.Close()
        Else
            Dim lii As ListViewItem = IS_SALES_Release.lv_Freebie.Items.Add(txt_ID.Text)
            lii.SubItems.Add(txt_PartsNumber.Text)
            lii.SubItems.Add(txt_PartsName.Text)
            lii.SubItems.Add(txt_Quantity.Value)

            txt_ID.Text = String.Empty
            txt_PartsNumber.Text = String.Empty
            txt_PartsName.Text = String.Empty
            txt_Quantity.Value = 0
        End If
    End Sub
End Class