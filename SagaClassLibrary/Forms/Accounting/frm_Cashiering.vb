Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_Cashiering

        Sub New()
            If Me.xuc_Grid_Cashiering Is Nothing Then
                Me.xuc_Grid_Cashiering = New Controls.Accounting.xuc_Grid_Cashiering()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, xuc_Grid_Cashiering.gridView, BtnCancel)

            class_Saga_Procedures.Initialize_BarManager(Me.xuc_Grid_Cashiering.barManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Cashiering_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(Me.xuc_Grid_Cashiering.repositoryItemLookUpEdit_Branch)
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, xuc_Grid_Cashiering.gridView)
        End Function

        Private Sub frm_Cashiering_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

    End Class

End Namespace