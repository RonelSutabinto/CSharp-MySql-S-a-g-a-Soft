Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class main_mc_price
    Private Sub main_mc_price_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showUnitPrice()
    End Sub

    Sub showUnitPrice()
        Dim Parameters As SqlParameter() = {}

        LViewShowModel.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowUnitPrice")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewShowModel.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(myDataReader.Item("branddesc").ToString())
                    li.SubItems.Add(myDataReader.Item("modeldesc").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("cod"), "##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("lcp"), "##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("aoc"), "##0.00"))
                    li.SubItems.Add(Format(myDataReader.Item("rebates"), "##0.00"))
                Loop
            End If
        End Using
    End Sub

    Sub UpdatePrice()
        LViewShowModel.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamCode", txt_id.Text),
            New SqlParameter("@ParamLCP", txt_lcp.Text),
            New SqlParameter("@ParamCOD", txt_cod.Text),
            New SqlParameter("@ParamAOC", txt_aoc.Text),
            New SqlParameter("@ParamRebates", txt_rebates.Text),
            New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamTransactionDate", MainMenu.statusBrCode.Caption)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_UpdatePrice", "Update Price")
    End Sub

    Private Sub LViewShowModel_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewShowModel.DoubleClick
        txt_id.Text = LViewShowModel.SelectedItems.Item(0).SubItems(0).Text
        txt_brand.Text = LViewShowModel.SelectedItems.Item(0).SubItems(1).Text
        txt_model.Text = LViewShowModel.SelectedItems.Item(0).SubItems(2).Text
        txt_cod.Text = LViewShowModel.SelectedItems.Item(0).SubItems(3).Text
        txt_lcp.Text = LViewShowModel.SelectedItems.Item(0).SubItems(4).Text
        txt_aoc.Text = LViewShowModel.SelectedItems.Item(0).SubItems(5).Text
        txt_rebates.Text = LViewShowModel.SelectedItems.Item(0).SubItems(6).Text
    End Sub

    Sub ClearFields()
        txt_id.Text = String.Empty
        txt_brand.Text = String.Empty
        txt_model.Text = String.Empty
        txt_cod.Text = String.Empty
        txt_lcp.Text = String.Empty
        txt_aoc.Text = String.Empty
        txt_rebates.Text = String.Empty
    End Sub

    Private Sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        UpdatePrice()
        showUnitPrice()
        ClearFields()
    End Sub

End Class