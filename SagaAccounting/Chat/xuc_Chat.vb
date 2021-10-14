Imports MyClassLibrary.Classes
Imports System
Imports System.Net.Sockets
Imports System.Windows.Forms

Namespace Chat

    Public Class xuc_Chat
        Dim clientSocket As New TcpClient()
        Dim serverStream As NetworkStream
        Dim readData As String
        Dim infiniteCounter As Integer

        Private Sub xuc_Chat_Connect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Server.Text = class_Tools.RegKeyGet(Me.Name, Server.Name, "127.0.0.1")
            Port.Text = class_Tools.RegKeyGet(Me.Name, Port.Name, "2300")
        End Sub

        Private Sub msg()
            If Me.InvokeRequired Then
                Me.Invoke(New MethodInvoker(AddressOf msg))
            Else
                Chat.Text = Chat.Text + Environment.NewLine + " >> " + readData
            End If
        End Sub

        Private Sub btn_Connect_Click(sender As Object, e As EventArgs) Handles btn_Connect.Click
            'readData = "Conected to Chat Server ..."

            'Try
            '    clientSocket.Connect(Server.Text.Trim, Convert.ToInt32(Port.Text.Trim))
            '    btn_Connect.Text = "Connected"
            '    serverStream = clientSocket.GetStream()
            'Catch Ex As SocketException
            '    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, class_procedures.xform, $"{ex.Source}{Environment.NewLine}{ex.Message}")
            'End Try

            'Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(class_Variables.sUserName + "$")

            'Try
            '    serverStream.Write(outStream, 0, outStream.Length)
            '    serverStream.Flush()

            '    Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
            '    ctThread.Start()
            'Catch ex As Exception
            '    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, class_procedures.xform, $"{Ex.Source}{Environment.NewLine}{Ex.Message}")
            'Catch Ex As IOException
            '    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, class_procedures.xform, $"{ex.Source}{Environment.NewLine}{ex.Message}")
            'End Try
        End Sub

        Private Sub getMessage()
            For infiniteCounter = 1 To 2
                infiniteCounter = 1

                Try
                    serverStream = clientSocket.GetStream()
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try

                Dim buffSize As Integer
                Dim inStream(10024) As Byte
                buffSize = clientSocket.ReceiveBufferSize
                Try
                    serverStream.Read(inStream, 0, buffSize)
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
                Dim returndata As String = System.Text.Encoding.ASCII.GetString(inStream)
                readData = String.Empty + returndata
                msg()
            Next
        End Sub

        Private Sub btn_Send_Click(sender As Object, e As EventArgs) Handles btn_Send.Click
            'Dim outStream As Byte() = System.Text.Encoding.ASCII.GetBytes(Message.Text.Trim + "$")
            'serverStream.Write(outStream, 0, outStream.Length)
            'serverStream.Flush()
        End Sub

    End Class

End Namespace