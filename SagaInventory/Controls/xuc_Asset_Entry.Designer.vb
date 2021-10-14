<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xuc_Asset_Entry
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Verified_by = New DevExpress.XtraEditors.TextEdit()
        Me.Inventory_No = New DevExpress.XtraEditors.TextEdit()
        Me.Descriptions = New DevExpress.XtraEditors.MemoEdit()
        Me.Employee_Name = New DevExpress.XtraEditors.LookUpEdit()
        Me.Date_Received = New DevExpress.XtraEditors.DateEdit()
        Me.Status = New DevExpress.XtraEditors.ToggleSwitch()
        Me.Date_Turnover = New DevExpress.XtraEditors.DateEdit()
        Me.Notes = New DevExpress.XtraEditors.MemoEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.ID = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.Verified_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventory_No.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Descriptions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_Received.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_Received.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_Turnover.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Date_Turnover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl.Controls.Add(Me.LabelControl1)
        Me.LayoutControl.Controls.Add(Me.Verified_by)
        Me.LayoutControl.Controls.Add(Me.Inventory_No)
        Me.LayoutControl.Controls.Add(Me.Descriptions)
        Me.LayoutControl.Controls.Add(Me.Employee_Name)
        Me.LayoutControl.Controls.Add(Me.Date_Received)
        Me.LayoutControl.Controls.Add(Me.Status)
        Me.LayoutControl.Controls.Add(Me.Date_Turnover)
        Me.LayoutControl.Controls.Add(Me.Notes)
        Me.LayoutControl.Controls.Add(Me.ID)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl1"
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(270, 301)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 156)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.StyleController = Me.layoutControl
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Status"
        '
        'Verified_by
        '
        Me.Verified_by.Location = New System.Drawing.Point(96, 203)
        Me.Verified_by.Name = "Verified_by"
        Me.Verified_by.Size = New System.Drawing.Size(162, 20)
        Me.Verified_by.StyleController = Me.layoutControl
        Me.Verified_by.TabIndex = 8
        '
        'Inventory_No
        '
        Me.Inventory_No.Location = New System.Drawing.Point(96, 84)
        Me.Inventory_No.Name = "Inventory_No"
        Me.Inventory_No.Size = New System.Drawing.Size(162, 20)
        Me.Inventory_No.StyleController = Me.layoutControl
        Me.Inventory_No.TabIndex = 3
        '
        'Descriptions
        '
        Me.Descriptions.Location = New System.Drawing.Point(96, 108)
        Me.Descriptions.Name = "Descriptions"
        Me.Descriptions.Size = New System.Drawing.Size(162, 44)
        Me.Descriptions.StyleController = Me.layoutControl
        Me.Descriptions.TabIndex = 4
        '
        'Employee_Name
        '
        Me.Employee_Name.Location = New System.Drawing.Point(96, 36)
        Me.Employee_Name.Name = "Employee_Name"
        Me.Employee_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Employee_Name.Properties.NullText = ""
        Me.Employee_Name.Size = New System.Drawing.Size(162, 20)
        Me.Employee_Name.StyleController = Me.layoutControl
        Me.Employee_Name.TabIndex = 1
        '
        'Date_Received
        '
        Me.Date_Received.EditValue = Nothing
        Me.Date_Received.Location = New System.Drawing.Point(96, 60)
        Me.Date_Received.Name = "Date_Received"
        Me.Date_Received.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_Received.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_Received.Properties.DisplayFormat.FormatString = ""
        Me.Date_Received.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_Received.Properties.EditFormat.FormatString = ""
        Me.Date_Received.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_Received.Properties.Mask.EditMask = ""
        Me.Date_Received.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Date_Received.Size = New System.Drawing.Size(162, 20)
        Me.Date_Received.StyleController = Me.layoutControl
        Me.Date_Received.TabIndex = 2
        '
        'Status
        '
        Me.Status.EditValue = Nothing
        Me.Status.Location = New System.Drawing.Point(83, 156)
        Me.Status.Name = "Status"
        Me.Status.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.Status.Properties.OffText = "Not Functional"
        Me.Status.Properties.OnText = "Functional"
        Me.Status.Size = New System.Drawing.Size(175, 19)
        Me.Status.StyleController = Me.layoutControl
        Me.Status.TabIndex = 6
        '
        'Date_Turnover
        '
        Me.Date_Turnover.EditValue = Nothing
        Me.Date_Turnover.Location = New System.Drawing.Point(96, 179)
        Me.Date_Turnover.Name = "Date_Turnover"
        Me.Date_Turnover.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_Turnover.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Date_Turnover.Properties.DisplayFormat.FormatString = ""
        Me.Date_Turnover.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_Turnover.Properties.EditFormat.FormatString = ""
        Me.Date_Turnover.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Date_Turnover.Properties.Mask.EditMask = ""
        Me.Date_Turnover.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.Date_Turnover.Size = New System.Drawing.Size(162, 20)
        Me.Date_Turnover.StyleController = Me.layoutControl
        Me.Date_Turnover.TabIndex = 7
        '
        'Notes
        '
        Me.Notes.Location = New System.Drawing.Point(96, 227)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(162, 62)
        Me.Notes.StyleController = Me.layoutControl
        Me.Notes.TabIndex = 9
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.EmptySpaceItem1, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(270, 301)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Employee_Name
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(250, 24)
        Me.LayoutControlItem1.Text = "Employee Name"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Date_Received
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(250, 24)
        Me.LayoutControlItem4.Text = "Date Received"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Inventory_No
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(250, 24)
        Me.LayoutControlItem5.Text = "Inventory No."
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseForeColor = True
        Me.LayoutControlItem6.Control = Me.Descriptions
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(0, 48)
        Me.LayoutControlItem6.MinSize = New System.Drawing.Size(119, 48)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(250, 48)
        Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem6.Text = "Descriptions"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.Status
        Me.LayoutControlItem7.Location = New System.Drawing.Point(71, 144)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(179, 23)
        Me.LayoutControlItem7.Text = "Inventory Status"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Date_Turnover
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 167)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(250, 24)
        Me.LayoutControlItem8.Text = "Date Turnover"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.Verified_by
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 191)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(250, 24)
        Me.LayoutControlItem9.Text = "verified by"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.Notes
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 215)
        Me.LayoutControlItem10.MinSize = New System.Drawing.Size(100, 20)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(250, 66)
        Me.LayoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem10.Text = "Notes"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(81, 13)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.LabelControl1
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(36, 23)
        Me.LayoutControlItem11.Text = "Status"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(36, 144)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(35, 23)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(96, 12)
        Me.ID.Name = "ID"
        
        Me.ID.Size = New System.Drawing.Size(162, 20)
        Me.ID.StyleController = Me.layoutControl
        Me.ID.TabIndex = 0
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.ID
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(250, 24)
        Me.LayoutControlItem2.Text = "ID"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
        '
        'xuc_Entries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.layoutControl)
        Me.Name = "xuc_Entries"
        Me.Size = New System.Drawing.Size(270, 301)
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.Verified_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventory_No.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Descriptions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_Received.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_Received.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_Turnover.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Date_Turnover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Verified_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Inventory_No As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Descriptions As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Employee_Name As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Date_Received As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Status As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents Date_Turnover As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
