'
'  Name:
'
'    ExcelExportListView
'
'  Description:
'
'    Sample code to show how to open and manipulate an Excel spreadsheet from within a
'    VB application.
'
'  Notes:
'
'    It is very important to not reference objects directly through other objects. This
'    is often referred to as the double-dot restriction. For example, when you create
'    a local variable to refer to the active worksheet, first create a local variable
'    to refer to the active workbook, then generate the worksheet reference through
'    that variable. That is do
'
'       Dim book As Excel.Workbook = xls.ActiveWorkbook
'       Dim sheet As Excel.Worksheet = book.ActiveSheet
'
'    rather than
'
'       Dim sheet As ExcelWorksheet = xls.ActiveWorkbook.ActiveSheet
'
'    If you do the latter then you will end up with one orphan Excel.exe task for each
'    time you run the application.
'
'  Audit:
'
'    2013-06-20  rj  original code
'
Public Class Form1

    Private Sub btnPopulate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopulate.Click
        'Add a few test items to the listview
        'lvwToExport.Items.Add(New ListViewItem({"one", "two", "three"}))
        'lvwToExport.Items.Add(New ListViewItem({"four", "five", "six"}))
        'lvwToExport.Items.Add(New ListViewItem({"seven", "eight", "nine"}))
        'lvwToExport.Items.Add(New ListViewItem({"ten", "eleven", "twelve"}))
        'lvwToExport.Items.Add(New ListViewItem({"thirteen", "fourteen", "fifteen"}))
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        ''Export the listview to an Excel spreadsheet
        'Dim SaveFileDialog1 As New SaveFileDialog
        'SaveFileDialog1.Title = "Save Excel File"
        ''SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls|Excel Files (*.xlsx)|*.xslx"
        'SaveFileDialog1.Filter = "ics files (*.ics)|*.ics"
        'SaveFileDialog1.ShowDialog()
        ''exit if no file selected
        'If SaveFileDialog1.FileName = "" Then
        '    Exit Sub
        'End If
        ''create objects to interface to Excel
        'Dim xls As New Excel.Application
        'Dim book As Excel.Workbook
        'Dim sheet As Excel.Worksheet

        ''Dim book As Excel.Workbook = xls.ActiveWorkbook
        ''Dim sheet As Excel.Worksheet = book.ActiveSheet

        ''create a workbook and get reference to first worksheet
        'xls.Workbooks.Add()
        'book = xls.ActiveWorkbook
        'sheet = book.ActiveSheet
        ''step through rows and columns and copy data to worksheet
        'Dim row As Integer = 1
        'Dim col As Integer = 1
        'For Each item As ListViewItem In lvwToExport.Items
        '    For i As Integer = 0 To item.SubItems.Count - 1
        '        sheet.Cells(row, col) = item.SubItems(i).Text
        '        col = col + 1
        '    Next
        '    row += 1
        '    col = 1
        'Next
        ''save the workbook and clean up
        'book.SaveAs(SaveFileDialog1.FileName)
        'xls.Workbooks.Close()
        'xls.Quit()
        'releaseObject(sheet)
        'releaseObject(book)
        'releaseObject(xls)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        'Release an automation object
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch Ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class