Namespace Classes

    Public Class DateDifference
        Private ReadOnly monthDay As Integer() = New Integer(11) {31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        Private ReadOnly fromDate As DateTime
        Private ReadOnly toDate As DateTime

        Public Sub New(ByVal d1 As DateTime, ByVal d2 As DateTime)
            Dim increment As Integer

            If d1 > d2 Then
                fromDate = d2
                toDate = d1
            Else
                fromDate = d1
                toDate = d2
            End If

            increment = 0

            If fromDate.Day > toDate.Day Then
                increment = Me.monthDay(fromDate.Month - 1)
            End If

            If increment = -1 Then

                If DateTime.IsLeapYear(fromDate.Year) Then
                    increment = 29
                Else
                    increment = 28
                End If
            End If

            If increment <> 0 Then
                Days = (toDate.Day + increment) - fromDate.Day
                increment = 1
            Else
                Days = toDate.Day - fromDate.Day
            End If

            If (fromDate.Month + increment) > toDate.Month Then
                Me.Months = (toDate.Month + 12) - (fromDate.Month + increment)
                increment = 1
            Else
                Me.Months = (toDate.Month) - (fromDate.Month + increment)
                increment = 0
            End If

            Me.Years = toDate.Year - (fromDate.Year + increment)
        End Sub

        Public Overrides Function ToString() As String
            Return $"{Me.Years} Year(s), {Me.Months} month(s), {Me.Days} day(s)"
        End Function

        Public ReadOnly Property Years As Integer

        Public ReadOnly Property Months As Integer

        Public ReadOnly Property Days As Integer
    End Class

End Namespace