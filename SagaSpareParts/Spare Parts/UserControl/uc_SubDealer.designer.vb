<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc_SubDealer
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.dtp_PostingDate = New DevExpress.XtraEditors.DateEdit()
        Me.txt_SubAddress = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_SubName = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_ID = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.dtp_PostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtp_PostingDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SubAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_SubName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dtp_PostingDate)
        Me.LayoutControl1.Controls.Add(Me.txt_SubAddress)
        Me.LayoutControl1.Controls.Add(Me.txt_SubName)
        Me.LayoutControl1.Controls.Add(Me.txt_ID)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(-1114, 169, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(245, 417)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dtp_PostingDate
        '
        Me.dtp_PostingDate.EditValue = Nothing
        Me.dtp_PostingDate.Location = New System.Drawing.Point(109, 379)
        Me.dtp_PostingDate.Name = "dtp_PostingDate"
        Me.dtp_PostingDate.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_PostingDate.Properties.Appearance.Options.UseFont = True
        Me.dtp_PostingDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_PostingDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtp_PostingDate.Size = New System.Drawing.Size(124, 26)
        Me.dtp_PostingDate.StyleController = Me.LayoutControl1
        Me.dtp_PostingDate.TabIndex = 4
        '
        'txt_SubAddress
        '
        Me.txt_SubAddress.Location = New System.Drawing.Point(109, 75)
        Me.txt_SubAddress.Name = "txt_SubAddress"
        Me.txt_SubAddress.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubAddress.Properties.Appearance.Options.UseFont = True
        Me.txt_SubAddress.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubAddress.Size = New System.Drawing.Size(124, 300)
        Me.txt_SubAddress.StyleController = Me.LayoutControl1
        Me.txt_SubAddress.TabIndex = 3
        '
        'txt_SubName
        '
        Me.txt_SubName.Location = New System.Drawing.Point(109, 42)
        Me.txt_SubName.Name = "txt_SubName"
        Me.txt_SubName.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubName.Properties.Appearance.Options.UseFont = True
        Me.txt_SubName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubName.Size = New System.Drawing.Size(124, 29)
        Me.txt_SubName.StyleController = Me.LayoutControl1
        Me.txt_SubName.TabIndex = 2
        '
        'txt_ID
        '
        Me.txt_ID.Location = New System.Drawing.Point(109, 12)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Properties.Appearance.Options.UseFont = True
        Me.txt_ID.Size = New System.Drawing.Size(124, 26)
        Me.txt_ID.StyleController = Me.LayoutControl1
        Me.txt_ID.TabIndex = 0
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(245, 417)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txt_ID
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(225, 30)
        Me.LayoutControlItem1.Text = "ID"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txt_SubName
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 33)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(111, 33)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(225, 33)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.Text = "Sub Dealer Name"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txt_SubAddress
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 63)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(225, 304)
        Me.LayoutControlItem3.Text = "Sub Dealer Address"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(94, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.dtp_PostingDate
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 367)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(225, 30)
        Me.LayoutControlItem4.Text = "Posting Date"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(94, 13)
        '
        'uc_SubDealer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "uc_SubDealer"
        Me.Size = New System.Drawing.Size(245, 417)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.dtp_PostingDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtp_PostingDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SubAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_SubName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents dtp_PostingDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txt_SubAddress As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_SubName As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
