<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maint_ChangeApprover_Sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides sub Dispose(ByVal disposing As Boolean)
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
    private sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(maint_ChangeApprover_Sales))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.newtool = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolpostpayment = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_approver = New System.Windows.Forms.Label()
        Me.txt_approverFull = New System.Windows.Forms.Label()
        Me.LViewItems = New System.Windows.Forms.ListView()
        Me.BranchCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.full = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_newApprover = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(42, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 23)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "CURRENT APPROVER"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Teal
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newtool, Me.ToolStripSeparator2, Me.toolpostpayment, Me.ToolStripSeparator3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(503, 34)
        Me.ToolStrip1.TabIndex = 188
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'newtool
        '
        Me.newtool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.newtool.Image = CType(resources.GetObject("newtool.Image"), System.Drawing.Image)
        Me.newtool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.newtool.Name = "newtool"
        Me.newtool.Size = New System.Drawing.Size(23, 31)
        Me.newtool.Text = "ToolStripButton2"
        Me.newtool.ToolTipText = "NEW"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 34)
        '
        'toolpostpayment
        '
        Me.toolpostpayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolpostpayment.Image = CType(resources.GetObject("toolpostpayment.Image"), System.Drawing.Image)
        Me.toolpostpayment.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolpostpayment.Name = "toolpostpayment"
        Me.toolpostpayment.Size = New System.Drawing.Size(23, 31)
        Me.toolpostpayment.Text = "ToolStripButton1"
        Me.toolpostpayment.ToolTipText = "SAVE APPROVER"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 34)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 267)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "NEW APPROVER"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_approver
        '
        Me.txt_approver.BackColor = System.Drawing.Color.White
        Me.txt_approver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_approver.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_approver.ForeColor = System.Drawing.Color.Black
        Me.txt_approver.Location = New System.Drawing.Point(374, 56)
        Me.txt_approver.Name = "txt_approver"
        Me.txt_approver.Size = New System.Drawing.Size(108, 23)
        Me.txt_approver.TabIndex = 203
        Me.txt_approver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_approverFull
        '
        Me.txt_approverFull.BackColor = System.Drawing.Color.White
        Me.txt_approverFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_approverFull.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_approverFull.ForeColor = System.Drawing.Color.Black
        Me.txt_approverFull.Location = New System.Drawing.Point(175, 56)
        Me.txt_approverFull.Name = "txt_approverFull"
        Me.txt_approverFull.Size = New System.Drawing.Size(193, 23)
        Me.txt_approverFull.TabIndex = 204
        Me.txt_approverFull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LViewItems
        '
        Me.LViewItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BranchCode, Me.username, Me.full})
        Me.LViewItems.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItems.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewItems.FullRowSelect = True
        Me.LViewItems.GridLines = True
        Me.LViewItems.HideSelection = False
        Me.LViewItems.Location = New System.Drawing.Point(45, 91)
        Me.LViewItems.Name = "LViewItems"
        Me.LViewItems.Size = New System.Drawing.Size(437, 171)
        Me.LViewItems.TabIndex = 205
        Me.LViewItems.UseCompatibleStateImageBehavior = False
        Me.LViewItems.View = System.Windows.Forms.View.Details
        '
        'BranchCode
        '
        Me.BranchCode.Text = "BRANCH"
        Me.BranchCode.Width = 87
        '
        'username
        '
        Me.username.Text = "USERNAME"
        Me.username.Width = 124
        '
        'full
        '
        Me.full.Text = "NAME"
        Me.full.Width = 219
        '
        'txt_newApprover
        '
        Me.txt_newApprover.BackColor = System.Drawing.Color.White
        Me.txt_newApprover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_newApprover.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_newApprover.ForeColor = System.Drawing.Color.Black
        Me.txt_newApprover.Location = New System.Drawing.Point(139, 267)
        Me.txt_newApprover.Name = "txt_newApprover"
        Me.txt_newApprover.Size = New System.Drawing.Size(343, 23)
        Me.txt_newApprover.TabIndex = 206
        Me.txt_newApprover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'maint_ChangeApprover_Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(503, 310)
        Me.Controls.Add(Me.txt_newApprover)
        Me.Controls.Add(Me.LViewItems)
        Me.Controls.Add(Me.txt_approverFull)
        Me.Controls.Add(Me.txt_approver)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "maint_ChangeApprover_Sales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CHANGE APPROVER"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents newtool As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolpostpayment As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_approver As System.Windows.Forms.Label
    Friend WithEvents txt_approverFull As System.Windows.Forms.Label
    Friend WithEvents LViewItems As System.Windows.Forms.ListView
    Friend WithEvents BranchCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents username As System.Windows.Forms.ColumnHeader
    Friend WithEvents full As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_newApprover As System.Windows.Forms.Label
End Class
