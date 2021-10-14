<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IS_Inventory_List
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
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
        Me.dateGrant = New DevExpress.XtraEditors.DateEdit()
        Me.txt_ledset = New System.Windows.Forms.TextBox()
        Me.txt_branchCode = New System.Windows.Forms.TextBox()
        Me.DateBegin = New DevExpress.XtraEditors.DateEdit()
        Me.Label2 = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New DevExpress.XtraEditors.LabelControl()
        Me.cmd_find = New DevExpress.XtraEditors.SimpleButton()
        Me.dateGrant2 = New DevExpress.XtraEditors.DateEdit()
        Me.DateEnd = New DevExpress.XtraEditors.DateEdit()
        CType(Me.dateGrant.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateGrant.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateBegin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateBegin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateGrant2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateGrant2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEnd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LViewList.Location = New System.Drawing.Point(4, 59)
        Me.LViewList.Name = "LViewList"
        Me.LViewList.Size = New System.Drawing.Size(519, 203)
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
        Me.txt_accountno.Location = New System.Drawing.Point(777, 69)
        Me.txt_accountno.Name = "txt_accountno"
        Me.txt_accountno.Size = New System.Drawing.Size(100, 22)
        Me.txt_accountno.TabIndex = 17
        '
        'dateGrant
        '
        Me.dateGrant.EditValue = New Date(2020, 11, 16, 0, 0, 0, 0)
        Me.dateGrant.Location = New System.Drawing.Point(539, 97)
        Me.dateGrant.Margin = New System.Windows.Forms.Padding(2)
        Me.dateGrant.Name = "dateGrant"
        Me.dateGrant.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateGrant.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateGrant.Size = New System.Drawing.Size(85, 20)
        Me.dateGrant.TabIndex = 18
        '
        'txt_ledset
        '
        Me.txt_ledset.Location = New System.Drawing.Point(777, 121)
        Me.txt_ledset.Name = "txt_ledset"
        Me.txt_ledset.Size = New System.Drawing.Size(100, 22)
        Me.txt_ledset.TabIndex = 19
        Me.txt_ledset.Text = "ledset"
        '
        'txt_branchCode
        '
        Me.txt_branchCode.Location = New System.Drawing.Point(777, 147)
        Me.txt_branchCode.Name = "txt_branchCode"
        Me.txt_branchCode.Size = New System.Drawing.Size(100, 22)
        Me.txt_branchCode.TabIndex = 20
        Me.txt_branchCode.Text = "ledset"
        '
        'DateBegin
        '
        Me.DateBegin.Location = New System.Drawing.Point(86, 9)
        Me.DateBegin.Margin = New System.Windows.Forms.Padding(2)
        Me.DateBegin.Name = "DateBegin"
        Me.DateBegin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateBegin.Size = New System.Drawing.Size(112, 20)
        Me.DateBegin.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 35)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "DATE END"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(9, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "DATE BEGIN"
        '
        'cmd_find
        '
        Me.cmd_find.Location = New System.Drawing.Point(202, 8)
        Me.cmd_find.Margin = New System.Windows.Forms.Padding(2)
        Me.cmd_find.Name = "cmd_find"
        Me.cmd_find.Size = New System.Drawing.Size(90, 43)
        Me.cmd_find.TabIndex = 26
        Me.cmd_find.Text = "SHOW"
        '
        'dateGrant2
        '
        Me.dateGrant2.EditValue = "Label1"
        Me.dateGrant2.Location = New System.Drawing.Point(603, 144)
        Me.dateGrant2.Margin = New System.Windows.Forms.Padding(2)
        Me.dateGrant2.Name = "dateGrant2"
        Me.dateGrant2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateGrant2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateGrant2.Size = New System.Drawing.Size(33, 20)
        Me.dateGrant2.TabIndex = 27
        '
        'DateEnd
        '
        Me.DateEnd.Location = New System.Drawing.Point(85, 31)
        Me.DateEnd.Name = "DateEnd"
        Me.DateEnd.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEnd.Size = New System.Drawing.Size(113, 20)
        Me.DateEnd.TabIndex = 23
        '
        'IS_Inventory_List
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 266)
        Me.Controls.Add(Me.dateGrant2)
        Me.Controls.Add(Me.cmd_find)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateBegin)
        Me.Controls.Add(Me.txt_branchCode)
        Me.Controls.Add(Me.txt_ledset)
        Me.Controls.Add(Me.dateGrant)
        Me.Controls.Add(Me.txt_accountno)
        Me.Controls.Add(Me.LViewList)
        Me.Controls.Add(Me.DateEnd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("IS_Inventory_List.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inventory_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSACTION LIST"
        CType(Me.dateGrant.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateGrant.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateBegin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateBegin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateGrant2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateGrant2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEnd.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEnd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dateGrant As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ledset As System.Windows.Forms.ColumnHeader
    Friend WithEvents txt_ledset As System.Windows.Forms.TextBox
    Friend WithEvents txt_branchCode As System.Windows.Forms.TextBox
    Friend WithEvents brcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateBegin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmd_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dateGrant2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents approver As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateEnd As DevExpress.XtraEditors.DateEdit
End Class
