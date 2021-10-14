Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Checker_Approver_Receiving

    Sub Show_SPA_Inventory()
        lvParts.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@Paramrefno", txt_RefNo.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_RefNo")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lvParts.Items.Add(myDataReader.Item("PartsNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("PartsName").ToString())
                    li.SubItems.Add(myDataReader.Item("Brand").ToString())
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
                    li.SubItems.Add(myDataReader.Item("Transactedby").ToString())
                    li.SubItems.Add(myDataReader.Item("ID").ToString())
                    li.SubItems.Add(myDataReader.Item("Category").ToString())
                    li.SubItems.Add(myDataReader.Item("BinBox").ToString())
                Loop
            End If

            txt_Vendor.Text = myDataReader("Vendor").ToString()
            txt_RefNo.Text = myDataReader("Refno").ToString()
            txt_POno.Text = myDataReader("PONo").ToString()
            cmb_WhCategory.Text = myDataReader("whCategory").ToString()
            txt_WhCode.Text = myDataReader("whCode").ToString()
            txt_Note.Text = myDataReader("Note").ToString()
            txt_Status.Text = myDataReader("InventoryStatus").ToString()
            txt_Checker.Text = myDataReader("Checker").ToString()
            txt_Approver.Text = myDataReader("Approver").ToString()
            txt_Remarks.Text = myDataReader("Remarks").ToString()
            txt_Source.Text = myDataReader("SourceEvent").ToString()
            txt_BrCode.Text = myDataReader("ReceivingBranch").ToString()
            lbl_SubTotal.Text = myDataReader("TotalCostWOVAT").ToString()
            lbl_Less.Text = myDataReader("TotalLess").ToString()
            lbl_GrandTotal.Text = myDataReader("GrandTotal").ToString()
            lbl_Discount.Text = myDataReader("TotalDiscountAMT").ToString()
        End Using
    End Sub

    Sub clearForm()
        txt_RefNo.Text = String.Empty
        txt_Vendor.Text = String.Empty
        txt_POno.Text = String.Empty
        cmb_WhCategory.Text = String.Empty
        txt_WhCode.Text = String.Empty
        txt_Note.Text = String.Empty
        txt_Approver.Text = String.Empty
        txt_Checker.Text = String.Empty
        txt_Checker.Text = String.Empty
        lvParts.Items.Clear()
    End Sub

    Sub SPA_Inventory_Check_ReceivingSpareParts()
        For x = 0 To lvParts.Items.Count - 1
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Paramrefno", txt_RefNo.Text),
                New SqlParameter("@ParamRemarks", txt_Remarks.Text),
                New SqlParameter("@ParamCurrentApprover", txt_Approver.Text),
                New SqlParameter("@ParamInventoryStatus", txt_Status.Text),
                New SqlParameter("@ParamSourceEvent", txt_Source.Text),
                New SqlParameter("@ParamReceivingBranch", MainMenu.statusBrCode.Caption),
                New SqlParameter("@ParamQuantity", lvParts.Items(x).SubItems(10).Text),
                New SqlParameter("@Paramprev_ID", lvParts.Items(x).SubItems(14).Text)
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Inventory_Check_ReceivingSpareParts")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    'MsgBox(mydatareader.Item("Message").ToString())
                End If
            End Using
        Next

        If txt_Approver.Text = MainMenu.App_User_Name.Caption Then
            MsgBox("Spare Parts Approved.", vbInformation)
        ElseIf txt_Checker.Text = MainMenu.App_User_Name.Caption Then
            MsgBox("Spare Parts Send! Please inform your Approver.", vbInformation)
        End If
    End Sub

    Sub SPA_Inventory_DisApproved_ReceivingSpareParts()
        For x = 0 To lvParts.Items.Count - 1
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Paramrefno", txt_RefNo.Text),
                New SqlParameter("@ParamRemarks", txt_Remarks.Text),
                New SqlParameter("@ParamTransactedby", lvParts.Items(x).SubItems(13).Text)
            }

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Inventory_DisApproved_ReceivingSpareParts")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    'MsgBox(mydatareader.Item("Message").ToString())
                End If
            End Using
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
End Class