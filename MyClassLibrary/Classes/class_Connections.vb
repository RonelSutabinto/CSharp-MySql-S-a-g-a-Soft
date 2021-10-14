Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets

Namespace Classes
    Public Module class_Connections
        Public bServerOnline As Boolean

        Public Function is_Network_Adapter_OK() As Boolean
            If NetworkInterface.GetIsNetworkAvailable() Then
                Return True
            Else
                If class_Database.bIsLocal Then
                    Return True
                Else
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"You are not connected to the network or internet due to following reasons:{Environment.NewLine}Wireless/Local network adapter(s) is/are:{Environment.NewLine} - disabled,{Environment.NewLine} - not available,{Environment.NewLine} - not connected.{Environment.NewLine}Please fix the following:{Environment.NewLine} - enable/restart your wifi adapter,{Environment.NewLine} - reinsert/reconnect local Ethernet cable(s),{Environment.NewLine} - wireless/network Ethernet adapter driver(s),{Environment.NewLine} - check and verify database server parameters.")
                    Return False
                End If
            End If
        End Function

        Public Function Get_IP_Internet() As String
            If is_Network_Adapter_OK() Then
                Dim IP As New WebClient
                Try
                    Return IP.DownloadString("http://bot.whatismyipaddress.com")
                Catch Ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
            Return Nothing
        End Function

        Public Function Initialize_IP(ByVal sIP As String) As Boolean
            class_Procedures.splash_Show("Initializing IP addresses.")
            If Not is_Network_Adapter_OK() Then Return False

            If check_Internet(sIP) Then
                Try
                    class_Variables.sLocal_IP = $"{New WebClient().DownloadString("https://api.ipify.org")}"
                    Return True
                Catch Ex As Exception
                    class_Variables.sLocal_IP = class_Connections.Get_IP_Local
                    Return class_Procedures.Show_Error(Ex)
                Finally
                    class_Procedures.splash_Close()
                End Try
            Else
                class_Variables.sLocal_IP = class_Connections.Get_IP_Local

                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"You are not connected to the internet. {Environment.NewLine}Please check your internet connection and verify database server parameters.")
                class_Procedures.splash_Close()
                Return False
            End If
        End Function

        Public Function Get_IP_Local() As String
            If Not is_Network_Adapter_OK() Then Return Nothing
            Dim sIP As String = String.Empty
            Dim host = Dns.GetHostEntry(Dns.GetHostName())
            For Each iP In host.AddressList
                If iP.AddressFamily = AddressFamily.InterNetwork Then
                    sIP = $"{sIP} {iP}"
                End If
            Next
            Return sIP.Trim
        End Function

        Public Function check_Internet(ByVal sWebSite As String) As Boolean
            If Not is_Network_Adapter_OK() Then Return False
            Dim pingable As Boolean = False
            Dim pinger As Ping = Nothing
            Try
                pinger = New Ping()
                Dim reply As PingReply = pinger.Send(sWebSite)
                pingable = reply.Status = IPStatus.Success
                Return True
            Catch Ex As PingException
                class_Procedures.Show_Error(Ex)
                Return False
            Finally
                If pinger IsNot Nothing Then pinger.Dispose()
            End Try
        End Function

        Public Function check_Host(ByVal sHost As String) As Boolean
            If Not is_Network_Adapter_OK() Then Return False
            Dim pingable As Boolean = False
            Dim pinger As Ping = Nothing
            Try
                class_Procedures.splash_Show($"Pinging {sHost}")
                pinger = New Ping()
                Dim reply As PingReply = pinger.Send(sHost)
                pingable = reply.Status = IPStatus.Success
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"The host {sHost}{Environment.NewLine}is reachable or online")
            Catch Ex As PingException
                class_Procedures.Show_Error(Ex)
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"The host is offline or you are not connected to internet. {Environment.NewLine}Please check the server host IP address or your internet connection.")
                pingable = False
            Finally
                If pinger IsNot Nothing Then
                    pinger.Dispose()
                End If
                class_Procedures.splash_Close()
            End Try
            Return pingable
        End Function

        Public Sub ping_Host(ByVal sHost As String, Optional ByVal bContinous As Boolean = False)
            If Not is_Network_Adapter_OK() Then Return
            Dim proc As System.Diagnostics.ProcessStartInfo = New System.Diagnostics.ProcessStartInfo With {
            .FileName = "C:\windows\system32\cmd.exe"
        }

            If bContinous Then
                proc.Arguments = $"/c ping -t {sHost}"
            Else
                proc.Arguments = $"/c ping {sHost}"
            End If

            System.Diagnostics.Process.Start(proc)
        End Sub

        Public Function get_IP_GEO(ByVal IP As String) As String
            If Not is_Network_Adapter_OK() Then Return Nothing
            If IP Is String.Empty Then Return Nothing

            Try
                Dim url = $"http://api.ipstack.com/{IP}?access_key=8eb90a8f1db251c6642ab4cecabf8d13"
                Dim request = WebRequest.Create(url)

                Using wrs As WebResponse = request.GetResponse()
                    Dim stream As Stream = wrs.GetResponseStream()
                    Using reader As StreamReader = New StreamReader(stream)
                        Dim json As String = reader.ReadToEnd()
                        Dim obj = JObject.Parse(json)
                        Dim sContinent = CStr(obj("continent_name"))
                        Dim sCountry = CStr(obj("country_name"))
                        Dim sRegion = CStr(obj("region_name"))
                        Dim sCity = CStr(obj("city"))
                        Dim sZIP = CStr(obj("zip"))
                        Dim sLatitude = CStr(obj("latitude"))
                        Dim sLongitude = CStr(obj("longitude"))
                        class_Procedures.splash_Close()
                        Return ($"Continent:{sContinent} Country:{sCountry} Region:{sRegion} City:{sCity} ZIP:{sZIP} Latitude:{sLatitude} Longitude:{sLongitude}")
                    End Using
                End Using
            Catch Ex As WebException
                class_Procedures.Show_Error(Ex)
                Return Nothing
            End Try
        End Function

        Public Function Upload_Update_File(ByVal sAppName As String, ByVal sAppExtension As String) As Boolean
            class_Procedures.splash_Show(frm, $"uploading {sAppName}.{sAppExtension} to FTP", "Uploading Update File", True)

            Dim miUri As String = $"ftp://{class_Database.SqlServer}/{sAppName}/{sAppName}.{sAppExtension}"
            Dim miRequest As FtpWebRequest = CType(WebRequest.Create(miUri), FtpWebRequest)
            miRequest.Credentials = New Net.NetworkCredential(class_Database.SqlUser, class_Database.SqlUser)
            miRequest.Method = Net.WebRequestMethods.Ftp.UploadFile
            Try
                Dim bFile() As Byte = System.IO.File.ReadAllBytes($"C:\inetpub\{sAppName}.{sAppExtension}")
                Dim miStream As System.IO.Stream = miRequest.GetRequestStream()
                miStream.Write(bFile, 0, bFile.Length)
                miStream.Close()
                miStream.Dispose()
                Return True
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
                Return False
            Finally
                class_Procedures.splash_Close(True)
            End Try
            Return False
        End Function

    End Module
End Namespace