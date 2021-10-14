<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xuc_PDC
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
        Me.Customer_Address = New DevExpress.XtraEditors.TextEdit()
        Me.Check_No = New DevExpress.XtraEditors.TextEdit()
        Me.PDC_Description = New DevExpress.XtraEditors.MemoEdit()
        Me.SBD_Mat_Date = New DevExpress.XtraEditors.DateEdit()
        Me.SBD_Amount_Due = New DevExpress.XtraEditors.CalcEdit()
        Me.Due_Date = New DevExpress.XtraEditors.DateEdit()
        Me.Amount = New DevExpress.XtraEditors.CalcEdit()
        Me.Bank_Name = New DevExpress.XtraEditors.TextEdit()
        Me.PDC_Id = New DevExpress.XtraEditors.TextEdit()
        Me.Customer_Name = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.Remarks = New DevExpress.XtraEditors.MemoEdit()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl.SuspendLayout()
        CType(Me.Customer_Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Check_No.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDC_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBD_Mat_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBD_Mat_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SBD_Amount_Due.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Due_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Due_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bank_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PDC_Id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customer_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Remarks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl.Controls.Add(Me.Customer_Address)
        Me.LayoutControl.Controls.Add(Me.Check_No)
        Me.LayoutControl.Controls.Add(Me.PDC_Description)
        Me.LayoutControl.Controls.Add(Me.SBD_Mat_Date)
        Me.LayoutControl.Controls.Add(Me.SBD_Amount_Due)
        Me.LayoutControl.Controls.Add(Me.Due_Date)
        Me.LayoutControl.Controls.Add(Me.Amount)
        Me.LayoutControl.Controls.Add(Me.Bank_Name)
        Me.LayoutControl.Controls.Add(Me.PDC_Id)
        Me.LayoutControl.Controls.Add(Me.Customer_Name)
        Me.LayoutControl.Controls.Add(Me.Remarks)
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl1"
        Me.LayoutControl.Root = Me.Root
        Me.LayoutControl.Size = New System.Drawing.Size(266, 389)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'Customer_Address
        '
        Me.Customer_Address.Location = New System.Drawing.Point(112, 84)
        Me.Customer_Address.Name = "Customer_Address"
        Me.Customer_Address.Properties.ReadOnly = True
        Me.Customer_Address.Size = New System.Drawing.Size(142, 20)
        Me.Customer_Address.StyleController = Me.layoutControl
        Me.Customer_Address.TabIndex = 7
        '
        'Check_No
        '
        Me.Check_No.Location = New System.Drawing.Point(112, 108)
        Me.Check_No.Name = "Check_No"
        Me.Check_No.Size = New System.Drawing.Size(142, 20)
        Me.Check_No.StyleController = Me.layoutControl
        Me.Check_No.TabIndex = 1
        '
        'PDC_Description
        '
        Me.PDC_Description.Location = New System.Drawing.Point(112, 228)
        Me.PDC_Description.Name = "PDC_Description"
        Me.PDC_Description.Size = New System.Drawing.Size(142, 76)
        Me.PDC_Description.StyleController = Me.layoutControl
        Me.PDC_Description.TabIndex = 4
        '
        'SBD_Mat_Date
        '
        Me.SBD_Mat_Date.EditValue = Nothing
        Me.SBD_Mat_Date.Location = New System.Drawing.Point(112, 204)
        Me.SBD_Mat_Date.Name = "SBD_Mat_Date"
        Me.SBD_Mat_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SBD_Mat_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SBD_Mat_Date.Properties.DisplayFormat.FormatString = ""
        Me.SBD_Mat_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SBD_Mat_Date.Properties.EditFormat.FormatString = ""
        Me.SBD_Mat_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.SBD_Mat_Date.Properties.MaskSettings.Set("mask", "")
        Me.SBD_Mat_Date.Properties.ReadOnly = True
        Me.SBD_Mat_Date.Size = New System.Drawing.Size(142, 20)
        Me.SBD_Mat_Date.StyleController = Me.layoutControl
        Me.SBD_Mat_Date.TabIndex = 9
        '
        'SBD_Amount_Due
        '
        Me.SBD_Amount_Due.Location = New System.Drawing.Point(112, 180)
        Me.SBD_Amount_Due.Name = "SBD_Amount_Due"
        Me.SBD_Amount_Due.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SBD_Amount_Due.Properties.ReadOnly = True
        Me.SBD_Amount_Due.Size = New System.Drawing.Size(142, 20)
        Me.SBD_Amount_Due.StyleController = Me.layoutControl
        Me.SBD_Amount_Due.TabIndex = 8
        '
        'Due_Date
        '
        Me.Due_Date.EditValue = Nothing
        Me.Due_Date.Location = New System.Drawing.Point(112, 156)
        Me.Due_Date.Name = "Due_Date"
        Me.Due_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Due_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Due_Date.Properties.DisplayFormat.FormatString = ""
        Me.Due_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Due_Date.Properties.EditFormat.FormatString = ""
        Me.Due_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Due_Date.Properties.MaskSettings.Set("mask", "")
        Me.Due_Date.Size = New System.Drawing.Size(142, 20)
        Me.Due_Date.StyleController = Me.layoutControl
        Me.Due_Date.TabIndex = 3
        '
        'Amount
        '
        Me.Amount.Location = New System.Drawing.Point(112, 132)
        Me.Amount.Name = "Amount"
        Me.Amount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Amount.Size = New System.Drawing.Size(142, 20)
        Me.Amount.StyleController = Me.layoutControl
        Me.Amount.TabIndex = 2
        '
        'Bank_Name
        '
        Me.Bank_Name.Location = New System.Drawing.Point(112, 36)
        Me.Bank_Name.Name = "Bank_Name"
        Me.Bank_Name.Size = New System.Drawing.Size(142, 20)
        Me.Bank_Name.StyleController = Me.layoutControl
        Me.Bank_Name.TabIndex = 0
        '
        'PDC_Id
        '
        Me.PDC_Id.Location = New System.Drawing.Point(112, 12)
        Me.PDC_Id.Name = "PDC_Id"
        Me.PDC_Id.Properties.ReadOnly = True
        Me.PDC_Id.Size = New System.Drawing.Size(142, 20)
        Me.PDC_Id.StyleController = Me.layoutControl
        Me.PDC_Id.TabIndex = 5
        '
        'Customer_Name
        '
        Me.Customer_Name.Location = New System.Drawing.Point(112, 60)
        Me.Customer_Name.Name = "Customer_Name"
        Me.Customer_Name.Properties.ReadOnly = True
        Me.Customer_Name.Size = New System.Drawing.Size(142, 20)
        Me.Customer_Name.StyleController = Me.layoutControl
        Me.Customer_Name.TabIndex = 6
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(266, 389)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.Bank_Name
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem1.Text = "Bank Name"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.Customer_Name
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem2.Text = "Customer Name"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.Customer_Address
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem3.Text = "Customer Address"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.Check_No
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem4.Text = "Check Number"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.Amount
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 120)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem5.Text = "Amount"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.Due_Date
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 144)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem6.Text = "Due Date"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.PDC_Description
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 216)
        Me.LayoutControlItem7.MaxSize = New System.Drawing.Size(0, 80)
        Me.LayoutControlItem7.MinSize = New System.Drawing.Size(114, 80)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(246, 80)
        Me.LayoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem7.Text = "Description"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.SBD_Amount_Due
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 168)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem8.Text = "SBD Amount Due"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SBD_Mat_Date
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 192)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem9.Text = "SBD Maturity Date"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(88, 13)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.PDC_Id
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(246, 24)
        Me.LayoutControlItem10.Text = "ID"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(88, 13)
        '
        'Remarks
        '
        Me.Remarks.Location = New System.Drawing.Point(112, 308)
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Size = New System.Drawing.Size(142, 69)
        Me.Remarks.StyleController = Me.layoutControl
        Me.Remarks.TabIndex = 10
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.Remarks
        Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 296)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(246, 73)
        Me.LayoutControlItem11.Text = "Remarks"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(88, 13)
        '
        'xuc_PDC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.layoutControl)
        Me.Name = "xuc_PDC"
        Me.Size = New System.Drawing.Size(266, 389)
        CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl.ResumeLayout(False)
        CType(Me.Customer_Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Check_No.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDC_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBD_Mat_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBD_Mat_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SBD_Amount_Due.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Due_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Due_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bank_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PDC_Id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customer_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Remarks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Customer_Address As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Check_No As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PDC_Description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SBD_Mat_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SBD_Amount_Due As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Due_Date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Amount As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Bank_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PDC_Id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents Customer_Name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Remarks As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
End Class
