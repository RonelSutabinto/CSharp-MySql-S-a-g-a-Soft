Imports Microsoft.Win32
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Namespace Classes
    Public Module class_Tools
        Const passphrase As String = "webMh@rjun"

        Public Function Encrypt(ByVal sText As String) As String
            Dim Results As Byte()
            Dim UTF8 As UTF8Encoding = New UTF8Encoding()
            Dim HashProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
            Dim TDESKey As Byte() = HashProvider.ComputeHash(UTF8.GetBytes(passphrase))
            Dim TDESAlgorithm As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider With {
                .Key = TDESKey,
                .Mode = CipherMode.ECB,
                .Padding = PaddingMode.PKCS7
            }
            Dim DataToEncrypt As Byte() = UTF8.GetBytes(sText)

            Try
                Dim Encryptor As ICryptoTransform = TDESAlgorithm.CreateEncryptor()
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length)
            Catch Ex As CryptographicException
                class_Procedures.Show_Error(Ex)
                Return Nothing
            Finally
                TDESAlgorithm.Clear()
                HashProvider.Clear()
            End Try

            Return Convert.ToBase64String(Results)
        End Function

        Public Function Decrypt(ByVal sText As String, Optional ByVal sDefault As String = "") As String
            If sText Is String.Empty Then Return String.Empty
            Dim Results As Byte()
            Dim UTF8 As UTF8Encoding = New UTF8Encoding()
            Dim HashProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
            Dim TDESKey As Byte() = HashProvider.ComputeHash(UTF8.GetBytes(passphrase))
            Dim TDESAlgorithm As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider With {
            .Key = TDESKey,
            .Mode = CipherMode.ECB,
            .Padding = PaddingMode.PKCS7
        }

            Try
                Dim DataToDecrypt As Byte() = Convert.FromBase64String(sText)
                Dim Decryptor As ICryptoTransform = TDESAlgorithm.CreateDecryptor()
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length)
            Catch Ex As CryptographicException
                class_Procedures.Show_Error(Ex)
                Return sDefault
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
                Return sDefault
            Finally
                TDESAlgorithm.Clear()
                HashProvider.Clear()
            End Try

            Return UTF8.GetString(Results)
        End Function

        Public Sub ReplaceInFile(ByVal OrigFile As String, ByVal NewFile As String, ByVal searchText As String, ByVal replaceText As String)
            Dim reader As StreamReader = New StreamReader(OrigFile)
            Dim content As String = reader.ReadToEnd()
            reader.Close()
            content = Regex.Replace(content, searchText, replaceText)

            Using writer As StreamWriter = New StreamWriter(NewFile)
                writer.Write(content)
            End Using
        End Sub

        Public Sub SubKeyTreeDelete(ByVal registryPath As RegistryKey, ByVal keyToDelete As String)
            If registryPath IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(keyToDelete) Then
                Dim throwOnMissingSubKey As Boolean = False
                Try
                    registryPath.DeleteSubKeyTree(keyToDelete, throwOnMissingSubKey)
                Catch
                End Try
            End If
        End Sub

        Public Function RegKeyGet(ByVal keySection As String, ByVal keyName As String, ByVal keyDefault As String) As String
            Dim sPath As String = $"{Application.ProductName}\\{keySection}\\{keyName}"
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(sPath, True)
            If key Is Nothing Then
                key = Registry.CurrentUser.CreateSubKey(sPath)
                key.SetValue(keyName, keyDefault)
            End If
            Return CStr(key.GetValue(keyName))
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

        Public Function RegKeyGet(ByVal keySection As String, ByVal keyName As String, ByVal keyDefault As Integer) As Integer
            Dim sPath As String = $"{Application.ProductName}\\{keySection}\\{keyName}"
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(sPath, True)
            If key Is Nothing Then
                key = Registry.CurrentUser.CreateSubKey(sPath)
                key.SetValue(keyName, keyDefault)
            End If
            Return CInt(key.GetValue(keyName))
        End Function

        Public Function RegKeyGet(ByVal keySection As String, ByVal keyName As String, ByVal keyDefault As Decimal) As Decimal
            Dim sPath As String = $"{Application.ProductName}\\{keySection}\\{keyName}"
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(sPath, True)
            If key Is Nothing Then
                key = Registry.CurrentUser.CreateSubKey(sPath)
                key.SetValue(keyName, keyDefault)
            End If
            Return CDec(key.GetValue(keyName))
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

        Public Sub RegKeySet(ByVal keySection As String, ByVal keyName As String, ByVal keyValue As Boolean)
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

        Public Sub RegKeySet(ByVal keySection As String, ByVal keyName As String, ByVal keyValue As Decimal)
            Dim sPath As String = $"{Application.ProductName}\\{keySection}\\{keyName}"
            Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(sPath, True)
            If key IsNot Nothing Then
                key.SetValue(keyName, keyValue)
                key.Close()
            End If
        End Sub

    End Module
End Namespace