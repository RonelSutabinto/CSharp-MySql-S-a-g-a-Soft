Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Persons

    Public Class frm_Users
        Inherits DevExpress.XtraEditors.XtraForm

        Private bLoopStop As Boolean

        Public Sub New()
            If Me.xuc_User Is Nothing Then
                Me.xuc_User = New Controls.Persons.xuc_User()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, xuc_User.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)

            Me.xuc_User.User_Name.Properties.CharacterCasing = CharacterCasing.Normal
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Users_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, xuc_User.layoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Users_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(xuc_User.user_Branch)
        End Sub

        Private Sub frm_Users_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Dim RepositoryItemLookUpEdit_Corporation As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Corporation(RepositoryItemLookUpEdit_Corporation)
            colCorporation.ColumnEdit = RepositoryItemLookUpEdit_Corporation

            Dim RepositoryItemLookUpEdit_Branch As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit_Branch)
            colbranchcode.ColumnEdit = RepositoryItemLookUpEdit_Branch

            Dim RepositoryItemLookUpEdit_Employee As RepositoryItemLookUpEdit = New RepositoryItemLookUpEdit
            class_Saga_Variables.Initialize_Employee()
            class_Saga_Procedures.Initialize_Employee(RepositoryItemLookUpEdit_Employee)
            colEmployee_Code.ColumnEdit = RepositoryItemLookUpEdit_Employee

            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_User.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_User.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub Data_Load()
            Dim sSearch As String = String.Empty

            If BarEditItem_Search.EditValue Is Nothing Then
                Dim sqlParameters = {New SqlParameter("@Action_Type", "LOAD_ALL")}
                class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_User_Procedures", "Application Users List")
            Else
                sSearch = BarEditItem_Search.EditValue.ToString
                If sSearch.Length > 0 Then
                    Load_Search(BarEditItem_Search.EditValue.ToString.Trim)
                End If
            End If
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM Users WHERE username LIKE '%{sSearch}%' OR fullname LIKE '%{sSearch}%'", "Users")
            End If
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

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub Data_Show()
            Try
                With xuc_User
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                    .Corporation.EditValue = gridView.GetFocusedRowCellValue(colCorporation)
                    .user_Branch.EditValue = gridView.GetFocusedRowCellValue(colbranchcode)
                    .User_Name.EditValue = gridView.GetFocusedRowCellDisplayText(colusername)
                    .Employee_Code.EditValue = gridView.GetFocusedRowCellValue(colEmployee_Code)
                    .user_FName.Text = gridView.GetFocusedRowCellDisplayText(colFName)
                    .user_MName.Text = gridView.GetFocusedRowCellDisplayText(colMI)
                    .user_LName.Text = gridView.GetFocusedRowCellDisplayText(colLName)
                    .user_Full_Name.Text = gridView.GetFocusedRowCellDisplayText(colfullname)
                    .user_Position.EditValue = gridView.GetFocusedRowCellDisplayText(coldesignation)
                    .isSuperUser.IsOn = gridView.GetFocusedRowCellValue(colIsSuperUser)
                    .isAdministator.IsOn = gridView.GetFocusedRowCellValue(colIsAdmin)
                    .isMaintenance.IsOn = gridView.GetFocusedRowCellValue(colIsMaintenance)
                    .isApprover.IsOn = gridView.GetFocusedRowCellValue(colIsApprover)
                    .isAccounting.IsOn = gridView.GetFocusedRowCellValue(colIsAccounting)
                    .isAudit.IsOn = gridView.GetFocusedRowCellValue(colIsAudit)
                    .isLogistics.IsOn = gridView.GetFocusedRowCellValue(colIsLogistics)
                    .isInventory.IsOn = gridView.GetFocusedRowCellValue(colIsInventory)
                    .isSpareParts.IsOn = gridView.GetFocusedRowCellValue(colIsInventorySP)
                    .isCashier.IsOn = gridView.GetFocusedRowCellValue(colIsCashier)
                    .isBookkeeper.IsOn = gridView.GetFocusedRowCellValue(colIsBookkeeper)
                    .isReceptionist.IsOn = gridView.GetFocusedRowCellValue(colIsReceptionist)
                    .isNewAccounts.IsOn = gridView.GetFocusedRowCellValue(colISNewAccounts)
                    .isRelease.IsOn = gridView.GetFocusedRowCellValue(colIsRelease)
                    .isCollection.IsOn = gridView.GetFocusedRowCellValue(colIsCollection)
                    .IsReports.IsOn = gridView.GetFocusedRowCellValue(colIsReports)
                    .IsUpdate.IsOn = gridView.GetFocusedRowCellValue(colIsUpdate)
                    .IsBetaTester.IsOn = gridView.GetFocusedRowCellValue(colIsBetaTester)
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If gridView.RowCount > 0 AndAlso e.Clicks.Equals(2) Then
                class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                Data_Show()
            End If
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            Select Case e.KeyCode
                Case Keys.Delete
                    xuc_User.Control_Delete(gridView.GetFocusedRowCellDisplayText(colusername))

                Case Keys.Enter
                    Data_Show()
            End Select
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_User.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If check_Password_Save.Checked Then
                Me.xuc_User.Control_Save(True)
            Else
                Me.xuc_User.Control_Save(False)
            End If

            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            xuc_User.Control_Delete(gridView.GetFocusedRowCellDisplayText(colusername))
        End Sub

        Private Sub btn_Receive_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Receive_Update.ItemClick
            With gridView
                If .SelectedRowsCount > 0 Then
                    Dim sqlParameters As SqlParameter()

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Receive Update", "updated", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        sqlParameters = {
                            New SqlParameter("@username", gridView.GetRowCellDisplayText(iRowHandle, colusername)),
                            New SqlParameter("@Action_Type", "RECEIVE_UPDATE")
                        }
                        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_User_Procedures", "Set User Account to receive updates")
                    Next

                    btn_Reload_ItemClick(sender, e)
                End If
            End With
        End Sub

        Private Sub btn_Password_Reset_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Password_Reset.ItemClick
            If Not class_Procedures.actionAsk("Reset user password", "reset wrong user") Then Return
            If class_Saga_Database.Reset_Pass(Me.xuc_User.User_Name.Text.Trim) Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"User Password has been tagged as Reset.{Environment.NewLine}The user will then set her/his new password upon login.", "Reset Password", True)
            End If
        End Sub

        Private Sub btn_Deactivate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Deactivate.ItemClick
            With gridView
                If .SelectedRowsCount > 0 Then
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Deactivate User Account", "deactivated", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sqlParameters As SqlParameter() = {
                            New SqlParameter("@username", gridView.GetFocusedRowCellDisplayText(colusername)),
                            New SqlParameter("@Action_Type", "DEACTIVATE")
                        }
                        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_User_Procedures", "Deactivate User Account")
                    Next

                    btn_Reload_ItemClick(sender, e)
                End If
            End With
        End Sub

    End Class

End Namespace