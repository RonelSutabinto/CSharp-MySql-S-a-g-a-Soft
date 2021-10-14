Namespace Controls.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Trial_Balance_Tree
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xuc_Trial_Balance_Tree))
            Me.treeList = New DevExpress.XtraTreeList.TreeList()
            Me.colCOA_Name = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colFS_Name = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Summary = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Code = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colBalance_Type = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colDate_Type = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colBalance_Date = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colBeginning_Balance_Debit = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colBeginning_Balance_Credit = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colDate_Range_Start = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colTotal_Debit = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colTotal_Credit = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colDate_Range_End = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colEnding_Balance_Debit = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colEnding_Balance_Credit = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCOA_Normal = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colBalance_Sheet = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colIncome_Statement = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colNotes = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colAdded_By = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colAdded_Date = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colModified_By = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colModified_Date = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colID = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
            Me.btn_Reload = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_COA_Balances = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_COA_Ledger = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Preview = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Expand = New DevExpress.XtraBars.BarButtonItem()
            Me.btn_Collapse = New DevExpress.XtraBars.BarButtonItem()
            Me.barManager = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            CType(Me.treeList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'treeList
            '
            Me.treeList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colCOA_Name, Me.colFS_Name, Me.colCOA_Summary, Me.colCOA_Code, Me.colBalance_Type, Me.colDate_Type, Me.colBalance_Date, Me.colBeginning_Balance_Debit, Me.colBeginning_Balance_Credit, Me.colDate_Range_Start, Me.colTotal_Debit, Me.colTotal_Credit, Me.colDate_Range_End, Me.colEnding_Balance_Debit, Me.colEnding_Balance_Credit, Me.colCOA_Normal, Me.colBalance_Sheet, Me.colIncome_Statement, Me.colNotes, Me.colAdded_By, Me.colAdded_Date, Me.colModified_By, Me.colModified_Date, Me.colID})
            Me.treeList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeList.Location = New System.Drawing.Point(0, 0)
            Me.treeList.Name = "treeList"
            Me.treeList.OptionsView.AutoWidth = False
            Me.treeList.Size = New System.Drawing.Size(419, 267)
            Me.treeList.TabIndex = 0
            '
            'colCOA_Name
            '
            Me.colCOA_Name.FieldName = "COA_Name"
            Me.colCOA_Name.Name = "colCOA_Name"
            Me.colCOA_Name.Visible = True
            Me.colCOA_Name.VisibleIndex = 0
            '
            'colFS_Name
            '
            Me.colFS_Name.FieldName = "FS_Name"
            Me.colFS_Name.Name = "colFS_Name"
            Me.colFS_Name.Visible = True
            Me.colFS_Name.VisibleIndex = 1
            '
            'colCOA_Summary
            '
            Me.colCOA_Summary.FieldName = "COA_Summary"
            Me.colCOA_Summary.Name = "colCOA_Summary"
            Me.colCOA_Summary.Visible = True
            Me.colCOA_Summary.VisibleIndex = 2
            '
            'colCOA_Code
            '
            Me.colCOA_Code.FieldName = "COA_Code"
            Me.colCOA_Code.Name = "colCOA_Code"
            Me.colCOA_Code.Visible = True
            Me.colCOA_Code.VisibleIndex = 3
            '
            'colBalance_Type
            '
            Me.colBalance_Type.FieldName = "Balance_Type"
            Me.colBalance_Type.Name = "colBalance_Type"
            Me.colBalance_Type.Visible = True
            Me.colBalance_Type.VisibleIndex = 4
            '
            'colDate_Type
            '
            Me.colDate_Type.FieldName = "Date_Type"
            Me.colDate_Type.Name = "colDate_Type"
            Me.colDate_Type.Visible = True
            Me.colDate_Type.VisibleIndex = 5
            '
            'colBalance_Date
            '
            Me.colBalance_Date.FieldName = "Balance_Date"
            Me.colBalance_Date.Name = "colBalance_Date"
            Me.colBalance_Date.Visible = True
            Me.colBalance_Date.VisibleIndex = 6
            '
            'colBeginning_Balance_Debit
            '
            Me.colBeginning_Balance_Debit.AllNodesSummary = True
            Me.colBeginning_Balance_Debit.Caption = "Beginning Debit"
            Me.colBeginning_Balance_Debit.FieldName = "Beginning_Balance_Debit"
            Me.colBeginning_Balance_Debit.Format.FormatString = "{0:N2}"
            Me.colBeginning_Balance_Debit.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBeginning_Balance_Debit.Name = "colBeginning_Balance_Debit"
            Me.colBeginning_Balance_Debit.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colBeginning_Balance_Debit.RowFooterSummaryStrFormat = "{0:N2}"
            Me.colBeginning_Balance_Debit.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colBeginning_Balance_Debit.SummaryFooterStrFormat = "{0:N2}"
            Me.colBeginning_Balance_Debit.Visible = True
            Me.colBeginning_Balance_Debit.VisibleIndex = 7
            '
            'colBeginning_Balance_Credit
            '
            Me.colBeginning_Balance_Credit.AllNodesSummary = True
            Me.colBeginning_Balance_Credit.Caption = "Beginning Credit"
            Me.colBeginning_Balance_Credit.FieldName = "Beginning_Balance_Credit"
            Me.colBeginning_Balance_Credit.Format.FormatString = "{0:N2}"
            Me.colBeginning_Balance_Credit.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBeginning_Balance_Credit.Name = "colBeginning_Balance_Credit"
            Me.colBeginning_Balance_Credit.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colBeginning_Balance_Credit.RowFooterSummaryStrFormat = "{0:N2}"
            Me.colBeginning_Balance_Credit.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colBeginning_Balance_Credit.SummaryFooterStrFormat = "{0:N2}"
            Me.colBeginning_Balance_Credit.Visible = True
            Me.colBeginning_Balance_Credit.VisibleIndex = 8
            '
            'colDate_Range_Start
            '
            Me.colDate_Range_Start.FieldName = "Date_Range_Start"
            Me.colDate_Range_Start.Name = "colDate_Range_Start"
            Me.colDate_Range_Start.Visible = True
            Me.colDate_Range_Start.VisibleIndex = 9
            '
            'colTotal_Debit
            '
            Me.colTotal_Debit.AllNodesSummary = True
            Me.colTotal_Debit.FieldName = "Total_Debit"
            Me.colTotal_Debit.Format.FormatString = "{0:N2}"
            Me.colTotal_Debit.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Debit.Name = "colTotal_Debit"
            Me.colTotal_Debit.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colTotal_Debit.RowFooterSummaryStrFormat = "{0:N2}"
            Me.colTotal_Debit.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colTotal_Debit.SummaryFooterStrFormat = "{0:N2}"
            Me.colTotal_Debit.Visible = True
            Me.colTotal_Debit.VisibleIndex = 10
            '
            'colTotal_Credit
            '
            Me.colTotal_Credit.AllNodesSummary = True
            Me.colTotal_Credit.FieldName = "Total_Credit"
            Me.colTotal_Credit.Format.FormatString = "{0:N2}"
            Me.colTotal_Credit.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal_Credit.Name = "colTotal_Credit"
            Me.colTotal_Credit.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colTotal_Credit.RowFooterSummaryStrFormat = "{0:N2}"
            Me.colTotal_Credit.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colTotal_Credit.SummaryFooterStrFormat = "{0:N2}"
            Me.colTotal_Credit.Visible = True
            Me.colTotal_Credit.VisibleIndex = 11
            '
            'colDate_Range_End
            '
            Me.colDate_Range_End.FieldName = "Date_Range_End"
            Me.colDate_Range_End.Name = "colDate_Range_End"
            Me.colDate_Range_End.Visible = True
            Me.colDate_Range_End.VisibleIndex = 12
            '
            'colEnding_Balance_Debit
            '
            Me.colEnding_Balance_Debit.AllNodesSummary = True
            Me.colEnding_Balance_Debit.Caption = "Ending Debit"
            Me.colEnding_Balance_Debit.FieldName = "Ending_Balance_Debit"
            Me.colEnding_Balance_Debit.Format.FormatString = "{0:N2}"
            Me.colEnding_Balance_Debit.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colEnding_Balance_Debit.Name = "colEnding_Balance_Debit"
            Me.colEnding_Balance_Debit.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colEnding_Balance_Debit.RowFooterSummaryStrFormat = "{0:N2}"
            Me.colEnding_Balance_Debit.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colEnding_Balance_Debit.SummaryFooterStrFormat = "{0:N2}"
            Me.colEnding_Balance_Debit.Visible = True
            Me.colEnding_Balance_Debit.VisibleIndex = 13
            '
            'colEnding_Balance_Credit
            '
            Me.colEnding_Balance_Credit.AllNodesSummary = True
            Me.colEnding_Balance_Credit.Caption = "Ending Credit"
            Me.colEnding_Balance_Credit.FieldName = "Ending_Balance_Credit"
            Me.colEnding_Balance_Credit.Format.FormatString = "{0:N2}"
            Me.colEnding_Balance_Credit.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colEnding_Balance_Credit.Name = "colEnding_Balance_Credit"
            Me.colEnding_Balance_Credit.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colEnding_Balance_Credit.RowFooterSummaryStrFormat = "{0:N2}"
            Me.colEnding_Balance_Credit.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colEnding_Balance_Credit.SummaryFooterStrFormat = "{0:N2}"
            Me.colEnding_Balance_Credit.Visible = True
            Me.colEnding_Balance_Credit.VisibleIndex = 14
            '
            'colCOA_Normal
            '
            Me.colCOA_Normal.FieldName = "COA_Normal"
            Me.colCOA_Normal.Name = "colCOA_Normal"
            Me.colCOA_Normal.Visible = True
            Me.colCOA_Normal.VisibleIndex = 15
            '
            'colBalance_Sheet
            '
            Me.colBalance_Sheet.AllNodesSummary = True
            Me.colBalance_Sheet.FieldName = "Balance_Sheet"
            Me.colBalance_Sheet.Format.FormatString = "{0:N2}"
            Me.colBalance_Sheet.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBalance_Sheet.Name = "colBalance_Sheet"
            Me.colBalance_Sheet.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colBalance_Sheet.RowFooterSummaryStrFormat = "{0:N2}"
            Me.colBalance_Sheet.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colBalance_Sheet.SummaryFooterStrFormat = "{0:N2}"
            Me.colBalance_Sheet.Visible = True
            Me.colBalance_Sheet.VisibleIndex = 16
            '
            'colIncome_Statement
            '
            Me.colIncome_Statement.AllNodesSummary = True
            Me.colIncome_Statement.FieldName = "Income_Statement"
            Me.colIncome_Statement.Format.FormatString = "{0:N2}"
            Me.colIncome_Statement.Format.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colIncome_Statement.Name = "colIncome_Statement"
            Me.colIncome_Statement.RowFooterSummary = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colIncome_Statement.RowFooterSummaryStrFormat = "{0:N2}"
            Me.colIncome_Statement.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
            Me.colIncome_Statement.SummaryFooterStrFormat = "{0:N2}"
            Me.colIncome_Statement.Visible = True
            Me.colIncome_Statement.VisibleIndex = 17
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 18
            '
            'colAdded_By
            '
            Me.colAdded_By.FieldName = "Added_By"
            Me.colAdded_By.Name = "colAdded_By"
            Me.colAdded_By.Visible = True
            Me.colAdded_By.VisibleIndex = 19
            '
            'colAdded_Date
            '
            Me.colAdded_Date.FieldName = "Added_Date"
            Me.colAdded_Date.Name = "colAdded_Date"
            Me.colAdded_Date.Visible = True
            Me.colAdded_Date.VisibleIndex = 20
            '
            'colModified_By
            '
            Me.colModified_By.FieldName = "Modified_By"
            Me.colModified_By.Name = "colModified_By"
            Me.colModified_By.Visible = True
            Me.colModified_By.VisibleIndex = 21
            '
            'colModified_Date
            '
            Me.colModified_Date.FieldName = "Modified_Date"
            Me.colModified_Date.Name = "colModified_Date"
            Me.colModified_Date.Visible = True
            Me.colModified_Date.VisibleIndex = 22
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 23
            '
            'PopupMenu
            '
            Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Reload), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_COA_Balances), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_COA_Ledger), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Preview), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Expand, True), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_Collapse)})
            Me.PopupMenu.Manager = Me.barManager
            Me.PopupMenu.Name = "PopupMenu"
            '
            'btn_Reload
            '
            Me.btn_Reload.Caption = "Reload"
            Me.btn_Reload.Id = 0
            Me.btn_Reload.ImageOptions.ImageIndex = 0
            Me.btn_Reload.ImageOptions.LargeImageIndex = 0
            Me.btn_Reload.Name = "btn_Reload"
            '
            'btn_COA_Balances
            '
            Me.btn_COA_Balances.Caption = "Balances"
            Me.btn_COA_Balances.Id = 22
            Me.btn_COA_Balances.ImageOptions.Image = CType(resources.GetObject("btn_COA_Balances.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_COA_Balances.ImageOptions.LargeImage = CType(resources.GetObject("btn_COA_Balances.ImageOptions.LargeImage"), System.Drawing.Image)
            Me.btn_COA_Balances.Name = "btn_COA_Balances"
            '
            'btn_COA_Ledger
            '
            Me.btn_COA_Ledger.Caption = "Ledger"
            Me.btn_COA_Ledger.Id = 19
            Me.btn_COA_Ledger.ImageOptions.ImageIndex = 8
            Me.btn_COA_Ledger.ImageOptions.LargeImageIndex = 8
            Me.btn_COA_Ledger.Name = "btn_COA_Ledger"
            '
            'btn_Preview
            '
            Me.btn_Preview.Caption = "Preview"
            Me.btn_Preview.Id = 8
            Me.btn_Preview.ImageOptions.ImageIndex = 1
            Me.btn_Preview.ImageOptions.LargeImageIndex = 1
            Me.btn_Preview.Name = "btn_Preview"
            '
            'btn_Expand
            '
            Me.btn_Expand.Caption = "Expand"
            Me.btn_Expand.Id = 17
            Me.btn_Expand.ImageOptions.ImageIndex = 6
            Me.btn_Expand.Name = "btn_Expand"
            '
            'btn_Collapse
            '
            Me.btn_Collapse.Caption = "Collapse"
            Me.btn_Collapse.Id = 18
            Me.btn_Collapse.ImageOptions.ImageIndex = 7
            Me.btn_Collapse.Name = "btn_Collapse"
            '
            'barManager
            '
            Me.barManager.DockControls.Add(Me.barDockControlTop)
            Me.barManager.DockControls.Add(Me.barDockControlBottom)
            Me.barManager.DockControls.Add(Me.barDockControlLeft)
            Me.barManager.DockControls.Add(Me.barDockControlRight)
            Me.barManager.Form = Me
            Me.barManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_Reload, Me.btn_Preview, Me.btn_Expand, Me.btn_Collapse, Me.btn_COA_Ledger, Me.btn_COA_Balances})
            Me.barManager.MaxItemId = 23
            Me.barManager.SharedImageCollectionImageSizeMode = DevExpress.Utils.SharedImageCollectionImageSizeMode.UseImageSize
            '
            'barDockControlTop
            '
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager
            Me.barDockControlTop.Size = New System.Drawing.Size(419, 0)
            '
            'barDockControlBottom
            '
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 267)
            Me.barDockControlBottom.Manager = Me.barManager
            Me.barDockControlBottom.Size = New System.Drawing.Size(419, 0)
            '
            'barDockControlLeft
            '
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Manager = Me.barManager
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 267)
            '
            'barDockControlRight
            '
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(419, 0)
            Me.barDockControlRight.Manager = Me.barManager
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 267)
            '
            'xuc_Trial_Balance_Tree
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.treeList)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "xuc_Trial_Balance_Tree"
            Me.Size = New System.Drawing.Size(419, 267)
            CType(Me.treeList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.barManager, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents treeList As DevExpress.XtraTreeList.TreeList
        Friend WithEvents colCOA_Name As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colFS_Name As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Summary As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Code As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colBalance_Type As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colDate_Type As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colBalance_Date As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colBeginning_Balance_Debit As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colBeginning_Balance_Credit As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colDate_Range_Start As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colTotal_Debit As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colTotal_Credit As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colDate_Range_End As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colEnding_Balance_Debit As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colEnding_Balance_Credit As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colCOA_Normal As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colBalance_Sheet As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colIncome_Statement As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colNotes As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colAdded_By As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colAdded_Date As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colModified_By As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents colModified_Date As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
        Friend WithEvents btn_Reload As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_COA_Balances As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_COA_Ledger As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Preview As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Expand As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents btn_Collapse As DevExpress.XtraBars.BarButtonItem
        Friend WithEvents barManager As DevExpress.XtraBars.BarManager
        Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
        Friend WithEvents colID As DevExpress.XtraTreeList.Columns.TreeListColumn
    End Class
End Namespace