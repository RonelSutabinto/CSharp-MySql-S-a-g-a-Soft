Namespace Controls.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Budget
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
            Me.Budget_Amount = New DevExpress.XtraEditors.CalcEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Budget_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.Budget_Name = New DevExpress.XtraEditors.TextEdit()
            Me.Budget_Code = New DevExpress.XtraEditors.TextEdit()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Budget_Balance = New DevExpress.XtraEditors.CalcEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.Budget_Amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Budget_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Budget_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Budget_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Budget_Balance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.Budget_Amount)
            Me.layoutControl.Controls.Add(Me.Notes)
            Me.layoutControl.Controls.Add(Me.Budget_Description)
            Me.layoutControl.Controls.Add(Me.Budget_Name)
            Me.layoutControl.Controls.Add(Me.Budget_Code)
            Me.layoutControl.Controls.Add(Me.ID)
            Me.layoutControl.Controls.Add(Me.Budget_Balance)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(263, 284)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'Budget_Amount
            '
            Me.Budget_Amount.Location = New System.Drawing.Point(77, 60)
            Me.Budget_Amount.Name = "Budget_Amount"
            Me.Budget_Amount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Budget_Amount.Size = New System.Drawing.Size(174, 20)
            Me.Budget_Amount.StyleController = Me.layoutControl
            Me.Budget_Amount.TabIndex = 3
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(77, 192)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(174, 80)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 6
            '
            'Budget_Description
            '
            Me.Budget_Description.Location = New System.Drawing.Point(77, 108)
            Me.Budget_Description.Name = "Budget_Description"
            Me.Budget_Description.Size = New System.Drawing.Size(174, 70)
            Me.Budget_Description.StyleController = Me.layoutControl
            Me.Budget_Description.TabIndex = 5
            '
            'Budget_Name
            '
            Me.Budget_Name.Location = New System.Drawing.Point(77, 36)
            Me.Budget_Name.Name = "Budget_Name"
            Me.Budget_Name.Size = New System.Drawing.Size(174, 20)
            Me.Budget_Name.StyleController = Me.layoutControl
            Me.Budget_Name.TabIndex = 2
            '
            'Budget_Code
            '
            Me.Budget_Code.Location = New System.Drawing.Point(198, 12)
            Me.Budget_Code.Name = "Budget_Code"
            Me.Budget_Code.Size = New System.Drawing.Size(53, 20)
            Me.Budget_Code.StyleController = Me.layoutControl
            Me.Budget_Code.TabIndex = 1
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(77, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(52, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 0
            '
            'Budget_Balance
            '
            Me.Budget_Balance.Location = New System.Drawing.Point(77, 84)
            Me.Budget_Balance.Name = "Budget_Balance"
            Me.Budget_Balance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Budget_Balance.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.Budget_Balance.Properties.ReadOnly = True
            Me.Budget_Balance.Size = New System.Drawing.Size(174, 20)
            Me.Budget_Balance.StyleController = Me.layoutControl
            Me.Budget_Balance.TabIndex = 4
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.SplitterItem1, Me.LayoutControlItem2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(263, 284)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(121, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Budget_Code
            Me.LayoutControlItem2.Location = New System.Drawing.Point(121, 0)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(122, 24)
            Me.LayoutControlItem2.Text = "Code"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Budget_Name
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(243, 24)
            Me.LayoutControlItem3.Text = "Name"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Budget_Description
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(243, 74)
            Me.LayoutControlItem4.Text = "Description"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Notes
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 180)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(243, 84)
            Me.LayoutControlItem5.Text = "Notes"
            Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Budget_Amount
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(243, 24)
            Me.LayoutControlItem6.Text = "Amount"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(53, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.Budget_Balance
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(243, 24)
            Me.LayoutControlItem7.Text = "Balance"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(53, 13)
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(0, 170)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(243, 10)
            '
            'xuc_Budget
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_Budget"
            Me.Size = New System.Drawing.Size(263, 284)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.Budget_Amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Budget_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Budget_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Budget_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Budget_Balance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Budget_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Budget_Name As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Budget_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Budget_Amount As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Budget_Balance As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace