Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class frm_Customer_Information

    Private Sub frm_Customer_Information_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, GridView, BtnCancel)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub frm_Customer_Information_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Xuc_Customer_Information.CIF_Key_Increment()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub MC_For_Reprice_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Close()
    End Sub

    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, DockManager, GridView, True)
    End Sub

    Private Sub Btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Save.ItemClick
        Xuc_Customer_Information.SaveData()
    End Sub

    Private Sub RepositoryItemTextEdit_Quick_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles RepositoryItemTextEdit_Quick_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            Data_Load()
        End If
    End Sub

    Sub Data_Load()
        Dim Parameters As SqlParameter()
        Try
            Parameters = {New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Quick_Search", Quick_Search.EditValue)}
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GridControl, GridView, "so_Find_Customer_Information", "CIFACCOUNTS")
        Catch Ex As Exception
            
        End Try
    End Sub

    Private Sub GridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        If e.Clicks.Equals(2) Then
            Xuc_Customer_Information.CIF_Key.EditValue = GridView.GetFocusedRowCellDisplayText("CIFKey")
            Xuc_Customer_Information.Last_Name.EditValue = GridView.GetFocusedRowCellDisplayText("LName")
            Xuc_Customer_Information.First_Name.EditValue = GridView.GetFocusedRowCellDisplayText("FName")
            Xuc_Customer_Information.Middle_Name.EditValue = GridView.GetFocusedRowCellDisplayText("MName")
            Xuc_Customer_Information.Date_of_Birth.EditValue = GridView.GetFocusedRowCellValue("BDay")
            Xuc_Customer_Information.Gender.EditValue = GridView.GetFocusedRowCellDisplayText("Gender")
            Xuc_Customer_Information.Civil_Status.EditValue = GridView.GetFocusedRowCellDisplayText("MStatus")
            Xuc_Customer_Information.Address.EditValue = GridView.GetFocusedRowCellDisplayText("Address")
            Xuc_Customer_Information.Occupation.EditValue = GridView.GetFocusedRowCellDisplayText("Occupation")
            Xuc_Customer_Information.Contact_Number.EditValue = GridView.GetFocusedRowCellDisplayText("ContactNumber")
            Xuc_Customer_Information.Business_Name.EditValue = GridView.GetFocusedRowCellDisplayText("BusinessName")
            Xuc_Customer_Information.Business_Address.EditValue = GridView.GetFocusedRowCellDisplayText("BusAddress")
            Xuc_Customer_Information.Spouse_Last_Name.EditValue = GridView.GetFocusedRowCellDisplayText("SpouseLName")
            Xuc_Customer_Information.Spouse_First_Name.EditValue = GridView.GetFocusedRowCellDisplayText("SpouseFName")
            Xuc_Customer_Information.Spouse_Middle_Name.EditValue = GridView.GetFocusedRowCellDisplayText("SpouseMName")
            Xuc_Customer_Information.Spouse_Date_of_Birth.EditValue = GridView.GetFocusedRowCellValue("SPouseBDay")
            Xuc_Customer_Information.Spouse_Occupation.EditValue = GridView.GetFocusedRowCellDisplayText("SpouseOccupation")
            Xuc_Customer_Information.Spouse_Occupation_Address.EditValue = GridView.GetFocusedRowCellDisplayText("SpouseOccupAddress")
            Xuc_Customer_Information.Cedula_Number.EditValue = GridView.GetFocusedRowCellDisplayText("ctc")

        End If
    End Sub

End Class