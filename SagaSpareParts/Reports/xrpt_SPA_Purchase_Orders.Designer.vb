﻿Namespace SagaSpareParts
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class xrpt_SPA_Purchase_Orders
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
            Me.components = New System.ComponentModel.Container()
            Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
            Dim MsSqlConnectionParameters1 As DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters = New DevExpress.DataAccess.ConnectionParameters.MsSqlConnectionParameters()
            Dim SelectQuery1 As DevExpress.DataAccess.Sql.SelectQuery = New DevExpress.DataAccess.Sql.SelectQuery()
            Dim Column1 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression1 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Table1 As DevExpress.DataAccess.Sql.Table = New DevExpress.DataAccess.Sql.Table()
            Dim Column2 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression2 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column3 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression3 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column4 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression4 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column5 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression5 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column6 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression6 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column7 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression7 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column8 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression8 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column9 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression9 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column10 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression10 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column11 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression11 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column12 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression12 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column13 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression13 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column14 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression14 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column15 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression15 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column16 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression16 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column17 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression17 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim Column18 As DevExpress.DataAccess.Sql.Column = New DevExpress.DataAccess.Sql.Column()
            Dim ColumnExpression18 As DevExpress.DataAccess.Sql.ColumnExpression = New DevExpress.DataAccess.Sql.ColumnExpression()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrpt_SPA_Purchase_Orders))
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.XrTable5 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
            Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.XrLabel_Corporation = New DevExpress.XtraReports.UI.XRLabel()
            Me.label_Document_Title = New DevExpress.XtraReports.UI.XRLabel()
            Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Brand = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Purchase_Order_Code = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Dealer = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Order_Date = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell_Address = New DevExpress.XtraReports.UI.XRTableCell()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell20 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.pageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.Product_Version = New DevExpress.XtraReports.UI.XRLabel()
            Me.pageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
            Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell52 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell37 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell40 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell55 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell43 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell46 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell53 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell38 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell54 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell19 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell42 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell51 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell45 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell48 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Prepared_By = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Verified_By = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Checked_By = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Recommended_By = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Approved_By = New DevExpress.XtraReports.UI.XRTableCell()
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
            Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Prepared_Personnel = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Verified_Personnel = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Checked_Personnel = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Recommend = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Approved_Personnel = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Prepared_Position = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Verified_Position = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Checked_Position = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Position = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Approved_Position = New DevExpress.XtraReports.UI.XRTableCell()
            Me.SqlDataSource = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
            CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'TopMargin
            '
            Me.TopMargin.HeightF = 50.0!
            Me.TopMargin.Name = "TopMargin"
            '
            'BottomMargin
            '
            Me.BottomMargin.HeightF = 50.0!
            Me.BottomMargin.Name = "BottomMargin"
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable5})
            Me.Detail.HeightF = 25.0!
            Me.Detail.Name = "Detail"
            '
            'XrTable5
            '
            Me.XrTable5.BorderColor = System.Drawing.Color.Transparent
            Me.XrTable5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTable5.ForeColor = System.Drawing.Color.Black
            Me.XrTable5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.XrTable5.Name = "XrTable5"
            Me.XrTable5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
            Me.XrTable5.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow9})
            Me.XrTable5.SizeF = New System.Drawing.SizeF(1200.0!, 25.0!)
            Me.XrTable5.StylePriority.UseBorderColor = False
            Me.XrTable5.StylePriority.UseFont = False
            Me.XrTable5.StylePriority.UseForeColor = False
            '
            'XrTableRow9
            '
            Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell22, Me.XrTableCell23, Me.XrTableCell24, Me.XrTableCell25, Me.XrTableCell33, Me.XrTableCell26, Me.XrTableCell27, Me.XrTableCell30, Me.XrTableCell31})
            Me.XrTableRow9.Name = "XrTableRow9"
            Me.XrTableRow9.Weight = 1.0R
            '
            'XrTableCell10
            '
            Me.XrTableCell10.BackColor = System.Drawing.Color.Transparent
            Me.XrTableCell10.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell10.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
            Me.XrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.XrTableCell10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parts_Number]")})
            Me.XrTableCell10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell10.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell10.Multiline = True
            Me.XrTableCell10.Name = "XrTableCell10"
            Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell10.StylePriority.UseBackColor = False
            Me.XrTableCell10.StylePriority.UseBorderColor = False
            Me.XrTableCell10.StylePriority.UseBorderDashStyle = False
            Me.XrTableCell10.StylePriority.UseBorders = False
            Me.XrTableCell10.StylePriority.UseFont = False
            Me.XrTableCell10.StylePriority.UseForeColor = False
            Me.XrTableCell10.StylePriority.UsePadding = False
            Me.XrTableCell10.StylePriority.UseTextAlignment = False
            Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell10.Weight = 2.9133824394553725R
            '
            'XrTableCell11
            '
            Me.XrTableCell11.BackColor = System.Drawing.Color.Transparent
            Me.XrTableCell11.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell11.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
            Me.XrTableCell11.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.XrTableCell11.CanShrink = True
            Me.XrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parts_Name]")})
            Me.XrTableCell11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell11.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell11.Name = "XrTableCell11"
            Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell11.StylePriority.UseBackColor = False
            Me.XrTableCell11.StylePriority.UseBorderColor = False
            Me.XrTableCell11.StylePriority.UseBorderDashStyle = False
            Me.XrTableCell11.StylePriority.UseBorders = False
            Me.XrTableCell11.StylePriority.UseFont = False
            Me.XrTableCell11.StylePriority.UseForeColor = False
            Me.XrTableCell11.StylePriority.UsePadding = False
            Me.XrTableCell11.StylePriority.UseTextAlignment = False
            Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell11.Weight = 3.6781453346393547R
            Me.XrTableCell11.WordWrap = False
            '
            'XrTableCell22
            '
            Me.XrTableCell22.BackColor = System.Drawing.Color.Transparent
            Me.XrTableCell22.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell22.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
            Me.XrTableCell22.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.XrTableCell22.CanShrink = True
            Me.XrTableCell22.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Quantity_Order]")})
            Me.XrTableCell22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell22.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell22.Name = "XrTableCell22"
            Me.XrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell22.StylePriority.UseBackColor = False
            Me.XrTableCell22.StylePriority.UseBorderColor = False
            Me.XrTableCell22.StylePriority.UseBorderDashStyle = False
            Me.XrTableCell22.StylePriority.UseBorders = False
            Me.XrTableCell22.StylePriority.UseFont = False
            Me.XrTableCell22.StylePriority.UseForeColor = False
            Me.XrTableCell22.StylePriority.UsePadding = False
            Me.XrTableCell22.StylePriority.UseTextAlignment = False
            Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell22.TextFormatString = "{0:#,#}"
            Me.XrTableCell22.Weight = 1.6428241948408604R
            Me.XrTableCell22.WordWrap = False
            '
            'XrTableCell23
            '
            Me.XrTableCell23.BackColor = System.Drawing.Color.Transparent
            Me.XrTableCell23.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell23.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
            Me.XrTableCell23.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.XrTableCell23.CanShrink = True
            Me.XrTableCell23.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Remaining_Inventory]")})
            Me.XrTableCell23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell23.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell23.Name = "XrTableCell23"
            Me.XrTableCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell23.StylePriority.UseBackColor = False
            Me.XrTableCell23.StylePriority.UseBorderColor = False
            Me.XrTableCell23.StylePriority.UseBorderDashStyle = False
            Me.XrTableCell23.StylePriority.UseBorders = False
            Me.XrTableCell23.StylePriority.UseFont = False
            Me.XrTableCell23.StylePriority.UseForeColor = False
            Me.XrTableCell23.StylePriority.UsePadding = False
            Me.XrTableCell23.StylePriority.UseTextAlignment = False
            Me.XrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell23.TextFormatString = "{0:#,#}"
            Me.XrTableCell23.Weight = 1.7212280083403517R
            Me.XrTableCell23.WordWrap = False
            '
            'XrTableCell24
            '
            Me.XrTableCell24.BackColor = System.Drawing.Color.Transparent
            Me.XrTableCell24.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell24.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
            Me.XrTableCell24.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.XrTableCell24.CanShrink = True
            Me.XrTableCell24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Sales_Summary]")})
            Me.XrTableCell24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell24.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell24.Name = "XrTableCell24"
            Me.XrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell24.StylePriority.UseBackColor = False
            Me.XrTableCell24.StylePriority.UseBorderColor = False
            Me.XrTableCell24.StylePriority.UseBorderDashStyle = False
            Me.XrTableCell24.StylePriority.UseBorders = False
            Me.XrTableCell24.StylePriority.UseFont = False
            Me.XrTableCell24.StylePriority.UseForeColor = False
            Me.XrTableCell24.StylePriority.UsePadding = False
            Me.XrTableCell24.StylePriority.UseTextAlignment = False
            Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell24.TextFormatString = "{0:#,#}"
            Me.XrTableCell24.Weight = 1.78760005798885R
            Me.XrTableCell24.WordWrap = False
            '
            'XrTableCell25
            '
            Me.XrTableCell25.BackColor = System.Drawing.Color.Transparent
            Me.XrTableCell25.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell25.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
            Me.XrTableCell25.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.XrTableCell25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SRP]")})
            Me.XrTableCell25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell25.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell25.Multiline = True
            Me.XrTableCell25.Name = "XrTableCell25"
            Me.XrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100.0!)
            Me.XrTableCell25.StylePriority.UseBackColor = False
            Me.XrTableCell25.StylePriority.UseBorderColor = False
            Me.XrTableCell25.StylePriority.UseBorderDashStyle = False
            Me.XrTableCell25.StylePriority.UseBorders = False
            Me.XrTableCell25.StylePriority.UseFont = False
            Me.XrTableCell25.StylePriority.UseForeColor = False
            Me.XrTableCell25.StylePriority.UsePadding = False
            Me.XrTableCell25.StylePriority.UseTextAlignment = False
            Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell25.TextFormatString = "{0:n2}"
            Me.XrTableCell25.Weight = 1.8085684515508396R
            '
            'XrTableCell33
            '
            Me.XrTableCell33.BackColor = System.Drawing.Color.Transparent
            Me.XrTableCell33.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell33.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
            Me.XrTableCell33.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.XrTableCell33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Cost]")})
            Me.XrTableCell33.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell33.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell33.Multiline = True
            Me.XrTableCell33.Name = "XrTableCell33"
            Me.XrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100.0!)
            Me.XrTableCell33.StylePriority.UseBackColor = False
            Me.XrTableCell33.StylePriority.UseBorderColor = False
            Me.XrTableCell33.StylePriority.UseBorderDashStyle = False
            Me.XrTableCell33.StylePriority.UseBorders = False
            Me.XrTableCell33.StylePriority.UseFont = False
            Me.XrTableCell33.StylePriority.UseForeColor = False
            Me.XrTableCell33.StylePriority.UsePadding = False
            Me.XrTableCell33.StylePriority.UseTextAlignment = False
            Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell33.TextFormatString = "{0:n2}"
            Me.XrTableCell33.Weight = 2.107682118697924R
            '
            'XrTableCell26
            '
            Me.XrTableCell26.BackColor = System.Drawing.Color.Transparent
            Me.XrTableCell26.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell26.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
            Me.XrTableCell26.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.XrTableCell26.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total_Cost]")})
            Me.XrTableCell26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell26.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell26.Multiline = True
            Me.XrTableCell26.Name = "XrTableCell26"
            Me.XrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100.0!)
            Me.XrTableCell26.StylePriority.UseBackColor = False
            Me.XrTableCell26.StylePriority.UseBorderColor = False
            Me.XrTableCell26.StylePriority.UseBorderDashStyle = False
            Me.XrTableCell26.StylePriority.UseBorders = False
            Me.XrTableCell26.StylePriority.UseFont = False
            Me.XrTableCell26.StylePriority.UseForeColor = False
            Me.XrTableCell26.StylePriority.UsePadding = False
            Me.XrTableCell26.StylePriority.UseTextAlignment = False
            Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell26.TextFormatString = "{0:N2}"
            Me.XrTableCell26.Weight = 1.8006317966635315R
            '
            'XrTableCell27
            '
            Me.XrTableCell27.BackColor = System.Drawing.Color.Transparent
            Me.XrTableCell27.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell27.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
            Me.XrTableCell27.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.XrTableCell27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total_SRP]")})
            Me.XrTableCell27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell27.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell27.Multiline = True
            Me.XrTableCell27.Name = "XrTableCell27"
            Me.XrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
            Me.XrTableCell27.StylePriority.UseBackColor = False
            Me.XrTableCell27.StylePriority.UseBorderColor = False
            Me.XrTableCell27.StylePriority.UseBorderDashStyle = False
            Me.XrTableCell27.StylePriority.UseBorders = False
            Me.XrTableCell27.StylePriority.UseFont = False
            Me.XrTableCell27.StylePriority.UseForeColor = False
            Me.XrTableCell27.StylePriority.UsePadding = False
            Me.XrTableCell27.StylePriority.UseTextAlignment = False
            Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell27.TextFormatString = "{0:N2}"
            Me.XrTableCell27.Weight = 1.9624872532268625R
            '
            'XrTableCell30
            '
            Me.XrTableCell30.BackColor = System.Drawing.Color.Transparent
            Me.XrTableCell30.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell30.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
            Me.XrTableCell30.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.XrTableCell30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Total_Rebates]")})
            Me.XrTableCell30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell30.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell30.Multiline = True
            Me.XrTableCell30.Name = "XrTableCell30"
            Me.XrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
            Me.XrTableCell30.StylePriority.UseBackColor = False
            Me.XrTableCell30.StylePriority.UseBorderColor = False
            Me.XrTableCell30.StylePriority.UseBorderDashStyle = False
            Me.XrTableCell30.StylePriority.UseBorders = False
            Me.XrTableCell30.StylePriority.UseFont = False
            Me.XrTableCell30.StylePriority.UseForeColor = False
            Me.XrTableCell30.StylePriority.UsePadding = False
            Me.XrTableCell30.StylePriority.UseTextAlignment = False
            Me.XrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell30.TextFormatString = "{0:N2}"
            Me.XrTableCell30.Weight = 1.7075625518310029R
            '
            'XrTableCell31
            '
            Me.XrTableCell31.BackColor = System.Drawing.Color.Transparent
            Me.XrTableCell31.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell31.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Dash
            Me.XrTableCell31.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.XrTableCell31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Net_Profit]")})
            Me.XrTableCell31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell31.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell31.Multiline = True
            Me.XrTableCell31.Name = "XrTableCell31"
            Me.XrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 10, 0, 0, 100.0!)
            Me.XrTableCell31.StylePriority.UseBackColor = False
            Me.XrTableCell31.StylePriority.UseBorderColor = False
            Me.XrTableCell31.StylePriority.UseBorderDashStyle = False
            Me.XrTableCell31.StylePriority.UseBorders = False
            Me.XrTableCell31.StylePriority.UseFont = False
            Me.XrTableCell31.StylePriority.UseForeColor = False
            Me.XrTableCell31.StylePriority.UsePadding = False
            Me.XrTableCell31.StylePriority.UseTextAlignment = False
            Me.XrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell31.TextFormatString = "{0:N2}"
            Me.XrTableCell31.Weight = 2.1769474555149868R
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel5, Me.XrLabel_Corporation, Me.label_Document_Title})
            Me.ReportHeader.HeightF = 85.86102!
            Me.ReportHeader.Name = "ReportHeader"
            '
            'XrLabel3
            '
            Me.XrLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 35.20832!)
            Me.XrLabel3.Name = "XrLabel3"
            Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel3.SizeF = New System.Drawing.SizeF(1200.0!, 15.0!)
            Me.XrLabel3.StylePriority.UseFont = False
            Me.XrLabel3.StylePriority.UseTextAlignment = False
            Me.XrLabel3.Text = "Telephone Number: 212 5878"
            Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrLabel5
            '
            Me.XrLabel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Italic)
            Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 20.20833!)
            Me.XrLabel5.Name = "XrLabel5"
            Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel5.SizeF = New System.Drawing.SizeF(1200.0!, 15.0!)
            Me.XrLabel5.StylePriority.UseFont = False
            Me.XrLabel5.StylePriority.UseTextAlignment = False
            Me.XrLabel5.Text = "HEAD OFFICE - National Highway, Sta. Isabel, Dipolog City, ZN"
            Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrLabel_Corporation
            '
            Me.XrLabel_Corporation.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrLabel_Corporation.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.XrLabel_Corporation.Name = "XrLabel_Corporation"
            Me.XrLabel_Corporation.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_Corporation.SizeF = New System.Drawing.SizeF(1200.0!, 20.20833!)
            Me.XrLabel_Corporation.StylePriority.UseFont = False
            Me.XrLabel_Corporation.StylePriority.UseTextAlignment = False
            Me.XrLabel_Corporation.Text = "SAGA MOTORS CORPORATION"
            Me.XrLabel_Corporation.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'label_Document_Title
            '
            Me.label_Document_Title.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
            Me.label_Document_Title.ForeColor = System.Drawing.Color.Black
            Me.label_Document_Title.LocationFloat = New DevExpress.Utils.PointFloat(0!, 50.20835!)
            Me.label_Document_Title.Name = "label_Document_Title"
            Me.label_Document_Title.SizeF = New System.Drawing.SizeF(1200.0!, 24.19432!)
            Me.label_Document_Title.StylePriority.UseFont = False
            Me.label_Document_Title.StylePriority.UseForeColor = False
            Me.label_Document_Title.StylePriority.UseTextAlignment = False
            Me.label_Document_Title.Text = "SPA Purchase Order"
            Me.label_Document_Title.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrTable1
            '
            Me.XrTable1.BorderColor = System.Drawing.Color.White
            Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.XrTable1.Name = "XrTable1"
            Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2, Me.XrTableRow3})
            Me.XrTable1.SizeF = New System.Drawing.SizeF(777.0236!, 70.00002!)
            Me.XrTable1.StylePriority.UseBorderColor = False
            Me.XrTable1.StylePriority.UseBorders = False
            Me.XrTable1.StylePriority.UsePadding = False
            Me.XrTable1.StylePriority.UseTextAlignment = False
            Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableRow1
            '
            Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell_Brand, Me.XrTableCell3, Me.XrTableCell_Purchase_Order_Code})
            Me.XrTableRow1.Name = "XrTableRow1"
            Me.XrTableRow1.Weight = 1.0R
            '
            'XrTableCell2
            '
            Me.XrTableCell2.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell2.BorderColor = System.Drawing.Color.White
            Me.XrTableCell2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.XrTableCell2.ForeColor = System.Drawing.Color.White
            Me.XrTableCell2.Multiline = True
            Me.XrTableCell2.Name = "XrTableCell2"
            Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell2.StylePriority.UseBackColor = False
            Me.XrTableCell2.StylePriority.UseBorderColor = False
            Me.XrTableCell2.StylePriority.UseFont = False
            Me.XrTableCell2.StylePriority.UseForeColor = False
            Me.XrTableCell2.StylePriority.UsePadding = False
            Me.XrTableCell2.Text = "BRAND"
            Me.XrTableCell2.Weight = 0.61331063663514085R
            '
            'XrTableCell_Brand
            '
            Me.XrTableCell_Brand.BackColor = System.Drawing.Color.Empty
            Me.XrTableCell_Brand.BorderColor = System.Drawing.Color.Empty
            Me.XrTableCell_Brand.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.XrTableCell_Brand.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell_Brand.Multiline = True
            Me.XrTableCell_Brand.Name = "XrTableCell_Brand"
            Me.XrTableCell_Brand.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell_Brand.StylePriority.UseBackColor = False
            Me.XrTableCell_Brand.StylePriority.UseBorderColor = False
            Me.XrTableCell_Brand.StylePriority.UseFont = False
            Me.XrTableCell_Brand.StylePriority.UseForeColor = False
            Me.XrTableCell_Brand.StylePriority.UsePadding = False
            Me.XrTableCell_Brand.Weight = 2.8365618450152952R
            '
            'XrTableCell3
            '
            Me.XrTableCell3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell3.BorderColor = System.Drawing.Color.White
            Me.XrTableCell3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.XrTableCell3.ForeColor = System.Drawing.Color.White
            Me.XrTableCell3.Multiline = True
            Me.XrTableCell3.Name = "XrTableCell3"
            Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell3.StylePriority.UseBackColor = False
            Me.XrTableCell3.StylePriority.UseBorderColor = False
            Me.XrTableCell3.StylePriority.UseFont = False
            Me.XrTableCell3.StylePriority.UseForeColor = False
            Me.XrTableCell3.StylePriority.UsePadding = False
            Me.XrTableCell3.Text = "P. O. NUMBER"
            Me.XrTableCell3.Weight = 0.87105581571328416R
            '
            'XrTableCell_Purchase_Order_Code
            '
            Me.XrTableCell_Purchase_Order_Code.BorderColor = System.Drawing.Color.Empty
            Me.XrTableCell_Purchase_Order_Code.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.XrTableCell_Purchase_Order_Code.Multiline = True
            Me.XrTableCell_Purchase_Order_Code.Name = "XrTableCell_Purchase_Order_Code"
            Me.XrTableCell_Purchase_Order_Code.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell_Purchase_Order_Code.StylePriority.UseBorderColor = False
            Me.XrTableCell_Purchase_Order_Code.StylePriority.UseFont = False
            Me.XrTableCell_Purchase_Order_Code.StylePriority.UsePadding = False
            Me.XrTableCell_Purchase_Order_Code.StylePriority.UseTextAlignment = False
            Me.XrTableCell_Purchase_Order_Code.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            Me.XrTableCell_Purchase_Order_Code.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell_Purchase_Order_Code.Weight = 1.6360320722158208R
            '
            'XrTableRow2
            '
            Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell_Dealer, Me.XrTableCell5, Me.XrTableCell_Order_Date})
            Me.XrTableRow2.Name = "XrTableRow2"
            Me.XrTableRow2.Weight = 1.0R
            '
            'XrTableCell1
            '
            Me.XrTableCell1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell1.BorderColor = System.Drawing.Color.White
            Me.XrTableCell1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.XrTableCell1.ForeColor = System.Drawing.Color.White
            Me.XrTableCell1.Multiline = True
            Me.XrTableCell1.Name = "XrTableCell1"
            Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell1.StylePriority.UseBackColor = False
            Me.XrTableCell1.StylePriority.UseBorderColor = False
            Me.XrTableCell1.StylePriority.UseFont = False
            Me.XrTableCell1.StylePriority.UseForeColor = False
            Me.XrTableCell1.StylePriority.UsePadding = False
            Me.XrTableCell1.Text = "SUPPLIER"
            Me.XrTableCell1.Weight = 0.61331045552681906R
            '
            'XrTableCell_Dealer
            '
            Me.XrTableCell_Dealer.BackColor = System.Drawing.Color.Empty
            Me.XrTableCell_Dealer.BorderColor = System.Drawing.Color.Empty
            Me.XrTableCell_Dealer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.XrTableCell_Dealer.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell_Dealer.Multiline = True
            Me.XrTableCell_Dealer.Name = "XrTableCell_Dealer"
            Me.XrTableCell_Dealer.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell_Dealer.StylePriority.UseBackColor = False
            Me.XrTableCell_Dealer.StylePriority.UseBorderColor = False
            Me.XrTableCell_Dealer.StylePriority.UseFont = False
            Me.XrTableCell_Dealer.StylePriority.UseForeColor = False
            Me.XrTableCell_Dealer.StylePriority.UsePadding = False
            Me.XrTableCell_Dealer.Weight = 2.8365617008897268R
            '
            'XrTableCell5
            '
            Me.XrTableCell5.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell5.BorderColor = System.Drawing.Color.White
            Me.XrTableCell5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.XrTableCell5.ForeColor = System.Drawing.Color.White
            Me.XrTableCell5.Multiline = True
            Me.XrTableCell5.Name = "XrTableCell5"
            Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell5.StylePriority.UseBackColor = False
            Me.XrTableCell5.StylePriority.UseBorderColor = False
            Me.XrTableCell5.StylePriority.UseFont = False
            Me.XrTableCell5.StylePriority.UseForeColor = False
            Me.XrTableCell5.StylePriority.UsePadding = False
            Me.XrTableCell5.Text = "PREPARED DATE"
            Me.XrTableCell5.Weight = 0.87105574069687264R
            '
            'XrTableCell_Order_Date
            '
            Me.XrTableCell_Order_Date.BorderColor = System.Drawing.Color.Empty
            Me.XrTableCell_Order_Date.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.XrTableCell_Order_Date.Multiline = True
            Me.XrTableCell_Order_Date.Name = "XrTableCell_Order_Date"
            Me.XrTableCell_Order_Date.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell_Order_Date.StylePriority.UseBorderColor = False
            Me.XrTableCell_Order_Date.StylePriority.UseFont = False
            Me.XrTableCell_Order_Date.StylePriority.UsePadding = False
            Me.XrTableCell_Order_Date.StylePriority.UseTextAlignment = False
            Me.XrTableCell_Order_Date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell_Order_Date.TextFormatString = "{0:MMMM d, yyyy}"
            Me.XrTableCell_Order_Date.Weight = 1.6360318904529927R
            '
            'XrTableRow3
            '
            Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.XrTableCell_Address})
            Me.XrTableRow3.Name = "XrTableRow3"
            Me.XrTableRow3.Weight = 1.0R
            '
            'XrTableCell4
            '
            Me.XrTableCell4.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell4.BorderColor = System.Drawing.Color.White
            Me.XrTableCell4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.XrTableCell4.ForeColor = System.Drawing.Color.White
            Me.XrTableCell4.Multiline = True
            Me.XrTableCell4.Name = "XrTableCell4"
            Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell4.StylePriority.UseBackColor = False
            Me.XrTableCell4.StylePriority.UseBorderColor = False
            Me.XrTableCell4.StylePriority.UseFont = False
            Me.XrTableCell4.StylePriority.UseForeColor = False
            Me.XrTableCell4.StylePriority.UsePadding = False
            Me.XrTableCell4.Text = "ADDRESS"
            Me.XrTableCell4.Weight = 0.92250333300612564R
            '
            'XrTableCell_Address
            '
            Me.XrTableCell_Address.BackColor = System.Drawing.Color.Empty
            Me.XrTableCell_Address.BorderColor = System.Drawing.Color.Empty
            Me.XrTableCell_Address.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
            Me.XrTableCell_Address.ForeColor = System.Drawing.Color.Black
            Me.XrTableCell_Address.Multiline = True
            Me.XrTableCell_Address.Name = "XrTableCell_Address"
            Me.XrTableCell_Address.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell_Address.StylePriority.UseBackColor = False
            Me.XrTableCell_Address.StylePriority.UseBorderColor = False
            Me.XrTableCell_Address.StylePriority.UseFont = False
            Me.XrTableCell_Address.StylePriority.UseForeColor = False
            Me.XrTableCell_Address.StylePriority.UsePadding = False
            Me.XrTableCell_Address.Weight = 8.0375833575340625R
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4, Me.XrTable1})
            Me.PageHeader.HeightF = 95.00002!
            Me.PageHeader.Name = "PageHeader"
            '
            'XrTable4
            '
            Me.XrTable4.BorderColor = System.Drawing.Color.Transparent
            Me.XrTable4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTable4.ForeColor = System.Drawing.Color.Black
            Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 70.00002!)
            Me.XrTable4.Name = "XrTable4"
            Me.XrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
            Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
            Me.XrTable4.SizeF = New System.Drawing.SizeF(1200.0!, 25.0!)
            Me.XrTable4.StylePriority.UseBorderColor = False
            Me.XrTable4.StylePriority.UseFont = False
            Me.XrTable4.StylePriority.UseForeColor = False
            '
            'XrTableRow4
            '
            Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell9, Me.XrTableCell6, Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell18, Me.XrTableCell32, Me.XrTableCell21, Me.XrTableCell8, Me.XrTableCell13, Me.XrTableCell20})
            Me.XrTableRow4.Name = "XrTableRow4"
            Me.XrTableRow4.Weight = 1.0R
            '
            'XrTableCell7
            '
            Me.XrTableCell7.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell7.BorderColor = System.Drawing.Color.White
            Me.XrTableCell7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell7.ForeColor = System.Drawing.Color.White
            Me.XrTableCell7.Multiline = True
            Me.XrTableCell7.Name = "XrTableCell7"
            Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell7.StylePriority.UseBackColor = False
            Me.XrTableCell7.StylePriority.UseBorderColor = False
            Me.XrTableCell7.StylePriority.UseBorders = False
            Me.XrTableCell7.StylePriority.UseFont = False
            Me.XrTableCell7.StylePriority.UseForeColor = False
            Me.XrTableCell7.StylePriority.UsePadding = False
            Me.XrTableCell7.StylePriority.UseTextAlignment = False
            Me.XrTableCell7.Text = "PART NUMBER / SKU"
            Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.XrTableCell7.Weight = 2.913382439455372R
            '
            'XrTableCell9
            '
            Me.XrTableCell9.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell9.BorderColor = System.Drawing.Color.White
            Me.XrTableCell9.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell9.ForeColor = System.Drawing.Color.White
            Me.XrTableCell9.Multiline = True
            Me.XrTableCell9.Name = "XrTableCell9"
            Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell9.StylePriority.UseBackColor = False
            Me.XrTableCell9.StylePriority.UseBorderColor = False
            Me.XrTableCell9.StylePriority.UseBorders = False
            Me.XrTableCell9.StylePriority.UseFont = False
            Me.XrTableCell9.StylePriority.UseForeColor = False
            Me.XrTableCell9.StylePriority.UsePadding = False
            Me.XrTableCell9.StylePriority.UseTextAlignment = False
            Me.XrTableCell9.Text = "DESCRIPTION"
            Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.XrTableCell9.Weight = 3.6781453346393542R
            '
            'XrTableCell6
            '
            Me.XrTableCell6.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell6.BorderColor = System.Drawing.Color.White
            Me.XrTableCell6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell6.ForeColor = System.Drawing.Color.White
            Me.XrTableCell6.Multiline = True
            Me.XrTableCell6.Name = "XrTableCell6"
            Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell6.StylePriority.UseBackColor = False
            Me.XrTableCell6.StylePriority.UseBorderColor = False
            Me.XrTableCell6.StylePriority.UseBorders = False
            Me.XrTableCell6.StylePriority.UseFont = False
            Me.XrTableCell6.StylePriority.UseForeColor = False
            Me.XrTableCell6.StylePriority.UsePadding = False
            Me.XrTableCell6.StylePriority.UseTextAlignment = False
            Me.XrTableCell6.Text = "QTY"
            Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.XrTableCell6.Weight = 1.6428241948408604R
            '
            'XrTableCell14
            '
            Me.XrTableCell14.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell14.BorderColor = System.Drawing.Color.White
            Me.XrTableCell14.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell14.ForeColor = System.Drawing.Color.White
            Me.XrTableCell14.Multiline = True
            Me.XrTableCell14.Name = "XrTableCell14"
            Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell14.StylePriority.UseBackColor = False
            Me.XrTableCell14.StylePriority.UseBorderColor = False
            Me.XrTableCell14.StylePriority.UseBorders = False
            Me.XrTableCell14.StylePriority.UseFont = False
            Me.XrTableCell14.StylePriority.UseForeColor = False
            Me.XrTableCell14.StylePriority.UsePadding = False
            Me.XrTableCell14.StylePriority.UseTextAlignment = False
            Me.XrTableCell14.Text = "INVENTORY"
            Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.XrTableCell14.Weight = 1.7212280083403515R
            '
            'XrTableCell15
            '
            Me.XrTableCell15.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell15.BorderColor = System.Drawing.Color.White
            Me.XrTableCell15.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell15.ForeColor = System.Drawing.Color.White
            Me.XrTableCell15.Multiline = True
            Me.XrTableCell15.Name = "XrTableCell15"
            Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell15.StylePriority.UseBackColor = False
            Me.XrTableCell15.StylePriority.UseBorderColor = False
            Me.XrTableCell15.StylePriority.UseBorders = False
            Me.XrTableCell15.StylePriority.UseFont = False
            Me.XrTableCell15.StylePriority.UseForeColor = False
            Me.XrTableCell15.StylePriority.UsePadding = False
            Me.XrTableCell15.StylePriority.UseTextAlignment = False
            Me.XrTableCell15.Text = "SALES SUMMARY"
            Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.XrTableCell15.Weight = 1.7876000579888502R
            '
            'XrTableCell18
            '
            Me.XrTableCell18.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell18.BorderColor = System.Drawing.Color.White
            Me.XrTableCell18.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell18.ForeColor = System.Drawing.Color.White
            Me.XrTableCell18.Multiline = True
            Me.XrTableCell18.Name = "XrTableCell18"
            Me.XrTableCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableCell18.StylePriority.UseBackColor = False
            Me.XrTableCell18.StylePriority.UseBorderColor = False
            Me.XrTableCell18.StylePriority.UseBorders = False
            Me.XrTableCell18.StylePriority.UseFont = False
            Me.XrTableCell18.StylePriority.UseForeColor = False
            Me.XrTableCell18.StylePriority.UsePadding = False
            Me.XrTableCell18.StylePriority.UseTextAlignment = False
            Me.XrTableCell18.Text = "SRP"
            Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.XrTableCell18.Weight = 1.8085684515508398R
            '
            'XrTableCell32
            '
            Me.XrTableCell32.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell32.BorderColor = System.Drawing.Color.White
            Me.XrTableCell32.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell32.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell32.ForeColor = System.Drawing.Color.White
            Me.XrTableCell32.Multiline = True
            Me.XrTableCell32.Name = "XrTableCell32"
            Me.XrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableCell32.StylePriority.UseBackColor = False
            Me.XrTableCell32.StylePriority.UseBorderColor = False
            Me.XrTableCell32.StylePriority.UseBorders = False
            Me.XrTableCell32.StylePriority.UseFont = False
            Me.XrTableCell32.StylePriority.UseForeColor = False
            Me.XrTableCell32.StylePriority.UsePadding = False
            Me.XrTableCell32.StylePriority.UseTextAlignment = False
            Me.XrTableCell32.Text = "COST"
            Me.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.XrTableCell32.Weight = 2.1076821186979249R
            '
            'XrTableCell21
            '
            Me.XrTableCell21.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell21.BorderColor = System.Drawing.Color.White
            Me.XrTableCell21.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell21.ForeColor = System.Drawing.Color.White
            Me.XrTableCell21.Multiline = True
            Me.XrTableCell21.Name = "XrTableCell21"
            Me.XrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableCell21.StylePriority.UseBackColor = False
            Me.XrTableCell21.StylePriority.UseBorderColor = False
            Me.XrTableCell21.StylePriority.UseBorders = False
            Me.XrTableCell21.StylePriority.UseFont = False
            Me.XrTableCell21.StylePriority.UseForeColor = False
            Me.XrTableCell21.StylePriority.UsePadding = False
            Me.XrTableCell21.StylePriority.UseTextAlignment = False
            Me.XrTableCell21.Text = "TOTAL COST"
            Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.XrTableCell21.Weight = 1.8006317966635297R
            '
            'XrTableCell8
            '
            Me.XrTableCell8.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell8.BorderColor = System.Drawing.Color.White
            Me.XrTableCell8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell8.ForeColor = System.Drawing.Color.White
            Me.XrTableCell8.Multiline = True
            Me.XrTableCell8.Name = "XrTableCell8"
            Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableCell8.StylePriority.UseBackColor = False
            Me.XrTableCell8.StylePriority.UseBorderColor = False
            Me.XrTableCell8.StylePriority.UseBorders = False
            Me.XrTableCell8.StylePriority.UseFont = False
            Me.XrTableCell8.StylePriority.UseForeColor = False
            Me.XrTableCell8.StylePriority.UsePadding = False
            Me.XrTableCell8.StylePriority.UseTextAlignment = False
            Me.XrTableCell8.Text = "TOTAL SRP"
            Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.XrTableCell8.Weight = 1.9624872532268629R
            '
            'XrTableCell13
            '
            Me.XrTableCell13.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell13.BorderColor = System.Drawing.Color.White
            Me.XrTableCell13.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell13.ForeColor = System.Drawing.Color.White
            Me.XrTableCell13.Multiline = True
            Me.XrTableCell13.Name = "XrTableCell13"
            Me.XrTableCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableCell13.StylePriority.UseBackColor = False
            Me.XrTableCell13.StylePriority.UseBorderColor = False
            Me.XrTableCell13.StylePriority.UseBorders = False
            Me.XrTableCell13.StylePriority.UseFont = False
            Me.XrTableCell13.StylePriority.UseForeColor = False
            Me.XrTableCell13.StylePriority.UsePadding = False
            Me.XrTableCell13.StylePriority.UseTextAlignment = False
            Me.XrTableCell13.Text = "TOTAL REBATE"
            Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.XrTableCell13.Weight = 1.7075627000132974R
            '
            'XrTableCell20
            '
            Me.XrTableCell20.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(130, Byte), Integer))
            Me.XrTableCell20.BorderColor = System.Drawing.Color.White
            Me.XrTableCell20.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell20.ForeColor = System.Drawing.Color.White
            Me.XrTableCell20.Multiline = True
            Me.XrTableCell20.Name = "XrTableCell20"
            Me.XrTableCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableCell20.StylePriority.UseBackColor = False
            Me.XrTableCell20.StylePriority.UseBorderColor = False
            Me.XrTableCell20.StylePriority.UseBorders = False
            Me.XrTableCell20.StylePriority.UseFont = False
            Me.XrTableCell20.StylePriority.UseForeColor = False
            Me.XrTableCell20.StylePriority.UsePadding = False
            Me.XrTableCell20.StylePriority.UseTextAlignment = False
            Me.XrTableCell20.Text = "PROFIT"
            Me.XrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.XrTableCell20.Weight = 2.1769473073326928R
            '
            'PageFooter
            '
            Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageInfo1, Me.Product_Version, Me.pageInfo2})
            Me.PageFooter.HeightF = 22.99999!
            Me.PageFooter.Name = "PageFooter"
            '
            'pageInfo1
            '
            Me.pageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.pageInfo1.Name = "pageInfo1"
            Me.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
            Me.pageInfo1.SizeF = New System.Drawing.SizeF(200.0!, 22.99999!)
            '
            'Product_Version
            '
            Me.Product_Version.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Product_Version.ForeColor = System.Drawing.SystemColors.ControlDark
            Me.Product_Version.LocationFloat = New DevExpress.Utils.PointFloat(200.0!, 0!)
            Me.Product_Version.Name = "Product_Version"
            Me.Product_Version.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.Product_Version.SizeF = New System.Drawing.SizeF(451.4908!, 22.99999!)
            Me.Product_Version.StylePriority.UseFont = False
            Me.Product_Version.StylePriority.UseForeColor = False
            Me.Product_Version.StylePriority.UseTextAlignment = False
            Me.Product_Version.Text = "Product_Version"
            Me.Product_Version.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'pageInfo2
            '
            Me.pageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(651.4908!, 0!)
            Me.pageInfo2.Name = "pageInfo2"
            Me.pageInfo2.SizeF = New System.Drawing.SizeF(98.50922!, 22.99999!)
            Me.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
            Me.pageInfo2.TextFormatString = "Page {0} of {1}"
            '
            'XrTable3
            '
            Me.XrTable3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.XrTable3.Name = "XrTable3"
            Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow11, Me.XrTableRow10, Me.XrTableRow6, Me.XrTableRow5})
            Me.XrTable3.SizeF = New System.Drawing.SizeF(1200.0!, 100.0!)
            Me.XrTable3.StylePriority.UseFont = False
            '
            'XrTableRow11
            '
            Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell52, Me.XrTableCell34, Me.XrTableCell35, Me.XrTableCell37, Me.XrTableCell40, Me.XrTableCell55, Me.XrTableCell49, Me.XrTableCell43, Me.XrTableCell46, Me.XrTableCell36})
            Me.XrTableRow11.Name = "XrTableRow11"
            Me.XrTableRow11.Weight = 1.0R
            '
            'XrTableCell52
            '
            Me.XrTableCell52.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell52.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.XrTableCell52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell52.Multiline = True
            Me.XrTableCell52.Name = "XrTableCell52"
            Me.XrTableCell52.StylePriority.UseBorderColor = False
            Me.XrTableCell52.StylePriority.UseBorders = False
            Me.XrTableCell52.StylePriority.UseFont = False
            Me.XrTableCell52.StylePriority.UseTextAlignment = False
            Me.XrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell52.Weight = 3.3694885338570839R
            '
            'XrTableCell34
            '
            Me.XrTableCell34.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell34.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.XrTableCell34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell34.Name = "XrTableCell34"
            Me.XrTableCell34.StylePriority.UseBorderColor = False
            Me.XrTableCell34.StylePriority.UseBorders = False
            Me.XrTableCell34.StylePriority.UseFont = False
            Me.XrTableCell34.StylePriority.UseTextAlignment = False
            Me.XrTableCell34.Text = "Total:"
            Me.XrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell34.Weight = 1.0611979935246034R
            '
            'XrTableCell35
            '
            Me.XrTableCell35.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell35.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell35.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(([Quantity_Order]))")})
            Me.XrTableCell35.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell35.Name = "XrTableCell35"
            Me.XrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell35.StylePriority.UseBorderColor = False
            Me.XrTableCell35.StylePriority.UseBorders = False
            Me.XrTableCell35.StylePriority.UseFont = False
            Me.XrTableCell35.StylePriority.UsePadding = False
            Me.XrTableCell35.StylePriority.UseTextAlignment = False
            XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.XrTableCell35.Summary = XrSummary1
            Me.XrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell35.TextFormatString = "{0:#,#}"
            Me.XrTableCell35.Weight = 1.10427375696913R
            '
            'XrTableCell37
            '
            Me.XrTableCell37.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell37.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell37.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(([Remaining_Inventory]))")})
            Me.XrTableCell37.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell37.Multiline = True
            Me.XrTableCell37.Name = "XrTableCell37"
            Me.XrTableCell37.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 20, 0, 0, 100.0!)
            Me.XrTableCell37.StylePriority.UseBorderColor = False
            Me.XrTableCell37.StylePriority.UseBorders = False
            Me.XrTableCell37.StylePriority.UseFont = False
            Me.XrTableCell37.StylePriority.UsePadding = False
            Me.XrTableCell37.StylePriority.UseTextAlignment = False
            XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.XrTableCell37.Summary = XrSummary2
            Me.XrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell37.TextFormatString = "{0:#,#}"
            Me.XrTableCell37.Weight = 1.1569700661147309R
            '
            'XrTableCell40
            '
            Me.XrTableCell40.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell40.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell40.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(([Sales_Summary]))")})
            Me.XrTableCell40.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell40.Multiline = True
            Me.XrTableCell40.Name = "XrTableCell40"
            Me.XrTableCell40.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 20, 0, 0, 100.0!)
            Me.XrTableCell40.StylePriority.UseBorderColor = False
            Me.XrTableCell40.StylePriority.UseBorders = False
            Me.XrTableCell40.StylePriority.UseFont = False
            Me.XrTableCell40.StylePriority.UsePadding = False
            Me.XrTableCell40.StylePriority.UseTextAlignment = False
            XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.XrTableCell40.Summary = XrSummary3
            Me.XrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell40.TextFormatString = "{0:#,#}"
            Me.XrTableCell40.Weight = 1.2015870940404618R
            '
            'XrTableCell55
            '
            Me.XrTableCell55.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell55.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell55.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell55.Multiline = True
            Me.XrTableCell55.Name = "XrTableCell55"
            Me.XrTableCell55.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 20, 0, 0, 100.0!)
            Me.XrTableCell55.StylePriority.UseBorderColor = False
            Me.XrTableCell55.StylePriority.UseBorders = False
            Me.XrTableCell55.StylePriority.UseFont = False
            Me.XrTableCell55.StylePriority.UsePadding = False
            Me.XrTableCell55.StylePriority.UseTextAlignment = False
            Me.XrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell55.Weight = 2.6324212384241497R
            '
            'XrTableCell49
            '
            Me.XrTableCell49.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell49.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell49.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(([Total_Cost]))")})
            Me.XrTableCell49.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell49.Multiline = True
            Me.XrTableCell49.Name = "XrTableCell49"
            Me.XrTableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 20, 0, 0, 100.0!)
            Me.XrTableCell49.StylePriority.UseBorderColor = False
            Me.XrTableCell49.StylePriority.UseBorders = False
            Me.XrTableCell49.StylePriority.UseFont = False
            Me.XrTableCell49.StylePriority.UsePadding = False
            Me.XrTableCell49.StylePriority.UseTextAlignment = False
            XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.XrTableCell49.Summary = XrSummary4
            Me.XrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell49.TextFormatString = "{0:N2}"
            Me.XrTableCell49.Weight = 1.2103468229150747R
            '
            'XrTableCell43
            '
            Me.XrTableCell43.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell43.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell43.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(([Total_SRP]))")})
            Me.XrTableCell43.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell43.Multiline = True
            Me.XrTableCell43.Name = "XrTableCell43"
            Me.XrTableCell43.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 20, 0, 0, 100.0!)
            Me.XrTableCell43.StylePriority.UseBorderColor = False
            Me.XrTableCell43.StylePriority.UseBorders = False
            Me.XrTableCell43.StylePriority.UseFont = False
            Me.XrTableCell43.StylePriority.UsePadding = False
            Me.XrTableCell43.StylePriority.UseTextAlignment = False
            XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.XrTableCell43.Summary = XrSummary5
            Me.XrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell43.TextFormatString = "{0:N2}"
            Me.XrTableCell43.Weight = 1.3191425385815763R
            '
            'XrTableCell46
            '
            Me.XrTableCell46.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell46.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell46.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(([Total_Rebates]))")})
            Me.XrTableCell46.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell46.Multiline = True
            Me.XrTableCell46.Name = "XrTableCell46"
            Me.XrTableCell46.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 20, 0, 0, 100.0!)
            Me.XrTableCell46.StylePriority.UseBorderColor = False
            Me.XrTableCell46.StylePriority.UseBorders = False
            Me.XrTableCell46.StylePriority.UseFont = False
            Me.XrTableCell46.StylePriority.UsePadding = False
            Me.XrTableCell46.StylePriority.UseTextAlignment = False
            XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.XrTableCell46.Summary = XrSummary6
            Me.XrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell46.TextFormatString = "{0:N2}"
            Me.XrTableCell46.Weight = 1.147787564421396R
            '
            'XrTableCell36
            '
            Me.XrTableCell36.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell36.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell36.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum(([Net_Profit]))")})
            Me.XrTableCell36.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell36.Name = "XrTableCell36"
            Me.XrTableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 20, 0, 0, 100.0!)
            Me.XrTableCell36.StylePriority.UseBorderColor = False
            Me.XrTableCell36.StylePriority.UseBorders = False
            Me.XrTableCell36.StylePriority.UseFont = False
            Me.XrTableCell36.StylePriority.UsePadding = False
            Me.XrTableCell36.StylePriority.UseTextAlignment = False
            XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
            Me.XrTableCell36.Summary = XrSummary7
            Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell36.TextFormatString = "{0:N2}"
            Me.XrTableCell36.Weight = 1.4632985877498164R
            '
            'XrTableRow10
            '
            Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell53, Me.XrTableCell12, Me.XrTableCell28, Me.XrTableCell38, Me.XrTableCell29})
            Me.XrTableRow10.Name = "XrTableRow10"
            Me.XrTableRow10.Weight = 1.0R
            '
            'XrTableCell53
            '
            Me.XrTableCell53.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell53.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell53.Multiline = True
            Me.XrTableCell53.Name = "XrTableCell53"
            Me.XrTableCell53.StylePriority.UseBorders = False
            Me.XrTableCell53.StylePriority.UseFont = False
            Me.XrTableCell53.StylePriority.UseTextAlignment = False
            Me.XrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell53.Weight = 0.54319387968987R
            '
            'XrTableCell12
            '
            Me.XrTableCell12.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell12.Multiline = True
            Me.XrTableCell12.Name = "XrTableCell12"
            Me.XrTableCell12.StylePriority.UseBorders = False
            Me.XrTableCell12.StylePriority.UseFont = False
            Me.XrTableCell12.StylePriority.UseTextAlignment = False
            Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell12.Weight = 0.54319387968987R
            '
            'XrTableCell28
            '
            Me.XrTableCell28.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell28.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell28.Multiline = True
            Me.XrTableCell28.Name = "XrTableCell28"
            Me.XrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell28.StylePriority.UseBorders = False
            Me.XrTableCell28.StylePriority.UseFont = False
            Me.XrTableCell28.StylePriority.UsePadding = False
            Me.XrTableCell28.StylePriority.UseTextAlignment = False
            Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell28.Weight = 0.51957677484383469R
            '
            'XrTableCell38
            '
            Me.XrTableCell38.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell38.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell38.Multiline = True
            Me.XrTableCell38.Name = "XrTableCell38"
            Me.XrTableCell38.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 20, 0, 0, 100.0!)
            Me.XrTableCell38.StylePriority.UseBorders = False
            Me.XrTableCell38.StylePriority.UseFont = False
            Me.XrTableCell38.StylePriority.UsePadding = False
            Me.XrTableCell38.StylePriority.UseTextAlignment = False
            Me.XrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell38.Weight = 0.95217686453664419R
            '
            'XrTableCell29
            '
            Me.XrTableCell29.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.XrTableCell29.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.[Double]
            Me.XrTableCell29.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.XrTableCell29.CanGrow = False
            Me.XrTableCell29.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell29.Name = "XrTableCell29"
            Me.XrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 20, 0, 0, 100.0!)
            Me.XrTableCell29.StylePriority.UseBorderColor = False
            Me.XrTableCell29.StylePriority.UseBorderDashStyle = False
            Me.XrTableCell29.StylePriority.UseBorders = False
            Me.XrTableCell29.StylePriority.UseFont = False
            Me.XrTableCell29.StylePriority.UsePadding = False
            Me.XrTableCell29.StylePriority.UseTextAlignment = False
            Me.XrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell29.Weight = 6.4872187455842845R
            Me.XrTableCell29.WordWrap = False
            '
            'XrTableRow6
            '
            Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell54, Me.XrTableCell16, Me.XrTableCell19, Me.XrTableCell39, Me.XrTableCell42, Me.XrTableCell51, Me.XrTableCell45, Me.XrTableCell48, Me.XrTableCell17})
            Me.XrTableRow6.Name = "XrTableRow6"
            Me.XrTableRow6.Weight = 1.0R
            '
            'XrTableCell54
            '
            Me.XrTableCell54.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell54.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell54.Multiline = True
            Me.XrTableCell54.Name = "XrTableCell54"
            Me.XrTableCell54.StylePriority.UseBorders = False
            Me.XrTableCell54.StylePriority.UseFont = False
            Me.XrTableCell54.StylePriority.UseTextAlignment = False
            Me.XrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell54.Weight = 0.54319391572674647R
            '
            'XrTableCell16
            '
            Me.XrTableCell16.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell16.Name = "XrTableCell16"
            Me.XrTableCell16.StylePriority.UseBorders = False
            Me.XrTableCell16.StylePriority.UseFont = False
            Me.XrTableCell16.StylePriority.UseTextAlignment = False
            Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell16.Weight = 0.54319391572674647R
            '
            'XrTableCell19
            '
            Me.XrTableCell19.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell19.CanShrink = True
            Me.XrTableCell19.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell19.Name = "XrTableCell19"
            Me.XrTableCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.XrTableCell19.StylePriority.UseBorders = False
            Me.XrTableCell19.StylePriority.UseFont = False
            Me.XrTableCell19.StylePriority.UsePadding = False
            Me.XrTableCell19.StylePriority.UseTextAlignment = False
            Me.XrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell19.Weight = 0.51957681088071106R
            Me.XrTableCell19.WordWrap = False
            '
            'XrTableCell39
            '
            Me.XrTableCell39.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell39.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell39.Multiline = True
            Me.XrTableCell39.Name = "XrTableCell39"
            Me.XrTableCell39.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100.0!)
            Me.XrTableCell39.StylePriority.UseBorders = False
            Me.XrTableCell39.StylePriority.UseFont = False
            Me.XrTableCell39.StylePriority.UsePadding = False
            Me.XrTableCell39.StylePriority.UseTextAlignment = False
            Me.XrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell39.Weight = 1.0627707293720943R
            '
            'XrTableCell42
            '
            Me.XrTableCell42.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell42.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell42.Multiline = True
            Me.XrTableCell42.Name = "XrTableCell42"
            Me.XrTableCell42.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100.0!)
            Me.XrTableCell42.StylePriority.UseBorders = False
            Me.XrTableCell42.StylePriority.UseFont = False
            Me.XrTableCell42.StylePriority.UsePadding = False
            Me.XrTableCell42.StylePriority.UseTextAlignment = False
            Me.XrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell42.Weight = 1.0627707293720943R
            '
            'XrTableCell51
            '
            Me.XrTableCell51.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell51.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell51.Multiline = True
            Me.XrTableCell51.Name = "XrTableCell51"
            Me.XrTableCell51.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100.0!)
            Me.XrTableCell51.StylePriority.UseBorders = False
            Me.XrTableCell51.StylePriority.UseFont = False
            Me.XrTableCell51.StylePriority.UsePadding = False
            Me.XrTableCell51.StylePriority.UseTextAlignment = False
            Me.XrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell51.Weight = 1.0627707293720943R
            '
            'XrTableCell45
            '
            Me.XrTableCell45.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell45.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell45.Multiline = True
            Me.XrTableCell45.Name = "XrTableCell45"
            Me.XrTableCell45.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100.0!)
            Me.XrTableCell45.StylePriority.UseBorders = False
            Me.XrTableCell45.StylePriority.UseFont = False
            Me.XrTableCell45.StylePriority.UsePadding = False
            Me.XrTableCell45.StylePriority.UseTextAlignment = False
            Me.XrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell45.Weight = 1.0627707293720943R
            '
            'XrTableCell48
            '
            Me.XrTableCell48.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell48.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell48.Multiline = True
            Me.XrTableCell48.Name = "XrTableCell48"
            Me.XrTableCell48.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100.0!)
            Me.XrTableCell48.StylePriority.UseBorders = False
            Me.XrTableCell48.StylePriority.UseFont = False
            Me.XrTableCell48.StylePriority.UsePadding = False
            Me.XrTableCell48.StylePriority.UseTextAlignment = False
            Me.XrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell48.Weight = 1.0627707293720943R
            '
            'XrTableCell17
            '
            Me.XrTableCell17.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.XrTableCell17.CanShrink = True
            Me.XrTableCell17.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell17.Name = "XrTableCell17"
            Me.XrTableCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 100.0!)
            Me.XrTableCell17.StylePriority.UseBorders = False
            Me.XrTableCell17.StylePriority.UseFont = False
            Me.XrTableCell17.StylePriority.UsePadding = False
            Me.XrTableCell17.StylePriority.UseTextAlignment = False
            Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.XrTableCell17.Weight = 2.1255414587441885R
            Me.XrTableCell17.WordWrap = False
            '
            'XrTableRow5
            '
            Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Prepared_By, Me.Verified_By, Me.Checked_By, Me.Recommended_By, Me.Approved_By})
            Me.XrTableRow5.Name = "XrTableRow5"
            Me.XrTableRow5.Weight = 1.0R
            '
            'Prepared_By
            '
            Me.Prepared_By.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Prepared_By.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Prepared_By.Multiline = True
            Me.Prepared_By.Name = "Prepared_By"
            Me.Prepared_By.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Prepared_By.StylePriority.UseBorders = False
            Me.Prepared_By.StylePriority.UseFont = False
            Me.Prepared_By.StylePriority.UsePadding = False
            Me.Prepared_By.StylePriority.UseTextAlignment = False
            Me.Prepared_By.Text = "Prepared By"
            Me.Prepared_By.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Prepared_By.Weight = 0.67739876971583446R
            '
            'Verified_By
            '
            Me.Verified_By.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Verified_By.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Verified_By.Multiline = True
            Me.Verified_By.Name = "Verified_By"
            Me.Verified_By.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Verified_By.StylePriority.UseBorders = False
            Me.Verified_By.StylePriority.UseFont = False
            Me.Verified_By.StylePriority.UsePadding = False
            Me.Verified_By.StylePriority.UseTextAlignment = False
            Me.Verified_By.Text = "Verified By"
            Me.Verified_By.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Verified_By.Weight = 0.74506633488510265R
            '
            'Checked_By
            '
            Me.Checked_By.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Checked_By.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Checked_By.Multiline = True
            Me.Checked_By.Name = "Checked_By"
            Me.Checked_By.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Checked_By.StylePriority.UseBorders = False
            Me.Checked_By.StylePriority.UseFont = False
            Me.Checked_By.StylePriority.UsePadding = False
            Me.Checked_By.StylePriority.UseTextAlignment = False
            Me.Checked_By.Text = "Endorsed By"
            Me.Checked_By.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Checked_By.Weight = 0.81639051145095975R
            '
            'Recommended_By
            '
            Me.Recommended_By.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Recommended_By.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Recommended_By.Multiline = True
            Me.Recommended_By.Name = "Recommended_By"
            Me.Recommended_By.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Recommended_By.StylePriority.UseBorders = False
            Me.Recommended_By.StylePriority.UseFont = False
            Me.Recommended_By.StylePriority.UsePadding = False
            Me.Recommended_By.StylePriority.UseTextAlignment = False
            Me.Recommended_By.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Recommended_By.Weight = 0.33151827243777343R
            '
            'Approved_By
            '
            Me.Approved_By.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Approved_By.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Approved_By.Multiline = True
            Me.Approved_By.Name = "Approved_By"
            Me.Approved_By.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Approved_By.StylePriority.UseBorders = False
            Me.Approved_By.StylePriority.UseFont = False
            Me.Approved_By.StylePriority.UsePadding = False
            Me.Approved_By.StylePriority.UseTextAlignment = False
            Me.Approved_By.Text = "Approved By"
            Me.Approved_By.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Approved_By.Weight = 1.1203456566530026R
            '
            'ReportFooter
            '
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2, Me.XrTable3})
            Me.ReportFooter.HeightF = 216.4868!
            Me.ReportFooter.Name = "ReportFooter"
            '
            'XrTable2
            '
            Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 148.764!)
            Me.XrTable2.Name = "XrTable2"
            Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
            Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow8, Me.XrTableRow7})
            Me.XrTable2.SizeF = New System.Drawing.SizeF(1200.0!, 40.0!)
            '
            'XrTableRow8
            '
            Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Prepared_Personnel, Me.Verified_Personnel, Me.Checked_Personnel, Me.Recommend, Me.Approved_Personnel})
            Me.XrTableRow8.Name = "XrTableRow8"
            Me.XrTableRow8.Weight = 1.0R
            '
            'Prepared_Personnel
            '
            Me.Prepared_Personnel.CanShrink = True
            Me.Prepared_Personnel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Prepared_Personnel.Name = "Prepared_Personnel"
            Me.Prepared_Personnel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Prepared_Personnel.StylePriority.UseFont = False
            Me.Prepared_Personnel.StylePriority.UsePadding = False
            Me.Prepared_Personnel.StylePriority.UseTextAlignment = False
            Me.Prepared_Personnel.Text = "RICHARD DALUCANOG"
            Me.Prepared_Personnel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Prepared_Personnel.Weight = 0.92000002034505224R
            Me.Prepared_Personnel.WordWrap = False
            '
            'Verified_Personnel
            '
            Me.Verified_Personnel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Verified_Personnel.Multiline = True
            Me.Verified_Personnel.Name = "Verified_Personnel"
            Me.Verified_Personnel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Verified_Personnel.StylePriority.UseFont = False
            Me.Verified_Personnel.StylePriority.UsePadding = False
            Me.Verified_Personnel.StylePriority.UseTextAlignment = False
            Me.Verified_Personnel.Text = "JAMES S. OMANDAM"
            Me.Verified_Personnel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Verified_Personnel.Weight = 1.0119015425046287R
            '
            'Checked_Personnel
            '
            Me.Checked_Personnel.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.Checked_Personnel.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Checked_Personnel.CanShrink = True
            Me.Checked_Personnel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Checked_Personnel.Name = "Checked_Personnel"
            Me.Checked_Personnel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Checked_Personnel.StylePriority.UseBorderColor = False
            Me.Checked_Personnel.StylePriority.UseBorders = False
            Me.Checked_Personnel.StylePriority.UseFont = False
            Me.Checked_Personnel.StylePriority.UsePadding = False
            Me.Checked_Personnel.StylePriority.UseTextAlignment = False
            Me.Checked_Personnel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Checked_Personnel.Weight = 1.1087693120638527R
            Me.Checked_Personnel.WordWrap = False
            '
            'Recommend
            '
            Me.Recommend.CanShrink = True
            Me.Recommend.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Recommend.Name = "Recommend"
            Me.Recommend.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Recommend.StylePriority.UseFont = False
            Me.Recommend.StylePriority.UsePadding = False
            Me.Recommend.StylePriority.UseTextAlignment = False
            Me.Recommend.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Recommend.Weight = 0.45024722131093337R
            Me.Recommend.WordWrap = False
            '
            'Approved_Personnel
            '
            Me.Approved_Personnel.BorderColor = System.Drawing.SystemColors.HotTrack
            Me.Approved_Personnel.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.Approved_Personnel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Approved_Personnel.Multiline = True
            Me.Approved_Personnel.Name = "Approved_Personnel"
            Me.Approved_Personnel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Approved_Personnel.StylePriority.UseBorderColor = False
            Me.Approved_Personnel.StylePriority.UseBorders = False
            Me.Approved_Personnel.StylePriority.UseFont = False
            Me.Approved_Personnel.StylePriority.UsePadding = False
            Me.Approved_Personnel.StylePriority.UseTextAlignment = False
            Me.Approved_Personnel.Text = "MARIA KATRINA FRANCESCA H. ROLEDA"
            Me.Approved_Personnel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Approved_Personnel.Weight = 1.5215819037755327R
            '
            'XrTableRow7
            '
            Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Prepared_Position, Me.Verified_Position, Me.Checked_Position, Me.Position, Me.Approved_Position})
            Me.XrTableRow7.Name = "XrTableRow7"
            Me.XrTableRow7.Weight = 1.0R
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
            Me.Prepared_Position.Text = "Spare Parts Supervisor"
            Me.Prepared_Position.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Prepared_Position.Weight = 0.92000002034505224R
            '
            'Verified_Position
            '
            Me.Verified_Position.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Verified_Position.Multiline = True
            Me.Verified_Position.Name = "Verified_Position"
            Me.Verified_Position.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Verified_Position.StylePriority.UseFont = False
            Me.Verified_Position.StylePriority.UsePadding = False
            Me.Verified_Position.StylePriority.UseTextAlignment = False
            Me.Verified_Position.Text = "VP - Operations & Sales"
            Me.Verified_Position.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Verified_Position.Weight = 1.0119015425046287R
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
            Me.Checked_Position.Text = "Comptroller"
            Me.Checked_Position.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Checked_Position.Weight = 1.1087695670127864R
            '
            'Position
            '
            Me.Position.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Position.Multiline = True
            Me.Position.Name = "Position"
            Me.Position.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Position.StylePriority.UseFont = False
            Me.Position.StylePriority.UsePadding = False
            Me.Position.StylePriority.UseTextAlignment = False
            Me.Position.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Position.Weight = 0.45024722131093342R
            '
            'Approved_Position
            '
            Me.Approved_Position.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Approved_Position.Multiline = True
            Me.Approved_Position.Name = "Approved_Position"
            Me.Approved_Position.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
            Me.Approved_Position.StylePriority.UseFont = False
            Me.Approved_Position.StylePriority.UsePadding = False
            Me.Approved_Position.StylePriority.UseTextAlignment = False
            Me.Approved_Position.Text = "President & CEO"
            Me.Approved_Position.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Approved_Position.Weight = 1.5215816488265987R
            '
            'SqlDataSource
            '
            Me.SqlDataSource.ConnectionName = "ics.ICS.dbo"
            MsSqlConnectionParameters1.AuthorizationType = DevExpress.DataAccess.ConnectionParameters.MsSqlAuthorizationType.SqlServer
            MsSqlConnectionParameters1.DatabaseName = "ICS"
            MsSqlConnectionParameters1.ServerName = "192.168.13.15"
            Me.SqlDataSource.ConnectionParameters = MsSqlConnectionParameters1
            Me.SqlDataSource.Name = "SqlDataSource"
            ColumnExpression1.ColumnName = "BranchCode"
            Table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""903"" />"
            Table1.Name = "TransactionPettyCash"
            ColumnExpression1.Table = Table1
            Column1.Expression = ColumnExpression1
            ColumnExpression2.ColumnName = "PTCCategory"
            ColumnExpression2.Table = Table1
            Column2.Expression = ColumnExpression2
            ColumnExpression3.ColumnName = "ExpDetails"
            ColumnExpression3.Table = Table1
            Column3.Expression = ColumnExpression3
            ColumnExpression4.ColumnName = "Recipient"
            ColumnExpression4.Table = Table1
            Column4.Expression = ColumnExpression4
            ColumnExpression5.ColumnName = "AccountName"
            ColumnExpression5.Table = Table1
            Column5.Expression = ColumnExpression5
            ColumnExpression6.ColumnName = "EngineNo"
            ColumnExpression6.Table = Table1
            Column6.Expression = ColumnExpression6
            ColumnExpression7.ColumnName = "ORNo"
            ColumnExpression7.Table = Table1
            Column7.Expression = ColumnExpression7
            ColumnExpression8.ColumnName = "AmountPaid"
            ColumnExpression8.Table = Table1
            Column8.Expression = ColumnExpression8
            ColumnExpression9.ColumnName = "AmntNetofVAT"
            ColumnExpression9.Table = Table1
            Column9.Expression = ColumnExpression9
            ColumnExpression10.ColumnName = "Corp"
            ColumnExpression10.Table = Table1
            Column10.Expression = ColumnExpression10
            ColumnExpression11.ColumnName = "Particulars"
            ColumnExpression11.Table = Table1
            Column11.Expression = ColumnExpression11
            ColumnExpression12.ColumnName = "TransStatus"
            ColumnExpression12.Table = Table1
            Column12.Expression = ColumnExpression12
            ColumnExpression13.ColumnName = "Notes"
            ColumnExpression13.Table = Table1
            Column13.Expression = ColumnExpression13
            ColumnExpression14.ColumnName = "Vendor"
            ColumnExpression14.Table = Table1
            Column14.Expression = ColumnExpression14
            ColumnExpression15.ColumnName = "VATAmt"
            ColumnExpression15.Table = Table1
            Column15.Expression = ColumnExpression15
            ColumnExpression16.ColumnName = "IsDeleted"
            ColumnExpression16.Table = Table1
            Column16.Expression = ColumnExpression16
            ColumnExpression17.ColumnName = "Expense_Code"
            ColumnExpression17.Table = Table1
            Column17.Expression = ColumnExpression17
            ColumnExpression18.ColumnName = "PostingDate"
            ColumnExpression18.Table = Table1
            Column18.Expression = ColumnExpression18
            SelectQuery1.Columns.Add(Column1)
            SelectQuery1.Columns.Add(Column2)
            SelectQuery1.Columns.Add(Column3)
            SelectQuery1.Columns.Add(Column4)
            SelectQuery1.Columns.Add(Column5)
            SelectQuery1.Columns.Add(Column6)
            SelectQuery1.Columns.Add(Column7)
            SelectQuery1.Columns.Add(Column8)
            SelectQuery1.Columns.Add(Column9)
            SelectQuery1.Columns.Add(Column10)
            SelectQuery1.Columns.Add(Column11)
            SelectQuery1.Columns.Add(Column12)
            SelectQuery1.Columns.Add(Column13)
            SelectQuery1.Columns.Add(Column14)
            SelectQuery1.Columns.Add(Column15)
            SelectQuery1.Columns.Add(Column16)
            SelectQuery1.Columns.Add(Column17)
            SelectQuery1.Columns.Add(Column18)
            SelectQuery1.Name = "TransactionPettyCash"
            SelectQuery1.Tables.Add(Table1)
            Me.SqlDataSource.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {SelectQuery1})
            Me.SqlDataSource.ResultSchemaSerializable = resources.GetString("SqlDataSource.ResultSchemaSerializable")
            '
            'xrpt_SPA_Purchase_Orders
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader, Me.PageHeader, Me.PageFooter, Me.ReportFooter})
            Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.SqlDataSource})
            Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Landscape = True
            Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
            Me.PageHeight = 850
            Me.PageWidth = 1300
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.Version = "20.2"
            CType(Me.XrTable5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_Corporation As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents label_Document_Title As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Brand As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Purchase_Order_Code As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Dealer As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Order_Date As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Address As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
        Friend WithEvents pageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
        Friend WithEvents Product_Version As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents pageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
        Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
        Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents SqlDataSource As DevExpress.DataAccess.Sql.SqlDataSource
        Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Prepared_By As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Checked_By As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Recommended_By As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Prepared_Personnel As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Checked_Personnel As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Recommend As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Prepared_Position As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Checked_Position As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Position As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTable5 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell19 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell20 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Verified_Personnel As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Verified_Position As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Verified_By As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell37 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell40 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell43 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell46 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell38 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell42 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell45 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell48 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell51 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell52 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell53 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell54 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell55 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Approved_By As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Approved_Personnel As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Approved_Position As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace