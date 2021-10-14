Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_CreditMemo

    Private Sub Admin_CreditMemo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txt_refno.Text = MainMenu.statusBrCode.Caption & Now.ToString("M") & Now.ToString("d") & Now.ToString("yy") & Now.ToString("hh") & Now.ToString("mm") & Now.ToString("ss")
        ShowAccountNumber()
    End Sub

    Sub clearfield()

        txt_branchcode.Text = String.Empty
        txt_acctno.Text = String.Empty
        txt_LedSet.Text = String.Empty

        prinoverride.Text = "0"
        intoverride.Text = "0"
        penoverride.Text = "0"
        dstoverride.Text = "0"
        otcoverride.Text = "0"
        odroverride.Text = "0"
        ocroverride.Text = "0"
        insoverride.Text = "0"
        aocoverride.Text = "0"
        svcoverride.Text = "0"
        reboverride.Text = "0"

    End Sub

    Sub ShowAccountNumber()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_AccountNumberShow")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_refno.Text = myDataReader("BranchCode").ToString() & Val(myDataReader.Item("CreditMemoCode").ToString() + 1)
            End If
        End Using
    End Sub

    Sub PostCreditMemo()
        Dim Parameters As SqlParameter() =
        {
            New SqlParameter("@ParamBranchCode", txt_branchcode.Text),
            New SqlParameter("@ParamAccountNumber", txt_acctno.Text),
            New SqlParameter("@ParamPostingDate", postingDate.Value),
            New SqlParameter("@ParamAmountPaid", txt_TotAmtPaid.Text),
            New SqlParameter("@ParamRefNo", txt_refno.Text),
            New SqlParameter("@ParamPrin", prinoverride.Text),
            New SqlParameter("@ParamInt", intoverride.Text),
            New SqlParameter("@Paramaoc", aocoverride.Text),
            New SqlParameter("@Paramsvc", svcoverride.Text),
            New SqlParameter("@Parampen", penoverride.Text),
            New SqlParameter("@Paramdst", dstoverride.Text),
            New SqlParameter("@Paramotc", otcoverride.Text),
            New SqlParameter("@Paramodr", odroverride.Text),
            New SqlParameter("@Paramocr", ocroverride.Text),
            New SqlParameter("@Paramins", insoverride.Text),
            New SqlParameter("@Paramtotal", txt_TotAmtPaid.Text),
            New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamLedgersetNumber", txt_LedSet.Text),
            New SqlParameter("@Paramnote", txt_remarks.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "Post_Credit_Memo")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MsgBox(myDataReader.Item("Message").ToString())
            End If
        End Using
    End Sub

    Private Sub cmd_vendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_vendor.Click
        clearfield()

        IS_Sales_ReleaseAccount_List.quickSearch.Focus()
        IS_Sales_ReleaseAccount_List.Text = "CREDITMEMO"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Private Sub newtool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newtool.Click
        clearfield()
        ShowAccountNumber()
    End Sub

    Private Sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        PostCreditMemo()
    End Sub

End Class