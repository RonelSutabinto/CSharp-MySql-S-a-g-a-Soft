Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Search_Sales_Inquiry
    Sub SPA_Show_Sales_Inquiry()
        lv_Sales_Inquiry.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamCustName", txt_Search.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Show_Sales_Inquiry")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_Sales_Inquiry.Items.Add(myDataReader.Item("branchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("custCode").ToString())
                    li.SubItems.Add(myDataReader.Item("custName").ToString())
                    li.SubItems.Add(myDataReader.Item("custAddress").ToString())
                    li.SubItems.Add(myDataReader.Item("SINo").ToString())
                    li.SubItems.Add(myDataReader.Item("PostingDate").ToString())
                    li.SubItems.Add(myDataReader.Item("subTotal").ToString())
                Loop
            End If
        End Using
    End Sub

    Private Sub txt_Search_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Search.KeyDown
        If e.KeyCode = Keys.Enter Then
            SPA_Show_Sales_Inquiry()
        End If
    End Sub

    Sub SPA_Find_SINo_Sales()
        lv_Sales_Inquiry.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamSINo", txt_SINo.Text),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_SINo_Sales")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = SPA_Sales_Inquiry.lv_Parts.Items.Add(myDataReader.Item("branchCode").ToString())
                    li.SubItems.Add(myDataReader.Item("Quantity").ToString())
                    li.SubItems.Add(myDataReader.Item("quantityUnit").ToString())
                    li.SubItems.Add(myDataReader.Item("Descriptions").ToString())
                    li.SubItems.Add(myDataReader.Item("UnitPrice").ToString())
                    li.SubItems.Add(myDataReader.Item("GrossTotal").ToString())
                    li.SubItems.Add(myDataReader.Item("SalesDiscount").ToString())
                    li.SubItems.Add(myDataReader.Item("SalesDiscount_PCT").ToString())
                    li.SubItems.Add(myDataReader.Item("Discounted_SRP").ToString())
                    li.SubItems.Add(myDataReader.Item("subTotal").ToString())
                    li.SubItems.Add(myDataReader.Item("prev_ID").ToString())
                    li.SubItems.Add(myDataReader.Item("partsNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("partsName").ToString())
                Loop

                SPA_Sales_Inquiry.cmb_Terms.Text = myDataReader("Terms").ToString()
                SPA_Sales_Inquiry.dtp_Maturity.Text = myDataReader("MaturityDate").ToString()
                SPA_Sales_Inquiry.cmb_TransCategory.Text = myDataReader("trans_Category").ToString()
                SPA_Sales_Inquiry.txt_TransCode.Text = myDataReader("trans_Code").ToString()
                SPA_Sales_Inquiry.dtp_Date.Text = myDataReader("postingDate").ToString()
                SPA_Sales_Inquiry.txt_CustName.Text = myDataReader("custName").ToString()
                SPA_Sales_Inquiry.txt_Address.Text = myDataReader("custAddress").ToString()
                SPA_Sales_Inquiry.txt_SINo.Text = myDataReader("SINo").ToString()
                SPA_Sales_Inquiry.cmb_SI_Code.Text = myDataReader("SI_Code").ToString()
                SPA_Sales_Inquiry.txt_Note.Text = myDataReader("Note").ToString()
                SPA_Sales_Inquiry.txt_Status.Text = myDataReader("SaleStatus").ToString()
                SPA_Sales_Inquiry.txt_GTotal.Text = myDataReader("GrandTotal").ToString()
                SPA_Sales_Inquiry.txt_Balance.Text = myDataReader("SalesBalance").ToString()
                SPA_Sales_Inquiry.txt_BranchCode.Text = myDataReader("BranchCode").ToString()
                SPA_Sales_Inquiry.txt_custCode.Text = myDataReader("custCode").ToString()
                SPA_Sales_Inquiry.txt_CRNumber.Text = myDataReader("CRNumber").ToString()
                SPA_Sales_Inquiry.txt_AmountDue.Text = myDataReader("GrandTotal").ToString()

                '-------------------------Pause-------------------'

                SPA_Sales_Inquiry.cmb_Terms1.Text = myDataReader("Terms").ToString()
                SPA_Sales_Inquiry.dtp_Maturity1.Text = myDataReader("MaturityDate").ToString()
                SPA_Sales_Inquiry.cmb_TransCategory1.Text = myDataReader("trans_Category").ToString()
                SPA_Sales_Inquiry.txt_TransCode1.Text = myDataReader("trans_Code").ToString()
                SPA_Sales_Inquiry.dtp_Date1.Text = myDataReader("postingDate").ToString()
                SPA_Sales_Inquiry.txt_CustName1.Text = myDataReader("custName").ToString()
                SPA_Sales_Inquiry.txt_Address1.Text = myDataReader("custAddress").ToString()
                SPA_Sales_Inquiry.txt_SINo1.Text = myDataReader("SINo").ToString()
                SPA_Sales_Inquiry.cmb_SI_Code1.Text = myDataReader("SI_Code").ToString()
                SPA_Sales_Inquiry.txt_Note1.Text = myDataReader("Note").ToString()
                SPA_Sales_Inquiry.txt_Status1.Text = myDataReader("SaleStatus").ToString()
                SPA_Sales_Inquiry.txt_Balance1.Text = myDataReader("SalesBalance").ToString()
                SPA_Sales_Inquiry.txt_BranchCode1.Text = myDataReader("BranchCode").ToString()
                SPA_Sales_Inquiry.txt_CRNumber1.Text = myDataReader("CRNumber").ToString()
                SPA_Sales_Inquiry.txt_AmountDue1.Text = myDataReader("GrandTotal").ToString()
            End If
        End Using
    End Sub

    Sub SPA_Find_SINo_Sales_Collection()
        lv_Sales_Inquiry.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamSINo", txt_SINo.Text),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_SINo_Sales_Collection")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                SPA_Sales_Inquiry.txt_Credit.Text = myDataReader("AmountPaid").ToString()

                '-------------------------Pause-------------------'

                SPA_Sales_Inquiry.txt_Credit1.Text = myDataReader("AmountPaid").ToString()
            End If
        End Using
    End Sub

    Private Sub lv_Sales_Inquiry_DoubleClick(sender As Object, e As EventArgs) Handles lv_Sales_Inquiry.DoubleClick
        txt_SINo.Text = lv_Sales_Inquiry.SelectedItems.Item(0).SubItems(4).Text()
        SPA_Find_SINo_Sales()
        SPA_Find_SINo_Sales_Collection()
        SPA_Sales_Inquiry.lv_Ledger.Items.Clear()
        SPA_Sales_Inquiry.ShowDialog()
        Me.Close()
    End Sub
End Class