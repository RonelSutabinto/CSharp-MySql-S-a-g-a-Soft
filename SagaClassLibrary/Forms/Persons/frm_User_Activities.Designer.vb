Namespace Forms.Persons
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_User_Activities
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
        'It can be Modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colTransactedBy = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTransactionDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit_Branch = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()

            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit_Branch})
            Me.gridControl.Size = New System.Drawing.Size(404, 417)
            Me.gridControl.TabIndex = 2
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTransactedBy, Me.colTransactionDate, Me.colCode, Me.colDescription})
            Me.gridView.OptionsView.ColumnAutoWidth = False
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            '
            'colTransactedBy
            '
            Me.colTransactedBy.Caption = "Transacted By"
            Me.colTransactedBy.FieldName = "TransactedBy"
            Me.colTransactedBy.Name = "colTransactedBy"
            Me.colTransactedBy.Visible = True
            Me.colTransactedBy.VisibleIndex = 0
            '
            'colTransactionDate
            '
            Me.colTransactionDate.Caption = "Transacted"
            Me.colTransactionDate.FieldName = "TransactionDate"
            Me.colTransactionDate.Name = "colTransactionDate"
            Me.colTransactionDate.Visible = True
            Me.colTransactionDate.VisibleIndex = 1
            '
            'colCode
            '
            Me.colCode.Caption = "Code"
            Me.colCode.FieldName = "Code"
            Me.colCode.Name = "colCode"
            Me.colCode.Visible = True
            Me.colCode.VisibleIndex = 2
            '
            'colDescription
            '
            Me.colDescription.Caption = "Description"
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 3
            '
            'repositoryItemLookUpEdit_Branch
            '
            Me.repositoryItemLookUpEdit_Branch.AutoHeight = False
            Me.repositoryItemLookUpEdit_Branch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit_Branch.Name = "repositoryItemLookUpEdit_Branch"
            '
            'frm_User_Activities
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(404, 417)
            Me.Controls.Add(Me.gridControl)
            Me.Name = "frm_User_Activities"
            Me.Text = "User's Activity"
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemLookUpEdit_Branch, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents repositoryItemLookUpEdit_Branch As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents colTransactedBy As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colTransactionDate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace