Imports MyClassLibrary.Classes

Public Class SPA_InputAmount
    'Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click
    '    If txt_Type.EditValue.Equals("SALES") Then
    '        SPA_Sales.lbl_AmountPaid.Text = CStr(Math.Round(Val(txt_AmountPaid.Text), 2))
    '        SPA_Sales.lbl_Tendered.Text = CStr(Math.Round(Val(txt_Tendered.Text), 2))
    '        SPA_Sales.lbl_Change.Text = txt_ChangeDue.Text
    '        Me.Close()
    '    ElseIf txt_Type.EditValue.Equals("INQUIRY") Then
    '        SPA_Sales_Inquiry.lbl_Total.Text = txt_AmountDue.Text
    '        SPA_Sales_Inquiry.lbl_AmountPaid.Text.Equals(CStr(Math.Round(Val(txt_AmountPaid.Text), 2)))
    '        SPA_Sales_Inquiry.lbl_Tendered.Text.Equals(CStr(Math.Round(Val(txt_Tendered.Text), 2)))
    '        SPA_Sales_Inquiry.lbl_Change.Text = txt_ChangeDue.Text
    '        Me.Close()
    '    End If
    'End Sub

    Sub Total()
        If txt_Tendered.EditValue.Equals(0) Then
            txt_Tendered.EditValue = 0.00
        End If
        txt_ChangeDue.EditValue = Math.Round(Val(txt_Tendered.EditValue), 2) - Math.Round(Val(txt_AmountDue.EditValue), 2)
        If Val(txt_AmountDue.EditValue) <= Val(txt_Tendered.EditValue) Then
            txt_AmountPaid.EditValue = Math.Round(Val(txt_AmountDue.EditValue), 2)
        Else
            txt_AmountPaid.EditValue = Math.Round(Val(txt_Tendered.EditValue), 2)
        End If

        If Convert.ToDecimal(txt_ChangeDue.EditValue) < 0 Then
            txt_ChangeDue.EditValue = 0.00
        End If

    End Sub

    Private Sub txt_Tendered_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Tendered.EditValueChanged
        Total()
    End Sub

    Private Sub txt_Tendered_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Tendered.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then

            Try
                If txt_Type.EditValue.Equals("SALES") Then
                    Dim dAmountPaid, dTendered, dChange As Double
                    dAmountPaid = Math.Round(Val(txt_AmountPaid.Text), 2)
                    dTendered = Math.Round(Val(txt_Tendered.Text), 2)
                    dChange = Math.Round(Val(txt_ChangeDue.Text), 2)

                    SPA_Sales.lbl_AmountPaid.Text = CStr(dAmountPaid)
                    SPA_Sales.lbl_Tendered.Text = CStr(dTendered)
                    SPA_Sales.lbl_Change.Text = CStr(dChange)

                ElseIf txt_Type.EditValue.Equals("INQUIRY") Then
                    SPA_Sales_Inquiry.lbl_Total.Text = txt_AmountDue.Text
                    SPA_Sales_Inquiry.lbl_AmountPaid.Text = CStr(Math.Round(Val(txt_AmountPaid.Text), 2))
                    SPA_Sales_Inquiry.lbl_Tendered.Text = CStr(Math.Round(Val(txt_Tendered.Text), 2))
                    SPA_Sales_Inquiry.lbl_Change.Text = txt_ChangeDue.Text
                End If
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
            Me.Close()
        End If
    End Sub

End Class