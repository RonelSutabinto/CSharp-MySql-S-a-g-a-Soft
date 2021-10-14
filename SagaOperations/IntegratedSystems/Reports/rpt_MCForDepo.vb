Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient
Imports wSClassLib.myModules

Public Class rpt_MCForDepo
    Private Sub rpt_MCForDepo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DockPanel.Visible = False
        BarEditItem_CutOff.EditValue = Now
    End Sub

    Private Sub rpt_MCForDepo_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(BarManager1)

        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit1)

        Initialize_Button(DockPanel)

        Initialize_InvRemarks("MCAccount")
        Initialize_InvRemarks("MCAccount", txt_Remarks)

        If MainMenu.statusBrCode.Caption = "000" Then
            barEditItem_Branch.Enabled = True
            barEditItem_Branch.EditValue = MainMenu.statusBrCode.Caption
        Else
            barEditItem_Branch.Enabled = False
            barEditItem_Branch.EditValue = MainMenu.statusBrCode.Caption
        End If
    End Sub

    Private Sub Btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        showList()
    End Sub

    Sub showList()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", barEditItem_Branch.EditValue),
            New SqlParameter("@ParamCutOffDate", BarEditItem_CutOff.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCList, GridView, "mg_Generate_AgedAccounts")
    End Sub

    Private Sub Btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick

        Dim report As New RPT_ActualCollectionPrintPreview()
        GridView.SelectAll()
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
        report.Parameters("DateBegin").Value = Format(BarEditItem_CutOff.EditValue, "MM/dd/yyyy")

        report.XrLabel7.Text = String.Empty
        'report.Parameters("DateEnd").Value = "")
        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Sub mg_ShowBranchDetails()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", barEditItem_Branch.EditValue),
            New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowBranchDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                PreparedBy.Text = myDataReader("Maker").ToString()
                CheckedBy.Text = myDataReader("BM").ToString()
                BranchName.Text = myDataReader("BranchName").ToString()
                BranchAddress.Text = myDataReader("BranchAddress").ToString()
            End If
        End Using
    End Sub

    Private Sub barEditItem_Branch_EditValueChanged(sender As Object, e As EventArgs) Handles barEditItem_Branch.EditValueChanged
        mg_ShowBranchDetails()
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles GridView.DoubleClick
        txt_BranchCode.Text = GridView.Columns.View.GetFocusedRowCellValue("BranchCode")
        txt_AccountNumber.Text = GridView.Columns.View.GetFocusedRowCellValue("AccountNumber")
        txt_LedgerSetNumber.Text = GridView.Columns.View.GetFocusedRowCellValue("LedgerSetNumber")

        DockPanel.Visible = True
    End Sub

    Private Sub FrmBtn_Update_Click(sender As Object, e As EventArgs) Handles FrmBtn_Update.Click
        mg_UpdateAccountsAdvanced()
        DockPanel.Visible = False

        class_Procedures.splash_Show("Loading List..")
        showList()
        class_Procedures.splash_Close()
    End Sub

    Sub mg_UpdateAccountsAdvanced()
        Dim Parameters As SqlParameter() = {
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

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_UpdateAccountsAdvanced", "Account Update", $"{txt_AccountNumber.Text}-{txt_LedgerSetNumber.Text}")
    End Sub

End Class