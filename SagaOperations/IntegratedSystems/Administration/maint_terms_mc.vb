Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class maint_terms_mc
    Private Sub maint_terms_mc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadmodel()
    End Sub

    Sub loadmodel()
        txt_model.Items.Clear()

        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowModelAttrib")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_model.Items.Add(myDataReader.Item("Modeldesc").ToString())
            End If
        End Using
    End Sub

    Sub mg_ShowModelcode()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamModel", txt_model.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowModelcodeAttrib")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                Label_id.Text = myDataReader("id").ToString()
            End If
        End Using
    End Sub

    Sub mg_ShowModifyTerms()
        LViewShowModel.Items.Clear()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamModelCode", Label_id.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowModifyTerms")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = LViewShowModel.Items.Add(myDataReader.Item("modelcode").ToString())
                    li.SubItems.Add(mydatareader.Item("Terms").ToString())
                    li.SubItems.Add(mydatareader.Item("Rate").ToString())
                Loop
            End If
        End Using
    End Sub

    Sub PostProductTerms()
        LViewShowModel.Items.Clear()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamModel", txt_model.Text),
            New SqlParameter("@ParamModelCode", Label_id.Text),
            New SqlParameter("@ParamTerms", txt_terms.Text),
            New SqlParameter("@ParamRate", txt_rate.Text),
            New SqlParameter("@ParamDateCreated", MainMenu.dateStatus.Caption),
            New SqlParameter("@ParamTransactedBy", MainMenu.App_User_Name.Caption)
        }

        class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "post_productTerms", "Unit Terms", txt_model.Text)
    End Sub

    Sub DELProductTerms()
        LViewShowModel.Items.Clear()

        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamModelCode", Label_id.Text),
            New SqlParameter("@ParamTerms", txt_terms.Text)
        }

        class_Database.Procedure_Execute(class_Database.ICSConnection, Parameters, "delete_productTerms", "Delete Term", True)
    End Sub

    Private Sub txt_model_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_model.TextChanged
        mg_ShowModelcode()
        mg_ShowModifyTerms()
    End Sub

    Private Sub LViewShowModel_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewShowModel.DoubleClick
        txt_terms.Text = LViewShowModel.SelectedItems.Item(0).SubItems(1).Text()
        txt_rate.Text = LViewShowModel.SelectedItems.Item(0).SubItems(2).Text()
    End Sub

    Private Sub toolpostpayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolpostpayment.Click
        PostProductTerms()
        mg_ShowModifyTerms()
        txt_terms.Text = String.Empty
        txt_rate.Text = String.Empty
    End Sub

    Private Sub informationtool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles informationtool.Click
        DELProductTerms()
        mg_ShowModifyTerms()
        txt_terms.Text = String.Empty
        txt_rate.Text = String.Empty
    End Sub

End Class