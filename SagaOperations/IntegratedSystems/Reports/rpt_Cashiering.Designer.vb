<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpt_Cashiering
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    Private Sub InitializeComponent()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_Cashiering))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_BranchCode = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.DateBegin = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.DateEnd = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.Btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.GCashiering = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BranchAddress = New System.Windows.Forms.Label()
        Me.BranchName = New System.Windows.Forms.Label()
        Me.CheckedBy = New System.Windows.Forms.Label()
        Me.PreparedBy = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCashiering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.txt_BranchCode, Me.BarStaticItem2, Me.DateBegin, Me.BarStaticItem3, Me.DateEnd, Me.Btn_Reload, Me.Btn_Preview})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_BranchCode), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.DateBegin), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.DateEnd), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.Btn_Reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.Btn_Preview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "BranchCode"
        Me.BarStaticItem1.Id = 0
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'txt_BranchCode
        '
        Me.txt_BranchCode.Edit = Me.RepositoryItemTextEdit1
        Me.txt_BranchCode.EditWidth = 96
        Me.txt_BranchCode.Id = 1
        Me.txt_BranchCode.Name = "txt_BranchCode"
        ToolTipItem1.Text = "BranchCode"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.txt_BranchCode.SuperTip = SuperToolTip1
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "DateBegin"
        Me.BarStaticItem2.Id = 2
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'DateBegin
        '
        Me.DateBegin.Edit = Me.RepositoryItemDateEdit1
        Me.DateBegin.EditWidth = 136
        Me.DateBegin.Id = 3
        Me.DateBegin.Name = "DateBegin"
        ToolTipItem2.Text = "Date Begin"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.DateBegin.SuperTip = SuperToolTip2
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "DateEnd"
        Me.BarStaticItem3.Id = 4
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'DateEnd
        '
        Me.DateEnd.Edit = Me.RepositoryItemDateEdit2
        Me.DateEnd.EditWidth = 146
        Me.DateEnd.Id = 5
        Me.DateEnd.Name = "DateEnd"
        ToolTipItem3.Text = "Date End"
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.DateEnd.SuperTip = SuperToolTip3
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'Btn_Reload
        '
        Me.Btn_Reload.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Btn_Reload.Caption = "Find"
        Me.Btn_Reload.Id = 6
        Me.Btn_Reload.Name = "Btn_Reload"
        ToolTipItem4.Text = "Find"
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.Btn_Reload.SuperTip = SuperToolTip4
        '
        'Btn_Preview
        '
        Me.Btn_Preview.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Btn_Preview.Caption = "PrintPreview"
        Me.Btn_Preview.Id = 7
        Me.Btn_Preview.Name = "Btn_Preview"
        ToolTipItem5.Text = "Print"
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.Btn_Preview.SuperTip = SuperToolTip5
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(813, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 350)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(813, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 326)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(813, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 326)
        '
        'GCashiering
        '
        Me.GCashiering.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCashiering.Location = New System.Drawing.Point(0, 24)
        Me.GCashiering.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.GCashiering.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GCashiering.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GCashiering.MainView = Me.GridView
        Me.GCashiering.Name = "GCashiering"
        Me.GCashiering.Size = New System.Drawing.Size(813, 326)
        Me.GCashiering.TabIndex = 121
        Me.GCashiering.UseEmbeddedNavigator = True
        Me.GCashiering.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView, Me.CardView1, Me.GridView2, Me.GridView1})
        '
        'GridView
        '
        Me.GridView.Appearance.FooterPanel.BackColor = System.Drawing.Color.Transparent
        Me.GridView.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.Transparent
        Me.GridView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Transparent
        Me.GridView.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GridView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.GridView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Black
        Me.GridView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView.Appearance.Preview.BackColor = System.Drawing.Color.White
        Me.GridView.Appearance.Preview.BackColor2 = System.Drawing.Color.White
        Me.GridView.Appearance.Preview.BorderColor = System.Drawing.Color.Black
        Me.GridView.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.AppearancePrint.EvenRow.Options.UseFont = True
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.BranchCode, Me.AccountName, Me.PostingDate, Me.Transactions, Me.Invoices, Me.Descriptions, Me.RefNo, Me.AmountDue, Me.Vat, Me.NETVAT, Me.discnt, Me.NetGross})
        Me.GridView.GridControl = Me.GCashiering
        Me.GridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountDue", Me.AmountDue, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Vat", Me.Vat, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NETVAT", Me.NETVAT, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "discnt", Me.discnt, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetGross", Me.NetGross, "")})
        Me.GridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView.OptionsBehavior.AutoExpandAllGroups = True
        Me.GridView.OptionsBehavior.Editable = False
        Me.GridView.OptionsPrint.AllowMultilineHeaders = True
        Me.GridView.OptionsPrint.EnableAppearanceEvenRow = True
        Me.GridView.OptionsPrint.EnableAppearanceOddRow = True
        Me.GridView.OptionsPrint.ExpandAllDetails = True
        Me.GridView.OptionsPrint.PrintDetails = True
        Me.GridView.OptionsPrint.PrintFilterInfo = True
        Me.GridView.OptionsPrint.PrintPreview = True
        Me.GridView.OptionsPrint.PrintSelectedRowsOnly = True
        Me.GridView.OptionsPrint.UsePrintStyles = False
        Me.GridView.OptionsSelection.MultiSelect = True
        Me.GridView.OptionsView.ColumnAutoWidth = False
        Me.GridView.OptionsView.ShowFooter = True
        Me.GridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
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
        Me.NetGross.FieldName = "NetGross"
        Me.NetGross.Name = "NetGross"
        Me.NetGross.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NetGross", "SUM={0:N2}")})
        Me.NetGross.Visible = True
        Me.NetGross.VisibleIndex = 11
        '
        'CardView1
        '
        Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5})
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.GCashiering
        Me.CardView1.Name = "CardView1"
        Me.CardView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.[Auto]
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
        'GridView2
        '
        Me.GridView2.GridControl = Me.GCashiering
        Me.GridView2.Name = "GridView2"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GCashiering
        Me.GridView1.Name = "GridView1"
        '
        'BranchAddress
        '
        Me.BranchAddress.Location = New System.Drawing.Point(485, 52)
        Me.BranchAddress.Name = "BranchAddress"
        Me.BranchAddress.Size = New System.Drawing.Size(81, 19)
        Me.BranchAddress.TabIndex = 132
        Me.BranchAddress.Text = "BranchAddress"
        '
        'BranchName
        '
        Me.BranchName.Location = New System.Drawing.Point(409, 52)
        Me.BranchName.Name = "BranchName"
        Me.BranchName.Size = New System.Drawing.Size(81, 19)
        Me.BranchName.TabIndex = 131
        Me.BranchName.Text = "BranchName"
        '
        'CheckedBy
        '
        Me.CheckedBy.Location = New System.Drawing.Point(323, 52)
        Me.CheckedBy.Name = "CheckedBy"
        Me.CheckedBy.Size = New System.Drawing.Size(81, 19)
        Me.CheckedBy.TabIndex = 130
        Me.CheckedBy.Text = "CheckedBy"
        '
        'PreparedBy
        '
        Me.PreparedBy.Location = New System.Drawing.Point(247, 52)
        Me.PreparedBy.Name = "PreparedBy"
        Me.PreparedBy.Size = New System.Drawing.Size(81, 19)
        Me.PreparedBy.TabIndex = 129
        Me.PreparedBy.Text = "PreparedBy:"
        '
        'rpt_Cashiering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(813, 350)
        Me.Controls.Add(Me.GCashiering)
        Me.Controls.Add(Me.BranchAddress)
        Me.Controls.Add(Me.BranchName)
        Me.Controls.Add(Me.CheckedBy)
        Me.Controls.Add(Me.PreparedBy)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rpt_Cashiering"
        Me.Text = "CASHIERING"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCashiering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_BranchCode As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents DateBegin As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents DateEnd As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GCashiering As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchAddress As Label
    Friend WithEvents BranchName As Label
    Friend WithEvents CheckedBy As Label
    Friend WithEvents PreparedBy As Label
End Class
