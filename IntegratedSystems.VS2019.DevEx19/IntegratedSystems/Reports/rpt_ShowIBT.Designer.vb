<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpt_ShowIBT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_ShowIBT))
        Me.GCIBT = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BranchPrevCust = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountNoPrev = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LedSetPrev = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmountDue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Transactions = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Descriptions = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Transactedby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InitiatingBranch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.InitiatingBranchName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.GCIBT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCIBT
        '
        Me.GCIBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCIBT.Location = New System.Drawing.Point(0, 20)
        Me.GCIBT.MainView = Me.gridView
        Me.GCIBT.Name = "GCIBT"
        Me.GCIBT.Size = New System.Drawing.Size(567, 349)
        Me.GCIBT.TabIndex = 122
        Me.GCIBT.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.BranchPrevCust, Me.AccountNoPrev, Me.LedSetPrev, Me.AccountName, Me.AmountDue, Me.RefNo, Me.PostingDate, Me.Transactions, Me.Descriptions, Me.Transactedby, Me.InitiatingBranch, Me.InitiatingBranchName})
        Me.gridView.gridControl = Me.GCIBT
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsView.ColumnAutoWidth = False
        '
        'BranchPrevCust
        '
        Me.BranchPrevCust.Caption = "BranchCode"
        Me.BranchPrevCust.FieldName = "BranchPrevCust"
        Me.BranchPrevCust.Name = "BranchPrevCust"
        Me.BranchPrevCust.Visible = True
        Me.BranchPrevCust.VisibleIndex = 0
        '
        'AccountNoPrev
        '
        Me.AccountNoPrev.Caption = "AccountNumber"
        Me.AccountNoPrev.FieldName = "AccountNoPrev"
        Me.AccountNoPrev.Name = "AccountNoPrev"
        Me.AccountNoPrev.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "AccountNoPrev", "{0}")})
        Me.AccountNoPrev.Visible = True
        Me.AccountNoPrev.VisibleIndex = 1
        '
        'LedSetPrev
        '
        Me.LedSetPrev.Caption = "LedgerSet"
        Me.LedSetPrev.FieldName = "LedSetPrev"
        Me.LedSetPrev.Name = "LedSetPrev"
        Me.LedSetPrev.Visible = True
        Me.LedSetPrev.VisibleIndex = 2
        '
        'AccountName
        '
        Me.AccountName.Caption = "AccountName"
        Me.AccountName.FieldName = "AccountName"
        Me.AccountName.Name = "AccountName"
        Me.AccountName.Visible = True
        Me.AccountName.VisibleIndex = 3
        '
        'AmountDue
        '
        Me.AmountDue.Caption = "AmountDue"
        Me.AmountDue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AmountDue.FieldName = "AmountDue"
        Me.AmountDue.Name = "AmountDue"
        Me.AmountDue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountDue", "SUM={0:N2}")})
        Me.AmountDue.Visible = True
        Me.AmountDue.VisibleIndex = 4
        '
        'RefNo
        '
        Me.RefNo.Caption = "RefNo"
        Me.RefNo.FieldName = "RefNo"
        Me.RefNo.Name = "RefNo"
        Me.RefNo.Visible = True
        Me.RefNo.VisibleIndex = 5
        '
        'PostingDate
        '
        Me.PostingDate.Caption = "PostingDate"
        Me.PostingDate.FieldName = "PostingDate"
        Me.PostingDate.Name = "PostingDate"
        Me.PostingDate.Visible = True
        Me.PostingDate.VisibleIndex = 6
        '
        'Transactions
        '
        Me.Transactions.Caption = "Transactions"
        Me.Transactions.FieldName = "Transactions"
        Me.Transactions.Name = "Transactions"
        Me.Transactions.Visible = True
        Me.Transactions.VisibleIndex = 7
        '
        'Descriptions
        '
        Me.Descriptions.Caption = "Descriptions"
        Me.Descriptions.FieldName = "Descriptions"
        Me.Descriptions.Name = "Descriptions"
        Me.Descriptions.Visible = True
        Me.Descriptions.VisibleIndex = 8
        '
        'Transactedby
        '
        Me.Transactedby.Caption = "Transactedby"
        Me.Transactedby.FieldName = "Transactedby"
        Me.Transactedby.Name = "Transactedby"
        Me.Transactedby.Visible = True
        Me.Transactedby.VisibleIndex = 9
        '
        'InitiatingBranch
        '
        Me.InitiatingBranch.Caption = "InitiatingBranch"
        Me.InitiatingBranch.FieldName = "InitiatingBranch"
        Me.InitiatingBranch.Name = "InitiatingBranch"
        Me.InitiatingBranch.Visible = True
        Me.InitiatingBranch.VisibleIndex = 10
        '
        'InitiatingBranchName
        '
        Me.InitiatingBranchName.Caption = "InitiatingBranchName"
        Me.InitiatingBranchName.FieldName = "InitiatingBranchName"
        Me.InitiatingBranchName.Name = "InitiatingBranchName"
        Me.InitiatingBranchName.Visible = True
        Me.InitiatingBranchName.VisibleIndex = 11
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
        '
        'btn_Preview
        '
        Me.btn_Preview.Caption = "Preview"
        Me.btn_Preview.Id = 7
        Me.btn_Preview.Name = "btn_Preview"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(567, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 369)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(567, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 349)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(567, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 349)
        '
        'rpt_ShowIBT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 369)
        Me.Controls.Add(Me.GCIBT)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("rpt_ShowIBT.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "rpt_ShowIBT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INTER BRANCH PAYMENT MONITORING"
        CType(Me.GCIBT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GCIBT As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BranchPrevCust As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountNoPrev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LedSetPrev As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmountDue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PostingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Transactions As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Descriptions As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Transactedby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InitiatingBranch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InitiatingBranchName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
End Class
