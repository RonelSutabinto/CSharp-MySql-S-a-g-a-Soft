Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Controls.Logistics

    Public Class xuc_Unit_Invoice

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Brand(Brand_Code)
            Brand_Code.Select()
        End Sub

        Friend Sub Control_New(Optional ByVal bClear As Boolean = False)
            If bClear AndAlso Not class_Procedures.actionAsk("New Unit Invoice", "Initialize new Unit Invoice", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bClear)
            class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Invoice_Code, "inv_Unit_Invoices", "Invoice_Code", "INVOICE-")
            Invoice_Number.SelectAll()
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Unit_Invoice_Procedures")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Invoice_Code.Text = myDataReader("Invoice_Code").ToString
                        Brand_Code.EditValue = myDataReader("Brand_Code").ToString
                        Order_Code.EditValue = myDataReader("Order_Code").ToString
                        Invoice_Number.Text = myDataReader("Invoice_Number").ToString
                        Due_Date.EditValue = Convert.ToDateTime(myDataReader("Due_Date"))
                        Due_Date.EditValue = Convert.ToDateTime(myDataReader("Due_Date"))
                        Model_Code.EditValue = myDataReader("Model_Code").ToString
                        Quantity.Value = Convert.ToInt32(myDataReader("Quantity"))
                        Invoice_Amount.Value = Convert.ToDecimal(myDataReader("Invoice_Amount"))
                        Remaining_Balance.Value = Convert.ToDecimal(myDataReader("Remaining_Balance"))
                        Freight_Cost.Value = Convert.ToDecimal(myDataReader("Freight_Cost"))
                        Invoice_Description.Text = myDataReader("Invoice_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                        Return True
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(Invoice_Code) Then Return False
            If class_Procedures.isEmpty(Invoice_Number) Then Return False
            If class_Procedures.isEmpty(Brand_Code) Then Return False
            If class_Procedures.isEmpty(Model_Code) Then Return False
            If class_Procedures.isEmpty(Model_Name) Then Return False
            If class_Procedures.isEmpty(Quantity) Then Return False
            If class_Procedures.isEmpty(Invoice_Amount) Then Return False
            If class_Procedures.isEmpty(Remaining_Balance) Then Return False
            If class_Procedures.isEmpty(Freight_Cost) Then Return False

            If ID.EditValue.Equals("0") Then
                class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Invoice_Code, "inv_Unit_Invoices", "Invoice_Code", "INVOICE-")
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Invoice_Code", Invoice_Code.Text.Trim.ToUpper),
                New SqlParameter("@Brand_Code", Brand_Code.EditValue),
                New SqlParameter("@Order_Code", Order_Code.EditValue),
                New SqlParameter("@Invoice_Number", Invoice_Number.Text.Trim.ToUpper),
                New SqlParameter("@Due_Date", Due_Date.EditValue),
                New SqlParameter("@Due_Date", Due_Date.EditValue),
                New SqlParameter("@Model_Code", Model_Code.EditValue),
                New SqlParameter("@Quantity", Quantity.Value),
                New SqlParameter("@Invoice_Amount", Invoice_Amount.Value),
                New SqlParameter("@Remaining_Balance", Remaining_Balance.Value),
                New SqlParameter("@Freight_Cost", Freight_Cost.Value),
                New SqlParameter("@Invoice_Description", Invoice_Description.Text.Trim),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Unit_Invoice_Procedures", "Unit Invoice", Invoice_Code.Text)
        End Function

        Friend Function Control_Delete() As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "DELETE")
            }

            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Unit_Invoice_Procedures", "Delete Unit Invoice", True))
        End Function

        Private Sub Brand_Code_Validated(sender As Object, e As EventArgs) Handles Brand_Code.Validated
            class_Saga_Variables.Initialize_MC_Models(False, Brand_Code.Text.Trim)
            class_Saga_Procedures.Initialize_MC_Model(Model_Code)
        End Sub

        Private Sub Model_Code_Validated(sender As Object, e As EventArgs) Handles Model_Code.Validated
            Try
                Model_Name.Text = Model_Code.GetColumnValue("modeldesc")
                Model_Color.Text = Model_Code.GetColumnValue("Color")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub LayoutControlItem11_DoubleClick(sender As Object, e As EventArgs) Handles LayoutControlItem11.DoubleClick

        End Sub

        Private Sub LayoutControlItem_Balance_DoubleClick(sender As Object, e As EventArgs) Handles LayoutControlItem_Balance.DoubleClick
            Remaining_Balance.Value = Invoice_Amount.Value
        End Sub

        Private Sub Brand_Code_EditValueChanged(sender As Object, e As EventArgs) Handles Brand_Code.EditValueChanged
            'class_Saga_Variables.Initialize_Purchase_Orders(Brand_Code.Text)
            class_Saga_Procedures.Initialize_Purchase_Order(Order_Code, Brand_Code.Text)
        End Sub
    End Class

End Namespace