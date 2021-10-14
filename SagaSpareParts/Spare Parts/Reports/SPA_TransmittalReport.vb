Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class SPA_TransmittalReport
    Sub Show_SPA_Inventory()
        Dim Parameters As SqlParameter() = {New SqlParameter("@Paramrefno", txt_SINo.EditValue)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_RefNo")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_Vendor.EditValue = myDataReader("Vendor").ToString()
                txt_SINo.EditValue = myDataReader("Refno").ToString()
                txt_PONo.EditValue = myDataReader("PONo").ToString()
                cmb_whCategory.EditValue = myDataReader("whCategory").ToString()
                txt_whCode.EditValue = myDataReader("whCode").ToString()
                txt_Note.EditValue = myDataReader("Note").ToString()
                cmb_Status.EditValue = myDataReader("InventoryStatus").ToString()
                txt_Partsman.EditValue = myDataReader("Checker").ToString()
                txt_Approver.EditValue = myDataReader("Approver").ToString()
                txt_Remarks.EditValue = myDataReader("Remarks").ToString()
                txt_BrCode.EditValue = myDataReader("ReceivingBranch").ToString()
                dtp_Date.EditValue = myDataReader("postingDate").ToString()
                lbl_SubTotal.Text = myDataReader("TotalCostWOVAT").ToString()
                lbl_Less.Text = myDataReader("TotalLess").ToString()
                lbl_GrandTotal.Text = myDataReader("GrandTotal").ToString()
            End If
        End Using
    End Sub

    Sub SearchSINo_ToBranch()
        GridView.Columns.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamRefNo", txt_SINo.EditValue)}

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, GridControl, GridView, "SPA_Find_RefNoForTransmittal")
    End Sub

    Private Sub txt_SINo_EditValueChanged(sender As Object, e As EventArgs) Handles txt_SINo.EditValueChanged
        Show_SPA_Inventory()
        SearchSINo_ToBranch()
        SPA_ShowFullNameApprover()
        SPA_ShowFullNameParstman()
        SPA_ShowFullNamePrepared()
    End Sub

    Private Sub toolPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles toolPrint.ItemClick
        Dim report As New xRptTransmittal_Outgoing()
        ' Obtain a parameter and set its value.
        report.Parameters("DateTrans").Value = dtp_Date.Text
        report.Parameters("PONo").Value = txt_PONo.EditValue
        report.Parameters("SINo").Value = txt_SINo.EditValue
        report.Parameters("Source").Value = txt_Source.EditValue
        report.Parameters("BranchTo").Value = txt_BrCode.EditValue & " - " & txt_Vendor.EditValue
        report.Parameters("BranchFrom").Value = class_Saga_Variables.sBranchCode & " - " & class_Saga_Variables.sBranchCode
        report.Parameters("TotalCost").Value = lbl_SubTotal.Text
        report.Parameters("TotalVat").Value = lbl_Less.Text
        report.Parameters("TotalAmount").Value = lbl_GrandTotal.Text
        report.Parameters("preparedBy").Value = txt_PreparedName.EditValue
        report.Parameters("NotedBy").Value = txt_ApproverName.EditValue
        report.Parameters("Notes").Value = txt_Note.EditValue
        report.Parameters("ReceivedBy").Value = txt_CheckerName.EditValue
        report.Parameters("Designation1").Value = txt_Designation1.EditValue
        report.Parameters("Designation2").Value = txt_Designation2.EditValue
        report.Parameters("Designation3").Value = txt_Designation3.EditValue
        report.Parameters("Transfers").Value = Me.Text & " REPORTS"

        ' Hide the Parameters' UI from end-users (if you did not hide it at design time).
        For Each param In report.Parameters
            param.Visible = False
        Next

        GridView.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GridControl
        report.ShowPreview
    End Sub

    Private Sub SPA_TransmittalReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cmb_Status.Text = "FOR TRANSPORT" Or cmb_Status.Text = "For Transport" Then
            Me.Text = "FOR TRANSPORT"
        ElseIf cmb_Status.Text = "Approved" Then
            Me.Text = "ACCEPTED TRANSFERS"
        End If
        subTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        subTotal.SummaryItem.DisplayFormat = "SubTotal = {0:n2}"
    End Sub

    Sub SPA_ShowFullNameApprover()
        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_ShowFullName")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_ApproverName.EditValue = myDataReader("fullname").ToString
                    txt_Designation3.EditValue = myDataReader("designation").ToString
                Loop
            End If
        End Using
    End Sub

    Sub SPA_ShowFullNameParstman()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamUserName", txt_Partsman.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_ShowFullName")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_CheckerName.EditValue = myDataReader("fullname").ToString
                    txt_Designation2.EditValue = myDataReader("designation").ToString
                Loop
            End If
        End Using
    End Sub

    Sub SPA_ShowFullNamePrepared()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamUserName", class_Saga_Database.get_Branch_Name(class_Saga_Variables.sBranchCode))}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_ShowFullName")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_PreparedName.EditValue = myDataReader("fullname").ToString
                    txt_Designation1.EditValue = myDataReader("designation").ToString
                Loop
            End If
        End Using
    End Sub

End Class