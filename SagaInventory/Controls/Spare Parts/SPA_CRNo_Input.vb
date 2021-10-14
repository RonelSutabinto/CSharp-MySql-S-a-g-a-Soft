Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class SPA_CRNo_Input

    Private Sub txt_CRNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_CRNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Searching_For_Duplication()
        End If
    End Sub

    Sub Searching_For_Duplication()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamCRNo", txt_CRNo.Text),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_CRNo_avoid_Dup")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                If myDataReader.Item("Status").ToString() = "0" Then
                    SPA_Sales_Inquiry.txt_CRNumber.EditValue = txt_CRNo.EditValue
                    SPA_Sales_Inquiry.txt_CRNumber1.EditValue = txt_CRNo.EditValue
                    txt_CRNo.EditValue = String.Empty
                    Me.Close()

                ElseIf myDataReader.Item("status").ToString() = "1" Then
                    MsgBox(myDataReader.Item("Message"), MessageBoxIcon.Stop)
                End If
                Return
            End If
        End Using
    End Sub

End Class