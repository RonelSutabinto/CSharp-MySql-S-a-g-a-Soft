<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inquiry_CustLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Inquiry_CustLedger))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.prin = New System.Windows.Forms.TabPage()
        Me.LViewLedgerPrin = New System.Windows.Forms.ListView()
        Me.postDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mnemonic = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.begbal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cr = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.endingbal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transby = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.aecode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.int = New System.Windows.Forms.TabPage()
        Me.LViewLedgerINT = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.aoc = New System.Windows.Forms.TabPage()
        Me.LViewLedgerAOC = New System.Windows.Forms.ListView()
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pcli = New System.Windows.Forms.TabPage()
        Me.LViewLedgerPCLI = New System.Windows.Forms.ListView()
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader24 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.otc = New System.Windows.Forms.TabPage()
        Me.LViewLedgerOTC = New System.Windows.Forms.ListView()
        Me.ColumnHeader25 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader26 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader27 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader28 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader29 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader30 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader31 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader32 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1.SuspendLayout()
        Me.prin.SuspendLayout()
        Me.int.SuspendLayout()
        Me.aoc.SuspendLayout()
        Me.pcli.SuspendLayout()
        Me.otc.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.prin)
        Me.TabControl1.Controls.Add(Me.int)
        Me.TabControl1.Controls.Add(Me.aoc)
        Me.TabControl1.Controls.Add(Me.pcli)
        Me.TabControl1.Controls.Add(Me.otc)
        Me.TabControl1.Location = New System.Drawing.Point(10, 15)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(764, 367)
        Me.TabControl1.TabIndex = 0
        '
        'prin
        '
        Me.prin.Controls.Add(Me.LViewLedgerPrin)
        Me.prin.Location = New System.Drawing.Point(4, 22)
        Me.prin.Name = "prin"
        Me.prin.Padding = New System.Windows.Forms.Padding(3)
        Me.prin.Size = New System.Drawing.Size(756, 341)
        Me.prin.TabIndex = 0
        Me.prin.Text = "PRIN"
        Me.prin.UseVisualStyleBackColor = True
        '
        'LViewLedgerPrin
        '
        Me.LViewLedgerPrin.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.LViewLedgerPrin.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LViewLedgerPrin.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.postDate, Me.mnemonic, Me.begbal, Me.dr, Me.cr, Me.endingbal, Me.transby, Me.aecode})
        Me.LViewLedgerPrin.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewLedgerPrin.ForeColor = System.Drawing.Color.Teal
        Me.LViewLedgerPrin.GridLines = True
        Me.LViewLedgerPrin.Location = New System.Drawing.Point(0, 1)
        Me.LViewLedgerPrin.Name = "LViewLedgerPrin"
        Me.LViewLedgerPrin.Size = New System.Drawing.Size(730, 322)
        Me.LViewLedgerPrin.TabIndex = 0
        Me.LViewLedgerPrin.UseCompatibleStateImageBehavior = False
        Me.LViewLedgerPrin.View = System.Windows.Forms.View.Details
        '
        'postDate
        '
        Me.postDate.Text = "DATE"
        Me.postDate.Width = 99
        '
        'mnemonic
        '
        Me.mnemonic.Text = "MNEMONIC"
        Me.mnemonic.Width = 93
        '
        'begbal
        '
        Me.begbal.Text = "BEGINNING"
        Me.begbal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.begbal.Width = 93
        '
        'dr
        '
        Me.dr.Text = "DEBIT"
        Me.dr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.dr.Width = 109
        '
        'cr
        '
        Me.cr.Text = "CREDIT"
        Me.cr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.cr.Width = 110
        '
        'endingbal
        '
        Me.endingbal.Text = "ENDING"
        Me.endingbal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.endingbal.Width = 105
        '
        'transby
        '
        Me.transby.Text = "TRANSACTEDBY"
        Me.transby.Width = 119
        '
        'aecode
        '
        Me.aecode.Text = "ACCT EXECUTIVE"
        Me.aecode.Width = 112
        '
        'int
        '
        Me.int.Controls.Add(Me.LViewLedgerINT)
        Me.int.Location = New System.Drawing.Point(4, 22)
        Me.int.Name = "int"
        Me.int.Padding = New System.Windows.Forms.Padding(3)
        Me.int.Size = New System.Drawing.Size(756, 341)
        Me.int.TabIndex = 1
        Me.int.Text = "INT"
        Me.int.UseVisualStyleBackColor = True
        '
        'LViewLedgerINT
        '
        Me.LViewLedgerINT.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.LViewLedgerINT.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LViewLedgerINT.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LViewLedgerINT.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewLedgerINT.ForeColor = System.Drawing.Color.Teal
        Me.LViewLedgerINT.GridLines = True
        Me.LViewLedgerINT.Location = New System.Drawing.Point(0, 1)
        Me.LViewLedgerINT.Name = "LViewLedgerINT"
        Me.LViewLedgerINT.Size = New System.Drawing.Size(730, 322)
        Me.LViewLedgerINT.TabIndex = 1
        Me.LViewLedgerINT.UseCompatibleStateImageBehavior = False
        Me.LViewLedgerINT.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DATE"
        Me.ColumnHeader1.Width = 99
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "MNEMONIC"
        Me.ColumnHeader2.Width = 93
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "BEGINNING"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 93
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DEBIT"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 109
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "CREDIT"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 110
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "ENDING"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 105
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "TRANSACTEDBY"
        Me.ColumnHeader7.Width = 119
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ACCT EXECUTIVE"
        Me.ColumnHeader8.Width = 112
        '
        'aoc
        '
        Me.aoc.Controls.Add(Me.LViewLedgerAOC)
        Me.aoc.Location = New System.Drawing.Point(4, 22)
        Me.aoc.Name = "aoc"
        Me.aoc.Padding = New System.Windows.Forms.Padding(3)
        Me.aoc.Size = New System.Drawing.Size(756, 341)
        Me.aoc.TabIndex = 4
        Me.aoc.Text = "AOC"
        Me.aoc.UseVisualStyleBackColor = True
        '
        'LViewLedgerAOC
        '
        Me.LViewLedgerAOC.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.LViewLedgerAOC.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LViewLedgerAOC.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16})
        Me.LViewLedgerAOC.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewLedgerAOC.ForeColor = System.Drawing.Color.Teal
        Me.LViewLedgerAOC.GridLines = True
        Me.LViewLedgerAOC.Location = New System.Drawing.Point(0, 1)
        Me.LViewLedgerAOC.Name = "LViewLedgerAOC"
        Me.LViewLedgerAOC.Size = New System.Drawing.Size(730, 322)
        Me.LViewLedgerAOC.TabIndex = 1
        Me.LViewLedgerAOC.UseCompatibleStateImageBehavior = False
        Me.LViewLedgerAOC.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "DATE"
        Me.ColumnHeader9.Width = 99
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "MNEMONIC"
        Me.ColumnHeader10.Width = 93
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "BEGINNING"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader11.Width = 93
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "DEBIT"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader12.Width = 109
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "CREDIT"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader13.Width = 110
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "ENDING"
        Me.ColumnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader14.Width = 105
        '
        'ColumnHeader15
        '
        Me.ColumnHeader15.Text = "TRANSACTEDBY"
        Me.ColumnHeader15.Width = 119
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = "ACCT EXECUTIVE"
        Me.ColumnHeader16.Width = 112
        '
        'pcli
        '
        Me.pcli.Controls.Add(Me.LViewLedgerPCLI)
        Me.pcli.Location = New System.Drawing.Point(4, 22)
        Me.pcli.Name = "pcli"
        Me.pcli.Size = New System.Drawing.Size(756, 341)
        Me.pcli.TabIndex = 2
        Me.pcli.Text = "PCLI"
        Me.pcli.UseVisualStyleBackColor = True
        '
        'LViewLedgerPCLI
        '
        Me.LViewLedgerPCLI.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.LViewLedgerPCLI.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LViewLedgerPCLI.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23, Me.ColumnHeader24})
        Me.LViewLedgerPCLI.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewLedgerPCLI.ForeColor = System.Drawing.Color.Teal
        Me.LViewLedgerPCLI.GridLines = True
        Me.LViewLedgerPCLI.Location = New System.Drawing.Point(0, 1)
        Me.LViewLedgerPCLI.Name = "LViewLedgerPCLI"
        Me.LViewLedgerPCLI.Size = New System.Drawing.Size(730, 322)
        Me.LViewLedgerPCLI.TabIndex = 2
        Me.LViewLedgerPCLI.UseCompatibleStateImageBehavior = False
        Me.LViewLedgerPCLI.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "DATE"
        Me.ColumnHeader17.Width = 99
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "MNEMONIC"
        Me.ColumnHeader18.Width = 93
        '
        'ColumnHeader19
        '
        Me.ColumnHeader19.Text = "BEGINNING"
        Me.ColumnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader19.Width = 93
        '
        'ColumnHeader20
        '
        Me.ColumnHeader20.Text = "DEBIT"
        Me.ColumnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader20.Width = 109
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "CREDIT"
        Me.ColumnHeader21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader21.Width = 110
        '
        'ColumnHeader22
        '
        Me.ColumnHeader22.Text = "ENDING"
        Me.ColumnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader22.Width = 105
        '
        'ColumnHeader23
        '
        Me.ColumnHeader23.Text = "TRANSACTEDBY"
        Me.ColumnHeader23.Width = 119
        '
        'ColumnHeader24
        '
        Me.ColumnHeader24.Text = "ACCT EXECUTIVE"
        Me.ColumnHeader24.Width = 112
        '
        'otc
        '
        Me.otc.Controls.Add(Me.LViewLedgerOTC)
        Me.otc.Location = New System.Drawing.Point(4, 22)
        Me.otc.Name = "otc"
        Me.otc.Size = New System.Drawing.Size(756, 341)
        Me.otc.TabIndex = 3
        Me.otc.Text = "OTC"
        Me.otc.UseVisualStyleBackColor = True
        '
        'LViewLedgerOTC
        '
        Me.LViewLedgerOTC.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.LViewLedgerOTC.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LViewLedgerOTC.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader25, Me.ColumnHeader26, Me.ColumnHeader27, Me.ColumnHeader28, Me.ColumnHeader29, Me.ColumnHeader30, Me.ColumnHeader31, Me.ColumnHeader32})
        Me.LViewLedgerOTC.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewLedgerOTC.ForeColor = System.Drawing.Color.Teal
        Me.LViewLedgerOTC.GridLines = True
        Me.LViewLedgerOTC.Location = New System.Drawing.Point(0, 1)
        Me.LViewLedgerOTC.Name = "LViewLedgerOTC"
        Me.LViewLedgerOTC.Size = New System.Drawing.Size(730, 322)
        Me.LViewLedgerOTC.TabIndex = 2
        Me.LViewLedgerOTC.UseCompatibleStateImageBehavior = False
        Me.LViewLedgerOTC.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader25
        '
        Me.ColumnHeader25.Text = "DATE"
        Me.ColumnHeader25.Width = 99
        '
        'ColumnHeader26
        '
        Me.ColumnHeader26.Text = "MNEMONIC"
        Me.ColumnHeader26.Width = 93
        '
        'ColumnHeader27
        '
        Me.ColumnHeader27.Text = "BEGINNING"
        Me.ColumnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader27.Width = 93
        '
        'ColumnHeader28
        '
        Me.ColumnHeader28.Text = "DEBIT"
        Me.ColumnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader28.Width = 109
        '
        'ColumnHeader29
        '
        Me.ColumnHeader29.Text = "CREDIT"
        Me.ColumnHeader29.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader29.Width = 110
        '
        'ColumnHeader30
        '
        Me.ColumnHeader30.Text = "ENDING"
        Me.ColumnHeader30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader30.Width = 105
        '
        'ColumnHeader31
        '
        Me.ColumnHeader31.Text = "TRANSACTEDBY"
        Me.ColumnHeader31.Width = 119
        '
        'ColumnHeader32
        '
        Me.ColumnHeader32.Text = "ACCT EXECUTIVE"
        Me.ColumnHeader32.Width = 112
        '
        'IS_Inquiry_CustLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(788, 407)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inquiry_CustLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IS_Inquiry_CustLedger"
        Me.TabControl1.ResumeLayout(False)
        Me.prin.ResumeLayout(False)
        Me.int.ResumeLayout(False)
        Me.aoc.ResumeLayout(False)
        Me.pcli.ResumeLayout(False)
        Me.otc.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents prin As System.Windows.Forms.TabPage
    Friend WithEvents int As System.Windows.Forms.TabPage
    Friend WithEvents pcli As System.Windows.Forms.TabPage
    Friend WithEvents otc As System.Windows.Forms.TabPage
    Friend WithEvents LViewLedgerPrin As System.Windows.Forms.ListView
    Friend WithEvents postDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents mnemonic As System.Windows.Forms.ColumnHeader
    Friend WithEvents begbal As System.Windows.Forms.ColumnHeader
    Friend WithEvents dr As System.Windows.Forms.ColumnHeader
    Friend WithEvents cr As System.Windows.Forms.ColumnHeader
    Friend WithEvents endingbal As System.Windows.Forms.ColumnHeader
    Friend WithEvents transby As System.Windows.Forms.ColumnHeader
    Friend WithEvents aecode As System.Windows.Forms.ColumnHeader
    Friend WithEvents aoc As System.Windows.Forms.TabPage
    Friend WithEvents LViewLedgerINT As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LViewLedgerAOC As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader15 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LViewLedgerPCLI As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader24 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LViewLedgerOTC As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader25 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader26 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader27 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader28 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader29 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader30 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader31 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader32 As System.Windows.Forms.ColumnHeader
End Class
