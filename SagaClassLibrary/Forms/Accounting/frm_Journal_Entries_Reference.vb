Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_Journal_Entries_Reference
        Friend sCOACode, sReference, sDescription, sCode, sName, sCheck As String

        Public Sub New()
            If Me.xuc_Journal_Entries Is Nothing Then
                Me.xuc_Journal_Entries = New Controls.Accounting.xuc_Journal_Entries()
            End If

            If Me.xuc_Journal_Entries.xuc_Account_Search Is Nothing Then
                Me.xuc_Journal_Entries.xuc_Account_Search = New Controls.Information.Account.xuc_Account_Search()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, BtnCancel)

            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
            class_Saga_Procedures.Initialize_BarManager(Me.xuc_Journal_Entries, Me.xuc_Journal_Entries.BarManager)

            class_Procedures.Initialize_gridView(xuc_Journal_Entries, xuc_Journal_Entries.gridView, True, True)

            btn_New.ItemShortcut = New BarShortcut(Keys.Insert)
        End Sub

        Private Sub frm_Journal_Entries_Reference_Load(sender As Object, e As EventArgs) Handles Me.Load
            Dim repositoryItemLookUpEdit_Corporation As New RepositoryItemLookUpEdit()
            class_Saga_Procedures.Initialize_Corporation(repositoryItemLookUpEdit_Corporation)
            xuc_Journal_Entries.colCorporation.ColumnEdit = repositoryItemLookUpEdit_Corporation

            class_Saga_Procedures.Initialize_Branch(xuc_Journal_Entries.repositoryItemLookUpEdit_Branch)
            class_Saga_Procedures.Initialize_COA(xuc_Journal_Entries.RepositoryItemLookUpEdit_COA_Summary, eCOA_Type.COA_Summary)
            class_Saga_Procedures.Initialize_COA(xuc_Journal_Entries.RepositoryItemLookUpEdit_COA, eCOA_Type.COA_All)

            btn_Regenerate_Codes.Enabled = class_Saga_Variables.isAccounting
            btn_Print_Check.Enabled = class_Saga_Variables.isAccounting
            btn_Approve.Enabled = class_Saga_Variables.isAccounting AndAlso class_Saga_Variables.isApprover

            With xuc_Journal_Entries
                .btn_Save.Enabled = class_Saga_Variables.isAccounting
                .btn_Update.Enabled = class_Saga_Variables.isAccounting
                .btn_Delete.Enabled = class_Saga_Variables.isAccounting
                .btn_Approve.Enabled = class_Saga_Variables.isAccounting
                .btn_Lock.Enabled = class_Saga_Variables.isAccounting
            End With
        End Sub

        Private Sub frm_Journal_Entries_Reference_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            xuc_Journal_Entries.xuc_Account_Search.gridView.RestoreLayoutFromRegistry("Account Names")

            Toggle_Auto_Credit.Checked = class_Tools.RegKeyGet(Me.Name, Toggle_Auto_Credit.Name, False)
            Toggle_Unbalanced.Checked = class_Tools.RegKeyGet(Me.Name, Toggle_Unbalanced.Name, False)
            BarEditItemToggle_COA_Type.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItemToggle_COA_Type.Name, False)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            xuc_Journal_Entries.gridView.SaveLayoutToRegistry(xuc_Journal_Entries.Name)
            xuc_Journal_Entries.xuc_Account_Search.gridView.SaveLayoutToRegistry(xuc_Journal_Entries.xuc_Account_Search.Name)

            class_Tools.RegKeySet(Me.Name, Toggle_Auto_Credit.Name, Toggle_Auto_Credit.Checked)
            class_Tools.RegKeySet(Me.Name, Toggle_Unbalanced.Name, Toggle_Unbalanced.Checked)
            class_Tools.RegKeySet(Me.Name, BarEditItemToggle_COA_Type.Name, Convert.ToBoolean(BarEditItemToggle_COA_Type.EditValue))

            Return class_Procedures.Form_Close(Me, BarManager, btn_Save.Enabled)
        End Function

        Private Sub frm_Journal_Entries_Reference_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            Form_Close()
        End Sub

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Refresh_Connection_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Refresh_Connection.ItemClick
            class_Saga_Procedures.Refresh_Connection()
        End Sub

        Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick

            xuc_Journal_Entries.RepositoryItemComboBox_Type.DropDownRows = class_Database.Fill_Edit(class_Database.ICSConnection, xuc_Journal_Entries.RepositoryItemComboBox_Type, "acc_Journal_Entries", "Journal_Type")
            xuc_Journal_Entries.RepositoryItemComboBox_Profile.DropDownRows = class_Database.Fill_Edit(class_Database.ICSConnection, xuc_Journal_Entries.RepositoryItemComboBox_Profile, "acc_Journal_Entries", "Journal_Profile")
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            xuc_Journal_Entries.Data_Load(sReference, 0, Me.xuc_Journal_Entries.gridView.Editable)
        End Sub

        Private Sub btn_Load_Deleted_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Load_Deleted.ItemClick
            xuc_Journal_Entries.Data_Load(sReference, 0, Me.xuc_Journal_Entries.gridView.Editable,,, True)
        End Sub

        Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Journal_Entries.gridView.AddNewRow()
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick

            xuc_Journal_Entries.Journal_Entries_Save()
        End Sub

        Private Sub btn_Save_Print_Voucher_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Print_Voucher.ItemClick
            If xuc_Journal_Entries.Journal_Entries_Save() Then Me.xuc_Journal_Entries.Print_Voucher()
        End Sub

        Private Sub btn_Save_Print_Check_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Print_Check.ItemClick
            If xuc_Journal_Entries.Journal_Entries_Save() Then Me.xuc_Journal_Entries.Print_Check()
        End Sub

        Private Sub btn_Save_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Close.ItemClick

            If xuc_Journal_Entries.Journal_Entries_Save() Then Form_Close()
        End Sub

        Private Sub BarEditItem_Document_Title_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItem_Document_Title.EditValueChanged
            xuc_Journal_Entries.sTitle = BarEditItem_Document_Title.EditValue.ToString
            class_Tools.RegKeySet(Me.Name, BarEditItem_Document_Title.Name, BarEditItem_Document_Title.EditValue.ToString)
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick

            xuc_Journal_Entries.Journal_Entries_Update()
        End Sub

        Private Sub frm_Journal_Entries_Reference_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
            Select Case e.KeyCode
                Case Keys.Insert
                    xuc_Journal_Entries.gridView.AddNewRow()
            End Select
        End Sub

        Private Sub btn_Validation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Validate.ItemClick

        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Verify.ItemClick
            xuc_Journal_Entries.btn_Verify_ItemClick(sender, e)
        End Sub

        Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
            xuc_Journal_Entries.Journal_Entries_Approval()
        End Sub

        Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
            xuc_Journal_Entries.Journal_Entries_Approve()
        End Sub

        Private Sub btn_Regenerate_Codes_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Regenerate_Codes.ItemClick
            xuc_Journal_Entries.Repair_Primary_Keys()
        End Sub

        Private Sub btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            Me.xuc_Journal_Entries.Print_Voucher()
        End Sub

        Private Sub btn_Save_Template_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Save_Template.ItemClick
            Me.xuc_Journal_Entries.Journal_Template_Save()
        End Sub

        Private Sub btn_Save_Approval_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Save_Approval.ItemClick
            With xuc_Journal_Entries
                If .gridView.DataRowCount > 0 AndAlso .Journal_Entries_Save() Then

                    .gridView.SelectAll()
                    .Journal_Entries_Approval()
                End If
            End With
        End Sub

        Private Sub BarEditItemToggle_COA_Type_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItemToggle_COA_Type.EditValueChanged
            If Convert.ToBoolean(BarEditItemToggle_COA_Type.EditValue) Then
                class_Saga_Procedures.Initialize_COA(xuc_Journal_Entries.RepositoryItemLookUpEdit_COA, eCOA_Type.COA_All)
            Else
                class_Saga_Procedures.Initialize_COA(xuc_Journal_Entries.RepositoryItemLookUpEdit_COA, eCOA_Type.COA_Detail)
            End If
        End Sub

        Private Sub Toggle_Auto_Credit_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles Toggle_Auto_Credit.CheckedChanged
            xuc_Journal_Entries.bAutoCredit = Toggle_Auto_Credit.Checked
        End Sub

        Private Sub Toggle_Unbalanced_CheckedChanged(sender As Object, e As ItemClickEventArgs) Handles Toggle_Unbalanced.CheckedChanged
            xuc_Journal_Entries.bUnbalanced = Toggle_Unbalanced.Checked
        End Sub

        Private Sub BarEditItem_Remarks_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItem_Remarks.EditValueChanged
            Me.xuc_Journal_Entries.sDescription = BarEditItem_Remarks.EditValue.ToString
        End Sub

        Private Sub btn_Print_Check_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print_Check.ItemClick

            Me.xuc_Journal_Entries.Print_Check()
        End Sub

    End Class

End Namespace