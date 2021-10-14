Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Spare_Parts_Add

    Sub Find_Spare_Parts()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamPartsNumber", txt_PartsNumber.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_Master")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_ID.Text = myDataReader("id").ToString()
                txt_PartsNumber.Text = myDataReader("PartsNumber").ToString()
                txt_PartsName.Text = myDataReader("PartsName").ToString()
                txt_Brand.Text = myDataReader("Brand").ToString()
                txt_ModelCode.Text = myDataReader("ModelCode").ToString()
                txt_ModelName.Text = myDataReader("ModelName").ToString()
                txt_Note.Text = myDataReader("Note").ToString()
                txt_Remarks.Text = myDataReader("Remarks").ToString()
                txt_SRP12.Text = myDataReader("SRP").ToString()
                txt_Quantity.Text = myDataReader("Quantity").ToString()
            End If
        End Using
    End Sub

    Private Sub Spare_Parts_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPA_ShowCategory()
    End Sub

    Sub Total()
        If txt_Quantity.Text = String.Empty Then
            txt_Quantity.Text = "0"
        End If
        txt_Total.Text = Math.Round(Decimal.Parse(txt_CostWVAT.Text) * Decimal.Parse(txt_Quantity.Text), 2)
    End Sub

    Sub Total1()
        If txt_Quantity.Text = String.Empty Then
            txt_Quantity.Text = "0"
        End If
        txt_Total.Text = Math.Round(Decimal.Parse(txt_SRP.Text) * Decimal.Parse(txt_Quantity.Text), 2)
    End Sub

    Sub Total2()
        If txt_Quantity.Text = String.Empty Then
            txt_Quantity.Text = "0"
        End If
        txt_Total.Text = Math.Round(Decimal.Parse(txt_CostWoVAT.Text) * Decimal.Parse(txt_Quantity.Text), 2)
    End Sub

    Sub ForParts()
        lbl_Total.Text = Math.Round(Decimal.Parse(txt_CostWoVAT.Text) * Decimal.Parse(txt_Quantity.Text), 2)
    End Sub

    Private Sub txt_SRP_TextChanged(sender As Object, e As EventArgs) Handles txt_SRP.TextChanged
        If Not IsNumeric(Me.txt_SRP.Text) Then
            Me.ErrorProvider1.SetError(Me.txt_SRP, "Please enter a number.")
            Return
        Else
            Me.ErrorProvider1.SetError(Me.txt_SRP, String.Empty)
        End If
    End Sub

    Private Sub txt_DiscountPCT_TextChanged(sender As Object, e As EventArgs) Handles txt_DiscountPCT.TextChanged
        If Not IsNumeric(Me.txt_DiscountPCT.Text) Then
            Me.ErrorProvider1.SetError(Me.txt_DiscountPCT, "Please enter a number.")
            Return
        Else
            Me.ErrorProvider1.SetError(Me.txt_DiscountPCT, String.Empty)

            lbl_Less.Text = "0." + txt_DiscountPCT.Text
        End If
    End Sub

    Private Sub txt_DiscountAMT_TextChanged(sender As Object, e As EventArgs) Handles txt_DiscountAMT.TextChanged
        If Not IsNumeric(Me.txt_DiscountAMT.Text) Then
            Me.ErrorProvider1.SetError(Me.txt_DiscountAMT, "Please enter a number.")
            Return
        Else
            Me.ErrorProvider1.SetError(Me.txt_DiscountAMT, String.Empty)
        End If
    End Sub

    Private Sub txt_PriceWVAT_TextChanged(sender As Object, e As EventArgs) Handles txt_PriceWVAT.TextChanged
        If Not IsNumeric(Me.txt_PriceWVAT.Text) Then
            Me.ErrorProvider1.SetError(Me.txt_PriceWVAT, "Please enter a number.")
            Return
        Else
            Me.ErrorProvider1.SetError(Me.txt_PriceWVAT, String.Empty)
        End If
    End Sub

    Private Sub txt_PriceWoVAT_TextChanged(sender As Object, e As EventArgs) Handles txt_PriceWoVAT.TextChanged
        If Not IsNumeric(Me.txt_PriceWoVAT.Text) Then
            Me.ErrorProvider1.SetError(Me.txt_PriceWoVAT, "Please enter a number.")
            Return
        Else
            Me.ErrorProvider1.SetError(Me.txt_PriceWoVAT, String.Empty)
        End If
    End Sub

    Private Sub txt_CostWVAT_TextChanged(sender As Object, e As EventArgs) Handles txt_CostWVAT.TextChanged
        If SPA_Receiving.txt_Vendor.Text = "KAWASAKI MOTORS PHIL." Then
            txt_DiscountAMT.Text = Math.Round(Val(txt_SRP.Text) * Val(lbl_Less.Text), 2)
            txt_CostWVAT.Text = Math.Round(Val(txt_SRP.Text) - Val(txt_DiscountAMT.Text), 2)
        Else
            txt_DiscountAMT.Text = Math.Round(Val(txt_CostWVAT.Text) * Val(lbl_Less.Text), 2)
        End If
        If Not IsNumeric(Me.txt_CostWVAT.Text) Then
            Me.ErrorProvider1.SetError(Me.txt_CostWVAT, "Please enter a number.")
            Return
        Else
            Me.ErrorProvider1.SetError(Me.txt_CostWVAT, String.Empty)
        End If
    End Sub

    Private Sub txt_CostWoVAT_TextChanged(sender As Object, e As EventArgs) Handles txt_CostWoVAT.TextChanged
        If Not IsNumeric(Me.txt_CostWoVAT.Text) Then
            Me.ErrorProvider1.SetError(Me.txt_CostWoVAT, "Please enter a number.")
            Return
        Else
            Me.ErrorProvider1.SetError(Me.txt_CostWoVAT, String.Empty)
        End If
    End Sub

    Private Sub txt_Total_TextChanged(sender As Object, e As EventArgs) Handles txt_Total.TextChanged
        If Not IsNumeric(Me.txt_Total.Text) Then
            Me.ErrorProvider1.SetError(Me.txt_Total, "Please enter a number.")
            Return
        Else
            Me.ErrorProvider1.SetError(Me.txt_Total, String.Empty)
        End If
    End Sub

    Private Sub txt_Quantity_TextChanged(sender As Object, e As EventArgs) Handles txt_Quantity.TextChanged
        If SPA_Receiving.txt_Vendor.Text = "KAWASAKI MOTORS PHIL." Then
            Total1()
        ElseIf SPA_Receiving.txt_Vendor.Text = "HONDA PHILIPPINES" Then
            Total()
        ElseIf SPA_Receiving.txt_Vendor.Text = "SUZUKI PHILIPPINES" Then
            Total()
        ElseIf SPA_Receiving.txt_Vendor.Text = "YAMAHA MOTORS INC." Then
            Total()
        Else
            Total2()
        End If
        ForParts()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If txt_Quantity.Text = "0" Then
            MsgBox("Zero(0) Quantity is not Allowed!", vbOKOnly, Application.CompanyName)
        Else
            Dim lii As ListViewItem = SPA_Receiving.lvParts.Items.Add(txt_PartsNumber.Text)
            lii.SubItems.Add(txt_PartsName.Text)
            lii.SubItems.Add(txt_Brand.Text)
            lii.SubItems.Add(txt_SC_SpareParts.Text)
            lii.SubItems.Add(txt_SRP.Text)
            lii.SubItems.Add(txt_Quantity.Text)
            lii.SubItems.Add(txt_CostWVAT.Text)
            lii.SubItems.Add(txt_CostWoVAT.Text)
            lii.SubItems.Add(txt_DiscountPCT.Text)
            lii.SubItems.Add(txt_DiscountAMT.Text)
            lii.SubItems.Add(txt_PriceWVAT.Text)
            lii.SubItems.Add(txt_PriceWoVAT.Text)
            lii.SubItems.Add(txt_ModelCode.Text)
            lii.SubItems.Add(txt_ModelName.Text)
            lii.SubItems.Add(txt_Total.Text)
            lii.SubItems.Add(cmb_Category.Text)
            lii.SubItems.Add(txt_BinBox.Text)

            SPA_Receiving.lbl_Count.Text = SPA_Receiving.lvParts.Items.Count
            ClearTxt()
            SPA_Receiving.TotalParts()
            SPA_Receiving.LV_PARTS_Total()

            Me.Close()
        End If
    End Sub

    Private Sub txt_CostWVAT_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CostWVAT.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_CostWoVAT.Text = Math.Round(Val(txt_CostWVAT.Text) / Val(lbl_VAT.Text), 2)
            txt_CostWoVAT.Focus.Equals(True)
        End If
    End Sub

    Private Sub txt_CostWoVAT_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CostWoVAT.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_CostWVAT.Text = Math.Round(Val(txt_CostWoVAT.Text) * Val(lbl_VAT.Text), 2)
            txt_Quantity.Focus.Equals(True)
        End If
    End Sub

    Private Sub txt_DiscountPCT_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_DiscountPCT.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_SRP.Enabled = True
            txt_DiscountPCT.Enabled = True
            txt_SRP.Focus.Equals(True)
        End If
    End Sub

    Private Sub txt_SRP_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SRP.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_CostWVAT.Focus.Equals(True)
        End If
    End Sub

    Sub ClearTxt()
        txt_CostWVAT.Text = "0.00"
        txt_CostWoVAT.Text = "0.00"
        txt_DiscountPCT.Text = "0"
        txt_DiscountAMT.Text = "0.00"
        txt_PriceWVAT.Text = "0.00"
        txt_PriceWoVAT.Text = "0.00"
        txt_SRP.Text = "0.00"
        txt_Quantity.Text = "0"
        txt_Total.Text = "0.00"
    End Sub

    Private Sub txt_SRP1_TextChanged(sender As Object, e As EventArgs) Handles txt_SRP12.TextChanged
        txt_SRP.Text = Math.Round(Val(txt_SRP12.Text), 2)
    End Sub

    Private Sub txt_PartsNumber_TextChanged(sender As Object, e As EventArgs) Handles txt_PartsNumber.TextChanged
        Find_Spare_Parts()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Sub SPA_ShowCategory()
        cmb_Category.Items.Clear()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamMnemonic", lbl_Category.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_ShowCategory")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                cmb_Category.Items.Add(myDataReader.Item("Category_Description").ToString)
            End If
        End Using
    End Sub

    Private Sub txt_Quantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Quantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_Quantity.Text = "0" Then
                MsgBox("Zero(0) Quantity is not Allowed!", vbOKOnly, Application.CompanyName)
            Else
                Dim lii As ListViewItem = SPA_Receiving.lvParts.Items.Add(txt_PartsNumber.Text)
                lii.SubItems.Add(txt_PartsName.Text)
                lii.SubItems.Add(txt_Brand.Text)
                lii.SubItems.Add(txt_SC_SpareParts.Text)
                lii.SubItems.Add(txt_SRP.Text)
                lii.SubItems.Add(txt_Quantity.Text)
                lii.SubItems.Add(txt_CostWVAT.Text)
                lii.SubItems.Add(txt_CostWoVAT.Text)
                lii.SubItems.Add(txt_DiscountPCT.Text)
                lii.SubItems.Add(txt_DiscountAMT.Text)
                lii.SubItems.Add(txt_PriceWVAT.Text)
                lii.SubItems.Add(txt_PriceWoVAT.Text)
                lii.SubItems.Add(txt_ModelCode.Text)
                lii.SubItems.Add(txt_ModelName.Text)
                lii.SubItems.Add(txt_Total.Text)
                lii.SubItems.Add(cmb_Category.Text)
                lii.SubItems.Add(txt_BinBox.Text)

                SPA_Receiving.lbl_Count.Text = SPA_Receiving.lvParts.Items.Count
                ClearTxt()
                SPA_Receiving.TotalParts()
                SPA_Receiving.LV_PARTS_Total()

                Me.Close()
            End If
        End If
    End Sub

End Class