<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_Sales_Summary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_Sales_Summary))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.SkinBarSubItem1 = New DevExpress.XtraBars.SkinBarSubItem()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar5 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.txt_BrCode = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.dtp_DateBegin = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.dtp_DateEnd = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btn_Find = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Print = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_Date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_Transaction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_Reference = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_Customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_Sales = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_Return = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_Discount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txt_BMName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Designation = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BMName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Designation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(85, 112)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.SkinBarSubItem1)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'SkinBarSubItem1
        '
        Me.SkinBarSubItem1.Caption = "SkinBarSubItem1"
        Me.SkinBarSubItem1.Id = 0
        Me.SkinBarSubItem1.Name = "SkinBarSubItem1"
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(855, 147)
        Me.Bar1.FloatSize = New System.Drawing.Size(46, 29)
        Me.Bar1.Offset = 802
        Me.Bar1.Text = "Tools"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar5})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.dtp_DateBegin, Me.BarStaticItem2, Me.dtp_DateEnd, Me.btn_Find, Me.btn_Print, Me.BarStaticItem3, Me.txt_BrCode})
        Me.BarManager1.MainMenu = Me.Bar5
        Me.BarManager1.MaxItemId = 11
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemComboBox1})
        '
        'Bar5
        '
        Me.Bar5.BarName = "Main menu"
        Me.Bar5.DockCol = 0
        Me.Bar5.DockRow = 0
        Me.Bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.txt_BrCode), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.dtp_DateBegin), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.dtp_DateEnd), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Find), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Print)})
        Me.Bar5.OptionsBar.MultiLine = True
        Me.Bar5.OptionsBar.UseWholeRow = True
        Me.Bar5.Text = "Main menu"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "Branch"
        Me.BarStaticItem3.Id = 7
        Me.BarStaticItem3.Name = "BarStaticItem3"
        Me.BarStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'txt_BrCode
        '
        Me.txt_BrCode.Caption = "BarEditItem3"
        Me.txt_BrCode.Edit = Me.RepositoryItemTextEdit1
        Me.txt_BrCode.EditWidth = 62
        Me.txt_BrCode.Id = 8
        Me.txt_BrCode.Name = "txt_BrCode"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Date Begin"
        Me.BarStaticItem1.Id = 0
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'dtp_DateBegin
        '
        Me.dtp_DateBegin.Caption = "BarEditItem1"
        Me.dtp_DateBegin.Edit = Me.RepositoryItemDateEdit1
        Me.dtp_DateBegin.EditWidth = 119
        Me.dtp_DateBegin.Id = 1
        Me.dtp_DateBegin.Name = "dtp_DateBegin"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.EditFormat.FormatString = "MM/dd/yyyy"
        Me.RepositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.Mask.EditMask = "MM/dd/yyyy"
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Date End"
        Me.BarStaticItem2.Id = 2
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'dtp_DateEnd
        '
        Me.dtp_DateEnd.Caption = "BarEditItem2"
        Me.dtp_DateEnd.Edit = Me.RepositoryItemDateEdit2
        Me.dtp_DateEnd.EditWidth = 126
        Me.dtp_DateEnd.Id = 3
        Me.dtp_DateEnd.Name = "dtp_DateEnd"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.RepositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit2.EditFormat.FormatString = "MM/dd/yyyy"
        Me.RepositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit2.Mask.EditMask = "MM/dd/yyyy"
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'btn_Find
        '
        Me.btn_Find.Caption = "Find"
        Me.btn_Find.Glyph = CType(resources.GetObject("btn_Find.Glyph"), System.Drawing.Image)
        Me.btn_Find.Id = 4
        Me.btn_Find.Name = "btn_Find"
        Me.btn_Find.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btn_Print
        '
        Me.btn_Print.Caption = "Print"
        Me.btn_Print.Glyph = CType(resources.GetObject("btn_Print.Glyph"), System.Drawing.Image)
        Me.btn_Print.Id = 5
        Me.btn_Print.LargeGlyph = CType(resources.GetObject("btn_Print.LargeGlyph"), System.Drawing.Image)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1117, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 279)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1117, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 255)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1117, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 255)
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'GridControl
        '
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.GridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.GridControl.Location = New System.Drawing.Point(0, 24)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(1117, 255)
        Me.GridControl.TabIndex = 10
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_Date, Me.col_Code, Me.col_Transaction, Me.col_Reference, Me.col_Customer, Me.col_Sales, Me.col_Return, Me.col_Discount, Me.col_Total})
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView.OptionsBehavior.Editable = False
        Me.GridView.OptionsDetail.EnableMasterViewMode = False
        Me.GridView.OptionsView.ColumnAutoWidth = False
        Me.GridView.OptionsView.ShowFooter = True
        '
        'col_Date
        '
        Me.col_Date.Caption = "DATE"
        Me.col_Date.FieldName = "postingDate"
        Me.col_Date.Name = "col_Date"
        Me.col_Date.Visible = True
        Me.col_Date.VisibleIndex = 0
        '
        'col_Code
        '
        Me.col_Code.Caption = "CODE"
        Me.col_Code.FieldName = "trans_Code"
        Me.col_Code.Name = "col_Code"
        Me.col_Code.Visible = True
        Me.col_Code.VisibleIndex = 1
        '
        'col_Transaction
        '
        Me.col_Transaction.Caption = "TRANSACTION NAME"
        Me.col_Transaction.FieldName = "trans_Category"
        Me.col_Transaction.Name = "col_Transaction"
        Me.col_Transaction.Visible = True
        Me.col_Transaction.VisibleIndex = 2
        '
        'col_Reference
        '
        Me.col_Reference.Caption = "REFERENCE"
        Me.col_Reference.FieldName = "SINo"
        Me.col_Reference.Name = "col_Reference"
        Me.col_Reference.Visible = True
        Me.col_Reference.VisibleIndex = 3
        '
        'col_Customer
        '
        Me.col_Customer.Caption = "CUSTOMER NAME"
        Me.col_Customer.FieldName = "custName"
        Me.col_Customer.Name = "col_Customer"
        Me.col_Customer.Visible = True
        Me.col_Customer.VisibleIndex = 4
        '
        'col_Sales
        '
        Me.col_Sales.Caption = "SALES"
        Me.col_Sales.FieldName = "subTotal"
        Me.col_Sales.Name = "col_Sales"
        Me.col_Sales.Visible = True
        Me.col_Sales.VisibleIndex = 5
        '
        'col_Return
        '
        Me.col_Return.Caption = "RETURN"
        Me.col_Return.FieldName = "SalesReturned"
        Me.col_Return.Name = "col_Return"
        Me.col_Return.Visible = True
        Me.col_Return.VisibleIndex = 6
        '
        'col_Discount
        '
        Me.col_Discount.Caption = "DISCOUNT"
        Me.col_Discount.Name = "col_Discount"
        Me.col_Discount.Visible = True
        Me.col_Discount.VisibleIndex = 7
        '
        'col_Total
        '
        Me.col_Total.Caption = "TOTAL"
        Me.col_Total.FieldName = "sub_Total"
        Me.col_Total.Name = "col_Total"
        Me.col_Total.Visible = True
        Me.col_Total.VisibleIndex = 8
        '
        'txt_BMName
        '
        Me.txt_BMName.Location = New System.Drawing.Point(285, 178)
        Me.txt_BMName.MenuManager = Me.BarManager1
        Me.txt_BMName.Name = "txt_BMName"
        Me.txt_BMName.Size = New System.Drawing.Size(183, 20)
        Me.txt_BMName.TabIndex = 15
        '
        'txt_Designation
        '
        Me.txt_Designation.Location = New System.Drawing.Point(489, 178)
        Me.txt_Designation.MenuManager = Me.BarManager1
        Me.txt_Designation.Name = "txt_Designation"
        Me.txt_Designation.Size = New System.Drawing.Size(183, 20)
        Me.txt_Designation.TabIndex = 16
        '
        'SPA_Sales_Summary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 279)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.txt_Designation)
        Me.Controls.Add(Me.txt_BMName)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "SPA_Sales_Summary"
        Me.Text = "SALES SUMMARY"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BMName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Designation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents SkinBarSubItem1 As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar5 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents txt_BrCode As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents dtp_DateBegin As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents dtp_DateEnd As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btn_Find As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Print As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_Transaction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_Reference As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_Customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_Sales As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_Return As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_Discount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_Designation As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_BMName As DevExpress.XtraEditors.TextEdit
End Class
