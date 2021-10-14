Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class XtraForm_Journal_Entries
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XtraForm_Journal_Entries))
            Me.GridControl = New DevExpress.XtraGrid.GridControl()
            Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsVerified = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTable_ID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCorporation = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranch = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Reference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCOA_Summary = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.RepositoryItemLookUpEdit_COA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colCOA_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Credit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCheck_Number = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Code = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccount_Name = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Profile = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colJournal_Status = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPosted_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPosting_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransacted_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransaction_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAdded_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModified_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colApproved_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIsLocked = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocked_By = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLocked_Date = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.Bar_Actions = New DevExpress.XtraBars.Bar()
            Me.Btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Delete = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Close = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar_Parameters = New DevExpress.XtraBars.Bar()
            Me.BarEditItem_Corporation = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemComboBox_Corporation = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.BarEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.BarEditItem_Search = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemSearchControl_Search = New DevExpress.XtraEditors.Repository.RepositoryItemSearchControl()
            Me.BarEditItem_Start = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDateEdit_Start = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.BarEditItem_End = New DevExpress.XtraBars.BarEditItem()
            Me.RepositoryItemDateEdit_End = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
            Me.Bar_Commands = New DevExpress.XtraBars.Bar()
            Me.Btn_Journal_Entries = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Approval = New DevExpress.XtraBars.BarButtonItem()
            Me.Btn_Stop = New DevExpress.XtraBars.BarButtonItem()
            Me.Bar1 = New DevExpress.XtraBars.Bar()
            Me.Btn_ProofSheet = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Start, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_End, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemDateEdit_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GridControl
            '
            Me.GridControl.DataMember = "view_Journal_Entries"
            Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl.Location = New System.Drawing.Point(0, 45)
            Me.GridControl.MainView = Me.GridView
            Me.GridControl.Name = "GridControl"
            Me.GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_COA})
            Me.GridControl.Size = New System.Drawing.Size(718, 415)
            Me.GridControl.TabIndex = 0
            Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
            '
            'GridView
            '
            Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colIsVerified, Me.colTable_ID, Me.colCorporation, Me.colBranch, Me.colJournal_Code, Me.colJournal_Reference, Me.colCOA_Code, Me.colCOA_Summary, Me.colCOA_Name, Me.colJournal_Debit, Me.colJournal_Credit, Me.colCheck_Number, Me.colAccount_Code, Me.colAccount_Name, Me.colJournal_Description, Me.colJournal_Type, Me.colJournal_Profile, Me.colNotes, Me.colJournal_Status, Me.colPosted_By, Me.colPosting_Date, Me.colTransacted_By, Me.colTransaction_Date, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colApproved_By, Me.colApproved_Date, Me.colIsLocked, Me.colLocked_By, Me.colLocked_Date})
            Me.GridView.GridControl = Me.GridControl
            Me.GridView.Name = "GridView"
            Me.GridView.OptionsView.ColumnAutoWidth = False
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colIsVerified
            '
            Me.colIsVerified.FieldName = "IsVerified"
            Me.colIsVerified.Name = "colIsVerified"
            Me.colIsVerified.Visible = True
            Me.colIsVerified.VisibleIndex = 1
            '
            'colTable_ID
            '
            Me.colTable_ID.FieldName = "Table_ID"
            Me.colTable_ID.Name = "colTable_ID"
            Me.colTable_ID.Visible = True
            Me.colTable_ID.VisibleIndex = 2
            '
            'colCorporation
            '
            Me.colCorporation.FieldName = "Corporation"
            Me.colCorporation.Name = "colCorporation"
            Me.colCorporation.Visible = True
            Me.colCorporation.VisibleIndex = 3
            '
            'colBranch
            '
            Me.colBranch.FieldName = "Branch"
            Me.colBranch.Name = "colBranch"
            Me.colBranch.Visible = True
            Me.colBranch.VisibleIndex = 4
            '
            'colJournal_Code
            '
            Me.colJournal_Code.FieldName = "Journal_Code"
            Me.colJournal_Code.Name = "colJournal_Code"
            Me.colJournal_Code.Visible = True
            Me.colJournal_Code.VisibleIndex = 5
            '
            'colJournal_Reference
            '
            Me.colJournal_Reference.FieldName = "Journal_Reference"
            Me.colJournal_Reference.Name = "colJournal_Reference"
            Me.colJournal_Reference.Visible = True
            Me.colJournal_Reference.VisibleIndex = 6
            '
            'colCOA_Code
            '
            Me.colCOA_Code.FieldName = "COA_Code"
            Me.colCOA_Code.Name = "colCOA_Code"
            Me.colCOA_Code.Visible = True
            Me.colCOA_Code.VisibleIndex = 7
            '
            'colCOA_Summary
            '
            Me.colCOA_Summary.ColumnEdit = Me.RepositoryItemLookUpEdit_COA
            Me.colCOA_Summary.FieldName = "COA_Summary"
            Me.colCOA_Summary.Name = "colCOA_Summary"
            Me.colCOA_Summary.Visible = True
            Me.colCOA_Summary.VisibleIndex = 8
            '
            'RepositoryItemLookUpEdit_COA
            '
            Me.RepositoryItemLookUpEdit_COA.AutoHeight = False
            Me.RepositoryItemLookUpEdit_COA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_COA.Name = "RepositoryItemLookUpEdit_COA"
            '
            'colCOA_Name
            '
            Me.colCOA_Name.FieldName = "COA_Name"
            Me.colCOA_Name.Name = "colCOA_Name"
            Me.colCOA_Name.Visible = True
            Me.colCOA_Name.VisibleIndex = 9
            '
            'colJournal_Debit
            '
            Me.colJournal_Debit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colJournal_Debit.FieldName = "Journal_Debit"
            Me.colJournal_Debit.Name = "colJournal_Debit"
            Me.colJournal_Debit.Visible = True
            Me.colJournal_Debit.VisibleIndex = 10
            '
            'colJournal_Credit
            '
            Me.colJournal_Credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colJournal_Credit.FieldName = "Journal_Credit"
            Me.colJournal_Credit.Name = "colJournal_Credit"
            Me.colJournal_Credit.Visible = True
            Me.colJournal_Credit.VisibleIndex = 11
            '
            'colCheck_Number
            '
            Me.colCheck_Number.FieldName = "Check_Number"
            Me.colCheck_Number.Name = "colCheck_Number"
            Me.colCheck_Number.Visible = True
            Me.colCheck_Number.VisibleIndex = 12
            '
            'colAccount_Code
            '
            Me.colAccount_Code.FieldName = "Account_Code"
            Me.colAccount_Code.Name = "colAccount_Code"
            Me.colAccount_Code.Visible = True
            Me.colAccount_Code.VisibleIndex = 13
            '
            'colAccount_Name
            '
            Me.colAccount_Name.FieldName = "Account_Name"
            Me.colAccount_Name.Name = "colAccount_Name"
            Me.colAccount_Name.Visible = True
            Me.colAccount_Name.VisibleIndex = 14
            '
            'colJournal_Description
            '
            Me.colJournal_Description.FieldName = "Journal_Description"
            Me.colJournal_Description.Name = "colJournal_Description"
            Me.colJournal_Description.Visible = True
            Me.colJournal_Description.VisibleIndex = 15
            '
            'colJournal_Type
            '
            Me.colJournal_Type.FieldName = "Journal_Type"
            Me.colJournal_Type.Name = "colJournal_Type"
            Me.colJournal_Type.Visible = True
            Me.colJournal_Type.VisibleIndex = 16
            '
            'colJournal_Profile
            '
            Me.colJournal_Profile.FieldName = "Journal_Profile"
            Me.colJournal_Profile.Name = "colJournal_Profile"
            Me.colJournal_Profile.Visible = True
            Me.colJournal_Profile.VisibleIndex = 17
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 18
            '
            'colJournal_Status
            '
            Me.colJournal_Status.FieldName = "Journal_Status"
            Me.colJournal_Status.Name = "colJournal_Status"
            Me.colJournal_Status.Visible = True
            Me.colJournal_Status.VisibleIndex = 19
            '
            'colPosted_By
            '
            Me.colPosted_By.FieldName = "Posted_By"
            Me.colPosted_By.Name = "colPosted_By"
            Me.colPosted_By.Visible = True
            Me.colPosted_By.VisibleIndex = 20
            '
            'colPosting_Date
            '
            Me.colPosting_Date.FieldName = "Posting_Date"
            Me.colPosting_Date.Name = "colPosting_Date"
            Me.colPosting_Date.Visible = True
            Me.colPosting_Date.VisibleIndex = 21
            '
            'colTransacted_By
            '
            Me.colTransacted_By.FieldName = "Transacted_By"
            Me.colTransacted_By.Name = "colTransacted_By"
            Me.colTransacted_By.Visible = True
            Me.colTransacted_By.VisibleIndex = 22
            '
            'colTransaction_Date
            '
            Me.colTransaction_Date.FieldName = "Transaction_Date"
            Me.colTransaction_Date.Name = "colTransaction_Date"
            Me.colTransaction_Date.Visible = True
            Me.colTransaction_Date.VisibleIndex = 23
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 24
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 25
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 26
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 27
            '
            'colApproved_By
            '
            Me.colApproved_By.FieldName = "Approved_By"
            Me.colApproved_By.Name = "colApproved_By"
            Me.colApproved_By.Visible = True
            Me.colApproved_By.VisibleIndex = 28
            '
            'colApproved_Date
            '
            Me.colApproved_Date.FieldName = "Approved_Date"
            Me.colApproved_Date.Name = "colApproved_Date"
            Me.colApproved_Date.Visible = True
            Me.colApproved_Date.VisibleIndex = 29
            '
            'colIsLocked
            '
            Me.colIsLocked.FieldName = "IsLocked"
            Me.colIsLocked.Name = "colIsLocked"
            Me.colIsLocked.Visible = True
            Me.colIsLocked.VisibleIndex = 30
            '
            'colLocked_By
            '
            Me.colLocked_By.FieldName = "Locked_By"
            Me.colLocked_By.Name = "colLocked_By"
            Me.colLocked_By.Visible = True
            Me.colLocked_By.VisibleIndex = 31
            '
            'colLocked_Date
            '
            Me.colLocked_Date.FieldName = "Locked_Date"
            Me.colLocked_Date.Name = "colLocked_Date"
            Me.colLocked_Date.Visible = True
            Me.colLocked_Date.VisibleIndex = 32
            '
            'BarManager
            '
            Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar_Actions, Me.Bar_Parameters, Me.Bar_Commands, Me.Bar1})
            Me.BarManager.DockControls.Add(Me.barDockControlTop)
            Me.BarManager.DockControls.Add(Me.barDockControlBottom)
            Me.BarManager.DockControls.Add(Me.barDockControlLeft)
            Me.BarManager.DockControls.Add(Me.barDockControlRight)
            Me.BarManager.Form = Me
            Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_Reload, Me.Btn_Preview, Me.Btn_Close, Me.Btn_Journal_Entries, Me.Btn_Stop, Me.BarEditItem_Branch, Me.BarEditItem_Search, Me.BarEditItem_Start, Me.BarEditItem_End, Me.BarEditItem_Corporation, Me.Btn_Delete, Me.Btn_Approval, Me.Btn_ProofSheet})
            Me.BarManager.MaxItemId = 17
            Me.BarManager.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_Branch, Me.RepositoryItemSearchControl_Search, Me.RepositoryItemDateEdit_Start, Me.RepositoryItemDateEdit_End, Me.RepositoryItemComboBox_Corporation})
            '
            'Bar_Actions
            '
            Me.Bar_Actions.BarName = "Actions"
            Me.Bar_Actions.DockCol = 1
            Me.Bar_Actions.DockRow = 0
            Me.Bar_Actions.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Actions.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
            Me.Bar_Actions.Text = "Actions"
            '
            'Btn_Reload
            '
            Me.Btn_Reload.Caption = "Reload"
            Me.Btn_Reload.Id = 0
            Me.Btn_Reload.Name = "Btn_Reload"
            '
            'Btn_Preview
            '
            Me.Btn_Preview.Caption = "Preview"
            Me.Btn_Preview.Id = 1
            Me.Btn_Preview.Name = "Btn_Preview"
            '
            'Btn_Delete
            '
            Me.Btn_Delete.Caption = "Delete"
            Me.Btn_Delete.Id = 13
            Me.Btn_Delete.Name = "Btn_Delete"
            '
            'Btn_Close
            '
            Me.Btn_Close.Caption = "Close"
            Me.Btn_Close.Id = 2
            Me.Btn_Close.Name = "Btn_Close"
            '
            'Bar_Parameters
            '
            Me.Bar_Parameters.BarName = "Parameters"
            Me.Bar_Parameters.DockCol = 0
            Me.Bar_Parameters.DockRow = 0
            Me.Bar_Parameters.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Parameters.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Corporation), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Branch), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Search), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_Start), New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem_End)})
            Me.Bar_Parameters.Text = "Parameters"
            '
            'BarEditItem_Corporation
            '
            Me.BarEditItem_Corporation.Caption = "Corporation"
            Me.BarEditItem_Corporation.Edit = Me.RepositoryItemComboBox_Corporation
            Me.BarEditItem_Corporation.Id = 11
            Me.BarEditItem_Corporation.Name = "BarEditItem_Corporation"
            '
            'RepositoryItemComboBox_Corporation
            '
            Me.RepositoryItemComboBox_Corporation.AutoHeight = False
            Me.RepositoryItemComboBox_Corporation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemComboBox_Corporation.Items.AddRange(New Object() {"SFC", "SMC"})
            Me.RepositoryItemComboBox_Corporation.Name = "RepositoryItemComboBox_Corporation"
            Me.RepositoryItemComboBox_Corporation.Sorted = True
            Me.RepositoryItemComboBox_Corporation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            '
            'BarEditItem_Branch
            '
            Me.BarEditItem_Branch.Caption = "Branch"
            Me.BarEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit_Branch
            Me.BarEditItem_Branch.Id = 7
            Me.BarEditItem_Branch.Name = "BarEditItem_Branch"
            '
            'RepositoryItemLookUpEdit_Branch
            '
            Me.RepositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.RepositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_Branch.Name = "RepositoryItemLookUpEdit_Branch"
            '
            'BarEditItem_Search
            '
            Me.BarEditItem_Search.Caption = "Search"
            Me.BarEditItem_Search.Edit = Me.RepositoryItemSearchControl_Search
            Me.BarEditItem_Search.Id = 8
            Me.BarEditItem_Search.Name = "BarEditItem_Search"
            '
            'RepositoryItemSearchControl_Search
            '
            Me.RepositoryItemSearchControl_Search.AutoHeight = False
            Me.RepositoryItemSearchControl_Search.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.RepositoryItemSearchControl_Search.Name = "RepositoryItemSearchControl_Search"
            '
            'BarEditItem_Start
            '
            Me.BarEditItem_Start.Caption = "Start"
            Me.BarEditItem_Start.Edit = Me.RepositoryItemDateEdit_Start
            Me.BarEditItem_Start.Id = 9
            Me.BarEditItem_Start.Name = "BarEditItem_Start"
            '
            'RepositoryItemDateEdit_Start
            '
            Me.RepositoryItemDateEdit_Start.AutoHeight = False
            Me.RepositoryItemDateEdit_Start.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_Start.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_Start.Name = "RepositoryItemDateEdit_Start"
            '
            'BarEditItem_End
            '
            Me.BarEditItem_End.Caption = "End"
            Me.BarEditItem_End.Edit = Me.RepositoryItemDateEdit_End
            Me.BarEditItem_End.Id = 10
            Me.BarEditItem_End.Name = "BarEditItem_End"
            '
            'RepositoryItemDateEdit_End
            '
            Me.RepositoryItemDateEdit_End.AutoHeight = False
            Me.RepositoryItemDateEdit_End.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_End.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemDateEdit_End.Name = "RepositoryItemDateEdit_End"
            '
            'Bar_Commands
            '
            Me.Bar_Commands.BarName = "Commands"
            Me.Bar_Commands.DockCol = 0
            Me.Bar_Commands.DockRow = 1
            Me.Bar_Commands.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar_Commands.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal_Entries), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Approval, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Stop, True)})
            Me.Bar_Commands.Text = "Commands"
            '
            'Btn_Journal_Entries
            '
            Me.Btn_Journal_Entries.Caption = "Journal Entries"
            Me.Btn_Journal_Entries.Id = 4
            Me.Btn_Journal_Entries.Name = "Btn_Journal_Entries"
            '
            'Btn_Approval
            '
            Me.Btn_Approval.Caption = "Approval"
            Me.Btn_Approval.Id = 14
            Me.Btn_Approval.Name = "Btn_Approval"
            '
            'Btn_Stop
            '
            Me.Btn_Stop.Caption = "Stop"
            Me.Btn_Stop.Id = 5
            Me.Btn_Stop.Name = "Btn_Stop"
            '
            'Bar1
            '
            Me.Bar1.BarName = "Custom 5"
            Me.Bar1.DockCol = 1
            Me.Bar1.DockRow = 1
            Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_ProofSheet)})
            Me.Bar1.Offset = 235
            Me.Bar1.Text = "Custom 5"
            '
            'Btn_ProofSheet
            '
            Me.Btn_ProofSheet.Caption = "Proof Sheet"
            Me.Btn_ProofSheet.Id = 15
            Me.Btn_ProofSheet.ImageOptions.Image = CType(resources.GetObject("Btn_ProofSheet.ImageOptions.Image"), System.Drawing.Image)
            Me.Btn_ProofSheet.ImageOptions.LargeImage = CType(resources.GetObject("Btn_ProofSheet.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.Btn_ProofSheet.Name = "Btn_ProofSheet"
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.BarManager
            Me.barDockControlTop.Size = New System.Drawing.Size(718, 45)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 460)
            Me.barDockControlBottom.Manager = Me.BarManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(718, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
            Me.barDockControlLeft.Manager = Me.BarManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 415)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(718, 45)
            Me.barDockControlRight.Manager = Me.BarManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 415)
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Journal_Entries, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Stop), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Delete, True), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Approval), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Close, True)})
            Me.PopupMenu.Manager = Me.BarManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'XtraForm_Journal_Entries
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(718, 460)
            Me.Controls.Add(Me.GridControl)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "XtraForm_Journal_Entries"
            Me.Text = "Journal Entries"
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemComboBox_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSearchControl_Search, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Start.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_Start, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_End.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemDateEdit_End, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
        Friend WithEvents Bar_Actions As DevExpress.XtraBars.Bar
        Friend WithEvents Btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Close As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar_Parameters As DevExpress.XtraBars.Bar
        Friend WithEvents BarEditItem_Branch As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents BarEditItem_Search As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemSearchControl_Search As DevExpress.XtraEditors.Repository.RepositoryItemSearchControl
        Friend WithEvents BarEditItem_Start As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit_Start As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents BarEditItem_End As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemDateEdit_End As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents Btn_Journal_Entries As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Stop As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents BarEditItem_Corporation As DevExpress.XtraBars.BarEditItem
        Friend WithEvents RepositoryItemComboBox_Corporation As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTable_ID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranch As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Reference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Code As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccount_Name As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Debit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Credit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Status As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransacted_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransaction_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colApproved_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colModified_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colJournal_Profile As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPosted_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPosting_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCOA_Summary As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCorporation As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsLocked As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLocked_By As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLocked_Date As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIsVerified As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCheck_Number As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_COA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents Bar_Commands As DevExpress.XtraBars.Bar
        Friend WithEvents Btn_Delete As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Btn_Approval As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
        Friend WithEvents Btn_ProofSheet As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace