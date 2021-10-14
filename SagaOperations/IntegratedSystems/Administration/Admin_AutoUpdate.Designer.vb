<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_AutoUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_AutoUpdate))
        Me.cmd_autoupdateM1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmd_autoupdateM2 = New System.Windows.Forms.Button()
        Me.cmd_updateMirror3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmd_autoupdateM1
        '
        Me.cmd_autoupdateM1.Location = New System.Drawing.Point(16, 127)
        Me.cmd_autoupdateM1.Name = "cmd_autoupdateM1"
        Me.cmd_autoupdateM1.Size = New System.Drawing.Size(92, 39)
        Me.cmd_autoupdateM1.TabIndex = 0
        Me.cmd_autoupdateM1.Text = "MIRROR 1"
        Me.cmd_autoupdateM1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(432, 242)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(40, 20)
        Me.WebBrowser1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "For new update please save it to:"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(460, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "C:\Program Files (x86)\webSources\Integrated Management Information System"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(24, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "OR"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(12, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(460, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "C:\Program Files\webSources\Integrated Management Information System"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(231, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "HOW TO:"
        '
        'cmd_autoupdateM2
        '
        Me.cmd_autoupdateM2.Location = New System.Drawing.Point(179, 127)
        Me.cmd_autoupdateM2.Name = "cmd_autoupdateM2"
        Me.cmd_autoupdateM2.Size = New System.Drawing.Size(92, 39)
        Me.cmd_autoupdateM2.TabIndex = 7
        Me.cmd_autoupdateM2.Text = "MIRROR 2"
        Me.cmd_autoupdateM2.UseVisualStyleBackColor = True
        '
        'cmd_updateMirror3
        '
        Me.cmd_updateMirror3.Location = New System.Drawing.Point(343, 127)
        Me.cmd_updateMirror3.Name = "cmd_updateMirror3"
        Me.cmd_updateMirror3.Size = New System.Drawing.Size(92, 39)
        Me.cmd_updateMirror3.TabIndex = 8
        Me.cmd_updateMirror3.Text = "MIRROR 3"
        Me.cmd_updateMirror3.UseVisualStyleBackColor = True
        '
        'Admin_AutoUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(464, 184)
        Me.Controls.Add(Me.cmd_updateMirror3)
        Me.Controls.Add(Me.cmd_autoupdateM2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.cmd_autoupdateM1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin_AutoUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AUTO UPDATE"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_autoupdateM1 As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmd_autoupdateM2 As System.Windows.Forms.Button
    Friend WithEvents cmd_updateMirror3 As Button
End Class
