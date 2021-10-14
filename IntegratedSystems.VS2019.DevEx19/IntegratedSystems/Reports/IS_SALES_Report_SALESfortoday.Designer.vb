<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_SALESforToday
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_SALESforToday))
        Me.cmd_showInvent = New System.Windows.Forms.Button()
        Me.trans_date = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_salesType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_BranchName = New System.Windows.Forms.ComboBox()
        Me.txt_BranchCode = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmd_showInvent
        '
        Me.cmd_showInvent.AutoSize = True
        Me.cmd_showInvent.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmd_showInvent.BackgroundImage = CType(resources.GetObject("cmd_showInvent.BackgroundImage"), System.Drawing.Image)
        Me.cmd_showInvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_showInvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_showInvent.Location = New System.Drawing.Point(323, 9)
        Me.cmd_showInvent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd_showInvent.Name = "cmd_showInvent"
        Me.cmd_showInvent.Size = New System.Drawing.Size(99, 109)
        Me.cmd_showInvent.TabIndex = 4
        Me.cmd_showInvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmd_showInvent.UseVisualStyleBackColor = False
        '
        'trans_date
        '
        Me.trans_date.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.trans_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.trans_date.Location = New System.Drawing.Point(133, 95)
        Me.trans_date.Name = "trans_date"
        Me.trans_date.Size = New System.Drawing.Size(172, 22)
        Me.trans_date.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 31)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "TRANSACTION DATE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 23)
        Me.Label4.TabIndex = 123
        Me.Label4.Text = "SALE TYPE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_salesType
        '
        Me.cmb_salesType.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_salesType.FormattingEnabled = True
        Me.cmb_salesType.Items.AddRange(New Object() {"COD", "FIN"})
        Me.cmb_salesType.Location = New System.Drawing.Point(132, 67)
        Me.cmb_salesType.Name = "cmb_salesType"
        Me.cmb_salesType.Size = New System.Drawing.Size(172, 23)
        Me.cmb_salesType.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 23)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "BRANCH"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmb_BranchName
        '
        Me.cmb_BranchName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_BranchName.FormattingEnabled = True
        Me.cmb_BranchName.Location = New System.Drawing.Point(132, 12)
        Me.cmb_BranchName.Name = "cmb_BranchName"
        Me.cmb_BranchName.Size = New System.Drawing.Size(172, 23)
        Me.cmb_BranchName.TabIndex = 0
        '
        'txt_BranchCode
        '
        Me.txt_BranchCode.Enabled = False
        Me.txt_BranchCode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BranchCode.Location = New System.Drawing.Point(132, 40)
        Me.txt_BranchCode.Name = "txt_BranchCode"
        Me.txt_BranchCode.Size = New System.Drawing.Size(172, 22)
        Me.txt_BranchCode.TabIndex = 1
        '
        'IS_SALESforToday
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 139)
        Me.Controls.Add(Me.txt_BranchCode)
        Me.Controls.Add(Me.cmb_BranchName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmb_salesType)
        Me.Controls.Add(Me.cmd_showInvent)
        Me.Controls.Add(Me.trans_date)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_SALESforToday"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES REPORT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_showInvent As System.Windows.Forms.Button
    Friend WithEvents trans_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_salesType As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_BranchName As System.Windows.Forms.ComboBox
    Friend WithEvents txt_BranchCode As System.Windows.Forms.TextBox
End Class
