Namespace Controls.Logistics
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Inclusion
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
            Me.Inclusion_Type = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Inclusion_Name = New DevExpress.XtraEditors.TextEdit()
            Me.Description = New DevExpress.XtraEditors.MemoEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Inclusion_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Inclusion_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Inclusion_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Inclusion_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LayoutControl
            '
            Me.LayoutControl.Controls.Add(Me.ID)
            Me.LayoutControl.Controls.Add(Me.Inclusion_Type)
            Me.LayoutControl.Controls.Add(Me.Inclusion_Name)
            Me.LayoutControl.Controls.Add(Me.Description)
            Me.LayoutControl.Controls.Add(Me.Notes)
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
            Me.ID.Location = New System.Drawing.Point(77, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(138, 20)
            Me.ID.StyleController = Me.LayoutControl
            Me.ID.TabIndex = 0
            '
            'Inclusion_Type
            '
            Me.Inclusion_Type.Location = New System.Drawing.Point(77, 60)
            Me.Inclusion_Type.Name = "Inclusion_Type"
            Me.Inclusion_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Inclusion_Type.Size = New System.Drawing.Size(138, 20)
            Me.Inclusion_Type.StyleController = Me.LayoutControl
            Me.Inclusion_Type.TabIndex = 2
            '
            'Inclusion_Name
            '
            Me.Inclusion_Name.Location = New System.Drawing.Point(77, 84)
            Me.Inclusion_Name.Name = "Inclusion_Name"
            Me.Inclusion_Name.Size = New System.Drawing.Size(138, 20)
            Me.Inclusion_Name.StyleController = Me.LayoutControl
            Me.Inclusion_Name.TabIndex = 3
            '
            'Description
            '
            Me.Description.Location = New System.Drawing.Point(77, 108)
            Me.Description.Name = "Description"
            Me.Description.Size = New System.Drawing.Size(138, 46)
            Me.Description.StyleController = Me.LayoutControl
            Me.Description.TabIndex = 4
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(77, 168)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(138, 68)
            Me.Notes.StyleController = Me.LayoutControl
            Me.Notes.TabIndex = 5
            '
            'Inclusion_Code
            '
            Me.Inclusion_Code.Location = New System.Drawing.Point(77, 36)
            Me.Inclusion_Code.Name = "Inclusion_Code"
            Me.Inclusion_Code.Properties.ReadOnly = True
            Me.Inclusion_Code.Size = New System.Drawing.Size(138, 20)
            Me.Inclusion_Code.StyleController = Me.LayoutControl
            Me.Inclusion_Code.TabIndex = 1
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.SplitterItem1})
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
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Inclusion_Type
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(207, 24)
            Me.LayoutControlItem2.Text = "Type"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Inclusion_Name
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(207, 24)
            Me.LayoutControlItem3.Text = "Name"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Description
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(207, 50)
            Me.LayoutControlItem4.Text = "Description"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Notes
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 156)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(207, 72)
            Me.LayoutControlItem5.Text = "Notes"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Inclusion_Code
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(207, 24)
            Me.LayoutControlItem6.Text = "Code"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(53, 13)
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(0, 146)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(207, 10)
            '
            'xuc_Inclusion
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.LayoutControl)
            Me.Name = "xuc_Inclusion"
            Me.Size = New System.Drawing.Size(227, 248)
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Inclusion_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Inclusion_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Inclusion_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Inclusion_Type As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents Inclusion_Name As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Inclusion_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace