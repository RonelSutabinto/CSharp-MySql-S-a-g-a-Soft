Namespace Controls.Logistics
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Inclusion_Inventory
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
            Me.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Description = New DevExpress.XtraEditors.MemoEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Engine = New DevExpress.XtraEditors.LookUpEdit()
            Me.Inventory_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Inclusion_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Engine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Inventory_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Inclusion_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LayoutControl
            '
            Me.LayoutControl.Controls.Add(Me.ID)
            Me.LayoutControl.Controls.Add(Me.Description)
            Me.LayoutControl.Controls.Add(Me.Notes)
            Me.LayoutControl.Controls.Add(Me.Engine)
            Me.LayoutControl.Controls.Add(Me.Inventory_Code)
            Me.LayoutControl.Controls.Add(Me.Inclusion_Code)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl"
            Me.LayoutControl.Root = Me.Root
            Me.LayoutControl.Size = New System.Drawing.Size(227, 248)
            Me.LayoutControl.TabIndex = 0
            Me.LayoutControl.Text = "LayoutControl1"
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(84, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(131, 20)
            Me.ID.StyleController = Me.LayoutControl
            Me.ID.TabIndex = 0
            '
            'Description
            '
            Me.Description.Location = New System.Drawing.Point(84, 108)
            Me.Description.Name = "Description"
            Me.Description.Properties.ReadOnly = True
            Me.Description.Size = New System.Drawing.Size(131, 46)
            Me.Description.StyleController = Me.LayoutControl
            Me.Description.TabIndex = 6
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(84, 168)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(131, 68)
            Me.Notes.StyleController = Me.LayoutControl
            Me.Notes.TabIndex = 7
            '
            'Engine
            '
            Me.Engine.Location = New System.Drawing.Point(84, 84)
            Me.Engine.Name = "Engine"
            Me.Engine.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Engine.Properties.NullText = ""
            Me.Engine.Size = New System.Drawing.Size(131, 20)
            Me.Engine.StyleController = Me.LayoutControl
            Me.Engine.TabIndex = 5
            '
            'Inventory_Code
            '
            Me.Inventory_Code.Location = New System.Drawing.Point(84, 60)
            Me.Inventory_Code.Name = "Inventory_Code"
            Me.Inventory_Code.Size = New System.Drawing.Size(131, 20)
            Me.Inventory_Code.StyleController = Me.LayoutControl
            Me.Inventory_Code.TabIndex = 4
            '
            'Inclusion_Code
            '
            Me.Inclusion_Code.Location = New System.Drawing.Point(84, 36)
            Me.Inclusion_Code.Name = "Inclusion_Code"
            Me.Inclusion_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Inclusion_Code.Properties.NullText = ""
            Me.Inclusion_Code.Size = New System.Drawing.Size(131, 20)
            Me.Inclusion_Code.StyleController = Me.LayoutControl
            Me.Inclusion_Code.TabIndex = 1
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.SplitterItem1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(227, 248)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(207, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(60, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Description
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(207, 50)
            Me.LayoutControlItem4.Text = "Description"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(60, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Notes
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 156)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(207, 72)
            Me.LayoutControlItem5.Text = "Notes"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(60, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Inclusion_Code
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(207, 24)
            Me.LayoutControlItem6.Text = "Inclusion"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(60, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.Engine
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(207, 24)
            Me.LayoutControlItem7.Text = "Engine"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(60, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.Inventory_Code
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(207, 24)
            Me.LayoutControlItem8.Text = "Inv. Number"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(60, 13)
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(0, 146)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(207, 10)
            '
            'xuc_Inclusion_Inventory
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.LayoutControl)
            Me.Name = "xuc_Inclusion_Inventory"
            Me.Size = New System.Drawing.Size(227, 248)
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Engine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Inventory_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Inclusion_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Engine As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Inventory_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Inclusion_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace