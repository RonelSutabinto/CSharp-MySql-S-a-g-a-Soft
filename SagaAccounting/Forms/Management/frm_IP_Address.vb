Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System
Imports System.Windows.Forms

Partial Class frm_IP_Address
    Inherits DevExpress.XtraEditors.XtraForm

    Friend bLoopStop As Boolean

    Friend Sub New()
        If Me.xuc_IP_Access Is Nothing Then
            Me.xuc_IP_Access = New Controls.Management.xuc_IP_Access()
        End If

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel)

        class_Saga_Procedures.Initialize_BarManager(Me, barManager)
    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, True)
    End Function

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_IP_Address_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        class_Saga_Procedures.Initialize_Branch(xuc_IP_Access.ip_Branch)
        class_Saga_Procedures.Initialize_Branch(repositoryItemLookUpEdit_Branch)
    End Sub

    Private Sub frm_IP_Address_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
        xuc_IP_Access.Control_Initialize()
    End Sub

    Private Sub Data_Load()

        If class_Procedures.isEmpty(xuc_IP_Access.ip_Branch) Then Return

        If check_Load_All.Checked Then
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, "SELECT * FROM IPAddresses", "IPAddresses")
        Else
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM IPAddresses WHERE BranchCode LIKE '{xuc_IP_Access.ip_Branch.EditValue}'", "IPAddresses")
        End If
    End Sub

    Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Data_Load()
    End Sub

    Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
        xuc_IP_Access.Control_New()
    End Sub

    Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        xuc_IP_Access.Control_Save()
        If check_Reload.Checked Then Data_Load()
    End Sub

    Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
        If xuc_IP_Access.Control_Delete(xuc_IP_Access.ip_Address.Text) Then
            gridView.DeleteRow(gridView.FocusedRowHandle)
        End If
    End Sub

    Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
        class_Procedures.Initialize_Printing(e)
    End Sub

    Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        gridView.ShowRibbonPrintPreview()
    End Sub

    Private Sub Data_Show()
        If gridView.RowCount > 0 Then
            xuc_IP_Access.ip_Branch.EditValue = gridView.GetFocusedRowCellDisplayText(gridColumnBranchCode)
            xuc_IP_Access.ip_Address.Text = gridView.GetFocusedRowCellDisplayText(gridColumnIPAddress)
        End If
    End Sub

    Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
        With gridView
            If .DataRowCount > 0 Then
                Select Case e.KeyCode
                    Case Keys.Enter
                        Data_Show()

                    Case Keys.Delete
                        If Not class_Procedures.actionAsk("Delete IP", "Delete IP Address(es)", "delete some used IP Address(es)") Then Return
                        class_Procedures.splash_Show("deleting IP Address(es)")

                        Dim iRowHandle, iRowHandleOld As Integer
                        Dim selectedRows As Integer() = .GetSelectedRows()

                        For i As Integer = 0 To selectedRows.Length - 1
                            iRowHandle = selectedRows(i)

                            If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Delete IP(s)", "deleted", bLoopStop) Then
                                iRowHandleOld = iRowHandle
                            Else Return
                            End If

                            class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM IPAddresses WHERE IPAddress LIKE '{ .GetRowCellDisplayText(iRowHandle, gridColumnIPAddress)}'")
                        Next
                        .DeleteSelectedRows()
                        class_Procedures.splash_Close()
                    Case Else
                End Select
            End If
        End With
    End Sub

End Class