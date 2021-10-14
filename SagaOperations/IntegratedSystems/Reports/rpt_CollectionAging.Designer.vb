<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpt_CollectionAging
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_CollectionAging))
        Me.RepositoryItemTimeEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
        Me.GCCollectionAging = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_BrCode = New DevExpress.XtraBars.BarEditItem()
        Me.txt_BrCodeRepository = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.CutOffDate = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_AECode = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_AccountStatus = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.BarStaticItem5 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_Corp = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.Btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txt_BranchCode2 = New DevExpress.XtraBars.BarEditItem()
        Me.txt_BranchCodeRepository = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txt_BranchCode = New DevExpress.XtraBars.BarEditItem()
        Me.BWAging = New System.ComponentModel.BackgroundWorker()
        Me.BranchAddress = New System.Windows.Forms.Label()
        Me.BranchName = New System.Windows.Forms.Label()
        Me.CheckedBy = New System.Windows.Forms.Label()
        Me.PreparedBy = New System.Windows.Forms.Label()
        Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
        Me.txt_BrCodeParam = New System.Windows.Forms.TextBox()
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCCollectionAging, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BrCodeRepository, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BranchCodeRepository, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTimeEdit2
        '
        Me.RepositoryItemTimeEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemTimeEdit2.Name = "RepositoryItemTimeEdit2"
        '
        'GCCollectionAging
        '
        Me.GCCollectionAging.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCollectionAging.Location = New System.Drawing.Point(0, 48)
        Me.GCCollectionAging.LookAndFeel.SkinName = "Office 2010 Black"
        Me.GCCollectionAging.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GCCollectionAging.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GCCollectionAging.MainView = Me.GridView
        Me.GCCollectionAging.Name = "GCCollectionAging"
        Me.GCCollectionAging.Size = New System.Drawing.Size(923, 368)
        Me.GCCollectionAging.TabIndex = 123
        Me.GCCollectionAging.UseEmbeddedNavigator = True
        Me.GCCollectionAging.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView, Me.CardView1, Me.GridView2, Me.GridView1})
        '
        'GridView
        '
        Me.GridView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.GridView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White
        Me.GridView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Black
        Me.GridView.Appearance.HeaderPanel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.AppearancePrint.EvenRow.Options.UseFont = True
        Me.GridView.AppearancePrint.Preview.BackColor = System.Drawing.Color.White
        Me.GridView.AppearancePrint.Preview.BackColor2 = System.Drawing.Color.White
        Me.GridView.GridControl = Me.GCCollectionAging
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
        'CardView1
        '
        Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5})
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.GCCollectionAging
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
        Me.GridView2.GridControl = Me.GCCollectionAging
        Me.GridView2.Name = "GridView2"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GCCollectionAging
        Me.GridView1.Name = "GridView1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.txt_BranchCode2, Me.BarStaticItem2, Me.CutOffDate, Me.Btn_Reload, Me.BarStaticItem3, Me.txt_AECode, Me.BarStaticItem4, Me.txt_AccountStatus, Me.BarStaticItem5, Me.txt_Corp, Me.Btn_Preview, Me.txt_BranchCode, Me.txt_BrCode})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 14
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.txt_BranchCodeRepository, Me.RepositoryItemDateEdit1, Me.RepositoryItemComboBox1, Me.RepositoryItemComboBox2, Me.RepositoryItemComboBox3, Me.txt_BrCodeRepository})
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_BrCode), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.CutOffDate, "", False, True, True, 96), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.txt_AECode, "", False, True, True, 109), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_AccountStatus), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_Corp), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.Btn_Reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.Btn_Preview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        'txt_BrCode
        '
        Me.txt_BrCode.Edit = Me.txt_BrCodeRepository
        Me.txt_BrCode.EditWidth = 100
        Me.txt_BrCode.Enabled = False
        Me.txt_BrCode.Id = 13
        Me.txt_BrCode.Name = "txt_BrCode"
        '
        'txt_BrCodeRepository
        '
        Me.txt_BrCodeRepository.AutoHeight = False
        Me.txt_BrCodeRepository.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_BrCodeRepository.Name = "txt_BrCodeRepository"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Cut Off Date"
        Me.BarStaticItem2.Id = 2
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'CutOffDate
        '
        Me.CutOffDate.Edit = Me.RepositoryItemDateEdit1
        Me.CutOffDate.EditWidth = 99
        Me.CutOffDate.Id = 3
        Me.CutOffDate.Name = "CutOffDate"
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
        Me.BarStaticItem3.Caption = "AE Code"
        Me.BarStaticItem3.Id = 5
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'txt_AECode
        '
        Me.txt_AECode.Edit = Me.RepositoryItemComboBox1
        Me.txt_AECode.EditWidth = 115
        Me.txt_AECode.Id = 6
        Me.txt_AECode.Name = "txt_AECode"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfficerName", "OfficerName"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("AccountExecutive", "AccountExecutive")})
        Me.RepositoryItemComboBox1.DisplayMember = "OfficerName"
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.ValueMember = "AccountExecutive"
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Caption = "AccountStatus"
        Me.BarStaticItem4.Id = 7
        Me.BarStaticItem4.Name = "BarStaticItem4"
        '
        'txt_AccountStatus
        '
        Me.txt_AccountStatus.Edit = Me.RepositoryItemComboBox2
        Me.txt_AccountStatus.EditWidth = 86
        Me.txt_AccountStatus.Id = 8
        Me.txt_AccountStatus.Name = "txt_AccountStatus"
        '
        'RepositoryItemComboBox2
        '
        Me.RepositoryItemComboBox2.AutoHeight = False
        Me.RepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox2.Name = "RepositoryItemComboBox2"
        '
        'BarStaticItem5
        '
        Me.BarStaticItem5.Caption = "CORP"
        Me.BarStaticItem5.Id = 9
        Me.BarStaticItem5.Name = "BarStaticItem5"
        '
        'txt_Corp
        '
        Me.txt_Corp.Edit = Me.RepositoryItemComboBox3
        Me.txt_Corp.EditWidth = 66
        Me.txt_Corp.Id = 10
        Me.txt_Corp.Name = "txt_Corp"
        '
        'RepositoryItemComboBox3
        '
        Me.RepositoryItemComboBox3.AutoHeight = False
        Me.RepositoryItemComboBox3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox3.Name = "RepositoryItemComboBox3"
        '
        'Btn_Reload
        '
        Me.Btn_Reload.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Btn_Reload.Caption = "Find"
        Me.Btn_Reload.Id = 4
        Me.Btn_Reload.Name = "Btn_Reload"
        '
        'Btn_Preview
        '
        Me.Btn_Preview.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Btn_Preview.Caption = "Preview"
        Me.Btn_Preview.Id = 11
        Me.Btn_Preview.Name = "Btn_Preview"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(923, 48)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 416)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(923, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 48)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 368)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(923, 48)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 368)
        '
        'txt_BranchCode2
        '
        Me.txt_BranchCode2.Edit = Me.txt_BranchCodeRepository
        Me.txt_BranchCode2.EditWidth = 66
        Me.txt_BranchCode2.Id = 1
        Me.txt_BranchCode2.Name = "txt_BranchCode2"
        '
        'txt_BranchCodeRepository
        '
        Me.txt_BranchCodeRepository.AutoHeight = False
        Me.txt_BranchCodeRepository.Name = "txt_BranchCodeRepository"
        '
        'txt_BranchCode
        '
        Me.txt_BranchCode.Edit = Me.txt_BranchCodeRepository
        Me.txt_BranchCode.EditWidth = 103
        Me.txt_BranchCode.Id = 12
        Me.txt_BranchCode.Name = "txt_BranchCode"
        '
        'BWAging
        '
        '
        'BranchAddress
        '
        Me.BranchAddress.Location = New System.Drawing.Point(474, 74)
        Me.BranchAddress.Name = "BranchAddress"
        Me.BranchAddress.Size = New System.Drawing.Size(81, 19)
        Me.BranchAddress.TabIndex = 140
        Me.BranchAddress.Text = "BranchAddress"
        '
        'BranchName
        '
        Me.BranchName.Location = New System.Drawing.Point(398, 74)
        Me.BranchName.Name = "BranchName"
        Me.BranchName.Size = New System.Drawing.Size(81, 19)
        Me.BranchName.TabIndex = 139
        Me.BranchName.Text = "BranchName"
        '
        'CheckedBy
        '
        Me.CheckedBy.Location = New System.Drawing.Point(312, 74)
        Me.CheckedBy.Name = "CheckedBy"
        Me.CheckedBy.Size = New System.Drawing.Size(81, 19)
        Me.CheckedBy.TabIndex = 138
        Me.CheckedBy.Text = "CheckedBy"
        '
        'PreparedBy
        '
        Me.PreparedBy.Location = New System.Drawing.Point(236, 74)
        Me.PreparedBy.Name = "PreparedBy"
        Me.PreparedBy.Size = New System.Drawing.Size(81, 19)
        Me.PreparedBy.TabIndex = 137
        Me.PreparedBy.Text = "PreparedBy:"
        '
        'BarEditItem1
        '
        Me.BarEditItem1.Edit = Me.RepositoryItemDateEdit1
        Me.BarEditItem1.EditWidth = 99
        Me.BarEditItem1.Id = 3
        Me.BarEditItem1.Name = "BarEditItem1"
        '
        'txt_BrCodeParam
        '
        Me.txt_BrCodeParam.Location = New System.Drawing.Point(410, 96)
        Me.txt_BrCodeParam.Name = "txt_BrCodeParam"
        Me.txt_BrCodeParam.Size = New System.Drawing.Size(86, 21)
        Me.txt_BrCodeParam.TabIndex = 145
        Me.txt_BrCodeParam.Visible = False
        '
        'rpt_CollectionAging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 416)
        Me.Controls.Add(Me.txt_BrCodeParam)
        Me.Controls.Add(Me.GCCollectionAging)
        Me.Controls.Add(Me.BranchAddress)
        Me.Controls.Add(Me.BranchName)
        Me.Controls.Add(Me.CheckedBy)
        Me.Controls.Add(Me.PreparedBy)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rpt_CollectionAging"
        Me.Text = "COLLECTION AGING"
        CType(Me.RepositoryItemTimeEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCCollectionAging, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BrCodeRepository, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BranchCodeRepository, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GCCollectionAging As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_BranchCode2 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txt_BranchCodeRepository As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents CutOffDate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_AECode As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_AccountStatus As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarStaticItem5 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_Corp As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BWAging As System.ComponentModel.BackgroundWorker
    Friend WithEvents BranchAddress As Label
    Friend WithEvents BranchName As Label
    Friend WithEvents CheckedBy As Label
    Friend WithEvents PreparedBy As Label
    Friend WithEvents Btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txt_BranchCode As DevExpress.XtraBars.BarEditItem
    Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txt_BrCode As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txt_BrCodeParam As TextBox
    Friend WithEvents RepositoryItemTimeEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents txt_BrCodeRepository As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
