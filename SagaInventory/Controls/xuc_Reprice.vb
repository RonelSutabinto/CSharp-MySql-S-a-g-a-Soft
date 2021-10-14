Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class xuc_Reprice
    Friend InventoryID, ModelCode, LedgerSet As Integer
    Friend BranchCode, RefNo, PONo, AccountNumber, EngineNo, ChassisNo, InventoryStatus, WH_Code As String

    Friend Function Control_Update_iRep() As Boolean
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@COD", COD.EditValue),
            New SqlParameter("@LCP", LCP.EditValue),
            New SqlParameter("@AOC", AOC.EditValue),
            New SqlParameter("@Inventory_Status", "Approved"),
            New SqlParameter("@Engine_Number", EngineNo),
            New SqlParameter("@Branch_Code", BranchCode),
            New SqlParameter("@Prev_ID", InventoryID),
            New SqlParameter("@DP", Down_Payments.EditValue),
            New SqlParameter("@WH_Code", WH_Code),
            New SqlParameter("@Action_Type", "iRepo_Approval")
        }

        Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "bj_Inventory_DepUnits", "REPO APPROVAL", COD.EditValue)
    End Function

    Friend Function Control_Update_Rep() As Boolean
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@COD", COD.EditValue),
            New SqlParameter("@LCP", LCP.EditValue),
            New SqlParameter("@AOC", AOC.EditValue),
            New SqlParameter("@Inventory_Status", "Approved"),
            New SqlParameter("@Engine_Number", EngineNo),
            New SqlParameter("@Branch_Code", BranchCode),
            New SqlParameter("@Prev_ID", InventoryID),
            New SqlParameter("@DP", Down_Payments.EditValue),
            New SqlParameter("@WH_Code", WH_Code),
            New SqlParameter("@Action_Type", "Repo_Approval")
        }

        Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "bj_Inventory_DepUnits", "REPO APPROVAL", COD.EditValue)
    End Function


    Friend Function Control_Reclass() As Boolean
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", BranchCode),
            New SqlParameter("@ParamAccountNumber", AccountNumber),
            New SqlParameter("@ParamLedgerSetNumber", LedgerSet),
            New SqlParameter("@ParamPostingDate", Date.Now()),
            New SqlParameter("@ParamNewStatus", "REP"),
            New SqlParameter("@ParamTransactedby", class_Variables.sUserName)
        }

        Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_AdminReclassStatus", "DEPO TO REPO", AccountNumber)
    End Function

End Class