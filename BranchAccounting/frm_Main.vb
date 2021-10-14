Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes

Partial Public Class frm_Main
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Saga_Variables.Initialize_Branch()
        class_Saga_Variables.Initialize_COA_Summary()

        class_Saga_Procedures.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit_Branch, True)

        BarEditItem_Branch.EditValue = class_Saga_Variables.sBranchCode
        BarHeaderItem_User.Caption = class_Variables.sUserName

        BarStaticItem_Connection.Caption = class_Database.ICSConnectionTemp
    End Sub

    Private Sub Form_Main_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Sub Form_Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        class_Tools.RegKeySet(Me.Name, BarEditItem_Branch.Name, BarEditItem_Branch.EditValue.ToString)
    End Sub

    Private Sub Form_Show(ByVal frm As XtraForm)
        With frm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub btn_MC_Sales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MC_Sales.ItemClick
        Dim frm As New Forms.frm_MC_Sale
        Form_Show(frm)
    End Sub

    Private Sub btn_Collection_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Collection.ItemClick
        Dim frm As New Forms.frm_Collection
        Form_Show(frm)
    End Sub

    Private Sub btn_Cashiering_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Cashiering.ItemClick
        Dim frm As New Forms.frm_Cashiering
        Form_Show(frm)
    End Sub

    Private Sub btn_SPA_Sales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SPA_Sales.ItemClick
        Dim frm As New Forms.frm_SPA_Sale
        Form_Show(frm)
    End Sub

    Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
        Dim frm As New Forms.frm_Journal_Entries_Branch With {
            .eMode = Forms.frm_Journal_Entries_Branch.LoadMode.mDateRange
        }

        Form_Show(frm)

        frm.Bar_Parameters.Visible = True
    End Sub

End Class