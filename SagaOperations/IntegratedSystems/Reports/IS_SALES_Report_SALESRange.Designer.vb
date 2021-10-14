<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_SALES_Report_SALESRange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_SALES_Report_SALESRange))
        Me.txt_BranchCode = New System.Windows.Forms.TextBox()
        Me.cmb_BranchName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_showInvent = New System.Windows.Forms.Button()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txt_BranchCode
        '
        Me.txt_BranchCode.Enabled = False
        Me.txt_BranchCode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BranchCode.Location = New System.Drawing.Point(85, 40)
        Me.txt_BranchCode.Name = "txt_BranchCode"
        Me.txt_BranchCode.Size = New System.Drawing.Size(264, 22)
        Me.txt_BranchCode.TabIndex = 131
        '
        'cmb_BranchName
        '
        Me.cmb_BranchName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_BranchName.FormattingEnabled = True
        Me.cmb_BranchName.Location = New System.Drawing.Point(85, 12)
        Me.cmb_BranchName.Name = "cmb_BranchName"
        Me.cmb_BranchName.Size = New System.Drawing.Size(264, 23)
        Me.cmb_BranchName.TabIndex = 130
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 23)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "BRANCH"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmd_showInvent
        '
        Me.cmd_showInvent.AutoSize = True
        Me.cmd_showInvent.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmd_showInvent.BackgroundImage = CType(resources.GetObject("cmd_showInvent.BackgroundImage"), System.Drawing.Image)
        Me.cmd_showInvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_showInvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_showInvent.Location = New System.Drawing.Point(372, 9)
        Me.cmd_showInvent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd_showInvent.Name = "cmd_showInvent"
        Me.cmd_showInvent.Size = New System.Drawing.Size(99, 109)
        Me.cmd_showInvent.TabIndex = 134
        Me.cmd_showInvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_showInvent.UseVisualStyleBackColor = False
        '
        'dateTo
        '
        Me.dateTo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTo.Location = New System.Drawing.Point(85, 95)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(264, 22)
        Me.dateTo.TabIndex = 133
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 31)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "TO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 23)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "FROM"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dateFrom
        '
        Me.dateFrom.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFrom.Location = New System.Drawing.Point(85, 68)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(264, 22)
        Me.dateFrom.TabIndex = 138
        '
        'IS_SALES_Report_SALESRange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 149)
        Me.Controls.Add(Me.dateFrom)
        Me.Controls.Add(Me.txt_BranchCode)
        Me.Controls.Add(Me.cmb_BranchName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_showInvent)
        Me.Controls.Add(Me.dateTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_SALES_Report_SALESRange"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES LISTING"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_BranchCode As System.Windows.Forms.TextBox
    Friend WithEvents cmb_BranchName As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_showInvent As System.Windows.Forms.Button
    Friend WithEvents dateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dateFrom As System.Windows.Forms.DateTimePicker
End Class
