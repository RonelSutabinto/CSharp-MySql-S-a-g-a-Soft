Imports System.Data.SqlClient
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports wSClassLib.myModules

Namespace Modules
    Module Module_Data
        Friend bLoopStop As Boolean

        Public Function SetDataset(ByVal sConnection As String, ByVal ds As DataSet, ByVal sQuery As String, ByVal sTable As String) As DataSet
            FillData(sConnection, ds, myDataAdapter, sQuery, sTable)
            Return ds
        End Function

        Public Function BindSource(ByVal sConnection As String, ByVal ds As DataSet, ByVal sQuery As String, ByVal sTable As String) As BindingSource
            Try
                FillData(sConnection, ds, myDataAdapter, sQuery, sTable)
                Dim bs As BindingSource = New BindingSource() With {
                .DataSource = ds,
                .DataMember = sTable
            }
                Return bs
            Catch Ex As ArgumentException
                Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.ParamName}{Environment.NewLine}{Ex.Message}")
            End Try
            Return Nothing
        End Function

        Public Function BindData(ByVal sConnection As String, ByVal lookUpEdit As LookUpEdit, ByVal sQuery As String, ByVal sTable As String) As Boolean
            Try
                splash_Show($"loading {sTable}")
                Using ds As DataSet = New DataSet()
                    lookUpEdit.Properties.DataSource = BindSource(sConnection, ds, sQuery, sTable)
                    lookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
                End Using
                Return True
            Catch Ex As ArgumentException
                Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.ParamName}{Environment.NewLine}{Ex.Message}")
                Return False
            Finally
                splash_Close()
                lookUpEdit.Select()
            End Try
        End Function

        Public Function Procedure_BindData(ByVal sConnection As String, ByVal xRpt As XtraReport, ByVal sProcedureName As String, ByVal Parameters As SqlParameter(), ByVal sTable As String) As Boolean
            Dim MySQLConnection = New SqlConnection(sConnection)
            Using MyCommand As SqlCommand = New SqlCommand(sProcedureName, MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                MyCommand.Parameters.AddRange(Parameters)
                Try
                    splash_Show($"loading {sTable}")
                    Dim da As SqlDataAdapter = New SqlDataAdapter(MyCommand)
                    Dim ds As DataSet = New DataSet()
                    MySQLConnection.Open()
                    ds.Clear()
                    da.Fill(ds, sTable)
                    xRpt.DataMember = sTable
                    xRpt.DataSource = ds
                    Dim rpTool As ReportPrintTool = New ReportPrintTool(xRpt)
                    rpTool.ShowRibbonPreview()
                    Return True
                Catch Ex As ArgumentException
                    Modules.Set_Message(Modules.MsgMode.Sql, $"{Environment.NewLine}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                Catch Ex As InvalidOperationException
                    Modules.Set_Message(Modules.MsgMode.Sql, $"{Environment.NewLine}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                Catch Ex As SqlException
                    Modules.Set_Message(Modules.MsgMode.Sql, $"{Environment.NewLine}{Ex.ErrorCode}{Environment.NewLine}{Ex.Server}{Environment.NewLine}{Ex.Source}-{Ex.Procedure}-{Ex.LineNumber}{Environment.NewLine}{Ex.Message}")
                Finally
                    splash_Close()
                End Try
            End Using
            Return False
        End Function

        Public Function Procedure_Retrieve(ByVal sConnection As String, ByVal GridControl As GridControl, ByVal GridView As GridView, ByVal sProcedureName As String, ByVal Parameters As SqlParameter()) As Boolean
            Dim MySQLConnection As SqlConnection = New SqlConnection(sConnection)
            Using MyCommand As SqlCommand = New SqlCommand(sProcedureName, MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                MyCommand.Parameters.AddRange(Parameters)
                Dim iRow = GridView.FocusedRowHandle
                Try
                    splash_Show($"retrieving Data")
                    GridView.LoadingPanelVisible = True

                    MySQLConnection.Open()
                    Dim dr As SqlDataReader = MyCommand.ExecuteReader()
                    If dr.HasRows Then
                        GridControl.DataSource = dr
                        Return True
                    Else
                        GridControl.DataSource = Nothing
                    End If
                Catch Ex As ArgumentException
                    Modules.Set_Message(Modules.MsgMode.Sql, $"{Environment.NewLine}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                    Return False
                Catch Ex As InvalidOperationException
                    Modules.Set_Message(Modules.MsgMode.Sql, $"{Environment.NewLine}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                    Return False
                Catch Ex As SqlException
                    Modules.Set_Message(Modules.MsgMode.Sql, $"{Environment.NewLine}{Ex.ErrorCode}{Environment.NewLine}{Ex.Server}{Environment.NewLine}{Ex.Source}-{Ex.Procedure}-{Ex.LineNumber}{Environment.NewLine}{Ex.Message}")
                    Return False
                Finally
                    If GridView.DataRowCount < 4000 Then GridView.BestFitColumns()
                    If iRow.Equals(0) Then
                        GridView.MoveFirst()
                    Else
                        GridView.ClearSelection()
                        GridView.SelectRow(iRow)
                        GridView.MakeRowVisible(iRow)
                    End If
                    GridView.LoadingPanelVisible = False
                    splash_Close()
                End Try
            End Using
            Return False
        End Function

        Public Function Procedure_Execute(ByVal sTitle As String, ByVal sProcedureName As String, ByVal Parameters As SqlParameter(), Optional ByVal bAsk As Boolean = False) As Integer
            If bAsk AndAlso Not Query_Execute_Ask(sTitle) Then Return 0
            Using MySQLConnection = New SqlConnection(connectSP)
                Using MyCommand As SqlCommand = New SqlCommand(sProcedureName, MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                    MyCommand.Parameters.AddRange(Parameters)
                    Try
                        splash_Show($"executing Query")
                        MySQLConnection.Open()
                        Dim iRows = MyCommand.ExecuteNonQuery()
                        Modules.Set_Message(Modules.MsgMode.Info, $"Executing {sTitle}{Environment.NewLine}{iRows} row(s) affected.")
                        Return iRows
                    Catch Ex As InvalidOperationException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.HResult}{Environment.NewLine}{Ex.Message}")
                        Return 0
                    Catch Ex As SqlException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.ErrorCode}{Environment.NewLine}{Ex.Server}{Environment.NewLine}{Ex.Source}-{Ex.Procedure}-{Ex.LineNumber}{Environment.NewLine}{Ex.Message}")
                        Return 0
                    Finally
                        splash_Close()
                    End Try
                End Using
            End Using
            Return 0
        End Function

        Public Function Query_Execute_Ask(ByVal sTitle As String, Optional ByVal sQuery As String = "") As Boolean
            Modules.Set_Message(Modules.MsgMode.Warning, $"You are about to Execute [{sTitle}] that might affect data records.{Environment.NewLine}{Environment.NewLine}Please continue if you are certain.", "Execute SQL Query Command", True)
            If XtraMessageBox.Show($"Do you want to execute this:{Environment.NewLine}{sTitle} {sQuery}?{Environment.NewLine}{Environment.NewLine}Note: You can't UNDO this operation.", $"{sTitle}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question).Equals(DialogResult.Yes) Then
                Return True
            Else
                Return False
            End If
        End Function

        Public Function RecordCount(ByVal sQuery As String) As Integer
            Dim i As Integer = 0
            Using MySQLConnection = New SqlConnection(connectSP)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        MySQLConnection.Open()
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            If MyDataReader.HasRows Then
                                While MyDataReader.Read()
                                    i += 1
                                End While
                            End If
                        End Using
                        Return i
                    Catch Ex As InvalidOperationException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.HResult}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                    Catch Ex As SqlException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.ErrorCode}{Environment.NewLine}{Ex.Server}{Environment.NewLine}{Ex.Source}-{Ex.Procedure}-{Ex.LineNumber}{Environment.NewLine}{Ex.Message}")
                    Finally

                    End Try
                End Using
            End Using
            Return 0
        End Function

        Public Function Procedure_Save(ByVal sConnection As String, ByVal sTitle As String, ByVal sProcedureName As String, ByVal Parameters As SqlParameter(), Optional ByVal bAsk As Boolean = False, Optional ByVal sCode As String = "") As Boolean
            If bAsk AndAlso Not DataSaveAsk(sCode) Then Return False

            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sProcedureName, MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                    MyCommand.Parameters.AddRange(Parameters)
                    Try
                        splash_Show($"saving Data")
                        MySQLConnection.Open()
                        Dim i As Integer
                        i = MyCommand.ExecuteNonQuery()
                        Modules.Set_Message(Modules.MsgMode.Save, sTitle)
                        Return CBool(i)
                    Catch Ex As SqlTypes.SqlTypeException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.HResult}{Environment.NewLine}{Ex.Message}")
                        Return False
                    Catch Ex As InvalidOperationException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.HResult}{Environment.NewLine}{Ex.Message}")
                        Return False
                    Catch Ex As SqlException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.ErrorCode}{Environment.NewLine}{Ex.Server}{Environment.NewLine}{Ex.Source}-{Ex.Procedure}-{Ex.LineNumber}{Environment.NewLine}{Ex.Message}")
                        Return False
                    Finally
                        splash_Close()
                    End Try
                End Using
            End Using
            Return False
        End Function

        Public Sub FillData(ByVal sConnection As String, ByVal ds As DataSet, ByVal da As SqlDataAdapter, ByVal sQuery As String, ByVal sTable As String)
            Using MySQLConnection = New SqlConnection(sConnection)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    da.SelectCommand = New SqlCommand(sQuery, MySQLConnection)
                    ds.Clear()
                    Try
                        splash_Show($"loading {sTable}")
                        MySQLConnection.Open()
                        da.Fill(ds, sTable)
                    Catch Ex As FormatException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.HResult}{Environment.NewLine}{Ex.Message}")
                    Catch Ex As OverflowException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.HResult}{Environment.NewLine}{Ex.Message}")
                    Catch Ex As InvalidOperationException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.HResult}{Environment.NewLine}{Ex.Message}")
                    Catch Ex As NullReferenceException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.HResult}{Environment.NewLine}{Ex.Message}")
                    Catch Ex As OutOfMemoryException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.HResult}{Environment.NewLine}{Ex.Message}")
                    Catch Ex As SqlException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.ErrorCode}{Environment.NewLine}{Ex.Server}{Environment.NewLine}{Ex.Source}-{Ex.Procedure}-{Ex.LineNumber}{Environment.NewLine}{Ex.Message}")
                    Finally
                        splash_Close()
                    End Try
                End Using
            End Using
        End Sub

        Public Function BindData(ByVal sConnection As String, ByVal gc As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal sQuery As String, ByVal sTable As String) As Boolean
            Dim iRow As Integer
            Try
                splash_Show($"loading {sTable}")
                gridView.LoadingPanelVisible = True

                If gridView.SelectedRowsCount > 0 Then
                    iRow = gridView.FocusedRowHandle
                Else
                    iRow = 0
                End If

                Using ds As DataSet = New DataSet()
                    gc.DataSource = BindSource(sConnection, ds, sQuery, sTable)
                End Using

                Return True
            Catch Ex As ArgumentException
                Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.ParamName}{Environment.NewLine}{Ex.Message}")
                Return False
            Finally
                If gridView.DataRowCount < 2000 Then gridView.BestFitColumns()

                gridView.LoadingPanelVisible = False
                gridView.SelectRow(iRow)
                gridView.MakeRowVisible(iRow)

                splash_Close()
            End Try
        End Function

        Public Function GetData(ByVal sQuery As String, ByVal sField As String) As String
            Using MySQLConnection = New SqlConnection(connectSP)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        splash_Show($"getting {sField}")
                        MySQLConnection.Open()
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            MyDataReader.Read()
                            If MyDataReader.HasRows Then
                                Return MyDataReader(sField).ToString
                            End If
                        End Using
                    Catch Ex As IndexOutOfRangeException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.HResult}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                    Catch Ex As SqlException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.HResult}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                    Finally
                        splash_Close()
                    End Try
                End Using
            End Using
            Return Nothing
        End Function

        Public Function GetAmount(ByVal sQuery As String, ByVal sField As String) As Decimal
            Dim dAmount As Decimal = 0
            Using MySQLConnection = New SqlConnection(connectSP)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        splash_Show($"getting {sField}")
                        MySQLConnection.Open()
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            MyDataReader.Read()
                            If MyDataReader.HasRows Then
                                Try
                                    dAmount = CDec(MyDataReader(sField))
                                Catch ex As InvalidCastException
                                    dAmount = 0
                                End Try
                            End If
                        End Using
                        Return dAmount
                    Catch Ex As IndexOutOfRangeException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.HResult}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                        Return 0
                    Catch Ex As InvalidOperationException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.HResult}{Environment.NewLine}{Ex.Message}")
                        Return 0
                    Catch Ex As SqlException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.ErrorCode}{Environment.NewLine}{Ex.Server}{Environment.NewLine}{Ex.Source}-{Ex.Procedure}-{Ex.LineNumber}{Environment.NewLine}{Ex.Message}")
                        Return 0
                    Finally
                        splash_Close()
                    End Try
                End Using
            End Using
            Return 0
        End Function

        Public Function IsDataExist(ByVal sQuery As String) As Boolean
            Using MySQLConnection = New SqlConnection(connectSP)
                Using MyCommand As SqlCommand = New SqlCommand(sQuery, MySQLConnection)
                    Try
                        MySQLConnection.Open()
                        Using MyDataReader As SqlDataReader = MyCommand.ExecuteReader()
                            Return MyDataReader.HasRows
                        End Using
                    Catch Ex As SqlException
                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.ErrorCode}{Environment.NewLine}{Ex.Server}{Environment.NewLine}{Ex.Source}-{Ex.Procedure}-{Ex.LineNumber}{Environment.NewLine}{Ex.Message}")
                        Return False
                    Finally

                    End Try
                End Using
            End Using
            Return False
        End Function

        Public Function DataUpdate(ByVal sUpdateQuery As String, Optional ByVal bForce As Boolean = False) As Boolean
            Using MySQLConnection = New SqlConnection(connectSP)
                Using MyCommand As SqlCommand = New SqlCommand(sUpdateQuery, MySQLConnection)
                    Try
                        splash_Show($"updating Data")
                        MySQLConnection.Open()
                        If Modules.bNotifications Or bForce Then
                            Modules.Set_Message(Modules.MsgMode.Info, $"[{sUpdateQuery}]{Environment.NewLine}{MyCommand.ExecuteNonQuery()} record(s) has been successfully executed.")
                        Else
                            MyCommand.ExecuteNonQuery()
                        End If
                        Return True
                    Catch Ex As InvalidOperationException

                        Modules.Set_Message(Modules.MsgMode.Errorr, $"{Ex.HResult}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                        Return False
                    Catch Ex As SqlException

                        Modules.Set_Message(Modules.MsgMode.Sql, $"{Ex.ErrorCode}{Environment.NewLine}{Ex.Server}{Environment.NewLine}{Ex.Source}-{Ex.Procedure}-{Ex.LineNumber}{Environment.NewLine}{Ex.Message}")
                        Return False
                    Finally
                        splash_Close()
                    End Try
                End Using
            End Using
            Return False
        End Function

        Public Function Journal_Entry_Save(ByVal sConnection As String, ByVal sProcedureType As String, ByVal iTableID As Integer) As Boolean
            Dim Parameters As SqlParameter() = {New SqlParameter("@Table_ID", iTableID),
                                                New SqlParameter("@Added_By", sUserName),
                                                New SqlParameter("@Modified_By", sUserName),
                                                New SqlParameter("@Action_Type", sProcedureType)}

            Return Modules.Procedure_Save(sConnection, $"{iTableID}", "acc_Journal_Batch_Entry", Parameters)
        End Function

        Public Function Journal_Verify(ByVal sConnection As String, ByVal iTableID As Integer, ByVal sAction As String) As Boolean
            Dim Parameters As SqlParameter() = {New SqlParameter("@Table_ID", iTableID),
                                                New SqlParameter("@Action_Type", sAction)}

            Return Modules.Procedure_Save(sConnection, $"{iTableID}", "acc_Verification_Procedures", Parameters)
        End Function

        'System Generated i.e. Unit transfers, Sales and Releases / Journal Entry Group
        Public Function Journal_Entries_Balanced(ByVal iTableID As Integer, ByVal sReference As String) As Boolean
            Dim dDebit As Decimal = Modules.GetAmount($"SELECT Journal_Reference, SUM(Journal_Debit) AS Journal_Debit FROM acc_Journal_Entries WHERE Table_ID Like '{iTableID}' AND Journal_Reference LIKE '{sReference}' GROUP BY Journal_Reference", "Journal_Debit")
            Dim dCredit As Decimal = Modules.GetAmount($"SELECT Journal_Reference, SUM(Journal_Credit) AS Journal_Credit FROM acc_Journal_Entries WHERE Table_ID Like '{iTableID}' AND Journal_Reference LIKE '{sReference}' GROUP BY Journal_Reference", "Journal_Credit")

            If Modules.IsDataExist($"SELECT Table_ID, Journal_Reference FROM acc_Journal_Entries WHERE Table_ID Like '{iTableID}' AND Journal_Reference LIKE '{sReference}'") Then
                If dDebit.Equals(dCredit) Then
                    Return Modules.DataUpdate($"UPDATE acc_Journal_Entries SET IsVerified = 1 WHERE Table_ID LIKE '{iTableID}' AND Journal_Reference LIKE '{sReference}'")
                End If
            Else
                Return False
            End If
            Return False
        End Function

        Public Function Journal_Entry_Change_Status(ByVal sConnection As String, ByVal iID As Integer, ByVal sSTatus As String, Optional ByVal sNotes As String = "") As Boolean
            Dim Parameters As SqlParameter() = {New SqlParameter("@ID", iID),
                                                New SqlParameter("@Journal_Status", sSTatus),
                                                New SqlParameter("@Modified_By", sUserName),
                                                New SqlParameter("@Notes", sNotes.Trim),
                                                New SqlParameter("@Action_Type", "STATUS")}
            Return Modules.Procedure_Save(sConnection, "Journal Entry Status", "acc_Journal_Procedures", Parameters)
        End Function

        Public Sub Journal_Update_Status(ByVal gridView As GridView, ByVal sPrevStatus As String, ByVal sNewStatus As String)
            With gridView
                If .SelectedRowsCount > 0 Then
                    If Not Modules.actionAsk("For Approval", $"send selected {sPrevStatus} Journal Entries for {sNewStatus}") Then Return
                    bLoopStop = False

                    Dim iRowHandle, iID As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    .ClearSelection()

                    splash_Show($"updating {sPrevStatus} to {sNewStatus}")
                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If Not Modules.GridView_Loop(gridView, iRowHandle, "Journal Status", "updated", bLoopStop) Then Return

                        Try
                            iID = CInt(.GetRowCellValue(iRowHandle, "ID"))
                        Catch ex As InvalidCastException
                            Modules.Set_Message(Modules.MsgMode.Errorr, $"{ex.Source}{Environment.NewLine}{ex.Message}{Environment.NewLine}{ex.StackTrace}", "ID Error", True)
                            Return
                        Finally

                        End Try

                        If .GetRowCellDisplayText(iRowHandle, "Journal_Status").Equals(sPrevStatus) AndAlso Modules.Journal_Entry_Change_Status(connectSP, iID, sNewStatus, .GetRowCellDisplayText(iRowHandle, "Notes")) Then
                            .SetRowCellValue(iRowHandle, "Journal_Status", sNewStatus)
                        End If
                    Next
                    If .DataRowCount <= 2000 Then .BestFitColumns()
                    Modules.Set_Message(Modules.MsgMode.Info, $"Selected Journal Entries were being forwarded to {sNewStatus}.", sNewStatus)
                    splash_Close()
                End If
            End With
        End Sub

        Public Function Verify_Update_TableID(ByVal sType As String, ByVal iTableID As Integer, ByVal iJournal As Integer) As Boolean
            If iTableID > 0 Then
                If sType.Contains("RECEIVING") Then
                    Return Modules.DataUpdate($"UPDATE item_Master SET IsJournal = {iJournal} WHERE id LIKE '{iTableID}'")
                ElseIf sType.Contains("RELEASE") Or sType.Contains("ACQUIRED") Or sType.Contains("ASSUME") Then
                    Return Modules.DataUpdate($"UPDATE CustAccount SET IsJournal = {iJournal} WHERE sequenceNo LIKE '{iTableID}'")
                ElseIf sType.Contains("PAYMENT") Then
                    Return Modules.DataUpdate($"UPDATE TransactionPayments SET IsJournal = {iJournal} WHERE ID LIKE '{iTableID}'")
                ElseIf sType.Contains("CASHIERING") Then
                    If sType.Contains("IBC") Then
                        Return Modules.DataUpdate($"UPDATE TransactionOtherCash SET IsJournal = {iJournal} WHERE ID LIKE '{iTableID}'")
                    ElseIf sType.Contains("CM") Then
                        Return Modules.DataUpdate($"UPDATE TransactionCM SET IsJournal = {iJournal} WHERE ID LIKE '{iTableID}'")
                    Else
                        Return Modules.DataUpdate($"UPDATE TransactionPayments SET IsJournal = {iJournal} WHERE ID LIKE '{iTableID}'")
                    End If
                End If
            End If
            Return False
        End Function

        Public Function Journal_Delete(ByVal gridView As GridView, Optional ByVal bLoopLive As Boolean = False) As Boolean
            Dim bDeleted As Boolean
            With gridView
                If .SelectedRowsCount > 0 Then
                    Dim sReason As String = Modules.Show_Input_Box("Input reason for delete", "Delete Journal Entry/Entries", String.Empty)

                    If Not Modules.actionAsk("Delete Journal Transaction(s)", "Delete Journal Transaction(s)", "You might delete some Journal transactions") Then Return False

                    Dim selectedRows As Integer() = .GetSelectedRows()
                    Dim iRowHandle As Integer

                    bLoopStop = False
                    .ClearSelection()

                    splash_Show($"deleting Data")
                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If Not Modules.GridView_Loop(gridView, iRowHandle, "Journal Delete", "deleted", bLoopStop, True, True) Then Return False

                        Dim Parameters As SqlParameter() = {New SqlParameter("@ID", .GetRowCellDisplayText(iRowHandle, "ID")),
                                                            New SqlParameter("@Modified_By", sUserName),
                                                            New SqlParameter("@Journal_Description", sReason),
                                                            New SqlParameter("@Action_Type", "DELETE")}

                        If Modules.Procedure_Execute("Delete Journal", "acc_Journal_Procedures", Parameters) > 0 Then
                            bDeleted = True
                            Try
                                Verify_Update_TableID(.GetRowCellDisplayText(iRowHandle, "Journal_Type"), CInt(.GetRowCellDisplayText(iRowHandle, "Table_ID")), 0)
                            Catch Ex As InvalidCastException
                                Modules.Set_Message(Modules.MsgMode.Errorr, $"{Ex.HResult}{Ex.Source}{Environment.NewLine}{Ex.Message}")
                                Continue For
                            End Try
                        End If
                    Next
                    .DeleteSelectedRows()
                    splash_Close()
                End If
            End With
            Return bDeleted
        End Function

    End Module
End Namespace