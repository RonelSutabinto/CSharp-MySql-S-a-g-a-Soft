Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient
Imports wSClassLib.myModules

Public Class rpt_Inventory_DetailsRemarks

    Private Sub rpt_Inventory_DetailsRemarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DockDetails.Visible = False
    End Sub

    Private Sub rpt_Inventory_DetailsRemarks_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(BarManager1)

        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit1)

        Initialize_whcodeOutgoing()
        Initialize_whcodeOutgoing(BarEditItem_Warehouse, RepositoryItemLookUpEdit3)
        Initialize_InvRemarks("MCInventory")
        Initialize_InvRemarks("MCInventory", txt_DetailedRemarks)

        Initialize_Button(DockDetails)

        txt_DateReceived.EditValue = Now

        If MainMenu.statusBrCode.Caption = "000" Then
            barEditItem_Branch.Enabled = True
            barEditItem_Branch.EditValue = MainMenu.statusBrCode.Caption
        Else
            barEditItem_Branch.Enabled = False
            barEditItem_Branch.EditValue = MainMenu.statusBrCode.Caption
        End If
    End Sub

    Private Sub Btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles Btn_Reload.ItemClick
        class_Procedures.splash_Show("Loading List")
        showInventory()
        class_Procedures.splash_Close()
    End Sub

    Sub showInventory()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", barEditItem_Branch.EditValue),
            New SqlParameter("@ParamIfExist", "1"),
            New SqlParameter("@ParamWHCode", BarEditItem_Warehouse.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCList, GridView, "mg_ShowMCInvDetailRemarks")
    End Sub

    Private Sub GridView_DoubleClick(sender As Object, e As EventArgs) Handles GridView.DoubleClick
        txt_ID.Text = GridView.Columns.View.GetFocusedRowCellValue("id")
        txt_BranchCode.Text = GridView.Columns.View.GetFocusedRowCellValue("branchcode")
        txt_BranchAbbrev.Text = GridView.Columns.View.GetFocusedRowCellValue("branchabrev")
        txt_BranchName.Text = GridView.Columns.View.GetFocusedRowCellValue("branchname")
        txt_REfNo.Text = GridView.Columns.View.GetFocusedRowCellValue("refno")
        txt_PONo.Text = GridView.Columns.View.GetFocusedRowCellValue("POno")
        txt_DateReceived.EditValue = GridView.Columns.View.GetFocusedRowCellValue("dateReceived")
        txt_Brand.Text = GridView.Columns.View.GetFocusedRowCellValue("brand")
        txt_Model.Text = GridView.Columns.View.GetFocusedRowCellValue("model")
        txt_Color.Text = GridView.Columns.View.GetFocusedRowCellValue("color")
        txt_EngineNo.Text = GridView.Columns.View.GetFocusedRowCellValue("engineno")
        txt_ChassisNo.Text = GridView.Columns.View.GetFocusedRowCellValue("chassisno")
        txt_KeyNo.Text = GridView.Columns.View.GetFocusedRowCellValue("keyno")
        txt_whcode.Text = GridView.Columns.View.GetFocusedRowCellValue("whCode")
        txt_Aged.Text = GridView.Columns.View.GetFocusedRowCellValue("Aged")
        txt_AccountName.Text = GridView.Columns.View.GetFocusedRowCellValue("AccountName")
        txt_AcctBrCode.Text = GridView.Columns.View.GetFocusedRowCellValue("BrCodeAccount")
        txt_AccountNumber.Text = GridView.Columns.View.GetFocusedRowCellValue("AccountNumber")
        txt_Ledset.Text = GridView.Columns.View.GetFocusedRowCellValue("LedgerSetNumber")
        txt_SpecNotes.Text = GridView.Columns.View.GetFocusedRowCellValue("SpecNotes")
        txt_DetailedRemarks.Text = GridView.Columns.View.GetFocusedRowCellValue("DetailRemark")

        DockDetails.Visible = True
    End Sub

    Private Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles FrmBtn_Update.Click
        ModifyInvDetailsRemarks()
        DockDetails.Visible = False
        class_Procedures.splash_Show("Loading List")
        showInventory()
        class_Procedures.splash_Close()
    End Sub

    Private Sub FrmBtn_Find_Account_Click(sender As Object, e As EventArgs) Handles FrmBtn_Find_Account.Click
        IS_Sales_ReleaseAccount_List.Text = "INVDETREMARKS"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Sub ModifyInvDetailsRemarks()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@Paramid", txt_ID.Text),
            New SqlParameter("@Paramvendor", txt_BranchName.Text),
            New SqlParameter("@ParamdateReceived", txt_DateReceived.Text),
            New SqlParameter("@Paramwhcategory", txt_whcode.Text),
            New SqlParameter("@ParamwhCode", txt_whcode.EditValue),
            New SqlParameter("@ParaminventoryStatus", String.Empty),
            New SqlParameter("@ParamIfExist", String.Empty),
            New SqlParameter("@ParamCode", String.Empty),
            New SqlParameter("@Parammodel", txt_Model.Text),
            New SqlParameter("@Paramcolor", txt_Color.Text),
            New SqlParameter("@Paramdescription", txt_Model.Text & " - " & txt_Color.Text),
            New SqlParameter("@Parambrand", txt_Brand.Text),
            New SqlParameter("@Paramengineno", txt_EngineNo.Text),
            New SqlParameter("@Paramchassisno", txt_ChassisNo.Text),
            New SqlParameter("@Paramkeyno", txt_KeyNo.Text),
            New SqlParameter("@Paramtransactedby", MainMenu.App_User_Name.Caption),
            New SqlParameter("@Paramtransactiondate", Now),
            New SqlParameter("@Parambranchcode", txt_BranchCode.Text),
            New SqlParameter("@Paramitem_grp", "MOTORCYCLE"),
            New SqlParameter("@ParamRemarks", txt_DetailedRemarks.Text),
            New SqlParameter("@ParamPrevID", String.Empty),
            New SqlParameter("@ParamSourceEvent", "INVDETREMARKS"),
            New SqlParameter("@Paramnote", txt_AccountName.Text),
            New SqlParameter("@ParasBranchCodeAccount", txt_AcctBrCode.Text),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_Ledset.Text),
            New SqlParameter("@ParamSpecNotes", txt_SpecNotes.Text),
            New SqlParameter("@ParamDetailedRemarks", txt_DetailedRemarks.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_AdminReclassInventory", "MOdifiy Details Remarks", txt_ID.Text)
    End Sub

End Class