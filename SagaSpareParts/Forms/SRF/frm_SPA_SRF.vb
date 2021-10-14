Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraGrid.Views.Grid
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frm_SPA_SRF
    Dim sBrCode, sBrand, sCategory, sPartNumber, sPartName, sType As String
    Dim iQuantity, iCartons, iBatch_Id, iId_Initial As Integer
    Dim dSRP, dRebates As Decimal
    Dim dUnitCost As Decimal = 0

    Public Sub New()
        If Me.Xuc_SPA_SRF Is Nothing Then
            Me.Xuc_SPA_SRF = Xuc_SPA_SRF()
        End If

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, Xuc_Settings)
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Function Form_Close() As Boolean
        gridView_Items.SaveLayoutToRegistry(gridView_Items.Name)
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

    Private Sub Frm_Purchase_Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Procedures.Initialize_gridView(gridView_Items, True, True)

        gridView_Items.RestoreLayoutFromRegistry(gridView_Items.Name)
    End Sub

    Private Sub Frm_Purchase_Orders_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If Xuc_Settings.Toggle_Auto_Initialize.IsOn Then Xuc_SPA_SRF.Control_Initialize()
        If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD", class_Saga_Variables.sBranchCode)

        Xuc_SPA_SRF.Transaction_Date.EditValue = class_Tools.RegKeyGet(Me.Name, Xuc_SPA_SRF.Transaction_Date.Name, CStr(Date.Now()))

    End Sub

    Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
        Xuc_SPA_SRF.Control_Initialize()
        Load_Items()
    End Sub

    Private Sub Data_Load(ByVal sActionType As String, ByVal sBranchCode As String)
        Dim sqlParameters As SqlParameter() = {New SqlParameter("@Action_Type", sActionType),
                                            New SqlParameter("@Branch_Code", sBranchCode)}
        class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, gridControl, gridView, "spa_Spare_Parts_Request_Procedures", "Stock Replenishment Form")
    End Sub

    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Data_Load("LOAD", class_Saga_Variables.sBranchCode)
    End Sub

    Private Sub btn_Reload_All_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_All.ItemClick
        Data_Load("LOAD_ALL", class_Saga_Variables.sBranchCode)
    End Sub

    Private Sub btn_Reload_Modified_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Modified.ItemClick
        Data_Load("LOAD_MODIFIED", class_Saga_Variables.sBranchCode)
    End Sub

    Private Sub btn_Reload_Deleted_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Deleted.ItemClick
        Data_Load("LOAD_DELETED", class_Saga_Variables.sBranchCode)
    End Sub

    Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
        class_Procedures.Initialize_Printing(e)
    End Sub

    Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        gridView.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
        Me.Xuc_SPA_SRF.Control_New(Xuc_Settings.Toggle_Clear_On_Action.IsOn)
        gridControl_Items.DataSource = Nothing
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        If Me.Xuc_SPA_SRF.Control_Save() Then
            Save_Item_List()

            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load("LOAD", class_Saga_Variables.sBranchCode)
            Else
                'Update_Data_Row()
            End If
        End If
    End Sub

    Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
        Me.Xuc_SPA_SRF.Control_Delete()
    End Sub

    Private Sub Data_Show()
        With Xuc_SPA_SRF
            .ID.Text = gridView.GetFocusedRowCellDisplayText(colID)
            .Branch_From.Text = CStr(gridView.GetFocusedRowCellValue(colBranch_From))
            .Reference.Text = CStr(gridView.GetFocusedRowCellValue(colReference))
            .SRF_Number.EditValue = gridView.GetFocusedRowCellValue(colSRF_Number)
            .Transaction_Date.EditValue = gridView.GetFocusedRowCellValue(colTransaction_Date)
            .Description.Text = gridView.GetFocusedRowCellDisplayText(colSKU_Description)
            .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
        End With
        Load_Items()
    End Sub

    Private Sub Load_Items()
        Initialize_Parts_Numbers(CStr(Xuc_SPA_SRF.Branch_From.GetColumnValue("BranchCode")))
        Initialize_Parts_Numbers(RepositoryItemLookUpEdit_Parts_Number)
        class_Procedures.Initialize_RepositoryItem(RepositoryItemLookUpEdit_Parts_Number, DevExpress.XtraEditors.Controls.TextEditStyles.Standard)
        class_Database.Bind_Data(class_Database.SPAConnection, gridControl_Items, gridView_Items, $"SELECT * FROM Spare_Parts_Request_Items WHERE Reference LIKE '{Xuc_SPA_SRF.Reference.EditValue}' ORDER BY ID", "Spare_Parts_Request_Items")
        class_Procedures.Initialize_gridView(gridView_Items, True, True)
    End Sub

    Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
        If Xuc_Settings.Toggle_Select.IsOn Then Data_Show()
    End Sub

    Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If (gridView.DataRowCount > 0) Then
            Select Case e.KeyValue
                Case Keys.Delete
                    If Xuc_SPA_SRF.Control_Delete Then
                        Try
                            gridView.DeleteSelectedRows()
                        Catch ex As Exception
                            class_Procedures.Show_Error(Ex)
                        End Try
                    End If
            End Select
        End If
    End Sub

    Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
        If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
            Dim sTatus As String = gridView.GetFocusedRowCellDisplayText(colStatus)
            btn_Approval.Enabled = sTatus.Equals("PENDING") Or sTatus.Equals("DISAPPROVED")
            btn_Disapprove.Enabled = sTatus.Equals("FOR APPROVAL")
            btn_Approve.Enabled = sTatus.Equals("FOR APPROVAL")
            PopupMenu.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
        If e.Clicks.Equals(2) AndAlso gridView.DataRowCount > 0 Then
            Select Case e.Column.FieldName
                Case "supplier_code"
                Case Else
                    'class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                    Data_Show()
            End Select
        End If
    End Sub
    Private Sub gridView_Items_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        With gridView_Items
            Select Case e.KeyCode
                Case Keys.Insert
                    .AddNewRow()

                Case Keys.Delete
                    If (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
                    Dim view As gridView = CType(sender, gridView)
                    view.DeleteRow(view.FocusedRowHandle)
            End Select
        End With
    End Sub

    Private Sub RepositoryItemLookUpEdit_Parts_Number_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit_Parts_Number.EditValueChanged
        Try
            sPartNumber = CType(sender, BaseEdit).EditValue.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RepositoryItemLookUpEdit_Parts_Number_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_Parts_Number.Validating
        Try
            Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)

            iBatch_Id = Convert.ToInt32(editor.GetColumnValue("id").ToString())
            gridView_Items.SetFocusedRowCellValue(colBatch_Id, iBatch_Id)

            sPartNumber = editor.GetColumnValue("PartsNumber").ToString()
            gridView_Items.SetFocusedRowCellValue(colParts_Number, sPartNumber)

            sPartName = editor.GetColumnValue("PartsName").ToString()
            gridView_Items.SetFocusedRowCellValue(colParts_Name, sPartName)

            sCategory = editor.GetColumnValue("Category").ToString()
            gridView_Items.SetFocusedRowCellValue(colCategory, sCategory)

            sBrand = editor.GetColumnValue("Brand").ToString()
            gridView_Items.SetFocusedRowCellValue(colBrand, sBrand)

            dSRP = CDec(editor.GetColumnValue("SRP"))
            gridView_Items.SetFocusedRowCellValue(colSRP, dSRP)

            dUnitCost = CDec(editor.GetColumnValue("SPCostWOVAT"))
            gridView_Items.SetFocusedRowCellValue(colCost, dUnitCost)

            iQuantity = 0
            gridView_Items.SetFocusedRowCellValue(colQuantity, iQuantity)

            iId_Initial = 0
            gridView_Items.SetFocusedRowCellValue(colID2, iId_Initial)

            Dim iSalesdDays = Date.Today.AddDays(-60)
            Dim iSalesCount, iInventory As Integer
            iSalesCount = Convert.ToInt32(class_Database.Get_Data(class_Database.SPAConnection, $"SELECT SUM(Quantity) AS Quantity FROM Transaction_Collection WHERE PartsNumber LIKE '{sPartNumber}' AND PostingDate >= '{iSalesdDays}' AND ErrorCorrectTag <> 1", "Quantity"))
            gridView_Items.SetFocusedRowCellValue(colSummary, iSalesCount)

            iInventory = Convert.ToInt32(class_Database.Get_Data(class_Database.SPAConnection, $"SELECT SUM(Quantity) AS Quantity FROM SPA_Inventory WHERE PartsNumber LIKE '{sPartNumber}' and ReceivingBranch LIKE '{class_Saga_Variables.sBranchCode}'", "Quantity"))
            gridView_Items.SetFocusedRowCellValue(colInventory_Count, iInventory)
        Catch ex As Exception
            XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RepositoryItemSpinEdit_Quantity_EditValueChanged(sender As Object, e As EventArgs) Handles RepositoryItemSpinEdit_Quantity.EditValueChanged
        Try
            iQuantity = Convert.ToInt32(CType(sender, BaseEdit).EditValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub gridView_Items_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView_Items.CellValueChanged
        Try
            With gridView_Items
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub

    Private Sub gridView_Items_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        gridView_Items.BestFitColumns()
    End Sub

    Private Sub btn_Unit_Order_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unit_Order_Reload.ItemClick
        Load_Items()
    End Sub

    Private Sub btn_Unit_Order_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unit_Order_Add.ItemClick
        gridView_Items.AddNewRow()
    End Sub

    Private Sub Save_Item_List()
        With gridView_Items
            If .DataRowCount > 0 Then
                For i As Integer = 0 To .DataRowCount - 1
                    Dim iID As Integer
                    Try
                        If .GetRowCellValue(i, colID2).Equals(Nothing) Then Return
                        Try
                            iID = Convert.ToInt32(.GetRowCellValue(i, colID2))
                        Catch ex As Exception
                            iID = 0
                        End Try
                        Dim UnitParameters As SqlParameter() = {New SqlParameter("@req_ID", .GetRowCellValue(i, colID2)),
                                                                New SqlParameter("@batch_Id", .GetRowCellValue(i, colBatch_Id)),
                                                                New SqlParameter("@Branch_From", class_Saga_Variables.sBranchCode),
                                                                New SqlParameter("@Branch_Code", Xuc_SPA_SRF.Branch_From.EditValue),
                                                                New SqlParameter("@Reference", Xuc_SPA_SRF.Reference.EditValue),
                                                                New SqlParameter("@SRF_Number", Xuc_SPA_SRF.SRF_Number.Text),
                                                                New SqlParameter("@Parts_Number", .GetRowCellValue(i, colParts_Number)),
                                                                New SqlParameter("@Parts_Name", .GetRowCellValue(i, colParts_Name)),
                                                                New SqlParameter("@Brand", .GetRowCellValue(i, colBrand)),
                                                                New SqlParameter("@Category", .GetRowCellValue(i, colCategory)),
                                                                New SqlParameter("@Quantity", .GetRowCellValue(i, colQuantity)),
                                                                New SqlParameter("@SRP", .GetRowCellValue(i, colSRP)),
                                                                New SqlParameter("@Cost", .GetRowCellValue(i, colCost)),
                                                                New SqlParameter("@Sales_Summary", .GetRowCellValue(i, colSummary)),
                                                                New SqlParameter("@Inventory_Count", .GetRowCellValue(i, colInventory_Count)),
                                                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                                New SqlParameter("@Action_Type", "SAVE_ITEM")}
                        class_Database.Procedure_Save(class_Database.SPAConnection, UnitParameters, "spa_Spare_Parts_Request_Procedures", "Purchase Item Unit")
                    Catch ex As Exception
                    End Try
                Next

                Dim sqlParameters As SqlParameter() = {New SqlParameter("@Reference", Xuc_SPA_SRF.Reference.EditValue),
                                                    New SqlParameter("@Action_Type", "UPDATE")}
                class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Spare_Parts_Request_Procedures", "Update Purchase Order Profile")
            End If
        End With
    End Sub

    Private Sub btn_Unit_Order_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print_Report.ItemClick
        If class_Procedures.isEmpty(Xuc_SPA_SRF.Reference) Then Return

        Dim xRpt As New SagaSpareParts.xrpt_SPA_Request()
        class_Database.Bind_Report(class_Database.SPAConnection, xRpt, $"SELECT * FROM Spare_Parts_Request_Items WHERE Reference LIKE '{Xuc_SPA_SRF.Reference.EditValue}' ORDER BY PartsNumber", "Spare_Parts_Request_Items")

        Try
            With xRpt
                .PaperKind = System.Drawing.Printing.PaperKind.Custom
                .PageWidth = 850
                .PageHeight = 1100

                .XrTableCell_Branch.Text = class_Saga_Database.get_Branch_Name(class_Saga_Variables.sBranchCode)
                .XrTableCell_Address.Text = get_Branch_Address(class_Saga_Variables.sBranchCode)

                .XrTableCell_Reference.Text = Xuc_SPA_SRF.Reference.EditValue.ToString
                .XrTableCell_Transaction_Date.Text = Xuc_SPA_SRF.Transaction_Date.Text

                .Product_Version.Text = $"{class_Functions.Product_Name_Version} - IT Department"
            End With
        Catch ex As Exception
            class_Procedures.Show_Error(Ex)
        End Try
    End Sub

    Private Sub btn_Modify_Orders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Modify_Orders.ItemClick
        If Xuc_SPA_SRF.Control_Modify(Convert.ToInt32(gridView.GetFocusedRowCellValue(colID))) Then
            Xuc_SPA_SRF.Control_New(Xuc_Settings.Toggle_Clear_On_Action.IsOn, True)
        End If
    End Sub
    Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
        Dim sqlParameters As SqlParameter() = {New SqlParameter("@req_ID", gridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "APPROVAL")}
        If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Spare_Parts_Request_Procedures", "Send Stock Replenishment Form For Approval", Xuc_SPA_SRF.Reference.EditValue.ToString) Then
            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD", class_Saga_Variables.sBranchCode)
        End If
    End Sub

    Private Sub btn_DisApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Disapprove.ItemClick
        Dim sqlParameters As SqlParameter() = {New SqlParameter("@req_ID", gridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "DISAPPROVE")}
        If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Spare_Parts_Request_Procedures", "Disapprove/Reject Stock Replenishment Form", Xuc_SPA_SRF.Reference.EditValue.ToString) Then
            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD", class_Saga_Variables.sBranchCode)
        End If
    End Sub

    Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
        Dim sqlParameters As SqlParameter() = {New SqlParameter("@req_ID", gridView.GetFocusedRowCellValue(colID)),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "APPROVE")}
        If class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Spare_Parts_Request_Procedures", "Approve Stock Replenishment Form", Xuc_SPA_SRF.Reference.EditValue.ToString) Then
            If Xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD", class_Saga_Variables.sBranchCode)
        End If
    End Sub
End Class
