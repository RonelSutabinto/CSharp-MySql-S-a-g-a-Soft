Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class rpt_CollectionAging
    Private Sub cmd_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        class_Procedures.splash_Show("Loading Computerized Ageing")
        showCollectionAging()
        class_Procedures.splash_Close()
    End Sub

    Sub showCollectionAging()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_BrCode.EditValue.ToString),
            New SqlParameter("@ParamPostingDate", CutOffDate.EditValue),
            New SqlParameter("@ParamAECode", txt_AECode.EditValue),
            New SqlParameter("@ParamAcctStatus", txt_AccountStatus.EditValue),
            New SqlParameter("@ParamCORP", txt_Corp.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCCollectionAging, GridView, "mg_Generate_Aging")
    End Sub

    Private Sub BWAging_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWAging.DoWork
        showCollectionAging()

        '' The asynchronous task you want to perform goes here
        '' the following is an example of how it typically goes.

        Const Max As Integer = 1000

        For i = 1 To Max
            '' do something

            '' (I put a sleep to simulate time consumed)
            Threading.Thread.Sleep(100)

            '' report progress at regular intervals
            BWAging.ReportProgress(CInt(100 * i / Max), "Running..." & i.ToString)

            '' check at regular intervals for CancellationPending
            If BWAging.CancellationPending Then
                BWAging.ReportProgress(CInt(100 * i / Max), "Cancelling...")
                Exit For
            End If
        Next

        '' any cleanup code go here
        '' ensure that you close all open resources before exitting out of this Method.
        '' try to skip off whatever is not desperately necessary if CancellationPending is True

        '' set the e.Cancel to True to indicate to the RunWorkerCompleted that you cancelled out
        If BWAging.CancellationPending Then
            e.Cancel = True
            BWAging.ReportProgress(100, "Cancelled.")
        End If
    End Sub

    Private Sub BWAging_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BWAging.RunWorkerCompleted
        '' This event is fired when your BackgroundWorker exits.
        '' It may have exitted Normally after completing its task,
        '' or because of Cancellation, or due to any Error.

        If e.Error IsNot Nothing Then
            '' if BackgroundWorker terminated due to error
            MessageBox.Show(e.Error.Message)
            '  MsgBox("Error occurred!")

        ElseIf e.Cancelled Then
            '' otherwise if it was cancelled
            MessageBox.Show("Task cancelled!")
            ' MsgBox("Task Cancelled!")
        Else
            '' otherwise it completed normally
            MessageBox.Show("Task completed!")
            '  MsgBox("Error completed!")
        End If
    End Sub

    Private Sub rpt_CollectionAging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(txt_BrCode, txt_BrCodeRepository)
        If MainMenu.statusBrCode.Caption = "000" Then
            txt_BrCode.Enabled = True
            txt_BrCode.EditValue = MainMenu.statusBrCode.Caption
        Else
            txt_BrCode.Enabled = False
            txt_BrCode.EditValue = MainMenu.statusBrCode.Caption
        End If

        mg_ShowCORP()
        mg_ShowBranchDetails()
        mg_ShowAccountStatus()

        CutOffDate.EditValue = DateTime.Now.ToString("MM/dd/yyyy")
    End Sub

    Sub mg_ShowBranchCode()
        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowBranchParameters")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    CType(txt_BrCode.Edit, RepositoryItemComboBox).Items.Add(myDataReader.Item("BranchCode").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub mg_ShowBranchDetails()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowBranchDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    PreparedBy.Text = myDataReader("Maker").ToString()
                    CheckedBy.Text = myDataReader("BM").ToString()
                    BranchName.Text = myDataReader("BranchName").ToString()
                    BranchAddress.Text = myDataReader("BranchAddress").ToString()
                Loop
            End If
        End Using
    End Sub

    Sub mg_ShowCORP()
        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowCORP")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    CType(txt_Corp.Edit, RepositoryItemComboBox).Items.Add(myDataReader.Item("CorpCode").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub mg_ShowAccountStatus()
        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAccountStatus")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    CType(txt_AccountStatus.Edit, RepositoryItemComboBox).Items.Add(myDataReader.Item("AcctStatus").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub cmd_Print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick
        Dim report As New RPT_ActualCollectionPrintPreview()
        GridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GCCollectionAging

        report.Parameters("AeCode").Value = txt_AECode
        report.Parameters("BranchAddress").Value = BranchAddress.Text
        report.Parameters("BranchCode").Value = txt_BrCode.EditValue
        report.Parameters("BranchName").Value = BranchName.Text
        report.Parameters("CheckedBy").Value = CheckedBy.Text
        report.Parameters("DateBegin").Value = String.Empty
        report.Parameters("DateEnd").Value = Format(CutOffDate.EditValue, "MM/dd/yyyy")
        report.Parameters("Preparedby").Value = PreparedBy.Text
        report.Parameters("ReportTitle").Value = "COLLECTION AGING" & " - " & txt_AccountStatus.EditValue

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Private Sub txt_BrCode_EditValueChanged(sender As Object, e As EventArgs) Handles txt_BrCode.EditValueChanged
        class_Saga_Variables.Initialize_AE(txt_BrCode.EditValue.ToString)
        class_Saga_Procedures.Initialize_AE(RepositoryItemComboBox1)
    End Sub

    Private Sub GridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        If e.Clicks > 1 Then
            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
        End If
    End Sub

    Private Sub rpt_CollectionAging_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)
    End Sub

End Class