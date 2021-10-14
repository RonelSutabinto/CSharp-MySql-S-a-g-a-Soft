<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_IntransitReport
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
        Me.lvApproved = New System.Windows.Forms.ListView()
        Me.refNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.poNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.spa_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.inventoryStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.sourceEvent = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BranchName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ReceivingBranchName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Show = New System.Windows.Forms.Button()
        Me.dtp_Begin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_End = New System.Windows.Forms.DateTimePicker()
        Me.txt_Source = New System.Windows.Forms.TextBox()
        Me.txt_User = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lvApproved
        '
        Me.lvApproved.BackColor = System.Drawing.Color.White
        Me.lvApproved.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.refNo, Me.poNo, Me.spa_Name, Me.inventoryStatus, Me.sourceEvent, Me.BranchName, Me.ReceivingBranchName})
        Me.lvApproved.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvApproved.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lvApproved.FullRowSelect = True
        Me.lvApproved.GridLines = True
        Me.lvApproved.Location = New System.Drawing.Point(3, 76)
        Me.lvApproved.Name = "lvApproved"
        Me.lvApproved.Size = New System.Drawing.Size(829, 279)
        Me.lvApproved.TabIndex = 33
        Me.lvApproved.UseCompatibleStateImageBehavior = False
        Me.lvApproved.View = System.Windows.Forms.View.Details
        '
        'refNo
        '
        Me.refNo.Text = "ReF No"
        Me.refNo.Width = 120
        '
        'poNo
        '
        Me.poNo.Text = "PO No"
        Me.poNo.Width = 120
        '
        'spa_Name
        '
        Me.spa_Name.Text = "NAME"
        Me.spa_Name.Width = 250
        '
        'inventoryStatus
        '
        Me.inventoryStatus.Text = "INVENTORY STATUS"
        Me.inventoryStatus.Width = 180
        '
        'sourceEvent
        '
        Me.sourceEvent.Text = "SOURCE EVENT"
        Me.sourceEvent.Width = 5
        '
        'BranchName
        '
        Me.BranchName.Text = "ORIGINATING BRANCH"
        Me.BranchName.Width = 150
        '
        'ReceivingBranchName
        '
        Me.ReceivingBranchName.Text = "RECEIVING BRANCH"
        Me.ReceivingBranchName.Width = 150
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "DATE BEGIN"
        '
        'btn_Show
        '
        Me.btn_Show.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Show.Location = New System.Drawing.Point(247, 15)
        Me.btn_Show.Name = "btn_Show"
        Me.btn_Show.Size = New System.Drawing.Size(75, 55)
        Me.btn_Show.TabIndex = 29
        Me.btn_Show.Text = "SHOW"
        Me.btn_Show.UseVisualStyleBackColor = True
        '
        'dtp_Begin
        '
        Me.dtp_Begin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Begin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Begin.Location = New System.Drawing.Point(107, 15)
        Me.dtp_Begin.Name = "dtp_Begin"
        Me.dtp_Begin.Size = New System.Drawing.Size(134, 26)
        Me.dtp_Begin.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "DATE END"
        '
        'dtp_End
        '
        Me.dtp_End.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_End.Location = New System.Drawing.Point(107, 44)
        Me.dtp_End.Name = "dtp_End"
        Me.dtp_End.Size = New System.Drawing.Size(134, 26)
        Me.dtp_End.TabIndex = 28
        '
        'txt_Source
        '
        Me.txt_Source.Location = New System.Drawing.Point(361, 196)
        Me.txt_Source.Name = "txt_Source"
        Me.txt_Source.Size = New System.Drawing.Size(198, 20)
        Me.txt_Source.TabIndex = 34
        '
        'txt_User
        '
        Me.txt_User.Location = New System.Drawing.Point(361, 170)
        Me.txt_User.Name = "txt_User"
        Me.txt_User.Size = New System.Drawing.Size(198, 20)
        Me.txt_User.TabIndex = 32
        '
        'SPA_IntransitReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(835, 360)
        Me.Controls.Add(Me.lvApproved)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Show)
        Me.Controls.Add(Me.dtp_Begin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_End)
        Me.Controls.Add(Me.txt_Source)
        Me.Controls.Add(Me.txt_User)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SPA_IntransitReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INTRANSIT REPORT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvApproved As ListView
    Friend WithEvents refNo As ColumnHeader
    Friend WithEvents poNo As ColumnHeader
    Friend WithEvents spa_Name As ColumnHeader
    Friend WithEvents inventoryStatus As ColumnHeader
    Friend WithEvents sourceEvent As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Show As Button
    Friend WithEvents dtp_Begin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_End As DateTimePicker
    Friend WithEvents txt_Source As TextBox
    Friend WithEvents txt_User As TextBox
    Friend WithEvents BranchName As ColumnHeader
    Friend WithEvents ReceivingBranchName As ColumnHeader
End Class
