<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rpt_CreditMemo
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem3 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem4 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim SuperToolTip5 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipItem5 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_CreditMemo))
        Me.GCCreditMemo = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.CardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BranchAddress = New System.Windows.Forms.Label()
        Me.BranchName = New System.Windows.Forms.Label()
        Me.CheckedBy = New System.Windows.Forms.Label()
        Me.PreparedBy = New System.Windows.Forms.Label()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_BranchCode = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.DateBegin = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.DateEnd = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.Btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.GCCreditMemo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCCreditMemo
        '
        Me.GCCreditMemo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCCreditMemo.Location = New System.Drawing.Point(0, 24)
        Me.GCCreditMemo.LookAndFeel.SkinName = "Office 2010 Black"
        Me.GCCreditMemo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.GCCreditMemo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GCCreditMemo.MainView = Me.GridView
        Me.GCCreditMemo.Name = "GCCreditMemo"
        Me.GCCreditMemo.Size = New System.Drawing.Size(790, 336)
        Me.GCCreditMemo.TabIndex = 122
        Me.GCCreditMemo.UseEmbeddedNavigator = True
        Me.GCCreditMemo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView, Me.CardView1, Me.GridView2, Me.GridView1})
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
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.BranchCode, Me.AccountNumber, Me.LedgerSetNumber, Me.AccountName, Me.PostingDate, Me.RefNo, Me.AmountPaid, Me.Principal, Me.Interest, Me.AOC, Me.Rebates, Me.PEN, Me.VAT, Me.AmntNetOfVat, Me.Note, Me.ErrorTag})
        Me.GridView.GridControl = Me.GCCreditMemo
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
        Me.AmountPaid.FieldName = "AmountPaid"
        Me.AmountPaid.Name = "AmountPaid"
        Me.AmountPaid.Visible = True
        Me.AmountPaid.VisibleIndex = 6
        '
        'Principal
        '
        Me.Principal.Caption = "Principal"
        Me.Principal.FieldName = "Principal"
        Me.Principal.Name = "Principal"
        Me.Principal.Visible = True
        Me.Principal.VisibleIndex = 7
        '
        'Interest
        '
        Me.Interest.Caption = "Interest"
        Me.Interest.FieldName = "Interest"
        Me.Interest.Name = "Interest"
        Me.Interest.Visible = True
        Me.Interest.VisibleIndex = 8
        '
        'AOC
        '
        Me.AOC.Caption = "AOC"
        Me.AOC.FieldName = "AOC"
        Me.AOC.Name = "AOC"
        Me.AOC.Visible = True
        Me.AOC.VisibleIndex = 9
        '
        'Rebates
        '
        Me.Rebates.Caption = "Rebates"
        Me.Rebates.FieldName = "Rebates"
        Me.Rebates.Name = "Rebates"
        Me.Rebates.Visible = True
        Me.Rebates.VisibleIndex = 10
        '
        'PEN
        '
        Me.PEN.Caption = "PEN"
        Me.PEN.FieldName = "PEN"
        Me.PEN.Name = "PEN"
        Me.PEN.Visible = True
        Me.PEN.VisibleIndex = 11
        '
        'VAT
        '
        Me.VAT.Caption = "VAT"
        Me.VAT.FieldName = "VAT"
        Me.VAT.Name = "VAT"
        Me.VAT.Visible = True
        Me.VAT.VisibleIndex = 12
        '
        'AmntNetOfVat
        '
        Me.AmntNetOfVat.Caption = "AmntNetOfVat"
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
        'CardView1
        '
        Me.CardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5})
        Me.CardView1.FocusedCardTopFieldIndex = 0
        Me.CardView1.GridControl = Me.GCCreditMemo
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
        Me.GridView2.GridControl = Me.GCCreditMemo
        Me.GridView2.Name = "GridView2"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GCCreditMemo
        Me.GridView1.Name = "GridView1"
        '
        'BranchAddress
        '
        Me.BranchAddress.Location = New System.Drawing.Point(423, 56)
        Me.BranchAddress.Name = "BranchAddress"
        Me.BranchAddress.Size = New System.Drawing.Size(81, 19)
        Me.BranchAddress.TabIndex = 136
        Me.BranchAddress.Text = "BranchAddress"
        '
        'BranchName
        '
        Me.BranchName.Location = New System.Drawing.Point(346, 56)
        Me.BranchName.Name = "BranchName"
        Me.BranchName.Size = New System.Drawing.Size(81, 19)
        Me.BranchName.TabIndex = 135
        Me.BranchName.Text = "BranchName"
        '
        'CheckedBy
        '
        Me.CheckedBy.Location = New System.Drawing.Point(261, 56)
        Me.CheckedBy.Name = "CheckedBy"
        Me.CheckedBy.Size = New System.Drawing.Size(81, 19)
        Me.CheckedBy.TabIndex = 134
        Me.CheckedBy.Text = "CheckedBy"
        '
        'PreparedBy
        '
        Me.PreparedBy.Location = New System.Drawing.Point(184, 56)
        Me.PreparedBy.Name = "PreparedBy"
        Me.PreparedBy.Size = New System.Drawing.Size(81, 19)
        Me.PreparedBy.TabIndex = 133
        Me.PreparedBy.Text = "PreparedBy:"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.txt_BranchCode, Me.BarStaticItem2, Me.DateBegin, Me.BarStaticItem3, Me.DateEnd, Me.Btn_Reload, Me.Btn_Preview})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_BranchCode), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.DateBegin), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.DateEnd), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.Btn_Reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.Btn_Preview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
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
        'txt_BranchCode
        '
        Me.txt_BranchCode.Edit = Me.RepositoryItemTextEdit1
        Me.txt_BranchCode.EditWidth = 84
        Me.txt_BranchCode.Id = 1
        Me.txt_BranchCode.Name = "txt_BranchCode"
        ToolTipItem1.Text = "BranchCode"
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.txt_BranchCode.SuperTip = SuperToolTip1
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "DateBegin"
        Me.BarStaticItem2.Id = 2
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'DateBegin
        '
        Me.DateBegin.Edit = Me.RepositoryItemDateEdit1
        Me.DateBegin.EditWidth = 106
        Me.DateBegin.Id = 3
        Me.DateBegin.Name = "DateBegin"
        ToolTipItem2.Text = "Date Begin"
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.DateBegin.SuperTip = SuperToolTip2
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
        Me.BarStaticItem3.Caption = "DateEnd"
        Me.BarStaticItem3.Id = 4
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'DateEnd
        '
        Me.DateEnd.Edit = Me.RepositoryItemDateEdit2
        Me.DateEnd.EditWidth = 110
        Me.DateEnd.Id = 5
        Me.DateEnd.Name = "DateEnd"
        ToolTipItem3.Text = "Date End"
        SuperToolTip3.Items.Add(ToolTipItem3)
        Me.DateEnd.SuperTip = SuperToolTip3
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'Btn_Reload
        '
        Me.Btn_Reload.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Btn_Reload.Caption = "Find"
        Me.Btn_Reload.Id = 6
        Me.Btn_Reload.Name = "Btn_Reload"
        ToolTipItem4.Text = "FIND"
        SuperToolTip4.Items.Add(ToolTipItem4)
        Me.Btn_Reload.SuperTip = SuperToolTip4
        '
        'Btn_Preview
        '
        Me.Btn_Preview.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Btn_Preview.Caption = "Preview"
        Me.Btn_Preview.Id = 7
        Me.Btn_Preview.Name = "Btn_Preview"
        ToolTipItem5.Text = "PRINT"
        SuperToolTip5.Items.Add(ToolTipItem5)
        Me.Btn_Preview.SuperTip = SuperToolTip5
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(790, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 360)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(790, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 336)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(790, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 336)
        '
        'rpt_CreditMemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 360)
        Me.Controls.Add(Me.GCCreditMemo)
        Me.Controls.Add(Me.BranchAddress)
        Me.Controls.Add(Me.BranchName)
        Me.Controls.Add(Me.CheckedBy)
        Me.Controls.Add(Me.PreparedBy)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rpt_CreditMemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREDIT MEMO"
        CType(Me.GCCreditMemo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GCCreditMemo As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LedgerSetNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CardView1 As DevExpress.XtraGrid.Views.Card.CardView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BranchAddress As Label
    Friend WithEvents BranchName As Label
    Friend WithEvents CheckedBy As Label
    Friend WithEvents PreparedBy As Label
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
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
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_BranchCode As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents DateBegin As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents DateEnd As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents Btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Preview As DevExpress.XtraBars.BarButtonItem
End Class
