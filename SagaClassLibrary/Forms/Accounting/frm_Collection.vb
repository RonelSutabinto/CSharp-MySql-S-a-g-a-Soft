Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_Collection

        Sub New()
            If xuc_Grid_Collection Is Nothing Then
                Me.xuc_Grid_Collection = New Controls.Accounting.xuc_Grid_Collection()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, BtnCancel)
            class_Procedures.Initialize_gridView(Me, Me.xuc_Grid_Collection.gridView)

            class_Saga_Procedures.Initialize_BarManager(Me.xuc_Grid_Collection.barManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Collection_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            'class_Saga_Procedures.Initialize_Branch(Me.xuc_Grid_Collection.repositoryItemLookUpEdit_Branch)
        End Sub

        Private Sub frm_Collection_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, Me.xuc_Grid_Collection.gridView)
        End Function

    End Class

End Namespace