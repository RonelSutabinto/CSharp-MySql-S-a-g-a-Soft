Imports MyClassLibrary.Classes
Imports System.Data.SqlClient

Public Class maint_item_attrib

    Private Sub maint_item_attrib_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

         loaditemattrib()
         LoadGroup()
         Loadbrand()
         loadmaker()
         loadmodel()
         loadcolor()
         loadcategory()
         loadvendor()
         LoadExport()
        Code_txtbx.Focus()
    End Sub

    Sub loaditemattrib()
        LViewItemsBrand.Items.Clear()
        mySQLConnection.Open()

        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from item_attrib order by description", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        Do While rs.Read()
            Dim li As ListViewItem = LViewItemsBrand.Items.Add(rs.Item("id").ToString())
            li.SubItems.Add(rs.Item("code").ToString())
            li.SubItems.Add(rs.Item("description").ToString())
            li.SubItems.Add(rs.Item("itemgrp").ToString())
            li.SubItems.Add(rs.Item("brand").ToString())
            li.SubItems.Add(rs.Item("make").ToString())
            li.SubItems.Add(rs.Item("model").ToString())
            li.SubItems.Add(rs.Item("year").ToString())
            li.SubItems.Add(rs.Item("color").ToString())
            li.SubItems.Add(rs.Item("whcategory").ToString())
            li.SubItems.Add(rs.Item("distributor").ToString())
            li.SubItems.Add(rs.Item("vendor").ToString())
            li.SubItems.Add(rs.Item("unitcost").ToString())
            li.SubItems.Add(rs.Item("unitprice").ToString())
            li.SubItems.Add(rs.Item("qty").ToString())
        Loop
        rs.Close()
        mySQLConnection.Close()
    End Sub

    Sub LoadExport()
        LViewItems.Items.Clear()
        mySQLConnection.Open()

        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from item_attrib", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        Do While rs.Read()
            Dim li As ListViewItem = LViewItems.Items.Add(rs.Item("model").ToString())
            li.SubItems.Add(rs.Item("code").ToString())
            li.SubItems.Add(rs.Item("description").ToString())
            li.SubItems.Add(rs.Item("make").ToString())
            li.SubItems.Add(rs.Item("brand").ToString())
            li.SubItems.Add(rs.Item("color").ToString())
        Loop
        rs.Close()
        mySQLConnection.Close()
    End Sub

    Sub LoadGroup()
        mySQLConnection.Open()
        Group_cmb.Text = String.Empty
        Group_cmb.Items.Clear()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_itemgrp", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        Do While rs.Read()
            Group_cmb.Items.Add(rs.Item("grpdesc").ToString())
        Loop
        rs.Close()
        mySQLConnection.Close()
    End Sub

    Sub Loadbrand()
        mySQLConnection.Open()
        brand_cmb.Text = String.Empty
        brand_cmb.Items.Clear()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_brand", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        Do While rs.Read()
            brand_cmb.Items.Add(rs.Item("branddesc").ToString())
        Loop
        rs.Close()
        mySQLConnection.Close()
    End Sub

    Sub loadmaker()
        mySQLConnection.Open()
        maker_cmb.Text = String.Empty
        maker_cmb.Items.Clear()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_make", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        Do While rs.Read()
            maker_cmb.Items.Add(rs.Item("makedesc").ToString())
        Loop
        rs.Close()
        mySQLConnection.Close()
    End Sub

    Sub loadmodel()
        model_cmb.Items.Clear()
        On Error GoTo out
        'Dim connection As New SqlConnection("Server= '" & My.Settings.ServerName & "'; Database = ICS; Integrated Security = true")
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowModelAttrib"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        'cmd.Parameters.AddWithValue("@ParamModel", MainMenu.statusBrCode.Caption)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        Do While rs.Read()
            model_cmb.Items.Add(rs.Item("Modeldesc").ToString())
            'MsgBox(rs.Item("Message").ToString, vbInformation, Application.CompanyName)
        Loop
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:
outs1:
    End Sub

    Sub loadcolor()
        mySQLConnection.Open()
        color_cmb.Text = String.Empty
        color_cmb.Items.Clear()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_itemcolor", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        Do While rs.Read()
            color_cmb.Items.Add(rs.Item("colordesc").ToString())
        Loop
        rs.Close()
        mySQLConnection.Close()
    End Sub

    Sub loadcategory()
        mySQLConnection.Open()
        category_cmb.Text = String.Empty
        category_cmb.Items.Clear()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_whcategory", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        Do While rs.Read()
            category_cmb.Items.Add(rs.Item("whcategorydesc").ToString())
        Loop
        rs.Close()
        mySQLConnection.Close()
    End Sub

    Sub loadvendor()
        mySQLConnection.Open()
        vendor_cmb.Text = String.Empty
        vendor_cmb.Items.Clear()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from maint_vendor", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        Do While rs.Read()
            vendor_cmb.Items.Add(rs.Item("vendordesc").ToString())
        Loop
        rs.Close()
        mySQLConnection.Close()
    End Sub

    Sub Save_Data()
        mySQLConnection.Open()
        Dim cmd As New SqlCommand
        Dim i As Integer
        With cmd
            .Connection = mySQLConnection
            .CommandText = "INSERT into item_attrib(code,description,itemgrp,brand,make,model,year,color,whcategory,distributor,vendor,unitcost,unitprice,qty) " _
                                  & "VALUES('" & Code_txtbx.Text & "','" & model_cmb.Text + " - " + color_cmb.Text & "','" & Group_cmb.Text & "','" & brand_cmb.Text & "','" & maker_cmb.Text & "','" & model_cmb.Text & "','" & date_txtbx.Text & "','" & color_cmb.Text & "','" & category_cmb.Text & "','" & distributor_cmb.Text & "','" & vendor_cmb.Text & "','" & Val(Cost_txtbx.Text) & "','" & Val(price_txtbx.Text) & "','" & quantity_txtbx.Text & "')"
            i = .ExecuteNonQuery
        End With

        MsgBox("Items Saved", vbInformation, "webSources")
         Clear_Item()

        Code_txtbx.Focus()
        mySQLConnection.Close()
         loaditemattrib()
         LoadExport()
    End Sub

    Private Sub LViewItemsBrand_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LViewItemsBrand.Click
        Code_txtbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(1).Text
        Group_cmb.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(3).Text
        brand_cmb.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(4).Text
        maker_cmb.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(5).Text
        model_cmb.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(6).Text
        date_txtbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(7).Text
        color_cmb.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(8).Text
        category_cmb.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(9).Text
        distributor_cmb.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(10).Text
        vendor_cmb.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(11).Text
        Cost_txtbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(12).Text
        price_txtbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(13).Text
        quantity_txtbx.Text = LViewItemsBrand.SelectedItems.Item(0).SubItems(14).Text
    End Sub

    Sub Clear_Item()
        Code_txtbx.Text = String.Empty
        Group_cmb.Text = String.Empty
        brand_cmb.Text = String.Empty
        maker_cmb.Text = String.Empty
        model_cmb.Text = String.Empty
        date_txtbx.Text = String.Empty
        color_cmb.Text = String.Empty
        category_cmb.Text = String.Empty
        distributor_cmb.Text = String.Empty
        vendor_cmb.Text = String.Empty
        Cost_txtbx.Text = String.Empty
        price_txtbx.Text = String.Empty
        quantity_txtbx.Text = String.Empty
    End Sub

    Sub Save_Item()
        mySQLConnection.Open()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from item_attrib where code LIKE '" & Code_txtbx.Text & "' ", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        If rs.Read = False Then
            '    'MsgBox("Code is already exist!", vbCritical, "webSources")
            '    rs.Close()
            mySQLConnection.Close()

            'Else

             Save_Data()
            mySQLConnection.Close()
        End If

    End Sub

    Private Sub newbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newbtn.Click
        Code_txtbx.Focus()
         Clear_Item()
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        If Code_txtbx.Text = String.Empty Then
            MsgBox("Code is Empty!", vbInformation, String.Empty)
            Code_txtbx.Focus()
        Else
            ' Save_Item()
             Save_Data()
        End If

    End Sub

    Private Sub CloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    Private Sub Dellete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dellete.Click
        Dim ask As MsgBoxResult

        mySQLConnection.Open()
        Dim select_cmd As New SqlClient.SqlCommand("SELECT * from item_attrib where code LIKE '" & Code_txtbx.Text & "' ", mySQLConnection)
        Dim rs As SqlDataReader = select_cmd.ExecuteReader()
        'Dim i As Integer
        If rs.Read = True Then
            rs.Close()
            mySQLConnection.Close()
            ask = MsgBox("Are you sure you want to Dellete this Data?", MsgBoxStyle.YesNo, String.Empty)
            If ask = MsgBoxResult.Yes Then
                 del_item()
            End If
            'GoTo out
        Else
            rs.Close()
            mySQLConnection.Close()
            MsgBox("Code is not exist!", vbCritical, "webSources")
        End If
    End Sub

    Sub del_item()
        mySQLConnection.Open()
        Dim cmd As New SqlCommand
        Dim i As Integer
        With cmd
            .Connection = mySQLConnection
            .CommandText = " DELETE from item_attrib where code LIKE '" & Code_txtbx.Text & "'"
            i = .ExecuteNonQuery
        End With
        mySQLConnection.Close()
         Clear_Item()
         loaditemattrib()
         LoadExport()

    End Sub

    Private Sub exportbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exportbtn.Click
        'Export the listview to an Excel spreadsheet
        Dim SaveFileDialog1 As New SaveFileDialog
        Dim formatRange As Excel.Range
        SaveFileDialog1.Title = "Save Excel File"
        'SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls|Excel Files (*.xlsx)|*.xslx"
        SaveFileDialog1.Filter = "ics files (*.ics)|*.ics"
        SaveFileDialog1.ShowDialog()
        'exit if no file selected
        If SaveFileDialog1.FileName = String.Empty Then
            Exit Sub
        End If
        'create objects to interface to Excel
        Dim xls As New Excel.Application
        Dim book As Excel.Workbook
        Dim sheet As Excel.Worksheet
        Dim temp As String

        'Dim book As Excel.Workbook = xls.ActiveWorkbook
        'Dim sheet As Excel.Worksheet = book.ActiveSheet

        'create a workbook and get reference to first worksheet
        xls.Workbooks.Add()
        book = xls.ActiveWorkbook
        sheet = book.ActiveSheet
        'step through rows and columns and copy data to worksheet
        Dim row As Integer = 1
        Dim col As Integer = 1

        For Each item As ListViewItem In LViewItems.Items
            For i As Integer = 0 To item.SubItems.Count - 1
                temp = item.SubItems(i).Text
                If temp = String.Empty Then
                    MsgBox("ok", MsgBoxStyle.OkOnly)
                End If
                formatRange = sheet.Range("a1", "b1")
                formatRange.Style.NumberFormat = "@"
                sheet.Cells(row, col) = temp

                col = col + 1
            Next
            row += 1
            col = 1
        Next
        'save the workbook and clean up
        book.SaveAs(SaveFileDialog1.FileName)
        xls.Workbooks.Close()
        xls.Quit()
        releaseObject(sheet)
        releaseObject(book)
        releaseObject(xls)
        LViewItems.Items.Clear()
        MsgBox("Items is Succesfully Save...", MsgBoxStyle.OkOnly)

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        'Release an automation object
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch Ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub model_cmb_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles model_cmb.SelectedIndexChanged

    End Sub

    Private Sub model_cmb_TabStopChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles model_cmb.TabStopChanged

    End Sub

    Private Sub model_cmb_TextChanged(sender As Object, e As System.EventArgs) Handles model_cmb.TextChanged
         mg_ShowModelcode()
    End Sub

    Sub mg_ShowModelcode()
        Code_txtbx.Text = String.Empty
        On Error GoTo out
        'Dim connection As New SqlConnection("Server= '" & My.Settings.ServerName & "'; Database = ICS; Integrated Security = true")
        Dim cmd As New SqlCommand
        Dim rs As SqlDataReader

        cmd.CommandText = "mg_ShowModelcodeAttrib"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = class_Database.mySQLConnection
        cmd.Parameters.AddWithValue("@ParamModel", model_cmb.Text)

        class_Database.OpenDB(ICSConnection)

        rs = cmd.ExecuteReader()
        ' Data is accessible through the DataReader object here.
        Do While rs.Read()
            Code_txtbx.Text = rs.Item("id").ToString()
            'MsgBox(rs.Item("Message").ToString, vbInformation, Application.CompanyName)
        Loop
        rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

out:    MsgBox(Err.Description)
        'rs.Close()
        class_Database.mySQLConnection.Close()
        GoTo outs1

outs:
outs1:
    End Sub

End Class