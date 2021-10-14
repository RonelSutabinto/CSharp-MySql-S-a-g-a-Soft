Imports System.Data.SqlClient

Public Class DatabaseBackup
    Dim con, con1 As SqlConnection

    Private Sub DatabaseBackup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        server(".")
    End Sub

    Sub server(ByVal str As String)
        cmbserver.Items.Clear()
        con = New SqlConnection("Data Source=" & str & ";Database=Master;integrated security=SSPI;")
        con.Open()
        Dim select_cmd = New SqlCommand("select *  from sysservers  where srvproduct='SQL Server'", con)
        Dim rs = select_cmd.ExecuteReader
        While rs.Read
            cmbserver.Items.Add(rs(2))
        End While
        rs.Close()
    End Sub

    Sub connection()
        cmbdatabase.Items.Clear()
        con = New SqlConnection("Data Source=" & Trim(cmbserver.Text) & ";Database=Master;integrated security=SSPI;")
        con.Open()
        cmbdatabase.Items.Clear()
        Dim select_cmd = New SqlCommand("select * from sysdatabases", con)
        Dim rs = select_cmd.ExecuteReader
        While rs.Read
            cmbdatabase.Items.Add(rs(0))
        End While
        rs.Close()
    End Sub

    Private Sub cmbserver_TextChanged(sender As Object, e As System.EventArgs) Handles cmbserver.TextChanged
        connection()
    End Sub

    Sub blank(ByVal str As String)
        If cmbserver.Text = String.Empty Or cmbdatabase.Text = String.Empty Then
            MsgBox("Server Name & Database Blank Field")
            Exit Sub
        Else
            If str = "backup" Then
                SaveFileDialog1.FileName = cmbdatabase.Text & Now.ToString("MM") & Now.ToString("dd") & Now.ToString("yyyy") & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
                SaveFileDialog1.ShowDialog()
                If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                    Timer1.Enabled = True
                    ProgressBar1.Visible = True
                    Dim s As String
                    s = SaveFileDialog1.FileName
                    query("backup database " & cmbdatabase.Text & " to disk='" & s & "'")
                Else
                    MsgBox("CANCEL")
                End If

            ElseIf str = "restore" Then
                OpenFileDialog1.ShowDialog()
                Timer1.Enabled = True
                ProgressBar1.Visible = True
                query("RESTORE DATABASE " & cmbdatabase.Text & " FROM disk='" & OpenFileDialog1.FileName & "'")
            End If
        End If
    End Sub

    Sub query(ByVal que As String)
        On Error Resume Next
        Dim select_cmd = New SqlCommand(que, con)
        select_cmd.ExecuteNonQuery()
    End Sub

    Private Sub cmbbackup_Click(sender As System.Object, e As System.EventArgs) Handles cmbbackup.Click
        blank("backup")
    End Sub

    Private Sub cmdrestore_Click(sender As System.Object, e As System.EventArgs) Handles cmdrestore.Click
        blank("restore")
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            MsgBox("Command Successful Done")
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
    End Sub

End Class