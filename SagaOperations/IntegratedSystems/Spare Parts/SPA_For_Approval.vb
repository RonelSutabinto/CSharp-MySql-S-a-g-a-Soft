Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class SPA_For_Approval
    Sub Data_Load()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamApprover", class_Variables.sUserName),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_Show_ForChecking_Inventory")
    End Sub

    Private Sub SPA_For_Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data_Load()
    End Sub

    Private Sub btn_Show_Click(sender As Object, e As EventArgs) Handles btn_Show.Click
        Data_Load()
    End Sub

    Private Sub GridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        Dim Receivingfrm As SPA_Checker_Approver_Receiving = New SPA_Checker_Approver_Receiving()
        Dim Outgoingfrm As SPA_Checker_Approver_Outgoing = New SPA_Checker_Approver_Outgoing()
        If e.Clicks.Equals(1) Then
            txt_Source.Text = GridView.GetFocusedRowCellDisplayText("SourceEvent")
        End If
        If e.Clicks.Equals(2) Then
            If txt_Source.Text = "RECEIVING" Then
                Receivingfrm.txt_RefNo.Text = GridView.GetFocusedRowCellDisplayText("Refno")
                Receivingfrm.txt_Source.Text = GridView.GetFocusedRowCellDisplayText("SourceEvent")
                Receivingfrm.Show()
            Else
                Outgoingfrm.txt_RefNo.Text = GridView.GetFocusedRowCellDisplayText("Refno")
                Outgoingfrm.txt_Source.Text = GridView.GetFocusedRowCellDisplayText("SourceEvent")
                Outgoingfrm.Show()
            End If

        End If
    End Sub

End Class