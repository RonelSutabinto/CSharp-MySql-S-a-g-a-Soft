Imports System.Data.SqlClient

Module modLoadParameters

    Friend Sub ICS_ShowBranchCode()
        ''On Error GoTo out
        'Dim cmd As New SqlCommand
        'Dim rs As SqlDataReader

        'cmd.CommandText = "mg_ShowBranchCode"
        'cmd.CommandType = CommandType.StoredProcedure

        'cmd.Connection = ICSTransactions
        'cmd.Parameters.AddWithValue("@ParamBranchName", frm_Request.Uc_Request.cmb_Branch.Text)

        'ICSTransactions.Open()
        'rs = cmd.ExecuteReader()
        'Do While rs.Read
        '    frm_Request.Uc_Request.txt_brCode.EditValue = rs.Item("BranchCode").ToString
        'Loop

        ''out:

        ''outs:
        ''outs1:  'rs.Close()
        'ICSTransactions.Close()
    End Sub

End Module