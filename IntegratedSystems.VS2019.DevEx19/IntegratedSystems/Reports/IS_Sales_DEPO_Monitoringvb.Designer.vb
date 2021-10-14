<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Sales_DEPO_Monitoringvb
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
        Me.LViewItems = New System.Windows.Forms.ListView()
        Me.BRCODE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ACCTNO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LEDSET = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ACCTNAME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ACCTSTATS = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DOR = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ADVPAY = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MA = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PEN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NOOFOD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LPM = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NOTES = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmb_transactions = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmd_show = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LViewItems
        '
        Me.LViewItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BRCODE, Me.ACCTNO, Me.LEDSET, Me.ACCTNAME, Me.ACCTSTATS, Me.DOR, Me.OB, Me.ADVPAY, Me.MA, Me.OD, Me.PEN, Me.NOOFOD, Me.LPM, Me.NOTES})
        Me.LViewItems.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItems.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewItems.FullRowSelect = True
        Me.LViewItems.GridLines = True
        Me.LViewItems.HideSelection = False
        Me.LViewItems.Location = New System.Drawing.Point(5, 76)
        Me.LViewItems.Margin = New System.Windows.Forms.Padding(4)
        Me.LViewItems.Name = "LViewItems"
        Me.LViewItems.Size = New System.Drawing.Size(975, 439)
        Me.LViewItems.TabIndex = 102
        Me.LViewItems.UseCompatibleStateImageBehavior = False
        Me.LViewItems.View = System.Windows.Forms.View.Details
        '
        'BRCODE
        '
        Me.BRCODE.Text = "BRCODE"
        Me.BRCODE.Width = 81
        '
        'ACCTNO
        '
        Me.ACCTNO.Text = "ACCOUNTNUMBER"
        Me.ACCTNO.Width = 155
        '
        'LEDSET
        '
        Me.LEDSET.Text = "LEDGERSET"
        Me.LEDSET.Width = 90
        '
        'ACCTNAME
        '
        Me.ACCTNAME.Text = "ACCOUNTNAME"
        Me.ACCTNAME.Width = 119
        '
        'ACCTSTATS
        '
        Me.ACCTSTATS.Text = "ACCOUNTSTATUS"
        Me.ACCTSTATS.Width = 137
        '
        'DOR
        '
        Me.DOR.Text = "DATERELEASED"
        Me.DOR.Width = 116
        '
        'OB
        '
        Me.OB.Text = "OUTSTANDING"
        Me.OB.Width = 124
        '
        'ADVPAY
        '
        Me.ADVPAY.Text = "ADVPAYMENT"
        Me.ADVPAY.Width = 112
        '
        'MA
        '
        Me.MA.Text = "MA"
        Me.MA.Width = 88
        '
        'OD
        '
        Me.OD.Text = "OVERDUEAMT"
        Me.OD.Width = 102
        '
        'PEN
        '
        Me.PEN.Text = "PENALTY"
        Me.PEN.Width = 78
        '
        'NOOFOD
        '
        Me.NOOFOD.Text = "NOofOD"
        Me.NOOFOD.Width = 78
        '
        'LPM
        '
        Me.LPM.Text = "LASTPAYDATE"
        Me.LPM.Width = 109
        '
        'NOTES
        '
        Me.NOTES.Text = "NOTES"
        '
        'cmb_transactions
        '
        Me.cmb_transactions.FormattingEnabled = True
        Me.cmb_transactions.Location = New System.Drawing.Point(171, 13)
        Me.cmb_transactions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmb_transactions.Name = "cmb_transactions"
        Me.cmb_transactions.Size = New System.Drawing.Size(213, 26)
        Me.cmb_transactions.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 23)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "BRANCH CODE"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 23)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "ACCOUNT EXECUTIVE"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(390, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 26)
        Me.TextBox1.TabIndex = 105
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(171, 43)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(213, 26)
        Me.ComboBox1.TabIndex = 106
        '
        'cmd_show
        '
        Me.cmd_show.Location = New System.Drawing.Point(580, 18)
        Me.cmd_show.Name = "cmd_show"
        Me.cmd_show.Size = New System.Drawing.Size(129, 51)
        Me.cmd_show.TabIndex = 107
        Me.cmd_show.Text = "Button1"
        Me.cmd_show.UseVisualStyleBackColor = True
        '
        'IS_Sales_DEPO_Monitoringvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(984, 520)
        Me.Controls.Add(Me.cmd_show)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cmb_transactions)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LViewItems)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Sales_DEPO_Monitoringvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEPO ACCOUNT MONITORING"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LViewItems As System.Windows.Forms.ListView
    Friend WithEvents BRCODE As System.Windows.Forms.ColumnHeader
    Friend WithEvents ACCTNO As System.Windows.Forms.ColumnHeader
    Friend WithEvents LEDSET As System.Windows.Forms.ColumnHeader
    Friend WithEvents ACCTNAME As System.Windows.Forms.ColumnHeader
    Friend WithEvents ACCTSTATS As System.Windows.Forms.ColumnHeader
    Friend WithEvents DOR As System.Windows.Forms.ColumnHeader
    Friend WithEvents OB As System.Windows.Forms.ColumnHeader
    Friend WithEvents ADVPAY As System.Windows.Forms.ColumnHeader
    Friend WithEvents MA As System.Windows.Forms.ColumnHeader
    Friend WithEvents OD As System.Windows.Forms.ColumnHeader
    Friend WithEvents PEN As System.Windows.Forms.ColumnHeader
    Friend WithEvents NOOFOD As System.Windows.Forms.ColumnHeader
    Friend WithEvents LPM As System.Windows.Forms.ColumnHeader
    Friend WithEvents NOTES As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmb_transactions As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_show As System.Windows.Forms.Button
End Class
