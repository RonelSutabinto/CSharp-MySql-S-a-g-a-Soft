Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Public Class frm_Chart_Of_Account
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        If Me.xuc_Chart_Of_Account Is Nothing Then
            Me.xuc_Chart_Of_Account = New Controls.Accounting.xuc_Chart_Of_Account()
        End If

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, xuc_Chart_Of_Account.layoutControl, BtnCancel)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Chart_Of_Account_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        btn_Save.Enabled = class_Saga_Variables.isAccounting
        btn_Save_Close.Enabled = class_Saga_Variables.isAccounting
    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me, BarManager)
    End Function

    Private Sub frm_Chart_Of_Account_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub Ledger_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Ledger.ItemClick
        class_Saga_Procedures.Show_COA_Ledger(xuc_Chart_Of_Account.COA_Code.Text, xuc_Chart_Of_Account.COA_Name.Text)
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        xuc_Chart_Of_Account.Control_Save(xuc_Chart_Of_Account.COA_Code.Text.Trim)
    End Sub

    Private Sub btn_Save_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Close.ItemClick
        If xuc_Chart_Of_Account.Control_Save(xuc_Chart_Of_Account.COA_Code.Text.Trim) Then Form_Close()
    End Sub

    Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

End Class