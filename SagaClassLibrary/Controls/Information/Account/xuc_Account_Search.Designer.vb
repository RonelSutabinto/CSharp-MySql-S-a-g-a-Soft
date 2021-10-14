Namespace Controls.Information.Account
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Account_Search
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
            Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCode2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOthers = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.xuc_Account_SearchLayoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.SearchControl_Accounts = New DevExpress.XtraEditors.SearchControl()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.gridControlitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xuc_Account_SearchLayoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xuc_Account_SearchLayoutControl1ConvertedLayout.SuspendLayout()
            CType(Me.SearchControl_Accounts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControlitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl
            '
            Me.gridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.gridControl.Location = New System.Drawing.Point(12, 36)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(313, 328)
            Me.gridControl.TabIndex = 1
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colType, Me.colBranchCode, Me.colCode1, Me.colCode2, Me.colName, Me.colAmount, Me.colDate, Me.colOthers, Me.colNotes})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            Me.gridView.OptionsView.ShowFooter = True
            Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colID, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'colID
            '
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            '
            'colType
            '
            Me.colType.FieldName = "Type"
            Me.colType.Name = "colType"
            Me.colType.Visible = True
            Me.colType.VisibleIndex = 1
            '
            'colBranchCode
            '
            Me.colBranchCode.Caption = "Branch"
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 2
            '
            'colCode1
            '
            Me.colCode1.Caption = "Code 1"
            Me.colCode1.FieldName = "Code1"
            Me.colCode1.Name = "colCode1"
            Me.colCode1.Visible = True
            Me.colCode1.VisibleIndex = 3
            '
            'colCode2
            '
            Me.colCode2.Caption = "Code 2"
            Me.colCode2.FieldName = "Code2"
            Me.colCode2.Name = "colCode2"
            Me.colCode2.Visible = True
            Me.colCode2.VisibleIndex = 4
            '
            'colName
            '
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            Me.colName.Visible = True
            Me.colName.VisibleIndex = 5
            '
            'colAmount
            '
            Me.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colAmount.FieldName = "Amount"
            Me.colAmount.Name = "colAmount"
            Me.colAmount.Visible = True
            Me.colAmount.VisibleIndex = 6
            '
            'colDate
            '
            Me.colDate.FieldName = "Date"
            Me.colDate.Name = "colDate"
            Me.colDate.Visible = True
            Me.colDate.VisibleIndex = 7
            '
            'colOthers
            '
            Me.colOthers.FieldName = "Others"
            Me.colOthers.Name = "colOthers"
            Me.colOthers.Visible = True
            Me.colOthers.VisibleIndex = 8
            '
            'colNotes
            '
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.Visible = True
            Me.colNotes.VisibleIndex = 9
            '
            'xuc_Account_SearchLayoutControl1ConvertedLayout
            '
            Me.xuc_Account_SearchLayoutControl1ConvertedLayout.Controls.Add(Me.SearchControl_Accounts)
            Me.xuc_Account_SearchLayoutControl1ConvertedLayout.Controls.Add(Me.gridControl)
            Me.xuc_Account_SearchLayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account_SearchLayoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Account_SearchLayoutControl1ConvertedLayout.Name = "xuc_Account_SearchLayoutControl1ConvertedLayout"
            Me.xuc_Account_SearchLayoutControl1ConvertedLayout.Root = Me.LayoutControlGroup1
            Me.xuc_Account_SearchLayoutControl1ConvertedLayout.Size = New System.Drawing.Size(337, 376)
            Me.xuc_Account_SearchLayoutControl1ConvertedLayout.TabIndex = 0
            '
            'SearchControl_Accounts
            '
            Me.SearchControl_Accounts.Location = New System.Drawing.Point(95, 12)
            Me.SearchControl_Accounts.Name = "SearchControl_Accounts"
            Me.SearchControl_Accounts.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus, "", -1, True, True, True, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
            Me.SearchControl_Accounts.Properties.ShowMRUButton = True
            Me.SearchControl_Accounts.Size = New System.Drawing.Size(230, 20)
            Me.SearchControl_Accounts.StyleController = Me.xuc_Account_SearchLayoutControl1ConvertedLayout
            Me.SearchControl_Accounts.TabIndex = 4
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.gridControlitem, Me.LayoutControlItem1})
            Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(337, 376)
            Me.LayoutControlGroup1.TextVisible = False
            '
            'gridControlitem
            '
            Me.gridControlitem.Control = Me.gridControl
            Me.gridControlitem.Location = New System.Drawing.Point(0, 24)
            Me.gridControlitem.Name = "gridControlitem"
            Me.gridControlitem.Size = New System.Drawing.Size(317, 332)
            Me.gridControlitem.TextSize = New System.Drawing.Size(0, 0)
            Me.gridControlitem.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.SearchControl_Accounts
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(317, 24)
            Me.LayoutControlItem1.Text = "Search Accounts"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(80, 13)
            '
            'xuc_Account_Search
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xuc_Account_SearchLayoutControl1ConvertedLayout)
            Me.Name = "xuc_Account_Search"
            Me.Size = New System.Drawing.Size(337, 376)
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xuc_Account_SearchLayoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xuc_Account_SearchLayoutControl1ConvertedLayout.ResumeLayout(False)
            CType(Me.SearchControl_Accounts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControlitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Public WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCode1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCode2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOthers As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents xuc_Account_SearchLayoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents gridControlitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
        Public WithEvents SearchControl_Accounts As DevExpress.XtraEditors.SearchControl
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAmount As DevExpress.XtraGrid.Columns.GridColumn
        Public WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace