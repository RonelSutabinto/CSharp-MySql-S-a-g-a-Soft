<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xuc_SPA_SRF
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
        Me.ID = New DevExpress.XtraEditors.TextEdit()
        Me.Reference = New DevExpress.XtraEditors.TextEdit()
        Me.SRF_Number = New DevExpress.XtraEditors.TextEdit()
        Me.Branch_From = New DevExpress.XtraEditors.LookUpEdit()
        Me.Transaction_Date = New DevExpress.XtraEditors.DateEdit()
        Me.Description = New DevExpress.XtraEditors.MemoEdit()
        Me.Notes = New DevExpress.XtraEditors.MemoEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SRF_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Branch_From.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transaction_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transaction_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl.Controls.Add(Me.ID)
        Me.LayoutControl.Controls.Add(Me.Reference)
        Me.LayoutControl.Controls.Add(Me.SRF_Number)
        Me.LayoutControl.Controls.Add(Me.Branch_From)
        Me.LayoutControl.Controls.Add(Me.Transaction_Date)
        Me.LayoutControl.Controls.Add(Me.Description)
        Me.LayoutControl.Controls.Add(Me.Notes)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl1"
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(254, 376)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(112, 12)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(130, 20)
        Me.ID.StyleController = Me.layoutControl
        Me.ID.TabIndex = 4
        '
        'Reference
        '
        Me.Reference.Location = New System.Drawing.Point(112, 60)
        Me.Reference.Name = "Reference"
        Me.Reference.Properties.ReadOnly = True
        Me.Reference.Size = New System.Drawing.Size(130, 20)
        Me.Reference.StyleController = Me.layoutControl
        Me.Reference.TabIndex = 6
        '
        'SRF_Number
        '
        Me.SRF_Number.Location = New System.Drawing.Point(112, 84)
        Me.SRF_Number.Name = "SRF_Number"
        Me.SRF_Number.Properties.ReadOnly = True
        Me.SRF_Number.Size = New System.Drawing.Size(130, 20)
        Me.SRF_Number.StyleController = Me.layoutControl
        Me.SRF_Number.TabIndex = 7
        '
        'Branch_From
        '
        Me.Branch_From.Location = New System.Drawing.Point(112, 36)
        Me.Branch_From.Name = "Branch_From"
        Me.Branch_From.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Branch_From.Properties.NullText = ""
        Me.Branch_From.Size = New System.Drawing.Size(130, 20)
        Me.Branch_From.StyleController = Me.layoutControl
        Me.Branch_From.TabIndex = 5
        '
        'Transaction_Date
        '
        Me.Transaction_Date.EditValue = Nothing
        Me.Transaction_Date.Location = New System.Drawing.Point(112, 108)
        Me.Transaction_Date.Name = "Transaction_Date"
        Me.Transaction_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Transaction_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Transaction_Date.Properties.DisplayFormat.FormatString = ""
        Me.Transaction_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Transaction_Date.Properties.EditFormat.FormatString = ""
        Me.Transaction_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Transaction_Date.Properties.Mask.EditMask = ""
        Me.Transaction_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Transaction_Date.Properties.ReadOnly = True
        Me.Transaction_Date.Size = New System.Drawing.Size(130, 20)
        Me.Transaction_Date.StyleController = Me.layoutControl
        Me.Transaction_Date.TabIndex = 8
        '
        'Description
        '
        Me.Description.Location = New System.Drawing.Point(112, 132)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(130, 46)
        Me.Description.StyleController = Me.layoutControl
        Me.Description.TabIndex = 10
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(112, 182)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(130, 182)
        Me.Notes.StyleController = Me.layoutControl
        Me.Notes.TabIndex = 11
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(254, 376)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.ID
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(234, 24)
        Me.LayoutControlItem1.Text = "ID"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Branch_From
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(234, 24)
        Me.LayoutControlItem2.Text = "Requested Branch"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Reference
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(234, 24)
        Me.LayoutControlItem3.Text = "Reference"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SRF_Number
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(234, 24)
        Me.LayoutControlItem4.Text = "SRF Number"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Transaction_Date
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(234, 24)
        Me.LayoutControlItem5.Text = "Transaction Date"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Description
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(0, 50)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(113, 50)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(234, 50)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Description"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Notes
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 170)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(234, 186)
        Me.LayoutControlItem8.Text = "Notes"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(88, 13)
        '
        'xuc_SPA_SRF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.layoutControl)
        Me.Name = "xuc_SPA_SRF"
        Me.Size = New System.Drawing.Size(254, 376)
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SRF_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Branch_From.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transaction_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transaction_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Reference As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SRF_Number As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Branch_From As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Transaction_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
End Class
