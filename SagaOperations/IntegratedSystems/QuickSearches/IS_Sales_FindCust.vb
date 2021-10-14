Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Sales_FindCust

    Private Sub IS_Sales_FindCust_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ShowAllCust()
    End Sub

    Sub QuickSearchshowAllCust()
        LvieWSearchCust.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamQuickText", QuickSearch.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowCIFAccounts_Quick_find")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LvieWSearchCust.Items.Add(myDataReader.Item("CIFKey").ToString())
                    li.SubItems.Add(myDataReader.Item("FullName").ToString())
                    li.SubItems.Add(myDataReader.Item("Address").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub showAllCust()
        LvieWSearchCust.Items.Clear()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowCIFAccounts")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LvieWSearchCust.Items.Add(myDataReader.Item("CIFKey").ToString())
                    li.SubItems.Add(myDataReader.Item("FullName").ToString())
                    li.SubItems.Add(myDataReader.Item("Address").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub LvieWSearchCust_DoubleClick(sender As Object, e As System.EventArgs) Handles LvieWSearchCust.DoubleClick
        If Me.Text = "RELEASE" Then
            IS_SALES_Release.txt_cifKey.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(0).Text
            IS_SALES_Release.txt_cust.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(1).Text
            IS_SALES_Release.txt_address.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(2).Text
            Me.Visible = False
        ElseIf Me.Text = "TRANSACTIONSCASHIERING" Then
            IS_Cashiering_Transactions.txt_cust.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(1).Text
            IS_Cashiering_Transactions.txt_cifkey.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(0).Text
            IS_Cashiering_Transactions.txt_address.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(2).Text
            Me.Visible = False
        ElseIf Me.Text = "ERRORCORRECT-CASHIERING" Then
            admin_errorcorrectcashiering.txt_cust.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(1).Text
            admin_errorcorrectcashiering.txt_cifkey.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(0).Text
            admin_errorcorrectcashiering.txt_address.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(2).Text
            Me.Visible = False
        End If

    End Sub

    Private Sub QuickSearch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles QuickSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            QuickSearchshowAllCust()
        End If
    End Sub
End Class