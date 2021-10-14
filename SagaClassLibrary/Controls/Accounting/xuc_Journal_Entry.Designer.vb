Namespace Controls.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Journal_Entry
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xuc_Journal_Entry))
            Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.Balance_Running = New DevExpress.XtraEditors.CalcEdit()
            Me.toggle_Is_Liquidation = New DevExpress.XtraEditors.ToggleSwitch()
            Me.Budget_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.btn_Liquidate = New DevExpress.XtraEditors.SimpleButton()
            Me.toggle_Liquidated = New DevExpress.XtraEditors.ToggleSwitch()
            Me.COA_Code = New DevExpress.XtraEditors.TreeListLookUpEdit()
            Me.TreeListLookUpEdit_COA = New DevExpress.XtraTreeList.TreeList()
            Me.colCOA_Summary = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.RepositoryItemLookUpEdit_COA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colCOA_Type = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Code = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Name = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Desc = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.Check_Number = New DevExpress.XtraEditors.LookUpEdit()
            Me.toggle_New_Reference = New DevExpress.XtraEditors.ToggleSwitch()
            Me.toggle_Reference = New DevExpress.XtraEditors.ToggleSwitch()
            Me.PopupContainerControl = New DevExpress.XtraEditors.PopupContainerControl()
            Me.xuc_Account_Search = New SagaClassLibrary.Controls.Information.Account.xuc_Account_Search()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Posting_Date = New DevExpress.XtraEditors.DateEdit()
            Me.Journal_Branch = New DevExpress.XtraEditors.LookUpEdit()
            Me.Journal_Debit = New DevExpress.XtraEditors.CalcEdit()
            Me.Journal_Credit = New DevExpress.XtraEditors.CalcEdit()
            Me.Account_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Journal_Profile = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Journal_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.Account_Name = New DevExpress.XtraEditors.PopupContainerEdit()
            Me.Journal_Type = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Journal_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Table_ID = New DevExpress.XtraEditors.TextEdit()
            Me.Journal_Reference = New DevExpress.XtraEditors.ButtonEdit()
            Me.Voucher_Reference = New DevExpress.XtraEditors.SearchLookUpEdit()
            Me.SearchLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.Liquidation_Justification = New DevExpress.XtraEditors.MemoEdit()
            Me.Corporation = New DevExpress.XtraEditors.LookUpEdit()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.Notesitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Journal_Descriptionitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
            Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.IDitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Journal_Typeitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Table_IDitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Journal_Referenceitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Journal_Codeitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem_Corporation = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Journal_Branchitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem_New_Reference = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.LayoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.Added = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.Modified = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.Approved = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.Deleted = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.Modification = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.Transacted = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.Verified = New DevExpress.XtraLayout.SimpleLabelItem()
            Me.Journal_Debititem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Account_Nameitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Journal_Profileitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Account_Codeitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Journal_Credititem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Posting_Dateitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Reference = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colExpense_Type = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Date_Posted = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLiquidation_Days = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLiquidation_Date_Expiry = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Debit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colVoucher_Description = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.SimpleLabelItem3 = New DevExpress.XtraLayout.SimpleLabelItem()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.Balance_Running.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toggle_Is_Liquidation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Budget_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toggle_Liquidated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.COA_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TreeListLookUpEdit_COA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toggle_New_Reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.toggle_Reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PopupContainerControl.SuspendLayout()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Posting_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Posting_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Branch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Debit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Credit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Profile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Table_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Voucher_Reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SearchLookUpEditView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Liquidation_Justification.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Corporation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notesitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Descriptionitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IDitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Typeitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Table_IDitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Referenceitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Codeitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem_Corporation, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Branchitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem_New_Reference, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Added, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Modified, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Approved, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Deleted, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Modification, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Transacted, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Verified, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Debititem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Nameitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Profileitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Account_Codeitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Journal_Credititem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Posting_Dateitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Notes
            '
            Me.Notes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Notes.Location = New System.Drawing.Point(93, 392)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(345, 88)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 18
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.Balance_Running)
            Me.layoutControl.Controls.Add(Me.toggle_Is_Liquidation)
            Me.layoutControl.Controls.Add(Me.Budget_Code)
            Me.layoutControl.Controls.Add(Me.btn_Liquidate)
            Me.layoutControl.Controls.Add(Me.toggle_Liquidated)
            Me.layoutControl.Controls.Add(Me.COA_Code)
            Me.layoutControl.Controls.Add(Me.Check_Number)
            Me.layoutControl.Controls.Add(Me.toggle_New_Reference)
            Me.layoutControl.Controls.Add(Me.toggle_Reference)
            Me.layoutControl.Controls.Add(Me.PopupContainerControl)
            Me.layoutControl.Controls.Add(Me.ID)
            Me.layoutControl.Controls.Add(Me.Posting_Date)
            Me.layoutControl.Controls.Add(Me.Journal_Branch)
            Me.layoutControl.Controls.Add(Me.Journal_Debit)
            Me.layoutControl.Controls.Add(Me.Notes)
            Me.layoutControl.Controls.Add(Me.Journal_Credit)
            Me.layoutControl.Controls.Add(Me.Account_Code)
            Me.layoutControl.Controls.Add(Me.Journal_Profile)
            Me.layoutControl.Controls.Add(Me.Journal_Description)
            Me.layoutControl.Controls.Add(Me.Account_Name)
            Me.layoutControl.Controls.Add(Me.Journal_Type)
            Me.layoutControl.Controls.Add(Me.Journal_Code)
            Me.layoutControl.Controls.Add(Me.Table_ID)
            Me.layoutControl.Controls.Add(Me.Journal_Reference)
            Me.layoutControl.Controls.Add(Me.Voucher_Reference)
            Me.layoutControl.Controls.Add(Me.Liquidation_Justification)
            Me.layoutControl.Controls.Add(Me.Corporation)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(347, 175, 650, 400)
            Me.layoutControl.Root = Me.LayoutControlGroup1
            Me.layoutControl.Size = New System.Drawing.Size(450, 492)
            Me.layoutControl.TabIndex = 0
            '
            'Balance_Running
            '
            Me.Balance_Running.Location = New System.Drawing.Point(105, 47)
            Me.Balance_Running.Name = "Balance_Running"
            Me.Balance_Running.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Balance_Running.Size = New System.Drawing.Size(321, 20)
            Me.Balance_Running.StyleController = Me.layoutControl
            Me.Balance_Running.TabIndex = 27
            '
            'toggle_Is_Liquidation
            '
            Me.toggle_Is_Liquidation.Location = New System.Drawing.Point(105, 47)
            Me.toggle_Is_Liquidation.Name = "toggle_Is_Liquidation"
            Me.toggle_Is_Liquidation.Properties.OffText = "No"
            Me.toggle_Is_Liquidation.Properties.OnText = "Yes"
            Me.toggle_Is_Liquidation.Size = New System.Drawing.Size(105, 18)
            Me.toggle_Is_Liquidation.StyleController = Me.layoutControl
            Me.toggle_Is_Liquidation.TabIndex = 19
            '
            'Budget_Code
            '
            Me.Budget_Code.Location = New System.Drawing.Point(105, 47)
            Me.Budget_Code.Name = "Budget_Code"
            Me.Budget_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Budget_Code.Properties.ReadOnly = True
            Me.Budget_Code.Size = New System.Drawing.Size(321, 20)
            Me.Budget_Code.StyleController = Me.layoutControl
            Me.Budget_Code.TabIndex = 4
            '
            'btn_Liquidate
            '
            Me.btn_Liquidate.ImageOptions.Image = CType(resources.GetObject("btn_Liquidate.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Liquidate.Location = New System.Drawing.Point(345, 69)
            Me.btn_Liquidate.Name = "btn_Liquidate"
            Me.btn_Liquidate.Size = New System.Drawing.Size(81, 22)
            Me.btn_Liquidate.StyleController = Me.layoutControl
            Me.btn_Liquidate.TabIndex = 2
            Me.btn_Liquidate.Text = "Liquidate"
            '
            'toggle_Liquidated
            '
            Me.toggle_Liquidated.Location = New System.Drawing.Point(295, 47)
            Me.toggle_Liquidated.Name = "toggle_Liquidated"
            Me.toggle_Liquidated.Properties.OffText = "No"
            Me.toggle_Liquidated.Properties.OnText = "Yes"
            Me.toggle_Liquidated.Size = New System.Drawing.Size(131, 18)
            Me.toggle_Liquidated.StyleController = Me.layoutControl
            Me.toggle_Liquidated.TabIndex = 1
            '
            'COA_Code
            '
            Me.COA_Code.Location = New System.Drawing.Point(93, 212)
            Me.COA_Code.Name = "COA_Code"
            Me.COA_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.COA_Code.Properties.DisplayMember = "COA_Name"
            Me.COA_Code.Properties.TreeList = Me.TreeListLookUpEdit_COA
            Me.COA_Code.Properties.ValueMember = "COA_Code"
            Me.COA_Code.Size = New System.Drawing.Size(345, 20)
            Me.COA_Code.StyleController = Me.layoutControl
            Me.COA_Code.TabIndex = 10
            '
            'TreeListLookUpEdit_COA
            '
            Me.TreeListLookUpEdit_COA.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colCOA_Summary, Me.colCOA_Type, Me.colCOA_Code, Me.colCOA_Name, Me.colCOA_Desc})
            Me.TreeListLookUpEdit_COA.KeyFieldName = "COA_Code"
            Me.TreeListLookUpEdit_COA.Location = New System.Drawing.Point(0, 0)
            Me.TreeListLookUpEdit_COA.Name = "TreeListLookUpEdit_COA"
            Me.TreeListLookUpEdit_COA.ParentFieldName = "COA_Summary"
            Me.TreeListLookUpEdit_COA.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_COA})
            Me.TreeListLookUpEdit_COA.Size = New System.Drawing.Size(400, 200)
            Me.TreeListLookUpEdit_COA.TabIndex = 0
            '
            'colCOA_Summary
            '
            Me.colCOA_Summary.Caption = "Summary"
            Me.colCOA_Summary.ColumnEdit = Me.RepositoryItemLookUpEdit_COA
            Me.colCOA_Summary.FieldName = "COA_Summary"
            Me.colCOA_Summary.Name = "colCOA_Summary"
            Me.colCOA_Summary.Visible = True
            Me.colCOA_Summary.VisibleIndex = 0
            '
            'RepositoryItemLookUpEdit_COA
            '
            Me.RepositoryItemLookUpEdit_COA.AutoHeight = False
            Me.RepositoryItemLookUpEdit_COA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_COA.Name = "RepositoryItemLookUpEdit_COA"
            '
            'colCOA_Type
            '
            Me.colCOA_Type.Caption = "Type"
            Me.colCOA_Type.FieldName = "COA_Type"
            Me.colCOA_Type.Name = "colCOA_Type"
            Me.colCOA_Type.Visible = True
            Me.colCOA_Type.VisibleIndex = 1
            '
            'colCOA_Code
            '
            Me.colCOA_Code.Caption = "Code"
            Me.colCOA_Code.FieldName = "COA_Code"
            Me.colCOA_Code.Name = "colCOA_Code"
            Me.colCOA_Code.Visible = True
            Me.colCOA_Code.VisibleIndex = 2
            '
            'colCOA_Name
            '
            Me.colCOA_Name.Caption = "Account Title"
            Me.colCOA_Name.FieldName = "COA_Name"
            Me.colCOA_Name.Name = "colCOA_Name"
            Me.colCOA_Name.Visible = True
            Me.colCOA_Name.VisibleIndex = 3
            '
            'colCOA_Desc
            '
            Me.colCOA_Desc.Caption = "Description"
            Me.colCOA_Desc.FieldName = "COA_Desc"
            Me.colCOA_Desc.Name = "colCOA_Desc"
            Me.colCOA_Desc.Visible = True
            Me.colCOA_Desc.VisibleIndex = 4
            '
            'Check_Number
            '
            Me.Check_Number.Location = New System.Drawing.Point(308, 236)
            Me.Check_Number.Name = "Check_Number"
            Me.Check_Number.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Check_Number.Size = New System.Drawing.Size(130, 20)
            Me.Check_Number.StyleController = Me.layoutControl
            Me.Check_Number.TabIndex = 12
            '
            'toggle_New_Reference
            '
            Me.toggle_New_Reference.Location = New System.Drawing.Point(308, 95)
            Me.toggle_New_Reference.Name = "toggle_New_Reference"
            Me.toggle_New_Reference.Properties.OffText = "Off"
            Me.toggle_New_Reference.Properties.OnText = "On"
            Me.toggle_New_Reference.Size = New System.Drawing.Size(118, 18)
            Me.toggle_New_Reference.StyleController = Me.layoutControl
            Me.toggle_New_Reference.TabIndex = 5
            '
            'toggle_Reference
            '
            Me.toggle_Reference.Location = New System.Drawing.Point(308, 71)
            Me.toggle_Reference.Name = "toggle_Reference"
            Me.toggle_Reference.Properties.OffText = "Off"
            Me.toggle_Reference.Properties.OnText = "On"
            Me.toggle_Reference.Size = New System.Drawing.Size(118, 18)
            Me.toggle_Reference.StyleController = Me.layoutControl
            Me.toggle_Reference.TabIndex = 3
            '
            'PopupContainerControl
            '
            Me.PopupContainerControl.AutoSize = True
            Me.PopupContainerControl.Controls.Add(Me.xuc_Account_Search)
            Me.PopupContainerControl.Location = New System.Drawing.Point(135, 345)
            Me.PopupContainerControl.Name = "PopupContainerControl"
            Me.PopupContainerControl.Size = New System.Drawing.Size(334, 174)
            Me.PopupContainerControl.TabIndex = 26
            '
            'xuc_Account_Search
            '
            Me.xuc_Account_Search.AccountName = Nothing
            Me.xuc_Account_Search.Amount = New Decimal(New Integer() {0, 0, 0, 0})
            Me.xuc_Account_Search.Code = Nothing
            Me.xuc_Account_Search.Code2 = Nothing
            Me.xuc_Account_Search.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account_Search.ID = 0
            Me.xuc_Account_Search.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Account_Search.Name = "xuc_Account_Search"
            Me.xuc_Account_Search.Others = Nothing
            Me.xuc_Account_Search.searchMode = SagaClassLibrary.Controls.Information.Account.xuc_Account_Search.Search_Mode.searchGlobal
            Me.xuc_Account_Search.Size = New System.Drawing.Size(334, 174)
            Me.xuc_Account_Search.TabIndex = 0
            Me.xuc_Account_Search.Type = Nothing
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(105, 47)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(117, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 0
            '
            'Posting_Date
            '
            Me.Posting_Date.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Posting_Date.EditValue = New Date(2020, 12, 16, 0, 0, 0, 0)
            Me.Posting_Date.Location = New System.Drawing.Point(93, 236)
            Me.Posting_Date.Name = "Posting_Date"
            Me.Posting_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Posting_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Posting_Date.Size = New System.Drawing.Size(130, 20)
            Me.Posting_Date.StyleController = Me.layoutControl
            Me.Posting_Date.TabIndex = 11
            '
            'Journal_Branch
            '
            Me.Journal_Branch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Journal_Branch.Location = New System.Drawing.Point(308, 119)
            Me.Journal_Branch.Name = "Journal_Branch"
            Me.Journal_Branch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Journal_Branch.Size = New System.Drawing.Size(118, 20)
            Me.Journal_Branch.StyleController = Me.layoutControl
            Me.Journal_Branch.TabIndex = 7
            '
            'Journal_Debit
            '
            Me.Journal_Debit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Journal_Debit.Location = New System.Drawing.Point(93, 308)
            Me.Journal_Debit.Name = "Journal_Debit"
            Me.Journal_Debit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Journal_Debit.Size = New System.Drawing.Size(129, 20)
            Me.Journal_Debit.StyleController = Me.layoutControl
            Me.Journal_Debit.TabIndex = 15
            '
            'Journal_Credit
            '
            Me.Journal_Credit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Journal_Credit.Location = New System.Drawing.Point(307, 308)
            Me.Journal_Credit.Name = "Journal_Credit"
            Me.Journal_Credit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Journal_Credit.Size = New System.Drawing.Size(131, 20)
            Me.Journal_Credit.StyleController = Me.layoutControl
            Me.Journal_Credit.TabIndex = 16
            '
            'Account_Code
            '
            Me.Account_Code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Account_Code.Location = New System.Drawing.Point(93, 260)
            Me.Account_Code.Name = "Account_Code"
            Me.Account_Code.Properties.ReadOnly = True
            Me.Account_Code.Size = New System.Drawing.Size(345, 20)
            Me.Account_Code.StyleController = Me.layoutControl
            Me.Account_Code.TabIndex = 13
            '
            'Journal_Profile
            '
            Me.Journal_Profile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Journal_Profile.Location = New System.Drawing.Point(93, 188)
            Me.Journal_Profile.Name = "Journal_Profile"
            Me.Journal_Profile.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, True, True, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.Journal_Profile.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.Journal_Profile.Size = New System.Drawing.Size(345, 20)
            Me.Journal_Profile.StyleController = Me.layoutControl
            Me.Journal_Profile.TabIndex = 9
            '
            'Journal_Description
            '
            Me.Journal_Description.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Journal_Description.Location = New System.Drawing.Point(93, 332)
            Me.Journal_Description.Name = "Journal_Description"
            Me.Journal_Description.Size = New System.Drawing.Size(345, 46)
            Me.Journal_Description.StyleController = Me.layoutControl
            Me.Journal_Description.TabIndex = 17
            '
            'Account_Name
            '
            Me.Account_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Account_Name.Location = New System.Drawing.Point(93, 284)
            Me.Account_Name.Name = "Account_Name"
            Me.Account_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Account_Name.Properties.PopupControl = Me.PopupContainerControl
            Me.Account_Name.Size = New System.Drawing.Size(345, 20)
            Me.Account_Name.StyleController = Me.layoutControl
            Me.Account_Name.TabIndex = 14
            '
            'Journal_Type
            '
            Me.Journal_Type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Journal_Type.Location = New System.Drawing.Point(105, 143)
            Me.Journal_Type.Name = "Journal_Type"
            Me.Journal_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "", -1, True, True, True, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.Journal_Type.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.Journal_Type.Size = New System.Drawing.Size(321, 20)
            Me.Journal_Type.StyleController = Me.layoutControl
            Me.Journal_Type.TabIndex = 8
            '
            'Journal_Code
            '
            Me.Journal_Code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Journal_Code.Location = New System.Drawing.Point(105, 71)
            Me.Journal_Code.Name = "Journal_Code"
            Me.Journal_Code.Size = New System.Drawing.Size(118, 20)
            Me.Journal_Code.StyleController = Me.layoutControl
            Me.Journal_Code.TabIndex = 2
            '
            'Table_ID
            '
            Me.Table_ID.Location = New System.Drawing.Point(307, 47)
            Me.Table_ID.Name = "Table_ID"
            Me.Table_ID.Size = New System.Drawing.Size(119, 20)
            Me.Table_ID.StyleController = Me.layoutControl
            Me.Table_ID.TabIndex = 1
            '
            'Journal_Reference
            '
            Me.Journal_Reference.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Journal_Reference.Location = New System.Drawing.Point(105, 95)
            Me.Journal_Reference.Name = "Journal_Reference"
            Me.Journal_Reference.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
            Me.Journal_Reference.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.Journal_Reference.Size = New System.Drawing.Size(118, 20)
            Me.Journal_Reference.StyleController = Me.layoutControl
            Me.Journal_Reference.TabIndex = 4
            '
            'Voucher_Reference
            '
            Me.Voucher_Reference.Location = New System.Drawing.Point(105, 69)
            Me.Voucher_Reference.Name = "Voucher_Reference"
            Me.Voucher_Reference.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.Voucher_Reference.Properties.PopupView = Me.SearchLookUpEditView
            Me.Voucher_Reference.Size = New System.Drawing.Size(236, 20)
            Me.Voucher_Reference.StyleController = Me.layoutControl
            Me.Voucher_Reference.TabIndex = 0
            '
            'SearchLookUpEditView
            '
            Me.SearchLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.SearchLookUpEditView.Name = "SearchLookUpEditView"
            Me.SearchLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.SearchLookUpEditView.OptionsView.ShowGroupPanel = False
            '
            'Liquidation_Justification
            '
            Me.Liquidation_Justification.Location = New System.Drawing.Point(105, 95)
            Me.Liquidation_Justification.Name = "Liquidation_Justification"
            Me.Liquidation_Justification.Size = New System.Drawing.Size(321, 77)
            Me.Liquidation_Justification.StyleController = Me.layoutControl
            Me.Liquidation_Justification.TabIndex = 3
            '
            'Corporation
            '
            Me.Corporation.Location = New System.Drawing.Point(105, 119)
            Me.Corporation.Name = "Corporation"
            Me.Corporation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Corporation.Properties.NullText = ""
            Me.Corporation.Properties.PopupSizeable = False
            Me.Corporation.Size = New System.Drawing.Size(118, 20)
            Me.Corporation.StyleController = Me.layoutControl
            Me.Corporation.TabIndex = 6
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Notesitem, Me.Journal_Descriptionitem, Me.TabbedControlGroup1, Me.Journal_Debititem, Me.Account_Nameitem, Me.Journal_Profileitem, Me.Account_Codeitem, Me.Journal_Credititem, Me.SplitterItem1, Me.LayoutControlItem2, Me.Posting_Dateitem, Me.LayoutControlItem1})
            Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(450, 492)
            Me.LayoutControlGroup1.TextVisible = False
            '
            'Notesitem
            '
            Me.Notesitem.Control = Me.Notes
            Me.Notesitem.Location = New System.Drawing.Point(0, 380)
            Me.Notesitem.MinSize = New System.Drawing.Size(85, 20)
            Me.Notesitem.Name = "Notesitem"
            Me.Notesitem.Size = New System.Drawing.Size(430, 92)
            Me.Notesitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.Notesitem.Text = "Notes"
            Me.Notesitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Notesitem.TextSize = New System.Drawing.Size(69, 13)
            '
            'Journal_Descriptionitem
            '
            Me.Journal_Descriptionitem.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.Journal_Descriptionitem.AppearanceItemCaption.Options.UseForeColor = True
            Me.Journal_Descriptionitem.Control = Me.Journal_Description
            Me.Journal_Descriptionitem.Location = New System.Drawing.Point(0, 320)
            Me.Journal_Descriptionitem.Name = "Journal_Descriptionitem"
            Me.Journal_Descriptionitem.Size = New System.Drawing.Size(430, 50)
            Me.Journal_Descriptionitem.Text = "Description"
            Me.Journal_Descriptionitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Journal_Descriptionitem.TextSize = New System.Drawing.Size(69, 13)
            '
            'TabbedControlGroup1
            '
            Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
            Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup2
            Me.TabbedControlGroup1.Size = New System.Drawing.Size(430, 176)
            Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup4, Me.LayoutControlGroup5, Me.LayoutControlGroup6})
            '
            'LayoutControlGroup2
            '
            Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.IDitem, Me.Journal_Typeitem, Me.Table_IDitem, Me.Journal_Referenceitem, Me.Journal_Codeitem, Me.LayoutControlItem_Corporation, Me.Journal_Branchitem, Me.LayoutControlItem3, Me.LayoutControlItem_New_Reference})
            Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
            Me.LayoutControlGroup2.Size = New System.Drawing.Size(406, 129)
            Me.LayoutControlGroup2.Text = "Journal"
            '
            'IDitem
            '
            Me.IDitem.Control = Me.ID
            Me.IDitem.Enabled = False
            Me.IDitem.Location = New System.Drawing.Point(0, 0)
            Me.IDitem.Name = "IDitem"
            Me.IDitem.Size = New System.Drawing.Size(202, 24)
            Me.IDitem.Text = "ID"
            Me.IDitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.IDitem.TextSize = New System.Drawing.Size(69, 13)
            '
            'Journal_Typeitem
            '
            Me.Journal_Typeitem.Control = Me.Journal_Type
            Me.Journal_Typeitem.Location = New System.Drawing.Point(0, 96)
            Me.Journal_Typeitem.Name = "Journal_Typeitem"
            Me.Journal_Typeitem.Size = New System.Drawing.Size(406, 33)
            Me.Journal_Typeitem.Text = "Type"
            Me.Journal_Typeitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Journal_Typeitem.TextSize = New System.Drawing.Size(69, 13)
            '
            'Table_IDitem
            '
            Me.Table_IDitem.Control = Me.Table_ID
            Me.Table_IDitem.Enabled = False
            Me.Table_IDitem.Location = New System.Drawing.Point(202, 0)
            Me.Table_IDitem.Name = "Table_IDitem"
            Me.Table_IDitem.Size = New System.Drawing.Size(204, 24)
            Me.Table_IDitem.Text = "Table ID"
            Me.Table_IDitem.TextSize = New System.Drawing.Size(69, 13)
            '
            'Journal_Referenceitem
            '
            Me.Journal_Referenceitem.Control = Me.Journal_Reference
            Me.Journal_Referenceitem.Enabled = False
            Me.Journal_Referenceitem.Location = New System.Drawing.Point(0, 48)
            Me.Journal_Referenceitem.Name = "Journal_Referenceitem"
            Me.Journal_Referenceitem.Size = New System.Drawing.Size(203, 24)
            Me.Journal_Referenceitem.Text = "Reference"
            Me.Journal_Referenceitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Journal_Referenceitem.TextSize = New System.Drawing.Size(69, 13)
            '
            'Journal_Codeitem
            '
            Me.Journal_Codeitem.Control = Me.Journal_Code
            Me.Journal_Codeitem.Enabled = False
            Me.Journal_Codeitem.Location = New System.Drawing.Point(0, 24)
            Me.Journal_Codeitem.Name = "Journal_Codeitem"
            Me.Journal_Codeitem.Size = New System.Drawing.Size(203, 24)
            Me.Journal_Codeitem.Text = "Code"
            Me.Journal_Codeitem.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem_Corporation
            '
            Me.LayoutControlItem_Corporation.Control = Me.Corporation
            Me.LayoutControlItem_Corporation.Enabled = False
            Me.LayoutControlItem_Corporation.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem_Corporation.Name = "LayoutControlItem_Corporation"
            Me.LayoutControlItem_Corporation.Size = New System.Drawing.Size(203, 24)
            Me.LayoutControlItem_Corporation.Text = "Corporation"
            Me.LayoutControlItem_Corporation.TextSize = New System.Drawing.Size(69, 13)
            '
            'Journal_Branchitem
            '
            Me.Journal_Branchitem.Control = Me.Journal_Branch
            Me.Journal_Branchitem.Location = New System.Drawing.Point(203, 72)
            Me.Journal_Branchitem.Name = "Journal_Branchitem"
            Me.Journal_Branchitem.Size = New System.Drawing.Size(203, 24)
            Me.Journal_Branchitem.Text = "Branch"
            Me.Journal_Branchitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Journal_Branchitem.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.toggle_Reference
            Me.LayoutControlItem3.Location = New System.Drawing.Point(203, 24)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(203, 24)
            Me.LayoutControlItem3.Text = "Edit Mode"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem_New_Reference
            '
            Me.LayoutControlItem_New_Reference.Control = Me.toggle_New_Reference
            Me.LayoutControlItem_New_Reference.Location = New System.Drawing.Point(203, 48)
            Me.LayoutControlItem_New_Reference.Name = "LayoutControlItem_New_Reference"
            Me.LayoutControlItem_New_Reference.Size = New System.Drawing.Size(203, 24)
            Me.LayoutControlItem_New_Reference.Text = "New Ref."
            Me.LayoutControlItem_New_Reference.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlGroup3
            '
            Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem5, Me.LayoutControlItem6})
            Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
            Me.LayoutControlGroup3.Size = New System.Drawing.Size(406, 129)
            Me.LayoutControlGroup3.Text = "Liquidation"
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Voucher_Reference
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 22)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(321, 26)
            Me.LayoutControlItem4.Text = "Voucher Ref."
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.Liquidation_Justification
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(406, 81)
            Me.LayoutControlItem8.Text = "Justification"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.toggle_Is_Liquidation
            Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(190, 22)
            Me.LayoutControlItem9.Text = "Liquidation?"
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.toggle_Liquidated
            Me.LayoutControlItem5.Location = New System.Drawing.Point(190, 0)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(216, 22)
            Me.LayoutControlItem5.Text = "Liquidated"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.btn_Liquidate
            Me.LayoutControlItem6.Location = New System.Drawing.Point(321, 22)
            Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(85, 26)
            Me.LayoutControlItem6.MinSize = New System.Drawing.Size(85, 26)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(85, 26)
            Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem6.TextVisible = False
            '
            'LayoutControlGroup4
            '
            Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem4, Me.LayoutControlItem7})
            Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
            Me.LayoutControlGroup4.Size = New System.Drawing.Size(406, 129)
            Me.LayoutControlGroup4.Text = "Budget"
            '
            'EmptySpaceItem4
            '
            Me.EmptySpaceItem4.AllowHotTrack = False
            Me.EmptySpaceItem4.Location = New System.Drawing.Point(0, 24)
            Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
            Me.EmptySpaceItem4.Size = New System.Drawing.Size(406, 105)
            Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.Budget_Code
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(406, 24)
            Me.LayoutControlItem7.Text = "Budget"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlGroup5
            '
            Me.LayoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.EmptySpaceItem1})
            Me.LayoutControlGroup5.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup5.Name = "LayoutControlGroup5"
            Me.LayoutControlGroup5.Size = New System.Drawing.Size(406, 129)
            Me.LayoutControlGroup5.Text = "Balance"
            '
            'LayoutControlItem10
            '
            Me.LayoutControlItem10.Control = Me.Balance_Running
            Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem10.Name = "LayoutControlItem10"
            Me.LayoutControlItem10.Size = New System.Drawing.Size(406, 24)
            Me.LayoutControlItem10.Text = "Running Bal."
            Me.LayoutControlItem10.TextSize = New System.Drawing.Size(69, 13)
            '
            'EmptySpaceItem1
            '
            Me.EmptySpaceItem1.AllowHotTrack = False
            Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 24)
            Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
            Me.EmptySpaceItem1.Size = New System.Drawing.Size(406, 105)
            Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            '
            'LayoutControlGroup6
            '
            Me.LayoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem2, Me.Added, Me.Modified, Me.Approved, Me.Deleted, Me.Modification, Me.Transacted, Me.Verified})
            Me.LayoutControlGroup6.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup6.Name = "LayoutControlGroup6"
            Me.LayoutControlGroup6.Size = New System.Drawing.Size(406, 129)
            Me.LayoutControlGroup6.Text = "Others"
            '
            'EmptySpaceItem2
            '
            Me.EmptySpaceItem2.AllowHotTrack = False
            Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 119)
            Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
            Me.EmptySpaceItem2.Size = New System.Drawing.Size(406, 10)
            Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            '
            'Added
            '
            Me.Added.AllowHotTrack = False
            Me.Added.Location = New System.Drawing.Point(0, 17)
            Me.Added.Name = "Added"
            Me.Added.Size = New System.Drawing.Size(406, 17)
            Me.Added.Text = "Added"
            Me.Added.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.Added.TextSize = New System.Drawing.Size(31, 13)
            '
            'Modified
            '
            Me.Modified.AllowHotTrack = False
            Me.Modified.Location = New System.Drawing.Point(0, 34)
            Me.Modified.Name = "Modified"
            Me.Modified.Size = New System.Drawing.Size(406, 17)
            Me.Modified.Text = "Modified"
            Me.Modified.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.Modified.TextSize = New System.Drawing.Size(40, 13)
            '
            'Approved
            '
            Me.Approved.AllowHotTrack = False
            Me.Approved.Location = New System.Drawing.Point(0, 51)
            Me.Approved.Name = "Approved"
            Me.Approved.Size = New System.Drawing.Size(406, 17)
            Me.Approved.Text = "Approved"
            Me.Approved.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.Approved.TextSize = New System.Drawing.Size(47, 13)
            '
            'Deleted
            '
            Me.Deleted.AllowHotTrack = False
            Me.Deleted.Location = New System.Drawing.Point(0, 68)
            Me.Deleted.Name = "Deleted"
            Me.Deleted.Size = New System.Drawing.Size(406, 17)
            Me.Deleted.Text = "Deleted"
            Me.Deleted.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.Deleted.TextSize = New System.Drawing.Size(37, 13)
            '
            'Modification
            '
            Me.Modification.AllowHotTrack = False
            Me.Modification.Location = New System.Drawing.Point(0, 102)
            Me.Modification.Name = "Modification"
            Me.Modification.Size = New System.Drawing.Size(406, 17)
            Me.Modification.Text = "Modification"
            Me.Modification.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.Modification.TextSize = New System.Drawing.Size(57, 13)
            '
            'Transacted
            '
            Me.Transacted.AllowHotTrack = False
            Me.Transacted.Location = New System.Drawing.Point(0, 0)
            Me.Transacted.Name = "Transacted"
            Me.Transacted.Size = New System.Drawing.Size(406, 17)
            Me.Transacted.Text = "Transacted"
            Me.Transacted.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.Transacted.TextSize = New System.Drawing.Size(54, 13)
            '
            'Verified
            '
            Me.Verified.AllowHotTrack = False
            Me.Verified.Location = New System.Drawing.Point(0, 85)
            Me.Verified.Name = "Verified"
            Me.Verified.Size = New System.Drawing.Size(406, 17)
            Me.Verified.Text = "Verified"
            Me.Verified.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
            Me.Verified.TextSize = New System.Drawing.Size(36, 13)
            '
            'Journal_Debititem
            '
            Me.Journal_Debititem.Control = Me.Journal_Debit
            Me.Journal_Debititem.Location = New System.Drawing.Point(0, 296)
            Me.Journal_Debititem.Name = "Journal_Debititem"
            Me.Journal_Debititem.Size = New System.Drawing.Size(214, 24)
            Me.Journal_Debititem.Text = "Debit"
            Me.Journal_Debititem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Journal_Debititem.TextSize = New System.Drawing.Size(69, 13)
            '
            'Account_Nameitem
            '
            Me.Account_Nameitem.Control = Me.Account_Name
            Me.Account_Nameitem.Location = New System.Drawing.Point(0, 272)
            Me.Account_Nameitem.Name = "Account_Nameitem"
            Me.Account_Nameitem.Size = New System.Drawing.Size(430, 24)
            Me.Account_Nameitem.Text = "Name"
            Me.Account_Nameitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Account_Nameitem.TextSize = New System.Drawing.Size(69, 13)
            '
            'Journal_Profileitem
            '
            Me.Journal_Profileitem.Control = Me.Journal_Profile
            Me.Journal_Profileitem.Location = New System.Drawing.Point(0, 176)
            Me.Journal_Profileitem.Name = "Journal_Profileitem"
            Me.Journal_Profileitem.Size = New System.Drawing.Size(430, 24)
            Me.Journal_Profileitem.Text = "Profile"
            Me.Journal_Profileitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Journal_Profileitem.TextSize = New System.Drawing.Size(69, 13)
            '
            'Account_Codeitem
            '
            Me.Account_Codeitem.Control = Me.Account_Code
            Me.Account_Codeitem.Location = New System.Drawing.Point(0, 248)
            Me.Account_Codeitem.Name = "Account_Codeitem"
            Me.Account_Codeitem.Size = New System.Drawing.Size(430, 24)
            Me.Account_Codeitem.Text = "Code"
            Me.Account_Codeitem.TextSize = New System.Drawing.Size(69, 13)
            Me.Account_Codeitem.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization
            '
            'Journal_Credititem
            '
            Me.Journal_Credititem.Control = Me.Journal_Credit
            Me.Journal_Credititem.Location = New System.Drawing.Point(214, 296)
            Me.Journal_Credititem.Name = "Journal_Credititem"
            Me.Journal_Credititem.Size = New System.Drawing.Size(216, 24)
            Me.Journal_Credititem.Text = "Credit"
            Me.Journal_Credititem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Journal_Credititem.TextSize = New System.Drawing.Size(69, 13)
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(0, 370)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(430, 10)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.COA_Code
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 200)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(430, 24)
            Me.LayoutControlItem2.Text = "Account Title"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(69, 13)
            '
            'Posting_Dateitem
            '
            Me.Posting_Dateitem.Control = Me.Posting_Date
            Me.Posting_Dateitem.Location = New System.Drawing.Point(0, 224)
            Me.Posting_Dateitem.Name = "Posting_Dateitem"
            Me.Posting_Dateitem.Size = New System.Drawing.Size(215, 24)
            Me.Posting_Dateitem.Text = "Posting Date"
            Me.Posting_Dateitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.Posting_Dateitem.TextSize = New System.Drawing.Size(69, 13)
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.Check_Number
            Me.LayoutControlItem1.Location = New System.Drawing.Point(215, 224)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(215, 24)
            Me.LayoutControlItem1.Text = "Check Number"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(69, 13)
            '
            'colID
            '
            Me.colID.Name = "colID"
            '
            'colVoucher_Reference
            '
            Me.colVoucher_Reference.Name = "colVoucher_Reference"
            '
            'colExpense_Type
            '
            Me.colExpense_Type.Name = "colExpense_Type"
            '
            'colVoucher_Date_Posted
            '
            Me.colVoucher_Date_Posted.Name = "colVoucher_Date_Posted"
            '
            'colLiquidation_Days
            '
            Me.colLiquidation_Days.Name = "colLiquidation_Days"
            '
            'colLiquidation_Date_Expiry
            '
            Me.colLiquidation_Date_Expiry.Name = "colLiquidation_Date_Expiry"
            '
            'colVoucher_Debit
            '
            Me.colVoucher_Debit.Name = "colVoucher_Debit"
            '
            'colVoucher_Description
            '
            Me.colVoucher_Description.Name = "colVoucher_Description"
            '
            'SimpleLabelItem3
            '
            Me.SimpleLabelItem3.AllowHotTrack = False
            Me.SimpleLabelItem3.Location = New System.Drawing.Point(120, 0)
            Me.SimpleLabelItem3.Name = "SimpleLabelItem3"
            Me.SimpleLabelItem3.Size = New System.Drawing.Size(120, 17)
            Me.SimpleLabelItem3.Text = "Posted_By"
            Me.SimpleLabelItem3.TextSize = New System.Drawing.Size(106, 13)
            '
            'xuc_Journal_Entry
            '
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_Journal_Entry"
            Me.Size = New System.Drawing.Size(450, 492)
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            Me.layoutControl.PerformLayout()
            CType(Me.Balance_Running.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toggle_Is_Liquidation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Budget_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toggle_Liquidated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.COA_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TreeListLookUpEdit_COA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_COA, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toggle_New_Reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.toggle_Reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PopupContainerControl.ResumeLayout(False)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Posting_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Posting_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Branch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Debit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Credit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Profile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Table_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Voucher_Reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SearchLookUpEditView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Liquidation_Justification.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Corporation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notesitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Descriptionitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IDitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Typeitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Table_IDitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Referenceitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Codeitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem_Corporation, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Branchitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem_New_Reference, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Added, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Modified, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Approved, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Deleted, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Modification, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Transacted, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Verified, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Debititem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Nameitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Profileitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Account_Codeitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Journal_Credititem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Posting_Dateitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SimpleLabelItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend Notes As DevExpress.XtraEditors.MemoEdit
        Friend Journal_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Journal_Credit As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents Journal_Debit As DevExpress.XtraEditors.CalcEdit
        Friend Account_Code As DevExpress.XtraEditors.TextEdit
        Friend Journal_Branch As DevExpress.XtraEditors.LookUpEdit
        Friend Posting_Date As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Journal_Profile As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents Journal_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Account_Name As DevExpress.XtraEditors.PopupContainerEdit
        Friend WithEvents PopupContainerControl As DevExpress.XtraEditors.PopupContainerControl
        Friend WithEvents xuc_Account_Search As Controls.Information.Account.xuc_Account_Search
        Friend WithEvents Journal_Type As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents Notesitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Journal_Descriptionitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Table_ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents toggle_Reference As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents Journal_Reference As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents toggle_New_Reference As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents Check_Number As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents COA_Code As DevExpress.XtraEditors.TreeListLookUpEdit
        Friend WithEvents TreeListLookUpEdit_COA As DevExpress.XtraTreeList.TreeList
        Friend WithEvents colCOA_Type As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Summary As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Code As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Name As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Desc As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents RepositoryItemLookUpEdit_COA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
        Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents IDitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Table_IDitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Journal_Codeitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Journal_Referenceitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem_Corporation As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem_New_Reference As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Journal_Branchitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Journal_Typeitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Journal_Profileitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Posting_Dateitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Account_Codeitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Account_Nameitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Journal_Debititem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Journal_Credititem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Voucher_Reference As DevExpress.XtraEditors.SearchLookUpEdit
        Friend WithEvents SearchLookUpEditView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colVoucher_Reference As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colExpense_Type As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVoucher_Date_Posted As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLiquidation_Days As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLiquidation_Date_Expiry As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVoucher_Debit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colVoucher_Description As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents toggle_Liquidated As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents btn_Liquidate As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Budget_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Liquidation_Justification As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents toggle_Is_Liquidation As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Corporation As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Balance_Running As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents LayoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents LayoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
        Friend WithEvents SimpleLabelItem3 As DevExpress.XtraLayout.SimpleLabelItem
        Friend WithEvents Added As DevExpress.XtraLayout.SimpleLabelItem
        Friend WithEvents Modified As DevExpress.XtraLayout.SimpleLabelItem
        Friend WithEvents Approved As DevExpress.XtraLayout.SimpleLabelItem
        Friend WithEvents Deleted As DevExpress.XtraLayout.SimpleLabelItem
        Friend WithEvents Modification As DevExpress.XtraLayout.SimpleLabelItem
        Friend WithEvents Transacted As DevExpress.XtraLayout.SimpleLabelItem
        Friend WithEvents Verified As DevExpress.XtraLayout.SimpleLabelItem
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace
