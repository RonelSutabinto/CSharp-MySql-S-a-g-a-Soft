Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
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

    private sub mg_ShowpendingTransactions()
        cntMCPending = 0
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamTransactedBy", class_Variables.sUserName)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowPendingTransactions")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cntMCPending = cntMCPending + 1
                Loop
            End If
        End Using
    End Sub

    private sub mg_ShowDisapprovedTransactionsMC()
        '        

        '        cntMCDisapproved = 0

        '        Dim sqlParameters As SqlParameter() = {}
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then

        '        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowDisapprovedTransactions"
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
        '        myDataReader.read
        '        New SqlParameter("@ParamTransactedby", class_Variables.sUserName)
        '        'New SqlParameter("@ParamInventoryStatus", Me.Text)
        '        

        '        myDataReader.Read()
        '        ' Data is accessible through the DataReader object here.

        '        Do While myDataReader.Read()
        '            cntMCDisapproved = cntMCDisapproved + 1
        '        Loop
        '        end if
        '        end using
        '        

        '    
        '        
        '        end using
        '        

        '   'MsgBox("Successful Updating")
        '
    End Sub

    private sub mg_ShowForApprovalMC()
        '        

        '        cntMCForApproval = 0

        '        Dim sqlParameters As SqlParameter() = {}
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then

        '        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowForApprovalTransactions"
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
        '        myDataReader.read
        '        New SqlParameter("@ParamApprover", class_Variables.sUserName)
        '        New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        '        

        '        myDataReader.Read()
        '        Do While myDataReader.Read()
        '            cntMCForApproval = cntMCForApproval + 1
        '        Loop
        '        end if
        '        end using
        '        

        '    

        '        end using
        '        

        '
        '

    End Sub

    private sub ShowInTransitTransactions()
        '        

        '        cntMCInTransit = 0

        '        Dim sqlParameters As SqlParameter() = {}
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then

        '        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowInTransitTransactionsRangeDate"
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
        '        myDataReader.read
        '        New SqlParameter("@ParamApprover", class_Variables.sUserName)
        '        New SqlParameter("@ParamDateBegin", Now)
        '        New SqlParameter("@ParamDateEnd", Now)
        '        
        '        myDataReader.Read()

        '        Do While myDataReader.Read()
        '            cntMCInTransit = cntMCInTransit + 1
        '        Loop
        '        end if
        '        end using
        '        

        '    

        '        end using
        '        

        '
        '
    End Sub

    friend sub showMCForDep()
        '        

        '        Dim sqlParameters As SqlParameter() = {}
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
        '        cntMCForDep = 0

        '        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_Generate_AgedAccounts"
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
        '        cmd.CommandTimeout = 500
        '        myDataReader.read
        '        New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        '        New SqlParameter("@ParamCutOffDate", Now)
        '        
        '        myDataReader.Read()

        '        Do While myDataReader.Read()
        '            cntMCForDep = cntMCForDep + 1
        '        Loop

        '        end if
        '        end using
        '        
        '    
        '        end using
        '        

        '   'MsgBox("Successful Updating")
        '
    End Sub

    friend sub showDEPtoREPCnt()
        cntDeptoRep = 0

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamDays", "45"),
            New SqlParameter("@ParamWH", "DEP")
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "rpt_DepRepMonitoring")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cntDeptoRep = cntDeptoRep + 1
                Loop
            End If
        End Using
    End Sub

    friend sub showREPAgedCnt()
        '        

        '        cntRepAged = 0
        '        Dim sqlParameters As SqlParameter() = {}
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then

        '        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "rpt_DepRepMonitoring"
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
        '        cmd.CommandTimeout = 100
        '        myDataReader.read
        '        New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        '        New SqlParameter("@ParamDays", "60")
        '        New SqlParameter("@ParamWH", "REP")

        '        
        '        myDataReader.Read()

        '        Do While myDataReader.Read()
        '            cntRepAged = cntRepAged + 1
        '        Loop
        '        end if
        '        end using
        '        
        '    
        '        end using
        '        

        '   'MsgBox("Successful Updating")
        '  'gridView.LoadingPanelVisible = False

    End Sub

    friend sub mg_MCOverdueAccts()
        '        

        '        cntMCOverAcct = 0
        '        Dim sqlParameters As SqlParameter() = {}
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then

        '        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowMCOverDueAcct"
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
        '        myDataReader.read
        '        New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)

        '        

        '        myDataReader.Read()

        '        Do While myDataReader.Read()
        '            cntMCOverAcct = cntMCOverAcct + 1
        '        Loop
        '        end if
        '        end using
        '        

        '    
        '        
        '        end using
        '        

        '   'MsgBox("Successful Updating")
        '
    End Sub

    friend sub mg_MCCurrentAccts()
        '        

        '        cntMCCurrAcct = 0
        '        Dim sqlParameters As SqlParameter() = {}
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then

        '        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowMCCurrentAcct"
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
        '        myDataReader.read
        '        New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)

        '        

        '        myDataReader.Read()

        '        Do While myDataReader.Read()
        '            cntMCCurrAcct = cntMCCurrAcct + 1
        '        Loop
        '        end if
        '        end using
        '        

        '    
        '        
        '        end using
        '        

        '   'MsgBox("Successful Updating")
        '
    End Sub

    friend sub mg_MCDEPAccts()
        '        

        '        cntMCDEPAcct = 0
        '        Dim sqlParameters As SqlParameter() = {}
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then

        '        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowMCDEPAcct"
        '        If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
        '        myDataReader.read
        '        New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)

        '        

        '        myDataReader.Read()

        '        Do While myDataReader.Read()
        '            cntMCDEPAcct = cntMCDEPAcct + 1
        '        Loop
        '        end if
        '        end using
        '        

        '    
        '        
        '        end using
        '        

        '   'MsgBox("Successful Updating")
        '
    End Sub

    friend sub mg_SPACustDepDue()

    End Sub

    friend sub CountAllTransactions()
        MainMenu.MCForApproval.Visible = False
        MainMenu.MCInTransit.Visible = False
        MainMenu.InvCntTrans.Visible = False
        MainMenu.MCDeptoREP.Visible = False
        MainMenu.MCRepAged.Visible = False

        mg_ShowForApprovalMC()
        ShowInTransitTransactions()
        mg_ShowDisapprovedTransactionsMC()
        mg_ShowpendingTransactions()
        showDEPtoREPCnt()
        showREPAgedCnt()
        showMCForDep()

        mg_MCCurrentAccts()
        mg_MCOverdueAccts()
        mg_MCDEPAccts()
        mg_SPACustDepDue()

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

        'IS_FirstLoadSummary.txt_MCOverdueAcct.Text = cntMCOverAcct
        'IS_FirstLoadSummary.txt_CurMCAcct.Text = cntMCCurrAcct
        'IS_FirstLoadSummary.txt_TotOvCurAcct.Text = cntMCOverAcct + cntMCCurrAcct

        cntTotCurOver = cntMCOverAcct + cntMCCurrAcct

    End Sub

End Module