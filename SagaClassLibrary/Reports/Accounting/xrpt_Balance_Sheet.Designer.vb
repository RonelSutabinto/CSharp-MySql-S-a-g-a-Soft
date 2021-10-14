Namespace Reports.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class xrpt_Balance_Sheet
        Inherits DevExpress.XtraReports.UI.XtraReport

        'XtraReport overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Designer
        'It can be modified using the Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrpt_Balance_Sheet))
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.Product_Version = New DevExpress.XtraReports.UI.XRLabel()
            Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.As_Of_Month = New DevExpress.XtraReports.UI.XRLabel()
            Me.Document_Title = New DevExpress.XtraReports.UI.XRLabel()
            Me.XrLabel_Corporation = New DevExpress.XtraReports.UI.XRLabel()
            Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Prepared_Personnel = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Checked_Personnel = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Prepared_Position = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Checked_Position = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Noted_Personnel = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Noted_Position = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Approved_Personnel = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Approved_Position = New DevExpress.XtraReports.UI.XRTableCell()
            CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'TopMargin
            '
            Me.TopMargin.HeightF = 50.0!
            Me.TopMargin.Name = "TopMargin"
            '
            'BottomMargin
            '
            Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo2, Me.Product_Version, Me.pageInfo1})
            Me.BottomMargin.HeightF = 50.0!
            Me.BottomMargin.Name = "BottomMargin"
            '
            'pageInfo2
            '
            Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(651.4908!, 0!)
            Me.pageInfo2.Name = "pageInfo2"
            Me.pageInfo2.SizeF = New System.Drawing.SizeF(98.50922!, 20.00001!)
            Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.pageInfo2.TextFormatString = "Page {0} of {1}"
            '
            'Product_Version
            '
            Me.Product_Version.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Product_Version.ForeColor = System.Drawing.SystemColors.ControlDarkDark
            Me.Product_Version.LocationFloat = New DevExpress.Utils.PointFloat(200.0!, 0!)
            Me.Product_Version.Name = "Product_Version"
            Me.Product_Version.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.Product_Version.SizeF = New System.Drawing.SizeF(451.4908!, 20.00001!)
            Me.Product_Version.StylePriority.UseFont = False
            Me.Product_Version.StylePriority.UseForeColor = False
            Me.Product_Version.StylePriority.UseTextAlignment = False
            Me.Product_Version.Text = "Product_Version"
            Me.Product_Version.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'pageInfo1
            '
            Me.pageInfo1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
            Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.pageInfo1.Name = "pageInfo1"
            Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.pageInfo1.SizeF = New System.Drawing.SizeF(200.0!, 20.0!)
            Me.pageInfo1.StylePriority.UseForeColor = False
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
            Me.Detail.HeightF = 22.0!
            Me.Detail.Name = "Detail"
            '
            'XrTable2
            '
            Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(10.00001!, 0!)
            Me.XrTable2.Name = "XrTable2"
            Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
            Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
            Me.XrTable2.SizeF = New System.Drawing.SizeF(690.0!, 22.0!)
            '
            'XrTableRow3
            '
            Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell3, Me.XrTableCell5})
            Me.XrTableRow3.Name = "XrTableRow3"
            Me.XrTableRow3.Weight = 1.0R
            '
            'XrTableCell1
            '
            Me.XrTableCell1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[COA_Code]")})
            Me.XrTableCell1.Multiline = True
            Me.XrTableCell1.Name = "XrTableCell1"
            Me.XrTableCell1.StylePriority.UseTextAlignment = False
            Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell1.Weight = 0.54950597532027834R
            '
            'XrTableCell3
            '
            Me.XrTableCell3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[COA_Name]")})
            Me.XrTableCell3.Multiline = True
            Me.XrTableCell3.Name = "XrTableCell3"
            Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 50, 0, 0, 100.0!)
            Me.XrTableCell3.StylePriority.UsePadding = False
            Me.XrTableCell3.StylePriority.UseTextAlignment = False
            Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell3.Weight = 1.9232708779117553R
            '
            'XrTableCell5
            '
            Me.XrTableCell5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Balance_Sheet]")})
            Me.XrTableCell5.Multiline = True
            Me.XrTableCell5.Name = "XrTableCell5"
            Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
            Me.XrTableCell5.StylePriority.UsePadding = False
            Me.XrTableCell5.StylePriority.UseTextAlignment = False
            Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell5.TextFormatString = "{0:N2}"
            Me.XrTableCell5.Weight = 0.6868825358976568R
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.As_Of_Month, Me.Document_Title, Me.XrLabel_Corporation, Me.XrLabel5, Me.XrLabel3, Me.xrPictureBox1})
            Me.ReportHeader.HeightF = 150.0!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'As_Of_Month
            '
            Me.As_Of_Month.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic)
            Me.As_Of_Month.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 130.0!)
            Me.As_Of_Month.Name = "As_Of_Month"
            Me.As_Of_Month.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.As_Of_Month.SizeF = New System.Drawing.SizeF(450.0!, 15.0!)
            Me.As_Of_Month.StylePriority.UseFont = False
            Me.As_Of_Month.StylePriority.UsePadding = False
            Me.As_Of_Month.StylePriority.UseTextAlignment = False
            Me.As_Of_Month.Text = "As of January 2021"
            Me.As_Of_Month.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'Document_Title
            '
            Me.Document_Title.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
            Me.Document_Title.ForeColor = System.Drawing.Color.Black
            Me.Document_Title.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 105.8057!)
            Me.Document_Title.Name = "Document_Title"
            Me.Document_Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Document_Title.SizeF = New System.Drawing.SizeF(450.0!, 24.19433!)
            Me.Document_Title.StylePriority.UseFont = False
            Me.Document_Title.StylePriority.UseForeColor = False
            Me.Document_Title.StylePriority.UsePadding = False
            Me.Document_Title.StylePriority.UseTextAlignment = False
            Me.Document_Title.Text = "STATEMENT OF FINANCIAL POSITION"
            Me.Document_Title.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrLabel_Corporation
            '
            Me.XrLabel_Corporation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrLabel_Corporation.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 55.59737!)
            Me.XrLabel_Corporation.Name = "XrLabel_Corporation"
            Me.XrLabel_Corporation.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrLabel_Corporation.SizeF = New System.Drawing.SizeF(450.0!, 20.20832!)
            Me.XrLabel_Corporation.StylePriority.UseFont = False
            Me.XrLabel_Corporation.StylePriority.UsePadding = False
            Me.XrLabel_Corporation.StylePriority.UseTextAlignment = False
            Me.XrLabel_Corporation.Text = "SAGA MOTORS CORPORATION"
            Me.XrLabel_Corporation.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrLabel5
            '
            Me.XrLabel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic)
            Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 75.80569!)
            Me.XrLabel5.Name = "XrLabel5"
            Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrLabel5.SizeF = New System.Drawing.SizeF(450.0!, 15.0!)
            Me.XrLabel5.StylePriority.UseFont = False
            Me.XrLabel5.StylePriority.UsePadding = False
            Me.XrLabel5.StylePriority.UseTextAlignment = False
            Me.XrLabel5.Text = "HEAD OFFICE - National Highway, Sta. Isabel, Dipolog City, ZN"
            Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrLabel3
            '
            Me.XrLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 90.80569!)
            Me.XrLabel3.Name = "XrLabel3"
            Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrLabel3.SizeF = New System.Drawing.SizeF(450.0!, 15.00001!)
            Me.XrLabel3.StylePriority.UseFont = False
            Me.XrLabel3.StylePriority.UsePadding = False
            Me.XrLabel3.StylePriority.UseTextAlignment = False
            Me.XrLabel3.Text = "Telephone Number: 212 5878"
            Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'xrPictureBox1
            '
            Me.xrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("xrPictureBox1.ImageSource"))
            Me.xrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.xrPictureBox1.Name = "xrPictureBox1"
            Me.xrPictureBox1.SizeF = New System.Drawing.SizeF(750.0!, 150.0!)
            Me.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage
            '
            'ReportFooter
            '
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
            Me.ReportFooter.HeightF = 200.0!
            Me.ReportFooter.Name = "ReportFooter"
            '
            'XrTable5
            '
            Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.XrTable5.Name = "XrTable5"
            Me.XrTable5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
            Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4, Me.XrTableRow7, Me.XrTableRow6, Me.XrTableRow8, Me.XrTableRow1, Me.XrTableRow11, Me.XrTableRow12, Me.XrTableRow13, Me.XrTableRow2, Me.XrTableRow5})
            Me.XrTable5.SizeF = New System.Drawing.SizeF(750.0!, 200.0!)
            '
            'XrTableRow4
            '
            Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2})
            Me.XrTableRow4.Name = "XrTableRow4"
            Me.XrTableRow4.Weight = 1.0R
            '
            'XrTableCell2
            '
            Me.XrTableCell2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell2.Multiline = True
            Me.XrTableCell2.Name = "XrTableCell2"
            Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell2.StylePriority.UseFont = False
            Me.XrTableCell2.StylePriority.UsePadding = False
            Me.XrTableCell2.StylePriority.UseTextAlignment = False
            Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell2.Weight = 1.8333333333333335R
            '
            'XrTableRow7
            '
            Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.XrTableCell12})
            Me.XrTableRow7.Name = "XrTableRow7"
            Me.XrTableRow7.Weight = 1.0R
            '
            'XrTableCell11
            '
            Me.XrTableCell11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell11.Multiline = True
            Me.XrTableCell11.Name = "XrTableCell11"
            Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell11.StylePriority.UseFont = False
            Me.XrTableCell11.StylePriority.UsePadding = False
            Me.XrTableCell11.StylePriority.UseTextAlignment = False
            Me.XrTableCell11.Text = "Prepared By"
            Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell11.Weight = 0.91666666666666663R
            '
            'XrTableCell12
            '
            Me.XrTableCell12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell12.Multiline = True
            Me.XrTableCell12.Name = "XrTableCell12"
            Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell12.StylePriority.UseFont = False
            Me.XrTableCell12.StylePriority.UsePadding = False
            Me.XrTableCell12.StylePriority.UseTextAlignment = False
            Me.XrTableCell12.Text = "Checked By"
            Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell12.Weight = 0.916666666666667R
            '
            'XrTableRow6
            '
            Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell8})
            Me.XrTableRow6.Name = "XrTableRow6"
            Me.XrTableRow6.Weight = 1.0R
            '
            'XrTableCell7
            '
            Me.XrTableCell7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell7.Multiline = True
            Me.XrTableCell7.Name = "XrTableCell7"
            Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableCell7.StylePriority.UseFont = False
            Me.XrTableCell7.StylePriority.UsePadding = False
            Me.XrTableCell7.StylePriority.UseTextAlignment = False
            Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell7.Weight = 0.91666664632161454R
            '
            'XrTableCell8
            '
            Me.XrTableCell8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell8.Multiline = True
            Me.XrTableCell8.Name = "XrTableCell8"
            Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableCell8.StylePriority.UseFont = False
            Me.XrTableCell8.StylePriority.UsePadding = False
            Me.XrTableCell8.StylePriority.UseTextAlignment = False
            Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell8.Weight = 0.91666668701171883R
            '
            'XrTableRow8
            '
            Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Prepared_Personnel, Me.Checked_Personnel})
            Me.XrTableRow8.Name = "XrTableRow8"
            Me.XrTableRow8.Weight = 1.0R
            '
            'Prepared_Personnel
            '
            Me.Prepared_Personnel.CanShrink = True
            Me.Prepared_Personnel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Prepared_Personnel.Name = "Prepared_Personnel"
            Me.Prepared_Personnel.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Prepared_Personnel.StylePriority.UseFont = False
            Me.Prepared_Personnel.StylePriority.UsePadding = False
            Me.Prepared_Personnel.StylePriority.UseTextAlignment = False
            Me.Prepared_Personnel.Text = "SHARON JADE P. MIOLE"
            Me.Prepared_Personnel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Prepared_Personnel.Weight = 0.91666664632161454R
            Me.Prepared_Personnel.WordWrap = False
            '
            'Checked_Personnel
            '
            Me.Checked_Personnel.CanShrink = True
            Me.Checked_Personnel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Checked_Personnel.Name = "Checked_Personnel"
            Me.Checked_Personnel.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Checked_Personnel.StylePriority.UseFont = False
            Me.Checked_Personnel.StylePriority.UsePadding = False
            Me.Checked_Personnel.StylePriority.UseTextAlignment = False
            Me.Checked_Personnel.Text = "INNA CASSANDRA R. MONTEROSO"
            Me.Checked_Personnel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Checked_Personnel.Weight = 0.91666668701171883R
            Me.Checked_Personnel.WordWrap = False
            '
            'XrTableRow1
            '
            Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Prepared_Position, Me.Checked_Position})
            Me.XrTableRow1.Name = "XrTableRow1"
            Me.XrTableRow1.Weight = 1.0R
            '
            'Prepared_Position
            '
            Me.Prepared_Position.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Prepared_Position.Multiline = True
            Me.Prepared_Position.Name = "Prepared_Position"
            Me.Prepared_Position.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Prepared_Position.StylePriority.UseFont = False
            Me.Prepared_Position.StylePriority.UsePadding = False
            Me.Prepared_Position.StylePriority.UseTextAlignment = False
            Me.Prepared_Position.Text = "Accounting Assistant"
            Me.Prepared_Position.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Prepared_Position.Weight = 0.91666664632161454R
            '
            'Checked_Position
            '
            Me.Checked_Position.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Checked_Position.Multiline = True
            Me.Checked_Position.Name = "Checked_Position"
            Me.Checked_Position.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Checked_Position.StylePriority.UseFont = False
            Me.Checked_Position.StylePriority.UsePadding = False
            Me.Checked_Position.StylePriority.UseTextAlignment = False
            Me.Checked_Position.Text = "Accounting Head"
            Me.Checked_Position.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Checked_Position.Weight = 0.91666668701171883R
            '
            'XrTableRow11
            '
            Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27})
            Me.XrTableRow11.Name = "XrTableRow11"
            Me.XrTableRow11.Weight = 1.0R
            '
            'XrTableCell27
            '
            Me.XrTableCell27.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell27.Multiline = True
            Me.XrTableCell27.Name = "XrTableCell27"
            Me.XrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableCell27.StylePriority.UseFont = False
            Me.XrTableCell27.StylePriority.UsePadding = False
            Me.XrTableCell27.StylePriority.UseTextAlignment = False
            Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell27.Weight = 1.8333333333333335R
            '
            'XrTableRow12
            '
            Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell10})
            Me.XrTableRow12.Name = "XrTableRow12"
            Me.XrTableRow12.Weight = 1.0R
            '
            'XrTableCell9
            '
            Me.XrTableCell9.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell9.Multiline = True
            Me.XrTableCell9.Name = "XrTableCell9"
            Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell9.StylePriority.UseFont = False
            Me.XrTableCell9.StylePriority.UsePadding = False
            Me.XrTableCell9.StylePriority.UseTextAlignment = False
            Me.XrTableCell9.Text = "Noted By"
            Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell9.Weight = 0.91666666666666674R
            '
            'XrTableCell10
            '
            Me.XrTableCell10.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell10.Multiline = True
            Me.XrTableCell10.Name = "XrTableCell10"
            Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableCell10.StylePriority.UseFont = False
            Me.XrTableCell10.StylePriority.UsePadding = False
            Me.XrTableCell10.StylePriority.UseTextAlignment = False
            Me.XrTableCell10.Text = "Approved By"
            Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell10.Weight = 0.91666666666666674R
            '
            'XrTableRow13
            '
            Me.XrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell13})
            Me.XrTableRow13.Name = "XrTableRow13"
            Me.XrTableRow13.Weight = 1.0R
            '
            'XrTableCell13
            '
            Me.XrTableCell13.Font = New System.Drawing.Font("Segoe UI Semibold", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell13.Multiline = True
            Me.XrTableCell13.Name = "XrTableCell13"
            Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell13.StylePriority.UseFont = False
            Me.XrTableCell13.StylePriority.UsePadding = False
            Me.XrTableCell13.StylePriority.UseTextAlignment = False
            Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell13.Weight = 1.8333333333333335R
            '
            'XrTableRow2
            '
            Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Noted_Personnel, Me.Approved_Personnel})
            Me.XrTableRow2.Name = "XrTableRow2"
            Me.XrTableRow2.Weight = 1.0R
            '
            'Noted_Personnel
            '
            Me.Noted_Personnel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.Noted_Personnel.Multiline = True
            Me.Noted_Personnel.Name = "Noted_Personnel"
            Me.Noted_Personnel.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Noted_Personnel.StylePriority.UseFont = False
            Me.Noted_Personnel.StylePriority.UsePadding = False
            Me.Noted_Personnel.StylePriority.UseTextAlignment = False
            Me.Noted_Personnel.Text = "LIRA J. LACQIUO"
            Me.Noted_Personnel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Noted_Personnel.Weight = 0.91666666666666674R
            '
            'XrTableRow5
            '
            Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Noted_Position, Me.Approved_Position})
            Me.XrTableRow5.Name = "XrTableRow5"
            Me.XrTableRow5.Weight = 1.0R
            '
            'Noted_Position
            '
            Me.Noted_Position.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.Noted_Position.Multiline = True
            Me.Noted_Position.Name = "Noted_Position"
            Me.Noted_Position.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Noted_Position.StylePriority.UseFont = False
            Me.Noted_Position.StylePriority.UsePadding = False
            Me.Noted_Position.StylePriority.UseTextAlignment = False
            Me.Noted_Position.Text = "Comptroller"
            Me.Noted_Position.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Noted_Position.Weight = 0.91666666666666674R
            '
            'Approved_Personnel
            '
            Me.Approved_Personnel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.Approved_Personnel.Multiline = True
            Me.Approved_Personnel.Name = "Approved_Personnel"
            Me.Approved_Personnel.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Approved_Personnel.StylePriority.UseFont = False
            Me.Approved_Personnel.StylePriority.UsePadding = False
            Me.Approved_Personnel.StylePriority.UseTextAlignment = False
            Me.Approved_Personnel.Text = "MARIA KATRINA FRANCESCA H. ROLEDA"
            Me.Approved_Personnel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Approved_Personnel.Weight = 0.91666666666666674R
            '
            'Approved_Position
            '
            Me.Approved_Position.Font = New System.Drawing.Font("Segoe UI", 8.0!)
            Me.Approved_Position.Multiline = True
            Me.Approved_Position.Name = "Approved_Position"
            Me.Approved_Position.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Approved_Position.StylePriority.UseFont = False
            Me.Approved_Position.StylePriority.UsePadding = False
            Me.Approved_Position.StylePriority.UseTextAlignment = False
            Me.Approved_Position.Text = "President / CEO"
            Me.Approved_Position.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Approved_Position.Weight = 0.91666666666666674R
            '
            'xrpt_Balance_Sheet
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader, Me.ReportFooter})
            Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
            Me.PageHeight = 1300
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.Version = "20.2"
            CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Friend WithEvents Document_Title As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_Corporation As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
        Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Prepared_Personnel As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Checked_Personnel As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Friend WithEvents Product_Version As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Private WithEvents xrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
        Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Prepared_Position As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Checked_Position As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents As_Of_Month As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow13 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Noted_Personnel As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Noted_Position As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Approved_Personnel As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Approved_Position As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace