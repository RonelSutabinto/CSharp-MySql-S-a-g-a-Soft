Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Forms.Information.Item

    Public Class frm_Unit_Color
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If Me.xuc_Color Is Nothing Then
                Me.xuc_Color = New Controls.Information.Item.xuc_Color()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, xuc_Color.layoutControl, BtnCancel)

            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Unit_Color_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
            Me.xuc_Color.Control_Initialize()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, BarManager)
        End Function

        Private Sub frm_Unit_Color_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

    End Class

End Namespace