Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Forms.Information.Item

    Public Class frm_Unit_Model
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If Me.xuc_Item Is Nothing Then
                Me.xuc_Item = New Controls.Information.Item.xuc_Item()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, xuc_Item.layoutControl, BtnCancel)

            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Unit_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
            Me.xuc_Item.Control_Initialize()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, BarManager)
        End Function

        Private Sub frm_Unit_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_New_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_New.ItemClick
            xuc_Item.Control_New()
        End Sub

        Private Sub btn_Save_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Save.ItemClick
            xuc_Item.Control_Save()
        End Sub

        Private Sub btn_Save_Close_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Save_Close.ItemClick
            If xuc_Item.Control_Save() Then Form_Close()
        End Sub

    End Class

End Namespace