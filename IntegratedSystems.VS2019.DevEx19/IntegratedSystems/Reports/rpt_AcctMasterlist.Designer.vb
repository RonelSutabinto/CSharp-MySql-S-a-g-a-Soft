<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpt_AcctMasterlist
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_AcctMasterlist))
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Posting_Date = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit_Posting_Date = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_AeCode = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit_AE = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit_Posting_Date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit_Posting_Date.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit_AE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem4, Me.txt_AeCode, Me.btn_Reload, Me.btn_Preview, Me.btn_Close, Me.Posting_Date})
        Me.BarManager.MaxItemId = 16
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit_AE, Me.RepositoryItemDateEdit_Posting_Date})
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 1"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Posting_Date), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem4), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.txt_AeCode, "", False, True, True, 77), New DevExpress.XtraBars.LinkPersistInfo(CType((DevExpress.XtraBars.BarLinkUserDefines.Caption Or DevExpress.XtraBars.BarLinkUserDefines.PaintStyle), DevExpress.XtraBars.BarLinkUserDefines), Me.btn_Reload, "FIND", False, False, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Preview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
        Me.Bar1.Text = "Custom 1"
        '
        'Posting_Date
        '
        Me.Posting_Date.Caption = "Cut Off Date"
        Me.Posting_Date.Edit = Me.RepositoryItemDateEdit_Posting_Date
        Me.Posting_Date.Id = 15
        Me.Posting_Date.Name = "Posting_Date"
        '
        'RepositoryItemDateEdit_Posting_Date
        '
        Me.RepositoryItemDateEdit_Posting_Date.AutoHeight = False
        Me.RepositoryItemDateEdit_Posting_Date.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit_Posting_Date.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit_Posting_Date.Name = "RepositoryItemDateEdit_Posting_Date"
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Caption = "AECode"
        Me.BarStaticItem4.Id = 10
        Me.BarStaticItem4.Name = "BarStaticItem4"
        '
        'txt_AeCode
        '
        Me.txt_AeCode.Caption = " "
        Me.txt_AeCode.Edit = Me.RepositoryItemTextEdit_AE
        Me.txt_AeCode.EditValue = " "
        Me.txt_AeCode.Id = 11
        Me.txt_AeCode.Name = "txt_AeCode"
        '
        'RepositoryItemTextEdit_AE
        '
        Me.RepositoryItemTextEdit_AE.AutoHeight = False
        Me.RepositoryItemTextEdit_AE.Name = "RepositoryItemTextEdit_AE"
        '
        'btn_Reload
        '
        Me.btn_Reload.Caption = "Reload"
        Me.btn_Reload.Id = 12
        Me.btn_Reload.Name = "btn_Reload"
        '
        'btn_Preview
        '
        Me.btn_Preview.Caption = "Preview"
        Me.btn_Preview.Id = 13
        Me.btn_Preview.Name = "btn_Preview"
        '
        'btn_Close
        '
        Me.btn_Close.Caption = "Close"
        Me.btn_Close.Id = 14
        Me.btn_Close.Name = "btn_Close"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(722, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 321)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(722, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 301)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(722, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 301)
        '
        'gridView
        '
        Me.gridView.DetailHeight = 303
        Me.gridView.gridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        '
        'gridControl
        '
        Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl.Location = New System.Drawing.Point(0, 20)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.BarManager
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(722, 301)
        Me.gridControl.TabIndex = 4
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'rpt_AcctMasterlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 321)
        Me.Controls.Add(Me.gridControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("rpt_AcctMasterlist.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "rpt_AcctMasterlist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCOUNT MASTERLIST"
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit_Posting_Date.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit_Posting_Date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit_AE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_AeCode As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit_AE As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Posting_Date As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit_Posting_Date As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
End Class
