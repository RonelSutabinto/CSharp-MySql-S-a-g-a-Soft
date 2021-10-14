Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Branch
    Private Sub SPA_Branch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_BrCode.EditValue = MainMenu.statusBrCode.Caption
        If MainMenu.statusBrCode.Caption = "000" Then
            txt_BrCode.Enabled = True
        Else
            Disabled_txt()
            txt_BrCode.Enabled = False
        End If
        Show_SparePartsWithParam()
        SPA_BrandParameter()
        SPA_CategoryParameter()
        LV_PARTS_TotalQuantity()
        LV_PARTS_TotalCost()
        LV_PARTS_TotalSRP()
    End Sub

    Sub SPA_Find_SparePartsWithParam()
        lv_Parts.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", txt_Search.EditValue),
            New SqlParameter("@ParamBranchCode", txt_BrCode.EditValue)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_SparePartsWithParam")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_Parts.Items.Add(myDataReader.Item("ReceivingBranch").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsName").ToString())
                    li.SubItems.Add(myDataReader.Item("InventoryStatus").ToString())
                    li.SubItems.Add(myDataReader.Item("Quantity").ToString())
                    li.SubItems.Add(myDataReader.Item("Prev_Quantity").ToString())
                    li.SubItems.Add(myDataReader.Item("SRP").ToString())
                    li.SubItems.Add(myDataReader.Item("SPCostWOVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("Subtotal").ToString())
                    li.SubItems.Add(myDataReader.Item("ID").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub btn_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Find.ItemClick
        SPA_Find_SparePartsWithParam()
        LV_PARTS_TotalQuantity()
        LV_PARTS_TotalCost()
        LV_PARTS_TotalSRP()
    End Sub

    Sub Show_SparePartsWithParam()
        lv_Parts.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", txt_BrCode.EditValue)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_ShowSparePartsWithParam")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_Parts.Items.Add(myDataReader.Item("ReceivingBranch").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsName").ToString())
                    li.SubItems.Add(myDataReader.Item("InventoryStatus").ToString())
                    li.SubItems.Add(myDataReader.Item("Quantity").ToString())
                    li.SubItems.Add(myDataReader.Item("Prev_Quantity").ToString())
                    li.SubItems.Add(myDataReader.Item("SRP").ToString())
                    li.SubItems.Add(myDataReader.Item("SPCostWOVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("Subtotal").ToString())
                    li.SubItems.Add(myDataReader.Item("ID").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub SPA_Find_SpareParts_ID()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamID", txt_ID.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_SpareParts_ID")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_ID.Text = myDataReader("ID").ToString()
                txt_BranchCode.Text = myDataReader("ReceivingBranch").ToString()
                txt_PartsNumber.Text = myDataReader("PartsNumber").ToString()
                txt_PartsName.Text = myDataReader("PartsName").ToString()
                cmb_Brand.Text = myDataReader("Brand").ToString()
                cmb_Category.Text = myDataReader("Category").ToString()
                txt_ModelCode.Text = myDataReader("ModelCode").ToString()
                txt_ModelName.Text = myDataReader("ModelName").ToString()
                txt_Note.Text = myDataReader("Note").ToString()
                txt_Remarks.Text = myDataReader("Remarks").ToString()
                dtp_PostingDate.Text = myDataReader("PostingDate").ToString()
                txt_Status.Text = myDataReader("InventoryStatus").ToString()
                txt_Refno.Text = myDataReader("Refno").ToString()
                txt_POno.Text = myDataReader("PONo").ToString()
                txt_Branch.Text = myDataReader("Vendor").ToString()
                txt_Quantity.Text = myDataReader("Quantity").ToString()
                txt_Prev_Quantity.Text = myDataReader("Prev_Quantity").ToString()
                txt_CostWVAT.Text = myDataReader("SPCostWVAT").ToString()
                txt_CostWOVAT.Text = myDataReader("SPCostWoVAT").ToString()
                txt_Checker.Text = myDataReader("Checker").ToString()
                txt_Approver.Text = myDataReader("Approver").ToString()
                dtp_DateCheck.Text = myDataReader("DateCheck").ToString()
                dtp_DateApproved.Text = myDataReader("DateApproved").ToString()
                txt_CurrentApprover.Text = myDataReader("CurrentApprover").ToString()
                txt_Source.Text = myDataReader("SourceEvent").ToString()
                txt_SRP.Text = myDataReader("SRP").ToString()
                txt_BinBox.Text = myDataReader("BinBox").ToString()
                txt_SubTotal.Text = myDataReader("SubTotal").ToString()
                txt_TotalLess.Text = myDataReader("TotalLess").ToString()
                txt_GrandTotal.Text = myDataReader("GrandTotal").ToString()
                txt_Discount.Text = myDataReader("TotalDiscountAMT").ToString()
                txt_TotalCostWOVAT.Text = myDataReader("TotalCostWOVAT").ToString()
            End If
        End Using
    End Sub

    Sub SPA_BrandParameter()
        cmb_Brand.Properties.Items.Clear()
        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_BrandParameter")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_Brand.Properties.Items.Add(myDataReader.Item("branddesc").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub SPA_CategoryParameter()
        cmb_Category.Properties.Items.Clear()
        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_CategoryParameter")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_Category.Properties.Items.Add(myDataReader.Item("Category_Description").ToString)
                Loop
            End If
        End Using
    End Sub

    Private Sub lv_Parts_DoubleClick(sender As Object, e As EventArgs) Handles lv_Parts.DoubleClick
        txt_PartsNumber.EditValue = lv_Parts.SelectedItems.Item(0).SubItems(1).Text()
        txt_PartsName.EditValue = lv_Parts.SelectedItems.Item(0).SubItems(2).Text()
        txt_Status.EditValue = lv_Parts.SelectedItems.Item(0).SubItems(3).Text()
        txt_Quantity.EditValue = lv_Parts.SelectedItems.Item(0).SubItems(4).Text()
        txt_Prev_Quantity.EditValue = lv_Parts.SelectedItems.Item(0).SubItems(5).Text()
        txt_SRP.EditValue = lv_Parts.SelectedItems.Item(0).SubItems(6).Text()
        txt_CostWOVAT.EditValue = lv_Parts.SelectedItems.Item(0).SubItems(7).Text()
        txt_ID.EditValue = lv_Parts.SelectedItems.Item(0).SubItems(9).Text()
        If txt_Discount.EditValue = String.Empty Or txt_CostWVAT.Text = String.Empty Or txt_CostWOVAT.Text = String.Empty Or txt_SRP.Text = String.Empty Or txt_SubTotal.Text = String.Empty Or txt_GrandTotal.Text = String.Empty Or txt_TotalCostWOVAT.Text = String.Empty Then
            txt_Discount.EditValue = "0.00"
            txt_CostWVAT.EditValue = "0.00"
            txt_CostWOVAT.EditValue = "0.00"
            txt_SRP.EditValue = "0.00"
            txt_SubTotal.EditValue = "0.00"
            txt_GrandTotal.EditValue = "0.00"
            txt_TotalCostWOVAT.EditValue = "0.00"
        End If
    End Sub

    Private Sub txt_ID_EditValueChanged(sender As Object, e As EventArgs) Handles txt_ID.EditValueChanged
        SPA_Find_SpareParts_ID()
    End Sub

    Sub SPA_Inventory_Modify_SpareParts()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamID", txt_ID.EditValue),
            New SqlParameter("@ParamReceivingBranch", txt_BranchCode.EditValue),
            New SqlParameter("@ParamPartsNumber", txt_PartsNumber.EditValue),
            New SqlParameter("@ParamPartsName", txt_PartsName.EditValue),
            New SqlParameter("@ParamBrand", cmb_Brand.Text),
            New SqlParameter("@ParamCategory", cmb_Category.EditValue),
            New SqlParameter("@ParamModelCode", txt_ModelCode.EditValue),
            New SqlParameter("@ParamModelName", txt_ModelName.EditValue),
            New SqlParameter("@ParamNote", txt_Note.EditValue),
            New SqlParameter("@ParamRemarks", txt_Remarks.EditValue),
            New SqlParameter("@ParamPostingDate", dtp_PostingDate.EditValue),
            New SqlParameter("@ParamInventoryStatus", txt_Status.EditValue),
            New SqlParameter("@ParamRefno", txt_Refno.EditValue),
            New SqlParameter("@ParamPONo", txt_POno.EditValue),
            New SqlParameter("@ParamVendor", txt_Branch.EditValue),
            New SqlParameter("@ParamQuantity", txt_Quantity.EditValue),
            New SqlParameter("@ParamPrev_Quantity", txt_Prev_Quantity.EditValue),
            New SqlParameter("@ParamSPCostWVAT", txt_CostWVAT.EditValue),
            New SqlParameter("@ParamSPCostWOVAT", txt_CostWOVAT.EditValue),
            New SqlParameter("@ParamChecker", txt_Checker.EditValue),
            New SqlParameter("@ParamApprover", txt_Approver.EditValue),
            New SqlParameter("@ParamDateCheck", dtp_DateCheck.EditValue),
            New SqlParameter("@ParamDateApproved", dtp_DateApproved.EditValue),
            New SqlParameter("@ParamCurrentApprover", txt_CurrentApprover.EditValue),
            New SqlParameter("@ParamSourceEvent", txt_Source.EditValue),
            New SqlParameter("@ParamSRP", txt_SRP.EditValue),
            New SqlParameter("@ParamBinBox", txt_BinBox.EditValue),
            New SqlParameter("@ParamSubTotal", txt_SubTotal.EditValue),
            New SqlParameter("@ParamTotalLess", txt_TotalLess.EditValue),
            New SqlParameter("@ParamGrandTotal", txt_GrandTotal.EditValue),
            New SqlParameter("@ParamDiscount", txt_Discount.EditValue),
            New SqlParameter("@ParamTotalCostWOVAT", txt_TotalCostWOVAT.EditValue),
            New SqlParameter("@ParamTransactedby", MainMenu.App_User_Name.Caption)
        }

        class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "SPA_Inventory_Modify_SpareParts", "Modifiy SPA")
    End Sub

    Sub SPA_Inventory_Delete_SpareParts()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamID", txt_ID.Text),
            New SqlParameter("@ParamReceivingBranch", txt_BranchCode.Text),
            New SqlParameter("@ParamRefno", txt_Refno.Text),
            New SqlParameter("@ParamPONo", txt_POno.Text),
            New SqlParameter("@ParamPartsNumber", txt_PartsNumber.Text),
            New SqlParameter("@ParamPartsName", txt_PartsName.Text),
            New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Inventory_Delete_SpareParts", "Delete SPA")
    End Sub

    Private Sub btn_Refresh_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Refresh.ItemClick
        Show_SparePartsWithParam()
        clear_Txt()
    End Sub

    Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        SPA_Inventory_Modify_SpareParts()
        SPA_Find_SparePartsWithParam()
        clear_Txt()
    End Sub

    Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick

        Dim delete As Integer = MessageBox.Show("Are you sure Deleting this Spare Parts - " + txt_PartsNumber.Text, Application.CompanyName, MessageBoxButtons.YesNo)
        If delete = DialogResult.No Then
            MessageBox.Show("Cancel Deleting " + txt_PartsNumber.Text + " - Spare Parts", Application.CompanyName)
        Else
            SPA_Inventory_Delete_SpareParts()
            SPA_Find_SparePartsWithParam()
            clear_Txt()
        End If

    End Sub

    Private Sub txt_Quantity_EditValueChanged(sender As Object, e As EventArgs) Handles txt_Quantity.EditValueChanged
        txt_SubTotal.Text = Math.Round(Val(txt_Quantity.Text) * Val(txt_CostWVAT.Text), 2)
    End Sub

    Private Sub txt_CostWOVAT_EditValueChanged(sender As Object, e As EventArgs) Handles txt_CostWOVAT.EditValueChanged
        txt_CostWVAT.Text = Math.Round(Val(txt_CostWOVAT.Text) * Val(1.12), 2)
    End Sub

    Private Sub txt_CostWVAT_EditValueChanged(sender As Object, e As EventArgs) Handles txt_CostWVAT.EditValueChanged
        txt_SubTotal.Text = Math.Round(Val(txt_Quantity.Text) * Val(txt_CostWVAT.Text), 2)
    End Sub

    Sub LV_PARTS_TotalQuantity()
        Dim TotalSum As Double = 0
        Dim Sum As ListViewItem

        For Each Sum In lv_Parts.Items
            TotalSum += CDbl(Sum.SubItems.Item(4).Text)
        Next
        statusQuantity.Caption = TotalSum
    End Sub

    Sub LV_PARTS_TotalCost()
        Dim TotalSum As Double = 0
        Dim Sum As ListViewItem

        For Each Sum In lv_Parts.Items
            TotalSum += Math.Round(CDbl(Sum.SubItems.Item(7).Text) * CDbl(Sum.SubItems.Item(4).Text), 2)
        Next
        statusTotalCost.Caption = TotalSum
    End Sub

    Sub LV_PARTS_TotalSRP()
        Dim TotalSum As Double = 0
        Dim Sum As ListViewItem

        For Each Sum In lv_Parts.Items
            TotalSum += Math.Round(CDbl(Sum.SubItems.Item(6).Text) * CDbl(Sum.SubItems.Item(4).Text), 2)
        Next
        statusTotalSRP.Caption = TotalSum
    End Sub

    Sub clear_Txt()
        txt_ID.Text = String.Empty
        txt_BranchCode.Text = txt_BrCode.EditValue
        txt_PartsNumber.Text = String.Empty
        txt_PartsName.Text = String.Empty
        cmb_Brand.Text = "YAMAHA"
        cmb_Category.Text = "Spare Parts"
        txt_ModelCode.Text = "N/A"
        txt_ModelName.Text = "N/A"
        txt_Note.Text = "OK"
        txt_Remarks.Text = String.Empty
        dtp_PostingDate.Text = Now()
        txt_Status.Text = "Approved"
        txt_Refno.Text = "000-MIGRATED"
        txt_POno.Text = "000-MIGRATED"
        txt_Branch.Text = MainMenu.StatusLevel.Caption
        txt_Quantity.Text = "0"
        txt_Prev_Quantity.Text = "0"
        txt_CostWVAT.Text = "0"
        txt_CostWOVAT.Text = "0"
        txt_Checker.Text = "rdalucanog000"
        txt_Approver.Text = "rdsenolos"
        dtp_DateCheck.Text = Now()
        dtp_DateApproved.Text = Now()
        txt_CurrentApprover.Text = "Approved"
        txt_Source.Text = "OUTGOING"
        txt_SRP.Text = "0.00"
        txt_BinBox.Text = "0.00"
        txt_SubTotal.Text = "0.00"
        txt_TotalLess.Text = "0.00"
        txt_GrandTotal.Text = "0.00"
        txt_Discount.Text = "0.00"
        txt_TotalCostWOVAT.Text = "0.00"
        lv_Parts.Items.Clear()
    End Sub

    Sub Disabled_txt()
        txt_ID.Enabled = False
        txt_BranchCode.Enabled = False
        txt_PartsNumber.Enabled = False
        txt_PartsName.Enabled = False
        cmb_Brand.Enabled = False
        cmb_Category.Enabled = False
        txt_ModelCode.Enabled = False
        txt_ModelName.Enabled = False
        txt_Note.Enabled = False
        txt_Remarks.Enabled = False
        dtp_PostingDate.Text = Now()
        dtp_PostingDate.Enabled = False
        txt_Status.Enabled = False
        txt_Refno.Enabled = False
        txt_POno.Enabled = False
        txt_Branch.Enabled = False
        txt_Quantity.Enabled = False
        txt_Prev_Quantity.Enabled = False
        txt_CostWVAT.Enabled = False
        txt_CostWOVAT.Enabled = False
        txt_Checker.Enabled = False
        txt_Approver.Enabled = False
        dtp_DateCheck.Enabled = False
        dtp_DateApproved.Enabled = False
        txt_CurrentApprover.Enabled = False
        txt_Source.Enabled = False
        txt_SRP.Enabled = False
        txt_SubTotal.Enabled = False
        txt_TotalLess.Enabled = False
        txt_GrandTotal.Enabled = False
        txt_Discount.Enabled = False
        txt_TotalCostWOVAT.Enabled = False
        lv_Parts.Items.Clear()
    End Sub

    Private Sub btn_New1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New1.ItemClick
        Dim News As Integer = MessageBox.Show("Are you sure Clearing all the Fields?", Application.CompanyName, MessageBoxButtons.YesNo)
        If News = DialogResult.No Then
            MessageBox.Show("Thanks not clearing all the Fields?", Application.CompanyName)
        Else
            clear_Txt()
        End If
    End Sub
End Class