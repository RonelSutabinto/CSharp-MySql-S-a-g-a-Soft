<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_Pending
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
        Me.lvPending = New System.Windows.Forms.ListView()
        Me.refNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.poNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.spa_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.inventoryStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Show = New System.Windows.Forms.Button()
        Me.dtp_Begin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_End = New System.Windows.Forms.DateTimePicker()
        Me.txt_Refno = New System.Windows.Forms.TextBox()
        Me.txt_Source = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lvPending
        '
        Me.lvPending.BackColor = System.Drawing.Color.White
        Me.lvPending.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.refNo, Me.poNo, Me.spa_Name, Me.inventoryStatus})
        Me.lvPending.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPending.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lvPending.FullRowSelect = True
        Me.lvPending.GridLines = True
        Me.lvPending.Location = New System.Drawing.Point(3, 77)
        Me.lvPending.Name = "lvPending"
        Me.lvPending.Size = New System.Drawing.Size(689, 279)
        Me.lvPending.TabIndex = 39
        Me.lvPending.UseCompatibleStateImageBehavior = False
        Me.lvPending.View = System.Windows.Forms.View.Details
        '
        'refNo
        '
        Me.refNo.Text = "ReF No"
        Me.refNo.Width = 150
        '
        'poNo
        '
        Me.poNo.Text = "PO No"
        Me.poNo.Width = 150
        '
        'spa_Name
        '
        Me.spa_Name.Text = "NAME"
        Me.spa_Name.Width = 200
        '
        'inventoryStatus
        '
        Me.inventoryStatus.Text = "INVENTORY STATUS"
        Me.inventoryStatus.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "DATE BEGIN"
        '
        'btn_Show
        '
        Me.btn_Show.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Show.Location = New System.Drawing.Point(247, 16)
        Me.btn_Show.Name = "btn_Show"
        Me.btn_Show.Size = New System.Drawing.Size(75, 55)
        Me.btn_Show.TabIndex = 35
        Me.btn_Show.Text = "SHOW"
        Me.btn_Show.UseVisualStyleBackColor = True
        '
        'dtp_Begin
        '
        Me.dtp_Begin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Begin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Begin.Location = New System.Drawing.Point(107, 16)
        Me.dtp_Begin.Name = "dtp_Begin"
        Me.dtp_Begin.Size = New System.Drawing.Size(134, 26)
        Me.dtp_Begin.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "DATE END"
        '
        'dtp_End
        '
        Me.dtp_End.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_End.Location = New System.Drawing.Point(107, 45)
        Me.dtp_End.Name = "dtp_End"
        Me.dtp_End.Size = New System.Drawing.Size(134, 26)
        Me.dtp_End.TabIndex = 34
        '
        'txt_Refno
        '
        Me.txt_Refno.Location = New System.Drawing.Point(361, 171)
        Me.txt_Refno.Name = "txt_Refno"
        Me.txt_Refno.Size = New System.Drawing.Size(198, 20)
        Me.txt_Refno.TabIndex = 38
        '
        'txt_Source
        '
        Me.txt_Source.Location = New System.Drawing.Point(361, 197)
        Me.txt_Source.Name = "txt_Source"
        Me.txt_Source.Size = New System.Drawing.Size(198, 20)
        Me.txt_Source.TabIndex = 40
        '
        'SPA_Pending
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(695, 360)
        Me.Controls.Add(Me.lvPending)
        Me.Controls.Add(Me.txt_Source)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Show)
        Me.Controls.Add(Me.dtp_Begin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_End)
        Me.Controls.Add(Me.txt_Refno)
        Me.Name = "SPA_Pending"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PENDING SPARE PARTS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvPending As ListView
    Friend WithEvents refNo As ColumnHeader
    Friend WithEvents poNo As ColumnHeader
    Friend WithEvents spa_Name As ColumnHeader
    Friend WithEvents inventoryStatus As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Show As Button
    Friend WithEvents dtp_Begin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_End As DateTimePicker
    Friend WithEvents txt_Refno As TextBox
    Friend WithEvents txt_Source As TextBox
End Class
