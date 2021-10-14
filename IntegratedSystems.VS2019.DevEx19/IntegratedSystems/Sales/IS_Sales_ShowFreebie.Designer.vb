<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IS_Sales_ShowFreebie
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides sub Dispose(ByVal disposing As Boolean)
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
    private sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IS_Sales_ShowFreebie))
        Me.lv_Parts = New System.Windows.Forms.ListView()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.partsName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.quantity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.txt_PartsNumber = New System.Windows.Forms.TextBox()
        Me.txt_PartsName = New System.Windows.Forms.TextBox()
        Me.txt_Quantity = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.savebtn = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.txt_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lv_Parts
        '
        Me.lv_Parts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.partsNumber, Me.partsName, Me.quantity})
        Me.lv_Parts.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lv_Parts.FullRowSelect = True
        Me.lv_Parts.GridLines = True
        Me.lv_Parts.HideSelection = False
        Me.lv_Parts.HoverSelection = True
        Me.lv_Parts.Location = New System.Drawing.Point(6, 56)
        Me.lv_Parts.Name = "lv_Parts"
        Me.lv_Parts.Size = New System.Drawing.Size(584, 222)
        Me.lv_Parts.TabIndex = 9
        Me.lv_Parts.UseCompatibleStateImageBehavior = False
        Me.lv_Parts.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.ID.text = "ID"
        Me.id.Width = 75
        '
        'partsNumber
        '
        Me.partsNumber.Text = "PARTS NUMBER"
        Me.partsNumber.Width = 202
        '
        'partsName
        '
        Me.partsName.Text = "PARTS NAME"
        Me.partsName.Width = 308
        '
        'quantity
        '
        Me.quantity.Text = "QUANTITY"
        Me.quantity.Width = 82
        '
        'txt_Search
        '
        Me.txt_Search.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Search.Location = New System.Drawing.Point(6, 29)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(584, 27)
        Me.txt_Search.TabIndex = 8
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ID.Location = New System.Drawing.Point(83, 283)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.ReadOnly = True
        Me.txt_ID.Size = New System.Drawing.Size(218, 27)
        Me.txt_ID.TabIndex = 10
        '
        'txt_PartsNumber
        '
        Me.txt_PartsNumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsNumber.Location = New System.Drawing.Point(405, 283)
        Me.txt_PartsNumber.Name = "txt_PartsNumber"
        Me.txt_PartsNumber.ReadOnly = True
        Me.txt_PartsNumber.Size = New System.Drawing.Size(184, 27)
        Me.txt_PartsNumber.TabIndex = 11
        '
        'txt_PartsName
        '
        Me.txt_PartsName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PartsName.Location = New System.Drawing.Point(83, 311)
        Me.txt_PartsName.Name = "txt_PartsName"
        Me.txt_PartsName.ReadOnly = True
        Me.txt_PartsName.Size = New System.Drawing.Size(218, 27)
        Me.txt_PartsName.TabIndex = 12
        '
        'txt_Quantity
        '
        Me.txt_Quantity.Location = New System.Drawing.Point(405, 315)
        Me.txt_Quantity.Name = "txt_Quantity"
        Me.txt_Quantity.Size = New System.Drawing.Size(183, 22)
        Me.txt_Quantity.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 282)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "IDNo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "PartsNumber"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "PartsName"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(306, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Quantity"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockWindowTabFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.savebtn})
        Me.BarManager1.MaxItemId = 2
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 1"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.savebtn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar1.Text = "Custom 1"
        '
        'savebtn
        '
        Me.savebtn.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.savebtn.Caption = "SAVE"
        Me.savebtn.Id = 1
        Me.savebtn.ImageOptions.Image = CType(resources.GetObject("savebtn.ImageOptions.Image"), System.Drawing.Image)
        Me.savebtn.ImageOptions.LargeImage = CType(resources.GetObject("savebtn.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.savebtn.Name = "savebtn"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.barDockControlTop.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.barDockControlTop.Appearance.Options.UseBackColor = True
        Me.barDockControlTop.Appearance.Options.UseBorderColor = True
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(595, 26)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 340)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(595, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 26)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 314)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(595, 26)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 314)
        '
        'IS_Sales_ShowFreebie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 340)
        Me.Controls.Add(Me.txt_Quantity)
        Me.Controls.Add(Me.txt_PartsName)
        Me.Controls.Add(Me.txt_PartsNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.lv_Parts)
        Me.Controls.Add(Me.txt_Search)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IconOptions.Icon = CType(resources.GetObject("IS_Sales_ShowFreebie.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "IS_Sales_ShowFreebie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FREEBIES"
        CType(Me.txt_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lv_Parts As ListView
    Friend WithEvents id As ColumnHeader
    Friend WithEvents partsNumber As ColumnHeader
    Friend WithEvents partsName As ColumnHeader
    Friend WithEvents quantity As ColumnHeader
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents txt_PartsNumber As TextBox
    Friend WithEvents txt_PartsName As TextBox
    Friend WithEvents txt_Quantity As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents savebtn As DevExpress.XtraBars.BarButtonItem
End Class
