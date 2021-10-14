<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rpt_Credit_Memo
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
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_Credit_Memo))
        Me.GCCreditMemo = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LedgerSetNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PostingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RefNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmountPaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Principal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Interest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Rebates = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PEN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmntNetOfVat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Note = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ErrorTag = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.GCCreditMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCCreditMemo
        '
        Me.GCCreditMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCreditMemo.Location = New System.Drawing.Point(0, 20)
        Me.GCCreditMemo.MainView = Me.gridView
        Me.GCCreditMemo.Name = "GCCreditMemo"
        Me.GCCreditMemo.Size = New System.Drawing.Size(547, 342)
        Me.GCCreditMemo.TabIndex = 122
        Me.GCCreditMemo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.BranchCode, Me.AccountNumber, Me.LedgerSetNumber, Me.AccountName, Me.PostingDate, Me.RefNo, Me.AmountPaid, Me.Principal, Me.Interest, Me.AOC, Me.Rebates, Me.PEN, Me.VAT, Me.AmntNetOfVat, Me.Note, Me.ErrorTag})
        Me.gridView.gridControl = Me.GCCreditMemo
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
        Me.AccountNumber.Visible = True
        Me.AccountNumber.VisibleIndex = 1
        Me.AccountNumber.Width = 48
        '
        'LedgerSetNumber
        '
        Me.LedgerSetNumber.Caption = "LedgerSetNumber"
        Me.LedgerSetNumber.FieldName = "LedgerSetNumber"
        Me.LedgerSetNumber.Name = "LedgerSetNumber"
        Me.LedgerSetNumber.Visible = True
        Me.LedgerSetNumber.VisibleIndex = 2
        '
        'AccountName
        '
        Me.AccountName.Caption = "AccountName"
        Me.AccountName.FieldName = "AccountName"
        Me.AccountName.Name = "AccountName"
        Me.AccountName.Visible = True
        Me.AccountName.VisibleIndex = 3
        '
        'PostingDate
        '
        Me.PostingDate.Caption = "PostingDate"
        Me.PostingDate.FieldName = "PostingDate"
        Me.PostingDate.Name = "PostingDate"
        Me.PostingDate.Visible = True
        Me.PostingDate.VisibleIndex = 4
        '
        'RefNo
        '
        Me.RefNo.Caption = "RefNo"
        Me.RefNo.FieldName = "RefNo"
        Me.RefNo.Name = "RefNo"
        Me.RefNo.Visible = True
        Me.RefNo.VisibleIndex = 5
        '
        'AmountPaid
        '
        Me.AmountPaid.Caption = "AmountPaid"
        Me.AmountPaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AmountPaid.FieldName = "AmountPaid"
        Me.AmountPaid.Name = "AmountPaid"
        Me.AmountPaid.Visible = True
        Me.AmountPaid.VisibleIndex = 6
        '
        'Principal
        '
        Me.Principal.Caption = "Principal"
        Me.Principal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Principal.FieldName = "Principal"
        Me.Principal.Name = "Principal"
        Me.Principal.Visible = True
        Me.Principal.VisibleIndex = 7
        '
        'Interest
        '
        Me.Interest.Caption = "Interest"
        Me.Interest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Interest.FieldName = "Interest"
        Me.Interest.Name = "Interest"
        Me.Interest.Visible = True
        Me.Interest.VisibleIndex = 8
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
        'Rebates
        '
        Me.Rebates.Caption = "Rebates"
        Me.Rebates.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Rebates.FieldName = "Rebates"
        Me.Rebates.Name = "Rebates"
        Me.Rebates.Visible = True
        Me.Rebates.VisibleIndex = 10
        '
        'PEN
        '
        Me.PEN.Caption = "PEN"
        Me.PEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PEN.FieldName = "PEN"
        Me.PEN.Name = "PEN"
        Me.PEN.Visible = True
        Me.PEN.VisibleIndex = 11
        '
        'VAT
        '
        Me.VAT.Caption = "VAT"
        Me.VAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.VAT.FieldName = "VAT"
        Me.VAT.Name = "VAT"
        Me.VAT.Visible = True
        Me.VAT.VisibleIndex = 12
        '
        'AmntNetOfVat
        '
        Me.AmntNetOfVat.Caption = "AmntNetOfVat"
        Me.AmntNetOfVat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.AmntNetOfVat.FieldName = "AmntNetOfVat"
        Me.AmntNetOfVat.Name = "AmntNetOfVat"
        Me.AmntNetOfVat.Visible = True
        Me.AmntNetOfVat.VisibleIndex = 13
        '
        'Note
        '
        Me.Note.Caption = "Note"
        Me.Note.FieldName = "Note"
        Me.Note.Name = "Note"
        Me.Note.Visible = True
        Me.Note.VisibleIndex = 14
        '
        'ErrorTag
        '
        Me.ErrorTag.Caption = "ErrorTag"
        Me.ErrorTag.FieldName = "ErrorTag"
        Me.ErrorTag.Name = "ErrorTag"
        Me.ErrorTag.Visible = True
        Me.ErrorTag.VisibleIndex = 15
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
        ToolTipItem1.Text = "FIND"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.btn_Reload.SuperTip = SuperToolTip1
        '
        'btn_Preview
        '
        Me.btn_Preview.Caption = "Preview"
        Me.btn_Preview.Id = 7
        Me.btn_Preview.Name = "btn_Preview"
        ToolTipItem2.Text = "PRINT"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.btn_Preview.SuperTip = SuperToolTip2
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
        Me.barDockControlTop.Size = New System.Drawing.Size(547, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 362)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(547, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 342)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(547, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 342)
        '
        'rpt_Credit_Memo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 362)
        Me.Controls.Add(Me.GCCreditMemo)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("rpt_Credit_Memo.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "rpt_Credit_Memo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREDIT MEMO"
        CType(Me.GCCreditMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GCCreditMemo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LedgerSetNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents AccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PostingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RefNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmountPaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Principal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Interest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rebates As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PEN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmntNetOfVat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Note As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ErrorTag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
End Class
