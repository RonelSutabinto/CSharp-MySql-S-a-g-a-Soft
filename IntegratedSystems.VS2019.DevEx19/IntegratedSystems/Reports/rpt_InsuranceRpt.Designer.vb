<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rpt_InsuranceRpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_InsuranceRpt))
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemDateEdit_Date_Start = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemDateEdit_Date_End = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GInsurance = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.No = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Accountname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountNameHypLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.Address = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DateGranted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SINo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EngineNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChassisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Color = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TPLInsurance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RegistrationFee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SOP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MiscExpenses = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SaleType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.MVIRNoHyLink = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.MVIRNoEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit_Date_Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit_Date_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit_Date_End, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit_Date_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GInsurance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountNameHypLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MVIRNoHyLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MVIRNoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Preview, Me.btn_Close})
        Me.BarManager.MaxItemId = 14
        Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit_Date_Start, Me.RepositoryItemDateEdit_Date_End})
        '
        'Bar1
        '
        Me.Bar1.BarName = "MainMenu"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Reload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btn_Preview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
        Me.Bar1.Text = "MainMenu"
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
        Me.btn_Close.Id = 13
        Me.btn_Close.Name = "btn_Close"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager
        Me.barDockControlTop.Size = New System.Drawing.Size(541, 20)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 364)
        Me.barDockControlBottom.Manager = Me.BarManager
        Me.barDockControlBottom.Size = New System.Drawing.Size(541, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
        Me.barDockControlLeft.Manager = Me.BarManager
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 344)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(541, 20)
        Me.barDockControlRight.Manager = Me.BarManager
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 344)
        '
        'RepositoryItemDateEdit_Date_Start
        '
        Me.RepositoryItemDateEdit_Date_Start.AutoHeight = False
        Me.RepositoryItemDateEdit_Date_Start.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit_Date_Start.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit_Date_Start.Name = "RepositoryItemDateEdit_Date_Start"
        '
        'RepositoryItemDateEdit_Date_End
        '
        Me.RepositoryItemDateEdit_Date_End.AutoHeight = False
        Me.RepositoryItemDateEdit_Date_End.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit_Date_End.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit_Date_End.Name = "RepositoryItemDateEdit_Date_End"
        '
        'GInsurance
        '
        Me.GInsurance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GInsurance.Location = New System.Drawing.Point(0, 20)
        Me.GInsurance.MainView = Me.gridView
        Me.GInsurance.Name = "GInsurance"
        Me.GInsurance.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.MVIRNoHyLink, Me.AccountNameHypLink, Me.MVIRNoEdit})
        Me.GInsurance.Size = New System.Drawing.Size(541, 344)
        Me.GInsurance.TabIndex = 123
        Me.GInsurance.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No, Me.Accountname, Me.Address, Me.DateGranted, Me.SINo, Me.Brand, Me.Model, Me.EngineNo, Me.ChassisNo, Me.Color, Me.TPLInsurance, Me.RegistrationFee, Me.SOP, Me.MiscExpenses, Me.Total, Me.SaleType})
        Me.gridView.gridControl = Me.GInsurance
        Me.gridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", Me.Total, "{0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TPLInsurance", Me.TPLInsurance, "{0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RegistrationFee", Me.RegistrationFee, "{0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SOP", Me.SOP, "{0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MiscExpenses", Me.MiscExpenses, "{0:N2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Accountname", Me.Accountname, "(Sub-Total)")})
        Me.gridView.Name = "gridView"
        Me.gridView.OptionsView.ColumnAutoWidth = False
        '
        'No
        '
        Me.No.Caption = "No"
        Me.No.Name = "No"
        Me.No.Visible = True
        Me.No.VisibleIndex = 0
        '
        'Accountname
        '
        Me.Accountname.Caption = "Accountname"
        Me.Accountname.ColumnEdit = Me.AccountNameHypLink
        Me.Accountname.FieldName = "Accountname"
        Me.Accountname.Name = "Accountname"
        Me.Accountname.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Accountname", "TOTAL")})
        Me.Accountname.Visible = True
        Me.Accountname.VisibleIndex = 1
        '
        'AccountNameHypLink
        '
        Me.AccountNameHypLink.Appearance.FontStyleDelta = System.Drawing.FontStyle.Underline
        Me.AccountNameHypLink.Appearance.ForeColor = System.Drawing.Color.Red
        Me.AccountNameHypLink.Appearance.Options.UseFont = True
        Me.AccountNameHypLink.Appearance.Options.UseForeColor = True
        Me.AccountNameHypLink.AutoHeight = False
        Me.AccountNameHypLink.Name = "AccountNameHypLink"
        '
        'Address
        '
        Me.Address.Caption = "Address"
        Me.Address.FieldName = "Address"
        Me.Address.Name = "Address"
        Me.Address.Visible = True
        Me.Address.VisibleIndex = 2
        '
        'DateGranted
        '
        Me.DateGranted.Caption = "DateGranted"
        Me.DateGranted.FieldName = "DateGranted"
        Me.DateGranted.Name = "DateGranted"
        Me.DateGranted.Visible = True
        Me.DateGranted.VisibleIndex = 3
        '
        'SINo
        '
        Me.SINo.Caption = "SINo"
        Me.SINo.FieldName = "SINo"
        Me.SINo.Name = "SINo"
        Me.SINo.Visible = True
        Me.SINo.VisibleIndex = 4
        '
        'Brand
        '
        Me.Brand.Caption = "Brand"
        Me.Brand.FieldName = "Brand"
        Me.Brand.Name = "Brand"
        Me.Brand.Visible = True
        Me.Brand.VisibleIndex = 5
        '
        'Model
        '
        Me.Model.Caption = "Model"
        Me.Model.FieldName = "Model"
        Me.Model.Name = "Model"
        Me.Model.Visible = True
        Me.Model.VisibleIndex = 6
        '
        'EngineNo
        '
        Me.EngineNo.Caption = "EngineNo"
        Me.EngineNo.FieldName = "EngineNo"
        Me.EngineNo.Name = "EngineNo"
        Me.EngineNo.Visible = True
        Me.EngineNo.VisibleIndex = 7
        '
        'ChassisNo
        '
        Me.ChassisNo.Caption = "ChassisNo"
        Me.ChassisNo.FieldName = "ChassisNo"
        Me.ChassisNo.Name = "ChassisNo"
        Me.ChassisNo.Visible = True
        Me.ChassisNo.VisibleIndex = 8
        '
        'Color
        '
        Me.Color.Caption = "Color"
        Me.Color.FieldName = "Color"
        Me.Color.Name = "Color"
        Me.Color.Visible = True
        Me.Color.VisibleIndex = 9
        '
        'TPLInsurance
        '
        Me.TPLInsurance.Caption = "TPLInsurance"
        Me.TPLInsurance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TPLInsurance.FieldName = "TPLInsurance"
        Me.TPLInsurance.Name = "TPLInsurance"
        Me.TPLInsurance.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TPLInsurance", "{0:N2}")})
        Me.TPLInsurance.Visible = True
        Me.TPLInsurance.VisibleIndex = 10
        '
        'RegistrationFee
        '
        Me.RegistrationFee.Caption = "RegistrationFee"
        Me.RegistrationFee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.RegistrationFee.FieldName = "RegistrationFee"
        Me.RegistrationFee.Name = "RegistrationFee"
        Me.RegistrationFee.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RegistrationFee", "{0:N2}")})
        Me.RegistrationFee.Visible = True
        Me.RegistrationFee.VisibleIndex = 11
        '
        'SOP
        '
        Me.SOP.Caption = "SOP"
        Me.SOP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SOP.FieldName = "SOP"
        Me.SOP.Name = "SOP"
        Me.SOP.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SOP", "{0:N2}")})
        Me.SOP.Visible = True
        Me.SOP.VisibleIndex = 12
        '
        'MiscExpenses
        '
        Me.MiscExpenses.Caption = "MiscExpenses"
        Me.MiscExpenses.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.MiscExpenses.FieldName = "MiscExpenses"
        Me.MiscExpenses.Name = "MiscExpenses"
        Me.MiscExpenses.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MiscExpenses", "{0:N2}")})
        Me.MiscExpenses.Visible = True
        Me.MiscExpenses.VisibleIndex = 13
        '
        'Total
        '
        Me.Total.Caption = "Total"
        Me.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.FieldName = "Total"
        Me.Total.Name = "Total"
        Me.Total.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:N2}")})
        Me.Total.Visible = True
        Me.Total.VisibleIndex = 14
        '
        'SaleType
        '
        Me.SaleType.Caption = "SaleType"
        Me.SaleType.FieldName = "SaleType"
        Me.SaleType.Name = "SaleType"
        Me.SaleType.Visible = True
        Me.SaleType.VisibleIndex = 15
        '
        'MVIRNoHyLink
        '
        Me.MVIRNoHyLink.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MVIRNoHyLink.Appearance.FontStyleDelta = System.Drawing.FontStyle.Underline
        Me.MVIRNoHyLink.Appearance.ForeColor = System.Drawing.Color.Red
        Me.MVIRNoHyLink.Appearance.Options.UseBackColor = True
        Me.MVIRNoHyLink.Appearance.Options.UseFont = True
        Me.MVIRNoHyLink.Appearance.Options.UseForeColor = True
        Me.MVIRNoHyLink.AutoHeight = False
        Me.MVIRNoHyLink.Name = "MVIRNoHyLink"
        '
        'MVIRNoEdit
        '
        Me.MVIRNoEdit.Appearance.BorderColor = System.Drawing.Color.Red
        Me.MVIRNoEdit.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MVIRNoEdit.Appearance.ForeColor = System.Drawing.Color.Red
        Me.MVIRNoEdit.Appearance.Options.UseBorderColor = True
        Me.MVIRNoEdit.Appearance.Options.UseFont = True
        Me.MVIRNoEdit.Appearance.Options.UseForeColor = True
        Me.MVIRNoEdit.AutoHeight = False
        Me.MVIRNoEdit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MVIRNoEdit.Name = "MVIRNoEdit"
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
        'rpt_InsuranceRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 364)
        Me.Controls.Add(Me.GInsurance)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("rpt_InsuranceRpt.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "rpt_InsuranceRpt"
        Me.Text = "INSURANCE REPORT"
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit_Date_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit_Date_Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit_Date_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit_Date_End, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GInsurance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountNameHypLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MVIRNoHyLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MVIRNoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GInsurance As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Accountname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateGranted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SINo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EngineNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChassisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Color As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TPLInsurance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RegistrationFee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SOP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MiscExpenses As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SaleType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents No As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountNameHypLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents MVIRNoHyLink As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents MVIRNoEdit As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit_Date_Start As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit_Date_End As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
End Class
