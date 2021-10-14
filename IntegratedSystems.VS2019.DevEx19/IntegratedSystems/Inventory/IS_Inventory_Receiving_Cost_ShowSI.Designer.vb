<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Inventory_Receiving_Cost_ShowSI
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
        Me.LViewList = New System.Windows.Forms.ListView()
        Me.refno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vendor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.invstats = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.source = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateApprovd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dateGrant = New System.Windows.Forms.DateTimePicker()
        Me.txt_accountno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuickSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LViewList
        '
        Me.LViewList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.refno, Me.pono, Me.vendor, Me.invstats, Me.source, Me.dateApprovd})
        Me.LViewList.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewList.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewList.FullRowSelect = True
        Me.LViewList.GridLines = True
        Me.LViewList.Location = New System.Drawing.Point(7, 41)
        Me.LViewList.Name = "LViewList"
        Me.LViewList.Size = New System.Drawing.Size(690, 252)
        Me.LViewList.TabIndex = 17
        Me.LViewList.UseCompatibleStateImageBehavior = False
        Me.LViewList.View = System.Windows.Forms.View.Details
        '
        'refno
        '
        Me.refno.Text = "ReF No"
        Me.refno.Width = 100
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
        'dateApprovd
        '
        Me.dateApprovd.Text = "DATE APPROVED"
        Me.dateApprovd.Width = 90
        '
        'dateGrant
        '
        Me.dateGrant.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateGrant.Location = New System.Drawing.Point(754, 88)
        Me.dateGrant.Name = "dateGrant"
        Me.dateGrant.Size = New System.Drawing.Size(100, 23)
        Me.dateGrant.TabIndex = 20
        '
        'txt_accountno
        '
        Me.txt_accountno.Location = New System.Drawing.Point(754, 62)
        Me.txt_accountno.Name = "txt_accountno"
        Me.txt_accountno.Size = New System.Drawing.Size(100, 23)
        Me.txt_accountno.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Quicksearch"
        '
        'QuickSearch
        '
        Me.QuickSearch.Location = New System.Drawing.Point(89, 12)
        Me.QuickSearch.Name = "QuickSearch"
        Me.QuickSearch.Size = New System.Drawing.Size(608, 23)
        Me.QuickSearch.TabIndex = 21
        '
        'IS_Inventory_Receiving_Cost_ShowSI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(703, 298)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuickSearch)
        Me.Controls.Add(Me.dateGrant)
        Me.Controls.Add(Me.txt_accountno)
        Me.Controls.Add(Me.LViewList)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Inventory_Receiving_Cost_ShowSI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SHOW"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LViewList As System.Windows.Forms.ListView
    Friend WithEvents refno As System.Windows.Forms.ColumnHeader
    Friend WithEvents pono As System.Windows.Forms.ColumnHeader
    Friend WithEvents vendor As System.Windows.Forms.ColumnHeader
    Friend WithEvents invstats As System.Windows.Forms.ColumnHeader
    Friend WithEvents source As System.Windows.Forms.ColumnHeader
    Friend WithEvents dateApprovd As System.Windows.Forms.ColumnHeader
    Friend WithEvents dateGrant As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_accountno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuickSearch As System.Windows.Forms.TextBox
End Class
