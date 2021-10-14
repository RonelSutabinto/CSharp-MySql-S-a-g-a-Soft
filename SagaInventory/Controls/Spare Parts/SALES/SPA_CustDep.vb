Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class SPA_CustDep
    Sub SPA_Find_CRNo_CustDep()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamCRNo", txt_CRNo.Text),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_CRNo_CustDep")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_Custname1.Text = myDataReader("custName").ToString
                txt_Address1.Text = myDataReader("custAddress").ToString
                dtp_Date1.Text = myDataReader("PostingDate").ToString
                txt_VAT.Text = myDataReader("VATAmount").ToString
                txt_NetVAT.Text = myDataReader("NetAmntOfVat").ToString
            End If
        End Using
    End Sub

    Sub SPA_AccountCode()
        cmb_Transaction.Properties.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamIsCommand", Me.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_AccountCode")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                cmb_Transaction.Properties.Items.Add(myDataReader.Item("Transactions").ToString)
            End If
        End Using
    End Sub

    Sub Show_InvoicesTransaction()
        cmb_Invoices.Properties.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamID", txt_ID.EditValue)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Show_Invoices")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                cmb_Invoices.Properties.Items.Add(myDataReader.Item("Invoices").ToString)
            End If
        End Using
    End Sub

    Sub SPA_CustDep_Register()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@Paramtrans_Category", cmb_Transaction.Text),
            New SqlParameter("@Paramtrans_Code", txt_Code.Text),
            New SqlParameter("@ParamInvoices", cmb_Invoices.Text),
            New SqlParameter("@ParamPostingDate", dtp_Date.Text),
            New SqlParameter("@ParamCustName", txt_Custname.Text),
            New SqlParameter("@ParamCIFKey", txt_CIFKey.Text),
            New SqlParameter("@ParamCustAddress", txt_Address.Text),
            New SqlParameter("@ParamCRNo", txt_CRNo.Text),
            New SqlParameter("@ParamTerms", cmb_Terms.Text),
            New SqlParameter("@ParamDescription", txt_Description.Text),
            New SqlParameter("@ParamAmountDue", txt_AmountDue.Text),
            New SqlParameter("@ParamDiscount", txt_Discount.Text),
            New SqlParameter("@ParamBranchCode", class_Saga_Variables.sBranchCode)
        }

        class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "SPA_CustDep_Register", "Customer Deposit")
    End Sub

    Sub SPA_Show_Mnemonic()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamTransactions", cmb_Transaction.EditValue)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Show_Mnemonic")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    txt_Code.EditValue = myDataReader("Mnemonic").ToString
                    txt_ID.EditValue = myDataReader("TransactionID").ToString
                Loop
            End If
        End Using
    End Sub

    Private Sub btn_Post_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Post.ItemClick
        SPA_CustDep_Register()
    End Sub

    Private Sub SPA_CustDep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPA_AccountCode()
    End Sub

    Private Sub cmb_Transaction_EditValueChanged(sender As Object, e As EventArgs) Handles cmb_Transaction.EditValueChanged
        SPA_Show_Mnemonic()
        Show_InvoicesTransaction()
    End Sub

    Private Sub btn_Print_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Print.ItemClick
        SPA_Find_CRNo_CustDep()
    End Sub

    Private Sub btn_BillTo_Click(sender As Object, e As EventArgs) Handles btn_BillTo.Click
        SPA_Search_CIF.lbl_Type.Text = Me.Text
        SPA_Search_CIF.ShowDialog()
    End Sub
End Class