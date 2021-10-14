Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Public Class frm_COA_Ledger

    Friend sCOACode As String
    Friend bVirtual, bLoopStop As Boolean

    Public Sub New()
        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, gridView, BtnCancel)

        class_Saga_Procedures.Initialize_BarManager(Me, barManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

    Private Sub frm_Journal_Entries_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        class_Saga_Procedures.Initialize_COA(RepositoryItemLookUpEdit_COA, eCOA_Type.COA_All)
    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me, barManager, gridView)
    End Function

    Private Sub frm_Journal_Entries_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        Data_Load()
    End Sub

    Private Sub btn_Load_All_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Load_All.ItemClick
        Data_Load(True)
    End Sub

    Friend Sub Data_Load(Optional ByVal bAll As Boolean = False)


        Dim dtLedgerBalance As Date
        Try
            dtLedgerBalance = convert.todatetime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COA_Code, Balance_Date FROM acc_Chart_Of_Accounts WHERE COA_Code LIKE '{sCOACode}'", "Balance_Date"))
        Catch ex As Exception
            dtLedgerBalance = "01/01/0001"
        End Try

        Dim sQueryJournal As String

        If bAll Then
            sQueryJournal = $"SELECT ID, 'JOURNAL' AS Type, COA_Summary, COA_Code, COA_Name, Account_Name, Journal_Reference AS Reference, Journal_Debit AS Debit, Journal_Credit AS Credit, Posting_Date, Balance, COA_Normal, Journal_Description, Notes, Added_By, Added_Date, Modified_By, Modified_Date, Approved_By, Approved_Date, Locked_By, Locked_Date FROM view_Journal_Entries WHERE IsDeleted <> 1 AND COA_Code LIKE '{sCOACode}' ORDER BY Posting_Date ASC"
        Else
            sQueryJournal = $"SELECT ID, 'JOURNAL' AS Type, COA_Summary, COA_Code, COA_Name, Account_Name, Journal_Reference AS Reference, Journal_Debit AS Debit, Journal_Credit AS Credit, Posting_Date, Balance, COA_Normal, Journal_Description, Notes, Added_By, Added_Date, Modified_By, Modified_Date, Approved_By, Approved_Date, Locked_By, Locked_Date FROM view_Journal_Entries WHERE IsDeleted <> 1 AND Posting_Date >= '{dtLedgerBalance}' AND COA_Code LIKE '{sCOACode}' ORDER BY Posting_Date ASC"
        End If

        class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, sQueryJournal, "view_Journal_Entries")
        gridView.ClearSorting()
        colPosting_Date.SortIndex = 0
    End Sub

    Private Sub btn_Beginning_Balance_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Beginning_Balance.ItemClick
        If class_Database.Data_Save_Ask("Set as Account Beginning Balance") Then
            With gridView
                Select Case .FocusedColumn.FieldName
                    Case "Debit"
                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Chart_Of_Accounts Set Balance = '{ .GetFocusedRowCellValue(colDebit)}', Balance_Date = '{convert.todatetime(.GetFocusedRowCellValue(colPosting_Date))}' WHERE COA_Code LIKE '{ .GetFocusedRowCellValue(colCOA_Code)}'", True)

                    Case "Credit"
                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Chart_Of_Accounts Set Balance = '{ .GetFocusedRowCellValue(colCredit)}', Balance_Date = '{convert.todatetime(.GetFocusedRowCellValue(colPosting_Date))}' WHERE COA_Code LIKE '{ .GetFocusedRowCellValue(colCOA_Code)}'", True)

                    Case "Balance"
                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Chart_Of_Accounts Set Balance = '{ .GetFocusedRowCellValue(colBalance)}', Balance_Date = '{convert.todatetime(.GetFocusedRowCellValue(colPosting_Date))}' WHERE COA_Code LIKE '{ .GetFocusedRowCellValue(colCOA_Code)}'", True)
                End Select
            End With
        End If
    End Sub

    Friend Sub btn_Generate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Generate.ItemClick
        Dim dDebit, dCredit As Decimal
        Dim dLedgerBalance As Decimal = convert.todecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COA_Code, Balance FROM acc_Chart_Of_Accounts WHERE COA_Code LIKE '{sCOACode}'", "Balance"))

        For i As Integer = 0 To gridView.DataRowCount - 1
            Try
                dDebit += convert.todecimal(gridView.GetRowCellValue(i, "Debit"))
                dCredit += convert.todecimal(gridView.GetRowCellValue(i, "Credit"))

                Select Case gridView.GetRowCellDisplayText(i, colCOA_Normal)
                    Case "DEBIT"
                        If dDebit > 0 Then
                            dLedgerBalance += dDebit
                        Else
                            dLedgerBalance -= dCredit
                        End If
                        gridView.SetRowCellValue(i, colBalance, dLedgerBalance)
                    Case "CREDIT"
                        If dDebit > 0 Then
                            dLedgerBalance -= dDebit
                        Else
                            dLedgerBalance += dCredit
                        End If
                        gridView.SetRowCellValue(i, colBalance, dLedgerBalance)
                End Select
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            Finally
                dDebit = 0
                dCredit = 0
            End Try
        Next
        gridView.BestFitColumns()
        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Running Balance is: {dLedgerBalance:N2}")
    End Sub

    Friend Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
        With gridView
            If .SelectedRowsCount > 0 Then
                If Not bVirtual AndAlso Not class_Procedures.actionAsk("Journal Balance", "Update Journal Balances", "You might update the wrong Journal Balances") Then Return

                Dim iRowHandle, iRowHandleOld As Integer
                Dim selectedRows As Integer() = gridView.GetSelectedRows()


                bLoopStop = False
                .ClearSelection()

                For iRowHandle = 0 To selectedRows.Length - 1
                    If Not bVirtual Then
                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Balances", "updated", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If
                    End If

                    Dim dBalance As Decimal = .GetRowCellValue(iRowHandle, colBalance)
                    If Not bVirtual Then
                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries Set Balance = '{ dBalance}' WHERE ID LIKE '{ .GetRowCellValue(iRowHandle, colID)}'")
                    End If

                    If iRowHandle = gridView.DataRowCount - 1 Then
                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Chart_Of_Accounts Set Balance_Running = '{ dBalance}' WHERE COA_Code LIKE '{ .GetRowCellValue(iRowHandle, colCOA_Code)}'")
                    End If
                Next

                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"The selected Journal Balances were updated.", "Journal Balance")
            End If
        End With
    End Sub

    Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
        If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
            Select Case e.Column.Name
                Case "colID"
                    class_Saga_Procedures.Show_Journal_Entry(gridView.GetFocusedRowCellDisplayText(colID))

                Case "colCOA_Code"
                    class_Saga_Procedures.Show_COA(gridView.GetFocusedRowCellDisplayText(colCOA_Code))

                Case "colReference"
                    class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colReference), gridView.GetFocusedRowCellValue(colID))

                Case Else
                    If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

            End Select
        End If
    End Sub

    Private Sub gridView_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles gridView.KeyDown
        If gridView.SelectedRowsCount > 0 Then
            Select Case e.KeyCode
                Case Keys.F2
                    If Convert.ToInt32(gridView.GetFocusedRowCellValue(colID)) > 0 Then
                        class_Saga_Procedures.Show_Journal_Entry(gridView.GetFocusedRowCellDisplayText(colID))
                    End If

                Case Keys.F6
                    class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colReference), gridView.GetFocusedRowCellValue(colID))

            End Select
        End If
    End Sub

    Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
        If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
            PopupMenu.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
        class_Procedures.Initialize_Printing(e)
    End Sub

    Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
        gridView.ShowRibbonPrintPreview()
    End Sub

End Class