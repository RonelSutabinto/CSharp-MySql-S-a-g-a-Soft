Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Namespace Controls
    Public Class xuc_SPA_Receive_Order
        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            Branch_Code.EditValue = class_Saga_Database.get_Branch_Name(class_Saga_Variables.sBranchCode)
            Transaction_Date.EditValue = Date.Today()
            Reference.Select()
        End Sub

        Friend Sub Control_New(Optional ByVal bClear As Boolean = False)
            If bClear AndAlso Not class_Procedures.actionAsk("New Receive Order", "Initialize new Receive Order", "You might lose unsaved data") Then Return

            If class_Procedures.isEmpty(Transaction_Type) Then Return
            If class_Procedures.isEmpty(Order_Code) Then Return
            'Dim sOrderCode() As String = Order_Code.Text.Split("-")
            Dim sType As String = Transaction_Type.Text
            Dim sOrderCode As String = Order_Code.EditValue.ToString
            Dim branchSupplier As String = CStr(Branch_From.EditValue)
            class_Procedures.Initialize_Controls(Me, bClear)
            Transaction_Type.Text = sType
            Order_Code.EditValue = sOrderCode
            Branch_From.EditValue = branchSupplier

            ID.Text = "0"
            If Transaction_Type.EditValue.Equals("RECEIVING") Then
                Transaction_Code.Text = class_Database.Get_Last_ID(class_Database.SPAConnection, "Spare_Parts_Inventory", "Transaction_Code", $"{Transaction_Type.EditValue}-{Order_Code.GetColumnValue("Brand")}-", "id")
                Branch_From.EditValue = CStr(Order_Code.GetColumnValue("Supplier_Name"))
                Branch_Code.EditValue = class_Saga_Database.get_Branch_Name(class_Saga_Variables.sBranchCode)
                Reference.Select()
            End If
        End Sub

        Private Sub Transaction_Type_EditValueChanged(sender As Object, e As EventArgs) Handles Transaction_Type.EditValueChanged
            If CType(sender, BaseEdit).EditValue Is Nothing Then Return

            If CType(sender, BaseEdit).EditValue.Equals("RECEIVING") Then
                Order_Code.Properties.ReadOnly = False
                Initialize_SPA_Purchase_Orders()
                Initialize_SPA_Purchase_Orders(Order_Code)
                SKU_Status.EditValue = "NEW"
            Else
                Transaction_Code.Text = class_Database.Get_Last_ID(class_Database.SPAConnection, "Spare_Parts_Inventory", "Transaction_Code", $"Transfer-", "id")
                Reference.Select()
                Order_Code.Properties.ReadOnly = True
            End If
        End Sub

        Private Sub Order_Code_EditValueChanged(sender As Object, e As EventArgs) Handles Order_Code.EditValueChanged
            Branch_From.Properties.ReadOnly = True
            Branch_From.Text = CStr(Order_Code.GetColumnValue("Supplier_Name"))
            Transaction_Code.Text = class_Database.Get_Last_ID(class_Database.SPAConnection, "Spare_Parts_Inventory", "Transaction_Code", $"{Transaction_Type.EditValue}-{Order_Code.GetColumnValue("Brand")}-", "id")
            Reference.Select()
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.Text),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }
            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, "spa_Receive_Transfer_Procedures")
                ID.Text = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        ' Transaction_Code.Text = myDataReader("Transaction_Code").ToString
                        Reference.Text = myDataReader("Reference").ToString
                        Order_Code.EditValue = CDate(myDataReader("Order_Code"))
                        Branch_From.EditValue = myDataReader("Vendor_Name").ToString
                        Transaction_Date.EditValue = CDate(myDataReader("Transaction_Date"))
                        Received_Date.EditValue = CDate(myDataReader("Added_Date"))
                        Branch_Code.Text = myDataReader("Branch_Name").ToString
                        Transaction_Type.EditValue = CDec(myDataReader("Transaction_Type"))
                        SKU_Status.Text = myDataReader("SKU_Status").ToString
                        SKU_Description.Text = myDataReader("SKU_Description").ToString
                        Notes.Text = myDataReader("Notes").ToString
                        Return True
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(Ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If Transaction_Type.EditValue Is "RECEIVING" Then
                If class_Procedures.isEmpty(Transaction_Code) Then Return False
                If class_Procedures.isEmpty(Transaction_Type) Then Return False
                If class_Procedures.isEmpty(Reference) Then Return False
                If class_Procedures.isEmpty(Order_Code) Then Return False
                If class_Procedures.isEmpty(Branch_Code) Then Return False

                Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                                New SqlParameter("@Transaction_Code", Transaction_Code.EditValue),
                                                New SqlParameter("@Transaction_Type", Transaction_Type.EditValue),
                                                New SqlParameter("@SKU_Status", SKU_Status.EditValue),
                                                New SqlParameter("@Reference", Reference.Text.Trim.ToUpper),
                                                New SqlParameter("@Order_Code", Order_Code.EditValue),
                                                New SqlParameter("@Supplier_Code", class_Saga_Variables.sBranchCode),
                                                New SqlParameter("@Supplier_Name", Branch_From.EditValue),
                                                New SqlParameter("@Branch_Name", Branch_Code.EditValue),
                                                New SqlParameter("@Transaction_Date", Transaction_Date.EditValue),
                                                New SqlParameter("@Received_Date", Received_Date.EditValue),
                                                New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                                                New SqlParameter("@SKU_Description", SKU_Description.Text.Trim),
                                                New SqlParameter("@Notes", Notes.Text.Trim),
                                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "SAVE")}

                Return class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Receive_Transfer_Procedures", "Receive Order", Transaction_Code.Text)
            Else
                If class_Procedures.isEmpty(Transaction_Code) Then Return False
                If class_Procedures.isEmpty(Transaction_Type) Then Return False
                If class_Procedures.isEmpty(Reference) Then Return False
                If class_Procedures.isEmpty(Branch_Code) Then Return False

                Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                                New SqlParameter("@Transaction_Code", Transaction_Code.EditValue),
                                                New SqlParameter("@Transaction_Type", Transaction_Type.EditValue),
                                                New SqlParameter("@SKU_Status", SKU_Status.EditValue),
                                                New SqlParameter("@Reference", Reference.Text.Trim.ToUpper),
                                                New SqlParameter("@Order_Code", Order_Code.EditValue),
                                                New SqlParameter("@Supplier_Code", Branch_From.EditValue),
                                                New SqlParameter("@Supplier_Name", Branch_From.Text.Trim),
                                                New SqlParameter("@Branch_Name", Branch_Code.EditValue),
                                                New SqlParameter("@Transaction_Date", Transaction_Date.EditValue),
                                                New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                                                New SqlParameter("@Received_Date", Received_Date.EditValue),
                                                New SqlParameter("@SKU_Description", SKU_Description.Text.Trim),
                                                New SqlParameter("@Notes", Notes.Text.Trim),
                                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                                New SqlParameter("@Modified_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "SAVE")}

                Return class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Receive_Transfer_Procedures", "Receive Order", Transaction_Code.Text)
            End If
        End Function

        Friend Function Control_Delete() As Boolean
            Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                        New SqlParameter("@Action_Type", "DELETE")}

            Return CBool(class_Database.Procedure_Execute(class_Database.SPAConnection, sqlParameters, "Delete Receive Order", "spa_Receive_Transfer_Procedures", True))
        End Function
    End Class
End Namespace