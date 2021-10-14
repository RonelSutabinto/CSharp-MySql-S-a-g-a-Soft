Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_AcceptedTransfers
    Sub SPA_Transmittal_Accepted()
        lvApproved.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamMaker", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Transmittal_Accepted")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lvApproved.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(myDataReader.Item("InventoryStatus").ToString())
                    li.SubItems.Add(myDataReader.Item("SourceEvent").ToString())
                    li.SubItems.Add(myDataReader.Item("BranchName").ToString())
                    li.SubItems.Add(myDataReader.Item("ReceivingBranchName").ToString())
                Loop
            End If
    End Sub

    Sub SPA_Transmittal_Accepted_Date()
        lvApproved.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamMaker", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamDateBegin", dtp_Begin.Text),
            New SqlParameter("@ParamDateEnd", dtp_End.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Transmittal_Accepted_Date")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lvApproved.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(myDataReader.Item("InventoryStatus").ToString())
                    li.SubItems.Add(myDataReader.Item("SourceEvent").ToString())
                    li.SubItems.Add(myDataReader.Item("BranchName").ToString())
                    li.SubItems.Add(myDataReader.Item("RecievingBranchName").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub SPA_For_Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPA_Transmittal_Accepted()
    End Sub

    Private Sub lvApproval_DoubleClick(sender As Object, e As EventArgs) Handles lvApproved.DoubleClick
        'Dim Form As New SPA_Checker_Approver_Outgoing
        If txt_Source.Text = "OUTGOING" And txt_Status.Text = "Approved" Then
            SPA_TransmittalReport.MdiParent = MainMenu
            SPA_TransmittalReport.Show()
            SPA_TransmittalReport.Text = "APPROVED"
            SPA_TransmittalReport.txt_SINo.Text = lvApproved.SelectedItems.Item(0).SubItems(0).Text()
            SPA_TransmittalReport.txt_Source.Text = lvApproved.SelectedItems.Item(0).SubItems(4).Text()
            lvApproved.Items.Clear()
            Me.Close()
        End If

    End Sub

    Private Sub btn_Show_Click(sender As Object, e As EventArgs) Handles btn_Show.Click
        SPA_Transmittal_Accepted_Date()
    End Sub

    Private Sub lvApproval_Click(sender As Object, e As EventArgs) Handles lvApproved.Click
        txt_Status.Text = lvApproved.SelectedItems.Item(0).SubItems(3).Text()
        txt_Source.Text = lvApproved.SelectedItems.Item(0).SubItems(4).Text()
    End Sub

End Class