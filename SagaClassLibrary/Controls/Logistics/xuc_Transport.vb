Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Logistics

    Public Class xuc_Transport
        Inherits DevExpress.XtraEditors.XtraUserControl

        Friend sReference, sPurchaseOrder As String

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()

            class_Saga_Procedures.Initialize_Branch(Branch_From)
            class_Saga_Procedures.Initialize_Branch(Branch_To)

            class_Database.Fill_Edit(class_Database.ICSConnection, Vendor, "item_Master", "vendor")
            class_Database.Fill_Edit(class_Database.ICSConnection, WHCode, "item_Master", "whCode")
            class_Database.Fill_Edit(class_Database.ICSConnection, Transacted_By, "item_Master", "transactedby")
            class_Database.Fill_Edit(class_Database.ICSConnection, Approved_By, "item_Master", "approver")
            Reference_Number.Select()
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = false)
            If bask AndAlso Not class_Procedures.actionAsk("New Transport Profile", "Initialize new Transport Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bask)
        End Sub

        Friend Function Control_Retrieve(ByVal sCode As String) As Boolean

            Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT * FROM item_Master WHERE refno LIKE '{sCode}'")
                ID_Code.Text = sCode
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Transaction_Code.Text = myDataReader("transcode").ToString
                        Purchase_Order.Text = myDataReader("POno").ToString
                        Branch_From.EditValue = myDataReader("OriginatingBranch").ToString
                        Branch_To.EditValue = myDataReader("branchcode").ToString
                        Vendor.Text = myDataReader("vendor").ToString
                        Reference_Number.Text = myDataReader("refno").ToString
                        sReference = myDataReader("refno").ToString
                        Purchase_Order.Text = myDataReader("POno").ToString
                        sPurchaseOrder = myDataReader("POno").ToString
                        Transport_Category.Text = myDataReader("whcategory").ToString
                        WHCode.Text = myDataReader("whCode").ToString
                        TransactionDate.EditValue = convert.todatetime(myDataReader("transactiondate"))
                        Transacted_By.Text = myDataReader("transactedby").ToString
                        Approved_By.Text = myDataReader("approver").ToString
                        Remarks.Text = myDataReader("remarks").ToString
                        Notes.Text = myDataReader("note").ToString

                        Total_Cost.Value = convert.todecimal(myDataReader("totalUnitCost"))
                        Total_VAT.Value = convert.todecimal(myDataReader("totalVATAmt"))
                        Grand_Total.Value = convert.todecimal(myDataReader("GrandTotalUnitCost"))
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Save() As Boolean
            If class_Procedures.isEmpty(ID_Code) Then Return False
            If class_Procedures.isEmpty(Transaction_Code) Then Return False
            If class_Procedures.isEmpty(Reference_Number) Then Return False
            If class_Procedures.isEmpty(Purchase_Order) Then Return False
            If class_Procedures.isEmpty(Transport_Category) Then Return False
            If class_Procedures.isEmpty(WHCode) Then Return False
            If class_Procedures.isEmpty(Transacted_By) Then Return False
            If class_Procedures.isEmpty(Approved_By) Then Return False
            If Not class_Database.Data_Save_Ask(Reference_Number.Text) Then Return False
            class_Procedures.splash_Show("Saving Transport Profile")

            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand($"UPDATE item_Master SET OriginatingBranch = @OriginatingBranch, branchcode = @branchcode, vendor = @vendor, refno = @refno, POno = @POno, whcategory = @whcategory, whCode = @whCode, transactiondate = @transactiondate, transactedby = @transactedby, approver = @approver, remarks = @remarks, note = @note, totalUnitCost = @totalUnitCost, totalVATAmt = @totalVATAmt, GrandTotalUnitCost = @GrandTotalUnitCost WHERE id LIKE '{ID_Code.Text}'", MySQLConnection)

                    With MyCommand.Parameters
                        .Add("@OriginatingBranch", SqlDbType.VarChar).Value = Branch_From.EditValue
                        .Add("@branchcode", SqlDbType.VarChar).Value = Branch_To.EditValue
                        .Add("@vendor", SqlDbType.VarChar).Value = Vendor.Text
                        .Add("@refno", SqlDbType.VarChar).Value = Reference_Number.Text.Trim
                        .Add("@POno", SqlDbType.VarChar).Value = Reference_Number.Text.Trim
                        .Add("@whcategory", SqlDbType.VarChar).Value = Transport_Category.Text.Trim
                        .Add("@whCode", SqlDbType.VarChar).Value = WHCode.Text.Trim
                        .Add("@transactiondate", SqlDbType.Date).Value = TransactionDate.Text
                        .Add("@transactedby", SqlDbType.VarChar).Value = Transacted_By.Text
                        .Add("@approver", SqlDbType.VarChar).Value = Approved_By.Text
                        .Add("@remarks", SqlDbType.VarChar).Value = Remarks.Text.Trim
                        .Add("@note", SqlDbType.VarChar).Value = Notes.Text.Trim
                        .Add("@totalUnitCost", SqlDbType.Money).Value = Total_Cost.Value
                        .Add("@totalVATAmt", SqlDbType.Money).Value = Total_VAT.Value
                        .Add("@GrandTotalUnitCost", SqlDbType.Money).Value = Grand_Total.Value
                    End With

                    Try
                        MySQLConnection.Open()
                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                            If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET refno = '{Reference_Number.Text}', POno = '{Purchase_Order.Text}', transactedby = '{Transacted_By.Text}', approver = '{Approved_By.Text}' WHERE refno LIKE '{sReference}'", True) Then
                                class_Procedures.Set_Message(class_Procedures.MsgMode.Save, "Inventory Profiles")
                            End If
                        End If
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    Finally
                        class_Procedures.splash_Close()
                    End Try
                End Using
            End Using
            Return False
        End Function

        Friend Function Control_Delete() As Boolean

            If class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM item_Master WHERE id LIKE '{ID_Code.Text}'", $"Item Transport: {Transaction_Code.Text}") Then
                Return class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM item_Details WHERE refno LIKE '{Reference_Number.Text}'")
            Else Return False
            End If
        End Function

    End Class

End Namespace