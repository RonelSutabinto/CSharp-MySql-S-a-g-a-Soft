Imports DevExpress.XtraEditors.Repository
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Management

    Public Class frm_Branches
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If Me.xuc_Branch Is Nothing Then
                Me.xuc_Branch = New Controls.Management.xuc_Branch()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, xuc_Branch.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager)

        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Branches_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim employeeRepositoryItemLookUpEdit As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Employee(employeeRepositoryItemLookUpEdit)
            colBranch_Manager.ColumnEdit = employeeRepositoryItemLookUpEdit
            colBranch_Admin.ColumnEdit = employeeRepositoryItemLookUpEdit
        End Sub

        Private Sub frm_Branches_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Branch.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, xuc_Branch.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Branches_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Branch.Control_Initialize()
        End Sub

        Private Sub Data_Load()
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, "SELECT * FROM BranchParameters", "BranchParameters")
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Branch.Control_New()
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            xuc_Branch.Control_Save()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then
                Data_Load()
            Else
                Update_Data_Row()
            End If
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            With gridView
                class_Procedures.splash_Show("Updating Branch Ceiling")

                Dim iRowHandleOld As Integer

                .ClearSelection()

                For i As Integer = 0 To .DataRowCount - 1
                    If class_Functions.gridView_Loop(gridView, iRowHandleOld, i, "Update Branch ceiling", "updated", False) Then
                        iRowHandleOld = i
                    Else Return
                    End If

                    Dim sBrCode As String = .GetRowCellValue(i, colBranchCode)

                    Dim sqlParameters As SqlParameter() = {
                        New SqlParameter("@Branch_Code", sBrCode),
                        New SqlParameter("@Modified_By", class_Variables.sUserName),
                        New SqlParameter("@Action_Type", "UPDATE_CEILING")
                    }
                    class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Procedures", "Update Branch ceiling")
                Next

                Data_Load()
                class_Procedures.splash_Close()
            End With
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Branch
                    Try
                        .ID.EditValue = gridView.GetFocusedRowCellValue(colID)
                        .Branch_Area.EditValue = $"AREA-{gridView.GetFocusedRowCellDisplayText(colBranch_Area)}"
                        .Branch_Code.EditValue = gridView.GetFocusedRowCellDisplayText(colBranchCode)
                        .Pre_Code.Text = gridView.GetFocusedRowCellDisplayText(colPre_Code)
                        .Branch_Name.Text = gridView.GetFocusedRowCellDisplayText(colBranch)
                        .Branch_Local.Text = gridView.GetFocusedRowCellDisplayText(colBranch_Local)
                        .Branch_Address.Text = gridView.GetFocusedRowCellDisplayText(colAddress)
                        .Branch_Manager.Text = gridView.GetFocusedRowCellDisplayText(colBranch_Manager)
                        .Branch_Admin.Text = gridView.GetFocusedRowCellDisplayText(colBranch_Admin)
                        .LTO_Payable.Value = gridView.GetFocusedRowCellValue(colLTO_Payable)
                        .Insurance.Value = gridView.GetFocusedRowCellValue(colInsurance)
                        .Notarial_Fee.Value = gridView.GetFocusedRowCellValue(colNotarial_Fee)
                        .Petty_Cash_Budget.Value = gridView.GetFocusedRowCellValue(colPetty_Cash_Budget)
                        .Petty_Cash_Replenish.Value = gridView.GetFocusedRowCellValue(colPetty_Cash_Replenish)
                        .For_Approval.Value = gridView.GetFocusedRowCellValue(colFor_Approval)
                        .For_Liquidation.Value = gridView.GetFocusedRowCellValue(colFor_Liquidation)
                        .Petty_Cash_Balance.Value = gridView.GetFocusedRowCellValue(colPetty_Cash_Balance)
                        .CTC_Number.Text = gridView.GetFocusedRowCellDisplayText(colCTC_Number)
                        .CTC_Date.EditValue = gridView.GetFocusedRowCellValue(colCTC_Date)
                        .CTC_Place.Text = gridView.GetFocusedRowCellDisplayText(colCTC_Place)
                        .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    End Try
                End With
            End If
        End Sub

        Private Sub Update_Data_Row()
            If gridView.RowCount > 0 Then
                With gridView
                    .SetFocusedRowCellValue(colBranchCode, xuc_Branch.Branch_Code.EditValue)
                    .SetFocusedRowCellValue(colPre_Code, xuc_Branch.Pre_Code.Text)
                    .SetFocusedRowCellValue(colBranch, xuc_Branch.Branch_Name.Text)
                    .SetFocusedRowCellValue(colAddress, xuc_Branch.Branch_Address.Text)
                    .SetFocusedRowCellValue(colBranch_Area, xuc_Branch.Branch_Area.EditValue)
                    .SetFocusedRowCellValue(colBranch_Manager, xuc_Branch.Branch_Manager.EditValue)
                    .SetFocusedRowCellValue(colBranch_Admin, xuc_Branch.Branch_Admin.EditValue)
                    .SetFocusedRowCellValue(colLTO_Payable, xuc_Branch.LTO_Payable.Value)
                    .SetFocusedRowCellValue(colInsurance, xuc_Branch.Insurance.Value)
                    .SetFocusedRowCellValue(colNotarial_Fee, xuc_Branch.Notarial_Fee.Value)
                    .SetFocusedRowCellValue(colPetty_Cash_Budget, xuc_Branch.Petty_Cash_Budget.Value)
                    .SetFocusedRowCellValue(colPetty_Cash_Replenish, xuc_Branch.Petty_Cash_Replenish.Value)
                    .SetFocusedRowCellValue(colFor_Approval, xuc_Branch.For_Approval.Value)
                    .SetFocusedRowCellValue(colFor_Liquidation, xuc_Branch.For_Liquidation.Value)
                    .SetFocusedRowCellValue(colPetty_Cash_Balance, xuc_Branch.Petty_Cash_Balance.Value)
                    .SetFocusedRowCellValue(colCTC_Number, xuc_Branch.CTC_Number.Text)
                    .SetFocusedRowCellValue(colCTC_Date, xuc_Branch.CTC_Date.EditValue)
                    .SetFocusedRowCellValue(colCTC_Place, xuc_Branch.CTC_Place.Text)
                    .SetFocusedRowCellValue(colNotes, xuc_Branch.Notes.Text)
                End With
            End If
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then Data_Show()
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

    End Class

End Namespace