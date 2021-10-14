Namespace Controls.Persons
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Account_Executive
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
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.AE_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Branch_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.AE_Name = New DevExpress.XtraEditors.LookUpEdit()
            Me.Chassis = New DevExpress.XtraEditors.TextEdit()
            Me.Plate_Number = New DevExpress.XtraEditors.TextEdit()
            Me.Engine = New DevExpress.XtraEditors.LookUpEdit()
            Me.CTC_Number = New DevExpress.XtraEditors.TextEdit()
            Me.CTC_Place = New DevExpress.XtraEditors.TextEdit()
            Me.CTC_Date = New DevExpress.XtraEditors.DateEdit()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ae_Nameitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ae_Branchitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ae_Notesitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ae_Codeitem = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AE_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AE_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Chassis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Plate_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Engine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CTC_Number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CTC_Place.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CTC_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CTC_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ae_Nameitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ae_Branchitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ae_Notesitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ae_Codeitem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.ID)
            Me.layoutControl.Controls.Add(Me.AE_Code)
            Me.layoutControl.Controls.Add(Me.Branch_Code)
            Me.layoutControl.Controls.Add(Me.Notes)
            Me.layoutControl.Controls.Add(Me.AE_Name)
            Me.layoutControl.Controls.Add(Me.Chassis)
            Me.layoutControl.Controls.Add(Me.Plate_Number)
            Me.layoutControl.Controls.Add(Me.Engine)
            Me.layoutControl.Controls.Add(Me.CTC_Number)
            Me.layoutControl.Controls.Add(Me.CTC_Place)
            Me.layoutControl.Controls.Add(Me.CTC_Date)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.LayoutControlGroup1
            Me.layoutControl.Size = New System.Drawing.Size(300, 350)
            Me.layoutControl.TabIndex = 0
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(72, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(76, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 0
            '
            'AE_Code
            '
            Me.AE_Code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.AE_Code.Location = New System.Drawing.Point(212, 12)
            Me.AE_Code.Name = "AE_Code"
            Me.AE_Code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.AE_Code.Size = New System.Drawing.Size(76, 20)
            Me.AE_Code.StyleController = Me.layoutControl
            Me.AE_Code.TabIndex = 1
            '
            'Branch_Code
            '
            Me.Branch_Code.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Branch_Code.Location = New System.Drawing.Point(72, 36)
            Me.Branch_Code.Name = "Branch_Code"
            Me.Branch_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Branch_Code.Size = New System.Drawing.Size(216, 20)
            Me.Branch_Code.StyleController = Me.layoutControl
            Me.Branch_Code.TabIndex = 2
            '
            'Notes
            '
            Me.Notes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Notes.Location = New System.Drawing.Point(72, 228)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(216, 110)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 10
            '
            'AE_Name
            '
            Me.AE_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.AE_Name.Location = New System.Drawing.Point(72, 60)
            Me.AE_Name.Name = "AE_Name"
            Me.AE_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.AE_Name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.AE_Name.Properties.NullText = ""
            Me.AE_Name.Size = New System.Drawing.Size(216, 20)
            Me.AE_Name.StyleController = Me.layoutControl
            Me.AE_Name.TabIndex = 3
            '
            'Chassis
            '
            Me.Chassis.Location = New System.Drawing.Point(72, 108)
            Me.Chassis.Name = "Chassis"
            Me.Chassis.Size = New System.Drawing.Size(216, 20)
            Me.Chassis.StyleController = Me.layoutControl
            Me.Chassis.TabIndex = 5
            '
            'Plate_Number
            '
            Me.Plate_Number.Location = New System.Drawing.Point(72, 132)
            Me.Plate_Number.Name = "Plate_Number"
            Me.Plate_Number.Size = New System.Drawing.Size(216, 20)
            Me.Plate_Number.StyleController = Me.layoutControl
            Me.Plate_Number.TabIndex = 6
            '
            'Engine
            '
            Me.Engine.Location = New System.Drawing.Point(72, 84)
            Me.Engine.Name = "Engine"
            Me.Engine.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Engine.Properties.DisplayMember = "EngineNo"
            Me.Engine.Properties.NullText = ""
            Me.Engine.Properties.ValueMember = "EngineNo"
            Me.Engine.Size = New System.Drawing.Size(216, 20)
            Me.Engine.StyleController = Me.layoutControl
            Me.Engine.TabIndex = 4
            '
            'CTC_Number
            '
            Me.CTC_Number.Location = New System.Drawing.Point(72, 156)
            Me.CTC_Number.Name = "CTC_Number"
            Me.CTC_Number.Size = New System.Drawing.Size(216, 20)
            Me.CTC_Number.StyleController = Me.layoutControl
            Me.CTC_Number.TabIndex = 7
            '
            'CTC_Place
            '
            Me.CTC_Place.Location = New System.Drawing.Point(72, 204)
            Me.CTC_Place.Name = "CTC_Place"
            Me.CTC_Place.Size = New System.Drawing.Size(216, 20)
            Me.CTC_Place.StyleController = Me.layoutControl
            Me.CTC_Place.TabIndex = 9
            '
            'CTC_Date
            '
            Me.CTC_Date.EditValue = Nothing
            Me.CTC_Date.Location = New System.Drawing.Point(72, 180)
            Me.CTC_Date.Name = "CTC_Date"
            Me.CTC_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.CTC_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.CTC_Date.Properties.DisplayFormat.FormatString = ""
            Me.CTC_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.CTC_Date.Properties.EditFormat.FormatString = ""
            Me.CTC_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.CTC_Date.Properties.Mask.EditMask = ""
            Me.CTC_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.CTC_Date.Size = New System.Drawing.Size(216, 20)
            Me.CTC_Date.StyleController = Me.layoutControl
            Me.CTC_Date.TabIndex = 8
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ae_Nameitem, Me.ae_Branchitem, Me.ae_Notesitem, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.ae_Codeitem})
            Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(300, 350)
            Me.LayoutControlGroup1.TextVisible = False
            '
            'ae_Nameitem
            '
            Me.ae_Nameitem.Control = Me.AE_Name
            Me.ae_Nameitem.Location = New System.Drawing.Point(0, 48)
            Me.ae_Nameitem.Name = "ae_Nameitem"
            Me.ae_Nameitem.Size = New System.Drawing.Size(280, 24)
            Me.ae_Nameitem.Text = "Name"
            Me.ae_Nameitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.ae_Nameitem.TextSize = New System.Drawing.Size(48, 13)
            '
            'ae_Branchitem
            '
            Me.ae_Branchitem.Control = Me.Branch_Code
            Me.ae_Branchitem.Location = New System.Drawing.Point(0, 24)
            Me.ae_Branchitem.Name = "ae_Branchitem"
            Me.ae_Branchitem.Size = New System.Drawing.Size(280, 24)
            Me.ae_Branchitem.Text = "Branch"
            Me.ae_Branchitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.ae_Branchitem.TextSize = New System.Drawing.Size(48, 13)
            '
            'ae_Notesitem
            '
            Me.ae_Notesitem.Control = Me.Notes
            Me.ae_Notesitem.Location = New System.Drawing.Point(0, 216)
            Me.ae_Notesitem.Name = "ae_Notesitem"
            Me.ae_Notesitem.Size = New System.Drawing.Size(280, 114)
            Me.ae_Notesitem.Text = "Notes"
            Me.ae_Notesitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.ae_Notesitem.TextSize = New System.Drawing.Size(48, 13)
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(140, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(48, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Engine
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem2.Text = "Engine"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(48, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Chassis
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem3.Text = "Chassis"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(48, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Plate_Number
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 120)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem4.Text = "Plate #"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(48, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.CTC_Number
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 144)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem5.Text = "CTC #"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(48, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.CTC_Place
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 192)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem6.Text = "CTC Place"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(48, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.CTC_Date
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 168)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(280, 24)
            Me.LayoutControlItem7.Text = "CTC Date"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(48, 13)
            '
            'ae_Codeitem
            '
            Me.ae_Codeitem.Control = Me.AE_Code
            Me.ae_Codeitem.Location = New System.Drawing.Point(140, 0)
            Me.ae_Codeitem.Name = "ae_Codeitem"
            Me.ae_Codeitem.Size = New System.Drawing.Size(140, 24)
            Me.ae_Codeitem.Text = "Code"
            Me.ae_Codeitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.ae_Codeitem.TextSize = New System.Drawing.Size(48, 13)
            '
            'xuc_Account_Executive
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_Account_Executive"
            Me.Size = New System.Drawing.Size(300, 350)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AE_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AE_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Chassis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Plate_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Engine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CTC_Number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CTC_Place.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CTC_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CTC_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ae_Nameitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ae_Branchitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ae_Notesitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ae_Codeitem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend AE_Code As DevExpress.XtraEditors.TextEdit
        Friend Branch_Code As DevExpress.XtraEditors.LookUpEdit
        Friend Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents ae_Nameitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ae_Codeitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ae_Branchitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ae_Notesitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents AE_Name As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Chassis As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Plate_Number As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Engine As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents CTC_Number As DevExpress.XtraEditors.TextEdit
        Friend WithEvents CTC_Place As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents CTC_Date As DevExpress.XtraEditors.DateEdit
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace