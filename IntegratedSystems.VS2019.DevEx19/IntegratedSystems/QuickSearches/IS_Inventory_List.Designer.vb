<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inventory_List
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Inventory_List))
        Me.LViewList = New System.Windows.Forms.ListView()
        Me.refno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vendor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.invstats = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.source = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tayp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateGranted = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ledset = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.approver = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_accountno = New System.Windows.Forms.TextBox()
        Me.dateGrant = New System.Windows.Forms.DateTimePicker()
        Me.txt_ledset = New System.Windows.Forms.TextBox()
        Me.txt_branchCode = New System.Windows.Forms.TextBox()
        Me.DateBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmd_find = New System.Windows.Forms.Button()
        Me.dateGrant2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LViewList
        '
        Me.LViewList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.refno, Me.transcode, Me.pono, Me.vendor, Me.invstats, Me.source, Me.tayp, Me.dateGranted, Me.ledset, Me.brcode, Me.approver})
        Me.LViewList.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewList.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewList.FullRowSelect = True
        Me.LViewList.GridLines = True
        Me.LViewList.HideSelection = False
        Me.LViewList.Location = New System.Drawing.Point(5, 82)
        Me.LViewList.Margin = New System.Windows.Forms.Padding(4)
        Me.LViewList.Name = "LViewList"
        Me.LViewList.Size = New System.Drawing.Size(691, 279)
        Me.LViewList.TabIndex = 16
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
        'vendor
        '
        Me.vendor.Text = "NAME"
        Me.vendor.Width = 203
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
        'txt_accountno
        '
        Me.txt_accountno.Location = New System.Drawing.Point(1036, 96)
        Me.txt_accountno.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_accountno.Name = "txt_accountno"
        Me.txt_accountno.Size = New System.Drawing.Size(132, 26)
        Me.txt_accountno.TabIndex = 17
        '
        'dateGrant
        '
        Me.dateGrant.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateGrant.Location = New System.Drawing.Point(719, 134)
        Me.dateGrant.Margin = New System.Windows.Forms.Padding(4)
        Me.dateGrant.Name = "dateGrant"
        Me.dateGrant.Size = New System.Drawing.Size(113, 26)
        Me.dateGrant.TabIndex = 18
        '
        'txt_ledset
        '
        Me.txt_ledset.Location = New System.Drawing.Point(1036, 168)
        Me.txt_ledset.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ledset.Name = "txt_ledset"
        Me.txt_ledset.Size = New System.Drawing.Size(132, 26)
        Me.txt_ledset.TabIndex = 19
        Me.txt_ledset.Text = "ledset"
        '
        'txt_branchCode
        '
        Me.txt_branchCode.Location = New System.Drawing.Point(1036, 204)
        Me.txt_branchCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_branchCode.Name = "txt_branchCode"
        Me.txt_branchCode.Size = New System.Drawing.Size(132, 26)
        Me.txt_branchCode.TabIndex = 20
        Me.txt_branchCode.Text = "ledset"
        '
        'DateBegin
        '
        Me.DateBegin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateBegin.Location = New System.Drawing.Point(114, 13)
        Me.DateBegin.Margin = New System.Windows.Forms.Padding(4)
        Me.DateBegin.Name = "DateBegin"
        Me.DateBegin.Size = New System.Drawing.Size(150, 26)
        Me.DateBegin.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "DATE END"
        '
        'DateEnd
        '
        Me.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateEnd.Location = New System.Drawing.Point(113, 43)
        Me.DateEnd.Margin = New System.Windows.Forms.Padding(4)
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Size = New System.Drawing.Size(150, 26)
        Me.DateEnd.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "DATE BEGIN"
        '
        'cmd_find
        '
        Me.cmd_find.Location = New System.Drawing.Point(272, 13)
        Me.cmd_find.Name = "cmd_find"
        Me.cmd_find.Size = New System.Drawing.Size(82, 56)
        Me.cmd_find.TabIndex = 26
        Me.cmd_find.Text = "SHOW"
        Me.cmd_find.UseVisualStyleBackColor = True
        '
        'dateGrant2
        '
        Me.dateGrant2.AutoSize = True
        Me.dateGrant2.Location = New System.Drawing.Point(804, 199)
        Me.dateGrant2.Name = "dateGrant2"
        Me.dateGrant2.Size = New System.Drawing.Size(48, 18)
        Me.dateGrant2.TabIndex = 27
        Me.dateGrant2.Text = "Label1"
        '
        'IS_Inventory_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(703, 365)
        Me.Controls.Add(Me.dateGrant2)
        Me.Controls.Add(Me.cmd_find)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateEnd)
        Me.Controls.Add(Me.DateBegin)
        Me.Controls.Add(Me.txt_branchCode)
        Me.Controls.Add(Me.txt_ledset)
        Me.Controls.Add(Me.dateGrant)
        Me.Controls.Add(Me.txt_accountno)
        Me.Controls.Add(Me.LViewList)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inventory_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSACTION LIST"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LViewList As System.Windows.Forms.ListView
    Friend WithEvents refno As System.Windows.Forms.ColumnHeader
    Friend WithEvents transcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents pono As System.Windows.Forms.ColumnHeader
    Friend WithEvents vendor As System.Windows.Forms.ColumnHeader
    Friend WithEvents invstats As System.Windows.Forms.ColumnHeader
    Friend WithEvents source As System.Windows.Forms.ColumnHeader
    Friend WithEvents tayp As System.Windows.Forms.ColumnHeader
    Friend WithEvents dateGranted As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_accountno As System.Windows.Forms.TextBox
    Friend WithEvents dateGrant As System.Windows.Forms.DateTimePicker
    Friend WithEvents ledset As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_ledset As System.Windows.Forms.TextBox
    Friend WithEvents txt_branchCode As System.Windows.Forms.TextBox
    Friend WithEvents brcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmd_find As System.Windows.Forms.Button
    Friend WithEvents dateGrant2 As System.Windows.Forms.Label
    Friend WithEvents approver As System.Windows.Forms.ColumnHeader
End Class
