Namespace Controls.Information.Item
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Color
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
            Me.Color_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Color_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Color = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.id = New DevExpress.XtraEditors.TextEdit()
            Me.ColorDesc = New DevExpress.XtraEditors.TextEdit()
            Me.Color_Index = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.PNP_LTO_Input = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem_Description = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.Color_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Color_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Color.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ColorDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Color_Index.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PNP_LTO_Input.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem_Description, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LayoutControl
            '
            Me.LayoutControl.Controls.Add(Me.Color_Description)
            Me.LayoutControl.Controls.Add(Me.Notes)
            Me.LayoutControl.Controls.Add(Me.Color_Code)
            Me.LayoutControl.Controls.Add(Me.Color)
            Me.LayoutControl.Controls.Add(Me.id)
            Me.LayoutControl.Controls.Add(Me.ColorDesc)
            Me.LayoutControl.Controls.Add(Me.Color_Index)
            Me.LayoutControl.Controls.Add(Me.PNP_LTO_Input)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl"
            Me.LayoutControl.Root = Me.Root
            Me.LayoutControl.Size = New System.Drawing.Size(250, 283)
            Me.LayoutControl.TabIndex = 0
            Me.LayoutControl.Text = "LayoutControl1"
            '
            'Color_Description
            '
            Me.Color_Description.Location = New System.Drawing.Point(77, 156)
            Me.Color_Description.Name = "Color_Description"
            Me.Color_Description.Size = New System.Drawing.Size(161, 46)
            Me.Color_Description.StyleController = Me.LayoutControl
            Me.Color_Description.TabIndex = 6
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(77, 216)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(161, 55)
            Me.Notes.StyleController = Me.LayoutControl
            Me.Notes.TabIndex = 7
            '
            'Color_Code
            '
            Me.Color_Code.Location = New System.Drawing.Point(77, 36)
            Me.Color_Code.Name = "Color_Code"
            Me.Color_Code.Properties.ReadOnly = True
            Me.Color_Code.Size = New System.Drawing.Size(161, 20)
            Me.Color_Code.StyleController = Me.LayoutControl
            Me.Color_Code.TabIndex = 1
            '
            'Color
            '
            Me.Color.Location = New System.Drawing.Point(77, 84)
            Me.Color.Name = "Color"
            Me.Color.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Color.Size = New System.Drawing.Size(161, 20)
            Me.Color.StyleController = Me.LayoutControl
            Me.Color.TabIndex = 3
            '
            'id
            '
            Me.id.Location = New System.Drawing.Point(77, 12)
            Me.id.Name = "id"
            Me.id.Size = New System.Drawing.Size(161, 20)
            Me.id.StyleController = Me.LayoutControl
            Me.id.TabIndex = 0
            '
            'ColorDesc
            '
            Me.ColorDesc.Location = New System.Drawing.Point(77, 108)
            Me.ColorDesc.Name = "ColorDesc"
            Me.ColorDesc.Size = New System.Drawing.Size(161, 20)
            Me.ColorDesc.StyleController = Me.LayoutControl
            Me.ColorDesc.TabIndex = 4
            '
            'Color_Index
            '
            Me.Color_Index.Location = New System.Drawing.Point(77, 60)
            Me.Color_Index.Name = "Color_Index"
            Me.Color_Index.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Color_Index.Size = New System.Drawing.Size(161, 20)
            Me.Color_Index.StyleController = Me.LayoutControl
            Me.Color_Index.TabIndex = 2
            '
            'PNP_LTO_Input
            '
            Me.PNP_LTO_Input.Location = New System.Drawing.Point(77, 132)
            Me.PNP_LTO_Input.Name = "PNP_LTO_Input"
            Me.PNP_LTO_Input.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.PNP_LTO_Input.Size = New System.Drawing.Size(161, 20)
            Me.PNP_LTO_Input.StyleController = Me.LayoutControl
            Me.PNP_LTO_Input.TabIndex = 5
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem8, Me.LayoutControlItem_Description, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.SplitterItem1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(250, 283)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.id
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Color
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem2.Text = "Dominant"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.ColorDesc
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem5.Text = "Color"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Color_Code
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem6.Text = "Code"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.Notes
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 204)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(230, 59)
            Me.LayoutControlItem8.Text = "Notes"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem_Description
            '
            Me.LayoutControlItem_Description.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.HotTrack
            Me.LayoutControlItem_Description.AppearanceItemCaption.Options.UseForeColor = True
            Me.LayoutControlItem_Description.Control = Me.Color_Description
            Me.LayoutControlItem_Description.Location = New System.Drawing.Point(0, 144)
            Me.LayoutControlItem_Description.Name = "LayoutControlItem_Description"
            Me.LayoutControlItem_Description.Size = New System.Drawing.Size(230, 50)
            Me.LayoutControlItem_Description.Text = "Description"
            Me.LayoutControlItem_Description.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Color_Index
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem3.Text = "Index"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.PNP_LTO_Input
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 120)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(230, 24)
            Me.LayoutControlItem4.Text = "LTO Input"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(53, 13)
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(0, 194)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(230, 10)
            '
            'xuc_Color
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.LayoutControl)
            Me.Name = "xuc_Color"
            Me.Size = New System.Drawing.Size(250, 283)
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.Color_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Color_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Color.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ColorDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Color_Index.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PNP_LTO_Input.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem_Description, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents Color As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents id As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Color_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Color_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem_Description As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ColorDesc As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Color_Index As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents PNP_LTO_Input As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace