Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class rpt_CollectionAging
    Private sBranchName, sBranchAddress, sPreparedBy, sCheckedBy As String

    Public Sub New()
        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, gridView, BtnCancel)

        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me, gridView, True)
    End Function

    Private Sub rpt_CollectionAging_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub rpt_CollectionAging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        'class_Saga_Procedures.Initialize_Corporation(Corporation, RepositoryItemLookUpEdit_Corporation)
        class_Saga_Variables.Initialize_AE(class_Saga_Variables.sBranchCode)
        class_Saga_Procedures.Initialize_AE(Account_Executive, RepositoryItemLookUpEdit_AE)
    End Sub

    Private Sub rpt_CollectionAging_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Database.Fill_Edit(class_Database.ICSConnection, RepositoryItemComboBox_Account_Status, "CustAccount", "AccountStatus")

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamTransactedBy", class_Variables.sUserName)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowBranchDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    sBranchName = myDataReader("BranchName").ToString()
                    sBranchAddress = myDataReader("BranchAddress").ToString()
                    sPreparedBy = myDataReader("Maker").ToString()
                    sCheckedBy = myDataReader("BM").ToString()
                Loop
            End If
        End Using
    End Sub

    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        class_Procedures.splash_Show("Loading Computerized Ageing")
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamCORP", Corporation.EditValue),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode),
            New SqlParameter("@ParamPostingDate", class_Saga_Variables.dtEnd),
            New SqlParameter("@ParamAECode", Account_Executive.EditValue),
            New SqlParameter("@ParamAcctStatus", Account_Status.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GCCollectionAging, gridView, "mg_Generate_Aging", "Colection Ageing", True)
    End Sub

    Private Sub BWAging_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BWAging.DoWork
        'showCollectionAging()

        '' The asynchronous task you want to perform goes here
        '' the following is an example of how it typically goes.

        Const Max As Integer = 1000

        For i = 1 To Max
            '' do something

            '' (I put a sleep to simulate time consumed)
            Threading.Thread.Sleep(100)

            '' report progress at regular intervals
            BWAging.ReportProgress(Convert.ToInt32(100 * i / Max), "Running..." & i.ToString)

            '' check at regular intervals for CancellationPending
            If BWAging.CancellationPending Then
                BWAging.ReportProgress(Convert.ToInt32(100 * i / Max), "Cancelling...")
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

    Private Sub btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        Dim report As New RPT_ActualCollectionPrintPreview()
        gridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GCCollectionAging

        report.Parameters("ReportTitle").Value = $"COLLECTION AGING {Corporation.EditValue}"
        report.Parameters("AeCode").Value = Account_Executive.EditValue
        report.Parameters("BranchCode").Value = class_Saga_Variables.sBranchCode
        report.Parameters("BranchName").Value = sBranchName
        report.Parameters("BranchAddress").Value = sBranchAddress
        report.Parameters("DateBegin").Value = Format(class_Saga_Variables.dtStart, "MMM dd, yyyy")
        report.Parameters("DateEnd").Value = Format(class_Saga_Variables.dtEnd, "MMM dd, yyyy")
        report.Parameters("Preparedby").Value = sPreparedBy
        report.Parameters("CheckedBy").Value = sCheckedBy

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
        If e.Clicks > 1 Then
            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
        End If
    End Sub

End Class