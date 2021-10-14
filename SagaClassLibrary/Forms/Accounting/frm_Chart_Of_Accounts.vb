Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraTreeList
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Data.Entity
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_Chart_Of_Accounts
        Inherits DevExpress.XtraEditors.XtraForm

        Friend eDateType As eLoad_Type

        Dim iRowSelected As Int32
        Dim bLoopStop As Boolean

        Public Sub New()
            If Me.xuc_Chart_Of_Account Is Nothing Then
                Me.xuc_Chart_Of_Account = New Controls.Accounting.xuc_Chart_Of_Account()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, xuc_Chart_Of_Account.LayoutControl, xuc_Settings)
            class_Procedures.Initialize_TreeList(treeList, "COA_Summary", "COA_Code")

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Chart_Of_Accounts_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_COA(RepositoryItemLookUpEdit_COA, eCOA_Type.COA_All)
            colCOA_Summary1.ColumnEdit = RepositoryItemLookUpEdit_COA

            toggle_Auto_Expand.IsOn = class_Tools.RegKeyGet(Me.Name, toggle_Auto_Expand.Name, False)

            If xuc_Settings.Check_Save_Restore_Layout.Checked Then treeList.RestoreLayoutFromRegistry(Me.Name)

            btn_Save.Enabled = class_Saga_Variables.isAccounting
            btn_Delete.Enabled = class_Saga_Variables.isAccounting
            btn_Migrate.Enabled = class_Saga_Variables.isAccounting
            btn_Convert_Summary.Enabled = class_Saga_Variables.isAccounting
            btn_Lock.Enabled = class_Saga_Variables.isAccounting
            btn_Trial_Balance.Enabled = class_Saga_Variables.isAccounting
            btn_Account_Code_Re_Assign.Enabled = class_Saga_Variables.isAccounting

            Dim repositoryItemLookupEdit_Corporation As New RepositoryItemLookUpEdit
            class_Saga_Procedures.Initialize_Corporation(repositoryItemLookupEdit_Corporation, True)
            colCorporation.ColumnEdit = repositoryItemLookupEdit_Corporation
            colCorporation1.ColumnEdit = repositoryItemLookupEdit_Corporation
        End Sub

        Private Sub frm_Chart_Of_Accounts_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            BarEditItem_Date_Type.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Date_Type.Name, "MONTHLY")

            btn_Lock.Enabled = class_Variables.isAdministrator

            xuc_Chart_Of_Account.COA_Name.Properties.CharacterCasing = CharacterCasing.Normal

            BarEditItem_Date_Type_EditValueChanged(sender, e)

            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Chart_Of_Account.Control_Initialize()

            treeList.BestFitColumns()
            gridView.BestFitColumns()
        End Sub

        Private Function Form_Close() As Boolean
            class_Tools.RegKeySet(Me.Name, BarEditItem_Date_Type.Name, BarEditItem_Date_Type.EditValue)
            If xuc_Settings.Check_Save_Restore_Layout.Checked Then treeList.SaveLayoutToRegistry(Me.Name)

            class_Tools.RegKeySet(Me.Name, toggle_Auto_Expand.Name, toggle_Auto_Expand.IsOn)

            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, xuc_Chart_Of_Account.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub frm_Chart_Of_Accounts_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Chart_Of_Account.Control_Initialize()
        End Sub

        Friend Sub Data_Load()
            class_Database.DBError = False
            class_Database.Bind_Data(class_Database.ICSConnection, treeList, "SELECT * FROM view_Chart_Of_Accounts", "view_Chart_Of_Accounts")
            If toggle_Auto_Expand.IsOn Then
                treeList.ExpandAll()
            Else
                treeList.CollapseAll()
            End If

            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, "SELECT * FROM view_Chart_Of_Accounts", "view_Chart_Of_Accounts")
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            class_Saga_Procedures.Initialize_COA(RepositoryItemLookUpEdit_COA, eCOA_Type.COA_All)
            Data_Load()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0
                    treeList.ShowRibbonPrintPreview()
                Case 1
                    If gridView.RowCount > 0 Then gridView.ShowRibbonPrintPreview()
            End Select
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Chart_Of_Account.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
            xuc_Chart_Of_Account.ID.EditValue = gridView.DataRowCount + 1
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Chart_Of_Account.Control_Save(xuc_Chart_Of_Account.COA_Code.Text.Trim, xuc_Chart_Of_Account.Toggle_Save_By_ID.IsOn) Then

                If xuc_Chart_Of_Account.Toggle_Save_By_ID.IsOn Then xuc_Chart_Of_Account.Toggle_Save_By_ID.IsOn = False

                If xuc_Settings.Toggle_Auto_Reload.IsOn Then
                    Data_Load()
                Else
                    Data_Row_Update()
                End If
            End If
        End Sub

        Private Sub Data_Row_Update()
            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0
                    data_Update_TreeList()
                Case 1
                    data_Update_gridView()
            End Select
        End Sub

        Private Sub btn_Delete_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Delete.ItemClick

            Me.xuc_Chart_Of_Account.control_Delete()
        End Sub

        Private Sub data_Show_TreeView()
            If treeList.AllNodesCount > 0 Then
                Try
                    With xuc_Chart_Of_Account
                        .ID.EditValue = treeList.GetFocusedRowCellDisplayText(colID1)
                        .sOldCOACode = treeList.GetFocusedRowCellDisplayText(colCOA_Code1)
                        .COA_Code.Text = treeList.GetFocusedRowCellDisplayText(colCOA_Code1)
                        .Corporation.EditValue = treeList.GetFocusedRowCellValue(colCorporation1)
                        .COA_Statement.Text = treeList.GetFocusedRowCellDisplayText(colCOA_Statement1)
                        .COA_Level.Text = treeList.GetFocusedRowCellDisplayText(colCOA_Level1)
                        .COA_Type.Text = treeList.GetFocusedRowCellDisplayText(colCOA_Type1)
                        .COA_Summary.EditValue = RepositoryItemLookUpEdit_COA.GetKeyValueByDisplayText(treeList.GetFocusedRowCellDisplayText(colCOA_Summary1))
                        .COA_Name.Text = treeList.GetFocusedRowCellDisplayText(colCOA_Name1)
                        .FS_Name.Text = treeList.GetFocusedRowCellDisplayText(colFS_Name1)
                        .COA_Desc.Text = treeList.GetFocusedRowCellDisplayText(colCOA_Desc1)
                        .COA_Normal.Text = treeList.GetFocusedRowCellDisplayText(colCOA_Normal1)
                        .Notes.Text = treeList.GetFocusedRowCellDisplayText(colNotes1)
                        .IsFS.Checked = treeList.GetFocusedRowCellValue(colIsFS1)
                        .Balance.Value = treeList.GetFocusedRowCellValue(colBalance1)
                        .Balance_Date.EditValue = treeList.GetFocusedRowCellValue(colBalance_Date1)
                        .Balance_Running.Value = treeList.GetFocusedRowCellValue(colBalance_Running1)
                        .Balance_Limit.Value = treeList.GetFocusedRowCellValue(colBalance_Limit1)
                    End With
                Catch ex As Exception
                    'class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr,  $"{ex.Source}{Environment.NewLine}{ex.HResult}{Environment.NewLine}{ex.Message}")
                End Try
            End If
        End Sub

        Private Sub data_Show_gridView()
            If gridView.RowCount > 0 Then
                Try
                    With xuc_Chart_Of_Account
                        .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                        .sOldCOACode = gridView.GetFocusedRowCellDisplayText(colCOA_Code)
                        .COA_Code.Text = gridView.GetFocusedRowCellDisplayText(colCOA_Code)
                        .Corporation.EditValue = gridView.GetFocusedRowCellValue(colCorporation)
                        .COA_Statement.Text = gridView.GetFocusedRowCellDisplayText(colCOA_Statement)
                        .COA_Level.Text = gridView.GetFocusedRowCellDisplayText(colCOA_Level)
                        .COA_Type.Text = gridView.GetFocusedRowCellDisplayText(colCOA_Type)
                        .COA_Summary.EditValue = RepositoryItemLookUpEdit_COA.GetKeyValueByDisplayText(gridView.GetFocusedRowCellDisplayText(colCOA_Summary))
                        .COA_Name.Text = gridView.GetFocusedRowCellDisplayText(colCOA_Name)
                        .FS_Name.Text = gridView.GetFocusedRowCellDisplayText(colFS_Name)
                        .COA_Desc.Text = gridView.GetFocusedRowCellDisplayText(colCOA_Desc)
                        .COA_Normal.Text = gridView.GetFocusedRowCellDisplayText(colCOA_Normal)
                        .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                        .IsFS.Checked = gridView.GetFocusedRowCellValue(colIsFS)
                        .IsLedger.Checked = gridView.GetFocusedRowCellValue(colIsLedger)
                        .Balance.Value = gridView.GetFocusedRowCellValue(colBalance)
                        .Balance_Date.EditValue = gridView.GetFocusedRowCellValue(colBalance_Date)
                        .Balance_Running.Value = gridView.GetFocusedRowCellValue(colBalance_Running)
                        .Balance_Limit.Value = gridView.GetFocusedRowCellValue(colBalance_Limit)
                    End With
                Catch ex As Exception
                    'class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub data_Update_TreeList()
            With treeList
                .SetFocusedRowCellValue(colID1, xuc_Chart_Of_Account.ID.EditValue)
                .SetFocusedRowCellValue(colCOA_Code1, xuc_Chart_Of_Account.sOldCOACode)
                .SetFocusedRowCellValue(colCOA_Code1, xuc_Chart_Of_Account.COA_Code.Text)
                .SetFocusedRowCellValue(colCorporation1, xuc_Chart_Of_Account.Corporation.EditValue.ToString)
                .SetFocusedRowCellValue(colCOA_Statement1, xuc_Chart_Of_Account.COA_Statement.Text)
                .SetFocusedRowCellValue(colCOA_Level1, xuc_Chart_Of_Account.COA_Level.Text)
                .SetFocusedRowCellValue(colCOA_Type1, xuc_Chart_Of_Account.COA_Type.Text)
                .SetFocusedRowCellValue(colCOA_Summary1, xuc_Chart_Of_Account.COA_Summary.EditValue)
                .SetFocusedRowCellValue(colCOA_Name1, xuc_Chart_Of_Account.COA_Name.Text)
                .SetFocusedRowCellValue(colFS_Name1, xuc_Chart_Of_Account.FS_Name.Text)
                .SetFocusedRowCellValue(colCOA_Desc1, xuc_Chart_Of_Account.COA_Desc.Text)
                .SetFocusedRowCellValue(colCOA_Normal1, xuc_Chart_Of_Account.COA_Normal.Text)
                .SetFocusedRowCellValue(colIsFS1, xuc_Chart_Of_Account.IsFS.Checked)
                .SetFocusedRowCellValue(colIsLedger1, xuc_Chart_Of_Account.IsLedger.Checked)
                .SetFocusedRowCellValue(colBalance1, xuc_Chart_Of_Account.Balance.Value)
                .SetFocusedRowCellValue(colBalance_Date1, xuc_Chart_Of_Account.Balance_Date.EditValue)
                .SetFocusedRowCellValue(colBalance_Running1, xuc_Chart_Of_Account.Balance_Running.Value)
                .SetFocusedRowCellValue(colBalance_Limit1, xuc_Chart_Of_Account.Balance_Limit.Value)
                .SetFocusedRowCellValue(colNotes1, xuc_Chart_Of_Account.Notes.Text)
                .RefreshNode(.FocusedNode)
            End With
        End Sub

        Private Sub data_Update_gridView()
            With gridView
                .SetFocusedRowCellValue(colID, xuc_Chart_Of_Account.ID.EditValue)
                .SetFocusedRowCellValue(colCOA_Code, xuc_Chart_Of_Account.sOldCOACode)
                .SetFocusedRowCellValue(colCOA_Code, xuc_Chart_Of_Account.COA_Code.Text)
                .SetFocusedRowCellValue(colCorporation, xuc_Chart_Of_Account.Corporation.EditValue.ToString)
                .SetFocusedRowCellValue(colCOA_Statement, xuc_Chart_Of_Account.COA_Statement.Text)
                .SetFocusedRowCellValue(colCOA_Level, xuc_Chart_Of_Account.COA_Level.Text)
                .SetFocusedRowCellValue(colCOA_Type, xuc_Chart_Of_Account.COA_Type.Text)
                .SetFocusedRowCellValue(colCOA_Summary, xuc_Chart_Of_Account.COA_Summary.EditValue)
                .SetFocusedRowCellValue(colCOA_Name, xuc_Chart_Of_Account.COA_Name.Text)
                .SetFocusedRowCellValue(colFS_Name, xuc_Chart_Of_Account.FS_Name.Text)
                .SetFocusedRowCellValue(colCOA_Desc, xuc_Chart_Of_Account.COA_Desc.Text)
                .SetFocusedRowCellValue(colCOA_Normal, xuc_Chart_Of_Account.COA_Normal.Text)
                .SetFocusedRowCellValue(colIsFS, xuc_Chart_Of_Account.IsFS.Checked)
                .SetFocusedRowCellValue(colIsLedger, xuc_Chart_Of_Account.IsLedger.Checked)
                .SetFocusedRowCellValue(colBalance, xuc_Chart_Of_Account.Balance.Value)
                .SetFocusedRowCellValue(colBalance_Date, xuc_Chart_Of_Account.Balance_Date.EditValue)
                .SetFocusedRowCellValue(colBalance_Running, xuc_Chart_Of_Account.Balance_Running.Value)
                .SetFocusedRowCellValue(colBalance_Limit, xuc_Chart_Of_Account.Balance_Limit.Value)
                .SetFocusedRowCellValue(colNotes, xuc_Chart_Of_Account.Notes.Text)
                .RefreshRow(.FocusedRowHandle)
            End With
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If gridView.SelectedRowsCount > 0 Then

                Select Case e.KeyCode
                    Case Keys.F7
                        class_Saga_Procedures.Show_COA_Ledger(gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name))

                    Case Keys.Delete
                        If xuc_Chart_Of_Account.control_Delete() Then gridView.DeleteRow(gridView.FocusedRowHandle)

                    Case Else
                        data_Show_gridView()
                End Select
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then data_Show_gridView()
        End Sub

        Private Sub treeList_FocusedNodeChanged(sender As Object, e As FocusedNodeChangedEventArgs) Handles treeList.FocusedNodeChanged
            If xuc_Settings.Toggle_Select.IsOn Then data_Show_TreeView()
        End Sub

        Private Sub gridViewCOA_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles gridViewCOA.DoubleClick
            If gridViewCOA.RowCount > 0 Then
                With xuc_Chart_Of_Account
                    .COA_Code.Text = gridViewCOA.GetFocusedRowCellDisplayText(colAccountCode)
                    .COA_Level.Text = gridViewCOA.GetFocusedRowCellDisplayText(colSummaryAccount)
                    .COA_Name.Text = gridViewCOA.GetFocusedRowCellDisplayText(colDescription)
                End With
            End If
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If (gridView.RowCount > 0) AndAlso e.Clicks.Equals(2) Then

                iRowSelected = gridView.FocusedRowHandle
                Select Case e.Column.Name
                    Case "colAccountCode", "colCOA_Summary"
                        xuc_Chart_Of_Account.Control_Retrieve(e.CellValue.ToString)

                    Case Else
                        data_Show_gridView()
                        If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                End Select
            End If
        End Sub

        Private Sub gridView_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView.MouseDown
            If e.Button.Equals(MouseButtons.Right) AndAlso gridView.RowCount > 0 Then popupMenu.ShowPopup(Control.MousePosition)
        End Sub

        Private Sub treeList_MouseDown(sender As Object, e As MouseEventArgs) Handles treeList.MouseDown
            If e.Button.Equals(MouseButtons.Right) AndAlso treeList.AllNodesCount > 0 Then popupMenu.ShowPopup(Control.MousePosition)
        End Sub

        Private Sub treeList_KeyDown(sender As Object, e As KeyEventArgs) Handles treeList.KeyDown
            If treeList.VisibleNodesCount > 0 Then
                Select Case e.KeyCode
                    Case Keys.F7
                        class_Saga_Procedures.Show_COA_Ledger(gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name))

                    Case Keys.Delete
                        If xuc_Chart_Of_Account.control_Delete() Then treeList.DeleteNode(treeList.FocusedNode)

                    Case Else
                        data_Show_TreeView()
                End Select
            End If
        End Sub

        Private Sub btn_Insert_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Insert.ItemClick


            data_Show_TreeView()

            With xuc_Chart_Of_Account
                If .COA_Type.Text.Equals("SUMMARY") Then
                    class_Saga_Variables.Initialize_COA_Summary()
                    class_Saga_Procedures.Initialize_COA(.COA_Summary, eCOA_Type.COA_Summary)
                    .COA_Summary.EditValue = xuc_Chart_Of_Account.COA_Code.Text
                    .COA_Code.Text = $"{xuc_Chart_Of_Account.COA_Code.Text}01"
                    .COA_Type.Text = "DETAIL"
                    .COA_Level.Value = xuc_Chart_Of_Account.COA_Level.Value + 1
                End If

                .COA_Name.Text = class_Functions.Show_Input_Box($"Input new Account Title", "Insert Account", String.Empty)
                .Control_Save(xuc_Chart_Of_Account.COA_Code.Text.Trim)
            End With
        End Sub

        Private Sub treeList_DoubleClick(sender As Object, e As EventArgs) Handles treeList.DoubleClick
            'xuc_Chart_Of_Account.Control_Retrieve(CStr(treeList.FocusedNode.GetDisplayText(colCOA_Code1)))
        End Sub

        Private Sub btn_Convert_Summary_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Convert_Summary.ItemClick

            If class_Variables.isAdministrator Then
                If class_Procedures.actionAsk("Convert Account", "Convert to Summary", "You might convert the wrong Account") Then
                    data_Show_TreeView()

                    If class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Chart_Of_Accounts SET COA_Type = 'SUMMARY', COA_Name = '{xuc_Chart_Of_Account.COA_Name.Text.ToUpper}' WHERE COA_Code LIKE '{xuc_Chart_Of_Account.COA_Code.Text.Trim}'") Then
                        xuc_Chart_Of_Account.Control_Initialize()
                        xuc_Chart_Of_Account.Control_Retrieve(xuc_Chart_Of_Account.COA_Code.Text)
                        class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "Account Title has been successfully converted into Summary", "Convert to Summary")
                    End If
                End If
            End If
        End Sub

        Private Sub btn_Lock_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Lock.ItemClick
            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0
                    Try
                        If xuc_Chart_Of_Account.control_Lock(treeList.GetFocusedRowCellDisplayText(colCOA_Code1), Not treeList.GetFocusedRowCellValue(colIsLocked1)) > 0 Then
                            treeList.SetFocusedRowCellValue(colIsLocked1, Not treeList.GetFocusedRowCellValue(colIsLocked1))
                        End If
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    End Try
                Case 1
                    With gridView
                        If Not class_Procedures.actionAsk("Lock/Unlock Account Title", "Lock/Unlock Account Title", "Only Admin can lock/unlock the Account Title") Then Return

                        Dim iRowHandle, iRowHandleOld As Integer
                        Dim selectedRows As Integer() = .GetSelectedRows()

                        Dim bLock As Boolean

                        bLoopStop = False
                        .ClearSelection()

                        For i As Integer = 0 To selectedRows.Length - 1
                            iRowHandle = selectedRows(i)

                            If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Lock/Unlock Account", "locked/unlocked", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
                                iRowHandleOld = iRowHandle
                            Else Return
                            End If

                            Try
                                bLock = Not Convert.ToBoolean(.GetRowCellValue(iRowHandle, colIsLocked))
                            Catch ex As Exception
                                bLock = True
                            End Try

                            If Not xuc_Chart_Of_Account.control_Lock(.GetRowCellDisplayText(iRowHandle, colCOA_Code), bLock, False).Equals(0) Then
                                .SetRowCellValue(iRowHandle, colIsLocked, bLock)
                            End If
                        Next
                    End With
            End Select
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub btn_FS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_FS.ItemClick
            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0
                    Try
                        If xuc_Chart_Of_Account.control_FS(treeList.GetFocusedRowCellDisplayText(colCOA_Code1), Not treeList.GetFocusedRowCellValue(colIsFS1)) > 0 Then
                            treeList.SetFocusedRowCellValue(colIsFS1, Not treeList.GetFocusedRowCellValue(colIsFS1))
                        End If
                    Catch ex As Exception
                        class_Procedures.Show_Error(ex)
                    End Try
                Case 1
                    With gridView
                        If Not class_Procedures.actionAsk("Show/Unshow to Financial Statement", "Show/Unshow to Financial Statement", "Only Admin can Show/Unshow to Financial Statement") Then Return

                        Dim iRowHandle, iRowHandleOld As Integer
                        Dim selectedRows As Integer() = .GetSelectedRows()

                        Dim bLock As Boolean

                        bLoopStop = False
                        .ClearSelection()

                        For i As Integer = 0 To selectedRows.Length - 1
                            iRowHandle = selectedRows(i)

                            If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Show/Unshow Account Title", "showed/unshowed", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
                                iRowHandleOld = iRowHandle
                            Else Return
                            End If

                            Try
                                bLock = Not Convert.ToBoolean(.GetRowCellValue(iRowHandle, colIsFS))
                            Catch ex As Exception
                                bLock = True
                            End Try

                            If Not xuc_Chart_Of_Account.control_FS(.GetRowCellDisplayText(iRowHandle, colCOA_Code), bLock, False).Equals(0) Then
                                .SetRowCellValue(iRowHandle, colIsFS, bLock)
                            End If
                        Next
                    End With
            End Select
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        'Private Sub btn_Account_Code_Re_Assign_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Account_Code_Re_Assign.ItemClick
        '    Dim iCOASummary As Integer = Convert.ToInt32(xuc_Chart_Of_Account.COA_Summary.EditValue)
        '    Dim iCOACode As Integer = Convert.ToInt32(xuc_Chart_Of_Account.COA_Code.Text.Trim.Substring(iCOASummary.ToString.Length))
        '    Dim sCOACodeOld As String = xuc_Chart_Of_Account.COA_Code.Text.Trim '$"{iCOASummary}0{iCOACode}"

        '    'Dim COACodeOld As String = xuc_Chart_Of_Account.COA_Code.Text.Trim

        '    Dim sCOACodeNew As String = class_Functions.Show_Input_Box("Input New Account Code", "Re-Assign Account Code", class_Functions.Generate_ID($"{iCOASummary}", 3, iCOACode))

        '    If class_Database.Data_Save_Ask(class_Database.ICSConnection, "Re-Assign Account Code", $"SELECT COA_Code FROM acc_Chart_Of_Accounts WHERE COA_Code LIKE '{sCOACodeNew}'") Then

        '        With xuc_Chart_Of_Account
        '            .COA_Code.Text = sCOACodeNew

        '            If .Control_Save(sCOACodeOld, True) AndAlso class_Database.Data_Replace(class_Database.ICSConnection, "Account Code", "acc_Journal_Entries", "COA_Code", sCOACodeOld, sCOACodeNew) Then
        '                class_Database.Data_Update(class_Database.ICSConnection, $"UPDATE acc_Balances SET COA_Code = {sCOACodeNew} WHERE COA_Code LIKE {sCOACodeOld}", True)
        '                Data_Row_Update()
        '            End If

        '            .Toggle_Save_By_ID.IsOn = False
        '        End With

        '    End If
        'End Sub

        Private Sub btn_Migrate_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Migrate.ItemClick
            Dim sCOACodeNew As String = class_Functions.Show_Input_Box("Input Account Code to migrate", "New Account Code", xuc_Chart_Of_Account.COA_Code.Text.Trim)

            If class_Database.IsDataExist(class_Database.ICSConnection, $"SELECT COA_Code FROM acc_Chart_Of_Accounts WHERE COA_Code LIKE '{sCOACodeNew}'") Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Account Title Code already exist!", "Migration Error", True)
                Return
            End If

            If class_Variables.isAdministrator AndAlso class_Procedures.actionAsk("Migrate to Account", "Migrate all Journal Entries to Account") Then
                Dim sqlParameters As SqlParameter() = {
                    New SqlParameter("@COA_Code", xuc_Chart_Of_Account.COA_Code.Text.Trim),
                    New SqlParameter("@COA_Code_New", sCOACodeNew),
                    New SqlParameter("@Action_Type", "MIGRATE")
                }
                class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_COA_Procedures", "Migrate Account", sCOACodeNew)
            End If
        End Sub

        Private Sub btn_Another_Entry_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Another_Entry.ItemClick
            With xuc_Chart_Of_Account
                If .Control_Another_Entry() Then
                    .COA_Name.Select()
                End If
            End With
        End Sub

        Private Sub btn_Expand_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Expand.ItemClick
            toggle_Auto_Expand.IsOn = True
        End Sub

        Private Sub btn_Collapse_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Collapse.ItemClick
            toggle_Auto_Expand.IsOn = False
        End Sub

        Private Sub toggle_Auto_Expand_Toggled(sender As Object, e As EventArgs) Handles toggle_Auto_Expand.Toggled
            If toggle_Auto_Expand.IsOn Then
                treeList.ExpandAll()
            Else
                treeList.CollapseAll()
            End If
        End Sub

        Private Sub btn_COA_Ledger_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_COA_Ledger.ItemClick
            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0
                    class_Saga_Procedures.Show_COA_Ledger(treeList.GetFocusedRowCellDisplayText(colCOA_Code1), treeList.GetFocusedRowCellDisplayText(colCOA_Name1))

                Case 1
                    class_Saga_Procedures.Show_COA_Ledger(gridView.GetFocusedRowCellDisplayText(colCOA_Code), gridView.GetFocusedRowCellDisplayText(colCOA_Name))
            End Select
        End Sub

        Private Sub BarEditItem_Date_Type_EditValueChanged(sender As Object, e As EventArgs) Handles BarEditItem_Date_Type.EditValueChanged
            Select Case BarEditItem_Date_Type.EditValue
                Case "DAILY"
                    eDateType = class_Saga_Variables.eLoad_Type.Daily
                Case "MONTHLY"
                    eDateType = class_Saga_Variables.eLoad_Type.Monthly
                Case "RANGE"
                    eDateType = class_Saga_Variables.eLoad_Type.Range
            End Select
        End Sub

        Friend Sub btn_Trial_Balance_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Trial_Balance.ItemClick
            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0
                    Dim sCOAType As String = treeList.GetFocusedRowCellDisplayText(colCOA_Type1)
                    Dim sCOACode As String = treeList.GetFocusedRowCellDisplayText(colCOA_Code1)
                    Select Case sCOAType
                        Case "SUMMARY"
                            class_Saga_Database.Balance_Save("UPDATE_TOTAL", "SUMMARY", eDateType, class_Saga_Variables.sBranchCode, sCOACode, class_Saga_Variables.dtStart)
                            class_Saga_Database.Balance_Save("UPDATE_TOTAL", "DETAIL", eDateType, class_Saga_Variables.sBranchCode, sCOACode, class_Saga_Variables.dtStart)
                        Case "DETAIL"
                            class_Saga_Database.Balance_Save("UPDATE_TOTAL", "DETAIL", eDateType, class_Saga_Variables.sBranchCode, sCOACode, class_Saga_Variables.dtStart)
                    End Select
                Case 1
                    With gridView
                        If .SelectedRowsCount > 0 Then
                            If Not class_Procedures.actionAsk("Generate Trial Balances", "Generate Trial Balances") Then Return
                            class_Database.DBError = False
                            class_Procedures.splash_Show("Generating Trial Balances")

                            Dim iRowHandle, iRowHandleOld As Integer
                            Dim selectedRows As Integer() = .GetSelectedRows()

                            bLoopStop = False
                            .ClearSelection()

                            For i As Integer = 0 To selectedRows.Length - 1
                                iRowHandle = selectedRows(i)

                                If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Trial Balance", "generated", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
                                    iRowHandleOld = iRowHandle
                                Else Return
                                End If

                                Dim sCOACode As String = .GetRowCellDisplayText(iRowHandle, colCOA_Code)

                                If toggle_Balance_Type.Checked Then
                                    If .GetRowCellDisplayText(iRowHandle, colCOA_Type).Equals("SUMMARY") Then
                                        class_Saga_Database.Balance_Save("UPDATE_TOTAL", "SUMMARY", eDateType, class_Saga_Variables.sBranchCode, sCOACode, class_Saga_Variables.dtStart)
                                    End If
                                Else
                                    Select Case .GetRowCellDisplayText(iRowHandle, colCOA_Type)
                                        Case "SUMMARY"
                                            class_Saga_Database.Balance_Save("UPDATE_TOTAL", "SUMMARY", eDateType, class_Saga_Variables.sBranchCode, sCOACode, class_Saga_Variables.dtStart)
                                            class_Saga_Database.Balance_Save("UPDATE_TOTAL", "DETAIL", eDateType, class_Saga_Variables.sBranchCode, sCOACode, class_Saga_Variables.dtStart)
                                        Case "DETAIL"
                                            class_Saga_Database.Balance_Save("UPDATE_TOTAL", "DETAIL", eDateType, class_Saga_Variables.sBranchCode, sCOACode, class_Saga_Variables.dtStart)
                                    End Select
                                End If
                            Next

                            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Selected Account Titles were successfully generated.", "Chart Of Accounts Generation")
                            class_Procedures.splash_Close()
                        End If
                    End With
            End Select
        End Sub

        Friend Sub btn_Update_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Update.ItemClick
            With gridView
                If .SelectedRowsCount > 0 Then
                    If Not class_Procedures.actionAsk("Update Account Titles", "Update Account Titles") Then Return
                    class_Database.DBError = False
                    Dim iRowHandle, iRowHandleOld As Integer
                    Dim selectedRows As Integer() = .GetSelectedRows()

                    bLoopStop = False
                    .ClearSelection()

                    For i As Integer = 0 To selectedRows.Length - 1
                        iRowHandle = selectedRows(i)

                        If class_Functions.gridView_Loop(gridView, iRowHandleOld, iRowHandle, "Account Title", "udpated", bLoopStop, xuc_Settings.Toggle_Live_Looping.IsOn) Then
                            iRowHandleOld = iRowHandle
                        Else Return
                        End If

                        Dim sqlParameters As SqlParameter() = {
                            New SqlParameter("@COA_Code", .GetRowCellValue(iRowHandle, colCOA_Code)),
                            New SqlParameter("@COA_Summary", .GetRowCellValue(iRowHandle, colCOA_Summary)),
                            New SqlParameter("@Action_Type", "UPDATE")
                        }
                        class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_COA_Procedures", "Update Account Title")
                    Next

                    class_Procedures.Set_Message(class_Procedures.MsgMode.Info, $"Selected Account Titles were successfully generated.", "Account Titles update")
                End If
            End With
        End Sub

        Friend Sub btn_Stop_ItemClick(sender As Object, e As ItemClickEventArgs) Handles btn_Stop.ItemClick
            bLoopStop = True
        End Sub
    End Class
End Namespace