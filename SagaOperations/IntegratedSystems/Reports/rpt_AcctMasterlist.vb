Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class rpt_AcctMasterlist
    Private Sub rpt_AcctMasterlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(txt_BrCode, RepositoryItemTextEdit3)
        If MainMenu.statusBrCode.Caption = "000" Then
            txt_BrCode.Enabled = True
            txt_BrCode.EditValue = MainMenu.statusBrCode.Caption
        Else
            txt_BrCode.Enabled = False
            txt_BrCode.EditValue = MainMenu.statusBrCode.Caption
        End If
    End Sub

    Sub showAccountMasterlist()
        GViewAcctList.Columns.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_BrCode.EditValue),
            New SqlParameter("@ParamPostingDate", txt_PostingDate.EditValue),
            New SqlParameter("@ParamAECode", txt_AeCode.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCAcctList, GViewAcctList, "mg_MasterList")
    End Sub

    Private Sub cmd_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        class_Procedures.splash_Show("Loading Masterlist")
        showAccountMasterlist()
        class_Procedures.splash_Close()
    End Sub

    Private Sub cmd_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Preview.ItemClick
        ' Create a report instance.
        Dim report As New RPT_ActualCollectionPrintPreview()
        GViewAcctList.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GCAcctList
        'Obtain a parameter And set its value.
        report.Parameters("AeCode").Value = txt_AeCode.EditValue

        report.Parameters("BranchAddress").Value = BranchAddress.Text
        report.Parameters("BranchCode").Value = txt_BrCode.EditValue
        report.Parameters("BranchName").Value = BranchName.Text
        report.Parameters("CheckedBy").Value = CheckedBy.Text
        report.Parameters("DateBegin").Value = Format(txt_PostingDate.EditValue, "MM/dd/yyyy")
        report.Parameters("Preparedby").Value = PreparedBy.Text
        report.Parameters("ReportTitle").Value = "MC ACCOUNT MASTERLIST"
        report.XrLabel7.Text = String.Empty

        For Each param In report.Parameters
            param.Visible = False
        Next

        report.ShowPreview
    End Sub

    Sub mg_ShowBranchDetails()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_BrCode.EditValue.ToString),
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

    Private Sub txt_BrCode_EditValueChanged(sender As Object, e As EventArgs) Handles txt_BrCode.EditValueChanged
        mg_ShowBranchDetails()
    End Sub

    Private Sub rpt_AcctMasterlist_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(Me, BarManager1)
    End Sub

End Class