Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class maint_ChangeApprover_Sales

    private sub maint_ChangeApprover_Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowaPPROVERbyMaker()
        ShowaPPROVERbyBranch()
    End Sub

    private sub showaPPROVERbyMaker()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamUserName", class_Variables.sUserName),
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowApproverByMaker")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_approver.Text = myDataReader("approver").ToString()
                txt_approverFull.Text = myDataReader("ApproverFull").ToString()
            End If
        End Using
    End Sub

    private sub showaPPROVERbyBranch()
        LViewItems.Items.Clear()

        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowApproverByBranch")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItems.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("username").ToString())
                    li.SubItems.Add(myDataReader.Item("fullname").ToString())
                Loop
            End If
        End Using
    End Sub

    private sub mg_SetApproverSales()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode),
            New SqlParameter("@ParamUserName", class_Variables.sUserName),
            New SqlParameter("@ParamApprover", txt_newApprover.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_SetApproverSales")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MsgBox(myDataReader.Item("Message").ToString())
            End If
        End Using
    End Sub

    private sub showaPPROVERbyMakerREL()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@ParamUserName", class_Variables.sUserName),
            New SqlParameter("@ParamBranchCode", class_saga_variables.sbranchcode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowApproverByMaker")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                IS_SALES_Release.txt_approverREL.Text = myDataReader("approver").ToString()
                IS_SALES_Release.txt_approverFullREL.Text = myDataReader("ApproverFull").ToString()
            End If
        End Using
    End Sub

    private sub LViewItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewItems.DoubleClick
        txt_newApprover.Text = LViewItems.SelectedItems.Item(0).SubItems(1).Text()
    End Sub

    private sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        mg_SetApproverSales()
        showaPPROVERbyMakerREL()
        Me.Close()
    End Sub

    private sub LViewItems_Click(sender As Object, e As EventArgs) Handles LViewItems.Click
        txt_newApprover.Text = LViewItems.SelectedItems.Item(0).SubItems(1).Text()
    End Sub

End Class