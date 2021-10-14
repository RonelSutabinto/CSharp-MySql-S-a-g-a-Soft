Imports DevExpress.XtraEditors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class Login
    Inherits XtraForm

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

    Friend WithEvents OK_Login As SimpleButton
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    private sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.OK_Login = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Application_Version = New DevExpress.XtraEditors.LabelControl()
        Me.Pass_Word = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.IP_Address_Local = New DevExpress.XtraEditors.LabelControl()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Configuration_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKFORUPDATESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.User_Name = New DevExpress.XtraEditors.TextEdit()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit()
        Me.IP_Address_Internet = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.Pass_Word.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.User_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OK_Login
        '
        Me.OK_Login.Location = New System.Drawing.Point(297, 146)
        Me.OK_Login.Name = "OK_Login"
        Me.OK_Login.Size = New System.Drawing.Size(129, 36)
        Me.OK_Login.TabIndex = 5
        Me.OK_Login.Text = "LOGIN"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.Appearance.Options.UseFont = True
        Me.Label5.Location = New System.Drawing.Point(188, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "IP Address (Local)"
        '
        'Label4
        '
        Me.Label4.Appearance.Options.UseFont = True
        Me.Label4.Location = New System.Drawing.Point(188, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Application Version"
        '
        'Application_Version
        '
        Me.Application_Version.Appearance.Options.UseFont = True
        Me.Application_Version.Location = New System.Drawing.Point(297, 242)
        Me.Application_Version.Name = "Application_Version"
        Me.Application_Version.Size = New System.Drawing.Size(33, 13)
        Me.Application_Version.TabIndex = 8
        Me.Application_Version.Text = "0.0.0.0"
        '
        'Pass_Word
        '
        Me.Pass_Word.EditValue = ""
        Me.Pass_Word.Location = New System.Drawing.Point(226, 112)
        Me.Pass_Word.Name = "Pass_Word"
        Me.Pass_Word.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Pass_Word.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass_Word.Properties.Appearance.Options.UseBackColor = True
        Me.Pass_Word.Properties.Appearance.Options.UseFont = True
        Me.Pass_Word.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(10026)
        Me.Pass_Word.Size = New System.Drawing.Size(200, 28)
        Me.Pass_Word.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Appearance.Options.UseFont = True
        Me.Label1.Appearance.Options.UseForeColor = True
        Me.Label1.Location = New System.Drawing.Point(226, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MEMBER LOGIN"
        '
        'IP_Address_Local
        '
        Me.IP_Address_Local.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IP_Address_Local.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP_Address_Local.Appearance.Options.UseFont = True
        Me.IP_Address_Local.Location = New System.Drawing.Point(297, 202)
        Me.IP_Address_Local.Name = "IP_Address_Local"
        Me.IP_Address_Local.Size = New System.Drawing.Size(37, 15)
        Me.IP_Address_Local.TabIndex = 4
        Me.IP_Address_Local.Text = "0.0.0.0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Configuration_Settings, Me.ToolStripMenuItem1, Me.ABOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(10, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(529, 34)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Configuration_Settings
        '
        Me.Configuration_Settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Configuration_Settings.Name = "Configuration_Settings"
        Me.Configuration_Settings.Size = New System.Drawing.Size(69, 30)
        Me.Configuration_Settings.Text = "SETTINGS"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 30)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HELPToolStripMenuItem, Me.CHECKFORUPDATESToolStripMenuItem})
        Me.ABOUTToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(47, 30)
        Me.ABOUTToolStripMenuItem.Text = "HELP"
        Me.ABOUTToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.HELPToolStripMenuItem.Text = "ABOUT"
        '
        'CHECKFORUPDATESToolStripMenuItem
        '
        Me.CHECKFORUPDATESToolStripMenuItem.Name = "CHECKFORUPDATESToolStripMenuItem"
        Me.CHECKFORUPDATESToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.CHECKFORUPDATESToolStripMenuItem.Text = "CHECK FOR UPDATES"
        '
        'User_Name
        '
        Me.User_Name.Location = New System.Drawing.Point(226, 78)
        Me.User_Name.Name = "User_Name"
        Me.User_Name.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.User_Name.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_Name.Properties.Appearance.Options.UseBackColor = True
        Me.User_Name.Properties.Appearance.Options.UseFont = True
        Me.User_Name.Size = New System.Drawing.Size(200, 28)
        Me.User_Name.TabIndex = 2
        '
        'PictureEdit2
        '
        Me.PictureEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureEdit2.EditValue = CType(resources.GetObject("PictureEdit2.EditValue"), Object)
        Me.PictureEdit2.Location = New System.Drawing.Point(188, 108)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit2.Size = New System.Drawing.Size(32, 32)
        Me.PictureEdit2.TabIndex = 3
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(188, 74)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(32, 32)
        Me.PictureEdit1.TabIndex = 1
        '
        'PictureEdit3
        '
        Me.PictureEdit3.EditValue = CType(resources.GetObject("PictureEdit3.EditValue"), Object)
        Me.PictureEdit3.Location = New System.Drawing.Point(10, 51)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PictureEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit3.Size = New System.Drawing.Size(156, 205)
        Me.PictureEdit3.TabIndex = 1
        '
        'IP_Address_Internet
        '
        Me.IP_Address_Internet.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IP_Address_Internet.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IP_Address_Internet.Appearance.Options.UseFont = True
        Me.IP_Address_Internet.Location = New System.Drawing.Point(297, 221)
        Me.IP_Address_Internet.Name = "IP_Address_Internet"
        Me.IP_Address_Internet.Size = New System.Drawing.Size(37, 15)
        Me.IP_Address_Internet.TabIndex = 6
        Me.IP_Address_Internet.Text = "0.0.0.0"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(188, 223)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "IP Address (Internet)"
        '
        'Login
        '
        Me.AcceptButton = Me.OK_Login
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 268)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.User_Name)
        Me.Controls.Add(Me.IP_Address_Internet)
        Me.Controls.Add(Me.Pass_Word)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.OK_Login)
        Me.Controls.Add(Me.PictureEdit3)
        Me.Controls.Add(Me.PictureEdit2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.IP_Address_Local)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Application_Version)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("Login.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Login"
        Me.TopMost = True
        CType(Me.Pass_Word.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.User_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As LabelControl
    Friend WithEvents Pass_Word As TextEdit
    Friend WithEvents Application_Version As LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Label5 As LabelControl
    Friend WithEvents Label4 As LabelControl
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents IP_Address_Local As LabelControl
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Configuration_Settings As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKFORUPDATESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureEdit1 As PictureEdit
    Friend WithEvents User_Name As TextEdit
    Friend WithEvents PictureEdit3 As PictureEdit
    Friend WithEvents IP_Address_Internet As LabelControl
    Friend WithEvents LabelControl2 As LabelControl
End Class
