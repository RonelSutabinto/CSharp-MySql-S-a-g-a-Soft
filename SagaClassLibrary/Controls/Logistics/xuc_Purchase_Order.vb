Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Logistics

    Public Class xuc_Purchase_Order

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Brand(Brand_Code)

            Purchase_Order_Code.ReadOnly = False

            Brand_Code.Select()
        End Sub

        Friend Sub Control_New(ByVal bClear As Boolean, Optional ByVal bOrderModify As Boolean = False)
            If bClear AndAlso Not class_Procedures.actionAsk("New Purchase Order", "Initialize new Purchase Order", "You might lose unsaved data") Then Return

            ID.EditValue = 0

            If bClear Then
                Order_Date.EditValue = Date.Today
                Freight_Cost.Value = 0
                Is_Per_Unit.IsOn = False
                Order_Description.EditValue = String.Empty
                Notes.EditValue = String.Empty
            End If

            If Not class_Procedures.isEmpty(Brand_Code) Then
                If bOrderModify Then
                    Dim sOrderCode() As String = Order_Code.Text.Split("-")
                    class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Order_Code, "inv_Purchase_Orders", "Order_Code", $"{sOrderCode(0)}-{sOrderCode(1)}-{sOrderCode(2)}-")
                    ID.EditValue = 0
                Else
                    Order_Code.Text = class_Database.Get_Last_ID(class_Database.ICSConnection, "inv_Purchase_Orders", "Order_Code", $"PO-{Brand_Code.Text.Trim}-",, 2)
                End If
                Supplier_Name.Text = Brand_Code.GetColumnValue("Account_Name")

                Order_Date.Select()
            Else
                Brand_Code.Select()
            End If
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }
            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Purchase_Order_Procedures")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Order_Code.Text = myDataReader("Order_Code").ToString
                        Purchase_Order_Code.Text = myDataReader("Purchase_Order_Code").ToString
                        Brand_Code.Text = myDataReader("Brand_Code").ToString
                        Order_Date.EditValue = Convert.ToDateTime(myDataReader("Order_Date"))
                        Freight_Cost.EditValue = Convert.ToDecimal(myDataReader("Freight_Cost"))
                        Is_Per_Unit.EditValue = Convert.ToBoolean(myDataReader("Is_Per_Unit"))
                        Due_Date.EditValue = Convert.ToDateTime(myDataReader("Due_Date"))
                        Order_Description.Text = myDataReader("Order_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                        Return True
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Validated() As Boolean
            If class_Procedures.isEmpty(Order_Code) Then Return False
            If class_Procedures.isEmpty(Brand_Code) Then Return False
            Return True
        End Function

        Friend Function Control_Save(Optional ByVal bAsk As Boolean = False) As Boolean
            If Not Control_Validated() Then Return False

            Dim sOrderCode() As String = Order_Code.Text.Trim.Split("-")
            Dim sNotes As String = String.Empty
            Dim bModified As Boolean
            Dim sOrderCodeOld As String = String.Empty

            If ID.EditValue.Equals(0) Then
                Order_Code.Text = class_Database.Get_Last_ID(class_Database.ICSConnection, "inv_Purchase_Orders", "Order_Code", $"PO-{Brand_Code.Text.Trim}-",, 2)
            End If

            If sOrderCode.Length > 3 Then
                If Not class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT Order_Code FROM inv_Purchase_Orders WHERE Order_Code LIKE '{Order_Code.EditValue}'") Then
                    sNotes = class_Functions.Show_Input_Box("Input reason for modifying this Purchase Order", "Modify Purchase Order", String.Empty)
                Else
                    bModified = True
                    sOrderCodeOld = $"{sOrderCode(0)}-{sOrderCode(1)}-{sOrderCode(2)}"
                End If
            Else
                sNotes = Notes.Text.Trim
            End If

            If bAsk AndAlso Not class_Procedures.actionAsk("Purchase Order", "Save Purchase Order Transaction") Then Return False

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Order_Code", Order_Code.Text),
                New SqlParameter("@Purchase_Order_Code", Purchase_Order_Code.Text.Trim),
                New SqlParameter("@Order_Code_Old", sOrderCodeOld),
                New SqlParameter("@Brand_Code", Brand_Code.EditValue),
                New SqlParameter("@Supplier_Code", Brand_Code.GetColumnValue("Account_Code")),
                New SqlParameter("@Order_Date", Order_Date.EditValue),
                New SqlParameter("@Freight_Cost", Freight_Cost.EditValue),
                New SqlParameter("@Is_Per_Unit", Is_Per_Unit.EditValue),
                New SqlParameter("@Due_Date", Due_Date.EditValue),
                New SqlParameter("@Order_Description", Order_Description.Text.Trim),
                New SqlParameter("@Notes", sNotes),
                New SqlParameter("@Modified", bModified),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Purchase_Order_Procedures", "Purchase Order", Order_Code.Text)
        End Function

        Friend Function Control_Modify(ByVal sOrderCode As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Order_Code", sOrderCode),
                New SqlParameter("@Action_Type", "MODIFY")
            }

            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Purchase_Order_Procedures", "Modify Purchase Order", True))
        End Function

        Friend Function Control_Delete() As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Order_Code", Order_Code.EditValue),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "DELETE_PO")
            }

            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Purchase_Order_Procedures", "Delete Purchase Order", True))
        End Function

        Private Sub Brand_Code_EditValueChanged(sender As Object, e As EventArgs) Handles Brand_Code.EditValueChanged
            If Brand_Code.EditValue Is Nothing Then
                Supplier_Name.Text = Brand_Code.GetColumnValue("Account_Name")
            End If
        End Sub

    End Class
End Namespace