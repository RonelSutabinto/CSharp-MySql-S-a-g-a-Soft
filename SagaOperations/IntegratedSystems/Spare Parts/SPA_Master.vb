Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_Master
    Sub mg_Show_Spare_Parts_PO()
        lv_Parts.Items.Clear()

        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamQuickSearch", txt_Search.EditValue)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Show_master")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = lv_Parts.Items.Add(myDataReader.Item("partsNumber").ToString())
                    li.SubItems.Add(myDataReader.Item("partsName").ToString())
                    li.SubItems.Add(myDataReader.Item("SuperCeeding").ToString())
                    li.SubItems.Add(myDataReader.Item("brand").ToString())
                    li.SubItems.Add(myDataReader.Item("srp").ToString())
                    li.SubItems.Add(myDataReader.Item("ID").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub SPA_Find_SpareParts_Master_ID()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamID", txt_ID.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_Find_SpareParts_Master_ID")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_ID.Text = myDataReader("ID").ToString()
                txt_Branch.Text = myDataReader("BranchCode").ToString()
                txt_PartsNumber.Text = myDataReader("PartsNumber").ToString()
                txt_PartsName.Text = myDataReader("PartsName").ToString()
                cmb_Brand.Text = myDataReader("Brand").ToString()
                txt_ModelCode.Text = myDataReader("ModelCode").ToString()
                txt_ModelName.Text = myDataReader("ModelName").ToString()
                txt_Note.Text = myDataReader("Note").ToString()
                txt_Remarks.Text = myDataReader("Remarks").ToString()
                dtp_PostingDate.Text = myDataReader("PostingDate").ToString()
                txt_Quantity.Text = myDataReader("Quantity").ToString()
                txt_Transactedby.Text = myDataReader("Transactedby").ToString()
                dtp_TransactionDate.Text = myDataReader("TransactionDate").ToString()
                txt_SRP.Text = myDataReader("SRP").ToString()
                txt_DiscountPCT.Text = myDataReader("DiscountPCT").ToString()
                txt_DiscountAMT.Text = myDataReader("DiscountAMT").ToString()
                txt_PriceWOVAT.Text = myDataReader("PriceWOVAT").ToString()
                txt_PriceWVAT.Text = myDataReader("PriceWVAT").ToString()
                txt_SuperSeed.Text = myDataReader("SuperCeeding").ToString()
            End If
        End Using
    End Sub

    Private Sub btn_Find_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Find.ItemClick
        mg_Show_Spare_Parts_PO()
    End Sub

    Private Sub txt_ID_EditValueChanged(sender As Object, e As EventArgs) Handles txt_ID.EditValueChanged
        SPA_Find_SpareParts_Master_ID()
    End Sub

    Private Sub lv_Parts_DoubleClick(sender As Object, e As EventArgs) Handles lv_Parts.DoubleClick
        txt_ID.Text = lv_Parts.SelectedItems.Item(0).SubItems(5).Text()
    End Sub

    Sub SPA_BrandParameter()
        cmb_Brand.Properties.Items.Clear()

        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.SPAConnection, Parameters, "SPA_BrandParameter")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    cmb_Brand.Properties.Items.Add(myDataReader.Item("branddesc").ToString)
                Loop
            End If
        End Using
    End Sub

    Private Sub SPA_Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPA_BrandParameter()
    End Sub

    Sub SPA_Inventory_Register_SpareParts_Master()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_Branch.Text),
            New SqlParameter("@ParamPartsNumber", txt_PartsNumber.Text),
            New SqlParameter("@ParamPartsName", txt_PartsName.Text),
            New SqlParameter("@ParamBrand", cmb_Brand.Text),
            New SqlParameter("@ParamModelCode", txt_ModelCode.Text),
            New SqlParameter("@ParamModelName", txt_ModelName.Text),
            New SqlParameter("@ParamNote", txt_Note.Text),
            New SqlParameter("@ParamRemarks", txt_Remarks.Text),
            New SqlParameter("@ParamPostingDate", dtp_PostingDate.Text),
            New SqlParameter("@ParamQuantity", txt_Quantity.Text),
            New SqlParameter("@ParamPriceWVAT", txt_PriceWVAT.Text),
            New SqlParameter("@ParamPriceWOVAT", txt_PriceWOVAT.Text),
            New SqlParameter("@ParamTransactedby", txt_Transactedby.Text),
            New SqlParameter("@ParamTransactionDate", dtp_TransactionDate.Text),
            New SqlParameter("@ParamSRP", txt_SRP.Text),
            New SqlParameter("@ParamDiscountPCT", txt_DiscountPCT.Text),
            New SqlParameter("@ParamDiscountAMT", txt_DiscountAMT.Text),
            New SqlParameter("@ParamSuperCeed", txt_SuperSeed.Text)
        }

        class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "SPA_Inventory_Register_SpareParts_Master", "SPA Profile")
    End Sub

    Sub SPA_Inventory_DELETE_SpareParts_Master()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamID", txt_ID.Text),
            New SqlParameter("@ParamPartsNumber", txt_PartsNumber.Text),
            New SqlParameter("@ParamPartsName", txt_PartsName.Text)
        }

        class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "SPA_Inventory_DELETE_SpareParts_Master", "SPA Delete")
    End Sub

    Private Sub btn_Add_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Add.ItemClick
        SPA_Inventory_Register_SpareParts_Master()
        mg_Show_Spare_Parts_PO()
    End Sub

    Private Sub btn_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
        SPA_Inventory_DELETE_SpareParts_Master()
        mg_Show_Spare_Parts_PO()
    End Sub

End Class