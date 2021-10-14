<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_Master
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_Master))
        Me.lv_Parts = New System.Windows.Forms.ListView()
        Me.partsnumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.superSeed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.srp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btn_Add = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Refresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_BrCode = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_Search = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btn_Find = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txt_ID = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Brand = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtp_TransactionDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Branch = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_PartsName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_PartsNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_SRP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_DiscountPCT = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_DiscountAMT = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_PriceWOVAT = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_PriceWVAT = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_SuperSeed = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Quantity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Remarks = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Note = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ModelName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ModelCode = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Transactedby = New DevExpress.XtraEditors.TextEdit()
        Me.dtp_PostingDate = New DevExpress.XtraEditors.DateEdit()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_TransactionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_TransactionDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Branch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PartsName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PartsNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SRP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DiscountPCT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_DiscountAMT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PriceWOVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PriceWVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SuperSeed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Quantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ModelName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ModelCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Transactedby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_PostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_PostingDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lv_Parts
        '
        Me.lv_Parts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lv_Parts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.partsnumber, Me.partsName, Me.superSeed, Me.brand, Me.srp, Me.ID})
        Me.lv_Parts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Parts.FullRowSelect = True
        Me.lv_Parts.GridLines = True
        Me.lv_Parts.Location = New System.Drawing.Point(12, 229)
        Me.lv_Parts.Name = "lv_Parts"
        Me.lv_Parts.Size = New System.Drawing.Size(1052, 209)
        Me.lv_Parts.TabIndex = 15
        Me.lv_Parts.UseCompatibleStateImageBehavior = False
        Me.lv_Parts.View = System.Windows.Forms.View.Details
        '
        'partsnumber
        '
        Me.partsnumber.Text = "PARTS NUMBER"
        Me.partsnumber.Width = 250
        '
        'partsName
        '
        Me.partsName.Text = "PARTS NAME"
        Me.partsName.Width = 250
        '
        'superSeed
        '
        Me.superSeed.Text = "SUPER CEEDING"
        Me.superSeed.Width = 250
        '
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 150
        '
        'srp
        '
        Me.srp.Text = "SRP"
        Me.srp.Width = 150
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Add, Me.btn_Update, Me.btn_Delete, Me.btn_Refresh, Me.BarStaticItem1, Me.txt_BrCode, Me.BarStaticItem2, Me.txt_Search, Me.btn_Find})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Add, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Update, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Delete, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Refresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_BrCode), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_Search), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Find, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btn_Add
        '
        Me.btn_Add.Caption = "Add"
        Me.btn_Add.Glyph = CType(resources.GetObject("btn_Add.Glyph"), System.Drawing.Image)
        Me.btn_Add.Id = 0
        Me.btn_Add.LargeGlyph = CType(resources.GetObject("btn_Add.LargeGlyph"), System.Drawing.Image)
        Me.btn_Add.Name = "btn_Add"
        '
        'btn_Update
        '
        Me.btn_Update.Caption = "Update"
        Me.btn_Update.Glyph = CType(resources.GetObject("btn_Update.Glyph"), System.Drawing.Image)
        Me.btn_Update.Id = 1
        Me.btn_Update.LargeGlyph = CType(resources.GetObject("btn_Update.LargeGlyph"), System.Drawing.Image)
        Me.btn_Update.Name = "btn_Update"
        '
        'btn_Delete
        '
        Me.btn_Delete.Caption = "Delete"
        Me.btn_Delete.Glyph = CType(resources.GetObject("btn_Delete.Glyph"), System.Drawing.Image)
        Me.btn_Delete.Id = 2
        Me.btn_Delete.LargeGlyph = CType(resources.GetObject("btn_Delete.LargeGlyph"), System.Drawing.Image)
        Me.btn_Delete.Name = "btn_Delete"
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Caption = "Refresh"
        Me.btn_Refresh.Glyph = CType(resources.GetObject("btn_Refresh.Glyph"), System.Drawing.Image)
        Me.btn_Refresh.Id = 3
        Me.btn_Refresh.LargeGlyph = CType(resources.GetObject("btn_Refresh.LargeGlyph"), System.Drawing.Image)
        Me.btn_Refresh.Name = "btn_Refresh"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Branch"
        Me.BarStaticItem1.Id = 4
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'txt_BrCode
        '
        Me.txt_BrCode.Caption = "BarEditItem1"
        Me.txt_BrCode.Edit = Me.RepositoryItemTextEdit1
        Me.txt_BrCode.EditWidth = 51
        Me.txt_BrCode.Id = 5
        Me.txt_BrCode.Name = "txt_BrCode"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Quick Search"
        Me.BarStaticItem2.Id = 6
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'txt_Search
        '
        Me.txt_Search.Caption = "BarEditItem2"
        Me.txt_Search.Edit = Me.RepositoryItemTextEdit2
        Me.txt_Search.EditWidth = 177
        Me.txt_Search.Id = 7
        Me.txt_Search.Name = "txt_Search"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'btn_Find
        '
        Me.btn_Find.Caption = "Find"
        Me.btn_Find.Glyph = CType(resources.GetObject("btn_Find.Glyph"), System.Drawing.Image)
        Me.btn_Find.Id = 8
        Me.btn_Find.Name = "btn_Find"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1076, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 450)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1076, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 426)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1076, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 426)
        '
        'txt_ID
        '
        Me.txt_ID.EnterMoveNextControl = True
        Me.txt_ID.Location = New System.Drawing.Point(112, 54)
        Me.txt_ID.MenuManager = Me.BarManager1
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Properties.Appearance.Options.UseFont = True
        Me.txt_ID.Size = New System.Drawing.Size(145, 26)
        Me.txt_ID.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(65, 57)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(41, 19)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "Inv. ID"
        '
        'cmb_Brand
        '
        Me.cmb_Brand.EnterMoveNextControl = True
        Me.cmb_Brand.Location = New System.Drawing.Point(112, 118)
        Me.cmb_Brand.MenuManager = Me.BarManager1
        Me.cmb_Brand.Name = "cmb_Brand"
        Me.cmb_Brand.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Brand.Properties.Appearance.Options.UseFont = True
        Me.cmb_Brand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Brand.Size = New System.Drawing.Size(145, 26)
        Me.cmb_Brand.TabIndex = 4
        '
        'dtp_TransactionDate
        '
        Me.dtp_TransactionDate.EditValue = Nothing
        Me.dtp_TransactionDate.EnterMoveNextControl = True
        Me.dtp_TransactionDate.Location = New System.Drawing.Point(924, 118)
        Me.dtp_TransactionDate.MenuManager = Me.BarManager1
        Me.dtp_TransactionDate.Name = "dtp_TransactionDate"
        Me.dtp_TransactionDate.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_TransactionDate.Properties.Appearance.Options.UseFont = True
        Me.dtp_TransactionDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_TransactionDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_TransactionDate.Size = New System.Drawing.Size(140, 26)
        Me.dtp_TransactionDate.TabIndex = 15
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(283, 57)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(82, 19)
        Me.LabelControl2.TabIndex = 25
        Me.LabelControl2.Text = "Branch Code"
        '
        'txt_Branch
        '
        Me.txt_Branch.EnterMoveNextControl = True
        Me.txt_Branch.Location = New System.Drawing.Point(381, 54)
        Me.txt_Branch.MenuManager = Me.BarManager1
        Me.txt_Branch.Name = "txt_Branch"
        Me.txt_Branch.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Branch.Properties.Appearance.Options.UseFont = True
        Me.txt_Branch.Size = New System.Drawing.Size(145, 26)
        Me.txt_Branch.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(294, 89)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl3.TabIndex = 29
        Me.LabelControl3.Text = "PartsName"
        '
        'txt_PartsName
        '
        Me.txt_PartsName.EnterMoveNextControl = True
        Me.txt_PartsName.Location = New System.Drawing.Point(381, 86)
        Me.txt_PartsName.MenuManager = Me.BarManager1
        Me.txt_PartsName.Name = "txt_PartsName"
        Me.txt_PartsName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsName.Properties.Appearance.Options.UseFont = True
        Me.txt_PartsName.Size = New System.Drawing.Size(145, 26)
        Me.txt_PartsName.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(21, 89)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(85, 19)
        Me.LabelControl4.TabIndex = 27
        Me.LabelControl4.Text = "PartsNumber"
        '
        'txt_PartsNumber
        '
        Me.txt_PartsNumber.EnterMoveNextControl = True
        Me.txt_PartsNumber.Location = New System.Drawing.Point(112, 86)
        Me.txt_PartsNumber.MenuManager = Me.BarManager1
        Me.txt_PartsNumber.Name = "txt_PartsNumber"
        Me.txt_PartsNumber.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsNumber.Properties.Appearance.Options.UseFont = True
        Me.txt_PartsNumber.Size = New System.Drawing.Size(145, 26)
        Me.txt_PartsNumber.TabIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(65, 121)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl5.TabIndex = 34
        Me.LabelControl5.Text = "Brand"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(341, 121)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(24, 19)
        Me.LabelControl6.TabIndex = 36
        Me.LabelControl6.Text = "SRP"
        '
        'txt_SRP
        '
        Me.txt_SRP.EnterMoveNextControl = True
        Me.txt_SRP.Location = New System.Drawing.Point(381, 118)
        Me.txt_SRP.MenuManager = Me.BarManager1
        Me.txt_SRP.Name = "txt_SRP"
        Me.txt_SRP.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SRP.Properties.Appearance.Options.UseFont = True
        Me.txt_SRP.Size = New System.Drawing.Size(145, 26)
        Me.txt_SRP.TabIndex = 5
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(17, 153)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(86, 19)
        Me.LabelControl7.TabIndex = 38
        Me.LabelControl7.Text = "Discount PCT"
        '
        'txt_DiscountPCT
        '
        Me.txt_DiscountPCT.EnterMoveNextControl = True
        Me.txt_DiscountPCT.Location = New System.Drawing.Point(112, 150)
        Me.txt_DiscountPCT.MenuManager = Me.BarManager1
        Me.txt_DiscountPCT.Name = "txt_DiscountPCT"
        Me.txt_DiscountPCT.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DiscountPCT.Properties.Appearance.Options.UseFont = True
        Me.txt_DiscountPCT.Size = New System.Drawing.Size(145, 26)
        Me.txt_DiscountPCT.TabIndex = 6
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(274, 153)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(91, 19)
        Me.LabelControl8.TabIndex = 40
        Me.LabelControl8.Text = "Discount AMT"
        '
        'txt_DiscountAMT
        '
        Me.txt_DiscountAMT.EnterMoveNextControl = True
        Me.txt_DiscountAMT.Location = New System.Drawing.Point(381, 150)
        Me.txt_DiscountAMT.MenuManager = Me.BarManager1
        Me.txt_DiscountAMT.Name = "txt_DiscountAMT"
        Me.txt_DiscountAMT.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DiscountAMT.Properties.Appearance.Options.UseFont = True
        Me.txt_DiscountAMT.Size = New System.Drawing.Size(145, 26)
        Me.txt_DiscountAMT.TabIndex = 7
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(278, 185)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(87, 19)
        Me.LabelControl9.TabIndex = 44
        Me.LabelControl9.Text = "Price WOVAT"
        '
        'txt_PriceWOVAT
        '
        Me.txt_PriceWOVAT.EnterMoveNextControl = True
        Me.txt_PriceWOVAT.Location = New System.Drawing.Point(381, 182)
        Me.txt_PriceWOVAT.MenuManager = Me.BarManager1
        Me.txt_PriceWOVAT.Name = "txt_PriceWOVAT"
        Me.txt_PriceWOVAT.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PriceWOVAT.Properties.Appearance.Options.UseFont = True
        Me.txt_PriceWOVAT.Size = New System.Drawing.Size(145, 26)
        Me.txt_PriceWOVAT.TabIndex = 9
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(27, 185)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(76, 19)
        Me.LabelControl10.TabIndex = 42
        Me.LabelControl10.Text = "Price WVAT"
        '
        'txt_PriceWVAT
        '
        Me.txt_PriceWVAT.EnterMoveNextControl = True
        Me.txt_PriceWVAT.Location = New System.Drawing.Point(112, 182)
        Me.txt_PriceWVAT.MenuManager = Me.BarManager1
        Me.txt_PriceWVAT.Name = "txt_PriceWVAT"
        Me.txt_PriceWVAT.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PriceWVAT.Properties.Appearance.Options.UseFont = True
        Me.txt_PriceWVAT.Size = New System.Drawing.Size(145, 26)
        Me.txt_PriceWVAT.TabIndex = 8
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(570, 185)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(71, 19)
        Me.LabelControl12.TabIndex = 62
        Me.LabelControl12.Text = "Super Seed"
        '
        'txt_SuperSeed
        '
        Me.txt_SuperSeed.EnterMoveNextControl = True
        Me.txt_SuperSeed.Location = New System.Drawing.Point(655, 182)
        Me.txt_SuperSeed.MenuManager = Me.BarManager1
        Me.txt_SuperSeed.Name = "txt_SuperSeed"
        Me.txt_SuperSeed.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SuperSeed.Properties.Appearance.Options.UseFont = True
        Me.txt_SuperSeed.Size = New System.Drawing.Size(409, 26)
        Me.txt_SuperSeed.TabIndex = 18
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(817, 153)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(79, 19)
        Me.LabelControl13.TabIndex = 60
        Me.LabelControl13.Text = "PostingDate"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Location = New System.Drawing.Point(585, 153)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(56, 19)
        Me.LabelControl14.TabIndex = 58
        Me.LabelControl14.Text = "Quantity"
        '
        'txt_Quantity
        '
        Me.txt_Quantity.EnterMoveNextControl = True
        Me.txt_Quantity.Location = New System.Drawing.Point(655, 150)
        Me.txt_Quantity.MenuManager = Me.BarManager1
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Quantity.Properties.Appearance.Options.UseFont = True
        Me.txt_Quantity.Size = New System.Drawing.Size(145, 26)
        Me.txt_Quantity.TabIndex = 16
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Location = New System.Drawing.Point(814, 121)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(95, 19)
        Me.LabelControl15.TabIndex = 56
        Me.LabelControl15.Text = "Transact. Date"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Location = New System.Drawing.Point(559, 121)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(87, 19)
        Me.LabelControl16.TabIndex = 54
        Me.LabelControl16.Text = "Transactedby"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Location = New System.Drawing.Point(837, 89)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(56, 19)
        Me.LabelControl17.TabIndex = 53
        Me.LabelControl17.Text = "Remarks"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.EnterMoveNextControl = True
        Me.txt_Remarks.Location = New System.Drawing.Point(924, 86)
        Me.txt_Remarks.MenuManager = Me.BarManager1
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Properties.Appearance.Options.UseFont = True
        Me.txt_Remarks.Size = New System.Drawing.Size(140, 26)
        Me.txt_Remarks.TabIndex = 13
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Location = New System.Drawing.Point(615, 93)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(31, 19)
        Me.LabelControl18.TabIndex = 51
        Me.LabelControl18.Text = "Note"
        '
        'txt_Note
        '
        Me.txt_Note.EnterMoveNextControl = True
        Me.txt_Note.Location = New System.Drawing.Point(655, 86)
        Me.txt_Note.MenuManager = Me.BarManager1
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note.Properties.Appearance.Options.UseFont = True
        Me.txt_Note.Size = New System.Drawing.Size(145, 26)
        Me.txt_Note.TabIndex = 12
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Location = New System.Drawing.Point(826, 57)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(83, 19)
        Me.LabelControl19.TabIndex = 49
        Me.LabelControl19.Text = "Model Name"
        '
        'txt_ModelName
        '
        Me.txt_ModelName.EnterMoveNextControl = True
        Me.txt_ModelName.Location = New System.Drawing.Point(924, 54)
        Me.txt_ModelName.MenuManager = Me.BarManager1
        Me.txt_ModelName.Name = "txt_ModelName"
        Me.txt_ModelName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ModelName.Properties.Appearance.Options.UseFont = True
        Me.txt_ModelName.Size = New System.Drawing.Size(140, 26)
        Me.txt_ModelName.TabIndex = 11
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Location = New System.Drawing.Point(568, 57)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(78, 19)
        Me.LabelControl20.TabIndex = 46
        Me.LabelControl20.Text = "Model Code"
        '
        'txt_ModelCode
        '
        Me.txt_ModelCode.EnterMoveNextControl = True
        Me.txt_ModelCode.Location = New System.Drawing.Point(655, 54)
        Me.txt_ModelCode.MenuManager = Me.BarManager1
        Me.txt_ModelCode.Name = "txt_ModelCode"
        Me.txt_ModelCode.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ModelCode.Properties.Appearance.Options.UseFont = True
        Me.txt_ModelCode.Size = New System.Drawing.Size(145, 26)
        Me.txt_ModelCode.TabIndex = 10
        '
        'txt_Transactedby
        '
        Me.txt_Transactedby.EnterMoveNextControl = True
        Me.txt_Transactedby.Location = New System.Drawing.Point(655, 118)
        Me.txt_Transactedby.MenuManager = Me.BarManager1
        Me.txt_Transactedby.Name = "txt_Transactedby"
        Me.txt_Transactedby.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Transactedby.Properties.Appearance.Options.UseFont = True
        Me.txt_Transactedby.Size = New System.Drawing.Size(145, 26)
        Me.txt_Transactedby.TabIndex = 14
        '
        'dtp_PostingDate
        '
        Me.dtp_PostingDate.EditValue = Nothing
        Me.dtp_PostingDate.EnterMoveNextControl = True
        Me.dtp_PostingDate.Location = New System.Drawing.Point(924, 150)
        Me.dtp_PostingDate.MenuManager = Me.BarManager1
        Me.dtp_PostingDate.Name = "dtp_PostingDate"
        Me.dtp_PostingDate.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_PostingDate.Properties.Appearance.Options.UseFont = True
        Me.dtp_PostingDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_PostingDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_PostingDate.Size = New System.Drawing.Size(140, 26)
        Me.dtp_PostingDate.TabIndex = 17
        '
        'ID
        '
        Me.ID.Text = "ID"
        '
        'SPA_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 450)
        Me.Controls.Add(Me.dtp_PostingDate)
        Me.Controls.Add(Me.txt_Transactedby)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txt_SuperSeed)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txt_Quantity)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.txt_Note)
        Me.Controls.Add(Me.LabelControl19)
        Me.Controls.Add(Me.txt_ModelName)
        Me.Controls.Add(Me.LabelControl20)
        Me.Controls.Add(Me.txt_ModelCode)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txt_PriceWOVAT)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txt_PriceWVAT)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txt_DiscountAMT)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txt_DiscountPCT)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txt_SRP)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_PartsName)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_PartsNumber)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_Branch)
        Me.Controls.Add(Me.dtp_TransactionDate)
        Me.Controls.Add(Me.cmb_Brand)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lv_Parts)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "SPA_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPA_Master"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_TransactionDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_TransactionDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Branch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PartsName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PartsNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SRP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DiscountPCT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_DiscountAMT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PriceWOVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PriceWVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SuperSeed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Quantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ModelName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ModelCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Transactedby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_PostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_PostingDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lv_Parts As ListView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_Add As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Refresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_BrCode As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_Search As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btn_Find As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_PartsName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_PartsNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Branch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtp_TransactionDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmb_Brand As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtp_PostingDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_Transactedby As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_SuperSeed As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Quantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Remarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Note As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ModelName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ModelCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_PriceWOVAT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_PriceWVAT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_DiscountAMT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_DiscountPCT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_SRP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents partsnumber As ColumnHeader
    Friend WithEvents partsName As ColumnHeader
    Friend WithEvents superSeed As ColumnHeader
    Friend WithEvents brand As ColumnHeader
    Friend WithEvents srp As ColumnHeader
    Friend WithEvents ID As ColumnHeader
End Class
