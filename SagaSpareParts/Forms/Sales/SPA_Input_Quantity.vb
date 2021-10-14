Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_InputQuantity
    'Sub Find_Spare_Parts()
    '    Dim sqlParameters As SqlParameter() = {New SqlParameter("@ParamID", txt_ID.Text)}

    '    Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, "SPA_Find_PartsNumber")
    '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
    '            myDataReader.Read()
    '            txt_PartsNumber.Text = myDataReader("PartsNumber").ToString()
    '            txt_PartsName.Text = myDataReader("PartsName").ToString()
    '            txt_Quantity.Text = myDataReader("Quantity").ToString()
    '            txt_BrCode.Text = myDataReader("ReceivingBranch").ToString()
    '            If SPA_Sales.cmb_Pricing.Text = "1" Then
    '                txt_Price.Text = myDataReader("srp").ToString()
    '            ElseIf SPA_Sales.cmb_Pricing.Text = "2" Then
    '                txt_Price.Text = myDataReader("PriceWOVAT").ToString()
    '            ElseIf SPA_Sales.cmb_Pricing.Text = "3" Then
    '                txt_Price.Text = myDataReader("spCostWOVAT").ToString()
    '            ElseIf SPA_Sales.cmb_Pricing.Text = "4" Then
    '                txt_Price.Text = myDataReader("spCostWVAT").ToString()
    '            End If
    '            txt_ID.Text = myDataReader("ID").ToString()
    '        End If

    '        MsgBox(String.Format("{0} - {1}", Err.Number, Err.Description), vbCritical, Application.CompanyName)
    '    End Using
    'End Sub

    'Sub Find_Spare_Parts_Master()
    '    Dim sqlParameters As SqlParameter() = {New SqlParameter("@ParamID", txt_ID.Text)}

    '    Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, "SPA_Find_PartsNumber_Master")
    '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
    '            myDataReader.Read()
    '            txt_PartsNumber.Text = myDataReader("PartsNumber").ToString()
    '            txt_PartsName.Text = myDataReader("PartsName").ToString()
    '            txt_BrCode.Text = class_Saga_Variables.sBranchCode
    '            txt_Quantity1.Text = "1000"
    '            txt_Quantity.Text = "1000"
    '            If SPA_Sales.cmb_Pricing.Text = "1" Then
    '                txt_Price.Text = myDataReader("srp").ToString()
    '            ElseIf SPA_Sales.cmb_Pricing.Text = "2" Then
    '                txt_Price.Text = myDataReader("PriceWOVAT").ToString()
    '            ElseIf SPA_Sales.cmb_Pricing.Text = "3" Then
    '                txt_Price.Text = myDataReader("spCostWOVAT").ToString()
    '            ElseIf SPA_Sales.cmb_Pricing.Text = "4" Then
    '                txt_Price.Text = myDataReader("spCostWVAT").ToString()
    '            End If
    '            txt_ID.Text = myDataReader("ID").ToString()
    '        End If
    '    End Using
    'End Sub

    'Sub Total()
    '    If txt_Quantity.Text = String.Empty Then
    '        txt_Quantity.Text = "0"
    '    End If
    '    txt_SubTotal.Text = CStr(Val(txt_TotalAmount.Text) * Val(txt_Quantity1.Text))
    '    txt_TotalLess.Text = CStr(Val(txt_LessAmount.Text) * Val(txt_Quantity1.Text))
    '    txt_GrossTotal.Text = CStr(Val(txt_Price.Text) * Val(txt_Quantity1.Text))
    'End Sub

    'Sub Spare_Parts()
    '    If SPA_Sales.lv_Parts.Items.Count = 0 Then
    '        Dim lii As ListViewItem = SPA_Sales.lv_Parts.Items.Add(txt_BrCode.Text)
    '        lii.SubItems.Add(txt_Quantity1.Text)
    '        lii.SubItems.Add(txt_Unit.Text)
    '        lii.SubItems.Add(String.Format("{0} ({1})", txt_PartsNumber.Text, txt_PartsName.Text))
    '        lii.SubItems.Add(txt_Price.Text)
    '        lii.SubItems.Add(txt_GrossTotal.Text)
    '        lii.SubItems.Add(txt_TotalLess.Text)
    '        lii.SubItems.Add(txt_Discount.Text)
    '        lii.SubItems.Add(txt_TotalAmount.Text)
    '        lii.SubItems.Add(txt_SubTotal.Text)
    '        lii.SubItems.Add(txt_ID.Text)
    '        lii.SubItems.Add(txt_PartsNumber.Text)
    '        lii.SubItems.Add(txt_PartsName.Text)

    '        SPA_Sales.txt_partsNumber.Text = txt_PartsNumber.Text
    '        SPA_Sales.txt_partsName.Text = txt_PartsName.Text
    '        lii = Nothing
    '    Else
    '        With SPA_Sales.lv_Parts
    '            Dim itm As ListViewItem
    '            itm = .FindItemWithText(txt_ID.Text, True, 0, True)
    '            If Not itm Is Nothing Then
    '                MsgBox(String.Format("The PartsNumber ({0}) is already on the list.", txt_PartsNumber.Text), vbExclamation, Application.CompanyName)
    '            Else
    '                Dim lii As ListViewItem = SPA_Sales.lv_Parts.Items.Add(txt_BrCode.Text)
    '                lii.SubItems.Add(txt_Quantity1.Text)
    '                lii.SubItems.Add(txt_Unit.Text)
    '                lii.SubItems.Add(String.Format("{0} ({1})", txt_PartsNumber.Text, txt_PartsName.Text))
    '                lii.SubItems.Add(txt_Price.Text)
    '                lii.SubItems.Add(txt_GrossTotal.Text)
    '                lii.SubItems.Add(txt_TotalLess.Text)
    '                lii.SubItems.Add(txt_Discount.Text)
    '                lii.SubItems.Add(txt_TotalAmount.Text)
    '                lii.SubItems.Add(txt_SubTotal.Text)
    '                lii.SubItems.Add(txt_ID.Text)
    '                lii.SubItems.Add(txt_PartsNumber.Text)
    '                lii.SubItems.Add(txt_PartsName.Text)

    '                SPA_Sales.txt_partsNumber.Text = txt_PartsNumber.Text
    '                SPA_Sales.txt_partsName.Text = txt_PartsName.Text
    '                lii = Nothing
    '            End If

    '        End With

    '    End If
    'End Sub

    'Private Sub txt_Quantity1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Quantity1.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If txt_Quantity1.Text = "0" Then
    '            MsgBox("Zero(0) Quantity is not Allowed!", vbOKOnly, Application.CompanyName)
    '        Else
    '            ' Spare_Parts()

    '            If SPA_Sales.lv_Parts.Items.Count = 0 Then
    '                Dim lii As ListViewItem = SPA_Sales.lv_Parts.Items.Add(txt_BrCode.Text)
    '                lii.SubItems.Add(txt_Quantity1.Text)
    '                lii.SubItems.Add(txt_Unit.Text)
    '                lii.SubItems.Add(String.Format("{0} ({1})", txt_PartsNumber.Text, txt_PartsName.Text))
    '                lii.SubItems.Add(txt_Price.Text)
    '                lii.SubItems.Add(txt_GrossTotal.Text)
    '                lii.SubItems.Add(txt_TotalLess.Text)
    '                lii.SubItems.Add(txt_Discount.Text)
    '                lii.SubItems.Add(txt_TotalAmount.Text)
    '                lii.SubItems.Add(txt_SubTotal.Text)
    '                lii.SubItems.Add(txt_ID.Text)
    '                lii.SubItems.Add(txt_PartsNumber.Text)
    '                lii.SubItems.Add(txt_PartsName.Text)

    '                SPA_Sales.txt_partsNumber.Text = txt_PartsNumber.Text
    '                SPA_Sales.txt_partsName.Text = txt_PartsName.Text
    '                lii = Nothing
    '            Else
    '                With SPA_Sales.lv_Parts
    '                    Dim itm As ListViewItem
    '                    itm = .FindItemWithText(txt_ID.Text, True, 0, True)
    '                    If Not itm Is Nothing Then
    '                        MsgBox(String.Format("The PartsNumber ({0}) is already on the list.", txt_PartsNumber.Text), vbExclamation, Application.CompanyName)
    '                    Else
    '                        Dim lii As ListViewItem = SPA_Sales.lv_Parts.Items.Add(txt_BrCode.Text)
    '                        lii.SubItems.Add(txt_Quantity1.Text)
    '                        lii.SubItems.Add(txt_Unit.Text)
    '                        lii.SubItems.Add(String.Format("{0} ({1})", txt_PartsNumber.Text, txt_PartsName.Text))
    '                        lii.SubItems.Add(txt_Price.Text)
    '                        lii.SubItems.Add(txt_GrossTotal.Text)
    '                        lii.SubItems.Add(txt_TotalLess.Text)
    '                        lii.SubItems.Add(txt_Discount.Text)
    '                        lii.SubItems.Add(txt_TotalAmount.Text)
    '                        lii.SubItems.Add(txt_SubTotal.Text)
    '                        lii.SubItems.Add(txt_ID.Text)
    '                        lii.SubItems.Add(txt_PartsNumber.Text)
    '                        lii.SubItems.Add(txt_PartsName.Text)

    '                        SPA_Sales.txt_partsNumber.Text = txt_PartsNumber.Text
    '                        SPA_Sales.txt_partsName.Text = txt_PartsName.Text
    '                        lii = Nothing
    '                    End If

    '                End With

    '            End If

    '            Total()
    '            Me.Close()
    '            SPA_Search_Sales.Close()
    '            SPA_Sales.LV_PARTS_Total()
    '        End If
    '    End If
    'End Sub

    'Private Sub txt_Quantity1_TextChanged(sender As Object, e As EventArgs) Handles txt_Quantity1.TextChanged
    '    Total()
    'End Sub

    'Private Sub txt_ID_TextChanged(sender As Object, e As EventArgs) Handles txt_ID.TextChanged
    '    Find_Spare_Parts()
    'End Sub

    'Private Sub txt_Discount_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Discount.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txt_TotalPercent.Text = CStr(Val(txt_Discount.Text) / Val(txt_Percent.Text))
    '        txt_LessAmount.Text = CStr(Val(txt_TotalPercent.Text) * Val(txt_Price.Text))
    '        txt_TotalAmount.Text = CStr(Val(txt_Price.Text) - Val(txt_LessAmount.Text))
    '        txt_TotalAmount.Enabled = True
    '        txt_TotalAmount.Focus.Equals(True)
    '        Total()
    '    End If
    'End Sub

    'Private Sub txt_TotalAmount_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_TotalAmount.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        txt_Quantity1.Enabled = True
    '        txt_Quantity1.Focus.Equals(True)
    '        txt_SubTotal.Text = CStr(Val(txt_TotalAmount.Text) * Val(txt_Quantity1.Text))
    '    End If
    'End Sub

    'Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    '    Me.Close()
    'End Sub

    'Private Sub txt_LessAmount_TextChanged(sender As Object, e As EventArgs) Handles txt_LessAmount.TextChanged
    '    txt_TotalAmount.Text = CStr(Val(txt_Price.Text) - Val(txt_LessAmount.Text))
    '    Total()
    'End Sub

    'Private Sub txt_TotalAmount_TextChanged(sender As Object, e As EventArgs) Handles txt_TotalAmount.TextChanged
    '    txt_SubTotal.Text = CStr(Val(txt_TotalAmount.Text) * Val(txt_Quantity1.Text))
    'End Sub

End Class