Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Public Class Customers_Information

    private sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    private sub closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub

    private sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        SaveData()
    End Sub

    Friend Function SaveData() As Boolean
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@CIFKey", CIFkey.Text),
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
            New SqlParameter("@ctc", txt_ctc.Text)
        }
        Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "mg_RegisterCIFAccount", "CIF KEY", CIFkey.Text)
    End Function

    private sub BtnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBrowse.Click
        Using opf As New OpenFileDialog
            opf.Filter = "Image Formats(*.JPG;*.GIF;*.PNG;*.JPEG)|*.jpg;*.gif;*.png;*.jpeg"
            If opf.ShowDialog = DialogResult.OK Then
                CPictureBox.Image = Image.FromFile(opf.FileName)
            End If
        End Using
    End Sub

    private sub Customers_Information_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    private sub Customers_Information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LbranchCode.Text = class_saga_variables.sbranchcode
        CGender.Items.Clear()
        CIFkeyIncrement()
        CGender.Items.Add("MALE")
        CGender.Items.Add("FEMALE")
        L_user.Visible = False
        DupdateDate.Value = Now
        DupdateDate.Visible = False
        tempbox.Visible = False
    End Sub

    private sub CIFkeyIncrement()
        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_IncrementCIFKey")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                CIFkey.Text = myDataReader("CIFKeyNew").ToString()
            End If
        End Using
    End Sub

    private sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Customers_Information_find.L_branchCode.Text = LbranchCode.Text
        Customers_Information_find.ShowDialog()
    End Sub

    private sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    End Sub

    private sub ClearItems()
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

    private sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        ClearItems()
        CIFkeyIncrement()
    End Sub

    private sub CGender_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CGender.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.KeyChar = Char.ToUpper(e.KeyChar)
        End If
    End Sub
End Class