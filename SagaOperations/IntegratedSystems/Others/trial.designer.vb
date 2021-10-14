<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LViewList = New System.Windows.Forms.ListView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnPopulate = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.refno = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.transcode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.vendor = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.invstats = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwToExport = New System.Windows.Forms.ListView()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'LViewList
        '
        Me.LViewList.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewList.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewList.FullRowSelect = True
        Me.LViewList.GridLines = True
        Me.LViewList.Location = New System.Drawing.Point(76, 12)
        Me.LViewList.Name = "LViewList"
        Me.LViewList.Size = New System.Drawing.Size(662, 156)
        Me.LViewList.TabIndex = 17
        Me.LViewList.UseCompatibleStateImageBehavior = False
        Me.LViewList.View = System.Windows.Forms.View.Details
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(76, 222)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(128, 27)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Button1"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnPopulate
        '
        Me.btnPopulate.Location = New System.Drawing.Point(76, 222)
        Me.btnPopulate.Name = "btnPopulate"
        Me.btnPopulate.Size = New System.Drawing.Size(128, 27)
        Me.btnPopulate.TabIndex = 18
        Me.btnPopulate.Text = "Button1"
        Me.btnPopulate.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(254, 222)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(128, 27)
        Me.btnExport.TabIndex = 19
        Me.btnExport.Text = "Button1"
        Me.btnExport.UseVisualStyleBackColor = True
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
        Me.vendor.Text = "VENDOR"
        Me.vendor.Width = 203
        '
        'invstats
        '
        Me.invstats.Text = "INVENTORY STATUS"
        Me.invstats.Width = 140
        '
        'lvwToExport
        '
        Me.lvwToExport.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.refno, Me.transcode, Me.pono, Me.vendor, Me.invstats})
        Me.lvwToExport.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwToExport.ForeColor = System.Drawing.Color.SteelBlue
        Me.lvwToExport.FullRowSelect = True
        Me.lvwToExport.GridLines = True
        Me.lvwToExport.Location = New System.Drawing.Point(59, 12)
        Me.lvwToExport.Name = "lvwToExport"
        Me.lvwToExport.Size = New System.Drawing.Size(662, 156)
        Me.lvwToExport.TabIndex = 17
        Me.lvwToExport.UseCompatibleStateImageBehavior = False
        Me.lvwToExport.View = System.Windows.Forms.View.Details
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(786, 401)
        Me.RichTextBox1.TabIndex = 20
        Me.RichTextBox1.Text = ""
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 401)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnPopulate)
        Me.Controls.Add(Me.lvwToExport)
        Me.Name = "Form1"
        Me.Text = "trial"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LViewList As System.Windows.Forms.ListView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnPopulate As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents refno As System.Windows.Forms.ColumnHeader
    Friend WithEvents transcode As System.Windows.Forms.ColumnHeader
    Friend WithEvents pono As System.Windows.Forms.ColumnHeader
    Friend WithEvents vendor As System.Windows.Forms.ColumnHeader
    Friend WithEvents invstats As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwToExport As System.Windows.Forms.ListView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
