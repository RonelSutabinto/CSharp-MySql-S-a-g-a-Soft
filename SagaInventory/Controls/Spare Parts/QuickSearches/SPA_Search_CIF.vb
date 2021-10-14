Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Search_CIF
    Sub mg_ShowCIFKey()
        lv_CIF.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamQuickText", txt_Search.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "mg_ShowCIFAccounts_Quick_find")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_CIF.Items.Add(myDataReader.Item("FullName").ToString())
                    li.SubItems.Add(myDataReader.Item("Address").ToString())
                    li.SubItems.Add(myDataReader.Item("CIFKey").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            mg_ShowCIFKey()
            If lv_CIF.Items.Count() < 1 OrElse lv_CIF.Items(0).Text Is Nothing Then
                txt_Search.Width = 611
                btn_Add.Visible = True
            Else
                txt_Search.Width = 679
                btn_Add.Visible = False
            End If
        End If
    End Sub

    Private Sub lv_CIF_DoubleClick(sender As Object, e As EventArgs) Handles lv_CIF.DoubleClick
        If lbl_Type.Text = "SALES" Then
            SPA_Sales.txt_CustName.Text = lv_CIF.SelectedItems.Item(0).SubItems(0).Text()
            SPA_Sales.txt_Address.Text = lv_CIF.SelectedItems.Item(0).SubItems(1).Text()
            Me.Close()
        Else
            SPA_CustDep.txt_Custname.Text = lv_CIF.SelectedItems.Item(0).SubItems(0).Text()
            SPA_CustDep.txt_Address.Text = lv_CIF.SelectedItems.Item(0).SubItems(1).Text()
            SPA_CustDep.txt_CIFKey.Text = lv_CIF.SelectedItems.Item(0).SubItems(2).Text()
            Me.Close()
        End If
        lbl_Type.Text = "SALES"
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        'Customers_Information.ShowDialog()
        Me.Close()
    End Sub

End Class