<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SPA_TransmittalReport
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_TransmittalReport))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.toolPrint = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txt_Source = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.partsNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.partsName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Quantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.spCostWOVAT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_SRP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.subTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txt_Vendor = New DevExpress.XtraEditors.TextEdit()
        Me.cmb_Status = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dtp_Date = New DevExpress.XtraEditors.DateEdit()
        Me.btn_Add = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_BrCode = New DevExpress.XtraEditors.TextEdit()
        Me.btn_Show = New DevExpress.XtraEditors.SimpleButton()
        Me.cmb_whCategory = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_whCode = New DevExpress.XtraEditors.TextEdit()
        Me.txt_SINo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_PONo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Approver = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Partsman = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Note = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Remarks = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.txt_PreparedName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Designation3 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Designation2 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Designation1 = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ApproverName = New DevExpress.XtraEditors.TextEdit()
        Me.txt_CheckerName = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_GrandTotal = New System.Windows.Forms.Label()
        Me.lbl_Less = New System.Windows.Forms.Label()
        Me.lbl_SubTotal = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_Total = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Source.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Vendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BrCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_whCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_whCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SINo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_PONo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Approver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Partsman.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.txt_PreparedName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Designation3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Designation2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Designation1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ApproverName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_CheckerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.toolPrint})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 1
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.toolPrint)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'toolPrint
        '
        Me.toolPrint.Caption = "Print"
        Me.toolPrint.Glyph = CType(resources.GetObject("toolPrint.Glyph"), System.Drawing.Image)
        Me.toolPrint.Id = 0
        Me.toolPrint.LargeGlyph = CType(resources.GetObject("toolPrint.LargeGlyph"), System.Drawing.Image)
        Me.toolPrint.Name = "toolPrint"
        Me.toolPrint.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1057, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 431)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1057, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 407)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1057, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 407)
        '
        'txt_Source
        '
        Me.txt_Source.Location = New System.Drawing.Point(455, 104)
        Me.txt_Source.Name = "txt_Source"
        Me.txt_Source.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Source.Properties.Appearance.Options.UseFont = True
        Me.txt_Source.Size = New System.Drawing.Size(174, 26)
        Me.txt_Source.TabIndex = 33
        '
        'GridControl
        '
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl.Location = New System.Drawing.Point(0, 0)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(1057, 225)
        Me.GridControl.TabIndex = 11
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView, Me.GridView1})
        '
        'GridView
        '
        Me.GridView.AppearancePrint.FooterPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.GridView.AppearancePrint.HeaderPanel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.AppearancePrint.HeaderPanel.Options.UseFont = True
        Me.GridView.AppearancePrint.OddRow.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.AppearancePrint.OddRow.Options.UseFont = True
        Me.GridView.AppearancePrint.Preview.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.AppearancePrint.Preview.Options.UseFont = True
        Me.GridView.AppearancePrint.Row.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView.AppearancePrint.Row.Options.UseFont = True
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.partsNumber, Me.partsName, Me.Quantity, Me.spCostWOVAT, Me.col_SRP, Me.subTotal})
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        Me.GridView.OptionsView.ShowFooter = True
        '
        'partsNumber
        '
        Me.partsNumber.Caption = "PART NUMBER"
        Me.partsNumber.FieldName = "partsNumber"
        Me.partsNumber.Name = "partsNumber"
        Me.partsNumber.Visible = True
        Me.partsNumber.VisibleIndex = 0
        '
        'partsName
        '
        Me.partsName.Caption = "DESCRIPTION"
        Me.partsName.FieldName = "partsName"
        Me.partsName.Name = "partsName"
        Me.partsName.Visible = True
        Me.partsName.VisibleIndex = 1
        '
        'Quantity
        '
        Me.Quantity.Caption = "QUANTITY"
        Me.Quantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Quantity.FieldName = "Quantity"
        Me.Quantity.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Visible = True
        Me.Quantity.VisibleIndex = 2
        '
        'spCostWOVAT
        '
        Me.spCostWOVAT.Caption = "COST WO/VAT"
        Me.spCostWOVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spCostWOVAT.FieldName = "spCostWOVAT"
        Me.spCostWOVAT.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spCostWOVAT.Name = "spCostWOVAT"
        Me.spCostWOVAT.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "spCostWOVAT", "SUM Total Cost={0:n2}")})
        Me.spCostWOVAT.Visible = True
        Me.spCostWOVAT.VisibleIndex = 3
        '
        'col_SRP
        '
        Me.col_SRP.Caption = "SRP"
        Me.col_SRP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_SRP.FieldName = "SRP"
        Me.col_SRP.Name = "col_SRP"
        Me.col_SRP.Visible = True
        Me.col_SRP.VisibleIndex = 4
        '
        'subTotal
        '
        Me.subTotal.Caption = "SUB TOTAL"
        Me.subTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.subTotal.FieldName = "subTotal"
        Me.subTotal.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.subTotal.Name = "subTotal"
        Me.subTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "subTotal", "SUM SubTotal={0:n2}", New Decimal(New Integer() {0, 0, 0, 131072}))})
        Me.subTotal.Visible = True
        Me.subTotal.VisibleIndex = 5
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl
        Me.GridView1.Name = "GridView1"
        '
        'txt_Vendor
        '
        Me.txt_Vendor.Location = New System.Drawing.Point(145, 17)
        Me.txt_Vendor.Name = "txt_Vendor"
        Me.txt_Vendor.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Vendor.Properties.Appearance.Options.UseFont = True
        Me.txt_Vendor.Properties.ReadOnly = True
        Me.txt_Vendor.Size = New System.Drawing.Size(314, 26)
        Me.txt_Vendor.TabIndex = 14
        '
        'cmb_Status
        '
        Me.cmb_Status.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Status.Location = New System.Drawing.Point(720, 17)
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Status.Properties.Appearance.Options.UseFont = True
        Me.cmb_Status.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_Status.Properties.ReadOnly = True
        Me.cmb_Status.Size = New System.Drawing.Size(181, 26)
        Me.cmb_Status.TabIndex = 15
        '
        'dtp_Date
        '
        Me.dtp_Date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp_Date.EditValue = Nothing
        Me.dtp_Date.Location = New System.Drawing.Point(720, 49)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Properties.Appearance.Options.UseFont = True
        Me.dtp_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_Date.Properties.CalendarTimeProperties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dtp_Date.Properties.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Date.Properties.CalendarTimeProperties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtp_Date.Properties.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Date.Properties.CalendarTimeProperties.Mask.EditMask = "MM/dd/yyyy"
        Me.dtp_Date.Properties.DisplayFormat.FormatString = "MM/dd/ yyyy"
        Me.dtp_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Date.Properties.EditFormat.FormatString = "MM/dd/ yyyy"
        Me.dtp_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtp_Date.Properties.Mask.EditMask = "MM/dd/ yyyy"
        Me.dtp_Date.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.dtp_Date.Properties.ReadOnly = True
        Me.dtp_Date.Size = New System.Drawing.Size(181, 26)
        Me.dtp_Date.TabIndex = 16
        '
        'btn_Add
        '
        Me.btn_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Add.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Add.Appearance.Options.UseFont = True
        Me.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add.Image = CType(resources.GetObject("btn_Add.Image"), System.Drawing.Image)
        Me.btn_Add.Location = New System.Drawing.Point(907, 15)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(138, 92)
        Me.btn_Add.TabIndex = 17
        Me.btn_Add.Text = "PARTS"
        '
        'LabelControl1
        '
        Me.LabelControl1.AllowDrop = True
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Location = New System.Drawing.Point(8, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(132, 19)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "RECEIVING BRANCH"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Location = New System.Drawing.Point(679, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 19)
        Me.LabelControl2.TabIndex = 19
        Me.LabelControl2.Text = "DATE"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Location = New System.Drawing.Point(665, 20)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 19)
        Me.LabelControl3.TabIndex = 20
        Me.LabelControl3.Text = "STATUS"
        '
        'txt_BrCode
        '
        Me.txt_BrCode.Location = New System.Drawing.Point(465, 17)
        Me.txt_BrCode.Name = "txt_BrCode"
        Me.txt_BrCode.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BrCode.Properties.Appearance.Options.UseFont = True
        Me.txt_BrCode.Properties.ReadOnly = True
        Me.txt_BrCode.Size = New System.Drawing.Size(73, 26)
        Me.txt_BrCode.TabIndex = 21
        '
        'btn_Show
        '
        Me.btn_Show.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Show.Appearance.Options.UseFont = True
        Me.btn_Show.Image = CType(resources.GetObject("btn_Show.Image"), System.Drawing.Image)
        Me.btn_Show.Location = New System.Drawing.Point(544, 7)
        Me.btn_Show.Name = "btn_Show"
        Me.btn_Show.Size = New System.Drawing.Size(38, 36)
        Me.btn_Show.TabIndex = 22
        '
        'cmb_whCategory
        '
        Me.cmb_whCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_whCategory.Location = New System.Drawing.Point(720, 81)
        Me.cmb_whCategory.Name = "cmb_whCategory"
        Me.cmb_whCategory.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_whCategory.Properties.Appearance.Options.UseFont = True
        Me.cmb_whCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_whCategory.Properties.ReadOnly = True
        Me.cmb_whCategory.Size = New System.Drawing.Size(127, 26)
        Me.cmb_whCategory.TabIndex = 23
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl4.Location = New System.Drawing.Point(624, 84)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(93, 19)
        Me.LabelControl4.TabIndex = 24
        Me.LabelControl4.Text = "WARE HOUSE"
        '
        'txt_whCode
        '
        Me.txt_whCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_whCode.Location = New System.Drawing.Point(853, 81)
        Me.txt_whCode.Name = "txt_whCode"
        Me.txt_whCode.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_whCode.Properties.Appearance.Options.UseFont = True
        Me.txt_whCode.Properties.ReadOnly = True
        Me.txt_whCode.Size = New System.Drawing.Size(48, 26)
        Me.txt_whCode.TabIndex = 25
        '
        'txt_SINo
        '
        Me.txt_SINo.Location = New System.Drawing.Point(145, 49)
        Me.txt_SINo.Name = "txt_SINo"
        Me.txt_SINo.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SINo.Properties.Appearance.Options.UseFont = True
        Me.txt_SINo.Properties.ReadOnly = True
        Me.txt_SINo.Size = New System.Drawing.Size(174, 26)
        Me.txt_SINo.TabIndex = 26
        '
        'LabelControl5
        '
        Me.LabelControl5.AllowDrop = True
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl5.Location = New System.Drawing.Point(102, 52)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(40, 19)
        Me.LabelControl5.TabIndex = 27
        Me.LabelControl5.Text = "SI No."
        '
        'txt_PONo
        '
        Me.txt_PONo.Location = New System.Drawing.Point(408, 49)
        Me.txt_PONo.Name = "txt_PONo"
        Me.txt_PONo.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PONo.Properties.Appearance.Options.UseFont = True
        Me.txt_PONo.Properties.ReadOnly = True
        Me.txt_PONo.Size = New System.Drawing.Size(174, 26)
        Me.txt_PONo.TabIndex = 28
        '
        'LabelControl6
        '
        Me.LabelControl6.AllowDrop = True
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl6.Location = New System.Drawing.Point(357, 52)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(48, 19)
        Me.LabelControl6.TabIndex = 29
        Me.LabelControl6.Text = "PO No."
        '
        'txt_Approver
        '
        Me.txt_Approver.Location = New System.Drawing.Point(145, 81)
        Me.txt_Approver.Name = "txt_Approver"
        Me.txt_Approver.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Approver.Properties.Appearance.Options.UseFont = True
        Me.txt_Approver.Properties.ReadOnly = True
        Me.txt_Approver.Size = New System.Drawing.Size(174, 26)
        Me.txt_Approver.TabIndex = 30
        '
        'LabelControl8
        '
        Me.LabelControl8.AllowDrop = True
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl8.Location = New System.Drawing.Point(68, 84)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(74, 19)
        Me.LabelControl8.TabIndex = 31
        Me.LabelControl8.Text = "APPROVER"
        '
        'txt_Partsman
        '
        Me.txt_Partsman.Location = New System.Drawing.Point(408, 81)
        Me.txt_Partsman.Name = "txt_Partsman"
        Me.txt_Partsman.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Partsman.Properties.Appearance.Options.UseFont = True
        Me.txt_Partsman.Properties.ReadOnly = True
        Me.txt_Partsman.Size = New System.Drawing.Size(174, 26)
        Me.txt_Partsman.TabIndex = 32
        '
        'LabelControl7
        '
        Me.LabelControl7.AllowDrop = True
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl7.Location = New System.Drawing.Point(323, 84)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(79, 19)
        Me.LabelControl7.TabIndex = 33
        Me.LabelControl7.Text = "PARTSMAN"
        '
        'txt_Note
        '
        Me.txt_Note.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Note.Location = New System.Drawing.Point(145, 113)
        Me.txt_Note.Name = "txt_Note"
        Me.txt_Note.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Note.Properties.Appearance.Options.UseFont = True
        Me.txt_Note.Properties.ReadOnly = True
        Me.txt_Note.Size = New System.Drawing.Size(900, 26)
        Me.txt_Note.TabIndex = 34
        '
        'LabelControl9
        '
        Me.LabelControl9.AllowDrop = True
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl9.Location = New System.Drawing.Point(102, 116)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(38, 19)
        Me.LabelControl9.TabIndex = 35
        Me.LabelControl9.Text = "NOTE"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Remarks.Location = New System.Drawing.Point(145, 145)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Properties.Appearance.Options.UseFont = True
        Me.txt_Remarks.Properties.ReadOnly = True
        Me.txt_Remarks.Size = New System.Drawing.Size(900, 26)
        Me.txt_Remarks.TabIndex = 36
        '
        'LabelControl10
        '
        Me.LabelControl10.AllowDrop = True
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl10.Location = New System.Drawing.Point(76, 148)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(67, 19)
        Me.LabelControl10.TabIndex = 37
        Me.LabelControl10.Text = "REMARKS"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.White
        Me.SplitContainerControl1.Panel1.Appearance.BackColor2 = System.Drawing.Color.White
        Me.SplitContainerControl1.Panel1.Appearance.Options.UseBackColor = True
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_Note)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_PreparedName)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_Remarks)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_Designation3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_Designation2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_Designation1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl10)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl9)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl7)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_Partsman)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl8)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_Approver)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl6)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_PONo)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl5)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_SINo)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_whCode)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl4)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmb_whCategory)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.btn_Show)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_BrCode)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl3)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.LabelControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.btn_Add)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.dtp_Date)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.cmb_Status)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_Vendor)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_ApproverName)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.txt_CheckerName)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lbl_GrandTotal)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lbl_Less)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lbl_SubTotal)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Label18)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Label16)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.Label14)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lbl_Total)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.txt_Source)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1057, 407)
        Me.SplitContainerControl1.SplitterPosition = 177
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'txt_PreparedName
        '
        Me.txt_PreparedName.Location = New System.Drawing.Point(160, 113)
        Me.txt_PreparedName.Name = "txt_PreparedName"
        Me.txt_PreparedName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PreparedName.Properties.Appearance.Options.UseFont = True
        Me.txt_PreparedName.Properties.ReadOnly = True
        Me.txt_PreparedName.Size = New System.Drawing.Size(196, 26)
        Me.txt_PreparedName.TabIndex = 43
        '
        'txt_Designation3
        '
        Me.txt_Designation3.Location = New System.Drawing.Point(813, 113)
        Me.txt_Designation3.Name = "txt_Designation3"
        Me.txt_Designation3.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Designation3.Properties.Appearance.Options.UseFont = True
        Me.txt_Designation3.Properties.ReadOnly = True
        Me.txt_Designation3.Size = New System.Drawing.Size(196, 26)
        Me.txt_Designation3.TabIndex = 42
        '
        'txt_Designation2
        '
        Me.txt_Designation2.Location = New System.Drawing.Point(588, 145)
        Me.txt_Designation2.Name = "txt_Designation2"
        Me.txt_Designation2.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Designation2.Properties.Appearance.Options.UseFont = True
        Me.txt_Designation2.Properties.ReadOnly = True
        Me.txt_Designation2.Size = New System.Drawing.Size(196, 26)
        Me.txt_Designation2.TabIndex = 41
        '
        'txt_Designation1
        '
        Me.txt_Designation1.Location = New System.Drawing.Point(588, 113)
        Me.txt_Designation1.Name = "txt_Designation1"
        Me.txt_Designation1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Designation1.Properties.Appearance.Options.UseFont = True
        Me.txt_Designation1.Properties.ReadOnly = True
        Me.txt_Designation1.Size = New System.Drawing.Size(196, 26)
        Me.txt_Designation1.TabIndex = 40
        '
        'txt_ApproverName
        '
        Me.txt_ApproverName.Location = New System.Drawing.Point(362, 145)
        Me.txt_ApproverName.Name = "txt_ApproverName"
        Me.txt_ApproverName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ApproverName.Properties.Appearance.Options.UseFont = True
        Me.txt_ApproverName.Properties.ReadOnly = True
        Me.txt_ApproverName.Size = New System.Drawing.Size(196, 26)
        Me.txt_ApproverName.TabIndex = 39
        '
        'txt_CheckerName
        '
        Me.txt_CheckerName.Location = New System.Drawing.Point(362, 113)
        Me.txt_CheckerName.Name = "txt_CheckerName"
        Me.txt_CheckerName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CheckerName.Properties.Appearance.Options.UseFont = True
        Me.txt_CheckerName.Properties.ReadOnly = True
        Me.txt_CheckerName.Size = New System.Drawing.Size(196, 26)
        Me.txt_CheckerName.TabIndex = 38
        '
        'lbl_GrandTotal
        '
        Me.lbl_GrandTotal.AutoSize = True
        Me.lbl_GrandTotal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GrandTotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_GrandTotal.Location = New System.Drawing.Point(611, 157)
        Me.lbl_GrandTotal.Name = "lbl_GrandTotal"
        Me.lbl_GrandTotal.Size = New System.Drawing.Size(31, 15)
        Me.lbl_GrandTotal.TabIndex = 50
        Me.lbl_GrandTotal.Text = "0.00"
        '
        'lbl_Less
        '
        Me.lbl_Less.AutoSize = True
        Me.lbl_Less.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Less.ForeColor = System.Drawing.Color.Black
        Me.lbl_Less.Location = New System.Drawing.Point(611, 138)
        Me.lbl_Less.Name = "lbl_Less"
        Me.lbl_Less.Size = New System.Drawing.Size(31, 15)
        Me.lbl_Less.TabIndex = 49
        Me.lbl_Less.Text = "0.00"
        '
        'lbl_SubTotal
        '
        Me.lbl_SubTotal.AutoSize = True
        Me.lbl_SubTotal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubTotal.ForeColor = System.Drawing.Color.Black
        Me.lbl_SubTotal.Location = New System.Drawing.Point(611, 119)
        Me.lbl_SubTotal.Name = "lbl_SubTotal"
        Me.lbl_SubTotal.Size = New System.Drawing.Size(31, 15)
        Me.lbl_SubTotal.TabIndex = 48
        Me.lbl_SubTotal.Text = "0.00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(411, 157)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 15)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "GRAND TOTAL"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(411, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(87, 15)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "TOTAL VAT AMT"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(411, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 15)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "TOTAL UNIT COST"
        '
        'lbl_Total
        '
        Me.lbl_Total.AllowDrop = True
        Me.lbl_Total.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_Total.Location = New System.Drawing.Point(455, 136)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(8, 19)
        Me.lbl_Total.TabIndex = 34
        Me.lbl_Total.Text = "0"
        '
        'SPA_TransmittalReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 431)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "SPA_TransmittalReport"
        Me.Text = "FOR TRANSPORT"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Source.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Vendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BrCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_whCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_whCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SINo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_PONo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Approver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Partsman.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.txt_PreparedName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Designation3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Designation2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Designation1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ApproverName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_CheckerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents toolPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Remarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Note As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Partsman As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Approver As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_PONo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_SINo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_whCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_whCategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_Show As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_BrCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_Add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtp_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmb_Status As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_Vendor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_Source As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents partsNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents partsName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Quantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spCostWOVAT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_Total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents subTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_GrandTotal As Label
    Friend WithEvents lbl_Less As Label
    Friend WithEvents lbl_SubTotal As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_ApproverName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_CheckerName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Designation3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Designation2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Designation1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_PreparedName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents col_SRP As DevExpress.XtraGrid.Columns.GridColumn
End Class
