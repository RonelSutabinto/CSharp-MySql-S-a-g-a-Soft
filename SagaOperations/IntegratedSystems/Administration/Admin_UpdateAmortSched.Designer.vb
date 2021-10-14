<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_UpdateAmortSched
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_UpdateAmortSched))
        Dim SuperToolTip3 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem3 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim SuperToolTip4 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem4 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.cmd_Modify = New DevExpress.XtraBars.BarButtonItem()
        Me.cmd_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txt_MA = New System.Windows.Forms.TextBox()
        Me.txt_IntEndBal = New System.Windows.Forms.TextBox()
        Me.txt_Interest = New System.Windows.Forms.TextBox()
        Me.txt_IntBegBal = New System.Windows.Forms.TextBox()
        Me.txt_PrinEndBal = New System.Windows.Forms.TextBox()
        Me.txt_Principal = New System.Windows.Forms.TextBox()
        Me.txt_PrinBegBal = New System.Windows.Forms.TextBox()
        Me.txt_DueDate = New System.Windows.Forms.TextBox()
        Me.txt_LedgsetNo = New System.Windows.Forms.TextBox()
        Me.txt_AcctNumber = New System.Windows.Forms.TextBox()
        Me.txt_InstallNo = New System.Windows.Forms.TextBox()
        Me.txt_BranchCode = New System.Windows.Forms.TextBox()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmd_Modify, Me.cmd_Delete})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmd_Modify), New DevExpress.XtraBars.LinkPersistInfo(Me.cmd_Delete)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'cmd_Modify
        '
        Me.cmd_Modify.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmd_Modify.Glyph = CType(resources.GetObject("cmd_Modify.Glyph"), System.Drawing.Image)
        Me.cmd_Modify.Id = 0
        Me.cmd_Modify.LargeGlyph = CType(resources.GetObject("cmd_Modify.LargeGlyph"), System.Drawing.Image)
        Me.cmd_Modify.Name = "cmd_Modify"
        ToolTipTitleItem3.Text = "MODIFY"
        SuperToolTip3.Items.Add(ToolTipTitleItem3)
        Me.cmd_Modify.SuperTip = SuperToolTip3
        '
        'cmd_Delete
        '
        Me.cmd_Delete.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmd_Delete.Glyph = CType(resources.GetObject("cmd_Delete.Glyph"), System.Drawing.Image)
        Me.cmd_Delete.Id = 1
        Me.cmd_Delete.Name = "cmd_Delete"
        ToolTipTitleItem4.Text = "DELETE"
        SuperToolTip4.Items.Add(ToolTipTitleItem4)
        Me.cmd_Delete.SuperTip = SuperToolTip4
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(761, 42)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 219)
        Me.barDockControlBottom.Size = New System.Drawing.Size(761, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 42)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 177)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(761, 42)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 177)
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txt_MA)
        Me.LayoutControl1.Controls.Add(Me.txt_IntEndBal)
        Me.LayoutControl1.Controls.Add(Me.txt_Interest)
        Me.LayoutControl1.Controls.Add(Me.txt_IntBegBal)
        Me.LayoutControl1.Controls.Add(Me.txt_PrinEndBal)
        Me.LayoutControl1.Controls.Add(Me.txt_Principal)
        Me.LayoutControl1.Controls.Add(Me.txt_PrinBegBal)
        Me.LayoutControl1.Controls.Add(Me.txt_DueDate)
        Me.LayoutControl1.Controls.Add(Me.txt_LedgsetNo)
        Me.LayoutControl1.Controls.Add(Me.txt_AcctNumber)
        Me.LayoutControl1.Controls.Add(Me.txt_InstallNo)
        Me.LayoutControl1.Controls.Add(Me.txt_BranchCode)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 42)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1693, 24, 250, 350)
        Me.LayoutControl1.Root = Me.LayoutControlGroup1
        Me.LayoutControl1.Size = New System.Drawing.Size(761, 177)
        Me.LayoutControl1.TabIndex = 4
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txt_MA
        '
        Me.txt_MA.Location = New System.Drawing.Point(356, 132)
        Me.txt_MA.Name = "txt_MA"
        Me.txt_MA.Size = New System.Drawing.Size(158, 20)
        Me.txt_MA.TabIndex = 17
        '
        'txt_IntEndBal
        '
        Me.txt_IntEndBal.Location = New System.Drawing.Point(620, 108)
        Me.txt_IntEndBal.Name = "txt_IntEndBal"
        Me.txt_IntEndBal.Size = New System.Drawing.Size(129, 20)
        Me.txt_IntEndBal.TabIndex = 16
        '
        'txt_Interest
        '
        Me.txt_Interest.Location = New System.Drawing.Point(356, 108)
        Me.txt_Interest.Name = "txt_Interest"
        Me.txt_Interest.Size = New System.Drawing.Size(158, 20)
        Me.txt_Interest.TabIndex = 15
        '
        'txt_IntBegBal
        '
        Me.txt_IntBegBal.Location = New System.Drawing.Point(114, 108)
        Me.txt_IntBegBal.Name = "txt_IntBegBal"
        Me.txt_IntBegBal.Size = New System.Drawing.Size(136, 20)
        Me.txt_IntBegBal.TabIndex = 14
        '
        'txt_PrinEndBal
        '
        Me.txt_PrinEndBal.Location = New System.Drawing.Point(620, 84)
        Me.txt_PrinEndBal.Name = "txt_PrinEndBal"
        Me.txt_PrinEndBal.Size = New System.Drawing.Size(129, 20)
        Me.txt_PrinEndBal.TabIndex = 13
        '
        'txt_Principal
        '
        Me.txt_Principal.Location = New System.Drawing.Point(356, 84)
        Me.txt_Principal.Name = "txt_Principal"
        Me.txt_Principal.Size = New System.Drawing.Size(158, 20)
        Me.txt_Principal.TabIndex = 12
        '
        'txt_PrinBegBal
        '
        Me.txt_PrinBegBal.Location = New System.Drawing.Point(114, 84)
        Me.txt_PrinBegBal.Name = "txt_PrinBegBal"
        Me.txt_PrinBegBal.Size = New System.Drawing.Size(136, 20)
        Me.txt_PrinBegBal.TabIndex = 11
        '
        'txt_DueDate
        '
        Me.txt_DueDate.Location = New System.Drawing.Point(114, 60)
        Me.txt_DueDate.Name = "txt_DueDate"
        Me.txt_DueDate.Size = New System.Drawing.Size(635, 20)
        Me.txt_DueDate.TabIndex = 9
        '
        'txt_LedgsetNo
        '
        Me.txt_LedgsetNo.Location = New System.Drawing.Point(633, 36)
        Me.txt_LedgsetNo.Name = "txt_LedgsetNo"
        Me.txt_LedgsetNo.Size = New System.Drawing.Size(116, 20)
        Me.txt_LedgsetNo.TabIndex = 8
        '
        'txt_AcctNumber
        '
        Me.txt_AcctNumber.Location = New System.Drawing.Point(321, 36)
        Me.txt_AcctNumber.Name = "txt_AcctNumber"
        Me.txt_AcctNumber.Size = New System.Drawing.Size(206, 20)
        Me.txt_AcctNumber.TabIndex = 7
        '
        'txt_InstallNo
        '
        Me.txt_InstallNo.Location = New System.Drawing.Point(114, 12)
        Me.txt_InstallNo.Name = "txt_InstallNo"
        Me.txt_InstallNo.Size = New System.Drawing.Size(635, 20)
        Me.txt_InstallNo.TabIndex = 5
        '
        'txt_BranchCode
        '
        Me.txt_BranchCode.Location = New System.Drawing.Point(114, 36)
        Me.txt_BranchCode.Name = "txt_BranchCode"
        Me.txt_BranchCode.Size = New System.Drawing.Size(101, 20)
        Me.txt_BranchCode.TabIndex = 6
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.LayoutControlItem9, Me.LayoutControlItem10, Me.LayoutControlItem11, Me.LayoutControlItem12, Me.LayoutControlItem13})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "Root"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(761, 177)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txt_InstallNo
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(741, 24)
        Me.LayoutControlItem1.Text = "INSTALLNo"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.txt_BranchCode
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 24)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(207, 24)
        Me.LayoutControlItem2.Text = "BRANCHCODE"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.txt_AcctNumber
        Me.LayoutControlItem3.Location = New System.Drawing.Point(207, 24)
        Me.LayoutControlItem3.MinSize = New System.Drawing.Size(127, 24)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(312, 24)
        Me.LayoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem3.Text = "ACCOUNTNUMBER"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txt_LedgsetNo
        Me.LayoutControlItem4.Location = New System.Drawing.Point(519, 24)
        Me.LayoutControlItem4.MinSize = New System.Drawing.Size(127, 24)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(222, 24)
        Me.LayoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem4.Text = "LEDSETNUMBER"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.txt_DueDate
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 48)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(741, 24)
        Me.LayoutControlItem5.Text = "DUEDATE"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.txt_PrinBegBal
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(242, 24)
        Me.LayoutControlItem7.Text = "PrinBegBal"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.txt_Principal
        Me.LayoutControlItem8.Location = New System.Drawing.Point(242, 72)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem8.Text = "Principal"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.txt_PrinEndBal
        Me.LayoutControlItem9.Location = New System.Drawing.Point(506, 72)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(235, 24)
        Me.LayoutControlItem9.Text = "PrinEndBal"
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.txt_IntBegBal
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(242, 61)
        Me.LayoutControlItem10.Text = "IntBegBal"
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.txt_Interest
        Me.LayoutControlItem11.Location = New System.Drawing.Point(242, 96)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(264, 24)
        Me.LayoutControlItem11.Text = "Interest"
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.txt_IntEndBal
        Me.LayoutControlItem12.Location = New System.Drawing.Point(506, 96)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(235, 61)
        Me.LayoutControlItem12.Text = "IntEndBal"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(99, 15)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.txt_MA
        Me.LayoutControlItem13.Location = New System.Drawing.Point(242, 120)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(264, 37)
        Me.LayoutControlItem13.Text = "MA"
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(99, 15)
        '
        'Admin_UpdateAmortSched
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 219)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Admin_UpdateAmortSched"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UPDATE AMORTIZATION SCHEDULE"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmd_Modify As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmd_Delete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txt_MA As TextBox
    Friend WithEvents txt_IntEndBal As TextBox
    Friend WithEvents txt_Interest As TextBox
    Friend WithEvents txt_IntBegBal As TextBox
    Friend WithEvents txt_PrinEndBal As TextBox
    Friend WithEvents txt_Principal As TextBox
    Friend WithEvents txt_PrinBegBal As TextBox
    Friend WithEvents txt_DueDate As TextBox
    Friend WithEvents txt_LedgsetNo As TextBox
    Friend WithEvents txt_AcctNumber As TextBox
    Friend WithEvents txt_InstallNo As TextBox
    Friend WithEvents txt_BranchCode As TextBox
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
End Class
