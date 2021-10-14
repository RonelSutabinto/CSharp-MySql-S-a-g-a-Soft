Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Search_Sales_ErrorCorrect

    Sub SPA_Show_Sales_Inquiry()
        lv_Sales_ErrorCorrect.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ParamCustName", txt_Search.Text),
            New SqlParameter("@ParamPostingDate", dtp_Date.Value)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.spaSQLConnection, Parameters, "SPA_Show_Sales_ErrorCorrect")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_Sales_ErrorCorrect.Items.Add(myDataReader.Item("branchCode").ToString())
                    li.SubItems.Add(mydatareader.Item("custCode").ToString())
                    li.SubItems.Add(mydatareader.Item("custName").ToString())
                    li.SubItems.Add(mydatareader.Item("custAddress").ToString())
                    li.SubItems.Add(mydatareader.Item("SINo").ToString())
                    li.SubItems.Add(mydatareader.Item("PostingDate").ToString())
                    li.SubItems.Add(mydatareader.Item("ErrorCorrectTag").ToString())
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
        lv_Sales_ErrorCorrect.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamSINo", txt_SINo.Text),
            New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.spaSQLConnection, Parameters, "SPA_Find_SINo_Sales")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = SPA_ErrorCorrect.lv_Parts.Items.Add(myDataReader.Item("branchCode").ToString())
                    li.SubItems.Add(mydatareader.Item("Quantity").ToString())
                    li.SubItems.Add(mydatareader.Item("quantityUnit").ToString())
                    li.SubItems.Add(mydatareader.Item("Descriptions").ToString())
                    li.SubItems.Add(mydatareader.Item("UnitPrice").ToString())
                    li.SubItems.Add(mydatareader.Item("subTotal").ToString())
                    li.SubItems.Add(mydatareader.Item("prev_ID").ToString())
                    li.SubItems.Add(mydatareader.Item("ID").ToString())
                    li.SubItems.Add(mydatareader.Item("partsNumber").ToString())
                    li.SubItems.Add(mydatareader.Item("partsName").ToString())
                    li.SubItems.Add(mydatareader.Item("SubTotal").ToString())

                    SPA_ErrorCorrect.cmb_TransCategory.Text = myDataReader("trans_Category").ToString()
                    SPA_ErrorCorrect.txt_TransCode.Text = myDataReader("trans_Code").ToString()
                    SPA_ErrorCorrect.dtp_Date.Text = myDataReader("postingDate").ToString()
                    SPA_ErrorCorrect.txt_CustName.Text = myDataReader("custName").ToString()
                    SPA_ErrorCorrect.txt_custName1.Text = myDataReader("custName").ToString()
                    SPA_ErrorCorrect.txt_Address.Text = myDataReader("custAddress").ToString()
                    SPA_ErrorCorrect.txt_SINo.Text = myDataReader("SINo").ToString()
                    SPA_ErrorCorrect.txt_SINo1.Text = myDataReader("SINo").ToString()
                    SPA_ErrorCorrect.cmb_SI_Code.Text = myDataReader("SI_Code").ToString()
                    SPA_ErrorCorrect.txt_Note.Text = myDataReader("Note").ToString()
                    SPA_ErrorCorrect.txt_partsNumber.Text = myDataReader("partsNumber").ToString()
                    SPA_ErrorCorrect.txt_partsName.Text = myDataReader("partsName").ToString()
                Loop
            End If
        End Using
    End Sub

    Private Sub lv_Sales_ErrorCorrect_DoubleClick(sender As Object, e As EventArgs) Handles lv_Sales_ErrorCorrect.DoubleClick
        txt_SINo.Text = lv_Sales_ErrorCorrect.SelectedItems.Item(0).SubItems(4).Text()
        SPA_Find_SINo_Sales()
        SPA_ErrorCorrect.LV_PARTS_Total()
        SPA_ErrorCorrect.Show()
        Me.Close()
    End Sub

End Class