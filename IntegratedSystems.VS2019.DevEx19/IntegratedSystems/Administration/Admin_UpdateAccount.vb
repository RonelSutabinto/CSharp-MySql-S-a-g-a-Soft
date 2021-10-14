Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Public Class Admin_UpdateAccount

    private sub Admin_UpdateAccount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    private sub Admin_UpdateAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowAEName()
        ShowAgent()
        ShowBrand()
        ShowWHCode()
        ShowModel()
        ShowItemColor()
        ShowAccountStatus()
    End Sub

    private sub mg_UpdateAccountsAdvanced()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_brCode.Text),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamAccountName", txt_cust.Text),
            New SqlParameter("@ParamAddress", txt_address.Text),
            New SqlParameter("@ParamModel", txt_model.Text),
            New SqlParameter("@ParamColor", txt_color.Text),
            New SqlParameter("@ParamDescription", txt_descrip.Text),
            New SqlParameter("@ParamBrand", txt_brand.Text),
            New SqlParameter("@ParamWH", txt_whcode.Text),
            New SqlParameter("@ParamKeyNumber", txt_keynumber.Text),
            New SqlParameter("@ParamEngineNo", txt_EngineNo.Text),
            New SqlParameter("@ParamChassisNo", txt_ChassisNo.Text),
            New SqlParameter("@ParamCOD", txt_COD.Text),
            New SqlParameter("@ParamLCP", txt_LCP.Text),
            New SqlParameter("@ParamRebates", txt_rebates.Text),
            New SqlParameter("@ParamDP", txt_DP.Text),
            New SqlParameter("@ParamFinancedAmt", txt_FinancedAmt.Text),
            New SqlParameter("@ParamSaleType", cmb_SalesType.Text),
            New SqlParameter("@ParamTerms", txt_terms.Text),
            New SqlParameter("@ParamRate", txt_intrate.Text),
            New SqlParameter("@ParamAccountStatus", txt_accountStatus.Text),
            New SqlParameter("@ParamDateGranted", dategranted.EditValue),
            New SqlParameter("@ParamFirstPayDate", firstpayment.EditValue),
            New SqlParameter("@ParamMaturityDate", maturity.EditValue),
            New SqlParameter("@ParamLastMvmtDate", txt_lstmvmtdate.EditValue),
            New SqlParameter("@ParamAECode", txt_aecode.Text),
            New SqlParameter("@ParamAgentCode", txt_SellerCode.Text),
            New SqlParameter("@ParamGenAmortSched", gen_Amort_Sched.Checked),
            New SqlParameter("@ParamID", txt_ID.text),
            New SqlParameter("@ParamPrinOB", txt_PrinOB.Text),
            New SqlParameter("@ParamIntOB", txt_IntOB.Text),
            New SqlParameter("@ParamTotalOB", txt_TotalOB.Text),
            New SqlParameter("@ParamCIFKey", txt_cifKey.Text),
            New SqlParameter("@ParamDetailRemarks", "none"),
            New SqlParameter("@ParamSourceEvent", "Admin_UpdateAccount")
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_UpdateAccountsAdvanced", "Account Update", txt_cust.Text)
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

    private sub showAEName()
        txt_aename.Items.Clear()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccountExecutives")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_aename.Items.Add(myDataReader.Item("OfficerName").ToString)
                Loop
            End If
        End Using
    End Sub

    private sub showAgent()
        txt_SellerName.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAgent")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_SellerName.Items.Add(myDataReader.Item("AgentName").ToString())
                Loop
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

    private sub showAccountStatus()
        txt_accountStatus.Items.Clear()
        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowDistinctAcctStatus")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_accountStatus.Items.Add(myDataReader.Item("AccountStatus").ToString)
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

    private sub DescriptionFull()
        txt_descrip.Text = txt_model.Text & " - " & txt_color.Text
    End Sub

    private sub txt_model_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_model.TextChanged
        showModelCode()
        DescriptionFull()
    End Sub

    private sub showModelCode()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamModel", txt_model.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowModelcode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_code.Text = myDataReader("ModelCode").ToString()
            End If
        End Using
    End Sub

    private sub txt_color_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_color.TextChanged
        DescriptionFull()
    End Sub

    private sub txt_aename_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_aename.TextChanged
        showAECode()
    End Sub

    private sub showAECode()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamOfficerName", txt_aename.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAccountExecName")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_aecode.Text = myDataReader("AccountExecutive").ToString()
            End If
        End Using
    End Sub

    private sub txt_SellerName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SellerName.TextChanged
        showAgentCode()
    End Sub

    private sub showAgentCode()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamAgentName", txt_SellerName.Text),
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowAgentCode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_SellerCode.Text = (myDataReader("AgentCode").ToString())
            End If
        End Using
    End Sub

    private sub LViewLedgerPrin_MouseDown(sender As Object, e As MouseEventArgs) Handles LViewLedgerPrin.MouseDown
        If e.Button = MouseButtons.Right Then
            LViewEvent.Text = "LedgerPrin"
        End If
    End Sub

    private sub MoreDetails_Click(sender As Object, e As EventArgs) Handles MoreDetails.Click
        'If LViewEvent.Text = "LedgerPrin" Then
        '    Admin_UpdateAccount_ShowDetails_Ledger.txt_SeqNo.Text = LViewLedgerPrin.SelectedItems.Item(0).SubItems(12).Text()
        '    Admin_UpdateAccount_ShowDetails_Ledger.ShowDialog()
        'ElseIf LViewEvent.Text = "LedgerInt" Then
        '    Admin_UpdateAccount_ShowDetails_Ledger.txt_SeqNo.Text = LViewLedgerINT.SelectedItems.Item(0).SubItems(12).Text()
        '    Admin_UpdateAccount_ShowDetails_Ledger.ShowDialog()
        'ElseIf LViewEvent.Text = "LedgerAOC" Then
        '    Admin_UpdateAccount_ShowDetails_Ledger.txt_SeqNo.Text = LViewLedgerAOC.SelectedItems.Item(0).SubItems(10).Text()
        '    Admin_UpdateAccount_ShowDetails_Ledger.ShowDialog()
        'ElseIf LViewEvent.Text = "LedgerPEN" Then
        '    Admin_UpdateAccount_ShowDetails_Ledger.txt_SeqNo.Text = LViewLedgerPEN.SelectedItems.Item(0).SubItems(7).Text()
        '    Admin_UpdateAccount_ShowDetails_Ledger.ShowDialog()
        'ElseIf LViewEvent.Text = "LedgerREB" Then
        '    Admin_UpdateAccount_ShowDetails_Ledger.txt_SeqNo.Text = LViewLedgerREB.SelectedItems.Item(0).SubItems(7).Text()
        '    Admin_UpdateAccount_ShowDetails_Ledger.ShowDialog()
        'ElseIf LViewEvent.Text = "AmortSched" Then
        '    Admin_UpdateAmortSched.txt_InstallNo.Text = LViewAmortSched.SelectedItems.Item(0).SubItems(0).Text()
        '    Admin_UpdateAmortSched.txt_BranchCode.Text = LViewAmortSched.SelectedItems.Item(0).SubItems(1).Text()
        '    Admin_UpdateAmortSched.txt_AcctNumber.Text = LViewAmortSched.SelectedItems.Item(0).SubItems(2).Text()
        '    Admin_UpdateAmortSched.txt_LedgsetNo.Text = LViewAmortSched.SelectedItems.Item(0).SubItems(3).Text()
        '    Admin_UpdateAmortSched.txt_DueDate.Text = LViewAmortSched.SelectedItems.Item(0).SubItems(4).Text()

        '    Admin_UpdateAmortSched.txt_PrinBegBal.Text = LViewAmortSched.SelectedItems.Item(0).SubItems(6).Text()
        '    Admin_UpdateAmortSched.txt_Principal.Text = LViewAmortSched.SelectedItems.Item(0).SubItems(7).Text()
        '    Admin_UpdateAmortSched.txt_PrinEndBal.Text = LViewAmortSched.SelectedItems.Item(0).SubItems(8).Text()

        '    Admin_UpdateAmortSched.txt_IntBegBal.Text = LViewAmortSched.SelectedItems.Item(0).SubItems(9).Text()
        '    Admin_UpdateAmortSched.txt_Interest.Text = LViewAmortSched.SelectedItems.Item(0).SubItems(10).Text()
        '    Admin_UpdateAmortSched.txt_IntEndBal.Text = LViewAmortSched.SelectedItems.Item(0).SubItems(11).Text()

        '    Admin_UpdateAmortSched.txt_MA.Text = LViewAmortSched.SelectedItems.Item(0).SubItems(5).Text()
        '    Admin_UpdateAmortSched.ShowDialog()
        'End If
    End Sub

    private sub LViewLedgerINT_MouseDown(sender As Object, e As MouseEventArgs) Handles LViewLedgerINT.MouseDown
        If e.Button = MouseButtons.Right Then
            LViewEvent.Text = "LedgerInt"
        End If
    End Sub

    private sub LViewLedgerAOC_MouseDown(sender As Object, e As MouseEventArgs) Handles LViewLedgerAOC.MouseDown
        If e.Button = MouseButtons.Right Then
            LViewEvent.Text = "LedgerAOC"
        End If
    End Sub

    private sub LViewLedgerPEN_MouseDown(sender As Object, e As MouseEventArgs) Handles LViewLedgerPEN.MouseDown
        If e.Button = MouseButtons.Right Then
            LViewEvent.Text = "LedgerPEN"
        End If
    End Sub

    private sub LViewLedgerREB_MouseDown(sender As Object, e As MouseEventArgs) Handles LViewLedgerREB.MouseDown
        If e.Button = MouseButtons.Right Then
            LViewEvent.Text = "LedgerREB"
        End If
    End Sub

    private sub LViewAmortSched_MouseDown(sender As Object, e As MouseEventArgs) Handles LViewAmortSched.MouseDown
        If e.Button = MouseButtons.Right Then
            LViewEvent.Text = "AmortSched"
        End If
    End Sub

    private sub txt_cust_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_cust.KeyDown
        If e.KeyCode = Keys.Enter Then
            IS_Sales_ReleaseAccount_List.quickSearch.Text = txt_cust.Text
            IS_Sales_ReleaseAccount_List.Text = "ACCT_MGMT"
            IS_Sales_ReleaseAccount_List.ShowDialog()
        End If
    End Sub

    private sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
        If MsgBox("BranchCode : " & txt_brCode.Text & vbCrLf & "AccountNumber : " & txt_AccountNumber.Text & vbCrLf &
              "LedgerSetNumber : " & txt_LedSet.Text & vbCrLf & "AccountName : " & txt_cust.Text & vbCrLf & vbCrLf &
              "Do you want to proceed transaction?", vbYesNo, vbInformation) = vbYes Then
            mg_UpdateAccountsAdvanced()
            IS_Sales_ReleaseAccount_List.mg_UpdateAccount()
            IS_Sales_ReleaseAccount_List.showLedgerPrinAcctMgmt()
            IS_Sales_ReleaseAccount_List.showLedgerINTAcctMgmt()
            IS_Sales_ReleaseAccount_List.showLedgerREBAcctMgmt()
            IS_Sales_ReleaseAccount_List.showLedgerPENAcctMgmt()
            IS_Sales_ReleaseAccount_List.showAmortSchedAcctMgmt()
        Else
            MsgBox("Transaction unsuccessful", vbCritical, Application.CompanyName)
        End If
    End Sub

    private sub btn_Account_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Account.ItemClick
        IS_Sales_ReleaseAccount_List.Text = "ACCT_MGMT"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    private sub Admin_UpdateAccount_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)
    End Sub
End Class