Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Controls.Accounting
    Public Class xuc_Grid_Journal_References
        Friend bLoopStop, bClearSelection As Boolean

        Public Enum VerifyMode
            TableID
            Reference
        End Enum

        Public eVerification As VerifyMode

        Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Data_Load()
            'Dim sqlParameters As SqlParameter() = {
            '    New SqlParameter("@Corporation", class_Saga_Variables.sCorporation),
            '    New SqlParameter("@ID", Convert.ToBoolean(BarEditItem_List_Mode.EditValue)),
            '    New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
            '    New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
            '    New SqlParameter("@Action_Type", "LOAD_HO")
            '}

            'class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Journal_Procedures", "acc_Journal_Entries")

            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT DISTINCT Corporation, Journal_Reference, MIN(ID) As ID, MAX(Table_ID) As Table_ID, MAX(Branch_Code) As Branch_Code, MAX(Journal_Type) As Journal_Type, MAX(Account_Code) As Account_Code, MAX(Account_Name) As Account_Name, COUNT(Journal_Reference) As Journal_Entries, SUM(Journal_Debit) As Journal_Debit, SUM(Journal_Credit) As Journal_Credit, MIN(Journal_Description) As Journal_Description, MIN(Posting_Date) As Posting_Date, MIN(Added_By) AS Added_By, MIN(Journal_Status) AS Journal_Status FROM acc_Journal_Entries WHERE IsDeleted <> 1 AND Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Posting_Date >= '{class_Saga_Variables.dtStart}' AND Posting_Date <= '{class_Saga_Variables.dtEnd}' GROUP BY Corporation, Journal_Reference", "acc_Journal_Entries")
            'class_Database.BindData(class_Database.ICSConnection, gridControl, gridView, $"SELECT DISTINCT Corporation, Journal_Reference, MIN(ID) As ID, MAX(Table_ID) As Table_ID, MAX(Branch_Code) As Branch_Code, MAX(Journal_Type) As Journal_Type, MAX(Account_Code) As Account_Code, MAX(Account_Name) As Account_Name, COUNT(Journal_Reference) As Journal_Entries, SUM(Journal_Debit) As Journal_Debit, SUM(Journal_Credit) As Journal_Credit, MAX(Journal_Description) As Journal_Description, MAX(Posting_Date) As Posting_Date, MAX(Added_By) AS Added_By FROM acc_Journal_Entries WHERE IsDeleted <> 1 AND Corporation LIKE '{class_Saga_Variables.sCorporation}' AND Posting_Date >= '{class_Functions.FirstDayOfMonth(class_Saga_Variables.dtStart)}' AND Posting_Date <= '{class_Functions.LastDayOfMonth(class_Saga_Variables.dtStart)}' GROUP BY Corporation, Journal_Reference", "acc_Journal_Entries")
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView.MouseDown, gridControl.MouseDown
            If e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            Select Case e.KeyCode
                Case Keys.F2, Keys.F6, Keys.Enter
                    class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colJournal_Reference), gridView.GetFocusedRowCellValue(colTable_ID))
            End Select
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellValue(colJournal_Reference), gridView.GetFocusedRowCellValue(colTable_ID))
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then

                Dim sAccountType As String = gridView.GetFocusedRowCellDisplayText(colJournal_Type)
                Select Case e.Column.Name
                    Case "colJournal_Reference"
                        class_Saga_Procedures.Show_Journal_Entries_Reference(e.CellValue.ToString, gridView.GetFocusedRowCellValue(colTable_ID))

                    Case "colTable_ID"
                        Try
                            If sAccountType.Contains("VOUCHER") Then
                                class_Saga_Procedures.Show_Voucher(gridView.GetFocusedRowCellDisplayText(colJournal_Reference))
                            ElseIf sAccountType.Contains("RELEASE") Or sAccountType.Contains("ACQUIRED") Or sAccountType.Contains("ASSUME") Then
                                class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.ID, e.CellValue.ToString)
                            ElseIf sAccountType.Contains("PAYMENT") Then
                                class_Saga_Procedures.Show_Account_Payment(False, e.CellValue.ToString)
                            ElseIf sAccountType.Contains("CASHIERING") Then
                                If sAccountType.Contains("IBC") Then
                                    class_Saga_Procedures.Show_Account_Payment(True, e.CellValue.ToString)
                                ElseIf sAccountType.Contains("CM") Then
                                End If
                            End If
                        Catch ex As Exception

                        End Try

                    Case "colAccount_Code"
                        Dim sAccount As String = gridView.GetFocusedRowCellDisplayText(colAccount_Code)
                        Dim sCodes As String() = sAccount.Split(New Char() {"-"c})
                        Dim sAccountCode As String = sCodes(0)
                        Dim iLedger As Integer

                        If sAccountCode.Contains("NAME") Then
                            class_Saga_Procedures.Show_Account_Name(e.CellValue.ToString)

                        ElseIf sAccountCode.Contains("EMPL") Then
                            'class_Saga_Procedures.Show_Employee(e.CellValue.ToString)

                        ElseIf sAccountType.Contains("RECEIVING") Then
                            class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                        ElseIf sAccountType.Contains("TRANS") Then
                            class_Saga_Procedures.Show_Unit_Inventory(e.CellValue.ToString)

                        ElseIf sAccountType.Contains("RELEASE") Or sAccountType.Contains("ASSUME") Or sAccountType.Contains("CASHIERING") Or sAccountType.Contains("PAYMENT") Then
                            Try
                                iLedger = Convert.ToInt32(sCodes(1))
                                class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, sAccountCode, iLedger)
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                            End Try

                        ElseIf sAccountType.Contains("ACQUIRED") Then
                            Try
                                iLedger = Convert.ToInt32(sCodes(1))
                                class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, sAccountCode, iLedger)
                            Catch ex As Exception
                                class_Procedures.Show_Error(ex)
                            End Try
                        End If

                    Case Else
                        If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Control_Data_Load()
        End Sub

        Private Function IsEqual(ByVal dDebit As Decimal, ByVal dCredit As Decimal) As Boolean
            Return dDebit.Equals(dCredit)
        End Function

        Friend Function Control_Validate_Journal_Entries() As Integer
            Dim iCount As Integer = 0
            With gridView
                If .DataRowCount > 0 Then
                    class_Procedures.splash_Show("validating summaries")

                    bLoopStop = False
                    .ClearSelection()
                    For i As Integer = 0 To .DataRowCount - 1
                        If bLoopStop Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"The user stopped the validation looping process.")
                            Exit For
                        End If

                        If Not IsEqual(Convert.ToDecimal(.GetRowCellDisplayText(i, colJournal_Debit)), Convert.ToDecimal(.GetRowCellDisplayText(i, colJournal_Credit))) Then
                            .SelectRow(i)
                            .SetRowCellValue(i, colJournal_Entries, 0)
                            iCount += 1
                        End If
                        Application.DoEvents()
                    Next

                    gridView.ClearSorting()
                    gridView.ClearGrouping()
                    colJournal_Entries.SortIndex = 0
                    colJournal_Entries.GroupIndex = 0
                    gridView.BestFitColumns()

                    class_Procedures.splash_Close()
                End If
            End With
            Return iCount
        End Function

        Private Sub btn_Validate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Validate.ItemClick
            Control_Validate_Journal_Entries()
        End Sub

        Friend Sub Control_Verify()
            With gridView
                If .SelectedRowsCount > 0 Then
                    If Not class_Procedures.actionAsk("Verify Journal", "Verify Journal Transactions", "Update the wrong data") Then Return

                    class_Procedures.splash_Show($"Updating IsJournal Transactions of the selected Journal Reference Entries")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False

                    'If bClearSelection Then .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If .GetFocusedRowCellDisplayText(colJournal_Status).Contains("ERROR") Then Continue For

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Entries", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        class_Saga_Database.Journal_Verify(.GetRowCellValue(iRowHandle, colTable_ID), "VERIFY_JOURNAL", .GetRowCellValue(iRowHandle, colID))
                    Next

                    class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colJournal_Reference), gridView.GetFocusedRowCellValue(colTable_ID))

                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"The selected Journal Entries were Verified.", "IsJournal Update")
                    class_Procedures.splash_Close()
                End If
            End With
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            Control_Verify()
        End Sub

        Private Sub btn_Batch_Transactions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Batch_Transactions.ItemClick
            Dim sBrCode As String = gridView.GetFocusedRowCellValue(colBranch_Code)
            Dim iID As Integer = Convert.ToInt32(gridView.GetFocusedRowCellValue(colID))
            Dim dtPosting As Date = Convert.ToDateTime(gridView.GetFocusedRowCellValue(colPosting_Date))
            Dim sReference As String = gridView.GetFocusedRowCellDisplayText(colJournal_Reference)
            Dim sAccountName As String = gridView.GetFocusedRowCellDisplayText(colAccount_Name)

            If gridView.GetFocusedRowCellDisplayText(colJournal_Type).Contains("COLLECTION") Then
                class_Saga_Procedures.Show_Branch_Collections(sBrCode, dtPosting, iID, sReference, sAccountName)

            ElseIf gridView.GetFocusedRowCellDisplayText(colJournal_Type).Contains("CASHIERING") Then
                class_Saga_Procedures.Show_Branch_Cashiering(sBrCode, dtPosting, iID, sReference, sAccountName)

            End If
        End Sub

    End Class

End Namespace