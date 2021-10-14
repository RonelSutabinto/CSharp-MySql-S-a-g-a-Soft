Imports System.IO
Imports System.Net.Sockets

Public Class Admin_BroadcastMsg

    Dim clientB As TcpClient
    Dim sWriter As StreamWriter

    Private Sub Admin_BroadcastMsg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMenu.ConnectServerChat()
    End Sub

    Private Sub send(ByVal str As String)
        Try
            sWriter = New StreamWriter(clientB.GetStream)
            sWriter.WriteLine(str)
            sWriter.Flush()
        Catch Ex As Exception
            xUpdate("You're not connected to server")
        End Try
    End Sub

    Delegate Sub _xUpdate(ByVal str As String)

    Sub xUpdate(ByVal str As String)

        If InvokeRequired Then
            Invoke(New _xUpdate(AddressOf xUpdate), str)
        Else
            'GroupMsg.AppendText(str & vbNewLine)
            MyMessagebox.ActiveForm.Visible = False
            MyMessagebox.lbl_message.Text = str
            MyMessagebox.ShowDialog()
        End If



    End Sub

    Sub read(ByVal ar As IAsyncResult)
        Try
            xUpdate(New StreamReader(clientB.GetStream).ReadLine)
            clientB.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)
        Catch Ex As Exception
            xUpdate("You are disconnected from server")
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_broadcast_Click(sender As Object, e As EventArgs) Handles cmd_broadcast.Click
        MainMenu.sendB($"{MainMenu.App_User_Name.Caption} : {txt_BroadCast.Text}")
        txt_BroadCast.Clear()
        Me.Close()
    End Sub

    Private Sub txt_ConStatus_Click(sender As Object, e As EventArgs) Handles txt_ConStatus.Click

    End Sub

    Private Sub cmd_connectBroadCast_Click(sender As Object, e As EventArgs) Handles cmd_connectBroadCast.Click

    End Sub

    Private Sub txt_BroadCast_TextChanged(sender As Object, e As EventArgs) Handles txt_BroadCast.TextChanged

    End Sub

    'Private Sub cmd_connectBroadCast_Click(sender As Object, e As EventArgs) Handles cmd_connectBroadCast.Click
    '        '
    '        If cmd_connectBroadCast.Text = "Connect" Then
    '            Try
    '                'client = New TcpClient(Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", "")), CInt("3818"))
    '                clientB = New TcpClient("124.107.148.186", CInt("3819"))
    '                clientB.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)
    '                cmd_connectBroadCast.Text = "Disconnect"
    '                txt_ConStatus.Text = "ONLINE"
    '                txt_ConStatus.BackColor = Color.Green

    '                ' send(txt_FLName.Text & " is now online")
    '            Catch Ex As Exception
    '                txt_ConStatus.Text = "OFFLINE"
    '                txt_ConStatus.BackColor = Color.Red
    '            End Try
    '        Else
    '            clientB.Client.Close()
    '            clientB = Nothing
    '            cmd_connectBroadCast.Text = "Connect"
    '            txt_ConStatus.Text = "OFFLINE"
    '            txt_ConStatus.BackColor = Color.Red
    '        End If
    '
    '    End Sub
End Class