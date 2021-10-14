Imports Microsoft.Win32

Namespace Modules
    Module Module_Tools

        Public Function RegKeyGet(ByVal keySection As String, ByVal keyName As String, ByVal keyDefault As String) As String
            Dim sPath As String = $"{Application.ProductName}\\{keySection}\\{keyName}"
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(sPath, True)
            If key Is Nothing Then
                key = Registry.CurrentUser.CreateSubKey(sPath)
                key.SetValue(keyName, keyDefault)
            End If
            Return CStr(key.GetValue(keyName))
        End Function

        Public Function RegKeyGet(ByVal keySection As String, ByVal keyName As String, ByVal keyDefault As Integer) As Integer
            Dim sPath As String = $"{Application.ProductName}\\{keySection}\\{keyName}"
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(sPath, True)
            If key Is Nothing Then
                key = Registry.CurrentUser.CreateSubKey(sPath)
                key.SetValue(keyName, keyDefault)
            End If
            Return CInt(key.GetValue(keyName))
        End Function

        Public Function RegKeyGet(ByVal keySection As String, ByVal keyName As String, ByVal keyDefault As Boolean) As Boolean
            Dim sPath As String = $"{Application.ProductName}\\{keySection}\\{keyName}"
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(sPath, True)
            If key Is Nothing Then
                key = Registry.CurrentUser.CreateSubKey(sPath)
                key.SetValue(keyName, keyDefault)
            End If
            Return CBool(key.GetValue(keyName))
        End Function

        Public Sub RegKeySet(ByVal keySection As String, ByVal keyName As String, ByVal keyValue As String)
            If keyValue Is Nothing Then Return
            Dim sPath As String = $"{Application.ProductName}\\{keySection}\\{keyName}"
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(sPath, True)
            If key IsNot Nothing Then
                key.SetValue(keyName, keyValue)
                key.Close()
            End If
        End Sub

        Public Sub RegKeySet(ByVal keySection As String, ByVal keyName As String, ByVal keyValue As Integer)
            Dim sPath As String = $"{Application.ProductName}\\{keySection}\\{keyName}"
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(sPath, True)
            If key IsNot Nothing Then
                key.SetValue(keyName, keyValue)
                key.Close()
            End If
        End Sub

        Public Sub RegKeySet(ByVal keySection As String, ByVal keyName As String, ByVal keyValue As Boolean)
            Dim sPath As String = $"{Application.ProductName}\\{keySection}\\{keyName}"
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(sPath, True)
            If key IsNot Nothing Then
                key.SetValue(keyName, keyValue)
                key.Close()
            End If
        End Sub

    End Module
End Namespace