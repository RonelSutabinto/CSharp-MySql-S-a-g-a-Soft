Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_Inquiry_Refno
    private sub txt_Reference_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Reference.KeyDown
        If e.KeyCode = Keys.Enter Then
            mg_ShowItem_Details()
            mg_ShowItem_Master()
            lbl_ItemDetailsCount.Text = lvMaster.Items.Count
            lblItemMasterCount.Text = lvDetails.Items.Count
        End If
    End Sub

    private sub mg_ShowItem_Master()
        lvMaster.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@Paramrefno", txt_Reference.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowItem_Masters_Quick_find")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Dim li As ListViewItem = lvMaster.Items.Add(myDataReader.Item("BranchCode").ToString())
                li.SubItems.Add(myDataReader.Item("refno").ToString())
                li.SubItems.Add(myDataReader.Item("vendor").ToString())
                li.SubItems.Add(myDataReader.Item("transcode").ToString())
                li.SubItems.Add(myDataReader.Item("inventoryStatus").ToString())
                li.SubItems.Add(myDataReader.Item("dateReceived").ToString())
                li.SubItems.Add(myDataReader.Item("POno").ToString())
                li.SubItems.Add(myDataReader.Item("whcategory").ToString())
                li.SubItems.Add(myDataReader.Item("whCode").ToString())
                li.SubItems.Add(myDataReader.Item("transactedby").ToString())
                li.SubItems.Add(myDataReader.Item("transactiondate").ToString())
                li.SubItems.Add(myDataReader.Item("dateapproved").ToString())
                li.SubItems.Add(myDataReader.Item("totalUnitCost").ToString())
                li.SubItems.Add(myDataReader.Item("totalVATAmt").ToString())
                li.SubItems.Add(myDataReader.Item("GrandTotalUnitCost").ToString())
                li.SubItems.Add(myDataReader.Item("TotalUnitPrice").ToString())
                li.SubItems.Add(myDataReader.Item("itemcnt").ToString())
                li.SubItems.Add(myDataReader.Item("branchcode").ToString())
                li.SubItems.Add(myDataReader.Item("approver").ToString())
                li.SubItems.Add(myDataReader.Item("OriginatingBranch").ToString())
                li.SubItems.Add(myDataReader.Item("OriginatingMaker").ToString())
                li.SubItems.Add(myDataReader.Item("VendorCode").ToString())
                li.SubItems.Add(myDataReader.Item("SourceEvent").ToString())
                li.SubItems.Add(myDataReader.Item("remarks").ToString())
                li.SubItems.Add(myDataReader.Item("note").ToString())
            End If
        End Using
    End Sub

    private sub mg_ShowItem_Details()
        lvDetails.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamQuickSearch", txt_Reference.Text)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowItem_Details_Quick_find")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Dim li As ListViewItem = lvDetails.Items.Add(myDataReader.Item("id").ToString())
                li.SubItems.Add(myDataReader.Item("refno").ToString())
                li.SubItems.Add(myDataReader.Item("vendor").ToString())
                li.SubItems.Add(myDataReader.Item("transcode").ToString())
                li.SubItems.Add(myDataReader.Item("dateReceived").ToString())
                li.SubItems.Add(myDataReader.Item("POno").ToString())
                li.SubItems.Add(myDataReader.Item("whcategory").ToString())
                li.SubItems.Add(myDataReader.Item("whCode").ToString())
                li.SubItems.Add(myDataReader.Item("inventoryStatus").ToString())
                li.SubItems.Add(myDataReader.Item("IfExist").ToString())
                li.SubItems.Add(myDataReader.Item("Code").ToString())
                li.SubItems.Add(myDataReader.Item("model").ToString())
                li.SubItems.Add(myDataReader.Item("color").ToString())
                li.SubItems.Add(myDataReader.Item("description").ToString())
                li.SubItems.Add(myDataReader.Item("brand").ToString())
                li.SubItems.Add(myDataReader.Item("EngineNo").ToString())
                li.SubItems.Add(myDataReader.Item("ChassisNo").ToString())
                li.SubItems.Add(myDataReader.Item("keyno").ToString())
                li.SubItems.Add(myDataReader.Item("unitcost").ToString())
                li.SubItems.Add(myDataReader.Item("vatamt").ToString())
                li.SubItems.Add(myDataReader.Item("totalcost").ToString())
                li.SubItems.Add(myDataReader.Item("unitprice").ToString())
                li.SubItems.Add(myDataReader.Item("transactedby").ToString())
                li.SubItems.Add(myDataReader.Item("transactiondate").ToString())
                li.SubItems.Add(myDataReader.Item("branchcode").ToString())
                li.SubItems.Add(myDataReader.Item("note").ToString())
                li.SubItems.Add(myDataReader.Item("item_grp").ToString())
                li.SubItems.Add(myDataReader.Item("prevID").ToString())
                li.SubItems.Add(myDataReader.Item("temp").ToString())
                li.SubItems.Add(myDataReader.Item("Remarks").ToString())
            End If
        End Using
    End Sub

    private sub frmReference_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_ItemDetailsCount.Text = lvDetails.Items.Count
        lblItemMasterCount.Text = lvMaster.Items.Count
    End Sub
End Class