Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPrinting
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Controls.Accounting

    Public Class xuc_Grid_Collection
        Inherits DevExpress.XtraEditors.XtraUserControl

        Friend eLoadType As eLoad_Type

        Friend bErrors, bLoopStop, bLoopLive, bCustomPosting, bUpdateTableID, bUpdateORNumber, bSP As Boolean
        Friend dtPosting, dtCustomDate As Date
        Friend sBrCode, sORNumber, sAccountNumber, sAccountName As String
        Friend iTableID, iLedger, iLoopActionMode As Integer

        Public Sub New()
            InitializeComponent()

            Dim repositoryBranch = New RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Branch(repositoryBranch)
            colBranch_Code.ColumnEdit = repositoryBranch
            colIBP_Branch_Code.ColumnEdit = repositoryBranch
        End Sub

        'Branch and Posting Date
        Friend Sub Control_Data_Load(ByVal sBrCode As String, ByVal dtPosting As Date, ByVal iTableID As Integer, ByVal sORNumber As String)
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", sBrCode),
                New SqlParameter("@Date_Start", dtPosting),
                New SqlParameter("@Date_End", dtPosting),
                New SqlParameter("@Action_Type", "LOAD")
            }

            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Collection_Procedures", "TransactionPayments")

            If iTableID > 0 Then
                gridView.ClearSelection()
                For i As Integer = 0 To gridView.DataRowCount - 1
                    If Convert.ToInt32(gridView.GetRowCellValue(i, colID)).Equals(iTableID) Or gridView.GetRowCellDisplayText(i, colOR_Code).Equals(sORNumber) Then
                        gridView.SelectRow(i)
                        gridView.MakeRowVisible(i)
                        Exit For
                    End If
                Next
            Else
                gridView.MoveLastVisible()
            End If
        End Sub

        'Account Ledger
        Friend Sub Control_Data_Load(ByVal sAccountNumber As String, ByVal iLedger As Integer)
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Account_Code", sAccountNumber),
                New SqlParameter("@Ledger", iLedger),
                New SqlParameter("@Action_Type", "LOAD_ACCOUNT")
            }

            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Collection_Procedures", "TransactionPayments")
        End Sub

        'Collections
        Friend Sub Control_Data_Load(Optional ByVal sActionType As String = "LOAD", Optional ByVal sSearch As String = "")
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", sBrCode),
                New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Search", sSearch),
                New SqlParameter("@Action_Type", sActionType)
            }

            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Collection_Procedures", "TransactionPayments")
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            With gridView
                If .SelectedRowsCount > 0 Then
                    Select Case e.KeyCode
                        Case Keys.F2
                            If Convert.ToInt32(.GetFocusedRowCellValue(colID)) > 0 Then
                                class_Saga_Procedures.Show_Account_Payment(False, .GetFocusedRowCellDisplayText(colID))
                            End If

                        Case Keys.F6
                            Show_Journal_Entries()

                        Case Keys.Enter
                            Select Case .FocusedColumn.Name
                                Case "colORNumber"
                                    class_Saga_Procedures.Show_Account_Payment(False, .GetFocusedRowCellDisplayText(colID))
                            End Select

                        Case Keys.Delete
                            Payment_Delete()
                    End Select
                End If
            End With
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gridView.MouseDown, gridControl.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                popupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick

            Select Case eLoadType
                Case class_Saga_Variables.eLoad_Type.Account
                    Control_Data_Load(sAccountNumber, iLedger)

                Case class_Saga_Variables.eLoad_Type.Range
                    Control_Data_Load()

                Case class_Saga_Variables.eLoad_Type.Batch
                    Control_Data_Load(sBrCode, dtPosting, iTableID, sORNumber)
            End Select
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            With gridView
                If (.RowCount > 0) AndAlso e.Clicks.Equals(2) Then
                    Dim sAccountCode As String = .GetFocusedRowCellDisplayText(colAccount)
                    Dim sAccountName As String = .GetFocusedRowCellDisplayText(colAccountName)

                    Select Case e.Column.Name
                        Case "colID"
                            If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                            class_Saga_Procedures.Show_Account_Payment(False, .GetFocusedRowCellDisplayText(colID))

                        Case "colReference"
                            Try
                                class_Saga_Procedures.Show_Account_Payments(sAccountCode, Convert.ToInt32(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT AccountNumber, LedgerSetNumber, ORNumber FROM TransactionPayments WHERE ORNumber LIKE '{e.CellValue}'", "LedgerSetNumber")), sAccountName)
                            Catch ex As Exception
                                class_Saga_Procedures.Show_Account_Payments(sAccountCode, Convert.ToInt32(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT AccountNumber, LedgerSetNumber, ReferenceNumber FROM TransactionPayments WHERE ReferenceNumber LIKE '{e.CellValue}'", "LedgerSetNumber")), sAccountName)
                            End Try

                        Case "colOR_Code"
                            If bUpdateORNumber AndAlso class_Variables.isAdministrator Then
                                If class_Procedures.actionAsk("Update OR Number", "Update OR Number", "You might update the wrong OR Number.") Then
                                    Dim sOROld As String = .GetFocusedRowCellDisplayText(colOR_Code).ToUpper
                                    Dim sORNew As String = class_Functions.Show_Input_Box("Input new OR Number", "New OR Number", sOROld).ToUpper
                                    If Not sOROld.Equals(sORNew) Then
                                        If class_Database.Query_Execute(class_Database.ICSConnection, $"UPDATE TransactionPayments SET ReferenceNumber = '{sORNew}', ORNumber = '{sORNew}' WHERE ORNumber LIKE '{sOROld}'", True, "Update OR Number", "Update OR Number") Then
                                            class_Database.Query_Execute(class_Database.ICSConnection, $"UPDATE CustLedger SET ReferenceNumber = '{sORNew}', ORNumber = '{sORNew}' WHERE ORNumber LIKE '{sOROld}'")
                                            class_Database.Query_Execute(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET Journal_Reference = '{sORNew}' WHERE Journal_Reference LIKE '{sOROld}'")

                                            .SetFocusedRowCellValue(colReference, sORNew)
                                            .SetFocusedRowCellValue(colOR_Code, sORNew)
                                        End If
                                    End If
                                End If
                            Else
                                class_Saga_Procedures.Show_Account_Payment(False, .GetFocusedRowCellDisplayText(colID))
                            End If

                        Case "colAccount", "colLedger"
                            class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, .GetFocusedRowCellDisplayText(colAccount), Convert.ToInt32(.GetFocusedRowCellValue(colLedger)))

                        Case "colAdded_By"
                            class_Saga_Procedures.Show_User_Activity(e.CellValue.ToString)

                        Case "colIBP_Added_By"
                            class_Saga_Procedures.Show_User_Activity(e.CellValue.ToString)

                        Case "colIBP_ID"
                            class_Saga_Procedures.Show_Account_Payment(True, .GetFocusedRowCellValue(colIBP_ID))

                        Case Else
                            If e.CellValue Is Nothing Then
                                Return
                            Else
                                class_Procedures.Copy_Clipboard(e.CellValue.ToString)
                            End If

                    End Select
                End If
            End With
        End Sub

        Private Sub btn_Validation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Validate.ItemClick
            Validate_Payments()
        End Sub

        Friend Function IsValidated(ByVal iRow As Integer) As Boolean
            With gridView
                Dim sPayType As String = .GetRowCellDisplayText(iRow, colPayment_Code)
                'Dim sBrand As String = .GetRowCellDisplayText(iRow, colBrand)

                'If sBrand.Equals(String.Empty) Then
                '    .SetRowCellValue(iRow, colNotes, "*Brand is missing.")
                '    Return False
                'End If

                Select Case sPayType
                    Case "APAY"
                        Dim dAmountPaid As Decimal = Convert.ToDecimal(.GetRowCellDisplayText(iRow, colAmount_Paid))
                        Dim dPrincipal As Decimal = Convert.ToDecimal(.GetRowCellValue(iRow, colPrincipal))
                        Dim dInterest As Decimal = Convert.ToDecimal(.GetRowCellValue(iRow, colInterest))
                        Dim dRebate As Decimal = Convert.ToDecimal(.GetRowCellValue(iRow, colRebates))
                        Dim dPenalty As Decimal = Convert.ToDecimal(.GetRowCellValue(iRow, colPenalty))

                        Dim dVAT As Decimal
                        Try
                            dVAT = Convert.ToDecimal(.GetRowCellValue(iRow, colVAT))
                        Catch ex As Exception
                            dVAT = 0
                        End Try

                        Dim dNoVAT As Decimal
                        Try
                            dNoVAT = Convert.ToDecimal(.GetRowCellValue(iRow, colNoVAT))
                        Catch ex As Exception
                            dNoVAT = 0
                        End Try

                        Dim dIBAmountPaid As Decimal
                        Try
                            dIBAmountPaid = Convert.ToDecimal(.GetRowCellDisplayText(iRow, colIBP_Amount_Paid))
                        Catch ex As Exception
                            dIBAmountPaid = 0
                        End Try

                        Dim dtPosted As Date = Convert.ToDateTime(.GetRowCellValue(iRow, colPosting_Date))

                        Dim dtIBPosted As Date
                        Try
                            dtIBPosted = Convert.ToDateTime(.GetRowCellValue(iRow, colIBP_Posting_Date))
                        Catch ex As Exception
                            dtIBPosted = dtPosted
                        End Try

                        If Not dtPosted.Equals(dtIBPosted) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"*IBC vs. Non-Cash Posting Dates are not equal.", "Posting Date Error", True)
                            Return False
                        End If

                        If Not dAmountPaid.Equals(dIBAmountPaid) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"*IBC vs. Non-Cash Amounts are not equal.", "Payment Collection Error", True)
                            Return False
                        End If

                        Dim dDebit As Decimal = Math.Round(dAmountPaid + dInterest + dRebate, 2)
                        Dim dCredit As Decimal = Math.Round(dPrincipal + dInterest + dVAT + dNoVAT + dPenalty, 2)

                        If Not dDebit.Equals(dCredit) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"*[Paid Amount + Interest + Rebate] = {dDebit:N2}{Environment.NewLine}is not equal with{Environment.NewLine}[Principal] + [Interest] + [VAT] + [NoVAT] + [Penalty] = {dCredit:N2}", "Payment Collection Error", True)
                            Return False
                        End If
                End Select
            End With
            Return True
        End Function

        Friend Sub Validate_Payments()
            'Dim sPayType, sReference, sORNumber As String
            bLoopStop = False
            With gridView
                If .DataRowCount > 0 Then
                    class_Procedures.splash_Show("validating payments")

                    .ClearSelection()
                    For i As Integer = 0 To .DataRowCount

                        If bLoopStop Then
                            .SetRowCellValue(i, colNotes, "Validation stopped by the user.")
                            class_Procedures.Loop_Stop_Message("Collections", "validated")
                            Return
                        End If

                        If .GetRowCellDisplayText(i, colPayment_Code).Equals("DP") Then Continue For

                        Dim sPayType As String = .GetRowCellDisplayText(i, colPayment_Code)

                        If sPayType.Contains("PAY") Then
                            Dim sReference As String = .GetRowCellDisplayText(i, colReference)
                            Dim sORNumber As String = .GetRowCellDisplayText(i, colOR_Code)

                            If sReference.Contains(" ") Then
                                .SetRowCellValue(i, colNotes, $"*Reference contains blanks(_) and/or in wrong format.")
                                .SelectRow(i)
                            End If

                            If sORNumber.Contains(" ") Then
                                .SetRowCellValue(i, colNotes, $"*OR Code-Number contains blanks(_) and/or in wrong format.")
                                .SelectRow(i)
                            End If
                        End If

                        If Not IsValidated(i) Then
                            .SelectRow(i)
                            .FocusedRowHandle = i
                            .MakeRowVisible(i)
                            Application.DoEvents()
                        End If
                    Next

                    If .SelectedRowsCount > 0 Then class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"There are { .SelectedRowsCount} invalid payment entries found.{Environment.NewLine}Please check OR Number and/or Amount figures.")
                    class_Procedures.splash_Close()
                End If
            End With
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            Payment_Update()
        End Sub

        Friend Sub Payment_Update()
            With gridView
                If .DataRowCount > 0 Then
                    If Not class_Procedures.actionAsk("Collection Payment(s) Update", "Execute Collection Payment(s) update") Then Return

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Collections", "updated", bLoopStop,,, "Note") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If IsValidated(iRowHandle) Then
                            .SelectRow(iRowHandle)
                            Continue For
                        End If

                        Dim iTableID As Integer = Convert.ToInt32(.GetRowCellValue(iRowHandle, colID))

                        Dim dPrincipal As Decimal = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colPrincipal))
                        Dim dInterest As Decimal = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colInterest))
                        Dim dRebate As Decimal = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colRebates))
                        Dim dPenalty As Decimal = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colPenalty))

                        Dim dVATOld As Decimal
                        Try
                            dVATOld = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colVAT))
                        Catch ex As Exception
                            dVATOld = 0
                            class_Procedures.Show_Error(ex)
                        End Try

                        Dim dNoVATOld As Decimal
                        Try
                            dNoVATOld = Convert.ToDecimal(.GetRowCellValue(iRowHandle, colNoVAT))
                        Catch ex As Exception
                            dNoVATOld = 0
                            class_Procedures.Show_Error(ex)
                        End Try

                        If Not IsValidated(iRowHandle) AndAlso dInterest > 0 Then
                            Dim dVAT As Decimal = class_Functions.calculate_VAT(dInterest)
                            Dim dNoVAT As Decimal = class_Functions.calculate_no_VAT(dInterest)

                            Dim sNoteOld As String = .GetRowCellDisplayText(iRowHandle, colNotes)
                            Dim sNote As String = $"UPDATED VAT: {dVATOld}->{dVAT} & Non-VAT: {dNoVATOld}->{dNoVAT} [{Date.Now.ToShortDateString} {DateTime.Now.ToLongTimeString}]"

                            Dim dPaid As Decimal = (dPrincipal + dInterest + dPenalty) - dRebate
                            .SetRowCellValue(iRowHandle, colAmount_Paid, $"{dPaid}")
                            .SetRowCellValue(iRowHandle, colVAT, $"{dVAT}")
                            .SetRowCellValue(iRowHandle, colNoVAT, $"{dNoVAT}")

                            If sNoteOld.Contains(sNote) Then
                                .SetRowCellValue(iRowHandle, colNotes, $"{sNoteOld.Trim}")
                            Else
                                .SetRowCellValue(iRowHandle, colNotes, $"{sNoteOld} {sNote.Trim}")
                            End If

                            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                                Using MyCommand As SqlCommand = New SqlCommand($"UPDATE TransactionPayments SET AmountPaid = @AmountPaid, VAT = @VAT, AmntNetOfVat = @AmntNetOfVat WHERE ID LIKE '{iTableID}'", MySQLConnection)
                                    MyCommand.Parameters.Add("@AmountPaid", SqlDbType.Money).Value = dPaid
                                    MyCommand.Parameters.Add("@VAT", SqlDbType.Money).Value = dVAT
                                    MyCommand.Parameters.Add("@AmntNetOfVat", SqlDbType.Money).Value = dNoVAT

                                    Try
                                        MySQLConnection.Open()
                                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"ID-{iTableID}{Environment.NewLine}{sNote}{Environment.NewLine}was successfully updated.")
                                            .SetRowCellValue(iRowHandle, colNotes, sNote)
                                        End If
                                    Catch ex As Exception
                                        class_Procedures.Show_Error(ex)
                                    End Try
                                End Using
                            End Using
                        End If
                    Next
                End If
            End With
        End Sub

        Private Sub Payment_Delete()
            If class_Procedures.actionAsk("Delete Collections", "Delete selected Payment Collections") Then
                With gridView

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Delete Collection", "deleted", bLoopStop,, True, "Note") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM TransactionPayments WHERE ID LIKE '{ .GetRowCellDisplayText(iRowHandle, colID)}'")
                    Next

                    Try
                        .DeleteSelectedRows()
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    Finally
                        Control_Data_Load(sAccountNumber, iLedger)
                        .ClearColumnsFilter()
                        .BestFitColumns()
                    End Try
                End With
            End If
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick

            Payment_Delete()
        End Sub

        Private Sub gridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gridView.CellValueChanged
            Select Case e.Column.Name
                Case "colPrincipal_Balance", "colInterest_Balance"
                    gridView.SetRowCellValue(e.RowHandle, colOustanding_Balance, Convert.ToDecimal(gridView.GetRowCellValue(e.RowHandle, colPrincipal_Balance)) + Convert.ToDecimal(gridView.GetRowCellValue(e.RowHandle, colInterest_Balance)))
            End Select
        End Sub

        Friend Sub Show_Journal_Entries()
            If gridView.SelectedRowsCount > 0 Then
                Dim sReference As String
                If gridView.GetFocusedRowCellDisplayText(colPayment_Code).Contains("PAY") Then
                    sReference = gridView.GetFocusedRowCellDisplayText(colOR_Code).Trim
                Else
                    sReference = gridView.GetFocusedRowCellDisplayText(colEngine).Trim
                End If
                class_Saga_Procedures.Show_Journal_Entries_Reference(sReference, gridView.GetFocusedRowCellValue(colID), $"{gridView.GetFocusedRowCellDisplayText(colAccount)}-{gridView.GetFocusedRowCellDisplayText(colLedger)}", gridView.GetFocusedRowCellDisplayText(colAccountName), gridView.GetFocusedRowCellDisplayText(colPayment_Code))
            End If
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick

            Show_Journal_Entries()
        End Sub

        Private Sub btn_Journal_Entries2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries2.ItemClick
            class_Saga_Procedures.Show_Journal_Entries(class_Saga_Variables.eLoad_Type.CIF, $"{gridView.GetFocusedRowCellDisplayText(colAccount)}-{gridView.GetFocusedRowCellDisplayText(colLedger)}", gridView.GetFocusedRowCellDisplayText(colAccountName), gridView.GetFocusedRowCellDisplayText(colEngine))
        End Sub

        Private Sub btn_Batch_Transactions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Batch_Transactions.ItemClick
            If gridView.GetFocusedRowCellDisplayText(colPayment_Code).Equals("DP") Or gridView.GetFocusedRowCellDisplayText(colPayment_Code).Contains("COD") Then
                class_Saga_Procedures.Show_Releases(sBrCode, gridView.GetFocusedRowCellValue(colID), gridView.GetFocusedRowCellValue(colEngine))
            Else
                class_Saga_Procedures.Show_Branch_Collections(gridView.GetFocusedRowCellValue(colBranch_Code), Convert.ToDateTime(gridView.GetFocusedRowCellValue(colPosting_Date)), Convert.ToInt32(gridView.GetFocusedRowCellValue(colID)), gridView.GetFocusedRowCellDisplayText(colOR_Code), gridView.GetFocusedRowCellDisplayText(colAccountName))
            End If
        End Sub

        Private Sub btn_Stop_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
            class_Saga_Variables.bLoopStop = True
        End Sub

        Private Sub btn_Journal_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            Execute_Collections_Journal(True)
        End Sub

        Private Sub btn_Journal2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal2.ItemClick
            If class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM acc_Journal_Entries WHERE Journal_Reference LIKE '{gridView.GetFocusedRowCellDisplayText(colOR_Code)}' AND Journal_Status LIKE '%CANCELLED%'", "Cancelled Journal Entries") Then
                Execute_Collections_Journal(False, True)
            End If
        End Sub

        Friend Sub Execute_Collections_Journal(ByVal bAsk As Boolean, Optional ByVal bShowJournalEntries As Boolean = False)
            class_Database.DBError = False
            With gridView
                If .DataRowCount > 0 Then
                    If bCustomPosting Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"You are about to execute/post selected transaction(s) into Journal Entries on {dtCustomDate.ToShortDateString} as Late Posting instead of transaction posting date.{Environment.NewLine}{Environment.NewLine}Please continue if you are certain.", "Late Posting Confirmation", True)
                    End If

                    Select Case eLoadType
                        Case class_Saga_Variables.eLoad_Type.Range
                            If Not class_Procedures.actionAsk("Execute Journal Entries", "Execute Journal Entries [Payments]") Then Return
                            class_Procedures.splash_Show($"Executing Journal Entries{Environment.NewLine}[Payment Collections]{Environment.NewLine}Click Stop to stop or halt the execution.")

                        Case Else
                            class_Procedures.splash_Show($"Executing Journal Entries{Environment.NewLine}[Payments]{Environment.NewLine}{sAccountNumber}-{iLedger}{Environment.NewLine}{sAccountName}")
                    End Select

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        Try
                            Select Case iLoopActionMode
                                Case 1
                                    If Not Convert.ToBoolean(.GetRowCellValue(iRowHandle, colIsJournal)) Then Continue For
                                Case 2
                                    If Convert.ToBoolean(.GetRowCellValue(iRowHandle, colIsJournal)) Then Continue For
                            End Select
                        Catch ex As Exception

                        End Try

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Collection Journal", "executed", bLoopStop, True,, "Note") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sPayType As String = .GetRowCellDisplayText(iRowHandle, colPayment_Code)

                        If sPayType.Contains("PAY") AndAlso Not IsValidated(iRowHandle) Then Continue For

                        If sPayType.Equals("APAY") Then
                            If Not Convert.ToBoolean(.GetRowCellValue(iRowHandle, colIBP_Is_Journal)) Then
                                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "The Branch who received the payment collection amount should execute Journal Entries first before the Local Branch.", "Inter-Branch Journal Error", True)
                                Continue For
                            End If
                        End If

                        class_Saga_Database.Journal_Entry_Save("COLLECTION", .GetRowCellValue(iRowHandle, colID), .GetRowCellValue(iRowHandle, colPosting_Date))
                    Next

                    If bShowJournalEntries Then Show_Journal_Entries()
                End If
            End With
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    class_Procedures.splash_Show($"Verifying IsJournal Transactions of the selected Collections")

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()


                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        Try
                            Select Case iLoopActionMode
                                Case 1
                                    If Not Convert.ToBoolean(.GetRowCellValue(iRowHandle, colIsJournal)) Then Continue For
                                Case 2
                                    If Convert.ToBoolean(.GetRowCellValue(iRowHandle, colIsJournal)) Then Continue For
                            End Select
                        Catch ex As Exception

                        End Try

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Journal Entry Verification", "verified", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), "COLLECTION")
                    Next

                    Show_Journal_Entries()
                End If
            End With
        End Sub

    End Class

End Namespace