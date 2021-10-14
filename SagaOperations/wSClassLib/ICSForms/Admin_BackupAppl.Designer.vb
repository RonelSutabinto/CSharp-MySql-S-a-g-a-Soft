<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_BackupAppl
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_BackupAppl))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Btn_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.Btn_Execute = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.txt_URL = New DevExpress.XtraEditors.TextEdit()
        Me.txt_UpdateURL = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Fileversion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_changeLog = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TMandatory = New DevExpress.XtraEditors.ToggleSwitch()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_buildNo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_Appname = New DevExpress.XtraEditors.TextEdit()
        Me.tInclLib = New DevExpress.XtraEditors.ToggleSwitch()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cInclApp = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_LocPath = New DevExpress.XtraEditors.TextEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_URL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Fileversion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_changeLog.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TMandatory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_buildNo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Appname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tInclLib.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cInclApp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_LocPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.Btn_Save, Me.Btn_Execute})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.Btn_Save, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.Btn_Execute, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'Btn_Save
        '
        Me.Btn_Save.Caption = "Save"
        Me.Btn_Save.Id = 0
        Me.Btn_Save.Name = "Btn_Save"
        '
        'Btn_Execute
        '
        Me.Btn_Execute.Caption = "Execute"
        Me.Btn_Execute.Id = 1
        Me.Btn_Execute.Name = "Btn_Execute"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(784, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 561)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(784, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 537)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(784, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 537)
        '
        'txt_URL
        '
        Me.txt_URL.Location = New System.Drawing.Point(136, 42)
        Me.txt_URL.MenuManager = Me.BarManager1
        Me.txt_URL.Name = "txt_URL"
        Me.txt_URL.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_URL.Properties.Appearance.Options.UseFont = True
        Me.txt_URL.Size = New System.Drawing.Size(421, 22)
        Me.txt_URL.TabIndex = 4
        '
        'txt_UpdateURL
        '
        Me.txt_UpdateURL.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_UpdateURL.Appearance.Options.UseFont = True
        Me.txt_UpdateURL.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_UpdateURL.Location = New System.Drawing.Point(10, 45)
        Me.txt_UpdateURL.Name = "txt_UpdateURL"
        Me.txt_UpdateURL.Size = New System.Drawing.Size(77, 18)
        Me.txt_UpdateURL.TabIndex = 5
        Me.txt_UpdateURL.Text = "Update URL"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(10, 95)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(77, 18)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "File Version"
        '
        'txt_Fileversion
        '
        Me.txt_Fileversion.Location = New System.Drawing.Point(136, 91)
        Me.txt_Fileversion.MenuManager = Me.BarManager1
        Me.txt_Fileversion.Name = "txt_Fileversion"
        Me.txt_Fileversion.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Fileversion.Properties.Appearance.Options.UseFont = True
        Me.txt_Fileversion.Size = New System.Drawing.Size(196, 22)
        Me.txt_Fileversion.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(10, 119)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 18)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "ChangeLog"
        '
        'txt_changeLog
        '
        Me.txt_changeLog.Location = New System.Drawing.Point(136, 116)
        Me.txt_changeLog.MenuManager = Me.BarManager1
        Me.txt_changeLog.Name = "txt_changeLog"
        Me.txt_changeLog.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_changeLog.Properties.Appearance.Options.UseFont = True
        Me.txt_changeLog.Size = New System.Drawing.Size(196, 22)
        Me.txt_changeLog.TabIndex = 8
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(10, 150)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(77, 18)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Mandatory"
        '
        'TMandatory
        '
        Me.TMandatory.EditValue = True
        Me.TMandatory.Location = New System.Drawing.Point(136, 141)
        Me.TMandatory.MenuManager = Me.BarManager1
        Me.TMandatory.Name = "TMandatory"
        Me.TMandatory.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TMandatory.Properties.Appearance.Options.UseFont = True
        Me.TMandatory.Properties.OffText = "Off"
        Me.TMandatory.Properties.OnText = "On"
        Me.TMandatory.Size = New System.Drawing.Size(153, 26)
        Me.TMandatory.TabIndex = 12
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(351, 92)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 18)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Build"
        '
        'txt_buildNo
        '
        Me.txt_buildNo.Location = New System.Drawing.Point(404, 91)
        Me.txt_buildNo.MenuManager = Me.BarManager1
        Me.txt_buildNo.Name = "txt_buildNo"
        Me.txt_buildNo.Size = New System.Drawing.Size(153, 22)
        Me.txt_buildNo.TabIndex = 17
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.Location = New System.Drawing.Point(10, 69)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(119, 18)
        Me.LabelControl5.TabIndex = 20
        Me.LabelControl5.Text = "Application Name"
        '
        'txt_Appname
        '
        Me.txt_Appname.Location = New System.Drawing.Point(136, 66)
        Me.txt_Appname.MenuManager = Me.BarManager1
        Me.txt_Appname.Name = "txt_Appname"
        Me.txt_Appname.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Appname.Properties.Appearance.Options.UseFont = True
        Me.txt_Appname.Size = New System.Drawing.Size(196, 22)
        Me.txt_Appname.TabIndex = 19
        '
        'tInclLib
        '
        Me.tInclLib.Location = New System.Drawing.Point(136, 234)
        Me.tInclLib.MenuManager = Me.BarManager1
        Me.tInclLib.Name = "tInclLib"
        Me.tInclLib.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tInclLib.Properties.Appearance.Options.UseFont = True
        Me.tInclLib.Properties.OffText = "Off"
        Me.tInclLib.Properties.OnText = "On"
        Me.tInclLib.Size = New System.Drawing.Size(124, 26)
        Me.tInclLib.TabIndex = 26
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(10, 237)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(108, 24)
        Me.LabelControl6.TabIndex = 25
        Me.LabelControl6.Text = "Include Libraries"
        '
        'cInclApp
        '
        Me.cInclApp.Location = New System.Drawing.Point(10, 209)
        Me.cInclApp.MenuManager = Me.BarManager1
        Me.cInclApp.Name = "cInclApp"
        Me.cInclApp.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cInclApp.Properties.Appearance.Options.UseFont = True
        Me.cInclApp.Properties.Caption = "Create Patch File"
        Me.cInclApp.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.cInclApp.Size = New System.Drawing.Size(142, 19)
        Me.cInclApp.TabIndex = 28
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Location = New System.Drawing.Point(10, 294)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(77, 18)
        Me.LabelControl7.TabIndex = 30
        Me.LabelControl7.Text = "File Path"
        '
        'txt_LocPath
        '
        Me.txt_LocPath.Location = New System.Drawing.Point(136, 291)
        Me.txt_LocPath.MenuManager = Me.BarManager1
        Me.txt_LocPath.Name = "txt_LocPath"
        Me.txt_LocPath.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LocPath.Properties.Appearance.Options.UseFont = True
        Me.txt_LocPath.Size = New System.Drawing.Size(421, 22)
        Me.txt_LocPath.TabIndex = 29
        '
        'Admin_BackupAppl
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txt_LocPath)
        Me.Controls.Add(Me.cInclApp)
        Me.Controls.Add(Me.tInclLib)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_Appname)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_buildNo)
        Me.Controls.Add(Me.TMandatory)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_changeLog)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_Fileversion)
        Me.Controls.Add(Me.txt_UpdateURL)
        Me.Controls.Add(Me.txt_URL)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("Admin_BackupAppl.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin_BackupAppl"
        Me.Text = "File Version Update - Server"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_URL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Fileversion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_changeLog.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TMandatory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_buildNo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Appname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tInclLib.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cInclApp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_LocPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Btn_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Btn_Execute As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents TMandatory As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_changeLog As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Fileversion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_UpdateURL As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_URL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_buildNo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_Appname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cInclApp As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tInclLib As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_LocPath As DevExpress.XtraEditors.TextEdit
End Class
