<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CustFreebie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CustFreebie))
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
        Me.btn_Search = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Xuc_Freebies = New xuc_Freebies()
        Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.Xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.FreebieID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Branch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PartsNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PartsName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BegQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DbtQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CrQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EndQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TransStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockPanel1.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        Me.DockPanel2.SuspendLayout()
        Me.DockPanel2_Container.SuspendLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.DockManager = Me.DockManager
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_New, Me.btn_Save, Me.btn_Delete, Me.BarButtonItem4, Me.BarEditItem_Search, Me.btn_Search, Me.btn_Preview, Me.btn_Close})
        Me.BarManager.MaxItemId = 11
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem4), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_Search, "", False, True, True, 148), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Search, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Tools"
        '
        'btn_New
        '
        Me.btn_New.Caption = "New"
        Me.btn_New.Id = 0
        Me.btn_New.Name = "btn_New"
        '
        'btn_Save
        '
        Me.btn_Save.Caption = "Save"
        Me.btn_Save.Id = 1
        Me.btn_Save.Name = "btn_Save"
        '
        'btn_Delete
        '
        Me.btn_Delete.Caption = "Delete"
        Me.btn_Delete.Id = 2
        Me.btn_Delete.Name = "btn_Delete"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Id = 3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarEditItem_Search
        '
        Me.BarEditItem_Search.Caption = "BarEditItem1"
        Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
        Me.BarEditItem_Search.Id = 4
        Me.BarEditItem_Search.Name = "BarEditItem_Search"
        '
        'RepositoryItemSearchControl_Search
        '
        Me.RepositoryItemSearchControl_Search.AutoHeight = False
        Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
        '
        'btn_Search
        '
        Me.btn_Search.Caption = "Search"
        Me.btn_Search.Id = 8
        Me.btn_Search.ImageOptions.Image = CType(resources.GetObject("btn_Search.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_Search.Name = "btn_Search"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(714, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 418)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(714, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 394)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(714, 24)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 394)
        '
        'DockManager
        '
        Me.DockManager.Form = Me
        Me.DockManager.MenuManager = Me.BarManager
        Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2})
        Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockPanel1
        '
        Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
        Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockPanel1.ID = New System.Guid("db8b6d73-9be8-45b8-8287-367a24dd6b37")
        Me.DockPanel1.Location = New System.Drawing.Point(0, 24)
        Me.DockPanel1.Name = "DockPanel1"
        Me.DockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel1.Size = New System.Drawing.Size(200, 394)
        Me.DockPanel1.Text = "Informations"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.Xuc_Freebies)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(193, 365)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'Xuc_Freebies
        '
        Me.Xuc_Freebies.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Freebies.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Freebies.Name = "Xuc_Freebies"
        Me.Xuc_Freebies.Size = New System.Drawing.Size(193, 365)
        Me.Xuc_Freebies.TabIndex = 0
        '
        'DockPanel2
        '
        Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
        Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
        Me.DockPanel2.ID = New System.Guid("be2d3129-98cc-4adb-bc72-7f37dd3971c6")
        Me.DockPanel2.Location = New System.Drawing.Point(514, 24)
        Me.DockPanel2.Name = "DockPanel2"
        Me.DockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
        Me.DockPanel2.Size = New System.Drawing.Size(200, 394)
        Me.DockPanel2.Text = "Settings"
        '
        'DockPanel2_Container
        '
        Me.DockPanel2_Container.Controls.Add(Me.Xuc_Settings)
        Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
        Me.DockPanel2_Container.Name = "DockPanel2_Container"
        Me.DockPanel2_Container.Size = New System.Drawing.Size(193, 365)
        Me.DockPanel2_Container.TabIndex = 0
        '
        'Xuc_Settings
        '
        Me.Xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Xuc_Settings.Location = New System.Drawing.Point(0, 0)
        Me.Xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
        Me.Xuc_Settings.Name = "Xuc_Settings"
        Me.Xuc_Settings.Size = New System.Drawing.Size(270, 365)
        Me.Xuc_Settings.TabIndex = 0
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(200, 24)
        Me.gridControl.MainView = Me.GridView
        Me.gridControl.MenuManager = Me.BarManager
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(314, 394)
        Me.gridControl.TabIndex = 7
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.FreebieID, Me.Branch, Me.AccountNumber, Me.AccountName, Me.PartsNumber, Me.PartsName, Me.BegQty, Me.DbtQty, Me.CrQty, Me.EndQty, Me.PostingDate, Me.TransStatus})
        Me.GridView.gridControl = Me.gridControl
        Me.GridView.Name = "GridView"
        '
        'FreebieID
        '
        Me.FreebieID.FieldName = "FreebieID"
        Me.FreebieID.Name = "FreebieID"
        Me.FreebieID.Visible = True
        Me.FreebieID.VisibleIndex = 0
        '
        'Branch
        '
        Me.Branch.FieldName = "Branch"
        Me.Branch.Name = "Branch"
        Me.Branch.Visible = True
        Me.Branch.VisibleIndex = 1
        '
        'AccountNumber
        '
        Me.AccountNumber.FieldName = "AccountNumber"
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Visible = True
        Me.AccountNumber.VisibleIndex = 2
        '
        'AccountName
        '
        Me.AccountName.FieldName = "AccountName"
        Me.AccountName.Name = "AccountName"
        Me.AccountName.Visible = True
        Me.AccountName.VisibleIndex = 3
        '
        'PartsNumber
        '
        Me.PartsNumber.FieldName = "PartsNumber"
        Me.PartsNumber.Name = "PartsNumber"
        Me.PartsNumber.Visible = True
        Me.PartsNumber.VisibleIndex = 4
        '
        'PartsName
        '
        Me.PartsName.FieldName = "PartsName"
        Me.PartsName.Name = "PartsName"
        Me.PartsName.Visible = True
        Me.PartsName.VisibleIndex = 5
        '
        'BegQty
        '
        Me.BegQty.FieldName = "BegQty"
        Me.BegQty.Name = "BegQty"
        Me.BegQty.Visible = True
        Me.BegQty.VisibleIndex = 6
        '
        'DbtQty
        '
        Me.DbtQty.FieldName = "DbtQty"
        Me.DbtQty.Name = "DbtQty"
        Me.DbtQty.Visible = True
        Me.DbtQty.VisibleIndex = 7
        '
        'CrQty
        '
        Me.CrQty.FieldName = "CrQty"
        Me.CrQty.Name = "CrQty"
        Me.CrQty.Visible = True
        Me.CrQty.VisibleIndex = 8
        '
        'EndQty
        '
        Me.EndQty.FieldName = "EndQty"
        Me.EndQty.Name = "EndQty"
        Me.EndQty.Visible = True
        Me.EndQty.VisibleIndex = 9
        '
        'PostingDate
        '
        Me.PostingDate.FieldName = "PostingDate"
        Me.PostingDate.Name = "PostingDate"
        Me.PostingDate.Visible = True
        Me.PostingDate.VisibleIndex = 10
        '
        'TransStatus
        '
        Me.TransStatus.FieldName = "TransStatus"
        Me.TransStatus.Name = "TransStatus"
        Me.TransStatus.Visible = True
        Me.TransStatus.VisibleIndex = 11
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 3"
        Me.Bar2.DockCol = 1
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close)})
        Me.Bar2.Offset = 615
        Me.Bar2.Text = "Custom 3"
        '
        'btn_Preview
        '
        Me.btn_Preview.Caption = "Preview"
        Me.btn_Preview.Id = 9
        Me.btn_Preview.Name = "btn_Preview"
        '
        'btn_Close
        '
        Me.btn_Close.Caption = "Close"
        Me.btn_Close.Id = 10
        Me.btn_Close.Name = "btn_Close"
        '
        'frm_CustFreebie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 418)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.DockPanel2)
        Me.Controls.Add(Me.DockPanel1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frm_CustFreebie"
        Me.Text = "frm_CustFreebie"
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockPanel1.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel2.ResumeLayout(False)
        Me.DockPanel2_Container.ResumeLayout(False)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents xuc_Freebies As xuc_Freebies
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
    Friend WithEvents FreebieID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Branch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PartsNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PartsName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BegQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DbtQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CrQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EndQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PostingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TransStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
    Friend WithEvents btn_Search As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
End Class
