<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IS_Inventory_Receiving
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Inventory_Receiving))
        Me.receivedDate = New DevExpress.XtraEditors.DateEdit()
        Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.GridList = New DevExpress.XtraGrid.GridControl()
        Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btn_Generate = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_BatchImport = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_Send = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.DockItems = New DevExpress.XtraBars.Docking.DockPanel()
        Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.txt_ModelLookup = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_uniPrice = New DevExpress.XtraEditors.TextEdit()
        Me.txt_LedSet = New DevExpress.XtraEditors.TextEdit()
        Me.txt_BrCode = New DevExpress.XtraEditors.TextEdit()
        Me.txt_SpecNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.num_vat = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_AccountNumber = New DevExpress.XtraEditors.TextEdit()
        Me.txt_note = New DevExpress.XtraEditors.TextEdit()
        Me.txt_keynumber = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ChassisNo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_EngineNo = New DevExpress.XtraEditors.TextEdit()
        Me.txt_color = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_descrip = New DevExpress.XtraEditors.TextEdit()
        Me.Frmbtn_Export_to_Grid = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_Account = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_brand = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_totcost = New DevExpress.XtraEditors.CalcEdit()
        Me.txt_unitcost = New DevExpress.XtraEditors.CalcEdit()
        Me.txt_vatamount = New DevExpress.XtraEditors.CalcEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem17 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem18 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem19 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem21 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
        Me.LayoutControlItem23 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem24 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem26 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem27 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem28 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem29 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem30 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem31 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem32 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.cmd_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.cmd_disapproved = New DevExpress.XtraEditors.SimpleButton()
        Me.cmd_save = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_whcode = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_path = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_vendor = New DevExpress.XtraEditors.LookUpEdit()
        Me.txt_TransCode = New DevExpress.XtraEditors.TextEdit()
        Me.txt_invenStat = New DevExpress.XtraEditors.TextEdit()
        Me.txt_notes = New DevExpress.XtraEditors.TextEdit()
        Me.txt_remarks = New DevExpress.XtraEditors.TextEdit()
        Me.txt_approver = New DevExpress.XtraEditors.TextEdit()
        Me.txt_refno = New DevExpress.XtraEditors.TextEdit()
        Me.txt_pono = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.VENDOR = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cmd_list = New DevExpress.XtraEditors.SimpleButton()
        Me.eventform = New DevExpress.XtraEditors.TextEdit()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.statuserror = New DevExpress.XtraEditors.TextEdit()
        CType(Me.receivedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.receivedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.GridList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DockItems.SuspendLayout()
        Me.DockPanel1_Container.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.txt_ModelLookup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_uniPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_LedSet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_BrCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SpecNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_vat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AccountNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_note.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_keynumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ChassisNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_EngineNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_color.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_descrip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_totcost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_unitcost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_vatamount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_whcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_path.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_vendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TransCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_invenStat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_approver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_refno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENDOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eventform.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statuserror.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'receivedDate
        '
        Me.receivedDate.Location = New System.Drawing.Point(541, 12)
        Me.receivedDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.receivedDate.Name = "receivedDate"
        Me.receivedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.receivedDate.Properties.Mask.BeepOnError = True
        Me.receivedDate.Size = New System.Drawing.Size(111, 22)
        Me.receivedDate.StyleController = Me.layoutControl
        Me.receivedDate.TabIndex = 3
        '
        'LayoutControl1
        '
        Me.LayoutControl.Controls.Add(Me.GridList)
        Me.LayoutControl.Controls.Add(Me.txt_whcode)
        Me.LayoutControl.Controls.Add(Me.txt_path)
        Me.LayoutControl.Controls.Add(Me.lbl_vendor)
        Me.LayoutControl.Controls.Add(Me.txt_TransCode)
        Me.LayoutControl.Controls.Add(Me.txt_invenStat)
        Me.LayoutControl.Controls.Add(Me.txt_notes)
        Me.LayoutControl.Controls.Add(Me.txt_remarks)
        Me.LayoutControl.Controls.Add(Me.txt_approver)
        Me.LayoutControl.Controls.Add(Me.txt_refno)
        Me.LayoutControl.Controls.Add(Me.txt_pono)
        Me.LayoutControl.Controls.Add(Me.receivedDate)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(610, 24)
        Me.LayoutControl.Name = "LayoutControl1"
        Me.LayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(716, 266, 650, 400)
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(664, 567)
        Me.LayoutControl.TabIndex = 96
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'GridList
        '
        Me.GridList.Location = New System.Drawing.Point(12, 152)
        Me.GridList.MainView = Me.gridView
        Me.GridList.MenuManager = Me.BarManager1
        Me.GridList.Name = "GridList"
        Me.GridList.Size = New System.Drawing.Size(640, 403)
        Me.GridList.TabIndex = 97
        Me.GridList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
        '
        'gridView
        '
        Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Code, Me.Model, Me.Description, Me.Color, Me.Brand, Me.EngineNo, Me.ChassisNo, Me.KeyNo, Me.UnitCost, Me.VATAmt, Me.TotalCost, Me.UnitPrice, Me.AccountName, Me.BrCodeAcct, Me.AccountNumber, Me.LedgerSet, Me.SpecificNotes})
        Me.gridView.gridControl = Me.GridList
        Me.gridView.Name = "gridView"
        '
        'Code
        '
        Me.Code.Caption = "Code"
        Me.Code.FieldName = "Code"
        Me.Code.Name = "Code"
        Me.Code.Visible = True
        Me.Code.VisibleIndex = 0
        '
        'Model
        '
        Me.Model.Caption = "Model"
        Me.Model.FieldName = "Model"
        Me.Model.Name = "Model"
        Me.Model.Visible = True
        Me.Model.VisibleIndex = 1
        '
        'Description
        '
        Me.Description.Caption = "Description"
        Me.Description.FieldName = "Description"
        Me.Description.Name = "Description"
        Me.Description.Visible = True
        Me.Description.VisibleIndex = 2
        '
        'Color
        '
        Me.Color.Caption = "Color"
        Me.Color.FieldName = "Color"
        Me.Color.Name = "Color"
        Me.Color.Visible = True
        Me.Color.VisibleIndex = 3
        '
        'Brand
        '
        Me.Brand.Caption = "Brand"
        Me.Brand.FieldName = "Brand"
        Me.Brand.Name = "Brand"
        Me.Brand.Visible = True
        Me.Brand.VisibleIndex = 4
        '
        'EngineNo
        '
        Me.EngineNo.Caption = "EngineNo"
        Me.EngineNo.FieldName = "EngineNo"
        Me.EngineNo.Name = "EngineNo"
        Me.EngineNo.Visible = True
        Me.EngineNo.VisibleIndex = 5
        '
        'ChassisNo
        '
        Me.ChassisNo.Caption = "ChassisNo"
        Me.ChassisNo.FieldName = "ChassisNo"
        Me.ChassisNo.Name = "ChassisNo"
        Me.ChassisNo.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ChassisNo", "{0}")})
        Me.ChassisNo.Visible = True
        Me.ChassisNo.VisibleIndex = 6
        '
        'KeyNo
        '
        Me.KeyNo.Caption = "KeyNo"
        Me.KeyNo.FieldName = "KeyNo"
        Me.KeyNo.Name = "KeyNo"
        Me.KeyNo.Visible = True
        Me.KeyNo.VisibleIndex = 7
        '
        'UnitCost
        '
        Me.UnitCost.Caption = "UnitCost"
        Me.UnitCost.FieldName = "UnitCost"
        Me.UnitCost.Name = "UnitCost"
        Me.UnitCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitCost", "{0:0.##}")})
        Me.UnitCost.Visible = True
        Me.UnitCost.VisibleIndex = 8
        '
        'VATAmt
        '
        Me.VATAmt.Caption = "VATAmt"
        Me.VATAmt.FieldName = "VATAmt"
        Me.VATAmt.Name = "VATAmt"
        Me.VATAmt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VATAmt", "{0:0.##}")})
        Me.VATAmt.Visible = True
        Me.VATAmt.VisibleIndex = 9
        '
        'TotalCost
        '
        Me.TotalCost.Caption = "TotalCost"
        Me.TotalCost.FieldName = "TotalCost"
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalCost", "{0:0.##}")})
        Me.TotalCost.Visible = True
        Me.TotalCost.VisibleIndex = 10
        '
        'UnitPrice
        '
        Me.UnitPrice.Caption = "UnitPrice"
        Me.UnitPrice.FieldName = "UnitPrice"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "UnitPrice", "{0:0.##}")})
        Me.UnitPrice.Visible = True
        Me.UnitPrice.VisibleIndex = 11
        '
        'AccountName
        '
        Me.AccountName.Caption = "AccountName"
        Me.AccountName.FieldName = "AccountName"
        Me.AccountName.Name = "AccountName"
        Me.AccountName.Visible = True
        Me.AccountName.VisibleIndex = 12
        '
        'BrCodeAcct
        '
        Me.BrCodeAcct.Caption = "BrCodeAcct"
        Me.BrCodeAcct.FieldName = "BrCodeAcct"
        Me.BrCodeAcct.Name = "BrCodeAcct"
        Me.BrCodeAcct.Visible = True
        Me.BrCodeAcct.VisibleIndex = 13
        '
        'AccountNumber
        '
        Me.AccountNumber.Caption = "AccountNumber"
        Me.AccountNumber.FieldName = "AccountNumber"
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Visible = True
        Me.AccountNumber.VisibleIndex = 14
        '
        'LedgerSet
        '
        Me.LedgerSet.Caption = "LedgerSet"
        Me.LedgerSet.FieldName = "LedgerSet"
        Me.LedgerSet.Name = "LedgerSet"
        Me.LedgerSet.Visible = True
        Me.LedgerSet.VisibleIndex = 15
        '
        'SpecificNotes
        '
        Me.SpecificNotes.Caption = "SpecificNotes"
        Me.SpecificNotes.FieldName = "SpecificNotes"
        Me.SpecificNotes.Name = "SpecificNotes"
        Me.SpecificNotes.Visible = True
        Me.SpecificNotes.VisibleIndex = 16
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Generate, Me.btn_BatchImport, Me.btn_Send})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.FloatLocation = New System.Drawing.Point(191, 128)
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Generate), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_BatchImport), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Send)})
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
        'btn_BatchImport
        '
        Me.btn_BatchImport.Caption = "Import"
        Me.btn_BatchImport.Id = 1
        Me.btn_BatchImport.Name = "btn_BatchImport"
        '
        'btn_Send
        '
        Me.btn_Send.Caption = "Send"
        Me.btn_Send.Id = 3
        Me.btn_Send.Name = "btn_Send"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1274, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 591)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1274, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 567)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1274, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 567)
        '
        'DockManager1
        '
        Me.DockManager1.Form = Me
        Me.DockManager1.MenuManager = Me.BarManager1
        Me.DockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockItems})
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
        '
        'DockItems
        '
        Me.DockItems.Appearance.BorderColor = System.Drawing.Color.Red
        Me.DockItems.Appearance.Options.UseBorderColor = True
        Me.DockItems.Controls.Add(Me.DockPanel1_Container)
        Me.DockItems.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
        Me.DockItems.FloatVertical = True
        Me.DockItems.ID = New System.Guid("258cbfc2-831e-4a2a-87c2-23e7887750b9")
        Me.DockItems.ImageOptions.Image = CType(resources.GetObject("DockItems.ImageOptions.Image"), System.Drawing.Image)
        Me.DockItems.Location = New System.Drawing.Point(0, 24)
        Me.DockItems.Name = "DockItems"
        Me.DockItems.OriginalSize = New System.Drawing.Size(610, 335)
        Me.DockItems.Size = New System.Drawing.Size(610, 567)
        Me.DockItems.Text = "Items"
        '
        'DockPanel1_Container
        '
        Me.DockPanel1_Container.Controls.Add(Me.LayoutControl2)
        Me.DockPanel1_Container.Controls.Add(Me.cmd_approved)
        Me.DockPanel1_Container.Controls.Add(Me.cmd_disapproved)
        Me.DockPanel1_Container.Controls.Add(Me.cmd_save)
        Me.DockPanel1_Container.Location = New System.Drawing.Point(4, 25)
        Me.DockPanel1_Container.Name = "DockPanel1_Container"
        Me.DockPanel1_Container.Size = New System.Drawing.Size(601, 538)
        Me.DockPanel1_Container.TabIndex = 0
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.txt_ModelLookup)
        Me.LayoutControl2.Controls.Add(Me.txt_uniPrice)
        Me.LayoutControl2.Controls.Add(Me.txt_LedSet)
        Me.LayoutControl2.Controls.Add(Me.txt_BrCode)
        Me.LayoutControl2.Controls.Add(Me.txt_SpecNotes)
        Me.LayoutControl2.Controls.Add(Me.num_vat)
        Me.LayoutControl2.Controls.Add(Me.txt_AccountNumber)
        Me.LayoutControl2.Controls.Add(Me.txt_note)
        Me.LayoutControl2.Controls.Add(Me.txt_keynumber)
        Me.LayoutControl2.Controls.Add(Me.txt_ChassisNo)
        Me.LayoutControl2.Controls.Add(Me.txt_EngineNo)
        Me.LayoutControl2.Controls.Add(Me.txt_color)
        Me.LayoutControl2.Controls.Add(Me.txt_descrip)
        Me.LayoutControl2.Controls.Add(Me.Frmbtn_Export_to_Grid)
        Me.LayoutControl2.Controls.Add(Me.btn_Account)
        Me.LayoutControl2.Controls.Add(Me.txt_brand)
        Me.LayoutControl2.Controls.Add(Me.txt_totcost)
        Me.LayoutControl2.Controls.Add(Me.txt_unitcost)
        Me.LayoutControl2.Controls.Add(Me.txt_vatamount)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(589, 109, 650, 400)
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(601, 538)
        Me.LayoutControl2.TabIndex = 102
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'txt_ModelLookup
        '
        Me.txt_ModelLookup.Location = New System.Drawing.Point(105, 38)
        Me.txt_ModelLookup.MenuManager = Me.BarManager1
        Me.txt_ModelLookup.Name = "txt_ModelLookup"
        Me.txt_ModelLookup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_ModelLookup.Properties.NullText = "[Select dropdown list]"
        Me.txt_ModelLookup.Size = New System.Drawing.Size(266, 22)
        Me.txt_ModelLookup.StyleController = Me.LayoutControl2
        Me.txt_ModelLookup.TabIndex = 55
        '
        'txt_uniPrice
        '
        Me.txt_uniPrice.EditValue = "0.00"
        Me.txt_uniPrice.Location = New System.Drawing.Point(468, 116)
        Me.txt_uniPrice.Name = "txt_uniPrice"
        Me.txt_uniPrice.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_uniPrice.Properties.Appearance.Options.UseFont = True
        Me.txt_uniPrice.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_uniPrice.Properties.Mask.BeepOnError = True
        Me.txt_uniPrice.Properties.Mask.EditMask = "f"
        Me.txt_uniPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_uniPrice.Size = New System.Drawing.Size(121, 30)
        Me.txt_uniPrice.StyleController = Me.LayoutControl2
        Me.txt_uniPrice.TabIndex = 4
        '
        'txt_LedSet
        '
        Me.txt_LedSet.Enabled = False
        Me.txt_LedSet.Location = New System.Drawing.Point(495, 226)
        Me.txt_LedSet.Name = "txt_LedSet"
        Me.txt_LedSet.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LedSet.Properties.Appearance.Options.UseFont = True
        Me.txt_LedSet.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_LedSet.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_LedSet.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_LedSet.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_LedSet.Size = New System.Drawing.Size(94, 22)
        Me.txt_LedSet.StyleController = Me.LayoutControl2
        Me.txt_LedSet.TabIndex = 48
        '
        'txt_BrCode
        '
        Me.txt_BrCode.Enabled = False
        Me.txt_BrCode.Location = New System.Drawing.Point(105, 226)
        Me.txt_BrCode.Name = "txt_BrCode"
        Me.txt_BrCode.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BrCode.Properties.Appearance.Options.UseFont = True
        Me.txt_BrCode.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_BrCode.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_BrCode.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_BrCode.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_BrCode.Size = New System.Drawing.Size(127, 22)
        Me.txt_BrCode.StyleController = Me.LayoutControl2
        Me.txt_BrCode.TabIndex = 49
        '
        'txt_SpecNotes
        '
        Me.txt_SpecNotes.EditValue = "No particular notes"
        Me.txt_SpecNotes.Location = New System.Drawing.Point(105, 252)
        Me.txt_SpecNotes.Name = "txt_SpecNotes"
        Me.txt_SpecNotes.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SpecNotes.Properties.Appearance.Options.UseFont = True
        Me.txt_SpecNotes.Size = New System.Drawing.Size(484, 248)
        Me.txt_SpecNotes.StyleController = Me.LayoutControl2
        Me.txt_SpecNotes.TabIndex = 50
        '
        'num_vat
        '
        Me.num_vat.EditValue = New Decimal(New Integer() {12, 0, 0, 0})
        Me.num_vat.Location = New System.Drawing.Point(468, 38)
        Me.num_vat.Name = "num_vat"
        Me.num_vat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.num_vat.Size = New System.Drawing.Size(121, 22)
        Me.num_vat.StyleController = Me.LayoutControl2
        Me.num_vat.TabIndex = 52
        '
        'txt_AccountNumber
        '
        Me.txt_AccountNumber.Enabled = False
        Me.txt_AccountNumber.Location = New System.Drawing.Point(244, 226)
        Me.txt_AccountNumber.Name = "txt_AccountNumber"
        Me.txt_AccountNumber.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AccountNumber.Properties.Appearance.Options.UseFont = True
        Me.txt_AccountNumber.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_AccountNumber.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_AccountNumber.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_AccountNumber.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_AccountNumber.Size = New System.Drawing.Size(239, 22)
        Me.txt_AccountNumber.StyleController = Me.LayoutControl2
        Me.txt_AccountNumber.TabIndex = 47
        '
        'txt_note
        '
        Me.txt_note.Enabled = False
        Me.txt_note.Location = New System.Drawing.Point(105, 200)
        Me.txt_note.Name = "txt_note"
        Me.txt_note.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_note.Properties.Appearance.Options.UseFont = True
        Me.txt_note.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_note.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_note.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_note.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_note.Size = New System.Drawing.Size(331, 22)
        Me.txt_note.StyleController = Me.LayoutControl2
        Me.txt_note.TabIndex = 44
        '
        'txt_keynumber
        '
        Me.txt_keynumber.Location = New System.Drawing.Point(105, 116)
        Me.txt_keynumber.Name = "txt_keynumber"
        Me.txt_keynumber.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_keynumber.Properties.Appearance.Options.UseFont = True
        Me.txt_keynumber.Size = New System.Drawing.Size(266, 22)
        Me.txt_keynumber.StyleController = Me.LayoutControl2
        Me.txt_keynumber.TabIndex = 0
        '
        'txt_ChassisNo
        '
        Me.txt_ChassisNo.EditValue = ""
        Me.txt_ChassisNo.Location = New System.Drawing.Point(105, 168)
        Me.txt_ChassisNo.Name = "txt_ChassisNo"
        Me.txt_ChassisNo.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ChassisNo.Properties.Appearance.Options.UseFont = True
        Me.txt_ChassisNo.Size = New System.Drawing.Size(266, 22)
        Me.txt_ChassisNo.StyleController = Me.LayoutControl2
        Me.txt_ChassisNo.TabIndex = 2
        '
        'txt_EngineNo
        '
        Me.txt_EngineNo.Location = New System.Drawing.Point(105, 142)
        Me.txt_EngineNo.Name = "txt_EngineNo"
        Me.txt_EngineNo.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EngineNo.Properties.Appearance.Options.UseFont = True
        Me.txt_EngineNo.Size = New System.Drawing.Size(266, 22)
        Me.txt_EngineNo.StyleController = Me.LayoutControl2
        Me.txt_EngineNo.TabIndex = 1
        '
        'txt_color
        '
        Me.txt_color.Location = New System.Drawing.Point(105, 64)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_color.Properties.Appearance.Options.UseFont = True
        Me.txt_color.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_color.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_color.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_color.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_color.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_color.Properties.NullText = "[Select dropdown list]"
        Me.txt_color.Size = New System.Drawing.Size(266, 22)
        Me.txt_color.StyleController = Me.LayoutControl2
        Me.txt_color.TabIndex = 35
        '
        'txt_descrip
        '
        Me.txt_descrip.Enabled = False
        Me.txt_descrip.Location = New System.Drawing.Point(105, 90)
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descrip.Properties.Appearance.Options.UseFont = True
        Me.txt_descrip.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_descrip.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_descrip.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_descrip.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_descrip.Size = New System.Drawing.Size(266, 22)
        Me.txt_descrip.StyleController = Me.LayoutControl2
        Me.txt_descrip.TabIndex = 39
        '
        'Frmbtn_Export_to_Grid
        '
        Me.Frmbtn_Export_to_Grid.Appearance.BackColor = System.Drawing.Color.Red
        Me.Frmbtn_Export_to_Grid.Appearance.Options.UseBackColor = True
        Me.Frmbtn_Export_to_Grid.Appearance.Options.UseImage = True
        Me.Frmbtn_Export_to_Grid.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.Frmbtn_Export_to_Grid.Location = New System.Drawing.Point(12, 504)
        Me.Frmbtn_Export_to_Grid.Name = "Frmbtn_Export_to_Grid"
        Me.Frmbtn_Export_to_Grid.Size = New System.Drawing.Size(577, 22)
        Me.Frmbtn_Export_to_Grid.StyleController = Me.LayoutControl2
        Me.Frmbtn_Export_to_Grid.TabIndex = 53
        Me.Frmbtn_Export_to_GrID.text = "Export to Grid"
        '
        'btn_Account
        '
        Me.btn_Account.Location = New System.Drawing.Point(440, 200)
        Me.btn_Account.Name = "btn_Account"
        Me.btn_Account.Size = New System.Drawing.Size(149, 22)
        Me.btn_Account.StyleController = Me.LayoutControl2
        Me.btn_Account.TabIndex = 54
        Me.btn_Account.Text = "FIND"
        '
        'txt_brand
        '
        Me.txt_brand.Location = New System.Drawing.Point(105, 12)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Properties.Appearance.Options.UseFont = True
        Me.txt_brand.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txt_brand.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txt_brand.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txt_brand.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txt_brand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_brand.Properties.NullText = "[Select dropdown list]"
        Me.txt_brand.Size = New System.Drawing.Size(266, 22)
        Me.txt_brand.StyleController = Me.LayoutControl2
        Me.txt_brand.TabIndex = 28
        '
        'txt_totcost
        '
        Me.txt_totcost.EditValue = "0.00"
        Me.txt_totcost.Location = New System.Drawing.Point(468, 90)
        Me.txt_totcost.Name = "txt_totcost"
        Me.txt_totcost.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_totcost.Properties.Appearance.Options.UseFont = True
        Me.txt_totcost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_totcost.Properties.Mask.BeepOnError = True
        Me.txt_totcost.Properties.Mask.EditMask = "f"
        Me.txt_totcost.Properties.ReadOnly = True
        Me.txt_totcost.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_totcost.Size = New System.Drawing.Size(121, 22)
        Me.txt_totcost.StyleController = Me.LayoutControl2
        Me.txt_totcost.TabIndex = 30
        '
        'txt_unitcost
        '
        Me.txt_unitcost.EditValue = "0.00"
        Me.txt_unitcost.Location = New System.Drawing.Point(468, 12)
        Me.txt_unitcost.Name = "txt_unitcost"
        Me.txt_unitcost.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_unitcost.Properties.Appearance.Options.UseFont = True
        Me.txt_unitcost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_unitcost.Properties.Mask.BeepOnError = True
        Me.txt_unitcost.Properties.Mask.EditMask = "f"
        Me.txt_unitcost.Size = New System.Drawing.Size(121, 22)
        Me.txt_unitcost.StyleController = Me.LayoutControl2
        Me.txt_unitcost.TabIndex = 3
        '
        'txt_vatamount
        '
        Me.txt_vatamount.EditValue = "0"
        Me.txt_vatamount.Location = New System.Drawing.Point(468, 64)
        Me.txt_vatamount.Name = "txt_vatamount"
        Me.txt_vatamount.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vatamount.Properties.Appearance.Options.UseFont = True
        Me.txt_vatamount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_vatamount.Properties.Mask.BeepOnError = True
        Me.txt_vatamount.Properties.Mask.EditMask = "f"
        Me.txt_vatamount.Properties.ReadOnly = True
        Me.txt_vatamount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txt_vatamount.Size = New System.Drawing.Size(121, 22)
        Me.txt_vatamount.StyleController = Me.LayoutControl2
        Me.txt_vatamount.TabIndex = 27
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem13, Me.LayoutControlItem14, Me.LayoutControlItem16, Me.LayoutControlItem17, Me.LayoutControlItem18, Me.LayoutControlItem19, Me.LayoutControlItem20, Me.LayoutControlItem21, Me.LayoutControlItem22, Me.SplitterItem1, Me.LayoutControlItem23, Me.LayoutControlItem24, Me.LayoutControlItem25, Me.LayoutControlItem26, Me.LayoutControlItem27, Me.LayoutControlItem28, Me.LayoutControlItem29, Me.LayoutControlItem30, Me.LayoutControlItem31, Me.LayoutControlItem32, Me.EmptySpaceItem2})
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(601, 538)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txt_descrip
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem13.Name = "LayoutControlItem2"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(363, 26)
        Me.LayoutControlItem13.Text = "Description"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.txt_brand
        Me.LayoutControlItem14.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem3"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(363, 26)
        Me.LayoutControlItem14.Text = "Brand"
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.txt_color
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem16.Name = "LayoutControlItem5"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(363, 26)
        Me.LayoutControlItem16.Text = "Color"
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem17
        '
        Me.LayoutControlItem17.Control = Me.txt_keynumber
        Me.LayoutControlItem17.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem17.Name = "LayoutControlItem6"
        Me.LayoutControlItem17.Size = New System.Drawing.Size(363, 26)
        Me.LayoutControlItem17.Text = "Key Number"
        Me.LayoutControlItem17.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem18
        '
        Me.LayoutControlItem18.Control = Me.num_vat
        Me.LayoutControlItem18.Location = New System.Drawing.Point(363, 26)
        Me.LayoutControlItem18.MinSize = New System.Drawing.Size(147, 26)
        Me.LayoutControlItem18.Name = "LayoutControlItem10"
        Me.LayoutControlItem18.Size = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem18.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem18.Text = "VAT Pctg"
        Me.LayoutControlItem18.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem19
        '
        Me.LayoutControlItem19.Control = Me.txt_unitcost
        Me.LayoutControlItem19.Location = New System.Drawing.Point(363, 0)
        Me.LayoutControlItem19.MinSize = New System.Drawing.Size(50, 25)
        Me.LayoutControlItem19.Name = "LayoutControlItem9"
        Me.LayoutControlItem19.Size = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem19.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem19.Text = "Unit Cost"
        Me.LayoutControlItem19.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.txt_vatamount
        Me.LayoutControlItem20.Location = New System.Drawing.Point(363, 52)
        Me.LayoutControlItem20.Name = "LayoutControlItem11"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem20.Text = "VAT Amt"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem21
        '
        Me.LayoutControlItem21.Control = Me.txt_totcost
        Me.LayoutControlItem21.Location = New System.Drawing.Point(363, 78)
        Me.LayoutControlItem21.MinSize = New System.Drawing.Size(50, 25)
        Me.LayoutControlItem21.Name = "LayoutControlItem12"
        Me.LayoutControlItem21.Size = New System.Drawing.Size(218, 26)
        Me.LayoutControlItem21.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem21.Text = "Total Cost"
        Me.LayoutControlItem21.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.txt_uniPrice
        Me.LayoutControlItem22.Location = New System.Drawing.Point(363, 104)
        Me.LayoutControlItem22.Name = "LayoutControlItem13"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(218, 34)
        Me.LayoutControlItem22.Text = "Unit Price"
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(90, 15)
        '
        'SplitterItem1
        '
        Me.SplitterItem1.AllowHotTrack = True
        Me.SplitterItem1.Location = New System.Drawing.Point(0, 182)
        Me.SplitterItem1.Name = "SplitterItem1"
        Me.SplitterItem1.Size = New System.Drawing.Size(581, 6)
        '
        'LayoutControlItem23
        '
        Me.LayoutControlItem23.Control = Me.txt_note
        Me.LayoutControlItem23.Location = New System.Drawing.Point(0, 188)
        Me.LayoutControlItem23.Name = "LayoutControlItem14"
        Me.LayoutControlItem23.Size = New System.Drawing.Size(428, 26)
        Me.LayoutControlItem23.Text = "Customer Name"
        Me.LayoutControlItem23.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem24
        '
        Me.LayoutControlItem24.Control = Me.txt_EngineNo
        Me.LayoutControlItem24.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem24.Name = "LayoutControlItem7"
        Me.LayoutControlItem24.Size = New System.Drawing.Size(363, 26)
        Me.LayoutControlItem24.Text = "Engine Number"
        Me.LayoutControlItem24.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.txt_ChassisNo
        Me.LayoutControlItem25.Location = New System.Drawing.Point(0, 156)
        Me.LayoutControlItem25.Name = "LayoutControlItem8"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(363, 26)
        Me.LayoutControlItem25.Text = "Chassis Number"
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem26
        '
        Me.LayoutControlItem26.Control = Me.txt_BrCode
        Me.LayoutControlItem26.Location = New System.Drawing.Point(0, 214)
        Me.LayoutControlItem26.Name = "LayoutControlItem15"
        Me.LayoutControlItem26.Size = New System.Drawing.Size(224, 26)
        Me.LayoutControlItem26.Text = "Account Number"
        Me.LayoutControlItem26.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem27
        '
        Me.LayoutControlItem27.Control = Me.txt_LedSet
        Me.LayoutControlItem27.Location = New System.Drawing.Point(475, 214)
        Me.LayoutControlItem27.Name = "LayoutControlItem17"
        Me.LayoutControlItem27.Size = New System.Drawing.Size(106, 26)
        Me.LayoutControlItem27.Text = " "
        Me.LayoutControlItem27.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem27.TextSize = New System.Drawing.Size(3, 15)
        Me.LayoutControlItem27.TextToControlDistance = 5
        '
        'LayoutControlItem28
        '
        Me.LayoutControlItem28.Control = Me.txt_AccountNumber
        Me.LayoutControlItem28.Location = New System.Drawing.Point(224, 214)
        Me.LayoutControlItem28.MinSize = New System.Drawing.Size(173, 26)
        Me.LayoutControlItem28.Name = "LayoutControlItem16"
        Me.LayoutControlItem28.Size = New System.Drawing.Size(251, 26)
        Me.LayoutControlItem28.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem28.Text = " "
        Me.LayoutControlItem28.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LayoutControlItem28.TextSize = New System.Drawing.Size(3, 15)
        Me.LayoutControlItem28.TextToControlDistance = 5
        '
        'LayoutControlItem29
        '
        Me.LayoutControlItem29.Control = Me.txt_SpecNotes
        Me.LayoutControlItem29.Location = New System.Drawing.Point(0, 240)
        Me.LayoutControlItem29.Name = "LayoutControlItem18"
        Me.LayoutControlItem29.Size = New System.Drawing.Size(581, 252)
        Me.LayoutControlItem29.Text = "Specific Notes"
        Me.LayoutControlItem29.TextSize = New System.Drawing.Size(90, 15)
        '
        'LayoutControlItem30
        '
        Me.LayoutControlItem30.Control = Me.Frmbtn_Export_to_Grid
        Me.LayoutControlItem30.Location = New System.Drawing.Point(0, 492)
        Me.LayoutControlItem30.Name = "LayoutControlItem30"
        Me.LayoutControlItem30.Size = New System.Drawing.Size(581, 26)
        Me.LayoutControlItem30.Text = "Link to Grid"
        Me.LayoutControlItem30.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem30.TextVisible = False
        '
        'LayoutControlItem31
        '
        Me.LayoutControlItem31.Control = Me.btn_Account
        Me.LayoutControlItem31.Location = New System.Drawing.Point(428, 188)
        Me.LayoutControlItem31.Name = "LayoutControlItem31"
        Me.LayoutControlItem31.Size = New System.Drawing.Size(153, 26)
        Me.LayoutControlItem31.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem31.TextVisible = False
        '
        'LayoutControlItem32
        '
        Me.LayoutControlItem32.Control = Me.txt_ModelLookup
        Me.LayoutControlItem32.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem32.Name = "LayoutControlItem32"
        Me.LayoutControlItem32.Size = New System.Drawing.Size(363, 26)
        Me.LayoutControlItem32.Text = "Model"
        Me.LayoutControlItem32.TextSize = New System.Drawing.Size(90, 15)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(363, 138)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(218, 44)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'cmd_approved
        '
        Me.cmd_approved.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.cmd_approved.Appearance.Options.UseForeColor = True
        Me.cmd_approved.AutoSize = True
        Me.cmd_approved.BackgroundImage = CType(resources.GetObject("cmd_approved.BackgroundImage"), System.Drawing.Image)
        Me.cmd_approved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_approved.Location = New System.Drawing.Point(155, 433)
        Me.cmd_approved.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.cmd_approved.Name = "cmd_approved"
        Me.cmd_approved.Size = New System.Drawing.Size(16, 20)
        Me.cmd_approved.TabIndex = 81
        Me.ToolTip1.SetToolTip(Me.cmd_approved, "Approved Transaction")
        Me.cmd_approved.Visible = False
        '
        'cmd_disapproved
        '
        Me.cmd_disapproved.AutoSize = True
        Me.cmd_disapproved.BackgroundImage = CType(resources.GetObject("cmd_disapproved.BackgroundImage"), System.Drawing.Image)
        Me.cmd_disapproved.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_disapproved.Location = New System.Drawing.Point(224, 433)
        Me.cmd_disapproved.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.cmd_disapproved.Name = "cmd_disapproved"
        Me.cmd_disapproved.Size = New System.Drawing.Size(16, 20)
        Me.cmd_disapproved.TabIndex = 80
        Me.ToolTip1.SetToolTip(Me.cmd_disapproved, "Disapproved Transaction")
        Me.cmd_disapproved.Visible = False
        '
        'cmd_save
        '
        Me.cmd_save.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.cmd_save.Appearance.Options.UseForeColor = True
        Me.cmd_save.AutoSize = True
        Me.cmd_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmd_save.ImageOptions.Image = CType(resources.GetObject("cmd_save.ImageOptions.Image"), System.Drawing.Image)
        Me.cmd_save.Location = New System.Drawing.Point(20, 20)
        Me.cmd_save.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd_save.Name = "cmd_save"
        Me.cmd_save.Size = New System.Drawing.Size(87, 22)
        Me.cmd_save.TabIndex = 62
        Me.cmd_save.Text = "  &SEND"
        Me.ToolTip1.SetToolTip(Me.cmd_save, "Send form ForApproval!")
        '
        'txt_whcode
        '
        Me.txt_whcode.Location = New System.Drawing.Point(541, 38)
        Me.txt_whcode.Name = "txt_whcode"
        Me.txt_whcode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_whcode.Size = New System.Drawing.Size(111, 22)
        Me.txt_whcode.StyleController = Me.layoutControl
        Me.txt_whcode.TabIndex = 91
        '
        'txt_path
        '
        Me.txt_path.Location = New System.Drawing.Point(541, 64)
        Me.txt_path.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(111, 22)
        Me.txt_path.StyleController = Me.layoutControl
        Me.txt_path.TabIndex = 87
        '
        'lbl_vendor
        '
        Me.lbl_vendor.Location = New System.Drawing.Point(111, 12)
        Me.lbl_vendor.Name = "lbl_vendor"
        Me.lbl_vendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lbl_vendor.Size = New System.Drawing.Size(112, 22)
        Me.lbl_vendor.StyleController = Me.layoutControl
        Me.lbl_vendor.TabIndex = 90
        '
        'txt_TransCode
        '
        Me.txt_TransCode.Enabled = False
        Me.txt_TransCode.Location = New System.Drawing.Point(326, 12)
        Me.txt_TransCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_TransCode.Name = "txt_TransCode"
        Me.txt_TransCode.Size = New System.Drawing.Size(112, 22)
        Me.txt_TransCode.StyleController = Me.layoutControl
        Me.txt_TransCode.TabIndex = 11
        '
        'txt_invenStat
        '
        Me.txt_invenStat.EditValue = "For Approval"
        Me.txt_invenStat.Location = New System.Drawing.Point(111, 38)
        Me.txt_invenStat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_invenStat.Name = "txt_invenStat"
        Me.txt_invenStat.Properties.ReadOnly = True
        Me.txt_invenStat.Size = New System.Drawing.Size(112, 22)
        Me.txt_invenStat.StyleController = Me.layoutControl
        Me.txt_invenStat.TabIndex = 13
        '
        'txt_notes
        '
        Me.txt_notes.Location = New System.Drawing.Point(111, 90)
        Me.txt_notes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Size = New System.Drawing.Size(327, 22)
        Me.txt_notes.StyleController = Me.layoutControl
        Me.txt_notes.TabIndex = 84
        '
        'txt_remarks
        '
        Me.txt_remarks.Location = New System.Drawing.Point(111, 116)
        Me.txt_remarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(327, 22)
        Me.txt_remarks.StyleController = Me.layoutControl
        Me.txt_remarks.TabIndex = 82
        '
        'txt_approver
        '
        Me.txt_approver.Location = New System.Drawing.Point(326, 38)
        Me.txt_approver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_approver.Name = "txt_approver"
        Me.txt_approver.Properties.ReadOnly = True
        Me.txt_approver.Size = New System.Drawing.Size(112, 22)
        Me.txt_approver.StyleController = Me.layoutControl
        Me.txt_approver.TabIndex = 47
        '
        'txt_refno
        '
        Me.txt_refno.Location = New System.Drawing.Point(111, 64)
        Me.txt_refno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_refno.Name = "txt_refno"
        Me.txt_refno.Size = New System.Drawing.Size(112, 22)
        Me.txt_refno.StyleController = Me.layoutControl
        Me.txt_refno.TabIndex = 7
        '
        'txt_pono
        '
        Me.txt_pono.Location = New System.Drawing.Point(326, 64)
        Me.txt_pono.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_pono.Name = "txt_pono"
        Me.txt_pono.Size = New System.Drawing.Size(112, 22)
        Me.txt_pono.StyleController = Me.layoutControl
        Me.txt_pono.TabIndex = 9
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.VENDOR, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.EmptySpaceItem1, Me.LayoutControlItem11})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(664, 567)
        Me.Root.TextVisible = False
        '
        'VENDOR
        '
        Me.VENDOR.Control = Me.lbl_vendor
        Me.VENDOR.Location = New System.Drawing.Point(0, 0)
        Me.VENDOR.Name = "VENDOR"
        Me.VENDOR.Size = New System.Drawing.Size(215, 26)
        Me.VENDOR.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txt_TransCode
        Me.LayoutControlItem1.Location = New System.Drawing.Point(215, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(215, 26)
        Me.LayoutControlItem1.Text = "TransCode"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txt_invenStat
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 26)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(215, 26)
        Me.LayoutControlItem2.Text = "Status"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txt_approver
        Me.LayoutControlItem3.Location = New System.Drawing.Point(215, 26)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(215, 26)
        Me.LayoutControlItem3.Text = "Approver"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txt_refno
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 52)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(215, 26)
        Me.LayoutControlItem4.Text = "ReferenceNumber"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txt_pono
        Me.LayoutControlItem5.Location = New System.Drawing.Point(215, 52)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(215, 26)
        Me.LayoutControlItem5.Text = "PONumber"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txt_notes
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 78)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(430, 26)
        Me.LayoutControlItem6.Text = "Note"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txt_remarks
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 104)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(430, 26)
        Me.LayoutControlItem7.Text = "Remarks"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.receivedDate
        Me.LayoutControlItem8.Location = New System.Drawing.Point(430, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(214, 26)
        Me.LayoutControlItem8.Text = "Posting Date"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txt_whcode
        Me.LayoutControlItem9.Location = New System.Drawing.Point(430, 26)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(214, 26)
        Me.LayoutControlItem9.Text = "Warehouse"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(96, 15)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txt_path
        Me.LayoutControlItem10.Location = New System.Drawing.Point(430, 52)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(214, 88)
        Me.LayoutControlItem10.Text = "Path"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(96, 15)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 130)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(430, 10)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.GridList
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 140)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(644, 407)
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'cmd_list
        '
        Me.cmd_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_list.ImageOptions.Image = CType(resources.GetObject("cmd_list.ImageOptions.Image"), System.Drawing.Image)
        Me.cmd_list.Location = New System.Drawing.Point(1170, 371)
        Me.cmd_list.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd_list.Name = "cmd_list"
        Me.cmd_list.Size = New System.Drawing.Size(105, 54)
        Me.cmd_list.TabIndex = 49
        Me.cmd_list.Text = " &LIST"
        Me.cmd_list.Visible = False
        '
        'eventform
        '
        Me.eventform.EditValue = "eventform"
        Me.eventform.Location = New System.Drawing.Point(1104, 280)
        Me.eventform.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.eventform.Name = "eventform"
        Me.eventform.Size = New System.Drawing.Size(186, 22)
        Me.eventform.TabIndex = 60
        Me.eventform.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Integrated Core Systems"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'statuserror
        '
        Me.statuserror.EditValue = "statuserror1"
        Me.statuserror.Location = New System.Drawing.Point(579, 152)
        Me.statuserror.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.statuserror.Name = "statuserror"
        Me.statuserror.Size = New System.Drawing.Size(328, 22)
        Me.statuserror.TabIndex = 89
        Me.statuserror.Visible = False
        '
        'IS_Inventory_Receiving
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 591)
        Me.Controls.Add(Me.statuserror)
        Me.Controls.Add(Me.layoutControl)
        Me.Controls.Add(Me.eventform)
        Me.Controls.Add(Me.cmd_list)
        Me.Controls.Add(Me.DockItems)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("IS_Inventory_Receiving.IconOptions.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "IS_Inventory_Receiving"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTORY - RECEIVING"
        CType(Me.receivedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.receivedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.GridList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DockItems.ResumeLayout(False)
        Me.DockPanel1_Container.ResumeLayout(False)
        Me.DockPanel1_Container.PerformLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.txt_ModelLookup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_uniPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_LedSet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_BrCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SpecNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_vat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AccountNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_note.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_keynumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ChassisNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_EngineNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_color.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_descrip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_totcost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_unitcost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_vatamount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_whcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_path.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_vendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TransCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_invenStat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_approver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_refno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENDOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eventform.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statuserror.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents receivedDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_refno As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_pono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_TransCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_invenStat As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_approver As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmd_list As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eventform As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmd_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmd_approved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmd_disapproved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_remarks As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_notes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_path As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents statuserror As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_vendor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_whcode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents VENDOR As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btn_Generate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_BatchImport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridList As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents DockItems As DevExpress.XtraBars.Docking.DockPanel
    Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txt_uniPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_LedSet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_BrCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_SpecNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents num_vat As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_AccountNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_note As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_keynumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ChassisNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_EngineNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_color As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_descrip As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem17 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem18 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem19 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem21 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    Friend WithEvents LayoutControlItem23 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem24 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem26 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem27 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem28 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem29 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Frmbtn_Export_to_Grid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem30 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btn_Account As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem31 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txt_ModelLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_brand As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LayoutControlItem32 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btn_Send As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txt_totcost As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents txt_unitcost As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txt_vatamount As DevExpress.XtraEditors.CalcEdit
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
    Friend WithEvents BrCodeAcct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LedgerSet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpecificNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AccountName As DevExpress.XtraGrid.Columns.GridColumn
End Class
