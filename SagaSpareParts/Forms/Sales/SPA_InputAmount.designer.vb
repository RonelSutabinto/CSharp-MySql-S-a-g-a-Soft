<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_InputAmount
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_AmountDue = New DevExpress.XtraEditors.TextEdit()
        Me.txt_AmountPaid = New DevExpress.XtraEditors.TextEdit()
        Me.txt_ChangeDue = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Type = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_CustDep = New System.Windows.Forms.Label()
        Me.lbl_CustDepAmount = New System.Windows.Forms.Label()
        Me.txt_TenderedFix = New DevExpress.XtraEditors.TextEdit()
        Me.txt_Tendered = New DevExpress.XtraEditors.SpinEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.txt_AmountDue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_AmountPaid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ChangeDue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_TenderedFix.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Tendered.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "TOTAL AMOUNT DUE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "AMOUNT TENDERED"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 217)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TOTAL AMOUNT PAID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(22, 318)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CHANGE"
        '
        'txt_AmountDue
        '
        Me.txt_AmountDue.EnterMoveNextControl = True
        Me.txt_AmountDue.Location = New System.Drawing.Point(22, 43)
        Me.txt_AmountDue.Name = "txt_AmountDue"
        Me.txt_AmountDue.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AmountDue.Properties.Appearance.Options.UseFont = True
        Me.txt_AmountDue.Properties.ReadOnly = True
        Me.txt_AmountDue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_AmountDue.Size = New System.Drawing.Size(448, 52)
        Me.txt_AmountDue.TabIndex = 9
        '
        'txt_AmountPaid
        '
        Me.txt_AmountPaid.EnterMoveNextControl = True
        Me.txt_AmountPaid.Location = New System.Drawing.Point(20, 254)
        Me.txt_AmountPaid.Name = "txt_AmountPaid"
        Me.txt_AmountPaid.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AmountPaid.Properties.Appearance.Options.UseFont = True
        Me.txt_AmountPaid.Properties.ReadOnly = True
        Me.txt_AmountPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_AmountPaid.Size = New System.Drawing.Size(448, 52)
        Me.txt_AmountPaid.TabIndex = 9
        '
        'txt_ChangeDue
        '
        Me.txt_ChangeDue.EnterMoveNextControl = True
        Me.txt_ChangeDue.Location = New System.Drawing.Point(20, 355)
        Me.txt_ChangeDue.Name = "txt_ChangeDue"
        Me.txt_ChangeDue.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ChangeDue.Properties.Appearance.Options.UseFont = True
        Me.txt_ChangeDue.Properties.ReadOnly = True
        Me.txt_ChangeDue.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_ChangeDue.Size = New System.Drawing.Size(448, 52)
        Me.txt_ChangeDue.TabIndex = 9
        '
        'txt_Type
        '
        Me.txt_Type.EnterMoveNextControl = True
        Me.txt_Type.Location = New System.Drawing.Point(336, 54)
        Me.txt_Type.Name = "txt_Type"
        Me.txt_Type.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Type.Properties.Appearance.Options.UseFont = True
        Me.txt_Type.Properties.ReadOnly = True
        Me.txt_Type.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Type.Size = New System.Drawing.Size(121, 26)
        Me.txt_Type.TabIndex = 10
        '
        'lbl_CustDep
        '
        Me.lbl_CustDep.AutoSize = True
        Me.lbl_CustDep.BackColor = System.Drawing.Color.White
        Me.lbl_CustDep.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CustDep.ForeColor = System.Drawing.Color.Black
        Me.lbl_CustDep.Location = New System.Drawing.Point(21, 154)
        Me.lbl_CustDep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_CustDep.Name = "lbl_CustDep"
        Me.lbl_CustDep.Size = New System.Drawing.Size(88, 18)
        Me.lbl_CustDep.TabIndex = 13
        Me.lbl_CustDep.Text = "CUST DEP:"
        '
        'lbl_CustDepAmount
        '
        Me.lbl_CustDepAmount.AutoSize = True
        Me.lbl_CustDepAmount.BackColor = System.Drawing.Color.White
        Me.lbl_CustDepAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CustDepAmount.ForeColor = System.Drawing.Color.Black
        Me.lbl_CustDepAmount.Location = New System.Drawing.Point(38, 173)
        Me.lbl_CustDepAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_CustDepAmount.Name = "lbl_CustDepAmount"
        Me.lbl_CustDepAmount.Size = New System.Drawing.Size(20, 24)
        Me.lbl_CustDepAmount.TabIndex = 14
        Me.lbl_CustDepAmount.Text = "0"
        '
        'txt_TenderedFix
        '
        Me.txt_TenderedFix.EnterMoveNextControl = True
        Me.txt_TenderedFix.Location = New System.Drawing.Point(200, 158)
        Me.txt_TenderedFix.Name = "txt_TenderedFix"
        Me.txt_TenderedFix.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TenderedFix.Properties.Appearance.Options.UseFont = True
        Me.txt_TenderedFix.Properties.ReadOnly = True
        Me.txt_TenderedFix.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_TenderedFix.Size = New System.Drawing.Size(121, 26)
        Me.txt_TenderedFix.TabIndex = 15
        '
        'txt_Tendered
        '
        Me.txt_Tendered.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Tendered.Location = New System.Drawing.Point(20, 150)
        Me.txt_Tendered.Name = "txt_Tendered"
        Me.txt_Tendered.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tendered.Properties.Appearance.Options.UseFont = True
        Me.txt_Tendered.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_Tendered.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txt_Tendered.Properties.Mask.EditMask = "d"
        Me.txt_Tendered.Size = New System.Drawing.Size(448, 52)
        Me.txt_Tendered.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(16, 420)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Note:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(63, 421)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(240, 58)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "After inputting the amount tendered please hit Enter on the keyboard!"
        '
        'SPA_InputAmount
        '
        Me.Appearance.BackColor = System.Drawing.Color.Teal
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(489, 477)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_CustDep)
        Me.Controls.Add(Me.lbl_CustDepAmount)
        Me.Controls.Add(Me.txt_AmountDue)
        Me.Controls.Add(Me.txt_Type)
        Me.Controls.Add(Me.txt_ChangeDue)
        Me.Controls.Add(Me.txt_AmountPaid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Tendered)
        Me.Controls.Add(Me.txt_TenderedFix)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(491, 509)
        Me.Name = "SPA_InputAmount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INPUT AMOUNT"
        CType(Me.txt_AmountDue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_AmountPaid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ChangeDue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_TenderedFix.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Tendered.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_AmountDue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_AmountPaid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_ChangeDue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_CustDep As Label
    Friend WithEvents lbl_CustDepAmount As Label
    Friend WithEvents txt_TenderedFix As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_Tendered As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
