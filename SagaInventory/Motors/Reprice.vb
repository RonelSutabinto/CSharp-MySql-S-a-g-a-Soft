Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Public Class Reprice
    Friend Ledger_Set As Integer
    Friend Branch_Code, Account_Number, Engine_Number As String

    Sub Data_Load()
        Dim sqlParameters As SqlParameter()
        Try
            sqlParameters = {New SqlParameter("@Engine_Number", xuc_Reprice.EngineNo)}
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "bj_Show_TransactionPayments", "Accounts")
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub

    Private Sub gridControl_Click(sender As Object, e As EventArgs) Handles gridControl.Click
        Branch_Code = gridView.GetFocusedRowCellDisplayText("Branch_Code")
        Account_Number = gridView.GetFocusedRowCellDisplayText("Account_Number")
        Ledger_Set = gridView.GetFocusedRowCellDisplayText("Ledger_Set_Number")
        Engine_Number = gridView.GetFocusedRowCellDisplayText("Engine_Number")
    End Sub
    Private Sub Reprice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub MC_For_Reprice_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Close()
    End Sub

    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, True)
    End Sub

    Private Sub btn_Approved_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_OK.ItemClick
        If xuc_Reprice.WH_Code.Equals("REP") Then
            xuc_Reprice.Control_Update_Rep()
        Else
            xuc_Reprice.Control_Update_iRep()
        End If
        xuc_Reprice.Control_Reclass()
    End Sub

    Sub Data_Load_Ledger()
        Dim sqlParameters As SqlParameter()
        Try
            sqlParameters = {New SqlParameter("@Branch_Code", Branch_Code),
                New SqlParameter("@Account_Number", Account_Number),
                New SqlParameter("@Ledger_Set_Number", Ledger_Set),
                New SqlParameter("@Engine_Number", Engine_Number)}
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl_Ledger, gridView, "bj_Show_AccountLedger", "Account Ledger")
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub

    Private Sub gridControl_DoubleClick(sender As Object, e As EventArgs) Handles gridControl.DoubleClick
        Data_Load_Ledger()
        'Account_Ledger.ShowDialog()
    End Sub

End Class