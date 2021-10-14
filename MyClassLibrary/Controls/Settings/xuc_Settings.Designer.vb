Namespace Controls.Settings
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class xuc_Settings
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.Check_Clear_Selection = New DevExpress.XtraEditors.CheckEdit()
            Me.Check_Clear_Save_Delete = New DevExpress.XtraEditors.CheckEdit()
            Me.Check_Save_Restore_Layout = New DevExpress.XtraEditors.CheckEdit()
            Me.Check_Clear_New = New DevExpress.XtraEditors.CheckEdit()
            Me.Check_Auto_Show = New DevExpress.XtraEditors.CheckEdit()
            Me.Check_Load_All = New DevExpress.XtraEditors.CheckEdit()
            Me.Check_Auto_Reload = New DevExpress.XtraEditors.CheckEdit()
            Me.Check_Auto_Initialize = New DevExpress.XtraEditors.CheckEdit()
            Me.MemoEdit_Notes = New DevExpress.XtraEditors.MemoEdit()
            Me.Check_Live_Looping = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.LayoutControl1.SuspendLayout()
            CType(Me.Check_Clear_Selection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Clear_Save_Delete.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Save_Restore_Layout.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Clear_New.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Auto_Show.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Load_All.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Auto_Reload.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Auto_Initialize.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.MemoEdit_Notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Check_Live_Looping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'LayoutControl1
            '
            Me.LayoutControl1.Controls.Add(Me.Check_Clear_Selection)
            Me.LayoutControl1.Controls.Add(Me.Check_Clear_Save_Delete)
            Me.LayoutControl1.Controls.Add(Me.Check_Save_Restore_Layout)
            Me.LayoutControl1.Controls.Add(Me.Check_Clear_New)
            Me.LayoutControl1.Controls.Add(Me.Check_Auto_Show)
            Me.LayoutControl1.Controls.Add(Me.Check_Load_All)
            Me.LayoutControl1.Controls.Add(Me.Check_Auto_Reload)
            Me.LayoutControl1.Controls.Add(Me.Check_Auto_Initialize)
            Me.LayoutControl1.Controls.Add(Me.MemoEdit_Notes)
            Me.LayoutControl1.Controls.Add(Me.Check_Live_Looping)
            Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControl1.Name = "LayoutControl1"
            Me.LayoutControl1.Root = Me.Root
            Me.LayoutControl1.Size = New System.Drawing.Size(200, 400)
            Me.LayoutControl1.TabIndex = 0
            Me.LayoutControl1.Text = "LayoutControl1"
            '
            'Check_Clear_Selection
            '
            Me.Check_Clear_Selection.Location = New System.Drawing.Point(24, 134)
            Me.Check_Clear_Selection.Name = "Check_Clear_Selection"
            Me.Check_Clear_Selection.Properties.Caption = "Clear Selection"
            Me.Check_Clear_Selection.Size = New System.Drawing.Size(152, 19)
            Me.Check_Clear_Selection.StyleController = Me.LayoutControl1
            Me.Check_Clear_Selection.TabIndex = 4
            '
            'Check_Clear_Save_Delete
            '
            Me.Check_Clear_Save_Delete.Location = New System.Drawing.Point(24, 245)
            Me.Check_Clear_Save_Delete.Name = "Check_Clear_Save_Delete"
            Me.Check_Clear_Save_Delete.Properties.Caption = "Clear after Save/Delete"
            Me.Check_Clear_Save_Delete.Size = New System.Drawing.Size(152, 19)
            Me.Check_Clear_Save_Delete.StyleController = Me.LayoutControl1
            Me.Check_Clear_Save_Delete.TabIndex = 7
            '
            'Check_Save_Restore_Layout
            '
            Me.Check_Save_Restore_Layout.EditValue = True
            Me.Check_Save_Restore_Layout.Location = New System.Drawing.Point(24, 310)
            Me.Check_Save_Restore_Layout.Name = "Check_Save_Restore_Layout"
            Me.Check_Save_Restore_Layout.Properties.Caption = "Save / Restore Layout"
            Me.Check_Save_Restore_Layout.Size = New System.Drawing.Size(152, 19)
            Me.Check_Save_Restore_Layout.StyleController = Me.LayoutControl1
            Me.Check_Save_Restore_Layout.TabIndex = 8
            '
            'Check_Clear_New
            '
            Me.Check_Clear_New.Location = New System.Drawing.Point(24, 222)
            Me.Check_Clear_New.Name = "Check_Clear_New"
            Me.Check_Clear_New.Properties.Caption = "Clear on New"
            Me.Check_Clear_New.Size = New System.Drawing.Size(152, 19)
            Me.Check_Clear_New.StyleController = Me.LayoutControl1
            Me.Check_Clear_New.TabIndex = 6
            '
            'Check_Auto_Show
            '
            Me.Check_Auto_Show.Location = New System.Drawing.Point(24, 88)
            Me.Check_Auto_Show.Name = "Check_Auto_Show"
            Me.Check_Auto_Show.Properties.Caption = "Show on select"
            Me.Check_Auto_Show.Size = New System.Drawing.Size(152, 19)
            Me.Check_Auto_Show.StyleController = Me.LayoutControl1
            Me.Check_Auto_Show.TabIndex = 2
            '
            'Check_Load_All
            '
            Me.Check_Load_All.Location = New System.Drawing.Point(24, 65)
            Me.Check_Load_All.Name = "Check_Load_All"
            Me.Check_Load_All.Properties.Caption = "Load all"
            Me.Check_Load_All.Size = New System.Drawing.Size(152, 19)
            Me.Check_Load_All.StyleController = Me.LayoutControl1
            Me.Check_Load_All.TabIndex = 1
            '
            'Check_Auto_Reload
            '
            Me.Check_Auto_Reload.Location = New System.Drawing.Point(24, 42)
            Me.Check_Auto_Reload.Name = "Check_Auto_Reload"
            Me.Check_Auto_Reload.Properties.Caption = "Auto Reload"
            Me.Check_Auto_Reload.Size = New System.Drawing.Size(152, 19)
            Me.Check_Auto_Reload.StyleController = Me.LayoutControl1
            Me.Check_Auto_Reload.TabIndex = 0
            '
            'Check_Auto_Initialize
            '
            Me.Check_Auto_Initialize.Location = New System.Drawing.Point(24, 199)
            Me.Check_Auto_Initialize.Name = "Check_Auto_Initialize"
            Me.Check_Auto_Initialize.Properties.Caption = "Auto Initialize"
            Me.Check_Auto_Initialize.Size = New System.Drawing.Size(152, 19)
            Me.Check_Auto_Initialize.StyleController = Me.LayoutControl1
            Me.Check_Auto_Initialize.TabIndex = 5
            '
            'MemoEdit_Notes
            '
            Me.MemoEdit_Notes.Location = New System.Drawing.Point(24, 349)
            Me.MemoEdit_Notes.Name = "MemoEdit_Notes"
            Me.MemoEdit_Notes.Size = New System.Drawing.Size(152, 27)
            Me.MemoEdit_Notes.StyleController = Me.LayoutControl1
            Me.MemoEdit_Notes.TabIndex = 9
            '
            'Check_Live_Looping
            '
            Me.Check_Live_Looping.Location = New System.Drawing.Point(24, 111)
            Me.Check_Live_Looping.Name = "Check_Live_Looping"
            Me.Check_Live_Looping.Properties.Caption = "Live Looping"
            Me.Check_Live_Looping.Size = New System.Drawing.Size(152, 19)
            Me.Check_Live_Looping.StyleController = Me.LayoutControl1
            Me.Check_Live_Looping.TabIndex = 3
            '
            'Root
            '
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup2, Me.LayoutControlGroup3})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(200, 400)
            Me.Root.TextVisible = False
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem7, Me.LayoutControlItem10})
            Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(180, 157)
            Me.LayoutControlGroup1.Text = "Gridview"
            '
            'LayoutControlItem2
            '
            Me.LayoutControlItem2.Control = Me.Check_Auto_Reload
            Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem2.Name = "LayoutControlItem2"
            Me.LayoutControlItem2.Size = New System.Drawing.Size(156, 23)
            Me.LayoutControlItem2.Text = "Auto Reload"
            Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem2.TextVisible = False
            '
            'LayoutControlItem3
            '
            Me.LayoutControlItem3.Control = Me.Check_Load_All
            Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 23)
            Me.LayoutControlItem3.Name = "LayoutControlItem3"
            Me.LayoutControlItem3.Size = New System.Drawing.Size(156, 23)
            Me.LayoutControlItem3.Text = "Load all"
            Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem3.TextVisible = False
            '
            'LayoutControlItem4
            '
            Me.LayoutControlItem4.Control = Me.Check_Auto_Show
            Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 46)
            Me.LayoutControlItem4.Name = "LayoutControlItem4"
            Me.LayoutControlItem4.Size = New System.Drawing.Size(156, 23)
            Me.LayoutControlItem4.Text = "Show on select"
            Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem4.TextVisible = False
            '
            'LayoutControlItem7
            '
            Me.LayoutControlItem7.Control = Me.Check_Live_Looping
            Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 69)
            Me.LayoutControlItem7.Name = "LayoutControlItem7"
            Me.LayoutControlItem7.Size = New System.Drawing.Size(156, 23)
            Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem7.TextVisible = False
            '
            'LayoutControlItem10
            '
            Me.LayoutControlItem10.Control = Me.Check_Clear_Selection
            Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 92)
            Me.LayoutControlItem10.Name = "LayoutControlItem10"
            Me.LayoutControlItem10.Size = New System.Drawing.Size(156, 23)
            Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem10.TextVisible = False
            '
            'LayoutControlGroup2
            '
            Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem9})
            Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 157)
            Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
            Me.LayoutControlGroup2.Size = New System.Drawing.Size(180, 111)
            Me.LayoutControlGroup2.Text = "Information"
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.Check_Auto_Initialize
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(156, 23)
            Me.LayoutControlItem1.Text = "Auto Initialize"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem1.TextVisible = False
            '
            'LayoutControlItem5
            '
            Me.LayoutControlItem5.Control = Me.Check_Clear_New
            Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 23)
            Me.LayoutControlItem5.Name = "LayoutControlItem5"
            Me.LayoutControlItem5.Size = New System.Drawing.Size(156, 23)
            Me.LayoutControlItem5.Text = "Clear on New"
            Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem5.TextVisible = False
            '
            'LayoutControlItem9
            '
            Me.LayoutControlItem9.Control = Me.Check_Clear_Save_Delete
            Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 46)
            Me.LayoutControlItem9.Name = "LayoutControlItem9"
            Me.LayoutControlItem9.Size = New System.Drawing.Size(156, 23)
            Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem9.TextVisible = False
            '
            'LayoutControlGroup3
            '
            Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.LayoutControlItem8})
            Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 268)
            Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
            Me.LayoutControlGroup3.Size = New System.Drawing.Size(180, 112)
            Me.LayoutControlGroup3.Text = "Form"
            '
            'LayoutControlItem6
            '
            Me.LayoutControlItem6.Control = Me.MemoEdit_Notes
            Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 23)
            Me.LayoutControlItem6.Name = "LayoutControlItem6"
            Me.LayoutControlItem6.Size = New System.Drawing.Size(156, 47)
            Me.LayoutControlItem6.Text = "Form Notes"
            Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top
            Me.LayoutControlItem6.TextSize = New System.Drawing.Size(59, 13)
            '
            'LayoutControlItem8
            '
            Me.LayoutControlItem8.Control = Me.Check_Save_Restore_Layout
            Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem8.Name = "LayoutControlItem8"
            Me.LayoutControlItem8.Size = New System.Drawing.Size(156, 23)
            Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem8.TextVisible = False
            '
            'xuc_Settings
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.LayoutControl1)
            Me.Name = "xuc_Settings"
            Me.Size = New System.Drawing.Size(200, 400)
            CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.LayoutControl1.ResumeLayout(False)
            CType(Me.Check_Clear_Selection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Clear_Save_Delete.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Save_Restore_Layout.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Clear_New.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Auto_Show.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Load_All.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Auto_Reload.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Auto_Initialize.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.MemoEdit_Notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Check_Live_Looping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
        Public WithEvents Check_Auto_Show As DevExpress.XtraEditors.CheckEdit
        Public WithEvents Check_Load_All As DevExpress.XtraEditors.CheckEdit
        Public WithEvents Check_Auto_Reload As DevExpress.XtraEditors.CheckEdit
        Public WithEvents Check_Auto_Initialize As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
        Public WithEvents Check_Clear_New As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
        Public WithEvents MemoEdit_Notes As DevExpress.XtraEditors.MemoEdit
        Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
        Public WithEvents Check_Live_Looping As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
        Public WithEvents Check_Save_Restore_Layout As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
        Public WithEvents Check_Clear_Save_Delete As DevExpress.XtraEditors.CheckEdit
        Public WithEvents Check_Clear_Selection As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace