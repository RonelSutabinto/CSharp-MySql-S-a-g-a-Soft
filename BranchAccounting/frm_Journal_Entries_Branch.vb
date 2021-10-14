Imports BranchAccounting.Modules
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Forms
    Public Class frm_Journal_Entries_Branch
        Friend Enum LoadMode
            mDateRange
            mReference
        End Enum

        Friend eMode As LoadMode
        Friend sReference As String
        Friend bLoopStop As Boolean

        Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Sub frm_Journal_Entries_Branch_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
            Form_Close()
        End Sub

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            bLoopStop = True
            class_Saga_Database.bLoopStop = True

            class_Tools.RegKeySet(Me.Name, BarEditItem_Corporation.Name, BarEditItem_Corporation.EditValue.ToString)

            Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Journal_Entries_Branch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            BarEditItem_Corporation.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Corporation.Name, "SMC")

            btn_Delete.Enabled = class_Saga_Variables.isCashier
            btn_Approval.Enabled = class_Saga_Variables.isCashier
        End Sub

        Private Sub frm_Journal_Entries_Branch_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            'If xuc_Settings.Toggle_Auto_Reload.IsOn Then Form_Load_Data(BarEditItem_Corporation.EditValue.ToString, class_Saga_Variables.sBranchCode)

            Dim RepositoryItemLookUpEdit_COA As New RepositoryItemLookUpEdit()
            class_Saga_Procedures.Initialize_COA(RepositoryItemLookUpEdit_COA, eCOA_Type.COA_All)

            Dim RepositoryItemLookUpEdit_Branch As New RepositoryItemLookUpEdit()
            class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit_Branch)

            colCorporation.ColumnEdit = RepositoryItemLookUpEdit_Corporation
            colBranch_Code.ColumnEdit = RepositoryItemLookUpEdit_Branch
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If gridView.SelectedRowsCount > 0 Then
                Select Case e.KeyCode
                    Case Keys.F2

                    Case Keys.F6
                        Module_Forms.Show_Journal_Entries(gridView.GetFocusedRowCellDisplayText(colJournal_Reference))

                    Case Keys.Delete
                        class_Saga_Database.Transaction_Delete(gridView, "Journal Entry/Entries", "acc_Journal_Procedures", "DELETE")

                End Select
            End If
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView.MouseDown, gridControl.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM view_Journal_Entries WHERE IsDeleted <> 1 AND Branch_Code LIKE '{class_Saga_Variables.sBranchCode}' AND (Journal_Reference LIKE '%{sSearch}%' OR Account_Code LIKE '%{sSearch}%' OR Account_Name LIKE '%{sSearch}%' OR Journal_Description LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%')", "view_Journal_Entries")
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Try
                    Load_Search((CType(sender, BaseEdit)).Text.Trim)
                Catch ex As Exception

                End Try
            End If
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso e.Clicks.Equals(2) Then
                class_Procedures.Copy_Clipboard(e.CellValue.ToString)
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Select Case eMode
                Case LoadMode.mDateRange
                    Form_Load_Data(BarEditItem_Corporation.EditValue.ToString, class_Saga_Variables.sBranchCode)

                Case LoadMode.mReference
                    Form_Load_Data(sReference)
            End Select

        End Sub

        Private Sub Form_Load_Data(ByVal sCorp As String, ByVal sBrCode As String)
            If class_Saga_Variables.dtEnd.Subtract(class_Saga_Variables.dtStart).Days >= 27 Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"Displaying Journal Entries with more than 27 days will take some time and will cause this Application unresponsive.
                    {Environment.NewLine}Don't worry as this is normal due to large volume of Server-Client data downloading.
                    {Environment.NewLine}However, if data downloading took more time than usual - Data Error might occured or call IT Support for assistance.
                    {Environment.NewLine}Please continue if you are certain.", "Reminder", True)

                If Not class_Procedures.actionAsk("Download Journal Entries", $"Download Journal Entries between {class_Saga_Variables.dtStart:MMM dd, yyyy} to {class_Saga_Variables.dtEnd:MMM dd, yyyy}", "Data Error might occur Or Application will become unresposive", "adjust your Date range To decrease loading time") Then Return
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Corporation", sCorp),
                New SqlParameter("@Branch_Code", sBrCode),
                New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Action_Type", "LOAD_BRANCH")
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Journal_Procedures", "acc_Journal_Entries")
        End Sub

        Friend Sub Form_Load_Data(ByVal sReference As String)
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Journal_Reference", sReference),
                New SqlParameter("@Action_Type", "LOAD_REFERENCE")
            }
            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Journal_Procedures", "acc_Journal_Entries")
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            Module_Forms.Show_Journal_Entries(gridView.GetFocusedRowCellDisplayText(colJournal_Reference))
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            If class_Saga_Database.Transaction_Delete(gridView, "Journal Entry/Entries", "acc_Journal_Procedures", "DELETE") Then
                btn_Reload_ItemClick(sender, e)
            End If
        End Sub

        Private Function IsVerified() As Boolean
            With gridView
                .ClearColumnsFilter()
                If .RowCount > 0 Then
                    For i As Integer = 0 To .RowCount - 1
                        If Not Convert.ToBoolean(.GetRowCellValue(i, colIsVerified)) Or .GetRowCellDisplayText(i, colJournal_Status).Contains("ERROR") Or Not class_Saga_Functions.IsEqualSummary(colJournal_Debit, colJournal_Credit) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Journal Entries must be Balanced, Verified and without Errors before Approval.{Environment.NewLine}Please remove Journal Entries with Error, initiate Journal Verification or Re-Journal if needed", "Verification Error", True)
                            Return False
                        End If
                    Next
                End If
            End With
            Return True
        End Function

        Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
            class_Database.DBError = False
            If IsVerified() Then
                class_Saga_Database.Update_Transaction_Status(gridView, eTransaction.Journal, "Journal_Status", "PENDING", "FOR APPROVAL")
                btn_Reload_ItemClick(sender, e)
            End If
        End Sub

        Private Sub btn_Proof_Sheet_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Proof_Sheet.ItemClick
            If gridView.RowCount > 0 Then
                Dim xRpt As SagaClassLibrary.Reports.Accounting.xrpt_Proof_Sheet = New SagaClassLibrary.Reports.Accounting.xrpt_Proof_Sheet()

                Try
                    With xRpt
                        .PaperKind = System.Drawing.Printing.PaperKind.Custom
                        .PageWidth = 850
                        .PageHeight = 1300

                        If BarEditItem_Corporation.EditValue.ToString.Equals("SMC") Then
                            .XrTableCell_Corporation.Text = "MOTORS"
                        Else
                            .XrTableCell_Corporation.Text = "FINANCE"
                        End If
                        .XrLabel_Corporation.Text = $"SAGA { .XrTableCell_Corporation.Text} CORPORATION"

                        .Product_Version.Text = $"{$"{Application.ProductName} {Application.ProductVersion}™ {Date.Today.Year}"} - IT Department"

                        .Branch_Name.Text = class_Saga_Database.get_Branch_Name(class_Saga_Variables.sBranchCode)
                        .Transaction_Date.Text = $"{class_Saga_Variables.dtStart:MMMM dd, yyyy}"

                        Dim sqlParameters As SqlParameter() = {
                            New SqlParameter("@Corporation", BarEditItem_Corporation.EditValue.ToString),
                            New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                            New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                            New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                            New SqlParameter("@Action_Type", "PROOF_SHEET")
                        }
                        class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "acc_Journal_Procedures", "acc_Journal_Entries")
                    End With
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
            class_Saga_Database.bLoopStop = True
        End Sub

    End Class

End Namespace