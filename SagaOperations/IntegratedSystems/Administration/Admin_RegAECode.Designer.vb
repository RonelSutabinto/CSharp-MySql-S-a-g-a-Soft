<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_RegAECode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_RegAECode))
        Me.lvShowAE = New System.Windows.Forms.ListView()
        Me.officerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.accountExecutive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmb_Branch = New System.Windows.Forms.ComboBox()
        Me.txt_aecode = New System.Windows.Forms.TextBox()
        Me.txt_aeName = New System.Windows.Forms.TextBox()
        Me.txt_Supervisor = New System.Windows.Forms.TextBox()
        Me.txt_shortName = New System.Windows.Forms.TextBox()
        Me.txt_SupervisorName = New System.Windows.Forms.TextBox()
        Me.txt_brCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.toolNew = New System.Windows.Forms.ToolStripButton()
        Me.toolregister = New System.Windows.Forms.ToolStripButton()
        Me.toolFind = New System.Windows.Forms.ToolStripButton()
        Me.toolmodify = New System.Windows.Forms.ToolStripButton()
        Me.toolDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvShowAE
        '
        Me.lvShowAE.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.officerName, Me.accountExecutive})
        Me.lvShowAE.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvShowAE.FullRowSelect = True
        Me.lvShowAE.GridLines = True
        Me.lvShowAE.Location = New System.Drawing.Point(12, 260)
        Me.lvShowAE.Name = "lvShowAE"
        Me.lvShowAE.Size = New System.Drawing.Size(654, 258)
        Me.lvShowAE.TabIndex = 1
        Me.lvShowAE.UseCompatibleStateImageBehavior = False
        Me.lvShowAE.View = System.Windows.Forms.View.Details
        '
        'officerName
        '
        Me.officerName.Text = "Full Name"
        Me.officerName.Width = 413
        '
        'accountExecutive
        '
        Me.accountExecutive.Text = "Account Executive Code"
        Me.accountExecutive.Width = 235
        '
        'cmb_Branch
        '
        Me.cmb_Branch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Branch.FormattingEnabled = True
        Me.cmb_Branch.Location = New System.Drawing.Point(187, 41)
        Me.cmb_Branch.Name = "cmb_Branch"
        Me.cmb_Branch.Size = New System.Drawing.Size(332, 27)
        Me.cmb_Branch.TabIndex = 2
        '
        'txt_aecode
        '
        Me.txt_aecode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_aecode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_aecode.Location = New System.Drawing.Point(187, 75)
        Me.txt_aecode.MaxLength = 7
        Me.txt_aecode.Name = "txt_aecode"
        Me.txt_aecode.Size = New System.Drawing.Size(332, 27)
        Me.txt_aecode.TabIndex = 3
        '
        'txt_aeName
        '
        Me.txt_aeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_aeName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_aeName.Location = New System.Drawing.Point(187, 107)
        Me.txt_aeName.Name = "txt_aeName"
        Me.txt_aeName.Size = New System.Drawing.Size(332, 27)
        Me.txt_aeName.TabIndex = 4
        '
        'txt_Supervisor
        '
        Me.txt_Supervisor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Supervisor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Supervisor.Location = New System.Drawing.Point(187, 178)
        Me.txt_Supervisor.Name = "txt_Supervisor"
        Me.txt_Supervisor.Size = New System.Drawing.Size(479, 27)
        Me.txt_Supervisor.TabIndex = 6
        '
        'txt_shortName
        '
        Me.txt_shortName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_shortName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shortName.Location = New System.Drawing.Point(187, 139)
        Me.txt_shortName.Name = "txt_shortName"
        Me.txt_shortName.Size = New System.Drawing.Size(479, 27)
        Me.txt_shortName.TabIndex = 5
        '
        'txt_SupervisorName
        '
        Me.txt_SupervisorName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SupervisorName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SupervisorName.Location = New System.Drawing.Point(187, 216)
        Me.txt_SupervisorName.Name = "txt_SupervisorName"
        Me.txt_SupervisorName.Size = New System.Drawing.Size(479, 27)
        Me.txt_SupervisorName.TabIndex = 7
        '
        'txt_brCode
        '
        Me.txt_brCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brCode.Location = New System.Drawing.Point(544, 41)
        Me.txt_brCode.Name = "txt_brCode"
        Me.txt_brCode.ReadOnly = True
        Me.txt_brCode.Size = New System.Drawing.Size(122, 27)
        Me.txt_brCode.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "BRANCH CODE"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolNew, Me.toolregister, Me.toolFind, Me.toolmodify, Me.toolDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(680, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "AE CODE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "AE NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "SHORT NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "SUPERVISOR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "SUPERVISOR NAME"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(525, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Ex. 0010001"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(525, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Last, First, M.I"
        '
        'toolNew
        '
        Me.toolNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolNew.Image = CType(resources.GetObject("toolNew.Image"), System.Drawing.Image)
        Me.toolNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolNew.Name = "toolNew"
        Me.toolNew.Size = New System.Drawing.Size(23, 22)
        Me.toolNew.Text = "NEW"
        '
        'toolregister
        '
        Me.toolregister.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolregister.Enabled = False
        Me.toolregister.Image = CType(resources.GetObject("toolregister.Image"), System.Drawing.Image)
        Me.toolregister.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolregister.Name = "toolregister"
        Me.toolregister.Size = New System.Drawing.Size(23, 22)
        Me.toolregister.Text = "SAVE"
        '
        'toolFind
        '
        Me.toolFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolFind.Image = CType(resources.GetObject("toolFind.Image"), System.Drawing.Image)
        Me.toolFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolFind.Name = "toolFind"
        Me.toolFind.Size = New System.Drawing.Size(23, 22)
        Me.toolFind.Text = "FIND"
        '
        'toolmodify
        '
        Me.toolmodify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolmodify.Enabled = False
        Me.toolmodify.Image = CType(resources.GetObject("toolmodify.Image"), System.Drawing.Image)
        Me.toolmodify.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolmodify.Name = "toolmodify"
        Me.toolmodify.Size = New System.Drawing.Size(23, 22)
        Me.toolmodify.Text = "UPDATE"
        '
        'toolDelete
        '
        Me.toolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolDelete.Enabled = False
        Me.toolDelete.Image = CType(resources.GetObject("toolDelete.Image"), System.Drawing.Image)
        Me.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolDelete.Name = "toolDelete"
        Me.toolDelete.Size = New System.Drawing.Size(23, 22)
        Me.toolDelete.Text = "DELETE"
        '
        'Admin_RegAECode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(680, 530)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_brCode)
        Me.Controls.Add(Me.txt_SupervisorName)
        Me.Controls.Add(Me.txt_Supervisor)
        Me.Controls.Add(Me.txt_shortName)
        Me.Controls.Add(Me.txt_aeName)
        Me.Controls.Add(Me.txt_aecode)
        Me.Controls.Add(Me.cmb_Branch)
        Me.Controls.Add(Me.lvShowAE)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Admin_RegAECode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCOUNT EXECUTIVE MANAGEMENT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvShowAE As System.Windows.Forms.ListView
    Friend WithEvents officerName As System.Windows.Forms.ColumnHeader
    Friend WithEvents accountExecutive As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmb_Branch As System.Windows.Forms.ComboBox
    Friend WithEvents txt_aecode As System.Windows.Forms.TextBox
    Friend WithEvents txt_aeName As System.Windows.Forms.TextBox
    Friend WithEvents txt_Supervisor As System.Windows.Forms.TextBox
    Friend WithEvents txt_shortName As System.Windows.Forms.TextBox
    Friend WithEvents txt_SupervisorName As System.Windows.Forms.TextBox
    Friend WithEvents txt_brCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolregister As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolmodify As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
