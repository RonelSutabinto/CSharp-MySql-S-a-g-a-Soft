Namespace Controls.Management
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_IP_Access
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
            Me.ip_Address = New DevExpress.XtraEditors.TextEdit()
            Me.IP_Location = New DevExpress.XtraEditors.MemoEdit()
            Me.ip_Branch = New DevExpress.XtraEditors.LookUpEdit()
            Me.xuc_IP_AccessLayoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ip_Branchitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.ip_Addressitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.IP_Locationitem = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.ip_Address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IP_Location.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ip_Branch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.xuc_IP_AccessLayoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xuc_IP_AccessLayoutControl1ConvertedLayout.SuspendLayout()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ip_Branchitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ip_Addressitem, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.IP_Locationitem, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ip_Address
            '
            Me.ip_Address.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ip_Address.Location = New System.Drawing.Point(77, 36)
            Me.ip_Address.Name = "ip_Address"
            Me.ip_Address.Size = New System.Drawing.Size(111, 20)
            Me.ip_Address.StyleController = Me.xuc_IP_AccessLayoutControl1ConvertedLayout
            Me.ip_Address.TabIndex = 1
            '
            'IP_Location
            '
            Me.IP_Location.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.IP_Location.Enabled = False
            Me.IP_Location.Location = New System.Drawing.Point(12, 60)
            Me.IP_Location.Name = "IP_Location"
            Me.IP_Location.Size = New System.Drawing.Size(176, 128)
            Me.IP_Location.StyleController = Me.xuc_IP_AccessLayoutControl1ConvertedLayout
            Me.IP_Location.TabIndex = 2
            '
            'ip_Branch
            '
            Me.ip_Branch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ip_Branch.Location = New System.Drawing.Point(77, 12)
            Me.ip_Branch.Name = "ip_Branch"
            Me.ip_Branch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ip_Branch.Size = New System.Drawing.Size(111, 20)
            Me.ip_Branch.StyleController = Me.xuc_IP_AccessLayoutControl1ConvertedLayout
            Me.ip_Branch.TabIndex = 0
            '
            'xuc_IP_AccessLayoutControl1ConvertedLayout
            '
            Me.xuc_IP_AccessLayoutControl1ConvertedLayout.Controls.Add(Me.ip_Branch)
            Me.xuc_IP_AccessLayoutControl1ConvertedLayout.Controls.Add(Me.ip_Address)
            Me.xuc_IP_AccessLayoutControl1ConvertedLayout.Controls.Add(Me.IP_Location)
            Me.xuc_IP_AccessLayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xuc_IP_AccessLayoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.xuc_IP_AccessLayoutControl1ConvertedLayout.Name = "xuc_IP_AccessLayoutControl1ConvertedLayout"
            Me.xuc_IP_AccessLayoutControl1ConvertedLayout.Root = Me.LayoutControlGroup1
            Me.xuc_IP_AccessLayoutControl1ConvertedLayout.Size = New System.Drawing.Size(200, 200)
            Me.xuc_IP_AccessLayoutControl1ConvertedLayout.TabIndex = 0
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ip_Branchitem, Me.ip_Addressitem, Me.IP_Locationitem})
            Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(200, 200)
            Me.LayoutControlGroup1.TextVisible = False
            '
            'ip_Branchitem
            '
            Me.ip_Branchitem.Control = Me.ip_Branch
            Me.ip_Branchitem.Location = New System.Drawing.Point(0, 0)
            Me.ip_Branchitem.Name = "ip_Branchitem"
            Me.ip_Branchitem.Size = New System.Drawing.Size(180, 24)
            Me.ip_Branchitem.Text = "Branch"
            Me.ip_Branchitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.ip_Branchitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'ip_Addressitem
            '
            Me.ip_Addressitem.Control = Me.ip_Address
            Me.ip_Addressitem.Location = New System.Drawing.Point(0, 24)
            Me.ip_Addressitem.Name = "ip_Addressitem"
            Me.ip_Addressitem.Size = New System.Drawing.Size(180, 24)
            Me.ip_Addressitem.Text = "IP Address"
            Me.ip_Addressitem.TextLocation = DevExpress.Utils.Locations.Left
            Me.ip_Addressitem.TextSize = New System.Drawing.Size(53, 13)
            '
            'IP_Locationitem
            '
            Me.IP_Locationitem.Control = Me.IP_Location
            Me.IP_Locationitem.Location = New System.Drawing.Point(0, 48)
            Me.IP_Locationitem.Name = "IP_Locationitem"
            Me.IP_Locationitem.Size = New System.Drawing.Size(180, 132)
            Me.IP_Locationitem.TextSize = New System.Drawing.Size(0, 0)
            Me.IP_Locationitem.TextVisible = False
            '
            'xuc_IP_Access
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.xuc_IP_AccessLayoutControl1ConvertedLayout)
            Me.Name = "xuc_IP_Access"
            Me.Size = New System.Drawing.Size(200, 200)
            CType(Me.ip_Address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IP_Location.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ip_Branch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.xuc_IP_AccessLayoutControl1ConvertedLayout, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xuc_IP_AccessLayoutControl1ConvertedLayout.ResumeLayout(False)
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ip_Branchitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ip_Addressitem, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.IP_Locationitem, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents ip_Address As DevExpress.XtraEditors.TextEdit
        Friend IP_Location As DevExpress.XtraEditors.MemoEdit
        Friend ip_Branch As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents xuc_IP_AccessLayoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents ip_Branchitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents ip_Addressitem As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents IP_Locationitem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
