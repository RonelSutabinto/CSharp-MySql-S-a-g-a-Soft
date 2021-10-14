<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Spare_Parts_PO
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
        Me.lvParts = New System.Windows.Forms.ListView()
        Me.partsNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Superceeding = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brand = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.srp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.lbl_Parts_No = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvParts
        '
        Me.lvParts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.partsNumber, Me.partsName, Me.Superceeding, Me.brand, Me.srp})
        Me.lvParts.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvParts.FullRowSelect = True
        Me.lvParts.GridLines = True
        Me.lvParts.HoverSelection = True
        Me.lvParts.Location = New System.Drawing.Point(5, 47)
        Me.lvParts.Name = "lvParts"
        Me.lvParts.Size = New System.Drawing.Size(804, 405)
        Me.lvParts.TabIndex = 1
        Me.lvParts.UseCompatibleStateImageBehavior = False
        Me.lvParts.View = System.Windows.Forms.View.Details
        '
        'partsNumber
        '
        Me.partsNumber.Text = "PARTS NUMBER"
        Me.partsNumber.Width = 150
        '
        'partsName
        '
        Me.partsName.Text = "PARTS NAME"
        Me.partsName.Width = 150
        '
        'Superceeding
        '
        Me.Superceeding.Text = "SUPER CEEDING P/N"
        Me.Superceeding.Width = 150
        '
        'brand
        '
        Me.brand.Text = "BRAND"
        Me.brand.Width = 150
        '
        'srp
        '
        Me.srp.Text = "SRP"
        Me.srp.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "QUICK SEARCH"
        '
        'txt_Search
        '
        Me.txt_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txt_Search.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(104, 18)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(705, 23)
        Me.txt_Search.TabIndex = 5
        '
        'lbl_Parts_No
        '
        Me.lbl_Parts_No.AutoSize = True
        Me.lbl_Parts_No.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Parts_No.ForeColor = System.Drawing.Color.White
        Me.lbl_Parts_No.Location = New System.Drawing.Point(750, 460)
        Me.lbl_Parts_No.Name = "lbl_Parts_No"
        Me.lbl_Parts_No.Size = New System.Drawing.Size(20, 23)
        Me.lbl_Parts_No.TabIndex = 11
        Me.lbl_Parts_No.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(514, 464)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "NUMBERS OF INVENTORY"
        '
        'Search_Spare_Parts_PO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(816, 492)
        Me.Controls.Add(Me.lbl_Parts_No)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.lvParts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Search_Spare_Parts_PO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEARCH SPARE PARTS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvParts As ListView
    Friend WithEvents partsNumber As ColumnHeader
    Friend WithEvents brand As ColumnHeader
    Friend WithEvents srp As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents lbl_Parts_No As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents partsName As ColumnHeader
    Friend WithEvents Superceeding As ColumnHeader
End Class
