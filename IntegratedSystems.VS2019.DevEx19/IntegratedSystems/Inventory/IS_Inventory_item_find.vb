Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Public Class IS_Inventory_item_find

    Dim mQuickSearch As String

    private sub searchInventory()
        gridView.Columns.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", mQuickSearch)
        }
        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GridList, gridView, "mg_ShowItemAttrib")
    End Sub

    private sub IS_Inventory_item_find_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)

        If QuickSearch.EditValue Like String.Empty Then
            mQuickSearch = " "
        End If

        searchInventory()
    End Sub

    private sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        searchInventory()
    End Sub

    private sub QuickSearch_EditValueChanged(sender As Object, e As EventArgs) Handles QuickSearch.EditValueChanged
        mQuickSearch = QuickSearch.EditValue
    End Sub

    private sub RepositoryItemTextEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles RepositoryItemTextEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchInventory()
        End If
    End Sub

    private sub gridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
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

    private sub gridView_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles gridView.RowCellClick
        mCode = gridView.GetRowCellDisplayText(gridView.FocusedRowHandle, "Code")
        mDescription = gridView.GetRowCellDisplayText(gridView.FocusedRowHandle, "Description")
        mQuantity = gridView.GetRowCellDisplayText(gridView.FocusedRowHandle, "Quantity")
        mModel = gridView.GetRowCellDisplayText(gridView.FocusedRowHandle, "Model")
        mMaker = gridView.GetRowCellDisplayText(gridView.FocusedRowHandle, "Maker")
        mBrand = gridView.GetRowCellDisplayText(gridView.FocusedRowHandle, "Brand")
        mColor = gridView.GetRowCellDisplayText(gridView.FocusedRowHandle, "Color")
        mUnitPrice = gridView.GetRowCellDisplayText(gridView.FocusedRowHandle, "UnitPrice")
    End Sub
End Class