Imports DevExpress.DataAccess.Excel
Imports DevExpress.SpreadsheetSource
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Windows.Forms

Namespace Controls.Accounting

    Public Class xuc_Balance_Import
        Dim bLoopStop As Boolean
        Friend eDateType As eLoad_Type

        Sub New()
            InitializeComponent()
        End Sub

        Private Function GetExcelDataSource(ByVal sFileName As String) As ExcelDataSource
            Try
                Dim ds As New ExcelDataSource With {.FileName = sFileName}
                Dim excelSourceOptions As New ExcelSourceOptions()
                Dim excelWorksheetSettings As New ExcelWorksheetSettings With {
                    .WorksheetName = GetWorkSheetNameByIndex(sFileName, XtraInputBox.Show("Input sheet number", "Import Beginning Balances", 0))
                }
                excelSourceOptions.ImportSettings = excelWorksheetSettings

                Dim fieldCode As FieldInfo = New FieldInfo With {
                    .Name = "Code",
                    .Type = GetType(String)
                }
                Dim fieldDebit As FieldInfo = New FieldInfo With {
                    .Name = "Debit",
                    .Type = GetType(Decimal)
                }
                Dim fieldCredit As FieldInfo = New FieldInfo With {
                    .Name = "Credit",
                    .Type = GetType(Decimal)
                }
                Dim fieldAccount As FieldInfo = New FieldInfo With {
                    .Name = "Account",
                    .Type = GetType(String)
                }
                ds.Schema.AddRange(New FieldInfo() {fieldCode, fieldDebit, fieldCredit, fieldAccount})
                ds.SourceOptions = excelSourceOptions
                ds.Fill()
                Return ds
            Catch ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
            Return Nothing
        End Function

        Private Function GetWorkSheetNameByIndex(ByVal sFileName As String, ByVal p As Integer) As String
            Try
                Using spreadsheetSource As ISpreadsheetSource = SpreadsheetSourceFactory.CreateSource(sFileName)
                    Dim worksheetCollection As IWorksheetCollection = spreadsheetSource.Worksheets
                    Return worksheetCollection(p).Name
                End Using
            Catch ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
            Return Nothing
        End Function

        Private Sub btn_Import_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Import.ItemClick
            Dim openFileDialog As New XtraOpenFileDialog With {
                .RestoreDirectory = True,
                .Filter = "Trial Balance (xlsx)|*.xlsx|Trial Balance (xls)|*.xls"
                }
            If openFileDialog.ShowDialog().Equals(DialogResult.OK) Then
                Try
                    gridControl.DataSource = GetExcelDataSource(openFileDialog.FileName)
                Catch Ex As IO.FileNotFoundException
                    class_Procedures.Show_Error(Ex)
                Finally
                    gridView.BestFitColumns()
                End Try
            End If
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If e.Button.Equals(MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)
            End If
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            With gridView
                If .SelectedRowsCount > 0 Then
                    If Not class_Procedures.actionAsk("Import Beginning Balances", "Save/Update Imported Beginning Balances", "This might overwrite the existing beginning balances") Then Return
                    class_Database.DBError = False

                    Dim file As IO.StreamWriter

                    file = My.Computer.FileSystem.OpenTextFileWriter($"{Me.Name}.txt", False)

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Account Summaries", "updated", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sCOACode As String = .GetRowCellDisplayText(iRowHandle, colCode)
                        Dim sCOAName As String = .GetRowCellDisplayText(iRowHandle, colAccount)
                        Dim dBeginningBalanceDebit As Decimal = Math.Round(Convert.ToDecimal(.GetRowCellValue(iRowHandle, colDebit)), 2)
                        Dim dBeginningBalanceCredit As Decimal = Math.Round(Convert.ToDecimal(.GetRowCellValue(iRowHandle, colCredit)), 2)

                        If Not sCOACode.Equals(String.Empty) Then
                            If Not dBeginningBalanceDebit.Equals(0) Or Not dBeginningBalanceCredit.Equals(0) Then
                                If class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT COA_Code, COA_Name from acc_Chart_Of_Accounts WHERE COA_Code LIKE '{sCOACode}' AND COA_Name LIKE '{sCOAName}'") Then
                                    If class_Saga_Database.Balance_Save("IMPORT_BEGINNING", "DETAIL", eDateType, class_Saga_Variables.sBranchCode, sCOACode, class_Saga_Variables.dtStart, False, dBeginningBalanceDebit, dBeginningBalanceCredit) Then
                                        'file.WriteLine($"{DateTime.Now} Code:{sCOACode} Name:{sCOAName} Debit:{dBeginningBalanceDebit} Credit:{dBeginningBalanceCredit} - Beginning Balance migrated from excel file (Existing)")
                                    End If
                                Else
                                    file.WriteLine($"{DateTime.Now} Code:{sCOACode} Name:{sCOAName} Debit:{dBeginningBalanceDebit} Credit:{dBeginningBalanceCredit} - Account not found!")
                                End If
                            End If
                        Else
                            file.WriteLine($"{DateTime.Now} - Name:{sCOAName} Debit:{dBeginningBalanceDebit} Credit:{dBeginningBalanceCredit} - Skipped!")
                        End If
                    Next
                    file.Close()

                    .BestFitColumns()
                    If class_Database.DBError Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, "Trial Balances has been unsuccessfully Summarized due to Database connection error or the user stopped the process.")
                    Else
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "Trial Balances has been successfully updated.")
                    End If
                    class_Procedures.splash_Close()
                End If
            End With
        End Sub

        Private Sub btn_Stop_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
        End Sub

    End Class

End Namespace