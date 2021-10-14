Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class IS_FirstLoadSummaryTabular

    private sub IS_FirstLoadSummaryTabular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mg_ShowMCAEAccountCnt()
    End Sub

    private sub mg_ShowMCAEAccountCnt()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }
        class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GCAcctCnt, GViewCnt, "mg_ShowMCAEAccountCnt")
    End Sub

End Class