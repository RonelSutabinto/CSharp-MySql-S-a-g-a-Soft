Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Logistics

    Public Class frm_Purchase_Orders
        Public Sub New()
            If Me.xuc_Purchase_Order Is Nothing Then
                Me.xuc_Purchase_Order = New Controls.Logistics.xuc_Purchase_Order()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Purchase_Order.LayoutControl, xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Function Form_Close() As Boolean
            If xuc_Settings.Check_Save_Restore_Layout.Checked Then
                xuc_Purchase_Order_Units.gridView.SaveLayoutToRegistry(xuc_Purchase_Order_Units.Name)
                gridView_Summary.SaveLayoutToRegistry(gridView_Summary.Name)
            End If

            class_Tools.RegKeySet(Me.Name, xuc_Purchase_Order.Order_Date.Name, xuc_Purchase_Order.Order_Date.Text)

            Return class_Procedures.Form_Close(Me, BarManager, DockManager, gridView, xuc_Purchase_Order.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Purchase_Orders_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub frm_Purchase_Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            btn_Save.Enabled = class_Saga_Variables.isLogistics
            btn_Save_Order_Units.Enabled = class_Saga_Variables.isLogistics

            btn_Approval.Enabled = class_Saga_Variables.isLogistics
            btn_Approve.Enabled = class_Saga_Variables.isLogistics AndAlso class_Saga_Variables.isApprover

            Dim repositoryItemLookUpEdit_Branch As New RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Branch(repositoryItemLookUpEdit_Branch)

            class_Procedures.Initialize_gridView(gridView_Summary)
            colBranch_Code.ColumnEdit = repositoryItemLookUpEdit_Branch

            If xuc_Settings.Check_Save_Restore_Layout.Checked Then
                xuc_Purchase_Order_Units.gridView.RestoreLayoutFromRegistry(xuc_Purchase_Order_Units.Name)
                gridView_Summary.RestoreLayoutFromRegistry(gridView_Summary.Name)
            End If
        End Sub

        Private Sub frm_Purchase_Orders_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Purchase_Order.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load("LOAD")

            xuc_Purchase_Order.Order_Date.EditValue = class_Tools.RegKeyGet(Me.Name, xuc_Purchase_Order.Order_Date.Name, Date.Today)

            class_Saga_Variables.Initialize_Brands()
            class_Saga_Procedures.Initialize_Brand(RepositoryItemLookUpEdit_Brand_Code)
        End Sub

        Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Purchase_Order.Control_Initialize()
            class_Saga_Variables.Initialize_MC_Models(False, xuc_Purchase_Order.Brand_Code.Text.Trim, True)
        End Sub

        Private Sub Data_Load(ByVal sActionType As String, Optional ByVal sSearch As String = "")
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Search", sSearch),
                New SqlParameter("@Action_Type", sActionType)
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Purchase_Order_Procedures", "Purchase Orders")

            'gridView.ClearSorting()
            'colID.SortIndex = 0
            'colID.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load("LOAD")
        End Sub

        Private Sub btn_Reload_All_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_All.ItemClick
            Data_Load("LOAD_ALL")
        End Sub

        Private Sub btn_Reload_Modified_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Modified.ItemClick
            Data_Load("LOAD_MODIFIED")
        End Sub

        Private Sub btn_Reload_Deleted_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload_Deleted.ItemClick
            Data_Load("LOAD_DELETED")
        End Sub

        Friend Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                Data_Load("SEARCH", sSearch)
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Load_Search((CType(sender, BaseEdit)).Text.Trim)
            End If
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            Me.xuc_Purchase_Order.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
            xuc_Purchase_Order_Units.gridControl.DataSource = Nothing
        End Sub

        Private Sub btn_New_Wizard_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New_Wizard.ItemClick
            Dim wzform As New Forms.Logistics.wzFrm_Purchase_Order

            With wzform
                .Xuc_Purchase_Order.Control_Initialize()
                .Show()
            End With
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If Me.xuc_Purchase_Order.Control_Save() Then
                'Save_Item_List()
                If xuc_Settings.Toggle_Auto_Reload.IsOn Then
                    Data_Load("LOAD")
                End If
            End If
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            Me.xuc_Purchase_Order.Control_Delete()
        End Sub

        Private Sub btn_Unit_Order_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unit_Order_Add.ItemClick
            xuc_Purchase_Order_Units.gridView.AddNewRow()
        End Sub

        Private Sub btn_Save_Order_Units_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Order_Units.ItemClick
            If Me.xuc_Purchase_Order.Control_Save() Then
                xuc_Purchase_Order_Units.Save_Item_Orders()
                If xuc_Settings.Toggle_Auto_Reload.IsOn Then
                    Data_Load("LOAD")
                End If
            End If
        End Sub

        Private Sub btn_Recount_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Recount.ItemClick
            xuc_Purchase_Order_Units.MC_Order_Recount()
        End Sub

        Private Sub btn_MC_Units_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MC_Units.ItemClick
            class_Saga_Procedures.Show_MC_Order_Units(gridView.GetFocusedRowCellDisplayText(colOrder_Code), gridView.GetFocusedRowCellDisplayText(colOrder_Status), False, gridView.GetFocusedRowCellDisplayText(colBrand_Code), gridView.GetFocusedRowCellValue(colFreight_Cost), gridView.GetFocusedRowCellValue(colIs_Per_Unit))
        End Sub

        Private Sub Data_Show()
            With xuc_Purchase_Order
                .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                .Order_Code.Text = gridView.GetFocusedRowCellValue(colOrder_Code)
                .Purchase_Order_Code.Text = gridView.GetFocusedRowCellDisplayText(colPurchase_Order_Code)
                .Brand_Code.Text = gridView.GetFocusedRowCellDisplayText(colBrand_Code)
                .Order_Date.EditValue = gridView.GetFocusedRowCellValue(colOrder_Date)
                .Freight_Cost.EditValue = gridView.GetFocusedRowCellValue(colFreight_Cost)
                .Is_Per_Unit.EditValue = gridView.GetFocusedRowCellValue(colIs_Per_Unit)
                .Order_Description.Text = gridView.GetFocusedRowCellDisplayText(colOrder_Description)
                .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
            End With

            With xuc_Purchase_Order_Units
                .OrderCode = gridView.GetFocusedRowCellValue(colOrder_Code)
                .Status = gridView.GetFocusedRowCellDisplayText(colOrder_Status)
                .AllBrand = False
                .Brand = gridView.GetFocusedRowCellDisplayText(colBrand_Code)
                .FreightCost = gridView.GetFocusedRowCellValue(colFreight_Cost)
                .PerUnit = gridView.GetFocusedRowCellValue(colIs_Per_Unit)
            End With

            xuc_Purchase_Order_Units.Load_MC_Orders()

            Dim parametersSUM As SqlParameter() = {
                New SqlParameter("@Order_Code", gridView.GetFocusedRowCellDisplayText(colOrder_Code)),
                New SqlParameter("Action_Type", "LOAD_SUMMARY")
            }
            class_Database.Procedure_BindData(class_Database.ICSConnection, parametersSUM, gridControl_Summary, gridView_Summary, "inv_Purchase_Order_Procedures", "inv_Purchase_Order_Units")
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If (gridView.DataRowCount > 0) Then
                Select Case e.KeyValue
                    Case Keys.Delete
                        If class_Saga_Variables.isLogistics AndAlso xuc_Purchase_Order.Control_Delete Then
                            Try
                                gridView.DeleteSelectedRows()
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                            End Try
                        End If
                End Select
            End If
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                Dim sTatus As String = gridView.GetFocusedRowCellDisplayText(colOrder_Status)
                btn_Approval.Enabled = sTatus.Equals("PENDING") Or sTatus.Equals("DISAPPROVED")
                btn_DisApprove.Enabled = sTatus.Equals("FOR APPROVAL")
                btn_Approve.Enabled = sTatus.Equals("FOR APPROVAL")
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If e.Clicks.Equals(2) AndAlso gridView.DataRowCount > 0 Then
                Select Case e.Column.FieldName
                    Case "Order_Code"
                        class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                    Case "Total_Quantity"
                        If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE inv_Purchase_Orders SET Total_Quantity = 0 WHERE Order_Code LIKE '{gridView.GetFocusedRowCellDisplayText(colOrder_Code)}'") Then
                            gridView.SetFocusedRowCellValue(colTotal_Quantity, 0)
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Total Quantity was reset to Zero(0){Environment.NewLine}Please reload.", "Total Quantity")
                        End If

                    Case "Total_Received"
                        class_Saga_Procedures.Show_Unit_Inventory(xuc_Purchase_Order.Order_Code.EditValue)

                    Case Else
                        class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                        Data_Show()
                End Select
            End If
        End Sub

        Private Sub gridView_Summary_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView_Summary.RowCellClick
            If e.Clicks.Equals(2) AndAlso gridView_Summary.DataRowCount > 0 Then
                Select Case e.Column.FieldName
                    Case "Unit_Received"
                        Dim sOrderCode As String = gridView.GetFocusedRowCellDisplayText(colOrder_Code)
                        Dim sBrCode As String = gridView_Summary.GetFocusedRowCellValue(colBranch_Code)
                        Dim sModelCode As String = gridView_Summary.GetFocusedRowCellDisplayText(colModel_Code)
                        class_Saga_Procedures.Show_Unit_Inventory($"SELECT * FROM item_Details WHERE POno LIKE '{sOrderCode}' AND branchcode LIKE '{sBrCode}' AND Model_Code LIKE '{sModelCode}'", $"{sOrderCode} {sModelCode}")

                    Case Else
                        If e.CellValue IsNot Nothing Then
                            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                        End If
                        Data_Show()
                End Select
            End If
        End Sub

        Private Sub btn_Unit_Order_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Unit_Order_Preview.ItemClick
            If class_Procedures.isEmpty(xuc_Purchase_Order.Order_Code) Then Return

            Dim xRpt As New Reports.Logistics.xrpt_Purchase_Orders()
            class_Database.Bind_Report(class_Database.ICSConnection, xRpt, $"SELECT * FROM view_Purchase_Order_Units WHERE Order_Code LIKE '{xuc_Purchase_Order.Order_Code.EditValue}' ORDER BY Model_Name", "view_Purchase_Order_Units")

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 1300
                    .PageHeight = 850

                    .Brand.Text = xuc_Purchase_Order.Brand_Code.Text
                    .Dealer.Text = xuc_Purchase_Order.Supplier_Name.Text
                    .Address.Text = xuc_Purchase_Order.Brand_Code.GetColumnValue("Account_Address")

                    .Order_Code.Text = xuc_Purchase_Order.Order_Code.EditValue.ToString
                    .Order_Date.Text = xuc_Purchase_Order.Order_Date.Text
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Purchase_Order_Received_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Purchase_Order_Received.ItemClick
            If class_Procedures.isEmpty(xuc_Purchase_Order.Order_Code) Then Return

            Dim xRpt As New Reports.Logistics.xrpt_Purchase_Order_Received()

            Try
                With xRpt
                    .Landscape = True
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageHeight = 850
                    .PageWidth = 1300

                    .Brand.Text = xuc_Purchase_Order.Brand_Code.Text
                    .Dealer.Text = xuc_Purchase_Order.Supplier_Name.Text
                    .Address.Text = xuc_Purchase_Order.Brand_Code.GetColumnValue("Account_Address")
                End With

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Order_Code", gridView.GetFocusedRowCellValue(colOrder_Code)),
                    New SqlParameter("@Action_Type", "LOAD_PO_DR")
                }
                class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_Purchase_Order_Procedures", "inv_Purchase_Order_Units")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Purchase_Order_Monitoring_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Purchase_Order_Monitoring.ItemClick
            If class_Procedures.isEmpty(xuc_Purchase_Order.Order_Code) Then Return

            Dim xRpt As New Reports.Logistics.xrpt_Purchase_Order_Monitoring()

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .Landscape = True
                    .PageHeight = 850
                    .PageWidth = 1300

                    .Brand.Text = xuc_Purchase_Order.Brand_Code.Text
                    .Dealer.Text = xuc_Purchase_Order.Supplier_Name.Text
                    .Address.Text = xuc_Purchase_Order.Brand_Code.GetColumnValue("Account_Address")

                    .Branch_Address.Text = class_Saga_Database.get_Branch_Address("000")
                    .PO_From.Text = $"{class_Saga_Variables.dtStart:MMMM dd, yyyy}"
                    .PO_To.Text = $"{class_Saga_Variables.dtEnd:MMMM dd, yyyy}"
                End With

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Brand_Code", gridView.GetFocusedRowCellValue(colBrand_Code)),
                    New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                    New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                    New SqlParameter("@Action_Type", "LOAD_PO_MONITORING")
                }
                class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_Purchase_Order_Procedures", "inv_Purchase_Orders")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Purchase_Order_Summary_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Purchase_Order_Summary.ItemClick
            If class_Procedures.isEmpty(xuc_Purchase_Order.Order_Code) Then Return

            Dim xRpt As New Reports.Logistics.xrpt_Purchase_Order_Summary()

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageHeight = 850
                    .PageWidth = 1300

                    .Date_From.Text = $"{class_Saga_Variables.dtStart:MMM dd, yyyy}"
                    .Date_To.Text = $"{class_Saga_Variables.dtEnd:MMM dd, yyyy}"
                End With

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Brand_Code", gridView.GetFocusedRowCellValue(colBrand_Code)),
                    New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                    New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                    New SqlParameter("@Action_Type", "LOAD_PO_SUMMARY")
                }
                class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_Purchase_Order_Procedures", "inv_Purchase_Orders")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Modify_Orders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Modify_Orders.ItemClick
            If xuc_Purchase_Order.Control_Modify(gridView.GetFocusedRowCellValue(colOrder_Code)) Then
                xuc_Purchase_Order.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn, True)
            End If
        End Sub

        Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
            If class_Saga_Database.Update_Transaction_Status("inv_Purchase_Order_Procedures", "APPROVAL", gridView.GetFocusedRowCellValue(colID), "@Order_Code", gridView.GetFocusedRowCellDisplayText(colOrder_Code), "Send Purchase Orders For Approval") AndAlso
                xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load("LOAD")
            End If
        End Sub

        Private Sub btn_DisApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DisApprove.ItemClick
            If class_Saga_Database.Update_Transaction_Status("inv_Purchase_Order_Procedures", "DISAPPROVE", gridView.GetFocusedRowCellValue(colID), "@Order_Code", gridView.GetFocusedRowCellDisplayText(colOrder_Code), "Disapprove/Reject Purchase Orders") AndAlso
                xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load("LOAD")
            End If
        End Sub

        Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
            If class_Saga_Database.Update_Transaction_Status("inv_Purchase_Order_Procedures", "APPROVE", gridView.GetFocusedRowCellValue(colID), "@Order_Code", gridView.GetFocusedRowCellDisplayText(colOrder_Code), "Approve Purchase Orders") AndAlso
                xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load("LOAD")
            End If
        End Sub


    End Class

End Namespace