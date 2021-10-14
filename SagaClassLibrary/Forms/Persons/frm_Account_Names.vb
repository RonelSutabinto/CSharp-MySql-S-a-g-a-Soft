﻿Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Forms.Persons

    Public Class frm_Account_Names

        Public Sub New()
            If Me.xuc_Account_Name Is Nothing Then
                Me.xuc_Account_Name = New Controls.Persons.xuc_Account_Name()
            End If

            InitializeComponent()

            Dim BtnCancel = New SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel, xuc_Account_Name.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)

            AddHandler Me.EntityInstantFeedbackSource.GetQueryable, AddressOf EntityInstantFeedbackSource_GetQueryable
            AddHandler Me.EntityInstantFeedbackSource.DismissQueryable, AddressOf EntityInstantFeedbackSource_DismissQueryable
        End Sub

        ' This event is generated by Data Source Configuration Wizard
        Sub EntityInstantFeedbackSource_GetQueryable(sender As Object, e As DevExpress.Data.Linq.GetQueryableEventArgs)
            ' Instantiate a new DataContext
            Dim dataContext As AccEntities = New AccEntities()
            ' Assign a queryable source to the EntityInstantFeedbackSource
            e.QueryableSource = dataContext.acc_Account_Names
            ' Assign the DataContext to the Tag property,
            ' to dispose of it in the DismissQueryable event handler
            e.Tag = dataContext
        End Sub

        ' This event is generated by Data Source Configuration Wizard
        Sub EntityInstantFeedbackSource_DismissQueryable(sender As Object, e As DevExpress.Data.Linq.GetQueryableEventArgs)
            ' Dispose of the DataContext
            CType(e.Tag, AccEntities).Dispose()
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Account_Names_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            gridView.BestFitColumns()
        End Sub

        Private Sub frm_Account_Names_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Account_Name.Control_Initialize()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, DockManager, gridView, xuc_Account_Name.layoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub frm_Account_Names_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Account_Name.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick

            Data_Load()
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then

                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM acc_Account_Names WHERE Account_Code LIKE '%{sSearch}%' OR Account_Type LIKE '%{sSearch}%' OR Account_Name LIKE '%{sSearch}%' OR Account_Address LIKE '%{sSearch}%'", "acc_Account_Names")
            End If
        End Sub

        Private Sub Data_Load()

            xuc_Account_Name.Control_Initialize()
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, "SELECT * FROM acc_Account_Names", "acc_Account_Names")
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

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            If gridView.RowCount > 0 Then gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Account_Name.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Account_Name.control_Save() Then Update_Data_Row()
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            If xuc_Account_Name.Control_Delete(gridView.GetRowCellDisplayText(gridView.FocusedRowHandle, colAccount_Code)) Then gridView.DeleteRow(gridView.FocusedRowHandle)
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView.MouseDown, gridControl.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                popupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Account_Name
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                    .Account_Code.Text = gridView.GetFocusedRowCellDisplayText(colAccount_Code)
                    .Account_Type.Text = gridView.GetFocusedRowCellDisplayText(colAccount_Type)
                    .Account_Name.Text = gridView.GetFocusedRowCellDisplayText(colAccount_Name)
                    .Account_Address.Text = gridView.GetFocusedRowCellDisplayText(colAccount_Address)
                    .Account_Mobile.Text = gridView.GetFocusedRowCellDisplayText(colAccount_Mobile)
                    .Account_Description.Text = gridView.GetFocusedRowCellDisplayText(colAccount_Description)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                End With
            End If
        End Sub

        Private Sub Update_Data_Row()
            If gridView.RowCount > 0 Then
                With gridView
                    .SetRowCellValue(.FocusedRowHandle, colAccount_Type, xuc_Account_Name.Account_Type.Text.Trim)
                    .SetRowCellValue(.FocusedRowHandle, colAccount_Name, xuc_Account_Name.Account_Name.Text.Trim)
                    .SetRowCellValue(.FocusedRowHandle, colAccount_Address, xuc_Account_Name.Account_Address.Text.Trim)
                    .SetRowCellValue(.FocusedRowHandle, colAccount_Mobile, xuc_Account_Name.Account_Mobile.Text.Trim)
                    .SetRowCellValue(.FocusedRowHandle, colAccount_Description, xuc_Account_Name.Account_Description.Text.Trim)
                    .SetRowCellValue(.FocusedRowHandle, colNotes, xuc_Account_Name.Notes.Text.Trim)
                End With
            End If
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            If gridView.DataRowCount > 0 Then
                Select Case e.KeyValue
                    Case Keys.F2
                        Me.xuc_Account_Name.Select()

                    Case Keys.Enter
                        Data_Show()
                End Select
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Select Case e.Column.Name
                    Case "colAccount_Mobile"
                        'LC_SMS_3_3.Classes.Class_SMS.Show_Sender(gridView.GetFocusedRowCellDisplayText(colAccount_Name), e.CellValue.ToString)

                    Case Else
                        Data_Show()
                        If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            If gridView.DataRowCount > 0 Then

                If class_Procedures.actionAsk("Update Journal Entries with selected Account Name", "Update the wrong Account Name") Then
                    class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET Account_Code = '{gridView.GetFocusedRowCellDisplayText(colAccount_Code)}' WHERE Account_Name LIKE '{gridView.GetFocusedRowCellDisplayText(colAccount_Name)}'")
                End If
            End If
        End Sub

    End Class

End Namespace