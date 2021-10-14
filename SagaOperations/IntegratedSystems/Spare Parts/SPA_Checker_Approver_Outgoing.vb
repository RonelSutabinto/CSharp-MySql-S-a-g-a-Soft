Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Checker_Approver_Outgoing
    Sub Show_SPA_Inventory()
        lvParts.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@Paramrefno", txt_RefNo.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_RefNo")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lvParts.Items.Add(myDataReader.Item("PartsNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsName").ToString())
                    li.SubItems.Add(myDataReader.Item("Brand").ToString())
                    li.SubItems.Add(myDataReader.Item("SC_SpareParts").ToString())
                    li.SubItems.Add(myDataReader.Item("SRP").ToString())
                    li.SubItems.Add(myDataReader.Item("Quantity").ToString())
                    li.SubItems.Add(myDataReader.Item("SPCostWOVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("SPCostWVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("DiscountPCT").ToString())
                    li.SubItems.Add(myDataReader.Item("DiscountAMT").ToString())
                    li.SubItems.Add(myDataReader.Item("PriceWVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("priceWOVAT").ToString())
                    li.SubItems.Add(myDataReader.Item("ModelCode").ToString())
                    li.SubItems.Add(myDataReader.Item("ModelName").ToString())
                    li.SubItems.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("prev_ID").ToString())
                    li.SubItems.Add(myDataReader.Item("Transactedby").ToString())
                    li.SubItems.Add(myDataReader.Item("subTotal").ToString())
                    li.SubItems.Add(myDataReader.Item("Category").ToString())
                    li.SubItems.Add(myDataReader.Item("BinBox").ToString())
                Loop

                txt_RBranch.Text = myDataReader("Vendor").ToString()
                txt_RefNo.Text = myDataReader("Refno").ToString()
                txt_PONo.Text = myDataReader("PONo").ToString()
                cmb_WHCategory.Text = myDataReader("whCategory").ToString()
                txt_WHCode.Text = myDataReader("whCode").ToString()
                txt_Note.Text = myDataReader("Note").ToString()
                txt_Status.Text = myDataReader("InventoryStatus").ToString()
                txt_Partsman.Text = myDataReader("Checker").ToString()
                txt_Approver.Text = myDataReader("Approver").ToString()
                txt_Remarks.Text = myDataReader("Remarks").ToString()
                txt_Source.Text = myDataReader("SourceEvent").ToString()
                txt_BrCode.Text = myDataReader("ReceivingBranch").ToString()
                lbl_SubTotal.Text = myDataReader("TotalCostWOVAT").ToString()
                lbl_Less.Text = myDataReader("TotalLess").ToString()
                lbl_GrandTotal.Text = myDataReader("GrandTotal").ToString()
            End If
        End Using
    End Sub

    Sub clearForm()
        txt_RefNo.Text = String.Empty
        txt_RBranch.Text = String.Empty
        txt_PONo.Text = String.Empty
        cmb_WHCategory.Text = String.Empty
        txt_WHCode.Text = String.Empty
        txt_Note.Text = String.Empty
        txt_Approver.Text = String.Empty
        txt_Partsman.Text = String.Empty
        txt_Approver.Text = String.Empty
        lvParts.Items.Clear()
    End Sub

    Sub SPA_Inventory_Check_ReceivingSpareParts()
        For x = 0 To lvParts.Items.Count - 1
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Paramrefno", txt_RefNo.Text),
                New SqlParameter("@ParamRemarks", txt_Remarks.Text),
                New SqlParameter("@ParamCurrentApprover", txt_Partsman.Text),
                New SqlParameter("@ParamInventoryStatus", txt_Status.Text),
                New SqlParameter("@ParamSourceEvent", txt_Source.Text),
                New SqlParameter("@ParamReceivingBranch", MainMenu.statusBrCode.Caption),
                New SqlParameter("@ParamQuantity", lvParts.Items(x).SubItems(5).Text),
                New SqlParameter("@Paramprev_ID", lvParts.Items(x).SubItems(15).Text)
            }

            class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "SPA_Inventory_Check_ReceivingSpareParts", "SPA Receiving")
        Next

        If txt_Approver.Text = MainMenu.App_User_Name.Caption Then
            MsgBox("Spare Parts Send! Please inform your Partsman.", vbInformation)
        ElseIf txt_Partsman.Text = MainMenu.App_User_Name.Caption Then
            MsgBox("Spare Parts Approved.", vbInformation)
        End If
    End Sub

    Sub SPA_Inventory_DisApproved_ReceivingSpareParts()
        For x = 0 To lvParts.Items.Count - 1
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Paramrefno", txt_RefNo.Text),
                New SqlParameter("@ParamRemarks", txt_Remarks.Text),
                New SqlParameter("@ParamTransactedby", lvParts.Items(x).SubItems(16).Text)
            }

            class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "SPA_Inventory_DisApproved_ReceivingSpareParts", "SPA Disapprove receiving")
        Next
        MsgBox("Transaction Disapproved! Sent for MAKER. Please inform your Maker.", vbInformation)
    End Sub

    Private Sub btn_Approved_Click(sender As Object, e As EventArgs) Handles btn_Approved.Click
        SPA_Inventory_Check_ReceivingSpareParts()
        clearForm()
        Me.Hide()
    End Sub

    Private Sub Btn_DisApproved_Click(sender As Object, e As EventArgs) Handles Btn_DisApproved.Click
        SPA_Inventory_DisApproved_ReceivingSpareParts()
        clearForm()
        Me.Hide()
    End Sub

    Private Sub txt_RefNo_TextChanged(sender As Object, e As EventArgs) Handles txt_RefNo.TextChanged
        Show_SPA_Inventory()
    End Sub

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        Dim report As New xRptTransmittal_Outgoing()
        ' Obtain a parameter and set its value.
        report.Parameters("DateTrans").Value = MainMenu.dateStatus.Caption
        report.Parameters("PONo").Value = txt_PONo.Text
        report.Parameters("SINo").Value = txt_RefNo.Text
        report.Parameters("BranchTo").Value = txt_BrCode.Text
        report.Parameters("BranchFrom").Value = MainMenu.statusBrCode.Caption
        ' Hide the Parameters' UI from end-users (if you did not hide it at design time).
        For Each param In report.Parameters
            param.Visible = False
        Next

        For i = 0 To lvParts.Items.Count - 1
            'GridControl.ShowRibbonPrintPreview()
            'Create a report instance.
            report.Parameters("CostWoVAT").Value = lvParts.Items(i).SubItems(13).Text
            report.Parameters("Quantity").Value = lvParts.Items(i).SubItems(11).Text
            report.Parameters("Description").Value = lvParts.Items(i).SubItems(1).Text
            report.Parameters("PartNumber").Value = lvParts.Items(i).SubItems(0).Text
            report.Parameters("SubTotal").Value = lvParts.Items(i).SubItems(13).Text

        Next i

        ' Show the report's print preview depending on your target platform.
        report.ShowPreview
    End Sub

    Private Sub SPA_Checker_Approver_Outgoing_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class