Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Module Inventory
    Public cntMCInvTrans As Integer
    Public cntMCForApproval As Integer
    Public cntMCInTransit As Integer
    Public cntMCDisapproved As Integer
    Public cntMCPending As Integer

    Public cntDeptoRep As Integer
    Public cntRepAged As Integer
    Public cntInvDepRepTot As Integer
    Public cntMCForDep As Integer

    Public cntMCOverAcct As Integer
    Public cntMCCurrAcct As Integer
    Public cntTotCurOver As Integer
    Public cntMCDEPAcct As Integer

    Public cntSPACustDepDue As Integer

    Sub mg_ShowpendingTransactions()
        cntMCPending = 0
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowPendingTransactions")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cntMCPending = cntMCPending + 1
                Loop
            End If
        End Using
    End Sub

    Public Sub showDEPtoREPCnt()
        cntDeptoRep = 0
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamDays", "45"),
            New SqlParameter("@ParamWH", "DEP")
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "rpt_DepRepMonitoring")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cntDeptoRep = cntDeptoRep + 1
                Loop
            End If
        End Using
    End Sub

    Public Sub CountAllTransactions()
        MainMenu.MCForApproval.Visible = False
        MainMenu.MCInTransit.Visible = False
        MainMenu.InvCntTrans.Visible = False
        MainMenu.MCDeptoREP.Visible = False
        MainMenu.MCRepAged.Visible = False

        mg_ShowpendingTransactions()
        showDEPtoREPCnt()

        cntMCInvTrans = 0

        If cntMCForApproval > 0 Then
            MainMenu.MCForApproval.Visible = True
            MainMenu.MCForApproval.Properties.Text = cntMCForApproval
        End If

        If cntMCInTransit > 0 Then
            MainMenu.MCInTransit.Visible = True
            MainMenu.MCInTransit.Properties.Text = cntMCInTransit
        End If

        If cntMCDisapproved > 0 Then
            MainMenu.MCDisapproved.Visible = True
            MainMenu.MCDisapproved.Properties.Text = cntMCDisapproved
        End If

        If cntMCPending > 0 Then
            MainMenu.MCPending.Visible = True
            MainMenu.MCPending.Properties.Text = cntMCPending
        End If

        cntMCInvTrans = Val(cntMCForApproval) + Val(cntMCInTransit) + Val(cntMCDisapproved) + Val(cntMCPending)

        If cntMCInvTrans > 0 Then
            MainMenu.InvCntTrans.Visible = True
            MainMenu.InvCntTrans.Properties.Text = cntMCInvTrans
        End If

        If cntDeptoRep > 0 Then
            MainMenu.MCDeptoREP.Visible = True
            MainMenu.MCDeptoREP.Properties.Text = cntDeptoRep
        End If

        If cntRepAged > 0 Then
            MainMenu.MCRepAged.Visible = True
            MainMenu.MCRepAged.Properties.Text = cntRepAged
        End If

        cntInvDepRepTot = cntDeptoRep + cntRepAged
        If cntInvDepRepTot > 0 Then
            MainMenu.DepRepTotal.Visible = True
            MainMenu.DepRepTotal.Properties.Text = cntInvDepRepTot
        End If

        cntTotCurOver = cntMCOverAcct + cntMCCurrAcct
    End Sub
End Module