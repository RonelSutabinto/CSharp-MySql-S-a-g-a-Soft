Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class IS_Inventory_item_find
    Dim dt As DataTable

    Dim mQuickSearch As String

    Sub searchInventory()
        GridView.Columns.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamQuickSearch", mQuickSearch)}

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GridList, GridView, "mg_ShowItemAttrib")
    End Sub

    Private Sub IS_Inventory_item_find_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)

        If QuickSearch.EditValue Like String.Empty Then
            mQuickSearch = " "
        End If

        searchInventory()
    End Sub

    Private Sub Btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        searchInventory()
    End Sub

    Private Sub QuickSearch_EditValueChanged(sender As Object, e As EventArgs) Handles QuickSearch.EditValueChanged
        mQuickSearch = QuickSearch.EditValue
    End Sub

    Private Sub RepositoryItemTextEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles RepositoryItemTextEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchInventory()
        End If
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles GridView.DoubleClick
        IS_Inventory_Receiving.txt_descrip.Text = mDescription
        IS_Inventory_Receiving.txt_color.Text = mColor
        IS_Inventory_Receiving.txt_brand.Text = mBrand
        Me.Close()
        IS_Inventory_Receiving.DockItems.Visible = True
    End Sub

    Dim mCode As String
    Dim mDescription As String
    Dim mQuantity As String
    Dim mModel As String
    Dim mMaker As String
    Dim mBrand As String
    Dim mColor As String
    Dim mUnitPrice As String

    Private Sub GridView_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView.RowCellClick
        mCode = GridView.GetRowCellDisplayText(GridView.FocusedRowHandle, "Code")
        mDescription = GridView.GetRowCellDisplayText(GridView.FocusedRowHandle, "Description")
        mQuantity = GridView.GetRowCellDisplayText(GridView.FocusedRowHandle, "Quantity")
        mModel = GridView.GetRowCellDisplayText(GridView.FocusedRowHandle, "Model")
        mMaker = GridView.GetRowCellDisplayText(GridView.FocusedRowHandle, "Maker")
        mBrand = GridView.GetRowCellDisplayText(GridView.FocusedRowHandle, "Brand")
        mColor = GridView.GetRowCellDisplayText(GridView.FocusedRowHandle, "Color")
        mUnitPrice = GridView.GetRowCellDisplayText(GridView.FocusedRowHandle, "UnitPrice")
    End Sub
End Class