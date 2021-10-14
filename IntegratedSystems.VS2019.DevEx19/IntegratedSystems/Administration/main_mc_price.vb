Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class main_mc_price
    private sub main_mc_price_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        showUnitPrice()
    End Sub

    private sub showUnitPrice()
        Dim sqlParameters As SqlParameter() = {}

        LViewShowModel.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowUnitPrice")
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

    private sub UpdatePrice()
        LViewShowModel.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamCode", txt_ID.text),
            New SqlParameter("@ParamLCP", txt_lcp.Text),
            New SqlParameter("@ParamCOD", txt_cod.Text),
            New SqlParameter("@ParamAOC", txt_aoc.Text),
            New SqlParameter("@ParamRebates", txt_rebates.Text),
            New SqlParameter("@ParamTransactedBy", class_Variables.sUserName),
            New SqlParameter("@ParamTransactionDate", class_saga_variables.sbranchcode)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_UpdatePrice", "Update Price")
    End Sub

    private sub LViewShowModel_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewShowModel.DoubleClick
        txt_ID.text = LViewShowModel.SelectedItems.Item(0).SubItems(0).Text
        txt_brand.Text = LViewShowModel.SelectedItems.Item(0).SubItems(1).Text
        txt_model.Text = LViewShowModel.SelectedItems.Item(0).SubItems(2).Text
        txt_cod.Text = LViewShowModel.SelectedItems.Item(0).SubItems(3).Text
        txt_lcp.Text = LViewShowModel.SelectedItems.Item(0).SubItems(4).Text
        txt_aoc.Text = LViewShowModel.SelectedItems.Item(0).SubItems(5).Text
        txt_rebates.Text = LViewShowModel.SelectedItems.Item(0).SubItems(6).Text
    End Sub

    private sub ClearFields()
        txt_ID.text = String.Empty
        txt_brand.Text = String.Empty
        txt_model.Text = String.Empty
        txt_cod.Text = String.Empty
        txt_lcp.Text = String.Empty
        txt_aoc.Text = String.Empty
        txt_rebates.Text = String.Empty
    End Sub

    private sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        UpdatePrice()
        showUnitPrice()
        ClearFields()
    End Sub

End Class