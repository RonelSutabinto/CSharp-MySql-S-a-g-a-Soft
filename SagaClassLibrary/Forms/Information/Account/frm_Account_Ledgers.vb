Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Partial Class frm_Account_Ledgers
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, xuc_Grid_Ledger.gridView, BtnCancel)

        class_Saga_Procedures.Initialize_BarManager(Me, Me.xuc_Grid_Ledger.barManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Account_Ledger_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me, xuc_Grid_Ledger.gridView)
    End Function

    Private Sub frm_Account_Ledger_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

End Class