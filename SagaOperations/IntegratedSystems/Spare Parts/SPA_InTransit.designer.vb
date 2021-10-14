<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_InTransit
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Show = New System.Windows.Forms.Button()
        Me.dtp_Begin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp_End = New System.Windows.Forms.DateTimePicker()
        Me.txt_User = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel1.SuspendLayout()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "DATE BEGIN"
        '
        'btn_Show
        '
        Me.btn_Show.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Show.Location = New System.Drawing.Point(247, 16)
        Me.btn_Show.Name = "btn_Show"
        Me.btn_Show.Size = New System.Drawing.Size(75, 55)
        Me.btn_Show.TabIndex = 28
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
        Me.dtp_Begin.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "DATE END"
        '
        'dtp_End
        '
        Me.dtp_End.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_End.Location = New System.Drawing.Point(107, 45)
        Me.dtp_End.Name = "dtp_End"
        Me.dtp_End.Size = New System.Drawing.Size(134, 26)
        Me.dtp_End.TabIndex = 27
        '
        'txt_User
        '
        Me.txt_User.Location = New System.Drawing.Point(361, 171)
        Me.txt_User.Name = "txt_User"
        Me.txt_User.Size = New System.Drawing.Size(198, 20)
        Me.txt_User.TabIndex = 31
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GridControl)
        Me.Panel1.Location = New System.Drawing.Point(3, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 279)
        Me.Panel1.TabIndex = 32
        '
        'GridControl
        '
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(0, 0)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(688, 279)
        Me.GridControl.TabIndex = 13
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.DetailHeight = 303
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.Editable = False
        Me.GridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Classic
        Me.GridView.OptionsSelection.MultiSelect = True
        Me.GridView.OptionsView.ColumnAutoWidth = False
        Me.GridView.OptionsView.ShowFooter = True
        '
        'SPA_InTransit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(695, 360)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Show)
        Me.Controls.Add(Me.dtp_Begin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_End)
        Me.Controls.Add(Me.txt_User)
        Me.Name = "SPA_InTransit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INTRANSIT SPARE PARTS"
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Show As Button
    Friend WithEvents dtp_Begin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp_End As DateTimePicker
    Friend WithEvents txt_User As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
End Class
