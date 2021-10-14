<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_Search_CIF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SPA_Search_CIF))
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.lv_CIF = New System.Windows.Forms.ListView()
        Me.fullName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CIFKey = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.lbl_Type = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(12, 42)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(679, 27)
        Me.txt_Search.TabIndex = 0
        '
        'lv_CIF
        '
        Me.lv_CIF.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.fullName, Me.address, Me.CIFKey})
        Me.lv_CIF.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_CIF.FullRowSelect = True
        Me.lv_CIF.GridLines = True
        Me.lv_CIF.HideSelection = False
        Me.lv_CIF.Location = New System.Drawing.Point(12, 75)
        Me.lv_CIF.Name = "lv_CIF"
        Me.lv_CIF.Size = New System.Drawing.Size(679, 268)
        Me.lv_CIF.TabIndex = 1
        Me.lv_CIF.UseCompatibleStateImageBehavior = False
        Me.lv_CIF.View = System.Windows.Forms.View.Details
        '
        'fullName
        '
        Me.fullName.Text = "FULL NAME"
        Me.fullName.Width = 400
        '
        'address
        '
        Me.address.Text = "Address"
        Me.address.Width = 300
        '
        'CIFKey
        '
        Me.CIFKey.Text = "CIFKey"
        Me.CIFKey.Width = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SEARCH"
        '
        'btn_Add
        '
        Me.btn_Add.BackgroundImage = CType(resources.GetObject("btn_Add.BackgroundImage"), System.Drawing.Image)
        Me.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Add.Location = New System.Drawing.Point(629, 12)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(62, 57)
        Me.btn_Add.TabIndex = 3
        Me.btn_Add.UseVisualStyleBackColor = True
        Me.btn_Add.Visible = False
        '
        'lbl_Type
        '
        Me.lbl_Type.AutoSize = True
        Me.lbl_Type.Location = New System.Drawing.Point(271, 229)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Type.TabIndex = 4
        Me.lbl_Type.Text = "Type"
        '
        'SPA_Search_CIF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(703, 355)
        Me.Controls.Add(Me.lv_CIF)
        Me.Controls.Add(Me.lbl_Type)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(719, 394)
        Me.Name = "SPA_Search_CIF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEARCH CUSTOMER INFO."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Search As TextBox
    Friend WithEvents lv_CIF As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents fullName As ColumnHeader
    Friend WithEvents address As ColumnHeader
    Friend WithEvents btn_Add As Button
    Friend WithEvents lbl_Type As Label
    Friend WithEvents CIFKey As ColumnHeader
End Class
