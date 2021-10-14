Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Add_Outgoing
    Sub Find_Spare_Parts()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamPartsNumber", txt_PartsNumber.Text),
            New SqlParameter("@ParamID", txt_ID.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.spaSQLConnection, Parameters, "SPA_WH_Inventory")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                txt_ID.Text = myDataReader("id").ToString()
                txt_PartsNumber.Text = myDataReader("PartsNumber").ToString()
                txt_SC_SpareParts.Text = myDataReader("SC_SpareParts").ToString()
                txt_PartsName.Text = myDataReader("PartsName").ToString()
                txt_Brand.Text = myDataReader("Brand").ToString()
                txt_ModelCode.Text = myDataReader("ModelCode").ToString()
                txt_ModelName.Text = myDataReader("ModelName").ToString()
                txt_Note.Text = myDataReader("Note").ToString()
                txt_Remarks.Text = myDataReader("Remarks").ToString()
                txt_SRP.Text = myDataReader("SRP").ToString()
                txt_DiscountPCT.Text = myDataReader("DiscountPCT").ToString()
                txt_DiscountAMT.Text = myDataReader("DiscountAMT").ToString()
                txt_PriceWVAT.Text = myDataReader("PriceWVAT").ToString()
                txt_PriceWoVAT.Text = myDataReader("PriceWOVAT").ToString()
                txt_Quantity.Text = myDataReader("Quantity").ToString()
                lbl_Quantity1.Text = myDataReader("Quantity").ToString()
                txt_CostWVAT.Text = myDataReader("SPCostWVAT").ToString()
                txt_CostWoVAT.Text = myDataReader("SPCostWOVAT").ToString()
                txt_Category.Text = myDataReader("Category").ToString()
                txt_BinBox.Text = myDataReader("BinBox").ToString()
            End If
        End Using
    End Sub

    Sub Total()
        If txt_Quantity.Text = String.Empty Then
            txt_Quantity.Text = "0"
        End If
        txt_Total.Text = Val(txt_CostWoVAT.Text) * Val(txt_Quantity.Text)
    End Sub

    Sub ForParts()
        lbl_Total.Text = Math.Round(Decimal.Parse(txt_CostWoVAT.Text) * Decimal.Parse(txt_Quantity.Text), 2)
    End Sub

    Private Sub txt_Quantity_TextChanged(sender As Object, e As EventArgs) Handles txt_Quantity.TextChanged
        Total()
        Label22.Text = Val(lbl_Quantity1.Text) - Val(txt_Quantity.Text)
        ForParts()
    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        If txt_Quantity.Text = "0" Then
            MsgBox("Zero(0) Quantity is not Allowed!", vbOKOnly, Application.CompanyName)
        ElseIf Val(txt_Quantity.Text) > Val(lbl_Quantity1.Text) Then
            MsgBox("Higher Quantity is not Allowed!", vbOKOnly, Application.CompanyName)
        Else
            If SPA_Outgoing.lvParts.Items.Count = 0 Then
                Dim lii As ListViewItem = SPA_Outgoing.lvParts.Items.Add(txt_PartsNumber.Text)
                lii.SubItems.Add(txt_PartsName.Text)
                lii.SubItems.Add(txt_Brand.Text)
                lii.SubItems.Add(txt_SC_SpareParts.Text)
                lii.SubItems.Add(txt_SRP.Text)
                lii.SubItems.Add(txt_Quantity.Text)
                lii.SubItems.Add(txt_CostWoVAT.Text)
                lii.SubItems.Add(txt_CostWVAT.Text)
                lii.SubItems.Add(txt_DiscountPCT.Text)
                lii.SubItems.Add(txt_DiscountAMT.Text)
                lii.SubItems.Add(txt_PriceWVAT.Text)
                lii.SubItems.Add(txt_PriceWoVAT.Text)
                lii.SubItems.Add(txt_ModelCode.Text)
                lii.SubItems.Add(txt_ModelName.Text)
                lii.SubItems.Add(Label22.Text)
                lii.SubItems.Add(MainMenu.App_User_Name.Caption)
                lii.SubItems.Add(txt_ID.Text)
                lii.SubItems.Add(txt_Total.Text)
                lii.SubItems.Add(txt_Category.Text)
                lii.SubItems.Add(txt_BinBox.Text)

                SPA_Outgoing.lbl_Count.Text = SPA_Outgoing.lvParts.Items.Count
                SPA_Outgoing.TotalParts()
                ClearTxt()
                Me.Close()
                lii = Nothing
            Else
                With SPA_Outgoing.lvParts
                    Dim itm As ListViewItem
                    itm = .FindItemWithText(txt_ID.Text, True, 0, True)
                    If Not itm Is Nothing Then
                        MsgBox(String.Format("The PartsNumber ({0}) is already on the list.", txt_PartsNumber.Text), vbExclamation + vbOKOnly, Application.CompanyName)
                    Else
                        Dim lii As ListViewItem = SPA_Outgoing.lvParts.Items.Add(txt_PartsNumber.Text)
                        lii.SubItems.Add(txt_PartsName.Text)
                        lii.SubItems.Add(txt_Brand.Text)
                        lii.SubItems.Add(txt_SC_SpareParts.Text)
                        lii.SubItems.Add(txt_SRP.Text)
                        lii.SubItems.Add(txt_Quantity.Text)
                        lii.SubItems.Add(txt_CostWoVAT.Text)
                        lii.SubItems.Add(txt_CostWVAT.Text)
                        lii.SubItems.Add(txt_DiscountPCT.Text)
                        lii.SubItems.Add(txt_DiscountAMT.Text)
                        lii.SubItems.Add(txt_PriceWVAT.Text)
                        lii.SubItems.Add(txt_PriceWoVAT.Text)
                        lii.SubItems.Add(txt_ModelCode.Text)
                        lii.SubItems.Add(txt_ModelName.Text)
                        lii.SubItems.Add(Label22.Text)
                        lii.SubItems.Add(MainMenu.App_User_Name.Caption)
                        lii.SubItems.Add(txt_ID.Text)
                        lii.SubItems.Add(txt_Total.Text)
                        lii.SubItems.Add(txt_Category.Text)
                        lii.SubItems.Add(txt_BinBox.Text)

                        SPA_Outgoing.lbl_Count.Text = SPA_Outgoing.lvParts.Items.Count
                        SPA_Outgoing.TotalParts()
                        ClearTxt()
                        lii = Nothing
                    End If

                End With

            End If
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

    Private Sub txt_PartsNumber_TextChanged(sender As Object, e As EventArgs) Handles txt_PartsNumber.TextChanged
        Find_Spare_Parts()
        If txt_DiscountPCT.Text = String.Empty Then
            txt_DiscountPCT.Text = "0"
        ElseIf txt_DiscountAMT.Text = String.Empty Then
            txt_DiscountAMT.Text = "0.00"
        ElseIf txt_PriceWVAT.Text = String.Empty Then
            txt_PriceWVAT.Text = "0.00"
        ElseIf txt_PriceWoVAT.Text = String.Empty Then
            txt_PriceWoVAT.Text = "0.00"
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub txt_Quantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Quantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_Quantity.Text = "0" Then
                MsgBox("Zero(0) Quantity is not Allowed!", vbOKOnly, Application.CompanyName)
            ElseIf Val(txt_Quantity.Text) > Val(lbl_Quantity1.Text) Then
                MsgBox("Higher Quantity is not Allowed!", vbOKOnly, Application.CompanyName)
            Else
                If SPA_Outgoing.lvParts.Items.Count = 0 Then
                    Dim lii As ListViewItem = SPA_Outgoing.lvParts.Items.Add(txt_PartsNumber.Text)
                    lii.SubItems.Add(txt_PartsName.Text)
                    lii.SubItems.Add(txt_Brand.Text)
                    lii.SubItems.Add(txt_SC_SpareParts.Text)
                    lii.SubItems.Add(txt_SRP.Text)
                    lii.SubItems.Add(txt_Quantity.Text)
                    lii.SubItems.Add(txt_CostWoVAT.Text)
                    lii.SubItems.Add(txt_CostWVAT.Text)
                    lii.SubItems.Add(txt_DiscountPCT.Text)
                    lii.SubItems.Add(txt_DiscountAMT.Text)
                    lii.SubItems.Add(txt_PriceWVAT.Text)
                    lii.SubItems.Add(txt_PriceWoVAT.Text)
                    lii.SubItems.Add(txt_ModelCode.Text)
                    lii.SubItems.Add(txt_ModelName.Text)
                    lii.SubItems.Add(Label22.Text)
                    lii.SubItems.Add(MainMenu.App_User_Name.Caption)
                    lii.SubItems.Add(txt_ID.Text)
                    lii.SubItems.Add(txt_Total.Text)
                    lii.SubItems.Add(txt_Category.Text)
                    lii.SubItems.Add(txt_BinBox.Text)

                    SPA_Outgoing.lbl_Count.Text = SPA_Outgoing.lvParts.Items.Count
                    SPA_Outgoing.TotalParts()
                    ClearTxt()
                    Me.Close()
                    lii = Nothing
                Else
                    With SPA_Outgoing.lvParts
                        Dim itm As ListViewItem
                        itm = .FindItemWithText(txt_ID.Text, True, 0, True)
                        If Not itm Is Nothing Then
                            MsgBox(String.Format("The PartsNumber ({0}) is already on the list.", txt_PartsNumber.Text), vbExclamation + vbOKOnly, Application.CompanyName)
                        Else
                            Dim lii As ListViewItem = SPA_Outgoing.lvParts.Items.Add(txt_PartsNumber.Text)
                            lii.SubItems.Add(txt_PartsName.Text)
                            lii.SubItems.Add(txt_Brand.Text)
                            lii.SubItems.Add(txt_SC_SpareParts.Text)
                            lii.SubItems.Add(txt_SRP.Text)
                            lii.SubItems.Add(txt_Quantity.Text)
                            lii.SubItems.Add(txt_CostWoVAT.Text)
                            lii.SubItems.Add(txt_CostWVAT.Text)
                            lii.SubItems.Add(txt_DiscountPCT.Text)
                            lii.SubItems.Add(txt_DiscountAMT.Text)
                            lii.SubItems.Add(txt_PriceWVAT.Text)
                            lii.SubItems.Add(txt_PriceWoVAT.Text)
                            lii.SubItems.Add(txt_ModelCode.Text)
                            lii.SubItems.Add(txt_ModelName.Text)
                            lii.SubItems.Add(Label22.Text)
                            lii.SubItems.Add(MainMenu.App_User_Name.Caption)
                            lii.SubItems.Add(txt_ID.Text)
                            lii.SubItems.Add(txt_Total.Text)
                            lii.SubItems.Add(txt_Category.Text)
                            lii.SubItems.Add(txt_BinBox.Text)

                            SPA_Outgoing.lbl_Count.Text = SPA_Outgoing.lvParts.Items.Count
                            SPA_Outgoing.TotalParts()
                            ClearTxt()
                            lii = Nothing
                        End If

                    End With

                End If
            End If
        End If
    End Sub

End Class