<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_ErrorCorrect_Sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_ErrorCorrect_Sales))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_SINo1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_PostingDate = New System.Windows.Forms.DateTimePicker()
        Me.txt_custName1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 19)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "POSTING DATE"
        '
        'txt_SINo1
        '
        Me.txt_SINo1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SINo1.Location = New System.Drawing.Point(151, 124)
        Me.txt_SINo1.Name = "txt_SINo1"
        Me.txt_SINo1.Size = New System.Drawing.Size(219, 37)
        Me.txt_SINo1.TabIndex = 129
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "OR Number"
        '
        'dtp_PostingDate
        '
        Me.dtp_PostingDate.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_PostingDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_PostingDate.Location = New System.Drawing.Point(151, 81)
        Me.dtp_PostingDate.Name = "dtp_PostingDate"
        Me.dtp_PostingDate.Size = New System.Drawing.Size(365, 37)
        Me.dtp_PostingDate.TabIndex = 127
        '
        'txt_custName1
        '
        Me.txt_custName1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_custName1.Location = New System.Drawing.Point(151, 38)
        Me.txt_custName1.Name = "txt_custName1"
        Me.txt_custName1.ReadOnly = True
        Me.txt_custName1.Size = New System.Drawing.Size(365, 37)
        Me.txt_custName1.TabIndex = 126
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "CUSTOMER"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(529, 25)
        Me.ToolStrip1.TabIndex = 124
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolSave
        '
        Me.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolSave.Image = CType(resources.GetObject("toolSave.Image"), System.Drawing.Image)
        Me.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolSave.Name = "toolSave"
        Me.toolSave.Size = New System.Drawing.Size(23, 22)
        Me.toolSave.Text = "POST"
        '
        'SPA_ErrorCorrect_Sales
        '
        Me.Appearance.BackColor = System.Drawing.Color.Teal
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 177)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_SINo1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_PostingDate)
        Me.Controls.Add(Me.txt_custName1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "SPA_ErrorCorrect_Sales"
        Me.Text = "SPA_ErrorCorrect_Sales"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txt_SINo1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_PostingDate As DateTimePicker
    Friend WithEvents txt_custName1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toolSave As ToolStripButton
End Class
