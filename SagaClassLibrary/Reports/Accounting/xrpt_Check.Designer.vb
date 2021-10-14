Namespace Reports.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class xrpt_Check
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
        'It can be Modified using the Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.XrL_Name = New DevExpress.XtraReports.UI.XRLabel()
            Me.XrL_Amount_Words = New DevExpress.XtraReports.UI.XRLabel()
            Me.XrL_Amount_Numbers = New DevExpress.XtraReports.UI.XRLabel()
            Me.XrL_Date = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrL_Name, Me.XrL_Amount_Words, Me.XrL_Amount_Numbers, Me.XrL_Date})
            Me.Detail.HeightF = 169.7917!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'XrL_Name
            '
            Me.XrL_Name.CanShrink = True
            Me.XrL_Name.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrL_Name.LocationFloat = New DevExpress.Utils.PointFloat(84.64175!, 60.25!)
            Me.XrL_Name.Name = "XrL_Name"
            Me.XrL_Name.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrL_Name.SizeF = New System.Drawing.SizeF(472.4839!, 25.0!)
            Me.XrL_Name.StylePriority.UseFont = False
            Me.XrL_Name.StylePriority.UseTextAlignment = False
            Me.XrL_Name.Text = "XrL_Name"
            Me.XrL_Name.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrL_Amount_Words
            '
            Me.XrL_Amount_Words.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrL_Amount_Words.LocationFloat = New DevExpress.Utils.PointFloat(84.64176!, 91.24994!)
            Me.XrL_Amount_Words.Name = "XrL_Amount_Words"
            Me.XrL_Amount_Words.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 0, 100.0!)
            Me.XrL_Amount_Words.SizeF = New System.Drawing.SizeF(657.3582!, 45.0!)
            Me.XrL_Amount_Words.StylePriority.UseFont = False
            Me.XrL_Amount_Words.StylePriority.UsePadding = False
            Me.XrL_Amount_Words.StylePriority.UseTextAlignment = False
            Me.XrL_Amount_Words.Text = "XrL_Amount_Words"
            Me.XrL_Amount_Words.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'XrL_Amount_Numbers
            '
            Me.XrL_Amount_Numbers.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrL_Amount_Numbers.LocationFloat = New DevExpress.Utils.PointFloat(563.1256!, 60.25!)
            Me.XrL_Amount_Numbers.Name = "XrL_Amount_Numbers"
            Me.XrL_Amount_Numbers.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrL_Amount_Numbers.SizeF = New System.Drawing.SizeF(178.8744!, 25.0!)
            Me.XrL_Amount_Numbers.StylePriority.UseFont = False
            Me.XrL_Amount_Numbers.StylePriority.UseTextAlignment = False
            Me.XrL_Amount_Numbers.Text = "XrL_Amount_Numbers 69"
            Me.XrL_Amount_Numbers.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrL_Amount_Numbers.TextFormatString = "{0:n2}"
            '
            'XrL_Date
            '
            Me.XrL_Date.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrL_Date.LocationFloat = New DevExpress.Utils.PointFloat(564.1253!, 23.25002!)
            Me.XrL_Date.Name = "XrL_Date"
            Me.XrL_Date.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrL_Date.SizeF = New System.Drawing.SizeF(177.8747!, 25.0!)
            Me.XrL_Date.StylePriority.UseFont = False
            Me.XrL_Date.StylePriority.UseTextAlignment = False
            Me.XrL_Date.Text = "XrL_Date"
            Me.XrL_Date.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            Me.XrL_Date.TextFormatString = "{0:MMMM dd, yyyy}"
            '
            'TopMargin
            '
            Me.TopMargin.HeightF = 20.0!
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'BottomMargin
            '
            Me.BottomMargin.HeightF = 50.0!
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrpt_Check
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
            Me.Font = New System.Drawing.Font("Arial", 9.75!)
            Me.Margins = New System.Drawing.Printing.Margins(50, 50, 20, 50)
            Me.PageHeight = 300
            Me.PageWidth = 848
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.Version = "18.2"
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Friend WithEvents XrL_Date As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrL_Amount_Numbers As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrL_Name As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrL_Amount_Words As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace