Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class SPA_AddCIF
    Sub SPA_RegistertoCIF()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@CIFKey", txt_AccNo.Text),
            New SqlParameter("@LName", txt_LName.Text),
            New SqlParameter("@FName", txt_FName.Text),
            New SqlParameter("@MName", txt_MName.Text),
            New SqlParameter("@FullName", txt_LName.Text & ", " & txt_FName.Text & " " & txt_MName.Text),
            New SqlParameter("@Bday", dtp_DBirth.Text),
            New SqlParameter("@Gender", cmb_Gender.Text),
            New SqlParameter("@MStatus", cmb_Status.Text),
            New SqlParameter("@Address", txt_Address.Text),
            New SqlParameter("@Occupation", txt_Occupation.Text),
            New SqlParameter("@ContactNumber", txt_Contact.Text),
            New SqlParameter("@BusinessName", txt_business.Text),
            New SqlParameter("@BusAddress", txt_bAddress.Text),
            New SqlParameter("@SpouseLName", txt_WifeLName.Text),
            New SqlParameter("@SpouseFName", txt_WifeFName.Text),
            New SqlParameter("@SpouseMName", txt_WifeMName.Text),
            New SqlParameter("@SpouseBday", dtp_WifeDBirth.Text),
            New SqlParameter("@SpouseOccupation", txt_WifeOccupation.Text),
            New SqlParameter("@SpouseOccupAddress", txt_WifeOccuAddress.Text),
            New SqlParameter("@UpdatedDate", MainMenu.dateStatus.Caption),
            New SqlParameter("@TransactedBy", MainMenu.App_User_Name.Caption),
            New SqlParameter("@BranchCode", MainMenu.statusBrCode.Caption),
            New SqlParameter("@ctc", txt_CTC.Text)
        }

        class_Database.Procedure_Save(class_Database.SPAConnection, Parameters, "SPA_RegistertoCIF", "Customer Information", txt_AccNo.Text)
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SPA_RegistertoCIF()
        Me.Close()
        SPA_Sales.txt_CustName.Text = txt_LName.Text & ", " & txt_FName.Text & " " & txt_MName.Text
        SPA_Sales.txt_Address.Text = txt_Address.Text
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class