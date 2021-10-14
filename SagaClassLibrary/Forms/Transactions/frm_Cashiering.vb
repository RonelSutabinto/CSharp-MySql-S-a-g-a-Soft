Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Namespace Forms.Transactions
    Partial Public Class frm_Cashiering
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, BtnCancel)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, True)
        End Function

        Private Sub frm_Cashiering_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub frm_Cashiering_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_BarManager(BarManager)
            Posting_Date.EditValue = Date.Today
            Customer_Name.Select()
        End Sub

        Private Sub frm_Cashiering_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
            class_Saga_Procedures.Initialize_Branch(Branch_Code)
            Reference.Text = Branch_Code.GetColumnValue("Pre_Code")
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Load_Customer_Account()
            Load_Due(toggle_Payment_Mode.IsOn)
        End Sub

        Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            class_Procedures.Initialize_Controls(Me, True)
            Reference.Text = Branch_Code.GetColumnValue("Pre_Code")
            Customer_Name.Select()
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If class_Procedures.isEmpty(Customer_Name) Then Return
            If class_Procedures.isEmpty(Posting_Date) Then Return
            If class_Procedures.isEmpty(Amount_Paid) Then Return
            If class_Procedures.isEmpty(Reference) Then Return
            If class_Procedures.isEmpty(Interest) Then Return

            Dim sPaymentMode As String = String.Empty
            If toggle_Payment_Mode.IsOn Then
                sPaymentMode = "FULLPAYMENT"
            End If

            Dim sDepoStatus As String = String.Empty
            If toggle_Depo_Status.IsOn Then
                sDepoStatus = "Pullout"
            End If

            Dim sqlParameters As SqlParameter() =
                {
                    New SqlParameter("@ParamBranchCode", Branch_Code.EditValue),
                    New SqlParameter("@ParamAccountNumber", Account_Code.EditValue),
                    New SqlParameter("@ParamLedgersetNumber", Ledger.EditValue),
                    New SqlParameter("@ParamPostingDate", Posting_Date.EditValue),
                    New SqlParameter("@ParamAmountPaid", Amount_Paid.Value),
                    New SqlParameter("@ParamRefNo", Reference.Text.Trim.ToUpper),
                    New SqlParameter("@ParamPrin", Principal.Value),
                    New SqlParameter("@ParamInt", Interest.Value),
                    New SqlParameter("@Parampen", Penalty.Value),
                    New SqlParameter("@Paramreb", Rebates.Value),
                    New SqlParameter("@Paramtotal", Total.Value),
                    New SqlParameter("@ParamTotalDue", Due_Total.Value),
                    New SqlParameter("@ParamPaymentType", sPaymentMode),
                    New SqlParameter("@ParamPULLOUT", sDepoStatus),
                    New SqlParameter("@ParamIBP", toggle_Collection_Type.IsOn),
                    New SqlParameter("@Paramnote", Notes.Text.Trim()),
                    New SqlParameter("@ParamTransactedBy", class_Variables.sUserName)
                }

            'class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "Post_Payment_Update", "Post Payment", $"{Reference.Text.Trim} {Total.Value:N2}")

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "Post_Payment_Update", True)
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    Dim sError As String = myDataReader("Message").ToString
                    If sError.Contains("POSTED") Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, sError, "Payment Information", True)
                    Else
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, sError, "Payment Error", True)
                    End If
                End If
            End Using
        End Sub

        Private Sub Customer_Name_BeforePopup(sender As Object, e As EventArgs) Handles Customer_Name.BeforePopup
            PopupContainerControl_Accounts.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl_Accounts}_Width", 500)
            PopupContainerControl_Accounts.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl_Accounts}_Height", 400)
        End Sub

        Private Sub Customer_Name_Popup(sender As Object, e As EventArgs) Handles Customer_Name.Popup
            xuc_Account_Search_Accounts.searchMode = SagaClassLibrary.Controls.Information.Account.xuc_Account_Search.Search_Mode.searchAccounts
            xuc_Account_Search_Accounts.Load_Search(Customer_Name.Text.Trim)
        End Sub

        Private Sub Customer_Name_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles Customer_Name.Closed
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl_Accounts}_Width", PopupContainerControl_Accounts.Width)
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl_Accounts}_Height", PopupContainerControl_Accounts.Height)

            Try
                Dim sCodes As String() = xuc_Account_Search_Accounts.Code.Split(New Char() {"-"c})

                Account_Code.Text = sCodes(0)
                Ledger.Text = sCodes(1)
                Customer_Name.Text = xuc_Account_Search_Accounts.AccountName
                Customer_Address.EditValue = xuc_Account_Search_Accounts.Others

                Unit_Description.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT EngineNo, description FROM item_Details WHERE EngineNo LIKE '{xuc_Account_Search_Accounts.Code2}'", "description")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try

            Customer_Name.Select()
        End Sub

        Private Sub Load_Customer_Account()
            Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ID", xuc_Account_Search_Accounts.ID),
            New SqlParameter("@Action_Type", "RETRIEVE")
        }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_MC_Sale_Procedures", True)
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    Monthly_Principal.Value = Convert.ToDecimal(myDataReader("PrincipalPMT"))
                    Monthly_Interest.Value = Convert.ToDecimal(myDataReader("InterestPMT"))
                    Monthly_Amortization.Value = Convert.ToDecimal(myDataReader("PMT"))

                    Balance_Principal.Value = Convert.ToDecimal(myDataReader("PrincipalBalance"))
                    Balance_Interest.Value = Convert.ToDecimal(myDataReader("InterestBalance"))
                    Balance_Total.Value = Convert.ToDecimal(myDataReader("OutstandingBalance"))

                    engine.Text = myDataReader("EngineNo").ToString
                    Chassis.Text = myDataReader("ChassisNo").ToString

                    toggle_Depo_Status.Enabled = myDataReader("AccountStatus").ToString.Contains("DEP")
                End If
            End Using
        End Sub

        Private Sub Load_Due(ByVal bFullPayment As Boolean)
            Dim sProcedureName As String
            If bFullPayment Then
                sProcedureName = "mg_ShowDueFull"
            Else
                sProcedureName = "mg_ShowDue"
            End If

            Dim sqlParameters As SqlParameter() =
                {
                    New SqlParameter("@ParamBranchCode", Branch_Code.EditValue),
                    New SqlParameter("@ParamAccountNumber", Account_Code.Text),
                    New SqlParameter("@ParamLedgersetNumber", Ledger.Text),
                    New SqlParameter("@ParamPostingDate", Posting_Date.EditValue)
                }

            Try
                Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, sProcedureName, True)
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        Due_Principal.Value = Convert.ToDecimal(myDataReader.Item("Principal"))
                        Due_Interest.Value = Convert.ToDecimal(myDataReader.Item("Interest"))
                        Due_Penalty.Value = Convert.ToDecimal(myDataReader.Item("Penalty"))

                        Principal.Value = Convert.ToDecimal(myDataReader.Item("Principal"))
                        Interest.Value = Convert.ToDecimal(myDataReader.Item("Interest"))
                        Penalty.Value = Convert.ToDecimal(myDataReader.Item("Penalty"))
                    End If
                End Using
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            Finally
                Due_Total.Value = Due_Principal.Value + Due_Interest.Value + Due_Penalty.Value
            End Try
        End Sub

        Private Sub toggle_Payment_Mode_Toggled(sender As Object, e As EventArgs) Handles toggle_Payment_Mode.Toggled
            Load_Due(toggle_Payment_Mode.IsOn)
        End Sub

        Private Sub Customer_Name_Validated(sender As Object, e As EventArgs) Handles Customer_Name.Validated
            Load_Customer_Account()
            Load_Due(toggle_Payment_Mode.IsOn)
        End Sub

        Private Sub Amount_Paid_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Amount_Paid.Properties.ButtonClick
            If e.Button.Index.Equals(1) Then
                Amount_Paid.Value = Due_Total.Value
            End If
        End Sub

        Private Sub Amount_Paid_Validated(sender As Object, e As EventArgs) Handles Amount_Paid.Validated
            Dim sqlParameters As SqlParameter() =
                {
                    New SqlParameter("@ParamBranchCode", Branch_Code.EditValue),
                    New SqlParameter("@ParamAccountNumber", Account_Code.Text),
                    New SqlParameter("@ParamLedgersetNumber", Ledger.Text),
                    New SqlParameter("@ParamPostingDate", Posting_Date.EditValue),
                    New SqlParameter("@ParamAmountPaid", Amount_Paid.EditValue)
                }

            Try
                Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowPaymentDistribution", True)
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        Principal.Value = Convert.ToDecimal(myDataReader.Item("Prinpaid"))
                        Interest.Value = Convert.ToDecimal(myDataReader.Item("IntPaid"))
                        Penalty.Value = Convert.ToDecimal(myDataReader.Item("Penpaid"))
                        Rebates.Value = Convert.ToDecimal(myDataReader.Item("Rebates"))
                    End If
                End Using
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub Calculate_Total()
            Total.Value = (Principal.Value + Interest.Value + Penalty.Value) - Rebates.Value
        End Sub

        Private Sub Principal_EditValueChanged(sender As Object, e As EventArgs) Handles Principal.EditValueChanged
            Calculate_Total()
        End Sub

        Private Sub Interest_EditValueChanged(sender As Object, e As EventArgs) Handles Interest.EditValueChanged
            Calculate_Total()
        End Sub

        Private Sub Penalty_EditValueChanged(sender As Object, e As EventArgs) Handles Penalty.EditValueChanged
            Calculate_Total()
        End Sub

        Private Sub Rebates_EditValueChanged(sender As Object, e As EventArgs) Handles Rebates.EditValueChanged
            Calculate_Total()
        End Sub

        Private Sub Penalty_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Penalty.Properties.ButtonClick
            If e.Button.Index.Equals(1) Then
                Principal.Value += Penalty.Value
                Penalty.Value = 0
            End If
        End Sub

        Private Sub Account_Code_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Account_Code.ButtonClick
            If e.Button.Index.Equals(0) Then
                class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, Account_Code.Text, Ledger.Text, Customer_Name.Text)
            End If
        End Sub
    End Class
End Namespace