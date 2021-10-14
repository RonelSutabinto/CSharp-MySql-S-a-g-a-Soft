<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_PMT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Show_PMT))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_prinpmt = New System.Windows.Forms.Label()
        Me.txt_intpmt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_pmt = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_EffIntRate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRIN"
        '
        'txt_prinpmt
        '
        Me.txt_prinpmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_prinpmt.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prinpmt.ForeColor = System.Drawing.Color.White
        Me.txt_prinpmt.Location = New System.Drawing.Point(158, 23)
        Me.txt_prinpmt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_prinpmt.Name = "txt_prinpmt"
        Me.txt_prinpmt.Size = New System.Drawing.Size(162, 34)
        Me.txt_prinpmt.TabIndex = 1
        Me.txt_prinpmt.Text = "0.00"
        Me.txt_prinpmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_intpmt
        '
        Me.txt_intpmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_intpmt.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_intpmt.ForeColor = System.Drawing.Color.White
        Me.txt_intpmt.Location = New System.Drawing.Point(158, 66)
        Me.txt_intpmt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_intpmt.Name = "txt_intpmt"
        Me.txt_intpmt.Size = New System.Drawing.Size(162, 34)
        Me.txt_intpmt.TabIndex = 3
        Me.txt_intpmt.Text = "0.00"
        Me.txt_intpmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(50, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 34)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "INT"
        '
        'txt_pmt
        '
        Me.txt_pmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pmt.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pmt.ForeColor = System.Drawing.Color.Yellow
        Me.txt_pmt.Location = New System.Drawing.Point(158, 123)
        Me.txt_pmt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_pmt.Name = "txt_pmt"
        Me.txt_pmt.Size = New System.Drawing.Size(162, 34)
        Me.txt_pmt.TabIndex = 5
        Me.txt_pmt.Text = "0.00"
        Me.txt_pmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(50, 124)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 34)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "TOTAL MA"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(518, 66)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 34)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "0.00"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_EffIntRate
        '
        Me.txt_EffIntRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_EffIntRate.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EffIntRate.Location = New System.Drawing.Point(518, 23)
        Me.txt_EffIntRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txt_EffIntRate.Name = "txt_EffIntRate"
        Me.txt_EffIntRate.Size = New System.Drawing.Size(162, 34)
        Me.txt_EffIntRate.TabIndex = 6
        Me.txt_EffIntRate.Text = "0.00"
        Me.txt_EffIntRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Show_PMT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(361, 184)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_EffIntRate)
        Me.Controls.Add(Me.txt_pmt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_intpmt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_prinpmt)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Show_PMT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MONTHLY AMORTIZATION"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_prinpmt As Label
    Friend WithEvents txt_intpmt As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_pmt As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_EffIntRate As Label
End Class
