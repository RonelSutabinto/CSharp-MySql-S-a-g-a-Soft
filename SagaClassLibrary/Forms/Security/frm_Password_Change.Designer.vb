Namespace Forms.Security
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class frm_Password_Change
        Inherits DevExpress.XtraEditors.XtraForm

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Password_Change))
            Me.Password_Old = New DevExpress.XtraEditors.TextEdit()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.Password_New = New DevExpress.XtraEditors.TextEdit()
            Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.Password_Confirm = New DevExpress.XtraEditors.TextEdit()
            Me.btn_Save = New DevExpress.XtraEditors.SimpleButton()
            Me.btn_Close = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.Password_Old.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Password_New.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Password_Confirm.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Password_Old
            '
            Me.Password_Old.Location = New System.Drawing.Point(124, 21)
            Me.Password_Old.Name = "Password_Old"
            Me.Password_Old.Properties.UseSystemPasswordChar = True
            Me.Password_Old.Size = New System.Drawing.Size(156, 20)
            Me.Password_Old.TabIndex = 1
            '
            'LabelControl1
            '
            Me.LabelControl1.Location = New System.Drawing.Point(35, 24)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(76, 13)
            Me.LabelControl1.TabIndex = 0
            Me.LabelControl1.Text = "*Old Password"
            '
            'LabelControl2
            '
            Me.LabelControl2.Location = New System.Drawing.Point(35, 65)
            Me.LabelControl2.Name = "LabelControl2"
            Me.LabelControl2.Size = New System.Drawing.Size(80, 13)
            Me.LabelControl2.TabIndex = 2
            Me.LabelControl2.Text = "*New Password"
            '
            'Password_New
            '
            Me.Password_New.Location = New System.Drawing.Point(124, 62)
            Me.Password_New.Name = "Password_New"
            Me.Password_New.Properties.UseSystemPasswordChar = True
            Me.Password_New.Size = New System.Drawing.Size(156, 20)
            Me.Password_New.TabIndex = 3
            '
            'LabelControl3
            '
            Me.LabelControl3.Location = New System.Drawing.Point(35, 91)
            Me.LabelControl3.Name = "LabelControl3"
            Me.LabelControl3.Size = New System.Drawing.Size(49, 13)
            Me.LabelControl3.TabIndex = 4
            Me.LabelControl3.Text = "*Confirm "
            '
            'Password_Confirm
            '
            Me.Password_Confirm.Location = New System.Drawing.Point(124, 88)
            Me.Password_Confirm.Name = "Password_Confirm"
            Me.Password_Confirm.Properties.UseSystemPasswordChar = True
            Me.Password_Confirm.Size = New System.Drawing.Size(156, 20)
            Me.Password_Confirm.TabIndex = 5
            '
            'btn_Save
            '
            Me.btn_Save.ImageOptions.Image = CType(resources.GetObject("btn_Save.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Save.Location = New System.Drawing.Point(124, 125)
            Me.btn_Save.Name = "btn_Save"
            Me.btn_Save.Size = New System.Drawing.Size(75, 23)
            Me.btn_Save.TabIndex = 6
            Me.btn_Save.Text = "Save"
            '
            'btn_Close
            '
            Me.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btn_Close.ImageOptions.Image = CType(resources.GetObject("btn_Close.ImageOptions.Image"), System.Drawing.Image)
            Me.btn_Close.Location = New System.Drawing.Point(205, 125)
            Me.btn_Close.Name = "btn_Close"
            Me.btn_Close.Size = New System.Drawing.Size(75, 23)
            Me.btn_Close.TabIndex = 7
            Me.btn_Close.Text = "Close"
            '
            'frm_Password_Change
            '
            Me.AcceptButton = Me.btn_Save
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btn_Close
            Me.ClientSize = New System.Drawing.Size(315, 169)
            Me.Controls.Add(Me.btn_Close)
            Me.Controls.Add(Me.btn_Save)
            Me.Controls.Add(Me.LabelControl3)
            Me.Controls.Add(Me.Password_Confirm)
            Me.Controls.Add(Me.LabelControl2)
            Me.Controls.Add(Me.Password_New)
            Me.Controls.Add(Me.LabelControl1)
            Me.Controls.Add(Me.Password_Old)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
            Me.Name = "frm_Password_Change"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Change Password"

            CType(Me.Password_Old.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Password_New.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Password_Confirm.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Password_Old As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Password_New As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Password_Confirm As DevExpress.XtraEditors.TextEdit
        Friend WithEvents btn_Save As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btn_Close As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace