Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_ErrorCorrect
    Sub SPA_Sales_Log()
        For x = 0 To lv_Parts.Items.Count - 1
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Paramtrans_Category", cmb_TransCategory.Text),
                New SqlParameter("@Paramtrans_Code", txt_TransCode.Text),
                New SqlParameter("@ParampostingDate", dtp_Date.Text),
                New SqlParameter("@ParamcustName", txt_CustName.Text),
                New SqlParameter("@ParamcustAddress", txt_Address.Text),
                New SqlParameter("@ParamSINo", txt_SINo.Text),
                New SqlParameter("@ParamSI_Code", cmb_SI_Code.Text),
                New SqlParameter("@ParamNote", txt_Note.Text),
                New SqlParameter("@ParamTerms", cmb_Terms.Text),
                New SqlParameter("@ParamsubTotal", lbl_Total.Text),
                New SqlParameter("@ParamtransactedBy", class_Variables.sUserName),
                New SqlParameter("@ParambranchCode", lv_Parts.Items(x).SubItems(0).Text),
                New SqlParameter("@ParamQuantity", lv_Parts.Items(x).SubItems(1).Text),
                New SqlParameter("@ParamquantityUnit", lv_Parts.Items(x).SubItems(2).Text),
                New SqlParameter("@ParamDescriptions", lv_Parts.Items(x).SubItems(3).Text),
                New SqlParameter("@ParamUnitPrice", Decimal.Parse(lv_Parts.Items(x).SubItems(4).Text)),
                New SqlParameter("@Paramprev_ID", lv_Parts.Items(x).SubItems(6).Text),
                New SqlParameter("@ParamID", lv_Parts.Items(x).SubItems(7).Text),
                New SqlParameter("@ParampartsNumber", lv_Parts.Items(x).SubItems(8).Text),
                New SqlParameter("@ParampartsName", lv_Parts.Items(x).SubItems(9).Text)
            }

            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "SPA_Sales_Log", "Error Correct")
        Next
    End Sub

    Sub Transaction_Collection_To_SPA_Inventory()
        For x = 0 To lv_Parts.Items.Count - 1
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ParambranchCode", lv_Parts.Items(x).SubItems(0).Text),
                New SqlParameter("@ParamQuantity", lv_Parts.Items(x).SubItems(1).Text),
                New SqlParameter("@Paramprev_ID", lv_Parts.Items(x).SubItems(6).Text)
            }

            class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "Transaction_Collection_To_SPA_Inventory", "Error Correct")
        Next
        MsgBox("Spare Parts Error Corrected!", vbInformation, Application.CompanyName)
    End Sub

    Sub LV_PARTS_Total()
        Dim TotalSum As Double = 0
        Dim Sum As ListViewItem

        For Each Sum In lv_Parts.Items
            TotalSum += CDbl(Sum.SubItems.Item(5).Text)
        Next
        lbl_Total.Text = CStr(TotalSum)

    End Sub

    Private Sub btn_Search_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Search.ItemClick
        lv_Parts.Items.Clear()
        SPA_Search_Sales_ErrorCorrect.Show()
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        If txt_custName1.Text = String.Empty Then
            MsgBox("Please supply Customer Name!", vbOKOnly)
        ElseIf txt_SINo1.Text = String.Empty Then
            MsgBox("Please supply SI Number", vbOKOnly)
        Else
            SPA_Sales_Log()
            Transaction_Collection_To_SPA_Inventory()
            lv_Parts.Items.Clear()
            txt_custName1.Text = String.Empty
            txt_SINo1.Text = String.Empty
            lv_Parts.Items.Clear()
        End If
    End Sub
End Class