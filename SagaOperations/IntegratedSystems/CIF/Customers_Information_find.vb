Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Modules
Imports System.Data.SqlClient

Public Class Customers_Information_find

    'Private Sub closebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebtn.Click
    '    Me.Close()
    '    Customers_Information.Visible = True
    'End Sub

    'Private Sub Customers_Information_find_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
    '    If e.KeyCode = Keys.Escape Then Me.Close()
    'End Sub
    'Private Sub Customers_Information_find_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Timer1.Start()
    'End Sub
    'Sub loadCIF()
    '    LViewItems.Items.Clear()
    '    'class_Database.mySQLConnection.Open()

    '    Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT CIFKey,FullName,Bday,Gender from CIFAccounts WHERE branchcode LIKE '" & MainMenu.statusBrCode.Caption & "' ORDER BY fullname")
    '    'Dim rs As SqlDataReader = select_cmd.ExecuteReader()
    '    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then Do While myDataReader.Read()
    '        Dim li As ListViewItem = LViewItems.Items.Add(mydatareader.Item("CIFKey").ToString())
    '        li.SubItems.Add(mydatareader.Item("FullName").ToString())
    '        li.SubItems.Add(mydatareader.Item("Bday").ToString())
    '        li.SubItems.Add(mydatareader.Item("Gender").ToString())
    '    
    '    End Using
    '    'class_Database.mySQLConnection.Close()
    'End Sub
    'Private Sub LViewItems_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    txtSearch.Text = LViewItems.SelectedItems.Item(0).SubItems(1).Text
    'End Sub

    'Private Sub LViewItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    LoadItemtoCIF()
    '    Me.Close()
    'End Sub

    'Sub LoadItemtoCIF()
    '    Dim tempcif As String = LViewItems.SelectedItems.Item(0).SubItems(0).Text

    '    Dim command As New SqlCommand("SELECT * FROM CIFAccounts WHERE CIFKey = @id")
    '    command.Parameters.Add("@id", SqlDbType.VarChar).Value = tempcif

    '    Dim table As New DataTable

    '    Dim adapter As New SqlDataAdapter(command)

    '    adapter.Fill(table)

    '    Dim curTime As DateTime = DateTime.Now
    '    Dim birthDate As Date = LViewItems.SelectedItems.Item(0).SubItems(2).Text
    '    Dim elapsed As TimeSpan
    '    elapsed = curTime - birthDate
    '    Customers_Information.CAge.Text = Int(elapsed.Days / 365.25)

    '    Dim tempName As String = table.Rows(0)(1).ToString()

    '    If tempName = String.Empty Then

    '        Dim FullName As String = table.Rows(0)(4).ToString()
    '        Dim LastName As String = FullName.Split(",")(0)
    '        Dim FirstName As String = FullName.Split(",")(1)
    '        FirstName = FirstName.Split("")(1)
    '        Dim MiddleName As String = FullName.Split(",")(1)
    '        MiddleName = MiddleName.Split("")(2)
    '        Customers_Information.CLaname.Text = LastName
    '        Customers_Information.CFname.Text = FirstName
    '        Customers_Information.CMinitial.Text = MiddleName
    '    Else
    '        Customers_Information.CLaname.Text = table.Rows(0)(1).ToString()
    '        Customers_Information.CFname.Text = table.Rows(0)(2).ToString()
    '        Customers_Information.CMinitial.Text = table.Rows(0)(3).ToString()
    '    End If

    '    Customers_Information.CIFkey.Text = table.Rows(0)(0).ToString()

    '    Customers_Information.CDateofB.Text = LViewItems.SelectedItems.Item(0).SubItems(2).Text
    '    Customers_Information.CGender.Text = table.Rows(0)(6).ToString()
    '    Customers_Information.Cstatus.Text = table.Rows(0)(7).ToString()
    '    Customers_Information.Caddress.Text = table.Rows(0)(8).ToString()
    '    Customers_Information.Coccupation.Text = table.Rows(0)(9).ToString()
    '    Customers_Information.Ccontact.Text = table.Rows(0)(10).ToString()
    '    Customers_Information.Cbusiness.Text = table.Rows(0)(11).ToString()
    '    Customers_Information.CbusinessAddress.Text = table.Rows(0)(12).ToString()
    '    Customers_Information.SLname.Text = table.Rows(0)(13).ToString()
    '    Customers_Information.SFname.Text = table.Rows(0)(14).ToString()
    '    Customers_Information.SMinitial.Text = table.Rows(0)(15).ToString()
    '    Customers_Information.Sdateofb.Text = table.Rows(0)(16).ToString()
    '    Customers_Information.SOccupation.Text = table.Rows(0)(17).ToString()
    '    Customers_Information.SOccupationaddress.Text = table.Rows(0)(18).ToString()
    '    Customers_Information.txt_ctc.Text = table.Rows(0)(24).ToString()

    'End Sub

    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    Label3.Text = TimeOfDay.ToString("h:mm:ss tt")
    'End Sub

    'Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress

    '    Dim tmp As System.Windows.Forms.KeyPressEventArgs = e
    '    If tmp.KeyChar = ChrW(Keys.Enter) Then
    '        CIFsearch()
    '    End If
    'End Sub
    Sub Data_Load()
        Dim Parameters As SqlParameter()
        Try
            Parameters = {New SqlParameter("@Branch_Code", class_Saga_Variables.sBranchCode),
                New SqlParameter("@Quick_Search", txtSearch.Text)}
            class_Database.Procedure_Retrieve(class_Database.ICSConnection, GridControl, GridView, "so_Find_Customer_Information", Parameters, "CIFACCOUNTS")
        Catch Ex As Exception
            
        End Try
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            Data_Load()
        End If
    End Sub

    'Sub CIFsearch()
    '    LViewItems.Items.Clear()
    '    'class_Database.mySQLConnection.Open()
    '    Dim dt As String
    '    Using myDataReader As SqlDataReader = class_Database.SetSqlDataReader(class_Database.ICSConnection, "SELECT * FROM CIFAccounts WHERE FullName LIKE '%" & txtSearch.Text & "%' ORDER BY FullName")
    '    'Dim rs As SqlDataReader = select_cmd.ExecuteReader()
    '    If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then Do While myDataReader.Read()
    '        Dim li As ListViewItem = LViewItems.Items.Add(mydatareader.Item("CIFKey").ToString())
    '        li.SubItems.Add(mydatareader.Item("FullName").ToString())
    '        dt = Format(CDate(mydatareader.Item("Bday").ToString()), "yyyy-MM-dd")
    '        li.SubItems.Add(dt)
    '        li.SubItems.Add(mydatareader.Item("Gender").ToString())
    '    
    '    End Using
    '    'class_Database.mySQLConnection.Close()
    'End Sub

    'Sub Search_CIF()
    '    LViewItems.Items.Clear()
    'End Sub

    'Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    'End Sub

    'Private Sub LViewItems_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    'End Sub

End Class