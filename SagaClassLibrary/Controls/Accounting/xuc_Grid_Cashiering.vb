Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPrinting
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Controls.Accounting

    Public Class xuc_Grid_Cashiering
        Inherits DevExpress.XtraEditors.XtraUserControl

        Friend bLoopLive, bLoopStop, bCustomPosting, bUpdateTableID, bUpdateORNumber As Boolean
        Friend dtPosting, dtCustomDate As Date
        Friend iTableID, iLoopActionMode As Integer
        Friend sBrCode, sORNumber As String

        Friend eLoadType As eLoad_Type

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

            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Cashiering_Procedures", "TransactionOtherCash")

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

        Friend Sub Control_Data_Load(Optional ByVal sActionType As String = "LOAD", Optional ByVal sSearch As String = "")
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", sBrCode),
                New SqlParameter("@Date_Start", class_Saga_Variables.dtStart),
                New SqlParameter("@Date_End", class_Saga_Variables.dtEnd),
                New SqlParameter("@Search", sSearch),
                New SqlParameter("@Action_Type", sActionType)
            }

            class_Database.Procedure_BindData(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Cashiering_Procedures", "TransactionOtherCash")
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Reload.ItemClick
            Select Case eLoadType
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

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                popupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If gridView.SelectedRowsCount > 0 Then
                Select Case e.KeyCode
                    Case Keys.F2
                        If Convert.ToInt32(gridView.GetFocusedRowCellValue(colID)) > 0 Then
                            class_Saga_Procedures.Show_Account_Payment(True, gridView.GetFocusedRowCellDisplayText(colID))
                        End If

                    Case Keys.F6
                        class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colOR_Code), gridView.GetFocusedRowCellValue(colID))

                    Case Keys.Enter
                        If gridView.FocusedColumn.Name.Equals("colORNumber") Then
                            Setup_OR_Number()
                        End If
                End Select
            End If
        End Sub

        Private Sub Setup_OR_Number()
            If bUpdateORNumber AndAlso class_Variables.isAdministrator Then
                If class_Procedures.actionAsk("Update OR Number", "Update OR Number", "You might update the wrong OR Number.") Then
                    Dim sOROld As String = gridView.GetFocusedRowCellDisplayText(colOR_Code).ToUpper
                    Dim sORNew As String = class_Functions.Show_Input_Box("Input new OR Number", "New OR Number", $"{repositoryItemLookUpEdit_Branch.GetDataSourceRowByDisplayValue("Pre_Code")}-{sOROld}").ToUpper
                    If Not sOROld.Equals(sORNew) Then
                        If class_Database.Query_Execute(class_Database.ICSConnection, $"UPDATE TransactionOtherCash SET ReferenceNumber = '{sORNew}', ORNumber = '{sORNew}' WHERE ORNumber LIKE '{sOROld}'", True, "Update OR Number", "Update OR Number") Then
                            class_Database.Query_Execute(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries SET Journal_Reference = '{sORNew}' WHERE Journal_Reference LIKE '{sOROld}'")

                            gridView.SetFocusedRowCellValue(colReference, sORNew)
                            gridView.SetFocusedRowCellValue(colOR_Code, sORNew)
                        End If
                    End If
                End If
            Else
                class_Saga_Procedures.Show_Account_Payment(True, gridView.GetFocusedRowCellDisplayText(colID))
            End If
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            With gridView
                If (.RowCount > 0) AndAlso e.Clicks.Equals(2) Then
                    Select Case e.Column.Name
                        Case "colID"
                            class_Saga_Procedures.Show_Account_Payment(True, .GetFocusedRowCellDisplayText(colID))

                        Case "colCIFNo"
                            class_Saga_Procedures.Show_Customer(e.CellValue.ToString)

                        Case "colReferenceNumber"
                            Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT BranchCode, AccountNumber, LedgerSetNumber, AccountName, ORnumber FROM view_Payment_Transactions WHERE ORnumber LIKE '{ .GetFocusedRowCellDisplayText(colOR_Code)}'")
                                Try
                                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                                        myDataReader.Read()
                                        'Dim sBranchCode As String = myDataReader("BranchCode").ToString
                                        Dim sAccountNumber As String = myDataReader("AccountNumber").ToString
                                        Dim iLedger As Integer = Convert.ToInt32(myDataReader("LedgerSetNumber"))
                                        Dim sName As String = myDataReader("AccountName").ToString

                                        class_Saga_Procedures.Show_Account_Payments(sAccountNumber, iLedger, sName) 'sBranchCode,
                                    End If
                                Catch ex As Exception
                                    class_Procedures.Show_Error(ex)
                                End Try
                            End Using

                        Case "colOR_Code"
                            Setup_OR_Number()

                        Case "colIBP_OR"
                            class_Saga_Procedures.Show_Account_Payment(False, .GetFocusedRowCellDisplayText(colIBP_ID))

                        Case "colTransactedBy"
                            class_Saga_Procedures.Show_User_Activity(e.CellValue.ToString)

                        Case "colIBP_ID"
                            class_Saga_Procedures.Show_Account_Payment(False, .GetFocusedRowCellDisplayText(colIBP_ID))

                        Case Else
                            If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                    End Select
                End If
            End With
        End Sub

        Friend Sub Validate_Payments()
            If gridView.DataRowCount > 0 Then
                class_Procedures.splash_Show("validating payments")

                Dim sORNumber As String

                gridView.ClearSelection()
                For i As Integer = 0 To gridView.DataRowCount
                    gridView.MakeRowVisible(i)

                    sORNumber = gridView.GetRowCellDisplayText(i, colOR_Code)

                    If sORNumber.Contains(" ") Then gridView.SelectRow(i)
                Next
                class_Procedures.splash_Close()
            End If
        End Sub

        Friend Sub Update_List()
            With gridView
                If .DataRowCount > 0 Then
                    If Not class_Procedures.actionAsk("Inter-Branch Payment(s)", "Execute Inter-Branch Payment(s) Update", "This might take longer time to execute") Then Return

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()


                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Cashiering", "updated", bLoopStop, bLoopLive,, "Remarks") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sORNumber As String = .GetRowCellDisplayText(iRowHandle, colOR_Code)

                        If sORNumber.Contains(" ") Then
                            sORNumber = sORNumber.Replace(" ", String.Empty)
                            class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE TransactionOtherCash SET ORNumber = '{sORNumber}' WHERE ID LIKE '{ .GetRowCellValue(iRowHandle, colID)}'")
                        End If

                        .SetRowCellValue(iRowHandle, colOR_Code, sORNumber)
                    Next
                End If
            End With
        End Sub

        Friend Sub Show_Journal_Entries()
            If gridView.SelectedRowsCount > 0 Then
                class_Saga_Procedures.Show_Journal_Entries_Reference(gridView.GetFocusedRowCellDisplayText(colOR_Code), gridView.GetFocusedRowCellValue(colID), $"{gridView.GetFocusedRowCellDisplayText(colIBP_Account)}-{gridView.GetFocusedRowCellDisplayText(colIBP_Ledger)}", gridView.GetFocusedRowCellDisplayText(coAccount_Name), gridView.GetFocusedRowCellDisplayText(colNotes))
            End If
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick

            Show_Journal_Entries()
        End Sub

        Private Sub btn_Batch_Transactions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Batch_Transactions.ItemClick

            class_Saga_Procedures.Show_Branch_Cashiering(repositoryItemLookUpEdit_Branch.GetKeyValueByDisplayText(gridView.GetFocusedRowCellDisplayText(colBranch_Code)).ToString, Convert.ToDateTime(gridView.GetFocusedRowCellValue(colPosting_Date)), Convert.ToInt32(gridView.GetFocusedRowCellValue(colID)), gridView.GetFocusedRowCellDisplayText(colOR_Code), gridView.GetFocusedRowCellDisplayText(coAccount_Name))
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick

            With gridView
                If .DataRowCount > 0 Then
                    If Not class_Procedures.actionAsk("Update Cashiering", "Update Cashiering transactions") Then Return

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()


                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Cashiering Update", "updated", bLoopStop,,, "Remarks") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        If .GetRowCellDisplayText(iRowHandle, colNotes).Contains("Updated") Then Continue For

                        Dim sBrCodeIB As String
                        Try
                            sBrCodeIB = repositoryItemLookUpEdit_Branch.GetKeyValueByDisplayText(.GetRowCellDisplayText(iRowHandle, colIBP_Branch_Code)).ToString
                        Catch ex As Exception
                            .SetRowCellValue(iRowHandle, colNotes, $"[{iRowHandle}] Branch Error")
                            Exit For
                        End Try

                        Dim sReference As String = .GetRowCellDisplayText(iRowHandle, colOR_Code)
                        Dim sBrCode As String = repositoryItemLookUpEdit_Branch.GetKeyValueByDisplayText(.GetRowCellDisplayText(iRowHandle, colBranch_Code)).ToString

                        Dim sTableID As String = .GetRowCellDisplayText(iRowHandle, colID)

                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Journal_Entries Set Table_ID = '{sTableID}' WHERE Journal_Reference LIKE '{sReference}' AND Branch_Code LIKE '{sBrCode}'")

                        .SetRowCellValue(iRowHandle, colNotes, $"[{iRowHandle}] Updated")
                    Next
                End If
            End With
        End Sub

        Private Sub btn_Stop_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
            class_Saga_Variables.bLoopStop = True
        End Sub

        Private Sub btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            Execute_Cashiering_Journal(True)
        End Sub

        Friend Sub Execute_Cashiering_Journal(ByVal bConfirm As Boolean)
            With gridView
                If .DataRowCount > 0 Then
                    If bCustomPosting Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"You are about to execute/post selected transaction(s) into Journal Entries on {dtCustomDate.ToShortDateString} as Late Posting instead of transaction posting date.{Environment.NewLine}{Environment.NewLine}Please continue if you are certain.", "Late Posting Confirmation", True)
                    End If

                    If Not class_Procedures.actionAsk("Execute Journal Entries", "Execute Journal Entries [Payments]") Then Return
                    class_Procedures.splash_Show($"Executing Journal Entries{Environment.NewLine}[Payment Collections]{Environment.NewLine}Click Stop to stop or halt the execution.")

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

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Cashiering Journal", "executed", bLoopStop,,, "Remarks") Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Try
                            Dim sPayType As String = .GetRowCellDisplayText(iRowHandle, colPayment_Code)
                        Catch ex As Exception
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Cashiering transaction must have Pay Type that is required for Journal Entries.{Environment.NewLine}Please contact Branch Cashier or Update the transaction.")
                            Return
                        End Try

                        class_Saga_Database.Journal_Entry_Save("CASHIERING", .GetRowCellValue(iRowHandle, colID), .GetRowCellValue(iRowHandle, colPosting_Date))
                    Next

                    class_Saga_Procedures.Show_Journal_Entries_Reference(.GetRowCellDisplayText(iRowHandle, colOR_Code), .GetRowCellValue(iRowHandle, colID))

                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Journal Entry [Payments]{Environment.NewLine}Between Date Range were successfully executed.")
                    class_Procedures.splash_Close()
                End If
            End With
        End Sub

        Private Sub btn_Verify_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Verify.ItemClick
            class_Database.DBError = False
            With gridView
                If .SelectedRowsCount > 0 Then
                    class_Procedures.splash_Show($"updating IsJournal Transactions of the selected Collections")

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

                        class_Saga_Database.Journal_Verify(Convert.ToInt32(.GetRowCellValue(iRowHandle, colID)), "CASHIERING")
                    Next

                    Show_Journal_Entries()
                End If
            End With
        End Sub

    End Class

End Namespace