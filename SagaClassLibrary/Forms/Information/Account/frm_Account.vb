Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Forms.Information.Account

    Public Class frm_Account
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If Me.xuc_Account Is Nothing Then
                Me.xuc_Account = New Controls.Information.Account.xuc_Account()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, xuc_Account.layoutControl, BtnCancel)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Account_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            btn_Journal.Enabled = class_Saga_Variables.isCashier Or class_Saga_Variables.isAccounting
            btn_Journal_Entries.Enabled = class_Saga_Variables.isCashier Or class_Saga_Variables.isAccounting

            xuc_Account.Date_Granted.EditValue = Date.Today
            xuc_Account.Date_First_Payment.EditValue = Date.Today
            xuc_Account.Date_Maturity.EditValue = Date.Today
            xuc_Account.Date_Updated.EditValue = Date.Today

            xuc_Account.Control_Initialize_Lookups()

            xuc_Account.Check_Auto_Balance.EditValue = class_Tools.RegKeyGet(Me.Name, xuc_Account.Check_Auto_Balance.Name, False)

            Toggle_Skip_Covid.Checked = class_Tools.RegKeyGet(Me.Name, Toggle_Skip_Covid.Name, True)
        End Sub

        Private Function Form_Close() As Boolean
            class_Tools.RegKeySet(Me.Name, xuc_Account.Check_Auto_Balance.Name, xuc_Account.Check_Auto_Balance.Checked)
            class_Tools.RegKeySet(Me.Name, Toggle_Skip_Covid.Name, Toggle_Skip_Covid.Checked)

            Return class_Procedures.Form_Close(Me, barManager, btn_Save.Enabled)
        End Function

        Private Sub frm_Account_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Post_Payment_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Post_Payment.ItemClick
            class_Saga_Procedures.Show_Post_Payment(xuc_Account.Account_Code.Text, xuc_Account.Ledger.Text)
        End Sub

        Private Sub btn_Refresh_Connection_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Refresh_Connection.ItemClick
            class_Saga_Procedures.Refresh_Connection()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Account.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Dim sAccountCode As String = xuc_Account.Account_Code.Text
            Dim sLedgerSet As String = xuc_Account.Ledger.Text

            xuc_Account.Control_New(False)
            xuc_Account.Control_Retrieve($"SELECT * FROM CustAccount WHERE AccountNumber LIKE '{sAccountCode}' AND LedgerSetNumber LIKE '{sLedgerSet}'")
        End Sub

        Private Sub btn_Migrate_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Migrate.ItemClick
            xuc_Account.control_Migrate()
        End Sub

        Private Sub btn_Migrate_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Migrate_Close.ItemClick
            If xuc_Account.control_Migrate() Then class_Procedures.Form_Close(Me, barManager)
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Account.Control_New(True)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Account.control_Save() Then
                btn_Save.Enabled = True
            End If
        End Sub

        Private Sub btn_Release_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Release.ItemClick
            If xuc_Account.control_Release() Then
                btn_Release.Enabled = False
            End If
        End Sub

        Private Sub btn_Save_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Close.ItemClick
            If xuc_Account.control_Save() Then class_Procedures.Form_Close(Me, barManager)
        End Sub

        Private Sub btn_Repo_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Repo.ItemClick
            xuc_Account.Control_Reclass_Repo()
        End Sub

        Private Sub btn_Repo_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Repo_Close.ItemClick
            If xuc_Account.Control_Reclass_Repo() Then
                class_Procedures.Form_Close(Me, barManager)
            End If
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            If xuc_Account.Control_Cancel() Then

            End If
        End Sub

        Private Sub btn_Delete_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete_Close.ItemClick
            If xuc_Account.Control_Cancel() Then
                class_Procedures.Form_Close(Me, barManager)
            End If
        End Sub

        Private Sub btn_Ledger_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Ledger.ItemClick
            If class_Procedures.isEmpty(xuc_Account.Account_Code) Then Return
            If class_Procedures.isEmpty(xuc_Account.Ledger) Then Return

            class_Saga_Procedures.Show_Account_Ledgers(xuc_Account.Branch_Code.EditValue, xuc_Account.Account_Code.Text, xuc_Account.Ledger.Text, xuc_Account.Customer_Name.Text)
        End Sub

        Private Sub btn_Payments_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Payments.ItemClick
            If class_Procedures.isEmpty(xuc_Account.Account_Code) Then Return
            If class_Procedures.isEmpty(xuc_Account.Ledger) Then Return

            class_Saga_Procedures.Show_Account_Payments(xuc_Account.Account_Code.Text, Convert.ToInt32(xuc_Account.Ledger.EditValue), xuc_Account.Customer_Name.Text.Trim) 'xuc_Account.Account_Branch.EditValue.ToString,
        End Sub

        Private Sub btn_Reconcile_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reconcile.ItemClick
            class_Procedures.splash_Show("loading Account Reconciliation")
            Dim frm As frm_Account_Reconciliation = New frm_Account_Reconciliation() With {
            .Top = Me.Top,
            .Left = Me.Left + Me.Width,
            .Height = Me.Height
            }

            With frm
                .Show()
                .sBrCode = xuc_Account.Branch_Code.EditValue
                .sAccount = xuc_Account.Account_Code.Text
                .sLedger = xuc_Account.Ledger.Text

                .Account_Number.Text = $"Account Number: {xuc_Account.Account_Code.Text}-{xuc_Account.Ledger.Text}"
                .Account_Name.Text = $"Account Name: {xuc_Account.Customer_Name.Text}"
                .Account_Address.Text = $"Account Address: {xuc_Account.Customer_Address.Text}"

                .Terms.Text = xuc_Account.Terms.Text
                .Date_Granted.Text = xuc_Account.Date_Granted.Text
                .First_Payment.Text = xuc_Account.Date_First_Payment.Text
                .Last_Updated.Text = xuc_Account.Date_Updated.Text
                .Maturity.Text = xuc_Account.Date_Maturity.Text

                .Release_Principal.Text = xuc_Account.Begin_Principal.Text
                .Release_Interest.Text = xuc_Account.Begin_Interest.Text
                .Release_Outstanding.Text = xuc_Account.Begin_Outstanding.Text

                .Principal.Text = xuc_Account.Monthly_Principal.Text
                .Interest.Text = xuc_Account.Monthly_Interest.Text
                .Amortization.Text = xuc_Account.Amortization.Text

                .Account_Reconcile(Date.Now)
            End With
            class_Procedures.splash_Close()
        End Sub

        Private Sub btn_Amortization_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Amortization.ItemClick
            If class_Procedures.isEmpty(xuc_Account.Branch_Code) Then Return
            If class_Procedures.isEmpty(xuc_Account.Account_Code) Then Return
            If class_Procedures.isEmpty(xuc_Account.Ledger) Then Return

            class_Saga_Procedures.Show_Amortization(Me, xuc_Account.Branch_Code.EditValue, xuc_Account.Account_Code.Text.Trim, Convert.ToInt32(xuc_Account.Ledger.EditValue))
        End Sub

        Private Sub btn_History_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_History.ItemClick
            class_Saga_Procedures.Show_Unit_Inventory(xuc_Account.Engine.Text.Trim)
        End Sub

        Private Sub btn_Previous_Owners_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Previous_Owners.ItemClick
            class_Saga_Procedures.Show_Owners(xuc_Account.Engine.Text)
        End Sub

        Private Sub btn_Journal_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            class_Database.DBError = False
            If Not class_Procedures.actionAsk("Execute Account Journal Entries", "This might take longer time to execute") Then Return

            If class_Saga_Database.Journal_Entry_Save("RELEASE", Convert.ToInt32(xuc_Account.ID.EditValue), xuc_Account.Date_Granted.EditValue) Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Journal Entry [Sale/Release]:{Environment.NewLine}{xuc_Account.Account_Code.Text}-{xuc_Account.Ledger.EditValue}{Environment.NewLine}{xuc_Account.Customer_Name.Text}{Environment.NewLine}was successfully executed.")
                class_Saga_Procedures.Show_Journal_Entries_Reference(xuc_Account.Engine.Text, xuc_Account.ID.EditValue)
            End If
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
            class_Saga_Procedures.Show_Journal_Entries_Reference(xuc_Account.Engine.Text.Trim, xuc_Account.ID.EditValue, $"{xuc_Account.Account_Code.Text.Trim}-{xuc_Account.Ledger.Text}", xuc_Account.Customer_Name.Text.Trim,,, True)
        End Sub

        Private Sub btn_Amortization_Schedule_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Amortization_Schedule.ItemClick
            If class_Procedures.actionAsk("Amortization Schedule", "Re-Generate Amortization Schedule", "This will remove and then regenerate new sets of current Amortization schedules") Then
                With Me.xuc_Account
                    class_Database.Data_Delete_Quick(class_Database.ICSConnection, $"FROM AmortSched_md WHERE BranchCode LIKE '{ .Branch_Code.EditValue}' AND AccountNo LIKE '{ .Account_Code.Text}' AND LedgerSetNumber LIKE '{ .Ledger.EditValue}'")
                    Dim sqlParameters As SqlParameter() = {
                        New SqlParameter("@ParamInstallNo", Convert.ToInt32(.Terms.EditValue)),
                        New SqlParameter("@ParamBranchCode", .Branch_Code.EditValue),
                        New SqlParameter("@ParamAccountNo", .Account_Code.Text),
                        New SqlParameter("@ParamLedgerSetNumber", .Ledger.EditValue),
                        New SqlParameter("@ParamAmountFinance", convert.todecimal(.Financed.Value)),
                        New SqlParameter("@ParamDateGranted", convert.todatetime(.Date_Granted.EditValue)),
                        New SqlParameter("@ParamInteresRate", convert.todecimal(.Interest_Rate.EditValue)),
                        New SqlParameter("@SkipMarAprMay", Convert.ToBoolean(Toggle_Skip_Covid.Checked))
                    }

                    If class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "mg_create_schedule", "Amortization Schedule") Then
                        btn_Amortization_ItemClick(sender, e)
                    End If
                End With
            End If
        End Sub

        Private Sub btn_New_Row_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New_Row.ItemClick
            xuc_Account.gridView.AddNewRow()
        End Sub

        Private Sub btn_Amortization_Schedule_Document_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Amortization_Schedule_Document.ItemClick
            Try
                Dim xRpt As New Reports.Release.xrpt_Amortization_Schedule()

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", xuc_Account.Branch_Code.EditValue),
                    New SqlParameter("@Action_Type", "GET")
                }

                Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Branch_Procedures", True)
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        xRpt.Branch_Name.Text = myDataReader("Branch").ToString
                        xRpt.Branch_Address.Text = myDataReader("Address").ToString
                        xRpt.Branch_Manager.Text = myDataReader("BM").ToString
                    End If
                End Using

                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1300

                    .Customer_Name.Text = xuc_Account.Customer_Name.Text
                    .Customer_Name2.Text = xuc_Account.Customer_Name.Text
                    .Account_Code.Text = xuc_Account.Account_Code.Text
                    .Brand_Model.Text = $"{xuc_Account.Brand.Text} {xuc_Account.Model.Text} {xuc_Account.Color.Text}"
                    .Engine_Chassis.Text = $"{xuc_Account.Engine.Text} / {xuc_Account.Chassis.Text}"
                    .Key_Code.Text = xuc_Account.Key_Code.Text
                    .Terms.Text = xuc_Account.Terms.Text
                    .Total_Balance.Text = xuc_Account.Outstanding_Balance.Text

                    .Date_Granted.Text = xuc_Account.Date_Granted.Text
                    .Date_Maturity.Text = xuc_Account.Date_Maturity.Text
                End With

                class_Database.Bind_Report(class_Database.ICSConnection, xRpt, $"SELECT * FROM AmortSched_md WHERE AccountNo LIKE '{xuc_Account.Account_Code.Text}' AND LedgerSetNumber LIKE '{xuc_Account.Ledger.EditValue}' ORDER BY InstallNo", "AmortSched_md")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Certification_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Certification.ItemClick
            Try
                Dim xRpt As New Reports.Release.xrpt_Certification()

                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1100

                    .Month_Year.Text = $"{xuc_Account.Date_Granted:MMMM, yyyy}".ToUpper()

                    Dim iNth As Integer = Convert.ToDateTime(xuc_Account.Date_Granted.EditValue).Day
                    Dim sNth As String = class_Functions.GetOrdinal(iNth)
                    .Nth.Text = $"{iNth}{sNth}"
                End With

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Account_Code", xuc_Account.Account_Code.EditValue),
                    New SqlParameter("@Ledger", xuc_Account.Ledger.EditValue),
                    New SqlParameter("@Action_Type", "LOAD_ACCOUNT")
                }
                class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_MC_Sale_Procedures", "CustAccount")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Computation_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Computation.ItemClick
            Try
                Dim xRpt As New Reports.Release.xrpt_Computation()

                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1100

                    .Prepared_By.Text = class_Variables.sUserFullName
                    .Verified_By.Text = class_Saga_Database.get_Admin_Cashier(xuc_Account.Branch_Code.EditValue)
                End With

                Dim sqlParameters As SqlParameter() = {
                   New SqlParameter("@Account_Code", xuc_Account.Account_Code.EditValue),
                   New SqlParameter("@Ledger", xuc_Account.Ledger.EditValue),
                   New SqlParameter("@Action_Type", "LOAD_ACCOUNT")
               }
                class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_MC_Sale_Procedures", "CustAccount")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Waiver_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Waiver.ItemClick
            Try
                Dim xRpt As New Reports.Release.xrpt_Waiver()

                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1100
                End With

                Dim sqlParameters As SqlParameter() = {
                   New SqlParameter("@Account_Code", xuc_Account.Account_Code.EditValue),
                   New SqlParameter("@Ledger", xuc_Account.Ledger.EditValue),
                   New SqlParameter("@Action_Type", "LOAD_ACCOUNT")
               }
                class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_MC_Sale_Procedures", "CustAccount")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Pullout_Receipt_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Pullout_Receipt.ItemClick
            Try
                Dim xRpt As New Reports.Release.xrpt_Pull_Out()

                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1100

                    Dim iNth As Integer = Convert.ToDateTime(xuc_Account.Date_Granted.EditValue).Day
                    Dim sNth As String = class_Functions.GetOrdinal(iNth)
                    .Nth.Text = $"{iNth}{sNth}"
                End With

                Dim sqlParameters As SqlParameter() = {
                  New SqlParameter("@Account_Code", xuc_Account.Account_Code.EditValue),
                  New SqlParameter("@Ledger", xuc_Account.Ledger.EditValue),
                  New SqlParameter("@Action_Type", "LOAD_ACCOUNT")
                }
                class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_MC_Sale_Procedures", "CustAccount")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Chattel_Mortgage_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Chattel_Mortgage.ItemClick
            Try
                Dim xRpt As New Reports.Release.xrpt_Chattel_Mortgage()

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", xuc_Account.Branch_Code.EditValue),
                    New SqlParameter("@Action_Type", "GET")
                }

                Dim sBranchName As String = String.Empty
                Dim sBranchAddress As String = String.Empty
                Dim sBranchManager As String = String.Empty
                Dim sCTCNumber As String = String.Empty
                Dim sCTCPlace As String = String.Empty

                Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Branch_Procedures", True)
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        sBranchName = myDataReader("Branch").ToString
                        sBranchAddress = myDataReader("Address").ToString
                        sBranchManager = myDataReader("BM").ToString
                        sCTCNumber = myDataReader("CTC_Number").ToString
                        sCTCPlace = myDataReader("CTC_Place").ToString
                    End If
                End Using

                xRpt.Branch_Name.Text = sBranchName
                xRpt.Branch_Address.Text = sBranchAddress
                xRpt.Branch_Manager.Text = sBranchManager
                xRpt.Branch_Manager2.Text = sBranchManager

                xRpt.Branch_Manager3.Text = sBranchManager
                xRpt.CTC_Number_BM.Text = sCTCNumber
                xRpt.CTC_Place_BM.Text = sCTCPlace

                xRpt.CSA_Name.Text = $"{class_Variables.sUserFullName}"
                Dim sAECode As String = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT AccountNumber, AccountExecutive FROM CustAccount WHERE AccountNumber LIKE '{xuc_Account.Account_Code.EditValue}'", "AccountExecutive")
                Dim sAEName As String = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT AccountExecutive, OfficerName FROM AccountExecutives WHERE AccountExecutive LIKE '{sAECode}'", "OfficerName")
                xRpt.AE_Name.Text = $"{sAEName}"

                Dim sCustomerName As String = String.Empty
                Dim sCustomerAddress As String = String.Empty
                Dim sBrand As String = String.Empty
                Dim sModel As String = String.Empty
                Dim sColor As String = String.Empty
                Dim sEngine As String = String.Empty
                Dim sChassis As String = String.Empty

                Dim dFinanced As Decimal = 0
                Dim dRatePerAnnum As Decimal = 0

                Dim dtGranted As Date

                Dim AccountParameters As SqlParameter() = {
                    New SqlParameter("@Account_Code", xuc_Account.Account_Code.EditValue),
                    New SqlParameter("@Ledger", xuc_Account.Ledger.EditValue),
                    New SqlParameter("@Action_Type", "LOAD_ACCOUNT")
                }

                Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, AccountParameters, "inv_MC_Sale_Procedures", True)
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        dtGranted = Convert.ToDateTime(myDataReader("Date_Granted"))
                        sCustomerName = myDataReader("Customer_Name").ToString
                        sCustomerAddress = myDataReader("Customer_Address").ToString
                        sBrand = myDataReader("Brand").ToString
                        sModel = myDataReader("Model").ToString
                        sColor = myDataReader("Color").ToString
                        sEngine = myDataReader("Engine").ToString
                        sChassis = myDataReader("Chassis").ToString
                        dFinanced = Convert.ToDecimal(myDataReader("Financed"))
                        dRatePerAnnum = Convert.ToDecimal(myDataReader("Rate_Per_Annum"))
                    End If
                End Using

                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1100

                    Dim iNth As Integer = Convert.ToDateTime(xuc_Account.Date_Granted.EditValue).Day
                    Dim sNth As String = class_Functions.GetOrdinal(iNth)
                    .This_Deed_Of_Chattel_Mortgage.Text = $"{vbTab}This DEED OF CHATTEL MORTGAGE, executed this {iNth}{sNth} day of {dtGranted:MMMM, yyyy} by {sCustomerName}, Filipino citizen, single/married/widow(er), of legal age and a resident of {sCustomerAddress}, hereinafter referred to as the 'MORTGAGOR', and SAGA FINANCE CORPORATION, a corporation duly organized and existing under and by virtue of Philippine laws with business address at {sBranchName}, represented in this instance by its duly authorized representative, {sBranchManager}, hereinafter referred to as the 'MORTGAGEE';"
                    .That_The_Mortgator_Hereby.Text = $"{vbTab}1. That the MORTGAGOR hereby transfers and conveys by way of chattel mortgage to the MORTGAGEE, its successors and assigns, the following described personal property situated and ordinarily kept in {sCustomerAddress}, now in the possession of the MORTGAGOR unencumbered and free from all claims whatsoever of any person or entity, to wit:"
                    .Brand.Text = sBrand
                    .Model.Text = sModel
                    .Color.Text = sColor
                    .Engine.Text = sEngine
                    .Chassis.Text = sChassis
                    .That_The_Said_Chattel.Text = $"{vbTab}2. That the said chattel is given as security for the payment of a loan obtained by the MORTGAGOR from the MORTGAGEE in the amount of {class_Functions.AmountToWords(dFinanced)} ({dFinanced:N2}), Philippine currency, payable with interest at the rate of {class_Functions.AmountToWords(dRatePerAnnum, False)} percent ({dRatePerAnnum}%) per annum, in accordance with the following payment schedule:"
                    .In_Witness_Hereof.Text = $"{vbTab}IN WITNESS WHEREOF, the parties hereto have signed this instrument this {iNth}{sNth} day of {dtGranted:MMMM, yyyy} in {sBranchAddress}, Philippines."
                End With

                class_Database.Bind_Report(class_Database.ICSConnection, xRpt, $"SELECT * FROM CustAccount WHERE AccountNumber LIKE '{xuc_Account.Account_Code.Text}' AND LedgerSetNumber LIKE '{xuc_Account.Ledger.EditValue}'", "CustAccount")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Deed_Of_Reconveyance_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Deed_Of_Reconveyance.ItemClick
            Try
                Dim xRpt As New Reports.Release.xrpt_Deed_Of_Reconveyance()
                class_Database.Bind_Report(class_Database.ICSConnection, xRpt, $"SELECT * FROM CustAccount WHERE AccountNumber LIKE '{xuc_Account.Account_Code.Text}' AND LedgerSetNumber LIKE '{xuc_Account.Ledger.EditValue}'", "CustAccount")

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", xuc_Account.Branch_Code.EditValue),
                    New SqlParameter("@Action_Type", "GET")
                }

                Dim sBranchName As String = String.Empty
                Dim sBranchAddress As String = String.Empty
                Dim sBranchManager As String = String.Empty

                Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Branch_Procedures", True)
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        sBranchName = myDataReader("Branch").ToString
                        sBranchAddress = myDataReader("Address").ToString
                        sBranchManager = myDataReader("BM").ToString
                    End If
                End Using

                xRpt.Branch_Name.Text = sBranchName
                xRpt.Branch_Address.Text = sBranchAddress
                xRpt.Branch_Address2.Text = sBranchAddress

                xRpt.CSA_Name.Text = $"{class_Variables.sUserFullName}"
                Dim sAECode As String = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT AccountNumber, AccountExecutive FROM CustAccount WHERE AccountNumber LIKE '{xuc_Account.Account_Code.EditValue}'", "AccountExecutive")
                Dim sAEName As String = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT AccountExecutive, OfficerName FROM AccountExecutives WHERE AccountExecutive LIKE '{sAECode}'", "OfficerName")
                xRpt.AE_Name.Text = $"{sAEName}"

                Dim sCustomerName As String = String.Empty
                Dim sCustomerAddress As String = String.Empty
                Dim sBrand As String = String.Empty
                Dim sModel As String = String.Empty
                Dim sColor As String = String.Empty
                Dim sEngine As String = String.Empty
                Dim sChassis As String = String.Empty

                Dim dFinanced As Decimal = 0
                Dim dRatePerAnnum As Decimal = 0

                Dim dtGranted As Date

                Dim AccountParameters As SqlParameter() = {
                    New SqlParameter("@Account_Code", xuc_Account.Account_Code.EditValue),
                    New SqlParameter("@Ledger", xuc_Account.Ledger.EditValue),
                    New SqlParameter("@Action_Type", "LOAD_ACCOUNT")
                }

                Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, AccountParameters, "inv_MC_Sale_Procedures", True)
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        dtGranted = Convert.ToDateTime(myDataReader("Date_Granted"))
                        sCustomerName = myDataReader("Customer_Name").ToString
                        sCustomerAddress = myDataReader("Customer_Address").ToString
                        sBrand = myDataReader("Brand").ToString
                        sModel = myDataReader("Model").ToString
                        sColor = myDataReader("Color").ToString
                        sEngine = myDataReader("Engine").ToString
                        sChassis = myDataReader("Chassis").ToString
                        dFinanced = Convert.ToDecimal(myDataReader("Financed"))
                        dRatePerAnnum = Convert.ToDecimal(myDataReader("Rate_Per_Annum"))
                    End If
                End Using

                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1100

                    Dim iNth As Integer = Convert.ToDateTime(xuc_Account.Date_Granted.EditValue).Day
                    Dim sNth As String = class_Functions.GetOrdinal(iNth)
                    .That_I_Of_Legal_Age.Text = $"{vbTab}That I, {xuc_Account.Customer_Name.Text} of legal age, Filipino, married/single and a resident of {xuc_Account.Customer_Address.Text} hereby consents and voluntarily  give to SAGA FINANCE CORPORATION by way of reconveyance the herein below described motorcycle/ motorvehicle in view of my failure to faithfully pay my monthly installments:"
                    .Brand.Text = sBrand
                    .Model.Text = sModel
                    .Color.Text = sColor
                    .Engine.Text = sEngine
                    .Chassis.Text = sChassis
                    .Before_Me_Notary_Public.Text = $"{vbTab}BEFORE ME, Notary Public for and in the ______________________________ personally appeared the herein party who exhibited to me his/her Residence Certificate Number {xuc_Account.CTC_Number.Text} issued on {xuc_Account.CTC_Date.EditValue:MMMM dd, yyyy} at {xuc_Account.CTC_Place.Text} and who acknowleged the same is his/her voluntary act and deed and made for the used and purposes therein set forth."
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Deed_Of_Sale_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Deed_Of_Sale.ItemClick
            Try
                Dim xRpt As New Reports.Release.xrpt_Deed_Of_Sale()

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", xuc_Account.Branch_Code.EditValue),
                    New SqlParameter("@Action_Type", "GET")
                }

                Dim sBranchName As String = String.Empty
                Dim sBranchAddress As String = String.Empty
                Dim sBranchManager As String = String.Empty
                Dim sCTCNumber As String = String.Empty
                Dim sCTCPlace As String = String.Empty

                Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_Branch_Procedures", True)
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        sBranchName = myDataReader("Branch").ToString
                        sBranchAddress = myDataReader("Address").ToString
                        sBranchManager = myDataReader("BM").ToString
                        sCTCNumber = myDataReader("CTC_Number").ToString
                        sCTCPlace = myDataReader("CTC_Place").ToString
                    End If
                End Using

                xRpt.Branch_Name.Text = sBranchName
                xRpt.Branch_Address.Text = sBranchAddress
                xRpt.Branch_Manager.Text = sBranchManager

                xRpt.CSA_Name.Text = $"{class_Variables.sUserFullName}"
                Dim sAECode As String = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT AccountNumber, AccountExecutive FROM CustAccount WHERE AccountNumber LIKE '{xuc_Account.Account_Code.EditValue}'", "AccountExecutive")
                Dim sAEName As String = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT AccountExecutive, OfficerName FROM AccountExecutives WHERE AccountExecutive LIKE '{sAECode}'", "OfficerName")
                xRpt.AE_Name.Text = $"{sAEName}"

                Dim sCustomerName As String = String.Empty
                Dim sCustomerAddress As String = String.Empty
                Dim sBrand As String = String.Empty
                Dim sModel As String = String.Empty
                Dim sColor As String = String.Empty
                Dim sEngine As String = String.Empty
                Dim sChassis As String = String.Empty

                Dim dFinanced As Decimal = 0
                Dim dRatePerAnnum As Decimal = 0

                Dim dtGranted As Date

                Dim AccountParameters As SqlParameter() = {
                    New SqlParameter("@Account_Code", xuc_Account.Account_Code.EditValue),
                    New SqlParameter("@Ledger", xuc_Account.Ledger.EditValue),
                    New SqlParameter("@Action_Type", "LOAD_ACCOUNT")
                }

                Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, AccountParameters, "inv_MC_Sale_Procedures", True)
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        myDataReader.Read()
                        dtGranted = Convert.ToDateTime(myDataReader("Date_Granted"))
                        sCustomerName = myDataReader("Customer_Name").ToString
                        sCustomerAddress = myDataReader("Customer_Address").ToString
                        sBrand = myDataReader("Brand").ToString
                        sModel = myDataReader("Model").ToString
                        sColor = myDataReader("Color").ToString
                        sEngine = myDataReader("Engine").ToString
                        sChassis = myDataReader("Chassis").ToString
                        dFinanced = Convert.ToDecimal(myDataReader("Financed"))
                        dRatePerAnnum = Convert.ToDecimal(myDataReader("Rate_Per_Annum"))
                    End If
                End Using

                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1100

                    Dim iNth As Integer = Convert.ToDateTime(xuc_Account.Date_Granted.EditValue).Day
                    Dim sNth As String = class_Functions.GetOrdinal(iNth)
                    .That_I_Customer_Name.Text = $"{vbTab}That I, {xuc_Account.Customer_Name.Text} of legal age, Filipino, married/single and a resident of {xuc_Account.Customer_Address.Text}, Philippines for and in consideration of the sum pesos {class_Functions.AmountToWords(dFinanced)} Php ({dFinanced:N2}) Philippine currency and other valuable consideration paid in hand to me by ________________________________________ likewise of legal age, Filipino, married/single and a resident of ________________________________________ , Philippines, receipt of which is hereby acknowledge to my entire satisfaction do hereby CEDE, SELL, TRANSFER and assigns all my rights, interests participation and ownership to and in the following described motorcycle/motorvehicle to wit:"
                    .Brand.Text = sBrand
                    .Model.Text = sModel
                    .Color.Text = sColor
                    .Engine.Text = sEngine
                    .Chassis.Text = sChassis
                    .Before_Me_A_Notary_Public.Text = $"{vbTab}Before me a notary public in and for the Province of ______________________________, Philippines this _____ day of ____________________, _____ personally appeared {xuc_Account.Customer_Name.Text} with this Residence Certificate Number {xuc_Account.CTC_Number.Text} issued at {xuc_Account.CTC_Place} known to be the  same person who executed the foregoing instrument which they acknowledge as their free act and voluntary deed and that the entities they represent and they oath to the truth of the foregoing affidavit of good."
                End With

                class_Database.Bind_Report(class_Database.ICSConnection, xRpt, $"SELECT * FROM CustAccount WHERE AccountNumber LIKE '{xuc_Account.Account_Code.Text}' AND LedgerSetNumber LIKE '{xuc_Account.Ledger.EditValue}'", "CustAccount")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Disclosure_Statement_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Disclosure_Statement.ItemClick
            Try
                Dim xRpt As New Reports.Release.xrpt_Disclosure_Statement()

                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 1100
                End With

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Account_Code", xuc_Account.Account_Code.EditValue),
                    New SqlParameter("@Ledger", xuc_Account.Ledger.EditValue),
                    New SqlParameter("@Action_Type", "LOAD_ACCOUNT")
                }
                class_Database.Procedure_Bind_Report(class_Database.ICSConnection, sqlParameters, xRpt, "inv_MC_Sale_Procedures", "CustAccount")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub
    End Class

End Namespace