<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_FirstLoadSummaryTabular
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    private sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_FirstLoadSummaryTabular))
        Me.GCAcctCnt = New DevExpress.XtraGrid.GridControl()
        Me.GViewCnt = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.BrCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AECode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Current = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.OverDue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AcctCnt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Deposited = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GCAcctCnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GViewCnt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GCAcctCnt
        '
        Me.GCAcctCnt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCAcctCnt.Location = New System.Drawing.Point(0, 0)
        Me.GCAcctCnt.MainView = Me.GViewCnt
        Me.GCAcctCnt.Name = "GCAcctCnt"
        Me.GCAcctCnt.Size = New System.Drawing.Size(1011, 379)
        Me.GCAcctCnt.TabIndex = 0
        Me.GCAcctCnt.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GViewCnt})
        '
        'GViewCnt
        '
        Me.GViewCnt.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.BrCode, Me.AECode, Me.Current, Me.OverDue, Me.AcctCnt, Me.Deposited})
        Me.GViewCnt.gridControl = Me.GCAcctCnt
        Me.GViewCnt.Name = "GViewCnt"
        '
        'BrCode
        '
        Me.BrCode.Caption = "BrCode"
        Me.BrCode.FieldName = "BrCode"
        Me.BrCode.Name = "BrCode"
        Me.BrCode.Visible = True
        Me.BrCode.VisibleIndex = 0
        '
        'AECode
        '
        Me.AECode.Caption = "AECode"
        Me.AECode.FieldName = "AECode"
        Me.AECode.Name = "AECode"
        Me.AECode.Visible = True
        Me.AECode.VisibleIndex = 1
        '
        'Current
        '
        Me.Current.Caption = "Current"
        Me.Current.FieldName = "Current"
        Me.Current.Name = "Current"
        Me.Current.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Current", "SUM={0:0.##}")})
        Me.Current.Visible = True
        Me.Current.VisibleIndex = 2
        '
        'OverDue
        '
        Me.OverDue.Caption = "OverDue"
        Me.OverDue.FieldName = "OverDue"
        Me.OverDue.Name = "OverDue"
        Me.OverDue.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OverDue", "SUM={0:0.##}")})
        Me.OverDue.Visible = True
        Me.OverDue.VisibleIndex = 3
        '
        'AcctCnt
        '
        Me.AcctCnt.Caption = "TotalActiveAccount"
        Me.AcctCnt.FieldName = "AcctCnt"
        Me.AcctCnt.Name = "AcctCnt"
        Me.AcctCnt.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AcctCnt", "SUM={0:0.##}")})
        Me.AcctCnt.Visible = True
        Me.AcctCnt.VisibleIndex = 4
        '
        'Deposited
        '
        Me.Deposited.Caption = "Deposited"
        Me.Deposited.FieldName = "Deposited"
        Me.Deposited.Name = "Deposited"
        Me.Deposited.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Deposited", "SUM={0:0.##}")})
        Me.Deposited.Visible = True
        Me.Deposited.VisibleIndex = 5
        '
        'IS_FirstLoadSummaryTabular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1011, 379)
        Me.Controls.Add(Me.GCAcctCnt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_FirstLoadSummaryTabular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PER ACCOUNT EXECUTIVE"
        CType(Me.GCAcctCnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GViewCnt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GCAcctCnt As DevExpress.XtraGrid.GridControl
    Friend WithEvents GViewCnt As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BrCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AECode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Current As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents OverDue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AcctCnt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Deposited As DevExpress.XtraGrid.Columns.GridColumn
End Class
