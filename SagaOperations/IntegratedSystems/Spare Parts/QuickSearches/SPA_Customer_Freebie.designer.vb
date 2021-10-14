<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_Customer_Freebie
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
        Me.lv_Customer = New System.Windows.Forms.ListView()
        Me.AccountNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fullname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateGrant = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.lbl_Type = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LedgerSet = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BranchCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lv_Customer
        '
        Me.lv_Customer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.BranchCode, Me.AccountNumber, Me.LedgerSet, Me.fullname, Me.Address, Me.dateGrant})
        Me.lv_Customer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Customer.FullRowSelect = True
        Me.lv_Customer.GridLines = True
        Me.lv_Customer.HideSelection = False
        Me.lv_Customer.Location = New System.Drawing.Point(12, 76)
        Me.lv_Customer.Name = "lv_Customer"
        Me.lv_Customer.Size = New System.Drawing.Size(679, 268)
        Me.lv_Customer.TabIndex = 6
        Me.lv_Customer.UseCompatibleStateImageBehavior = False
        Me.lv_Customer.View = System.Windows.Forms.View.Details
        '
        'AccountNumber
        '
        Me.AccountNumber.Text = "ACCOUNT NUMBER"
        Me.AccountNumber.Width = 180
        '
        'fullname
        '
        Me.fullname.Text = "ACCOUNT NAME"
        Me.fullname.Width = 180
        '
        'Address
        '
        Me.Address.Text = "ADDRESS"
        Me.Address.Width = 200
        '
        'dateGrant
        '
        Me.dateGrant.Text = "DATE GRANTED"
        Me.dateGrant.Width = 120
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(12, 43)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(679, 27)
        Me.txt_Search.TabIndex = 5
        '
        'lbl_Type
        '
        Me.lbl_Type.AutoSize = True
        Me.lbl_Type.Location = New System.Drawing.Point(271, 230)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Type.TabIndex = 9
        Me.lbl_Type.Text = "Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SEARCH"
        '
        'LedgerSet
        '
        Me.LedgerSet.Text = "LEDGER"
        Me.LedgerSet.Width = 70
        '
        'BranchCode
        '
        Me.BranchCode.Text = "BRANCH CODE"
        Me.BranchCode.Width = 110
        '
        'SPA_Customer_Freebie
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 355)
        Me.Controls.Add(Me.lv_Customer)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.lbl_Type)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SPA_Customer_Freebie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPA_Customer_Freebie"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lv_Customer As ListView
    Friend WithEvents AccountNumber As ColumnHeader
    Friend WithEvents fullname As ColumnHeader
    Friend WithEvents dateGrant As ColumnHeader
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents lbl_Type As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Address As ColumnHeader
    Friend WithEvents LedgerSet As ColumnHeader
    Friend WithEvents BranchCode As ColumnHeader
End Class
