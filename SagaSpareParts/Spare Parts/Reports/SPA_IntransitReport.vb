Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class SPA_IntransitReport
    Sub SPA_Transmittal_Intransit()
        lvApproved.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamMaker", class_Variables.sUserName),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Transmittal_Intransit")
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
        End Using
    End Sub

    Private Sub SPA_For_Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPA_Transmittal_Intransit()
    End Sub

    Private Sub lvApproval_DoubleClick(sender As Object, e As EventArgs) Handles lvApproved.DoubleClick
        If txt_Source.Text = "OUTGOING" Then
            SPA_TransmittalReport.Show()
            SPA_TransmittalReport.Text = "TRANSMITTAL"
            SPA_TransmittalReport.txt_SINo.Text = lvApproved.SelectedItems.Item(0).SubItems(0).Text()
            SPA_TransmittalReport.txt_Source.Text = lvApproved.SelectedItems.Item(0).SubItems(4).Text()
            lvApproved.Items.Clear()
            Me.Close()
        End If

    End Sub

    Private Sub btn_Show_Click(sender As Object, e As EventArgs) Handles btn_Show.Click
        SPA_Transmittal_Intransit()
    End Sub

    Private Sub lvApproval_Click(sender As Object, e As EventArgs) Handles lvApproved.Click
        txt_User.Text = lvApproved.SelectedItems.Item(0).SubItems(0).Text()
        txt_Source.Text = lvApproved.SelectedItems.Item(0).SubItems(4).Text()
    End Sub

End Class