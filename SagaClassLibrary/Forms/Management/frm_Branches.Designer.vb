Namespace Forms.Management
    Partial Class frm_Branches
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPre_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Local = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Area = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Manager = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Admin = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDatabaseDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLTO_Payable = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInsurance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotarial_Fee = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPetty_Cash_Budget = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPetty_Cash_Replenish = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFor_Approval = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFor_Liquidation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPetty_Cash_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCTC_Number = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCTC_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCTC_Place = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.GridControl = New DevExpress.XtraGrid.GridControl()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Branch = New SagaClassLibrary.Controls.Management.xuc_Branch()
            Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.colCut_Off_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanel1.SuspendLayout()
            Me.dockPanel1_Container.SuspendLayout()
            Me.dockPanel2.SuspendLayout()
            Me.dockPanel2_Container.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colBranchCode, Me.colPre_Code, Me.colBranch_Local, Me.colBranch, Me.colBranch_Area, Me.colBranch_Manager, Me.colBranch_Admin, Me.colAddress, Me.colCut_Off_Date, Me.colDatabaseDate, Me.colLTO_Payable, Me.colInsurance, Me.colNotarial_Fee, Me.colPetty_Cash_Budget, Me.colPetty_Cash_Replenish, Me.colFor_Approval, Me.colFor_Liquidation, Me.colPetty_Cash_Balance, Me.colCTC_Number, Me.colCTC_Date, Me.colCTC_Place, Me.colNotes})
            Me.gridView.GridControl = Me.GridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colBranchCode
            '
            Me.colBranchCode.Caption = "Code"
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 1
            '
            'colPre_Code
            '
            Me.colPre_Code.Caption = "Pre-Code"
            Me.colPre_Code.FieldName = "Pre_Code"
            Me.colPre_Code.Name = "colPre_Code"
            Me.colPre_Code.Visible = True
            Me.colPre_Code.VisibleIndex = 2
            '
            'colBranch_Local
            '
            Me.colBranch_Local.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBranch_Local.FieldName = "Branch_Local"
            Me.colBranch_Local.Name = "colBranch_Local"
            Me.colBranch_Local.Visible = True
            Me.colBranch_Local.VisibleIndex = 3
            '
            'colBranch
            '
            Me.colBranch.Caption = "Branch"
            Me.colBranch.FieldName = "Branch"
            Me.colBranch.Name = "colBranch"
            Me.colBranch.Visible = True
            Me.colBranch.VisibleIndex = 4
            '
            'colBranch_Area
            '
            Me.colBranch_Area.Caption = "Area"
            Me.colBranch_Area.FieldName = "Branch_Area"
            Me.colBranch_Area.Name = "colBranch_Area"
            Me.colBranch_Area.Visible = True
            Me.colBranch_Area.VisibleIndex = 5
            '
            'colBranch_Manager
            '
            Me.colBranch_Manager.Caption = "Manager"
            Me.colBranch_Manager.FieldName = "Branch_Manager"
            Me.colBranch_Manager.Name = "colBranch_Manager"
            Me.colBranch_Manager.Visible = True
            Me.colBranch_Manager.VisibleIndex = 6
            '
            'colBranch_Admin
            '
            Me.colBranch_Admin.Caption = "Admin / Cashier"
            Me.colBranch_Admin.FieldName = "Branch_Admin"
            Me.colBranch_Admin.Name = "colBranch_Admin"
            Me.colBranch_Admin.Visible = True
            Me.colBranch_Admin.VisibleIndex = 7
            '
            'colAddress
            '
            Me.colAddress.Caption = "Address"
            Me.colAddress.FieldName = "Address"
            Me.colAddress.Name = "colAddress"
            Me.colAddress.Visible = True
            Me.colAddress.VisibleIndex = 8
            '
            'colDatabaseDate
            '
            Me.colDatabaseDate.Caption = "Database Date"
            Me.colDatabaseDate.FieldName = "DatabaseDate"
            Me.colDatabaseDate.Name = "colDatabaseDate"
            Me.colDatabaseDate.Visible = True
            Me.colDatabaseDate.VisibleIndex = 10
            '
            'colLTO_Payable
            '
            Me.colLTO_Payable.Caption = "LTO Payable"
            Me.colLTO_Payable.DisplayFormat.FormatString = "{0:n2}"
            Me.colLTO_Payable.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colLTO_Payable.FieldName = "LTO_Payable"
            Me.colLTO_Payable.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colLTO_Payable.Name = "colLTO_Payable"
            Me.colLTO_Payable.Visible = True
            Me.colLTO_Payable.VisibleIndex = 11
            '
            'colInsurance
            '
            Me.colInsurance.Caption = "Insurance"
            Me.colInsurance.DisplayFormat.FormatString = "{0:n2}"
            Me.colInsurance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInsurance.FieldName = "Insurance"
            Me.colInsurance.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInsurance.Name = "colInsurance"
            Me.colInsurance.Visible = True
            Me.colInsurance.VisibleIndex = 12
            '
            'colNotarial_Fee
            '
            Me.colNotarial_Fee.Caption = "Notarial Fee"
            Me.colNotarial_Fee.DisplayFormat.FormatString = "{0:n2}"
            Me.colNotarial_Fee.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colNotarial_Fee.FieldName = "Notarial_Fee"
            Me.colNotarial_Fee.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colNotarial_Fee.Name = "colNotarial_Fee"
            Me.colNotarial_Fee.Visible = True
            Me.colNotarial_Fee.VisibleIndex = 13
            '
            'colPetty_Cash_Budget
            '
            Me.colPetty_Cash_Budget.Caption = "Budget"
            Me.colPetty_Cash_Budget.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPetty_Cash_Budget.FieldName = "Petty_Cash_Budget"
            Me.colPetty_Cash_Budget.Name = "colPetty_Cash_Budget"
            Me.colPetty_Cash_Budget.Visible = True
            Me.colPetty_Cash_Budget.VisibleIndex = 14
            '
            'colPetty_Cash_Replenish
            '
            Me.colPetty_Cash_Replenish.Caption = "Replenishment"
            Me.colPetty_Cash_Replenish.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPetty_Cash_Replenish.FieldName = "Petty_Cash_Replenish"
            Me.colPetty_Cash_Replenish.Name = "colPetty_Cash_Replenish"
            Me.colPetty_Cash_Replenish.Visible = True
            Me.colPetty_Cash_Replenish.VisibleIndex = 15
            '
            'colFor_Approval
            '
            Me.colFor_Approval.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFor_Approval.FieldName = "For_Approval"
            Me.colFor_Approval.Name = "colFor_Approval"
            Me.colFor_Approval.Visible = True
            Me.colFor_Approval.VisibleIndex = 16
            '
            'colFor_Liquidation
            '
            Me.colFor_Liquidation.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFor_Liquidation.FieldName = "For_Liquidation"
            Me.colFor_Liquidation.Name = "colFor_Liquidation"
            Me.colFor_Liquidation.Visible = True
            Me.colFor_Liquidation.VisibleIndex = 17
            '
            'colPetty_Cash_Balance
            '
            Me.colPetty_Cash_Balance.Caption = "Balance"
            Me.colPetty_Cash_Balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPetty_Cash_Balance.FieldName = "Petty_Cash_Balance"
            Me.colPetty_Cash_Balance.Name = "colPetty_Cash_Balance"
            Me.colPetty_Cash_Balance.Visible = True
            Me.colPetty_Cash_Balance.VisibleIndex = 18
            '
            'colCTC_Number
            '
            Me.colCTC_Number.FieldName = "CTC_Number"
            Me.colCTC_Number.Name = "colCTC_Number"
            Me.colCTC_Number.Visible = True
            Me.colCTC_Number.VisibleIndex = 19
            '
            'colCTC_Date
            '
            Me.colCTC_Date.FieldName = "CTC_Date"
            Me.colCTC_Date.Name = "colCTC_Date"
            Me.colCTC_Date.Visible = True
            Me.colCTC_Date.VisibleIndex = 20
            '
            'colCTC_Place
            '
            Me.colCTC_Place.FieldName = "CTC_Place"
            Me.colCTC_Place.Name = "colCTC_Place"
            Me.colCTC_Place.Visible = True
            Me.colCTC_Place.VisibleIndex = 21
            '
            'colNotes
            '
            Me.colNotes.Caption = "Notes"
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 22
            '
            'GridControl
            '
            Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl.Location = New System.Drawing.Point(300, 20)
            Me.GridControl.MainView = Me.gridView
            Me.GridControl.Name = "GridControl"
            Me.GridControl.Size = New System.Drawing.Size(313, 502)
            Me.GridControl.TabIndex = 0
            Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'barManager
            '
            Me.barManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1})
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.DockManager = Me.dockManager
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Close, Me.btn_New, Me.btn_Delete, Me.btn_Save, Me.btn_Initialize, Me.btn_Preview, Me.btn_Update})
            Me.barManager.MaxItemId = 8
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'bar1
            '
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockRow = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.FloatLocation = New System.Drawing.Point(51, 141)
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close, True)})
            Me.bar1.Text = "Tools"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 5
            Me.btn_Initialize.ImageOptions.ImageIndex = 6
            Me.btn_Initialize.ImageOptions.LargeImageIndex = 6
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 0
            Me.btn_Reload.ImageOptions.ImageIndex = 0
            Me.btn_Reload.ImageOptions.LargeImageIndex = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.Id = 6
            Me.btn_Preview.ImageOptions.ImageIndex = 4
            Me.btn_Preview.ImageOptions.LargeImageIndex = 4
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 2
            Me.btn_New.ImageOptions.ImageIndex = 1
            Me.btn_New.ImageOptions.LargeImageIndex = 1
            Me.btn_New.Name = "btn_New"
            '
            'btn_Update
            '
            Me.btn_Update.Caption = "Update"
            Me.btn_Update.Id = 7
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 4
            Me.btn_Save.ImageOptions.ImageIndex = 2
            Me.btn_Save.ImageOptions.LargeImageIndex = 2
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 3
            Me.btn_Delete.ImageOptions.ImageIndex = 3
            Me.btn_Delete.ImageOptions.LargeImageIndex = 3
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 1
            Me.btn_Close.ImageOptions.ImageIndex = 5
            Me.btn_Close.ImageOptions.LargeImageIndex = 5
            Me.btn_Close.Name = "btn_Close"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(893, 20)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 522)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(893, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 502)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(893, 20)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 502)
            '
            'dockManager
            '
            Me.dockManager.Form = Me
            Me.dockManager.MenuManager = Me.barManager
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanel1, Me.dockPanel2})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl"})
            '
            'dockPanel1
            '
            Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
            Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.dockPanel1.ID = New System.Guid("11354670-72b1-4107-9913-c8a1b6d836ac")
            Me.dockPanel1.Location = New System.Drawing.Point(0, 20)
            Me.dockPanel1.Name = "dockPanel1"
            Me.dockPanel1.OriginalSize = New System.Drawing.Size(300, 400)
            Me.dockPanel1.Size = New System.Drawing.Size(300, 502)
            Me.dockPanel1.Text = "Branch Information"
            '
            'dockPanel1_Container
            '
            Me.dockPanel1_Container.Controls.Add(Me.xuc_Branch)
            Me.dockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.dockPanel1_Container.Name = "dockPanel1_Container"
            Me.dockPanel1_Container.Size = New System.Drawing.Size(293, 473)
            Me.dockPanel1_Container.TabIndex = 0
            '
            'xuc_Branch
            '
            Me.xuc_Branch.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Branch.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Branch.Name = "xuc_Branch"
            Me.xuc_Branch.Size = New System.Drawing.Size(293, 473)
            Me.xuc_Branch.TabIndex = 0
            '
            'dockPanel2
            '
            Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
            Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.dockPanel2.ID = New System.Guid("43ac3df2-8ca4-45ce-a495-15febb84ecab")
            Me.dockPanel2.Location = New System.Drawing.Point(613, 20)
            Me.dockPanel2.Name = "dockPanel2"
            Me.dockPanel2.OriginalSize = New System.Drawing.Size(280, 200)
            Me.dockPanel2.Size = New System.Drawing.Size(280, 502)
            Me.dockPanel2.Text = "Settings"
            '
            'dockPanel2_Container
            '
            Me.dockPanel2_Container.Controls.Add(Me.PanelControl1)
            Me.dockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.dockPanel2_Container.Name = "dockPanel2_Container"
            Me.dockPanel2_Container.Size = New System.Drawing.Size(273, 473)
            Me.dockPanel2_Container.TabIndex = 0
            '
            'PanelControl1
            '
            Me.PanelControl1.Controls.Add(Me.xuc_Settings)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(273, 473)
            Me.PanelControl1.TabIndex = 8
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(2, 2)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(270, 469)
            Me.xuc_Settings.TabIndex = 0
            '
            'colCut_Off_Date
            '
            Me.colCut_Off_Date.FieldName = "Cut_Off_Date"
            Me.colCut_Off_Date.Name = "colCut_Off_Date"
            Me.colCut_Off_Date.Visible = True
            Me.colCut_Off_Date.VisibleIndex = 9
            '
            'frm_Branches
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(893, 522)
            Me.Controls.Add(Me.GridControl)
            Me.Controls.Add(Me.dockPanel2)
            Me.Controls.Add(Me.dockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_Branches"
            Me.Text = "Branch List"
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanel1.ResumeLayout(False)
            Me.dockPanel1_Container.ResumeLayout(False)
            Me.dockPanel2.ResumeLayout(False)
            Me.dockPanel2_Container.ResumeLayout(False)
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
        Private barManager As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private dockManager As DevExpress.XtraBars.Docking.DockManager
        Friend dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Manager As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Local As DevExpress.XtraGrid.Columns.GridColumn
        Friend dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colLTO_Payable As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInsurance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotarial_Fee As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents xuc_Branch As Controls.Management.xuc_Branch
        Friend WithEvents colPre_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDatabaseDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents colBranch_Admin As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPetty_Cash_Budget As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPetty_Cash_Replenish As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFor_Approval As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFor_Liquidation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPetty_Cash_Balance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colBranch_Area As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCTC_Number As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCTC_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCTC_Place As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCut_Off_Date As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace