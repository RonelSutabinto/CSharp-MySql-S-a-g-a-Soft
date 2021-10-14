<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userConfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userConfig))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_oldpass = New System.Windows.Forms.TextBox()
        Me.txt_newpass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_re_newpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(37, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Password"
        '
        'txt_oldpass
        '
        Me.txt_oldpass.Location = New System.Drawing.Point(160, 51)
        Me.txt_oldpass.Name = "txt_oldpass"
        Me.txt_oldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_oldpass.Size = New System.Drawing.Size(137, 20)
        Me.txt_oldpass.TabIndex = 1
        '
        'txt_newpass
        '
        Me.txt_newpass.Location = New System.Drawing.Point(160, 76)
        Me.txt_newpass.Name = "txt_newpass"
        Me.txt_newpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_newpass.Size = New System.Drawing.Size(137, 20)
        Me.txt_newpass.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(37, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Password"
        '
        'txt_re_newpass
        '
        Me.txt_re_newpass.Location = New System.Drawing.Point(160, 101)
        Me.txt_re_newpass.Name = "txt_re_newpass"
        Me.txt_re_newpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_re_newpass.Size = New System.Drawing.Size(137, 20)
        Me.txt_re_newpass.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(37, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Retype New Password"
        '
        'btn_save
        '
        Me.btn_save.Image = CType(resources.GetObject("btn_save.Image"), System.Drawing.Image)
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(160, 127)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(137, 31)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "SAVE"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'userConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(323, 186)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_re_newpass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_newpass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_oldpass)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "userConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINISTRATION / USERCONFIG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_oldpass As System.Windows.Forms.TextBox
    Friend WithEvents txt_newpass As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_re_newpass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
End Class
