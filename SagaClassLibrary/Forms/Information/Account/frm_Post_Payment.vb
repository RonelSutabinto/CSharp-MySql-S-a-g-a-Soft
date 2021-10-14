Imports MyClassLibrary.Classes

Partial Friend Class frm_Post_Payment
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, BtnCancel)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Payment_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        payment_Date_Posting.EditValue = DateTime.Today
    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me)
    End Function

    Private Sub frm_Account_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

End Class