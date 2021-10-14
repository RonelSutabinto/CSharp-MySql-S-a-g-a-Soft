Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Logistics
    Public Class frm_MC_Requests
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If xuc_MC_Request Is Nothing Then
                Me.xuc_MC_Request = New Controls.Logistics.xuc_MC_Request()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, xuc_MC_Request.LayoutControl, xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_MC_Requests_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit_Branch)

            If xuc_Settings.Check_Save_Restore_Layout.Checked Then
                xuc_Purchase_Order_Units.gridView.RestoreLayoutFromRegistry(xuc_Purchase_Order_Units.Name)
            End If
        End Sub

        Private Sub frm_MC_Requests_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then
                xuc_MC_Request.Control_Initialize()
            End If
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Function Form_Close() As Boolean
            If xuc_Settings.Check_Save_Restore_Layout.Checked Then
                xuc_Purchase_Order_Units.gridView.SaveLayoutToRegistry(xuc_Purchase_Order_Units.Name)
            End If

            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, xuc_MC_Request.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_MC_Requests_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_MC_Request.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                'class_Database.BindData(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM Inclusion WHERE InclusionName LIKE '%{sSearch}%' OR InclusionAddress LIKE '%{sSearch}%'", "Inclusion")
            End If
        End Sub

        Private Sub Data_Load()
            Dim sActionType As String

            If xuc_Settings.Toggle_Load_All.IsOn Then
                If class_Saga_Variables.sBranchCode.Equals("000") Then
                    sActionType = "LOAD_ALL"
                Else
                    sActionType = "LOAD_BRANCH"
                End If
            Else
                sActionType = "LOAD_USER"
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", sActionType)
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_MC_Request_Procedures", "MC Requests")
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Try
                    Load_Search((CType(sender, BaseEdit)).Text.Trim)
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                Dim sStatus As String = gridView.GetFocusedRowCellDisplayText(colRequest_Status)
                btn_Save.Enabled = sStatus.Equals("PENDING") Or sStatus.Equals("DISAPPROVED")
                btn_Delete.Enabled = sStatus.Equals("PENDING") Or sStatus.Equals("DISAPPROVED")

                With xuc_MC_Request
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                    .Request_Code.EditValue = gridView.GetFocusedRowCellDisplayText(colRequest_Code)
                    .Supplier_Code.EditValue = gridView.GetFocusedRowCellValue(colSupplier_Code)
                    .Branch_Code.EditValue = gridView.GetFocusedRowCellValue(colBranch_Code)
                    .WHCode.EditValue = gridView.GetFocusedRowCellDisplayText(colWHCode)
                    .Request_Description.Text = gridView.GetFocusedRowCellDisplayText(colRequest_Description)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                End With

                With xuc_Purchase_Order_Units
                    .OrderCode = gridView.GetFocusedRowCellDisplayText(colRequest_Code)
                    .Status = gridView.GetFocusedRowCellDisplayText(colRequest_Status)
                    .AllBrand = True

                    .Load_MC_Orders()
                End With
            End If
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                Dim sStatus As String = gridView.GetFocusedRowCellDisplayText(colRequest_Status)
                btn_Approval.Enabled = sStatus.Equals("PENDING") Or sStatus.Equals("DISAPPROVED")
                btn_Approve.Enabled = sStatus.Equals("FOR APPROVAL")
                btn_DisApprove.Enabled = btn_Approve.Enabled

                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If gridView.DataRowCount > 0 AndAlso e.Clicks.Equals(2) Then
                Select Case e.Column.FieldName
                    Case "Request_Code"
                        class_Saga_Procedures.Show_MC_Order_Units(gridView.GetFocusedRowCellDisplayText(colRequest_Code), gridView.GetFocusedRowCellDisplayText(colRequest_Status))

                    Case Else
                        If e.CellValue IsNot Nothing Then
                            class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                            Data_Show()
                        End If
                End Select
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then Data_Show()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_MC_Request.Control_New(True, xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_New_Wizard_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New_Wizard.ItemClick
            Dim wzform As New Forms.Logistics.wzFrm_MC_Request

            With wzform
                .Xuc_MC_Request.Control_Initialize()
                .Show()
            End With
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_MC_Request.Control_Save(xuc_MC_Request.ID.EditValue) AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load()
            End If
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Preview_MC_Request_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview_MC_Request.ItemClick
            Dim xRpt As New Reports.Logistics.xrpt_MC_Requests()

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageHeight = 1100
                    .PageWidth = 850

                    .Branch_From_To.Text = $"{gridView.GetFocusedRowCellDisplayText(colSupplier_Code)} - {gridView.GetFocusedRowCellDisplayText(colBranch_Code)}"
                End With

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Request_Code", gridView.GetFocusedRowCellDisplayText(colRequest_Code)),
                    New SqlParameter("@Action_Type", "LOAD_MC_UNITS")
                }
                class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_MC_Request_Procedures", "inv_Purchase_Order_Units")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            If gridView.SelectedRowsCount.Equals(1) Then
                If xuc_MC_Request.Control_Delete(gridView.GetFocusedRowCellValue(colID)) Then
                    gridView.DeleteRow(gridView.FocusedRowHandle)
                End If
            End If
        End Sub

        Private Sub btn_MC_Units_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_MC_Units.ItemClick
            class_Saga_Procedures.Show_MC_Order_Units(gridView.GetFocusedRowCellDisplayText(colRequest_Code), gridView.GetFocusedRowCellDisplayText(colRequest_Status))
        End Sub

        Private Sub btn_Approval_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approval.ItemClick
            If class_Saga_Database.Update_Transaction_Status("inv_MC_Request_Procedures", "APPROVAL", gridView.GetFocusedRowCellValue(colID), "@Request_Code", gridView.GetFocusedRowCellDisplayText(colRequest_Code), "Send Purchase Orders For Approval") AndAlso
                xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load()
            End If
        End Sub

        Private Sub btn_DisApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DisApprove.ItemClick
            If class_Saga_Database.Update_Transaction_Status("inv_MC_Request_Procedures", "DISAPPROVE", gridView.GetFocusedRowCellValue(colID), "@Request_Code", gridView.GetFocusedRowCellDisplayText(colRequest_Code), "Disapprove/Reject Purchase Orders") AndAlso
                xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load()
            End If
        End Sub

        Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
            If class_Saga_Database.Update_Transaction_Status("inv_MC_Request_Procedures", "APPROVE", gridView.GetFocusedRowCellValue(colID), "@Request_Code", gridView.GetFocusedRowCellDisplayText(colRequest_Code), "Approve Purchase Orders") AndAlso
                xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load()
            End If
        End Sub
    End Class

End Namespace