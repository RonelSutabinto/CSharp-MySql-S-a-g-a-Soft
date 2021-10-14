<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inventory_Outgoing
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    private sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Inventory_Outgoing))
        Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.gridControl = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Color = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.EngineNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ChassisNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.KeyNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VATAmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TotalCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BrCodeAcct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AccountNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LedgerSet = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SpecificNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrevID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btn_Generate = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Send = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txt_notes = New DevExpress.XtraEditors.TextEdit()
        Me.txt_remarks = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_vendor = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_TransCode = New DevExpress.XtraEditors.TextEdit()
        Me.txt_receiverUsername = New DevExpress.XtraEditors.TextEdit()
        Me.txt_receiver = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_invenStat = New DevExpress.XtraEditors.TextEdit()
        Me.receivedDate = New DevExpress.XtraEditors.DateEdit()
        Me.txt_approver = New DevExpress.XtraEditors.TextEdit()
        Me.cmb_warehouse = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_refno = New DevExpress.XtraEditors.TextEdit()
        Me.txt_pono = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmd_list = New System.Windows.Forms.Button()
        Me.statuserror = New DevExpress.XtraEditors.TextEdit()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_vendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TransCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_receiverUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_receiver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_invenStat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.receivedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.receivedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_approver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmb_warehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_refno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statuserror.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl.Controls.Add(Me.gridControl)
        Me.LayoutControl.Controls.Add(Me.txt_notes)
        Me.LayoutControl.Controls.Add(Me.txt_remarks)
        Me.LayoutControl.Controls.Add(Me.lbl_vendor)
        Me.LayoutControl.Controls.Add(Me.txt_TransCode)
        Me.LayoutControl.Controls.Add(Me.txt_receiverUsername)
        Me.LayoutControl.Controls.Add(Me.txt_receiver)
        Me.LayoutControl.Controls.Add(Me.txt_invenStat)
        Me.LayoutControl.Controls.Add(Me.receivedDate)
        Me.LayoutControl.Controls.Add(Me.txt_approver)
        Me.LayoutControl.Controls.Add(Me.cmb_warehouse)
        Me.LayoutControl.Controls.Add(Me.txt_refno)
        Me.LayoutControl.Controls.Add(Me.txt_pono)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControl.Name = "LayoutControl1"
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(908, 513)
        Me.LayoutControl.TabIndex = 117
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'gridControl
        '
        Me.gridControl.Location = New System.Drawing.Point(12, 176)
        Me.gridControl.MainView = Me.gridView
        Me.gridControl.MenuManager = Me.BarManager1
        Me.gridControl.Name = "gridControl"
        Me.gridControl.Size = New System.Drawing.Size(884, 325)
        Me.gridControl.TabIndex = 111
        Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id, Me.Code, Me.Model, Me.Description, Me.Color, Me.Brand, Me.EngineNo, Me.ChassisNo, Me.KeyNo, Me.UnitCost, Me.VATAmt, Me.TotalCost, Me.UnitPrice, Me.AccountName, Me.BrCodeAcct, Me.AccountNumber, Me.LedgerSet, Me.SpecificNotes, Me.PrevID})
        Me.gridView.gridControl = Me.gridControl
        Me.gridView.Name = "gridView"
        '
        'id
        '
        Me.id.Caption = "ID"
        Me.id.FieldName = "id"
        Me.id.Name = "id"
        Me.id.Visible = True
        Me.id.VisibleIndex = 0
        '
        'Code
        '
        Me.Code.Caption = "Code"
        Me.Code.FieldName = "Code"
        Me.Code.Name = "Code"
        Me.Code.Visible = True
        Me.Code.VisibleIndex = 1
        '
        'Model
        '
        Me.Model.Caption = "Model"
        Me.Model.FieldName = "Model"
        Me.Model.Name = "Model"
        Me.Model.Visible = True
        Me.Model.VisibleIndex = 2
        '
        'Description
        '
        Me.Description.Caption = "Description"
        Me.Description.FieldName = "Description"
        Me.Description.Name = "Description"
        Me.Description.Visible = True
        Me.Description.VisibleIndex = 3
        '
        'Color
        '
        Me.Color.Caption = "Color"
        Me.Color.FieldName = "Color"
        Me.Color.Name = "Color"
        Me.Color.Visible = True
        Me.Color.VisibleIndex = 4
        '
        'Brand
        '
        Me.Brand.Caption = "Brand"
        Me.Brand.FieldName = "Brand"
        Me.Brand.Name = "Brand"
        Me.Brand.Visible = True
        Me.Brand.VisibleIndex = 5
        '
        'EngineNo
        '
        Me.EngineNo.Caption = "EngineNo"
        Me.EngineNo.FieldName = "EngineNo"
        Me.EngineNo.Name = "EngineNo"
        Me.EngineNo.Visible = True
        Me.EngineNo.VisibleIndex = 6
        '
        'ChassisNo
        '
        Me.ChassisNo.Caption = "ChassisNo"
        Me.ChassisNo.FieldName = "ChassisNo"
        Me.ChassisNo.Name = "ChassisNo"
        Me.ChassisNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ChassisNo", "{0}")})
        Me.ChassisNo.Visible = True
        Me.ChassisNo.VisibleIndex = 7
        '
        'KeyNo
        '
        Me.KeyNo.Caption = "KeyNo"
        Me.KeyNo.FieldName = "KeyNo"
        Me.KeyNo.Name = "KeyNo"
        Me.KeyNo.Visible = True
        Me.KeyNo.VisibleIndex = 8
        '
        'UnitCost
        '
        Me.UnitCost.Caption = "UnitCost"
        Me.UnitCost.FieldName = "UnitCost"
        Me.UnitCost.Name = "UnitCost"
        Me.UnitCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitCost", "{0:0.##}")})
        Me.UnitCost.Visible = True
        Me.UnitCost.VisibleIndex = 9
        '
        'VATAmt
        '
        Me.VATAmt.Caption = "VATAmt"
        Me.VATAmt.FieldName = "VATAmt"
        Me.VATAmt.Name = "VATAmt"
        Me.VATAmt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VATAmt", "{0:0.##}")})
        Me.VATAmt.Visible = True
        Me.VATAmt.VisibleIndex = 10
        '
        'TotalCost
        '
        Me.TotalCost.Caption = "TotalCost"
        Me.TotalCost.FieldName = "TotalCost"
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCost", "{0:0.##}")})
        Me.TotalCost.Visible = True
        Me.TotalCost.VisibleIndex = 11
        '
        'UnitPrice
        '
        Me.UnitPrice.Caption = "UnitPrice"
        Me.UnitPrice.FieldName = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitPrice", "{0:0.##}")})
        Me.UnitPrice.Visible = True
        Me.UnitPrice.VisibleIndex = 12
        '
        'AccountName
        '
        Me.AccountName.Caption = "AccountName"
        Me.AccountName.FieldName = "AccountName"
        Me.AccountName.Name = "AccountName"
        Me.AccountName.Visible = True
        Me.AccountName.VisibleIndex = 13
        '
        'BrCodeAcct
        '
        Me.BrCodeAcct.Caption = "BrCodeAcct"
        Me.BrCodeAcct.FieldName = "BrCodeAcct"
        Me.BrCodeAcct.Name = "BrCodeAcct"
        Me.BrCodeAcct.Visible = True
        Me.BrCodeAcct.VisibleIndex = 14
        '
        'AccountNumber
        '
        Me.AccountNumber.Caption = "AccountNumber"
        Me.AccountNumber.FieldName = "AccountNumber"
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Visible = True
        Me.AccountNumber.VisibleIndex = 15
        '
        'LedgerSet
        '
        Me.LedgerSet.Caption = "LedgerSet"
        Me.LedgerSet.FieldName = "LedgerSet"
        Me.LedgerSet.Name = "LedgerSet"
        Me.LedgerSet.Visible = True
        Me.LedgerSet.VisibleIndex = 16
        '
        'SpecificNotes
        '
        Me.SpecificNotes.Caption = "SpecificNotes"
        Me.SpecificNotes.FieldName = "SpecificNotes"
        Me.SpecificNotes.Name = "SpecificNotes"
        Me.SpecificNotes.Visible = True
        Me.SpecificNotes.VisibleIndex = 17
        '
        'PrevID
        '
        Me.PrevID.Caption = "PrevID"
        Me.PrevID.FieldName = "PrevID"
        Me.PrevID.Name = "PrevID"
        Me.PrevID.Visible = True
        Me.PrevID.VisibleIndex = 18
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Generate, Me.btn_Send})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Send)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btn_Generate
        '
        Me.btn_Generate.Caption = "Generate"
        Me.btn_Generate.Id = 0
        Me.btn_Generate.Name = "btn_Generate"
        '
        'btn_Send
        '
        Me.btn_Send.Caption = "Send"
        Me.btn_Send.Id = 1
        Me.btn_Send.Name = "btn_Send"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(908, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 537)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(908, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 513)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(908, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 513)
        '
        'txt_notes
        '
        Me.txt_notes.Location = New System.Drawing.Point(111, 124)
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Size = New System.Drawing.Size(785, 22)
        Me.txt_notes.StyleController = Me.layoutControl
        Me.txt_notes.TabIndex = 110
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(111, 150)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(785, 22)
        Me.txt_remarks.StyleController = Me.layoutControl
        Me.txt_remarks.TabIndex = 108
        '
        'lbl_vendor
        '
        Me.lbl_vendor.Location = New System.Drawing.Point(111, 12)
        Me.lbl_vendor.MenuManager = Me.BarManager1
        Me.lbl_vendor.Name = "lbl_vendor"
        Me.lbl_vendor.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vendor.Properties.Appearance.Options.UseFont = True
        Me.lbl_vendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lbl_vendor.Size = New System.Drawing.Size(427, 22)
        Me.lbl_vendor.StyleController = Me.layoutControl
        Me.lbl_vendor.TabIndex = 4
        '
        'txt_TransCode
        '
        Me.txt_TransCode.EditValue = "txt_TransCode"
        Me.txt_TransCode.Enabled = False
        Me.txt_TransCode.Location = New System.Drawing.Point(641, 12)
        Me.txt_TransCode.Name = "txt_TransCode"
        Me.txt_TransCode.Size = New System.Drawing.Size(255, 22)
        Me.txt_TransCode.StyleController = Me.layoutControl
        Me.txt_TransCode.TabIndex = 71
        '
        'txt_receiverUsername
        '
        Me.txt_receiverUsername.Enabled = False
        Me.txt_receiverUsername.Location = New System.Drawing.Point(395, 64)
        Me.txt_receiverUsername.Name = "txt_receiverUsername"
        Me.txt_receiverUsername.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_receiverUsername.Properties.Appearance.Options.UseFont = True
        Me.txt_receiverUsername.Size = New System.Drawing.Size(143, 26)
        Me.txt_receiverUsername.StyleController = Me.layoutControl
        Me.txt_receiverUsername.TabIndex = 107
        '
        'txt_receiver
        '
        Me.txt_receiver.Location = New System.Drawing.Point(111, 64)
        Me.txt_receiver.Name = "txt_receiver"
        Me.txt_receiver.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_receiver.Properties.Appearance.Options.UseFont = True
        Me.txt_receiver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_receiver.Size = New System.Drawing.Size(272, 22)
        Me.txt_receiver.StyleController = Me.layoutControl
        Me.txt_receiver.TabIndex = 99
        '
        'txt_invenStat
        '
        Me.txt_invenStat.EditValue = "For Transport"
        Me.txt_invenStat.Enabled = False
        Me.txt_invenStat.Location = New System.Drawing.Point(641, 38)
        Me.txt_invenStat.Name = "txt_invenStat"
        Me.txt_invenStat.Size = New System.Drawing.Size(255, 22)
        Me.txt_invenStat.StyleController = Me.layoutControl
        Me.txt_invenStat.TabIndex = 73
        '
        'receivedDate
        '
        Me.receivedDate.Enabled = False
        Me.receivedDate.Location = New System.Drawing.Point(641, 64)
        Me.receivedDate.Name = "receivedDate"
        Me.receivedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.receivedDate.Size = New System.Drawing.Size(255, 22)
        Me.receivedDate.StyleController = Me.layoutControl
        Me.receivedDate.TabIndex = 63
        '
        'txt_approver
        '
        Me.txt_approver.Enabled = False
        Me.txt_approver.Location = New System.Drawing.Point(111, 38)
        Me.txt_approver.Name = "txt_approver"
        Me.txt_approver.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_approver.Properties.Appearance.Options.UseFont = True
        Me.txt_approver.Size = New System.Drawing.Size(427, 22)
        Me.txt_approver.StyleController = Me.layoutControl
        Me.txt_approver.TabIndex = 100
        '
        'cmb_warehouse
        '
        Me.cmb_warehouse.Location = New System.Drawing.Point(610, 90)
        Me.cmb_warehouse.Name = "cmb_warehouse"
        Me.cmb_warehouse.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_warehouse.Properties.Appearance.Options.UseFont = True
        Me.cmb_warehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmb_warehouse.Size = New System.Drawing.Size(286, 22)
        Me.cmb_warehouse.StyleController = Me.layoutControl
        Me.cmb_warehouse.TabIndex = 80
        '
        'txt_refno
        '
        Me.txt_refno.Location = New System.Drawing.Point(111, 94)
        Me.txt_refno.Name = "txt_refno"
        Me.txt_refno.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_refno.Properties.Appearance.Options.UseFont = True
        Me.txt_refno.Size = New System.Drawing.Size(162, 26)
        Me.txt_refno.StyleController = Me.layoutControl
        Me.txt_refno.TabIndex = 67
        '
        'txt_pono
        '
        Me.txt_pono.Location = New System.Drawing.Point(376, 94)
        Me.txt_pono.Name = "txt_pono"
        Me.txt_pono.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pono.Properties.Appearance.Options.UseFont = True
        Me.txt_pono.Size = New System.Drawing.Size(162, 26)
        Me.txt_pono.StyleController = Me.layoutControl
        Me.txt_pono.TabIndex = 69
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem9, Me.LayoutControlItem11, Me.LayoutControlItem8, Me.LayoutControlItem12, Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem15})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(908, 513)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.lbl_vendor
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(530, 26)
        Me.LayoutControlItem1.Text = "Receiving Branch"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txt_TransCode
        Me.LayoutControlItem3.Location = New System.Drawing.Point(530, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(358, 26)
        Me.LayoutControlItem3.Text = "TransCode"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txt_invenStat
        Me.LayoutControlItem4.Location = New System.Drawing.Point(530, 26)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(358, 26)
        Me.LayoutControlItem4.Text = "Status"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.receivedDate
        Me.LayoutControlItem5.Location = New System.Drawing.Point(530, 52)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(358, 26)
        Me.LayoutControlItem5.Text = "Posting Date"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txt_approver
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(530, 26)
        Me.LayoutControlItem6.Text = "Approver"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txt_receiver
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(375, 30)
        Me.LayoutControlItem7.Text = "Recipient"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.cmb_warehouse
        Me.LayoutControlItem9.Location = New System.Drawing.Point(530, 78)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(358, 34)
        Me.LayoutControlItem9.Text = "Warehouse"
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(63, 15)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txt_refno
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 82)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(265, 30)
        Me.LayoutControlItem11.Text = "ReferenceNumber"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txt_receiverUsername
        Me.LayoutControlItem8.Location = New System.Drawing.Point(375, 52)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(155, 30)
        Me.LayoutControlItem8.Text = " "
        Me.LayoutControlItem8.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(3, 15)
        Me.LayoutControlItem8.TextToControlDistance = 5
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txt_pono
        Me.LayoutControlItem12.Location = New System.Drawing.Point(265, 82)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(265, 30)
        Me.LayoutControlItem12.Text = "PONumber"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txt_notes
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 112)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(888, 26)
        Me.LayoutControlItem13.Text = "Notes"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txt_remarks
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 138)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(888, 26)
        Me.LayoutControlItem14.Text = "Remarks"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.gridControl
        Me.LayoutControlItem15.Location = New System.Drawing.Point(0, 164)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(888, 329)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'cmd_list
        '
        Me.cmd_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_list.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_list.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.cmd_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_list.ForeColor = System.Drawing.Color.White
        Me.cmd_list.Image = CType(resources.GetObject("cmd_list.Image"), System.Drawing.Image)
        Me.cmd_list.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_list.Location = New System.Drawing.Point(95, 440)
        Me.cmd_list.Name = "cmd_list"
        Me.cmd_list.Size = New System.Drawing.Size(92, 42)
        Me.cmd_list.TabIndex = 104
        Me.cmd_list.Text = " &LIST"
        Me.cmd_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_list.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmd_list.UseVisualStyleBackColor = True
        Me.cmd_list.Visible = False
        '
        'statuserror
        '
        Me.statuserror.EditValue = "statuserror1"
        Me.statuserror.Location = New System.Drawing.Point(475, 472)
        Me.statuserror.Name = "statuserror"
        Me.statuserror.Size = New System.Drawing.Size(163, 22)
        Me.statuserror.TabIndex = 112
        Me.statuserror.Visible = False
        '
        'IS_Inventory_Outgoing
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 537)
        Me.Controls.Add(Me.statuserror)
        Me.Controls.Add(Me.cmd_list)
        Me.Controls.Add(Me.layoutControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "IS_Inventory_Outgoing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IS/Inventory/Outgoing"
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_vendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TransCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_receiverUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_receiver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_invenStat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.receivedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.receivedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_approver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmb_warehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_refno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statuserror.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_totUnitPrice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_count As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_grandTotal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents label99 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_totVatAmt As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_tot_unit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_warehouse As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_invenStat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_TransCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_pono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_refno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents receivedDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_receiver As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_approver As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmd_list As System.Windows.Forms.Button
    Friend WithEvents txt_receiverUsername As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_notes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_remarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents statuserror As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btn_Generate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_Send As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lbl_vendor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Color As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EngineNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ChassisNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KeyNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VATAmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BrCodeAcct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LedgerSet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpecificNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrevID As DevExpress.XtraGrid.Columns.GridColumn
End Class
