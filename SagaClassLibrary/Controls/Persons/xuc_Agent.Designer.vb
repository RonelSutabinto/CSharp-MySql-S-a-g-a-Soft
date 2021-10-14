Namespace Controls.Persons
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Agent
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
            Me.Agent_Code = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Branch_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Agent_Type = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Agent_Address = New DevExpress.XtraEditors.MemoEdit()
            Me.Agent_Name = New DevExpress.XtraEditors.TextEdit()
            Me.IsActive = New DevExpress.XtraEditors.ToggleSwitch()
            Me.Agent_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.agent_Branchitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.agent_Typeitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.agent_Notesitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.agent_Addressitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.agent_Nameitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.agent_Codeitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.Agent_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Agent_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Agent_Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Agent_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IsActive.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Agent_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.agent_Branchitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.agent_Typeitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.agent_Notesitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.agent_Addressitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.agent_Nameitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.agent_Codeitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Agent_Code
            '
            Me.Agent_Code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Agent_Code.Location = New System.Drawing.Point(217, 12)
            Me.Agent_Code.Name = "Agent_Code"
            Me.Agent_Code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.Agent_Code.Size = New System.Drawing.Size(71, 20)
            Me.Agent_Code.StyleController = Me.layoutControl
            Me.Agent_Code.TabIndex = 1
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.ID)
            Me.layoutControl.Controls.Add(Me.Agent_Code)
            Me.layoutControl.Controls.Add(Me.Branch_Code)
            Me.layoutControl.Controls.Add(Me.Agent_Type)
            Me.layoutControl.Controls.Add(Me.Notes)
            Me.layoutControl.Controls.Add(Me.Agent_Address)
            Me.layoutControl.Controls.Add(Me.Agent_Name)
            Me.layoutControl.Controls.Add(Me.IsActive)
            Me.layoutControl.Controls.Add(Me.Agent_Description)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.LayoutControlGroup1
            Me.layoutControl.Size = New System.Drawing.Size(300, 300)
            Me.layoutControl.TabIndex = 0
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(77, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(71, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 0
            '
            'Branch_Code
            '
            Me.Branch_Code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Branch_Code.Location = New System.Drawing.Point(77, 36)
            Me.Branch_Code.Name = "Branch_Code"
            Me.Branch_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Branch_Code.Size = New System.Drawing.Size(211, 20)
            Me.Branch_Code.StyleController = Me.layoutControl
            Me.Branch_Code.TabIndex = 2
            '
            'Agent_Type
            '
            Me.Agent_Type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Agent_Type.Location = New System.Drawing.Point(77, 60)
            Me.Agent_Type.Name = "Agent_Type"
            Me.Agent_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Agent_Type.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.Agent_Type.Size = New System.Drawing.Size(211, 20)
            Me.Agent_Type.StyleController = Me.layoutControl
            Me.Agent_Type.TabIndex = 3
            '
            'Notes
            '
            Me.Notes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Notes.Location = New System.Drawing.Point(77, 230)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(211, 58)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 8
            '
            'Agent_Address
            '
            Me.Agent_Address.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Agent_Address.Location = New System.Drawing.Point(77, 108)
            Me.Agent_Address.Name = "Agent_Address"
            Me.Agent_Address.Size = New System.Drawing.Size(211, 46)
            Me.Agent_Address.StyleController = Me.layoutControl
            Me.Agent_Address.TabIndex = 5
            '
            'Agent_Name
            '
            Me.Agent_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Agent_Name.Location = New System.Drawing.Point(77, 84)
            Me.Agent_Name.Name = "Agent_Name"
            Me.Agent_Name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.Agent_Name.Size = New System.Drawing.Size(211, 20)
            Me.Agent_Name.StyleController = Me.layoutControl
            Me.Agent_Name.TabIndex = 4
            '
            'IsActive
            '
            Me.IsActive.Location = New System.Drawing.Point(77, 208)
            Me.IsActive.Name = "IsActive"
            Me.IsActive.Properties.OffText = "Deactivated"
            Me.IsActive.Properties.OnText = "Active"
            Me.IsActive.Size = New System.Drawing.Size(211, 18)
            Me.IsActive.StyleController = Me.layoutControl
            Me.IsActive.TabIndex = 7
            '
            'Agent_Description
            '
            Me.Agent_Description.Location = New System.Drawing.Point(77, 158)
            Me.Agent_Description.Name = "Agent_Description"
            Me.Agent_Description.Size = New System.Drawing.Size(211, 46)
            Me.Agent_Description.StyleController = Me.layoutControl
            Me.Agent_Description.TabIndex = 6
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.agent_Branchitem, Me.agent_Typeitem, Me.agent_Notesitem, Me.agent_Addressitem, Me.agent_Nameitem, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.agent_Codeitem})
            Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(300, 300)
            Me.LayoutControlGroup1.TextVisible = False
            '
            'agent_Branchitem
            '
            Me.agent_Branchitem.Control = Me.Branch_Code
            Me.agent_Branchitem.Location = New System.Drawing.Point(0, 24)
            Me.agent_Branchitem.Name = "agent_Branchitem"
            Me.agent_Branchitem.Size = New System.Drawing.Size(280, 24)
            Me.agent_Branchitem.Text = "Branch"
            Me.agent_Branchitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.agent_Branchitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'agent_Typeitem
            '
            Me.agent_Typeitem.Control = Me.Agent_Type
            Me.agent_Typeitem.Location = New System.Drawing.Point(0, 48)
            Me.agent_Typeitem.Name = "agent_Typeitem"
            Me.agent_Typeitem.Size = New System.Drawing.Size(280, 24)
            Me.agent_Typeitem.Text = "Type"
            Me.agent_Typeitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.agent_Typeitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'agent_Notesitem
            '
            Me.agent_Notesitem.Control = Me.Notes
            Me.agent_Notesitem.Location = New System.Drawing.Point(0, 218)
            Me.agent_Notesitem.Name = "agent_Notesitem"
            Me.agent_Notesitem.Size = New System.Drawing.Size(280, 62)
            Me.agent_Notesitem.Text = "Notes"
            Me.agent_Notesitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.agent_Notesitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'agent_Addressitem
            '
            Me.agent_Addressitem.Control = Me.Agent_Address
            Me.agent_Addressitem.Location = New System.Drawing.Point(0, 96)
            Me.agent_Addressitem.MaxSize = New System.Drawing.Size(0, 50)
            Me.agent_Addressitem.MinSize = New System.Drawing.Size(56, 50)
            Me.agent_Addressitem.Name = "agent_Addressitem"
            Me.agent_Addressitem.Size = New System.Drawing.Size(280, 50)
            Me.agent_Addressitem.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.agent_Addressitem.Text = "Address"
            Me.agent_Addressitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.agent_Addressitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'agent_Nameitem
            '
            Me.agent_Nameitem.Control = Me.Agent_Name
            Me.agent_Nameitem.Location = New System.Drawing.Point(0, 72)
            Me.agent_Nameitem.Name = "agent_Nameitem"
            Me.agent_Nameitem.Size = New System.Drawing.Size(280, 24)
            Me.agent_Nameitem.Text = "Name"
            Me.agent_Nameitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.agent_Nameitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(140, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(53, 13)
            '
            'agent_Codeitem
            '
            Me.agent_Codeitem.Control = Me.Agent_Code
            Me.agent_Codeitem.Location = New System.Drawing.Point(140, 0)
            Me.agent_Codeitem.Name = "agent_Codeitem"
            Me.agent_Codeitem.Size = New System.Drawing.Size(140, 24)
            Me.agent_Codeitem.Text = "Code"
            Me.agent_Codeitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.agent_Codeitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.IsActive
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 196)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(280, 22)
            Me.LayoutControlItem2.Text = "Active"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Agent_Description
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 146)
            Me.LayoutControlItem3.MaxSize = New System.Drawing.Size(0, 50)
            Me.LayoutControlItem3.MinSize = New System.Drawing.Size(70, 50)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(280, 50)
            Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem3.Text = "Description"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(53, 13)
            '
            'xuc_Agent
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_Agent"
            Me.Size = New System.Drawing.Size(300, 300)
            CType(Me.Agent_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Agent_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Agent_Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Agent_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IsActive.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Agent_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.agent_Branchitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.agent_Typeitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.agent_Notesitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.agent_Addressitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.agent_Nameitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.agent_Codeitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend Agent_Code As DevExpress.XtraEditors.TextEdit
        Friend Branch_Code As DevExpress.XtraEditors.LookUpEdit
        Friend Agent_Type As DevExpress.XtraEditors.ComboBoxEdit
        Friend Notes As DevExpress.XtraEditors.MemoEdit
        Friend Agent_Address As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Agent_Name As DevExpress.XtraEditors.TextEdit
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents agent_Codeitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents agent_Branchitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents agent_Typeitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents agent_Notesitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents agent_Addressitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents agent_Nameitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IsActive As DevExpress.XtraEditors.ToggleSwitch
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Agent_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
