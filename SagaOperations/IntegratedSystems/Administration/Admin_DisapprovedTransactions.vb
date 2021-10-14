Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Admin_DisapprovedTransactions

    Private Sub Admin_DisapprovedTransactions_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Admin_DisapprovedTransactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mg_ShowDisapprovedTransactions()
    End Sub

    Sub mg_ShowDisapprovedTransactions()
        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_DisapprovedTransactionsShow")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewList.Items.Add(myDataReader.Item("refno").ToString())
                    li.SubItems.Add(myDataReader.Item("transcode").ToString())
                    li.SubItems.Add(myDataReader.Item("pono").ToString())
                    li.SubItems.Add(myDataReader.Item("vendor").ToString())
                    li.SubItems.Add(myDataReader.Item("invstats").ToString())
                    li.SubItems.Add(myDataReader.Item("source").ToString())
                    li.SubItems.Add(myDataReader.Item("type").ToString())
                    li.SubItems.Add(Format(myDataReader.Item("DateGranted"), "MM/dd/yyyy"))
                    li.SubItems.Add(myDataReader.Item("Ledgersetnumber").ToString)
                    li.SubItems.Add(myDataReader.Item("BranchCode").ToString)
                    li.SubItems.Add(myDataReader.Item("approver").ToString)
                Loop
            End If
        End Using
    End Sub

    Sub DeleteTransactions()
        LViewList.Items.Clear()
        Dim Parameters As SqlParameter() =
        {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamType", txt_type.Text),
            New SqlParameter("@ParamRefno", txt_accountno.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_ledset.Text),
            New SqlParameter("@ParamTranscode", txt_TransCode.Text),
            New SqlParameter("@ParamDateGranted", dateGrant2.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_DisapprovedTransactionsDelete")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MsgBox(myDataReader.Item("Message").ToString())
            End If
        End Using

        mg_ShowDisapprovedTransactions()
    End Sub

    Private Sub LViewList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewList.DoubleClick
        txt_accountno.Text = LViewList.SelectedItems.Item(0).SubItems(0).Text
        txt_TransCode.Text = LViewList.SelectedItems.Item(0).SubItems(1).Text
        txt_type.Text = LViewList.SelectedItems.Item(0).SubItems(6).Text
        dateGrant2.Text = LViewList.SelectedItems.Item(0).SubItems(7).Text
        txt_ledset.Text = LViewList.SelectedItems.Item(0).SubItems(8).Text
        txt_branchCode.Text = LViewList.SelectedItems.Item(0).SubItems(9).Text
        DeleteTransactions()
    End Sub

    Private Sub LViewList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LViewList.SelectedIndexChanged

    End Sub

End Class