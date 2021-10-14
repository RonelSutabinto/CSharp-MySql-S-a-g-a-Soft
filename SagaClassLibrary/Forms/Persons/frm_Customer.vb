Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes

Namespace Forms.Persons
    Public Class frm_Customer

        Public Sub New()
            If Me.xuc_Customer Is Nothing Then
                Me.xuc_Customer = New Controls.Persons.xuc_Customer()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, BtnCancel)

            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Customer_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(xuc_Customer.Branch_Code)
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, BarManager)
        End Function

        Private Sub frm_Customer_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            xuc_Customer.Control_Save()
        End Sub

        Private Sub btn_Save_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Close.ItemClick
            If xuc_Customer.Control_Save() Then Form_Close()
        End Sub

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

    End Class
End Namespace