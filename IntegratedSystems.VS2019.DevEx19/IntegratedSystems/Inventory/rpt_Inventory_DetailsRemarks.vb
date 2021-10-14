Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports wSClassLib.myModules

Public Class rpt_Inventory_DetailsRemarks

    private sub rpt_Inventory_DetailsRemarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DockDetails.Visible = False
    End Sub

    private sub rpt_Inventory_DetailsRemarks_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        class_Saga_Procedures.Initialize_BarManager(BarManager1)

        class_Saga_Variables.Initialize_Branch()
        class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit1)

        Initialize_whcodeOutgoing()
        Initialize_whcodeOutgoing(BarEditItem_Warehouse, RepositoryItemLookUpEdit3)
        Initialize_InvRemarks("MCInventory")
        Initialize_InvRemarks("MCInventory", txt_DetailedRemarks)

        'Initialize_Button(DockDetails)

        txt_DateReceived.EditValue = Now

        If class_saga_variables.sbranchcode = "000" Then
            barEditItem_Branch.Enabled = True
            barEditItem_Branch.EditValue = class_saga_variables.sbranchcode
        Else
            barEditItem_Branch.Enabled = False
            barEditItem_Branch.EditValue = class_saga_variables.sbranchcode
        End If
    End Sub

    private sub btn_Reload_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
        class_Procedures.splash_Show("Loading List")
        showInventory()
        class_Procedures.splash_Close()
    End Sub

    private sub showInventory()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", barEditItem_Branch.EditValue),
            New SqlParameter("@ParamIfExist", "1"),
            New SqlParameter("@ParamWHCode", BarEditItem_Warehouse.EditValue)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GCList, gridView, "mg_ShowMCInvDetailRemarks")
    End Sub

    private sub gridView_DoubleClick(sender As Object, e As EventArgs) Handles gridView.DoubleClick
        txt_ID.text = gridView.Columns.View.GetFocusedRowCellValue("id")
        txt_BranchCode.Text = gridView.Columns.View.GetFocusedRowCellValue("branchcode")
        txt_BranchAbbrev.Text = gridView.Columns.View.GetFocusedRowCellValue("branchabrev")
        txt_BranchName.Text = gridView.Columns.View.GetFocusedRowCellValue("branchname")
        txt_REfNo.Text = gridView.Columns.View.GetFocusedRowCellValue("refno")
        txt_PONo.Text = gridView.Columns.View.GetFocusedRowCellValue("POno")
        txt_DateReceived.EditValue = gridView.Columns.View.GetFocusedRowCellValue("dateReceived")
        txt_Brand.Text = gridView.Columns.View.GetFocusedRowCellValue("brand")
        txt_Model.Text = gridView.Columns.View.GetFocusedRowCellValue("model")
        txt_Color.Text = gridView.Columns.View.GetFocusedRowCellValue("color")
        txt_EngineNo.Text = gridView.Columns.View.GetFocusedRowCellValue("EngineNo")
        txt_ChassisNo.Text = gridView.Columns.View.GetFocusedRowCellValue("ChassisNo")
        txt_KeyNo.Text = gridView.Columns.View.GetFocusedRowCellValue("keyno")
        txt_whcode.Text = gridView.Columns.View.GetFocusedRowCellValue("whCode")
        txt_Aged.Text = gridView.Columns.View.GetFocusedRowCellValue("Aged")
        txt_AccountName.Text = gridView.Columns.View.GetFocusedRowCellValue("AccountName")
        txt_AcctBrCode.Text = gridView.Columns.View.GetFocusedRowCellValue("BrCodeAccount")
        txt_AccountNumber.Text = gridView.Columns.View.GetFocusedRowCellValue("AccountNumber")
        txt_Ledset.Text = gridView.Columns.View.GetFocusedRowCellValue("LedgerSetNumber")
        txt_SpecNotes.Text = gridView.Columns.View.GetFocusedRowCellValue("SpecNotes")
        txt_DetailedRemarks.Text = gridView.Columns.View.GetFocusedRowCellValue("DetailRemark")

        DockDetails.Visible = True
    End Sub

    private sub btn_Update_Click(sender As Object, e As EventArgs) Handles Frmbtn_Update.Click
        ModifyInvDetailsRemarks()
        DockDetails.Visible = False
        class_Procedures.splash_Show("Loading List")
        showInventory()
        class_Procedures.splash_Close()
    End Sub

    private sub Frmbtn_Find_Account_Click(sender As Object, e As EventArgs) Handles Frmbtn_Find_Account.Click
        IS_Sales_ReleaseAccount_List.Text = "INVDETREMARKS"
        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    private sub ModifyInvDetailsRemarks()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@Paramid", txt_ID.text),
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
            New SqlParameter("@ParamEngineNo", txt_EngineNo.Text),
            New SqlParameter("@ParamChassisNo", txt_ChassisNo.Text),
            New SqlParameter("@Paramkeyno", txt_KeyNo.Text),
            New SqlParameter("@Paramtransactedby", class_Variables.sUserName),
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

        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_AdminReclassInventory", "MOdifiy Details Remarks", txt_ID.text)
    End Sub

End Class