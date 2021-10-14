Namespace Forms.Information.Account
    Partial Friend Class frm_Amortization_Schedule
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colInstallNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBranchCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAccountNo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colLedgerSetNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDuedate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBeginningBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrincipal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInterest = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMonAmort = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIntBeginningBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colIntOutsBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOutsBalance = New DevExpress.XtraGrid.Columns.GridColumn()
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gridControl
            '
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(0, 0)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Name = "gridControl"
            Me.gridControl.Size = New System.Drawing.Size(398, 325)
            Me.gridControl.TabIndex = 0
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView})
            '
            'gridView
            '
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInstallNo, Me.colBranchCode, Me.colAccountNo, Me.colLedgerSetNumber, Me.colDuedate, Me.colBeginningBalance, Me.colPrincipal, Me.colInterest, Me.colMonAmort, Me.colIntBeginningBalance, Me.colIntOutsBalance, Me.colOutsBalance})
            Me.gridView.gridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsView.ColumnAutoWidth = False
            '
            'colInstallNo
            '
            Me.colInstallNo.Caption = "#"
            Me.colInstallNo.FieldName = "InstallNo"
            Me.colInstallNo.Name = "colInstallNo"
            Me.colInstallNo.Visible = True
            Me.colInstallNo.VisibleIndex = 0
            '
            'colBranchCode
            '
            Me.colBranchCode.Caption = "Branch"
            Me.colBranchCode.FieldName = "BranchCode"
            Me.colBranchCode.Name = "colBranchCode"
            Me.colBranchCode.Visible = True
            Me.colBranchCode.VisibleIndex = 1
            '
            'colAccountNo
            '
            Me.colAccountNo.Caption = "Account Number"
            Me.colAccountNo.FieldName = "AccountNo"
            Me.colAccountNo.Name = "colAccountNo"
            Me.colAccountNo.Visible = True
            Me.colAccountNo.VisibleIndex = 2
            '
            'colLedgerSetNumber
            '
            Me.colLedgerSetNumber.Caption = "Ledger"
            Me.colLedgerSetNumber.FieldName = "LedgerSetNumber"
            Me.colLedgerSetNumber.Name = "colLedgerSetNumber"
            Me.colLedgerSetNumber.Visible = True
            Me.colLedgerSetNumber.VisibleIndex = 3
            '
            'colDuedate
            '
            Me.colDuedate.Caption = "Due Date"
            Me.colDuedate.FieldName = "Duedate"
            Me.colDuedate.Name = "colDuedate"
            Me.colDuedate.Visible = True
            Me.colDuedate.VisibleIndex = 4
            '
            'colBeginningBalance
            '
            Me.colBeginningBalance.Caption = "Balance"
            Me.colBeginningBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colBeginningBalance.FieldName = "BeginningBalance"
            Me.colBeginningBalance.Name = "colBeginningBalance"
            Me.colBeginningBalance.Visible = True
            Me.colBeginningBalance.VisibleIndex = 5
            '
            'colPrincipal
            '
            Me.colPrincipal.Caption = "Principal"
            Me.colPrincipal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPrincipal.FieldName = "Principal"
            Me.colPrincipal.Name = "colPrincipal"
            Me.colPrincipal.Visible = True
            Me.colPrincipal.VisibleIndex = 6
            '
            'colInterest
            '
            Me.colInterest.Caption = "Interest"
            Me.colInterest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colInterest.FieldName = "Interest"
            Me.colInterest.Name = "colInterest"
            Me.colInterest.Visible = True
            Me.colInterest.VisibleIndex = 7
            '
            'colMonAmort
            '
            Me.colMonAmort.Caption = "Amortization"
            Me.colMonAmort.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colMonAmort.FieldName = "MonAmort"
            Me.colMonAmort.Name = "colMonAmort"
            Me.colMonAmort.Visible = True
            Me.colMonAmort.VisibleIndex = 8
            '
            'colIntBeginningBalance
            '
            Me.colIntBeginningBalance.Caption = "Principal Balance"
            Me.colIntBeginningBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colIntBeginningBalance.FieldName = "IntBeginningBalance"
            Me.colIntBeginningBalance.Name = "colIntBeginningBalance"
            Me.colIntBeginningBalance.Visible = True
            Me.colIntBeginningBalance.VisibleIndex = 9
            '
            'colIntOutsBalance
            '
            Me.colIntOutsBalance.Caption = "Interest Balance"
            Me.colIntOutsBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colIntOutsBalance.FieldName = "IntOutsBalance"
            Me.colIntOutsBalance.Name = "colIntOutsBalance"
            Me.colIntOutsBalance.Visible = True
            Me.colIntOutsBalance.VisibleIndex = 11
            '
            'colOutsBalance
            '
            Me.colOutsBalance.Caption = "Outstanding Balance"
            Me.colOutsBalance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colOutsBalance.FieldName = "OutsBalance"
            Me.colOutsBalance.Name = "colOutsBalance"
            Me.colOutsBalance.Visible = True
            Me.colOutsBalance.VisibleIndex = 10
            '
            'frm_Amortization_Schedule
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(398, 325)
            Me.Controls.Add(Me.gridControl)
            Me.Name = "frm_Amortization_Schedule"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.Text = "Amortization Schedule"
            CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents gridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents gridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents colInstallNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBranchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colAccountNo As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colDuedate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colBeginningBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colPrincipal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colInterest As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colMonAmort As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colOutsBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colLedgerSetNumber As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIntBeginningBalance As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents colIntOutsBalance As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace