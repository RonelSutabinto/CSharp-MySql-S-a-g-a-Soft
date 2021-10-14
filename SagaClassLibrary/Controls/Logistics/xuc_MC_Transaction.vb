Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Logistics
    Public Class xuc_MC_Transaction
        Friend sBranchFrom As String

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Variables.Initialize_Brands()
            class_Saga_Procedures.Initialize_MC_Transaction_Type(Transaction_Type)
            'class_Saga_Procedures.Initialize_Purchase_Order(Order_Code)
            class_Saga_Procedures.Initialize_Branch(Branch_Code)
            class_Saga_Procedures.Initialize_Warehouse(WHCode)
            Reference.Select()
        End Sub

        Friend Function Control_New(ByVal bAsk As Boolean, Optional ByVal bClear As Boolean = False) As Boolean
            If class_Procedures.isEmpty(Transaction_Type) Then Return False

            Try
                If Transaction_Type.Text.Equals("TRANSFER") AndAlso Branch_From.EditValue.Equals(Branch_Code.EditValue) Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"Originating and Destination Branches should not be the same.{Environment.NewLine}Please update.", "Invalid Destination Branch", True)
                    Branch_Code.Select()
                    Return False
                End If
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try

            If bAsk AndAlso Not class_Procedures.actionAsk($"New {Transaction_Type.Text}", $"Initialize New {Transaction_Type.Text}", "You might lose unsaved data") Then Return False

            Dim sType As String = Transaction_Type.EditValue
            Dim sBranchFrom As String = Branch_From.EditValue
            Dim sOrderCode As String = Order_Code.EditValue

            class_Procedures.Initialize_Controls(Me, bClear)
            Transaction_Type.EditValue = sType
            Branch_From.EditValue = sBranchFrom
            Order_Code.EditValue = sOrderCode

            If bClear Then Due_Date.EditValue = Today

            Received_Date.EditValue = Today
            Transaction_Date.EditValue = Today
            Generate_Code()

            Return True
        End Function

        Private Sub Generate_Code()
            Select Case Transaction_Type.Text
                Case "RECEIVING"
                    Branch_Code.EditValue = class_Saga_Variables.sBranchCode
                    If class_Procedures.isEmpty(Order_Code) Then Return
                    Dim sBrand_Name As String = Order_Code.GetColumnValue("Brand_Name")
                    class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Transaction_Code, "item_Master", "transcode", $"{Transaction_Type.Text}-{sBrand_Name}-")

                Case "DEPOSIT", "CONVERT"
                    Branch_From.EditValue = class_Saga_Variables.sBranchCode
                    Branch_Code.EditValue = class_Saga_Variables.sBranchCode
                    class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Transaction_Code, "item_Master", "transcode", $"{Transaction_Type.Text}-")
                    Order_Code.EditValue = Transaction_Code.Text
                    Reference.Text = Transaction_Code.Text

                Case Else
                    Branch_From.EditValue = class_Saga_Variables.sBranchCode
                    class_Procedures.Initialize_Edit_Code(class_Database.ICSConnection, Transaction_Code, "item_Master", "transcode", $"{Transaction_Type.Text}-")
                    'Dim sCode As String() = Transaction_Code.Text.Split("-")
                    'Order_Code.EditValue = $"{Branch_From.EditValue}-{Branch_Code.EditValue}-{sCode(1)}"
                    Reference.Text = Transaction_Code.Text
            End Select

            Reference.Select()
        End Sub

        Private Sub Transaction_Code_ButtonPressed(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Transaction_Code.ButtonPressed
            Due_Date.EditValue = Today
            Transaction_Date.EditValue = Today
            Generate_Code()
        End Sub

        Private Sub Transaction_Type_EditValueChanged(sender As Object, e As EventArgs) Handles Transaction_Type.EditValueChanged
            If CType(sender, BaseEdit).EditValue Is Nothing Then Return

            Branch_From.ReadOnly = Transaction_Type.Text.Equals("CONVERT") OrElse Transaction_Type.Text.Equals("DEPOSIT") OrElse Transaction_Type.Text.Equals("TRANSFER")
            Branch_Code.ReadOnly = Transaction_Type.Text.Equals("CONVERT") OrElse Transaction_Type.Text.Equals("DEPOSIT") OrElse Transaction_Type.Text.Equals("RECEIVING")
            Order_Code.ReadOnly = Transaction_Type.Text.Equals("CONVERT") OrElse Transaction_Type.Text.Equals("DEPOSIT")
            Reference.ReadOnly = Transaction_Type.Text.Equals("CONVERT") OrElse Transaction_Type.Text.Equals("DEPOSIT") OrElse Transaction_Type.Text.Equals("TRANSFER")

            Select Case CType(sender, BaseEdit).EditValue.ToString
                Case "RECEIVING"
                    class_Saga_Procedures.Initialize_Brand(Branch_From, "Account_Code", "Account_Name")
                    WHCode.EditValue = "NEW"

                Case "DEPOSIT", "CONVERT"
                    class_Saga_Procedures.Initialize_Branch(Branch_From)
                    Branch_From.EditValue = class_Saga_Variables.sBranchCode
                    Branch_Code.EditValue = class_Saga_Variables.sBranchCode
                    WHCode.EditValue = "DEP"

                Case "TRANSFER"
                    class_Saga_Procedures.Initialize_Branch(Branch_From)
                    If Not Branch_From.EditValue.Equals(Branch_Code.EditValue) Then
                        class_Saga_Procedures.Initialize_MC_Request(Order_Code, class_Saga_Variables.sBranchCode, Branch_Code.EditValue)
                    End If

            End Select
        End Sub

        Private Sub Branch_From_EditValueChanged(sender As Object, e As EventArgs) Handles Branch_From.EditValueChanged
            Select Case Transaction_Type.Text
                Case "RECEIVING"
                    Dim sBrand As String() = Branch_From.Text.Split(" ")
                    class_Saga_Procedures.Initialize_Purchase_Order(Order_Code, sBrand(0))

                Case "TRANSFER"
                    class_Saga_Procedures.Initialize_MC_Request(Order_Code, class_Saga_Variables.sBranchCode, Branch_Code.EditValue)

            End Select
        End Sub

        Private Sub Branch_Code_EditValueChanged(sender As Object, e As EventArgs) Handles Branch_Code.EditValueChanged
            If Transaction_Type.Text.Equals("TRANSFER") Then
                'class_Saga_Variables.Initialize_MC_Requests(class_Saga_Variables.sBranchCode, Branch_Code.EditValue)
                class_Saga_Procedures.Initialize_MC_Request(Order_Code, class_Saga_Variables.sBranchCode, Branch_Code.EditValue)
            End If
        End Sub

        Private Sub Order_Code_EditValueChanged(sender As Object, e As EventArgs) Handles Order_Code.EditValueChanged
            Select Case Transaction_Type.Text
                Case "RECEIVING"
                    Branch_From.Text = Order_Code.GetColumnValue("Account_Name")

            End Select
        End Sub

        Friend Function Control_Retrieve(ByVal sID As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Action_Type", "RETRIEVE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Receive_Transfer_Procedures")
                ID.EditValue = sID
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        Transaction_Type.EditValue = Convert.ToDecimal(myDataReader("SourceEvent"))
                        Transaction_Code.Text = myDataReader("transcode").ToString
                        Reference.Text = myDataReader("refno").ToString
                        Order_Code.EditValue = Convert.ToDateTime(myDataReader("POno"))
                        Branch_From.EditValue = myDataReader("OriginatingBranch").ToString
                        Branch_Code.Text = myDataReader("branchcode").ToString
                        Due_Date.EditValue = Convert.ToDateTime(myDataReader("Due_Date"))
                        Received_Date.EditValue = Convert.ToDateTime(myDataReader("dateReceived"))
                        Transaction_Date.EditValue = Convert.ToDateTime(myDataReader("transactiondate"))
                        WHCode.Text = myDataReader("whCode").ToString
                        Description.Text = myDataReader("remarks").ToString
                        Notes.Text = myDataReader("note").ToString
                        Return True
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
            Return False
        End Function

        Friend Function Control_Validated() As Boolean
            If class_Procedures.isEmpty(Transaction_Code) Then Return False
            If class_Procedures.isEmpty(Transaction_Type) Then Return False
            If class_Procedures.isEmpty(Reference) Then Return False
            If class_Procedures.isEmpty(Order_Code) Then Return False
            If class_Procedures.isEmpty(Branch_Code) Then Return False
            If class_Procedures.isEmpty(WHCode) Then Return False
            Return True
        End Function

        Friend Function Control_Save(Optional ByVal bAsk As Boolean = False) As Boolean
            If Not Control_Validated() Then Return False

            If Transaction_Type.Text.Equals("TRANSFER") AndAlso Branch_From.EditValue.Equals(Branch_Code.EditValue) Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Branch From and Branch To should not be the same.{Environment.NewLine}Please update.", "Same Branches", True)
                Return False
            End If

            If Transaction_Code.Text.Contains("--") Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Invalid Transaction Code", "Code Error", True)
                Transaction_Code.Select()
                Return False
            End If

            If ID.EditValue.Equals(0) Then
                Generate_Code()
                If Reference.Text.Length > 0 AndAlso class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT refno FROM item_Details WHERE refno LIKE '{Reference.EditValue}'") Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Reference already exist!", "Reference Error", True)
                    Return False
                End If
            End If

            If bAsk AndAlso Not class_Procedures.actionAsk("Receive/Transfer", "Save Receive/Transfer/Deposit Transaction") Then Return False

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Transaction_Code", Transaction_Code.Text),
                New SqlParameter("@Transaction_Type", Transaction_Type.Text),
                New SqlParameter("@Unit_Status", WHCode.EditValue),
                New SqlParameter("@Unit_Category", WHCode.Text),
                New SqlParameter("@Reference", Reference.Text.Trim.ToUpper),
                New SqlParameter("@Order_Code", Order_Code.EditValue),
                New SqlParameter("@Supplier_Code", Branch_From.EditValue),
                New SqlParameter("@Supplier_Name", Branch_From.Text.Trim),
                New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                New SqlParameter("@Due_Date", Due_Date.EditValue),
                New SqlParameter("@Received_Date", Received_Date.EditValue),
                New SqlParameter("@Description", Description.Text.Trim),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "SAVE")
            }

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_Receive_Transfer_Procedures", "Receive/Transfer/Deposit Transaction", Transaction_Code.Text)
        End Function

        Friend Function Control_Delete() As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Transaction_Code", Transaction_Code.Text),
                New SqlParameter("@Reference", Reference.Text),
                New SqlParameter("@Modified_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "DELETE")
            }

            Return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "inv_Receive_Transfer_Procedures", "Delete Receive Order", True))
        End Function

        Private Sub Reference_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Reference.KeyDown
            Select Case e.KeyCode
                Case System.Windows.Forms.Keys.Enter
                    If class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT refno FROM item_Master WHERE refno LIKE '{Reference.EditValue}'") Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, "Reference already exist!", "Already Exist", True)
                    End If

            End Select
        End Sub

        Private Sub Reference_Validated(sender As Object, e As EventArgs) Handles Reference.Validated
            Try
                If ID.EditValue.Equals(0) Then
                    If Reference.Text.Length > 0 AndAlso class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT refno FROM item_Details WHERE refno LIKE '{Reference.EditValue}'") Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, "Reference already exist!", "Reference Warning", True)
                    End If
                End If
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub Order_Code_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Order_Code.ButtonClick
            Select Case e.Button.Index
                Case 1
                    If class_Variables.isAdministrator Then
                        Dim sOrderCodeOld As String = Order_Code.EditValue
                        Dim sOrderCodeNew As String = class_Functions.Show_Input_Box("Input new Purchase Order Code", "New Purchase Order", sOrderCodeOld)

                        If Not class_Procedures.actionAsk("Purchase Order Code", "update or replace Purchase Order Code") Then Return

                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Master SET PONO = '{sOrderCodeNew}' WHERE transcode LIKE '{Transaction_Code.EditValue}' AND refno LIKE '{Reference.EditValue}'", True)
                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET PONO = '{sOrderCodeNew}', Is_Verified = 0 WHERE transcode LIKE '{Transaction_Code.EditValue}' AND refno LIKE '{Reference.EditValue}'", True)
                    End If
            End Select
        End Sub

        Private Sub Reference_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Reference.ButtonClick
            Select Case e.Button.Index
                Case 0
                    If class_Variables.isAdministrator Then
                        Dim sReferenceOld As String = Reference.EditValue
                        Dim sReferenceNew As String = class_Functions.Show_Input_Box("Input new Reference Code", "New Reference", sReferenceOld)

                        If Not class_Procedures.actionAsk("Reference Code", "update or replace Reference Code") Then Return

                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Master SET refno = '{sReferenceNew}' WHERE transcode LIKE '{Transaction_Code.EditValue}' AND PONO LIKE '{Order_Code.EditValue}'", True)
                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE item_Details SET refno = '{sReferenceNew}', Is_Verified = 0 WHERE transcode LIKE '{Transaction_Code.EditValue}' AND PONO LIKE '{Order_Code.EditValue}'", True)
                    End If
            End Select
        End Sub


    End Class
End Namespace