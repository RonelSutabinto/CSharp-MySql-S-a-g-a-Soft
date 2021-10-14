Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Namespace Controls
    Public Class xuc_SPA_Transfer
        Public Sub New()
            InitializeComponent()
        End Sub
        Friend Sub Control_Initialize()
            'Initialize_Branch(Branch_From)
            Transaction_Date.EditValue = Date.Today()
            Branch_From.Select()
        End Sub
        Friend Sub Control_New(Optional ByVal bClear As Boolean = False)
            If bClear AndAlso Not class_Procedures.actionAsk("New Transfer", "Initialize new Transfer", "You might lose unsaved data") Then Return

            If class_Procedures.isEmpty(Transaction_Type) Then Return
            If class_Procedures.isEmpty(SRF) Then Return
            Dim sType As String = Transaction_Type.Text
            Dim sOrderCode As String = SRF.EditValue.ToString
            Dim branchSupplier As String = CStr(Branch_From.EditValue)
            class_Procedures.Initialize_Controls(Me, bClear)
            Transaction_Type.Text = sType
            SRF.EditValue = sOrderCode
            Branch_From.EditValue = branchSupplier

            ID.Text = "0"
            If CStr(Transaction_Type.EditValue) = "OUTGOING" Then
                Transaction_Code.Text = class_Database.Get_Last_ID(class_Database.SPAConnection, "Spare_Parts_Inventory", "Transaction_Code", $"{"Transfer"}-", "id")
            End If
        End Sub

        Private Sub Transaction_Type_EditValueChanged(sender As Object, e As EventArgs) Handles Transaction_Type.EditValueChanged
            If CType(sender, BaseEdit).EditValue Is Nothing Then Return
            If CType(sender, BaseEdit).EditValue.Equals("RETAIL") Then
                Transaction_Code.Properties.ReadOnly = True
                Initialize_SPA_Requests(class_Saga_Variables.sBranchCode)
                Initialize_SPA_Request(SRF)
                Branch_From.Properties.ReadOnly = True
            Else
                Initialize_SPA_Purchase_Orders()
                Initialize_SPA_Purchase_Orders(SRF)
                Status.EditValue = "NEW"
            End If
        End Sub
        Private Sub SRF_EditValueChanged(sender As Object, e As EventArgs) Handles SRF.EditValueChanged
            If Transaction_Type.EditValue Is "RETAIL" Then
                Transaction_Code.Text = class_Database.Get_Last_ID(class_Database.SPAConnection, "Spare_Parts_Inventory", "Transaction_Code", $"{"Transfer"}-", "id")
                class_Saga_Procedures.Initialize_Branch(Branch_From)
                Branch_From.EditValue = class_Saga_Variables.sBranchCode
                Branch_C0de.EditValue = CStr(SRF.GetColumnValue("Branch_From"))
                class_Saga_Procedures.Initialize_Branch(Branch_C0de)
                Branch_C0de.Properties.ReadOnly = True
            Else
                Transaction_Code.Text = class_Database.Get_Last_ID(class_Database.SPAConnection, "Spare_Parts_Inventory", "Transaction_Code", $"{"Transfer"}-", "id")
                class_Saga_Procedures.Initialize_Branch(Branch_From)
                Branch_From.EditValue = class_Saga_Variables.sBranchCode
                Branch_From.Properties.ReadOnly = True
                class_Saga_Procedures.Initialize_Branch(Branch_C0de)
            End If
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                        New SqlParameter("@Action_Type", "RETRIEVE")}

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, "spa_Receive_Transfer_Procedures")
                ID.Text = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        'Transaction_Code.Text = myDataReader("Transaction_Code").ToString
                        SRF.EditValue = myDataReader("Order_Code").ToString
                        Branch_From.EditValue = myDataReader("Branch_Name").ToString
                        Transaction_Date.EditValue = CDate(myDataReader("Posting_Date"))
                        branch.Text = myDataReader("Branch_Code").ToString
                        Transaction_Type.EditValue = CDec(myDataReader("Transaction_Type"))
                        Status.Text = myDataReader("SKU_Status").ToString
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
            Dim sBrCode As String = CStr(SRF.GetColumnValue("Branch_From"))
            If class_Procedures.isEmpty(Transaction_Code) Then Return False
            If class_Procedures.isEmpty(Transaction_Type) Then Return False
            If class_Procedures.isEmpty(SRF) Then Return False
            If class_Procedures.isEmpty(Branch_C0de) Then Return False

            Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                                New SqlParameter("@Transaction_Code", Transaction_Code.EditValue),
                                                New SqlParameter("@Transaction_Type", Transaction_Type.EditValue),
                                                New SqlParameter("@Order_Code", SRF.EditValue),
                                                New SqlParameter("@Reference", SRF.Text),
                                                New SqlParameter("@Supplier_Code", class_Saga_Variables.sBranchCode),
                                                New SqlParameter("@Supplier_Name", Branch_From.Text.Trim),
                                                New SqlParameter("@Transaction_Date", Transaction_Date.EditValue),
                                                New SqlParameter("@Branch_Code", sBrCode),
                                                New SqlParameter("@Branch_Name", Branch_C0de.EditValue),
                                                New SqlParameter("@SKU_Description", SKU_Description.Text.Trim),
                                                New SqlParameter("@SKU_Status", Status.Text.Trim),
                                                New SqlParameter("@Notes", Notes.Text.Trim),
                                                New SqlParameter("@Added_By", class_Variables.sUserName),
                                                New SqlParameter("@Action_Type", "SAVE")}

            Return class_Database.Procedure_Save(class_Database.SPAConnection, sqlParameters, "spa_Receive_Transfer_Procedures", "Receive Order", Transaction_Code.Text)
        End Function

        Friend Function Control_Delete() As Boolean
            Dim sqlParameters As SqlParameter() = {New SqlParameter("@ID", ID.Text),
                                        New SqlParameter("@Action_Type", "DELETE")}

            Return CBool(class_Database.Procedure_Execute(class_Database.SPAConnection, sqlParameters, "spa_Receive_Transfer_Procedures", "Delete Receive Order", True))
        End Function

    End Class
End Namespace