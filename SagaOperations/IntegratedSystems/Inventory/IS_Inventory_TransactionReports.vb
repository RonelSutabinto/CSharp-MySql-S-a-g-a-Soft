﻿Imports CrystalDecisions.CrystalReports.Engine
Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inventory_TransactionReports
    Dim Crystal_Report As New ReportDocument

    Private Sub IS_Inventory_TransactionReports_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LViewList.Items.Clear()
    End Sub

    Sub searchTransType()
        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamInvStatus", txt_trans.Text),
            New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowInTransitMCByBranch")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("RefNo"))
                    li.SubItems.Add(myDataReader.Item("PONo").ToString())
                    li.SubItems.Add(myDataReader.Item("whcode"))
                    li.SubItems.Add(myDataReader.Item("inventoryStatus").ToString())
                    li.SubItems.Add(myDataReader.Item("SourceEvent"))
                Loop
            End If
        End Using
    End Sub

    Private Sub cmd_showInvent_Click(sender As System.Object, e As System.EventArgs) Handles cmd_showInvent.Click
        searchTransType()
    End Sub

    Private Sub LViewList_DoubleClick(sender As Object, e As System.EventArgs) Handles LViewList.DoubleClick
        txt_RefNo.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
        txt_PoNo.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
        txt_WhCode.Text = LViewList.SelectedItems.Item(0).SubItems(2).Text
        ' 
        LoadIntransitMCMaster()
        LoadIntransitMCDetails()
        ShowReport()
    End Sub

    Sub LoadIntransitMCMaster()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamRefNo", txt_RefNo.Text),
            New SqlParameter("@ParamPoNo", txt_PoNo.Text),
            New SqlParameter("@ParamWhCode", txt_WhCode.Text),
            New SqlParameter("@ParamTitle", txt_rptTitle.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowInMCInventoryMasterDetails")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                txt_BranchCode.Text = myDataReader("branchcode").ToString()
                txt_BranchName.Text = myDataReader("BranchName").ToString()
                txt_BranchAddress.Text = myDataReader("BranchAddress").ToString()
                txt_phoneNo.Text = myDataReader("BranchPhoneNumber").ToString()
                txt_vendor.Text = myDataReader("vendor").ToString()

                txt_Date.Text = Format(myDataReader.Item("dateReceived"), "MMMM d,yyyy")
                txt_Warehouse.Text = myDataReader("whcategory").ToString()
                txt_Count.Text = myDataReader("itemcnt").ToString()

                txt_UnitCostTot.EditValue = myDataReader("totalUnitCost").ToString()
                txt_VatTotal.EditValue = myDataReader("totalVATAmt").ToString()
                txt_GrandTotal.EditValue = myDataReader("GrandTotalUnitCost").ToString()
                txt_UnitPriceTotal.EditValue = myDataReader("TotalUnitPrice").ToString()

                txt_TransactedBy.Text = myDataReader("TransactedbyFull").ToString()
                txt_ApprovedBy.Text = myDataReader("ApproverFull").ToString()

                txt_ValidatedBy.Text = myDataReader("ValidatedByFull").ToString()

                txt_ReceivedBy.Text = myDataReader("BranchReceiverFull").ToString()
                txt_ConfirmedBy.Text = myDataReader("BMReceiver").ToString()
            End If
        End Using
    End Sub

    Sub LoadIntransitMCDetails()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamRefNo", txt_RefNo.Text),
            New SqlParameter("@ParamPoNo", txt_PoNo.Text),
            New SqlParameter("@ParamWhCode", txt_WhCode.Text),
            New SqlParameter("@ParamTitle", txt_rptTitle.Text)
        }

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCInTransitMC, GViewMCIntransit, "mg_ShowInMCInventoryMasterDetails")
    End Sub

    Sub ShowReport()
        Dim report As New rpt_inv_Inventory_ReceivingReport()
        GViewMCIntransit.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GCInTransitMC

        report.txt_Title.Text = txt_rptTitle.Text
        report.txt_Branch.Text = txt_BranchName.Text
        report.txt_BranchAddress.Text = txt_BranchAddress.Text
        report.txt_Number.Text = txt_phoneNo.Text

        report.txt_Vendor.Text = txt_vendor.Text
        report.txt_Date.Text = txt_Date.Text
        report.txt_Warehouse.Text = txt_Warehouse.Text

        report.txt_Refno.Text = txt_RefNo.Text
        report.txt_PONo.Text = txt_PoNo.Text

        report.txt_Count.Text = txt_Count.Text

        report.txt_CostTotal.Text = txt_UnitCostTot.Text
        report.txt_VatTotal.Text = txt_VatTotal.Text
        report.txt_GrandTotal.Text = txt_GrandTotal.Text
        report.txt_UnitPriceTotal.Text = txt_UnitPriceTotal.Text

        report.txt_Transactedby.Text = txt_TransactedBy.Text
        report.txt_approved.Text = txt_ApprovedBy.Text

        report.txt_validated.Text = txt_ValidatedBy.Text

        report.txt_ReceivedBy.Text = txt_ReceivedBy.Text
        report.txt_ReceiverBM.Text = txt_ConfirmedBy.Text

        report.ShowPreview
    End Sub
End Class