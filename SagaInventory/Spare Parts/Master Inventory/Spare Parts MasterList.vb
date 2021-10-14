Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes

Public Class Spare_Parts_MasterList

    Private Sub Spare_Parts_MasterList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Tickets_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Close()
    End Sub

    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
    End Sub

    Private Sub Spare_Parts_MasterList_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        xuc_Master_Entry.Control_Initialize()
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        xuc_Master_Entry.Control_Save()
    End Sub

End Class