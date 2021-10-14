Namespace Chat
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Chat
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xuc_Chat))
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.btn_Connect = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_Send = New DevExpress.XtraEditors.SimpleButton()
            Me.Message = New DevExpress.XtraEditors.TextEdit()
            Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.Port = New DevExpress.XtraEditors.TextEdit()
            Me.Server = New DevExpress.XtraEditors.TextEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.Chat = New DevExpress.XtraEditors.MemoEdit()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType(Me.Message.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Port.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Server.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Chat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LayoutControl1
            '
            Me.layoutControl.Controls.Add(Me.Chat)
            Me.layoutControl.Controls.Add(Me.btn_Connect)
            Me.layoutControl.Controls.Add(Me.btn_Send)
            Me.layoutControl.Controls.Add(Me.Message)
            Me.layoutControl.Controls.Add(Me.ComboBoxEdit1)
            Me.layoutControl.Controls.Add(Me.Port)
            Me.layoutControl.Controls.Add(Me.Server)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "LayoutControl1"
            Me.layoutControl.Root = Me.Root
            Me.layoutControl.Size = New System.Drawing.Size(300, 400)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "LayoutControl1"
            '
            'btn_Connect
            '
            Me.btn_Connect.ImageOptions.Image = CType(resources.GetObject("btn_Connect.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Connect.Location = New System.Drawing.Point(191, 36)
            Me.btn_Connect.Name = "btn_Connect"
            Me.btn_Connect.Size = New System.Drawing.Size(97, 22)
            Me.btn_Connect.StyleController = Me.layoutControl
            Me.btn_Connect.TabIndex = 3
            Me.btn_Connect.Text = "Connect"
            '
            'btn_Send
            '
            Me.btn_Send.ImageOptions.Image = CType(resources.GetObject("btn_Send.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Send.Location = New System.Drawing.Point(216, 366)
            Me.btn_Send.Name = "btn_Send"
            Me.btn_Send.Size = New System.Drawing.Size(72, 22)
            Me.btn_Send.StyleController = Me.layoutControl
            Me.btn_Send.TabIndex = 6
            Me.btn_Send.Text = "Send"
            '
            'Message
            '
            Me.Message.Location = New System.Drawing.Point(12, 366)
            Me.Message.Name = "Message"
            Me.Message.Size = New System.Drawing.Size(200, 20)
            Me.Message.StyleController = Me.layoutControl
            Me.Message.TabIndex = 5
            '
            'ComboBoxEdit1
            '
            Me.ComboBoxEdit1.Location = New System.Drawing.Point(46, 36)
            Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
            Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.ComboBoxEdit1.Size = New System.Drawing.Size(141, 20)
            Me.ComboBoxEdit1.StyleController = Me.layoutControl
            Me.ComboBoxEdit1.TabIndex = 2
            '
            'Port
            '
            Me.Port.EditValue = ""
            Me.Port.Location = New System.Drawing.Point(225, 12)
            Me.Port.Name = "Port"
            Me.Port.Size = New System.Drawing.Size(63, 20)
            Me.Port.StyleController = Me.layoutControl
            Me.Port.TabIndex = 1
            '
            'Server
            '
            Me.Server.EditValue = ""
            Me.Server.Location = New System.Drawing.Point(46, 12)
            Me.Server.Name = "Server"
            Me.Server.Size = New System.Drawing.Size(141, 20)
            Me.Server.StyleController = Me.layoutControl
            Me.Server.TabIndex = 0
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem2, Me.LayoutControlItem7, Me.LayoutControlItem4})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(300, 400)
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.Server
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(179, 24)
            Me.LayoutControlItem1.Text = "Server"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(31, 13)
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.ComboBoxEdit1
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 24)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(179, 26)
            Me.LayoutControlItem3.Text = "Room"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(31, 13)
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Message
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 354)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(204, 26)
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem5.TextVisible = False
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.btn_Send
            Me.LayoutControlItem6.Location = New System.Drawing.Point(204, 354)
            Me.LayoutControlItem6.MaxSize = New System.Drawing.Size(76, 26)
            Me.LayoutControlItem6.MinSize = New System.Drawing.Size(76, 26)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(76, 26)
            Me.LayoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem6.TextVisible = False
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Port
            Me.LayoutControlItem2.Location = New System.Drawing.Point(179, 0)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(101, 24)
            Me.LayoutControlItem2.Text = "Port"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(31, 13)
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.btn_Connect
            Me.LayoutControlItem7.Location = New System.Drawing.Point(179, 24)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(101, 26)
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem7.TextVisible = False
            '
            'Chat
            '
            Me.Chat.Location = New System.Drawing.Point(46, 62)
            Me.Chat.Name = "Chat"
            Me.Chat.Size = New System.Drawing.Size(242, 300)
            Me.Chat.StyleController = Me.layoutControl
            Me.Chat.TabIndex = 4
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Chat
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 50)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(280, 304)
            Me.LayoutControlItem4.Text = "Chat"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(31, 13)
            '
            'xuc_Chat
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "xuc_Chat"
            Me.Size = New System.Drawing.Size(300, 400)
            CType(Me.layoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType(Me.Message.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ComboBoxEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Port.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Server.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Chat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents layoutControl As DevExpress.XtraLayout.LayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents Server As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Port As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents btn_Send As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents Message As DevExpress.XtraEditors.TextEdit
        Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents btn_Connect As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents Chat As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace