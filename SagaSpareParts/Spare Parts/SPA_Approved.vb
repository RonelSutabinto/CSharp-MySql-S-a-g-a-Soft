Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class SPA_Approved

    Sub SPA_Show_Approved_Inventory()
        lvApproved.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamMaker", class_Variables.sUserName),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Show_Approved_Inventory")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lvApproved.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(myDataReader.Item("InventoryStatus").ToString())
                    li.SubItems.Add(myDataReader.Item("SourceEvent").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub SPA_For_Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPA_Show_Approved_Inventory()
    End Sub

    Private Sub lvApproval_DoubleClick(sender As Object, e As EventArgs) Handles lvApproved.DoubleClick
        If txt_Source.Text = "RECEIVING" Then
            SPA_ReceivingApproved.Show()
            SPA_ReceivingApproved.txt_RefNo.Text = lvApproved.SelectedItems.Item(0).SubItems(0).Text()
            SPA_ReceivingApproved.txt_Source.Text = lvApproved.SelectedItems.Item(0).SubItems(4).Text()
            lvApproved.Items.Clear()
            Me.Close()
        ElseIf txt_Source.Text = "OUTGOING" Then
            SPA_ReceivingApproved.Show()
            SPA_ReceivingApproved.txt_RefNo.Text = lvApproved.SelectedItems.Item(0).SubItems(0).Text()
            SPA_ReceivingApproved.txt_Source.Text = lvApproved.SelectedItems.Item(0).SubItems(4).Text()
            lvApproved.Items.Clear()
            Me.Close()
        End If

    End Sub

    Private Sub btn_Show_Click(sender As Object, e As EventArgs) Handles btn_Show.Click
        SPA_Show_Approved_Inventory()
    End Sub

    Private Sub lvApproval_Click(sender As Object, e As EventArgs) Handles lvApproved.Click
        txt_User.Text = lvApproved.SelectedItems.Item(0).SubItems(0).Text()
        txt_Source.Text = lvApproved.SelectedItems.Item(0).SubItems(4).Text()
    End Sub

End Class