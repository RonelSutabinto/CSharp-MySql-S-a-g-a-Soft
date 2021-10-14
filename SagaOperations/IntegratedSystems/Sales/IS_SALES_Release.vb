Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_SALES_Release
    Sub ComputeFinancedAmt()
        Dim testDiff As Decimal = 0

        If Val(txt_aoc.Text) > Val(txt_DP.Text) Then
            testDiff = "0.00"
        Else
            testDiff = Val(txt_DP.Text) - Val(txt_aoc.Text)
        End If

        If cmb_SalesType.Text = "TCOD" Or cmb_SalesType.Text = "ECOD" Then
            txt_FinancedAmt.Text = Val(txt_COD.Text) - Val(testDiff)

        ElseIf cmb_SalesType.Text = "COD" Then
            txt_FinancedAmt.Text = Val(txt_COD.Text) - Val(txt_DiscntAmt.Text)

        ElseIf cmb_SalesType.Text = "FIN" Then
            'testLCP = txt_DP.Text - txt_aoc.Text
            txt_FinancedAmt.Text = Val(txt_LCP.Text) - Val(testDiff)
        End If

    End Sub

    Private Sub IS_SALES_Release_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "Disapproved" Then
        Else
            txt_AccountNumber.Text = MainMenu.statusBrCode.Caption & Now.ToString("MM") & Now.ToString("dd") & Now.ToString("yyyy") & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")

        End If
        ShowDiscountType()
        ShowWh()
        ShowSalesType()
        ShowAEName()
        mg_AccountModel()
        ShowAgent()
        ShowaPPROVERbyMaker()
        cmb_SalesType.Enabled = False
        cmb_model.Enabled = False
        txt_terms.Enabled = False
        txt_intrate.Enabled = False
        txt_orno.Enabled = False
        txt_CRNo.Enabled = False
        cmb_aecode.Enabled = False
        cmb_infocen.Enabled = False
        show_MA.Enabled = False

    End Sub

    Sub ClearFields()
        txt_AccountNumber.Text = MainMenu.statusBrCode.Caption & Now.ToString("MM") & Now.ToString("dd") & Now.ToString("yyyy") & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
        txt_cust.Text = String.Empty
        txt_cifKey.Text = String.Empty
        txt_address.Text = String.Empty
        cmb_warehouse.Text = String.Empty
        cmbTag.Text = String.Empty

        cmb_model.Text = String.Empty
        txt_modelCode.Text = String.Empty
        txt_color.Text = String.Empty
        txt_brand.Text = String.Empty
        txt_keynumber.Text = String.Empty
        txt_engineNo.Text = String.Empty
        txt_chassisNo.Text = String.Empty
        txt_code.Text = String.Empty

        cmb_SalesType.Text = String.Empty
        receivedDate.Value = Now
        txt_intrate.Text = String.Empty
        txt_aecode.Text = String.Empty

        txt_COD.Text = "0.00"
        txt_LCP.Text = "0.00"
        txt_DP.Text = "0.00"
        txt_aoc.Text = "0.00"
        txt_FinancedAmt.Text = "0.00"
        txt_rebates.Text = "0.00"

        txt_terms.Text = String.Empty

        txt_id.Text = String.Empty
        txt_orno.Text = String.Empty
        txt_infoCode.Text = String.Empty
        cmb_aecode.Text = String.Empty
        cmb_infocen.Text = String.Empty

        txt_CRNo.Text = String.Empty
    End Sub

    Sub showaPPROVERbyMaker()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamUserName", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowApproverByMaker")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_approverREL.Text = myDataReader("approver").ToString()
                txt_approverFullREL.Text = myDataReader("ApproverFull").ToString()
            End If
        End Using
    End Sub

    Sub showDiscountTypeFAmt()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamDetails", cmb_discnt.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_DiscountTypeFAmt")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_DiscntAmt.Text = myDataReader("DiscAmt").ToString()
                DiscId.Text = myDataReader("id").ToString()
            End If
        End Using
    End Sub

    Sub showDiscountType()
        cmb_discnt.Items.Clear()

        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_DiscountType")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_discnt.Items.Add(myDataReader.Item("DisCntDetails").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub showWh()
        cmb_warehouse.Items.Clear()

        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowWhCode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_warehouse.Items.Add(myDataReader.Item("whcategorycode").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub showAECode()
        txt_aecode.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT * FROM AccountExecutives WHERE OfficerName LIKE '{cmb_aecode.Text}' AND branchcode LIKE '{MainMenu.statusBrCode.Caption}'", "AccountExecutive")
    End Sub

    Sub showAEName()
        cmb_aecode.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAccountExecutives")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_aecode.Items.Add(myDataReader.Item("OfficerName").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub showSalesType()
        cmb_SalesType.Items.Clear()

        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowSalesType")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_SalesType.Items.Add(myDataReader.Item("SalesTypeCode").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub showAgent()
        cmb_infocen.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAgent")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_infocen.Items.Add(myDataReader.Item("AgentName").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub showAgentCode()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamAgentName", cmb_infocen.Text),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowAgentCode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_infoCode.Text = (myDataReader.Item("AgentCode").ToString())
                txt_infoType.Text = (myDataReader.Item("InfoOutletType").ToString())
            End If
        End Using
    End Sub

    Private Sub cmb_SalesType_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_SalesType.TextChanged
        If cmb_SalesType.Text = "FIN" Then
            txt_LCP.Enabled = True
            txt_DP.Enabled = True
            txt_COD.Enabled = True
            txt_aoc.Enabled = True
            show_MA.Enabled = True
            MsgBox("SALES TYPE= INSTALLMENT" & vbCrLf & "TERMS = 6 MONTHS TO 3 YEARS!", vbInformation, Application.CompanyName)
        ElseIf cmb_SalesType.Text = "TCOD" Then
            txt_LCP.Enabled = True
            txt_DP.Enabled = True
            txt_COD.Enabled = True
            txt_aoc.Enabled = True
            show_MA.Enabled = True
            MsgBox("SALES TYPE= TERMED COD" & vbCrLf & "TERMS= GREATER THAN 1 MONTH TO 3 MONTHS", vbInformation, Application.CompanyName)
        ElseIf cmb_SalesType.Text = "ECOD" Then
            txt_LCP.Enabled = True
            txt_DP.Enabled = True
            txt_COD.Enabled = True
            txt_aoc.Enabled = True
            txt_terms.Text = "1"
            txt_intrate.Text = "100"
            MsgBox("SALES TYPE= EXTENDED COD" & vbCrLf & "TERMS= 15 DAYS TO 1 MONTH", vbInformation, Application.CompanyName)
        ElseIf cmb_SalesType.Text = "COD" Then
            txt_LCP.Enabled = False
            txt_DP.Enabled = False
            txt_COD.Enabled = True
            txt_aoc.Enabled = False
            txt_terms.Text = "0"
            txt_intrate.Text = "0"
            MsgBox("SALES TYPE= SPOT CASH", vbInformation, Application.CompanyName)
        End If
        cmb_model.Enabled = True
    End Sub

    Private Sub cmb_aecode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_aecode.TextChanged
        showAECode()
        cmb_infocen.Enabled = True
    End Sub

    Sub mg_ShowModelcode()
        txt_modelCode.Text = String.Empty

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamModel", cmb_model.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowModelcode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_modelCode.Text = myDataReader("ModelCode").ToString()
            End If
        End Using
    End Sub

    Sub mg_ShowModelTerms()
        txt_terms.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamModelCode", txt_modelCode.Text),
            New SqlParameter("@ParamSalesType", cmb_SalesType.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowTerm")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_terms.Items.Add(myDataReader.Item("Terms").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub mg_AccountModel()
        cmb_model.Items.Clear()

        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowModel")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_model.Items.Add(myDataReader.Item("Modeldesc").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub mg_ShowInterest()
        txt_intrate.Text = String.Empty

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamModelCode", txt_modelCode.Text),
            New SqlParameter("@ParamTerm", txt_terms.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowInterest")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_intrate.Text = myDataReader("rate").ToString()
                Loop
            End If
        End Using
    End Sub

    Sub SaveRec()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamAccountName", txt_cust.Text),
            New SqlParameter("@ParamLedgerSetNumber", "1"),
            New SqlParameter("@ParamCIFKey", txt_cifKey.Text),
            New SqlParameter("@ParamAccountAddress", txt_address.Text),
            New SqlParameter("@ParamAccountStatus", "Current"),
            New SqlParameter("@ParamwhCode", cmb_warehouse.Text),
            New SqlParameter("@ParamTag", cmbTag.Text),
            New SqlParameter("@ParamModel", txt_model.Text),
            New SqlParameter("@ParamColor", txt_color.Text),
            New SqlParameter("@ParamBrand", txt_brand.Text),
            New SqlParameter("@ParamKeyNo", txt_keynumber.Text),
            New SqlParameter("@ParamEngineNo", txt_engineNo.Text),
            New SqlParameter("@ParamChassisNo", txt_chassisNo.Text),
            New SqlParameter("@ParamCode", txt_code.Text),
            New SqlParameter("@ParamSaleType", cmb_SalesType.Text),
            New SqlParameter("@ParamDateGranted", Format(receivedDate.Value, "MM/dd/yyyy")),
            New SqlParameter("@ParamMaturityDate", Format(receivedDate.Value, "MM/dd/yyyy")),
            New SqlParameter("@ParamFirstPayDate", Format(receivedDate.Value, "MM/dd/yyyy")),
            New SqlParameter("@ParamInterestRate", txt_intrate.Text),
            New SqlParameter("@ParamAccountExecutive", txt_aecode.Text),
            New SqlParameter("@ParamCOD", txt_COD.Text),
            New SqlParameter("@ParamLCP", txt_LCP.Text),
            New SqlParameter("@ParamDP", txt_DP.Text),
            New SqlParameter("@ParamFinancedAmt", txt_FinancedAmt.Text),
            New SqlParameter("@ParamTerms", txt_terms.Text),
            New SqlParameter("@ParamPMT", "0"),
            New SqlParameter("@ParamPrincipalBalance", "0"),
            New SqlParameter("@ParamInterestBalance", "0"),
            New SqlParameter("@ParamPCLIBalance", "0"),
            New SqlParameter("@ParamLastMvmtDate", Format(Now, "MM/dd/yyyy")),
            New SqlParameter("@ParamRemarks", String.Empty),
            New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamID", txt_id.Text),
            New SqlParameter("@ParamORNo", txt_orno.Text),
            New SqlParameter("@ParamAgentCode", txt_infoCode.Text),
            New SqlParameter("@ParamAOC", txt_aoc.Text),
            New SqlParameter("@ParamRebates", txt_rebates.Text),
            New SqlParameter("@ParamCRNo", txt_CRNo.Text),
            New SqlParameter("@ParamPrevBranchAccount", txt_PrevBranchCode.Text),
            New SqlParameter("@ParamPrevAccountnumber", txt_PrevAccountNumber.Text),
            New SqlParameter("@ParamPrevLedgerSetNumber", txt_LedgerSetNumber.Text),
            New SqlParameter("@ParamPrevAccountName", txt_PrevOwner.Text),
            New SqlParameter("@ParamDiscID", DiscId.Text),
            New SqlParameter("@ParamDiscAmt", txt_DiscntAmt.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_AccountReleaseApplication", "Customer Sale Account", $"{txt_AccountNumber.Text}-1")
    End Sub

    Private Sub cmd_send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_send.Click
        If cmb_aecode.Text = String.Empty Then
            MsgBox("Please select Account Executive.", vbInformation, "webSources")
            Return
        End If
        SaveRec()
        Me.Close()
    End Sub

    Private Sub cmb_model_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_model.TextChanged
        mg_ShowModelcode()
        mg_ShowModelTerms()
        txt_terms.Enabled = True
    End Sub

    Private Sub txt_terms_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_terms.TextChanged
        mg_ShowInterest()
        txt_intrate.Enabled = True
    End Sub

    Private Sub toolsendForApproval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolsendForApproval.Click
        If cmb_aecode.Text = String.Empty Then
            MsgBox("Please select Account Executive.", vbInformation, "webSources")
            Return
        End If

        If lv_Freebie.Items.Count = 0 Then
            If MsgBox("No Freebie for this Application?", vbYesNo, Application.CompanyName) = vbYes Then
                SaveRec()
            End If
        Else
            SaveRec()
        End If
        If lv_Freebie.Items.Count > 0 Then
            mg_RegisterFreebie()
        End If
        Me.Close()
    End Sub

    Private Sub cmb_warehouse_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_warehouse.TextChanged
        cmbTag.Items.Clear()
        If cmb_warehouse.Text = "NEW" Then
            cmbTag.Text = String.Empty

            txt_PrevOwner.Text = String.Empty
            txt_PrevBranchCode.Text = String.Empty
            txt_PrevAccountNumber.Text = String.Empty
            txt_LedgerSetNumber.Text = String.Empty

            btn_PrevOwner.Enabled = False
        ElseIf cmb_warehouse.Text = "DEP" Then
            cmbTag.Text = "ASM"

            txt_PrevOwner.Text = String.Empty
            txt_PrevBranchCode.Text = String.Empty
            txt_PrevAccountNumber.Text = String.Empty
            txt_LedgerSetNumber.Text = String.Empty

            btn_PrevOwner.Enabled = True

        ElseIf cmb_warehouse.Text = "REP" Then
            cmbTag.Text = String.Empty
            btn_PrevOwner.Enabled = True
        End If
        cmb_SalesType.Enabled = True
    End Sub

    Private Sub cmbTag_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTag.TextChanged
        If cmbTag.Text = "ASM" Then
            txt_intrate.Enabled = False
            cmb_SalesType.Enabled = False
            txt_terms.Enabled = False

            cmb_SalesType.Text = "FIN"
            txt_terms.Text = "0"
            txt_intrate.Text = "0"
        Else
            cmb_SalesType.Enabled = True
            txt_terms.Enabled = True
            txt_intrate.Enabled = True
        End If
    End Sub

    Private Sub cmb_infocen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_infocen.TextChanged
        showAgentCode()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        maint_ChangeApprover_Sales.ShowDialog()
    End Sub

    Private Sub toolnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolnew.Click
        ClearFields()
    End Sub

    Private Sub txt_intrate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_intrate.TextChanged
        txt_orno.Enabled = True
    End Sub

    Private Sub txt_aoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_aoc.TextChanged
        ComputeFinancedAmt()
    End Sub

    Private Sub txt_COD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_COD.TextChanged
        ComputeFinancedAmt()
    End Sub

    Private Sub txt_LCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_LCP.TextChanged
        ComputeFinancedAmt()
    End Sub

    Private Sub txt_DP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_DP.TextChanged
        ComputeFinancedAmt()
    End Sub

    Private Sub txt_orno_TextChanged(sender As Object, e As EventArgs) Handles txt_orno.TextChanged
        txt_CRNo.Enabled = True
    End Sub

    Private Sub txt_CRNo_TextChanged(sender As Object, e As EventArgs) Handles txt_CRNo.TextChanged
        cmb_aecode.Enabled = True
    End Sub

    Private Sub show_MA_Click(sender As Object, e As EventArgs) Handles show_MA.Click
        Dim a As Double
        a = (txt_FinancedAmt.Text * txt_intrate.Text) / 100
        Show_PMT.txt_pmt.Text = Format(Math.Round(a / txt_terms.Text), "#,##0.00")

        Show_PMT.txt_prinpmt.Text = Decimal.Round(txt_FinancedAmt.Text / txt_terms.Text, 2, MidpointRounding.AwayFromZero)
        Show_PMT.txt_intpmt.Text = Show_PMT.txt_pmt.Text - Show_PMT.txt_prinpmt.Text

        Show_PMT.ShowDialog()
    End Sub

    Private Sub btn_PrevOwner_Click(sender As Object, e As EventArgs) Handles btn_PrevOwner.Click
        IS_Sales_ReleaseAccount_List.quickSearch.Text = String.Empty
        IS_Sales_ReleaseAccount_List.Text = "SEARCH PREVIOUS"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Private Sub cmb_discnt_TextChanged(sender As Object, e As EventArgs) Handles cmb_discnt.TextChanged
        showDiscountTypeFAmt()
        ComputeFinancedAmt()
    End Sub

    Private Sub cmd_ShowFreebie_Click(sender As Object, e As EventArgs) Handles cmd_ShowFreebie.Click
        IS_Sales_ShowFreebie.ShowDialog()
    End Sub

    Private Sub cmd_Cust_Click(sender As Object, e As EventArgs) Handles cmd_Cust.Click
        IS_Sales_FindCust.Text = "RELEASE"
        IS_Sales_FindCust.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmd_showInvent.Click
        If cmb_SalesType.Text = String.Empty Then
            MsgBox("Please select SALES Type!", vbInformation, "webSources")
            cmb_SalesType.Focus()
            Return
        End If
        If cmb_SalesType.Text = "FIN" And cmb_warehouse.Text <> "DEP" Then
            If txt_DP.Text = "0.00" Then
                MsgBox("Please supply D/P", vbInformation, Application.CompanyName)
                Return
            End If
        End If
        If cmb_SalesType.Text = "FIN" And txt_terms.Text = String.Empty Then
            MsgBox("Please supply TERMS", vbInformation, Application.CompanyName)
        End If
        If txt_cust.Text = String.Empty Then
            MsgBox("Please select customer.", vbInformation, "webSources")
            IS_Sales_FindCust.ShowDialog()
            Return
        End If

        If txt_orno.Text = String.Empty Then
            MsgBox("Please supply SI Number!", vbInformation, "webSources")
            txt_orno.Focus()
            Return
        End If

        If txt_CRNo.Text = String.Empty Then
            MsgBox("Please supply CR Number!", vbInformation, "webSources")
            txt_CRNo.Focus()
            Return
        End If

        If cmb_warehouse.Text = String.Empty Then
            MsgBox("Please select warehouse code.", vbInformation, "webSources")
            cmb_warehouse.Focus()
            Return
        End If
        If cmb_aecode.Text = String.Empty Then
            MsgBox("Please supply Account Executive!", vbInformation, "webSources")
            cmb_aecode.Focus()
            Return
        End If
        If cmb_infocen.Text = String.Empty Then
            MsgBox("Please select infocenter / outlet!", vbInformation, "webSources")
            cmb_infocen.Focus()
            Return
        End If
        If cmb_model.Text = String.Empty Then
            MsgBox("Please select Model!", vbInformation, "webSources")
            cmb_model.Focus()
            Return
        End If

        IS_Sales_item_find.ShowDialog()
    End Sub

    Sub mg_RegisterFreebie()
        For x = 0 To lv_Freebie.Items.Count - 1
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
                New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
                New SqlParameter("@ParamLedgersetNumber", "1"),
                New SqlParameter("@ParamPartsNumber", lv_Freebie.Items(x).SubItems(1).Text),
                New SqlParameter("@ParamPartsName", lv_Freebie.Items(x).SubItems(2).Text),
                New SqlParameter("@ParamBegQty", "0"),
                New SqlParameter("@ParamDrQty", lv_Freebie.Items(x).SubItems(3).Text),
                New SqlParameter("@ParamCrQty", "0"),
                New SqlParameter("@ParamEndQty", lv_Freebie.Items(x).SubItems(3).Text),
                New SqlParameter("@ParamPostingDate", Format(receivedDate.Value, "MM/dd/yyyy")),
                New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
            }

            class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_CustFreebieRegister", "Add Freebie")
        Next
        MsgBox("Sent ForApproval. Please inform your approver.", vbInformation)
    End Sub

    Private Sub lv_Freebie_DoubleClick(sender As Object, e As EventArgs) Handles lv_Freebie.DoubleClick
        lv_Freebie.Items.RemoveAt(lv_Freebie.SelectedIndices(0))
    End Sub

    Private Sub txt_DpEdit_TextChanged(sender As Object, e As EventArgs) Handles txt_DpEdit.TextChanged
        txt_DP.Text = txt_DpEdit.Text
    End Sub

End Class