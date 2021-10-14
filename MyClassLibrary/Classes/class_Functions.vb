Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions

Namespace Classes
    Public Module class_Functions

        Public Enum PasswordScore
            Blank
            VeryWeak
            Weak
            Medium
            Strong
            VeryStrong
        End Enum

        Public Function CheckPasswordStrength(ByVal password As String) As PasswordScore
            Dim N As Integer = 0
            Dim L As Integer = password.Length
            If L = 0 Then Return PasswordScore.Blank
            If Regex.IsMatch(password, "[\d]", RegexOptions.ECMAScript) Then N += 10
            If Regex.IsMatch(password, "[a-z]", RegexOptions.ECMAScript) Then N += 26
            If Regex.IsMatch(password, "[A-Z]", RegexOptions.ECMAScript) Then N += 26
            If Regex.IsMatch(password, "[~`!@#$%\^\&\*\(\)\-_\+=\[\{\]\}\|\\;:'\""<\,>\.\?\/£]", RegexOptions.ECMAScript) AndAlso password.Length > 8 Then N += 33
            Dim H As Integer
            Try
                H = Convert.ToInt32(L * (Math.Round(Math.Log(N) / Math.Log(2))))
            Catch Ex As OverflowException
                H = 0
                class_Procedures.Set_Message(class_Procedures.MsgMode.Sql, $"{Environment.NewLine}{Ex.Source}{Environment.NewLine}{Ex.Message}")
            End Try
            If H <= 32 Then Return PasswordScore.VeryWeak
            If H <= 48 Then Return PasswordScore.Weak
            If H <= 64 Then Return PasswordScore.Medium
            If H <= 80 Then Return PasswordScore.Strong
            Return PasswordScore.VeryStrong
        End Function

        Public Function Product_Name_Version() As String
            Return $"{Application.ProductName} {Application.ProductVersion}™ {Date.Today.Year}"
        End Function

        Public Function AutoID(ByVal sPreCode As String) As String
            Return $"{sPreCode}{DateTime.Now:yyyyMMddHHmmssfff)}"
        End Function

        Public Function FirstDayOfMonth(ByVal value As DateTime) As DateTime
            Return New DateTime(value.Year, value.Month, 1)
        End Function

        <Extension()>
        Public Function DaysInMonth(ByVal value As DateTime) As Integer
            Return DateTime.DaysInMonth(value.Year, value.Month)
        End Function

        <Extension()>
        Public Function LastDayOfMonth(ByVal value As DateTime) As DateTime
            Return New DateTime(value.Year, value.Month, value.DaysInMonth())
        End Function

        Public Function GetMonthDifference(ByVal startDate As Date, ByVal endDate As Date) As Integer
            Return Math.Abs(12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month)
        End Function

        Public Function Next_Working_Date(ByVal dt As Date, Optional ByVal bShiftPressed As Boolean = False) As Date
            Dim i As Integer
            If bShiftPressed Then
                i = -1
            Else
                i = 1
            End If
            dt = dt.AddDays(i)
            If dt.DayOfWeek.Equals(DayOfWeek.Sunday) Then
                dt = dt.AddDays(i)
            End If
            Return dt
        End Function

        Public Function WorkingDays(ByVal dtDateFrom As Date, ByVal dtDateTo As Date) As Integer
            Dim _elapsedDays As Integer = 0
            Dim _weekendDays As DayOfWeek() = {DayOfWeek.Sunday}

            For i = 0 To (dtDateTo - dtDateFrom).Days
                If Not _weekendDays.Contains(dtDateFrom.AddDays(i).DayOfWeek) Then _elapsedDays += 1
            Next

            Return _elapsedDays
        End Function

        Public Function WorkingDays(ByVal dtDateFrom As Date, ByVal iDAys As Integer) As Date
            Dim _elapsedDate As Date = dtDateFrom
            Dim _weekendDays As DayOfWeek() = {DayOfWeek.Saturday, DayOfWeek.Sunday}

            If iDAys > 0 Then
                For i = 0 To iDAys - 1
                    _elapsedDate = _elapsedDate.AddDays(1)
                    If _weekendDays.Contains(_elapsedDate.DayOfWeek) Then
                        i -= 1
                    End If
                Next
            End If
            Return _elapsedDate
        End Function

        Public Function Generate_ID(ByVal sCode As String, ByVal iZeros As Integer) As String
            Return CInt(sCode.Remove(0, sCode.Length - iZeros)).ToString
        End Function

        Public Function Generate_ID(ByVal sPreCode As String, ByVal iZeros As Integer, ByVal iCode As Integer) As String
            Dim sTmpCode, sCode As String
            Dim iLength As Integer = iCode.ToString.Length

            If iLength > iZeros Then iZeros = iLength
            Dim sZeros As String = New String("0"c, iZeros)
            sTmpCode = $"{sPreCode}{sZeros}"
            sCode = sTmpCode.Remove(sTmpCode.Length - iLength)

            Return sCode.Insert(sTmpCode.Length - iLength, iCode.ToString)
        End Function

        Public Function Code_Increment(ByVal sCode As String, ByVal iCount As Integer) As String
            If sCode.Equals(String.Empty) Then Return String.Empty
            Dim iValueNew As Integer = CInt(sCode.Remove(0, sCode.Length - iCount)) + 1
            Return $"{sCode.Remove(sCode.Length - iValueNew.ToString.Length)}{iValueNew}"
        End Function

        Public Function calculate_VAT(ByVal dAmount As Decimal) As Decimal
            Return Math.Round((dAmount / CDec(1.12)) * CDec(0.12), 2)
        End Function

        Public Function calculate_no_VAT(ByVal dAmount As Decimal) As Decimal
            Return Math.Round(dAmount - ((dAmount / CDec(1.12)) * CDec(0.12)), 2)
        End Function

        Public Function Percent(ByVal dAmount As Decimal, ByVal dPercent As Decimal) As Decimal
            Return ((dAmount * dPercent) / 100) - dAmount
        End Function

        Public Function maskString(ByVal s As String, ByVal iUnMaskLeft As Integer, ByVal iUnMaskRight As Integer) As String
            Dim sReturn As String = Nothing
            Try
                Dim firstPart As String = s.Substring(0, iUnMaskLeft)
                Dim len As Integer = s.Length
                Dim lastPart As String = s.Substring(len - iUnMaskRight, iUnMaskRight)
                Dim middlePartLenght As Integer = len - (firstPart.Length + lastPart.Length)
                Dim middlePart As String = New String("•"c, middlePartLenght)
                sReturn = $"{firstPart}{middlePart}{lastPart}"
            Catch Ex As Exception
                class_Procedures.Show_Error(Ex)
            End Try
            Return sReturn
        End Function

        Public Function AmountToWords(ByVal sNumber As String) As String
            Dim sNumberSet As String = Trim(sNumber)
            Dim sAmount As String() = sNumberSet.Split(New Char() {"."c})
            Dim sPesos = sAmount(0)
            Dim sCents As String = Nothing

            Try
                sCents = Left(sAmount(1), 2)
            Catch Ex As Exception
                class_Procedures.Set_Message(class_Procedures.MsgMode.Sql, $"{Ex.Source}{Environment.NewLine}{Ex.Message}{Environment.NewLine}Please make sure that the [Amount in Words] are specified.", "Amount in Words")
            End Try

            Try
                If CInt(sCents) > 0 Then
                    Return $"{NumberToText(CInt(sPesos)).Trim} Pesos and {NumberToText(CInt(sCents))} Cents Only"
                Else
                    Return $"{NumberToText(CInt(sPesos)).Trim} Pesos Only"
                End If
            Catch Ex As OverflowException
                class_Procedures.Show_Error(Ex)
            End Try
            Return Nothing
        End Function

        Private Function NumberToText(ByVal n As Integer) As String
            Select Case n
                Case 0
                    Return String.Empty
                Case 1 To 19
                    Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                    Return $"{arr(n - 1)}"
                Case 20 To 99
                    Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
                    Return $"{arr(n \ 10 - 2)} {NumberToText(n Mod 10)}"
                Case 100 To 199
                    Return $"One Hundred {NumberToText(n Mod 100)}"
                Case 200 To 999
                    Return $"{NumberToText(n \ 100)} Hundred {NumberToText(n Mod 100)}"
                Case 1000 To 1999
                    Return $"One Thousand {NumberToText(n Mod 1000)}"
                Case 2000 To 999999
                    Return $"{NumberToText(n \ 1000)} Thousand {NumberToText(n Mod 1000)}"
                Case 1000000 To 1999999
                    Return $"One Million {NumberToText(n Mod 1000000)}"
                Case 1000000 To 999999999
                    Return $"{NumberToText(n \ 1000000)} Million {NumberToText(n Mod 1000000)}"
                Case 1000000000 To 1999999999
                    Return $"One Billion {NumberToText(n Mod 1000000000)}"
                Case Else
                    Return $"{NumberToText(n \ 1000000000)} Billion {NumberToText(n Mod 1000000000)}"
            End Select
        End Function

        Public Function IsUpperCase(ByVal input As String) As Boolean
            For i As Integer = 0 To input.Length - 1
                If String.Compare(input.Substring(i, 1), input.Substring(i, 1).ToUpper(), False) <> 0 Then Return False
            Next
            Return True
        End Function

        Private Sub Args_Showing(sender As Object, e As XtraMessageShowingArgs)
            'e.Form.Icon = XtraForm1.Icon
        End Sub

        Public Function Show_Input_Box(ByVal sPrompt As String, ByVal sCaption As String, ByVal dDefaultResponse As String) As String
            Dim sResult As String = String.Empty
            Dim args As New XtraInputBoxArgs()
            AddHandler args.Showing, AddressOf Args_Showing

            args.Caption = sCaption
            args.Prompt = sPrompt
            args.DefaultButtonIndex = 0
            args.DefaultResponse = dDefaultResponse

            Try
                sResult = XtraInputBox.Show(args).ToString
            Catch Ex As Exception
                Return String.Empty
            End Try

            class_Procedures.Copy_Clipboard(sResult)
            Return sResult
        End Function

        Public Function Show_Input_Box(ByVal sPrompt As String, ByVal sCaption As String, ByVal dDefaultResponse As Date) As Date
            Dim args As New XtraInputBoxArgs()
            AddHandler args.Showing, AddressOf Args_Showing

            args.Caption = sCaption
            args.Prompt = sPrompt
            args.DefaultButtonIndex = 0

            Dim editor As New DateEdit()
            editor.Properties.CalendarView = Repository.CalendarView.TouchUI
            editor.Properties.Mask.EditMask = "MMMM dd, yyyy"
            args.Editor = editor
            args.DefaultResponse = dDefaultResponse
            Return CDate(XtraInputBox.Show(args))
        End Function

        Public Function Show_Input_Box(ByVal sPrompt As String, ByVal sCaption As String, ByVal dDefaultResponse As Integer) As Integer
            Dim args As New XtraInputBoxArgs()
            AddHandler args.Showing, AddressOf Args_Showing

            args.Caption = sCaption
            args.Prompt = sPrompt
            args.DefaultButtonIndex = 0

            Dim editor As New CalcEdit()
            editor.Properties.Mask.EditMask = "N0"
            args.Editor = editor
            args.DefaultResponse = dDefaultResponse

            Return CInt(XtraInputBox.Show(args))
        End Function

        Public Function Show_Input_Box(ByVal sPrompt As String, ByVal sCaption As String, ByVal dDefaultResponse As Decimal) As Decimal
            Dim args As New XtraInputBoxArgs()
            AddHandler args.Showing, AddressOf Args_Showing

            args.Caption = sCaption
            args.Prompt = sPrompt
            args.DefaultButtonIndex = 0

            Dim editor As New CalcEdit()
            editor.Properties.Mask.EditMask = "N2"
            args.Editor = editor
            args.DefaultResponse = dDefaultResponse

            Return CDec(XtraInputBox.Show(args))
        End Function

        Public Function GridView_Loop(ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal iRowHandleOld As Integer, ByVal iRowHandle As Integer, ByVal sTitle As String, ByVal sAction As String, ByVal bLoopStop As Boolean, Optional ByVal bLoopLive As Boolean = True, Optional ByVal bSelectAll As Boolean = False, Optional ByVal columnFieldName As String = "Notes") As Boolean
            With gridView
                If bLoopStop OrElse class_Database.DBError Then
                    .SetRowCellValue(iRowHandle, columnFieldName, class_Database.sError)
                    class_Procedures.Loop_Stop_Message(sTitle, sAction)
                    Return False
                End If

                If bLoopLive Then
                    If Not bSelectAll Then .UnselectRow(iRowHandleOld)
                    .FocusedRowHandle = iRowHandle
                    .MakeRowVisible(iRowHandle)
                    If Not bSelectAll Then .SelectRow(iRowHandle)
                    Application.DoEvents()
                End If
            End With
            Return True
        End Function

    End Module
End Namespace