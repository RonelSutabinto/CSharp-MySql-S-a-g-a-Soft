Imports SagaClassLibrary.Modules
Imports SagaOperations.Classes

Public Class Xuc_Spare_Parts_Details
    Dim Total_Percent, Percentage As Double

    Sub Initialize_Parts()
        class_Operation_Variables.Initialize_Spare_Parts(class_Saga_Variables.sBranchCode)
        class_Saga_Procedures.Initialize_Spare_Parts(Parts_Number)
    End Sub

    Private Sub Parts_Number_EditValueChanged(sender As Object, e As EventArgs) Handles Parts_Number.EditValueChanged
        Parts_Name.EditValue = Parts_Number.GetColumnValue("PartsName")
        ID.EditValue = Parts_Number.GetColumnValue("id")
        Quantity.EditValue = Parts_Number.GetColumnValue("Quantity")
        Unit.EditValue = Parts_Number.GetColumnValue("Unit")
        Unit_Price.EditValue = Parts_Number.GetColumnValue("SRP")
    End Sub

    Private Sub Discount_Percentage_KeyDown(sender As Object, e As KeyEventArgs) Handles Discount_Percentage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Percentage = "100"
            Total_Percent = Val(Discount_Percentage.EditValue) / Val(Percentage)
            Discount_Amount.EditValue = Val(Total_Percent) * Val(Unit_Price.EditValue)
            Selling_Price.EditValue = Val(Unit_Price.EditValue) - Val(Discount_Amount.EditValue)
            Selling_Price.Enabled = True
            Selling_Price.Focus.Equals(True)
            Total()
        End If
    End Sub

    Private Sub Input_Quantity_EditValueChanged(sender As Object, e As EventArgs) Handles Input_Quantity.EditValueChanged
        Total()
    End Sub

    Private Sub Selling_Price_EditValueChanged(sender As Object, e As EventArgs) Handles Selling_Price.EditValueChanged
        Net_Total.EditValue = Val(Selling_Price.EditValue) * Val(Input_Quantity.EditValue)
    End Sub

    Sub Total()
        Net_Total.EditValue = Val(Selling_Price.EditValue) * Val(Input_Quantity.EditValue)
        Total_Less.EditValue = Val(Discount_Amount.EditValue) * Val(Input_Quantity.EditValue)
        Gross_Total.EditValue = Val(Unit_Price.EditValue) * Val(Input_Quantity.EditValue)
    End Sub

    Private Sub Input_Quantity_KeyDown(sender As Object, e As KeyEventArgs) Handles Input_Quantity.KeyDown
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

End Class