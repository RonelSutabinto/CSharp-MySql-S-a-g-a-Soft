<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_Branch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_Branch))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btn_New1 = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Refresh = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_BrCode = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_Search = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btn_Find = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.statusQuantity = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem5 = New DevExpress.XtraBars.BarStaticItem()
        Me.statusTotalSRP = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.ToolFind = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
        Me.statusTotalCost = New DevExpress.XtraBars.BarStaticItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.lv_Parts = New System.Windows.Forms.ListView()
        Me.BranchCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PartsNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PartsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InventoryStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Prev_Quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SRP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SPCostWOVAT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_ID = New DevExpress.XtraEditors.TextEdit()
        Me.cmb_Brand = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtp_PostingDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_PartsName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_PartsNumber = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cmb_Category = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_ModelCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ModelName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Note = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Remarks = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Status = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_BranchCode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Refno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_POno = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Branch = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Approver = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Checker = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_CostWOVAT = New DevExpress.XtraEditors.TextEdit()
        Me.txt_CostWVAT = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Prev_Quantity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Quantity = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.dtp_DateCheck = New DevExpress.XtraEditors.DateEdit()
        Me.dtp_DateApproved = New DevExpress.XtraEditors.DateEdit()
        Me.txt_Source = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_CurrentApprover = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_SRP = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_BinBox = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_TotalLess = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_SubTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Discount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_GrandTotal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_TotalCostWOVAT = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_PostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_PostingDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PartsName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PartsNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Category.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ModelCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ModelName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BranchCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Refno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_POno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Branch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Approver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Checker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CostWOVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CostWVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Prev_Quantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Quantity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_DateCheck.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_DateCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_DateApproved.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_DateApproved.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Source.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CurrentApprover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SRP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BinBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TotalLess.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SubTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_GrandTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TotalCostWOVAT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ToolFind, Me.BarStaticItem2, Me.txt_Search, Me.btn_Find, Me.btn_Save, Me.btn_Delete, Me.btn_Refresh, Me.btn_New, Me.btn_New1, Me.BarStaticItem1, Me.txt_BrCode, Me.statusQuantity, Me.statusTotalCost, Me.BarStaticItem3, Me.BarStaticItem4, Me.BarStaticItem5, Me.statusTotalSRP})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 23
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5})
        Me.BarManager1.StatusBar = Me.Bar1
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(2872, 214)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_New1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete, True), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Refresh, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_BrCode), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_Search), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Find, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btn_New1
        '
        Me.btn_New1.Caption = "New"
        Me.btn_New1.Id = 11
        Me.btn_New1.ImageOptions.Image = CType(resources.GetObject("btn_New1.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_New1.ImageOptions.LargeImage = CType(resources.GetObject("btn_New1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_New1.Name = "btn_New1"
        '
        'btn_Save
        '
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.Id = 7
        Me.btn_Save.ImageOptions.Image = CType(resources.GetObject("btn_Save.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Save.ImageOptions.LargeImage = CType(resources.GetObject("btn_Save.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btn_Delete
        '
        Me.btn_Delete.Caption = "Delete"
        Me.btn_Delete.Id = 8
        Me.btn_Delete.ImageOptions.Image = CType(resources.GetObject("btn_Delete.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Delete.ImageOptions.LargeImage = CType(resources.GetObject("btn_Delete.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Delete.Name = "btn_Delete"
        Me.btn_Delete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Caption = "Refresh"
        Me.btn_Refresh.Id = 9
        Me.btn_Refresh.ImageOptions.Image = CType(resources.GetObject("btn_Refresh.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Refresh.ImageOptions.LargeImage = CType(resources.GetObject("btn_Refresh.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btn_Refresh.Name = "btn_Refresh"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Branch"
        Me.BarStaticItem1.Id = 14
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'txt_BrCode
        '
        Me.txt_BrCode.Caption = "BarEditItem1"
        Me.txt_BrCode.Edit = Me.RepositoryItemTextEdit5
        Me.txt_BrCode.Id = 16
        Me.txt_BrCode.Name = "txt_BrCode"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Search Parts No. / Parts Name:"
        Me.BarStaticItem2.Id = 4
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'txt_Search
        '
        Me.txt_Search.Edit = Me.RepositoryItemTextEdit3
        Me.txt_Search.EditWidth = 164
        Me.txt_Search.Id = 5
        Me.txt_Search.Name = "txt_Search"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'btn_Find
        '
        Me.btn_Find.Caption = "Find"
        Me.btn_Find.Id = 6
        Me.btn_Find.ImageOptions.Image = CType(resources.GetObject("btn_Find.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Find.Name = "btn_Find"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 3"
        Me.Bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.statusQuantity), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.statusTotalSRP)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Custom 3"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "TOTAL QUANTITY = "
        Me.BarStaticItem3.Id = 19
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'statusQuantity
        '
        Me.statusQuantity.Caption = "0"
        Me.statusQuantity.Id = 17
        Me.statusQuantity.Name = "statusQuantity"
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Caption = "TOTAL COST = "
        Me.BarStaticItem4.Id = 20
        Me.BarStaticItem4.Name = "BarStaticItem4"
        '
        'BarStaticItem5
        '
        Me.BarStaticItem5.Caption = "TOTAL SRP = "
        Me.BarStaticItem5.Id = 21
        Me.BarStaticItem5.Name = "BarStaticItem5"
        '
        'statusTotalSRP
        '
        Me.statusTotalSRP.Caption = "0"
        Me.statusTotalSRP.Id = 22
        Me.statusTotalSRP.Name = "statusTotalSRP"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(924, 26)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 484)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(924, 26)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 26)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 458)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(924, 26)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 458)
        '
        'ToolFind
        '
        Me.ToolFind.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.ToolFind.Caption = "Find"
        Me.ToolFind.Id = 3
        Me.ToolFind.ImageOptions.Image = CType(resources.GetObject("ToolFind.ImageOptions.Image"), System.Drawing.Image)
        Me.ToolFind.Name = "ToolFind"
        Me.ToolFind.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btn_New
        '
        Me.btn_New.Caption = "New"
        Me.btn_New.Id = 10
        Me.btn_New.Name = "btn_New"
        Me.btn_New.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'statusTotalCost
        '
        Me.statusTotalCost.Caption = "0"
        Me.statusTotalCost.Id = 18
        Me.statusTotalCost.Name = "statusTotalCost"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'lv_Parts
        '
        Me.lv_Parts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lv_Parts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BranchCode, Me.PartsNumber, Me.PartsName, Me.InventoryStatus, Me.Quantity, Me.Prev_Quantity, Me.SRP, Me.SPCostWOVAT, Me.SubTotal, Me.ID})
        Me.lv_Parts.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Parts.FullRowSelect = True
        Me.lv_Parts.GridLines = True
        Me.lv_Parts.HideSelection = False
        Me.lv_Parts.Location = New System.Drawing.Point(12, 303)
        Me.lv_Parts.Name = "lv_Parts"
        Me.lv_Parts.Size = New System.Drawing.Size(903, 178)
        Me.lv_Parts.TabIndex = 14
        Me.lv_Parts.UseCompatibleStateImageBehavior = False
        Me.lv_Parts.View = System.Windows.Forms.View.Details
        '
        'BranchCode
        '
        Me.BranchCode.Text = "BRANCH CODE"
        Me.BranchCode.Width = 120
        '
        'PartsNumber
        '
        Me.PartsNumber.Text = "PARTS NUMBER"
        Me.PartsNumber.Width = 200
        '
        'PartsName
        '
        Me.PartsName.Text = "PARTS NAME"
        Me.PartsName.Width = 200
        '
        'InventoryStatus
        '
        Me.InventoryStatus.Text = "INVENTORY STATUS"
        Me.InventoryStatus.Width = 200
        '
        'Quantity
        '
        Me.Quantity.Text = "QTY"
        Me.Quantity.Width = 150
        '
        'Prev_Quantity
        '
        Me.Prev_Quantity.Text = "Previous Quantity"
        Me.Prev_Quantity.Width = 150
        '
        'SRP
        '
        Me.SRP.Text = "SRP"
        Me.SRP.Width = 150
        '
        'SPCostWOVAT
        '
        Me.SPCostWOVAT.Text = "COST W/O VAT"
        Me.SPCostWOVAT.Width = 150
        '
        'SubTotal
        '
        Me.SubTotal.Text = "SUB TOTAL"
        Me.SubTotal.Width = 150
        '
        'ID
        '
        Me.ID.Text = "Inventory ID"
        Me.ID.Width = 120
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(109, 33)
        Me.txt_ID.MenuManager = Me.BarManager1
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Properties.Appearance.Options.UseFont = True
        Me.txt_ID.Properties.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(122, 24)
        Me.txt_ID.TabIndex = 15
        '
        'cmb_Brand
        '
        Me.cmb_Brand.Location = New System.Drawing.Point(109, 93)
        Me.cmb_Brand.MenuManager = Me.BarManager1
        Me.cmb_Brand.Name = "cmb_Brand"
        Me.cmb_Brand.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Brand.Properties.Appearance.Options.UseFont = True
        Me.cmb_Brand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Brand.Size = New System.Drawing.Size(122, 24)
        Me.cmb_Brand.TabIndex = 16
        '
        'dtp_PostingDate
        '
        Me.dtp_PostingDate.EditValue = Nothing
        Me.dtp_PostingDate.Location = New System.Drawing.Point(109, 213)
        Me.dtp_PostingDate.MenuManager = Me.BarManager1
        Me.dtp_PostingDate.Name = "dtp_PostingDate"
        Me.dtp_PostingDate.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_PostingDate.Properties.Appearance.Options.UseFont = True
        Me.dtp_PostingDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_PostingDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_PostingDate.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dtp_PostingDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_PostingDate.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtp_PostingDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_PostingDate.Properties.Mask.EditMask = "MM/dd/yyyy"
        Me.dtp_PostingDate.Size = New System.Drawing.Size(122, 24)
        Me.dtp_PostingDate.TabIndex = 17
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(15, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(76, 18)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "Inventory ID"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(239, 66)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 18)
        Me.LabelControl2.TabIndex = 19
        Me.LabelControl2.Text = "PartsName"
        '
        'txt_PartsName
        '
        Me.txt_PartsName.Location = New System.Drawing.Point(328, 63)
        Me.txt_PartsName.MenuManager = Me.BarManager1
        Me.txt_PartsName.Name = "txt_PartsName"
        Me.txt_PartsName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsName.Properties.Appearance.Options.UseFont = True
        Me.txt_PartsName.Size = New System.Drawing.Size(128, 24)
        Me.txt_PartsName.TabIndex = 20
        '
        'txt_PartsNumber
        '
        Me.txt_PartsNumber.Location = New System.Drawing.Point(109, 63)
        Me.txt_PartsNumber.MenuManager = Me.BarManager1
        Me.txt_PartsNumber.Name = "txt_PartsNumber"
        Me.txt_PartsNumber.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsNumber.Properties.Appearance.Options.UseFont = True
        Me.txt_PartsNumber.Size = New System.Drawing.Size(122, 24)
        Me.txt_PartsNumber.TabIndex = 22
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(9, 66)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(82, 18)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "PartsNumber"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(55, 96)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(36, 18)
        Me.LabelControl4.TabIndex = 23
        Me.LabelControl4.Text = "Brand"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(252, 96)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 18)
        Me.LabelControl5.TabIndex = 29
        Me.LabelControl5.Text = "Category"
        '
        'cmb_Category
        '
        Me.cmb_Category.Location = New System.Drawing.Point(328, 93)
        Me.cmb_Category.MenuManager = Me.BarManager1
        Me.cmb_Category.Name = "cmb_Category"
        Me.cmb_Category.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Category.Properties.Appearance.Options.UseFont = True
        Me.cmb_Category.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Category.Size = New System.Drawing.Size(128, 24)
        Me.cmb_Category.TabIndex = 28
        '
        'txt_ModelCode
        '
        Me.txt_ModelCode.Location = New System.Drawing.Point(109, 123)
        Me.txt_ModelCode.MenuManager = Me.BarManager1
        Me.txt_ModelCode.Name = "txt_ModelCode"
        Me.txt_ModelCode.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ModelCode.Properties.Appearance.Options.UseFont = True
        Me.txt_ModelCode.Size = New System.Drawing.Size(122, 24)
        Me.txt_ModelCode.TabIndex = 33
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(9, 126)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(72, 18)
        Me.LabelControl6.TabIndex = 32
        Me.LabelControl6.Text = "ModelCode"
        '
        'txt_ModelName
        '
        Me.txt_ModelName.Location = New System.Drawing.Point(328, 123)
        Me.txt_ModelName.MenuManager = Me.BarManager1
        Me.txt_ModelName.Name = "txt_ModelName"
        Me.txt_ModelName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ModelName.Properties.Appearance.Options.UseFont = True
        Me.txt_ModelName.Size = New System.Drawing.Size(128, 24)
        Me.txt_ModelName.TabIndex = 31
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(239, 126)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(77, 18)
        Me.LabelControl7.TabIndex = 30
        Me.LabelControl7.Text = "ModelName"
        '
        'txt_Note
        '
        Me.txt_Note.Location = New System.Drawing.Point(109, 153)
        Me.txt_Note.MenuManager = Me.BarManager1
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note.Properties.Appearance.Options.UseFont = True
        Me.txt_Note.Size = New System.Drawing.Size(307, 24)
        Me.txt_Note.TabIndex = 37
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(50, 159)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(31, 18)
        Me.LabelControl8.TabIndex = 36
        Me.LabelControl8.Text = "Note"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Location = New System.Drawing.Point(109, 183)
        Me.txt_Remarks.MenuManager = Me.BarManager1
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Properties.Appearance.Options.UseFont = True
        Me.txt_Remarks.Size = New System.Drawing.Size(307, 24)
        Me.txt_Remarks.TabIndex = 35
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(30, 186)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(53, 18)
        Me.LabelControl9.TabIndex = 34
        Me.LabelControl9.Text = "Remarks"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(12, 216)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl10.TabIndex = 38
        Me.LabelControl10.Text = "PostingDate"
        '
        'txt_Status
        '
        Me.txt_Status.Location = New System.Drawing.Point(311, 215)
        Me.txt_Status.MenuManager = Me.BarManager1
        Me.txt_Status.Name = "txt_Status"
        Me.txt_Status.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Status.Properties.Appearance.Options.UseFont = True
        Me.txt_Status.Size = New System.Drawing.Size(105, 24)
        Me.txt_Status.TabIndex = 40
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(235, 218)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(64, 18)
        Me.LabelControl11.TabIndex = 39
        Me.LabelControl11.Text = "Inv_Status"
        '
        'txt_BranchCode
        '
        Me.txt_BranchCode.Location = New System.Drawing.Point(328, 33)
        Me.txt_BranchCode.MenuManager = Me.BarManager1
        Me.txt_BranchCode.Name = "txt_BranchCode"
        Me.txt_BranchCode.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BranchCode.Properties.Appearance.Options.UseFont = True
        Me.txt_BranchCode.Size = New System.Drawing.Size(128, 24)
        Me.txt_BranchCode.TabIndex = 42
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(242, 36)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(77, 18)
        Me.LabelControl12.TabIndex = 41
        Me.LabelControl12.Text = "Branch Code"
        '
        'txt_Refno
        '
        Me.txt_Refno.Location = New System.Drawing.Point(109, 243)
        Me.txt_Refno.MenuManager = Me.BarManager1
        Me.txt_Refno.Name = "txt_Refno"
        Me.txt_Refno.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Refno.Properties.Appearance.Options.UseFont = True
        Me.txt_Refno.Size = New System.Drawing.Size(122, 24)
        Me.txt_Refno.TabIndex = 46
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(50, 246)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(37, 18)
        Me.LabelControl13.TabIndex = 45
        Me.LabelControl13.Text = "Refno"
        '
        'txt_POno
        '
        Me.txt_POno.Location = New System.Drawing.Point(311, 245)
        Me.txt_POno.MenuManager = Me.BarManager1
        Me.txt_POno.Name = "txt_POno"
        Me.txt_POno.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POno.Properties.Appearance.Options.UseFont = True
        Me.txt_POno.Size = New System.Drawing.Size(105, 24)
        Me.txt_POno.TabIndex = 44
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(263, 248)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(36, 18)
        Me.LabelControl14.TabIndex = 43
        Me.LabelControl14.Text = "PONo"
        '
        'txt_Branch
        '
        Me.txt_Branch.Location = New System.Drawing.Point(109, 273)
        Me.txt_Branch.MenuManager = Me.BarManager1
        Me.txt_Branch.Name = "txt_Branch"
        Me.txt_Branch.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Branch.Properties.Appearance.Options.UseFont = True
        Me.txt_Branch.Size = New System.Drawing.Size(406, 24)
        Me.txt_Branch.TabIndex = 48
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseForeColor = True
        Me.LabelControl15.Location = New System.Drawing.Point(9, 276)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(94, 18)
        Me.LabelControl15.TabIndex = 47
        Me.LabelControl15.Text = "Vendor/Branch"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Appearance.Options.UseForeColor = True
        Me.LabelControl18.Location = New System.Drawing.Point(716, 123)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(93, 18)
        Me.LabelControl18.TabIndex = 69
        Me.LabelControl18.Text = "Date Approved"
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Appearance.Options.UseForeColor = True
        Me.LabelControl19.Location = New System.Drawing.Point(501, 126)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(69, 18)
        Me.LabelControl19.TabIndex = 66
        Me.LabelControl19.Text = "Date Check"
        '
        'txt_Approver
        '
        Me.txt_Approver.Location = New System.Drawing.Point(815, 87)
        Me.txt_Approver.MenuManager = Me.BarManager1
        Me.txt_Approver.Name = "txt_Approver"
        Me.txt_Approver.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Approver.Properties.Appearance.Options.UseFont = True
        Me.txt_Approver.Size = New System.Drawing.Size(100, 24)
        Me.txt_Approver.TabIndex = 65
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(751, 90)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(58, 18)
        Me.LabelControl16.TabIndex = 64
        Me.LabelControl16.Text = "Approver"
        '
        'txt_Checker
        '
        Me.txt_Checker.Location = New System.Drawing.Point(581, 90)
        Me.txt_Checker.MenuManager = Me.BarManager1
        Me.txt_Checker.Name = "txt_Checker"
        Me.txt_Checker.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Checker.Properties.Appearance.Options.UseFont = True
        Me.txt_Checker.Size = New System.Drawing.Size(131, 24)
        Me.txt_Checker.TabIndex = 63
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Appearance.Options.UseForeColor = True
        Me.LabelControl17.Location = New System.Drawing.Point(461, 93)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(114, 18)
        Me.LabelControl17.TabIndex = 62
        Me.LabelControl17.Text = "Checker/Partsman"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Appearance.Options.UseForeColor = True
        Me.LabelControl20.Location = New System.Drawing.Point(733, 60)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(76, 18)
        Me.LabelControl20.TabIndex = 77
        Me.LabelControl20.Text = "Cost WoVAT"
        '
        'txt_CostWOVAT
        '
        Me.txt_CostWOVAT.Location = New System.Drawing.Point(815, 57)
        Me.txt_CostWOVAT.MenuManager = Me.BarManager1
        Me.txt_CostWOVAT.Name = "txt_CostWOVAT"
        Me.txt_CostWOVAT.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CostWOVAT.Properties.Appearance.Options.UseFont = True
        Me.txt_CostWOVAT.Size = New System.Drawing.Size(100, 24)
        Me.txt_CostWOVAT.TabIndex = 76
        '
        'txt_CostWVAT
        '
        Me.txt_CostWVAT.Location = New System.Drawing.Point(581, 60)
        Me.txt_CostWVAT.MenuManager = Me.BarManager1
        Me.txt_CostWVAT.Name = "txt_CostWVAT"
        Me.txt_CostWVAT.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CostWVAT.Properties.Appearance.Options.UseFont = True
        Me.txt_CostWVAT.Size = New System.Drawing.Size(131, 24)
        Me.txt_CostWVAT.TabIndex = 75
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Appearance.Options.UseForeColor = True
        Me.LabelControl21.Location = New System.Drawing.Point(501, 66)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(68, 18)
        Me.LabelControl21.TabIndex = 74
        Me.LabelControl21.Text = "Cost WVAT"
        '
        'txt_Prev_Quantity
        '
        Me.txt_Prev_Quantity.Location = New System.Drawing.Point(815, 27)
        Me.txt_Prev_Quantity.MenuManager = Me.BarManager1
        Me.txt_Prev_Quantity.Name = "txt_Prev_Quantity"
        Me.txt_Prev_Quantity.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Prev_Quantity.Properties.Appearance.Options.UseFont = True
        Me.txt_Prev_Quantity.Size = New System.Drawing.Size(100, 24)
        Me.txt_Prev_Quantity.TabIndex = 73
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Appearance.Options.UseForeColor = True
        Me.LabelControl22.Location = New System.Drawing.Point(720, 30)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(89, 18)
        Me.LabelControl22.TabIndex = 72
        Me.LabelControl22.Text = "Prev_Quantity"
        '
        'txt_Quantity
        '
        Me.txt_Quantity.Location = New System.Drawing.Point(581, 30)
        Me.txt_Quantity.MenuManager = Me.BarManager1
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Quantity.Properties.Appearance.Options.UseFont = True
        Me.txt_Quantity.Size = New System.Drawing.Size(131, 24)
        Me.txt_Quantity.TabIndex = 71
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl23.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Appearance.Options.UseForeColor = True
        Me.LabelControl23.Location = New System.Drawing.Point(515, 33)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(54, 18)
        Me.LabelControl23.TabIndex = 70
        Me.LabelControl23.Text = "Quantity"
        '
        'dtp_DateCheck
        '
        Me.dtp_DateCheck.EditValue = Nothing
        Me.dtp_DateCheck.Location = New System.Drawing.Point(581, 123)
        Me.dtp_DateCheck.MenuManager = Me.BarManager1
        Me.dtp_DateCheck.Name = "dtp_DateCheck"
        Me.dtp_DateCheck.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DateCheck.Properties.Appearance.Options.UseFont = True
        Me.dtp_DateCheck.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_DateCheck.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_DateCheck.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dtp_DateCheck.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_DateCheck.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtp_DateCheck.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_DateCheck.Properties.Mask.EditMask = "MM/dd/yyyy"
        Me.dtp_DateCheck.Size = New System.Drawing.Size(131, 24)
        Me.dtp_DateCheck.TabIndex = 78
        '
        'dtp_DateApproved
        '
        Me.dtp_DateApproved.EditValue = Nothing
        Me.dtp_DateApproved.Location = New System.Drawing.Point(815, 120)
        Me.dtp_DateApproved.MenuManager = Me.BarManager1
        Me.dtp_DateApproved.Name = "dtp_DateApproved"
        Me.dtp_DateApproved.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_DateApproved.Properties.Appearance.Options.UseFont = True
        Me.dtp_DateApproved.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_DateApproved.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_DateApproved.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dtp_DateApproved.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_DateApproved.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtp_DateApproved.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_DateApproved.Properties.Mask.EditMask = "MM/dd/yyyy"
        Me.dtp_DateApproved.Size = New System.Drawing.Size(100, 24)
        Me.dtp_DateApproved.TabIndex = 79
        '
        'txt_Source
        '
        Me.txt_Source.Location = New System.Drawing.Point(793, 156)
        Me.txt_Source.MenuManager = Me.BarManager1
        Me.txt_Source.Name = "txt_Source"
        Me.txt_Source.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Source.Properties.Appearance.Options.UseFont = True
        Me.txt_Source.Size = New System.Drawing.Size(122, 24)
        Me.txt_Source.TabIndex = 83
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl24.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl24.Appearance.Options.UseFont = True
        Me.LabelControl24.Appearance.Options.UseForeColor = True
        Me.LabelControl24.Location = New System.Drawing.Point(707, 159)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(80, 18)
        Me.LabelControl24.TabIndex = 82
        Me.LabelControl24.Text = "Source Event"
        '
        'txt_CurrentApprover
        '
        Me.txt_CurrentApprover.Location = New System.Drawing.Point(539, 156)
        Me.txt_CurrentApprover.MenuManager = Me.BarManager1
        Me.txt_CurrentApprover.Name = "txt_CurrentApprover"
        Me.txt_CurrentApprover.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CurrentApprover.Properties.Appearance.Options.UseFont = True
        Me.txt_CurrentApprover.Size = New System.Drawing.Size(109, 24)
        Me.txt_CurrentApprover.TabIndex = 81
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl25.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl25.Appearance.Options.UseFont = True
        Me.LabelControl25.Appearance.Options.UseForeColor = True
        Me.LabelControl25.Location = New System.Drawing.Point(419, 159)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(108, 18)
        Me.LabelControl25.TabIndex = 80
        Me.LabelControl25.Text = "Current Approver"
        '
        'txt_SRP
        '
        Me.txt_SRP.Location = New System.Drawing.Point(539, 186)
        Me.txt_SRP.MenuManager = Me.BarManager1
        Me.txt_SRP.Name = "txt_SRP"
        Me.txt_SRP.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SRP.Properties.Appearance.Options.UseFont = True
        Me.txt_SRP.Size = New System.Drawing.Size(109, 24)
        Me.txt_SRP.TabIndex = 85
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl26.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl26.Appearance.Options.UseFont = True
        Me.LabelControl26.Appearance.Options.UseForeColor = True
        Me.LabelControl26.Location = New System.Drawing.Point(504, 189)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(23, 18)
        Me.LabelControl26.TabIndex = 84
        Me.LabelControl26.Text = "SRP"
        '
        'txt_BinBox
        '
        Me.txt_BinBox.Location = New System.Drawing.Point(793, 186)
        Me.txt_BinBox.MenuManager = Me.BarManager1
        Me.txt_BinBox.Name = "txt_BinBox"
        Me.txt_BinBox.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BinBox.Properties.Appearance.Options.UseFont = True
        Me.txt_BinBox.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_BinBox.Size = New System.Drawing.Size(122, 24)
        Me.txt_BinBox.TabIndex = 87
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl27.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl27.Appearance.Options.UseFont = True
        Me.LabelControl27.Appearance.Options.UseForeColor = True
        Me.LabelControl27.Location = New System.Drawing.Point(744, 189)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(43, 18)
        Me.LabelControl27.TabIndex = 86
        Me.LabelControl27.Text = "BinBox"
        '
        'txt_TotalLess
        '
        Me.txt_TotalLess.Location = New System.Drawing.Point(793, 216)
        Me.txt_TotalLess.MenuManager = Me.BarManager1
        Me.txt_TotalLess.Name = "txt_TotalLess"
        Me.txt_TotalLess.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalLess.Properties.Appearance.Options.UseFont = True
        Me.txt_TotalLess.Size = New System.Drawing.Size(122, 24)
        Me.txt_TotalLess.TabIndex = 91
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl28.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl28.Appearance.Options.UseFont = True
        Me.LabelControl28.Appearance.Options.UseForeColor = True
        Me.LabelControl28.Location = New System.Drawing.Point(729, 219)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(57, 18)
        Me.LabelControl28.TabIndex = 90
        Me.LabelControl28.Text = "TotalLess"
        '
        'txt_SubTotal
        '
        Me.txt_SubTotal.Location = New System.Drawing.Point(539, 216)
        Me.txt_SubTotal.MenuManager = Me.BarManager1
        Me.txt_SubTotal.Name = "txt_SubTotal"
        Me.txt_SubTotal.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubTotal.Properties.Appearance.Options.UseFont = True
        Me.txt_SubTotal.Size = New System.Drawing.Size(109, 24)
        Me.txt_SubTotal.TabIndex = 89
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl29.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl29.Appearance.Options.UseFont = True
        Me.LabelControl29.Appearance.Options.UseForeColor = True
        Me.LabelControl29.Location = New System.Drawing.Point(474, 219)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(54, 18)
        Me.LabelControl29.TabIndex = 88
        Me.LabelControl29.Text = "SubTotal"
        '
        'txt_Discount
        '
        Me.txt_Discount.Location = New System.Drawing.Point(793, 246)
        Me.txt_Discount.MenuManager = Me.BarManager1
        Me.txt_Discount.Name = "txt_Discount"
        Me.txt_Discount.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Discount.Properties.Appearance.Options.UseFont = True
        Me.txt_Discount.Size = New System.Drawing.Size(122, 24)
        Me.txt_Discount.TabIndex = 95
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl30.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl30.Appearance.Options.UseFont = True
        Me.LabelControl30.Appearance.Options.UseForeColor = True
        Me.LabelControl30.Location = New System.Drawing.Point(702, 249)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(85, 18)
        Me.LabelControl30.TabIndex = 94
        Me.LabelControl30.Text = "TotalDiscount"
        '
        'txt_GrandTotal
        '
        Me.txt_GrandTotal.Location = New System.Drawing.Point(539, 246)
        Me.txt_GrandTotal.MenuManager = Me.BarManager1
        Me.txt_GrandTotal.Name = "txt_GrandTotal"
        Me.txt_GrandTotal.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GrandTotal.Properties.Appearance.Options.UseFont = True
        Me.txt_GrandTotal.Size = New System.Drawing.Size(109, 24)
        Me.txt_GrandTotal.TabIndex = 93
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl31.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl31.Appearance.Options.UseFont = True
        Me.LabelControl31.Appearance.Options.UseForeColor = True
        Me.LabelControl31.Location = New System.Drawing.Point(460, 249)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(68, 18)
        Me.LabelControl31.TabIndex = 92
        Me.LabelControl31.Text = "GrandTotal"
        '
        'txt_TotalCostWOVAT
        '
        Me.txt_TotalCostWOVAT.Location = New System.Drawing.Point(670, 274)
        Me.txt_TotalCostWOVAT.MenuManager = Me.BarManager1
        Me.txt_TotalCostWOVAT.Name = "txt_TotalCostWOVAT"
        Me.txt_TotalCostWOVAT.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalCostWOVAT.Properties.Appearance.Options.UseFont = True
        Me.txt_TotalCostWOVAT.Size = New System.Drawing.Size(245, 24)
        Me.txt_TotalCostWOVAT.TabIndex = 97
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl32.Appearance.Options.UseFont = True
        Me.LabelControl32.Location = New System.Drawing.Point(551, 277)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(113, 18)
        Me.LabelControl32.TabIndex = 96
        Me.LabelControl32.Text = "Total Cost Wo VAT"
        '
        'SPA_Branch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(924, 510)
        Me.Controls.Add(Me.txt_TotalCostWOVAT)
        Me.Controls.Add(Me.LabelControl32)
        Me.Controls.Add(Me.txt_Discount)
        Me.Controls.Add(Me.LabelControl30)
        Me.Controls.Add(Me.txt_GrandTotal)
        Me.Controls.Add(Me.LabelControl31)
        Me.Controls.Add(Me.txt_TotalLess)
        Me.Controls.Add(Me.LabelControl28)
        Me.Controls.Add(Me.txt_SubTotal)
        Me.Controls.Add(Me.LabelControl29)
        Me.Controls.Add(Me.txt_BinBox)
        Me.Controls.Add(Me.LabelControl27)
        Me.Controls.Add(Me.txt_SRP)
        Me.Controls.Add(Me.LabelControl26)
        Me.Controls.Add(Me.txt_Source)
        Me.Controls.Add(Me.LabelControl24)
        Me.Controls.Add(Me.txt_CurrentApprover)
        Me.Controls.Add(Me.LabelControl25)
        Me.Controls.Add(Me.dtp_DateApproved)
        Me.Controls.Add(Me.dtp_DateCheck)
        Me.Controls.Add(Me.LabelControl20)
        Me.Controls.Add(Me.txt_CostWOVAT)
        Me.Controls.Add(Me.txt_CostWVAT)
        Me.Controls.Add(Me.LabelControl21)
        Me.Controls.Add(Me.txt_Prev_Quantity)
        Me.Controls.Add(Me.LabelControl22)
        Me.Controls.Add(Me.txt_Quantity)
        Me.Controls.Add(Me.LabelControl23)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.LabelControl19)
        Me.Controls.Add(Me.txt_Approver)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.txt_Checker)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.txt_Branch)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.txt_Refno)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txt_POno)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txt_BranchCode)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txt_Status)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txt_Note)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txt_ModelCode)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txt_ModelName)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cmb_Category)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_PartsNumber)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_PartsName)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.dtp_PostingDate)
        Me.Controls.Add(Me.cmb_Brand)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lv_Parts)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SPA_Branch"
        Me.Text = "SPARE PARTS MANAGEMENT"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_PostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_PostingDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PartsName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PartsNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Category.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ModelCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ModelName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BranchCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Refno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_POno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Branch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Approver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Checker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CostWOVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CostWVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Prev_Quantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Quantity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_DateCheck.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_DateCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_DateApproved.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_DateApproved.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Source.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CurrentApprover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SRP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BinBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TotalLess.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SubTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_GrandTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TotalCostWOVAT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ToolFind As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_Search As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btn_Find As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Refresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_PartsNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_PartsName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtp_PostingDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmb_Brand As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lv_Parts As ListView
    Friend WithEvents txt_Branch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Refno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_POno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_BranchCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Status As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Note As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Remarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ModelCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ModelName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_Category As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_TotalCostWOVAT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Discount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_GrandTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_TotalLess As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_SubTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_BinBox As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_SRP As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Source As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_CurrentApprover As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtp_DateApproved As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtp_DateCheck As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_CostWOVAT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_CostWVAT As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Prev_Quantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Quantity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Approver As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Checker As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_New1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BranchCode As ColumnHeader
    Friend WithEvents PartsNumber As ColumnHeader
    Friend WithEvents PartsName As ColumnHeader
    Friend WithEvents Quantity As ColumnHeader
    Friend WithEvents SRP As ColumnHeader
    Friend WithEvents SPCostWOVAT As ColumnHeader
    Friend WithEvents SubTotal As ColumnHeader
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents InventoryStatus As ColumnHeader
    Friend WithEvents Prev_Quantity As ColumnHeader
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_BrCode As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents statusQuantity As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents statusTotalCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem5 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents statusTotalSRP As DevExpress.XtraBars.BarStaticItem
End Class
