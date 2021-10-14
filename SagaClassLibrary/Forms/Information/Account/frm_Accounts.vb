Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Forms.Information.Account

    Public Class frm_Accounts
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If Me.xuc_Account Is Nothing Then
                Me.xuc_Account = New Controls.Information.Account.xuc_Account()
            End If

            If Me.xuc_Accounts Is Nothing Then
                Me.xuc_Accounts = New Controls.Information.Account.xuc_Accounts()
            End If

            If Me.xuc_Grid_Ledger Is Nothing Then
                Me.xuc_Grid_Ledger = New Controls.Information.Account.xuc_Grid_Ledger()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, xuc_Accounts.gridView, BtnCancel)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager)
            class_Saga_Procedures.Initialize_BarManager(xuc_Accounts, xuc_Accounts.barManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Accounts_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Registry_Values_Get()

            class_Saga_Procedures.Initialize_Branch(xuc_Account.Branch_Code)
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, repositoryItemLookUpEdit_Branch)

            BarEditItem_Date_Granted.Enabled = False
        End Sub

        Private Sub Registry_Values_Get()
            check_form_Account.EditValue = class_Tools.RegKeyGet(Me.Name, check_form_Account.Name, False)
            check_Ledger_Show.EditValue = class_Tools.RegKeyGet(Me.Name, check_Ledger_Show.Name, False)
            BarEditItem_Date_Granted.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Date_Granted.Name, Date.Today.ToString("MMM dd, yyyy"))
        End Sub

        Private Sub Registry_Values_Set()
            class_Tools.RegKeySet(Me.Name, check_form_Account.Name, check_form_Account.Checked)
            class_Tools.RegKeySet(Me.Name, check_Ledger_Show.Name, check_Ledger_Show.Checked)
            class_Tools.RegKeySet(Me.Name, BarEditItem_Date_Granted.Name, BarEditItem_Date_Granted.EditValue.ToString)
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Account.Control_Initialize()
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, repositoryItemLookUpEdit_Branch)
        End Sub

        Private Function Form_Close() As Boolean
            xuc_Accounts.Stop_Execute()
            Registry_Values_Set()
            Return class_Procedures.Form_Close(Me, barManager, dockManager, xuc_Accounts.gridView, True)
        End Function

        Private Sub frm_Accounts_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            xuc_Accounts.Control_Data_Load(barEditItem_Branch.EditValue.ToString, xuc_Settings.Toggle_Load_All.IsOn) ', barCheckItem_Closed_Accounts.Checked, BarEditItem_Date_Granted.EditValue)
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Account.Control_New(True)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            xuc_Account.control_Save()
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick

        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            xuc_Accounts.gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Try
                    xuc_Accounts.Load_Search((CType(sender, BaseEdit)).Text.Trim)
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub ToggleClosedAccounts_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ToggleClosedAccounts.CheckedChanged
            BarEditItem_Date_Granted.Enabled = ToggleClosedAccounts.Checked
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            class_Saga_Variables.bLoopStop = True
            xuc_Accounts.bLoopStop = True
        End Sub

        Private Sub btn_SMS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SMS.ItemClick
            'LC_SMS_3_3.Classes.Class_SMS.Show_Sender(xuc_Accounts.gridView, "view_Accounts", "AccountName", "ContactNumber", "Remarks")
        End Sub

    End Class

End Namespace