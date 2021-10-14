Imports System.Data.SqlClient
Imports System.Net.Sockets
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms
Imports MyClassLibrary.Classes

Namespace myModules
    Public Module CentralModule

        '' Public Delegate Sub MsgHandler(ByVal Msg As String)
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
        Public ICSConnectionMJ As New SqlConnection(connectICSMJ)

        Public connectMIS As String
        Public MISConnection As New SqlConnection(connectMIS)

        Public Sub InitializeApps()
            connectSP = "Data Source='" & hHostServer & "';" _
                               & "Initial Catalog ='" & hDBName & "';" _
                               & "Persist Security Info=True;" _
                               & "User ID ='" & hDBUser & "';" _
                               & "Password='" & hDBPw & "' "
            SPConnect.ConnectionString = connectSP

            class_Database.ICSConnection = connectSP

            connectSpareParts = "Data Source='" & hHostServer & "';" _
                                 & "Initial Catalog =Spare_Parts;" _
                                 & "Persist Security Info=True;" _
                                 & "User ID ='" & hDBUser & "';" _
                                 & "Password='" & hDBPw & "' ;Timeout=300"
            SPConnectSpareParts.ConnectionString = connectSpareParts

            connectSP2 = "Data Source='" & hHostServer & "';" _
                               & "Initial Catalog ='" & hDBName & "';" _
                               & "Persist Security Info=True;" _
                               & "User ID ='" & hDBUser & "';" _
                               & "Password='" & hDBPw & "' ;Timeout=300"
            SPConnect2.ConnectionString = connectSP2

            connectICSmj = "Data Source='" & hHostServer & "';" _
                               & "Initial Catalog ='" & hDBName & "';" _
                               & "Persist Security Info=True;" _
                               & "User ID ='" & hDBUser & "';" _
                               & "Password='" & hDBPw & "' ;Timeout=300"
            ICSConnectionMJ.ConnectionString = connectICSmj

            connectMIS = "Data Source='" & hHostServer & "';" _
                               & "Initial Catalog ='" & hDBName & "';" _
                               & "Persist Security Info=True;" _
                               & "User ID ='" & hDBUser & "';" _
                               & "Password='" & hDBPw & "' ;Timeout=300"
            MISConnection.ConnectionString = connectMIS
        End Sub

        Const passphrase As String = "webMh@rjun"

        Public Function EncryptString(ByVal Message As String) As String
            Dim Results As Byte()
            Dim UTF8 As System.Text.UTF8Encoding = New System.Text.UTF8Encoding()
            Dim HashProvider As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
            Dim TDESKey As Byte() = HashProvider.ComputeHash(UTF8.GetBytes(passphrase))
            Dim TDESAlgorithm As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider With {
                .Key = TDESKey,
                .Mode = CipherMode.ECB,
                .Padding = PaddingMode.PKCS7
            }
            Dim DataToEncrypt As Byte() = UTF8.GetBytes(Message)

            Try
                Dim Encryptor As ICryptoTransform = TDESAlgorithm.CreateEncryptor()
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length)
            Catch ex As CryptographicException

                Return Nothing
            Finally
                TDESAlgorithm.Clear()
                HashProvider.Clear()
            End Try

            Return Convert.ToBase64String(Results)
        End Function

        Public Function DecryptString(ByVal Message As String) As String
            If Message Is String.Empty Then Return String.Empty
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
                Dim DataToDecrypt As Byte() = Convert.FromBase64String(Message)
                Dim Decryptor As ICryptoTransform = TDESAlgorithm.CreateDecryptor()
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length)
            Catch ex As CryptographicException

                Return Nothing
            Catch ex As FormatException

                Return Nothing
            Finally
                TDESAlgorithm.Clear()
                HashProvider.Clear()
            End Try

            Return UTF8.GetString(Results)
        End Function

        Public Function newCheckConnection(ByVal SName As String, ByVal DBName As String, ByVal UName As String, ByVal Pass As String) As Boolean
            If sqlConn.State <> 0 Then
                sqlConn.Close()
                newCheckConnection = False
            End If

            sqlConn.ConnectionString = "Server=" & SName & ";" _
                                 & "Database=" & DBName & ";" _
                                 & "User Id=" & UName & ";" _
                                 & "Password=" & Pass & ";"
            Try
                sqlConn.Open()
                newCheckConnection = True
            Catch ex As Exception
                newCheckConnection = False
            End Try
        End Function

        Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
            'Let's make sure entered value is numeric
            If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

            'I used this kind of approach using String instead of Double as datatype then I applied string manipulation
            'and remove the decimal value then store it in tempDecValue and re-attach it to nAmount upon entering the recursion
            'The reason is that I tried using the Double datatype but when it comes to quadrillion values and with decimal values
            'I noticed that the ones and tens values changed, or some errors encountered. I couldn't figure it out until I came up with this concept.

            'tempDecValue gets the decimal value from the original value nAmount
            'tempDecValue is added to the nAmount every time it enters the recursion
            Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then tempDecValue = nAmount.Substring(nAmount.IndexOf("."))

            'Removing the decimal value from nAmount
            nAmount = Replace(nAmount, tempDecValue, String.Empty)

            Try
                'Assigning the nAmount to intAmount having the LONG datatype
                Dim intAmount As Long = nAmount

                'Let's trap the values entered into the recursion; if greater than 0 then let's evaluate the numbers in set, otherwise,
                '(1) all numbers have already been evaluated and return the designated word values (for entered whole numbers); or
                '(2) evaluate last set, which is the decimal value
                'either which proceed to else statement and/or return the result
                If intAmount > 0 Then
                    'Let's segregate the entered values into 3-digit sets of numbers and count it then store in the nSet
                    'For example: 9223372036854775807 has 7 sets; start from right to left (807, 775, 854, 036...), until the last set which is 9
                    nSet = IIf((intAmount.ToString.Trim.Length / 3) > (CLng(intAmount.ToString.Trim.Length / 3)), CLng(intAmount.ToString.Trim.Length / 3) + 1, CLng(intAmount.ToString.Trim.Length / 3))

                    'eAmount gets each 3-digit set entered into the recursion
                    'Though I said sets start from right to left, we start evaluating each set from left to right of the entered values.
                    'For example: 9223372036854775807 (actual: 9,223,372,036,854,775,807), 9 (1st set to be evaluated), 223 (next set), 372 (next set),... and so on
                    'and so forth until all are evaluated, including the decimal values, in case there exists
                    'NOTE: 9 is in Quintillion range, 223 is in Quadrillion, 372 in Trillion, and so on and so forth
                    Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim, (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))

                    'Multiplier gets the 10 to the power of the nSet
                    'This is needed to remove the evaluated set from the original values
                    'For example: 1st set is 9 (the 1st value of eAmount) and there are 7 sets so:
                    '10 ^ (((7 - 1) * 3)) is 1000000000000000000
                    '9 multiplied by 1000000000000000000 is 9000000000000000000
                    'remove 9000000000000000000 from 9223372036854775807 which results in 223372036854775807, the next value of nAmount within which the decimal value .75 shall be attached
                    'the flow goes on and on until nAmount reaches zero, or the decimal value
                    'so multiplier has a vital function as we go on and we shall see later
                    Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                    'These are the worded values
                    Dim Ones() As String = {String.Empty, "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"}
                    Dim Teens() As String = {String.Empty, "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                    Dim Tens() As String = {String.Empty, "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                    Dim HMBT() As String = {String.Empty, String.Empty, "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion"}

                    'Let's reuse the intAmount object
                    intAmount = eAmount

                    'Remember, we have a 3-digit number in each set
                    'from left to right is hundreds, tens, and ones
                    'For example 9 is the ones in the first set for evaluation; the next set is 223 (1st 2 is hundreds, next 2 is tens, and 3 is ones)
                    'These statements segregate the numbers in the set
                    Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                    Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                    Dim nOne As Integer = intAmount \ 1

                    'After the segregation, we now have to evaluate the retrieved numbers and put the corresponding words for each number
                    If nHundred > 0 Then wAmount = wAmount & Ones(nHundred) & " Hundred " 'This is for hundreds
                    If nTen > 0 Then 'This is for tens and teens
                        'In case of teens, like 11 to 19, it will be trapped in here and proceed to the designated word
                        If nTen = 1 And nOne > 0 Then 'This is for teens (number ten plus ones succeeding it) Example:
                            wAmount = wAmount & Teens(nOne) & " " '11 is Eleven, 12 is Twelve, 15 is Fifteen, 17 is Seventeen, and so on
                        Else 'This is for tens, 10 to 90
                            wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ") 'If there is ones succeeding it, put a dash before the ones, example: Twenty-, Thirty-, Forty-, etc.
                            If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " " 'This is for ones (1-9) with the tens (20-90) preceeding it. Example: 21 is Twenty-One, 34 is Thirty-Four, 48 is Forty-Eight
                        End If
                    Else 'This is for ones, 1 to 9
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                    'Let's put in here the ranges (1st set(number 9) is Quintillion, next(number 223) is Quadrillion, next(372) is Trillion, ...so on and so forth)
                    wAmount = wAmount & HMBT(nSet) & " "
                    'Proceed to next set to evaluate by entering the same function we are in (recursion)
                    wAmount = AmountInWords(CStr(CLng(nAmount) - (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
                Else 'When nAmount reaches 0, we proceed to this statement
                    'If there is no decimal value then proceed to display the result
                    'But if there is a decimal value then let's evaluate each number of the decimal value
                    'First we re-attach the decimal value to its original value, the nAmount
                    If Val(nAmount) = 0 Then nAmount = nAmount & tempDecValue : tempDecValue = String.Empty
                    'Now, if we have decimal value, let's convert it into whole numbers (not rounding it off, but actually converting to whole numbers),
                    'put it into the recursion for the last time, evaluate it, give the corresponding words and then finally, display the result
                    If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100), wAmount.Trim & " Pesos And ", 1)) & " Cents"
                End If
            Catch ex As Exception
                'Should there be any error encountered, this will handle it.
                MessageBox.Show("Error Encountered: " & ex.Message, "Convert Numbers To Words", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return "!#ERROR_ENCOUNTERED"
            End Try

            'Trap null values
            If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount = IIf(InStr(wAmount.Trim.ToLower, "pesos"), wAmount.Trim, wAmount.Trim & " Pesos")

            'Display the result
            Return wAmount
        End Function

        Public Function AmountInWordsNoCurrency(ByVal nAmount As String, Optional ByVal wAmount As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
            'Let's make sure entered value is numeric
            If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

            'I used this kind of approach using String instead of Double as datatype then I applied string manipulation
            'and remove the decimal value then store it in tempDecValue and re-attach it to nAmount upon entering the recursion
            'The reason is that I tried using the Double datatype but when it comes to quadrillion values and with decimal values
            'I noticed that the ones and tens values changed, or some errors encountered. I couldn't figure it out until I came up with this concept.

            'tempDecValue gets the decimal value from the original value nAmount
            'tempDecValue is added to the nAmount every time it enters the recursion
            Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then tempDecValue = nAmount.Substring(nAmount.IndexOf("."))

            'Removing the decimal value from nAmount
            nAmount = Replace(nAmount, tempDecValue, String.Empty)

            Try
                'Assigning the nAmount to intAmount having the LONG datatype
                Dim intAmount As Long = nAmount

                'Let's trap the values entered into the recursion; if greater than 0 then let's evaluate the numbers in set, otherwise,
                '(1) all numbers have already been evaluated and return the designated word values (for entered whole numbers); or
                '(2) evaluate last set, which is the decimal value
                'either which proceed to else statement and/or return the result
                If intAmount > 0 Then
                    'Let's segregate the entered values into 3-digit sets of numbers and count it then store in the nSet
                    'For example: 9223372036854775807 has 7 sets; start from right to left (807, 775, 854, 036...), until the last set which is 9
                    nSet = IIf((intAmount.ToString.Trim.Length / 3) > (CLng(intAmount.ToString.Trim.Length / 3)), CLng(intAmount.ToString.Trim.Length / 3) + 1, CLng(intAmount.ToString.Trim.Length / 3))

                    'eAmount gets each 3-digit set entered into the recursion
                    'Though I said sets start from right to left, we start evaluating each set from left to right of the entered values.
                    'For example: 9223372036854775807 (actual: 9,223,372,036,854,775,807), 9 (1st set to be evaluated), 223 (next set), 372 (next set),... and so on
                    'and so forth until all are evaluated, including the decimal values, in case there exists
                    'NOTE: 9 is in Quintillion range, 223 is in Quadrillion, 372 in Trillion, and so on and so forth
                    Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim, (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))

                    'Multiplier gets the 10 to the power of the nSet
                    'This is needed to remove the evaluated set from the original values
                    'For example: 1st set is 9 (the 1st value of eAmount) and there are 7 sets so:
                    '10 ^ (((7 - 1) * 3)) is 1000000000000000000
                    '9 multiplied by 1000000000000000000 is 9000000000000000000
                    'remove 9000000000000000000 from 9223372036854775807 which results in 223372036854775807, the next value of nAmount within which the decimal value .75 shall be attached
                    'the flow goes on and on until nAmount reaches zero, or the decimal value
                    'so multiplier has a vital function as we go on and we shall see later
                    Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                    'These are the worded values
                    Dim Ones() As String = {String.Empty, "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"}
                    Dim Teens() As String = {String.Empty, "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                    Dim Tens() As String = {String.Empty, "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                    Dim HMBT() As String = {String.Empty, String.Empty, "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion"}

                    'Let's reuse the intAmount object
                    intAmount = eAmount

                    'Remember, we have a 3-digit number in each set
                    'from left to right is hundreds, tens, and ones
                    'For example 9 is the ones in the first set for evaluation; the next set is 223 (1st 2 is hundreds, next 2 is tens, and 3 is ones)
                    'These statements segregate the numbers in the set
                    Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                    Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                    Dim nOne As Integer = intAmount \ 1

                    'After the segregation, we now have to evaluate the retrieved numbers and put the corresponding words for each number
                    If nHundred > 0 Then wAmount = wAmount & Ones(nHundred) & " Hundred " 'This is for hundreds
                    If nTen > 0 Then 'This is for tens and teens
                        'In case of teens, like 11 to 19, it will be trapped in here and proceed to the designated word
                        If nTen = 1 And nOne > 0 Then 'This is for teens (number ten plus ones succeeding it) Example:
                            wAmount = wAmount & Teens(nOne) & " " '11 is Eleven, 12 is Twelve, 15 is Fifteen, 17 is Seventeen, and so on
                        Else 'This is for tens, 10 to 90
                            wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ") 'If there is ones succeeding it, put a dash before the ones, example: Twenty-, Thirty-, Forty-, etc.
                            If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " " 'This is for ones (1-9) with the tens (20-90) preceeding it. Example: 21 is Twenty-One, 34 is Thirty-Four, 48 is Forty-Eight
                        End If
                    Else 'This is for ones, 1 to 9
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne)
                    End If
                    'Let's put in here the ranges (1st set(number 9) is Quintillion, next(number 223) is Quadrillion, next(372) is Trillion, ...so on and so forth)
                    wAmount = wAmount & HMBT(nSet)
                    'Proceed to next set to evaluate by entering the same function we are in (recursion)
                    wAmount = AmountInWordsNoCurrency(CStr(CLng(nAmount) - (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
                Else 'When nAmount reaches 0, we proceed to this statement
                    'If there is no decimal value then proceed to display the result
                    'But if there is a decimal value then let's evaluate each number of the decimal value
                    'First we re-attach the decimal value to its original value, the nAmount
                    If Val(nAmount) = 0 Then nAmount = nAmount & tempDecValue : tempDecValue = String.Empty
                    'Now, if we have decimal value, let's convert it into whole numbers (not rounding it off, but actually converting to whole numbers),
                    'put it into the recursion for the last time, evaluate it, give the corresponding words and then finally, display the result
                    If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100), wAmount.Trim, 1))
                End If
            Catch ex As Exception
                'Should there be any error encountered, this will handle it.
                MessageBox.Show("Error Encountered: " & ex.Message, "Convert Numbers To Words", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return "!#ERROR_ENCOUNTERED"
            End Try

            'Trap null values
            If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount = IIf(InStr(wAmount.Trim.ToLower, ""), wAmount.Trim, wAmount.Trim)

            'Display the result
            Return wAmount
        End Function

        Public Function GetOrdinal(num As Integer) As String

            Select Case (num Mod 100)
                Case 11, 12, 13
                    Return "th"
            End Select

            Select Case (num Mod 10)
                Case 1
                    Return "st"
                Case 2
                    Return "nd"
                Case 3
                    Return "rd"
                Case Else
                    Return "th"
            End Select

        End Function

    End Module

End Namespace