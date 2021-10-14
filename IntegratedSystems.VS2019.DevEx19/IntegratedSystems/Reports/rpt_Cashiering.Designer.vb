<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpt_Cashiering
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    private sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_Cashiering))
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GCashiering = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Transactions = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Invoices = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descriptions = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmountDue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Vat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NETVAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.discnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NetGross = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCashiering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Preview, Me.btn_Close})
        Me.BarManager.MainMenu = Me.Bar2
        Me.BarManager.MaxItemId = 10
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Preview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btn_Reload
        '
        Me.btn_Reload.Caption = "Reload"
        Me.btn_Reload.Id = 6
        Me.btn_Reload.Name = "btn_Reload"
        ToolTipItem1.Text = "Find"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btn_Reload.SuperTip = SuperToolTip1
        '
        'btn_Preview
        '
        Me.btn_Preview.Caption = "Preview"
        Me.btn_Preview.Id = 7
        Me.btn_Preview.Name = "btn_Preview"
        ToolTipItem2.Text = "Print"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btn_Preview.SuperTip = SuperToolTip2
        '
        'btn_Close
        '
        Me.btn_Close.Caption = "Close"
        Me.btn_Close.Id = 9
        Me.btn_Close.Name = "btn_Close"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(685, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 350)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(685, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 330)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(685, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 330)
        '
        'GCashiering
        '
        Me.GCashiering.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCashiering.Location = New System.Drawing.Point(0, 20)
        Me.GCashiering.MainView = Me.gridView
        Me.GCashiering.Name = "GCashiering"
        Me.GCashiering.Size = New System.Drawing.Size(685, 330)
        Me.GCashiering.TabIndex = 121
        Me.GCashiering.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.gridView.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.BranchCode, Me.AccountName, Me.PostingDate, Me.Transactions, Me.Invoices, Me.Descriptions, Me.RefNo, Me.AmountDue, Me.Vat, Me.NETVAT, Me.discnt, Me.NetGross})
        Me.gridView.gridControl = Me.GCashiering
        Me.gridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountDue", Me.AmountDue, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Vat", Me.Vat, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETVAT", Me.NETVAT, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "discnt", Me.discnt, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetGross", Me.NetGross, "")})
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsView.ColumnAutoWidth = False
        '
        'BranchCode
        '
        Me.BranchCode.Caption = "Branch"
        Me.BranchCode.FieldName = "BranchCode"
        Me.BranchCode.Name = "BranchCode"
        Me.BranchCode.Visible = True
        Me.BranchCode.VisibleIndex = 0
        Me.BranchCode.Width = 52
        '
        'AccountName
        '
        Me.AccountName.Caption = "AccountName"
        Me.AccountName.FieldName = "AccountName"
        Me.AccountName.Name = "AccountName"
        Me.AccountName.Visible = True
        Me.AccountName.VisibleIndex = 1
        Me.AccountName.Width = 48
        '
        'PostingDate
        '
        Me.PostingDate.Caption = "PostingDate"
        Me.PostingDate.FieldName = "PostingDate"
        Me.PostingDate.Name = "PostingDate"
        Me.PostingDate.Visible = True
        Me.PostingDate.VisibleIndex = 2
        '
        'Transactions
        '
        Me.Transactions.Caption = "Transactions"
        Me.Transactions.FieldName = "Transactions"
        Me.Transactions.Name = "Transactions"
        Me.Transactions.Visible = True
        Me.Transactions.VisibleIndex = 3
        Me.Transactions.Width = 48
        '
        'Invoices
        '
        Me.Invoices.Caption = "Invoices"
        Me.Invoices.FieldName = "Invoices"
        Me.Invoices.Name = "Invoices"
        Me.Invoices.Visible = True
        Me.Invoices.VisibleIndex = 4
        Me.Invoices.Width = 48
        '
        'Descriptions
        '
        Me.Descriptions.Caption = "Descriptions"
        Me.Descriptions.FieldName = "Descriptions"
        Me.Descriptions.Name = "Descriptions"
        Me.Descriptions.Visible = True
        Me.Descriptions.VisibleIndex = 5
        Me.Descriptions.Width = 48
        '
        'RefNo
        '
        Me.RefNo.Caption = "RefNo"
        Me.RefNo.FieldName = "RefNo"
        Me.RefNo.Name = "RefNo"
        Me.RefNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "RefNo", "{0}")})
        Me.RefNo.Visible = True
        Me.RefNo.VisibleIndex = 6
        Me.RefNo.Width = 48
        '
        'AmountDue
        '
        Me.AmountDue.Caption = "AmountDue"
        Me.AmountDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AmountDue.FieldName = "AmountDue"
        Me.AmountDue.Name = "AmountDue"
        Me.AmountDue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountDue", "SUM={0:N2}")})
        Me.AmountDue.Visible = True
        Me.AmountDue.VisibleIndex = 7
        Me.AmountDue.Width = 48
        '
        'Vat
        '
        Me.Vat.Caption = "VAT"
        Me.Vat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Vat.FieldName = "Vat"
        Me.Vat.Name = "Vat"
        Me.Vat.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Vat", "SUM={0:N2}")})
        Me.Vat.Visible = True
        Me.Vat.VisibleIndex = 8
        Me.Vat.Width = 48
        '
        'NETVAT
        '
        Me.NETVAT.Caption = "NETVAT"
        Me.NETVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NETVAT.FieldName = "NETVAT"
        Me.NETVAT.Name = "NETVAT"
        Me.NETVAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETVAT", "SUM={0:N2}")})
        Me.NETVAT.Visible = True
        Me.NETVAT.VisibleIndex = 9
        Me.NETVAT.Width = 65
        '
        'discnt
        '
        Me.discnt.Caption = "Discount"
        Me.discnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.discnt.FieldName = "discnt"
        Me.discnt.Name = "discnt"
        Me.discnt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "discnt", "SUM={0:N2}")})
        Me.discnt.Visible = True
        Me.discnt.VisibleIndex = 10
        Me.discnt.Width = 48
        '
        'NetGross
        '
        Me.NetGross.Caption = "Net"
        Me.NetGross.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NetGross.FieldName = "NetGross"
        Me.NetGross.Name = "NetGross"
        Me.NetGross.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetGross", "SUM={0:N2}")})
        Me.NetGross.Visible = True
        Me.NetGross.VisibleIndex = 11
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "BrCode"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 91
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "ACCTNo"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 131
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "LEDGERSETNo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 84
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "PostingDate"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 404
        '
        'rpt_Cashiering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 350)
        Me.Controls.Add(Me.GCashiering)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("rpt_Cashiering.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "rpt_Cashiering"
        Me.Text = "CASHIERING"
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCashiering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GCashiering As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PostingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Transactions As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Invoices As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descriptions As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmountDue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents discnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NetGross As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Vat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NETVAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
End Class
