Imports SagaClassLibrary.Classes
Imports MyClassLibrary.Classes

Public Class frm_Sales_New
    Private Sub frm_Sales_New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton

        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, Xuc_Sales_Entries.gridView_List, BtnCancel)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        Load_Items()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub
    Private Sub Load_Items()
        Initialize_Parts_Numbers(class_Saga_Variables.sBranchCode)
        Initialize_Parts_Numbers1(Xuc_Sales_Entries.RepositoryItemLookUpEdit_PartNumber)
        class_Procedures.Initialize_gridView(Xuc_Sales_Entries.gridView_List, True, True)
    End Sub
    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, Xuc_Sales_Entries.gridView_List, True)
    End Sub
    Private Sub frm_Sales_Entries_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Close()
    End Sub

    Private Sub frm_Sales_New_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Xuc_Sales_Entries.Control_Initialize()
        class_Procedures.Initialize_gridView(Xuc_Sales_Entries.gridView_List, True, True)
    End Sub

    Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
        Load_Items()
        Xuc_Sales_Entries.Control_Initialize()
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton

        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click
        class_Procedures.Initialize_Form(Me, Xuc_Sales_Entries.gridView_List, BtnCancel)
    End Sub
    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        Xuc_Sales_Entries.Control_Save()
        Xuc_Sales_Entries.Save_Item_List()
    End Sub
End Class