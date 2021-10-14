Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class maint_ChangeApprover_Sales

    Private Sub maint_ChangeApprover_Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ShowaPPROVERbyMaker()
        ShowaPPROVERbyBranch()
    End Sub

    Sub showaPPROVERbyMaker()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamUserName", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowApproverByMaker")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_approver.Text = myDataReader("approver").ToString()
                txt_approverFull.Text = myDataReader("ApproverFull").ToString()
            End If
        End Using
    End Sub

    Sub showaPPROVERbyBranch()
        LViewItems.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowApproverByBranch")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewItems.Items.Add(myDataReader.Item("BranchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("username").ToString())
                    li.SubItems.Add(myDataReader.Item("fullname").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub mg_SetApproverSales()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamUserName", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamApprover", txt_newApprover.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_SetApproverSales")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MsgBox(myDataReader.Item("Message").ToString())
            End If
        End Using
    End Sub

    Sub showaPPROVERbyMakerREL()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamUserName", MainMenu.App_User_Name.Caption),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowApproverByMaker")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                IS_SALES_Release.txt_approverREL.Text = myDataReader("approver").ToString()
                IS_SALES_Release.txt_approverFullREL.Text = myDataReader("ApproverFull").ToString()
            End If
        End Using
    End Sub

    Private Sub LViewItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewItems.DoubleClick
        txt_newApprover.Text = LViewItems.SelectedItems.Item(0).SubItems(1).Text()
    End Sub

    Private Sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        mg_SetApproverSales()
        showaPPROVERbyMakerREL()
        Me.Close()
    End Sub

    Private Sub LViewItems_Click(sender As Object, e As EventArgs) Handles LViewItems.Click
        txt_newApprover.Text = LViewItems.SelectedItems.Item(0).SubItems(1).Text()
    End Sub

End Class