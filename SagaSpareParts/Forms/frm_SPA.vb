Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes

Namespace Forms

    Public Class frm_SPA

        Public Sub New()
            If Me.Xuc_Spare_Part Is Nothing Then
                Me.Xuc_Spare_Part = New SagaSpareParts.Controls.Xuc_Spare_Part()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, BtnCancel)
            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Sub frm_SPA_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, BarManager)
        End Function

        Private Sub frm_Account_Executive_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            Xuc_Spare_Part.Control_Save(True)
        End Sub

        Private Sub btn_Save_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Close.ItemClick
            If Xuc_Spare_Part.Control_Save(True) Then Form_Close()
        End Sub

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

    End Class

End Namespace