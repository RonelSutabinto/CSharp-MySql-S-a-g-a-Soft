Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient
Imports wSClassLib.myModules

Public Class IS_Inventory_Outgoing_View
    Dim Crystal_Report As New ReportDocument

    Private Sub lbl_vendor_TextChanged(sender As Object, e As System.EventArgs) Handles lbl_vendor.TextChanged
        lbl_vendor.Text = lbl_vendor.Text.ToUpper()
    End Sub

    Private Sub IS_Inventory_Outgoing_View_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        clearItems()
    End Sub

    Private Sub IS_Inventory_Outgoing_View_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cmd_print.Visible = False

        If MainMenu.statusBrCode.Caption = txt_originatingBranch.Text Then
        Else
            txt_receiver.EditValue = MainMenu.App_User_Name.Caption
            txt_receiver.Text = MainMenu.App_User_Name.Caption
            txt_receiver.Enabled = False
            searchBranchApprover()
        End If
    End Sub

    Sub searchBranchApprover()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM item_master WHERE refno LIKE '" & txt_refno.Text & "' AND pono LIKE '" & txt_pono.Text & "' AND transcode LIKE '" & txt_TransCode.Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                lbl_approver.Text = myDataReader("OriginatingMaker").ToString
            End If
        End Using
    End Sub

    Sub clearItems()
        lbl_vendor.Text = String.Empty
        lbl_vendorCode.Text = String.Empty
        txt_refno.Text = String.Empty
        txt_pono.Text = String.Empty
        txt_TransCode.Text = String.Empty
        txt_sender.Text = String.Empty
        txt_originatingBranch.Text = String.Empty
        txt_invenStat.Text = String.Empty
        txt_receiver.Text = String.Empty
        txt_whcode.Text = String.Empty
        cmb_warehouse.Text = String.Empty
        LViewItems.Items.Clear()
    End Sub

    Private Sub cmd_approved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_approved.Click
        If MainMenu.statusBrCode.Caption = txt_originatingBranch.Text Then
            If txt_receiver.Text = String.Empty Then
                MsgBox("Please select Receiver of the transport!", vbCritical, "webSources")
            End If

            If txt_receiver.Text = "[EditValue is null]" Then
                MsgBox("Please select Receiver of the transport!", vbCritical, "webSources")
            End If
            Approveditems_SameBranch()
            cmd_print.Location = New Point(13, 441)
            cmd_print.Visible = True
            cmd_approved.Visible = False
            cmd_disapproved.Visible = False
        Else
            Approveditems_InterBranch()
            cmd_print.Location = New Point(13, 441)
            cmd_print.Visible = True
            cmd_approved.Visible = False
            cmd_disapproved.Visible = False
        End If
    End Sub

    Sub Approveditems_SameBranch()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamRefNo", txt_refno.Text),
            New SqlParameter("@ParamPONo", txt_pono.Text),
            New SqlParameter("@ParamInventoryStatus", txt_invenStat.Text),
            New SqlParameter("@ParamOriginatingBranch", txt_originatingBranch.Text),
            New SqlParameter("@ParamOriginatingMaker", lbl_approver.Text),
            New SqlParameter("@ParamSourceEvent", "OUTGOING"),
            New SqlParameter("@ParamApprover", txt_receiver.EditValue),
            New SqlParameter("@ParamTransactedby", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamWHCode", txt_whcode.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_Inventory_ItemApproval", "Approved Unit Items", txt_refno.Text)

        cmd_print.Location = New Point(13, 441)
        cmd_print.Visible = True
    End Sub

    Sub Approveditems_InterBranch()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamRefNo", txt_refno.Text),
            New SqlParameter("@ParamPONo", txt_pono.Text),
            New SqlParameter("@ParamInventoryStatus", txt_invenStat.Text),
            New SqlParameter("@ParamOriginatingBranch", txt_originatingBranch.Text),
            New SqlParameter("@ParamOriginatingMaker", txt_sender.Text),
            New SqlParameter("@ParamSourceEvent", "INTERBRANCH"),
            New SqlParameter("@ParamApprover", txt_receiver.EditValue),
            New SqlParameter("@ParamTransactedby", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamWHCode", txt_whcode.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_Inventory_ItemApproval", "Approved Inter-Branch Unit Items", txt_refno.Text)

        cmd_print.Location = New Point(13, 441)
        cmd_print.Visible = True
    End Sub

    Private Sub cmd_disapproved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_disapproved.Click
        grp_remarks.Visible = True
    End Sub

    Sub DisApproveditems()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamRefNo", txt_refno.Text),
            New SqlParameter("@ParamPONo", txt_pono.Text),
            New SqlParameter("@ParamInventoryStatus", txt_invenStat.Text),
            New SqlParameter("@ParamSourceEvent", "OUTGOING"),
            New SqlParameter("@ParamRemarks", txt_disappr_remarks.Text),
            New SqlParameter("@ParamTransactedby", txt_sender.Text),
            New SqlParameter("@ParamApprover", lbl_approver.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_Inventory_ItemDisapproved", "Disapproved Unit Items", "txt_refno.Text")
    End Sub

    Private Sub cmd_print_Click(sender As System.Object, e As System.EventArgs) Handles cmd_print.Click
        Dim CrTable As Table
        Dim CrTables As Tables
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim reportPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "IS_Inventory_ReceivingReport.rpt")
        Crystal_Report.Load(reportPath)
        Dim crParameterValue As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        With crConnectionInfo
            .ServerName = class_Tools.Decrypt(class_Tools.RegKeyGet("HostServer", "HostServer", String.Empty))
            .DatabaseName = class_Tools.Decrypt(class_Tools.RegKeyGet("Dbase", "DataBaseName", String.Empty))
            .UserID = class_Tools.Decrypt(class_Tools.RegKeyGet("DBaseUname", "DataBaseUserName", String.Empty))
            .Password = class_Tools.Decrypt(class_Tools.RegKeyGet("DBasePassword", "DataBasePassWord", String.Empty))
        End With
        CrTables = Crystal_Report.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next
        Crystal_Report.SetParameterValue("refno", txt_refno.Text)
        Crystal_Report.SetParameterValue("pono", txt_pono.Text)
        Crystal_Report.SetParameterValue("whCode", txt_whcode.Text)
        Crystal_Report.SetParameterValue("rptTitle", txt_rptTitle.Text)

        rpt_page.CrystalReportViewer1.ReportSource = Crystal_Report
        rpt_page.CrystalReportViewer1.Refresh()
        rpt_page.ShowDialog()
    End Sub

    Private Sub cmb_disapp_Click(sender As System.Object, e As System.EventArgs) Handles cmb_disapp.Click
        DisApproveditems()
        grp_remarks.Visible = False
    End Sub

    Private Sub IS_Inventory_Outgoing_View_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        mVendorCode = lbl_vendorCode.Text
        Initialize_InvOutReceiver()
        Initialize_InvOutReceiver(txt_receiver)
    End Sub
End Class