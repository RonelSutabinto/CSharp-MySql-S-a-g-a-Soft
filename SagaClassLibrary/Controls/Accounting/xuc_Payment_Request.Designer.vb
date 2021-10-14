Namespace Controls.Accounting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Payment_Request
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
            Me.PopupContainerControl = New DevExpress.XtraEditors.PopupContainerControl()
            Me.xuc_Account_Search = New SagaClassLibrary.Controls.Information.Account.xuc_Account_Search()
            Me.ID = New DevExpress.XtraEditors.TextEdit()
            Me.Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Branch_Code = New DevExpress.XtraEditors.LookUpEdit()
            Me.Request_Description = New DevExpress.XtraEditors.MemoEdit()
            Me.Payee_Address = New DevExpress.XtraEditors.MemoEdit()
            Me.Request_Date = New DevExpress.XtraEditors.DateEdit()
            Me.Request_Code = New DevExpress.XtraEditors.TextEdit()
            Me.Payee_Name = New DevExpress.XtraEditors.PopupContainerEdit()
            Me.Request_Type = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Request_Amount = New DevExpress.XtraEditors.CalcEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SplitterItem1 = New DevExpress.XtraLayout.SplitterItem()
            Me.SplitterItem2 = New DevExpress.XtraLayout.SplitterItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PopupContainerControl.SuspendLayout()
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Request_Description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Payee_Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Request_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Request_Date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Request_Code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Payee_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Request_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Request_Amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'layoutControl
            '
            Me.layoutControl.Controls.Add(Me.PopupContainerControl)
            Me.layoutControl.Controls.Add(Me.ID)
            Me.layoutControl.Controls.Add(Me.Notes)
            Me.layoutControl.Controls.Add(Me.Branch_Code)
            Me.layoutControl.Controls.Add(Me.Request_Description)
            Me.layoutControl.Controls.Add(Me.Payee_Address)
            Me.layoutControl.Controls.Add(Me.Request_Date)
            Me.layoutControl.Controls.Add(Me.Request_Code)
            Me.layoutControl.Controls.Add(Me.Payee_Name)
            Me.layoutControl.Controls.Add(Me.Request_Type)
            Me.layoutControl.Controls.Add(Me.Request_Amount)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(308, 400)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'PopupContainerControl
            '
            Me.PopupContainerControl.Controls.Add(Me.xuc_Account_Search)
            Me.PopupContainerControl.Location = New System.Drawing.Point(138, 240)
            Me.PopupContainerControl.Name = "PopupContainerControl"
            Me.PopupContainerControl.Size = New System.Drawing.Size(280, 174)
            Me.PopupContainerControl.TabIndex = 23
            '
            'xuc_Account_Search
            '
            Me.xuc_Account_Search.AccountName = Nothing
            Me.xuc_Account_Search.Amount = New Decimal(New Integer() {0, 0, 0, 0})
            Me.xuc_Account_Search.Code = Nothing
            Me.xuc_Account_Search.Code2 = Nothing
            Me.xuc_Account_Search.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_Account_Search.ID = 0
            Me.xuc_Account_Search.Location = New System.Drawing.Point(0, 0)
            Me.xuc_Account_Search.Name = "xuc_Account_Search"
            Me.xuc_Account_Search.Others = Nothing
            Me.xuc_Account_Search.searchMode = SagaClassLibrary.Controls.Information.Account.xuc_Account_Search.Search_Mode.searchGlobal
            Me.xuc_Account_Search.Size = New System.Drawing.Size(280, 174)
            Me.xuc_Account_Search.TabIndex = 0
            Me.xuc_Account_Search.Type = Nothing
            '
            'ID
            '
            Me.ID.Location = New System.Drawing.Point(92, 12)
            Me.ID.Name = "ID"
            Me.ID.Size = New System.Drawing.Size(60, 20)
            Me.ID.StyleController = Me.layoutControl
            Me.ID.TabIndex = 0
            '
            'Notes
            '
            Me.Notes.Location = New System.Drawing.Point(92, 276)
            Me.Notes.Name = "Notes"
            Me.Notes.Size = New System.Drawing.Size(204, 112)
            Me.Notes.StyleController = Me.layoutControl
            Me.Notes.TabIndex = 9
            '
            'Branch_Code
            '
            Me.Branch_Code.Location = New System.Drawing.Point(92, 36)
            Me.Branch_Code.Name = "Branch_Code"
            Me.Branch_Code.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Branch_Code.Properties.NullText = ""
            Me.Branch_Code.Properties.PopupSizeable = False
            Me.Branch_Code.Size = New System.Drawing.Size(204, 20)
            Me.Branch_Code.StyleController = Me.layoutControl
            Me.Branch_Code.TabIndex = 2
            '
            'Request_Description
            '
            Me.Request_Description.Location = New System.Drawing.Point(92, 216)
            Me.Request_Description.Name = "Request_Description"
            Me.Request_Description.Size = New System.Drawing.Size(204, 46)
            Me.Request_Description.StyleController = Me.layoutControl
            Me.Request_Description.TabIndex = 8
            '
            'Payee_Address
            '
            Me.Payee_Address.Location = New System.Drawing.Point(92, 156)
            Me.Payee_Address.Name = "Payee_Address"
            Me.Payee_Address.Size = New System.Drawing.Size(204, 46)
            Me.Payee_Address.StyleController = Me.layoutControl
            Me.Payee_Address.TabIndex = 7
            '
            'Request_Date
            '
            Me.Request_Date.EditValue = Nothing
            Me.Request_Date.Location = New System.Drawing.Point(92, 84)
            Me.Request_Date.Name = "Request_Date"
            Me.Request_Date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Request_Date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Request_Date.Properties.DisplayFormat.FormatString = ""
            Me.Request_Date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Request_Date.Properties.EditFormat.FormatString = ""
            Me.Request_Date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.Request_Date.Properties.Mask.EditMask = ""
            Me.Request_Date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.Request_Date.Size = New System.Drawing.Size(204, 20)
            Me.Request_Date.StyleController = Me.layoutControl
            Me.Request_Date.TabIndex = 4
            '
            'Request_Code
            '
            Me.Request_Code.Location = New System.Drawing.Point(236, 12)
            Me.Request_Code.Name = "Request_Code"
            Me.Request_Code.Size = New System.Drawing.Size(60, 20)
            Me.Request_Code.StyleController = Me.layoutControl
            Me.Request_Code.TabIndex = 1
            '
            'Payee_Name
            '
            Me.Payee_Name.Location = New System.Drawing.Point(92, 132)
            Me.Payee_Name.Name = "Payee_Name"
            Me.Payee_Name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Payee_Name.Properties.PopupControl = Me.PopupContainerControl
            Me.Payee_Name.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
            Me.Payee_Name.Size = New System.Drawing.Size(204, 20)
            Me.Payee_Name.StyleController = Me.layoutControl
            Me.Payee_Name.TabIndex = 6
            '
            'Request_Type
            '
            Me.Request_Type.Location = New System.Drawing.Point(92, 60)
            Me.Request_Type.Name = "Request_Type"
            Me.Request_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Request_Type.Size = New System.Drawing.Size(204, 20)
            Me.Request_Type.StyleController = Me.layoutControl
            Me.Request_Type.TabIndex = 3
            '
            'Request_Amount
            '
            Me.Request_Amount.Location = New System.Drawing.Point(92, 108)
            Me.Request_Amount.Name = "Request_Amount"
            Me.Request_Amount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.Request_Amount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.Request_Amount.Size = New System.Drawing.Size(204, 20)
            Me.Request_Amount.StyleController = Me.layoutControl
            Me.Request_Amount.TabIndex = 5
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem9, Me.LayoutControlItem2, Me.SplitterItem1, Me.SplitterItem2, Me.LayoutControlItem8, Me.LayoutControlItem10})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(308, 400)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.ID
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(144, 24)
            Me.LayoutControlItem1.Text = "ID"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Notes
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 264)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(288, 116)
            Me.LayoutControlItem3.Text = "Notes"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Request_Description
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 204)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(288, 50)
            Me.LayoutControlItem4.Text = "Description"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Payee_Name
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 120)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(288, 24)
            Me.LayoutControlItem5.Text = "Payee / Name"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.Payee_Address
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 144)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(288, 50)
            Me.LayoutControlItem7.Text = "Address"
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.Request_Date
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 72)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(288, 24)
            Me.LayoutControlItem6.Text = "Request Date"
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.Request_Type
            Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 48)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(288, 24)
            Me.LayoutControlItem9.Text = "Request Type"
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Branch_Code
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(288, 24)
            Me.LayoutControlItem2.Text = "Branch"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(68, 13)
            '
            'SplitterItem1
            '
            Me.SplitterItem1.AllowHotTrack = True
            Me.SplitterItem1.Location = New System.Drawing.Point(0, 194)
            Me.SplitterItem1.Name = "SplitterItem1"
            Me.SplitterItem1.Size = New System.Drawing.Size(288, 10)
            '
            'SplitterItem2
            '
            Me.SplitterItem2.AllowHotTrack = True
            Me.SplitterItem2.Location = New System.Drawing.Point(0, 254)
            Me.SplitterItem2.Name = "SplitterItem2"
            Me.SplitterItem2.Size = New System.Drawing.Size(288, 10)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.Request_Code
            Me.LayoutControlItem8.Location = New System.Drawing.Point(144, 0)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(144, 24)
            Me.LayoutControlItem8.Text = "Request Code"
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(68, 13)
            '
            'LayoutControlItem10
            '
            Me.LayoutControlItem10.Control = Me.Request_Amount
            Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 96)
            Me.LayoutControlItem10.Name = "LayoutControlItem10"
            Me.LayoutControlItem10.Size = New System.Drawing.Size(288, 24)
            Me.LayoutControlItem10.Text = "Amount"
            Me.LayoutControlItem10.TextSize = New System.Drawing.Size(68, 13)
            '
            'xuc_Payment_Request
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_Payment_Request"
            Me.Size = New System.Drawing.Size(308, 400)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.PopupContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PopupContainerControl.ResumeLayout(False)
            CType(Me.ID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Branch_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Request_Description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Payee_Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Request_Date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Request_Date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Request_Code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Payee_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Request_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Request_Amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitterItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents ID As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Branch_Code As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Request_Description As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Payee_Address As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Request_Date As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Request_Code As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Payee_Name As DevExpress.XtraEditors.PopupContainerEdit
        Friend WithEvents Request_Type As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents PopupContainerControl As DevExpress.XtraEditors.PopupContainerControl
        Friend WithEvents xuc_Account_Search As Information.Account.xuc_Account_Search
        Friend WithEvents Request_Amount As DevExpress.XtraEditors.CalcEdit
        Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SplitterItem1 As DevExpress.XtraLayout.SplitterItem
        Friend WithEvents SplitterItem2 As DevExpress.XtraLayout.SplitterItem
    End Class
End Namespace