Namespace Controls.Logistics
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_MC_Transaction_Units
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xuc_MC_Transaction_Units))
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIfExist = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colEngine = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Engine = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colChassis = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Chassis = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colRemarks = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colKeyNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInclusions = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemTokenEdit_Inclusions = New DevExpress.XtraEditors.Repository.RepositoryItemTokenEdit()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFreight_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemCalcEdit_Unit_Item_Cost = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.colVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemCalcEdit_Unit_Item_Total_Cost = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.colTransacted_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUpdated_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUpdated_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Model_Code = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview_Units = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview_Unit_Costing = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Add_To_PO = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New_Unit_Model = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar1 = New DevExpress.XtraBars.Bar()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Engine, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Chassis, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemTokenEdit_Inclusions, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_Unit_Item_Cost, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_Unit_Item_Total_Cost, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Model_Code, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTokenEdit_Inclusions, Me.RepositoryItemCalcEdit_Unit_Item_Cost, Me.RepositoryItemLookUpEdit_Engine, Me.RepositoryItemCalcEdit_Unit_Item_Total_Cost, Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemLookUpEdit_Chassis, Me.RepositoryItemLookUpEdit_Model_Code})
            Me.gridControl.Size = New System.Drawing.Size(313, 332)
            Me.gridControl.TabIndex = 16
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsJournal, Me.colIfExist, Me.colStatus, Me.colBranch_Code, Me.colEngine, Me.colChassis, Me.colRemarks, Me.colModel_Code, Me.colBrand, Me.colModel, Me.colColor, Me.colDescription, Me.colKeyNumber, Me.colInclusions, Me.colNotes, Me.colFreight_Cost, Me.colUnit_Cost, Me.colVAT, Me.colTotal_Cost, Me.colTransacted_By, Me.colAdded_Date, Me.colUpdated_By, Me.colUpdated_Date})
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.OptionsColumn.AllowEdit = False
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colIsJournal
            '
            Me.colIsJournal.Caption = "Journal"
            Me.colIsJournal.FieldName = "IsJournal"
            Me.colIsJournal.Name = "colIsJournal"
            Me.colIsJournal.OptionsColumn.AllowEdit = False
            Me.colIsJournal.Visible = True
            Me.colIsJournal.VisibleIndex = 1
            '
            'colIfExist
            '
            Me.colIfExist.FieldName = "IfExist"
            Me.colIfExist.Name = "colIfExist"
            Me.colIfExist.OptionsColumn.AllowEdit = False
            Me.colIfExist.Visible = True
            Me.colIfExist.VisibleIndex = 2
            '
            'colStatus
            '
            Me.colStatus.Caption = "Status"
            Me.colStatus.FieldName = "InventoryStatus"
            Me.colStatus.Name = "colStatus"
            Me.colStatus.OptionsColumn.AllowEdit = False
            Me.colStatus.Visible = True
            Me.colStatus.VisibleIndex = 3
            '
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch"
            Me.colBranch_Code.ColumnEdit = Me.RepositoryItemLookUpEdit_Branch
            Me.colBranch_Code.FieldName = "BranchCode"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 4
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'colEngine
            '
            Me.colEngine.Caption = "Engine"
            Me.colEngine.ColumnEdit = Me.RepositoryItemLookUpEdit_Engine
            Me.colEngine.FieldName = "EngineNo"
            Me.colEngine.Name = "colEngine"
            Me.colEngine.Visible = True
            Me.colEngine.VisibleIndex = 5
            '
            'RepositoryItemLookUpEdit_Engine
            '
            Me.RepositoryItemLookUpEdit_Engine.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Engine.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Engine.Name = "RepositoryItemLookUpEdit_Engine"
            '
            'colChassis
            '
            Me.colChassis.Caption = "Chassis"
            Me.colChassis.ColumnEdit = Me.RepositoryItemLookUpEdit_Chassis
            Me.colChassis.FieldName = "ChassisNo"
            Me.colChassis.Name = "colChassis"
            Me.colChassis.Visible = True
            Me.colChassis.VisibleIndex = 6
            '
            'RepositoryItemLookUpEdit_Chassis
            '
            Me.RepositoryItemLookUpEdit_Chassis.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Chassis.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Chassis.Name = "RepositoryItemLookUpEdit_Chassis"
            '
            'colRemarks
            '
            Me.colRemarks.FieldName = "Remarks"
            Me.colRemarks.Name = "colRemarks"
            Me.colRemarks.Visible = True
            Me.colRemarks.VisibleIndex = 7
            '
            'colModel_Code
            '
            Me.colModel_Code.FieldName = "Model_Code"
            Me.colModel_Code.Name = "colModel_Code"
            Me.colModel_Code.Visible = True
            Me.colModel_Code.VisibleIndex = 8
            '
            'colBrand
            '
            Me.colBrand.FieldName = "Brand"
            Me.colBrand.Name = "colBrand"
            Me.colBrand.OptionsColumn.AllowEdit = False
            Me.colBrand.Visible = True
            Me.colBrand.VisibleIndex = 9
            '
            'colModel
            '
            Me.colModel.FieldName = "Model"
            Me.colModel.Name = "colModel"
            Me.colModel.OptionsColumn.AllowEdit = False
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 10
            '
            'colColor
            '
            Me.colColor.Caption = "Color"
            Me.colColor.FieldName = "Color"
            Me.colColor.Name = "colColor"
            Me.colColor.OptionsColumn.AllowEdit = False
            Me.colColor.Visible = True
            Me.colColor.VisibleIndex = 11
            '
            'colDescription
            '
            Me.colDescription.Caption = "Description"
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.OptionsColumn.AllowEdit = False
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 12
            '
            'colKeyNumber
            '
            Me.colKeyNumber.Caption = "Key Code"
            Me.colKeyNumber.FieldName = "KeyNo"
            Me.colKeyNumber.Name = "colKeyNumber"
            Me.colKeyNumber.Visible = True
            Me.colKeyNumber.VisibleIndex = 13
            '
            'colInclusions
            '
            Me.colInclusions.Caption = "Inclusions"
            Me.colInclusions.ColumnEdit = Me.RepositoryItemTokenEdit_Inclusions
            Me.colInclusions.FieldName = "Inclusions"
            Me.colInclusions.Name = "colInclusions"
            Me.colInclusions.Visible = True
            Me.colInclusions.VisibleIndex = 14
            '
            'RepositoryItemTokenEdit_Inclusions
            '
            Me.RepositoryItemTokenEdit_Inclusions.Name = "RepositoryItemTokenEdit_Inclusions"
            '
            'colNotes
            '
            Me.colNotes.Caption = "Notes"
            Me.colNotes.FieldName = "Note"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 15
            '
            'colFreight_Cost
            '
            Me.colFreight_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFreight_Cost.FieldName = "Freight_Cost"
            Me.colFreight_Cost.Name = "colFreight_Cost"
            Me.colFreight_Cost.OptionsColumn.AllowEdit = False
            Me.colFreight_Cost.Visible = True
            Me.colFreight_Cost.VisibleIndex = 16
            '
            'colUnit_Cost
            '
            Me.colUnit_Cost.Caption = "Unit Cost"
            Me.colUnit_Cost.ColumnEdit = Me.RepositoryItemCalcEdit_Unit_Item_Cost
            Me.colUnit_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnit_Cost.FieldName = "UnitCost"
            Me.colUnit_Cost.Name = "colUnit_Cost"
            Me.colUnit_Cost.Visible = True
            Me.colUnit_Cost.VisibleIndex = 17
            '
            'RepositoryItemCalcEdit_Unit_Item_Cost
            '
            Me.RepositoryItemCalcEdit_Unit_Item_Cost.AutoHeight = False
            Me.RepositoryItemCalcEdit_Unit_Item_Cost.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_Unit_Item_Cost.Name = "RepositoryItemCalcEdit_Unit_Item_Cost"
            '
            'colVAT
            '
            Me.colVAT.Caption = "VAT"
            Me.colVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colVAT.FieldName = "VATAmt"
            Me.colVAT.Name = "colVAT"
            Me.colVAT.OptionsColumn.AllowEdit = False
            Me.colVAT.Visible = True
            Me.colVAT.VisibleIndex = 18
            '
            'colTotal_Cost
            '
            Me.colTotal_Cost.Caption = "Total Cost"
            Me.colTotal_Cost.ColumnEdit = Me.RepositoryItemCalcEdit_Unit_Item_Total_Cost
            Me.colTotal_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Cost.FieldName = "TotalCost"
            Me.colTotal_Cost.Name = "colTotal_Cost"
            Me.colTotal_Cost.Visible = True
            Me.colTotal_Cost.VisibleIndex = 19
            '
            'RepositoryItemCalcEdit_Unit_Item_Total_Cost
            '
            Me.RepositoryItemCalcEdit_Unit_Item_Total_Cost.AutoHeight = False
            Me.RepositoryItemCalcEdit_Unit_Item_Total_Cost.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_Unit_Item_Total_Cost.Name = "RepositoryItemCalcEdit_Unit_Item_Total_Cost"
            '
            'colTransacted_By
            '
            Me.colTransacted_By.Caption = "Added By"
            Me.colTransacted_By.FieldName = "TransactedBy"
            Me.colTransacted_By.Name = "colTransacted_By"
            Me.colTransacted_By.OptionsColumn.AllowEdit = False
            Me.colTransacted_By.Visible = True
            Me.colTransacted_By.VisibleIndex = 20
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.OptionsColumn.AllowEdit = False
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 21
            '
            'colUpdated_By
            '
            Me.colUpdated_By.Caption = "Updated By"
            Me.colUpdated_By.FieldName = "OriginatingMaker"
            Me.colUpdated_By.Name = "colUpdated_By"
            Me.colUpdated_By.OptionsColumn.AllowEdit = False
            Me.colUpdated_By.Visible = True
            Me.colUpdated_By.VisibleIndex = 22
            '
            'colUpdated_Date
            '
            Me.colUpdated_Date.FieldName = "UpdatedDate"
            Me.colUpdated_Date.Name = "colUpdated_Date"
            Me.colUpdated_Date.OptionsColumn.AllowEdit = False
            Me.colUpdated_Date.Visible = True
            Me.colUpdated_Date.VisibleIndex = 23
            '
            'RepositoryItemLookUpEdit_Model_Code
            '
            Me.RepositoryItemLookUpEdit_Model_Code.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Model_Code.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Model_Code.Name = "RepositoryItemLookUpEdit_Model_Code"
            '
            'BarManager
            '
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Initialize, Me.btn_Reload, Me.btn_New, Me.btn_Delete, Me.btn_Preview, Me.btn_Save, Me.btn_Preview_Units, Me.btn_Preview_Unit_Costing, Me.btn_Update, Me.btn_Add_To_PO, Me.btn_New_Unit_Model})
            Me.BarManager.MaxItemId = 51
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(313, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 332)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(313, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 332)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(313, 0)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 332)
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 0
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 3
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 4
            Me.btn_New.Name = "btn_New"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 6
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_Preview
            '
            Me.btn_Preview.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.Id = 8
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 25
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Preview_Units
            '
            Me.btn_Preview_Units.Caption = "Preview Unit Items"
            Me.btn_Preview_Units.Id = 27
            Me.btn_Preview_Units.ImageOptions.Image = CType(resources.GetObject("btn_Preview_Units.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Preview_Units.ImageOptions.LargeImage = CType(resources.GetObject("btn_Preview_Units.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Preview_Units.Name = "btn_Preview_Units"
            '
            'btn_Preview_Unit_Costing
            '
            Me.btn_Preview_Unit_Costing.Caption = "Preview Unit Costing"
            Me.btn_Preview_Unit_Costing.Id = 41
            Me.btn_Preview_Unit_Costing.ImageOptions.Image = CType(resources.GetObject("btn_Preview_Unit_Costing.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Preview_Unit_Costing.ImageOptions.LargeImage = CType(resources.GetObject("btn_Preview_Unit_Costing.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Preview_Unit_Costing.Name = "btn_Preview_Unit_Costing"
            '
            'btn_Update
            '
            Me.btn_Update.Caption = "Update"
            Me.btn_Update.Id = 46
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Add_To_PO
            '
            Me.btn_Add_To_PO.Caption = "Add to Purchase Order"
            Me.btn_Add_To_PO.Id = 48
            Me.btn_Add_To_PO.ImageOptions.Image = CType(resources.GetObject("btn_Add_To_PO.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Add_To_PO.ImageOptions.LargeImage = CType(resources.GetObject("btn_Add_To_PO.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Add_To_PO.Name = "btn_Add_To_PO"
            '
            'btn_New_Unit_Model
            '
            Me.btn_New_Unit_Model.Caption = "Add New Unit Model"
            Me.btn_New_Unit_Model.Id = 50
            Me.btn_New_Unit_Model.ImageOptions.Image = CType(resources.GetObject("btn_New_Unit_Model.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_New_Unit_Model.ImageOptions.LargeImage = CType(resources.GetObject("btn_New_Unit_Model.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_New_Unit_Model.Name = "btn_New_Unit_Model"
            '
            'Bar1
            '
            Me.Bar1.BarName = "Actions"
            Me.Bar1.DockCol = 1
            Me.Bar1.DockRow = 1
            Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete)})
            Me.Bar1.Text = "Actions"
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview_Units, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview_Unit_Costing), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New_Unit_Model, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Add_To_PO)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'xuc_MC_Transaction_Units
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "xuc_MC_Transaction_Units"
            Me.Size = New System.Drawing.Size(313, 332)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Engine, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Chassis, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemTokenEdit_Inclusions, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_Unit_Item_Cost, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_Unit_Item_Total_Cost, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Model_Code, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIfExist As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEngine As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_Engine As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colChassis As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRemarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colKeyNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInclusions As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemTokenEdit_Inclusions As DevExpress.XtraEditors.Repository.RepositoryItemTokenEdit
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFreight_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_Unit_Item_Cost As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents colVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_Unit_Item_Total_Cost As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents colTransacted_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUpdated_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUpdated_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Public WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Public WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview_Units As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview_Unit_Costing As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Add_To_PO As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit_Chassis As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit_Model_Code As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents btn_New_Unit_Model As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace