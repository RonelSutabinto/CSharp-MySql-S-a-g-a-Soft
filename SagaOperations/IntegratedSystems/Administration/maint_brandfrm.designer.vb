<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class maint_brandfrm
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
        Me.BrandTextBox = New System.Windows.Forms.TextBox()
        Me.LViewItemsBrand = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.brnd = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Save = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Dellete = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BrandTextBox
        '
        Me.BrandTextBox.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandTextBox.Location = New System.Drawing.Point(90, 12)
        Me.BrandTextBox.Name = "BrandTextBox"
        Me.BrandTextBox.Size = New System.Drawing.Size(396, 21)
        Me.BrandTextBox.TabIndex = 2
        '
        'LViewItemsBrand
        '
        Me.LViewItemsBrand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LViewItemsBrand.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.brnd})
        Me.LViewItemsBrand.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LViewItemsBrand.ForeColor = System.Drawing.Color.SteelBlue
        Me.LViewItemsBrand.FullRowSelect = True
        Me.LViewItemsBrand.GridLines = True
        Me.LViewItemsBrand.HideSelection = False
        Me.LViewItemsBrand.Location = New System.Drawing.Point(22, 39)
        Me.LViewItemsBrand.Name = "LViewItemsBrand"
        Me.LViewItemsBrand.Size = New System.Drawing.Size(464, 237)
        Me.LViewItemsBrand.TabIndex = 29
        Me.LViewItemsBrand.UseCompatibleStateImageBehavior = False
        Me.LViewItemsBrand.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 160
        '
        'brnd
        '
        Me.brnd.Text = "BRAND"
        Me.brnd.Width = 300
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(22, 291)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(109, 31)
        Me.Save.TabIndex = 30
        Me.Save.Text = "&ADD"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "BRAND:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Dellete
        '
        Me.Dellete.Location = New System.Drawing.Point(137, 291)
        Me.Dellete.Name = "Dellete"
        Me.Dellete.Size = New System.Drawing.Size(109, 31)
        Me.Dellete.TabIndex = 32
        Me.Dellete.Text = "&DELETE"
        Me.Dellete.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Location = New System.Drawing.Point(252, 291)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(109, 31)
        Me.CloseBtn.TabIndex = 33
        Me.CloseBtn.Text = "&CLOSE"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'maint_brandfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 330)
        Me.Controls.Add(Me.BrandTextBox)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.Dellete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.LViewItemsBrand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "maint_brandfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " maint_brandfrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BrandTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LViewItemsBrand As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Private WithEvents brnd As System.Windows.Forms.ColumnHeader
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Dellete As System.Windows.Forms.Button
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
End Class
