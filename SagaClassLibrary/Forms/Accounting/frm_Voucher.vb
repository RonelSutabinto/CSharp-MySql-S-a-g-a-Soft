Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Public Class frm_Voucher
    Public voucherType As eVoucherType

    Public Sub New()
        If Me.xuc_Voucher Is Nothing Then
            Me.xuc_Voucher = New Controls.Accounting.xuc_Voucher()
        End If

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, xuc_Voucher.xuc_Account_Search.gridView, BtnCancel)

        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Voucher_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        btn_Save.Enabled = class_Saga_Variables.isAccounting
        btn_Save_Close.Enabled = class_Saga_Variables.isAccounting
        btn_Save_Journal_Entries.Enabled = class_Saga_Variables.isAccounting
    End Sub

    Private Function Form_Close() As Boolean
        class_Tools.RegKeySet(Me.Name, xuc_Voucher.Voucher_Approver.Name, xuc_Voucher.Voucher_Approver.Text.Trim)

        Return class_Procedures.Form_Close(Me, BarManager, xuc_Voucher.xuc_Account_Search.gridView)
    End Function

    Private Sub frm_Vouchere_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
        Me.xuc_Voucher.Control_Initialize()
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        Me.xuc_Voucher.control_Save(voucherType)
    End Sub

    Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
        Show_Journal_Entries()
    End Sub

    Private Sub Show_Journal_Entries()
        With xuc_Voucher
            Dim iID As Int16 = .ID.EditValue
            Dim sReference As String = .Voucher_Reference.Text.Trim
            Dim sApprover As String = .Voucher_Approver.Text.Trim
            Dim sBrCode As String = .Voucher_Branch.EditValue.ToString
            Dim sType As String = .Expense_Type.Text.Trim
            Dim sProfile As String = .Voucher_Profile.Text.Trim
            Dim sAccountCode As String = .Account_Code.Text
            Dim sAccountName As String = .Account_Name.Text.Trim
            Dim sDescription As String = .Voucher_Description.Text
            Dim dtPosted As Date = convert.todatetime(.Voucher_Date_Posted.EditValue)
            Dim sCOACode As String = String.Empty
            Try
                sCOACode = .COA_Code.EditValue.ToString
            Catch ex As Exception
                sCOACode = String.Empty
            End Try

            Dim sCheck As String = "0"
            Try
                sCheck = .Voucher_Check.EditValue.ToString()
            Catch ex As Exception
                sCheck = "0"
            Finally
                class_Saga_Procedures.Show_Journal_Entries_Reference(iID, iID, sReference, sBrCode, sType, sProfile, sAccountCode, sAccountName, dtPosted, sApprover, sCOACode, sCheck, sDescription) ', class_Saga_Functions.Journal_Pre_Code("VOUCHER")
            End Try
        End With
    End Sub

    Private Sub btn_Save_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Journal_Entries.ItemClick
        If xuc_Voucher.control_Save(voucherType) Then
            Show_Journal_Entries()
        End If
        Form_Close()
    End Sub

    Private Sub btn_Save_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Close.ItemClick
        If xuc_Voucher.control_Save(voucherType) Then Form_Close()
    End Sub

    Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

End Class