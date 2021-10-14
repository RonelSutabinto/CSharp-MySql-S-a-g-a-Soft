Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Sales_ShowFreebie

    private sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Show_SPA_Find_InventoryforSales()
        End If
    End Sub

    private sub Show_SPA_Find_InventoryforSales()
        lv_Parts.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", txt_Search.Text),
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "SPA_Find_Freebies")
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

    private sub lv_Parts_DoubleClick(sender As Object, e As EventArgs) Handles lv_Parts.DoubleClick
        txt_ID.text = lv_Parts.SelectedItems.Item(0).SubItems(0).Text
        txt_PartsNumber.Text = lv_Parts.SelectedItems.Item(0).SubItems(1).Text
        txt_PartsName.Text = lv_Parts.SelectedItems.Item(0).SubItems(2).Text
        txt_Quantity.Value = "1"
    End Sub

    private sub savebtn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles savebtn.ItemClick
        If MsgBox("Do you want to add another Frebbie?", vbYesNo, Application.CompanyName) = MsgBoxResult.No Then
            Dim lii As ListViewItem = IS_SALES_Release.lv_Freebie.Items.Add(txt_ID.text)
            lii.SubItems.Add(txt_PartsNumber.Text)
            lii.SubItems.Add(txt_PartsName.Text)
            lii.SubItems.Add(txt_Quantity.Value)
            Me.Close()
        Else
            Dim lii As ListViewItem = IS_SALES_Release.lv_Freebie.Items.Add(txt_ID.text)
            lii.SubItems.Add(txt_PartsNumber.Text)
            lii.SubItems.Add(txt_PartsName.Text)
            lii.SubItems.Add(txt_Quantity.Value)

            txt_ID.text = String.Empty
            txt_PartsNumber.Text = String.Empty
            txt_PartsName.Text = String.Empty
            txt_Quantity.Value = 0
        End If
    End Sub

    private sub IS_Sales_ShowFreebie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class