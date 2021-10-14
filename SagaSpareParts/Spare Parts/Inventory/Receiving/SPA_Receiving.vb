Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Receiving

    Private Sub btn_Add_SPA_Click(sender As Object, e As EventArgs) Handles btn_Add_SPA.Click
        Search_Spare_Parts_PO.Show()
    End Sub

    Private Sub btn_Vendor_Click(sender As Object, e As EventArgs) Handles btn_Vendor.Click
        If Spare_Parts_Vendor.txt_Search.Text = String.Empty Then
            Spare_Parts_Vendor.Show_Vendor()
            Spare_Parts_Vendor.lv_Vendor.BringToFront()
            Spare_Parts_Vendor.Show_Vendor()
        End If
        Spare_Parts_Vendor.ShowDialog()
        Load_POno()
    End Sub

    Private Sub lvParts_DoubleClick(sender As Object, e As EventArgs) Handles lvParts.DoubleClick
        lvParts.Items.RemoveAt(lvParts.SelectedIndices(0))
        TotalParts()
    End Sub

    Private Sub btn_Send_Click(sender As Object, e As EventArgs) Handles btn_Send.Click
        If txt_RefNo.Text = String.Empty Or txt_Vendor.Text = String.Empty Or txt_POno.Text = String.Empty Or txt_POno.Text = String.Empty Or cmb_WhCategory.Text = String.Empty Or
            cmb_WhCategory.Text = String.Empty Or txt_WhCode.Text = String.Empty Or txt_Note.Text = String.Empty Or txt_Approver.Text = String.Empty Or txt_Checker.Text = String.Empty Then
            MsgBox("Some fields are empty, please fill up them.", vbCritical)
            Return
        ElseIf txt_POno.Text = "ALREADY EXISTS!" Then
            MsgBox("PONo/Refno ALREADY EXISTS, Please check your PO Number/ Ref. Number", vbCritical)
        Else
            SPA_Inventory_ReceivingSpareParts()
            clearForm()
            Me.Close()
            txt_RefNo.Focus()
        End If
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

    Sub Load_FromMakers()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamUsername", MainMenu.App_User_Name.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.spaSQLConnection, Parameters, "SPA_Load_FromMakers")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_Approver.Text = myDataReader("Approver").ToString()
                txt_Checker.Text = myDataReader("Checker").ToString()
            End If
        End Using
    End Sub

    Sub SPA_Inventory_ReceivingSpareParts()
        For x = 0 To lvParts.Items.Count - 1
            Dim Parameters As SqlParameter() = {
                New SqlParameter("@Paramrefno", txt_RefNo.Text),
                New SqlParameter("@Paramvendor", txt_Vendor.Text),
                New SqlParameter("@ParamPostingDate", Format(dtp_Date.Value, "MM/dd/yyyy")),
                New SqlParameter("@ParamPOno", txt_POno.Text),
                New SqlParameter("@Paramwhcategory", cmb_WhCategory.Text),
                New SqlParameter("@Paramwhcode", txt_WhCode.Text),
                New SqlParameter("@ParamNote", txt_Note.Text),
                New SqlParameter("@ParamApprover", txt_Approver.Text),
                New SqlParameter("@ParamChecker", txt_Checker.Text),
                New SqlParameter("@ParamCurrentApprover", txt_Checker.Text),
                New SqlParameter("@ParamSourceEvent", txt_Source.Text),
                New SqlParameter("@ParamPartsNumber", lvParts.Items(x).SubItems(0).Text),
                New SqlParameter("@ParamPartsName", lvParts.Items(x).SubItems(1).Text),
                New SqlParameter("@ParamBrand", lvParts.Items(x).SubItems(2).Text),
                New SqlParameter("@ParamSC_SpareParts", lvParts.Items(x).SubItems(3).Text),
                New SqlParameter("@ParamSRP", lvParts.Items(x).SubItems(4).Text),
                New SqlParameter("@ParamQuantity", lvParts.Items(x).SubItems(5).Text),
                New SqlParameter("@ParamSPCostWVAT", lvParts.Items(x).SubItems(6).Text),
                New SqlParameter("@ParamSPCostWOVAT", lvParts.Items(x).SubItems(7).Text),
                New SqlParameter("@ParamDiscountPCT", lvParts.Items(x).SubItems(8).Text),
                New SqlParameter("@ParamDiscountAMT", lvParts.Items(x).SubItems(9).Text),
                New SqlParameter("@ParamPriceWVAT", lvParts.Items(x).SubItems(10).Text),
                New SqlParameter("@ParamPriceWOVAT", lvParts.Items(x).SubItems(11).Text),
                New SqlParameter("@ParamModelCode", lvParts.Items(x).SubItems(12).Text),
                New SqlParameter("@ParamModelName", lvParts.Items(x).SubItems(13).Text),
                New SqlParameter("@ParamSubTotal", lvParts.Items(x).SubItems(14).Text),
                New SqlParameter("@ParamCategory", lvParts.Items(x).SubItems(15).Text),
                New SqlParameter("@ParamBinBox", lvParts.Items(x).SubItems(16).Text),
                New SqlParameter("@Parambranchcode", MainMenu.statusBrCode.Caption),
                New SqlParameter("@ParamReceivingBranch", MainMenu.statusBrCode.Caption),
                New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption),
                New SqlParameter("@ParamTotalLess", lbl_Less.Text),
                New SqlParameter("@ParamGrandTotal", lbl_GrandTotal.Text),
                New SqlParameter("@ParamTotalCostWOVAT", lbl_SubTotal.Text),
                New SqlParameter("@ParamTotalDiscountAMT", lbl_Discount.Text)
            }

            class_Database.Procedure_Retrieve(class_Database.spaSQLConnection, Parameters, "SPA_Inventory_ReceivingSpareParts", "SPA Receiving")
        Next
        MsgBox("Spare Parts Send! Please inform your Checker.", vbInformation, Application.CompanyName)
    End Sub

    Private Sub cmb_WhCategory_TextChanged(sender As Object, e As EventArgs) Handles cmb_WhCategory.TextChanged
        If cmb_WhCategory.Text = "BRAND NEW" Then
            txt_WhCode.Text = "NEW"
        ElseIf cmb_WhCategory.Text = "OLD" Then
            txt_WhCode.Text = "OLD"
        End If
    End Sub

    Private Sub Spare_Parts_PO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_FromMakers()
    End Sub

    Sub LV_PARTS_Total()
        Dim TotalSum As Double = 0
        Dim Sum As ListViewItem

        For Each Sum In lvParts.Items
            TotalSum += CDbl(Sum.SubItems.Item(9).Text)
        Next
        lbl_Discount.Text = TotalSum
    End Sub

    Sub TotalParts()
        Dim TotalSum As Double = 0
        Dim Sum As ListViewItem

        For Each Sum In lvParts.Items
            TotalSum += CDbl(Sum.SubItems.Item(14).Text)
        Next
        lbl_GrandTotal.Text = TotalSum
    End Sub

    Private Sub lbl_GrandTotal_TextChanged(sender As Object, e As EventArgs) Handles lbl_GrandTotal.TextChanged
        If txt_Vendor.Text = "KAWASAKI MOTORS PHIL." Then
            lbl_TotalLess.Text = lbl_GrandTotal.Text
            lbl_Less.Text = Math.Round(lbl_GrandTotal.Text - lbl_SubTotal.Text, 2)
            lbl_VATLess.Text = "1.12"
        ElseIf txt_Vendor.Text = "HONDA PHILIPPINES" Then
            lbl_TotalLess.Text = lbl_GrandTotal.Text
            lbl_Less.Text = Math.Round(lbl_GrandTotal.Text - lbl_SubTotal.Text, 2)
            lbl_VATLess.Text = "1.12"
        ElseIf txt_Vendor.Text = "SUZUKI PHILIPPINES" Then
            lbl_TotalLess.Text = lbl_GrandTotal.Text
            lbl_Less.Text = Math.Round(lbl_GrandTotal.Text - lbl_SubTotal.Text, 2)
            lbl_VATLess.Text = "1.12"
        ElseIf txt_Vendor.Text = "YAMAHA MOTORS INC." Then
            lbl_TotalLess.Text = lbl_GrandTotal.Text
            lbl_Less.Text = Math.Round(lbl_GrandTotal.Text - lbl_SubTotal.Text, 2)
            lbl_VATLess.Text = "1.12"
        Else
            lbl_SubTotal.Text = lbl_GrandTotal.Text
            lbl_TotalLess.Text = "0"
            lbl_VATLess.Text = "1.12"
        End If
    End Sub

    Private Sub lbl_TotalLess_TextChanged(sender As Object, e As EventArgs) Handles lbl_TotalLess.TextChanged
        If txt_Vendor.Text = "KAWASAKI MOTORS PHIL." Then
            lbl_SubTotal.Text = Math.Round(lbl_TotalLess.Text / 1.12, 2)
        ElseIf txt_Vendor.Text = "HONDA PHILIPPINES" Then
            lbl_SubTotal.Text = Math.Round(lbl_TotalLess.Text / 1.12, 2)
        ElseIf txt_Vendor.Text = "SUZUKI PHILIPPINES" Then
            lbl_SubTotal.Text = Math.Round(lbl_TotalLess.Text / 1.12, 2)
        ElseIf txt_Vendor.Text = "YAMAHA MOTORS INC." Then
            lbl_SubTotal.Text = Math.Round(lbl_TotalLess.Text / 1.12, 2)
        Else
            lbl_SubTotal.Text = lbl_GrandTotal.Text
        End If
    End Sub

    Sub Searching_For_Duplication_RefNo()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamRefNo", txt_RefNo.Text),
            New SqlParameter("@ParambranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_RefNo_avoid_Dup")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_RefNo.Text = "ALREADY EXISTS!"
            End If
        End Using
        end using
    End Sub

    Sub Searching_For_Duplication_PONo()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamPONo", txt_POno.Text),
            New SqlParameter("@ParambranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_PONo_avoid_Dup")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_POno.Text = "ALREADY EXISTS!"
            End If
        End Using
    End Sub

    Private Sub txt_RefNo_TextChanged(sender As Object, e As EventArgs) Handles txt_RefNo.TextChanged
        Searching_For_Duplication_RefNo()
    End Sub

    Private Sub txt_POno_TextChanged(sender As Object, e As EventArgs) Handles txt_POno.TextChanged
        Searching_For_Duplication_PONo()
    End Sub

    Sub Load_POno()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamVendor", txt_Vendor.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "SPA_ReceivingPONo")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_POno.Text = myDataReader("Refno").ToString()
            End If
        End Using
    End Sub

    Private Sub txt_Vendor_TextChanged(sender As Object, e As EventArgs) Handles txt_Vendor.TextChanged
        Load_POno()
    End Sub

End Class