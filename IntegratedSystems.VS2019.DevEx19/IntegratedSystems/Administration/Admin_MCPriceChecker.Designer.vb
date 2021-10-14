<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_MCPriceChecker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_MCPriceChecker))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_pmt = New System.Windows.Forms.TextBox()
        Me.txt_intpmt = New System.Windows.Forms.TextBox()
        Me.txt_prinpmt = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txt_modelcode = New System.Windows.Forms.TextBox()
        Me.txt_FinancedAmt = New System.Windows.Forms.TextBox()
        Me.txt_model = New System.Windows.Forms.ComboBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txt_ratePA = New System.Windows.Forms.TextBox()
        Me.txt_aoc = New System.Windows.Forms.TextBox()
        Me.txt_DP = New System.Windows.Forms.TextBox()
        Me.txt_rebates = New System.Windows.Forms.TextBox()
        Me.txt_LCP = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_intrate = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_terms = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_effintrate = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.txt_modelcode)
        Me.GroupBox3.Controls.Add(Me.txt_FinancedAmt)
        Me.GroupBox3.Controls.Add(Me.txt_model)
        Me.GroupBox3.Controls.Add(Me.Label46)
        Me.GroupBox3.Controls.Add(Me.txt_ratePA)
        Me.GroupBox3.Controls.Add(Me.txt_aoc)
        Me.GroupBox3.Controls.Add(Me.txt_DP)
        Me.GroupBox3.Controls.Add(Me.txt_rebates)
        Me.GroupBox3.Controls.Add(Me.txt_LCP)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.txt_intrate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txt_terms)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label45)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txt_effintrate)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.Label41)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(839, 341)
        Me.GroupBox3.TabIndex = 143
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MC DETAILS"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.txt_pmt)
        Me.GroupBox5.Controls.Add(Me.txt_intpmt)
        Me.GroupBox5.Controls.Add(Me.txt_prinpmt)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.Label47)
        Me.GroupBox5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Red
        Me.GroupBox5.Location = New System.Drawing.Point(342, 179)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(469, 156)
        Me.GroupBox5.TabIndex = 150
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "AMORTIZATION"
        '
        'txt_pmt
        '
        Me.txt_pmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_pmt.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pmt.ForeColor = System.Drawing.Color.Red
        Me.txt_pmt.Location = New System.Drawing.Point(201, 97)
        Me.txt_pmt.Name = "txt_pmt"
        Me.txt_pmt.Size = New System.Drawing.Size(249, 47)
        Me.txt_pmt.TabIndex = 219
        Me.txt_pmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_intpmt
        '
        Me.txt_intpmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_intpmt.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_intpmt.ForeColor = System.Drawing.Color.Teal
        Me.txt_intpmt.Location = New System.Drawing.Point(201, 58)
        Me.txt_intpmt.Name = "txt_intpmt"
        Me.txt_intpmt.Size = New System.Drawing.Size(249, 40)
        Me.txt_intpmt.TabIndex = 32
        Me.txt_intpmt.Text = "0"
        Me.txt_intpmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_prinpmt
        '
        Me.txt_prinpmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_prinpmt.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prinpmt.ForeColor = System.Drawing.Color.Teal
        Me.txt_prinpmt.Location = New System.Drawing.Point(201, 19)
        Me.txt_prinpmt.Name = "txt_prinpmt"
        Me.txt_prinpmt.Size = New System.Drawing.Size(249, 40)
        Me.txt_prinpmt.TabIndex = 31
        Me.txt_prinpmt.Text = "0"
        Me.txt_prinpmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Red
        Me.Label32.Location = New System.Drawing.Point(12, 104)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(172, 37)
        Me.Label32.TabIndex = 91
        Me.Label32.Text = "TOTAL"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Red
        Me.Label44.Location = New System.Drawing.Point(12, 29)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(172, 26)
        Me.Label44.TabIndex = 85
        Me.Label44.Text = "PRINCIPAL"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Red
        Me.Label47.Location = New System.Drawing.Point(12, 64)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(172, 34)
        Me.Label47.TabIndex = 80
        Me.Label47.Text = "INTEREST"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_modelcode
        '
        Me.txt_modelcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_modelcode.Enabled = False
        Me.txt_modelcode.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_modelcode.Location = New System.Drawing.Point(676, 66)
        Me.txt_modelcode.Name = "txt_modelcode"
        Me.txt_modelcode.Size = New System.Drawing.Size(157, 33)
        Me.txt_modelcode.TabIndex = 215
        Me.txt_modelcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_FinancedAmt
        '
        Me.txt_FinancedAmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_FinancedAmt.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FinancedAmt.Location = New System.Drawing.Point(140, 250)
        Me.txt_FinancedAmt.Name = "txt_FinancedAmt"
        Me.txt_FinancedAmt.Size = New System.Drawing.Size(171, 33)
        Me.txt_FinancedAmt.TabIndex = 15
        Me.txt_FinancedAmt.Text = "0.00"
        Me.txt_FinancedAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_model
        '
        Me.txt_model.Enabled = False
        Me.txt_model.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_model.FormattingEnabled = True
        Me.txt_model.Location = New System.Drawing.Point(132, 66)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(520, 34)
        Me.txt_model.TabIndex = 1
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Teal
        Me.Label46.Location = New System.Drawing.Point(6, 69)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(133, 31)
        Me.Label46.TabIndex = 214
        Me.Label46.Text = "MODEL"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_ratePA
        '
        Me.txt_ratePA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ratePA.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ratePA.Location = New System.Drawing.Point(960, 72)
        Me.txt_ratePA.Name = "txt_ratePA"
        Me.txt_ratePA.Size = New System.Drawing.Size(102, 26)
        Me.txt_ratePA.TabIndex = 212
        Me.txt_ratePA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_aoc
        '
        Me.txt_aoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_aoc.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_aoc.Location = New System.Drawing.Point(140, 214)
        Me.txt_aoc.Name = "txt_aoc"
        Me.txt_aoc.Size = New System.Drawing.Size(171, 33)
        Me.txt_aoc.TabIndex = 14
        Me.txt_aoc.Text = "0.00"
        Me.txt_aoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_DP
        '
        Me.txt_DP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_DP.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DP.Location = New System.Drawing.Point(132, 25)
        Me.txt_DP.Name = "txt_DP"
        Me.txt_DP.Size = New System.Drawing.Size(179, 33)
        Me.txt_DP.TabIndex = 0
        Me.txt_DP.Text = "0.00"
        Me.txt_DP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_rebates
        '
        Me.txt_rebates.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_rebates.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rebates.Location = New System.Drawing.Point(140, 289)
        Me.txt_rebates.Name = "txt_rebates"
        Me.txt_rebates.Size = New System.Drawing.Size(171, 33)
        Me.txt_rebates.TabIndex = 12
        Me.txt_rebates.Text = "0.00"
        Me.txt_rebates.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_LCP
        '
        Me.txt_LCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_LCP.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LCP.Location = New System.Drawing.Point(140, 177)
        Me.txt_LCP.Name = "txt_LCP"
        Me.txt_LCP.Size = New System.Drawing.Size(171, 33)
        Me.txt_LCP.TabIndex = 11
        Me.txt_LCP.Text = "0.00"
        Me.txt_LCP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Teal
        Me.Label33.Location = New System.Drawing.Point(14, 216)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(125, 28)
        Me.Label33.TabIndex = 92
        Me.Label33.Text = "AOC"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Teal
        Me.Label30.Location = New System.Drawing.Point(14, 290)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(120, 34)
        Me.Label30.TabIndex = 89
        Me.Label30.Text = "REBATES"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_intrate
        '
        Me.txt_intrate.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_intrate.FormattingEnabled = True
        Me.txt_intrate.Items.AddRange(New Object() {"0", "100", "103", "106", "109", "115", "117", "120", "130", "134", "145", "151", "160", "168", "172", "190", "202"})
        Me.txt_intrate.Location = New System.Drawing.Point(471, 106)
        Me.txt_intrate.Name = "txt_intrate"
        Me.txt_intrate.Size = New System.Drawing.Size(181, 34)
        Me.txt_intrate.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(6, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 31)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "D/P"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Teal
        Me.Label20.Location = New System.Drawing.Point(14, 250)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(110, 34)
        Me.Label20.TabIndex = 88
        Me.Label20.Text = "FINANCED"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_terms
        '
        Me.txt_terms.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_terms.FormattingEnabled = True
        Me.txt_terms.Items.AddRange(New Object() {"36", "24", "18", "12", "6", "3", "2", "1"})
        Me.txt_terms.Location = New System.Drawing.Point(132, 107)
        Me.txt_terms.Name = "txt_terms"
        Me.txt_terms.Size = New System.Drawing.Size(224, 34)
        Me.txt_terms.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(14, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 35)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "LCP"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Teal
        Me.Label45.Location = New System.Drawing.Point(3, 110)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(133, 31)
        Me.Label45.TabIndex = 80
        Me.Label45.Text = "TERMS"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Teal
        Me.Label11.Location = New System.Drawing.Point(373, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 34)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "RATE"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_effintrate
        '
        Me.txt_effintrate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_effintrate.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_effintrate.Location = New System.Drawing.Point(960, 41)
        Me.txt_effintrate.Name = "txt_effintrate"
        Me.txt_effintrate.Size = New System.Drawing.Size(86, 26)
        Me.txt_effintrate.TabIndex = 212
        Me.txt_effintrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Teal
        Me.Label40.Location = New System.Drawing.Point(877, 45)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(82, 21)
        Me.Label40.TabIndex = 96
        Me.Label40.Text = "Eff Int RATE"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Teal
        Me.Label41.Location = New System.Drawing.Point(906, 73)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(65, 21)
        Me.Label41.TabIndex = 207
        Me.Label41.Text = "RATEPA"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Admin_MCPriceChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(863, 363)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admin_MCPriceChecker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MC PRICE CHECKER"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_FinancedAmt As System.Windows.Forms.TextBox
    Friend WithEvents txt_model As System.Windows.Forms.ComboBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txt_ratePA As System.Windows.Forms.TextBox
    Friend WithEvents txt_aoc As System.Windows.Forms.TextBox
    Friend WithEvents txt_DP As System.Windows.Forms.TextBox
    Friend WithEvents txt_rebates As System.Windows.Forms.TextBox
    Friend WithEvents txt_LCP As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txt_intrate As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_terms As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_effintrate As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pmt As System.Windows.Forms.TextBox
    Friend WithEvents txt_intpmt As System.Windows.Forms.TextBox
    Friend WithEvents txt_prinpmt As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txt_modelcode As System.Windows.Forms.TextBox
End Class
