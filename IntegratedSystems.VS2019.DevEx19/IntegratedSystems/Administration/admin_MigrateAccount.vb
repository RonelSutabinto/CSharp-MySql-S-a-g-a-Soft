Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class admin_MigrateAccount
    private sub txt_intrate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_intrate.TextChanged

        If txt_terms.Text = String.Empty Then
            MsgBox("Please supply Terms", vbCritical, Application.CompanyName)
            Return
        Else
            txt_effintrate.Text = txt_intrate.Text - 100
            txt_ratePA.Text = Format(Val(txt_effintrate.Text / (txt_terms.Text / 12)), "#.00")

            Dim a As Double
            a = (txt_FinancedAmt.Text * txt_intrate.Text) / 100
            ' MsgBox(a)
            txt_pmt.Text = Math.Round(a / txt_terms.Text)
            'MsgBox(txt_pmt.Text)
        End If
    End Sub

    private sub showItemColor()
        txt_color.Items.Clear()

        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowItemColor")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_color.Items.Add(myDataReader.Item("colordesc").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub showModelCode()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamModel", txt_model.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowModelcode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                txt_code.Text = myDataReader("ModelCode").ToString()
            End If
        End Using
    End Sub

    private sub showModel()
        txt_model.Items.Clear()
        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowModel")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_model.Items.Add(myDataReader.Item("modeldesc").ToString)
                Loop
            End If
        End Using
    End Sub

    private sub showWHCode()
        txt_whcode.Items.Clear()
        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowWhCode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_whcode.Items.Add(myDataReader.Item("whcategorycode").ToString)
                Loop
            End If
        End Using
    End Sub

    private sub showBrand()
        txt_brand.Items.Clear()
        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowBrand")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_brand.Items.Add(myDataReader.Item("branddesc").ToString)
                Loop
            End If
        End Using
    End Sub

    private sub showAEName()
        cmb_aename.Items.Clear()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccountExecutives")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_aename.Items.Add(myDataReader.Item("OfficerName").ToString)
                Loop
            End If
        End Using
    End Sub

    private sub showAECode()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamOfficerName", cmb_aename.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccountExecName")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                txt_aecode.Text = myDataReader("AccountExecutive").ToString()
            End If
        End Using
    End Sub

    private sub cmb_aename_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_aename.TextChanged
        showAECode()
    End Sub

    private sub NewAccount()
        If MsgBox("ARE YOU SURE YOU WANT TO CREATE NEW DATA?", vbOKCancel, Application.CompanyName) = MsgBoxResult.Ok Then
            btn_copy.Visible = False
            txt_cust.Text = String.Empty
            txt_address.Text = String.Empty

            txt_accountStatus.Text = "Current"
            dategranted.Text = Now
            maturity.Text = Now
            firstpayment.Text = Now
            txt_lstmvmtdate.Text = Now

            txt_model.Text = String.Empty
            txt_color.Text = String.Empty
            txt_keynumber.Text = "0000"
            txt_EngineNo.Text = String.Empty
            txt_ChassisNo.Text = String.Empty
            txt_code.Text = String.Empty
            txt_COD.Text = "0"
            txt_LCP.Text = "0"
            txt_DP.Text = "0"
            txt_FinancedAmt.Text = "0"
            txt_aoc.Text = "0"
            txt_rebates.Text = "0"
            txt_prinpmt.Text = "0"
            txt_intpmt.Text = "0"
            txt_pmt.Text = "0"

            txt_prinbal.Text = "0"
            txt_intbal.Text = "0"
            txt_outstandingbal.Text = "0"

            txt_prinBegBal.Text = "0"
            txt_INTBegBal.Text = "0"

            txt_orno.Text = "0"
            txt_crno.Text = "0"

            'txt_terms.Text = ""
            cmb_SalesType.Text = String.Empty
            txt_reltype.Text = "SIM"
            cmb_tag.Text = "NONE"

            'txt_corp.Text = ""

            txt_brCode.Text = class_saga_variables.sbranchcode
            txt_LedSet.Text = "1"

            showAEName()
            showAgent()
            showBrand()
            showWHCode()
            showModel()
            showItemColor()
            TabControl1.SelectedIndex = 0
            txt_cust.Select()
        Else
            Return
        End If

    End Sub

    private sub admin_MigrateAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = Keys.Escape Then Me.Close()
        If e.KeyCode = Keys.D1 AndAlso e.Modifiers = Keys.Control Then
            TabControl1.SelectedIndex = 0
        End If
        If e.KeyCode = Keys.D2 AndAlso e.Modifiers = Keys.Control Then
            TabControl1.SelectedIndex = 1
        End If
        If e.KeyCode = Keys.D3 AndAlso e.Modifiers = Keys.Control Then
            TabControl1.SelectedIndex = 2
        End If
        If e.KeyCode = Keys.N AndAlso e.Modifiers = Keys.Control Then
            NewAccount()
        End If
        If e.KeyCode = Keys.O AndAlso e.Modifiers = Keys.Control Then
            MainMenu.IsMdiContainer = True
            MC_Collection.MdiParent = MainMenu
            MC_Collection.Text = "MIGRATE"
            MC_Collection.toolpostpayment.Enabled = False
            'IS_Sales_Payments.txt_amort.Visible = True
            MC_Collection.txt_Partial.Visible = True
            MC_Collection.txt_amort2.Visible = True
            MC_Collection.Label42.Visible = True
            MC_Collection.Label43.Visible = True
            MC_Collection.Show()
            MC_Collection.Focus()
        End If
        If e.KeyCode = Keys.D AndAlso e.Modifiers = Keys.Control Then
            MainMenu.IsMdiContainer = True
            admin_acctCancel.MdiParent = MainMenu
            admin_acctCancel.Show()
            admin_acctCancel.Focus()
        End If
    End Sub

    private sub admin_MigrateAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txt_brCode.Text = class_saga_variables.sbranchcode
        txt_LedSet.Text = "1"
        btn_copy.Visible = False
        showAEName()
        showAgent()
        showBrand()
        showWHCode()
        showModel()
        showItemColor()
        txt_cust.Select()
    End Sub

    Private sub MigrateAccount()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamCIFKey", txt_cifKey.Text),
            New SqlParameter("@ParamAccountName", txt_cust.Text),
            New SqlParameter("@ParamAccountAddress", txt_address.Text),
            New SqlParameter("@ParamAccountStatus", txt_accountStatus.Text),
            New SqlParameter("@ParamPrevStatus", txt_accountStatus.Text),
            New SqlParameter("@ParamEffectiveIntRate", txt_effintrate.Text),
            New SqlParameter("@ParamIntRatePerAnnum", txt_ratePA.Text),
            New SqlParameter("@ParamInterestRate", txt_intrate.Text),
            New SqlParameter("@ParamDateGranted", dategranted.Text),
            New SqlParameter("@ParamMaturityDate", maturity.Text),
            New SqlParameter("@ParamFirstPayDate", firstpayment.Text),
            New SqlParameter("@ParamLastMvmtDate", txt_lstmvmtdate.Text),
            New SqlParameter("@ParamwhCode", txt_whcode.Text),
            New SqlParameter("@ParamModel", txt_model.Text),
            New SqlParameter("@ParamColor", txt_color.Text),
            New SqlParameter("@ParamBrand", txt_brand.Text),
            New SqlParameter("@ParamKeyNo", txt_keynumber.Text),
            New SqlParameter("@ParamEngineNo", txt_EngineNo.Text),
            New SqlParameter("@ParamChassisNo", txt_ChassisNo.Text),
            New SqlParameter("@ParamCode", txt_code.Text),
            New SqlParameter("@ParamCOD", txt_COD.Text),
            New SqlParameter("@ParamLCP", txt_LCP.Text),
            New SqlParameter("@ParamDP", txt_DP.Text),
            New SqlParameter("@ParamFinancedAmt", txt_FinancedAmt.Text),
            New SqlParameter("@ParamAOC", txt_aoc.Text),
            New SqlParameter("@ParamRebates", txt_rebates.Text),
            New SqlParameter("@ParamPrincipalPMT", txt_prinpmt.Text),
            New SqlParameter("@ParamInterestPMT", txt_intpmt.Text),
            New SqlParameter("@ParamPMT", txt_pmt.Text),
            New SqlParameter("@ParamPrincipalBalance", txt_prinbal.Text),
            New SqlParameter("@ParamInterestBalance", txt_intbal.Text),
            New SqlParameter("@ParamOutstandingBalance", txt_outstandingbal.Text),
            New SqlParameter("@ParamTempPrin", txt_prinBegBal.Text),
            New SqlParameter("@ParamTempInt", txt_INTBegBal.Text),
            New SqlParameter("@ParamORNo", txt_orno.Text),
            New SqlParameter("@ParamCRNo", txt_crno.Text),
            New SqlParameter("@ParamTerms", txt_terms.Text),
            New SqlParameter("@ParamSaleType", cmb_SalesType.Text),
            New SqlParameter("@ParamReleaseType", txt_reltype.Text),
            New SqlParameter("@ParamTag", cmb_tag.Text),
            New SqlParameter("@ParamAccountExecutive", txt_aecode.Text),
            New SqlParameter("@ParamAgentCode", txt_agent.Text),
            New SqlParameter("@ParamTransactedBy", class_Variables.sUserName),
            New SqlParameter("@ParamCORP", txt_corp.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_InsertCustAccountSIM", "Migrate Account", txt_cust.Text)
    End Sub

    private sub showAgent()
        cmb_agent.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAgent")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_agent.Items.Add(myDataReader.Item("AgentName").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub showAgentCode()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAgentName", cmb_agent.Text),
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAgentCode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_agent.Text = (myDataReader.Item("AgentCode").ToString())
            End If
        End Using
    End Sub

    private sub cmb_agent_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_agent.TextChanged
        showAgentCode()
    End Sub

    private sub txt_model_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_model.TextChanged
        showModelCode()
    End Sub

    private sub toolpost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpost.Click
        MigrateAccount()
    End Sub

    private sub newtool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newtool.Click
        NewAccount()
    End Sub

    private sub firstpayment_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firstpayment.ValueChanged
        maturity.Value = firstpayment.Value.AddMonths(txt_terms.Text - 1)

        MsgBox("First Payment Date Event: " & Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)
    End Sub

    private sub dategranted_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dategranted.ValueChanged
        If Format(dategranted.Value, "dd") <= 15 Then 'date is less than or equal to 15
            If Format(dategranted.Value, "MM") = "11" Then 'if month is equal to november
                firstpayment.Value = New Date(dategranted.Value.Year, "12", "18")
            ElseIf Format(dategranted.Value, "MM") = "12" Then 'if month is equal to december
                firstpayment.Value = New Date(dategranted.Value.Year + 1, "01", "18")
            Else
                firstpayment.Value = New Date(dategranted.Value.Year, dategranted.Value.Month + 1, "18")
            End If
        Else 'date greater than 15
            If Format(dategranted.Value, "MM") = "11" Then 'if month is equal to november
                firstpayment.Value = New Date(dategranted.Value.Year + 1, "1", "3")
            ElseIf Format(dategranted.Value, "MM") = "12" Then 'if month is equal to december
                firstpayment.Value = New Date(dategranted.Value.Year + 1, "2", "3")
            Else
                firstpayment.Value = New Date(dategranted.Value.Year, dategranted.Value.Month + 2, "3")
            End If
        End If
        MsgBox("Date Granted Event: " & Err.Number & " - " & Err.Description, vbCritical, Application.CompanyName)
    End Sub

    private sub txt_FinancedAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_FinancedAmt.TextChanged
        txt_prinBegBal.Text = txt_FinancedAmt.Text
    End Sub

    private sub txt_pmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_pmt.TextChanged
        txt_TotalBegBal.Text = txt_pmt.Text * txt_terms.Text
        txt_prinpmt.Text = Decimal.Round(txt_FinancedAmt.Text / txt_terms.Text, 2, MidpointRounding.AwayFromZero)
        txt_intpmt.Text = txt_pmt.Text - txt_prinpmt.Text
    End Sub

    private sub txt_TotalBegBal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_TotalBegBal.TextChanged
        txt_INTBegBal.Text = txt_TotalBegBal.Text - txt_prinBegBal.Text
    End Sub

    private sub txt_totpartial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_totpartial.TextChanged
        If txt_totpartial.Text = String.Empty Then
            txt_totpartial.Text = "0"
        End If
        txt_PrinPartial.Text = txt_totpartial.Text - txt_intpmt.Text
        txt_outswParti.Text = Val(txt_outstandingbal.Text) + Val(txt_totpartial.Text)

        MsgBox(Err.Number & " - " & Err.Description)
    End Sub

    private sub closexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closexit.Click
        grpPartial.Visible = False
    End Sub

    private sub txt_PrinPartial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_PrinPartial.TextChanged
        If txt_PrinPartial.Text <= 0 Then
            txt_PrinPArtialNet.Text = "0"
        Else
            txt_PrinPArtialNet.Text = txt_PrinPartial.Text
        End If
    End Sub

    private sub txt_outswParti_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_outswParti.TextChanged
        txt_dividedbyPMT.Text = Val(txt_outswParti.Text) / Val(txt_pmt.Text)
    End Sub

    private sub checkPart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkpartial.CheckedChanged
        If checkpartial.Checked = True Then
            grpPartial.Visible = True
        End If
    End Sub

    private sub txt_dividedbyPMT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_dividedbyPMT.TextChanged
        txt_multiPrinPMT.Text = Val(txt_dividedbyPMT.Text) * Val(txt_prinpmt.Text)
    End Sub

    private sub txt_multiPrinPMT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_multiPrinPMT.TextChanged
        txt_prinbal.Text = Val(txt_multiPrinPMT.Text) - Val(txt_PrinPArtialNet.Text)
    End Sub

    private sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        txt_totpartial.Text = "1"
        txt_totpartial.Text = "0"
    End Sub

    private sub txt_outstandingbal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_outstandingbal.TextChanged
        RadioButton1.Checked = False
    End Sub

    private sub txt_LCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_LCP.TextChanged
        txt_FinancedAmt.Text = Val(txt_LCP.Text) - Val(txt_DP.Text)
    End Sub

    private sub txt_DP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_DP.TextChanged
        txt_FinancedAmt.Text = Val(txt_LCP.Text) - Val(txt_DP.Text)
    End Sub

    private sub toolCALC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolCALC.Click
        Process.Start("calc.exe")
    End Sub

    private sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        MainMenu.IsMdiContainer = True
        MC_Collection.MdiParent = MainMenu
        MC_Collection.Text = "MIGRATE"
        MC_Collection.toolpostpayment.Enabled = False
        MC_Collection.txt_Partial.Visible = True
        MC_Collection.txt_amort2.Visible = True
        MC_Collection.Label42.Visible = True
        MC_Collection.Label43.Visible = True
        MC_Collection.Show()
        MC_Collection.Focus()
    End Sub

    private sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        MainMenu.IsMdiContainer = True
        admin_acctCancel.MdiParent = MainMenu
        admin_acctCancel.Show()
        admin_acctCancel.Focus()
    End Sub

    private sub btn_copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy.Click
        txt_prinBegBal.Text = txt_prinbal.Text
        txt_INTBegBal.Text = txt_intbal.Text
        txt_TotalBegBal.Text = txt_outstandingbal.Text
    End Sub

    private sub cmb_SalesType_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_SalesType.TextChanged
        If cmb_SalesType.Text = "ASM" Then
            cmb_tag.Text = "ASM"
            btn_copy.Visible = True
        Else
            cmb_tag.Text = "NONE"
            btn_copy.Visible = False
        End If
    End Sub

    private sub toolexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolexit.Click
        Me.Close()
    End Sub

    private sub txt_cust_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_cust.TextChanged
        Me.Text = "MIGRATE ACCOUNT / " & txt_cust.Text
    End Sub

    private sub cmd_recomLCP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_recomLCP.Click
        txt_LCP.Text = Val(txt_LCP.Text) - Val(txt_aoc.Text)
    End Sub

End Class