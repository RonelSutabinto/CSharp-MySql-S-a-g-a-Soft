Imports DevExpress.XtraBars
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Information.Item

    Partial Public Class frm_Unit_Models
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If Me.xuc_Item Is Nothing Then
                Me.xuc_Item = New Controls.Information.Item.xuc_Item()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, xuc_Item.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Unit_Models_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub frm_Unit_Models_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Item.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, xuc_Item.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Unit_Models_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub Data_Load()
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Action_Type", "LOAD")
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Model_Procedures", "Unit Item Models")
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Item.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                Try
                    With xuc_Item
                        .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                        .Model_Status.IsOn = gridView.GetFocusedRowCellValue(colModel_Status)
                        .Model_Code.Text = $"MODEL-{ .ID.EditValue}"
                        .Model_Code.Text = gridView.GetFocusedRowCellDisplayText(colModel_Code)
                        .Item_Group.Text = gridView.GetFocusedRowCellDisplayText(colItem_Group)
                        .Product_Type.Text = gridView.GetFocusedRowCellDisplayText(colProduct_Type)
                        .Brand.Text = gridView.GetFocusedRowCellDisplayText(colBrand)
                        .Model.Text = gridView.GetFocusedRowCellDisplayText(colModel)
                        .Sub_Model.Text = gridView.GetFocusedRowCellDisplayText(colSubModel)
                        .Color.Text = gridView.GetFocusedRowCellDisplayText(colColor)
                        .Custom_Color.Text = gridView.GetFocusedRowCellDisplayText(colCustom_Color)
                        .Description.Text = gridView.GetFocusedRowCellDisplayText(colDescription)
                        .Engine_Prefix.Text = gridView.GetFocusedRowCellDisplayText(colEnginePrefix)
                        .Chassis_Prefix.Text = gridView.GetFocusedRowCellDisplayText(colChassisPrefix)
                        .Unit_Cost.Value = gridView.GetFocusedRowCellValue(colUnit_Cost)
                        .Unit_SRP.Value = gridView.GetFocusedRowCellValue(colUnit_SRP)
                        .COD.Value = gridView.GetFocusedRowCellValue(colCOD)
                        .Down_Payment.Value = gridView.GetFocusedRowCellValue(colDownPayment)
                        .AOC.Value = gridView.GetFocusedRowCellValue(colAOC)
                        .LCP.Value = gridView.GetFocusedRowCellValue(colLCP)
                        .Financed.Value = gridView.GetFocusedRowCellValue(colFinanced)
                        .Rebates.Value = gridView.GetFocusedRowCellValue(colRebate)
                        .Interest_Rate_12.Value = gridView.GetFocusedRowCellValue(colInterestRate12)
                        .Monthly_12.Value = gridView.GetFocusedRowCellValue(colMonthly12)
                        .Interest_Rate_18.Value = gridView.GetFocusedRowCellValue(colInterestRate18)
                        .Monthly_18.Value = gridView.GetFocusedRowCellValue(colMonthly18)
                        .Interest_Rate_24.Value = gridView.GetFocusedRowCellValue(colInterestRate24)
                        .Monthly_24.Value = gridView.GetFocusedRowCellValue(colMonthly24)
                        .Interest_Rate_36.Value = gridView.GetFocusedRowCellValue(colInterestRate36)
                        .Monthly_36.Value = gridView.GetFocusedRowCellValue(colMonthly36)
                        .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                    End With
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown

        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Item.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Item.Control_Save() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Delete.ItemClick
            If xuc_Item.Control_Delete() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub btn_Update_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    If xuc_Settings.Toggle_Clear_Selection.IsOn Then .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "MC Model Unit Cost updating", "updated", False) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sqlParameters As SqlParameter() = {
                            New SqlParameter("@Model_Code", .GetRowCellDisplayText(iRowHandle, colModel_Code)),
                            New SqlParameter("@Action_Type", "UPDATE_UNIT_COST")
                        }
                        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Model_Procedures", "Update Model Unit Cost")
                    Next
                End If
            End With
        End Sub


    End Class

End Namespace