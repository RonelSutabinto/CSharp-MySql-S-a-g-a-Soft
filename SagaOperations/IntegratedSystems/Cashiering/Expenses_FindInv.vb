Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Expenses_FindInv

    Private Sub Expenses_FindInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Expenses_FindInv_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(BarManager1)

        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit1)

        BarEditItem_Branch.EditValue = MainMenu.statusBrCode.Caption

        If MainMenu.statusBrCode.Caption = "000" Then
            BarEditItem_Branch.Enabled = True
            BarEditItem_Branch.EditValue = MainMenu.statusBrCode.Caption
        Else
            BarEditItem_Branch.Enabled = False
            BarEditItem_Branch.EditValue = MainMenu.statusBrCode.Caption
        End If
        'If Me.Text = "TEQ" Or Me.Text = "REP" Then
        mg_ShowItemWH()
        'ElseIf Me.Text = "CUST" Then

        ' End If

    End Sub

    Private Sub Btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        mg_ShowItemWH()
    End Sub

    Sub mg_ShowItemWH()
        On Error GoTo out

        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        GridView.Columns.Clear()

        cmd.CommandText = "mg_ShowPettyCashAcctName"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandTimeout = 500
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamBranchCode", BarEditItem_Branch.EditValue)
        cmd.Parameters.AddWithValue("@ParamWHcode", Me.Text)
        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()

        GridControl.DataSource = (rs)
        GridView.BestFitColumns(True)

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1
out:    MsgBox(Err.Description)
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:
    End Sub

    Private Sub GridControl_Click(sender As Object, e As EventArgs) Handles GridControl.Click

    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles GridView.DoubleClick
        'Frm_Expense_Entry.Engine.EditValue = GridView.Columns.View.GetFocusedRowCellValue("EngineNo")
        'Frm_Expense_Entry.Chassis.EditValue = GridView.Columns.View.GetFocusedRowCellValue("ChassisNo")
        'Frm_Expense_Entry.Account_Name.Text = GridView.Columns.View.GetFocusedRowCellValue("Custodian")
        MsgBox("Data added successfully!!", vbInformation, Application.CompanyName)
    End Sub

End Class