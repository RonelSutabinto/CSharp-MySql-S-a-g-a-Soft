Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class maint_CustAccount
    private sub maint_CustAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearFields()
    End Sub

    private sub ClearFields()
        txt_brCode.Text = String.Empty
        txt_AccountNumber.Text = String.Empty
        txt_LedSet.Text = String.Empty
        txt_cust.Text = String.Empty
        txt_address.Text = String.Empty
        txt_cifKey.Text = String.Empty

        txt_code.Text = String.Empty
        txt_ID.text = String.Empty
        txt_model.Text = String.Empty
        txt_color.Text = String.Empty
        txt_brand.Text = String.Empty
        txt_descrip.Text = String.Empty
        txt_keynumber.Text = String.Empty
        txt_EngineNo.Text = String.Empty
        txt_ChassisNo.Text = String.Empty
        txt_whcode.Text = String.Empty
        txt_COD.Text = String.Empty
        txt_LCP.Text = String.Empty
        txt_DP.Text = String.Empty
        txt_FinancedAmt.Text = String.Empty
        txt_rebates.Text = String.Empty
        txt_aoc.Text = String.Empty

        txt_orno.Text = String.Empty
        cmb_SalesType.Text = String.Empty
        txt_terms.Text = String.Empty
        txt_intrate.Text = String.Empty
        txt_accountStatus.Text = String.Empty
        dategranted.Text = String.Empty
        firstpayment.Text = String.Empty
        maturity.Text = String.Empty

        txt_prinpmt.Text = String.Empty
        txt_intpmt.Text = String.Empty
        txt_pmt.Text = String.Empty

        txt_prinbal.Text = String.Empty
        txt_intbal.Text = String.Empty
        txt_outstandingbal.Text = String.Empty

        txt_prinBegBal.Text = String.Empty
        txt_INTBegBal.Text = String.Empty
    End Sub

    private sub txt_prinpmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_prinpmt.TextChanged
        Totals()
    End Sub

    private sub Totals()
        txt_TotalBegBal.Text = Val(txt_prinBegBal.Text) + Val(txt_INTBegBal.Text)
        txt_outstandingbal.Text = Val(txt_prinbal.Text) + Val(txt_intbal.Text)
        txt_pmt.Text = Val(txt_prinpmt.Text) + Val(txt_intpmt.Text)
    End Sub

    private sub informationtool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles informationtool.Click
        IS_Sales_ReleaseAccount_List.Text = "UPDATEACCTS"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    private sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        mg_UpdateAccount()
    End Sub

    private sub mg_UpdateAccount()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_brCode.Text),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamTerms", txt_terms.Text),
            New SqlParameter("@ParamFinancedAmt", txt_FinancedAmt.Text),
            New SqlParameter("@ParamPrincipalBalance", txt_prinbal.Text),
            New SqlParameter("@ParamInterestBalance", txt_intbal.Text),
            New SqlParameter("@ParamOutstandingBalance", txt_outstandingbal.Text),
            New SqlParameter("@ParamPMT", txt_pmt.Text),
            New SqlParameter("@ParamPrincipalPMT", txt_prinpmt.Text),
            New SqlParameter("@ParamInterestPMT", txt_intpmt.Text),
            New SqlParameter("@ParamTempPrin", txt_prinBegBal.Text),
            New SqlParameter("@ParamTempInt", txt_INTBegBal.Text),
            New SqlParameter("@ParamDateGranted", dategranted.Text),
            New SqlParameter("@ParamFirstPaydate", firstpayment.Text),
            New SqlParameter("@ParamMaturityDate", maturity.Text),
            New SqlParameter("@ParamSaleType", cmb_SalesType.Text),
            New SqlParameter("@ParamRate", txt_intrate.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_UpdateAccounts")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MsgBox(myDataReader.Item("Message").ToString())
            End If
        End Using
    End Sub

    private sub txt_intpmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_intpmt.TextChanged
        Totals()
    End Sub

    private sub txt_prinBegBal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_prinBegBal.TextChanged
        Totals()
    End Sub

    private sub txt_INTBegBal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_INTBegBal.TextChanged
        Totals()
    End Sub

    private sub txt_prinbal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_prinbal.TextChanged
        Totals()
    End Sub

    private sub txt_intbal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_intbal.TextChanged
        Totals()
    End Sub

End Class