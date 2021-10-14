Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Public Class MainMenu
    Private Sub MainMenu_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        BarStaticItem_Username.Caption = $"User: {class_Variables.sUserName}"
        BarStaticItem_Position.Caption = $"Position: {class_Variables.sPosition}"
        BarStaticItem_Server_IP.Caption = $"Server IP: {class_Database.SqlServer}"
        BarStaticItem_Local_IP.Caption = $"Local IP: {class_Variables.sLocal_IP}"

        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit_Branch)
    End Sub
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Database.Initialize_Connection()

        Me.Text = class_Functions.Product_Name_Version

        class_Saga_Variables.sBranchCode = class_Tools.RegKeyGet(Me.Name, BarEditItem_Branch.Name, "000")
    End Sub
    Private Sub bar_Master_List_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bar_Master_List.ItemClick
        Dim frm As Master_List = New Master_List()
        Show_Form(frm, "Master List")
    End Sub

    Friend Sub Show_Form(ByVal xFrm As XtraForm, ByVal sTitle As String, Optional ByVal bChild As Boolean = True)
        class_Procedures.splash_Show(sTitle, , True, class_Procedures.xFormMode.xForm)
        Try
            With xFrm
                If bChild Then .MdiParent = Me
                .Text = sTitle
                .Icon = Me.Icon
                .Show()
            End With
        Catch ex As Exception

        End Try
        class_Procedures.splash_Close(True)
    End Sub

    Private Sub bar_Master_List_SPA_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bar_Master_List_SPA.ItemClick
        Dim frm As Spare_Parts_MasterList = New Spare_Parts_MasterList()
        Show_Form(frm, "Spare Parts Master List")
    End Sub

    Private Sub MCDepUnits_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles MCDepUnits.ItemClick
        Dim frm As MC_For_Reprice = New MC_For_Reprice()
        Show_Form(frm, "MC Deposited for Reprice")
    End Sub

    Private Sub BarReprice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarReprice.ItemClick
        Dim frm As Repricing_List = New Repricing_List()
        Show_Form(frm, "For Repricing List")
    End Sub

    Private Sub BarRepPriceList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarRepPriceList.ItemClick
        Dim frm As PriceList_Summary = New PriceList_Summary()
        Show_Form(frm, "PRICELIST SUMMARY")
    End Sub

    Private Sub Bar_iRepUnits_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Bar_iRepUnits.ItemClick
        Dim frm As frm_iREP_Units = New frm_iREP_Units()
        Show_Form(frm, "iREP Units")
    End Sub

    Private Sub Bar_iREPforREPRICE_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Bar_iREPforREPRICE.ItemClick
        Dim frm As frm_Repricing_List_iREP = New frm_Repricing_List_iREP()
        Show_Form(frm, "INACTIVE REPO FOR REPRICING LIST")
    End Sub

    Private Sub BarButtonItem_REPtoiREP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_REPtoiREP.ItemClick
        Dim frm As frm_Rep_to_IRep = New frm_Rep_to_IRep()
        Show_Form(frm, "REPO TO INACTIVE REPO")

    End Sub
End Class