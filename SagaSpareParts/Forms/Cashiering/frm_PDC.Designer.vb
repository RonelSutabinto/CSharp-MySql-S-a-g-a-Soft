Namespace Forms.Cashiering
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_PDC
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
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar1 = New DevExpress.XtraBars.Bar()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar3 = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Date_Start = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDate_Start = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.BarEditItem_Date_End = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDate_End = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.DockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.DockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_PDC = New xuc_PDC()
            Me.DockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
            Me.DockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.xuc_Settings = New MyClassLibrary.Controls.Settings.xuc_Settings()
            Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.RepositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
            Me.gridControl_List = New DevExpress.XtraGrid.GridControl()
            Me.gridView_List = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.col_PDC_Id = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsPDC = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBank_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPDC_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPDC_Address = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPDC_No = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPDC_Amount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPDC_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSBD_Amount_Due = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSBD_Maturity_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSBD_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDate_Start, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDate_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDate_End, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDate_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DockPanel1.SuspendLayout()
            Me.DockPanel1_Container.SuspendLayout()
            Me.DockPanel2.SuspendLayout()
            Me.DockPanel2_Container.SuspendLayout()
            CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl_List, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView_List, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.DockManager = Me.DockManager
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_New, Me.btn_Initialize, Me.btn_Save, Me.btn_Reload, Me.btn_Delete, Me.btn_Preview, Me.btn_Close, Me.BarEditItem_Date_Start, Me.BarEditItem_Date_End})
            Me.BarManager.MaxItemId = 11
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemDate_Start, Me.RepositoryItemDate_End})
            '
            'Bar1
            '
            Me.Bar1.BarName = "Tools"
            Me.Bar1.DockCol = 0
            Me.Bar1.DockRow = 0
            Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Close)})
            Me.Bar1.Text = "Tools"
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 0
            Me.btn_New.Name = "btn_New"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 1
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Save
            '
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 2
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 3
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 4
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.Id = 5
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_Close
            '
            Me.btn_Close.Caption = "Close"
            Me.btn_Close.Id = 6
            Me.btn_Close.Name = "btn_Close"
            '
            'Bar3
            '
            Me.Bar3.BarName = "Custom 4"
            Me.Bar3.DockCol = 1
            Me.Bar3.DockRow = 0
            Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_Date_Start, "", False, True, True, 113), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_Date_End, "", False, True, True, 118)})
            Me.Bar3.Offset = 327
            Me.Bar3.Text = "Custom 4"
            '
            'BarEditItem_Date_Start
            '
            Me.BarEditItem_Date_Start.Caption = "Date Start"
            Me.BarEditItem_Date_Start.Edit = Me.RepositoryItemDate_Start
            Me.BarEditItem_Date_Start.Id = 9
            Me.BarEditItem_Date_Start.Name = "BarEditItem_Date_Start"
            '
            'RepositoryItemDate_Start
            '
            Me.RepositoryItemDate_Start.AutoHeight = False
            Me.RepositoryItemDate_Start.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDate_Start.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDate_Start.Name = "RepositoryItemDate_Start"
            '
            'BarEditItem_Date_End
            '
            Me.BarEditItem_Date_End.Caption = "Date End"
            Me.BarEditItem_Date_End.Edit = Me.RepositoryItemDate_End
            Me.BarEditItem_Date_End.Id = 10
            Me.BarEditItem_Date_End.Name = "BarEditItem_Date_End"
            '
            'RepositoryItemDate_End
            '
            Me.RepositoryItemDate_End.AutoHeight = False
            Me.RepositoryItemDate_End.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDate_End.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDate_End.Name = "RepositoryItemDate_End"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(900, 20)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 472)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(900, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 20)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 452)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(900, 20)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 452)
            '
            'DockManager
            '
            Me.DockManager.Form = Me
            Me.DockManager.MenuManager = Me.BarManager
            Me.DockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.DockPanel1, Me.DockPanel2})
            Me.DockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl", "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl", "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"})
            '
            'DockPanel1
            '
            Me.DockPanel1.Controls.Add(Me.DockPanel1_Container)
            Me.DockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left
            Me.DockPanel1.ID = New System.Guid("6859f08c-69cf-4323-9c9b-8c3f7d832db6")
            Me.DockPanel1.Location = New System.Drawing.Point(0, 20)
            Me.DockPanel1.Name = "DockPanel1"
            Me.DockPanel1.OriginalSize = New System.Drawing.Size(254, 200)
            Me.DockPanel1.Size = New System.Drawing.Size(254, 452)
            Me.DockPanel1.Text = "Informations"
            '
            'DockPanel1_Container
            '
            Me.DockPanel1_Container.Controls.Add(Me.xuc_PDC)
            Me.DockPanel1_Container.Location = New System.Drawing.Point(3, 26)
            Me.DockPanel1_Container.Name = "DockPanel1_Container"
            Me.DockPanel1_Container.Size = New System.Drawing.Size(247, 423)
            Me.DockPanel1_Container.TabIndex = 0
            '
            'xuc_PDC
            '
            Me.xuc_PDC.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_PDC.Location = New System.Drawing.Point(0, 0)
            Me.xuc_PDC.Name = "xuc_PDC"
            Me.xuc_PDC.Size = New System.Drawing.Size(247, 423)
            Me.xuc_PDC.TabIndex = 0
            '
            'DockPanel2
            '
            Me.DockPanel2.Controls.Add(Me.DockPanel2_Container)
            Me.DockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.DockPanel2.ID = New System.Guid("169b42e4-2e3c-495b-931f-f90e843f8bf2")
            Me.DockPanel2.Location = New System.Drawing.Point(644, 20)
            Me.DockPanel2.Name = "DockPanel2"
            Me.DockPanel2.OriginalSize = New System.Drawing.Size(256, 200)
            Me.DockPanel2.Size = New System.Drawing.Size(256, 452)
            Me.DockPanel2.Text = "Settings"
            '
            'DockPanel2_Container
            '
            Me.DockPanel2_Container.Controls.Add(Me.xuc_Settings)
            Me.DockPanel2_Container.Location = New System.Drawing.Point(4, 26)
            Me.DockPanel2_Container.Name = "DockPanel2_Container"
            Me.DockPanel2_Container.Size = New System.Drawing.Size(249, 423)
            Me.DockPanel2_Container.TabIndex = 0
            '
            'xuc_Settings
            '
            Me.xuc_Settings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Settings.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Settings.MinimumSize = New System.Drawing.Size(270, 0)
            Me.xuc_Settings.Name = "xuc_Settings"
            Me.xuc_Settings.Size = New System.Drawing.Size(270, 423)
            Me.xuc_Settings.TabIndex = 0
            '
            'RepositoryItemDateEdit1
            '
            Me.RepositoryItemDateEdit1.AutoHeight = False
            Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
            '
            'RepositoryItemDateEdit2
            '
            Me.RepositoryItemDateEdit2.AutoHeight = False
            Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
            '
            'RepositoryItemTimeEdit1
            '
            Me.RepositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemTimeEdit1.Name = "RepositoryItemTimeEdit1"
            '
            'gridControl_List
            '
            Me.gridControl_List.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl_List.Location = New System.Drawing.Point(254, 20)
            Me.gridControl_List.MainView = Me.gridView_List
            Me.gridControl_List.MenuManager = Me.BarManager
            Me.gridControl_List.Name = "gridControl_List"
            Me.gridControl_List.Size = New System.Drawing.Size(390, 452)
            Me.gridControl_List.TabIndex = 14
            Me.gridControl_List.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView_List})
            '
            'gridView_List
            '
            Me.gridView_List.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_PDC_Id, Me.colIsPDC, Me.colBank_Name, Me.colPDC_Name, Me.colPDC_Address, Me.colPDC_No, Me.colPDC_Amount, Me.colPDC_Date, Me.colSBD_Amount_Due, Me.colSBD_Maturity_Date, Me.colSBD_Description})
            Me.gridView_List.GridControl = Me.gridControl_List
            Me.gridView_List.Name = "gridView_List"
            Me.gridView_List.OptionsBehavior.Editable = False
            '
            'col_PDC_Id
            '
            Me.col_PDC_Id.FieldName = "PDC_Id"
            Me.col_PDC_Id.Name = "col_PDC_Id"
            Me.col_PDC_Id.Visible = True
            Me.col_PDC_Id.VisibleIndex = 0
            '
            'colIsPDC
            '
            Me.colIsPDC.FieldName = "IsPDC"
            Me.colIsPDC.Name = "colIsPDC"
            Me.colIsPDC.Visible = True
            Me.colIsPDC.VisibleIndex = 1
            '
            'colBank_Name
            '
            Me.colBank_Name.FieldName = "Bank_Name"
            Me.colBank_Name.Name = "colBank_Name"
            Me.colBank_Name.Visible = True
            Me.colBank_Name.VisibleIndex = 2
            '
            'colPDC_Name
            '
            Me.colPDC_Name.FieldName = "Customer_Name"
            Me.colPDC_Name.Name = "colPDC_Name"
            Me.colPDC_Name.Visible = True
            Me.colPDC_Name.VisibleIndex = 3
            '
            'colPDC_Address
            '
            Me.colPDC_Address.FieldName = "Customer_Address"
            Me.colPDC_Address.Name = "colPDC_Address"
            Me.colPDC_Address.Visible = True
            Me.colPDC_Address.VisibleIndex = 4
            '
            'colPDC_No
            '
            Me.colPDC_No.FieldName = "Check_No"
            Me.colPDC_No.Name = "colPDC_No"
            Me.colPDC_No.Visible = True
            Me.colPDC_No.VisibleIndex = 5
            '
            'colPDC_Amount
            '
            Me.colPDC_Amount.FieldName = "Amount"
            Me.colPDC_Amount.Name = "colPDC_Amount"
            Me.colPDC_Amount.Visible = True
            Me.colPDC_Amount.VisibleIndex = 6
            '
            'colPDC_Date
            '
            Me.colPDC_Date.FieldName = "Due_Date"
            Me.colPDC_Date.Name = "colPDC_Date"
            Me.colPDC_Date.Visible = True
            Me.colPDC_Date.VisibleIndex = 7
            '
            'colSBD_Amount_Due
            '
            Me.colSBD_Amount_Due.FieldName = "SBD_Amount_Due"
            Me.colSBD_Amount_Due.Name = "colSBD_Amount_Due"
            Me.colSBD_Amount_Due.Visible = True
            Me.colSBD_Amount_Due.VisibleIndex = 8
            '
            'colSBD_Maturity_Date
            '
            Me.colSBD_Maturity_Date.FieldName = "SBD_Maturity_Date"
            Me.colSBD_Maturity_Date.Name = "colSBD_Maturity_Date"
            Me.colSBD_Maturity_Date.Visible = True
            Me.colSBD_Maturity_Date.VisibleIndex = 9
            '
            'colSBD_Description
            '
            Me.colSBD_Description.FieldName = "PDC_Description"
            Me.colSBD_Description.Name = "colSBD_Description"
            Me.colSBD_Description.Visible = True
            Me.colSBD_Description.VisibleIndex = 10
            '
            'frm_PDC
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(900, 472)
            Me.Controls.Add(Me.gridControl_List)
            Me.Controls.Add(Me.DockPanel2)
            Me.Controls.Add(Me.DockPanel1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "frm_PDC"
            Me.Text = "frm_PDC"
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDate_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDate_Start, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDate_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDate_End, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DockManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DockPanel1.ResumeLayout(False)
            Me.DockPanel1_Container.ResumeLayout(False)
            Me.DockPanel2.ResumeLayout(False)
            Me.DockPanel2_Container.ResumeLayout(False)
            CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemTimeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl_List, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView_List, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Date_Start As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDate_Start As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents BarEditItem_Date_End As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDate_End As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents RepositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Friend WithEvents gridControl_List As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView_List As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents col_PDC_Id As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsPDC As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBank_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPDC_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPDC_Address As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPDC_No As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPDC_Amount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPDC_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSBD_Amount_Due As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSBD_Maturity_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSBD_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents DockManager As DevExpress.XtraBars.Docking.DockManager
        Friend WithEvents DockPanel2 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents DockPanel1 As DevExpress.XtraBars.Docking.DockPanel
        Friend WithEvents DockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Friend WithEvents xuc_Settings As MyClassLibrary.Controls.Settings.xuc_Settings
        Friend WithEvents xuc_PDC As xuc_PDC
    End Class
End Namespace