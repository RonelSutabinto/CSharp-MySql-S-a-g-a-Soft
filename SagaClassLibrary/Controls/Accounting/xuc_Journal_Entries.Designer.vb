Namespace Controls.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Journal_Entries
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
            Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xuc_Journal_Entries))
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsVerified = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTable_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemComboBox_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.colBranch_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colCOA_Summary = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_COA_Summary = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colCOA_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_COA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colJournal_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemCalcEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.colJournal_Credit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck_Number = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_Check_Numbers = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colJournal_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemComboBox_Type = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.colJournal_Profile = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemComboBox_Profile = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.colAccount_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemPopupContainerEdit = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
            Me.PopupContainerControl = New DevExpress.XtraEditors.PopupContainerControl()
            Me.xuc_Account_Search = New SagaClassLibrary.Controls.Information.Account.xuc_Account_Search()
            Me.colJournal_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPosted_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPosting_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.colTransacted_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransaction_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocked_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocked_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.btn_New = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Save = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Print_Check = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approval = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Validate = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Approve = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Initialize = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Update = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Verify = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Regenerate_Codes = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Batch_Transactions = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Insert = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Lock = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Journal_Entries2 = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Ledger = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Error_Report = New DevExpress.XtraBars.BarButtonItem()
            Me.RepositoryItemTextEdit_Document_Title = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.RepositoryItemcheckEdit_Check_Unbalanced = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.RepositoryItemcheckEdit_Check_Auto_Credit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
            Me.RepositoryItemComboBox_Paper_Size = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.RepositoryItemTextEdit_Remarks = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.RepositoryItemComboBox_Document_Title = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_COA_Summary, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Check_Numbers, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Type, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Profile, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemPopupContainerEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PopupContainerControl.SuspendLayout()
            CType(Me.RepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemTextEdit_Document_Title, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemcheckEdit_Check_Unbalanced, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemcheckEdit_Check_Auto_Credit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Paper_Size, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemTextEdit_Remarks, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Document_Title, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            GridLevelNode1.RelationName = "Level1"
            Me.gridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit_Branch, Me.RepositoryItemLookUpEdit_COA, Me.RepositoryItemCalcEdit, Me.RepositoryItemComboBox_Profile, Me.RepositoryItemDateEdit, Me.RepositoryItemComboBox_Type, Me.RepositoryItemPopupContainerEdit, Me.RepositoryItemComboBox_Corporation, Me.RepositoryItemLookUpEdit_Check_Numbers, Me.RepositoryItemLookUpEdit_COA_Summary})
            Me.gridControl.Size = New System.Drawing.Size(599, 337)
            Me.gridControl.TabIndex = 3
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsVerified, Me.colTable_ID, Me.colJournal_Code, Me.colCorporation, Me.colBranch_Code, Me.colCOA_Summary, Me.colCOA_Code, Me.colCOA_Name, Me.colJournal_Debit, Me.colJournal_Credit, Me.colCheck_Number, Me.colJournal_Type, Me.colJournal_Profile, Me.colAccount_Code, Me.colAccount_Name, Me.colJournal_Description, Me.colJournal_Status, Me.colNotes, Me.colPosted_By, Me.colPosting_Date, Me.colTransacted_By, Me.colTransaction_Date, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colApproved_By, Me.colApproved_Date, Me.colLocked_By, Me.colLocked_Date})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.Caption = "ID"
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.OptionsColumn.AllowEdit = False
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colIsVerified
            '
            Me.colIsVerified.Caption = "Verified"
            Me.colIsVerified.FieldName = "IsVerified"
            Me.colIsVerified.Name = "colIsVerified"
            Me.colIsVerified.OptionsColumn.AllowEdit = False
            Me.colIsVerified.Visible = True
            Me.colIsVerified.VisibleIndex = 1
            '
            'colTable_ID
            '
            Me.colTable_ID.Caption = "Table ID"
            Me.colTable_ID.FieldName = "Table_ID"
            Me.colTable_ID.Name = "colTable_ID"
            Me.colTable_ID.OptionsColumn.AllowEdit = False
            Me.colTable_ID.Visible = True
            Me.colTable_ID.VisibleIndex = 2
            Me.colTable_ID.Width = 73
            '
            'colJournal_Code
            '
            Me.colJournal_Code.Caption = "Journal Code"
            Me.colJournal_Code.FieldName = "Journal_Code"
            Me.colJournal_Code.Name = "colJournal_Code"
            Me.colJournal_Code.OptionsColumn.AllowEdit = False
            Me.colJournal_Code.Visible = True
            Me.colJournal_Code.VisibleIndex = 3
            '
            'colCorporation
            '
            Me.colCorporation.Caption = "Corporation"
            Me.colCorporation.ColumnEdit = Me.RepositoryItemComboBox_Corporation
            Me.colCorporation.FieldName = "Corporation"
            Me.colCorporation.Name = "colCorporation"
            Me.colCorporation.Visible = True
            Me.colCorporation.VisibleIndex = 4
            '
            'RepositoryItemComboBox_Corporation
            '
            Me.RepositoryItemComboBox_Corporation.AutoHeight = False
            Me.RepositoryItemComboBox_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Corporation.Items.AddRange(New Object() {"SFC", "SMC"})
            Me.RepositoryItemComboBox_Corporation.Name = "RepositoryItemComboBox_Corporation"
            Me.RepositoryItemComboBox_Corporation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'colBranch_Code
            '
            Me.colBranch_Code.Caption = "Branch"
            Me.colBranch_Code.ColumnEdit = Me.repositoryItemLookUpEdit_Branch
            Me.colBranch_Code.FieldName = "Branch_Code"
            Me.colBranch_Code.Name = "colBranch_Code"
            Me.colBranch_Code.Visible = True
            Me.colBranch_Code.VisibleIndex = 5
            '
            'repositoryItemLookUpEdit_Branch
            '
            Me.repositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.repositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit_Branch.Name = "repositoryItemLookUpEdit_Branch"
            '
            'colCOA_Summary
            '
            Me.colCOA_Summary.Caption = "Summary"
            Me.colCOA_Summary.ColumnEdit = Me.RepositoryItemLookUpEdit_COA_Summary
            Me.colCOA_Summary.FieldName = "COA_Summary"
            Me.colCOA_Summary.Name = "colCOA_Summary"
            Me.colCOA_Summary.OptionsColumn.AllowEdit = False
            Me.colCOA_Summary.Visible = True
            Me.colCOA_Summary.VisibleIndex = 6
            '
            'RepositoryItemLookUpEdit_COA_Summary
            '
            Me.RepositoryItemLookUpEdit_COA_Summary.AutoHeight = False
            Me.RepositoryItemLookUpEdit_COA_Summary.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_COA_Summary.Name = "RepositoryItemLookUpEdit_COA_Summary"
            '
            'colCOA_Code
            '
            Me.colCOA_Code.Caption = "Code"
            Me.colCOA_Code.FieldName = "COA_Code"
            Me.colCOA_Code.Name = "colCOA_Code"
            Me.colCOA_Code.OptionsColumn.AllowEdit = False
            Me.colCOA_Code.Visible = True
            Me.colCOA_Code.VisibleIndex = 7
            '
            'colCOA_Name
            '
            Me.colCOA_Name.Caption = "Account Title"
            Me.colCOA_Name.ColumnEdit = Me.RepositoryItemLookUpEdit_COA
            Me.colCOA_Name.FieldName = "COA_Code"
            Me.colCOA_Name.Name = "colCOA_Name"
            Me.colCOA_Name.Visible = True
            Me.colCOA_Name.VisibleIndex = 8
            Me.colCOA_Name.Width = 1952
            '
            'RepositoryItemLookUpEdit_COA
            '
            Me.RepositoryItemLookUpEdit_COA.AutoHeight = False
            Me.RepositoryItemLookUpEdit_COA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_COA.Name = "RepositoryItemLookUpEdit_COA"
            Me.RepositoryItemLookUpEdit_COA.NullText = ""
            '
            'colJournal_Debit
            '
            Me.colJournal_Debit.Caption = "Debit"
            Me.colJournal_Debit.ColumnEdit = Me.RepositoryItemCalcEdit
            Me.colJournal_Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colJournal_Debit.FieldName = "Journal_Debit"
            Me.colJournal_Debit.Name = "colJournal_Debit"
            Me.colJournal_Debit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Journal_Debit", "SUM={0:N2}")})
            Me.colJournal_Debit.Visible = True
            Me.colJournal_Debit.VisibleIndex = 9
            '
            'RepositoryItemCalcEdit
            '
            Me.RepositoryItemCalcEdit.AutoHeight = False
            Me.RepositoryItemCalcEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit.Name = "RepositoryItemCalcEdit"
            Me.RepositoryItemCalcEdit.NullText = "0.00"
            '
            'colJournal_Credit
            '
            Me.colJournal_Credit.Caption = "Credit"
            Me.colJournal_Credit.ColumnEdit = Me.RepositoryItemCalcEdit
            Me.colJournal_Credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colJournal_Credit.FieldName = "Journal_Credit"
            Me.colJournal_Credit.Name = "colJournal_Credit"
            Me.colJournal_Credit.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Journal_Credit", "SUM={0:N2}")})
            Me.colJournal_Credit.Visible = True
            Me.colJournal_Credit.VisibleIndex = 10
            '
            'colCheck_Number
            '
            Me.colCheck_Number.Caption = "Check"
            Me.colCheck_Number.ColumnEdit = Me.RepositoryItemLookUpEdit_Check_Numbers
            Me.colCheck_Number.FieldName = "Check_Number"
            Me.colCheck_Number.Name = "colCheck_Number"
            Me.colCheck_Number.Visible = True
            Me.colCheck_Number.VisibleIndex = 11
            '
            'RepositoryItemLookUpEdit_Check_Numbers
            '
            Me.RepositoryItemLookUpEdit_Check_Numbers.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Check_Numbers.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Check_Numbers.Name = "RepositoryItemLookUpEdit_Check_Numbers"
            '
            'colJournal_Type
            '
            Me.colJournal_Type.Caption = "Type"
            Me.colJournal_Type.ColumnEdit = Me.RepositoryItemComboBox_Type
            Me.colJournal_Type.FieldName = "Journal_Type"
            Me.colJournal_Type.Name = "colJournal_Type"
            Me.colJournal_Type.Visible = True
            Me.colJournal_Type.VisibleIndex = 12
            '
            'RepositoryItemComboBox_Type
            '
            Me.RepositoryItemComboBox_Type.AutoHeight = False
            Me.RepositoryItemComboBox_Type.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Type.Name = "RepositoryItemComboBox_Type"
            '
            'colJournal_Profile
            '
            Me.colJournal_Profile.Caption = "Profile"
            Me.colJournal_Profile.ColumnEdit = Me.RepositoryItemComboBox_Profile
            Me.colJournal_Profile.FieldName = "Journal_Profile"
            Me.colJournal_Profile.Name = "colJournal_Profile"
            Me.colJournal_Profile.Visible = True
            Me.colJournal_Profile.VisibleIndex = 13
            '
            'RepositoryItemComboBox_Profile
            '
            Me.RepositoryItemComboBox_Profile.AutoHeight = False
            Me.RepositoryItemComboBox_Profile.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Profile.Name = "RepositoryItemComboBox_Profile"
            Me.RepositoryItemComboBox_Profile.NullValuePrompt = "Select Type..."
            Me.RepositoryItemComboBox_Profile.Sorted = True
            '
            'colAccount_Code
            '
            Me.colAccount_Code.Caption = "Account Code"
            Me.colAccount_Code.FieldName = "Account_Code"
            Me.colAccount_Code.Name = "colAccount_Code"
            Me.colAccount_Code.OptionsColumn.AllowEdit = False
            Me.colAccount_Code.Visible = True
            Me.colAccount_Code.VisibleIndex = 14
            '
            'colAccount_Name
            '
            Me.colAccount_Name.Caption = "Account Name"
            Me.colAccount_Name.ColumnEdit = Me.RepositoryItemPopupContainerEdit
            Me.colAccount_Name.FieldName = "Account_Name"
            Me.colAccount_Name.Name = "colAccount_Name"
            Me.colAccount_Name.Visible = True
            Me.colAccount_Name.VisibleIndex = 15
            '
            'RepositoryItemPopupContainerEdit
            '
            Me.RepositoryItemPopupContainerEdit.AutoHeight = False
            Me.RepositoryItemPopupContainerEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemPopupContainerEdit.Name = "RepositoryItemPopupContainerEdit"
            Me.RepositoryItemPopupContainerEdit.PopupControl = Me.PopupContainerControl
            Me.RepositoryItemPopupContainerEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            '
            'PopupContainerControl
            '
            Me.PopupContainerControl.Controls.Add(Me.xuc_Account_Search)
            Me.PopupContainerControl.Location = New System.Drawing.Point(25, 117)
            Me.PopupContainerControl.Name = "PopupContainerControl"
            Me.PopupContainerControl.Size = New System.Drawing.Size(235, 179)
            Me.PopupContainerControl.TabIndex = 5
            '
            'xuc_Account_Search
            '
            Me.xuc_Account_Search.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account_Search.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Account_Search.Name = "xuc_Account_Search"
            Me.xuc_Account_Search.Size = New System.Drawing.Size(235, 179)
            Me.xuc_Account_Search.TabIndex = 4
            '
            'colJournal_Description
            '
            Me.colJournal_Description.Caption = "Description"
            Me.colJournal_Description.FieldName = "Journal_Description"
            Me.colJournal_Description.Name = "colJournal_Description"
            Me.colJournal_Description.Visible = True
            Me.colJournal_Description.VisibleIndex = 16
            '
            'colJournal_Status
            '
            Me.colJournal_Status.Caption = "Status"
            Me.colJournal_Status.FieldName = "Journal_Status"
            Me.colJournal_Status.Name = "colJournal_Status"
            Me.colJournal_Status.OptionsColumn.AllowEdit = False
            Me.colJournal_Status.Visible = True
            Me.colJournal_Status.VisibleIndex = 17
            '
            'colNotes
            '
            Me.colNotes.Caption = "Notes"
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 18
            '
            'colPosted_By
            '
            Me.colPosted_By.FieldName = "Posted_By"
            Me.colPosted_By.Name = "colPosted_By"
            Me.colPosted_By.Visible = True
            Me.colPosted_By.VisibleIndex = 19
            '
            'colPosting_Date
            '
            Me.colPosting_Date.Caption = "Posted"
            Me.colPosting_Date.ColumnEdit = Me.RepositoryItemDateEdit
            Me.colPosting_Date.FieldName = "Posting_Date"
            Me.colPosting_Date.Name = "colPosting_Date"
            Me.colPosting_Date.Visible = True
            Me.colPosting_Date.VisibleIndex = 20
            '
            'RepositoryItemDateEdit
            '
            Me.RepositoryItemDateEdit.AutoHeight = False
            Me.RepositoryItemDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit.CalendarTimeProperties.DisplayFormat.FormatString = "MMMM dd, yyyy"
            Me.RepositoryItemDateEdit.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.RepositoryItemDateEdit.CalendarTimeProperties.EditFormat.FormatString = "MMMM dd, yyyy"
            Me.RepositoryItemDateEdit.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.RepositoryItemDateEdit.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = True
            Me.RepositoryItemDateEdit.DisplayFormat.FormatString = "MMMM dd, yyyy"
            Me.RepositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.RepositoryItemDateEdit.EditFormat.FormatString = "MMMM dd, yyyy"
            Me.RepositoryItemDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.RepositoryItemDateEdit.Mask.BeepOnError = True
            Me.RepositoryItemDateEdit.Mask.EditMask = "MMMM dd, yyyy"
            Me.RepositoryItemDateEdit.Mask.UseMaskAsDisplayFormat = True
            Me.RepositoryItemDateEdit.Name = "RepositoryItemDateEdit"
            '
            'colTransacted_By
            '
            Me.colTransacted_By.FieldName = "Transacted_By"
            Me.colTransacted_By.Name = "colTransacted_By"
            Me.colTransacted_By.Visible = True
            Me.colTransacted_By.VisibleIndex = 21
            '
            'colTransaction_Date
            '
            Me.colTransaction_Date.Caption = "Transacted"
            Me.colTransaction_Date.ColumnEdit = Me.RepositoryItemDateEdit
            Me.colTransaction_Date.FieldName = "Transaction_Date"
            Me.colTransaction_Date.Name = "colTransaction_Date"
            Me.colTransaction_Date.OptionsColumn.AllowEdit = False
            Me.colTransaction_Date.Visible = True
            Me.colTransaction_Date.VisibleIndex = 22
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.OptionsColumn.AllowEdit = False
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 23
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.OptionsColumn.AllowEdit = False
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 24
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.OptionsColumn.AllowEdit = False
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 25
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.OptionsColumn.AllowEdit = False
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 26
            '
            'colApproved_By
            '
            Me.colApproved_By.FieldName = "Approved_By"
            Me.colApproved_By.Name = "colApproved_By"
            Me.colApproved_By.OptionsColumn.AllowEdit = False
            Me.colApproved_By.Visible = True
            Me.colApproved_By.VisibleIndex = 27
            '
            'colApproved_Date
            '
            Me.colApproved_Date.FieldName = "Approved_Date"
            Me.colApproved_Date.Name = "colApproved_Date"
            Me.colApproved_Date.OptionsColumn.AllowEdit = False
            Me.colApproved_Date.Visible = True
            Me.colApproved_Date.VisibleIndex = 28
            '
            'colLocked_By
            '
            Me.colLocked_By.FieldName = "Locked_By"
            Me.colLocked_By.Name = "colLocked_By"
            Me.colLocked_By.OptionsColumn.AllowEdit = False
            Me.colLocked_By.Visible = True
            Me.colLocked_By.VisibleIndex = 29
            '
            'colLocked_Date
            '
            Me.colLocked_Date.FieldName = "Locked_Date"
            Me.colLocked_Date.Name = "colLocked_Date"
            Me.colLocked_Date.OptionsColumn.AllowEdit = False
            Me.colLocked_Date.Visible = True
            Me.colLocked_Date.VisibleIndex = 30
            '
            'BarManager
            '
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_New, Me.btn_Reload, Me.btn_Save, Me.btn_Preview, Me.btn_Print_Check, Me.btn_Approval, Me.btn_Validate, Me.btn_Approve, Me.btn_Initialize, Me.btn_Update, Me.btn_Verify, Me.btn_Regenerate_Codes, Me.btn_Delete, Me.btn_Batch_Transactions, Me.btn_Insert, Me.btn_Lock, Me.btn_Journal_Entries2, Me.btn_Ledger, Me.btn_Error_Report})
            Me.BarManager.MaxItemId = 42
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit_Document_Title, Me.RepositoryItemcheckEdit_Check_Unbalanced, Me.RepositoryItemcheckEdit_Check_Auto_Credit, Me.RepositoryItemComboBox_Paper_Size, Me.RepositoryItemTextEdit_Remarks, Me.RepositoryItemComboBox_Document_Title})
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(599, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 337)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(599, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 337)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(599, 0)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 337)
            '
            'btn_New
            '
            Me.btn_New.Caption = "New"
            Me.btn_New.Id = 3
            Me.btn_New.ImageOptions.ImageIndex = 2
            Me.btn_New.ImageOptions.LargeImageIndex = 2
            Me.btn_New.Name = "btn_New"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 4
            Me.btn_Reload.ImageOptions.ImageIndex = 0
            Me.btn_Reload.ImageOptions.LargeImageIndex = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_Save
            '
            Me.btn_Save.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
            Me.btn_Save.Caption = "Save"
            Me.btn_Save.Id = 5
            Me.btn_Save.ImageOptions.ImageIndex = 3
            Me.btn_Save.ImageOptions.LargeImageIndex = 3
            Me.btn_Save.Name = "btn_Save"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "&Preview"
            Me.btn_Preview.Id = 6
            Me.btn_Preview.ImageOptions.ImageIndex = 5
            Me.btn_Preview.ImageOptions.LargeImageIndex = 5
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_Print_Check
            '
            Me.btn_Print_Check.Caption = "&Print Check "
            Me.btn_Print_Check.Id = 7
            Me.btn_Print_Check.ImageOptions.ImageIndex = 6
            Me.btn_Print_Check.ImageOptions.LargeImageIndex = 6
            Me.btn_Print_Check.Name = "btn_Print_Check"
            '
            'btn_Approval
            '
            Me.btn_Approval.Caption = "For Appr&oval"
            Me.btn_Approval.Id = 21
            Me.btn_Approval.ImageOptions.ImageIndex = 10
            Me.btn_Approval.ImageOptions.LargeImageIndex = 10
            Me.btn_Approval.Name = "btn_Approval"
            '
            'btn_Validate
            '
            Me.btn_Validate.Caption = "Vali&dation"
            Me.btn_Validate.Id = 22
            Me.btn_Validate.ImageOptions.ImageIndex = 7
            Me.btn_Validate.ImageOptions.LargeImageIndex = 7
            Me.btn_Validate.Name = "btn_Validate"
            '
            'btn_Approve
            '
            Me.btn_Approve.Caption = "&Approve"
            Me.btn_Approve.Id = 23
            Me.btn_Approve.ImageOptions.ImageIndex = 11
            Me.btn_Approve.ImageOptions.LargeImageIndex = 11
            Me.btn_Approve.Name = "btn_Approve"
            '
            'btn_Initialize
            '
            Me.btn_Initialize.Caption = "Initialize"
            Me.btn_Initialize.Id = 25
            Me.btn_Initialize.ImageOptions.ImageIndex = 1
            Me.btn_Initialize.ImageOptions.LargeImageIndex = 1
            Me.btn_Initialize.Name = "btn_Initialize"
            '
            'btn_Update
            '
            Me.btn_Update.Caption = "Over&write"
            Me.btn_Update.Id = 28
            Me.btn_Update.ImageOptions.ImageIndex = 4
            Me.btn_Update.ImageOptions.LargeImageIndex = 4
            Me.btn_Update.Name = "btn_Update"
            '
            'btn_Verify
            '
            Me.btn_Verify.Caption = "Verify"
            Me.btn_Verify.Id = 30
            Me.btn_Verify.ImageOptions.ImageIndex = 8
            Me.btn_Verify.ImageOptions.LargeImageIndex = 8
            Me.btn_Verify.Name = "btn_Verify"
            '
            'btn_Regenerate_Codes
            '
            Me.btn_Regenerate_Codes.Caption = "Repair Primary Keys"
            Me.btn_Regenerate_Codes.Id = 31
            Me.btn_Regenerate_Codes.ImageOptions.ImageIndex = 9
            Me.btn_Regenerate_Codes.ImageOptions.LargeImageIndex = 9
            Me.btn_Regenerate_Codes.Name = "btn_Regenerate_Codes"
            '
            'btn_Delete
            '
            Me.btn_Delete.Caption = "Delete"
            Me.btn_Delete.Id = 35
            Me.btn_Delete.Name = "btn_Delete"
            '
            'btn_Batch_Transactions
            '
            Me.btn_Batch_Transactions.Caption = "Batch Transactions"
            Me.btn_Batch_Transactions.Id = 36
            Me.btn_Batch_Transactions.Name = "btn_Batch_Transactions"
            '
            'btn_Insert
            '
            Me.btn_Insert.Caption = "Insert"
            Me.btn_Insert.Id = 37
            Me.btn_Insert.Name = "btn_Insert"
            '
            'btn_Lock
            '
            Me.btn_Lock.Caption = "Lock"
            Me.btn_Lock.Id = 38
            Me.btn_Lock.Name = "btn_Lock"
            '
            'btn_Journal_Entries2
            '
            Me.btn_Journal_Entries2.Caption = "Journal Entries 2"
            Me.btn_Journal_Entries2.Id = 39
            Me.btn_Journal_Entries2.Name = "btn_Journal_Entries2"
            '
            'btn_Ledger
            '
            Me.btn_Ledger.Caption = "Ledger"
            Me.btn_Ledger.Id = 40
            Me.btn_Ledger.Name = "btn_Ledger"
            '
            'btn_Error_Report
            '
            Me.btn_Error_Report.Caption = "Error Report"
            Me.btn_Error_Report.Id = 41
            Me.btn_Error_Report.ImageOptions.Image = CType(resources.GetObject("btn_Error_Report.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Error_Report.ImageOptions.LargeImage = CType(resources.GetObject("btn_Error_Report.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_Error_Report.Name = "btn_Error_Report"
            '
            'RepositoryItemTextEdit_Document_Title
            '
            Me.RepositoryItemTextEdit_Document_Title.AutoHeight = False
            Me.RepositoryItemTextEdit_Document_Title.Name = "RepositoryItemTextEdit_Document_Title"
            '
            'RepositoryItemcheckEdit_Check_Unbalanced
            '
            Me.RepositoryItemcheckEdit_Check_Unbalanced.Caption = ""
            Me.RepositoryItemcheckEdit_Check_Unbalanced.Name = "RepositoryItemcheckEdit_Check_Unbalanced"
            '
            'RepositoryItemcheckEdit_Check_Auto_Credit
            '
            Me.RepositoryItemcheckEdit_Check_Auto_Credit.AutoHeight = False
            Me.RepositoryItemcheckEdit_Check_Auto_Credit.Name = "RepositoryItemcheckEdit_Check_Auto_Credit"
            '
            'RepositoryItemComboBox_Paper_Size
            '
            Me.RepositoryItemComboBox_Paper_Size.AutoHeight = False
            Me.RepositoryItemComboBox_Paper_Size.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Paper_Size.Items.AddRange(New Object() {"FULL", "HALF"})
            Me.RepositoryItemComboBox_Paper_Size.Name = "RepositoryItemComboBox_Paper_Size"
            Me.RepositoryItemComboBox_Paper_Size.Sorted = True
            Me.RepositoryItemComboBox_Paper_Size.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'RepositoryItemTextEdit_Remarks
            '
            Me.RepositoryItemTextEdit_Remarks.AutoHeight = False
            Me.RepositoryItemTextEdit_Remarks.Name = "RepositoryItemTextEdit_Remarks"
            '
            'RepositoryItemComboBox_Document_Title
            '
            Me.RepositoryItemComboBox_Document_Title.AutoHeight = False
            Me.RepositoryItemComboBox_Document_Title.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Document_Title.Items.AddRange(New Object() {"CASH/CHECK VOUCHER", "JOURNAL ENTRIES"})
            Me.RepositoryItemComboBox_Document_Title.Name = "RepositoryItemComboBox_Document_Title"
            Me.RepositoryItemComboBox_Document_Title.Sorted = True
            Me.RepositoryItemComboBox_Document_Title.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Initialize), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Print_Check), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_New, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Insert), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Save), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Update), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Error_Report), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Regenerate_Codes, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approval, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Approve), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Lock), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Journal_Entries2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Batch_Transactions), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Ledger), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Validate, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Verify)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'xuc_Journal_Entries
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.PopupContainerControl)
            Me.Controls.Add(Me.gridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "xuc_Journal_Entries"
            Me.Size = New System.Drawing.Size(599, 337)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_COA_Summary, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Check_Numbers, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Type, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Profile, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemPopupContainerEdit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PopupContainerControl.ResumeLayout(False)
            CType(Me.RepositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemTextEdit_Document_Title, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemcheckEdit_Check_Unbalanced, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemcheckEdit_Check_Auto_Credit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Paper_Size, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemTextEdit_Remarks, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Document_Title, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents repositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit_COA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemComboBox_Type As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents RepositoryItemComboBox_Profile As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents RepositoryItemCalcEdit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents RepositoryItemDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents xuc_Account_Search As Controls.Information.Account.xuc_Account_Search
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents btn_New As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Save As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Print_Check As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approval As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Validate As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Approve As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Initialize As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Update As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Verify As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Regenerate_Codes As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemTextEdit_Document_Title As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents RepositoryItemcheckEdit_Check_Unbalanced As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents RepositoryItemcheckEdit_Check_Auto_Credit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents RepositoryItemComboBox_Paper_Size As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents RepositoryItemTextEdit_Remarks As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents RepositoryItemComboBox_Document_Title As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents RepositoryItemPopupContainerEdit As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Friend WithEvents PopupContainerControl As DevExpress.XtraEditors.PopupContainerControl
        Friend WithEvents RepositoryItemComboBox_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Batch_Transactions As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemLookUpEdit_Check_Numbers As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents btn_Insert As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Lock As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Journal_Entries2 As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents RepositoryItemLookUpEdit_COA_Summary As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsVerified As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTable_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Summary As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Debit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Credit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Profile As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCheck_Number As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPosting_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransaction_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLocked_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLocked_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPosted_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransacted_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents btn_Ledger As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Error_Report As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace