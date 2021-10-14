Imports System.Data.SqlClient
Imports DevExpress.XtraEditors

Namespace myModules
    Public Module Module_Variables
        Public mFileVersion As String
        Public mBuildNo As String
        Public mAppName As String
        Public mUpdateUrl As String
        Public mBrCode As String
        Public mTargetForm As String
        Public mVendorCode As String

        Public hHostServer As String
        Public hHostName As String
        Public hDBUser As String
        Public hDBPw As String
        Public hDBName As String
        Public hAppUser As String

        Public isAdmin As Boolean
        Public sError As String
        Public sUserName As String

        Public sBranchCode As String
        Public iBranchCount As Integer = 0

        Public bSplash As Boolean
        Public bLoopStop As Boolean
        Public bNotifications As Boolean

        Public LUE_Branches As LookUpEdit = New LookUpEdit()

        Public coaAll As LookUpEdit = New LookUpEdit()
        Public coaSummary As LookUpEdit = New LookUpEdit()
        Public coaDetail As LookUpEdit = New LookUpEdit()

        Public mySQLConnection As SqlConnection = New SqlConnection()
        Public myDataAdapter As SqlDataAdapter = New SqlDataAdapter()

        ' Friend connectSP As String = $"Data Source=192.168.13.15; Initial Catalog=ics; Persist Security Info=True; User ID=cbsumile; Password=cbsumile;"
        'Public SPConnect As New SqlConnection

        Friend Sub Initialize_Connection()
            'connectSP = "Data Source='" & DecryptString(RegKeyGet("HostServer", "HostServer", String.Empty)) & "';" _
            '                       & "Initial Catalog ='" & DecryptString(RegKeyGet("Dbase", "DataBaseName", String.Empty)) & "';" _
            '                       & "Persist Security Info=True;" _
            '                       & "User ID ='" & DecryptString(RegKeyGet("DBaseUname", "DataBaseUserName", String.Empty)) & "';" _
            '                       & "Password='" & DecryptString(RegKeyGet("DBasePassword", "DataBasePassWord", String.Empty)) & "'"
            'SPConnect.ConnectionString = connectSP
        End Sub
    End Module
End Namespace