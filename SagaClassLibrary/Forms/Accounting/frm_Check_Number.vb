Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Public Class frm_Check_Number

    Public Sub New()
        If Me.xuc_Check Is Nothing Then
            Me.xuc_Check = New Controls.Accounting.xuc_Check()
        End If

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, xuc_Check.layoutControl, BtnCancel)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Check_Number_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        btn_Save.Enabled = class_Saga_Variables.isAccounting
        btn_Save_Close.Enabled = class_Saga_Variables.isAccounting
        btn_Cancel.Enabled = class_Saga_Variables.isAccounting
    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me, BarManager)
    End Function

    Private Sub frm_Check_Number_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Cancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Cancel.ItemClick

        Me.xuc_Check.Control_Check_Cancel()
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick

        xuc_Check.Control_Save()
    End Sub

    Private Sub btn_Save_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Close.ItemClick

        If xuc_Check.Control_Save() Then Form_Close()
    End Sub

    Private Sub btn_Print_Check_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print_Check.ItemClick
        class_Saga_Procedures.Print_Check(xuc_Check.Bank_Account.Text, xuc_Check.Check_Number.Text, xuc_Check.Check_Payee.Text, Convert.ToDecimal(xuc_Check.Check_Amount.Value), Convert.ToDateTime(xuc_Check.Issued_Date.EditValue), xuc_Check.Check_Description.Text, xuc_Check.Notes.Text)
    End Sub

    Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

End Class