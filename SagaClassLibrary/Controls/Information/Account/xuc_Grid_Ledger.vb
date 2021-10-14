Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Controls.Information.Account

    Public Class xuc_Grid_Ledger
        Inherits DevExpress.XtraEditors.XtraUserControl

        Friend bLoopStop As Boolean
        Friend sBrCode, sAccount, sLedger As String

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Data_Load(ByVal sBrCode As String, ByVal sAccount As String, ByVal sLedger As String)
            class_Saga_Procedures.Initialize_Branch(repositoryItemLookUpEdit_Branch)
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM CustLedger WHERE BranchCode LIKE '{sBrCode}' AND AccountNumber LIKE '{sAccount}' AND LedgerSetNumber LIKE '{sLedger}'", "CustLedger")
            gridView.MakeRowVisible(gridView.DataRowCount - 1)
        End Sub

        Friend Sub Control_Data_Load(ByVal sBrCode As String, ByVal dtStart As Date, ByVal dtEnd As Date)
            class_Saga_Procedures.Initialize_Branch(repositoryItemLookUpEdit_Branch)
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM CustLedger WHERE BranchCode LIKE '{sBrCode}' AND TransactionDate >= '{dtStart}' AND TransactionDate <= '{dtEnd}'", "CustLedger")
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Control_Data_Load(sBrCode, sAccount, sLedger)
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso e.Clicks.Equals(2) Then

                Select Case e.Column.Name
                    Case "colSequenceNumber"
                        class_Saga_Procedures.Show_Account_Ledger(e.CellValue.ToString)

                    Case "colAccountNumber"
                        class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, e.CellValue.ToString, Convert.ToInt32(gridView.GetFocusedRowCellValue(colLedgerSetNumber)))

                    Case "colTransactedBy"
                        class_Saga_Procedures.Show_User_Activity(e.CellValue.ToString)

                    Case Else
                        If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView.MouseDown, gridControl.MouseDown
            If e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                popupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick

            class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colORNumber), gridView.GetFocusedRowCellValue(colSequenceNumber))
        End Sub

        Private Sub btn_Generate_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Generate.ItemClick
            With gridView
                Dim dBalancePrincipal, dBalanceInterest As Decimal

                bLoopStop = False
                .ClearSelection()

                dBalancePrincipal = .GetRowCellValue(0, colEndingBalance)
                .SetRowCellValue(0, colNote, dBalancePrincipal)

                For i As Integer = 1 To gridView.DataRowCount - 1

                    Select Case .GetRowCellDisplayText(i, colLedgerType)
                        Case "PRIN"
                            dBalancePrincipal -= .GetRowCellValue(i, colCredit)

                        Case "REB"
                            dBalancePrincipal -= .GetRowCellValue(i, colDebit)

                        Case "PEN"
                            dBalancePrincipal += .GetRowCellValue(i, colCredit)

                        Case "INT"
                            dBalanceInterest -= .GetRowCellValue(1, colCredit)

                    End Select

                    .SetRowCellValue(i, colErrorCorrectTag, dBalancePrincipal)
                Next
            End With
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles gridView.KeyDown
            With gridView

                Select Case e.KeyCode
                    Case Keys.F2
                        class_Saga_Procedures.Show_Account_Ledger(.GetFocusedRowCellDisplayText(colSequenceNumber))

                    Case Keys.Delete
                        If class_Procedures.actionAsk("Delete Ledgers", "Delete selected payment ledgers") Then
                            Dim iRowHandle, iRowHandleOld As Integer
                            Dim selectedRows As Integer() = .GetSelectedRows()
                            bLoopStop = False
                            For i As Integer = 0 To selectedRows.Length - 1
                                iRowHandle = selectedRows(i)

                                If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Delete Ledger", "deleted", bLoopStop) Then
                                    iRowHandleOld = iRowHandle
                                Else Return
                                End If

                                class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM CustLedger WHERE SequenceNumber LIKE '{ .GetRowCellDisplayText(iRowHandle, colSequenceNumber)}'")
                            Next

                            .DeleteSelectedRows()
                            .BestFitColumns()
                        End If
                End Select
            End With
        End Sub

    End Class

End Namespace