Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Logistics

    Public Class frm_Inclusion_Inventory
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If xuc_Inclusion_Inventory Is Nothing Then
                Me.xuc_Inclusion_Inventory = New Controls.Logistics.xuc_Inclusion_Inventory()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, xuc_Inclusion_Inventory.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)

        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Inclusions_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub frm_Inclusions_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Inclusion_Inventory.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, xuc_Inclusion_Inventory.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Inclusions_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Inclusion_Inventory.Control_Initialize()
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
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Action_Type", "LOAD_INC_INV")
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "inv_Inclusion_Procedures", "Inclusions")
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
                With xuc_Inclusion_Inventory
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                    .Inclusion_Code.EditValue = gridView.GetFocusedRowCellDisplayText(colInclusion_Code)
                    .Inventory_Code.Text = gridView.GetFocusedRowCellDisplayText(colInventory_Code)
                    .Engine.Text = gridView.GetFocusedRowCellDisplayText(colEngine)
                    .Description.Text = gridView.GetFocusedRowCellDisplayText(colDescription)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                End With
            End If
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If gridView.DataRowCount > 0 AndAlso e.Clicks.Equals(2) Then
                Data_Show()
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then Data_Show()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Inclusion_Inventory.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Receive_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Receive.ItemClick
            If xuc_Inclusion_Inventory.Control_Receive() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Inclusion_Inventory.Control_Save(xuc_Inclusion_Inventory.ID.EditValue) AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            'If xuc_Inclusion_Inventory.Control_Delete() Then
            '    gridView.DeleteRow(gridView.FocusedRowHandle)
            'End If
        End Sub
    End Class

End Namespace