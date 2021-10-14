Imports System.Data.SqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports MyClassLibrary.Classes.class_Procedures
Imports SagaClassLibrary.Classes
Public Class frm_SPA_Utility
    Dim sBrCode, sCategory, sPartNumber, sPartName, sType, sBrand As String
    Dim iQuantity, iCartons As Integer
    Dim dSRP, dRebates As Decimal
    Dim dUnitCost As Decimal = 0
    Dim bLoopStop As Boolean
    Friend sBalanceType As String

    Private Sub Show_Form(ByVal xFrm As XtraForm, ByVal sTitle As String, Optional ByVal bChild As Boolean = True)
        class_Procedures.splash_Show(sTitle, , True, xFormMode.xForm)
        Try
            xFrm.Icon = Me.Icon
            xFrm.Text = sTitle
            If bChild Then xFrm.MdiParent = Me
            xFrm.Show()
        Catch ex As Exception

        End Try
        class_Procedures.splash_Close(True)
    End Sub
    Private Sub frm_SPA_Utility_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton

        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, Xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        If Me.Xuc_Utility.Control_Save() Then
            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load("LOAD")
            Else
                'Update_Data_Row()
            End If
        End If
    End Sub

    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
    End Sub
    Private Sub frm_SPA_Utility_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Close()
    End Sub

    Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
        Xuc_Utility.Control_Delete()
        Data_Load("LOAD")
    End Sub

    Private Sub btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        If class_Procedures.isEmpty(Xuc_Utility.Receiving_Branch) Then Return

        Dim xRpt As New SagaSpareParts.xrpt_SPA_Purchase_Orders_Overall_Summary()

        Try
            With xRpt
                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 1300
                .PageHeight = 850

                '.XrTableCell_Brand.Text = Xuc_Utility.Brand.Text
                '.XrTableCell_Dealer.Text = Xuc_Utility.Supplier_Name.Text
                '.XrTableCell_Address.Text = CStr(Xuc_Utility.Brand.GetColumnValue("Account_Address"))

                '.XrTableCell_Order_Date.Text = Xuc_Utility.Order_Date.Text
            End With

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Action_Type", "LOAD_SUMMARY")
            }

            class_Database.Procedure_Bind_Report(class_Database.SPAConnection, sqlParameters, xRpt, "spa_Modify_Procedures", "SPA_Inventory")
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        End Try
    End Sub

    Private Sub frm_SPA_Utility_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Xuc_Settings.Toggle_Auto_Initialize.IsOn Then Xuc_Utility.Control_Initialize()
        'If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD")
        If class_Saga_Variables.sBranchCode.Equals("000") Then
            RepositoryItemLookUpEdit_Branch.ReadOnly = False
        Else
            RepositoryItemLookUpEdit_Branch.ReadOnly = True

        End If
        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(BarEditItem_Branch, RepositoryItemLookUpEdit_Branch)

    End Sub

    Private Sub Data_Load(ByVal sActionType As String)

        Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@BranchCode", BarEditItem_Branch.EditValue),
                New SqlParameter("@Action_Type", sActionType)
            }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, gridView, "spa_Modification_Procedures", "Spare Parts Modification")

        gridView.ClearSorting()
        colID.SortIndex = 0
        colID.SortOrder = DevExpress.Data.ColumnSortOrder.Descending

    End Sub
    Private Sub Data_Load_Quick(ByVal sActionType As String)

        Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@QuickSearch", BarEditItem_Search.EditValue),
                New SqlParameter("@Action_Type", sActionType)
            }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, gridView, "spa_Modification_Procedures", "Spare Parts Modification")

        gridView.ClearSorting()
        colID.SortIndex = 0
        colID.SortOrder = DevExpress.Data.ColumnSortOrder.Descending

    End Sub
    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Data_Load("LOAD")
    End Sub
    Private Sub Data_Show()
        With Xuc_Utility
            .ID.Text = gridView.GetFocusedRowCellDisplayText(colID)
            .sBranchCode = gridView.GetFocusedRowCellDisplayText(colBranchCode)
            .PartsNumber.Text = gridView.GetFocusedRowCellDisplayText(colPartsNumber)
            .PartsName.Text = CStr(gridView.GetFocusedRowCellValue(colPartsName))
            .PO_Name.EditValue = CStr(gridView.GetFocusedRowCellValue(colPONo))
            .Brand.EditValue = gridView.GetFocusedRowCellValue(colBrand)
            .Category.EditValue = gridView.GetFocusedRowCellValue(colCategory)
            .SRP.Text = gridView.GetFocusedRowCellDisplayText(colSRP)
            .SPCostWOVAT.Text = gridView.GetFocusedRowCellDisplayText(colSPCostWOVAT)
            .TotalCostWOVAT.EditValue = gridView.GetFocusedRowCellDisplayText(colTotalCostWOVAT)
            .Quantity.Text = gridView.GetFocusedRowCellDisplayText(colQuantity)
            .BinBox.Text = gridView.GetFocusedRowCellDisplayText(colBinBox)
            .Branch_Code.Text = gridView.GetFocusedRowCellDisplayText(colBranch_Code)
            .Receiving_Branch.Text = gridView.GetFocusedRowCellDisplayText(colReceiving_Branch)
            .Classification.Text = gridView.GetFocusedRowCellDisplayText(colClassification)
        End With
    End Sub
    Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
        If e.Clicks.Equals(2) AndAlso gridView.DataRowCount > 0 Then
            Select Case e.Column.FieldName
                Case "supplier_code"
                Case Else
                    class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                    Data_Show()
            End Select
        End If
    End Sub
    Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            Try
                Data_Load_Quick("LOAD_ALL")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End If
    End Sub
End Class