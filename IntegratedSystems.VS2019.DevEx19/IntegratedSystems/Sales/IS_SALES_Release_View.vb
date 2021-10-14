Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_SALES_Release_View
    private sub cmd_approved_Click(sender As System.Object, e As System.EventArgs) Handles cmd_approved.Click
        mg_AccountRelease()
        Me.Close()
    End Sub

    private sub mg_AccountRelease()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamAccountName", txt_cust.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamTag", cmbTag.Text),
            New SqlParameter("@ParamCIFKey", txt_cifKey.Text),
            New SqlParameter("@ParamAccountAddress", txt_address.Text),
            New SqlParameter("@ParamAccountStatus", "Current"),
            New SqlParameter("@ParamwhCode", cmb_warehouse.Text),
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
            New SqlParameter("@ParamRemarks", "na"),
            New SqlParameter("@ParamID", txt_ID.text),
            New SqlParameter("@ParamORNo", txt_orno.Text),
            New SqlParameter("@ParamCRNo", txt_CRNo.Text),
            New SqlParameter("@ParamPrevBranchAccount", txt_PrevBranchCode.Text),
            New SqlParameter("@ParamPrevAccountnumber", txt_PrevAccountNumber.Text),
            New SqlParameter("@ParamPrevLedgerSetNumber", txt_LedgerSetNumber.Text),
            New SqlParameter("@ParamPrevAccountName", txt_PrevOwner.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_AccountRelease", "Account Release", $"{txt_cust.Text}-{txt_LedSet.Text}")
    End Sub

    private sub mg_AccountRelease_Disapproved()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_AccountRelease_Disapproved", "Disapprove Release", $"{txt_AccountNumber.Text}-{txt_LedSet.Text}")
    End Sub

    private sub cmd_disapproved_Click(sender As System.Object, e As System.EventArgs) Handles cmd_disapproved.Click
        mg_AccountRelease_Disapproved()
        Me.Close()
    End Sub

    private sub IS_SALES_Release_View_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        receivedDate.Format = DateTimePickerFormat.Custom
        receivedDate.CustomFormat = "MM/dd/yyyy"
    End Sub

End Class