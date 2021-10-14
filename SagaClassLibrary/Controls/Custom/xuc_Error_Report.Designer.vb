Namespace Controls.Custom
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Error_Report
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
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Branch_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Error_Type = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Transaction_Reference = New DevExpress.XtraEditors.TextEdit()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Error_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Error_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Transaction_Reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Error_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LayoutControl1
            '
            Me.LayoutControl.Controls.Add(Me.ID)
            Me.LayoutControl.Controls.Add(Me.Branch_Code)
            Me.LayoutControl.Controls.Add(Me.Error_Type)
            Me.LayoutControl.Controls.Add(Me.Transaction_Reference)
            Me.LayoutControl.Controls.Add(Me.Error_Description)
            Me.LayoutControl.Controls.Add(Me.Notes)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl1"
            Me.LayoutControl.Root = Me.Root
            Me.LayoutControl.Size = New System.Drawing.Size(250, 300)
            Me.LayoutControl.TabIndex = 0
            Me.LayoutControl.Text = "LayoutControl1"
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(250, 300)
            Me.Root.TextVisible = False
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(83, 12)
            Me.ID.Name = "ID"
            
            Me.ID.Size = New System.Drawing.Size(155, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 4
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(59, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Branch_Code
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem2.Text = "Branch"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(59, 13)
            '
            'Branch_Code
            '
            Me.Branch_Code.Location = New System.Drawing.Point(83, 36)
            Me.Branch_Code.Name = "Branch_Code"
            Me.Branch_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Branch_Code.Properties.NullText = ""
            Me.Branch_Code.Properties.PopupSizeable = False
            Me.Branch_Code.Properties.ReadOnly = True
            Me.Branch_Code.Size = New System.Drawing.Size(155, 20)
            Me.Branch_Code.StyleController = Me.layoutControl
            Me.Branch_Code.TabIndex = 5
            '
            'Error_Type
            '
            Me.Error_Type.Location = New System.Drawing.Point(83, 60)
            Me.Error_Type.Name = "Error_Type"
            Me.Error_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Error_Type.Size = New System.Drawing.Size(155, 20)
            Me.Error_Type.StyleController = Me.layoutControl
            Me.Error_Type.TabIndex = 6
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Error_Type
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem3.Text = "Type"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(59, 13)
            '
            'Transaction_Reference
            '
            Me.Transaction_Reference.Location = New System.Drawing.Point(83, 84)
            Me.Transaction_Reference.Name = "Transaction_Reference"
            Me.Transaction_Reference.Properties.ReadOnly = True
            Me.Transaction_Reference.Size = New System.Drawing.Size(155, 20)
            Me.Transaction_Reference.StyleController = Me.layoutControl
            Me.Transaction_Reference.TabIndex = 7
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Transaction_Reference
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem4.Text = "Reference"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(59, 13)
            '
            'Error_Description
            '
            Me.Error_Description.Location = New System.Drawing.Point(83, 108)
            Me.Error_Description.Name = "Error_Description"
            Me.Error_Description.Size = New System.Drawing.Size(155, 96)
            Me.Error_Description.StyleController = Me.layoutControl
            Me.Error_Description.TabIndex = 8
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Error_Description
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem5.MaxSize = New System.Drawing.Size(0, 100)
            Me.LayoutControlItem5.MinSize = New System.Drawing.Size(85, 100)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(230, 100)
            Me.LayoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem5.Text = "Description"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(59, 13)
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(83, 208)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(155, 80)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 9
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Notes
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 196)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(230, 84)
            Me.LayoutControlItem6.Text = "Notes"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(59, 13)
            '
            'xuc_Error_Report
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_Error_Report"
            Me.Size = New System.Drawing.Size(250, 300)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Error_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Transaction_Reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Error_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Branch_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Error_Type As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents Transaction_Reference As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Error_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace