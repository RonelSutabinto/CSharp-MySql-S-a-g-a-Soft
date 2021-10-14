Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Pending
    Sub SPA_Show_Pending_Inventory()
        lvPending.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamMaker", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Show_Pending_Inventory")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lvPending.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(myDataReader.Item("InventoryStatus").ToString())
                    li.SubItems.Add(myDataReader.Item("SourceEvent").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub SPA_Pending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPA_Show_Pending_Inventory()
    End Sub

    Private Sub lvPending_DoubleClick(sender As Object, e As EventArgs) Handles lvPending.DoubleClick
        If txt_Source.Text = "RECEIVING" Then
            SPA_Checker_Approver_Receiving.txt_RefNo.Text = lvPending.SelectedItems.Item(0).SubItems(0).Text()
            SPA_Checker_Approver_Receiving.txt_Source.Text = lvPending.SelectedItems.Item(0).SubItems(4).Text()
            SPA_Checker_Approver_Receiving.lbl_Count.Text = SPA_Checker_Approver_Receiving.lvParts.Items.Count
            SPA_Checker_Approver_Receiving.btn_Approved.Visible = False
            SPA_Checker_Approver_Receiving.Btn_DisApproved.Visible = False
            SPA_Checker_Approver_Receiving.btn_Print.Visible = False
            lvPending.Items.Clear()
            SPA_Checker_Approver_Receiving.ShowDialog()
            Me.Close()
        ElseIf txt_Source.Text = "OUTGOING" Then
            SPA_Checker_Approver_Outgoing.txt_RefNo.Text = lvPending.SelectedItems.Item(0).SubItems(0).Text()
            SPA_Checker_Approver_Outgoing.txt_Source.Text = lvPending.SelectedItems.Item(0).SubItems(4).Text()
            SPA_Checker_Approver_Outgoing.lbl_Count.Text = SPA_Checker_Approver_Outgoing.lvParts.Items.Count
            SPA_Checker_Approver_Outgoing.btn_Approved.Visible = False
            SPA_Checker_Approver_Outgoing.Btn_DisApproved.Visible = False
            SPA_Checker_Approver_Outgoing.btn_Print.Visible = False
            lvPending.Items.Clear()
            SPA_Checker_Approver_Outgoing.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub lvPending_Click(sender As Object, e As EventArgs) Handles lvPending.Click
        txt_Refno.Text = lvPending.SelectedItems.Item(0).SubItems(0).Text()
        txt_Source.Text = lvPending.SelectedItems.Item(0).SubItems(4).Text()
    End Sub

End Class