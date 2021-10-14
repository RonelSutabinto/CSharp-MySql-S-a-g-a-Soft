Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports BranchAccounting.Modules
Imports wSClassLib.myModules

Namespace Forms
    Public Class XtraForm_Journal_Entries

        Friend Enum LoadMode
            mDateRange
            mReference
        End Enum

        Friend eMode As LoadMode
        Friend sReference As String

        Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            Modules.Initialize_Form(Me, GridView, BtnCancel)
            Modules.Initialize_BarManager(Me, BarManager)
        End Sub

        Friend bLoopStop As Boolean

        Private Sub XtraForm_Journal_Entries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Modules.Initialize_COA(RepositoryItemLookUpEdit_COA)
        End Sub

        Private Sub XtraForm_Journal_Entries_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Modules.Initialize_Branch()
            Modules.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit_Branch)

            BarEditItem_Corporation.EditValue = Module_Tools.RegKeyGet(Me.Name, BarEditItem_Corporation.Name, "SMC")

            BarEditItem_Branch.EditValue = mBrCode
            BarEditItem_Branch.Enabled = False

            BarEditItem_Start.EditValue = CDate(Module_Tools.RegKeyGet(Me.Name, BarEditItem_Start.Name, Today.ToLongDateString))
            BarEditItem_End.EditValue = CDate(Module_Tools.RegKeyGet(Me.Name, BarEditItem_End.Name, Today.ToLongDateString))

            GridView.RestoreLayoutFromRegistry(Me.Name)
        End Sub

        Private Sub XtraForm_Journal_Entries_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
            Form_Close()
        End Sub

        Private Sub Btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            bLoopStop = True
            Modules.Module_Data.bLoopStop = True

            Module_Tools.RegKeySet(Me.Name, BarEditItem_Corporation.Name, BarEditItem_Corporation.EditValue.ToString)

            Module_Tools.RegKeySet(Me.Name, BarEditItem_Start.Name, BarEditItem_Start.EditValue.ToString)
            Module_Tools.RegKeySet(Me.Name, BarEditItem_End.Name, BarEditItem_End.EditValue.ToString)

            Return Modules.Form_Close(Me, BarManager, GridView, True)
        End Function

        Private Sub GridView_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView.KeyDown
            If GridView.SelectedRowsCount > 0 Then
                Select Case e.KeyCode
                    Case Keys.F2

                    Case Keys.F6
                        Module_Forms.Show_Journal_Entries(GridView.GetFocusedRowCellDisplayText(colJournal_Reference))

                    Case Keys.Delete
                       Modules.Journal_Delete(GridView, True)

                End Select
            End If
        End Sub

        Private Sub GridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridView.MouseDown, GridControl.MouseDown
            If GridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
               Modules.BindData(connectSP, GridControl, GridView, $"SELECT * FROM view_Journal_Entries WHERE IsDeleted <> 1 AND Branch_Code LIKE '{BarEditItem_Branch.EditValue}' AND (Journal_Reference LIKE '%{sSearch}%' OR Account_Code LIKE '%{sSearch}%' OR Account_Name LIKE '%{sSearch}%' OR Journal_Description LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%')", "view_Journal_Entries")
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Try
                    Load_Search((CType(sender, BaseEdit)).Text.Trim)
                Catch Ex As NullReferenceException

                End Try
            End If
        End Sub

        Private Sub BarEditItem_Start_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItem_Start.ItemDoubleClick
            BarEditItem_Start.EditValue = Modules.Next_Working_Date(CDate(BarEditItem_Start.EditValue), My.Computer.Keyboard.ShiftKeyDown)
            BarEditItem_End.EditValue = BarEditItem_Start.EditValue
        End Sub

        Private Sub BarEditItem_End_ItemDoubleClick(sender As Object, e As ItemClickEventArgs) Handles BarEditItem_End.ItemDoubleClick
            BarEditItem_End.EditValue = BarEditItem_Start.EditValue
        End Sub

        Private Sub GridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles GridView.PrintInitialize
            Modules.Initialize_Printing(e)
        End Sub

        Private Sub Btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick
            GridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub GridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
            If (GridView.RowCount > 0) AndAlso e.Clicks.Equals(2) Then
                Modules.Copy_Clipboard(e.CellValue.ToString)
            End If
        End Sub

        Private Sub Btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
            Select Case eMode
                Case LoadMode.mDateRange
                    Form_Data_Load(BarEditItem_Corporation.EditValue.ToString, BarEditItem_Branch.EditValue.ToString)

                Case LoadMode.mReference
                    Form_Data_Load(sReference)
            End Select

        End Sub

        Private Sub Form_Data_Load(ByVal sCorp As String, ByVal sBrCode As String)
            Dim dtStart As Date = CDate(BarEditItem_Start.EditValue)
            Dim dtEnd As Date = CDate(BarEditItem_End.EditValue)

            If dtEnd.Subtract(dtStart).Days > 31 Then
                Modules.Set_Message(Modules.MsgMode.Warning, $"Displaying Journal Entries with more than 30 days will take some time and will cause this Application unresponsive.
                    {Environment.NewLine}Don't worry as this is normal due to large volume of Server-Client data downloading.
                    {Environment.NewLine}However, if data downloading took more time than usual - Data Error might occured or call IT Support for assistance.
                    {Environment.NewLine}Please continue if you are certain.", "Reminder", True)
            End If

            If Not Modules.actionAsk("Download Journal Entries", $"Download Journal Entries between {dtStart.ToString("MMM dd, yyyy")} to {dtEnd.ToString("MMM dd, yyyy")}", "Data Error might occur Or Application will become unresposive", "adjust your Date range To decrease loading time") Then Return

            Dim Parameters As SqlParameter() = {New SqlParameter("@Corporation", sCorp),
                                                New SqlParameter("@Branch_Code", sBrCode),
                                                New SqlParameter("@Date_Start", dtStart),
                                                New SqlParameter("@Date_End", dtEnd),
                                                New SqlParameter("@Action_Type", "LOAD_BRANCH")}

           Modules.Procedure_Retrieve(connectSP, GridControl, GridView, "acc_Journal_Procedures", Parameters)
        End Sub

        Friend Sub Form_Data_Load(ByVal sReference As String)
            Dim Parameters As SqlParameter() = {New SqlParameter("@Journal_Reference", sReference),
                                            New SqlParameter("@Action_Type", "LOAD_REFERENCE")}

           Modules.Procedure_Retrieve(connectSP, GridControl, GridView, "acc_Journal_Procedures", Parameters)
        End Sub

        Private Sub Btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Journal_Entries.ItemClick
            Module_Forms.Show_Journal_Entries(GridView.GetFocusedRowCellDisplayText(colJournal_Reference))
        End Sub

        Private Sub Btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Delete.ItemClick
            If Modules.Journal_Delete(GridView, True) Then
                Btn_Reload_ItemClick(sender, e)
            End If
        End Sub

        Private Function IsVerified() As Boolean
            With GridView
                .ClearColumnsFilter()
                If .RowCount > 0 Then
                    For i As Integer = 0 To .RowCount - 1
                        If Not CBool(.GetRowCellValue(i, colIsVerified)) Or .GetRowCellDisplayText(i, colJournal_Status).Contains("ERROR") Or Not Modules.IsEqualSummary(colJournal_Debit, colJournal_Credit) Then
                            Modules.Set_Message(Modules.MsgMode.Errorr, $"All Journal Entries must be Verified before Approval.{Environment.NewLine}Please initiate Journal Verification or Re-Journal if needed", "Verification Error", True)
                            Return False
                        End If
                    Next
                End If
            End With
            Return True
        End Function

        Private Sub Btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Approval.ItemClick
            If IsVerified() Then
               Modules.Journal_Update_Status(GridView, "PENDING", "FOR APPROVAL")
                Btn_Reload_ItemClick(sender, e)
            End If
        End Sub

        Private Sub Btn_ProofSheet_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_ProofSheet.ItemClick
            If GridView.RowCount > 0 Then
                Dim xRpt As New xrpt_Proof_Sheet()

                Try
                    With xRpt
                        .PaperKind = System.Drawing.Printing.PaperKind.Custom
                        .PageWidth = 850
                        .PageHeight = 1300

                        If BarEditItem_Corporation.EditValue.ToString.Equals("SMC") Then
                            .XrLabel_Corporation.Text.Equals("SAGA MOTORS CORPORATION")
                            .XrTableCell_Corporation.Text = "MOTORS"
                        Else
                            .XrLabel_Corporation.Text.Equals("SAGA FINANCE CORPORATION")
                            .XrTableCell_Corporation.Text = "FINANCE"
                        End If

                        .XrL_Product_Version.Text = $"{$"{Application.ProductName} {Application.ProductVersion}™ {Date.Today.Year}"} - IT Department"

                        .XrTableCell_Branch_Name.Text = RepositoryItemLookUpEdit_Branch.GetDisplayValueByKeyValue(BarEditItem_Branch.EditValue).ToString
                        .XrTableCell_Transaction_Date.Text = CDate(BarEditItem_Start.EditValue).ToString("MMMM dd, yyyy")

                        Dim Parameters As SqlParameter() = {New SqlParameter("@Corporation", BarEditItem_Corporation.EditValue.ToString),
                                                            New SqlParameter("@Branch_Code", BarEditItem_Branch.EditValue.ToString),
                                                            New SqlParameter("@Date_Start", CDate(BarEditItem_Start.EditValue)),
                                                            New SqlParameter("@Date_End", CDate(BarEditItem_End.EditValue)),
                                                            New SqlParameter("@Action_Type", "PROOF_SHEET")}

                       Modules.Procedure_BindData(connectSP, xRpt, "acc_Journal_Procedures", Parameters, "acc_Journal_Entries")
                    End With
                Catch Ex As NullReferenceException
                    Modules.Set_Message(Modules.MsgMode.Errorr, $"{Ex.HResult}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                Finally

                End Try
            End If
        End Sub

        Private Sub Btn_Stop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles Btn_Stop.ItemClick
            bLoopStop = True
            Modules.Module_Data.bLoopStop = True
        End Sub
    End Class
End Namespace