Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class IS_Sales_SP_temp

    Private Sub IS_Sales_SP_temp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSP()
        quickSearch.Text = String.Empty
        LViewItems.Items.Clear()
    End Sub

    Sub LViewRowCnt()
        Dim TotalCount As Integer

        TotalCount = 0
        Dim TempNode As ListViewItem
        ' Dim TempUnitCost, TempVATAmt, TempUnitPrice, TempGrandTotal As Double

        '  If IS_Inventory_item_add.eventForm.Text = "Receiving" Then
        For Each TempNode In LViewItems.Items
            TotalCount = TotalCount + 1
        Next

        txt_rows.Text = TotalCount
    End Sub

    Sub LoadSP()
        LViewItems.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamQuickText", quickSearch.Text),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "sp_Load")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItems.Items.Add(myDataReader.Item("PartsNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsName").ToString())
                    li.SubItems.Add(myDataReader.Item("srp").ToString())
                    li.SubItems.Add(myDataReader.Item("Quantity").ToString())
                    li.SubItems.Add(myDataReader.Item("ID").ToString())
                Loop
            End If
        End Using

        LViewRowCnt()
    End Sub

    Private Sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamPartsNumber", txt_PartsNumber.Text),
            New SqlParameter("@ParamPartsName", txt_PartsName.Text),
            New SqlParameter("@ParamQuantity", txt_quantity.Value),
            New SqlParameter("@ParamRemarks", txt_remarks.Text),
            New SqlParameter("@ParamTransactedBy", class_Variables.sUserName),
            New SqlParameter("@ParamTransactionDate", Now),
            New SqlParameter("@ParamPostingDate", Now),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }

        class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "Spare_Parts_Subtract", "Post Payment", txt_PartsNumber.Text)

        LoadSP()
    End Sub

    Private Sub quickSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles quickSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadSP()
        End If
    End Sub

    Private Sub LViewItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewItems.DoubleClick
        txt_PartsNumber.Text = LViewItems.SelectedItems.Item(0).SubItems(0).Text
        txt_PartsName.Text = LViewItems.SelectedItems.Item(0).SubItems(1).Text
        txt_ID.Text = LViewItems.SelectedItems.Item(0).SubItems(4).Text
    End Sub
End Class