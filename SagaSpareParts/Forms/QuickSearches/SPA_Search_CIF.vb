Imports System.Data.SqlClient
Imports MyClassLibrary.Classes

Public Class SPA_Search_CIF

    '    Sub mg_ShowCIFKey()

    '        lv_CIF.Items.Clear()
    '        Dim cmd As New SqlCommand

    '        Dim rs As SqlDataReader

    '        cmd.CommandText = "mg_ShowCIFAccounts_Quick_find"
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = SPConnectSpareParts
    '        cmd.Parameters.AddWithValue("@ParamQuickText", txt_Search.Text)

    '        SPConnectSpareParts.Open()

    '        rs = cmd.ExecuteReader()
    '        Data Is accessible through the DataReader object here.
    '        Do While rs.Read()
    '            Dim li As ListViewItem = lv_CIF.Items.Add(rs.Item("FullName").ToString())
    '            li.SubItems.Add(rs.Item("Address").ToString())
    '            li.SubItems.Add(rs.Item("CIFKey").ToString())
    '        Loop
    '        rs.Close()
    '        SPConnectSpareParts.Close()
    '        GoTo outs1

    'out:    MsgBox(Err.Description)
    '        rs.Close()
    '        GoTo outs1

    'outs:
    'outs1:
    '    End Sub
    Private Sub Data_Load()

        Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ParamQuickText", txt_Search.Text)
            }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, gridView, "mg_ShowCIFAccounts_Quick_find", "Customer Information")

        gridView.ClearSorting()
        colFullName.SortIndex = 0
        colFullName.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending

    End Sub

    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Data_Load()
            'If gridView.Columns.Count() < 1 OrElse gridView.Columns(0).ColumnEdit Is Nothing Then
            '    txt_Search.Width = 611
            '    btn_Add.Visible = True
            'Else
            '    txt_Search.Width = 679
            '    btn_Add.Visible = False
            'End If
        End If
    End Sub

    '    Private Sub lv_CIF_DoubleClick(sender As Object, e As EventArgs) Handles lv_CIF.DoubleClick
    '        SPA_Sales.txt_CustName.EditValue = lv_CIF.SelectedItems.Item(0).SubItems(0).Text()
    '        SPA_Sales.txt_Address.EditValue = lv_CIF.SelectedItems.Item(0).SubItems(1).Text()
    '        lbl_Type.Text = "SALES"
    '        'Me.Hide()
    '    End Sub

    '    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
    '        SPA_AddCIF.ShowDialog()
    '        Me.Close()
    '    End Sub
    Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
        Dim frm As SPA_Sales = New SPA_Sales()
        If e.Clicks.Equals(2) Then
            frm.txt_CustName.EditValue = gridView.GetFocusedRowCellDisplayText("FullName")
            frm.txt_Address.EditValue = gridView.GetFocusedRowCellDisplayText("Address")
            frm.txt_Custname1.Text = gridView.GetFocusedRowCellDisplayText("FullName")
            frm.txt_Address1.Text = gridView.GetFocusedRowCellDisplayText("Address")
            Me.Close()
        End If
    End Sub


End Class