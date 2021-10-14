Imports DevExpress.XtraGrid.Views.Base
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Forms.Information.Account

    Public Class frm_Account_Applications
        Inherits DevExpress.XtraEditors.XtraForm

        Friend bLoopStop As Boolean

        Public Sub New()
            If Me.xuc_Account_Application Is Nothing Then
                Me.xuc_Account_Application = New Controls.Information.Account.xuc_Account_Application()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, Me.xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager)
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, Me.xuc_Settings, True)
        End Function

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Account_Applications_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(xuc_Account_Application.acount_Branch)
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, repositoryItemLookUpEdit_Branch)
            class_Saga_Procedures.Initialize_Branch(repositoryItemLookUpEdit_Branch)
        End Sub

        Private Sub frm_Account_Applications_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then
                xuc_Account_Application.Control_Initialize()
            End If
        End Sub

        Private Sub frm_Account_Applications_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Account_Application.Control_Initialize()
        End Sub

        Private Sub Data_Load()

            If xuc_Settings.Toggle_Load_All.IsOn OrElse barEditItem_Branch.EditValue.ToString.Equals("000") Then
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM CustAccountApplications WHERE DateGranted >= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtStart}', 23) OR DateGranted >= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtEnd}', 23)", "CustAccountApplications")
            Else
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM CustAccountApplications WHERE DateGranted >= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtStart}', 23) OR DateGranted >= CONVERT(VARCHAR(10), '{class_Saga_Variables.dtEnd}', 23) AND BranchCode LIKE '{barEditItem_Branch.EditValue}' ", "CustAccountApplications")
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            xuc_Account_Application.Control_Save()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            If xuc_Account_Application.Control_Delete() Then gridView.DeleteRow(gridView.FocusedRowHandle)
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Account_Application
                    .ID_Code.Text = gridView.GetFocusedRowCellDisplayText(colid)
                    .acount_Branch.EditValue = repositoryItemLookUpEdit_Branch.GetKeyValueByDisplayText(gridView.GetFocusedRowCellDisplayText(colBranchCode))
                    .acount_Brand.Text = gridView.GetFocusedRowCellDisplayText(colBrand)
                    .acount_Model.Text = gridView.GetFocusedRowCellDisplayText(colModel)
                    .acount_Color.Text = gridView.GetFocusedRowCellDisplayText(colColor)
                    .acount_Engine.Text = gridView.GetFocusedRowCellDisplayText(colEngineNo)
                    .acount_Chassis.Text = gridView.GetFocusedRowCellDisplayText(colChassisNo)
                    .acount_Approver.Text = gridView.GetFocusedRowCellDisplayText(colApprover)
                    .acount_Status.Text = gridView.GetFocusedRowCellDisplayText(colStatus)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colRemarks)
                End With
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(sender As Object, e As FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                Select Case e.Column.Name

                End Select
                class_Procedures.Copy_Clipboard(e.CellValue.ToString)
            End If
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            With gridView
                If .DataRowCount > 0 Then
                    Select Case e.KeyCode
                        Case Keys.Enter
                            Data_Show()

                        Case Keys.Delete
                            If Not class_Procedures.actionAsk("Delete disapproved applications", "delete some approved applications") Then Return
                            class_Procedures.splash_Show("deleting disapproved applications")
                            Dim iRowHandle, iRowHandleOld As Integer
                            Dim selectedRows As Integer() = .GetSelectedRows()

                            For i As Integer = 0 To selectedRows.Length - 1
                                iRowHandle = selectedRows(i)

                                If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Delete Account Application(s)", "deleted", bLoopStop,, True, "Remarks") Then
                                    iRowHandleOld = iRowHandle
                                Else Return
                                End If

                                class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM CustAccountApplications WHERE id LIKE '{ .GetRowCellDisplayText(iRowHandle, colid)}'")
                            Next
                            .DeleteSelectedRows()
                            class_Procedures.splash_Close()
                        Case Else
                    End Select
                End If
            End With
        End Sub

    End Class

End Namespace