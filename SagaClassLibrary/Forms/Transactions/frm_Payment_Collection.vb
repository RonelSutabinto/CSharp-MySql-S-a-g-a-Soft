Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Windows.Forms

Namespace Forms.Transactions
    Partial Public Class frm_Payment_Collection
        Inherits DevExpress.XtraEditors.XtraForm

        Dim dDP, dOB As Decimal

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

        Private Sub frm_Payment_Collection_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub frm_Payment_Collection_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_BarManager(BarManager)
            class_Saga_Procedures.Initialize_Branch(Branch_Code)

            Me.Reference.Properties.MaskSettings.Set("mask", $"{Branch_Code.GetColumnValue("Pre_Code")}-LRL000000")
            Reference.Text = Branch_Code.GetColumnValue("Pre_Code")

            Posting_Date.EditValue = class_Saga_Database.get_Branch_Date(class_Saga_Variables.sBranchCode)
        End Sub

        Private Sub frm_Payment_Collection_shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
            Customer_Name.Select()
        End Sub

        Private Sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Load_Customer_Account(xuc_Account_Search_Accounts.ID)
            Load_Due(toggle_Payment_Mode.IsOn)
        End Sub

        Private Sub btn_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            class_Procedures.Initialize_Controls(Me, True)
            Reference.Text = Branch_Code.GetColumnValue("Pre_Code")
            Customer_Name.Select()
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            Post_Collection()
        End Sub

        Private Function Post_Collection() As Boolean
            If class_Procedures.isEmpty(Customer_Name) Then Return False
            If class_Procedures.isEmpty(Posting_Date) Then Return False
            If class_Procedures.isEmpty(Amount_Paid) Then Return False
            If class_Procedures.isEmpty(Reference) Then Return False
            If class_Procedures.isEmpty(Interest) Then Return False
            If class_Procedures.isEmpty(Notes) Then Return False

            If Reference.Text.Contains("_") Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Reference/OR Number not valid", "Reference Error", True)
                Reference.SelectAll()
                Return False
            End If

            Dim sPaymentMode As String = String.Empty
            If toggle_Payment_Mode.IsOn Then
                sPaymentMode = "FULLPAYMENT"
            End If

            Dim sDepoStatus As String = String.Empty
            If toggle_Depo_Status.IsOn Then
                sDepoStatus = "Pullout"
            End If

            If Not class_Procedures.actionAsk(sTitle:="Collection Payment", sTransaction:=$"Post collection payment - [{Reference.Text.ToUpper}] P{Amount_Paid.Value:N2}", sNote:="You might post it to a wrong Account.") Then
                Return False
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
                    New SqlParameter("@Paramnote", Notes.Text.Trim().ToUpper),
                    New SqlParameter("@ParamTransactedBy", class_Variables.sUserName),
                    New SqlParameter("@Application", Application.ProductName)
                }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "Post_Payment_Update", True)
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    Dim sError As String = myDataReader("Message").ToString
                    If sError.Contains("POSTED") Then
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, sError, "Transaction Information", True)
                        Return True
                    Else
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, sError, "Transaction Error", True)
                        Return False
                    End If
                End If
            End Using
            Return False
        End Function

        Private Sub Customer_Name_BeforePopup(sender As Object, e As EventArgs) Handles Customer_Name.BeforePopup
            PopupContainerControl_Accounts.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl_Accounts}_Width", 500)
            PopupContainerControl_Accounts.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl_Accounts}_Height", 400)
        End Sub

        Private Sub Customer_Name_Popup(sender As Object, e As EventArgs) Handles Customer_Name.Popup
            xuc_Account_Search_Accounts.searchMode = SagaClassLibrary.Controls.Information.Account.xuc_Account_Search.Search_Mode.searchAccounts
            xuc_Account_Search_Accounts.Load_Search(Customer_Name.Text.Trim, Branch_Code.EditValue, False)
        End Sub

        Private Sub Customer_Name_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles Customer_Name.Closed
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl_Accounts}_Width", PopupContainerControl_Accounts.Width)
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl_Accounts}_Height", PopupContainerControl_Accounts.Height)

            Try
                If xuc_Account_Search_Accounts.Amount < 1 Then
                    class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Customer has no Outstanding Balance!", "Balance Error", True)
                    Customer_Name.Select()
                    Return
                End If

                Dim sCodes As String() = xuc_Account_Search_Accounts.Code.Split(New Char() {"-"c})

                Account_Code.Text = sCodes(0)
                Ledger.Text = sCodes(1)
                Customer_Name.Text = xuc_Account_Search_Accounts.AccountName
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try

            Customer_Name.Select()
        End Sub

        Private Sub Load_Customer_Account(ByVal iID As Integer)
            Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ID", iID),
            New SqlParameter("@Action_Type", "RETRIEVE")
        }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_MC_Sale_Procedures", True)
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    Customer_Address.Text = myDataReader("AccountAddress").ToString
                    AE_Code.Text = myDataReader("AccountExecutive").ToString
                    Unit_Description.Text = $"{myDataReader("Brand")} {myDataReader("Model")} {myDataReader("Color")}"

                    Monthly_Principal.Value = Convert.ToDecimal(myDataReader("PrincipalPMT"))
                    Monthly_Interest.Value = Convert.ToDecimal(myDataReader("InterestPMT"))
                    Monthly_Amortization.Value = Convert.ToDecimal(myDataReader("PMT"))

                    Balance_Principal.Value = Convert.ToDecimal(myDataReader("PrincipalBalance"))
                    Balance_Interest.Value = Convert.ToDecimal(myDataReader("InterestBalance"))
                    Balance_Total.Value = Convert.ToDecimal(myDataReader("OutstandingBalance"))

                    First_Payment.EditValue = Convert.ToDateTime(myDataReader("FirstPayDate"))
                    Engine.Text = myDataReader("EngineNo").ToString
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

        Private Sub Customer_Name_Validated(sender As Object, e As EventArgs) Handles Customer_Name.Validated
            Load_Customer_Account(xuc_Account_Search_Accounts.ID)
            Load_Due(toggle_Payment_Mode.IsOn)
        End Sub

        Private Sub toggle_Payment_Mode_Toggled(sender As Object, e As EventArgs) Handles toggle_Payment_Mode.Toggled
            Load_Due(toggle_Payment_Mode.IsOn)
        End Sub

        Private Sub LayoutControl_Total_Due_DoubleClick(sender As Object, e As EventArgs) Handles LayoutControl_Total_Due.DoubleClick
            Amount_Paid.Value = Due_Total.Value
            Amount_Paid.Select()
        End Sub

        Private Sub Amount_Paid_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Amount_Paid.Properties.ButtonClick
            If e.Button.Index.Equals(1) Then
                Amount_Paid.Value = Due_Total.Value
                Amount_Paid.Select()
            End If
        End Sub

        Private Sub Amount_Paid_Validated(sender As Object, e As EventArgs) Handles Amount_Paid.Validated
            If Not toggle_Payment_Mode.IsOn Then
                Payment_Distribution()
            End If
            Principal.Select()
        End Sub

        Private Sub Payment_Distribution()
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
            Finally
                Calculate_Total()
            End Try
        End Sub

        Private Sub Calculate_Total()
            Total.Value = (Principal.Value + Interest.Value + Penalty.Value) - Rebates.Value
        End Sub

        Private Sub Principal_Validated(sender As Object, e As EventArgs) Handles Principal.Validated
            Calculate_Total()
        End Sub

        Private Sub Interest_Validated(sender As Object, e As EventArgs) Handles Interest.Validated
            Calculate_Total()
        End Sub

        Private Sub Penalty_Validated(sender As Object, e As EventArgs) Handles Penalty.Validated
            Calculate_Total()
        End Sub

        Private Sub Rebates_Validated(sender As Object, e As EventArgs) Handles Rebates.Validated
            Calculate_Total()
        End Sub

        Private Sub Penalty_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Penalty.Properties.ButtonClick
            If e.Button.Index.Equals(1) Then
                Principal.Value += Penalty.Value
                Penalty.Value = 0
            End If
        End Sub

        Private Sub Rebates_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Rebates.Properties.ButtonClick
            If e.Button.Index.Equals(1) Then
                Total.Value += Rebates.Value
                Rebates.Value = 0
            End If
        End Sub

        Private Sub Account_Code_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Account_Code.ButtonClick
            If e.Button.Index.Equals(0) Then
                class_Saga_Procedures.Show_Account(class_Saga_Variables.eLoad_Type.Ledger, Account_Code.Text, Ledger.Text, Customer_Name.Text)
            End If
        End Sub

        Private Function isAccount_Empty() As Boolean
            If class_Procedures.isEmpty(Account_Code) Then Return True
            If class_Procedures.isEmpty(Ledger) Then Return True
            Return False
        End Function

        Private Sub btn_Schedule_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Schedule.ItemClick
            If Not isAccount_Empty() Then
                class_Saga_Procedures.Show_Amortization(Branch_Code.EditValue, Account_Code.Text, Convert.ToInt32(Ledger.EditValue))
            End If
        End Sub

        Private Sub btn_Payments_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Payments.ItemClick
            If Not isAccount_Empty() Then
                class_Saga_Procedures.Show_Account_Payments(Account_Code.Text, Convert.ToInt32(Ledger.EditValue), Customer_Name.Text.Trim)
            End If
        End Sub

        Private Sub btn_Ledger_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Ledger.ItemClick
            If Not isAccount_Empty() Then
                class_Saga_Procedures.Show_Account_Ledgers(Branch_Code.EditValue, Account_Code.Text, Ledger.Text, Customer_Name.Text)
            End If
        End Sub

        Private Sub toggle_Collection_Type_Toggled(sender As Object, e As EventArgs) Handles toggle_Collection_Type.Toggled
            If toggle_Collection_Type.IsOn Then
                Me.Reference.Properties.MaskSettings.Set("mask", $"LLL-LRL000000")
                class_Saga_Procedures.Initialize_IBP_Transactions(IBP_Reference, Branch_Code.EditValue)
            Else
                Me.Reference.Properties.MaskSettings.Set("mask", $"{Branch_Code.GetColumnValue("Pre_Code")}-LRL000000")
                Reference.Text = Branch_Code.GetColumnValue("Pre_Code")
            End If
            Reference.ReadOnly = toggle_Collection_Type.IsOn
            Posting_Date.ReadOnly = toggle_Collection_Type.IsOn

            toggle_Payment_Mode.IsOn = False
            toggle_Payment_Mode.ReadOnly = toggle_Collection_Type.IsOn

            IBP_Reference.ReadOnly = Not toggle_Collection_Type.IsOn
        End Sub

        Private Sub IBP_Reference_Validated(sender As Object, e As EventArgs) Handles IBP_Reference.Validated
            Account_Code.EditValue = IBP_Reference.GetColumnValue("BranchAccountNumberCust")
            Ledger.EditValue = IBP_Reference.GetColumnValue("LedgerSetnumberCust")
            Customer_Name.EditValue = IBP_Reference.GetColumnValue("AccountName")
            Posting_Date.EditValue = IBP_Reference.GetColumnValue("PostingDate")
            Notes.Text = IBP_Reference.GetColumnValue("Description")

            Dim iID As Integer = Convert.ToInt32(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT SequenceNo, AccountNumber, LedgerSetNumber FROM CustAccount WHERE AccountNumber LIKE '{Account_Code.EditValue}' AND LedgerSetNumber LIKE '{Ledger.EditValue}'", "SequenceNo"))
            Load_Customer_Account(iID)

            Load_Due(toggle_Payment_Mode.IsOn)

            Reference.EditValue = IBP_Reference.EditValue
            Amount_Paid.Value = IBP_Reference.GetColumnValue("AmountDue")

            Payment_Distribution()
        End Sub

        Private Sub btn_Print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print.ItemClick
            If class_Procedures.isEmpty(Branch_Code) Then Return
            If class_Procedures.isEmpty(Account_Code) Then Return
            If class_Procedures.isEmpty(Ledger) Then Return
            If class_Procedures.isEmpty(Amount_Paid) Then Return
            If class_Procedures.isEmpty(Reference) Then Return
            If class_Procedures.isEmpty(Notes) Then Return

            Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", Branch_Code.EditValue),
            New SqlParameter("@ParamAccountNumber", Account_Code.Text),
            New SqlParameter("@ParamLedgerSetNumber", Ledger.Text),
            New SqlParameter("@ParamRefNo", Reference.Text)
        }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowVatOR")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    myDataReader.Read()
                    dDP = Convert.ToDecimal(myDataReader.Item("DP"))
                    dOB = Convert.ToDecimal(myDataReader.Item("OutstandingBalance"))
                End If
            End Using

            Dim xRpt As New Reports.Transactions.xrpt_Collection_Receipt
            Dim rpTool = New ReportPrintTool(xRpt)
            Try
                Dim dReceived As Decimal = (Principal.Value + Interest.Value + Penalty.Value) - Rebates.Value
                With xRpt
                    .Posting_Date.Text = $"{Posting_Date.EditValue:MMM dd, yyyy}"
                    .Customer_Name.Text = Customer_Name.Text
                    .Customer_Address.Text = Customer_Address.Text
                    .Amount_Received.Text = dReceived.ToString("N2")

                    .Reference.Text = Reference.Text.ToUpper
                    .Amortization.Text = Monthly_Amortization.Text
                    .Interest.Text = Interest.Text
                    .VAT.Text = class_Functions.calculate_VAT(Interest.Value).ToString("N2")
                    .NoVAT.Text = class_Functions.calculate_no_VAT(Interest.Value).ToString("N2")
                    .Penalty.Text = Penalty.Text
                    .Rebates.Text = $"- {Rebates.Text}"
                    .Total.Text = $"PHP {dReceived:N2}"
                    .Outstanding_Balance.Text = dOB.ToString("N2")

                    .Notes.Text = Notes.Text.Trim.ToUpper
                    .Printed_By.Text = class_Variables.sUserFullName
                    .Printed_Date.Text = $"{Date.Now:F}"

                    .Amount_Words.Text = class_Functions.AmountToWords(dReceived.ToString).ToUpper
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            Finally
                rpTool.ShowRibbonPreview()
            End Try

            'With PrintDocument
            '    .DefaultPageSettings.Landscape = False
            'End With
            'DirectCast(PrintPreviewDialog, Form).WindowState = FormWindowState.Maximized
            'With PrintPreviewDialog
            '    .PrintPreviewControl.Width = FormWindowState.Maximized
            '    .PrintPreviewControl.Zoom = 1.5
            '    .ShowDialog()
            'End With
        End Sub

        Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument.PrintPage
            Dim TitleFont As New Font("calibri", 10, FontStyle.Bold)
            Dim BodyFont As New Font("calibri", 10, FontStyle.Regular)
            Dim BodyFont2 As New Font("calibri", 10)
            Dim BodyFontAMT As New Font("calibri", 10, FontStyle.Regular) ', Alignment.RightAlign)
            Dim format As New StringFormat(StringFormatFlags.DirectionRightToLeft)

            Dim FirstColAmt As Integer = 200
            Dim SecondColAmt As Integer = 410
            Dim H As Integer = 0
            H = 65
            e.Graphics.DrawString(Posting_Date.Text, BodyFont, Brushes.Black, 300, H)
            H += 35 '100
            e.Graphics.DrawString(Customer_Name.Text, TitleFont, Brushes.Black, 100, H)
            H += 20 '120
            e.Graphics.DrawString(Customer_Address.Text, BodyFont, Brushes.Black, 100, H)
            H += 20 '140
            e.Graphics.DrawString(class_Functions.AmountToWords(Amount_Paid.EditValue), BodyFont2, Brushes.Black, 100, H)
            H += 20 '160
            e.Graphics.DrawString(Due_Total.Text, BodyFont2, Brushes.Black, 22, H)
            e.Graphics.DrawString(Notes.Text, BodyFont, Brushes.Black, 180, H)

            H += 30 '180
            e.Graphics.DrawString("REFERENCE: ", BodyFont, Brushes.Black, 22, H)
            e.Graphics.DrawString(Reference.Text.ToUpper, BodyFont, Brushes.Black, 160, H)
            H += 20 '
            e.Graphics.DrawString("AMORTIZATION ", BodyFont, Brushes.Black, 32, H)
            e.Graphics.DrawString(Monthly_Amortization.Text, BodyFontAMT, Brushes.Black, 260, H, format)
            H += 20 '
            e.Graphics.DrawString("ADD: Penalty ", BodyFont, Brushes.Black, 32, H)
            e.Graphics.DrawString(Penalty.Text, BodyFontAMT, Brushes.Black, 260, H, format)
            H += 20 '
            e.Graphics.DrawString("LESS: Rebates ", BodyFont, Brushes.Black, 32, H)
            e.Graphics.DrawString(Rebates.Text, BodyFontAMT, Brushes.Black, 160, H)

            H += 20 '
            e.Graphics.DrawString("DOWNPAYMENT ", BodyFont, Brushes.Black, 22, H)
            e.Graphics.DrawString(dDP.ToString("N2"), BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
            e.Graphics.DrawString("TOTAL SALES VAT ", BodyFont, Brushes.Black, 220, H)
            e.Graphics.DrawString(class_Functions.calculate_no_VAT(Interest.Value).ToString("N2"), BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
            H += 20 '
            e.Graphics.DrawString("TOTAL AMT PAID ", BodyFont, Brushes.Black, 22, H)
            e.Graphics.DrawString(Amount_Paid.EditValue, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
            e.Graphics.DrawString("LESS VAT ", BodyFont, Brushes.Black, 220, H)
            e.Graphics.DrawString(class_Functions.calculate_VAT(Interest.Value).ToString("N2"), BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
            H += 20 '
            e.Graphics.DrawString("VATABLE SALES ", BodyFont, Brushes.Black, 22, H)
            e.Graphics.DrawString(Interest.Text, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
            e.Graphics.DrawString("AMT NET OF VAT ", BodyFont, Brushes.Black, 220, H)
            e.Graphics.DrawString(class_Functions.calculate_no_VAT(Interest.Value).ToString("N2"), BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
            H += 20 '
            e.Graphics.DrawString("VAT EXEMPT SALES ", BodyFont, Brushes.Black, 22, H)
            e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
            e.Graphics.DrawString("Less: SC/PWD Discount ", BodyFont, Brushes.Black, 220, H)
            e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
            H += 20 '
            e.Graphics.DrawString("ZERO RATED SALES ", BodyFont, Brushes.Black, 22, H)
            e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
            e.Graphics.DrawString("AMOUNT DUE ", BodyFont, Brushes.Black, 220, H)
            e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
            H += 20 '
            e.Graphics.DrawString("VAT AMOUNT ", BodyFont, Brushes.Black, 22, H)
            e.Graphics.DrawString(class_Functions.calculate_VAT(Interest.Value).ToString("N2"), BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
            e.Graphics.DrawString("ADD VAT ", BodyFont, Brushes.Black, 220, H)
            e.Graphics.DrawString(class_Functions.calculate_VAT(Interest.Value).ToString("N2"), BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
            H += 20 '
            e.Graphics.DrawString("OUTSTANDING BALANCE ", TitleFont, Brushes.Black, 40, H)
            e.Graphics.DrawString(dOB.ToString("N2"), TitleFont, Brushes.Black, 300, H, format)
            H += 40 '
            e.Graphics.DrawString("Printed by: ", TitleFont, Brushes.Black, 22, H)
            e.Graphics.DrawString(class_Variables.sUserFullName, TitleFont, Brushes.Black, 90, H)
            e.Graphics.DrawString("Printed Date: ", TitleFont, Brushes.Black, 260, H)
            e.Graphics.DrawString($"{Date.Today:MMM dd, yyyy}", TitleFont, Brushes.Black, 340, H)
            H += 10
            e.Graphics.DrawString($"{Date.Today:hh mm ss}", TitleFont, Brushes.Black, 340, H)
        End Sub
    End Class
End Namespace