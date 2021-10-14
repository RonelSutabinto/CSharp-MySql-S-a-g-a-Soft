Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inquiry_Refno
    Private Sub txt_Reference_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Reference.KeyDown
        If e.KeyCode = Keys.Enter Then
            mg_ShowItem_Details()
            mg_ShowItem_Master()
            lbl_ItemDetailsCount.Text = lvMaster.Items.Count
            lblItemMasterCount.Text = lvDetails.Items.Count
        End If
    End Sub

    Sub mg_ShowItem_Master()
        lvMaster.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@Paramrefno", txt_Reference.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowItem_Masters_Quick_find")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Dim li As ListViewItem = lvMaster.Items.Add(myDataReader.Item("BranchCode").ToString())
                li.SubItems.Add(mydatareader.Item("refno").ToString())
                li.SubItems.Add(mydatareader.Item("vendor").ToString())
                li.SubItems.Add(mydatareader.Item("transcode").ToString())
                li.SubItems.Add(mydatareader.Item("inventoryStatus").ToString())
                li.SubItems.Add(mydatareader.Item("dateReceived").ToString())
                li.SubItems.Add(mydatareader.Item("POno").ToString())
                li.SubItems.Add(mydatareader.Item("whcategory").ToString())
                li.SubItems.Add(mydatareader.Item("whCode").ToString())
                li.SubItems.Add(mydatareader.Item("transactedby").ToString())
                li.SubItems.Add(mydatareader.Item("transactiondate").ToString())
                li.SubItems.Add(mydatareader.Item("dateapproved").ToString())
                li.SubItems.Add(mydatareader.Item("totalUnitCost").ToString())
                li.SubItems.Add(mydatareader.Item("totalVATAmt").ToString())
                li.SubItems.Add(mydatareader.Item("GrandTotalUnitCost").ToString())
                li.SubItems.Add(mydatareader.Item("TotalUnitPrice").ToString())
                li.SubItems.Add(mydatareader.Item("itemcnt").ToString())
                li.SubItems.Add(mydatareader.Item("branchcode").ToString())
                li.SubItems.Add(mydatareader.Item("approver").ToString())
                li.SubItems.Add(mydatareader.Item("OriginatingBranch").ToString())
                li.SubItems.Add(mydatareader.Item("OriginatingMaker").ToString())
                li.SubItems.Add(mydatareader.Item("VendorCode").ToString())
                li.SubItems.Add(mydatareader.Item("SourceEvent").ToString())
                li.SubItems.Add(mydatareader.Item("remarks").ToString())
                li.SubItems.Add(mydatareader.Item("note").ToString())
            End If
        End Using
    End Sub

    Sub mg_ShowItem_Details()
        lvDetails.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamQuickSearch", txt_Reference.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowItem_Details_Quick_find")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Dim li As ListViewItem = lvDetails.Items.Add(myDataReader.Item("id").ToString())
                li.SubItems.Add(mydatareader.Item("refno").ToString())
                li.SubItems.Add(mydatareader.Item("vendor").ToString())
                li.SubItems.Add(mydatareader.Item("transcode").ToString())
                li.SubItems.Add(mydatareader.Item("dateReceived").ToString())
                li.SubItems.Add(mydatareader.Item("POno").ToString())
                li.SubItems.Add(mydatareader.Item("whcategory").ToString())
                li.SubItems.Add(mydatareader.Item("whCode").ToString())
                li.SubItems.Add(mydatareader.Item("inventoryStatus").ToString())
                li.SubItems.Add(mydatareader.Item("IfExist").ToString())
                li.SubItems.Add(mydatareader.Item("Code").ToString())
                li.SubItems.Add(mydatareader.Item("model").ToString())
                li.SubItems.Add(mydatareader.Item("color").ToString())
                li.SubItems.Add(mydatareader.Item("description").ToString())
                li.SubItems.Add(mydatareader.Item("brand").ToString())
                li.SubItems.Add(mydatareader.Item("engineno").ToString())
                li.SubItems.Add(mydatareader.Item("chassisno").ToString())
                li.SubItems.Add(mydatareader.Item("keyno").ToString())
                li.SubItems.Add(mydatareader.Item("unitcost").ToString())
                li.SubItems.Add(mydatareader.Item("vatamt").ToString())
                li.SubItems.Add(mydatareader.Item("totalcost").ToString())
                li.SubItems.Add(mydatareader.Item("unitprice").ToString())
                li.SubItems.Add(mydatareader.Item("transactedby").ToString())
                li.SubItems.Add(mydatareader.Item("transactiondate").ToString())
                li.SubItems.Add(mydatareader.Item("branchcode").ToString())
                li.SubItems.Add(mydatareader.Item("note").ToString())
                li.SubItems.Add(mydatareader.Item("item_grp").ToString())
                li.SubItems.Add(mydatareader.Item("prevID").ToString())
                li.SubItems.Add(mydatareader.Item("temp").ToString())
                li.SubItems.Add(mydatareader.Item("Remarks").ToString())
            End If
        End Using
    End Sub

    Private Sub frmReference_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_ItemDetailsCount.Text = lvDetails.Items.Count
        lblItemMasterCount.Text = lvMaster.Items.Count
    End Sub
End Class