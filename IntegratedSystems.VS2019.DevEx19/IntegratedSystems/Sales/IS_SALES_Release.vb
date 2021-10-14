Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_SALES_Release
    private sub ComputeFinancedAmt()
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

    private sub IS_SALES_Release_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "Disapproved" Then
        Else
            txt_AccountNumber.Text = class_saga_variables.sbranchcode & Now.ToString("MM") & Now.ToString("dd") & Now.ToString("yyyy") & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")

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

    Friend Sub ClearFields()
        txt_AccountNumber.Text = class_saga_variables.sbranchcode & Now.ToString("MM") & Now.ToString("dd") & Now.ToString("yyyy") & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
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
        txt_EngineNo.Text = String.Empty
        txt_ChassisNo.Text = String.Empty
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

        txt_ID.text = String.Empty
        txt_orno.Text = String.Empty
        txt_infoCode.Text = String.Empty
        cmb_aecode.Text = String.Empty
        cmb_infocen.Text = String.Empty

        txt_CRNo.Text = String.Empty
    End Sub

    Private sub showaPPROVERbyMaker()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamUserName", class_Variables.sUserName),
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowApproverByMaker")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_approverREL.Text = myDataReader("approver").ToString()
                txt_approverFullREL.Text = myDataReader("ApproverFull").ToString()
            End If
        End Using
    End Sub

    private sub showDiscountTypeFAmt()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamDetails", cmb_discnt.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_DiscountTypeFAmt")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_DiscntAmt.Text = myDataReader("DiscAmt").ToString()
                DiscId.Text = myDataReader("id").ToString()
            End If
        End Using
    End Sub

    private sub showDiscountType()
        cmb_discnt.Items.Clear()

        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_DiscountType")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_discnt.Items.Add(myDataReader.Item("DisCntDetails").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub showWh()
        cmb_warehouse.Items.Clear()

        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowWhCode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_warehouse.Items.Add(myDataReader.Item("whcategorycode").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub showAECode()
        txt_aecode.Text = class_Database.Get_Data(class_Database.ICSConnection, $"SELECT * FROM AccountExecutives WHERE OfficerName LIKE '{cmb_aecode.Text}' AND branchcode LIKE '{class_saga_variables.sbranchcode}'", "AccountExecutive")
    End Sub

    private sub showAEName()
        cmb_aecode.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccountExecutives")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_aecode.Items.Add(myDataReader.Item("OfficerName").ToString)
                Loop
            End If
        End Using
    End Sub

    private sub showSalesType()
        cmb_SalesType.Items.Clear()

        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowSalesType")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_SalesType.Items.Add(myDataReader.Item("SalesTypeCode").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub showAgent()
        cmb_infocen.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAgent")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_infocen.Items.Add(myDataReader.Item("AgentName").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub showAgentCode()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAgentName", cmb_infocen.Text),
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAgentCode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_infoCode.Text = (myDataReader.Item("AgentCode").ToString())
                txt_infoType.Text = (myDataReader.Item("InfoOutletType").ToString())
            End If
        End Using
    End Sub

    private sub cmb_SalesType_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_SalesType.TextChanged
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

    private sub cmb_aecode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_aecode.TextChanged
        showAECode()
        cmb_infocen.Enabled = True
    End Sub

    private sub mg_ShowModelcode()
        txt_modelCode.Text = String.Empty

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamModel", cmb_model.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowModelcode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_modelCode.Text = myDataReader("ModelCode").ToString()
            End If
        End Using
    End Sub

    private sub mg_ShowModelTerms()
        txt_terms.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamModelCode", txt_modelCode.Text),
            New SqlParameter("@ParamSalesType", cmb_SalesType.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowTerm")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_terms.Items.Add(myDataReader.Item("Terms").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub mg_AccountModel()
        cmb_model.Items.Clear()

        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowModel")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_model.Items.Add(myDataReader.Item("Modeldesc").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub mg_ShowInterest()
        txt_intrate.Text = String.Empty

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamModelCode", txt_modelCode.Text),
            New SqlParameter("@ParamTerm", txt_terms.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowInterest")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_intrate.Text = myDataReader("rate").ToString()
                Loop
            End If
        End Using
    End Sub

    private sub SaveRec()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
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
            New SqlParameter("@ParamEngineNo", txt_EngineNo.Text),
            New SqlParameter("@ParamChassisNo", txt_ChassisNo.Text),
            New SqlParameter("@ParamCode", txt_code.Text),
            New SqlParameter("@ParamSaleType", cmb_SalesType.Text),
            New SqlParameter("@ParamDateGranted", Format(receivedDate.Value, "MMM dd, yyyy")),
            New SqlParameter("@ParamMaturityDate", Format(receivedDate.Value, "MMM dd, yyyy")),
            New SqlParameter("@ParamFirstPayDate", Format(receivedDate.Value, "MMM dd, yyyy")),
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
            New SqlParameter("@ParamLastMvmtDate", Format(Now, "MMM dd, yyyy")),
            New SqlParameter("@ParamRemarks", String.Empty),
            New SqlParameter("@ParamTransactedBy", class_Variables.sUserName),
            New SqlParameter("@ParamID", txt_ID.text),
            New SqlParameter("@ParamORNo", txt_orno.Text),
            New SqlParameter("@ParamAgentCode", txt_infoCode.Text),
            New SqlParameter("@ParamAOC", txt_aoc.Text),
            New SqlParameter("@ParamRebates", txt_rebates.Text),
            New SqlParameter("@ParamCRNo", txt_CRNo.Text),
            New SqlParameter("@ParamPrevBranchAccount", txt_PrevBranchCode.Text),
            New SqlParameter("@ParamPrevAccountnumber", txt_PrevAccountNumber.Text),
            New SqlParameter("@ParamPrevLedgerSetNumber", txt_LedgerSetNumber.Text),
            New SqlParameter("@ParamPrevAccountName", txt_PrevOwner.Text),
            New SqlParameter("@ParamDiscID", DiscID.Text),
            New SqlParameter("@ParamDiscAmt", txt_DiscntAmt.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_AccountReleaseApplication", "Customer Sale Account", $"{txt_AccountNumber.Text}-1")
        'class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "inv_MC_Sale_Procedures", "Customer Sale/Release", $"{txt_AccountNumber.Text}-1")
    End Sub

    private sub cmd_send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_send.Click
        If cmb_aecode.Text = String.Empty Then
            MsgBox("Please select Account Executive.", vbInformation, "webSources")
            Return
        End If
        SaveRec()
        Me.Close()
    End Sub

    private sub cmb_model_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_model.TextChanged
        mg_ShowModelcode()
        mg_ShowModelTerms()
        txt_terms.Enabled = True
    End Sub

    private sub txt_terms_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_terms.TextChanged
        mg_ShowInterest()
        txt_intrate.Enabled = True
    End Sub

    private sub btn_Approval_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Approval.Click
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

    private sub cmb_warehouse_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_warehouse.TextChanged
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

    private sub cmbTag_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTag.TextChanged
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

    private sub cmb_infocen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_infocen.TextChanged
        showAgentCode()
    End Sub

    private sub btn_Approver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Approver.Click
        maint_ChangeApprover_Sales.ShowDialog()
    End Sub

    private sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        ClearFields()
    End Sub

    private sub txt_intrate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_intrate.TextChanged
        txt_orno.Enabled = True
    End Sub

    private sub txt_aoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_aoc.TextChanged
        ComputeFinancedAmt()
    End Sub

    private sub txt_COD_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_COD.TextChanged
        ComputeFinancedAmt()
    End Sub

    private sub txt_LCP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_LCP.TextChanged
        ComputeFinancedAmt()
    End Sub

    private sub txt_DP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_DP.TextChanged
        ComputeFinancedAmt()
    End Sub

    private sub txt_orno_TextChanged(sender As Object, e As EventArgs) Handles txt_orno.TextChanged
        txt_CRNo.Enabled = True
    End Sub

    private sub txt_CRNo_TextChanged(sender As Object, e As EventArgs) Handles txt_CRNo.TextChanged
        cmb_aecode.Enabled = True
    End Sub

    private sub show_MA_Click(sender As Object, e As EventArgs) Handles show_MA.Click
        Dim a As Double
        a = (txt_FinancedAmt.Text * txt_intrate.Text) / 100
        Show_PMT.txt_pmt.Text = Format(Math.Round(a / txt_terms.Text), "#,##0.00")

        Show_PMT.txt_prinpmt.Text = Decimal.Round(txt_FinancedAmt.Text / txt_terms.Text, 2, MidpointRounding.AwayFromZero)
        Show_PMT.txt_intpmt.Text = Show_PMT.txt_pmt.Text - Show_PMT.txt_prinpmt.Text

        Show_PMT.ShowDialog()
    End Sub

    private sub btn_PrevOwner_Click(sender As Object, e As EventArgs) Handles btn_PrevOwner.Click
        IS_Sales_ReleaseAccount_List.quickSearch.Text = String.Empty
        IS_Sales_ReleaseAccount_List.Text = "SEARCH PREVIOUS"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    private sub cmb_discnt_TextChanged(sender As Object, e As EventArgs) Handles cmb_discnt.TextChanged
        showDiscountTypeFAmt()
        ComputeFinancedAmt()
    End Sub

    private sub cmd_ShowFreebie_Click(sender As Object, e As EventArgs) Handles cmd_ShowFreebie.Click
        IS_Sales_ShowFreebie.ShowDialog()
    End Sub

    private sub cmd_Cust_Click(sender As Object, e As EventArgs) Handles cmd_Cust.Click
        IS_Sales_FindCust.Text = "RELEASE"
        IS_Sales_FindCust.ShowDialog()
    End Sub

    private sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmd_showInvent.Click
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

    private sub mg_RegisterFreebie()
        For x = 0 To lv_Freebie.Items.Count - 1
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
                New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
                New SqlParameter("@ParamLedgersetNumber", "1"),
                New SqlParameter("@ParamPartsNumber", lv_Freebie.Items(x).SubItems(1).Text),
                New SqlParameter("@ParamPartsName", lv_Freebie.Items(x).SubItems(2).Text),
                New SqlParameter("@ParamBegQty", "0"),
                New SqlParameter("@ParamDrQty", lv_Freebie.Items(x).SubItems(3).Text),
                New SqlParameter("@ParamCrQty", "0"),
                New SqlParameter("@ParamEndQty", lv_Freebie.Items(x).SubItems(3).Text),
                New SqlParameter("@ParamPostingDate", Format(receivedDate.Value, "MMM dd, yyyy")),
                New SqlParameter("@ParamTransactedBy", class_Variables.sUserName)
            }

            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_CustFreebieRegister", "Add Freebie")
        Next
        MsgBox("Sent ForApproval. Please inform your approver.", vbInformation)
    End Sub

    private sub lv_Freebie_DoubleClick(sender As Object, e As EventArgs) Handles lv_Freebie.DoubleClick
        lv_Freebie.Items.RemoveAt(lv_Freebie.SelectedIndices(0))
    End Sub

    private sub txt_DpEdit_TextChanged(sender As Object, e As EventArgs) Handles txt_DpEdit.TextChanged
        txt_DP.Text = txt_DpEdit.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class