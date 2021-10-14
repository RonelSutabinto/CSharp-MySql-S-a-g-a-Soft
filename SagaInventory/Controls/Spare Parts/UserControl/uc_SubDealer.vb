Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class uc_SubDealer
    Friend Sub control_Save()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamID", txt_ID.Text),
            New SqlParameter("@ParamSubName", txt_SubName.Text.Trim),
            New SqlParameter("@ParamSubAddress", txt_SubAddress.Text.Trim),
            New SqlParameter("@ParamTransactedby", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamPostingDate", dtp_PostingDate.Text)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "SPA_Register_SubDealer", "Dealer Profile")
    End Sub

    Friend Sub control_Clear()
        txt_ID.Text = String.Empty
        txt_SubName.Text = String.Empty
        txt_SubAddress.Text = String.Empty
        dtp_PostingDate.Text = Now()
    End Sub

End Class