Imports System.Data.SqlClient
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Public Class uc_SubDealer

    Friend Sub control_Save()

        Dim sqlParameters As SqlParameter() = {
           New SqlParameter("@ParamID", txt_ID.EditValue),
           New SqlParameter("@ParamSubName", txt_SubName.EditValue),
           New SqlParameter("@ParamSubAddress", txt_SubAddress.EditValue),
           New SqlParameter("@ParamTransactedby", class_Saga_Variables.sBranchCode),
           New SqlParameter("@ParamPostingDate", dtp_PostingDate.EditValue)
       }

        class_Database.Procedure_Retrieve(class_Database.SPAConnection, sqlParameters, "SPA_Register_SubDealer", False)
        MsgBox("Sub-Dealer Created/Updated!", vbInformation, Application.CompanyName)
    End Sub

    Friend Sub control_Clear()
        txt_ID.Text = ""
        txt_SubName.Text = ""
        txt_SubAddress.Text = ""
        dtp_PostingDate.Text = CStr(Date.Today())
    End Sub

End Class