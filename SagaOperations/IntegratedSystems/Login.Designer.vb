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
    Friend WithEvents UsernameLabel As LabelControl
    Friend WithEvents PasswordLabel As LabelControl
    Friend WithEvents OK As SimpleButton
    Friend WithEvents Cancel As SimpleButton

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.UsernameLabel = New DevExpress.XtraEditors.LabelControl()
        Me.PasswordLabel = New DevExpress.XtraEditors.LabelControl()
        Me.OK = New DevExpress.XtraEditors.SimpleButton()
        Me.Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.curversion = New System.Windows.Forms.TextBox()
        Me.serverStatus = New DevExpress.XtraEditors.LabelControl()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label5 = New DevExpress.XtraEditors.LabelControl()
        Me.Label4 = New DevExpress.XtraEditors.LabelControl()
        Me.Application_Version = New DevExpress.XtraEditors.LabelControl()
        Me.Pass_Word = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New DevExpress.XtraEditors.LabelControl()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.FormAssistant1 = New DevExpress.XtraBars.FormAssistant()
        Me.ipaddress = New DevExpress.XtraEditors.LabelControl()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Configuration_Settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HELPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CHECKFORUPDATESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.User_Name = New DevExpress.XtraEditors.TextEdit()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit()
        Me.Panel1.SuspendLayout()
        CType(Me.Pass_Word.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.User_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.UsernameLabel.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Appearance.Options.UseBackColor = True
        Me.UsernameLabel.Appearance.Options.UseFont = True
        Me.UsernameLabel.Location = New System.Drawing.Point(801, 278)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(52, 14)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PasswordLabel.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Appearance.Options.UseBackColor = True
        Me.PasswordLabel.Appearance.Options.UseFont = True
        Me.PasswordLabel.Location = New System.Drawing.Point(723, 353)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(50, 14)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(56, 124)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(256, 37)
        Me.OK.TabIndex = 2
        Me.OK.Text = "&LOGIN"
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(740, 440)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(110, 22)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancel"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.curversion)
        Me.Panel1.Controls.Add(Me.serverStatus)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(656, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 291)
        Me.Panel1.TabIndex = 12
        '
        'curversion
        '
        Me.curversion.Location = New System.Drawing.Point(312, 266)
        Me.curversion.Name = "curversion"
        Me.curversion.Size = New System.Drawing.Size(100, 23)
        Me.curversion.TabIndex = 22
        '
        'serverStatus
        '
        Me.serverStatus.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serverStatus.Appearance.ForeColor = System.Drawing.Color.Green
        Me.serverStatus.Appearance.Options.UseFont = True
        Me.serverStatus.Appearance.Options.UseForeColor = True
        Me.serverStatus.Location = New System.Drawing.Point(217, 246)
        Me.serverStatus.Name = "serverStatus"
        Me.serverStatus.Size = New System.Drawing.Size(55, 19)
        Me.serverStatus.TabIndex = 12
        Me.serverStatus.Text = "OFFLINE"
        Me.serverStatus.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape3})
        Me.ShapeContainer1.Size = New System.Drawing.Size(302, 291)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.Color.Silver
        Me.RectangleShape2.Location = New System.Drawing.Point(29, 133)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(238, 1)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderColor = System.Drawing.Color.Black
        Me.RectangleShape3.Location = New System.Drawing.Point(25, 99)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(249, 70)
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Appearance.Options.UseFont = True
        Me.Label5.Location = New System.Drawing.Point(13, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "IP Address"
        '
        'Label4
        '
        Me.Label4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Appearance.Options.UseFont = True
        Me.Label4.Location = New System.Drawing.Point(13, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Application"
        '
        'Application_Version
        '
        Me.Application_Version.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Application_Version.Appearance.Options.UseFont = True
        Me.Application_Version.Location = New System.Drawing.Point(104, 252)
        Me.Application_Version.Name = "Application_Version"
        Me.Application_Version.Size = New System.Drawing.Size(41, 13)
        Me.Application_Version.TabIndex = 10
        Me.Application_Version.Text = "0.0.0.0"
        '
        'Pass_Word
        '
        Me.Pass_Word.EditValue = ""
        Me.Pass_Word.Location = New System.Drawing.Point(56, 87)
        Me.Pass_Word.Name = "Pass_Word"
        Me.Pass_Word.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.Pass_Word.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pass_Word.Properties.Appearance.Options.UseBackColor = True
        Me.Pass_Word.Properties.Appearance.Options.UseFont = True
        Me.Pass_Word.Properties.Appearance.Options.UseTextOptions = True
        Me.Pass_Word.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Pass_Word.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Pass_Word.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Pass_Word.Size = New System.Drawing.Size(256, 30)
        Me.Pass_Word.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Appearance.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Appearance.Options.UseFont = True
        Me.Label1.Appearance.Options.UseForeColor = True
        Me.Label1.Location = New System.Drawing.Point(17, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MEMBER LOGIN"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(804, 160)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 23)
        Me.DateTimePicker1.TabIndex = 16
        '
        'ipaddress
        '
        Me.ipaddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ipaddress.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ipaddress.Appearance.Options.UseFont = True
        Me.ipaddress.Location = New System.Drawing.Point(104, 229)
        Me.ipaddress.Name = "ipaddress"
        Me.ipaddress.Size = New System.Drawing.Size(41, 13)
        Me.ipaddress.TabIndex = 22
        Me.ipaddress.Text = "0.0.0.0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Configuration_Settings, Me.ToolStripMenuItem1, Me.ABOUTToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 4)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(463, 30)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Configuration_Settings
        '
        Me.Configuration_Settings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Configuration_Settings.Name = "Configuration_Settings"
        Me.Configuration_Settings.Size = New System.Drawing.Size(69, 26)
        Me.Configuration_Settings.Text = "SETTINGS"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(25, 26)
        Me.ToolStripMenuItem1.Text = "|"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HELPToolStripMenuItem, Me.CHECKFORUPDATESToolStripMenuItem})
        Me.ABOUTToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(46, 26)
        Me.ABOUTToolStripMenuItem.Text = "HELP"
        Me.ABOUTToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'HELPToolStripMenuItem
        '
        Me.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem"
        Me.HELPToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.HELPToolStripMenuItem.Text = "ABOUT"
        '
        'CHECKFORUPDATESToolStripMenuItem
        '
        Me.CHECKFORUPDATESToolStripMenuItem.Name = "CHECKFORUPDATESToolStripMenuItem"
        Me.CHECKFORUPDATESToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CHECKFORUPDATESToolStripMenuItem.Text = "CHECK FOR UPDATES"
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.User_Name)
        Me.PanelControl1.Controls.Add(Me.Pass_Word)
        Me.PanelControl1.Controls.Add(Me.OK)
        Me.PanelControl1.Controls.Add(Me.PictureEdit2)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.PictureEdit1)
        Me.PanelControl1.Location = New System.Drawing.Point(141, 37)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(331, 179)
        Me.PanelControl1.TabIndex = 23
        '
        'User_Name
        '
        Me.User_Name.Location = New System.Drawing.Point(56, 54)
        Me.User_Name.Name = "User_Name"
        Me.User_Name.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.User_Name.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User_Name.Properties.Appearance.Options.UseBackColor = True
        Me.User_Name.Properties.Appearance.Options.UseFont = True
        Me.User_Name.Properties.Appearance.Options.UseTextOptions = True
        Me.User_Name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.User_Name.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.User_Name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.User_Name.Size = New System.Drawing.Size(256, 30)
        Me.User_Name.TabIndex = 0
        '
        'PictureEdit2
        '
        Me.PictureEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureEdit2.EditValue = Global.SagaOperations.My.Resources.Resources.loc2k
        Me.PictureEdit2.Location = New System.Drawing.Point(14, 86)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit2.Size = New System.Drawing.Size(33, 31)
        Me.PictureEdit2.TabIndex = 18
        '
        'PictureEdit1
        '
        Me.PictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureEdit1.EditValue = Global.SagaOperations.My.Resources.Resources.customers_32v32
        Me.PictureEdit1.Location = New System.Drawing.Point(14, 56)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(33, 28)
        Me.PictureEdit1.TabIndex = 13
        '
        'PictureEdit3
        '
        Me.PictureEdit3.EditValue = Global.SagaOperations.My.Resources.Resources.LOGO_SAGA_NEW
        Me.PictureEdit3.Location = New System.Drawing.Point(8, 37)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PictureEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit3.Size = New System.Drawing.Size(137, 179)
        Me.PictureEdit3.TabIndex = 24
        '
        'Login
        '
        Me.AcceptButton = Me.OK
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(462, 273)
        Me.Controls.Add(Me.PictureEdit3)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ipaddress)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Application_Version)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("Login.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(492, 328)
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN AREA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Pass_Word.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.User_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As LabelControl
    Friend WithEvents Pass_Word As TextEdit
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Application_Version As LabelControl
    Friend WithEvents serverStatus As LabelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents Label5 As LabelControl
    Friend WithEvents Label4 As LabelControl
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents RectangleShape2 As PowerPacks.RectangleShape
    Private WithEvents RectangleShape3 As PowerPacks.RectangleShape
    Friend WithEvents curversion As TextBox
    Friend WithEvents FormAssistant1 As DevExpress.XtraBars.FormAssistant
    Friend WithEvents ipaddress As LabelControl
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Configuration_Settings As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HELPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CHECKFORUPDATESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelControl1 As PanelControl
    'Friend WithEvents CachedInventoryList1 As CachedInventoryList
    Friend WithEvents PictureEdit1 As PictureEdit
    Friend WithEvents User_Name As TextEdit
    Friend WithEvents PictureEdit3 As PictureEdit
End Class
