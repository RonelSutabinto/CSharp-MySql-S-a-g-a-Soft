Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns

Namespace Modules
    Module Module_Functions

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

        Public Function calculate_VAT(ByVal dAmount As Decimal) As Decimal
            Return Math.Round((dAmount / CDec(1.12)) * CDec(0.12), 2)
        End Function

        Public Function calculate_no_VAT(ByVal dAmount As Decimal) As Decimal
            Return Math.Round(dAmount - ((dAmount / CDec(1.12)) * CDec(0.12)), 2)
        End Function

        Private Sub Args_Showing(sender As Object, e As XtraMessageShowingArgs)

        End Sub

        Public Function Show_Input_Box(ByVal sPrompt As String, ByVal sCaption As String, ByVal dDefaultResponse As String) As String
            Dim sResult As String
            Dim args As New XtraInputBoxArgs()
            AddHandler args.Showing, AddressOf Args_Showing

            args.Caption = sCaption
            args.Prompt = sPrompt
            args.DefaultButtonIndex = 0
            args.DefaultResponse = dDefaultResponse
            Try
                sResult = XtraInputBox.Show(args).ToString
            Catch Ex As NullReferenceException
                sResult = String.Empty
            End Try
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

        Public Function GridView_Loop(ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal iRowHandle As Integer, ByVal sTitle As String, ByVal sAction As String, ByVal bLoopStop As Boolean, Optional ByVal bLoopLive As Boolean = True, Optional ByVal bSelectAll As Boolean = False) As Boolean
            With gridView
                If bLoopLive Then
                    If Not bSelectAll Then .UnselectRow(iRowHandle - 1)
                    .FocusedRowHandle = iRowHandle
                    .MakeRowVisible(iRowHandle)
                    If Not bSelectAll Then .SelectRow(iRowHandle)
                    Application.DoEvents()
                End If

                If bLoopStop Then
                    Modules.Loop_Stop_Message(sTitle, sAction)
                    Return False
                End If
            End With
            Return True
        End Function

        Friend Function IsEqualSummary(ByVal colDebit As GridColumn, ByVal colCredit As GridColumn) As Boolean
            Dim dSumDebit As Decimal = Math.Round(CDec(colDebit.SummaryItem.SummaryValue), 2)
            Dim dSumCredit As Decimal = Math.Round(CDec(colCredit.SummaryItem.SummaryValue), 2)

            Return dSumDebit.Equals(dSumCredit)
        End Function
    End Module
End Namespace