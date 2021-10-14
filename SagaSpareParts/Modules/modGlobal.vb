Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting.BarCode
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.Drawing.Printing
Imports System.Windows.Forms

Module modGlobal

    Public Function CreateQRCodeBarCode(ByVal BarCodeText As String) As XRBarCode
        Dim barCode As New XRBarCode()
        barCode.Symbology = New QRCodeGenerator()
        barCode.Text = BarCodeText
        barCode.WidthF = 400
        barCode.HeightF = 150
        barCode.AutoModule = True

        CType(barCode.Symbology, QRCodeGenerator).CompactionMode = QRCodeCompactionMode.AlphaNumeric
        CType(barCode.Symbology, QRCodeGenerator).ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H
        CType(barCode.Symbology, QRCodeGenerator).Version = QRCodeVersion.AutoVersion
        Return barCode
    End Function

    '' Public Delegate Sub MsgHandler(ByVal Msg As String)
    Public sqlConn As New SqlConnection

    Public SqlComm As New SqlCommand
    Public isDBRecord As SqlDataReader
    Public DBAdapter As SqlDataAdapter
    Public ServerName, DatabaseName, UserName, UserPassword As String

    Public connectPayroll As String = "Data Source=192.168.13.15;Initial Catalog=Payroll;Persist Security Info=True;User ID=sa;Password=barcode10"

    'Public connectPayroll As String = "Data Source=(local);Initial Catalog=Payroll;Persist Security Info=True;User ID=sa;Password=@n1m@t0r "
    Public PayrollConnection As New SqlConnection(connectPayroll)

    'Public connectMIS As String = "Data Source='" & My.Settings.ServerName & "';Initial Catalog='" & My.Settings.DatabaseName & "';Persist Security Info=True;User ID='" & My.Settings.Username & "';Password='" & My.Settings.UserPassword & "' "
    'Public MISConnection As New SqlConnection(connectMIS)

    'Public connectICS As String = "Data Source=192.168.13.15;Initial Catalog=ICS;Persist Security Info=True;User ID=bjpbelonghilot;Password=bjpbelonghilot"
    'Public ICSConnection As New SqlConnection(connectICS)

    Public connectICS1 As String = "Data Source=192.168.13.15;Initial Catalog=ICS;Persist Security Info=True;User ID=bjpbelonghilot;Password=bjpbelonghilot"
    Public SPConnect As New SqlConnection(connectICS1)

    'Public connectSpareParts As String = "Data Source=localhost;Initial Catalog=Spare_Parts;Persist Security Info=True;User ID=sa;Password=saga;Timeout=100"
    'Public SPConnectSpareParts As New SqlConnection(connectSpareParts)

    'Public connectICSTransactions As String = "Data Source=localhost;Initial Catalog=ICSTransactions;Persist Security Info=True;User ID=sa;Password=saga;Timeout=100"
    'Public ICSTransactions As New SqlConnection(connectICSTransactions)

    'Public connectSpareParts As String = "Data Source=192.168.13.40;Initial Catalog=Spare_Parts;Persist Security Info=True;User ID=bjpbelonghilot;Password=bjpbelonghilot;Timeout=100"
    'Public SPConnectSpareParts As New SqlConnection(connectSpareParts)

    Public connectICSTransactions As String = "Data Source=192.168.13.40;Initial Catalog=ICSTransactions;Persist Security Info=True;User ID=bjpbelonghilot;Password=bjpbelonghilot;Timeout=100"
    Public ICSTransactions As New SqlConnection(connectICSTransactions)

    'Public connectSpareParts As String = "Data Source=192.168.13.15;Initial Catalog=Spare_Parts;Persist Security Info=True;User ID=bjpbelonghilot;Password=bjpbelonghilot;Timeout=100"
    'Public SPConnectSpareParts As New SqlConnection(connectSpareParts)

    Public connectSpareParts As String = "Data Source=124.107.148.186;Initial Catalog=Spare_Parts;Persist Security Info=True;User ID=branch@saga;Password=sql@saga2020;Timeout=100"
    Public SPConnectSpareParts As New SqlConnection(connectSpareParts)

    'Public connectICSTransactions As String = "Data Source=192.168.13.15;Initial Catalog=ICSTransactions;Persist Security Info=True;User ID=bjpbelonghilot;Password=bjpbelonghilot;Timeout=100"
    'Public ICSTransactions As New SqlConnection(connectICSTransactions)

    'Public connectSpareParts As String = "Data Source=(local);Initial Catalog=Spare_Parts;Persist Security Info=True;User ID=sa;Passwordsaga;Timeout=100"
    'Public SPConnectSpareParts As New SqlConnection(connectSpareParts)

    'Public connectICSTransactions As String = "Data Source=172.168.5.55;Initial Catalog=ICSTransactions;Persist Security Info=True;User ID=bjpbelonghilot;Password=bjpbelonghilot;Timeout=100"
    'Public ICSTransactions As New SqlConnection(connectICSTransactions)

    'Public connectSpareParts As String = "Data Source=192.168.13.15;Initial Catalog=Spare_Parts;Persist Security Info=True;User ID=bjpbelonghilot;Password=bjpbelonghilot;Timeout=15"
    'Public SPConnectSpareParts As New SqlConnection(connectSpareParts)

    'Public connectICSTransactions As String = "Data Source=192.168.13.15;Initial Catalog=ICSTransactions;Persist Security Info=True;User ID=bjpbelonghilot;Password=bjpbelonghilot;Timeout=15"
    'Public ICSTransactions As New SqlConnection(connectICSTransactions)

    'Public connectSpareParts As String = "Data Source=124.107.148.186;Initial Catalog=Spare_Parts;Persist Security Info=True;User ID=bjpbelonghilot;Password=bjpbelonghilot "
    'Public SPConnectSpareParts As New SqlConnection(connectSpareParts)

    'Public connectSP As String = "Data Source=localhost;Initial Catalog=ICS;Persist Security Info=True;User ID=sa;Password=saga;Timeout=1000"
    'Public SPConnect As New SqlConnection(connectSP)

    'Public connectSP2 As String = "Data Source='" & My.Settings.ServerName & "';Initial Catalog='" & My.Settings.DatabaseName & "';Persist Security Info=True;User ID='" & My.Settings.Username & "';Password='" & My.Settings.UserPassword & "' "
    'Public SPConnect2 As New SqlConnection(connectSP2)
    'Public SPConnect As New SqlConnection("Server='" & My.Settings.ServerName & "'; Database = '" & My.Settings.DatabaseName & "'; Integrated Security = true")
    'Public SPcmd As New SqlCommand
    'Public SPrs As SqlDataReader

    'Public Function OpenDB(ByVal connectSpareParts As String, ByVal connectICSTransactions As String) As Boolean

    '    Try
    '        CloseDB()
    '        sqlConn.ConnectionString = connectSpareParts
    '        sqlConn.ConnectionString = connectICSTransactions
    '        sqlConn.Open()
    '        Return True
    '    Catch Ex As InvalidOperationException
    '        Return False
    '    Catch Ex As SqlException
    '        Return False
    '    End Try
    'End Function

    'Public Sub CloseDB()
    '    If sqlConn.State.Equals(ConnectionState.Open) Then sqlConn.Close()
    'End Sub

    Public Sub LViewEvent()
        'Dim TotalunitCost As Double = 0
        'Dim TotalVATAmt As Double = 0
        'Dim GrandTotal As Double = 0
        'Dim TotalUnitPrice As Double
        'Dim TotalCount As Double = 0

        'Dim TempNode As ListViewItem
        'Dim TempUnitCost, TempVATAmt, TempUnitPrice, TempGrandTotal As Double

        ''  If IS_Inventory_item_add.eventForm.Text = "Receiving" Then
        'For Each TempNode In IS_Inventory_Receiving.LViewItems.Items
        '    If Double.TryParse(TempNode.SubItems.Item(7).Text, TempUnitCost) Then
        '        TotalunitCost += TempUnitCost
        '    End If
        '    If Double.TryParse(TempNode.SubItems.Item(8).Text, TempVATAmt) Then
        '        TotalVATAmt += TempVATAmt
        '    End If
        '    If Double.TryParse(TempNode.SubItems.Item(9).Text, TempGrandTotal) Then
        '        GrandTotal += TempGrandTotal
        '    End If
        '    If Double.TryParse(TempNode.SubItems.Item(10).Text, TempUnitPrice) Then
        '        TotalUnitPrice += TempUnitPrice
        '    End If
        '    TotalCount = TotalCount + 1
        'Next
        'IS_Inventory_Receiving.lbl_tot_unit.Text = Format(TotalunitCost, "###.##")
        'IS_Inventory_Receiving.lbl_totVatAmt.Text = Format(TotalVATAmt, "###.##")
        'IS_Inventory_Receiving.lbl_grandTotal.Text = Format(GrandTotal, "###.##")
        'IS_Inventory_Receiving.lbl_totUnitPrice.Text = Format(TotalUnitPrice, "###.##")
        'IS_Inventory_Receiving.lbl_count.Text = TotalCount
    End Sub

    Public Sub LViewEventOutgoing()
        'Dim TotalunitCost As Double = 0
        'Dim TotalVATAmt As Double = 0
        'Dim GrandTotal As Double = 0
        'Dim TotalUnitPrice As Double
        'Dim TotalCount As Double = 0

        'Dim TempNode As ListViewItem
        'Dim TempUnitCost, TempVATAmt, TempUnitPrice, TempGrandTotal As Double

        'For Each TempNode In IS_Inventory_Outgoing.LViewItems.Items
        '    If Double.TryParse(TempNode.SubItems.Item(8).Text, TempUnitCost) Then
        '        TotalunitCost += TempUnitCost
        '    End If
        '    If Double.TryParse(TempNode.SubItems.Item(9).Text, TempVATAmt) Then
        '        TotalVATAmt += TempVATAmt
        '    End If
        '    If Double.TryParse(TempNode.SubItems.Item(10).Text, TempGrandTotal) Then
        '        GrandTotal += TempGrandTotal
        '    End If
        '    If Double.TryParse(TempNode.SubItems.Item(11).Text, TempUnitPrice) Then
        '        TotalUnitPrice += TempUnitPrice
        '    End If
        '    TotalCount = TotalCount + 1
        'Next
        'IS_Inventory_Outgoing.lbl_tot_unit.Text = Format(TotalunitCost, "###.##")
        'IS_Inventory_Outgoing.lbl_totVatAmt.Text = Format(TotalVATAmt, "###.##")
        'IS_Inventory_Outgoing.lbl_grandTotal.Text = Format(GrandTotal, "###.##")
        'IS_Inventory_Outgoing.lbl_totUnitPrice.Text = Format(TotalUnitPrice, "###.##")
        'IS_Inventory_Outgoing.lbl_count.Text = TotalCount
    End Sub

    Public Sub MainMenuPermission()
        'ICSConnection.Open()
        'Dim select_cmd As New SqlClient.SqlCommand("SELECT * from users where username like '" & Login.UsernameTextBox.Text & "' and password like '" & Login.PasswordTextBox.Text & "' ", ICSConnection)
        'Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        'If Not rs.Read = False Then
        '    If rs.Item("IsApprover").ToString = "1" Then
        '        MainMenu.FORAPPROVALToolStripMenuItem.Enabled = True
        '        MainMenu.MCTool.Enabled = False
        '        MainMenu.SPTool.Enabled = False
        '        MainMenu.StatusLevel.Text = "Approver"
        '        'ICSConnection.Close()
        '    End If
        '    If rs.Item("IsReceptionist").ToString = "1" Then
        '        MainMenu.StatusLevel.Text = "Maker"
        '        'ICSConnection.Close()
        '    End If
        '    If rs.Item("IsBookkeeper").ToString = "1" Then
        '        MainMenu.Accountingtoolbar.Enabled = True
        '        'ICSConnection.Close()
        '    Else
        '        MainMenu.Accountingtoolbar.Enabled = False
        '    End If
        '    'Else
        '    MainMenu.FORAPPROVALToolStripMenuItem.Enabled = False
        '    MainMenu.RECEIVINGToolStripMenuItem.Enabled = True
        '    MainMenu.OUTGOINGToolStripMenuItem.Enabled = True
        '    MainMenu.toolIsAccounting.Enabled = False
        '    ICSConnection.Close()
        'End If
        'End If
        'rs.Close()
        'ICSConnection.Close()
    End Sub

    'Public Function newCheckConnection(ByVal SName As String, ByVal DBName As String, ByVal UName As String, ByVal Pass As String) As Boolean
    '    If sqlConn.State <> 0 Then
    '        sqlConn.Close()
    '        newCheckConnection = False
    '    End If

    '    sqlConn.ConnectionString = "Server=" & SName & ";" _
    '                             & "Database=" & DBName & ";" _
    '                             & "User Id=" & UName & ";" _
    '                             & "Password=" & Pass & ";"
    '    Try
    '        sqlConn.Open()
    '        newCheckConnection = True
    '    Catch ex As Exception
    '        newCheckConnection = False
    '    End Try
    'End Function

    'Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
    '    'Let's make sure entered value is numeric
    '    If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

    '    'I used this kind of approach using String instead of Double as datatype then I applied string manipulation
    '    'and remove the decimal value then store it in tempDecValue and re-attach it to nAmount upon entering the recursion
    '    'The reason is that I tried using the Double datatype but when it comes to quadrillion values and with decimal values
    '    'I noticed that the ones and tens values changed, or some errors encountered. I couldn't figure it out until I came up with this concept.

    '    'tempDecValue gets the decimal value from the original value nAmount
    '    'tempDecValue is added to the nAmount every time it enters the recursion
    '    Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then tempDecValue = nAmount.Substring(nAmount.IndexOf("."))

    '    'Removing the decimal value from nAmount
    '    nAmount = Replace(nAmount, tempDecValue, String.Empty)

    '    Try
    '        'Assigning the nAmount to intAmount having the LONG datatype
    '        Dim intAmount As Long = nAmount

    '        'Let's trap the values entered into the recursion; if greater than 0 then let's evaluate the numbers in set, otherwise,
    '        '(1) all numbers have already been evaluated and return the designated word values (for entered whole numbers); or
    '        '(2) evaluate last set, which is the decimal value
    '        'either which proceed to else statement and/or return the result
    '        If intAmount > 0 Then
    '            'Let's segregate the entered values into 3-digit sets of numbers and count it then store in the nSet
    '            'For example: 9223372036854775807 has 7 sets; start from right to left (807, 775, 854, 036...), until the last set which is 9
    '            nSet = IIf((intAmount.ToString.Trim.Length / 3) > (CLng(intAmount.ToString.Trim.Length / 3)), CLng(intAmount.ToString.Trim.Length / 3) + 1, CLng(intAmount.ToString.Trim.Length / 3))

    '            'eAmount gets each 3-digit set entered into the recursion
    '            'Though I said sets start from right to left, we start evaluating each set from left to right of the entered values.
    '            'For example: 9223372036854775807 (actual: 9,223,372,036,854,775,807), 9 (1st set to be evaluated), 223 (next set), 372 (next set),... and so on
    '            'and so forth until all are evaluated, including the decimal values, in case there exists
    '            'NOTE: 9 is in Quintillion range, 223 is in Quadrillion, 372 in Trillion, and so on and so forth
    '            Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim, (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))

    '            'Multiplier gets the 10 to the power of the nSet
    '            'This is needed to remove the evaluated set from the original values
    '            'For example: 1st set is 9 (the 1st value of eAmount) and there are 7 sets so:
    '            '10 ^ (((7 - 1) * 3)) is 1000000000000000000
    '            '9 multiplied by 1000000000000000000 is 9000000000000000000
    '            'remove 9000000000000000000 from 9223372036854775807 which results in 223372036854775807, the next value of nAmount within which the decimal value .75 shall be attached
    '            'the flow goes on and on until nAmount reaches zero, or the decimal value
    '            'so multiplier has a vital function as we go on and we shall see later
    '            Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

    '            'These are the worded values
    '            Dim Ones() As String = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"}
    '            Dim Teens() As String = {"", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
    '            Dim Tens() As String = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
    '            Dim HMBT() As String = {"", "", "Thousand", "Million", "Billion", "Trillion", "Quadrillion", "Quintillion"}

    '            'Let's reuse the intAmount object
    '            intAmount = eAmount

    '            'Remember, we have a 3-digit number in each set
    '            'from left to right is hundreds, tens, and ones
    '            'For example 9 is the ones in the first set for evaluation; the next set is 223 (1st 2 is hundreds, next 2 is tens, and 3 is ones)
    '            'These statements segregate the numbers in the set
    '            Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
    '            Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
    '            Dim nOne As Integer = intAmount \ 1

    '            'After the segregation, we now have to evaluate the retrieved numbers and put the corresponding words for each number
    '            If nHundred > 0 Then wAmount = wAmount & Ones(nHundred) & " Hundred " 'This is for hundreds
    '            If nTen > 0 Then 'This is for tens and teens
    '                'In case of teens, like 11 to 19, it will be trapped in here and proceed to the designated word
    '                If nTen = 1 And nOne > 0 Then 'This is for teens (number ten plus ones succeeding it) Example:
    '                    wAmount = wAmount & Teens(nOne) & " " '11 is Eleven, 12 is Twelve, 15 is Fifteen, 17 is Seventeen, and so on
    '                Else 'This is for tens, 10 to 90
    '                    wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ") 'If there is ones succeeding it, put a dash before the ones, example: Twenty-, Thirty-, Forty-, etc.
    '                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " " 'This is for ones (1-9) with the tens (20-90) preceeding it. Example: 21 is Twenty-One, 34 is Thirty-Four, 48 is Forty-Eight
    '                End If
    '            Else 'This is for ones, 1 to 9
    '                If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
    '            End If
    '            'Let's put in here the ranges (1st set(number 9) is Quintillion, next(number 223) is Quadrillion, next(372) is Trillion, ...so on and so forth)
    '            wAmount = wAmount & HMBT(nSet) & " "
    '            'Proceed to next set to evaluate by entering the same function we are in (recursion)
    '            wAmount = AmountInWords(CStr(CLng(nAmount) - (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
    '        Else 'When nAmount reaches 0, we proceed to this statement
    '            'If there is no decimal value then proceed to display the result
    '            'But if there is a decimal value then let's evaluate each number of the decimal value
    '            'First we re-attach the decimal value to its original value, the nAmount
    '            If Val(nAmount) = 0 Then nAmount = nAmount & tempDecValue : tempDecValue = String.Empty
    '            'Now, if we have decimal value, let's convert it into whole numbers (not rounding it off, but actually converting to whole numbers),
    '            'put it into the recursion for the last time, evaluate it, give the corresponding words and then finally, display the result
    '            If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100), wAmount.Trim & " Pesos And ", 1)) & " Cents"
    '        End If
    '    Catch ex As Exception
    '        'Should there be any error encountered, this will handle it.
    '        MessageBox.Show("Error Encountered: " & ex.Message, "Convert Numbers To Words", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Return "!#ERROR_ENCOUNTERED"
    '    End Try

    '    'Trap null values
    '    If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount = IIf(InStr(wAmount.Trim.ToLower, "pesos"), wAmount.Trim, wAmount.Trim & " Pesos")

    '    'Display the result
    '    Return wAmount
    'End Function

    'Friend Function NumberToWords(ByVal sNumber As String) As String
    '    Dim sNumberSet As String = Trim(sNumber)
    '    Dim sAmount As String() = sNumberSet.Split(New Char() {"."c})
    '    Dim sPesos = sAmount(0)
    '    Dim sCents = sAmount(1)

    '    If Convert.ToInt32(sCents) > 0 Then
    '        Return $"{NumberToText(Convert.ToInt32(sPesos))} Pesos and {NumberToText(Convert.ToInt32(sCents))} Cents Only"
    '    Else
    '        Return $"{NumberToText(Convert.ToInt32(sPesos))} Pesos Only"
    '    End If

    'End Function

    'Private Function NumberToText(ByVal n As Integer) As String
    '    Select Case n
    '        Case 0
    '            Return ""
    '        Case 1 To 19
    '            Dim arr() As String = {"One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
    '            Return $"{arr(n - 1)}"
    '        Case 20 To 99
    '            Dim arr() As String = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
    '            Return $"{arr(n \ 10 - 2)} {NumberToText(n Mod 10)}"
    '        Case 100 To 199
    '            Return $"One Hundred {NumberToText(n Mod 100)}"
    '        Case 200 To 999
    '            Return $"{NumberToText(n \ 100)} Hundred {NumberToText(n Mod 100)}"
    '        Case 1000 To 1999
    '            Return $"One Thousand {NumberToText(n Mod 1000)}"
    '        Case 2000 To 999999
    '            Return $"{NumberToText(n \ 1000)} Thousand {NumberToText(n Mod 1000)}"
    '        Case 1000000 To 1999999
    '            Return $"One Million {NumberToText(n Mod 1000000)}"
    '        Case 1000000 To 999999999
    '            Return $"{NumberToText(n \ 1000000)} Million {NumberToText(n Mod 1000000)}"
    '        Case 1000000000 To 1999999999
    '            Return $"One Billion {NumberToText(n Mod 1000000000)}"
    '        Case Else
    '            Return $"{NumberToText(n \ 1000000000)} Billion {NumberToText(n Mod 1000000000)}"
    '    End Select
    'End Function

End Module