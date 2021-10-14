Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Public Class frm_Journal_Profile
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        If Me.xuc_Journal_Profile Is Nothing Then
            Me.xuc_Journal_Profile = New Controls.Accounting.xuc_Journal_Profile()
        End If

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, xuc_Journal_Profile.layoutControl, BtnCancel)

        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Journal_Profile_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        btn_Save.Enabled = class_Saga_Variables.isAccounting
        btn_Save_Close.Enabled = class_Saga_Variables.isAccounting
    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me, BarManager)
    End Function

    Private Sub frm_Journal_Profile_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick

        xuc_Journal_Profile.Control_Save()
    End Sub

    Private Sub btn_Save_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Close.ItemClick

        If xuc_Journal_Profile.Control_Save() Then Form_Close()
    End Sub

    Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

End Class