Namespace Controls.Logistics
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Purchase_Order_Units
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xuc_Purchase_Order_Units))
            Me.Bar1 = New DevExpress.XtraBars.Bar()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colModel_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Model_Code = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colModel_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Model = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemSpinEdit_Quantity = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Color = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Color = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colUnit_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFreight_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFreight_Cost_Total = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colGrand_Total = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Received = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFreight_Cost_Received = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Cost_Received = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDue_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Remaining = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Cost_Remaining = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrder_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Re_Count = New DevExpress.XtraBars.BarButtonItem()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Model_Code, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Model, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSpinEdit_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Color, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Bar1
            '
            Me.Bar1.BarName = "Actions"
            Me.Bar1.DockCol = 1
            Me.Bar1.DockRow = 1
            Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar1.Text = "Actions"
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Model, Me.RepositoryItemSpinEdit_Quantity, Me.RepositoryItemLookUpEdit_Color, Me.RepositoryItemLookUpEdit_Model_Code, Me.RepositoryItemLookUpEdit_Branch})
            Me.gridControl.Size = New System.Drawing.Size(313, 332)
            Me.gridControl.TabIndex = 21
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colBranch_Code, Me.colModel_Code, Me.colModel_Name, Me.colQuantity, Me.colNotes, Me.colUnit_Color, Me.colUnit_Cost, Me.colTotal_Cost, Me.colFreight_Cost, Me.colFreight_Cost_Total, Me.colGrand_Total, Me.colUnit_Received, Me.colFreight_Cost_Received, Me.colTotal_Cost_Received, Me.colDue_Date, Me.colUnit_Remaining, Me.colTotal_Cost_Remaining, Me.colUnit_Description, Me.colOrder_Status, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date})
            Me.gridView.gridControl = Me.gridControl
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
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch"
            Me.colBranch_Code.ColumnEdit = Me.RepositoryItemLookUpEdit_Branch
            Me.colBranch_Code.FieldName = "Branch_Code"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 1
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'colModel_Code
            '
            Me.colModel_Code.ColumnEdit = Me.RepositoryItemLookUpEdit_Model_Code
            Me.colModel_Code.FieldName = "Model_Code"
            Me.colModel_Code.Name = "colModel_Code"
            Me.colModel_Code.Visible = True
            Me.colModel_Code.VisibleIndex = 2
            '
            'RepositoryItemLookUpEdit_Model_Code
            '
            Me.RepositoryItemLookUpEdit_Model_Code.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Model_Code.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Model_Code.Name = "RepositoryItemLookUpEdit_Model_Code"
            '
            'colModel_Name
            '
            Me.colModel_Name.Caption = "Model"
            Me.colModel_Name.ColumnEdit = Me.RepositoryItemLookUpEdit_Model
            Me.colModel_Name.FieldName = "Model_Name"
            Me.colModel_Name.Name = "colModel_Name"
            Me.colModel_Name.Visible = True
            Me.colModel_Name.VisibleIndex = 3
            '
            'RepositoryItemLookUpEdit_Model
            '
            Me.RepositoryItemLookUpEdit_Model.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Model.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Model.Name = "RepositoryItemLookUpEdit_Model"
            '
            'colQuantity
            '
            Me.colQuantity.ColumnEdit = Me.RepositoryItemSpinEdit_Quantity
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 4
            '
            'RepositoryItemSpinEdit_Quantity
            '
            Me.RepositoryItemSpinEdit_Quantity.AutoHeight = False
            Me.RepositoryItemSpinEdit_Quantity.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemSpinEdit_Quantity.Name = "RepositoryItemSpinEdit_Quantity"
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 5
            '
            'colUnit_Color
            '
            Me.colUnit_Color.ColumnEdit = Me.RepositoryItemLookUpEdit_Color
            Me.colUnit_Color.FieldName = "Unit_Color"
            Me.colUnit_Color.Name = "colUnit_Color"
            Me.colUnit_Color.Visible = True
            Me.colUnit_Color.VisibleIndex = 6
            '
            'RepositoryItemLookUpEdit_Color
            '
            Me.RepositoryItemLookUpEdit_Color.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Color.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Color.Name = "RepositoryItemLookUpEdit_Color"
            '
            'colUnit_Cost
            '
            Me.colUnit_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnit_Cost.FieldName = "Unit_Cost"
            Me.colUnit_Cost.Name = "colUnit_Cost"
            Me.colUnit_Cost.OptionsColumn.AllowEdit = False
            Me.colUnit_Cost.Visible = True
            Me.colUnit_Cost.VisibleIndex = 7
            '
            'colTotal_Cost
            '
            Me.colTotal_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Cost.FieldName = "Total_Cost"
            Me.colTotal_Cost.Name = "colTotal_Cost"
            Me.colTotal_Cost.OptionsColumn.AllowEdit = False
            Me.colTotal_Cost.Visible = True
            Me.colTotal_Cost.VisibleIndex = 8
            '
            'colFreight_Cost
            '
            Me.colFreight_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFreight_Cost.FieldName = "Freight_Cost"
            Me.colFreight_Cost.Name = "colFreight_Cost"
            Me.colFreight_Cost.OptionsColumn.AllowEdit = False
            Me.colFreight_Cost.Visible = True
            Me.colFreight_Cost.VisibleIndex = 9
            '
            'colFreight_Cost_Total
            '
            Me.colFreight_Cost_Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFreight_Cost_Total.FieldName = "Freight_Cost_Total"
            Me.colFreight_Cost_Total.Name = "colFreight_Cost_Total"
            Me.colFreight_Cost_Total.OptionsColumn.AllowEdit = False
            Me.colFreight_Cost_Total.Visible = True
            Me.colFreight_Cost_Total.VisibleIndex = 10
            '
            'colGrand_Total
            '
            Me.colGrand_Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colGrand_Total.FieldName = "Grand_Total"
            Me.colGrand_Total.Name = "colGrand_Total"
            Me.colGrand_Total.OptionsColumn.AllowEdit = False
            Me.colGrand_Total.Visible = True
            Me.colGrand_Total.VisibleIndex = 11
            '
            'colUnit_Received
            '
            Me.colUnit_Received.Caption = "Received"
            Me.colUnit_Received.FieldName = "Unit_Received"
            Me.colUnit_Received.Name = "colUnit_Received"
            Me.colUnit_Received.OptionsColumn.AllowEdit = False
            Me.colUnit_Received.Visible = True
            Me.colUnit_Received.VisibleIndex = 12
            '
            'colFreight_Cost_Received
            '
            Me.colFreight_Cost_Received.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFreight_Cost_Received.FieldName = "Freight_Cost_Received"
            Me.colFreight_Cost_Received.Name = "colFreight_Cost_Received"
            Me.colFreight_Cost_Received.OptionsColumn.AllowEdit = False
            Me.colFreight_Cost_Received.Visible = True
            Me.colFreight_Cost_Received.VisibleIndex = 13
            '
            'colTotal_Cost_Received
            '
            Me.colTotal_Cost_Received.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Cost_Received.FieldName = "Total_Cost_Received"
            Me.colTotal_Cost_Received.Name = "colTotal_Cost_Received"
            Me.colTotal_Cost_Received.OptionsColumn.AllowEdit = False
            Me.colTotal_Cost_Received.Visible = True
            Me.colTotal_Cost_Received.VisibleIndex = 14
            '
            'colDue_Date
            '
            Me.colDue_Date.FieldName = "Due_Date"
            Me.colDue_Date.Name = "colDue_Date"
            Me.colDue_Date.OptionsColumn.AllowEdit = False
            Me.colDue_Date.Visible = True
            Me.colDue_Date.VisibleIndex = 15
            '
            'colUnit_Remaining
            '
            Me.colUnit_Remaining.Caption = "Remaining"
            Me.colUnit_Remaining.FieldName = "Unit_Remaining"
            Me.colUnit_Remaining.Name = "colUnit_Remaining"
            Me.colUnit_Remaining.OptionsColumn.AllowEdit = False
            Me.colUnit_Remaining.Visible = True
            Me.colUnit_Remaining.VisibleIndex = 16
            '
            'colTotal_Cost_Remaining
            '
            Me.colTotal_Cost_Remaining.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Cost_Remaining.FieldName = "Total_Cost_Remaining"
            Me.colTotal_Cost_Remaining.Name = "colTotal_Cost_Remaining"
            Me.colTotal_Cost_Remaining.OptionsColumn.AllowEdit = False
            Me.colTotal_Cost_Remaining.Visible = True
            Me.colTotal_Cost_Remaining.VisibleIndex = 17
            '
            'colUnit_Description
            '
            Me.colUnit_Description.FieldName = "Unit_Description"
            Me.colUnit_Description.Name = "colUnit_Description"
            Me.colUnit_Description.Visible = True
            Me.colUnit_Description.VisibleIndex = 18
            '
            'colOrder_Status
            '
            Me.colOrder_Status.FieldName = "Order_Status"
            Me.colOrder_Status.Name = "colOrder_Status"
            Me.colOrder_Status.OptionsColumn.AllowEdit = False
            Me.colOrder_Status.Visible = True
            Me.colOrder_Status.VisibleIndex = 19
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.OptionsColumn.AllowEdit = False
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 20
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.OptionsColumn.AllowEdit = False
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 21
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.OptionsColumn.AllowEdit = False
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 22
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.OptionsColumn.AllowEdit = False
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 23
            '
            'BarManager
            '
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Initialize, Me.btn_Reload, Me.btn_New, Me.btn_Save, Me.btn_Delete, Me.btn_Preview, Me.btn_Re_Count})
            Me.BarManager.MaxItemId = 34
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
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 5
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 6
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.Id = 8
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_Re_Count
            '
            Me.btn_Re_Count.Caption = "Recount"
            Me.btn_Re_Count.Id = 33
            Me.btn_Re_Count.ImageOptions.Image = CType(resources.GetObject("btn_Re_Count.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Re_Count.ImageOptions.LargeImage = CType(resources.GetObject("btn_Re_Count.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Re_Count.Name = "btn_Re_Count"
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Re_Count), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'xuc_Purchase_Order_Units
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "xuc_Purchase_Order_Units"
            Me.Size = New System.Drawing.Size(313, 332)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Model_Code, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Model, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSpinEdit_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Color, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_Model_Code As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colModel_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_Model As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colUnit_Color As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_Color As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemSpinEdit_Quantity As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Friend WithEvents colUnit_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFreight_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFreight_Cost_Total As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colGrand_Total As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Received As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFreight_Cost_Received As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Cost_Received As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDue_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Remaining As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Cost_Remaining As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOrder_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Re_Count As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    End Class
End Namespace