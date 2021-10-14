'Imports System.IO
'Imports Microsoft.Office.Interop.Excel

Public Class TestForm

    Private Structure ExcelRows
        Dim C1Code As String
        Dim C2Model As String
        Dim C3Description As String
        Dim C4Color As String
        Dim C5Brand As String
    End Structure

    Private ExcelRowList As List(Of ExcelRows) = New List(Of ExcelRows)

    Private Sub cmd_import_Click(sender As System.Object, e As System.EventArgs) Handles cmd_import.Click
        'Dim myStream As Stream = Nothing
        'Dim openFileDialog1 As New OpenFileDialog()

        ''openFileDialog1.InitialDirectory = "c:\"
        'openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        'openFileDialog1.FilterIndex = 2
        'openFileDialog1.RestoreDirectory = True

        'If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Try
        '        myStream = openFileDialog1.OpenFile()
        '        If (myStream IsNot Nothing) Then
        '            ' Insert code to read the stream here.
        '            'MsgBox(openFileDialog1.FileName)
        '        End If
        '    Catch Ex As Exception
        '        MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
        '    Finally
        '        ' Check this again, since we need to make sure we didn't throw an exception on open.
        '        If (myStream IsNot Nothing) Then
        '            myStream.Close()
        '        End If
        '    End Try
        'End If
        'MsgBox(openFileDialog1.FileName)

        'Dim con As New OleDbConnection
        'Dim Exfilepath As String = openFileDialog1.FileName
        'Dim dt As New DataTable
        'Dim dt2 As New DataTable
        'Dim ds As New DataSet
        'con.ConnectionString = ("provider=Microsoft.Jet.OLEDB.4.0; Data Source='" & Exfilepath & "';Extended Properties=Excel 8.0; ") 'provider for excel 2003
        'con.Open()
        'dt.Clear()
        'ds.Tables.Add(dt)
        'Dim da As New OleDbDataAdapter("Select * from [Sheet1$]", con)
        'da.Fill(dt)
        'Dim dc As DataColumn
        ''this will input excel column name to listview column name
        'For Each dc In ds.Tables(0).Columns
        '    Dim ch As New ColumnHeader
        '    ch.Text = dc.ColumnName
        '    ch.Width = 110 'set the columns width
        '    LViewItems.Columns.Add(ch)
        'Next
        ''this will populate all data in listview
        'For Each myRow In dt.Rows
        '    LViewItems.Items.Add(myRow.item(0))
        '    LViewItems.Items(LViewItems.Items.Count - 1).SubItems.Add(myRow.Item(1))
        'Next
        'con.Close()

        LViewItems.Items.Clear()
        Me.OpenFileDialog1.FileName = Nothing
        'OpenFileDialog1.Filter =  "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        OpenFileDialog1.Filter = "txt files (*.ics)|*.ics"
        If Me.OpenFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Me.TextBox1.Text = Me.OpenFileDialog1.FileName
        End If

        If Me.TextBox1.Text = String.Empty Then
            GoTo out
        End If
        If GetInfo() = True Then
            For Each Xitem In ExcelRowList
                Dim lvitem As ListViewItem
                lvitem = Me.LViewItems.Items.Add(Xitem.C1Code)
                lvitem.SubItems.AddRange(New String() {Xitem.C2Model, Xitem.C3Description, Xitem.C4Color, Xitem.C5Brand})

            Next
        End If
out:
    End Sub

    Private Function GetInfo() As Boolean
        Dim Completed As Boolean = False
        'open excel workbook
        Dim MyExcel As New Excel.Application
        'Dim myex As New Excel.
        MyExcel.Workbooks.Open(Me.TextBox1.Text)

        'extract
        MyExcel.Sheets("Sheet1").activate()
        MyExcel.Range("A1").Activate()

        Dim ThisRow As New ExcelRows
        Do
            If MyExcel.ActiveCell.Value > Nothing Or MyExcel.ActiveCell.Text > Nothing Then
                ThisRow.C1Code = MyExcel.ActiveCell.Value
                MyExcel.ActiveCell.Offset(0, 1).Activate()

                ThisRow.C2Model = MyExcel.ActiveCell.Value
                MyExcel.ActiveCell.Offset(0, 1).Activate()

                ThisRow.C3Description = MyExcel.ActiveCell.Value
                MyExcel.ActiveCell.Offset(0, 1).Activate()

                ThisRow.C4Color = MyExcel.ActiveCell.Value
                MyExcel.ActiveCell.Offset(0, 1).Activate()

                ThisRow.C5Brand = MyExcel.ActiveCell.Value

                ExcelRowList.Add(ThisRow)

                MyExcel.ActiveCell.Offset(1, -4).Activate()
            Else
                Completed = True
                Exit Do
            End If
        Loop

        'close excel workbook
        Return Completed
    End Function

    Private Sub TestForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

End Class