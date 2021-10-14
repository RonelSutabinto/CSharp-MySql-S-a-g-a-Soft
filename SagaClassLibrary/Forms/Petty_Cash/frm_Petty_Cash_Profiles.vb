Imports DevExpress.XtraEditors.Repository
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Petty_Cash

    Public Class frm_Petty_Cash_Transactions_Profiles

        Sub New()
            If Me.xuc_Petty_Cash_Profile Is Nothing Then
                Me.xuc_Petty_Cash_Profile = New Controls.Petty_Cash.xuc_Petty_Cash_Profile()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Petty_Cash_Profile.LayoutControl, xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(Me, barManager)
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, DockManager, gridView, xuc_Petty_Cash_Profile.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Petty_Cash_Transactions_Profiles_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub frm_Petty_Cash_Transactions_Profiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit_Branch)
            colBranch_Code.ColumnEdit = RepositoryItemLookUpEdit_Branch

            Dim RepositoryItemLookUpEdit_Corporation = New RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Corporation(RepositoryItemLookUpEdit_Corporation, True)
            colProfile_Corporation.ColumnEdit = RepositoryItemLookUpEdit_Corporation

            Dim RepositoryItemLookUpEdit_COA = New RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_COA(RepositoryItemLookUpEdit_COA, eCOA_Type.COA_All)
            colCOA_Code.ColumnEdit = RepositoryItemLookUpEdit_COA
        End Sub

        Private Sub frm_Petty_Cash_Transactions_Profiles_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Petty_Cash_Profile.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            Me.xuc_Petty_Cash_Profile.Control_Initialize()
        End Sub

        Private Sub Data_Load()
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Action_Type", "LOAD_PROFILES")
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GridControl, gridView, "acc_Petty_Cash_Procedures", "Petty Cash Profiles")
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Petty_Cash_Profile.Select()
            Me.xuc_Petty_Cash_Profile.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If Me.xuc_Petty_Cash_Profile.Control_Save() Then
                If xuc_Settings.Toggle_Auto_Reload.IsOn Then
                    Data_Load()
                Else
                    Update_Data_Row()
                End If
            End If
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            Me.xuc_Petty_Cash_Profile.Control_Delete()
        End Sub

        Private Sub Data_Show()
            With xuc_Petty_Cash_Profile
                .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                .Petty_Cash_Code.Text = gridView.GetFocusedRowCellValue(colPetty_Cash_Code)
                .Branch_Code.EditValue = gridView.GetFocusedRowCellValue(colBranch_Code)
                .Profile_Code.EditValue = gridView.GetFocusedRowCellValue(colProfile_Code)
                .Category_Ceiling.Value = gridView.GetFocusedRowCellValue(colCategory_Ceiling)
                .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
            End With
        End Sub

        Private Sub Update_Data_Row()
            If gridView.RowCount > 0 Then
                With gridView
                    .SetFocusedRowCellValue(colID, xuc_Petty_Cash_Profile.ID.EditValue)
                    .SetFocusedRowCellValue(colPetty_Cash_Code, xuc_Petty_Cash_Profile.Petty_Cash_Code.Text)
                    .SetFocusedRowCellValue(colBranch_Code, xuc_Petty_Cash_Profile.Branch_Code.EditValue)
                    .SetFocusedRowCellValue(colCategory_Ceiling, xuc_Petty_Cash_Profile.Category_Ceiling.Value)
                    .SetFocusedRowCellValue(colNotes, xuc_Petty_Cash_Profile.Notes.Text)
                End With
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If e.Clicks.Equals(2) AndAlso gridView.DataRowCount > 0 Then
                Select Case e.Column.FieldName
                    Case "Profile_Code"
                        class_Saga_Procedures.Show_Journal_Profile(e.CellValue.ToString)

                    Case Else
                        Data_Show()
                End Select
            End If
        End Sub

    End Class

End Namespace