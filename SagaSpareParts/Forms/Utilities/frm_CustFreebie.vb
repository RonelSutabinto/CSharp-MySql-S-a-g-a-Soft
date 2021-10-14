Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class frm_CustFreebie
    Public Sub New()
        If Me.Xuc_Freebies Is Nothing Then
            Me.Xuc_Freebies = Xuc_Freebies()
        End If

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, GridView, BtnCancel, Xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub
    Private Function Form_Close() As Boolean
        GridView.SaveLayoutToRegistry(GridView.Name)
        Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
    End Function

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_CustFreebie_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Form_Close()
    End Sub

    Private Sub frm_CustFreebie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Procedures.Initialize_gridView(GridView, True, True)

        GridView.RestoreLayoutFromRegistry(GridView.Name)
    End Sub

    Private Sub frm_CustFreebie_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Xuc_Settings.Toggle_Auto_Initialize.IsOn Then Xuc_Freebies.Control_Initialize()

        Xuc_Freebies.Posting_Date.EditValue = class_Tools.RegKeyGet(Me.Name, Xuc_Freebies.Posting_Date.Name, CStr(Date.Now()))

    End Sub
    Private Sub Data_Load(ByVal sBranchCode As String)
        Dim sqlParameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", sBranchCode),
                                            New SqlParameter("@ParamQuickSearch", BarEditItem_Search.EditValue)}
        class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, GridView, "SPA_Show_CustFreebie", "Customer Freebies")
    End Sub
    Private Sub btn_Search_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Search.ItemClick
        Data_Load(class_Saga_Variables.sBranchCode)
    End Sub
    Private Sub Data_Show()
        With Xuc_Freebies
            .FreebieID.Text = GridView.GetFocusedRowCellDisplayText(FreebieID)
            .Branch.Text = CStr(GridView.GetFocusedRowCellValue(Branch))
            .Account_Number.Text = CStr(GridView.GetFocusedRowCellValue(AccountNumber))
            .Account_Name.EditValue = GridView.GetFocusedRowCellValue(AccountName)
            .Parts_Number.EditValue = GridView.GetFocusedRowCellValue(PartsNumber)
            .Parts_Name.Text = GridView.GetFocusedRowCellDisplayText(PartsName)
            .Beginning_QTY.Text = GridView.GetFocusedRowCellDisplayText(BegQty)
            .Debit_QTY.Text = CStr(GridView.GetFocusedRowCellValue(DbtQty))
            .Credit_QTY.EditValue = GridView.GetFocusedRowCellValue(CrQty)
            .End_QTY.EditValue = GridView.GetFocusedRowCellValue(EndQty)
            .Posting_Date.Text = GridView.GetFocusedRowCellDisplayText(PostingDate)
            .Transacted_By.Text = GridView.GetFocusedRowCellDisplayText(TransStatus)
        End With
    End Sub
    Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView.FocusedRowChanged
        If Xuc_Settings.Toggle_Select.IsOn Then Data_Show()
    End Sub
End Class