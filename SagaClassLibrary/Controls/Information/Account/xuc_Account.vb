Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Controls.Information.Account

    Public Class xuc_Account
        Inherits DevExpress.XtraEditors.XtraUserControl

        Private _retrieved As Boolean
        Friend Property Retrieved() As Boolean
            Get
                Return _retrieved
            End Get
            Set(value As Boolean)
                _retrieved = value
            End Set
        End Property

        Friend sAddedBy As String
        Private sPrevOwner As String = String.Empty
        Private sSICodeOld As String = String.Empty
        Private sCRCodeOld As String = String.Empty

        Public Sub New()
            InitializeComponent()

            Branch_Code.Enabled = class_Variables.isAdministrator
        End Sub

        Friend Sub Control_Initialize_Lookups()
            class_Saga_Procedures.Initialize_Corporation(Corporation)
            class_Saga_Procedures.Initialize_Branch(Branch_Code)
            class_Saga_Procedures.Initialize_Warehouse(Unit_Status)
            class_Saga_Procedures.Initialize_MC_Release_Type(Sale_Type)

            class_Saga_Variables.Initialize_AE(Branch_Code.EditValue)
            class_Saga_Procedures.Initialize_AE(AE_Code)

            class_Saga_Variables.Initialize_Agent(Branch_Code.EditValue)
            class_Saga_Procedures.Initialize_Agent(Agent_Code)

            class_Saga_Procedures.Initialize_MC_Promotions(Promo_Code)

            If ID.EditValue.Equals(0) Then
                class_Saga_Variables.Initialize_MC_Units(Branch_Code.EditValue, True)
                class_Saga_Procedures.Initialize_MC_Units(Engine)
            End If

            'temporary disable on development purpose
            'class_Saga_Procedures.Initialize_MC_Freebies(RepositoryItemLookUpEdit_Freebie, Branch_Code.EditValue)


            'class_Database.BindData(class_Database.SPAConnection, Freebies, $"SELECT DISTINCT (PartsNumber), ID, Brand, Category, PartsName, Quantity, SRP FROM Spare_Parts.dbo.SPA_Inventory WHERE ReceivingBranch LIKE {Branch_Code.EditValue}", "Spare_Parts.dbo.SPA_Inventory")

            'Dim sqlParameters As SqlParameter() = {
            '    New SqlParameter("@Branch_Code", Branch_Code.EditValue),
            '    New SqlParameter("@Action_Type", "LOAD_FREEBIES")
            '}

            'Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_MC_Sale_Procedures")
            '    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
            '        myDataReader.Read()
            '        Freebies.Properties.DataSource = myDataReader
            '    End If
            'End Using
        End Sub

        Friend Sub Control_Initialize()
            Control_Initialize_Lookups()
            class_Database.Fill_Edit(class_Database.ICSConnection, Account_Status, "CustAccount", "AccountStatus")
            class_Database.Fill_Edit(class_Database.ICSConnection, Brand, "maint_model", "branddesc")
            class_Database.Fill_Edit(class_Database.ICSConnection, Model, "maint_model", "modeldesc")
            class_Database.Fill_Edit(class_Database.ICSConnection, Color, "maint_model", "Custom_Color")
            class_Database.Fill_Edit(class_Database.ICSConnection, Sale_Type, "CustAccount", "SaleType")
            class_Database.Fill_Edit(class_Database.ICSConnection, Release_Type, "CustAccount", "ReleaseType")
            'class_Database.Fill_Edit(class_Database.ICSConnection, Account_Terms, "CustAccount", "Terms")
            class_Database.Fill_Edit(class_Database.ICSConnection, Interest_Rate, "CustAccount", "InterestRate")
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = False)
            class_Procedures.Initialize_Controls(Me, bAsk)

            If bAsk AndAlso Not class_Procedures.actionAsk("New Account Profile", "Initailize new Account Profile", "You might lose unsaved data") Then Return

            Control_Initialize()

            Account_Code.Text = $"SALE{Branch_Code.EditValue}{Date.Now:yyyyMMddhhmmss}"

            Ledger.EditValue = 1
            Account_Code.ReadOnly = True


            Agent_Code.EditValue = $"{Branch_Code.EditValue}00"

            Release_Type.EditValue = "ICS"
            Release_Type.ReadOnly = True

            class_Saga_Variables.Initialize_MC_Units(Branch_Code.EditValue, True)
            class_Saga_Procedures.Initialize_MC_Units(Engine)

            Chassis.ReadOnly = Not class_Saga_Variables.isAccounting
            Brand.ReadOnly = Not class_Saga_Variables.isAccounting
            Model.ReadOnly = Not class_Saga_Variables.isAccounting
            Color.ReadOnly = Not class_Saga_Variables.isAccounting

            'class_Procedures.Initialize_gridView(gridView, True, True)
            'temporary disable on development purpose
            'class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM CustFreebie WHERE AccountNumber LIKE '{Account_Code.Text.Trim}' AND LedgerSetNumber LIKE '{Ledger.EditValue}'", "CustFreebie")

            SI_Code.Properties.MaskSettings.Set("mask", $"{Branch_Code.GetColumnValue("Pre_Code")}-SI0000")

            Customer_Code.Select()
        End Sub

        Friend Function Control_Retrieve(ByVal sQuery As String) As Boolean
            Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, sQuery)
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()

                        Dim iInventoryID As Integer = Convert.ToInt32(myDataReader("id"))
                        sPrevOwner = myDataReader("PrevAccountName").ToString

                        ID.EditValue = myDataReader("sequenceNo").ToString
                        Branch_Code.EditValue = myDataReader("BranchCode").ToString

                        Agent_Code.EditValue = myDataReader("AgentCode").ToString
                        AE_Code.EditValue = myDataReader("AccountExecutive").ToString

                        Customer_Code.Text = myDataReader("CIFKey").ToString
                        Account_Code.Text = myDataReader("AccountNumber").ToString
                        Customer_Name.Text = myDataReader("AccountName").ToString
                        Customer_Address.Text = myDataReader("AccountAddress").ToString

                        Engine.Text = myDataReader("EngineNo").ToString
                        Chassis.Text = myDataReader("ChassisNo").ToString
                        Brand.Text = myDataReader("Brand").ToString
                        Model.Text = myDataReader("Model").ToString
                        Color.Text = myDataReader("Color").ToString
                        Key_Code.Text = myDataReader("KeyNo").ToString

                        Corporation.EditValue = myDataReader("CORP").ToString
                        Unit_Status.EditValue = myDataReader("whCode").ToString
                        Sale_Type.EditValue = myDataReader("SaleType").ToString
                        Release_Type.Text = myDataReader("ReleaseType").ToString
                        Toggle_Assume.IsOn = myDataReader("Tag").ToString.Equals("ASM")
                        Account_Status.Text = myDataReader("AccountStatus").ToString
                        Financed.EditValue = myDataReader("FinancedAmt")
                        COD.EditValue = myDataReader("COD")
                        LCP.EditValue = myDataReader("LCP")
                        Down_Payment.EditValue = myDataReader("DP")
                        AOC.EditValue = myDataReader("AOC")
                        Discount.EditValue = myDataReader("DiscAmt")
                        Date_Granted.Text = myDataReader("DateGranted").ToString
                        Date_Maturity.Text = myDataReader("MaturityDate").ToString
                        Date_First_Payment.Text = myDataReader("FirstPayDate").ToString
                        Date_Updated.Text = myDataReader("LastMvmtDate").ToString
                        Monthly_Principal.EditValue = myDataReader("PrincipalPMT")
                        Monthly_Interest.EditValue = myDataReader("InterestPMT")
                        Terms.EditValue = myDataReader("Terms")
                        Interest_Rate.EditValue = myDataReader("InterestRate")
                        Amortization.EditValue = myDataReader("PMT")
                        Rebate.EditValue = myDataReader("Rebates")
                        Begin_Principal.EditValue = myDataReader("TempPrin")
                        Begin_Interest.EditValue = myDataReader("TempInt")
                        Begin_Outstanding.Value = Begin_Principal.Value + Begin_Interest.Value
                        Outstanding_Principal.EditValue = myDataReader("PrincipalBalance")
                        Outstanding_Interest.EditValue = myDataReader("InterestBalance")
                        Outstanding_Balance.EditValue = myDataReader("OutstandingBalance")

                        SI_Code.Properties.ResetMaskSettings()
                        SI_Code.Text = myDataReader("ORNo").ToString
                        sSICodeOld = myDataReader("ORNo").ToString

                        CR_Code.Properties.ResetMaskSettings()
                        CR_Code.Text = myDataReader("CRNo").ToString
                        sCRCodeOld = myDataReader("CRNo").ToString

                        SFC_Payable.EditValue = myDataReader("SFCPayable")

                        Remarks.Text = myDataReader("Remarks").ToString
                        sAddedBy = myDataReader("TransactedBy").ToString
                        Ledger.Text = myDataReader("LedgerSetNumber").ToString

                        class_Saga_Variables.Initialize_Agent(Branch_Code.EditValue)
                        class_Saga_Procedures.Initialize_Agent(Agent_Code)

                        class_Saga_Variables.Initialize_AE(Branch_Code.EditValue)
                        class_Saga_Procedures.Initialize_AE(AE_Code)

                        class_Saga_Variables.Initialize_MC_Unit(Engine.EditValue)
                        class_Saga_Procedures.Initialize_Engine_Chassis(Engine)

                        Load_Inventory_ID()
                        Account_Inventory_ID.EditValue = iInventoryID
                        Account_Inventory_ID.ClosePopup()

                        Load_Previous_Customers()
                        PrevAccountName.Text = sPrevOwner
                        PrevAccountName.ClosePopup()

                        class_Procedures.Initialize_gridView(gridView, True, True)
                        class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM CustFreebie WHERE AccountNumber LIKE '{Account_Code.Text.Trim}' AND LedgerSetNumber LIKE '{Ledger.EditValue}'", "CustFreebie")

                        If Not IsDBNull(myDataReader("CTC_Number")) Then
                            CTC_Number.Text = myDataReader("CTC_Number")
                            CTC_Date.EditValue = Convert.ToDateTime(myDataReader("CTC_Date"))
                            CTC_Place.Text = myDataReader("CTC_Place")
                        End If

                        Return True
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    Finally
                        Customer_Name.Select()
                    End Try
                End If
            End Using
            Return False
        End Function

        Private Sub Customer_Code_BeforePopup(sender As Object, e As EventArgs) Handles Customer_Code.BeforePopup
            PopupContainerControl.Width = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Width", 500)
            PopupContainerControl.Height = class_Tools.RegKeyGet(Me.Name, $"{PopupContainerControl}_Height", 400)
        End Sub

        Private Sub Customer_Code_Popup(sender As Object, e As EventArgs) Handles Customer_Code.Popup
            If class_Procedures.isEmpty(Branch_Code) Then Return
            xuc_Account_Search.searchMode = xuc_Account_Search.Search_Mode.searchCustomer
            xuc_Account_Search.Load_Search(Customer_Code.Text.Trim)
        End Sub

        Private Sub Customer_Code_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles Customer_Code.Closed
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Width", PopupContainerControl.Width)
            class_Tools.RegKeySet(Me.Name, $"{PopupContainerControl}_Height", PopupContainerControl.Height)

            Customer_Code.Text = xuc_Account_Search.Code
            Customer_Name.Text = xuc_Account_Search.AccountName
            Customer_Address.Text = xuc_Account_Search.Others
            Agent_Code.Select()
        End Sub

        Private Sub Engine_Validated(sender As Object, e As EventArgs) Handles Engine.Validated

        End Sub

        Friend Sub Load_Inventory_ID()
            class_Database.Bind_Data(class_Database.ICSConnection, Account_Inventory_ID, $"SELECT id, whCode, whcategory, EngineNo, dateReceived FROM item_Details WHERE EngineNo LIKE '{Engine.Text.Trim}' ORDER BY id", "item_Details")
        End Sub

        Friend Sub Load_Previous_Customers()
            class_Database.Bind_Data(class_Database.ICSConnection, PrevAccountName, $"SELECT sequenceNo, AccountNumber, LedgerSetNumber, AccountName, EngineNo, DateGranted FROM CustAccount WHERE EngineNo LIKE '{Engine.Text.Trim}' AND sequenceNo < '{ID.EditValue}' ORDER BY sequenceNo", "CustAccount")
        End Sub

        Private Sub Engine_KeyDown(sender As Object, e As KeyEventArgs) Handles Engine.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then
                Chassis.Text = Engine.GetColumnValue("ChassisNo")
                Brand.Text = Engine.GetColumnValue("Brand")
                Model.Text = Engine.GetColumnValue("Model")
                Color.Text = Engine.GetColumnValue("Color")

                Unit_Status.EditValue = Engine.GetColumnValue("WHCode")
                If Unit_Status.EditValue = "REP" Then
                    Corporation.EditValue = "SFC"
                Else
                    Corporation.EditValue = "SMC"
                End If

                Me.CR_Code.Properties.MaskSettings.Set("mask", $"{Branch_Code.GetColumnValue("Pre_Code")}-CR{Corporation.EditValue.Substring(1, 1)}0000")

                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Model_Code", Engine.GetColumnValue("Model_Code")),
                    New SqlParameter("@Action_Type", "RETRIEVE")
                }

                Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "inv_Model_Procedures")
                    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                        Try
                            myDataReader.Read()
                            COD.Value = Convert.ToDecimal(myDataReader("COD"))
                            LCP.Value = Convert.ToDecimal(myDataReader("LCP"))
                            AOC.Value = Convert.ToDecimal(myDataReader("AOC"))
                            Rebate.Value = Convert.ToDecimal(myDataReader("Rebates"))
                            Down_Payment.Value = Convert.ToDecimal(myDataReader("DownPayment"))
                            Financed.Value = Convert.ToDecimal(myDataReader("Financed"))
                            Rebate.Value = Convert.ToDecimal(myDataReader("Rebates"))
                            Sale_Type.Text = "FIN"
                            Terms.EditValue = 36
                            Interest_Rate.Text = Convert.ToDecimal(myDataReader("InterestRate36"))
                            Promo_Code.EditValue = "PROMO-1"
                        Catch ex As Exception
                            class_Procedures.Show_Error(ex)
                        End Try
                    End If
                End Using
            End If
        End Sub

        Private Sub Sale_Type_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Sale_Type.EditValueChanged
            LCP.Enabled = Not Sale_Type.Text.Contains("COD")
            Down_Payment.Enabled = Sale_Type.Text.Equals("ECOD") Or Sale_Type.Text.Equals("TCOD") Or Sale_Type.Text.Contains("FIN")
            AOC.Enabled = Not Sale_Type.Text.Contains("COD")
            Financed.Enabled = Not Sale_Type.Text.Contains("COD")
            Date_Maturity.Enabled = Not Sale_Type.Text.Contains("COD")
            Date_First_Payment.Enabled = Not Sale_Type.Text.Contains("COD")
            Date_Updated.Enabled = Not Sale_Type.Text.Contains("COD")
            Monthly_Principal.Enabled = Not Sale_Type.Text.Contains("COD")
            Monthly_Interest.Enabled = Not Sale_Type.Text.Contains("COD")
            Terms.Enabled = Sale_Type.Text.Equals("TCOD") Or Sale_Type.Text.Contains("FIN")
            If Sale_Type.Text.Equals("TCOD") Then Terms.EditValue = 3
            If Sale_Type.Text.Contains("FIN") Then Terms.EditValue = 36
            Interest_Rate.Enabled = Sale_Type.Text.Equals("TCOD") Or Sale_Type.Text.Contains("FIN")
            Amortization.Enabled = Not Sale_Type.Text.Contains("COD")
            Rebate.Enabled = Not Sale_Type.Text.Contains("COD")
            Begin_Principal.Enabled = Not Sale_Type.Text.Contains("COD")
            Begin_Interest.Enabled = Not Sale_Type.Text.Contains("COD")
            Begin_Outstanding.Enabled = Not Sale_Type.Text.Contains("COD")
            Outstanding_Principal.Enabled = Not Sale_Type.Text.Contains("COD")
            Outstanding_Interest.Enabled = Not Sale_Type.Text.Contains("COD")
            Outstanding_Balance.Enabled = Not Sale_Type.Text.Contains("COD")
            Account_Partial.Enabled = Not Sale_Type.Text.Contains("COD")
        End Sub

        Private Sub set_Monthly_Amortization()
            Try
                If Down_Payment.Value < AOC.Value Then
                    Down_Payment.Value = AOC.Value
                End If

                If Sale_Type.Text.Contains("COD") Then
                    AOC.Value = 0
                    Rebate.Value = 0
                End If

                Financed.Value = (COD.Value - (Down_Payment.Value - AOC.Value) - Discount.Value)

                Select Case Sale_Type.EditValue
                    Case "COD"
                        Interest_Rate.EditValue = 0

                    Case "ECOD"
                        Terms.EditValue = 1
                        Interest_Rate.EditValue = 0

                    Case "TCOD"
                        Terms.EditValue = 3

                    Case "FIN"
                        Financed.Value = (LCP.Value - (Down_Payment.Value - AOC.Value) - Discount.Value)
                End Select

                Dim iTerms As Integer = Convert.ToInt32(Terms.EditValue)
                Dim dRate As Decimal = Convert.ToDecimal(Interest_Rate.Text)

                Amortization.Value = Math.Round((Financed.Value + Math.Round(class_Functions.Percent(Financed.Value, dRate), 0)) / iTerms, 0)
                Monthly_Principal.Value = Math.Round(Financed.Value / iTerms, 2, MidpointRounding.AwayFromZero)
                Monthly_Interest.EditValue = Math.Round(Amortization.Value - Monthly_Principal.Value, 2)

                Begin_Principal.Value = Math.Round(Monthly_Principal.Value * iTerms, 2)
                Begin_Interest.Value = Math.Round(Monthly_Interest.Value * iTerms, 2)
                Begin_Outstanding.Value = Amortization.Value * iTerms
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub Down_Payment_Validated(sender As Object, e As EventArgs) Handles Down_Payment.Validated
            set_Monthly_Amortization()
        End Sub

        Private Sub LCP_Validated(sender As Object, e As EventArgs) Handles LCP.Validated
            set_Monthly_Amortization()
        End Sub

        Private Sub Terms_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles Terms.Validated
            'Select Case e.KeyCode
            '    Case Keys.Enter
            If Terms.EditValue > 6 Then
                Interest_Rate.EditValue = Math.Round(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT * FROM maint_model WHERE Model_Code LIKE '{Engine.GetColumnValue("Model_Code")}'", $"InterestRate{Terms.EditValue}"), 2)
            End If
            set_Monthly_Amortization()
            '    Case Else
            'End Select
        End Sub

        Private Sub Interest_Rate_Validated(sender As Object, e As EventArgs) Handles Interest_Rate.Validated
            set_Monthly_Amortization()
        End Sub

        Private Sub set_Next_Payment()
            Try
                Dim iTerms As Integer = Convert.ToInt32(Terms.EditValue)
                Date_First_Payment.EditValue = Convert.ToDateTime(Date_Granted.EditValue).AddMonths(1)
                Dim iDay As Integer = Convert.ToDateTime(Date_First_Payment.EditValue).Day

                If iDay >= 16 Then
                    While Convert.ToDateTime(Date_First_Payment.EditValue).Day <> 3
                        Date_First_Payment.EditValue = Convert.ToDateTime(Date_First_Payment.EditValue).AddDays(1)
                    End While
                Else
                    While Convert.ToDateTime(Date_First_Payment.EditValue).Day <> 18
                        Date_First_Payment.EditValue = Convert.ToDateTime(Date_First_Payment.EditValue).AddDays(1)
                    End While
                End If

                Date_Maturity.EditValue = Convert.ToDateTime(Date_First_Payment.EditValue).AddMonths(iTerms - 1)
                If Convert.ToDateTime(Date_Updated.EditValue) < Convert.ToDateTime(Date_Granted.EditValue) Then Date_Updated.EditValue = Date_Granted.EditValue
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub Date_Granted_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles Date_Granted.Validated
            If Convert.ToDateTime(Date_Granted.EditValue).Year > Date.Today.Year Then
                Dim dt1 As DateTime = Convert.ToDateTime(Date_Granted.EditValue)
                Dim dt2 As DateTime = New DateTime(Date.Today.Year, dt1.Month, dt1.Day)
                Date_Granted.EditValue = dt2
            End If
            set_Next_Payment()
        End Sub

        Private Sub Date_Updated_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Date_Updated.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then

                Try
                    If Convert.ToDateTime(Date_Updated.EditValue) > Date.Today Then
                        Date_Updated.EditValue = Date.Today
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, "Date updated must be equal or earlier then today!")
                    End If

                    If Date_Granted.Text Is Date_Updated.Text Then
                        Outstanding_Balance.Value = Begin_Outstanding.Value
                    Else
                        Dim iMOnths As Integer = class_Functions.GetMonthDifference(Convert.ToDateTime(Date_First_Payment.Text), Convert.ToDateTime(Date_Updated.Text))
                        Outstanding_Balance.Value = Convert.ToDecimal(Begin_Outstanding.EditValue) - (Convert.ToDecimal(Amortization.EditValue) * (iMOnths + 1))
                    End If

                    Account_Outstanding_KeyDown(sender, e)
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub Account_Outstanding_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Outstanding_Balance.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then
                Outstanding_Principal.Value = 0
                Outstanding_Interest.Value = 0

                While Outstanding_Balance.Value > (Outstanding_Principal.Value + Outstanding_Interest.Value)
                    Outstanding_Principal.Value += Monthly_Principal.Value
                    Outstanding_Interest.Value += Monthly_Interest.Value
                End While

                Account_Partial.Value = Outstanding_Balance.Value - (Outstanding_Principal.Value + Outstanding_Interest.Value)
                Outstanding_Interest.Value += Account_Partial.Value
            End If
        End Sub

        Friend Function control_Migrate() As Boolean
            If class_Procedures.isEmpty(Branch_Code) Then Return False
            If class_Procedures.isEmpty(Account_Code) Then Return False
            If class_Procedures.isEmpty(Ledger) Then Return False
            If class_Procedures.isEmpty(Customer_Name) Then Return False
            If class_Procedures.isEmpty(Customer_Address) Then Return False
            If class_Procedures.isEmpty(AE_Code) Then Return False
            If class_Procedures.isEmpty(Model) Then Return False
            If class_Procedures.isEmpty(Brand) Then Return False
            If class_Procedures.isEmpty(Color) Then Return False
            If class_Procedures.isEmpty(Key_Code) Then Return False
            If class_Procedures.isEmpty(Engine) Then Return False
            If class_Procedures.isEmpty(Chassis) Then Return False
            If class_Procedures.isEmpty(Corporation) Then Return False
            If class_Procedures.isEmpty(Unit_Status) Then Return False
            If class_Procedures.isEmpty(Sale_Type) Then Return False
            If class_Procedures.isEmpty(Release_Type) Then Return False
            If class_Procedures.isEmpty(Account_Status) Then Return False
            If class_Procedures.isEmpty(Financed) AndAlso Sale_Type.Text IsNot "COD" Then Return False
            If class_Procedures.isEmpty(LCP) AndAlso Sale_Type.Text IsNot "COD" Then Return False
            If class_Procedures.isEmpty(Monthly_Principal) AndAlso Sale_Type.Text IsNot "COD" Then Return False
            If class_Procedures.isEmpty(Monthly_Interest) AndAlso Sale_Type.Text IsNot "COD" Then Return False
            If class_Procedures.isEmpty(Terms) AndAlso Sale_Type.Text IsNot "COD" Then Return False
            If class_Procedures.isEmpty(Interest_Rate) AndAlso Sale_Type.Text IsNot "COD" Then Return False
            If class_Procedures.isEmpty(Amortization) AndAlso Sale_Type.Text IsNot "COD" Then Return False
            If class_Procedures.isEmpty(Rebate) AndAlso Sale_Type.Text IsNot "COD" Then Return False
            If class_Procedures.isEmpty(Outstanding_Principal) AndAlso Sale_Type.Text IsNot "COD" Then Return False
            If class_Procedures.isEmpty(Outstanding_Interest) AndAlso Sale_Type.Text IsNot "COD" Then Return False
            If class_Procedures.isEmpty(Outstanding_Balance) AndAlso Sale_Type.Text IsNot "COD" Then Return False
            If Not class_Database.Data_Save_Ask(Account_Code.Text) Then Return False
            class_Procedures.splash_Show("Inserting Account Profile")

            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand("mg_InsertCustAccountSIM", MySQLConnection)
                    MyCommand.CommandType = CommandType.StoredProcedure

                    With MyCommand.Parameters
                        .Add("@CRNo", SqlDbType.VarChar).Value = "0"
                        .Add("@ORNo", SqlDbType.VarChar).Value = "0"
                        .Add("@BranchCode", SqlDbType.VarChar).Value = Branch_Code.EditValue
                        .Add("@AccountName", SqlDbType.VarChar).Value = Customer_Name.Text.Trim
                        .Add("@LedgerSetNumber", SqlDbType.TinyInt).Value = Ledger.EditValue
                        .Add("@CIFKey", SqlDbType.VarChar).Value = Customer_Code.Text.Trim
                        .Add("@AccountAddress", SqlDbType.VarChar).Value = Customer_Address.Text.Trim
                        .Add("@AccountExecutive", SqlDbType.VarChar).Value = AE_Code.EditValue
                        .Add("@AgentCode", SqlDbType.VarChar).Value = Agent_Code.EditValue
                        .Add("@Code", SqlDbType.VarChar).Value = Model.EditValue
                        .Add("@Model", SqlDbType.VarChar).Value = Model.Text.Trim
                        .Add("@Color", SqlDbType.VarChar).Value = Color.Text.Trim
                        .Add("@Brand", SqlDbType.VarChar).Value = Brand.Text.Trim
                        .Add("@KeyNo", SqlDbType.VarChar).Value = Key_Code.Text.Trim
                        .Add("@EngineNo", SqlDbType.VarChar).Value = Engine.Text.Trim
                        .Add("@ChassisNo", SqlDbType.VarChar).Value = Chassis.Text.Trim
                        .Add("@CORP", SqlDbType.VarChar).Value = Corporation.Text.Trim
                        .Add("@whCode", SqlDbType.VarChar).Value = Unit_Status.Text.Trim
                        .Add("@SaleType", SqlDbType.VarChar).Value = Sale_Type.Text.Trim
                        .Add("@ReleaseType", SqlDbType.VarChar).Value = Release_Type.Text.Trim
                        .Add("@AccountStatus", SqlDbType.VarChar).Value = Account_Status.Text.Trim

                        If Toggle_Assume.IsOn Then
                            .Add("@Tag", SqlDbType.VarChar).Value = "ASM"
                        Else
                            .Add("@Tag", SqlDbType.VarChar).Value = "NONE"
                        End If

                        .Add("@DateGranted", SqlDbType.DateTime).Value = Date_Granted.EditValue
                        .Add("@FirstPayDate", SqlDbType.DateTime).Value = Date_First_Payment.EditValue
                        .Add("@MaturityDate", SqlDbType.DateTime).Value = Date_Maturity.EditValue
                        .Add("@LastMvmtDate", SqlDbType.DateTime).Value = Date_Updated.EditValue
                        .Add("@Terms", SqlDbType.Int).Value = Terms.EditValue
                        .Add("@InterestRate", SqlDbType.Int).Value = Interest_Rate.EditValue
                        .Add("@EffectiveIntRate", SqlDbType.Int).Value = Convert.ToInt32(Interest_Rate.EditValue) - 100
                        Dim iIRPA As Integer = 0

                        Try
                            iIRPA = Convert.ToInt32((Convert.ToInt32(Interest_Rate.EditValue) - 100) / (Convert.ToInt32(Terms.EditValue) / 12))
                        Catch Ex As DivideByZeroException
                            class_Procedures.Show_Error(Ex)
                        Finally
                            .Add("@IntRatePerAnnum", SqlDbType.Int).Value = iIRPA
                        End Try

                        .Add("@COD", SqlDbType.Money).Value = COD.Value
                        .Add("@LCP", SqlDbType.Money).Value = LCP.Value
                        .Add("@DP", SqlDbType.Money).Value = Down_Payment.Value
                        .Add("@AOC", SqlDbType.Money).Value = AOC.Value
                        .Add("@FinancedAmt", SqlDbType.Money).Value = Financed.Value
                        .Add("@PrincipalPMT", SqlDbType.Money).Value = Monthly_Principal.Value
                        .Add("@InterestPMT", SqlDbType.Money).Value = Monthly_Interest.Value
                        .Add("@PMT", SqlDbType.Money).Value = Amortization.Value
                        .Add("@Rebates", SqlDbType.Money).Value = Rebate.Value
                        .Add("@PrincipalBalance", SqlDbType.Money).Value = Outstanding_Principal.Value
                        .Add("@InterestBalance", SqlDbType.Money).Value = Outstanding_Interest.Value
                        .Add("@OutstandingBalance", SqlDbType.Money).Value = Outstanding_Balance.Value
                        .Add("@TempPrin", SqlDbType.Money).Value = Begin_Principal.Value
                        .Add("@TempInt", SqlDbType.Money).Value = Begin_Interest.Value
                        .Add("@PrevStatus", SqlDbType.VarChar).Value = "Current"
                        .Add("@TransactedBy", SqlDbType.VarChar).Value = class_Variables.sUserName
                    End With

                    Try
                        MySQLConnection.Open()
                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Save, "Account Migration")
                            Return True
                        End If
                    Catch ex As Exception
                        Return class_Procedures.Show_Error(ex)
                    Finally
                        class_Procedures.splash_Close()
                    End Try
                End Using
            End Using
            Return True
        End Function

        Friend Function control_Save() As Boolean
            'Dim sActionType As String

            'If ID.EditValue.Equals(0) Then
            '    sActionType = "SAVE"
            'Else
            '    sActionType = "RELEASE"
            'End If

            If class_Procedures.isEmpty(Branch_Code) Then Return False
            If class_Procedures.isEmpty(Account_Code) Then Return False
            If class_Procedures.isEmpty(Ledger) Then Return False
            If class_Procedures.isEmpty(Customer_Code) Then Return False
            If class_Procedures.isEmpty(Customer_Name) Then Return False
            If class_Procedures.isEmpty(Customer_Address) Then Return False
            If class_Procedures.isEmpty(AE_Code) Then Return False
            If class_Procedures.isEmpty(Corporation) Then Return False
            If class_Procedures.isEmpty(Unit_Status) Then Return False
            If class_Procedures.isEmpty(Sale_Type) Then Return False
            If class_Procedures.isEmpty(Account_Status) Then Return False

            Try
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                    New SqlParameter("@Customer_Code", Customer_Code.Text),
                    New SqlParameter("@Account_Code", Account_Code.EditValue),
                    New SqlParameter("@Ledger", Ledger.EditValue),
                    New SqlParameter("@Agent_Code", Agent_Code.EditValue),
                    New SqlParameter("@AE_Code", AE_Code.EditValue),
                    New SqlParameter("@Engine", Engine.Text),
                    New SqlParameter("@Key_Code", Key_Code.EditValue.ToString.Trim.ToUpper),
                    New SqlParameter("@Corporation", Corporation.EditValue),
                    New SqlParameter("@Unit_Status", Unit_Status.EditValue),
                    New SqlParameter("@Account_Status", Account_Status.Text),
                    New SqlParameter("@Date_First_Payment", Date_First_Payment.EditValue),
                    New SqlParameter("@Date_Maturity", Date_Maturity.EditValue),
                    New SqlParameter("@Date_Updated", Date_Maturity.EditValue),
                    New SqlParameter("@Principal_Balance", Outstanding_Principal.Value),
                    New SqlParameter("@Interest_Balance", Outstanding_Interest.Value),
                    New SqlParameter("@Outstanding_Balance", Outstanding_Balance.Value),
                    New SqlParameter("@SI_Code", SI_Code.Text.Trim.ToUpper),
                    New SqlParameter("@SI_Code_Old", sSICodeOld.Trim.ToUpper),
                    New SqlParameter("@CR_Code", CR_Code.Text.Trim.ToUpper),
                    New SqlParameter("@CR_Code_Old", sCRCodeOld.Trim.ToUpper),
                    New SqlParameter("@CTC_Number", CTC_Number.Text.Trim.ToUpper),
                    New SqlParameter("@CTC_Date", CTC_Date.EditValue),
                    New SqlParameter("@CTC_Place", CTC_Place.Text.Trim),
                    New SqlParameter("@Notes", Remarks.Text.Trim),
                    New SqlParameter("@Action_Type", "UPDATE")
                }
                If class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_MC_Sale_Procedures", "MC Sale Information", Customer_Name.Text.Trim.ToUpper) Then
                    If Not PrevAccountName.Text.Equals(sPrevOwner) Then Account_Update_Previous_Owner()
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return class_Procedures.Show_Error(ex)
            Finally
                class_Procedures.splash_Close()
            End Try
        End Function

        Friend Function control_Release() As Boolean
            If Not ID.EditValue.Equals("0") Then Return False

            If class_Procedures.isEmpty(Customer_Code) Then Return False
            If class_Procedures.isEmpty(Branch_Code) Then Return False
            If class_Procedures.isEmpty(Account_Code) Then Return False
            If class_Procedures.isEmpty(Ledger) Then Return False
            If class_Procedures.isEmpty(Customer_Name) Then Return False
            If class_Procedures.isEmpty(Customer_Address) Then Return False
            If class_Procedures.isEmpty(Agent_Code) Then Return False
            If class_Procedures.isEmpty(AE_Code) Then Return False
            If class_Procedures.isEmpty(Corporation) Then Return False
            If class_Procedures.isEmpty(Sale_Type) Then Return False
            If class_Procedures.isEmpty(SI_Code) Then Return False
            If class_Procedures.isEmpty(CR_Code) Then Return False

            Dim sTag As String = "ASM"
            If Not Toggle_Assume.IsOn Then
                sTag = String.Empty
            End If

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Branch_Code", Branch_Code.EditValue),
                New SqlParameter("@Customer_Code", Customer_Code.Text.Trim.ToUpper),
                New SqlParameter("@Account_Code", Account_Code.Text.Trim.ToUpper),
                New SqlParameter("@Ledger", "1"),
                New SqlParameter("@ParamTag", sTag),
                New SqlParameter("@Agent_Code", Agent_Code.EditValue),
                New SqlParameter("@AE_Code", AE_Code.EditValue),
                New SqlParameter("@Engine", Engine.Text),
                New SqlParameter("@Key_Code", Key_Code.Text.Trim),
                New SqlParameter("@Model_Code", Engine.GetColumnValue("Model_Code")),
                New SqlParameter("@Corporation", Corporation.EditValue),
                New SqlParameter("@Sale_Type", Sale_Type.Text),
                New SqlParameter("@Date_Granted", Date_Granted.EditValue),
                New SqlParameter("@Date_First_Payment", Date_First_Payment.EditValue),
                New SqlParameter("@Date_Maturity", Date_Maturity.EditValue),
                New SqlParameter("@COD", COD.Value),
                New SqlParameter("@LCP", LCP.Value),
                New SqlParameter("@DP", Down_Payment.Value),
                New SqlParameter("@Promo_ID", Promo_Code.GetColumnValue("ID")),
                New SqlParameter("@Discount", Discount.Value),
                New SqlParameter("@Financed", Financed.Value),
                New SqlParameter("@Interest_Rate", Interest_Rate.EditValue),
                New SqlParameter("@Terms", Terms.EditValue),
                New SqlParameter("@Monthly_Principal", Monthly_Principal.Value),
                New SqlParameter("@Monthly_Interest", Monthly_Interest.Value),
                New SqlParameter("@Monthly_Amortization", Amortization.Value),
                New SqlParameter("@Principal_Balance", Outstanding_Principal.Value),
                New SqlParameter("@Interest_Balance", Outstanding_Interest.Value),
                New SqlParameter("@ParamPCLIBalance", "0"),
                New SqlParameter("@Remarks", Remarks.EditValue),
                New SqlParameter("@SI_Code", SI_Code.Text.Trim.ToUpper),
                New SqlParameter("@CR_Code", CR_Code.Text.Trim.ToUpper),
                New SqlParameter("@Added_By", class_Variables.sUserName),
                New SqlParameter("@Action_Type", "RELEASE")
            }

            If Not class_Saga_Database.Is_Branch_Date_Equal_Server(Branch_Code.EditValue, Date_Granted.EditValue) Then Return False

            If class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT Accountnumber FROM CustAccount WHERE AccountNumber LIKE '{Account_Code.Text}' AND LedgerSetNumber LIKE '{Ledger.Text}'") Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Account {Account_Code}-{Ledger.EditValue} already exist!", "Release Error", True)
                Return False
            End If

            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_MC_Sale_Procedures", "Sale/Release", $"{Account_Code.Text}-{Ledger.Text}")
        End Function

        Private Sub Account_Update_Previous_Owner()
            Dim sBrCode, sAccountNumber, sAccountName, sLedgerNumber As String
            Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, $"SELECT BranchCode, AccountNumber, AccountName, LedgerSetNumber FROM CustAccount WHERE AccountName LIKE '{PrevAccountName.Text.Trim}'")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    Try
                        myDataReader.Read()
                        sBrCode = myDataReader("BranchCode").ToString
                        sAccountNumber = myDataReader("AccountNumber").ToString
                        sAccountName = myDataReader("AccountName").ToString
                        sLedgerNumber = myDataReader("LedgerSetNumber").ToString
                        class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE CustAccount SET PrevBranchCode = '{sBrCode}', PrevAccountNumber = '{sAccountNumber}', PrevLedgerSetNumber = '{sLedgerNumber}', PrevAccountName = '{sAccountName}' WHERE BranchCode LIKE '{Branch_Code.EditValue}' AND AccountNumber LIKE '{Account_Code.Text.Trim}' AND LedgerSetNumber LIKE '{Ledger.Text.Trim}'")
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    End Try
                End If
            End Using
        End Sub

        Friend Function Control_Reclass_Repo() As Boolean
            If class_Procedures.isEmpty(Branch_Code) Then Return False
            If class_Procedures.isEmpty(Account_Code) Then Return False
            If class_Procedures.isEmpty(Ledger) Then Return False

            class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE CustAccount SET id = '{Account_Inventory_ID.EditValue}' WHERE BranchCode LIKE '{Branch_Code.EditValue}' AND AccountNumber LIKE '{Account_Code.Text.Trim}' AND LedgerSetNumber LIKE '{Ledger.Text.Trim}'")

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ParamBranchCode", Branch_Code.EditValue),
                New SqlParameter("@ParamAccountNumber", Account_Code.Text),
                New SqlParameter("@ParamLedgerSetNumber", Convert.ToInt32(Ledger.EditValue)),
                New SqlParameter("@ParamPostingDate", DateTime.Now),
                New SqlParameter("@ParamNewStatus", "REP"),
                New SqlParameter("@ParamTransactedby", class_Variables.sUserName)
            }

            Return class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "mg_AdminReclassStatus", "DEPO to REPO", True)
        End Function

        Friend Function Control_Cancel() As Boolean
            If class_Procedures.isEmpty(Branch_Code) Then Return False
            If class_Procedures.isEmpty(Account_Code) Then Return False
            If class_Procedures.isEmpty(Ledger) Then Return False

            class_Procedures.Set_Message(class_Procedures.MsgMode.Warning, $"You are about to Cancel the account.{Environment.NewLine}{Environment.NewLine}Please continue if you are certain.", "Cancel Account", True)

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ParamBranchCode", Branch_Code.EditValue),
                New SqlParameter("@ParamAccountNumber", Account_Code.Text),
                New SqlParameter("@ParamLedgerSetNumber", Ledger.Text),
                New SqlParameter("@ParamDateGranted", Date_Granted.EditValue),
                New SqlParameter("@ParamTransactedby", class_Variables.sUserName)
            }

            Dim dtGRanted As Date = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT AccountNumber, LedgerSetNumber, DateGranted FROM CustAccount WHERE AccountNumber LIKE '{Account_Code.Text}' AND LedgerSetNumber LIKE '{Ledger.Text}'", "DateGranted"))
            If Not class_Saga_Database.Is_Branch_Date_Equal_Server(Branch_Code.EditValue, dtGRanted) Then Return False

            Return class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "mg_AdminAccountCancel", "Cancel Account", True)
        End Function

        Friend Function Control_SOA() As Boolean
            If class_Procedures.isEmpty(Account_Code) Then Return False
            If class_Procedures.isEmpty(Ledger) Then Return False
            class_Procedures.splash_Show("Generating SOA")

            Using MySQLConnection = New SqlConnection(class_Database.ICSConnection)
                Using MyCommand As SqlCommand = New SqlCommand("acc_Account_SOA_Insert", MySQLConnection) With {.CommandType = CommandType.StoredProcedure}
                    MyCommand.Parameters.Add("@Account", SqlDbType.VarChar).Value = Account_Code.Text.Trim

                    Try
                        MySQLConnection.Open()
                        If Convert.ToBoolean(MyCommand.ExecuteNonQuery()) Then
                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Account {Account_Code.Text}-{Ledger.Text} of {Customer_Name.Text}{Environment.NewLine}Statement Of Account has been generated.")
                            Return True
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

        Private Sub Account_ID_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Account_Inventory_ID.ButtonClick
            Select Case e.Button.Index
                'Case 1
                '    class_Saga_Procedures.Show_Unit_Inventory(Engine.Text.Trim)
                Case 1
                    Load_Inventory_ID()
            End Select
        End Sub

        Private Sub Customer_Code_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Customer_Code.ButtonClick
            'If e.Button.Index.Equals(1) AndAlso class_Procedures.isEmpty(Customer_Code) Then Return
            'Control_Retrieve($"SELECT * FROM CustAccount WHERE CIFKey LIKE '{Customer_Code.Text}'")
        End Sub

        Private Sub Engine_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Engine.ButtonClick
            Select Case e.Button.Index
                Case 1
                    If Not class_Procedures.isEmpty(Engine) Then
                        class_Saga_Procedures.Show_Unit_Inventory(Engine.Text.Trim,, True)
                    End If
            End Select
        End Sub

        Private Sub Account_Chassis_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Chassis.ButtonClick
            If Not class_Procedures.isEmpty(Chassis) Then
                Select Case e.Button.Index
                    Case 0
                        class_Saga_Procedures.Show_Unit_Inventory(Chassis.Text.Trim,, True)
                End Select
            End If
        End Sub

        Private Sub Account_Number_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Account_Code.ButtonClick
            If class_Procedures.isEmpty(Account_Code) Then Return
            Control_New(False)
            Control_Retrieve($"SELECT * FROM CustAccount WHERE AccountNumber LIKE '{Account_Code.Text}' AND LedgerSetNumber LIKE '{Ledger.Text}'")
        End Sub

        Private Sub LayoutControlItem_Updated_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles LayoutControlItem_Updated.DoubleClick
            Date_Updated.EditValue = Date_Granted.EditValue
        End Sub

        Private Sub LayoutControlItem_Beginning_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles LayoutControlItem_Beginning.DoubleClick
            Begin_Principal.Value = Outstanding_Principal.Value
            Begin_Interest.Value = Outstanding_Interest.Value
            Begin_Outstanding.Value = Outstanding_Balance.Value
        End Sub

        Private Sub LayoutControlItem_Outstanding_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles LayoutControlItem_Outstanding.DoubleClick
            Date_Updated.EditValue = Convert.ToDateTime(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT SequenceNumber, BranchCode, AccountNumber, LedgerSetNumber, LedgerType, TransactionDate, ErrorCorrectTag FROM CustLedger WHERE BranchCode LIKE '{Branch_Code.EditValue}' AND AccountNumber LIKE '{Account_Code.Text}' AND LedgerSetNumber LIKE '{Ledger.EditValue}' AND LedgerType LIKE 'PRIN' AND ErrorCorrectTag LIKE '0' ORDER BY SequenceNumber DESC", "TransactionDate"))
            Outstanding_Principal.Value = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT SequenceNumber, BranchCode, AccountNumber, LedgerSetNumber, LedgerType, EndingBalance, ErrorCorrectTag FROM CustLedger WHERE BranchCode LIKE '{Branch_Code.EditValue}' AND AccountNumber LIKE '{Account_Code.Text}' AND LedgerSetNumber LIKE '{Ledger.EditValue}' AND LedgerType LIKE 'PRIN' AND ErrorCorrectTag LIKE '0' ORDER BY SequenceNumber DESC", "EndingBalance"))
            Outstanding_Interest.Value = Convert.ToDecimal(class_Database.Get_Data(class_Database.ICSConnection, $"SELECT SequenceNumber, BranchCode, AccountNumber, LedgerSetNumber, LedgerType, EndingBalance, ErrorCorrectTag FROM CustLedger WHERE BranchCode LIKE '{Branch_Code.EditValue}' AND AccountNumber LIKE '{Account_Code.Text}' AND LedgerSetNumber LIKE '{Ledger.EditValue}' AND LedgerType LIKE 'INT'  AND ErrorCorrectTag LIKE '0' ORDER BY SequenceNumber DESC", "EndingBalance"))
            Outstanding_Balance.Value = Outstanding_Principal.Value + Outstanding_Interest.Value
        End Sub

        Private Sub Account_Color_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Color.ButtonClick
            If e.Button.Index.Equals(1) Then
                class_Database.Fill_Edit(class_Database.ICSConnection, Color, "CustAccount", "Color")
            End If
        End Sub

        Private Sub Account_Ledger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Ledger.SelectedIndexChanged
            Dim sAccountNumber As String = Account_Code.Text
            Dim sLedger As String = Ledger.Text

            Account_Code.Text = sAccountNumber
            Ledger.Text = sLedger
            Control_Retrieve($"SELECT * FROM CustAccount WHERE AccountNumber LIKE '{sAccountNumber}' AND LedgerSetNumber LIKE '{sLedger}'")
        End Sub

        Private Sub Calculate_Balance()
            If Not Check_Auto_Balance.Checked Then
                Account_Partial.Value = 0
                Outstanding_Balance.Value = Outstanding_Principal.Value + Outstanding_Interest.Value
            End If
        End Sub

        Private Sub Account_Outstanding_Principal_EditValueChanged(sender As Object, e As EventArgs) Handles Outstanding_Principal.EditValueChanged
            Calculate_Balance()
        End Sub

        Private Sub Account_Outstanding_Interest_EditValueChanged(sender As Object, e As EventArgs) Handles Outstanding_Interest.EditValueChanged
            Calculate_Balance()
        End Sub

        Private Sub Promo_Code_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Promo_Code.ButtonClick
            If e.Button.Index.Equals(1) Then
                Promo_Code.EditValue = String.Empty
            End If
        End Sub

        Private Sub Promo_Code_Validated(sender As Object, e As EventArgs) Handles Promo_Code.Validated
            Try
                Discount.Value = Promo_Code.GetColumnValue("Discount")
                Discount.ReadOnly = Not Promo_Code.GetColumnValue("Promo_Type").Equals("CUSTOM")
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub RepositoryItemLookUpEdit_Freebie_Validated(sender As Object, e As EventArgs) Handles RepositoryItemLookUpEdit_Freebie.Validating
            Try
                Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
                gridView.SetFocusedRowCellValue(colPartsName, editor.GetColumnValue("PartsName"))
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub Corporation_Validated(sender As Object, e As EventArgs) Handles Corporation.Validated
            Me.CR_Code.Properties.MaskSettings.Set("mask", $"{Branch_Code.GetColumnValue("Pre_Code")}-CR{Corporation.EditValue.Substring(1, 1)}0000")
        End Sub

        Private Sub Unit_Status_EditValueChanged(sender As Object, e As EventArgs) Handles Unit_Status.EditValueChanged
            If IsDBNull(Unit_Status.EditValue) Then
                Toggle_Assume.Enabled = Unit_Status.EditValue.Equals("DEP")
            End If
        End Sub

        Private Sub RepositoryItemLookUpEdit_Freebie_Validated(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit_Freebie.Validating

        End Sub


    End Class

End Namespace