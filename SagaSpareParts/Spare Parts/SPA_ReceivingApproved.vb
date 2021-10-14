Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_ReceivingApproved
    Sub Show_SPA_Inventory()
        Dim Parameters As SqlParameter() = {New SqlParameter("@Paramrefno", txt_RefNo.EditValue)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_RefNo")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_Vendor.EditValue = myDataReader("Vendor").ToString()
                txt_RefNo.EditValue = myDataReader("Refno").ToString()
                txt_POno.EditValue = myDataReader("PONo").ToString()
                cmb_WhCategory.Text = myDataReader("whCategory").ToString()
                txt_WhCode.EditValue = myDataReader("whCode").ToString()
                txt_Note.EditValue = myDataReader("Note").ToString()
                txt_Status.EditValue = myDataReader("InventoryStatus").ToString()
                txt_Checker.EditValue = myDataReader("Checker").ToString()
                txt_Approver.EditValue = myDataReader("Approver").ToString()
                txt_Remarks.EditValue = myDataReader("Remarks").ToString()
                lbl_SubTotal.Text = myDataReader("TotalCostWOVAT").ToString()
                lbl_Less.Text = myDataReader("TotalLess").ToString()
                lbl_GrandTotal.Text = myDataReader("GrandTotal").ToString()
                txt_Discount.Text = myDataReader("TotalDiscountAMT").ToString()
                dtp_Date.EditValue = myDataReader("PostingDate").ToString()
            End If
        End Using
    End Sub

    Sub SearchSINo_ToBranch()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamRefNo", txt_RefNo.EditValue)}

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_Find_RefNoForReceivingApproved")
    End Sub

    Private Sub barPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles barPrint.ItemClick
        Dim report As New xRptReceivingApproved()
        ' Obtain a parameter and set its value.
        report.Parameters("BranchCode").Value = MainMenu.statusBrCode.Caption
        report.Parameters("BranchName").Value = MainMenu.StatusLevel.Caption
        report.Parameters("DateTrans").Value = dtp_Date.Text
        report.Parameters("PONo").Value = txt_POno.EditValue
        report.Parameters("SINo").Value = txt_RefNo.EditValue
        report.Parameters("Source").Value = txt_Source.EditValue
        report.Parameters("TotalCost").Value = lbl_SubTotal.Text
        report.Parameters("TotalVat").Value = lbl_Less.Text
        report.Parameters("TotalAmount").Value = lbl_GrandTotal.Text
        report.Parameters("TotalLess").Value = txt_Discount.Text
        report.Parameters("GrandTotal").Value = lbl_GrandTotal.Text - txt_Discount.Text
        report.Parameters("PreparedBy").Value = txt_PreparedName.EditValue
        report.Parameters("CheckedBy").Value = txt_CheckerName.EditValue
        report.Parameters("NotedBy").Value = txt_ApproverName.EditValue
        report.Parameters("Notes").Value = txt_Note.EditValue
        report.Parameters("Designation1").Value = txt_Designation1.EditValue
        report.Parameters("Designation2").Value = txt_Designation2.EditValue
        report.Parameters("Designation3").Value = txt_Designation3.EditValue
        ' Hide the Parameters' UI from end-users (if you did not hide it at design time).
        For Each param In report.Parameters
            param.Visible = False
        Next
        GridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GridControl
        report.ShowPreview
    End Sub

    Private Sub txt_RefNo_EditValueChanged(sender As Object, e As EventArgs) Handles txt_RefNo.EditValueChanged
        Show_SPA_Inventory()
        SearchSINo_ToBranch()
        SPA_ShowFullNamePrepared()
        SPA_ShowFullNameApprover()
        SPA_ShowFullNameChecker()
    End Sub

    Sub SPA_ShowFullNameChecker()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamUserName", txt_Checker.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_ShowFullName")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_CheckerName.EditValue = myDataReader("fullname").ToString
                txt_Designation2.EditValue = myDataReader("designation").ToString
            End If
        End Using
    End Sub

    Sub SPA_ShowFullNameApprover()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamUserName", txt_Approver.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_ShowFullName")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_ApproverName.EditValue = myDataReader("fullname").ToString
                txt_Designation3.EditValue = myDataReader("designation").ToString
            End If
        End Using
    End Sub

    Sub SPA_ShowFullNamePrepared()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamUserName", MainMenu.App_User_Name.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_ShowFullName")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_PreparedName.EditValue = myDataReader("fullname").ToString
                txt_Designation1.EditValue = myDataReader("designation").ToString
            End If
        End Using
    End Sub
End Class