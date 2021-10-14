﻿Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient
Imports System.IO

Public Class Customers_Information

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        SaveData()
    End Sub

    Friend Function SaveData() As Boolean
        Dim Parameters As SqlParameter() = {New SqlParameter("@CIFKey", CIFkey.Text),
                                            New SqlParameter("@LName", CLaname.Text),
                                            New SqlParameter("@FName", CFname.Text),
                                            New SqlParameter("@MName", CMinitial.Text),
                                            New SqlParameter("@FullName", CLaname.Text & ", " & CFname.Text & " " & CMinitial.Text),
                                            New SqlParameter("@Bday", CDateofB.Value),
                                            New SqlParameter("@Gender", CGender.Text),
                                            New SqlParameter("@MStatus", Cstatus.Text),
                                            New SqlParameter("@Address", Caddress.Text),
                                            New SqlParameter("@Occupation", Coccupation.Text),
                                            New SqlParameter("@ContactNumber", Ccontact.Text),
                                            New SqlParameter("@BusinessName", Cbusiness.Text),
                                            New SqlParameter("@BusAddress", CbusinessAddress.Text),
                                            New SqlParameter("@SpouseLName", SLname.Text),
                                            New SqlParameter("@SpouseFName", SFname.Text),
                                            New SqlParameter("@SpouseMName", SMinitial.Text),
                                            New SqlParameter("@SpouseBday", Sdateofb.Value),
                                            New SqlParameter("@SpouseOccupation", SOccupation.Text),
                                            New SqlParameter("@SpouseOccupAddress", SOccupationaddress.Text),
                                            New SqlParameter("@UpdatedDate", DupdateDate.Value),
                                            New SqlParameter("@TransactedBy", class_Variables.sUserName),
                                            New SqlParameter("@BranchCode", class_Saga_Variables.sBranchCode),
                                            New SqlParameter("@ctc", txt_ctc.Text)}

        Return class_Database.Procedure_Save(class_Database.ICSConnection, Parameters, "mg_RegisterCIFAccount", "CIF KEY", CIFkey.Text)
    End Function

    Private Sub BtnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Image Formats(*.JPG;*.GIF;*.PNG;*.JPEG)|*.jpg;*.gif;*.png;*.jpeg"
        If opf.ShowDialog = DialogResult.OK Then
            CPictureBox.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub Customers_Information_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Customers_Information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LbranchCode.Text = MainMenu.statusBrCode.Caption
        CGender.Items.Clear()
        CIFkeyIncrement()
        CGender.Items.Add("MALE")
        CGender.Items.Add("FEMALE")
        L_user.Visible = False
        DupdateDate.Value = Now
        DupdateDate.Visible = False
        tempbox.Visible = False
    End Sub

    Sub CIFkeyIncrement()
        Dim Parameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_IncrementCIFKey")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                CIFkey.Text = myDataReader("CIFKeyNew").ToString()
            End If
        End Using
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Customers_Information_find.L_branchCode.Text = LbranchCode.Text
        Customers_Information_find.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    End Sub

    Sub ClearItems()
        CLaname.Text = String.Empty
        CFname.Text = String.Empty
        CMinitial.Text = String.Empty
        CGender.Text = String.Empty
        Cstatus.Text = String.Empty
        CDateofB.Text = String.Empty
        CAge.Text = String.Empty
        Caddress.Text = String.Empty
        Coccupation.Text = String.Empty
        Ccontact.Text = String.Empty
        Cbusiness.Text = String.Empty
        CbusinessAddress.Text = String.Empty
        SLname.Text = String.Empty
        SFname.Text = String.Empty
        SMinitial.Text = String.Empty
        Sdateofb.Text = String.Empty
        SOccupation.Text = String.Empty
        SOccupationaddress.Text = String.Empty
        CPictureBox.Image = tempbox.Image
        CLaname.Focus()
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        ClearItems()
        CIFkeyIncrement()
    End Sub

    Private Sub CGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CGender.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
End Class