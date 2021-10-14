<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_AgentOutletMgmt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_AgentOutletMgmt))
        Me.lvAgent = New System.Windows.Forms.ListView()
        Me.agentCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.agentName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.InfoOutletType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.agentAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.officerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.accountExecutive = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_brCode = New System.Windows.Forms.TextBox()
        Me.txt_SellerAddress = New System.Windows.Forms.TextBox()
        Me.txt_AgentName = New System.Windows.Forms.TextBox()
        Me.txt_AgentCode = New System.Windows.Forms.TextBox()
        Me.cmb_Branch = New System.Windows.Forms.ComboBox()
        Me.cmb_SellerType = New System.Windows.Forms.ComboBox()
        Me.toolNew = New System.Windows.Forms.ToolStripButton()
        Me.toolregister = New System.Windows.Forms.ToolStripButton()
        Me.toolFind = New System.Windows.Forms.ToolStripButton()
        Me.toolmodify = New System.Windows.Forms.ToolStripButton()
        Me.toolDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvAgent
        '
        Me.lvAgent.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.agentCode, Me.agentName, Me.InfoOutletType, Me.agentAddress})
        Me.lvAgent.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvAgent.FullRowSelect = True
        Me.lvAgent.GridLines = True
        Me.lvAgent.Location = New System.Drawing.Point(17, 197)
        Me.lvAgent.Margin = New System.Windows.Forms.Padding(4)
        Me.lvAgent.Name = "lvAgent"
        Me.lvAgent.Size = New System.Drawing.Size(864, 282)
        Me.lvAgent.TabIndex = 1
        Me.lvAgent.UseCompatibleStateImageBehavior = False
        Me.lvAgent.View = System.Windows.Forms.View.Details
        '
        'agentCode
        '
        Me.agentCode.Text = "Agent Code"
        Me.agentCode.Width = 121
        '
        'agentName
        '
        Me.agentName.Text = "Agent Name"
        Me.agentName.Width = 251
        '
        'InfoOutletType
        '
        Me.InfoOutletType.Text = "Info Outlet Type"
        Me.InfoOutletType.Width = 188
        '
        'agentAddress
        '
        Me.agentAddress.Text = "Agent Address"
        Me.agentAddress.Width = 290
        '
        'officerName
        '
        Me.officerName.Text = "Full Name"
        Me.officerName.Width = 413
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(693, 73)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 19)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Ex. 00101"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 168)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 19)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "AGENT ADDRESS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(9, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "INFO OUTLET TYPE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 19)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "AGENT NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "AGENT CODE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(693, 104)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 19)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "First M.I Last"
        '
        'accountExecutive
        '
        Me.accountExecutive.Text = "Account Executive"
        Me.accountExecutive.Width = 235
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolNew, Me.toolregister, Me.toolFind, Me.toolmodify, Me.toolDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(897, 25)
        Me.ToolStrip1.TabIndex = 26
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 19)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "BRANCH CODE"
        '
        'txt_brCode
        '
        Me.txt_brCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_brCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brCode.Location = New System.Drawing.Point(719, 36)
        Me.txt_brCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_brCode.Name = "txt_brCode"
        Me.txt_brCode.ReadOnly = True
        Me.txt_brCode.Size = New System.Drawing.Size(161, 27)
        Me.txt_brCode.TabIndex = 24
        '
        'txt_SellerAddress
        '
        Me.txt_SellerAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SellerAddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SellerAddress.Location = New System.Drawing.Point(243, 163)
        Me.txt_SellerAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_SellerAddress.Name = "txt_SellerAddress"
        Me.txt_SellerAddress.Size = New System.Drawing.Size(637, 27)
        Me.txt_SellerAddress.TabIndex = 22
        '
        'txt_AgentName
        '
        Me.txt_AgentName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_AgentName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AgentName.Location = New System.Drawing.Point(243, 99)
        Me.txt_AgentName.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_AgentName.Name = "txt_AgentName"
        Me.txt_AgentName.Size = New System.Drawing.Size(441, 27)
        Me.txt_AgentName.TabIndex = 20
        '
        'txt_AgentCode
        '
        Me.txt_AgentCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_AgentCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AgentCode.Location = New System.Drawing.Point(243, 69)
        Me.txt_AgentCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_AgentCode.MaxLength = 5
        Me.txt_AgentCode.Name = "txt_AgentCode"
        Me.txt_AgentCode.Size = New System.Drawing.Size(441, 27)
        Me.txt_AgentCode.TabIndex = 19
        Me.txt_AgentCode.WordWrap = False
        '
        'cmb_Branch
        '
        Me.cmb_Branch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Branch.FormattingEnabled = True
        Me.cmb_Branch.Location = New System.Drawing.Point(243, 36)
        Me.cmb_Branch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Branch.Name = "cmb_Branch"
        Me.cmb_Branch.Size = New System.Drawing.Size(441, 27)
        Me.cmb_Branch.TabIndex = 18
        '
        'cmb_SellerType
        '
        Me.cmb_SellerType.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_SellerType.FormattingEnabled = True
        Me.cmb_SellerType.Location = New System.Drawing.Point(243, 130)
        Me.cmb_SellerType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_SellerType.Name = "cmb_SellerType"
        Me.cmb_SellerType.Size = New System.Drawing.Size(637, 27)
        Me.cmb_SellerType.TabIndex = 34
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
        Me.toolmodify.Image = CType(resources.GetObject("toolmodify.Image"), System.Drawing.Image)
        Me.toolmodify.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolmodify.Name = "toolmodify"
        Me.toolmodify.Size = New System.Drawing.Size(23, 22)
        Me.toolmodify.Text = "UPDATE"
        '
        'toolDelete
        '
        Me.toolDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolDelete.Image = CType(resources.GetObject("toolDelete.Image"), System.Drawing.Image)
        Me.toolDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolDelete.Name = "toolDelete"
        Me.toolDelete.Size = New System.Drawing.Size(23, 22)
        Me.toolDelete.Text = "DELETE"
        '
        'Admin_AgentOutletMgmt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(897, 498)
        Me.Controls.Add(Me.cmb_SellerType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_brCode)
        Me.Controls.Add(Me.txt_SellerAddress)
        Me.Controls.Add(Me.txt_AgentName)
        Me.Controls.Add(Me.txt_AgentCode)
        Me.Controls.Add(Me.cmb_Branch)
        Me.Controls.Add(Me.lvAgent)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Admin_AgentOutletMgmt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESELLER MANAGEMENT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvAgent As System.Windows.Forms.ListView
    Friend WithEvents agentCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents agentName As System.Windows.Forms.ColumnHeader
    Friend WithEvents InfoOutletType As System.Windows.Forms.ColumnHeader
    Friend WithEvents agentAddress As System.Windows.Forms.ColumnHeader
    Friend WithEvents officerName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents toolFind As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents toolmodify As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents toolregister As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents accountExecutive As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_brCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_SellerAddress As System.Windows.Forms.TextBox
    Friend WithEvents txt_AgentName As System.Windows.Forms.TextBox
    Friend WithEvents txt_AgentCode As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Branch As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_SellerType As System.Windows.Forms.ComboBox
End Class
