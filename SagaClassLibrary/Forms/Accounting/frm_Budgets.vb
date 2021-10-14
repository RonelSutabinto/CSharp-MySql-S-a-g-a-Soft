Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_Budgets

        Sub New()
            If Me.xuc_Budget Is Nothing Then
                Me.xuc_Budget = New Controls.Accounting.xuc_Budget()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Budget.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Budgets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            class_Procedures.Initialize_gridView(gridView_Ledger)
            gridView_Ledger.RestoreLayoutFromRegistry(gridView_Ledger.Name)

            btn_Save.Enabled = class_Saga_Variables.isAccounting
            btn_Delete.Enabled = class_Saga_Variables.isAccounting
        End Sub

        Private Sub frm_Budgets_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Budget.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Function Form_Close() As Boolean
            gridView_Ledger.SaveLayoutToRegistry(gridView_Ledger.Name)
            Return class_Procedures.Form_Close(Me, barManager, DockManager, gridView, xuc_Budget.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Budgets_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Budget.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub Data_Load()
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, "SELECT * FROM acc_Budgets", "acc_Budgets")
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

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then

                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM acc_Budgets WHERE Budget_Name LIKE '%{sSearch}%' OR Budget_Description LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%'", "acc_Budgets")
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If gridView.DataRowCount > 0 AndAlso xuc_Settings.Toggle_Select.IsOn Then
                Data_Show()
            End If
        End Sub

        Private Sub gridView_Ledger_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView_Ledger.RowCellClick
            If gridView.DataRowCount > 0 AndAlso e.Clicks.Equals(2) Then
                Select Case e.Column.Name
                    Case "colVoucher_Code"
                        class_Saga_Procedures.Show_Voucher(e.CellValue.ToString)

                    Case "colVoucher_Reference"
                        class_Saga_Procedures.Show_Journal_Entries_Reference(e.CellValue.ToString)

                    Case Else
                        class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                End Select
            End If
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Budget
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                    .Budget_Code.Text = gridView.GetFocusedRowCellDisplayText(colBudget_Code)
                    .Budget_Name.Text = gridView.GetFocusedRowCellDisplayText(colBudget_Name)
                    .Budget_Amount.Text = gridView.GetFocusedRowCellDisplayText(colBudget_Amount)
                    .Budget_Amount.ReadOnly = True
                    .Budget_Balance.Text = gridView.GetFocusedRowCellDisplayText(colBudget_Balance)
                    .Budget_Description.Text = gridView.GetFocusedRowCellDisplayText(colBudget_Description)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                End With

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Budget_Code", xuc_Budget.Budget_Code.Text),
                    New SqlParameter("@Action_Type", "LOAD")
                }

                class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl_Ledger, gridView_Ledger, "acc_Budget_Procedures", "Budget Ledger")
            End If
        End Sub

        Private Sub Update_Data_Row()
            If gridView.RowCount > 0 Then
                With gridView
                    .SetFocusedRowCellValue(colBudget_Code, xuc_Budget.Budget_Code.Text)
                    .SetFocusedRowCellValue(colBudget_Name, xuc_Budget.Budget_Name.Text)
                    .SetFocusedRowCellValue(colBudget_Amount, xuc_Budget.Budget_Amount.EditValue)
                    .SetFocusedRowCellValue(colBudget_Description, xuc_Budget.Budget_Description.Text)
                    .SetFocusedRowCellValue(colNotes, xuc_Budget.Notes.Text)
                End With
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If gridView.DataRowCount > 0 And gridView.SelectedRowsCount > 0 Then
                Select Case e.KeyValue
                    Case Keys.Enter
                        Data_Show()

                    Case Keys.F2
                        Me.xuc_Budget.Select()

                End Select
            End If
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Budget.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Budget.Control_Save() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then
                btn_Reload_ItemClick(sender, e)
            Else
                Update_Data_Row()
            End If
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Add_Debit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Add_Debit.ItemClick
            If Me.xuc_Budget.Add_Debit(Me.xuc_Budget.Budget_Code.Text, class_Functions.Show_Input_Box("Input Debit Amount", "New Budget Debit", 0), class_Functions.Show_Input_Box("Input Debit Description", "New Debit Description", String.Empty)) Then
                'class_Saga_Variables.Initialize_Budgets()
                Data_Show()
            End If
        End Sub

        Private Sub gridView_Ledger_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView_Ledger.KeyDown
            If gridView_Ledger.DataRowCount > 0 Then
                Select Case e.KeyValue
                    Case Keys.Delete
                        If class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM acc_Budget_Ledger WHERE ID LIKE '{gridView_Ledger.GetFocusedRowCellValue(colID)}'", "Delete Budget Ledger") Then
                            Data_Show()
                        End If
                End Select
            End If
        End Sub

    End Class

End Namespace