Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class frm_Repricing_List_iREP

    Private Sub Repricing_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, gridView, BtnCancel)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        class_Saga_Procedures.Initialize_Branch(Search_Branch, RepositoryItemLookUpEdit_Branch)
    End Sub

    Private Sub Repricing_List_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_Branch(Search_Branch, RepositoryItemLookUpEdit_Branch)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub MC_For_Reprice_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Close()
    End Sub

    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, gridView, True)
    End Sub

    Sub Data_Load()
        Dim sqlParameters As SqlParameter()
        Try
            sqlParameters = {New SqlParameter("@Branch_Code", Search_Branch.EditValue),
                             New SqlParameter("@Action_Type", "IREP")}
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GridControl, gridView, "rpt_DepUnits_forApproval", "TABLES")
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub

    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Data_Load()
    End Sub

    Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
        Dim frm As Reprice = New Reprice()
        If e.Clicks.Equals(2) Then
            frm.xuc_Reprice.ModelCode = gridView.GetFocusedRowCellDisplayText("Model_Code")
            frm.xuc_Reprice.Branch.Text = gridView.GetFocusedRowCellDisplayText("Branch")
            frm.xuc_Reprice.BranchCode = gridView.GetFocusedRowCellDisplayText("Branch_Code")
            frm.xuc_Reprice.EngineNo = gridView.GetFocusedRowCellDisplayText("Engine_Number")
            frm.xuc_Reprice.ChassisNo = gridView.GetFocusedRowCellDisplayText("Chassis_Number")
            frm.xuc_Reprice.WH_Code = gridView.GetFocusedRowCellValue("Specific_Notes")
            frm.xuc_Reprice.Restoration_Cost.EditValue = gridView.GetFocusedRowCellDisplayText("Unit_Cost")
            frm.xuc_Reprice.Outstanding_Balance.Text = gridView.GetFocusedRowCellDisplayText("Outstanding_Balance")
            frm.xuc_Reprice.AccountNumber = gridView.GetFocusedRowCellDisplayText("Account_Number")
            frm.xuc_Reprice.DP.Value = gridView.GetFocusedRowCellValue("DP")
            frm.xuc_Reprice.M_A.Value = gridView.GetFocusedRowCellValue("PMT")
            frm.xuc_Reprice.RefNo = gridView.GetFocusedRowCellDisplayText("Ref_Number")
            frm.xuc_Reprice.PONo = gridView.GetFocusedRowCellDisplayText("PO_Number")
            frm.xuc_Reprice.LedgerSet = gridView.GetFocusedRowCellValue("Ledger_Set_Number")
            frm.xuc_Reprice.InventoryID = gridView.GetFocusedRowCellValue("Prev_ID")
            frm.xuc_Reprice.Customer_Name.EditValue = gridView.GetFocusedRowCellValue("Account_Name")
            frm.xuc_Reprice.Principal.EditValue = gridView.GetFocusedRowCellValue("Principal_Balance")
            frm.xuc_Reprice.Interest.EditValue = gridView.GetFocusedRowCellValue("Interest_Balance")
            frm.xuc_Reprice.Classifications.EditValue = gridView.GetFocusedRowCellDisplayText("Specific_Notes")
            frm.Data_Load()
            frm.Show()
            frm.xuc_Reprice.LCP.IsNeedFocus.Equals(True)

            If frm.xuc_Reprice.InventoryStatus = "Approved" Then
                MsgBox("Nothing to do here...")
            End If
        End If
    End Sub

End Class