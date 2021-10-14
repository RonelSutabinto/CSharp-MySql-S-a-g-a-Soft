Imports System.Data.SqlClient
Imports System.Net.Sockets

Namespace myModules
    Public Module CentralModule
        Public sqlConn As New SqlConnection

        Public SqlComm As New SqlCommand
        Public isDBRecord As SqlDataReader
        Public DBAdapter As SqlDataAdapter
        Public ServerName, DatabaseName, UserName, UserPassword As String

        Public clientB As TcpClient

        Public connectPayroll As String = "Data Source=(local);Initial Catalog=Payroll;Persist Security Info=True;User ID=sa;Password=sagamotorscorp@admin"
        Public PayrollConnection As New SqlConnection(connectPayroll)

        Public connectSP As String
        Public SPConnect As New SqlConnection

        Public connectSpareParts As String
        Public SPConnectSpareParts As New SqlConnection(connectSpareParts)

        Public connectSP2 As String
        Public SPConnect2 As New SqlConnection(connectSP2)

        Public connectICSmj As String
        Public ICSConnectionMJ As New SqlConnection(connectICSmj)

        Public connectMIS As String
        Public MISConnection As New SqlConnection(connectMIS)
    End Module

End Namespace