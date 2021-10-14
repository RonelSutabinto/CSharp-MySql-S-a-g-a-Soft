<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Sales_FindCust
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Sales_FindCust))
        Me.LvieWSearchCust = New System.Windows.Forms.ListView()
        Me.cifkey = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.addresss = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuickSearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LvieWSearchCust
        '
        Me.LvieWSearchCust.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.cifkey, Me.fullName, Me.addresss})
        Me.LvieWSearchCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvieWSearchCust.ForeColor = System.Drawing.Color.Teal
        Me.LvieWSearchCust.FullRowSelect = True
        Me.LvieWSearchCust.GridLines = True
        Me.LvieWSearchCust.Location = New System.Drawing.Point(5, 76)
        Me.LvieWSearchCust.Margin = New System.Windows.Forms.Padding(4)
        Me.LvieWSearchCust.Name = "LvieWSearchCust"
        Me.LvieWSearchCust.Size = New System.Drawing.Size(479, 293)
        Me.LvieWSearchCust.TabIndex = 14
        Me.LvieWSearchCust.UseCompatibleStateImageBehavior = False
        Me.LvieWSearchCust.View = System.Windows.Forms.View.Details
        '
        'cifkey
        '
        Me.cifkey.Text = "CIFKey"
        Me.cifkey.Width = 216
        '
        'fullName
        '
        Me.fullName.Text = "FULL NAME"
        Me.fullName.Width = 319
        '
        'addresss
        '
        Me.addresss.Text = "ADDRESS"
        Me.addresss.Width = 199
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SEARCH CUSTOMER INFORMATION FILE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QuickSearch
        '
        Me.QuickSearch.ForeColor = System.Drawing.Color.Teal
        Me.QuickSearch.Location = New System.Drawing.Point(3, 41)
        Me.QuickSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.QuickSearch.Name = "QuickSearch"
        Me.QuickSearch.Size = New System.Drawing.Size(481, 26)
        Me.QuickSearch.TabIndex = 3
        '
        'IS_Sales_FindCust
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(488, 375)
        Me.Controls.Add(Me.LvieWSearchCust)
        Me.Controls.Add(Me.QuickSearch)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IS_Sales_FindCust"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FIND CUST"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LvieWSearchCust As System.Windows.Forms.ListView
    Friend WithEvents cifkey As System.Windows.Forms.ColumnHeader
    Friend WithEvents fullName As System.Windows.Forms.ColumnHeader
    Friend WithEvents addresss As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuickSearch As System.Windows.Forms.TextBox
End Class
