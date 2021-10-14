Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_Journal_Profiles
        Friend bLoopStop As Boolean

        Public Sub New()
            If Me.xuc_Journal_Profile Is Nothing Then
                Me.xuc_Journal_Profile = New Controls.Accounting.xuc_Journal_Profile()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Journal_Profile.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Journal_Profiles_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Corporation(RepositoryItemLookUpEdit_Corporation, True)
            xuc_Journal_Profile.Control_New(False)

            btn_Save.Enabled = class_Saga_Variables.isAccounting
            btn_Delete.Enabled = class_Saga_Variables.isAccounting
        End Sub

        Private Sub frm_Journal_Profiles_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Journal_Profile.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, DockManager, gridView, xuc_Journal_Profile.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Journal_Profiles_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Journal_Profile.Control_Initialize()
        End Sub

        Private Sub Data_Load()
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM view_Journal_Profiles", "view_Journal_Profiles")
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
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

                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM view_Journal_Profiles WHERE Payment_Code LIKE '%{sSearch}%' OR Profile_Name LIKE '%{sSearch}%' OR Profile_Description LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%'", "view_Journal_Profiles")
            End If
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            If gridView.RowCount > 0 Then gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Journal_Profile.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Journal_Profile.Control_Save() Then
                If Me.xuc_Settings.Toggle_Auto_Reload.IsOn Then
                    Data_Load()
                Else
                    Update_Data_Row()
                End If
            End If
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            'If xuc_Journal_Profile.Control_Delete() Then gridView.DeleteRow(gridView.FocusedRowHandle)
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            With gridView
                If .DataRowCount > 0 And .SelectedRowsCount > 0 Then
                    Select Case e.KeyValue
                        Case Keys.Delete
                            If Not class_Procedures.actionAsk("Delete Journal transaction(s)", "delete some Journal transactions") Then Return
                            class_Procedures.splash_Show("Deleting Journal Entry/Entries")

                            Dim iRowHandle, iRowHandleOld As Integer
                            Dim selectedRows As Integer() = .GetSelectedRows()

                            For i As Integer = 0 To selectedRows.Length - 1
                                iRowHandle = selectedRows(i)

                                If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Pofile", "deleted", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn, True) Then
                                    iRowHandleOld = iRowHandle
                                Else Return
                                End If
                            Next

                            .DeleteSelectedRows()
                            class_Procedures.splash_Close()
                    End Select
                End If
            End With
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If gridView.DataRowCount > 0 Then
                If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
            End If
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Journal_Profile
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                    .Profile_Corporation.Text = gridView.GetFocusedRowCellDisplayText(colProfile_Corporation)
                    .Profile_Code.Text = gridView.GetFocusedRowCellDisplayText(colProfile_Code)
                    .Profile_Type.Text = gridView.GetFocusedRowCellDisplayText(colProfile_Type)
                    .Payment_Code.Text = gridView.GetFocusedRowCellDisplayText(colPayment_Code)
                    .Profile_Name.Text = gridView.GetFocusedRowCellDisplayText(colProfile_Name)
                    .Friendly_Name.Text = gridView.GetFocusedRowCellDisplayText(colFriendly_Name)
                    .Journal_Type.Text = gridView.GetFocusedRowCellDisplayText(colJournal_Type)
                    .COA_Code.EditValue = gridView.GetFocusedRowCellDisplayText(colCOA_Code)
                    .Custom_COA.EditValue = (gridView.GetFocusedRowCellValue(colCustom_COA))
                    .Profile_VAT.EditValue = (gridView.GetFocusedRowCellValue(colProfile_VAT))
                    .Profile_Description.Text = gridView.GetFocusedRowCellDisplayText(colProfile_Description)
                    .Balance_Type.Text = gridView.GetFocusedRowCellDisplayText(colBalance_Type)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                End With
            End If
        End Sub

        Private Sub Update_Data_Row()
            With gridView
                .SetFocusedRowCellValue(colProfile_Corporation, xuc_Journal_Profile.Profile_Corporation.EditValue)
                .SetFocusedRowCellValue(colProfile_Code, xuc_Journal_Profile.Profile_Code.Text)
                .SetFocusedRowCellValue(colProfile_Type, xuc_Journal_Profile.Profile_Type.Text)
                .SetFocusedRowCellValue(colPayment_Code, xuc_Journal_Profile.Payment_Code.Text)
                .SetFocusedRowCellValue(colJournal_Type, xuc_Journal_Profile.Journal_Type.Text)
                .SetFocusedRowCellValue(colProfile_Name, xuc_Journal_Profile.Profile_Name.Text)
                .SetFocusedRowCellValue(colFriendly_Name, xuc_Journal_Profile.Friendly_Name.Text)
                .SetFocusedRowCellValue(colCOA_Code, xuc_Journal_Profile.COA_Code.EditValue)
                .SetFocusedRowCellValue(colCOA_Name, xuc_Journal_Profile.COA_Code.Text)
                .SetFocusedRowCellValue(colCustom_COA, xuc_Journal_Profile.Custom_COA.EditValue)
                .SetFocusedRowCellValue(colProfile_VAT, xuc_Journal_Profile.Profile_VAT.EditValue)
                .SetFocusedRowCellValue(colProfile_Description, xuc_Journal_Profile.Profile_Description.Text)
                .SetFocusedRowCellValue(colBalance_Type, xuc_Journal_Profile.Balance_Type.Text)
                .SetFocusedRowCellValue(colNotes, xuc_Journal_Profile.Notes.Text)
            End With
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Select Case e.Column.Name
                    Case "colCOA_Code"
                        class_Saga_Procedures.Show_COA(e.CellValue.ToString)

                    Case Else
                        Data_Show()
                        If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

    End Class

End Namespace