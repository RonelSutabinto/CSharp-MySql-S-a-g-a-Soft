<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rpt_MCForDepo
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    private sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.BarEditItem_CutOff = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.Frmbtn_Update = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_Remarks = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_LedgerSetNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txt_AccountNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txt_BranchCode = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.BranchCode = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.AccountNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LedgerSetNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.GCList = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BranchName = New System.Windows.Forms.Label()
        Me.CheckedBy = New System.Windows.Forms.Label()
        Me.PreparedBy = New System.Windows.Forms.Label()
        Me.BranchAddress = New System.Windows.Forms.Label()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.txt_Remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_LedgerSetNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AccountNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BranchCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BranchCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LedgerSetNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarEditItem_Branch, Me.BarEditItem_CutOff, Me.btn_Reload, Me.btn_Preview})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemDateEdit1})
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle Or DevExpress.XtraBars.BarLinkUserDefines.Width), DevExpress.XtraBars.BarLinkUserDefines), Me.BarEditItem_Branch, "", False, True, True, 207, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_CutOff, "", False, True, True, 188), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarEditItem_Branch
        '
        Me.BarEditItem_Branch.Caption = "Brnc"
        Me.BarEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit1
        Me.BarEditItem_Branch.Id = 0
        Me.BarEditItem_Branch.Name = "BarEditItem_Branch"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'BarEditItem_CutOff
        '
        Me.BarEditItem_CutOff.Edit = Me.RepositoryItemDateEdit1
        Me.BarEditItem_CutOff.Id = 2
        Me.BarEditItem_CutOff.Name = "BarEditItem_CutOff"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'btn_Reload
        '
        Me.btn_Reload.Caption = "Find"
        Me.btn_Reload.Id = 3
        Me.btn_Reload.Name = "btn_Reload"
        '
        'btn_Preview
        '
        Me.btn_Preview.Caption = "Preview"
        Me.btn_Preview.Id = 4
        Me.btn_Preview.Name = "btn_Preview"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(788, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 417)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(788, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 393)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(788, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 393)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel.ID = New System.Guid("ae4f39b4-9dd2-46dc-b3c9-bf199683b3e6")
        Me.DockPanel.Location = New System.Drawing.Point(0, 24)
        Me.DockPanel.Name = "DockPanel"
        Me.DockPanel.OriginalSize = New System.Drawing.Size(382, 200)
        Me.DockPanel.Size = New System.Drawing.Size(382, 393)
        Me.DockPanel.Text = "DetailRemarks"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.layoutControl)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 25)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(373, 364)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl1
        '
        Me.LayoutControl.Controls.Add(Me.Frmbtn_Update)
        Me.LayoutControl.Controls.Add(Me.txt_Remarks)
        Me.LayoutControl.Controls.Add(Me.txt_LedgerSetNumber)
        Me.LayoutControl.Controls.Add(Me.txt_AccountNumber)
        Me.LayoutControl.Controls.Add(Me.txt_BranchCode)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl1"
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(373, 364)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'Frmbtn_Update
        '
        Me.Frmbtn_Update.Location = New System.Drawing.Point(12, 116)
        Me.Frmbtn_Update.Name = "Frmbtn_Update"
        Me.Frmbtn_Update.Size = New System.Drawing.Size(349, 22)
        Me.Frmbtn_Update.StyleController = Me.layoutControl
        Me.Frmbtn_Update.TabIndex = 8
        Me.Frmbtn_Update.Text = "Update"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Location = New System.Drawing.Point(109, 90)
        Me.txt_Remarks.MenuManager = Me.BarManager1
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Remarks.Size = New System.Drawing.Size(252, 22)
        Me.txt_Remarks.StyleController = Me.layoutControl
        Me.txt_Remarks.TabIndex = 7
        '
        'txt_LedgerSetNumber
        '
        Me.txt_LedgerSetNumber.Location = New System.Drawing.Point(109, 64)
        Me.txt_LedgerSetNumber.MenuManager = Me.BarManager1
        Me.txt_LedgerSetNumber.Name = "txt_LedgerSetNumber"
        Me.txt_LedgerSetNumber.Size = New System.Drawing.Size(252, 22)
        Me.txt_LedgerSetNumber.StyleController = Me.layoutControl
        Me.txt_LedgerSetNumber.TabIndex = 6
        '
        'txt_AccountNumber
        '
        Me.txt_AccountNumber.Location = New System.Drawing.Point(109, 38)
        Me.txt_AccountNumber.MenuManager = Me.BarManager1
        Me.txt_AccountNumber.Name = "txt_AccountNumber"
        Me.txt_AccountNumber.Size = New System.Drawing.Size(252, 22)
        Me.txt_AccountNumber.StyleController = Me.layoutControl
        Me.txt_AccountNumber.TabIndex = 5
        '
        'txt_BranchCode
        '
        Me.txt_BranchCode.Location = New System.Drawing.Point(109, 12)
        Me.txt_BranchCode.MenuManager = Me.BarManager1
        Me.txt_BranchCode.Name = "txt_BranchCode"
        Me.txt_BranchCode.Size = New System.Drawing.Size(252, 22)
        Me.txt_BranchCode.StyleController = Me.layoutControl
        Me.txt_BranchCode.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.BranchCode, Me.EmptySpaceItem1, Me.AccountNumber, Me.LedgerSetNumber, Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(373, 364)
        Me.Root.TextVisible = False
        '
        'BranchCode
        '
        Me.BranchCode.Control = Me.txt_BranchCode
        Me.BranchCode.Location = New System.Drawing.Point(0, 0)
        Me.BranchCode.Name = "BranchCode"
        Me.BranchCode.Size = New System.Drawing.Size(353, 26)
        Me.BranchCode.TextSize = New System.Drawing.Size(94, 15)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 130)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(353, 214)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'AccountNumber
        '
        Me.AccountNumber.Control = Me.txt_AccountNumber
        Me.AccountNumber.Location = New System.Drawing.Point(0, 26)
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Size = New System.Drawing.Size(353, 26)
        Me.AccountNumber.TextSize = New System.Drawing.Size(94, 15)
        '
        'LedgerSetNumber
        '
        Me.LedgerSetNumber.Control = Me.txt_LedgerSetNumber
        Me.LedgerSetNumber.Location = New System.Drawing.Point(0, 52)
        Me.LedgerSetNumber.Name = "LedgerSetNumber"
        Me.LedgerSetNumber.Size = New System.Drawing.Size(353, 26)
        Me.LedgerSetNumber.TextSize = New System.Drawing.Size(94, 15)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txt_Remarks
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(353, 26)
        Me.LayoutControlItem1.Text = "Remarks"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(94, 15)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Frmbtn_Update
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(353, 26)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'GCList
        '
        Me.GCList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCList.Location = New System.Drawing.Point(382, 24)
        Me.GCList.MainView = Me.gridView
        Me.GCList.MenuManager = Me.BarManager1
        Me.GCList.Name = "GCList"
        Me.GCList.Size = New System.Drawing.Size(406, 393)
        Me.GCList.TabIndex = 4
        Me.GCList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.gridControl = Me.GCList
        Me.gridView.Name = "gridView"
        '
        'BranchName
        '
        Me.BranchName.Location = New System.Drawing.Point(584, 91)
        Me.BranchName.Name = "BranchName"
        Me.BranchName.Size = New System.Drawing.Size(94, 22)
        Me.BranchName.TabIndex = 136
        Me.BranchName.Text = "BranchName"
        '
        'CheckedBy
        '
        Me.CheckedBy.Location = New System.Drawing.Point(649, 56)
        Me.CheckedBy.Name = "CheckedBy"
        Me.CheckedBy.Size = New System.Drawing.Size(94, 22)
        Me.CheckedBy.TabIndex = 135
        Me.CheckedBy.Text = "CheckedBy"
        '
        'PreparedBy
        '
        Me.PreparedBy.Location = New System.Drawing.Point(559, 56)
        Me.PreparedBy.Name = "PreparedBy"
        Me.PreparedBy.Size = New System.Drawing.Size(94, 22)
        Me.PreparedBy.TabIndex = 134
        Me.PreparedBy.Text = "PreparedBy:"
        '
        'BranchAddress
        '
        Me.BranchAddress.Location = New System.Drawing.Point(676, 48)
        Me.BranchAddress.Name = "BranchAddress"
        Me.BranchAddress.Size = New System.Drawing.Size(94, 30)
        Me.BranchAddress.TabIndex = 133
        Me.BranchAddress.Text = "BranchAddress"
        '
        'rpt_MCForDepo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 417)
        Me.Controls.Add(Me.GCList)
        Me.Controls.Add(Me.CheckedBy)
        Me.Controls.Add(Me.BranchAddress)
        Me.Controls.Add(Me.BranchName)
        Me.Controls.Add(Me.PreparedBy)
        Me.Controls.Add(Me.DockPanel)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "rpt_MCForDepo"
        Me.Text = "MC Units for Depo"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.txt_Remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_LedgerSetNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AccountNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BranchCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BranchCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LedgerSetNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarEditItem_Branch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarEditItem_CutOff As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GCList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BranchName As Label
    Friend WithEvents CheckedBy As Label
    Friend WithEvents PreparedBy As Label
    Friend WithEvents BranchAddress As Label
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txt_Remarks As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_LedgerSetNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_AccountNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_BranchCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents BranchCode As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents AccountNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LedgerSetNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Frmbtn_Update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
