﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Expenses_FindInv
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
        Me.components = New System.ComponentModel.Container()
        Me.GridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.note = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.engineno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.chassisno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.keyno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.color = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.BarEditItem_Branch = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Btn_Reload = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl
        '
        Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl.Location = New System.Drawing.Point(0, 24)
        Me.GridControl.MainView = Me.GridView
        Me.GridControl.Name = "GridControl"
        Me.GridControl.Size = New System.Drawing.Size(734, 342)
        Me.GridControl.TabIndex = 0
        Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
        '
        'GridView
        '
        Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id, Me.note, Me.engineno, Me.chassisno, Me.keyno, Me.brand, Me.model, Me.color})
        Me.GridView.GridControl = Me.GridControl
        Me.GridView.Name = "GridView"
        Me.GridView.OptionsBehavior.Editable = False
        Me.GridView.OptionsView.ColumnAutoWidth = False
        Me.GridView.OptionsView.ShowFooter = True
        '
        'id
        '
        Me.id.Caption = "ID"
        Me.id.FieldName = "id"
        Me.id.Name = "id"
        Me.id.Visible = True
        Me.id.VisibleIndex = 0
        '
        'note
        '
        Me.note.Caption = "Custodian"
        Me.note.FieldName = "note"
        Me.note.Name = "note"
        Me.note.Visible = True
        Me.note.VisibleIndex = 1
        '
        'engineno
        '
        Me.engineno.Caption = "EngineNo"
        Me.engineno.FieldName = "engineno"
        Me.engineno.Name = "engineno"
        Me.engineno.Visible = True
        Me.engineno.VisibleIndex = 2
        '
        'chassisno
        '
        Me.chassisno.Caption = "ChassisNo"
        Me.chassisno.FieldName = "chassisno"
        Me.chassisno.Name = "chassisno"
        Me.chassisno.Visible = True
        Me.chassisno.VisibleIndex = 3
        '
        'keyno
        '
        Me.keyno.Caption = "KeyNumber"
        Me.keyno.FieldName = "keyno"
        Me.keyno.Name = "keyno"
        Me.keyno.Visible = True
        Me.keyno.VisibleIndex = 4
        '
        'brand
        '
        Me.brand.Caption = "Brand"
        Me.brand.FieldName = "brand"
        Me.brand.Name = "brand"
        Me.brand.Visible = True
        Me.brand.VisibleIndex = 5
        '
        'model
        '
        Me.model.Caption = "Model"
        Me.model.FieldName = "model"
        Me.model.Name = "model"
        Me.model.Visible = True
        Me.model.VisibleIndex = 6
        '
        'color
        '
        Me.color.Caption = "Color"
        Me.color.FieldName = "color"
        Me.color.Name = "color"
        Me.color.Visible = True
        Me.color.VisibleIndex = 7
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarEditItem_Branch, Me.Btn_Reload})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem_Branch, "", False, True, True, 251), New DevExpress.XtraBars.LinkPersistInfo(Me.Btn_Reload)})
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'BarEditItem_Branch
        '
        Me.BarEditItem_Branch.Edit = Me.RepositoryItemLookUpEdit1
        Me.BarEditItem_Branch.Id = 1
        Me.BarEditItem_Branch.Name = "BarEditItem_Branch"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'Btn_Reload
        '
        Me.Btn_Reload.Caption = "Find"
        Me.Btn_Reload.Id = 3
        Me.Btn_Reload.Name = "Btn_Reload"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(734, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 366)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(734, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 342)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(734, 24)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 342)
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'Expenses_FindInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 366)
        Me.Controls.Add(Me.GridControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Expenses_FindInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expenses - Find Inventory"
        CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents BarEditItem_Branch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Btn_Reload As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents note As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents engineno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chassisno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keyno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents color As DevExpress.XtraGrid.Columns.GridColumn
End Class
