Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Partial Public Class IS_InquiryORNo
    private sub RepositoryItemSearchControl1_KeyDown(sender As Object, e As KeyEventArgs) Handles RepositoryItemSearchControl1.KeyDown
        If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then

            Dim SearchText As String
            SearchText = (CType(sender, BaseEdit)).Text.Trim

            GViewRefNo.Columns.Clear()

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ParamRefNo", SearchText)
            }
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, GVRefNo, GViewRefNo, "mg_ShowRefNo")
        End If
    End Sub

    private sub GVRefNo_Click(sender As Object, e As EventArgs) Handles GVRefNo.Click
        If GViewRefNo.RowCount > 0 Then
            txt_RefNo.Text = GViewRefNo.GetFocusedRowCellDisplayText("RefNo")
            txt_InitiatingBr.Text = GViewRefNo.GetFocusedRowCellDisplayText("InitiatingBranch")
            txt_BrCode.Text = GViewRefNo.GetFocusedRowCellDisplayText("BranchCode")
            txt_AccountNumber.Text = GViewRefNo.GetFocusedRowCellDisplayText("AccountNumber")
            txt_Ledset.Text = GViewRefNo.GetFocusedRowCellDisplayText("LedgerSetNumber")
            txt_AccountName.Text = GViewRefNo.GetFocusedRowCellDisplayText("AccountName")
            txt_Mnemonic.Text = GViewRefNo.GetFocusedRowCellDisplayText("Mnemonic")
            txt_PostingDate.Text = GViewRefNo.GetFocusedRowCellDisplayText("PostingDate")
            txt_Transactions.Text = GViewRefNo.GetFocusedRowCellDisplayText("Trans")
            txt_Invoices.Text = GViewRefNo.GetFocusedRowCellDisplayText("Invoices")
            txt_Descriptions.Text = GViewRefNo.GetFocusedRowCellDisplayText("Descr")
            txt_AmountPaid.Text = GViewRefNo.GetFocusedRowCellDisplayText("AmountPaid")
            txt_TransactedBy.Text = GViewRefNo.GetFocusedRowCellDisplayText("TransactedBy")

        End If
    End Sub
End Class