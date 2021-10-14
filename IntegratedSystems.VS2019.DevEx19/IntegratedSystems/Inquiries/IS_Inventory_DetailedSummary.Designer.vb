<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IS_Inventory_DetailedSummary
    ' Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    private sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Inventory_DetailedSummary))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cnt = New System.Windows.Forms.Label()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.quickSearch = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.IfExist = New DevExpress.XtraBars.BarToggleSwitchItem()
        Me.Find = New DevExpress.XtraBars.BarButtonItem()
        Me.Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BtnHist = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GCInvList = New DevExpress.XtraGrid.GridControl()
        Me.GViewInvList = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridPopUp = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCInvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GViewInvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPopUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 544)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "COUNT:"
        '
        'cnt
        '
        Me.cnt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnt.ForeColor = System.Drawing.Color.White
        Me.cnt.Location = New System.Drawing.Point(90, 544)
        Me.cnt.Name = "cnt"
        Me.cnt.Size = New System.Drawing.Size(72, 21)
        Me.cnt.TabIndex = 34
        Me.cnt.Text = "0"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.quickSearch, Me.BarStaticItem1, Me.Find, Me.Preview, Me.IfExist, Me.BtnHist, Me.BarButtonItem2})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemButtonEdit1})
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.quickSearch, "", False, True, True, 169), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.IfExist, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.Find, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.Preview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "QuickSearch"
        Me.BarStaticItem1.Id = 1
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'quickSearch
        '
        Me.quickSearch.Caption = " "
        Me.quickSearch.Edit = Me.RepositoryItemTextEdit1
        Me.quickSearch.EditValue = "all"
        Me.quickSearch.Id = 0
        Me.quickSearch.Name = "quickSearch"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'IfExist
        '
        Me.IfExist.BindableChecked = True
        Me.IfExist.Caption = "IfExist?"
        Me.IfExist.Checked = True
        Me.IfExist.Id = 5
        Me.IfExist.Name = "IfExist"
        '
        'Find
        '
        Me.Find.Caption = "Find"
        Me.Find.Id = 3
        Me.Find.ImageOptions.Image = CType(resources.GetObject("Find.ImageOptions.Image"), System.Drawing.Image)
        Me.Find.Name = "Find"
        '
        'Preview
        '
        Me.Preview.Caption = "Preview"
        Me.Preview.Id = 4
        Me.Preview.ImageOptions.Image = CType(resources.GetObject("Preview.ImageOptions.Image"), System.Drawing.Image)
        Me.Preview.ImageOptions.LargeImage = CType(resources.GetObject("Preview.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.Preview.Name = "Preview"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(984, 28)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 571)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(984, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 28)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 543)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(984, 28)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 543)
        '
        'BtnHist
        '
        Me.BtnHist.Caption = "Show History"
        Me.BtnHist.Id = 8
        Me.BtnHist.ImageOptions.Image = CType(resources.GetObject("BtnHist.ImageOptions.Image"), System.Drawing.Image)
        Me.BtnHist.ImageOptions.LargeImage = CType(resources.GetObject("BtnHist.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BtnHist.Name = "BtnHist"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Customer Account"
        Me.BarButtonItem2.Id = 9
        Me.BarButtonItem2.ImageOptions.Image = CType(resources.GetObject("BarButtonItem2.ImageOptions.Image"), System.Drawing.Image)
        Me.BarButtonItem2.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem2.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'GCInvList
        '
        Me.GCInvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCInvList.Location = New System.Drawing.Point(0, 28)
        Me.GCInvList.MainView = Me.GViewInvList
        Me.GCInvList.MenuManager = Me.BarManager1
        Me.GCInvList.Name = "GCInvList"
        Me.GCInvList.Size = New System.Drawing.Size(984, 543)
        Me.GCInvList.TabIndex = 48
        Me.GCInvList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GViewInvList})
        '
        'GViewInvList
        '
        Me.GViewInvList.gridControl = Me.GCInvList
        Me.GViewInvList.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "branchcode", Nothing, "")})
        Me.GViewInvList.Name = "GViewInvList"
        '
        'GridPopUp
        '
        Me.GridPopUp.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.BtnHist, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem2)})
        Me.GridPopUp.Manager = Me.BarManager1
        Me.GridPopUp.Name = "GridPopUp"
        '
        'IS_Inventory_DetailedSummary
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 571)
        Me.Controls.Add(Me.GCInvList)
        Me.Controls.Add(Me.cnt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("IS_Inventory_DetailedSummary.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inventory_DetailedSummary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MC INVENTORY INQUIRY"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCInvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GViewInvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPopUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cnt As System.Windows.Forms.Label
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents quickSearch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Find As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents IfExist As DevExpress.XtraBars.BarToggleSwitchItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents GCInvList As DevExpress.XtraGrid.GridControl
    Friend WithEvents GViewInvList As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BtnHist As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridPopUp As DevExpress.XtraBars.PopupMenu
End Class
