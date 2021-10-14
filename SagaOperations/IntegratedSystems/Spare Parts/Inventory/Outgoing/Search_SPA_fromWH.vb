Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Search_SPA_fromWH

    Sub mg_Show_Spare_Parts_PO()
        lvParts.Items.Clear()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", txt_Search.Text),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.spaSQLConnection, Parameters, "SPA_Show_WareHouse")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lvParts.Items.Add(myDataReader.Item("id").ToString())
                    li.SubItems.Add(mydatareader.Item("partsNumber").ToString())
                    li.SubItems.Add(mydatareader.Item("partsName").ToString())
                    li.SubItems.Add(mydatareader.Item("Quantity").ToString())
                    li.SubItems.Add(mydatareader.Item("SC_SpareParts").ToString())
                    li.SubItems.Add(mydatareader.Item("brand").ToString())
                    li.SubItems.Add(mydatareader.Item("srp").ToString())
                    li.SubItems.Add(mydatareader.Item("ReceivingBranch").ToString())
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

    Private Sub lvParts_DoubleClick(sender As Object, e As EventArgs) Handles lvParts.DoubleClick
        SPA_Add_Outgoing.txt_ID.Text = lvParts.SelectedItems.Item(0).SubItems(0).Text()
        SPA_Add_Outgoing.txt_PartsNumber.Text = lvParts.SelectedItems.Item(0).SubItems(1).Text()

        SPA_Add_Outgoing.Find_Spare_Parts()
        SPA_Add_Outgoing.txt_PartsNumber.Focus()
        SPA_Add_Outgoing.Total()
        SPA_Add_Outgoing.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub Search_SPA_fromWH_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class