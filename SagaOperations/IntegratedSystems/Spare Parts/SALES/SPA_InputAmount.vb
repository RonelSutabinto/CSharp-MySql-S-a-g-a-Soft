Public Class SPA_InputAmount
    Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click
        If txt_Type.EditValue = "SALES" Then
            SPA_Sales.lbl_Total.Text = txt_AmountDue.Text
            SPA_Sales.lbl_AmountPaid.Text = Math.Round(Val(txt_AmountPaid.Text), 2)
            SPA_Sales.lbl_Tendered.Text = Math.Round(Val(txt_TenderedFix.Text), 2)
            SPA_Sales.lbl_Change.Text = txt_ChangeDue.Text
            Me.Close()
        ElseIf txt_Type.EditValue = "INQUIRY" Then
            SPA_Sales_Inquiry.lbl_Total.Text = txt_AmountDue.Text
            SPA_Sales_Inquiry.lbl_AmountPaid.Text = Math.Round(Val(txt_AmountPaid.Text), 2)
            SPA_Sales_Inquiry.lbl_Tendered.Text = Math.Round(Val(txt_TenderedFix.Text), 2)
            SPA_Sales_Inquiry.lbl_Change.Text = txt_ChangeDue.Text
            Me.Close()
        End If
    End Sub

    Sub Total()
        If txt_Tendered.EditValue.Equals(0) Then
            txt_Tendered.EditValue = 0.00
        End If
        txt_ChangeDue.EditValue = Math.Round(Val(txt_TenderedFix.EditValue) - Val(txt_AmountDue.EditValue), 2)
        If Val(txt_AmountDue.EditValue) <= Val(txt_TenderedFix.EditValue) Then
            txt_AmountPaid.EditValue = Math.Round(Val(txt_AmountDue.EditValue), 2)
        Else
            txt_AmountPaid.EditValue = Math.Round(Val(txt_TenderedFix.EditValue), 2)
        End If

        If txt_ChangeDue.EditValue < 0 Then
            txt_ChangeDue.EditValue = 0.00
        End If

    End Sub

    Private Sub txt_Tendered_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Tendered.EditValueChanged
        'Total()
        txt_TenderedFix.EditValue = Math.Round(Val(txt_Tendered.EditValue) + Val(lbl_CustDepAmount.Text), 2)
    End Sub

    Private Sub txt_Tendered_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Tendered.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_Type.EditValue = "SALES" Then
                SPA_Sales.lbl_Total.Text = txt_AmountDue.Text
                SPA_Sales.lbl_AmountPaid.Text = Math.Round(Val(txt_AmountPaid.Text), 2)
                SPA_Sales.lbl_Tendered.Text = Math.Round(Val(txt_TenderedFix.Text), 2)
                SPA_Sales.lbl_Change.Text = txt_ChangeDue.Text
                Me.Close()
            ElseIf txt_Type.EditValue = "INQUIRY" Then
                SPA_Sales_Inquiry.lbl_Total.Text = txt_AmountDue.Text
                SPA_Sales_Inquiry.lbl_AmountPaid.Text = Math.Round(Val(txt_AmountPaid.Text), 2)
                SPA_Sales_Inquiry.lbl_Tendered.Text = Math.Round(Val(txt_TenderedFix.Text), 2)
                SPA_Sales_Inquiry.lbl_Change.Text = txt_ChangeDue.Text
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txt_TenderedFix_EditValueChanged(sender As Object, e As EventArgs) Handles txt_TenderedFix.EditValueChanged
        Total()
    End Sub

    Private Sub SPA_InputAmount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lbl_CustDepAmount.Text = "0" Then
            txt_Tendered.EditValue = lbl_CustDepAmount.Text
        End If
    End Sub

End Class