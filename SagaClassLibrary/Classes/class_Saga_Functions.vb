Imports MyClassLibrary.Classes

Namespace Classes
    Public Module class_Saga_Functions
        Public Function Approver() As String
            Return class_Tools.RegKeyGet("Printing Details", "Approved By", String.Empty)
        End Function

        Public Function Journal_Pre_Code(ByVal sJournalType As String) As String
            If sJournalType.Contains("VOUCHER") Then
                Return "VOUCHER"
            Else
                Return "JOURNAL"
            End If
        End Function

        Public Function New_Journal_Reference() As String
            Dim sPreCode As String
            If Date.Today.Year >= 2020 Then
                If class_Saga_Variables.sCorporation.Equals("SFC") Then
                    sPreCode = $"JVF{class_Saga_Variables.dtStart.Year}{class_Saga_Variables.dtStart.ToString("MM")}-"
                Else
                    sPreCode = $"JVM{class_Saga_Variables.dtStart.Year}{class_Saga_Variables.dtStart.ToString("MM")}-"
                End If
            Else
                If class_Saga_Variables.sCorporation.Equals("SFC") Then
                    sPreCode = $"JVF{class_Saga_Variables.dtStart.ToString("MM")}-"
                Else
                    sPreCode = $"JVM{class_Saga_Variables.dtStart.ToString("MM")}-"
                End If
            End If

            Return $"{class_Database.Get_Last_ID(class_Database.ICSConnection, "acc_Journal_Entries", "Journal_Reference", sPreCode, sPreCode.Length, " AND IsDeleted <> 1")}"
        End Function

        Public Function Set_Brand_COA(ByVal sBrand As String, ByVal sCode As String) As String
            If sBrand.Contains("HONDA") Then Return $"{sCode}1"
            If sBrand.Contains("YAMAHA") Then Return $"{sCode}2"
            If sBrand.Contains("KAWASAKI") Then Return $"{sCode}3"
            If sBrand.Contains("SUZUKI") Then Return $"{sCode}4"
            If sBrand.Contains("APPARELS") Then Return $"1031501"
            Return "0"
        End Function

        Public Function Set_Output_VAT(ByVal sCorp As String, ByVal sBrCode As String) As String
            If sCorp.Equals("SFC") Then
                Return "20905"
            Else
                Return $"20915{sBrCode.Substring(1)}"
            End If
        End Function

        'Public Function Set_Balance_Type(ByVal toggleSwitch As DevExpress.XtraEditors.ToggleSwitch) As String
        '    If toggleSwitch.IsOn Then
        '        Return toggleSwitch.Properties.OnText.ToUpper
        '    Else
        '        Return toggleSwitch.Properties.OffText.ToUpper
        '    End If
        'End Function

        Public Function IsEqualSummary(ByVal colDebit As DevExpress.XtraGrid.Columns.GridColumn, ByVal colCredit As DevExpress.XtraGrid.Columns.GridColumn) As Boolean
            Dim dSumDebit As Decimal = Math.Round(Convert.ToDecimal(colDebit.SummaryItem.SummaryValue), 2)
            Dim dSumCredit As Decimal = Math.Round(Convert.ToDecimal(colCredit.SummaryItem.SummaryValue), 2)

            Return dSumDebit.Equals(dSumCredit)
        End Function

    End Module
End Namespace