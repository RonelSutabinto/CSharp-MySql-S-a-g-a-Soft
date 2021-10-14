Namespace Controls.Logistics
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_MC_Request
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
            Me.Request_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Supplier_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Request_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Branch_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.WHCode = New DevExpress.XtraEditors.LookUpEdit()
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Request_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Supplier_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Request_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.WHCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LayoutControl
            '
            Me.LayoutControl.Controls.Add(Me.ID)
            Me.LayoutControl.Controls.Add(Me.Request_Code)
            Me.LayoutControl.Controls.Add(Me.Supplier_Code)
            Me.LayoutControl.Controls.Add(Me.Request_Description)
            Me.LayoutControl.Controls.Add(Me.Notes)
            Me.LayoutControl.Controls.Add(Me.Branch_Code)
            Me.LayoutControl.Controls.Add(Me.WHCode)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl"
            Me.LayoutControl.Root = Me.Root
            Me.LayoutControl.Size = New System.Drawing.Size(200, 250)
            Me.LayoutControl.TabIndex = 0
            Me.LayoutControl.Text = "LayoutControl"
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(79, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(109, 20)
            Me.ID.StyleController = Me.LayoutControl
            Me.ID.TabIndex = 0
            '
            'Request_Code
            '
            Me.Request_Code.Location = New System.Drawing.Point(79, 36)
            Me.Request_Code.Name = "Request_Code"
            Me.Request_Code.Size = New System.Drawing.Size(109, 20)
            Me.Request_Code.StyleController = Me.LayoutControl
            Me.Request_Code.TabIndex = 1
            '
            'Supplier_Code
            '
            Me.Supplier_Code.Location = New System.Drawing.Point(79, 84)
            Me.Supplier_Code.Name = "Supplier_Code"
            Me.Supplier_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Supplier_Code.Properties.NullText = ""
            Me.Supplier_Code.Properties.PopupSizeable = False
            Me.Supplier_Code.Size = New System.Drawing.Size(109, 20)
            Me.Supplier_Code.StyleController = Me.LayoutControl
            Me.Supplier_Code.TabIndex = 3
            '
            'Request_Description
            '
            Me.Request_Description.Location = New System.Drawing.Point(79, 132)
            Me.Request_Description.Name = "Request_Description"
            Me.Request_Description.Size = New System.Drawing.Size(109, 42)
            Me.Request_Description.StyleController = Me.LayoutControl
            Me.Request_Description.TabIndex = 5
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(79, 188)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(109, 50)
            Me.Notes.StyleController = Me.LayoutControl
            Me.Notes.TabIndex = 6
            '
            'Branch_Code
            '
            Me.Branch_Code.Location = New System.Drawing.Point(79, 60)
            Me.Branch_Code.Name = "Branch_Code"
            Me.Branch_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Branch_Code.Properties.NullText = ""
            Me.Branch_Code.Properties.PopupSizeable = False
            Me.Branch_Code.Size = New System.Drawing.Size(109, 20)
            Me.Branch_Code.StyleController = Me.LayoutControl
            Me.Branch_Code.TabIndex = 2
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.SplitterItem1, Me.LayoutControlItem6, Me.LayoutControlItem7})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(200, 250)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(180, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(55, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Request_Code
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(180, 24)
            Me.LayoutControlItem2.Text = "Code"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(55, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Supplier_Code
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(180, 24)
            Me.LayoutControlItem3.Text = "Supplier"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(55, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Request_Description
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 120)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(180, 46)
            Me.LayoutControlItem4.Text = "Description"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(55, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Notes
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 176)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(180, 54)
            Me.LayoutControlItem5.Text = "Notes"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(55, 13)
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(0, 166)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(180, 10)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Branch_Code
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(180, 24)
            Me.LayoutControlItem6.Text = "Branch"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(55, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.WHCode
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(180, 24)
            Me.LayoutControlItem7.Text = "Warehouse"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(55, 13)
            '
            'WHCode
            '
            Me.WHCode.Location = New System.Drawing.Point(79, 108)
            Me.WHCode.Name = "WHCode"
            Me.WHCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.WHCode.Properties.NullText = ""
            Me.WHCode.Properties.PopupSizeable = False
            Me.WHCode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.WHCode.Size = New System.Drawing.Size(109, 20)
            Me.WHCode.StyleController = Me.LayoutControl
            Me.WHCode.TabIndex = 4
            '
            'xuc_MC_Request
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.LayoutControl)
            Me.Name = "xuc_MC_Request"
            Me.Size = New System.Drawing.Size(200, 250)
            CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Request_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Supplier_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Request_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.WHCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Request_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Supplier_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Request_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
        Friend WithEvents Branch_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents WHCode As DevExpress.XtraEditors.LookUpEdit
    End Class
End Namespace