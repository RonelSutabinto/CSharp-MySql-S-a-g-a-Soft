Imports DevExpress.DataAccess.Excel
Imports DevExpress.SpreadsheetSource
Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Windows.Forms

Namespace SagaSpareParts

    Public Class xuc_SPA_Import
        Dim bLoopStop As Boolean
        Friend sBalanceType As String

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

                Dim fieldSummary As FieldInfo = New FieldInfo With {
                    .Name = "PartsNumber",
                    .Type = GetType(String)
                }
                Dim fieldPartName As FieldInfo = New FieldInfo With {
                    .Name = "PartsName",
                    .Type = GetType(String)
                }
                Dim fieldSRP As FieldInfo = New FieldInfo With {
                    .Name = "SRP",
                    .Type = GetType(Double)
                }
                Dim fieldAccount As FieldInfo = New FieldInfo With {
                    .Name = "Account",
                    .Type = GetType(String)
                }
                ds.Schema.AddRange(New FieldInfo() {fieldSummary, fieldPartName, fieldSRP, fieldAccount})
                ds.SourceOptions = excelSourceOptions
                ds.Fill()
                Return ds
            Catch Ex As System.IO.IOException
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
            Catch Ex As System.IO.IOException
                class_Procedures.Show_Error(Ex)
            Catch Ex As ArgumentOutOfRangeException
                class_Procedures.Show_Error(Ex)
            End Try
            Return Nothing
        End Function

        Private Sub btn_Import_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Import.ItemClick
            Dim openFileDialog As New OpenFileDialog With {
        .RestoreDirectory = True,
        .Filter = "SKU Imports (xlsx)|*.xlsx|Trial Balance (xls)|*.xls"
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

                    If Not class_Procedures.actionAsk("Import Spare Parts", "Save/Update Imported Beginning Balances", "This might overwrite the existing beginning balances") Then Return

                    class_Procedures.splash_Show("Saving imported Spare Parts")

                    Dim file As IO.StreamWriter

                    file = My.Computer.FileSystem.OpenTextFileWriter($"{Me.Name}.txt", False)

                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "SKU Summaries", "updated", bLoopStop) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sCOAName As String = .GetRowCellDisplayText(iRowHandle, colAccount)
                        Dim sPartNumber As String = .GetRowCellDisplayText(iRowHandle, colPart_Number)
                        Dim sPartsName As String = .GetRowCellDisplayText(iRowHandle, colPart_Name)
                        'sSummaryName = .GetRowCellDisplayText(iRowHandle, colSummary)

                        If Not CDec(.GetRowCellValue(iRowHandle, colSRP)).Equals(0) Then
                            ' sPartNumber = CStr(class_Database.Get_Data(ICSConnection, $"SELECT PartsNumber FROM Spare_Parts_Master WHERE PartsNumber LIKE '{ .GetRowCellDisplayText(iRowHandle, colPart_Number)}'", "PartsNumber"))
                            'sPartNumber = class_Database.GetData(class_Database.ICSConnection, $"SELECT COA_Code, COA_Summary, COA_Name FROM acc_Chart_Of_Accounts WHERE COA_Summary LIKE '{sPartNumber}' AND COA_Name LIKE '{ .GetRowCellDisplayText(iRowHandle, colAccount)}'", "COA_Code")
                            If Not sPartNumber.Equals(String.Empty) Then
                                Dim dSRP As Decimal = Math.Round(CDec(.GetRowCellValue(iRowHandle, colSRP)), 2)

                                If class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT PartsNumber FROM Spare_Parts_Master WHERE PartsNumber LIKE '{sPartNumber}'") Then
                                    file.WriteLine($"{DateTime.Now} {sPartNumber} - {sCOAName} - SKU migrated from excel file (Existing)")
                                Else
                                    'class_Saga_Database.SKU_Save(sPartNumber, sPartsName, "", "", "", "", dSRP, 0, 0, 0, "Beginning Balance migrated from excel file (New)")
                                    file.WriteLine($"{DateTime.Now} {sPartNumber} - {sCOAName} - Spare Parts migrated from excel file (New)")
                                End If
                            Else
                                file.WriteLine($"{DateTime.Now} {sPartNumber} - {sCOAName} - SKU not found!")
                            End If
                        Else
                            file.WriteLine($"{DateTime.Now} - {sCOAName} - Skipped!")
                        End If
                    Next
                    file.Close()

                    .BestFitColumns()
                    If class_Database.DBError Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, "Spare Parts has been unsuccessfully Summarized due to Database connection error or the user stopped the process.")
                    Else
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "Spare Parts has been successfully updated.")
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