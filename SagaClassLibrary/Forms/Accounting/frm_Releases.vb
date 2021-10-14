Imports System.Windows.Forms
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Namespace Forms.Accounting

    Public Class frm_Releases
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If Me.xuc_Accounts Is Nothing Then
                Me.xuc_Accounts = New Controls.Information.Account.xuc_Accounts()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, xuc_Accounts.gridView, BtnCancel, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager)
            class_Saga_Procedures.Initialize_BarManager(xuc_Accounts, xuc_Accounts.barManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Releases_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit_Branch)

            BarEditItem_Posting_Date.EditValue = Date.Now
            BarEditItem_Posting_Date.Enabled = BarToggleSwitchItem_Custom_Posting_Date.Checked

            BarToggleSwitchItem_Custom_Posting_Date.Checked = class_Tools.RegKeyGet(Me.Name, BarToggleSwitchItem_Custom_Posting_Date.Name, False)
            BarEditItem_Posting_Date.EditValue = Convert.ToDateTime(class_Tools.RegKeyGet(Me.Name, BarEditItem_Posting_Date.Name, Date.Now.ToShortDateString))

            checkEdit_Journal_Entries.Checked = class_Tools.RegKeyGet(Me.Name, checkEdit_Journal_Entries.Name, False)
            checkEdit_Verify_Journal.Checked = class_Tools.RegKeyGet(Me.Name, checkEdit_Verify_Journal.Name, False)
        End Sub

        Private Sub frm_Releases_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If Me.xuc_Settings.Toggle_Auto_Reload.IsOn Then
                xuc_Accounts.Control_Data_Load(barEditItem_Branch.EditValue, Convert.ToInt32(Me.xuc_Accounts.gridView.GetFocusedRowCellValue(Me.xuc_Accounts.colID)))
            End If
        End Sub

        Private Function Form_Close() As Boolean
            Me.xuc_Accounts.bLoopStop = True

            class_Tools.RegKeySet(Me.Name, BarToggleSwitchItem_Custom_Posting_Date.Name, BarToggleSwitchItem_Custom_Posting_Date.Checked)
            class_Tools.RegKeySet(Me.Name, BarEditItem_Posting_Date.Name, BarEditItem_Posting_Date.EditValue.ToString)

            class_Tools.RegKeySet(Me.Name, checkEdit_Journal_Entries.Name, checkEdit_Journal_Entries.Checked)
            class_Tools.RegKeySet(Me.Name, checkEdit_Verify_Journal.Name, checkEdit_Verify_Journal.Checked)

            Try
                xuc_Accounts.barManager.SaveLayoutToRegistry(xuc_Accounts.Name)
            Catch ex As Exception

            End Try

            Return class_Procedures.Form_Close(Me, barManager, dockManager, xuc_Accounts.gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Releases_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick

        End Sub

        Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.CIF, "NEW",, "New Release Information", True)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            If xuc_Accounts.gridView.RowCount > 0 Then
                xuc_Accounts.gridView.ShowRibbonPrintPreview()
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            xuc_Accounts.Control_Data_Load(barEditItem_Branch.EditValue.ToString, Convert.ToInt32(Me.xuc_Accounts.gridView.GetFocusedRowCellValue(Me.xuc_Accounts.colID)))
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            xuc_Accounts.Stop_Execute()
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            If Me.xuc_Accounts.gridView.SelectedRowsCount > 0 Then Me.xuc_Accounts.Show_Journal_Entries()
        End Sub

        Private Sub btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            xuc_Accounts.Journal_Execute()
        End Sub

        Private Sub BarToggleSwitchItem_Custom_Posting_Date_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarToggleSwitchItem_Custom_Posting_Date.CheckedChanged
            BarEditItem_Posting_Date.Enabled = BarToggleSwitchItem_Custom_Posting_Date.Checked
            Me.xuc_Accounts.bCustomPosting = BarToggleSwitchItem_Custom_Posting_Date.Checked
        End Sub

        Private Sub BarEditItem_Posting_Date_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarEditItem_Posting_Date.ItemClick
            Me.xuc_Accounts.dtCustomDate = Convert.ToDateTime(BarEditItem_Posting_Date.EditValue)
        End Sub

        Private Sub Check_Update_Table_ID_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Update_Table_ID.CheckedChanged
            xuc_Accounts.bUpdateTableID = Check_Update_Table_ID.Checked
        End Sub

        Private Sub checkEdit_Journal_Entries_CheckedChanged(sender As Object, e As EventArgs) Handles checkEdit_Journal_Entries.CheckedChanged
            xuc_Accounts.bShowJournalEntries = checkEdit_Journal_Entries.Checked
        End Sub

        Private Sub checkEdit_Verify_Journal_CheckedChanged(sender As Object, e As EventArgs) Handles checkEdit_Verify_Journal.CheckedChanged
            xuc_Accounts.bVerify = checkEdit_Verify_Journal.Checked
        End Sub


    End Class

End Namespace