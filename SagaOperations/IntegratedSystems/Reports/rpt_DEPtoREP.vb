Imports DevExpress.XtraGrid.Views
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class rpt_DEPtoREP
    Private Sub rpt_DEPtoREP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MainMenu.statusBrCode.Caption = "000" Then
            txt_BranchCode.Enabled = True
            txt_BranchCode.EditValue = MainMenu.statusBrCode.Caption
        Else
            txt_BranchCode.Enabled = False
            txt_BranchCode.EditValue = MainMenu.statusBrCode.Caption
        End If
        mg_ShowBranchDetails()

    End Sub

    Sub mg_ShowBranchDetails()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowBranchDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                PreparedBy.Text = myDataReader("Maker").ToString()
                CheckedBy.Text = myDataReader("BM").ToString()
                BranchName.Text = myDataReader("BranchName").ToString()
                BranchAddress.Text = myDataReader("BranchAddress").ToString()
            End If
        End Using
    End Sub

    Private Sub cmd_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        class_Procedures.splash_Show("Loading List")
        showDEPtoREP()
        class_Procedures.splash_Close()
    End Sub

    Sub showDEPtoREP()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_BranchCode.EditValue),
            New SqlParameter("@ParamDays", txt_NoofDays.EditValue),
            New SqlParameter("@ParamWH", txt_whcode.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCInventoryList, GridView, "rpt_DepRepMonitoring")
    End Sub

    Private Sub GridView_RowCellClick(sender As Object, e As Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        If e.Clicks > 1 Then
            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
        End If
    End Sub

    Private Sub rpt_DEPtoREP_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)
        class_Procedures.splash_Show("Loading List")
        showDEPtoREP()
        class_Procedures.splash_Close()
    End Sub

End Class