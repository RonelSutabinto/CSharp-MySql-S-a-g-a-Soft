Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.SqlClient

Public Class Xuc_Customer_Information

    Private Sub Btn_Browse_Click(sender As Object, e As EventArgs) Handles Btn_Browse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Image Formats(*.JPG;*.GIF;*.PNG;*.JPEG)|*.jpg;*.gif;*.png;*.jpeg"
        If opf.ShowDialog = DialogResult.OK Then
            CPictureBox.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Sub CIF_Key_Increment()
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_IncrementCIFKey"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection

        class_Database.OpenDB(ICSConnection)
        rs = cmd.ExecuteReader()
        If rs.Read Then
            CIF_Key.EditValue = rs.Item("CIFKeyNew").ToString()
        End If
        class_Database.mySQLConnection.Close()
    End Sub

    Friend Function SaveData() As Boolean


        Dim Parameters As SqlParameter() = {New SqlParameter("@CIFKey", CIF_Key.EditValue),
                                            New SqlParameter("@LName", Last_Name.EditValue),
                                            New SqlParameter("@FName", First_Name.EditValue),
                                            New SqlParameter("@MName", Middle_Name.EditValue),
                                            New SqlParameter("@FullName", Last_Name.EditValue & ", " & First_Name.EditValue & " " & Middle_Name.EditValue),
                                            New SqlParameter("@Bday", Date_of_Birth.EditValue),
                                            New SqlParameter("@Gender", Gender.EditValue),
                                            New SqlParameter("@MStatus", Civil_Status.EditValue),
                                            New SqlParameter("@Address", Address.EditValue),
                                            New SqlParameter("@Occupation", Occupation.EditValue),
                                            New SqlParameter("@ContactNumber", Contact_Number.EditValue),
                                            New SqlParameter("@BusinessName", Business_Name.EditValue),
                                            New SqlParameter("@BusAddress", Business_Address.EditValue),
                                            New SqlParameter("@SpouseLName", Spouse_Last_Name.EditValue),
                                            New SqlParameter("@SpouseFName", Spouse_First_Name.EditValue),
                                            New SqlParameter("@SpouseMName", Spouse_Middle_Name.EditValue),
                                            New SqlParameter("@SpouseBday", Spouse_Date_of_Birth.EditValue),
                                            New SqlParameter("@SpouseOccupation", Spouse_Occupation.EditValue),
                                            New SqlParameter("@SpouseOccupAddress", Spouse_Occupation_Address.EditValue),
                                            New SqlParameter("@UpdatedDate", Date.Today()),
                                            New SqlParameter("@TransactedBy", class_Variables.sUserName),
                                            New SqlParameter("@BranchCode", class_Saga_Variables.sBranchCode),
                                            New SqlParameter("@ctc", Cedula_Number.EditValue)}

        Return class_Database.Procedure_Save(class_Database.ICSConnection, "CIF KEY", "mg_RegisterCIFAccount", Parameters, CIF_Key.EditValue)
    End Function

End Class