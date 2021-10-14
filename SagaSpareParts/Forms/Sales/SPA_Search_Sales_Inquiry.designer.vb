<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPA_Search_Sales_Inquiry
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
        Me.lv_Sales_Inquiry = New System.Windows.Forms.ListView()
        Me.branchCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.custName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.accountNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.custAddress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SINo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.postingDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtp_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.txt_SINo = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lv_Sales_Inquiry
        '
        Me.lv_Sales_Inquiry.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.branchCode, Me.accountNumber, Me.custName, Me.custAddress, Me.SINo, Me.postingDate, Me.total})
        Me.lv_Sales_Inquiry.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Sales_Inquiry.FullRowSelect = True
        Me.lv_Sales_Inquiry.GridLines = True
        Me.lv_Sales_Inquiry.Location = New System.Drawing.Point(12, 98)
        Me.lv_Sales_Inquiry.Name = "lv_Sales_Inquiry"
        Me.lv_Sales_Inquiry.Size = New System.Drawing.Size(865, 312)
        Me.lv_Sales_Inquiry.TabIndex = 0
        Me.lv_Sales_Inquiry.UseCompatibleStateImageBehavior = False
        Me.lv_Sales_Inquiry.View = System.Windows.Forms.View.Details
        '
        'branchCode
        '
        Me.branchCode.Text = "BRANCH"
        Me.branchCode.Width = 80
        '
        'custName
        '
        Me.custName.DisplayIndex = 1
        Me.custName.Text = "CUSTOMER NAME"
        Me.custName.Width = 200
        '
        'accountNumber
        '
        Me.accountNumber.Text = "ACCOUNT NUMBER"
        Me.accountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.accountNumber.Width = 150
        '
        'custAddress
        '
        Me.custAddress.Text = "CUSTOMER ADDRESS"
        Me.custAddress.Width = 250
        '
        'SINo
        '
        Me.SINo.Text = "SI No."
        Me.SINo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SINo.Width = 80
        '
        'postingDate
        '
        Me.postingDate.Text = "POSTING DATE"
        Me.postingDate.Width = 120
        '
        'total
        '
        Me.total.Text = "TOTAL"
        Me.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtp_Date)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_Search)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(865, 80)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH CATEGORY"
        '
        'dtp_Date
        '
        Me.dtp_Date.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Date.Location = New System.Drawing.Point(659, 26)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Size = New System.Drawing.Size(200, 37)
        Me.dtp_Date.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(531, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RELEASE DATE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CUSTOMER NAME"
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(166, 25)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(359, 37)
        Me.txt_Search.TabIndex = 0
        '
        'txt_SINo
        '
        Me.txt_SINo.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SINo.Location = New System.Drawing.Point(284, 211)
        Me.txt_SINo.Name = "txt_SINo"
        Me.txt_SINo.Size = New System.Drawing.Size(359, 37)
        Me.txt_SINo.TabIndex = 4
        '
        'SPA_Search_Sales_Inquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(889, 422)
        Me.Controls.Add(Me.lv_Sales_Inquiry)
        Me.Controls.Add(Me.txt_SINo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SPA_Search_Sales_Inquiry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALES INQUIRY"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lv_Sales_Inquiry As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtp_Date As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents branchCode As ColumnHeader
    Friend WithEvents custName As ColumnHeader
    Friend WithEvents custAddress As ColumnHeader
    Friend WithEvents SINo As ColumnHeader
    Friend WithEvents postingDate As ColumnHeader
    Friend WithEvents total As ColumnHeader
    Friend WithEvents txt_SINo As TextBox
    Friend WithEvents accountNumber As ColumnHeader
End Class
