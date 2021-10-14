Imports System.Data.SqlClient
Imports DevExpress.Skins
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports MyClassLibrary.Classes.class_Procedures
Imports SagaClassLibrary.Classes
Public Class frm_SPA_Master
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
    Private Sub frm_SPA_Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton

        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, GridView, BtnCancel, Xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        If Me.Xuc_SPA_Master.Control_Save() Then
            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load("LOAD")
            Else
                'Update_Data_Row()
            End If
        End If
    End Sub

    Private Sub Form_Close()
        class_Procedures.Form_Close(Me, BarManager, DockManager, GridView, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
    End Sub
    Private Sub frm_SPA_Master_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form_Close()
    End Sub

    Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
        Xuc_SPA_Master.Control_Delete()
        Data_Load("LOAD")
    End Sub

    Private Sub btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        'If class_Procedures.isEmpty(Xuc_SPA_Master.Receiving_Branch) Then Return

        Dim xRpt As New SagaSpareParts.xrpt_SPA_Purchase_Orders_Overall_Summary()

        Try
            With xRpt
                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 1300
                .PageHeight = 850

                '.XrTableCell_Brand.Text = Xuc_SPA_Master.Brand.Text
                '.XrTableCell_Dealer.Text = Xuc_SPA_Master.Supplier_Name.Text
                '.XrTableCell_Address.Text = CStr(Xuc_SPA_Master.Brand.GetColumnValue("Account_Address"))

                '.XrTableCell_Order_Date.Text = Xuc_SPA_Master.Order_Date.Text
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
        If Xuc_Settings.Toggle_Auto_Initialize.IsOn Then Xuc_SPA_Master.Control_Initialize()
        'If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD")
        class_Saga_Variables.Initialize_Branch()

    End Sub

    Private Sub Data_Load(ByVal sActionType As String)

        Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@PartsNumber", PartsNumber.EditValue),
                New SqlParameter("@Action_Type", sActionType)
            }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, GridControl, GridView, "spa_Modification_Procedures", "Spare Parts Modification")

        GridView.ClearSorting()
        colID.SortIndex = 0
        colID.SortOrder = DevExpress.Data.ColumnSortOrder.Descending

    End Sub
    Private Sub Data_Show()
        With Xuc_SPA_Master
            .ID.Text = GridView.GetFocusedRowCellDisplayText(colID)
            .Part_Number.Text = GridView.GetFocusedRowCellDisplayText(colPart_Number)
            .Part_Name.Text = CStr(GridView.GetFocusedRowCellValue(colPart_Name))
            .Brand.EditValue = GridView.GetFocusedRowCellValue(colBrand)
            .Category.EditValue = GridView.GetFocusedRowCellValue(colCategory)
            .SRP.Text = GridView.GetFocusedRowCellDisplayText(colSRP)
            .Cost_WoVAT.Text = GridView.GetFocusedRowCellDisplayText(colCost_WoVAT)
            .Cost_WVAT.Text = GridView.GetFocusedRowCellDisplayText(colCost_WVAT)
            .Posting_Date.Text = GridView.GetFocusedRowCellDisplayText(colPosting_Date)
        End With
    End Sub
    Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles GridView.RowCellClick
        If e.Clicks.Equals(2) AndAlso GridView.DataRowCount > 0 Then
            Select Case e.Column.FieldName
                Case "supplier_code"
                Case Else
                    class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                    Data_Show()
            End Select
        End If
    End Sub
    'Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
    '    If e.KeyCode.Equals(Keys.Enter) Then
    '        Try
    '            Data_Load_Quick("LOAD_ALL")
    '        Catch ex As Exception
    '            class_Procedures.Show_Error(ex)
    '        End Try
    '    End If
    'End Sub
End Class