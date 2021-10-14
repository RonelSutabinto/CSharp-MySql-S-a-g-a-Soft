Imports System.Windows.Forms
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Namespace Forms.Logistics
    Public Class frm_MC_Transfers
        Public Sub New()
            If xuc_MC_Transaction_Units Is Nothing Then
                Me.xuc_MC_Transaction_Units = New Controls.Logistics.xuc_MC_Transaction_Units()
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

        Private Sub frm_MC_Transfers_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            xuc_MC_Transaction_Units.gridView.SaveLayoutToRegistry(xuc_MC_Transaction_Units.Name)

        End Sub

        Private Sub frm_MC_Transfers_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        End Sub

        Private Function Form_Close() As Boolean
            xuc_MC_Transaction_Units.gridView.SaveLayoutToRegistry(xuc_MC_Transaction_Units.Name)

            Return class_Procedures.Form_Close(Me, BarManager, True)
        End Function

        Private Sub frm_MC_Transfers_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            'xuc_MC_Transaction_Units.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick

        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick

        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick

        End Sub

    End Class
End Namespace