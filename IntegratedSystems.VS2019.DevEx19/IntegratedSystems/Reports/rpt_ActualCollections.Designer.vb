<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rpt_ActualCollections
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_ActualCollections))
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LEDSet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ORNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmountPaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Principal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Interest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Rebates = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Remarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.whcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CORP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NETVAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalAdvanced = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Advanced = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NetCollection = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarMenu = New DevExpress.XtraBars.Bar()
        Me.Corporation = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Account_Executive = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit_AE = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit_AE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 20)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(406, 329)
        Me.gridControl.TabIndex = 120
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.BranchCode, Me.AccountNumber, Me.LEDSet, Me.PostingDate, Me.AccountName, Me.ORNumber, Me.AmountPaid, Me.Principal, Me.Interest, Me.AOC, Me.PEN, Me.Rebates, Me.Remarks, Me.Brand, Me.Model, Me.whcode, Me.CORP, Me.VAT, Me.NETVAT, Me.AccountStatus, Me.TotalAdvanced, Me.Advanced, Me.NetCollection})
        Me.gridView.DetailHeight = 303
        Me.gridView.gridControl = Me.gridControl
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
        'AccountNumber
        '
        Me.AccountNumber.Caption = "AccountNumber"
        Me.AccountNumber.FieldName = "AccountNumber"
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "AccountNumber", "{0}")})
        Me.AccountNumber.Visible = True
        Me.AccountNumber.VisibleIndex = 1
        Me.AccountNumber.Width = 96
        '
        'LEDSet
        '
        Me.LEDSet.Caption = "LEDSet"
        Me.LEDSet.FieldName = "LEDSet"
        Me.LEDSet.Name = "LEDSet"
        Me.LEDSet.Visible = True
        Me.LEDSet.VisibleIndex = 2
        Me.LEDSet.Width = 48
        '
        'PostingDate
        '
        Me.PostingDate.Caption = "PostingDate"
        Me.PostingDate.FieldName = "PostingDate"
        Me.PostingDate.Name = "PostingDate"
        Me.PostingDate.Visible = True
        Me.PostingDate.VisibleIndex = 3
        '
        'AccountName
        '
        Me.AccountName.Caption = "AccountName"
        Me.AccountName.FieldName = "AccountName"
        Me.AccountName.Name = "AccountName"
        Me.AccountName.Visible = True
        Me.AccountName.VisibleIndex = 4
        Me.AccountName.Width = 48
        '
        'ORNumber
        '
        Me.ORNumber.Caption = "ORNumber"
        Me.ORNumber.FieldName = "ORNumber"
        Me.ORNumber.Name = "ORNumber"
        Me.ORNumber.Visible = True
        Me.ORNumber.VisibleIndex = 5
        Me.ORNumber.Width = 48
        '
        'AmountPaid
        '
        Me.AmountPaid.Caption = "AmountPaid"
        Me.AmountPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AmountPaid.FieldName = "AmountPaid"
        Me.AmountPaid.Name = "AmountPaid"
        Me.AmountPaid.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountPaid", "SUM={0:N2}")})
        Me.AmountPaid.Visible = True
        Me.AmountPaid.VisibleIndex = 6
        Me.AmountPaid.Width = 48
        '
        'Principal
        '
        Me.Principal.Caption = "Principal"
        Me.Principal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Principal.FieldName = "Principal"
        Me.Principal.Name = "Principal"
        Me.Principal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Principal", "SUM={0:N2}")})
        Me.Principal.Visible = True
        Me.Principal.VisibleIndex = 7
        Me.Principal.Width = 48
        '
        'Interest
        '
        Me.Interest.Caption = "Interest"
        Me.Interest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Interest.FieldName = "Interest"
        Me.Interest.Name = "Interest"
        Me.Interest.Visible = True
        Me.Interest.VisibleIndex = 8
        Me.Interest.Width = 48
        '
        'AOC
        '
        Me.AOC.Caption = "AOC"
        Me.AOC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AOC.FieldName = "AOC"
        Me.AOC.Name = "AOC"
        Me.AOC.Visible = True
        Me.AOC.VisibleIndex = 9
        '
        'PEN
        '
        Me.PEN.Caption = "PEN"
        Me.PEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PEN.FieldName = "PEN"
        Me.PEN.Name = "PEN"
        Me.PEN.Visible = True
        Me.PEN.VisibleIndex = 10
        Me.PEN.Width = 48
        '
        'Rebates
        '
        Me.Rebates.Caption = "Rebates"
        Me.Rebates.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Rebates.FieldName = "Rebates"
        Me.Rebates.Name = "Rebates"
        Me.Rebates.Visible = True
        Me.Rebates.VisibleIndex = 11
        Me.Rebates.Width = 48
        '
        'Remarks
        '
        Me.Remarks.Caption = "Remarks"
        Me.Remarks.FieldName = "Remarks"
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Visible = True
        Me.Remarks.VisibleIndex = 12
        '
        'Brand
        '
        Me.Brand.Caption = "Brand"
        Me.Brand.FieldName = "Brand"
        Me.Brand.MinWidth = 17
        Me.Brand.Name = "Brand"
        Me.Brand.Visible = True
        Me.Brand.VisibleIndex = 13
        '
        'Model
        '
        Me.Model.Caption = "Model"
        Me.Model.FieldName = "Model"
        Me.Model.MinWidth = 17
        Me.Model.Name = "Model"
        Me.Model.Visible = True
        Me.Model.VisibleIndex = 14
        '
        'whcode
        '
        Me.whcode.Caption = "whcode"
        Me.whcode.FieldName = "whcode"
        Me.whcode.Name = "whcode"
        Me.whcode.Visible = True
        Me.whcode.VisibleIndex = 15
        Me.whcode.Width = 48
        '
        'CORP
        '
        Me.CORP.Caption = "CORP"
        Me.CORP.FieldName = "CORP"
        Me.CORP.Name = "CORP"
        Me.CORP.Visible = True
        Me.CORP.VisibleIndex = 16
        Me.CORP.Width = 48
        '
        'VAT
        '
        Me.VAT.Caption = "VAT"
        Me.VAT.FieldName = "VAT"
        Me.VAT.Name = "VAT"
        Me.VAT.Visible = True
        Me.VAT.VisibleIndex = 17
        Me.VAT.Width = 48
        '
        'NETVAT
        '
        Me.NETVAT.Caption = "NETVAT"
        Me.NETVAT.FieldName = "NETVAT"
        Me.NETVAT.Name = "NETVAT"
        Me.NETVAT.Visible = True
        Me.NETVAT.VisibleIndex = 18
        Me.NETVAT.Width = 65
        '
        'AccountStatus
        '
        Me.AccountStatus.Caption = "AccountStatus"
        Me.AccountStatus.FieldName = "AccountStatus"
        Me.AccountStatus.Name = "AccountStatus"
        Me.AccountStatus.Visible = True
        Me.AccountStatus.VisibleIndex = 19
        '
        'TotalAdvanced
        '
        Me.TotalAdvanced.Caption = "TotalAdvanced"
        Me.TotalAdvanced.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalAdvanced.FieldName = "TotalAdvanced"
        Me.TotalAdvanced.Name = "TotalAdvanced"
        Me.TotalAdvanced.Visible = True
        Me.TotalAdvanced.VisibleIndex = 20
        '
        'Advanced
        '
        Me.Advanced.Caption = "Advanced"
        Me.Advanced.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Advanced.FieldName = "Advanced"
        Me.Advanced.Name = "Advanced"
        Me.Advanced.Visible = True
        Me.Advanced.VisibleIndex = 21
        '
        'NetCollection
        '
        Me.NetCollection.Caption = "NetCollection"
        Me.NetCollection.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.NetCollection.FieldName = "NetCollection"
        Me.NetCollection.Name = "NetCollection"
        Me.NetCollection.Visible = True
        Me.NetCollection.VisibleIndex = 22
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
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.BarMenu})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Preview, Me.Corporation, Me.btn_Close, Me.Account_Executive})
        Me.BarManager.MainMenu = Me.BarMenu
        Me.BarManager.MaxItemId = 19
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Corporation, Me.RepositoryItemLookUpEdit_AE})
        '
        'BarMenu
        '
        Me.BarMenu.BarName = "Main menu"
        Me.BarMenu.DockCol = 0
        Me.BarMenu.DockRow = 0
        Me.BarMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.BarMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Corporation), New DevExpress.XtraBars.LinkPersistInfo(Me.Account_Executive), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Preview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
        Me.BarMenu.OptionsBar.MultiLine = True
        Me.BarMenu.OptionsBar.UseWholeRow = True
        Me.BarMenu.Text = "Main menu"
        '
        'Corporation
        '
        Me.Corporation.Caption = "Corporation"
        Me.Corporation.Edit = Me.RepositoryItemLookUpEdit_Corporation
        Me.Corporation.Id = 14
        Me.Corporation.Name = "Corporation"
        '
        'RepositoryItemLookUpEdit_Corporation
        '
        Me.RepositoryItemLookUpEdit_Corporation.AutoHeight = False
        Me.RepositoryItemLookUpEdit_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit_Corporation.Name = "RepositoryItemLookUpEdit_Corporation"
        '
        'Account_Executive
        '
        Me.Account_Executive.Caption = "Account Executive"
        Me.Account_Executive.Edit = Me.RepositoryItemLookUpEdit_AE
        Me.Account_Executive.Id = 18
        Me.Account_Executive.Name = "Account_Executive"
        '
        'RepositoryItemLookUpEdit_AE
        '
        Me.RepositoryItemLookUpEdit_AE.AutoHeight = False
        Me.RepositoryItemLookUpEdit_AE.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemLookUpEdit_AE.Name = "RepositoryItemLookUpEdit_AE"
        '
        'btn_Reload
        '
        Me.btn_Reload.Caption = "Reload"
        Me.btn_Reload.Id = 8
        Me.btn_Reload.Name = "btn_Reload"
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
        Me.btn_Close.Id = 17
        Me.btn_Close.Name = "btn_Close"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(406, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 349)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(406, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 329)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(406, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 329)
        '
        'rpt_ActualCollections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 349)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("rpt_ActualCollections.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "rpt_ActualCollections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUAL COLLECTIONS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit_AE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LEDSet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents BarMenu As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents AccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ORNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmountPaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Principal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Interest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rebates As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents whcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CORP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NETVAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PostingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Remarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalAdvanced As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Advanced As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NetCollection As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Corporation As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Account_Executive As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit_AE As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
