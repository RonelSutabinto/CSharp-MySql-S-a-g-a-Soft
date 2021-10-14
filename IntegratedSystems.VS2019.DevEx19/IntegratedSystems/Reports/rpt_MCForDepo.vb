Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports wSClassLib.myModules

Public Class rpt_MCForDepo
    private sub rpt_MCForDepo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DockPanel.Visible = False
        BarEditItem_CutOff.EditValue = Now
    End Sub

    private sub rpt_MCForDepo_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(BarManager1)

        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit1)

        'Initialize_Button(DockPanel)

        Initialize_InvRemarks("MCAccount")
        Initialize_InvRemarks("MCAccount", txt_Remarks)

        If class_saga_variables.sbranchcode = "000" Then
            barEditItem_Branch.Enabled = True
            barEditItem_Branch.EditValue = class_saga_variables.sbranchcode
        Else
            barEditItem_Branch.Enabled = False
            barEditItem_Branch.EditValue = class_saga_variables.sbranchcode
        End If
    End Sub

    private sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        showList()
    End Sub

    Friend Sub showList()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", BarEditItem_Branch.EditValue),
            New SqlParameter("@ParamCutOffDate", BarEditItem_CutOff.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GCList, gridView, "mg_Generate_AgedAccounts")
    End Sub

    Private sub btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick

        Dim report As New RPT_ActualCollectionPrintPreview()
        gridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GCList
        'report.Parameters("AeCode").Value = ""
        report.Parameters("BranchAddress").Value = BranchAddress.Text
        report.Parameters("BranchCode").Value = barEditItem_Branch.EditValue
        report.Parameters("BranchName").Value = BranchName.Text
        report.Parameters("CheckedBy").Value = CheckedBy.Text

        report.Parameters("Preparedby").Value = PreparedBy.Text
        report.Parameters("ReportTitle").Value = "MC FOR DEPO LIST"
        report.XrLabel7.Text = String.Empty
        report.XrLabel6.Text = "CutOffDate: "
        report.Parameters("DateBegin").Value = Format(BarEditItem_CutOff.EditValue, "MMM dd, yyyy")

        report.XrLabel7.Text = String.Empty
        'report.Parameters("DateEnd").Value = "")
        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    private sub mg_ShowBranchDetails()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", barEditItem_Branch.EditValue),
            New SqlParameter("@ParamTransactedBy", class_Variables.sUserName)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowBranchDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                PreparedBy.Text = myDataReader("Maker").ToString()
                CheckedBy.Text = myDataReader("BM").ToString()
                BranchName.Text = myDataReader("BranchName").ToString()
                BranchAddress.Text = myDataReader("BranchAddress").ToString()
            End If
        End Using
    End Sub

    private sub barEditItem_Branch_EditValueChanged(sender As Object, e As EventArgs) Handles barEditItem_Branch.EditValueChanged
        mg_ShowBranchDetails()
    End Sub

    private sub gridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
        txt_BranchCode.Text = gridView.Columns.View.GetFocusedRowCellValue("BranchCode")
        txt_AccountNumber.Text = gridView.Columns.View.GetFocusedRowCellValue("AccountNumber")
        txt_LedgerSetNumber.Text = gridView.Columns.View.GetFocusedRowCellValue("LedgerSetNumber")

        DockPanel.Visible = True
    End Sub

    private sub Frmbtn_Update_Click(sender As Object, e As EventArgs) Handles Frmbtn_Update.Click
        mg_UpdateAccountsAdvanced()
        DockPanel.Visible = False

        class_Procedures.splash_Show("Loading List..")
        showList()
        class_Procedures.splash_Close()
    End Sub

    private sub mg_UpdateAccountsAdvanced()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_BranchCode.Text),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedgerSetNumber.Text),
            New SqlParameter("@ParamAccountName", "0"),
            New SqlParameter("@ParamAddress", "0"),
            New SqlParameter("@ParamModel", "0"),
            New SqlParameter("@ParamColor", "0"),
            New SqlParameter("@ParamDescription", "0"),
            New SqlParameter("@ParamBrand", "0"),
            New SqlParameter("@ParamWH", "0"),
            New SqlParameter("@ParamKeyNumber", "0"),
            New SqlParameter("@ParamEngineNo", "0"),
            New SqlParameter("@ParamChassisNo", "0"),
            New SqlParameter("@ParamCOD", "0"),
            New SqlParameter("@ParamLCP", "0"),
            New SqlParameter("@ParamRebates", "0"),
            New SqlParameter("@ParamDP", "0"),
            New SqlParameter("@ParamFinancedAmt", "0"),
            New SqlParameter("@ParamSaleType", "0"),
            New SqlParameter("@ParamTerms", "0"),
            New SqlParameter("@ParamRate", "0"),
            New SqlParameter("@ParamAccountStatus", "0"),
            New SqlParameter("@ParamDateGranted", Now),
            New SqlParameter("@ParamFirstPayDate", Now),
            New SqlParameter("@ParamMaturityDate", Now),
            New SqlParameter("@ParamLastMvmtDate", Now),
            New SqlParameter("@ParamAECode", "0"),
            New SqlParameter("@ParamAgentCode", "0"),
            New SqlParameter("@ParamGenAmortSched", "0"),
            New SqlParameter("@ParamID", "0"),
            New SqlParameter("@ParamPrinOB", "0"),
            New SqlParameter("@ParamIntOB", "0"),
            New SqlParameter("@ParamTotalOB", "0"),
            New SqlParameter("@ParamCIFKey", "0"),
            New SqlParameter("@ParamDetailRemarks", txt_Remarks.Text),
            New SqlParameter("@ParamSourceEvent", "MCUnitsForDepo")
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_UpdateAccountsAdvanced", "Account Update", $"{txt_AccountNumber.Text}-{txt_LedgerSetNumber.Text}")
    End Sub

End Class