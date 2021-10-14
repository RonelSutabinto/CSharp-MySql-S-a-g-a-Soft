Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_FirstLoadSummaryTabular

    Private Sub IS_FirstLoadSummaryTabular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mg_ShowMCAEAccountCnt()
    End Sub

    Sub mg_ShowMCAEAccountCnt()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)}

        class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, GCAcctCnt, GViewCnt, "mg_ShowMCAEAccountCnt")
    End Sub

End Class