Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class SPA_InTransit
    Sub Data_Load()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamApprover", class_Variables.sUserName),
            New SqlParameter("@ParamReceivingBranch", class_Saga_Variables.sBranchCode)
        }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_Show_ForChecking_Inventory_InTransit")
    End Sub

    Private Sub SPA_For_Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data_Load()
    End Sub

    Private Sub GridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        Dim InTransitfrm As SPA_Checker_Approver_Outgoing = New SPA_Checker_Approver_Outgoing()
        If e.Clicks.Equals(2) Then
            If txt_User.Text = class_Variables.sUserName Then
                InTransitfrm.txt_RefNo.Text = GridView.GetFocusedRowCellDisplayText("Refno")
                InTransitfrm.txt_Source.Text = GridView.GetFocusedRowCellDisplayText("SourceEvent")
                InTransitfrm.Show()
            End If

        End If
    End Sub

    Private Sub btn_Show_Click(sender As Object, e As EventArgs) Handles btn_Show.Click
        Data_Load()
    End Sub

End Class