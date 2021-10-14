Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes

Public Class wzf_Voucher
    Friend sReference, sCode, sName, sCheck As String

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

        class_Procedures.Initialize_Form(Me, xuc_Voucher.layoutControl, BtnCancel)
        class_Procedures.Initialize_gridView(Me, xuc_Journal_Entries.gridView, True, True)

        class_Saga_Procedures.Initialize_BarManager(Me.xuc_Journal_Entries, Me.xuc_Journal_Entries.BarManager)

        xuc_Journal_Entries.btn_New.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Insert)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me, xuc_Journal_Entries.xuc_Account_Search.gridView, True)
    End Function

    Private Sub wf_Voucher_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        xuc_Journal_Entries.xuc_Account_Search.gridView.RestoreLayoutFromRegistry("Account Names")

        class_Saga_Procedures.Initialize_Branch(xuc_Voucher.Voucher_Branch)
        class_Saga_Procedures.Initialize_Branch(xuc_Journal_Entries.repositoryItemLookUpEdit_Branch)
        class_Saga_Procedures.Initialize_COA(xuc_Journal_Entries.RepositoryItemLookUpEdit_COA, eCOA_Type.COA_Detail)
        class_Saga_Procedures.Initialize_COA(xuc_Journal_Entries.RepositoryItemLookUpEdit_COA_Summary, eCOA_Type.COA_Summary)
        'class_Saga_Procedures.Initialize_Check(xuc_Journal_Entries.RepositoryItemLookUpEdit_Check_Numbers)

        xuc_Journal_Entries.RepositoryItemComboBox_Type.DropDownRows = class_Database.Fill_Edit(class_Database.ICSConnection, xuc_Journal_Entries.RepositoryItemComboBox_Type, "acc_Journal_Entries", "Journal_Type")
        xuc_Journal_Entries.RepositoryItemComboBox_Profile.DropDownRows = class_Database.Fill_Edit(class_Database.ICSConnection, xuc_Journal_Entries.RepositoryItemComboBox_Profile, "acc_Journal_Entries", "Journal_Profile")
    End Sub

    Private Sub WizardControl_NextClick(sender As Object, e As DevExpress.XtraWizard.WizardCommandButtonClickEventArgs) Handles WizardControl.NextClick
        'If Not xuc_Voucher.control_Save Then
        '    WizardControl.SendToBack()
        'End If
    End Sub

End Class