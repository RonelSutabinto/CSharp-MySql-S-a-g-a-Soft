Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Petty_Cash

    Public Class xuc_Expense
        Friend sTatus As String

        Public Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Branch(Branch_Code)

            class_Saga_Procedures.Initialize_Corporation(Category_Corporation, True)

            class_Saga_Variables.Initialize_Employee(Branch_Code.EditValue)
            class_Saga_Procedures.Initialize_Employee(Account_Name)

            With Expense_Category.Properties
                .BestFit()
                .Columns.Clear()
                .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Profile_Corporation", "Corp"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Journal_Type", "Category"),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Friendly_Name", "Sub-Category", -1, DevExpress.Utils.FormatType.None, String.Empty, True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Category_Ceiling", "Sub-Ceiling", -1, DevExpress.Utils.FormatType.Numeric, "N2", True, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Profile_Code", "Code", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Profile_VAT", "VAT", -1, DevExpress.Utils.FormatType.None, String.Empty, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None),
                                  New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Profile_Description", "Description")})

                .DisplayMember = "Friendly_Name"
                .DropDownRows = 20
                .ValueMember = "Profile_Code"
                .NullValuePrompt = "Select Category..."
            End With

            class_Database.Bind_Data(class_Database.ICSConnection, Expense_Category, $"SELECT * FROM view_Petty_Cash_Profiles WHERE Branch_Code LIKE '{Branch_Code.EditValue}'", "view_Petty_Cash_Profiles", False)

            Ceiling_Refresh()
        End Sub

        Private Sub Ceiling_Refresh()
            Check_Ceiling_Branch()

            If Expense_Category.EditValue IsNot Nothing Then
                Check_Ceiling_Category()
            End If

            Vendor.Properties.DropDownRows = class_Database.Fill_Edit(class_Database.ICSConnection, Vendor, "TransactionPettyCash", "BranchCode", "Vendor", Branch_Code.EditValue)

            Expense_Category.Select()
        End Sub

        Private Sub Set_SuperTip(ByVal calcEdit As DevExpress.XtraEditors.CalcEdit, ByVal sTitle As String, ByVal sToolTipItem1 As String, ByVal sToolTipItem2 As String, ByVal sToolTipItem3 As String, ByVal sToolTipItem4 As String)
            Dim SuperToolTip As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Dim ToolTipSeparatorItem1 As DevExpress.Utils.ToolTipSeparatorItem = New DevExpress.Utils.ToolTipSeparatorItem()
            Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()

            ToolTipTitleItem1.Text = sTitle
            ToolTipItem1.Text = sToolTipItem1
            ToolTipItem2.Text = sToolTipItem2
            ToolTipItem3.Text = sToolTipItem3
            ToolTipItem4.Text = sToolTipItem4
            SuperToolTip.Items.Add(ToolTipTitleItem1)
            SuperToolTip.Items.Add(ToolTipItem1)
            SuperToolTip.Items.Add(ToolTipItem2)
            SuperToolTip.Items.Add(ToolTipItem3)
            SuperToolTip.Items.Add(ToolTipSeparatorItem1)
            SuperToolTip.Items.Add(ToolTipItem4)
            calcEdit.SuperTip = SuperToolTip
        End Sub

        Private Sub Check_Ceiling_Branch()
            Dim dBranchCeiling, dForLiquidation, dForApproval As Decimal

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                New SqlParameter("@Action_Type", "GET_CEILING_BRANCH")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Procedures")
                Try
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        Branch_Ceiling.Value = convert.todecimal(myDataReader("Balance"))
                        dBranchCeiling = convert.todecimal(myDataReader("Ceiling_Branch"))
                        dForLiquidation = convert.todecimal(myDataReader("For_Liquidation"))
                        dForApproval = convert.todecimal(myDataReader("For_Approval"))
                    End If
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                Finally
                    Set_SuperTip(Branch_Ceiling, "Branch Ceiling Information", $"Branch Ceiling = {dBranchCeiling:N2}", $"For Liquidation Expenses = {dForLiquidation:N2}", $"For Approval Expenses = {dForApproval:N2}", $"Outstanding Balance = {(dBranchCeiling - (dForLiquidation + dForApproval)):N2}")
                End Try
            End Using
        End Sub

        Private Sub Check_Ceiling_Category()
            Dim dCategoryCeiling, dForLiquidation, dForApproval As Decimal

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                New SqlParameter("@Profile_Code", Expense_Category.EditValue),
                New SqlParameter("@Action_Type", "GET_CEILING_CATEGORY")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Procedures")
                Try
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        dCategoryCeiling = convert.todecimal(myDataReader("Ceiling_Category"))
                        dForLiquidation = convert.todecimal(myDataReader("For_Liquidation"))
                        dForApproval = convert.todecimal(myDataReader("For_Approval"))
                    End If
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                Finally
                    Category_Ceiling.Value = dCategoryCeiling - (dForLiquidation + dForApproval)
                End Try
            End Using

            If Category_Ceiling.Value > Branch_Ceiling.Value Then
                Category_Ceiling.Value = Branch_Ceiling.Value
                Set_SuperTip(Category_Ceiling, "Category Ceiling Information", $"Category Ceiling = {Branch_Ceiling.Value:N2}", $"For Liquidation Expenses = {dForLiquidation:N2}", $"For Approval Expenses = {dForApproval:N2}", $"Outstanding Balance = {Branch_Ceiling.Value:N2}")
            Else
                Set_SuperTip(Category_Ceiling, "Category Ceiling Information", $"Category Ceiling = {dCategoryCeiling:N2}", $"For Liquidation Expenses = {dForLiquidation:N2}", $"For Approval Expenses = {dForApproval:N2}", $"Outstanding Balance = {(dCategoryCeiling - (dForLiquidation + dForApproval)):N2}")
            End If
        End Sub

        Private Sub Petty_Cash_Category_EditValueChanged(sender As Object, e As EventArgs) Handles Expense_Category.EditValueChanged
            Dim sCorp As String = Expense_Category.GetColumnValue("Profile_Corporation")

            If sCorp Is Nothing Then Return

            Category_Corporation.EditValue = sCorp

            If sCorp.Equals("ALL") Then
                Category_Corporation.ReadOnly = False
            Else
                Category_Corporation.ReadOnly = True
            End If

            Dim sCategory As String = Expense_Category.GetColumnValue("Friendly_Name")
            If sCategory.Contains("PDI") Or
                sCategory.Contains("LITIGATION") Or
                sCategory.Contains("RECONDITION") Or
                sCategory.Contains("PULL_OUT") Then
                Recipient.ReadOnly = False
            Else
                Recipient.EditValue = String.Empty
                Recipient.ReadOnly = True
            End If

            If Expense_Category.EditValue.ToString.Contains("MEAL") Then
                Amount_Paid.Value = 80
            End If

            Is_VAT.IsOn = Convert.ToBoolean(Expense_Category.GetColumnValue("Profile_VAT"))
            Is_VAT.ReadOnly = Not Is_VAT.IsOn

            Check_Ceiling_Category()
        End Sub

        Private Sub Account_Name_EditValueChanged(sender As Object, e As EventArgs) Handles Account_Name.EditValueChanged
            Dim sCategory As String = Expense_Category.GetColumnValue("Journal_Type")

            If sCategory Is Nothing Then Return

            If sCategory.Contains("RECONDITION") Then
                Engine.EditValue = Account_Name.GetColumnValue("ENGINE")
            End If
        End Sub

        Private Sub Account_Name_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Account_Name.Properties.ButtonClick
            Select Case e.Button.Index
                Case 1
                    Account_Name.EditValue = String.Empty
            End Select
        End Sub


        Private Sub Recipient_BeforePopup(sender As Object, e As EventArgs) Handles Recipient.BeforePopup
            PopupContainerControl_Recipient.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl_Recipient}_Width", 500)
            PopupContainerControl_Recipient.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl_Recipient}_Height", 400)
        End Sub

        Private Sub Recipient_Popup(sender As Object, e As EventArgs) Handles Recipient.Popup
            xuc_Account_Search_Recipient.searchMode = SagaClassLibrary.Controls.Information.Account.xuc_Account_Search.Search_Mode.searchAccounts
            xuc_Account_Search_Recipient.Load_Search(Recipient.Text.Trim, Branch_Code.EditValue)
        End Sub

        Private Sub Recipient_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles Recipient.Closed
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl_Recipient}_Width", PopupContainerControl_Recipient.Width)
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl_Recipient}_Height", PopupContainerControl_Recipient.Height)

            Recipient.Text = xuc_Account_Search_Recipient.AccountName
            Engine.EditValue = xuc_Account_Search_Recipient.Code2
            Recipient.Select()
        End Sub

        Private Sub Recipient_EditValueChanged(sender As Object, e As EventArgs) Handles Recipient.EditValueChanged
            If Recipient.Text.Length.Equals(0) Then Engine.EditValue = Nothing
        End Sub

        Private Sub Engine_EditValueChanged(sender As Object, e As EventArgs) Handles Engine.EditValueChanged
            Chassis.Text = Engine.GetColumnValue("ChassisNo")
        End Sub

        Private Sub Amount_Paid_EditValueChanged(sender As Object, e As EventArgs) Handles Amount_Paid.EditValueChanged
            Calculate_VAT()
        End Sub

        Private Sub Calculate_VAT()
            If Is_VAT.IsOn Then
                VAT.Text = class_Functions.calculate_VAT(Amount_Paid.Value)
                No_VAT.Value = class_Functions.calculate_no_VAT(Amount_Paid.Value)
            Else
                Vendor.EditValue = String.Empty
                Official_Receipt.EditValue = String.Empty
                No_VAT.Value = 0
                VAT.Text = 0
            End If
        End Sub

        Private Sub Is_VAT_Toggled(sender As Object, e As EventArgs) Handles Is_VAT.Toggled
            Calculate_VAT()
        End Sub

        Public Sub Control_Retrieve(iID As Integer)
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", iID),
                New SqlParameter("@Action_Type", "RETRIEVE_EXPENSE")
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Procedures")
                Try
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        sTatus = myDataReader("TransStatus").ToString
                        Expense_Category.Text = myDataReader("ExpDetails").ToString
                        Expense_Category.ClosePopup()
                        Category_Corporation.EditValue = myDataReader("Corp").ToString
                        Posting_Date.EditValue = Convert.ToDateTime(myDataReader("PostingDate"))
                        Account_Name.Text = myDataReader("AccountName").ToString
                        Recipient.Text = myDataReader("Recipient").ToString
                        Amount_Paid.Value = Convert.ToDecimal(myDataReader("AmountPaid"))
                        Particulars.Text = myDataReader("Particulars").ToString
                        Vendor.Text = myDataReader("Vendor").ToString
                        Official_Receipt.Text = myDataReader("ORNo").ToString
                        VAT.Value = Convert.ToDecimal(myDataReader("VATAmt"))
                        No_VAT.Value = Convert.ToDecimal(myDataReader("AmntNetofVAT"))
                        Engine.EditValue = myDataReader("EngineNo").ToString
                        Notes.Text = myDataReader("Notes").ToString
                    End If
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End Using
        End Sub

        Friend Function Control_Post_Expense() As Boolean
            Dim sStatus As String = "PENDING"
            Dim sNotes As String = String.Empty

            If class_Procedures.isEmpty(Expense_Category) Then Return False
            If class_Procedures.isEmpty(Account_Name) Then Return False
            If class_Procedures.isEmpty(Amount_Paid) Then Return False
            If class_Procedures.isEmpty(Particulars) Then Return False

            If Category_Corporation.EditValue.ToString.Equals("ALL") Then
                class_Procedures.Show_Data_Error(Category_Corporation, "Select valid Corporation")
                Category_Corporation.Select()
                Return False
            End If

            If Amount_Paid.Value <= 0 Then
                class_Procedures.Show_Data_Error(Category_Corporation, "Input valid Amount Paid")
                Amount_Paid.Select()
                Return False
            End If

            If Not Branch_Code.EditValue.Equals("000") Then
                If Expense_Category.Text.Contains("MEAL") And Not Expense_Category.Text.Contains("VISITOR") And Not Amount_Paid.Value.Equals(50) And Not Amount_Paid.Value.Equals(80) And Not Amount_Paid.Value.Equals(100) Then
                    class_Procedures.Show_Data_Error(Category_Corporation, "Input valid Amount Paid")
                    Amount_Paid.Select()
                    Return False
                End If
            End If

            If Is_VAT.IsOn Then
                If class_Procedures.isEmpty(Vendor) Then Return False
                If class_Procedures.isEmpty(Official_Receipt) Then Return False
            End If

            If Amount_Paid.Value > Branch_Ceiling.Value Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Amount Paid exceeded the Branch Ceiling Limit.{Environment.NewLine}Please contact Accounting Administrator.", "Ceiling Error", True)
                Return False

            ElseIf Amount_Paid.Value > Category_Ceiling.Value Then
                If Convert.ToInt32(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT COUNT (*) AS COUNT FROM TransactionPettyCash WHERE BranchCode LIKE '{Branch_Code.EditValue}' AND Profile_Code LIKE '{Expense_Category.EditValue}' AND TransStatus LIKE 'FOR APPROVAL'", "COUNT")) > 0 Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Amount Paid exceeded the Category Ceiling Limit but you already have pending [FOR APPROVAL].{Environment.NewLine}Please contact Accounting Administrator to approve previous FOR APPROVAL.", "Ceiling Exceeded", True)
                    Return False
                Else
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"Amount Paid exceeded the Category Ceiling Limit.{Environment.NewLine}You may update the Amount Paid or Seek/Contact Accounting Administrator ForApproval.", "Ceiling Exceeded", True)
                    sNotes = class_Functions.Show_Input_Box("Input reason why this expense exceeded on the selected Category Ceiling", "Expense Ceiling Exceeded", String.Empty)
                    If sNotes.Length.Equals(0) Then Return False
                    sStatus = "FOR APPROVAL"
                End If
            End If

            Dim sEngine As String = String.Empty
            If Engine.EditValue IsNot Nothing Then
                sEngine = Engine.EditValue
            End If

            Try
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                    New SqlParameter("@Corporation", Category_Corporation.EditValue),
                    New SqlParameter("@Profile_Code", Expense_Category.EditValue),
                    New SqlParameter("@Account_Name", Account_Name.Text.Trim),
                    New SqlParameter("@Recipient", Recipient.Text.Trim),
                    New SqlParameter("@Amount_Paid", Amount_Paid.Value),
                    New SqlParameter("@Particulars", Particulars.Text.Trim),
                    New SqlParameter("@Vendor", Vendor.Text.Trim),
                    New SqlParameter("@OR_Number", Official_Receipt.Text.Trim),
                    New SqlParameter("@VAT", VAT.Value),
                    New SqlParameter("@No_VAT", No_VAT.Value),
                    New SqlParameter("@Engine", sEngine),
                    New SqlParameter("@Posting_Date", Posting_Date.EditValue),
                    New SqlParameter("@Status", sStatus),
                    New SqlParameter("@Notes", sNotes),
                    New SqlParameter("@Added_By", class_Variables.sUserName),
                    New SqlParameter("@Modified_By", class_Variables.sUserName),
                    New SqlParameter("@Action_Type", "POST_EXPENSE")
                }

                If class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Procedures", $"Petty Cash Expense {Expense_Category.Text}", Expense_Category.Text) Then
                    Ceiling_Refresh()
                End If
                Return False
            Catch ex As Exception
                Return class_Procedures.Show_Error(ex)
            End Try
        End Function

        Friend Function Control_Save() As Boolean
            Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@ID", ID.EditValue),
                    New SqlParameter("@Profile_Code", Expense_Category.EditValue),
                    New SqlParameter("@Account_Name", Account_Name.Text.Trim),
                    New SqlParameter("@Posting_Date", Posting_Date.EditValue),
                    New SqlParameter("@Modified_By", class_Variables.sUserName),
                    New SqlParameter("@Action_Type", "UPDATE_EXPENSE")
                }

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_Petty_Cash_Procedures", $"Petty Cash Expense", Expense_Category.Text)
        End Function

        Friend Function Control_Approve() As Boolean
            If Not class_Procedures.actionAsk("Approve Expense", "Approve current Expense", "You might approve a wrong Expense Transaction") Then Return False
            Return class_Saga_Database.Change_Status_Petty_Cash(ID.EditValue, "APPROVED")
        End Function

        Friend Function Control_DisApprove() As Boolean
            Dim sNotes As String = class_Functions.Show_Input_Box("Input Reason why Disapprove this Expense Transaction", "Disappove Expense Transction", String.Empty)
            If Not class_Procedures.actionAsk("Disapprove Expense", "Disapprove current Expense", "You might disapprove a wrong Expense Transaction") Then Return False
            Return class_Saga_Database.Change_Status_Petty_Cash(ID.EditValue, "DISAPPROVED",, sNotes)
        End Function
    End Class

End Namespace