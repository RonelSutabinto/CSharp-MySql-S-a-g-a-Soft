Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Public Class frm_COA_Balances

    Public Sub New()
        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, DockManager, gridView, BtnCancel)

        class_Saga_Procedures.Initialize_BarManager(Me, barManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Balances_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frm_Balances_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me, barManager, DockManager, gridView)
    End Function

    Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub frm_Balances_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick


    End Sub

    Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
        class_Procedures.Initialize_Printing(e)
    End Sub

    Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
        If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
            PopupMenu.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Friend Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
        If (gridView.DataRowCount > 0) AndAlso e.Clicks.Equals(2) Then
            If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)
            Select Case e.Column.Name

            End Select
        End If
    End Sub

    Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
        If (gridView.DataRowCount > 0) Then

            Select Case e.KeyValue
                Case Keys.Delete
                    If class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM acc_Balances WHERE ID LIKE '{gridView.GetFocusedRowCellDisplayText(colID)}'", "Delete Balance") Then
                        gridView.DeleteRow(gridView.FocusedRowHandle)
                    End If
            End Select
        End If
    End Sub

    Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        gridView.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick


    End Sub

    Friend Sub Data_Load(ByVal sCOACode As String)
        class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM view_Balances WHERE Corporation LIKE '{class_Saga_Variables.sCorporation}' AND COA_Code LIKE '{sCOACode}'", "view_Balances")
    End Sub

End Class