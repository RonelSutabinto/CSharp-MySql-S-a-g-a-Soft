Namespace Controls.Information.Account
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Accounts
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
        'It can be Modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xuc_Accounts))
            Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsJournal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomer_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedger = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomer_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomer_Address = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAgent_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAgent_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAgent_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAE_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAE_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBrand = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEngine = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colChassis = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colKey_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVAT = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal_Cost = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnit_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRelease_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSale_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAssume_Tag = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOD = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLCP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFinanced = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDP = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAOC = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRebates = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTerms = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterest_Rate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipal_Monthly = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterest_Monthly = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmortization = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipal_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterest_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOutstanding_Balance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate_Granted = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate_Updated = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate_First_Payment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate_Maturity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colSI_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCR_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrev_Branch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrev_Account_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrev_Ledger = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrev_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.Check_Include_Payments = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemcheckEdit_Include_Payments = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries2 = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Unit_Cost = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Amortization_Schedule = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Custom = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approve = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_DisApprove = New DevExpress.XtraBars.BarButtonItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.repositoryItemcheckEdit_Accounts_Closed = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.repositoryItemDateEdit_Date_Granted = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.popupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemcheckEdit_Include_Payments, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemcheckEdit_Accounts_Closed, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit_Date_Granted, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemDateEdit_Date_Granted.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(391, 409)
            Me.gridControl.TabIndex = 3
            Me.gridControl.UseEmbeddedNavigator = True
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsJournal, Me.colCorporation, Me.colBranch_Code, Me.colCustomer_Code, Me.colAccount_Code, Me.colLedger, Me.colCustomer_Name, Me.colCustomer_Address, Me.colAgent_Code, Me.colAgent_Type, Me.colAgent_Name, Me.colAE_Code, Me.colAE_Name, Me.colModel_ID, Me.colModel_Code, Me.colBrand, Me.colModel, Me.colColor, Me.colEngine, Me.colChassis, Me.colKey_Code, Me.colUnit_Cost, Me.colVAT, Me.colTotal_Cost, Me.colUnit_Status, Me.colRelease_Type, Me.colSale_Type, Me.colAssume_Tag, Me.colAccount_Status, Me.colCOD, Me.colLCP, Me.colFinanced, Me.colDP, Me.colAOC, Me.colRebates, Me.colDiscount_ID, Me.colDiscount, Me.colDiscount_Name, Me.colTerms, Me.colInterest_Rate, Me.colPrincipal_Monthly, Me.colInterest_Monthly, Me.colAmortization, Me.colPrincipal_Balance, Me.colInterest_Balance, Me.colOutstanding_Balance, Me.colDate_Granted, Me.colDate_Updated, Me.colDate_First_Payment, Me.colDate_Maturity, Me.colSI_Code, Me.colCR_Code, Me.colPrev_Branch_Code, Me.colPrev_Account_Code, Me.colPrev_Ledger, Me.colPrev_Name, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colApproved_By, Me.colApproved_Date, Me.colNotes})
            Me.gridView.DetailHeight = 431
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.MinWidth = 23
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            Me.colID.Width = 87
            '
            'colIsJournal
            '
            Me.colIsJournal.Caption = "Journal"
            Me.colIsJournal.FieldName = "IsJournal"
            Me.colIsJournal.MinWidth = 23
            Me.colIsJournal.Name = "colIsJournal"
            Me.colIsJournal.Visible = True
            Me.colIsJournal.VisibleIndex = 1
            Me.colIsJournal.Width = 87
            '
            'colCorporation
            '
            Me.colCorporation.FieldName = "Corporation"
            Me.colCorporation.MinWidth = 23
            Me.colCorporation.Name = "colCorporation"
            Me.colCorporation.Visible = True
            Me.colCorporation.VisibleIndex = 2
            Me.colCorporation.Width = 87
            '
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch"
            Me.colBranch_Code.FieldName = "Branch_Code"
            Me.colBranch_Code.MinWidth = 23
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 3
            Me.colBranch_Code.Width = 87
            '
            'colCustomer_Code
            '
            Me.colCustomer_Code.FieldName = "Customer_Code"
            Me.colCustomer_Code.MinWidth = 23
            Me.colCustomer_Code.Name = "colCustomer_Code"
            Me.colCustomer_Code.Visible = True
            Me.colCustomer_Code.VisibleIndex = 4
            Me.colCustomer_Code.Width = 87
            '
            'colAccount_Code
            '
            Me.colAccount_Code.FieldName = "Account_Code"
            Me.colAccount_Code.MinWidth = 23
            Me.colAccount_Code.Name = "colAccount_Code"
            Me.colAccount_Code.Visible = True
            Me.colAccount_Code.VisibleIndex = 5
            Me.colAccount_Code.Width = 87
            '
            'colLedger
            '
            Me.colLedger.FieldName = "Ledger"
            Me.colLedger.MinWidth = 23
            Me.colLedger.Name = "colLedger"
            Me.colLedger.Visible = True
            Me.colLedger.VisibleIndex = 6
            Me.colLedger.Width = 87
            '
            'colCustomer_Name
            '
            Me.colCustomer_Name.FieldName = "Customer_Name"
            Me.colCustomer_Name.MinWidth = 23
            Me.colCustomer_Name.Name = "colCustomer_Name"
            Me.colCustomer_Name.Visible = True
            Me.colCustomer_Name.VisibleIndex = 7
            Me.colCustomer_Name.Width = 87
            '
            'colCustomer_Address
            '
            Me.colCustomer_Address.FieldName = "Customer_Address"
            Me.colCustomer_Address.MinWidth = 23
            Me.colCustomer_Address.Name = "colCustomer_Address"
            Me.colCustomer_Address.Visible = True
            Me.colCustomer_Address.VisibleIndex = 8
            Me.colCustomer_Address.Width = 87
            '
            'colAgent_Code
            '
            Me.colAgent_Code.FieldName = "Agent_Code"
            Me.colAgent_Code.MinWidth = 23
            Me.colAgent_Code.Name = "colAgent_Code"
            Me.colAgent_Code.Visible = True
            Me.colAgent_Code.VisibleIndex = 9
            Me.colAgent_Code.Width = 87
            '
            'colAgent_Type
            '
            Me.colAgent_Type.FieldName = "Agent_Type"
            Me.colAgent_Type.MinWidth = 23
            Me.colAgent_Type.Name = "colAgent_Type"
            Me.colAgent_Type.Visible = True
            Me.colAgent_Type.VisibleIndex = 10
            Me.colAgent_Type.Width = 87
            '
            'colAgent_Name
            '
            Me.colAgent_Name.FieldName = "Agent_Name"
            Me.colAgent_Name.MinWidth = 23
            Me.colAgent_Name.Name = "colAgent_Name"
            Me.colAgent_Name.Visible = True
            Me.colAgent_Name.VisibleIndex = 11
            Me.colAgent_Name.Width = 87
            '
            'colAE_Code
            '
            Me.colAE_Code.FieldName = "AE_Code"
            Me.colAE_Code.MinWidth = 23
            Me.colAE_Code.Name = "colAE_Code"
            Me.colAE_Code.Visible = True
            Me.colAE_Code.VisibleIndex = 12
            Me.colAE_Code.Width = 87
            '
            'colAE_Name
            '
            Me.colAE_Name.FieldName = "AE_Name"
            Me.colAE_Name.MinWidth = 23
            Me.colAE_Name.Name = "colAE_Name"
            Me.colAE_Name.Visible = True
            Me.colAE_Name.VisibleIndex = 13
            Me.colAE_Name.Width = 87
            '
            'colModel_ID
            '
            Me.colModel_ID.FieldName = "Model_ID"
            Me.colModel_ID.MinWidth = 23
            Me.colModel_ID.Name = "colModel_ID"
            Me.colModel_ID.Visible = True
            Me.colModel_ID.VisibleIndex = 14
            Me.colModel_ID.Width = 87
            '
            'colModel_Code
            '
            Me.colModel_Code.FieldName = "Model_Code"
            Me.colModel_Code.MinWidth = 23
            Me.colModel_Code.Name = "colModel_Code"
            Me.colModel_Code.Visible = True
            Me.colModel_Code.VisibleIndex = 15
            Me.colModel_Code.Width = 87
            '
            'colBrand
            '
            Me.colBrand.FieldName = "Brand"
            Me.colBrand.MinWidth = 23
            Me.colBrand.Name = "colBrand"
            Me.colBrand.Visible = True
            Me.colBrand.VisibleIndex = 16
            Me.colBrand.Width = 87
            '
            'colModel
            '
            Me.colModel.FieldName = "Model"
            Me.colModel.MinWidth = 23
            Me.colModel.Name = "colModel"
            Me.colModel.Visible = True
            Me.colModel.VisibleIndex = 17
            Me.colModel.Width = 87
            '
            'colColor
            '
            Me.colColor.FieldName = "Color"
            Me.colColor.MinWidth = 23
            Me.colColor.Name = "colColor"
            Me.colColor.Visible = True
            Me.colColor.VisibleIndex = 18
            Me.colColor.Width = 87
            '
            'colEngine
            '
            Me.colEngine.FieldName = "Engine"
            Me.colEngine.MinWidth = 23
            Me.colEngine.Name = "colEngine"
            Me.colEngine.Visible = True
            Me.colEngine.VisibleIndex = 19
            Me.colEngine.Width = 87
            '
            'colChassis
            '
            Me.colChassis.FieldName = "Chassis"
            Me.colChassis.MinWidth = 23
            Me.colChassis.Name = "colChassis"
            Me.colChassis.Visible = True
            Me.colChassis.VisibleIndex = 20
            Me.colChassis.Width = 87
            '
            'colKey_Code
            '
            Me.colKey_Code.FieldName = "Key_Code"
            Me.colKey_Code.MinWidth = 23
            Me.colKey_Code.Name = "colKey_Code"
            Me.colKey_Code.Visible = True
            Me.colKey_Code.VisibleIndex = 21
            Me.colKey_Code.Width = 87
            '
            'colUnit_Cost
            '
            Me.colUnit_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnit_Cost.FieldName = "Unit_Cost"
            Me.colUnit_Cost.MinWidth = 23
            Me.colUnit_Cost.Name = "colUnit_Cost"
            Me.colUnit_Cost.Visible = True
            Me.colUnit_Cost.VisibleIndex = 22
            Me.colUnit_Cost.Width = 87
            '
            'colVAT
            '
            Me.colVAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colVAT.FieldName = "VAT"
            Me.colVAT.MinWidth = 23
            Me.colVAT.Name = "colVAT"
            Me.colVAT.Visible = True
            Me.colVAT.VisibleIndex = 23
            Me.colVAT.Width = 87
            '
            'colTotal_Cost
            '
            Me.colTotal_Cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Cost.FieldName = "Total_Cost"
            Me.colTotal_Cost.MinWidth = 23
            Me.colTotal_Cost.Name = "colTotal_Cost"
            Me.colTotal_Cost.Visible = True
            Me.colTotal_Cost.VisibleIndex = 24
            Me.colTotal_Cost.Width = 87
            '
            'colUnit_Status
            '
            Me.colUnit_Status.FieldName = "Unit_Status"
            Me.colUnit_Status.MinWidth = 23
            Me.colUnit_Status.Name = "colUnit_Status"
            Me.colUnit_Status.Visible = True
            Me.colUnit_Status.VisibleIndex = 25
            Me.colUnit_Status.Width = 87
            '
            'colRelease_Type
            '
            Me.colRelease_Type.FieldName = "Release_Type"
            Me.colRelease_Type.MinWidth = 23
            Me.colRelease_Type.Name = "colRelease_Type"
            Me.colRelease_Type.Visible = True
            Me.colRelease_Type.VisibleIndex = 26
            Me.colRelease_Type.Width = 87
            '
            'colSale_Type
            '
            Me.colSale_Type.FieldName = "Sale_Type"
            Me.colSale_Type.MinWidth = 23
            Me.colSale_Type.Name = "colSale_Type"
            Me.colSale_Type.Visible = True
            Me.colSale_Type.VisibleIndex = 27
            Me.colSale_Type.Width = 87
            '
            'colAssume_Tag
            '
            Me.colAssume_Tag.FieldName = "Assume_Tag"
            Me.colAssume_Tag.MinWidth = 23
            Me.colAssume_Tag.Name = "colAssume_Tag"
            Me.colAssume_Tag.Visible = True
            Me.colAssume_Tag.VisibleIndex = 28
            Me.colAssume_Tag.Width = 87
            '
            'colAccount_Status
            '
            Me.colAccount_Status.FieldName = "Account_Status"
            Me.colAccount_Status.MinWidth = 23
            Me.colAccount_Status.Name = "colAccount_Status"
            Me.colAccount_Status.Visible = True
            Me.colAccount_Status.VisibleIndex = 29
            Me.colAccount_Status.Width = 87
            '
            'colCOD
            '
            Me.colCOD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colCOD.FieldName = "COD"
            Me.colCOD.MinWidth = 23
            Me.colCOD.Name = "colCOD"
            Me.colCOD.Visible = True
            Me.colCOD.VisibleIndex = 30
            Me.colCOD.Width = 87
            '
            'colLCP
            '
            Me.colLCP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colLCP.FieldName = "LCP"
            Me.colLCP.MinWidth = 23
            Me.colLCP.Name = "colLCP"
            Me.colLCP.Visible = True
            Me.colLCP.VisibleIndex = 31
            Me.colLCP.Width = 87
            '
            'colFinanced
            '
            Me.colFinanced.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colFinanced.FieldName = "Financed"
            Me.colFinanced.MinWidth = 23
            Me.colFinanced.Name = "colFinanced"
            Me.colFinanced.Visible = True
            Me.colFinanced.VisibleIndex = 32
            Me.colFinanced.Width = 87
            '
            'colDP
            '
            Me.colDP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDP.FieldName = "DP"
            Me.colDP.MinWidth = 23
            Me.colDP.Name = "colDP"
            Me.colDP.Visible = True
            Me.colDP.VisibleIndex = 33
            Me.colDP.Width = 87
            '
            'colAOC
            '
            Me.colAOC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAOC.FieldName = "AOC"
            Me.colAOC.MinWidth = 23
            Me.colAOC.Name = "colAOC"
            Me.colAOC.Visible = True
            Me.colAOC.VisibleIndex = 34
            Me.colAOC.Width = 87
            '
            'colRebates
            '
            Me.colRebates.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRebates.FieldName = "Rebates"
            Me.colRebates.MinWidth = 23
            Me.colRebates.Name = "colRebates"
            Me.colRebates.Visible = True
            Me.colRebates.VisibleIndex = 35
            Me.colRebates.Width = 87
            '
            'colDiscount_ID
            '
            Me.colDiscount_ID.FieldName = "Disc_ID"
            Me.colDiscount_ID.MinWidth = 23
            Me.colDiscount_ID.Name = "colDiscount_ID"
            Me.colDiscount_ID.Visible = True
            Me.colDiscount_ID.VisibleIndex = 36
            Me.colDiscount_ID.Width = 87
            '
            'colDiscount
            '
            Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.MinWidth = 23
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 37
            Me.colDiscount.Width = 87
            '
            'colDiscount_Name
            '
            Me.colDiscount_Name.FieldName = "Discount_Name"
            Me.colDiscount_Name.MinWidth = 23
            Me.colDiscount_Name.Name = "colDiscount_Name"
            Me.colDiscount_Name.Visible = True
            Me.colDiscount_Name.VisibleIndex = 38
            Me.colDiscount_Name.Width = 87
            '
            'colTerms
            '
            Me.colTerms.FieldName = "Terms"
            Me.colTerms.MinWidth = 23
            Me.colTerms.Name = "colTerms"
            Me.colTerms.Visible = True
            Me.colTerms.VisibleIndex = 39
            Me.colTerms.Width = 87
            '
            'colInterest_Rate
            '
            Me.colInterest_Rate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterest_Rate.FieldName = "Interest_Rate"
            Me.colInterest_Rate.MinWidth = 23
            Me.colInterest_Rate.Name = "colInterest_Rate"
            Me.colInterest_Rate.Visible = True
            Me.colInterest_Rate.VisibleIndex = 40
            Me.colInterest_Rate.Width = 87
            '
            'colPrincipal_Monthly
            '
            Me.colPrincipal_Monthly.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipal_Monthly.FieldName = "Principal_Monthly"
            Me.colPrincipal_Monthly.MinWidth = 23
            Me.colPrincipal_Monthly.Name = "colPrincipal_Monthly"
            Me.colPrincipal_Monthly.Visible = True
            Me.colPrincipal_Monthly.VisibleIndex = 41
            Me.colPrincipal_Monthly.Width = 87
            '
            'colInterest_Monthly
            '
            Me.colInterest_Monthly.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterest_Monthly.FieldName = "Interest_Monthly"
            Me.colInterest_Monthly.MinWidth = 23
            Me.colInterest_Monthly.Name = "colInterest_Monthly"
            Me.colInterest_Monthly.Visible = True
            Me.colInterest_Monthly.VisibleIndex = 42
            Me.colInterest_Monthly.Width = 87
            '
            'colAmortization
            '
            Me.colAmortization.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmortization.FieldName = "Amortization"
            Me.colAmortization.MinWidth = 23
            Me.colAmortization.Name = "colAmortization"
            Me.colAmortization.Visible = True
            Me.colAmortization.VisibleIndex = 43
            Me.colAmortization.Width = 87
            '
            'colPrincipal_Balance
            '
            Me.colPrincipal_Balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipal_Balance.FieldName = "Principal_Balance"
            Me.colPrincipal_Balance.MinWidth = 23
            Me.colPrincipal_Balance.Name = "colPrincipal_Balance"
            Me.colPrincipal_Balance.Visible = True
            Me.colPrincipal_Balance.VisibleIndex = 44
            Me.colPrincipal_Balance.Width = 87
            '
            'colInterest_Balance
            '
            Me.colInterest_Balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterest_Balance.FieldName = "Interest_Balance"
            Me.colInterest_Balance.MinWidth = 23
            Me.colInterest_Balance.Name = "colInterest_Balance"
            Me.colInterest_Balance.Visible = True
            Me.colInterest_Balance.VisibleIndex = 45
            Me.colInterest_Balance.Width = 87
            '
            'colOutstanding_Balance
            '
            Me.colOutstanding_Balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colOutstanding_Balance.FieldName = "Outstanding_Balance"
            Me.colOutstanding_Balance.MinWidth = 23
            Me.colOutstanding_Balance.Name = "colOutstanding_Balance"
            Me.colOutstanding_Balance.Visible = True
            Me.colOutstanding_Balance.VisibleIndex = 46
            Me.colOutstanding_Balance.Width = 87
            '
            'colDate_Granted
            '
            Me.colDate_Granted.FieldName = "Date_Granted"
            Me.colDate_Granted.MinWidth = 23
            Me.colDate_Granted.Name = "colDate_Granted"
            Me.colDate_Granted.Visible = True
            Me.colDate_Granted.VisibleIndex = 47
            Me.colDate_Granted.Width = 87
            '
            'colDate_Updated
            '
            Me.colDate_Updated.FieldName = "Date_Updated"
            Me.colDate_Updated.MinWidth = 23
            Me.colDate_Updated.Name = "colDate_Updated"
            Me.colDate_Updated.Visible = True
            Me.colDate_Updated.VisibleIndex = 48
            Me.colDate_Updated.Width = 87
            '
            'colDate_First_Payment
            '
            Me.colDate_First_Payment.FieldName = "Date_First_Payment"
            Me.colDate_First_Payment.MinWidth = 23
            Me.colDate_First_Payment.Name = "colDate_First_Payment"
            Me.colDate_First_Payment.Visible = True
            Me.colDate_First_Payment.VisibleIndex = 49
            Me.colDate_First_Payment.Width = 87
            '
            'colDate_Maturity
            '
            Me.colDate_Maturity.FieldName = "Date_Maturity"
            Me.colDate_Maturity.MinWidth = 23
            Me.colDate_Maturity.Name = "colDate_Maturity"
            Me.colDate_Maturity.Visible = True
            Me.colDate_Maturity.VisibleIndex = 50
            Me.colDate_Maturity.Width = 87
            '
            'colSI_Code
            '
            Me.colSI_Code.FieldName = "SI_Code"
            Me.colSI_Code.MinWidth = 23
            Me.colSI_Code.Name = "colSI_Code"
            Me.colSI_Code.Visible = True
            Me.colSI_Code.VisibleIndex = 51
            Me.colSI_Code.Width = 87
            '
            'colCR_Code
            '
            Me.colCR_Code.FieldName = "CR_Code"
            Me.colCR_Code.MinWidth = 23
            Me.colCR_Code.Name = "colCR_Code"
            Me.colCR_Code.Visible = True
            Me.colCR_Code.VisibleIndex = 52
            Me.colCR_Code.Width = 87
            '
            'colPrev_Branch_Code
            '
            Me.colPrev_Branch_Code.Caption = "Prev_Branch"
            Me.colPrev_Branch_Code.FieldName = "Prev_Branch_Code"
            Me.colPrev_Branch_Code.MinWidth = 23
            Me.colPrev_Branch_Code.Name = "colPrev_Branch_Code"
            Me.colPrev_Branch_Code.Visible = True
            Me.colPrev_Branch_Code.VisibleIndex = 53
            Me.colPrev_Branch_Code.Width = 87
            '
            'colPrev_Account_Code
            '
            Me.colPrev_Account_Code.FieldName = "Prev_Account_Code"
            Me.colPrev_Account_Code.MinWidth = 23
            Me.colPrev_Account_Code.Name = "colPrev_Account_Code"
            Me.colPrev_Account_Code.Visible = True
            Me.colPrev_Account_Code.VisibleIndex = 54
            Me.colPrev_Account_Code.Width = 87
            '
            'colPrev_Ledger
            '
            Me.colPrev_Ledger.FieldName = "Prev_Ledger"
            Me.colPrev_Ledger.MinWidth = 23
            Me.colPrev_Ledger.Name = "colPrev_Ledger"
            Me.colPrev_Ledger.Visible = True
            Me.colPrev_Ledger.VisibleIndex = 55
            Me.colPrev_Ledger.Width = 87
            '
            'colPrev_Name
            '
            Me.colPrev_Name.Caption = "Prev Customer Name"
            Me.colPrev_Name.FieldName = "Prev_Name"
            Me.colPrev_Name.MinWidth = 23
            Me.colPrev_Name.Name = "colPrev_Name"
            Me.colPrev_Name.Visible = True
            Me.colPrev_Name.VisibleIndex = 56
            Me.colPrev_Name.Width = 87
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.MinWidth = 23
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 57
            Me.colAdded_By.Width = 87
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.MinWidth = 23
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 58
            Me.colAdded_Date.Width = 87
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.MinWidth = 23
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 59
            Me.colModified_By.Width = 87
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.MinWidth = 23
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 60
            Me.colModified_Date.Width = 87
            '
            'colApproved_By
            '
            Me.colApproved_By.FieldName = "Approved_By"
            Me.colApproved_By.MinWidth = 23
            Me.colApproved_By.Name = "colApproved_By"
            Me.colApproved_By.Visible = True
            Me.colApproved_By.VisibleIndex = 61
            Me.colApproved_By.Width = 87
            '
            'colApproved_Date
            '
            Me.colApproved_Date.FieldName = "Approved_Date"
            Me.colApproved_Date.MinWidth = 23
            Me.colApproved_Date.Name = "colApproved_Date"
            Me.colApproved_Date.Visible = True
            Me.colApproved_Date.VisibleIndex = 62
            Me.colApproved_Date.Width = 87
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.MinWidth = 23
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 63
            Me.colNotes.Width = 87
            '
            'barManager
            '
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Preview, Me.btn_Journal, Me.btn_Stop, Me.Check_Include_Payments, Me.btn_Journal_Entries, Me.btn_Verify, Me.btn_Journal_Entries2, Me.btn_Unit_Cost, Me.btn_Amortization_Schedule, Me.btn_Custom, Me.btn_Approve, Me.btn_DisApprove})
            Me.barManager.MaxItemId = 27
            Me.barManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSearchControl_Search, Me.repositoryItemcheckEdit_Accounts_Closed, Me.repositoryItemDateEdit_Date_Granted, Me.RepositoryItemcheckEdit_Include_Payments})
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.barDockControlTop.Size = New System.Drawing.Size(391, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 409)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.barDockControlBottom.Size = New System.Drawing.Size(391, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 409)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(391, 0)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 409)
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
            Me.btn_Preview.Id = 9
            Me.btn_Preview.ImageOptions.ImageIndex = 1
            Me.btn_Preview.ImageOptions.LargeImageIndex = 1
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_Journal
            '
            Me.btn_Journal.Caption = "Journal"
            Me.btn_Journal.Id = 14
            Me.btn_Journal.ImageOptions.ImageIndex = 4
            Me.btn_Journal.ImageOptions.LargeImageIndex = 4
            Me.btn_Journal.Name = "btn_Journal"
            '
            'btn_Stop
            '
            Me.btn_Stop.Caption = "Sto&p"
            Me.btn_Stop.Id = 15
            Me.btn_Stop.ImageOptions.ImageIndex = 5
            Me.btn_Stop.ImageOptions.LargeImageIndex = 5
            Me.btn_Stop.Name = "btn_Stop"
            '
            'Check_Include_Payments
            '
            Me.Check_Include_Payments.Caption = "Include Payments"
            Me.Check_Include_Payments.Edit = Me.RepositoryItemcheckEdit_Include_Payments
            Me.Check_Include_Payments.Id = 18
            Me.Check_Include_Payments.ImageOptions.ImageIndex = 2
            Me.Check_Include_Payments.ImageOptions.LargeImageIndex = 2
            Me.Check_Include_Payments.Name = "Check_Include_Payments"
            '
            'RepositoryItemcheckEdit_Include_Payments
            '
            Me.RepositoryItemcheckEdit_Include_Payments.AutoHeight = False
            Me.RepositoryItemcheckEdit_Include_Payments.Name = "RepositoryItemcheckEdit_Include_Payments"
            '
            'btn_Journal_Entries
            '
            Me.btn_Journal_Entries.Caption = "Journal Entries"
            Me.btn_Journal_Entries.Id = 19
            Me.btn_Journal_Entries.ImageOptions.ImageIndex = 3
            Me.btn_Journal_Entries.ImageOptions.LargeImageIndex = 3
            Me.btn_Journal_Entries.Name = "btn_Journal_Entries"
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 20
            Me.btn_Verify.ImageOptions.ImageIndex = 6
            Me.btn_Verify.ImageOptions.LargeImageIndex = 6
            Me.btn_Verify.Name = "btn_Verify"
            '
            'btn_Journal_Entries2
            '
            Me.btn_Journal_Entries2.Caption = "Journal Entries 2"
            Me.btn_Journal_Entries2.Id = 21
            Me.btn_Journal_Entries2.Name = "btn_Journal_Entries2"
            '
            'btn_Unit_Cost
            '
            Me.btn_Unit_Cost.Caption = "Unit Cost"
            Me.btn_Unit_Cost.Id = 22
            Me.btn_Unit_Cost.ImageOptions.Image = CType(resources.GetObject("btn_Unit_Cost.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Unit_Cost.ImageOptions.LargeImage = CType(resources.GetObject("btn_Unit_Cost.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Unit_Cost.Name = "btn_Unit_Cost"
            '
            'btn_Amortization_Schedule
            '
            Me.btn_Amortization_Schedule.Caption = "Amortization Schedule"
            Me.btn_Amortization_Schedule.Id = 23
            Me.btn_Amortization_Schedule.ImageOptions.Image = CType(resources.GetObject("btn_Amortization_Schedule.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Amortization_Schedule.ImageOptions.LargeImage = CType(resources.GetObject("btn_Amortization_Schedule.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Amortization_Schedule.Name = "btn_Amortization_Schedule"
            '
            'btn_Custom
            '
            Me.btn_Custom.Caption = "Custom"
            Me.btn_Custom.Id = 24
            Me.btn_Custom.ImageOptions.Image = CType(resources.GetObject("btn_Custom.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Custom.ImageOptions.LargeImage = CType(resources.GetObject("btn_Custom.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Custom.Name = "btn_Custom"
            '
            'btn_Approve
            '
            Me.btn_Approve.Caption = "Approve"
            Me.btn_Approve.Id = 25
            Me.btn_Approve.Name = "btn_Approve"
            '
            'btn_DisApprove
            '
            Me.btn_DisApprove.Caption = "DisApprove"
            Me.btn_DisApprove.Id = 26
            Me.btn_DisApprove.Name = "btn_DisApprove"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Clear, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            Me.RepositoryItemSearchControl_Search.ShowClearButton = False
            Me.RepositoryItemSearchControl_Search.ShowSearchButton = False
            '
            'repositoryItemcheckEdit_Accounts_Closed
            '
            Me.repositoryItemcheckEdit_Accounts_Closed.AutoHeight = False
            Me.repositoryItemcheckEdit_Accounts_Closed.Name = "repositoryItemcheckEdit_Accounts_Closed"
            '
            'repositoryItemDateEdit_Date_Granted
            '
            Me.repositoryItemDateEdit_Date_Granted.AutoHeight = False
            Me.repositoryItemDateEdit_Date_Granted.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit_Date_Granted.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemDateEdit_Date_Granted.Name = "repositoryItemDateEdit_Date_Granted"
            '
            'popupMenu
            '
            Me.popupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Check_Include_Payments, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries2), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Unit_Cost, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Amortization_Schedule), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Stop, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Custom), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approve, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_DisApprove)})
            Me.popupMenu.Manager = Me.barManager
            Me.popupMenu.Name = "popupMenu"
            '
            'xuc_Accounts
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "xuc_Accounts"
            Me.Size = New System.Drawing.Size(391, 409)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemcheckEdit_Include_Payments, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemcheckEdit_Accounts_Closed, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit_Date_Granted.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemDateEdit_Date_Granted, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.popupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Public WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents repositoryItemDateEdit_Date_Granted As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents repositoryItemcheckEdit_Accounts_Closed As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents popupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents Check_Include_Payments As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemcheckEdit_Include_Payments As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents btn_Journal_Entries2 As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Unit_Cost As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Amortization_Schedule As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Custom As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approve As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_DisApprove As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsJournal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCustomer_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedger As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCustomer_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCustomer_Address As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAgent_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAgent_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAE_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAgent_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBrand As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModel As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colEngine As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colChassis As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colKey_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVAT As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTotal_Cost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colUnit_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRelease_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSale_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOD As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLCP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colFinanced As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDP As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAOC As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colRebates As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscount_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDiscount_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTerms As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterest_Rate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipal_Monthly As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterest_Monthly As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmortization As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipal_Balance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterest_Balance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOutstanding_Balance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDate_Granted As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDate_Updated As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDate_First_Payment As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDate_Maturity As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colSI_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCR_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrev_Branch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrev_Account_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrev_Ledger As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrev_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAE_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAssume_Tag As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace