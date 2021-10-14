<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_BroadcastMsg
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides sub Dispose(ByVal disposing As Boolean)
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
    private sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_BroadcastMsg))
        Me.txt_BroadCast = New System.Windows.Forms.TextBox()
        Me.cmd_broadcast = New System.Windows.Forms.Button()
        Me.txt_ConStatus = New System.Windows.Forms.Label()
        Me.cmd_connectBroadCast = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_BroadCast
        '
        Me.txt_BroadCast.Location = New System.Drawing.Point(3, 46)
        Me.txt_BroadCast.Multiline = True
        Me.txt_BroadCast.Name = "txt_BroadCast"
        Me.txt_BroadCast.Size = New System.Drawing.Size(526, 114)
        Me.txt_BroadCast.TabIndex = 0
        '
        'cmd_broadcast
        '
        Me.cmd_broadcast.BackColor = System.Drawing.Color.Orange
        Me.cmd_broadcast.BackgroundImage = CType(resources.GetObject("cmd_broadcast.BackgroundImage"), System.Drawing.Image)
        Me.cmd_broadcast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmd_broadcast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_broadcast.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_broadcast.ForeColor = System.Drawing.Color.Blue
        Me.cmd_broadcast.Location = New System.Drawing.Point(535, 45)
        Me.cmd_broadcast.Name = "cmd_broadcast"
        Me.cmd_broadcast.Size = New System.Drawing.Size(124, 114)
        Me.cmd_broadcast.TabIndex = 1
        Me.cmd_broadcast.Text = "SEND"
        Me.cmd_broadcast.UseVisualStyleBackColor = False
        '
        'txt_ConStatus
        '
        Me.txt_ConStatus.BackColor = System.Drawing.Color.Red
        Me.txt_ConStatus.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ConStatus.ForeColor = System.Drawing.Color.White
        Me.txt_ConStatus.Location = New System.Drawing.Point(12, 7)
        Me.txt_ConStatus.Name = "txt_ConStatus"
        Me.txt_ConStatus.Size = New System.Drawing.Size(104, 33)
        Me.txt_ConStatus.TabIndex = 3
        Me.txt_ConStatus.Text = "OFFLINE"
        Me.txt_ConStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmd_connectBroadCast
        '
        Me.cmd_connectBroadCast.BackColor = System.Drawing.SystemColors.Desktop
        Me.cmd_connectBroadCast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_connectBroadCast.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cmd_connectBroadCast.Location = New System.Drawing.Point(122, 6)
        Me.cmd_connectBroadCast.Name = "cmd_connectBroadCast"
        Me.cmd_connectBroadCast.Size = New System.Drawing.Size(124, 35)
        Me.cmd_connectBroadCast.TabIndex = 4
        Me.cmd_connectBroadCast.Text = "Connect"
        Me.cmd_connectBroadCast.UseVisualStyleBackColor = False
        '
        'Admin_BroadcastMsg
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 168)
        Me.Controls.Add(Me.cmd_connectBroadCast)
        Me.Controls.Add(Me.txt_ConStatus)
        Me.Controls.Add(Me.cmd_broadcast)
        Me.Controls.Add(Me.txt_BroadCast)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin_BroadcastMsg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BROADCAST"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_BroadCast As TextBox
    Friend WithEvents cmd_broadcast As Button
    Friend WithEvents txt_ConStatus As Label
    Friend WithEvents cmd_connectBroadCast As Button
End Class
