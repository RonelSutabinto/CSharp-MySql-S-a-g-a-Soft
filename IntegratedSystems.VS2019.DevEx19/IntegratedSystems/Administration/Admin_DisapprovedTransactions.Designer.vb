<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_DisapprovedTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_DisapprovedTransactions))
        Me.cmd_find = New System.Windows.Forms.Button()
        Me.vendor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LViewList = New System.Windows.Forms.ListView()
        Me.refno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.invstats = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.source = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tayp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateGranted = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ledset = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.approver = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.dateGrant2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateBegin = New System.Windows.Forms.DateTimePicker()
        Me.txt_TransCode = New System.Windows.Forms.TextBox()
        Me.txt_branchCode = New System.Windows.Forms.TextBox()
        Me.txt_ledset = New System.Windows.Forms.TextBox()
        Me.dateGrant = New System.Windows.Forms.DateTimePicker()
        Me.txt_accountno = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmd_find
        '
        Me.cmd_find.Location = New System.Drawing.Point(271, 8)
        Me.cmd_find.Name = "cmd_find"
        Me.cmd_find.Size = New System.Drawing.Size(82, 56)
        Me.cmd_find.TabIndex = 50
        Me.cmd_find.Text = "SHOW"
        Me.cmd_find.UseVisualStyleBackColor = True
        '
        'vendor
        '
        Me.vendor.Text = "NAME"
        Me.vendor.Width = 203
        '
        'LViewList
        '
        Me.LViewList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.refno, Me.transcode, Me.pono, Me.vendor, Me.invstats, Me.source, Me.tayp, Me.dateGranted, Me.ledset, Me.brcode, Me.approver})
        Me.LViewList.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewList.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewList.FullRowSelect = True
        Me.LViewList.GridLines = True
        Me.LViewList.Location = New System.Drawing.Point(4, 77)
        Me.LViewList.Margin = New System.Windows.Forms.Padding(4)
        Me.LViewList.Name = "LViewList"
        Me.LViewList.Size = New System.Drawing.Size(691, 279)
        Me.LViewList.TabIndex = 41
        Me.LViewList.UseCompatibleStateImageBehavior = False
        Me.LViewList.View = System.Windows.Forms.View.Details
        '
        'refno
        '
        Me.refno.Text = "ReF No"
        Me.refno.Width = 100
        '
        'transcode
        '
        Me.transcode.Text = "TRANSCODE"
        Me.transcode.Width = 126
        '
        'pono
        '
        Me.pono.Text = "PO  No"
        Me.pono.Width = 112
        '
        'invstats
        '
        Me.invstats.Text = "INVENTORY STATUS"
        Me.invstats.Width = 140
        '
        'source
        '
        Me.source.Text = "Source"
        '
        'tayp
        '
        Me.tayp.Text = "TYPE"
        Me.tayp.Width = 100
        '
        'dateGranted
        '
        Me.dateGranted.Text = "DATEGRANTED"
        Me.dateGranted.Width = 90
        '
        'ledset
        '
        Me.ledset.Text = "LedgerSet"
        '
        'brcode
        '
        Me.brcode.Text = "BranchCode"
        '
        'approver
        '
        Me.approver.Text = "APPROVER"
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(722, 283)
        Me.txt_type.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(132, 23)
        Me.txt_type.TabIndex = 52
        Me.txt_type.Text = "type"
        '
        'dateGrant2
        '
        Me.dateGrant2.AutoSize = True
        Me.dateGrant2.Location = New System.Drawing.Point(788, 156)
        Me.dateGrant2.Name = "dateGrant2"
        Me.dateGrant2.Size = New System.Drawing.Size(43, 15)
        Me.dateGrant2.TabIndex = 51
        Me.dateGrant2.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "DATE BEGIN"
        '
        'DateEnd
        '
        Me.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateEnd.Location = New System.Drawing.Point(112, 38)
        Me.DateEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Size = New System.Drawing.Size(150, 23)
        Me.DateEnd.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "DATE END"
        '
        'DateBegin
        '
        Me.DateBegin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateBegin.Location = New System.Drawing.Point(113, 8)
        Me.DateBegin.Margin = New System.Windows.Forms.Padding(4)
        Me.DateBegin.Name = "DateBegin"
        Me.DateBegin.Size = New System.Drawing.Size(150, 23)
        Me.DateBegin.TabIndex = 46
        '
        'txt_TransCode
        '
        Me.txt_TransCode.Location = New System.Drawing.Point(722, 314)
        Me.txt_TransCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_TransCode.Name = "txt_TransCode"
        Me.txt_TransCode.Size = New System.Drawing.Size(132, 23)
        Me.txt_TransCode.TabIndex = 53
        Me.txt_TransCode.Text = "txt_TransCode"
        '
        'txt_branchCode
        '
        Me.txt_branchCode.Location = New System.Drawing.Point(722, 252)
        Me.txt_branchCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_branchCode.Name = "txt_branchCode"
        Me.txt_branchCode.Size = New System.Drawing.Size(132, 23)
        Me.txt_branchCode.TabIndex = 45
        Me.txt_branchCode.Text = "txt_brcode"
        '
        'txt_ledset
        '
        Me.txt_ledset.Location = New System.Drawing.Point(722, 216)
        Me.txt_ledset.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ledset.Name = "txt_ledset"
        Me.txt_ledset.Size = New System.Drawing.Size(132, 23)
        Me.txt_ledset.TabIndex = 44
        Me.txt_ledset.Text = "txt_ledset"
        '
        'dateGrant
        '
        Me.dateGrant.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateGrant.Location = New System.Drawing.Point(718, 129)
        Me.dateGrant.Margin = New System.Windows.Forms.Padding(4)
        Me.dateGrant.Name = "dateGrant"
        Me.dateGrant.Size = New System.Drawing.Size(113, 23)
        Me.dateGrant.TabIndex = 43
        '
        'txt_accountno
        '
        Me.txt_accountno.Location = New System.Drawing.Point(722, 175)
        Me.txt_accountno.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_accountno.Name = "txt_accountno"
        Me.txt_accountno.Size = New System.Drawing.Size(132, 23)
        Me.txt_accountno.TabIndex = 42
        Me.txt_accountno.Text = "txt_accountno"
        '
        'Admin_DisapprovedTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(701, 360)
        Me.Controls.Add(Me.cmd_find)
        Me.Controls.Add(Me.LViewList)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.dateGrant2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateEnd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateBegin)
        Me.Controls.Add(Me.txt_TransCode)
        Me.Controls.Add(Me.txt_branchCode)
        Me.Controls.Add(Me.txt_ledset)
        Me.Controls.Add(Me.dateGrant)
        Me.Controls.Add(Me.txt_accountno)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Admin_DisapprovedTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DISAPPROVED TRANSACTIONS PER BRANCH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_find As System.Windows.Forms.Button
    Friend WithEvents vendor As System.Windows.Forms.ColumnHeader
    Friend WithEvents LViewList As System.Windows.Forms.ListView
    Friend WithEvents refno As System.Windows.Forms.ColumnHeader
    Friend WithEvents transcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents pono As System.Windows.Forms.ColumnHeader
    Friend WithEvents invstats As System.Windows.Forms.ColumnHeader
    Friend WithEvents source As System.Windows.Forms.ColumnHeader
    Friend WithEvents tayp As System.Windows.Forms.ColumnHeader
    Friend WithEvents dateGranted As System.Windows.Forms.ColumnHeader
    Friend WithEvents ledset As System.Windows.Forms.ColumnHeader
    Friend WithEvents brcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents approver As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_type As System.Windows.Forms.TextBox
    Friend WithEvents dateGrant2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_TransCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_branchCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_ledset As System.Windows.Forms.TextBox
    Friend WithEvents dateGrant As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_accountno As System.Windows.Forms.TextBox
End Class
