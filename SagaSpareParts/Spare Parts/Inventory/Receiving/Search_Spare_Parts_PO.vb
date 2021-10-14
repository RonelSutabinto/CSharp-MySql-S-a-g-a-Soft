Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Search_Spare_Parts_PO
    Private Sub lvParts_DoubleClick(sender As Object, e As EventArgs) Handles lvParts.DoubleClick
        Spare_Parts_Add.txt_PartsNumber.Text = lvParts.SelectedItems.Item(0).SubItems(0).Text()
        Spare_Parts_Add.lbl_Total1.Text = SPA_Receiving.lbl_SubTotal.Text
        Spare_Parts_Add.Find_Spare_Parts()
        Spare_Parts_Add.txt_PartsNumber.Focus()
        Spare_Parts_Add.Total()
        Me.Close()
        Spare_Parts_Add.ShowDialog()
    End Sub

    Sub mg_Show_Spare_Parts_PO()
        lvParts.Items.Clear()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamQuickSearch", txt_Search.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.spaSQLConnection, Parameters, "SPA_Show_master")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lvParts.Items.Add(myDataReader.Item("partsNumber").ToString())
                    li.SubItems.Add(mydatareader.Item("partsName").ToString())
                    li.SubItems.Add(mydatareader.Item("SuperCeeding").ToString())
                    li.SubItems.Add(mydatareader.Item("brand").ToString())
                    li.SubItems.Add(mydatareader.Item("srp").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            mg_Show_Spare_Parts_PO()
            lbl_Parts_No.Text = lvParts.Items.Count
        End If
    End Sub

End Class