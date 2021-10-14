<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rpt_rd_AmortSched
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides sub Dispose(ByVal disposing As Boolean)
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
    private sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.PrintableComponentContainer1 = New DevExpress.XtraReports.UI.PrintableComponentContainer()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine()
        Me.txt_AccountName2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txt_Position = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.txt_BM = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txt_DateGranted = New DevExpress.XtraReports.UI.XRLabel()
        Me.txt_MaturityDate = New DevExpress.XtraReports.UI.XRLabel()
        Me.txt_Keyno = New DevExpress.XtraReports.UI.XRLabel()
        Me.txt_TotalBal = New DevExpress.XtraReports.UI.XRLabel()
        Me.txt_Model = New DevExpress.XtraReports.UI.XRLabel()
        Me.txt_EngineNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.txt_ChassisNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.txt_AccountNo = New DevExpress.XtraReports.UI.XRLabel()
        Me.txt_AccountName = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.txt_BranchAddress = New DevExpress.XtraReports.UI.XRLabel()
        Me.txt_Branch = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PrintableComponentContainer1})
        Me.Detail.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.HeightF = 19.79164!
        Me.Detail.MultiColumn.ColumnCount = 2
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseFont = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PrintableComponentContainer1
        '
        Me.PrintableComponentContainer1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.PrintableComponentContainer1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.PrintableComponentContainer1.Name = "PrintableComponentContainer1"
        Me.PrintableComponentContainer1.SizeF = New System.Drawing.SizeF(650.0001!, 19.79164!)
        Me.PrintableComponentContainer1.StylePriority.UseBorders = False
        '
        'XrLabel27
        '
        Me.XrLabel27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 151.0417!)
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(247.917!, 16.66669!)
        Me.XrLabel27.StylePriority.UseFont = False
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "(Signature of Borrower over Printed Name)"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine4
        '
        Me.XrLine4.BackColor = System.Drawing.Color.Transparent
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 148.9584!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(247.917!, 2.083374!)
        Me.XrLine4.StylePriority.UseBackColor = False
        '
        'txt_AccountName2
        '
        Me.txt_AccountName2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AccountName2.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 129.1667!)
        Me.txt_AccountName2.Name = "txt_AccountName2"
        Me.txt_AccountName2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_AccountName2.SizeF = New System.Drawing.SizeF(247.917!, 19.79172!)
        Me.txt_AccountName2.StylePriority.UseFont = False
        Me.txt_AccountName2.StylePriority.UseTextAlignment = False
        Me.txt_AccountName2.Text = "?CustomerName"
        Me.txt_AccountName2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'txt_Position
        '
        Me.txt_Position.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Position.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 67.7084!)
        Me.txt_Position.Name = "txt_Position"
        Me.txt_Position.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_Position.SizeF = New System.Drawing.SizeF(247.917!, 19.79169!)
        Me.txt_Position.StylePriority.UseFont = False
        Me.txt_Position.StylePriority.UseTextAlignment = False
        Me.txt_Position.Text = "Branch Manager"
        Me.txt_Position.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLine3
        '
        Me.XrLine3.BackColor = System.Drawing.Color.Transparent
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 87.50013!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(247.917!, 2.083344!)
        Me.XrLine3.StylePriority.UseBackColor = False
        '
        'XrLabel26
        '
        Me.XrLabel26.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 89.5834!)
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(247.917!, 16.66666!)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.StylePriority.UseTextAlignment = False
        Me.XrLabel26.Text = "Position"
        Me.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 38.5417!)
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(247.917!, 16.66666!)
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.Text = "Representative Over Printed Name)"
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel23
        '
        Me.XrLabel23.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 21.87506!)
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(247.917!, 16.66666!)
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "(Signature of Creditor/Authorized"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLine2
        '
        Me.XrLine2.BackColor = System.Drawing.Color.Transparent
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 19.79173!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(247.917!, 2.083344!)
        Me.XrLine2.StylePriority.UseBackColor = False
        '
        'txt_BM
        '
        Me.txt_BM.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BM.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 0!)
        Me.txt_BM.Name = "txt_BM"
        Me.txt_BM.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_BM.SizeF = New System.Drawing.SizeF(247.917!, 19.79169!)
        Me.txt_BM.StylePriority.UseFont = False
        Me.txt_BM.StylePriority.UseTextAlignment = False
        Me.txt_BM.Text = "?BM"
        Me.txt_BM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(101.0417!, 19.79166!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.Text = "Date Granted"
        '
        'XrLabel20
        '
        Me.XrLabel20.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 19.79167!)
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(101.0417!, 19.79166!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.Text = "Maturity Date"
        '
        'XrLabel21
        '
        Me.XrLabel21.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(495.8333!, 0!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(13.54163!, 19.79166!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = ":"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel22
        '
        Me.XrLabel22.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(495.8333!, 19.79167!)
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(13.54163!, 19.79166!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = ":"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'txt_DateGranted
        '
        Me.txt_DateGranted.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DateGranted.LocationFloat = New DevExpress.Utils.PointFloat(509.375!, 0!)
        Me.txt_DateGranted.Name = "txt_DateGranted"
        Me.txt_DateGranted.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_DateGranted.SizeF = New System.Drawing.SizeF(140.625!, 19.79167!)
        Me.txt_DateGranted.StylePriority.UseFont = False
        Me.txt_DateGranted.StylePriority.UseTextAlignment = False
        Me.txt_DateGranted.Text = "?DateGranted"
        Me.txt_DateGranted.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txt_MaturityDate
        '
        Me.txt_MaturityDate.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaturityDate.LocationFloat = New DevExpress.Utils.PointFloat(509.375!, 19.79167!)
        Me.txt_MaturityDate.Name = "txt_MaturityDate"
        Me.txt_MaturityDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_MaturityDate.SizeF = New System.Drawing.SizeF(140.625!, 19.79167!)
        Me.txt_MaturityDate.StylePriority.UseFont = False
        Me.txt_MaturityDate.StylePriority.UseTextAlignment = False
        Me.txt_MaturityDate.Text = "?DueDate"
        Me.txt_MaturityDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txt_Keyno
        '
        Me.txt_Keyno.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Keyno.LocationFloat = New DevExpress.Utils.PointFloat(509.375!, 59.375!)
        Me.txt_Keyno.Name = "txt_Keyno"
        Me.txt_Keyno.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_Keyno.SizeF = New System.Drawing.SizeF(140.625!, 19.79167!)
        Me.txt_Keyno.StylePriority.UseFont = False
        Me.txt_Keyno.StylePriority.UseTextAlignment = False
        Me.txt_Keyno.Text = "?Keyno"
        Me.txt_Keyno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txt_TotalBal
        '
        Me.txt_TotalBal.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalBal.LocationFloat = New DevExpress.Utils.PointFloat(509.375!, 39.58333!)
        Me.txt_TotalBal.Name = "txt_TotalBal"
        Me.txt_TotalBal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_TotalBal.SizeF = New System.Drawing.SizeF(140.625!, 19.79167!)
        Me.txt_TotalBal.StylePriority.UseFont = False
        Me.txt_TotalBal.StylePriority.UseTextAlignment = False
        Me.txt_TotalBal.Text = "?TotalBal"
        Me.txt_TotalBal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.txt_TotalBal.TextFormatString = "{0:,}"
        '
        'txt_Model
        '
        Me.txt_Model.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Model.LocationFloat = New DevExpress.Utils.PointFloat(135.4167!, 39.58333!)
        Me.txt_Model.Name = "txt_Model"
        Me.txt_Model.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_Model.SizeF = New System.Drawing.SizeF(259.375!, 19.79166!)
        Me.txt_Model.StylePriority.UseFont = False
        Me.txt_Model.StylePriority.UseTextAlignment = False
        Me.txt_Model.Text = "?Model"
        Me.txt_Model.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txt_EngineNo
        '
        Me.txt_EngineNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EngineNo.LocationFloat = New DevExpress.Utils.PointFloat(135.4167!, 59.375!)
        Me.txt_EngineNo.Name = "txt_EngineNo"
        Me.txt_EngineNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_EngineNo.SizeF = New System.Drawing.SizeF(259.375!, 19.79166!)
        Me.txt_EngineNo.StylePriority.UseFont = False
        Me.txt_EngineNo.StylePriority.UseTextAlignment = False
        Me.txt_EngineNo.Text = "?EngineNo"
        Me.txt_EngineNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txt_ChassisNo
        '
        Me.txt_ChassisNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ChassisNo.LocationFloat = New DevExpress.Utils.PointFloat(135.4167!, 79.16666!)
        Me.txt_ChassisNo.Name = "txt_ChassisNo"
        Me.txt_ChassisNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_ChassisNo.SizeF = New System.Drawing.SizeF(259.375!, 19.79166!)
        Me.txt_ChassisNo.StylePriority.UseFont = False
        Me.txt_ChassisNo.StylePriority.UseTextAlignment = False
        Me.txt_ChassisNo.Text = "?ChassisNo"
        Me.txt_ChassisNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txt_AccountNo
        '
        Me.txt_AccountNo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AccountNo.LocationFloat = New DevExpress.Utils.PointFloat(135.4167!, 19.79167!)
        Me.txt_AccountNo.Name = "txt_AccountNo"
        Me.txt_AccountNo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_AccountNo.SizeF = New System.Drawing.SizeF(259.375!, 19.79167!)
        Me.txt_AccountNo.StylePriority.UseFont = False
        Me.txt_AccountNo.StylePriority.UseTextAlignment = False
        Me.txt_AccountNo.Text = "?AccountNo"
        Me.txt_AccountNo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'txt_AccountName
        '
        Me.txt_AccountName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AccountName.LocationFloat = New DevExpress.Utils.PointFloat(135.4167!, 0!)
        Me.txt_AccountName.Name = "txt_AccountName"
        Me.txt_AccountName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_AccountName.SizeF = New System.Drawing.SizeF(259.375!, 19.79167!)
        Me.txt_AccountName.StylePriority.UseFont = False
        Me.txt_AccountName.StylePriority.UseTextAlignment = False
        Me.txt_AccountName.Text = "?CustomerName"
        Me.txt_AccountName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel16
        '
        Me.XrLabel16.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(121.875!, 59.375!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(13.54167!, 19.79166!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = ":"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(121.875!, 79.16666!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(13.54167!, 19.79166!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = ":"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(495.8333!, 39.58333!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(13.54167!, 19.79167!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = " :"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel19
        '
        Me.XrLabel19.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(495.8333!, 59.375!)
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(13.54167!, 19.79166!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = ":"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel14
        '
        Me.XrLabel14.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(121.875!, 19.79167!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(13.54167!, 19.79166!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = ":"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(121.875!, 39.58333!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(13.54167!, 19.79166!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = ":"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(121.875!, 0!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(13.54167!, 19.79166!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = ":"
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 59.375!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(76.04169!, 19.79166!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "Key No."
        '
        'XrLabel10
        '
        Me.XrLabel10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(394.7917!, 39.58333!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(101.0417!, 19.79167!)
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.Text = "Total Balance"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 59.375!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(121.875!, 19.79166!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "Engine No."
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 79.16666!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(121.875!, 19.79166!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "Chassis No."
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 19.79167!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(121.875!, 19.79166!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "PN/Account No."
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 39.58333!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(121.875!, 19.79166!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "Model"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(121.875!, 19.79166!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "Account Name"
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel2, Me.txt_BranchAddress, Me.txt_Branch, Me.XrLabel1})
        Me.TopMargin.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopMargin.HeightF = 87.83334!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseFont = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txt_BranchAddress
        '
        Me.txt_BranchAddress.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BranchAddress.LocationFloat = New DevExpress.Utils.PointFloat(0.0001430511!, 33.5!)
        Me.txt_BranchAddress.Name = "txt_BranchAddress"
        Me.txt_BranchAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_BranchAddress.SizeF = New System.Drawing.SizeF(650.0!, 11.54167!)
        Me.txt_BranchAddress.StylePriority.UseFont = False
        Me.txt_BranchAddress.StylePriority.UseTextAlignment = False
        Me.txt_BranchAddress.Text = "?Branch Address"
        Me.txt_BranchAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'txt_Branch
        '
        Me.txt_Branch.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Branch.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 23.0!)
        Me.txt_Branch.Name = "txt_Branch"
        Me.txt_Branch.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txt_Branch.SizeF = New System.Drawing.SizeF(650.0!, 10.5!)
        Me.txt_Branch.StylePriority.UseFont = False
        Me.txt_Branch.StylePriority.UseTextAlignment = False
        Me.txt_Branch.Text = "?Branch"
        Me.txt_Branch.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(650.0!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "SAGA FINANCE CORPORATION"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel11, Me.XrLabel20, Me.XrLabel21, Me.XrLabel22, Me.txt_DateGranted, Me.txt_MaturityDate, Me.txt_Keyno, Me.txt_TotalBal, Me.txt_Model, Me.txt_EngineNo, Me.txt_ChassisNo, Me.txt_AccountNo, Me.txt_AccountName, Me.XrLabel16, Me.XrLabel17, Me.XrLabel18, Me.XrLabel19, Me.XrLabel14, Me.XrLabel15, Me.XrLabel13, Me.XrLabel9, Me.XrLabel10, Me.XrLabel7, Me.XrLabel8, Me.XrLabel5, Me.XrLabel6, Me.XrLabel4})
        Me.ReportHeader.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportHeader.HeightF = 98.95833!
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.StylePriority.UseFont = False
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel27, Me.XrLine4, Me.txt_AccountName2, Me.txt_Position, Me.XrLine3, Me.XrLabel26, Me.XrLabel24, Me.XrLabel23, Me.XrLine2, Me.txt_BM})
        Me.PageFooter.HeightF = 176.0417!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.NotWithReportFooter
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 55.95834!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(650.0!, 19.79166!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "AMORTIZATION SCHEDULE"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'rpt_rd_AmortSched
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageFooter})
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(100, 100, 88, 0)
        Me.Version = "17.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txt_DateGranted As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txt_MaturityDate As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txt_Keyno As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txt_TotalBal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txt_Model As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txt_EngineNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txt_ChassisNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txt_AccountNo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txt_AccountName As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txt_Branch As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PrintableComponentContainer1 As DevExpress.XtraReports.UI.PrintableComponentContainer
    Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txt_AccountName2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txt_Position As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents txt_BM As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents txt_BranchAddress As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
End Class
