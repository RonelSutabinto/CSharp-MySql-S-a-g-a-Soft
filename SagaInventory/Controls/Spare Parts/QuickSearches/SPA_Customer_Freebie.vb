Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class SPA_Customer_Freebie

    Sub mg_ShowCIFKey()
        lv_Customer.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamQuickText", txt_Search.Text),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_ShowCustomerFreebie")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_Customer.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("LedgerSetNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountName").ToString())
                    li.SubItems.Add(myDataReader.Item("AccountAddress").ToString())
                    li.SubItems.Add(myDataReader.Item("DateGranted").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            mg_ShowCIFKey()
        End If
    End Sub

    Private Sub lv_Customer_DoubleClick(sender As Object, e As EventArgs) Handles lv_Customer.DoubleClick
        SPA_Sales.txt_CustName.Text = lv_Customer.SelectedItems.Item(0).SubItems(3).Text()
        SPA_Sales.txt_Address.Text = lv_Customer.SelectedItems.Item(0).SubItems(4).Text()
        SPA_Sales.lbl_AccountNumber.Text = lv_Customer.SelectedItems.Item(0).SubItems(1).Text()
        SPA_Sales.lbl_LedgerSetNumber.Text = lv_Customer.SelectedItems.Item(0).SubItems(2).Text()
        SPA_Sales.lbl_AccountNumber.Visible = True
        SPA_Sales.lbl_LedgerSetNumber.Visible = True
        Me.Close()
    End Sub

End Class