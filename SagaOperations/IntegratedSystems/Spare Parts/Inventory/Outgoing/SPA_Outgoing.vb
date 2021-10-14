Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Outgoing
    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click
        Search_SPA_fromWH.ShowDialog()
    End Sub

    Private Sub lvParts_DoubleClick(sender As Object, e As EventArgs) Handles lvParts.DoubleClick
        lvParts.Items.RemoveAt(lvParts.SelectedIndices(0))
        TotalParts()
    End Sub

    Sub clearForm()
        txt_RefNo.Text = String.Empty
        txt_BrCode.Text = String.Empty
        txt_RBranch.Text = String.Empty
        txt_PONo.Text = String.Empty
        cmb_WHCategory.Text = String.Empty
        txt_WHCode.Text = String.Empty
        txt_Note.Text = String.Empty
        txt_Approver.Text = String.Empty
        cmb_Partsman.Text = String.Empty
        txt_Status.Text = "For Transport"
        lvParts.Items.Clear()
    End Sub

    Sub SPA_Inventory_OutgoingSpareParts()
        For x = 0 To lvParts.Items.Count - 1
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Paramrefno", txt_RefNo.Text),
                New SqlParameter("@Paramvendor", txt_RBranch.Text),
                New SqlParameter("@ParamPostingDate", Format(dtp_Date.Value, "MM/dd/yyyy")),
                New SqlParameter("@ParamPOno", txt_PONo.Text),
                New SqlParameter("@Paramwhcategory", cmb_WHCategory.Text),
                New SqlParameter("@Paramwhcode", txt_WHCode.Text),
                New SqlParameter("@ParamNote", txt_Note.Text),
                New SqlParameter("@ParamApprover", txt_Approver.Text),
                New SqlParameter("@ParamChecker", cmb_Partsman.Text),
                New SqlParameter("@ParamCurrentApprover", txt_Approver.Text),
                New SqlParameter("@ParamPartsNumber", lvParts.Items(x).SubItems(0).Text),
                New SqlParameter("@ParamPartsName", lvParts.Items(x).SubItems(1).Text),
                New SqlParameter("@ParamBrand", lvParts.Items(x).SubItems(2).Text),
                New SqlParameter("@ParamSC_SpareParts", lvParts.Items(x).SubItems(3).Text),
                New SqlParameter("@ParamSRP", lvParts.Items(x).SubItems(4).Text),
                New SqlParameter("@ParamQuantity", lvParts.Items(x).SubItems(5).Text),
                New SqlParameter("@ParamSPCostWOVAT", lvParts.Items(x).SubItems(6).Text),
                New SqlParameter("@ParamSPCostWVAT", lvParts.Items(x).SubItems(7).Text),
                New SqlParameter("@ParamDiscountPCT", lvParts.Items(x).SubItems(8).Text),
                New SqlParameter("@ParamDiscountAMT", lvParts.Items(x).SubItems(9).Text),
                New SqlParameter("@ParamPriceWVAT", lvParts.Items(x).SubItems(10).Text),
                New SqlParameter("@ParamPriceWOVAT", lvParts.Items(x).SubItems(11).Text),
                New SqlParameter("@ParamModelCode", lvParts.Items(x).SubItems(12).Text),
                New SqlParameter("@ParamModelName", lvParts.Items(x).SubItems(13).Text),
                New SqlParameter("@Paramprev_ID", lvParts.Items(x).SubItems(16).Text),
                New SqlParameter("@ParamSubTotal", lvParts.Items(x).SubItems(17).Text),
                New SqlParameter("@ParamCategory", lvParts.Items(x).SubItems(18).Text),
                New SqlParameter("@ParamBinBox", lvParts.Items(x).SubItems(19).Text),
                New SqlParameter("@ParamSourceEvent", txt_Source.Text),
                New SqlParameter("@ParamReceivingBranch", txt_BrCode.Text),
                New SqlParameter("@Parambranchcode", MainMenu.statusBrCode.Caption),
                New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption),
                New SqlParameter("@ParamTotalLess", lbl_Less.Text),
                New SqlParameter("@ParamGrandTotal", lbl_GrandTotal.Text),
                New SqlParameter("@ParamTotalCostWOVAT", lbl_SubTotal.Text),
                New SqlParameter("@ParamCode", txt_Code.Text)
            }

            class_Database.Procedure_Retrieve(class_Database.spaSQLConnection, Parameters, "SPA_Inventory_OutgoingSpareParts", "SPA Outgoing Inventory")
        Next

        If txt_error.Text = "0" Then
            MsgBox("Spare Parts Send! Please inform. ", vbInformation, Application.CompanyName)
        ElseIf txt_error.Text = "1" Then
            MsgBox("Duplicate Reference No. Found!", vbInformation, Application.CompanyName)
        End If
    End Sub

    Sub Load_FromMakers()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamUsername", MainMenu.App_User_Name.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.spaSQLConnection, Parameters, "SPA_Load_FromMakers")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_Approver.Text = myDataReader("Checker").ToString()
            End If
        End Using
    End Sub

    Sub Load_Refno()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.spaSQLConnection, Parameters, "SPA_OutgoingRefNo")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_RefNo.Text = myDataReader("Refno").ToString()
                txt_Code.Text = myDataReader("Code").ToString()
            End If
        End Using
    End Sub

    Sub SPA_ShowPartsman()
        cmb_Partsman.Properties.Items.Clear()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", txt_BrCode.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.spaSQLConnection, Parameters, "SPA_ShowPartsman")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_Partsman.Properties.Items.Add(myDataReader.Item("username").ToString)
                Loop
            End If
        End Using
    End Sub

    Private Sub cmb_WhCategory_TextChanged(sender As Object, e As EventArgs) Handles cmb_WHCategory.TextChanged
        If cmb_WHCategory.Text = "BRAND NEW" Then
            txt_WHCode.Text = "NEW"
        ElseIf cmb_WHCategory.Text = "OLD" Then
            txt_WHCode.Text = "OLD"
        End If
    End Sub

    Private Sub btn_Send_Click(sender As Object, e As EventArgs) Handles btn_Send.Click
        If txt_RefNo.Text = String.Empty Or txt_RBranch.Text = String.Empty Or txt_BrCode.Text = String.Empty Or txt_PONo.Text = String.Empty Or txt_PONo.Text = String.Empty Or cmb_WHCategory.Text = String.Empty Or
            cmb_WHCategory.Text = String.Empty Or txt_WHCode.Text = String.Empty Or txt_Approver.Text = String.Empty Or cmb_Partsman.Text = String.Empty Then
            MsgBox("Some fields are empty, please fill up them.", vbCritical)
        ElseIf txt_RefNo.Text = "ALREADY EXISTS!" Then
            MsgBox("PONo/Refno ALREADY EXISTS, Please check your PO Number/ Ref. Number", vbCritical)
        Else
            SPA_Inventory_OutgoingSpareParts()
            clearForm()
            Me.Close()
        End If
    End Sub

    Private Sub btn_Branch_Click(sender As Object, e As EventArgs) Handles btn_Branch.Click
        If Spare_Parts_Vendor.txt_Search.Text = String.Empty Then
            Spare_Parts_Vendor.Show_Branch()
            Spare_Parts_Vendor.lv_Branch.BringToFront()
        End If
        Spare_Parts_Vendor.ShowDialog()
    End Sub

    Private Sub txt_BrCode_TextChanged(sender As Object, e As EventArgs) Handles txt_BrCode.TextChanged
        If txt_Status.Text = "For Transport" Then
            SPA_ShowPartsman()
        End If
    End Sub

    Sub TotalParts()
        Dim TotalSum As Double = 0
        Dim Sum As ListViewItem

        For Each Sum In lvParts.Items
            TotalSum += CDbl(Sum.SubItems.Item(17).Text)
        Next
        lbl_GrandTotal.Text = TotalSum
    End Sub

    Private Sub lbl_GrandTotal_TextChanged(sender As Object, e As EventArgs) Handles lbl_GrandTotal.TextChanged
        lbl_SubTotal.Text = lbl_GrandTotal.Text ' Math.Round(lbl_TotalLess.Text / 1.12, 2)
        lbl_Less.Text = "0" 'Math.Round(lbl_GrandTotal.Text - lbl_SubTotal.Text, 2)
    End Sub

    Private Sub SPA_Outgoing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_FromMakers()
        Load_Refno()
    End Sub

    Private Sub txt_RefNo_TextChanged(sender As Object, e As EventArgs) Handles txt_RefNo.TextChanged
        txt_PONo.Text = txt_RefNo.Text
        If txt_Status.Text = "Disapproved" Then
            txt_PONo.Text = txt_RefNo.Text
        End If
    End Sub

End Class