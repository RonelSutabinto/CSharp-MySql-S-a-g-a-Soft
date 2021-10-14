Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Sales_FindCust

    private sub IS_Sales_FindCust_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ShowAllCust()
    End Sub

    private sub QuickSearchshowAllCust()
        LvieWSearchCust.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamQuickText", QuickSearch.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowCIFAccounts_Quick_find")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LvieWSearchCust.Items.Add(myDataReader.Item("CIFKey").ToString())
                    li.SubItems.Add(myDataReader.Item("FullName").ToString())
                    li.SubItems.Add(myDataReader.Item("Address").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub showAllCust()
        LvieWSearchCust.Items.Clear()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowCIFAccounts")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LvieWSearchCust.Items.Add(myDataReader.Item("CIFKey").ToString())
                    li.SubItems.Add(myDataReader.Item("FullName").ToString())
                    li.SubItems.Add(myDataReader.Item("Address").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub LvieWSearchCust_DoubleClick(sender As Object, e As System.EventArgs) Handles LvieWSearchCust.DoubleClick
        If Me.Text = "RELEASE" Then
            IS_SALES_Release.txt_cifKey.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(0).Text
            IS_SALES_Release.txt_cust.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(1).Text
            IS_SALES_Release.txt_address.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(2).Text
            Me.Visible = False
        ElseIf Me.Text = "TRANSACTIONSCASHIERING" Then
            Cashiering_Transaction.txt_cust.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(1).Text
            Cashiering_Transaction.txt_cifkey.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(0).Text
            Cashiering_Transaction.txt_address.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(2).Text
            Me.Visible = False
        ElseIf Me.Text = "ERRORCORRECT-CASHIERING" Then
            Error_Correct_Cashiering.txt_cust.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(1).Text
            Error_Correct_Cashiering.txt_cifkey.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(0).Text
            Error_Correct_Cashiering.txt_address.Text = LvieWSearchCust.SelectedItems.Item(0).SubItems(2).Text
            Me.Visible = False
        End If

    End Sub

    private sub QuickSearch_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles QuickSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            QuickSearchshowAllCust()
        End If
    End Sub
End Class