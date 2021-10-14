Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_SALESforToday
    Private ReadOnly Crystal_Report As New ReportDocument
    Sub searchBranchName()
        cmb_BranchName.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM maint_branches ORDER BY branchcode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_BranchName.Items.Add(myDataReader.Item("branchname").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub searchBranchCode()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM maint_branches WHERE branchname LIKE '" & cmb_BranchName.Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_BranchCode.Text = myDataReader("branchcode").ToString()
                Loop
            End If
        End Using
    End Sub

    Sub searchSales()
        Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM TransactionReleases WHERE branchcode LIKE '" & txt_BranchCode.Text & "' AND inventoryStatus LIKE '" & cmb_salesType.Text & "' AND TransactionDate = '" & trans_date.Text & "'")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MsgBox(myDataReader.Item("model").ToString() & " - " & myDataReader("engineno").ToString() & " - " & myDataReader("chassisno").ToString())
            End If
        End Using
    End Sub

    Private Sub cmd_showInvent_Click(sender As System.Object, e As System.EventArgs) Handles cmd_showInvent.Click
        Dim CrTable As Table
        Dim CrTables As Tables
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo

        Dim reportPath As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "ListofSALEStoday.rpt")
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
        Crystal_Report.SetParameterValue("branchCode", txt_BranchCode.Text)
        Crystal_Report.SetParameterValue("salestype", cmb_salesType.Text)
        Crystal_Report.SetParameterValue("transactiondate", trans_date.Text)

        rpt_page.CrystalReportViewer1.ReportSource = Crystal_Report
        rpt_page.CrystalReportViewer1.Refresh()
        rpt_page.ShowDialog()
    End Sub

    Private Sub IS_SALESforToday_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        searchBranchName()
    End Sub

    Private Sub cmb_BranchName_TextChanged(sender As Object, e As System.EventArgs) Handles cmb_BranchName.TextChanged
        searchBranchCode()
    End Sub

End Class