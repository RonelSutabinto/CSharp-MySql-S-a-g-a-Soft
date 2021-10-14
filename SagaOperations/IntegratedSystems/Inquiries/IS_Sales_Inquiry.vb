Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DevExpress.XtraReports.UI
Imports MyClassLibrary.Classes
Imports System.Data.SqlClient
Imports System.IO
Imports wSClassLib.myModules

Public Class IS_Sales_Inquiry
    Dim Crystal_ReportShowSI As New ReportDocument

    Private Sub IS_Sales_Inquiry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
        If e.KeyCode = Keys.I AndAlso e.Modifiers = Keys.Control Then
            IS_Sales_ReleaseAccount_List.Text = "RELEASE"
            IS_Sales_ReleaseAccount_List.ShowDialog()
        End If
    End Sub

    Private Sub IS_Sales_Inquiry_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Me.Text = "LEDGER INQUIRY" Then

        ElseIf Me.Text = "INQUIRY" Then
            IS_Sales_ReleaseAccount_List.Text = "RELEASE"
            IS_Sales_ReleaseAccount_List.ShowDialog()
        End If
    End Sub

    Sub mg_ShowReleasedAccounts()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamBranchCode", MainMenu.statusBrCode.Caption)}

        IS_Sales_ReleaseAccount_List.LViewList.Items.Clear()
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowReleasedAccounts")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                Do While myDataReader.Read()
                    Dim li As ListViewItem = IS_Sales_ReleaseAccount_List.LViewList.Items.Add(myDataReader.Item("AccountNumber"))
                    li.SubItems.Add(myDataReader.Item("AccountName").ToString())
                    li.SubItems.Add(myDataReader.Item("DateGranted"))
                Loop
            End If
        End Using
    End Sub

    Private Sub cmb_ledger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        IS_Inquiry_CustLedger.Text = txt_cust.Text & " - " & txt_AccountNumber.Text

        IS_Inquiry_CustLedger.Show()
    End Sub

    Private Sub txt_accountStatus_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_accountStatus.TextChanged

    End Sub

    Sub ShowVATSI()
        Dim Parameters As SqlParameter() = {
            New SqlParameter("@ParamBranchCode", txt_brCode.Text),
            New SqlParameter("@ParamAccountNumber", txt_AccountNumber.Text),
            New SqlParameter("@ParamLedgerSetNumber", txt_LedSet.Text),
            New SqlParameter("@ParamRefNo", txt_orno.Text)
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_ShowVatSI")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                txt_totalamtpaid.Text = Format(myDataReader.Item("UnitPrice"), "#,##0.00")
                txt_vatamt.Text = Format(myDataReader.Item("vat"), "#,##0.00")
                txt_amtnetofvat.Text = Format(myDataReader.Item("netvat"), "#,##0.00")
            End If
        End Using
    End Sub

    Private Sub cmd_showSI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_showSI.Click
        If cmb_SalesType.Text = "FIN" Then
            txt_NetAmtFinanced.Text = txt_LCP.Text
            txt_vatablesales.Text = txt_LCP.Text
            txt_totalsalesvat.Text = txt_LCP.Text
            txt_amtdue.Text = txt_LCP.Text
            txt_NetDiscount.Text = "0"
            txt_numtoword.Text = AmountInWords(txt_LCP.Text)

        ElseIf cmb_SalesType.Text = "COD" Or cmb_SalesType.Text = "ECOD" Or cmb_SalesType.Text = "TCOD" Then
            txt_NetAmtFinanced.Text = txt_COD.Text
            txt_vatablesales.Text = txt_COD.Text
            txt_totalsalesvat.Text = txt_COD.Text
            txt_amtdue.Text = txt_COD.Text
            txt_NetDiscount.Text = txt_SalesDisc.Text
            txt_numtoword.Text = AmountInWords(txt_NetAmtFinanced.Text)
        End If

        ShowVATSI()

        With PrintDocument1
            .DefaultPageSettings.Landscape = False
        End With
        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        With PrintPreviewDialog1
            .PrintPreviewControl.Width = FormWindowState.Maximized
            .PrintPreviewControl.Zoom = 1.5
            .ShowDialog()
        End With

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim TitleFont As New Font("calibri", 10, FontStyle.Bold)
        Dim BodyFont As New Font("calibri", 10, FontStyle.Regular)
        Dim BodyFont2 As New Font("calibri", 10)
        Dim BodyFontAMT As New Font("calibri", 10, FontStyle.Regular, Alignment.RightAlign)
        Dim format As New StringFormat(StringFormatFlags.DirectionRightToLeft)

        Dim FirstColAmt As Integer = 200
        Dim SecondColAmt As Integer = 410
        Dim H As Integer = 0
        H = 45
        e.Graphics.DrawString(dategranted.Text, BodyFont, Brushes.Black, 340, H)
        H += 25 '90
        e.Graphics.DrawString(txt_cust.Text, TitleFont, Brushes.Black, 100, H)
        H += 40 '130
        e.Graphics.DrawString(txt_address.Text, BodyFont, Brushes.Black, 100, H)
        H += 10 '140
        e.Graphics.DrawString(txt_NetAmtFinanced.Text, BodyFont2, Brushes.Black, 30, H)
        e.Graphics.DrawString(txt_numtoword.Text, BodyFont2, Brushes.Black, 150, H)
        H += 25 '165
        e.Graphics.DrawString("MODEL: ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_model.Text, BodyFont, Brushes.Black, 160, H)
        H += 20 '
        e.Graphics.DrawString("Engine No ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_engineNo.Text, BodyFontAMT, Brushes.Black, 160, H)
        H += 20 '
        e.Graphics.DrawString("Chassis No", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_chassisNo.Text, BodyFontAMT, Brushes.Black, 160, H)
        H += 20 '
        e.Graphics.DrawString("Color ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_color.Text, BodyFontAMT, Brushes.Black, 160, H)
        H += 20 '
        e.Graphics.DrawString("VATABLE SALES ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_vatablesales.Text, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("TOTAL SALES VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(txt_totalsalesvat.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("VAT EXEMPT SALES ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("LESS VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(txt_vatamt.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("ZERO RATED SALES ", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("AMT NET OF VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(txt_amtnetofvat.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)

        H += 20 '
        e.Graphics.DrawString("VAT AMT", BodyFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(txt_lessvat.Text, BodyFontAMT, Brushes.Black, FirstColAmt, H, format)
        e.Graphics.DrawString("Less: Discount ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(txt_NetDiscount.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)
        H += 20 '
        e.Graphics.DrawString("Amount Due ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, SecondColAmt, H, format)

        H += 20 '
        e.Graphics.DrawString("Add VAT ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString("0.00", BodyFontAMT, Brushes.Black, SecondColAmt, H, format)

        H += 20 '
        e.Graphics.DrawString("Total Amt Due ", BodyFont, Brushes.Black, 220, H)
        e.Graphics.DrawString(txt_amtdue.Text, BodyFontAMT, Brushes.Black, SecondColAmt, H, format)

        H += 40 '
        e.Graphics.DrawString("Printed by: ", TitleFont, Brushes.Black, 22, H)
        e.Graphics.DrawString(MainMenu.App_Full_Name.Caption, TitleFont, Brushes.Black, 90, H)
        e.Graphics.DrawString("Printed Date: ", TitleFont, Brushes.Black, 260, H)
        e.Graphics.DrawString(MainMenu.dateStatus.Caption, TitleFont, Brushes.Black, 340, H)
    End Sub

    Private Sub PrintCoOwn_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintCoOwn.PrintPage

        Dim TitleFont As New Font("Arial", 16, FontStyle.Bold)
        Dim BodyFont As New Font("Arial", 12, FontStyle.Regular)
        Dim FooterFont As New Font("Arial", 9, FontStyle.Regular)

        Dim FooterFontRight As New Font("Arial", 9, FontStyle.Regular, Alignment.RightAlign)

        Dim TopHeader As New Font("Arial", 12, FontStyle.Bold)

        Dim HeaderFont As New Font("Monotype Corsiva", 40, FontStyle.Regular)

        ' Create font and brush.
        Dim drawBrush As New SolidBrush(Color.Black)

        ' Create rectangle for drawing.
        Dim x As Single = 1
        Dim y As Integer = 100
        Dim width As Single = 850
        Dim height As Single = 1000
        Dim drawRect As New RectangleF(x, y, width, height)
        Dim BodyFontAMT As New Font("calibri", 14, FontStyle.Regular, Alignment.RightAlign)
        ' Draw rectangle to screen.
        'Dim blackPen As New Pen(Color.Black)
        'e.Graphics.DrawRectangle(blackPen, x, y, width, height)

        ' Set format of string.
        Dim drawFormat As New StringFormat
        drawFormat.Alignment = StringAlignment.Center

        e.Graphics.DrawString("SAGA MOTORS CORPORATION", TopHeader, Brushes.Black, drawRect, drawFormat)
        y += 20
        Dim drawRect2 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString(branchName.Text, TopHeader, Brushes.Black, drawRect2, drawFormat)
        y += 20
        Dim drawRect3 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString(branchAddress.Text, TopHeader, Brushes.Black, drawRect3, drawFormat)

        y += 30
        Dim drawRect4 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString("present this", BodyFont, Brushes.Black, drawRect4, drawFormat)

        y += 50
        Dim drawRect5 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString("CERTIFICATE OF OWNERSHIP", HeaderFont, Brushes.Black, drawRect5, drawFormat)

        y += 80
        Dim drawRect6 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString("to", BodyFont, Brushes.Black, drawRect6, drawFormat)

        y += 40
        Dim drawRect7 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString(txt_cust.Text, TitleFont, Brushes.Black, drawRect7, drawFormat)

        y += 20
        Dim drawRect8 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString(txt_address.Text, BodyFont, Brushes.Black, drawRect8, drawFormat)

        y += 40
        Dim drawRect9 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString("for having purchased the following", BodyFont, Brushes.Black, drawRect9, drawFormat)

        y += 40
        Dim drawRect10 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString("BRAND: ", BodyFontAMT, Brushes.Black, 200, y)
        e.Graphics.DrawString(txt_brand.Text, BodyFontAMT, Brushes.Black, 400, y)

        y += 40
        Dim drawRect11 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString("MODEL: ", BodyFontAMT, Brushes.Black, 200, y)
        e.Graphics.DrawString(txt_model.Text, BodyFontAMT, Brushes.Black, 400, y)

        y += 40
        Dim drawRect12 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString("KEY No. :", BodyFontAMT, Brushes.Black, 200, y)
        e.Graphics.DrawString(txt_keynumber.Text, BodyFontAMT, Brushes.Black, 400, y)

        y += 40
        Dim drawRect13 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString("ENGINE No. : ", BodyFontAMT, Brushes.Black, 200, y)
        e.Graphics.DrawString(txt_engineNo.Text, BodyFontAMT, Brushes.Black, 400, y)

        y += 40
        Dim drawRect14 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString("CHASSIS No.:", BodyFontAMT, Brushes.Black, 200, y)
        e.Graphics.DrawString(txt_chassisNo.Text, BodyFontAMT, Brushes.Black, 400, y)

        y += 40
        Dim drawRect15 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString("DATE FULLY PAID :  " & txt_lstmvmtdate.Text, BodyFont, Brushes.Black, drawRect15, drawFormat)

        y += 150
        Dim drawRect16 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString(txt_BM.Text, BodyFont, Brushes.Black, drawRect16, drawFormat)

        y += 20
        Dim drawRect17 As New RectangleF(x, y, width, height)
        e.Graphics.DrawString("BRANCH MANAGER", BodyFont, Brushes.Black, drawRect17, drawFormat)

        y += 50
        e.Graphics.DrawString("Printed by: " & MainMenu.App_Full_Name.Caption, FooterFont, Brushes.Black, 100, y)
        e.Graphics.DrawString("Printed date:  " & Now, FooterFontRight, Brushes.Black, 600, y)

    End Sub

    Private Sub cmd_ShowCR_Click(sender As Object, e As EventArgs) Handles cmd_ShowCR.Click
        With PrintCR
            .DefaultPageSettings.Landscape = False
        End With

        DirectCast(PrintPreviewCR, Form).WindowState = FormWindowState.Maximized
        With PrintPreviewCR
            .PrintPreviewControl.Width = FormWindowState.Maximized
            .PrintPreviewControl.Zoom = "1.0"
            .ShowDialog()
        End With

    End Sub

    Private Sub PrintCR_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintCR.PrintPage
        Dim TitleFont As New Font("calibri", 10, FontStyle.Bold)
        Dim BodyFont As New Font("calibri", 10, FontStyle.Regular)
        Dim NameFont As New Font("calibri", 12, FontStyle.Regular)
        Dim BodyFont2 As New Font("calibri", 14, FontStyle.Bold)
        Dim format As New StringFormat(StringFormatFlags.DirectionRightToLeft)

        Dim FirstColAmt As Integer = 200
        Dim SecondColAmt As Integer = 410
        Dim H As Integer = 0
        H = 50
        'e.Graphics.DrawString("Full Feb. 2500 Full march 2500 Full April 2500 Full may 2500 Par. June 250", BodyFont, Brushes.Black, New Rectangle(15, H, e.Graphics.VisibleClipBounds.Width - 610, e.Graphics.VisibleClipBounds.Height - 140))
        e.Graphics.DrawString("D/P", NameFont, Brushes.Black, 35, H)
        e.Graphics.DrawString(txt_NetDP.Text, NameFont, Brushes.Black, 115, H)
        H += 55

        e.Graphics.DrawString(dategranted.Text, NameFont, Brushes.Black, 520, H)
        H += 25

        e.Graphics.DrawString(txt_cust.Text, NameFont, Brushes.Black, 300, H)
        H += 25

        e.Graphics.DrawString(txt_address.Text, BodyFont, Brushes.Black, 300, H)
        H += 25

        e.Graphics.DrawString(txt_Num2WordsDP.Text, BodyFont, Brushes.Black, 300, H)
        H += 15

        e.Graphics.DrawString(txt_NetDP.Text, NameFont, Brushes.Black, 115, H)
        H += 25

        e.Graphics.DrawString(txt_NetDP.Text, BodyFont2, Brushes.Black, 235, H)
        H += 73

        e.Graphics.DrawString(txt_NetDP.Text, BodyFont2, Brushes.Black, 115, H)
        H += 25

    End Sub

    Private Sub SearchEngine_Click(sender As Object, e As EventArgs) Handles SearchEngine.Click
        Dim SearchText As String
        SearchText = txt_engineNo.Text
        IS_Sales_ReleaseAccount_List.Text = "SEARCH DETAILS"
        IS_Sales_ReleaseAccount_List.SearchByEC.Text = SearchText

        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Private Sub SearchChassis_Click(sender As Object, e As EventArgs) Handles SearchChassis.Click
        Dim SearchText As String
        SearchText = txt_chassisNo.Text
        IS_Sales_ReleaseAccount_List.Text = "SEARCH DETAILS"
        IS_Sales_ReleaseAccount_List.SearchByEC.Text = SearchText

        IS_Sales_ReleaseAccount_List.ShowDialog()
    End Sub

    Private Sub txt_SalesDisc_TextChanged(sender As Object, e As EventArgs) Handles txt_SalesDisc.TextChanged
        txt_NetDP.Text = Val(txt_DP.Text) - Val(txt_SalesDisc.Text)
    End Sub

    Private Sub txt_NetDP_TextChanged(sender As Object, e As EventArgs) Handles txt_NetDP.TextChanged
        txt_Num2WordsDP.Text = AmountInWords(txt_NetDP.Text)
    End Sub

    Private Sub LViewLedgerPrin_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            '  MsgBox(LViewLedgerPrin.SelectedItems.Item(0).SubItems(2).Text)
        End If
    End Sub

    Private Sub SearchAcct_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        IS_Sales_ReleaseAccount_List.Text = "RELEASE"
        IS_Sales_ReleaseAccount_List.Visible = True
    End Sub

    Private Sub PrintCertOfOwn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles PrintCertOfOwn.ItemClick
        With PrintCoOwn
            .DefaultPageSettings.Landscape = False
        End With

        DirectCast(PrintPrevPrintCoOwn, Form).WindowState = FormWindowState.Maximized
        With PrintPrevPrintCoOwn

            .PrintPreviewControl.Width = FormWindowState.Maximized

            .PrintPreviewControl.AutoZoom = True

            .ShowDialog()
        End With
    End Sub

    Private Sub FreebieList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles FreebieList.ItemClick
        'GridControl.ShowRibbonPrintPreview()
        ' Create a report instance.
        Dim report As New PortraitBlank()

        GViewSimple.SelectAll()
        report.PrintableComponentContainer1.PrintableComponent = GCFreebiePrint
        'Obtain a parameter And set its value.
        report.Parameters("BranchName").Value = branchName.Text
        report.Parameters("BranchAddress").Value = branchAddress.Text

        report.ReportTitle.Text = "LIST OF FREEBIES"

        report.Label1Title.Text = "Prepared By: "
        report.Label1Name.Text = MainMenu.App_Full_Name.Caption
        report.Label1Designation.Text = String.Empty

        report.XrLabel4.Text = "CUSTOMER: "
        report.XrLabel5.Text = txt_cust.Text
        report.XrLabel6.Text = txt_address.Text

        report.XrLabel7.Text = "SPARE PARTS INCHARGE: "
        report.XrLabel8.Text = txt_SpaIncharge.Text
        report.XrLabel9.Text = txt_SPAInchargeDesignation.Text

        report.XrLabel10.Text = "APPROVED: "
        report.XrLabel11.Text = txt_BM.Text
        report.XrLabel12.Text = "BRANCH MANAGER"

        report.XrLabel13.Text = txt_brCode.Text & "-" & txt_AccountNumber.Text & "-" & txt_LedSet.Text

        For Each param In report.Parameters
            param.Visible = False
        Next
        report.ShowPreview
    End Sub

    Private Sub ReleasesDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles ReleasesDocs.ItemClick
        IS_Sales_PreprintedReleaseDocs.txt_cust.Text = txt_cust.Text
        IS_Sales_PreprintedReleaseDocs.txt_AccountNumber.Text = txt_AccountNumber.Text
        IS_Sales_PreprintedReleaseDocs.txt_LedgerSetNumber.Text = txt_LedSet.Text
        IS_Sales_PreprintedReleaseDocs.receivedDate.Value = dategranted.Text
        IS_Sales_PreprintedReleaseDocs.txt_DateGranted.Text = dategranted.Text

        Dim xDateGranted As Date
        Dim dDateGranted As Integer
        xDateGranted = dategranted.Text
        dDateGranted = xDateGranted.Day

        IS_Sales_PreprintedReleaseDocs.txt_day.Text = dDateGranted & GetOrdinal(dDateGranted)
        IS_Sales_PreprintedReleaseDocs.txt_month.Text = Format(xDateGranted, "MMMM")
        IS_Sales_PreprintedReleaseDocs.txt_year.Text = xDateGranted.Year

        IS_Sales_PreprintedReleaseDocs.ShowDialog()
    End Sub

    Private Sub SearchEngineInv_Click(sender As Object, e As EventArgs) Handles SearchEngineInv.Click
        Dim SearchText As String
        SearchText = txt_engineNo.Text
        IS_Inventory_DetailedSummary.quickSearch.EditValue = SearchText
        'IS_Inventory_DetailedSummary.SearchWhat()
        IS_Inventory_DetailedSummary.ShowDialog()
    End Sub

    Private Sub SearchChassisInv_Click(sender As Object, e As EventArgs) Handles SearchChassisInv.Click
        Dim SearchText As String
        SearchText = txt_chassisNo.Text
        IS_Inventory_DetailedSummary.quickSearch.EditValue = SearchText
        'IS_Inventory_DetailedSummary.SearchWhat()
        IS_Inventory_DetailedSummary.ShowDialog()
    End Sub

    Private Sub txt_accountStatus_EditValueChanged(sender As Object, e As EventArgs) Handles txt_accountStatus.EditValueChanged
        If txt_accountStatus.Text Like "OVERDUE" Or txt_accountStatus.Text Like "overdue" Or txt_accountStatus.Text Like "overdue " Or txt_accountStatus.Text Like " overdue" Or txt_accountStatus.Text Like "OVERDUE " Or txt_accountStatus.Text Like "Overdue" Then
            Me.BackColor = Color.Red
        ElseIf txt_accountStatus.Text Like "CURRENT" Or txt_accountStatus.Text Like "Current" Or txt_accountStatus.Text Like "current" Then
            Me.BackColor = Color.Teal
        ElseIf txt_accountStatus.Text LIKE "EXEMPT" Or txt_accountStatus.Text LIKE "Exempt" Or txt_accountStatus.Text LIKE "exempt" Then
            Me.BackColor = Color.Gray
        ElseIf txt_accountStatus.Text LIKE "DEP" Or txt_accountStatus.Text LIKE "Dep" Or txt_accountStatus.Text LIKE "dep" Then
            Me.BackColor = Color.Maroon
        ElseIf txt_accountStatus.Text LIKE "REPO" Or txt_accountStatus.Text LIKE "Repo" Or txt_accountStatus.Text LIKE "repo" Then
            Me.BackColor = Color.Green
        ElseIf txt_accountStatus.Text LIKE "CLOSED" Or txt_accountStatus.Text LIKE "closed" Or txt_accountStatus.Text LIKE "Closed" Then
            Me.BackColor = Color.LightGray
        End If
    End Sub

    Sub mg_ShowCIFImageCheck()
        Dim Parameters As SqlParameter() = {New SqlParameter("@ParamCIFKey", txt_cifKey.Text)}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, Parameters, "mg_CifImageCheck")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                If myDataReader("Status").ToString = "0" Then
                    ShowImagesAcctInq()
                End If
            End If
        End Using
    End Sub

    Sub ShowImagesAcctInq()
        Dim tempcif As String = txt_cifKey.Text
        Dim command As New SqlCommand("SELECT * FROM CIFAccountsImages WHERE CIFKey = @id")
        command.Parameters.Add("@id", SqlDbType.VarChar).Value = tempcif

        Dim table As New DataTable
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)
        class_Database.mySQLConnection.Open()
        Dim tempimg() As Byte = TryCast(table.Rows(0)(1), Byte())

        If tempimg IsNot Nothing Then
            Dim img() As Byte
            img = table.Rows(0)(1)
            Dim ms As New MemoryStream(img)
            CPictureBox.Image = Image.FromStream(ms)
        Else
            CPictureBox.Image = tempPic.Image
        End If
        class_Database.mySQLConnection.Close()
    End Sub

    Private Sub CPictureBox_Click(sender As Object, e As EventArgs) Handles CPictureBox.Click
        Dim frmImageEnlarge As New wSClassLib.ImageEnlarge
        frmImageEnlarge.PictureEdit1.Image = CPictureBox.Image
        frmImageEnlarge.ShowDialog()
        frmImageEnlarge.Focus()
    End Sub

End Class