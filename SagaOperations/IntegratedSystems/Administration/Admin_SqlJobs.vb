Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_SqlJobs
    Dim mValName As String
    Dim mValID As String

    Private Sub Admin_SqlJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ShowJobs()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        GView.Columns.Clear()
        cmd.CommandText = "execMG_SQLJobs_List"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection

        'cmd.Parameters.AddWithValue("@ParamBranchCode", txt_branchcode.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()

        'If rs.Read Then
        '    MsgBox(rs.Item("Message").ToString())
        'End If
        GCSQLJobList.DataSource = (rs)
        GView.BestFitColumns(True)

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:
    End Sub

    Sub StartJobs()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "execMG_SQLJobs_Start"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection

        cmd.Parameters.AddWithValue("@ParamJobName", mValName)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()

        If rs.Read Then
            MsgBox(rs.Item("Message").ToString())
        End If

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:
    End Sub

    Private Sub GView_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GView.RowCellClick
        'mValue = e.CellValue.ToString
        'mValue = GView.GetRowCellDisplayText(GView.FocusedRowHandle, "name")
        'MsgBox(mValue)
    End Sub

    Private Sub GView_DoubleClick(sender As Object, e As EventArgs) Handles GView.DoubleClick
        'MsgBox(mValue)

    End Sub

    Private Sub Btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        ShowJobs()
    End Sub

    Private Sub Admin_SqlJobs_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)
    End Sub

    Private Sub GCSQLJobList_Click(sender As Object, e As EventArgs) Handles GCSQLJobList.Click

    End Sub

    Private Sub GCSQLJobList_MouseDown(sender As Object, e As MouseEventArgs) Handles GCSQLJobList.MouseDown
        If e.Button = MouseButtons.Right Then
            ' MsgBox(sValue)
            RightClickPopUp.ShowPopup(MousePosition)

        End If
    End Sub

    Private Sub JobStartPopUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles JobStartPopUp.ItemClick
        StartJobs()

    End Sub

    Private Sub GView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GView.FocusedRowChanged
        mValName = GView.GetRowCellDisplayText(GView.FocusedRowHandle, "name")
        mValID = GView.GetRowCellDisplayText(GView.FocusedRowHandle, "job_id")
    End Sub

    Sub JobsHistory()
        On Error GoTo out
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        Admin_SQLJobsHistory.GViewJobHistory.Columns.Clear()
        cmd.CommandText = "execMG_SQLJobs_History"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection

        cmd.Parameters.AddWithValue("@ParamJobID", mValID)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()

        Admin_SQLJobsHistory.GCJobHistory.DataSource = (rs)
        Admin_SQLJobsHistory.GViewJobHistory.BestFitColumns(True)

        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:   'MsgBox("Successful Updating")
outs1:
    End Sub

    Private Sub ViewHistJob_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ViewHistJob.ItemClick
        JobsHistory()
        Admin_SQLJobsHistory.Text = mValName & ' - History'
        Admin_SQLJobsHistory.ShowDialog()
    End Sub

End Class