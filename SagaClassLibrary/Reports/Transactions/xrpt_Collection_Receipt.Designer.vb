Namespace Reports.Transactions
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class xrpt_Collection_Receipt
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
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Reference = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Amortization = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Interest = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.VAT = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow15 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.NoVAT = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Penalty = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Rebates = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Total = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Notes = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Outstanding_Balance = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Customer_Name = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Customer_Address = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Amount_Words = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow16 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Amount_Received = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.Posting_Date = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow18 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Discount = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Printed_By = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.XrTableRow19 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Printed_Date = New DevExpress.XtraReports.UI.XRTableCell()
            CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'TopMargin
            '
            Me.TopMargin.HeightF = 70.0!
            Me.TopMargin.Name = "TopMargin"
            '
            'BottomMargin
            '
            Me.BottomMargin.HeightF = 50.0!
            Me.BottomMargin.Name = "BottomMargin"
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2, Me.XrTable1})
            Me.Detail.HeightF = 365.0!
            Me.Detail.Name = "Detail"
            '
            'XrTable2
            '
            Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 115.0!)
            Me.XrTable2.Name = "XrTable2"
            Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
            Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7, Me.XrTableRow4, Me.XrTableRow11, Me.XrTableRow14, Me.XrTableRow15, Me.XrTableRow12, Me.XrTableRow13, Me.XrTableRow18, Me.XrTableRow6, Me.XrTableRow9, Me.XrTableRow10, Me.XrTableRow8, Me.XrTableRow5, Me.XrTableRow19})
            Me.XrTable2.SizeF = New System.Drawing.SizeF(370.0!, 250.0!)
            '
            'XrTableRow7
            '
            Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.Reference})
            Me.XrTableRow7.Name = "XrTableRow7"
            Me.XrTableRow7.Weight = 1.0R
            '
            'XrTableCell1
            '
            Me.XrTableCell1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell1.Multiline = True
            Me.XrTableCell1.Name = "XrTableCell1"
            Me.XrTableCell1.StylePriority.UseFont = False
            Me.XrTableCell1.StylePriority.UseTextAlignment = False
            Me.XrTableCell1.Text = "REFERENCE:"
            Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell1.Weight = 1.9459459377596939R
            '
            'Reference
            '
            Me.Reference.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Reference.Multiline = True
            Me.Reference.Name = "Reference"
            Me.Reference.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100.0!)
            Me.Reference.StylePriority.UseFont = False
            Me.Reference.StylePriority.UsePadding = False
            Me.Reference.StylePriority.UseTextAlignment = False
            Me.Reference.Text = "Reference"
            Me.Reference.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Reference.Weight = 4.054054062240307R
            '
            'XrTableRow4
            '
            Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.Amortization})
            Me.XrTableRow4.Name = "XrTableRow4"
            Me.XrTableRow4.Weight = 1.0R
            '
            'XrTableCell2
            '
            Me.XrTableCell2.CanShrink = True
            Me.XrTableCell2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell2.Multiline = True
            Me.XrTableCell2.Name = "XrTableCell2"
            Me.XrTableCell2.StylePriority.UseFont = False
            Me.XrTableCell2.StylePriority.UseTextAlignment = False
            Me.XrTableCell2.Text = "AMORTIZATION"
            Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell2.Weight = 1.9459459468218352R
            '
            'Amortization
            '
            Me.Amortization.CanShrink = True
            Me.Amortization.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Amortization.Multiline = True
            Me.Amortization.Name = "Amortization"
            Me.Amortization.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Amortization.StylePriority.UseFont = False
            Me.Amortization.StylePriority.UsePadding = False
            Me.Amortization.StylePriority.UseTextAlignment = False
            Me.Amortization.Text = "0.00"
            Me.Amortization.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Amortization.TextFormatString = "{0:N2}"
            Me.Amortization.Weight = 4.0540540531781657R
            '
            'XrTableRow11
            '
            Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.Interest})
            Me.XrTableRow11.Name = "XrTableRow11"
            Me.XrTableRow11.Weight = 1.0R
            '
            'XrTableCell9
            '
            Me.XrTableCell9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell9.Multiline = True
            Me.XrTableCell9.Name = "XrTableCell9"
            Me.XrTableCell9.StylePriority.UseFont = False
            Me.XrTableCell9.StylePriority.UseTextAlignment = False
            Me.XrTableCell9.Text = "VATABLE SALES"
            Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell9.Weight = 3.2432432805032896R
            '
            'Interest
            '
            Me.Interest.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Interest.Multiline = True
            Me.Interest.Name = "Interest"
            Me.Interest.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 20, 0, 0, 100.0!)
            Me.Interest.StylePriority.UseFont = False
            Me.Interest.StylePriority.UsePadding = False
            Me.Interest.StylePriority.UseTextAlignment = False
            Me.Interest.Text = "0.00"
            Me.Interest.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.Interest.TextFormatString = "{0:N2}"
            Me.Interest.Weight = 2.7567567194967113R
            '
            'XrTableRow14
            '
            Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10, Me.VAT})
            Me.XrTableRow14.Name = "XrTableRow14"
            Me.XrTableRow14.Weight = 1.0R
            '
            'XrTableCell10
            '
            Me.XrTableCell10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell10.Multiline = True
            Me.XrTableCell10.Name = "XrTableCell10"
            Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 0, 0, 0, 100.0!)
            Me.XrTableCell10.StylePriority.UseFont = False
            Me.XrTableCell10.StylePriority.UsePadding = False
            Me.XrTableCell10.StylePriority.UseTextAlignment = False
            Me.XrTableCell10.Text = "VAT"
            Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell10.Weight = 2.432432484610175R
            '
            'VAT
            '
            Me.VAT.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.VAT.Multiline = True
            Me.VAT.Name = "VAT"
            Me.VAT.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 80, 0, 0, 100.0!)
            Me.VAT.StylePriority.UseFont = False
            Me.VAT.StylePriority.UsePadding = False
            Me.VAT.StylePriority.UseTextAlignment = False
            Me.VAT.Text = "0.00"
            Me.VAT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.VAT.TextFormatString = "{0:N2}"
            Me.VAT.Weight = 3.5675675153898259R
            '
            'XrTableRow15
            '
            Me.XrTableRow15.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell14, Me.NoVAT})
            Me.XrTableRow15.Name = "XrTableRow15"
            Me.XrTableRow15.Weight = 1.0R
            '
            'XrTableCell14
            '
            Me.XrTableCell14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell14.Multiline = True
            Me.XrTableCell14.Name = "XrTableCell14"
            Me.XrTableCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(20, 2, 0, 0, 100.0!)
            Me.XrTableCell14.StylePriority.UseFont = False
            Me.XrTableCell14.StylePriority.UsePadding = False
            Me.XrTableCell14.StylePriority.UseTextAlignment = False
            Me.XrTableCell14.Text = "Amount Net of VAT"
            Me.XrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell14.Weight = 2.432432484610175R
            '
            'NoVAT
            '
            Me.NoVAT.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.NoVAT.Multiline = True
            Me.NoVAT.Name = "NoVAT"
            Me.NoVAT.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 80, 0, 0, 100.0!)
            Me.NoVAT.StylePriority.UseFont = False
            Me.NoVAT.StylePriority.UsePadding = False
            Me.NoVAT.StylePriority.UseTextAlignment = False
            Me.NoVAT.Text = "0.00"
            Me.NoVAT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.NoVAT.TextFormatString = "{0:N2}"
            Me.NoVAT.Weight = 3.5675675153898259R
            '
            'XrTableRow12
            '
            Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.Penalty})
            Me.XrTableRow12.Name = "XrTableRow12"
            Me.XrTableRow12.Weight = 1.0R
            '
            'XrTableCell11
            '
            Me.XrTableCell11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell11.Multiline = True
            Me.XrTableCell11.Name = "XrTableCell11"
            Me.XrTableCell11.StylePriority.UseFont = False
            Me.XrTableCell11.StylePriority.UseTextAlignment = False
            Me.XrTableCell11.Text = "Penalty (Additional)"
            Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell11.Weight = 3.2432432805032896R
            '
            'Penalty
            '
            Me.Penalty.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Penalty.Multiline = True
            Me.Penalty.Name = "Penalty"
            Me.Penalty.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 20, 0, 0, 100.0!)
            Me.Penalty.StylePriority.UseFont = False
            Me.Penalty.StylePriority.UsePadding = False
            Me.Penalty.StylePriority.UseTextAlignment = False
            Me.Penalty.Text = "0.00"
            Me.Penalty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.Penalty.TextFormatString = "{0:N2}"
            Me.Penalty.Weight = 2.7567567194967113R
            '
            'XrTableRow13
            '
            Me.XrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell13, Me.Rebates})
            Me.XrTableRow13.Name = "XrTableRow13"
            Me.XrTableRow13.Weight = 1.0R
            '
            'XrTableCell13
            '
            Me.XrTableCell13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell13.Multiline = True
            Me.XrTableCell13.Name = "XrTableCell13"
            Me.XrTableCell13.StylePriority.UseFont = False
            Me.XrTableCell13.StylePriority.UseTextAlignment = False
            Me.XrTableCell13.Text = "Rebates (Deduction)"
            Me.XrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell13.Weight = 2.432432484610175R
            '
            'Rebates
            '
            Me.Rebates.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Rebates.Multiline = True
            Me.Rebates.Name = "Rebates"
            Me.Rebates.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 80, 0, 0, 100.0!)
            Me.Rebates.StylePriority.UseFont = False
            Me.Rebates.StylePriority.UsePadding = False
            Me.Rebates.StylePriority.UseTextAlignment = False
            Me.Rebates.Text = "0.00"
            Me.Rebates.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.Rebates.TextFormatString = "{0:N2}"
            Me.Rebates.Weight = 3.5675675153898259R
            '
            'XrTableRow6
            '
            Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.Total})
            Me.XrTableRow6.Name = "XrTableRow6"
            Me.XrTableRow6.Weight = 1.0R
            '
            'XrTableCell3
            '
            Me.XrTableCell3.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.XrTableCell3.BorderWidth = 2.0!
            Me.XrTableCell3.CanShrink = True
            Me.XrTableCell3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell3.Multiline = True
            Me.XrTableCell3.Name = "XrTableCell3"
            Me.XrTableCell3.StylePriority.UseBorders = False
            Me.XrTableCell3.StylePriority.UseBorderWidth = False
            Me.XrTableCell3.StylePriority.UseFont = False
            Me.XrTableCell3.StylePriority.UseTextAlignment = False
            Me.XrTableCell3.Text = "TOTAL AMOUNT PAID"
            Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell3.Weight = 3.2432432805032887R
            '
            'Total
            '
            Me.Total.Borders = DevExpress.XtraPrinting.BorderSide.Top
            Me.Total.BorderWidth = 2.0!
            Me.Total.CanShrink = True
            Me.Total.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Total.Multiline = True
            Me.Total.Name = "Total"
            Me.Total.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 20, 0, 0, 100.0!)
            Me.Total.StylePriority.UseBorders = False
            Me.Total.StylePriority.UseBorderWidth = False
            Me.Total.StylePriority.UseFont = False
            Me.Total.StylePriority.UsePadding = False
            Me.Total.StylePriority.UseTextAlignment = False
            Me.Total.Text = "0.00"
            Me.Total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.Total.TextFormatString = "{0:N2}"
            Me.Total.Weight = 2.7567567194967113R
            '
            'XrTableRow9
            '
            Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Notes})
            Me.XrTableRow9.Name = "XrTableRow9"
            Me.XrTableRow9.Weight = 1.0R
            '
            'Notes
            '
            Me.Notes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Notes.Multiline = True
            Me.Notes.Name = "Notes"
            Me.Notes.StylePriority.UseFont = False
            Me.Notes.StylePriority.UseTextAlignment = False
            Me.Notes.Text = "Description"
            Me.Notes.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Notes.Weight = 6.0R
            '
            'XrTableRow10
            '
            Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.Outstanding_Balance})
            Me.XrTableRow10.Name = "XrTableRow10"
            Me.XrTableRow10.Weight = 1.0R
            '
            'XrTableCell8
            '
            Me.XrTableCell8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell8.Multiline = True
            Me.XrTableCell8.Name = "XrTableCell8"
            Me.XrTableCell8.StylePriority.UseFont = False
            Me.XrTableCell8.StylePriority.UseTextAlignment = False
            Me.XrTableCell8.Text = "Outstanding Balance"
            Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell8.Weight = 2.4324324846101741R
            '
            'Outstanding_Balance
            '
            Me.Outstanding_Balance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Outstanding_Balance.Multiline = True
            Me.Outstanding_Balance.Name = "Outstanding_Balance"
            Me.Outstanding_Balance.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Outstanding_Balance.StylePriority.UseFont = False
            Me.Outstanding_Balance.StylePriority.UsePadding = False
            Me.Outstanding_Balance.StylePriority.UseTextAlignment = False
            Me.Outstanding_Balance.Text = "0.00"
            Me.Outstanding_Balance.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Outstanding_Balance.Weight = 3.5675675153898259R
            '
            'XrTable1
            '
            Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
            Me.XrTable1.Name = "XrTable1"
            Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
            Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow17, Me.XrTableRow1, Me.XrTableRow2, Me.XrTableRow3, Me.XrTableRow16})
            Me.XrTable1.SizeF = New System.Drawing.SizeF(370.0!, 100.0!)
            '
            'XrTableRow1
            '
            Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Customer_Name})
            Me.XrTableRow1.Name = "XrTableRow1"
            Me.XrTableRow1.Weight = 1.0R
            '
            'Customer_Name
            '
            Me.Customer_Name.CanShrink = True
            Me.Customer_Name.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Customer_Name.Multiline = True
            Me.Customer_Name.Name = "Customer_Name"
            Me.Customer_Name.Padding = New DevExpress.XtraPrinting.PaddingInfo(40, 2, 0, 0, 100.0!)
            Me.Customer_Name.StylePriority.UseFont = False
            Me.Customer_Name.StylePriority.UsePadding = False
            Me.Customer_Name.StylePriority.UseTextAlignment = False
            Me.Customer_Name.Text = "Customer_Name"
            Me.Customer_Name.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Customer_Name.Weight = 3.0R
            '
            'XrTableRow2
            '
            Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Customer_Address})
            Me.XrTableRow2.Name = "XrTableRow2"
            Me.XrTableRow2.Weight = 1.0R
            '
            'Customer_Address
            '
            Me.Customer_Address.CanShrink = True
            Me.Customer_Address.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Customer_Address.Multiline = True
            Me.Customer_Address.Name = "Customer_Address"
            Me.Customer_Address.Padding = New DevExpress.XtraPrinting.PaddingInfo(40, 2, 0, 0, 100.0!)
            Me.Customer_Address.StylePriority.UseFont = False
            Me.Customer_Address.StylePriority.UsePadding = False
            Me.Customer_Address.StylePriority.UseTextAlignment = False
            Me.Customer_Address.Text = "Customer_Address"
            Me.Customer_Address.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Customer_Address.Weight = 3.0R
            '
            'XrTableRow3
            '
            Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Amount_Words})
            Me.XrTableRow3.Name = "XrTableRow3"
            Me.XrTableRow3.Weight = 1.0R
            '
            'Amount_Words
            '
            Me.Amount_Words.CanShrink = True
            Me.Amount_Words.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Amount_Words.Multiline = True
            Me.Amount_Words.Name = "Amount_Words"
            Me.Amount_Words.Padding = New DevExpress.XtraPrinting.PaddingInfo(40, 2, 0, 0, 100.0!)
            Me.Amount_Words.StylePriority.UseFont = False
            Me.Amount_Words.StylePriority.UsePadding = False
            Me.Amount_Words.StylePriority.UseTextAlignment = False
            Me.Amount_Words.Text = "Amount_Words"
            Me.Amount_Words.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Amount_Words.Weight = 3.0R
            '
            'XrTableRow16
            '
            Me.XrTableRow16.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Amount_Received})
            Me.XrTableRow16.Name = "XrTableRow16"
            Me.XrTableRow16.Weight = 1.0R
            '
            'Amount_Received
            '
            Me.Amount_Received.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Amount_Received.Multiline = True
            Me.Amount_Received.Name = "Amount_Received"
            Me.Amount_Received.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Amount_Received.StylePriority.UseFont = False
            Me.Amount_Received.StylePriority.UsePadding = False
            Me.Amount_Received.StylePriority.UseTextAlignment = False
            Me.Amount_Received.Text = "0.00"
            Me.Amount_Received.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Amount_Received.Weight = 3.0R
            '
            'XrTableRow17
            '
            Me.XrTableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.Posting_Date})
            Me.XrTableRow17.Name = "XrTableRow17"
            Me.XrTableRow17.Weight = 1.0R
            '
            'Posting_Date
            '
            Me.Posting_Date.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Posting_Date.Multiline = True
            Me.Posting_Date.Name = "Posting_Date"
            Me.Posting_Date.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Posting_Date.StylePriority.UseFont = False
            Me.Posting_Date.StylePriority.UsePadding = False
            Me.Posting_Date.StylePriority.UseTextAlignment = False
            Me.Posting_Date.Text = "Posting_Date"
            Me.Posting_Date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.Posting_Date.Weight = 3.0R
            '
            'XrTableRow18
            '
            Me.XrTableRow18.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.Discount})
            Me.XrTableRow18.Name = "XrTableRow18"
            Me.XrTableRow18.Weight = 1.0R
            '
            'XrTableCell6
            '
            Me.XrTableCell6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell6.Multiline = True
            Me.XrTableCell6.Name = "XrTableCell6"
            Me.XrTableCell6.StylePriority.UseFont = False
            Me.XrTableCell6.StylePriority.UseTextAlignment = False
            Me.XrTableCell6.Text = "SC/PWD Discount"
            Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell6.Weight = 2.432432484610175R
            '
            'Discount
            '
            Me.Discount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Discount.Multiline = True
            Me.Discount.Name = "Discount"
            Me.Discount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 80, 0, 0, 100.0!)
            Me.Discount.StylePriority.UseFont = False
            Me.Discount.StylePriority.UsePadding = False
            Me.Discount.StylePriority.UseTextAlignment = False
            Me.Discount.Text = "- 0.00"
            Me.Discount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.Discount.Weight = 3.5675675153898259R
            '
            'XrTableRow5
            '
            Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell4, Me.Printed_By})
            Me.XrTableRow5.Name = "XrTableRow5"
            Me.XrTableRow5.Weight = 1.0R
            '
            'XrTableCell4
            '
            Me.XrTableCell4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell4.Multiline = True
            Me.XrTableCell4.Name = "XrTableCell4"
            Me.XrTableCell4.StylePriority.UseFont = False
            Me.XrTableCell4.StylePriority.UseTextAlignment = False
            Me.XrTableCell4.Text = "Printed By"
            Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell4.Weight = 1.1351351519643305R
            '
            'Printed_By
            '
            Me.Printed_By.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Printed_By.Multiline = True
            Me.Printed_By.Name = "Printed_By"
            Me.Printed_By.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Printed_By.StylePriority.UseFont = False
            Me.Printed_By.StylePriority.UsePadding = False
            Me.Printed_By.StylePriority.UseTextAlignment = False
            Me.Printed_By.Text = "Printed_By"
            Me.Printed_By.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Printed_By.Weight = 4.8648648480356691R
            '
            'XrTableRow8
            '
            Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7})
            Me.XrTableRow8.Name = "XrTableRow8"
            Me.XrTableRow8.Weight = 1.0R
            '
            'XrTableCell7
            '
            Me.XrTableCell7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell7.Multiline = True
            Me.XrTableCell7.Name = "XrTableCell7"
            Me.XrTableCell7.StylePriority.UseFont = False
            Me.XrTableCell7.StylePriority.UseTextAlignment = False
            Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell7.Weight = 6.0R
            '
            'XrTableRow19
            '
            Me.XrTableRow19.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell5, Me.Printed_Date})
            Me.XrTableRow19.Name = "XrTableRow19"
            Me.XrTableRow19.Weight = 1.0R
            '
            'XrTableCell5
            '
            Me.XrTableCell5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell5.Multiline = True
            Me.XrTableCell5.Name = "XrTableCell5"
            Me.XrTableCell5.StylePriority.UseFont = False
            Me.XrTableCell5.StylePriority.UseTextAlignment = False
            Me.XrTableCell5.Text = "Date/Time"
            Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrTableCell5.Weight = 1.1351353994041531R
            '
            'Printed_Date
            '
            Me.Printed_Date.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Printed_Date.Multiline = True
            Me.Printed_Date.Name = "Printed_Date"
            Me.Printed_Date.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Printed_Date.StylePriority.UseFont = False
            Me.Printed_Date.StylePriority.UsePadding = False
            Me.Printed_Date.StylePriority.UseTextAlignment = False
            Me.Printed_Date.Text = "Printed_Date"
            Me.Printed_Date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.Printed_Date.Weight = 4.8648646005958476R
            '
            'xrpt_Collection_Receipt
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
            Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margins = New System.Drawing.Printing.Margins(50, 30, 70, 50)
            Me.PageHeight = 550
            Me.PageWidth = 450
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.Version = "20.2"
            CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Customer_Name As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Customer_Address As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Amount_Words As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Reference As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Amortization As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Total As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Notes As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Outstanding_Balance As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Interest As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Penalty As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow13 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Rebates As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow14 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents VAT As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow15 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents NoVAT As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow16 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Amount_Received As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow17 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents Posting_Date As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow18 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Discount As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Printed_By As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableRow19 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents Printed_Date As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace