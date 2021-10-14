Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_SPA_Receive_Order
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
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Transaction_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Reference = New DevExpress.XtraEditors.TextEdit()
            Me.Transaction_Type = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Order_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Transaction_Date = New DevExpress.XtraEditors.DateEdit()
            Me.SKU_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Received_Date = New DevExpress.XtraEditors.DateEdit()
            Me.SKU_Status = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Branch_From = New DevExpress.XtraEditors.TextEdit()
            Me.Branch_Code = New DevExpress.XtraEditors.TextEdit()
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
            Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl.SuspendLayout()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Transaction_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Reference.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Transaction_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Order_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Transaction_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Transaction_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SKU_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Received_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Received_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SKU_Status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Branch_From.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LayoutControl1
            '
            Me.LayoutControl.Controls.Add(Me.ID)
            Me.LayoutControl.Controls.Add(Me.Transaction_Code)
            Me.LayoutControl.Controls.Add(Me.Reference)
            Me.LayoutControl.Controls.Add(Me.Transaction_Type)
            Me.LayoutControl.Controls.Add(Me.Order_Code)
            Me.LayoutControl.Controls.Add(Me.Transaction_Date)
            Me.LayoutControl.Controls.Add(Me.SKU_Description)
            Me.LayoutControl.Controls.Add(Me.Notes)
            Me.LayoutControl.Controls.Add(Me.Received_Date)
            Me.LayoutControl.Controls.Add(Me.SKU_Status)
            Me.LayoutControl.Controls.Add(Me.Branch_From)
            Me.LayoutControl.Controls.Add(Me.Branch_Code)
            Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl.Name = "LayoutControl1"
            Me.LayoutControl.Root = Me.Root
            Me.LayoutControl.Size = New System.Drawing.Size(284, 425)
            Me.LayoutControl.TabIndex = 0
            Me.LayoutControl.Text = "LayoutControl1"
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(108, 12)
            Me.ID.Name = "ID"
            Me.ID.Properties.ReadOnly = True
            Me.ID.Size = New System.Drawing.Size(164, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 4
            '
            'Transaction_Code
            '
            Me.Transaction_Code.EditValue = ""
            Me.Transaction_Code.Location = New System.Drawing.Point(108, 84)
            Me.Transaction_Code.Name = "Transaction_Code"
            Me.Transaction_Code.Properties.ReadOnly = True
            Me.Transaction_Code.Size = New System.Drawing.Size(164, 20)
            Me.Transaction_Code.StyleController = Me.layoutControl
            Me.Transaction_Code.TabIndex = 7
            '
            'Reference
            '
            Me.Reference.Location = New System.Drawing.Point(108, 132)
            Me.Reference.Name = "Reference"
            Me.Reference.Size = New System.Drawing.Size(164, 20)
            Me.Reference.StyleController = Me.layoutControl
            Me.Reference.TabIndex = 9
            '
            'Transaction_Type
            '
            Me.Transaction_Type.Location = New System.Drawing.Point(108, 36)
            Me.Transaction_Type.Name = "Transaction_Type"
            Me.Transaction_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Transaction_Type.Properties.Items.AddRange(New Object() {"RECEIVING"})
            Me.Transaction_Type.Size = New System.Drawing.Size(164, 20)
            Me.Transaction_Type.StyleController = Me.layoutControl
            Me.Transaction_Type.TabIndex = 5
            '
            'Order_Code
            '
            Me.Order_Code.Location = New System.Drawing.Point(108, 60)
            Me.Order_Code.Name = "Order_Code"
            Me.Order_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Order_Code.Properties.NullText = ""
            Me.Order_Code.Size = New System.Drawing.Size(164, 20)
            Me.Order_Code.StyleController = Me.layoutControl
            Me.Order_Code.TabIndex = 6
            '
            'Transaction_Date
            '
            Me.Transaction_Date.EditValue = Nothing
            Me.Transaction_Date.Location = New System.Drawing.Point(108, 180)
            Me.Transaction_Date.Name = "Transaction_Date"
            Me.Transaction_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Transaction_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Transaction_Date.Properties.DisplayFormat.FormatString = ""
            Me.Transaction_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Transaction_Date.Properties.EditFormat.FormatString = ""
            Me.Transaction_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Transaction_Date.Properties.Mask.EditMask = ""
            Me.Transaction_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.Transaction_Date.Properties.ReadOnly = True
            Me.Transaction_Date.Size = New System.Drawing.Size(164, 20)
            Me.Transaction_Date.StyleController = Me.layoutControl
            Me.Transaction_Date.TabIndex = 11
            '
            'SKU_Description
            '
            Me.SKU_Description.Location = New System.Drawing.Point(108, 252)
            Me.SKU_Description.Name = "SKU_Description"
            Me.SKU_Description.Size = New System.Drawing.Size(164, 52)
            Me.SKU_Description.StyleController = Me.layoutControl
            Me.SKU_Description.TabIndex = 14
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(108, 308)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(164, 105)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 15
            '
            'Received_Date
            '
            Me.Received_Date.EditValue = Nothing
            Me.Received_Date.Location = New System.Drawing.Point(108, 156)
            Me.Received_Date.Name = "Received_Date"
            Me.Received_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Received_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Received_Date.Properties.DisplayFormat.FormatString = ""
            Me.Received_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Received_Date.Properties.EditFormat.FormatString = ""
            Me.Received_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Received_Date.Properties.Mask.EditMask = ""
            Me.Received_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.Received_Date.Size = New System.Drawing.Size(164, 20)
            Me.Received_Date.StyleController = Me.layoutControl
            Me.Received_Date.TabIndex = 10
            '
            'SKU_Status
            '
            Me.SKU_Status.Location = New System.Drawing.Point(108, 228)
            Me.SKU_Status.Name = "SKU_Status"
            Me.SKU_Status.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.SKU_Status.Properties.Items.AddRange(New Object() {"NEW", "OLD"})
            Me.SKU_Status.Properties.PopupSizeable = True
            Me.SKU_Status.Size = New System.Drawing.Size(164, 20)
            Me.SKU_Status.StyleController = Me.layoutControl
            Me.SKU_Status.TabIndex = 13
            '
            'Branch_From
            '
            Me.Branch_From.Location = New System.Drawing.Point(108, 108)
            Me.Branch_From.Name = "Branch_From"
            Me.Branch_From.Properties.ReadOnly = True
            Me.Branch_From.Size = New System.Drawing.Size(164, 20)
            Me.Branch_From.StyleController = Me.layoutControl
            Me.Branch_From.TabIndex = 8
            '
            'Branch_Code
            '
            Me.Branch_Code.Location = New System.Drawing.Point(108, 204)
            Me.Branch_Code.Name = "Branch_Code"
            Me.Branch_Code.Properties.ReadOnly = True
            Me.Branch_Code.Size = New System.Drawing.Size(164, 20)
            Me.Branch_Code.StyleController = Me.layoutControl
            Me.Branch_Code.TabIndex = 12
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(284, 425)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(264, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(84, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Transaction_Type
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(264, 24)
            Me.LayoutControlItem2.Text = "Type"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(84, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Order_Code
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(264, 24)
            Me.LayoutControlItem3.Text = "Purchase Order"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(84, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Transaction_Code
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(264, 24)
            Me.LayoutControlItem4.Text = "Transaction Code"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(84, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Branch_From
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(264, 24)
            Me.LayoutControlItem5.Text = "Supplier/Branch"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(84, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Reference
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 120)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(264, 24)
            Me.LayoutControlItem6.Text = "Reference"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(84, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.Received_Date
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(264, 24)
            Me.LayoutControlItem7.Text = "Received Date"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(84, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.Transaction_Date
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 168)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(264, 24)
            Me.LayoutControlItem8.Text = "Transaction Date"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(84, 13)
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.Branch_Code
            Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 192)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(264, 24)
            Me.LayoutControlItem9.Text = "Receiving Branch"
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(84, 13)
            '
            'LayoutControlItem10
            '
            Me.LayoutControlItem10.Control = Me.SKU_Status
            Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 216)
            Me.LayoutControlItem10.Name = "LayoutControlItem10"
            Me.LayoutControlItem10.Size = New System.Drawing.Size(264, 24)
            Me.LayoutControlItem10.Text = "SKU Status"
            Me.LayoutControlItem10.TextSize = New System.Drawing.Size(84, 13)
            '
            'LayoutControlItem11
            '
            Me.LayoutControlItem11.Control = Me.SKU_Description
            Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 240)
            Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(0, 56)
            Me.LayoutControlItem11.MinSize = New System.Drawing.Size(110, 56)
            Me.LayoutControlItem11.Name = "LayoutControlItem11"
            Me.LayoutControlItem11.Size = New System.Drawing.Size(264, 56)
            Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem11.Text = "Description"
            Me.LayoutControlItem11.TextSize = New System.Drawing.Size(84, 13)
            '
            'LayoutControlItem12
            '
            Me.LayoutControlItem12.Control = Me.Notes
            Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 296)
            Me.LayoutControlItem12.Name = "LayoutControlItem12"
            Me.LayoutControlItem12.Size = New System.Drawing.Size(264, 109)
            Me.LayoutControlItem12.Text = "Notes"
            Me.LayoutControlItem12.TextSize = New System.Drawing.Size(84, 13)
            '
            'xuc_SPA_Receive_Order
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_SPA_Receive_Order"
            Me.Size = New System.Drawing.Size(284, 425)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl.ResumeLayout(False)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Transaction_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Reference.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Transaction_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Order_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Transaction_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Transaction_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SKU_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Received_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Received_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SKU_Status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Branch_From.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
            CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Transaction_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Reference As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Transaction_Type As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents Order_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Transaction_Date As DevExpress.XtraEditors.DateEdit
        Friend WithEvents SKU_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Received_Date As DevExpress.XtraEditors.DateEdit
        Friend WithEvents SKU_Status As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents Branch_From As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Branch_Code As DevExpress.XtraEditors.TextEdit
    End Class
End Namespace