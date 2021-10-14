Imports System.Data.SqlClient
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Public Class frm_Costing

    Private Sub Data_Load(ByVal sActionType As String)
        Dim sqlParameters As SqlParameter() = {New SqlParameter("@Action_Type", sActionType),
                                            New SqlParameter("@Refno", BarEditItem_SearchParts.EditValue)}
        class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, gridView, "spa_Receive_Transfer_Procedures", "Spare Parts Costing")
    End Sub
    Private Sub btn_Honda_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Honda.ItemClick
        Dim xRpt As New xrpt_SPA_Receive_Orders_Accounting_Honda()
        class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM SPA_Inventory WHERE Refno LIKE '{BarEditItem_SearchParts.EditValue}' ORDER BY PARTSNUMBER", "SPA_Inventory") ' -----ADDITIONAL------- AND PONo LIKE '{Xuc_SPA_Receive_Order.Order_Code.Text}' AND Transaction_Code LIKE '{Xuc_SPA_Receive_Order.Transaction_Code.EditValue}'

        Try
            With xRpt
                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 850
                .PageHeight = 1300

                '.XrTableCell_Brand.Text = CStr(Xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Brand"))
                '.XrTableCell_Dealer.Text = CStr(Xuc_SPA_Receive_Order.Order_Code.GetColumnValue("Supplier_Name"))

                '.XrTableCell_Transaction_Code.Text = Xuc_SPA_Receive_Order.Transaction_Code.Text
                '.XrTableCell_Purchase_Order_Code.Text = Xuc_SPA_Receive_Order.Order_Code.EditValue.ToString
                '.XrTableCell_Transaction_Date.Text = Xuc_SPA_Receive_Order.Transaction_Date.Text
                '.XrTableCell_Received_Date.Text = Xuc_SPA_Receive_Order.Received_Date.Text
                '.XrTableCell_Reference.Text = Xuc_SPA_Receive_Order.Reference.Text

                .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub

    Private Sub btn_Yamaha_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Yamaha.ItemClick

    End Sub

    Private Sub btn_Kawasaki_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Kawasaki.ItemClick

    End Sub

    Private Sub btn_Suzuki_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Suzuki.ItemClick

    End Sub
    Private Sub RepositoryItemSearchControl_SearchParts_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_SearchParts.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            Try
                Data_Load("Load_Costing")
                class_Procedures.Initialize_gridView(gridView, True, True)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End If
    End Sub
    Public Sub New()

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, Xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Function Form_Close() As Boolean
        gridView.SaveLayoutToRegistry(gridView.Name)

        Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
    End Function

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub Frm_Purchase_Orders_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub
    Private Sub frm_Costing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Procedures.Initialize_gridView(gridView, True, True)
        gridView.RestoreLayoutFromRegistry(gridView.Name)
    End Sub

    Private Sub frm_Costing_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Procedures.Initialize_gridView(gridView)
    End Sub
    Private Sub gridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView.CellValueChanged
        Try
            With gridView
                Select Case e.Column.Name
                    Case "colSPCostWOVAT"
                        Dim dTotalCost As Decimal = CDec(.GetFocusedRowCellValue(colSPCostWOVAT)) * Convert.ToInt32(.GetFocusedRowCellValue(colQuantity))
                        .SetRowCellValue(e.RowHandle, colTotalCostWOVAT, CDbl(dTotalCost))
                End Select
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub
    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        class_Database.DBError = False
        With gridView
            If .SelectedRowsCount > 0 Then
                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = .GetSelectedRows()

                If Xuc_Settings.Toggle_Clear_Selection.IsOn Then .ClearSelection()

                For i As Integer = 0 To selectedRows.Length - 1
                    iRowHandle = selectedRows(i)

                    If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "SKU Item update", "updated") Then
                        iRowHandleOld = iRowHandle
                    Else Return
                    End If

                    Dim iID As Integer
                    Try
                        Try
                            iID = Convert.ToInt32(.GetRowCellValue(iRowHandle, colID))
                        Catch ex As Exception
                            iID = 0
                        End Try
                        Dim UnitParameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                                New SqlParameter("@PartsNumber", .GetRowCellDisplayText(iRowHandle, colPartsNumber)),
                                                                New SqlParameter("@PartsName", .GetRowCellDisplayText(iRowHandle, colPartsName)),
                                                                New SqlParameter("@Brand", .GetRowCellDisplayText(iRowHandle, colBrand)),
                                                                New SqlParameter("@SRP", .GetRowCellValue(iRowHandle, colSRP)),
                                                                New SqlParameter("@Prev_Quantity", .GetRowCellValue(iRowHandle, colQuantity)),
                                                                New SqlParameter("@SPCostWOVAT", .GetRowCellValue(iRowHandle, colSPCostWOVAT)),
                                                                New SqlParameter("@Category", .GetRowCellDisplayText(iRowHandle, colCategory)),
                                                                New SqlParameter("@Action_Type", "RECEIVING")}
                        class_Database.Procedure_Save(class_Database.SPAConnection, UnitParameters, "spa_Receive_Transfer_Procedures", "Receive Unit Item")
                    Catch ex As Exception
                        class_Procedures.Show_Error(Ex)
                    End Try
                Next

            End If
        End With
    End Sub
End Class