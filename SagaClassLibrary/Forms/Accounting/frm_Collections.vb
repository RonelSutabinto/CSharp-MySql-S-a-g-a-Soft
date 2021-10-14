Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_Collections
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If Me.xuc_Grid_Collection Is Nothing Then
                Me.xuc_Grid_Collection = New Controls.Accounting.xuc_Grid_Collection()
            End If

            If Me.xuc_Grid_Cashiering Is Nothing Then
                Me.xuc_Grid_Cashiering = New Controls.Accounting.xuc_Grid_Cashiering()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, BtnCancel, xuc_Settings)
            class_Saga_Procedures.Initialize_BarManager(Me, barManager)

            class_Procedures.Initialize_gridView(xuc_Grid_Collection, xuc_Grid_Collection.gridView)
            class_Procedures.Initialize_gridView(xuc_Grid_Cashiering, xuc_Grid_Cashiering.gridView)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Collections_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Registry_Values_Get()

            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, repositoryItemLookUpEdit_Branch)

            barEditItem_Branch.EditValue = class_Saga_Variables.sBranchCode
            BarEditItem_Posting_Date.Enabled = BarToggleSwitchItem_Custom_Posting_Date.Checked
            BarEditItem_Reason.Enabled = BarToggleSwitchItem_Custom_Posting_Date.Checked

            Me.xuc_Grid_Collection.dtPosting = class_Saga_Variables.dtStart
            Me.xuc_Grid_Cashiering.dtPosting = class_Saga_Variables.dtStart

            btn_Journal.Enabled = class_Saga_Variables.isAccounting Or class_Saga_Variables.isCashier
            btn_Update.Enabled = class_Saga_Variables.isAccounting Or class_Saga_Variables.isCashier
        End Sub

        Private Sub frm_Collections_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then Form_Initialize()
            If Check_Auto_Load_Filter.Checked Then Filter_Load()
        End Sub

        Private Sub Registry_Values_Get()
            BarCheckItem_Corporation.Checked = class_Tools.RegKeyGet(Me.Name, BarCheckItem_Corporation.Name, False)
            BarEditItem_Filter.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Filter.Name, "Default")
            Check_Auto_Load_Filter.Checked = class_Tools.RegKeyGet(Me.Name, Check_Auto_Load_Filter.Name, False)

            BarEditItem_Reason.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Reason.Name, String.Empty)

            class_Saga_Procedures.Initialize_BarManager(xuc_Grid_Collection, xuc_Grid_Collection.barManager)
            class_Saga_Procedures.Initialize_BarManager(xuc_Grid_Cashiering, xuc_Grid_Cashiering.barManager)
        End Sub

        Private Sub Registry_Values_Set()
            class_Tools.RegKeySet(Me.Name, BarCheckItem_Corporation.Name, BarCheckItem_Corporation.Checked)
            class_Tools.RegKeySet(Me.Name, BarEditItem_Filter.Name, BarEditItem_Filter.EditValue.ToString)
            class_Tools.RegKeySet(Me.Name, Check_Auto_Load_Filter.Name, Check_Auto_Load_Filter.Checked)

            class_Tools.RegKeySet(Me.Name, BarEditItem_Reason.Name, BarEditItem_Reason.EditValue.ToString)

            xuc_Grid_Collection.barManager.SaveLayoutToRegistry(xuc_Grid_Collection.Name)
            xuc_Grid_Cashiering.barManager.SaveLayoutToRegistry(xuc_Grid_Cashiering.Name)

            xuc_Grid_Collection.gridView.SaveLayoutToRegistry(xuc_Grid_Collection.Name)
            xuc_Grid_Cashiering.gridView.SaveLayoutToRegistry(xuc_Grid_Cashiering.Name)
        End Sub

        Private Function Form_Close() As Boolean
            Me.xuc_Grid_Collection.bLoopStop = True
            Me.xuc_Grid_Cashiering.bLoopStop = True

            Registry_Values_Set()
            Return class_Procedures.Form_Close(Me, barManager, dockManager, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub frm_Collections_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub RepositoryItemComboBox_Filter_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles RepositoryItemComboBox_Filter.Closed
            If Check_Auto_Load_Filter.Checked Then Filter_Load()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick

            Form_Initialize()
        End Sub

        Private Sub Form_Initialize()
            'class_Database.Fill_Edit(class_Database.ICSConnection, RepositoryItemComboBox_Filter, "acc_Grid_Filters", "Filter_Group", "Filter_Name", "Payment Collections")
            'class_Database.Fill_Edit(class_Database.ICSConnection, RepositoryItemComboBox_Filter, "acc_Grid_Filters", "Filter_Group", "Filter_Name", "Payment Collections", $"AND Filter_User LIKE '{class_Variables.sUserName}'")
        End Sub

        Private Sub Filter_Load()
            Dim sFilter As String = BarEditItem_Filter.EditValue.ToString.Trim
            Try
                Select Case XtraTabControl.SelectedTabPageIndex
                    Case 0
                        xuc_Grid_Collection.gridView.RestoreLayoutFromXml($"Payment {sFilter}")
                    Case 1
                        xuc_Grid_Cashiering.gridView.RestoreLayoutFromXml($"Cashiering {sFilter}")
                End Select
            Catch Ex As System.IO.FileNotFoundException
                class_Procedures.Show_Error(Ex)
            End Try
        End Sub

        Private Sub btn_Filter_Load_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Filter_Load.ItemClick
            Filter_Load()
        End Sub

        Private Sub btn_Filter_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Filter_Save.ItemClick
            Dim sFilter As String = BarEditItem_Filter.EditValue.ToString.Trim
            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0
                    class_Saga_Database.Filter_Save(xuc_Grid_Collection.gridView, "Payment", sFilter)
                Case 1
                    class_Saga_Database.Filter_Save(xuc_Grid_Cashiering.gridView, "Cashiering", sFilter)
            End Select
        End Sub

        Private Sub btn_Filter_Remove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Filter_Delete.ItemClick
            Dim sFilter As String = BarEditItem_Filter.EditValue.ToString.Trim
            class_Database.Data_Delete_Ask(class_Database.ICSConnection, $"FROM acc_Grid_Filters WHERE Filter_Name LIKE '{sFilter}'", $"Grid Filter: {sFilter}")
        End Sub

        Private Sub Load_Collection()

            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0
                    'Don't remove
                    'This is very important mode parameter
                    xuc_Grid_Collection.eLoadType = class_Saga_Variables.eLoad_Type.Range
                    xuc_Grid_Collection.Control_Data_Load()

                Case 1
                    xuc_Grid_Cashiering.Control_Data_Load()

            End Select
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Load_Collection()
        End Sub

        Private Sub btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick

        End Sub

        Private Sub btn_Batch_Transactions_Load_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Batch_Transactions.ItemClick
            Load_Collection()
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                xuc_Grid_Collection.Control_Data_Load("LOAD_SEARCH", sSearch)
                xuc_Grid_Cashiering.Control_Data_Load("LOAD_SEARCH", sSearch)
            End If
        End Sub

        Private Sub RepositoryItemSearchControl_Search_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles RepositoryItemSearchControl_Search.KeyDown
            If (TypeOf sender Is BaseEdit) AndAlso (e.KeyCode.Equals(Keys.Enter)) Then
                Try
                    Load_Search((CType(sender, BaseEdit)).Text.Trim)
                Catch ex As Exception
                    class_Procedures.Show_Error(ex)
                End Try
            End If
        End Sub

        Private Sub btn_Validation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Validate.ItemClick
            xuc_Grid_Collection.Validate_Payments()
            xuc_Grid_Cashiering.Validate_Payments()
        End Sub

        Private Sub btn_Update_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Update.ItemClick
            xuc_Grid_Collection.Payment_Update()
            xuc_Grid_Cashiering.Update_List()
        End Sub

        Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick

            Select Case XtraTabControl.SelectedTabPageIndex
                Case 0
                    Me.xuc_Grid_Collection.Show_Journal_Entries()
                Case 1
                    Me.xuc_Grid_Cashiering.Show_Journal_Entries()
            End Select
        End Sub

        Private Sub btn_Journal_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal.ItemClick
            xuc_Grid_Collection.Execute_Collections_Journal(True)
        End Sub

        Private Sub btn_Stop_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Stop.ItemClick
            xuc_Grid_Collection.bLoopStop = True
            xuc_Grid_Cashiering.bLoopStop = True
            class_Saga_Variables.bLoopStop = True
        End Sub

        Private Sub RadioGroup_Mode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RadioGroup_Mode.SelectedIndexChanged
            Me.xuc_Grid_Collection.iLoopActionMode = RadioGroup_Mode.SelectedIndex
            Me.xuc_Grid_Cashiering.iLoopActionMode = RadioGroup_Mode.SelectedIndex
        End Sub

        Private Sub Check_Update_Table_ID_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Update_Table_ID.CheckedChanged
            Me.xuc_Grid_Cashiering.bUpdateTableID = Check_Update_Table_ID.Checked
            Me.xuc_Grid_Collection.bUpdateTableID = Check_Update_Table_ID.Checked
        End Sub

        Private Sub Check_OR_Number_Update_CheckedChanged(sender As Object, e As EventArgs) Handles Check_OR_Number_Update.CheckedChanged
            Me.xuc_Grid_Cashiering.bUpdateORNumber = Check_OR_Number_Update.Checked
            Me.xuc_Grid_Collection.bUpdateORNumber = Check_OR_Number_Update.Checked
        End Sub

        Private Sub barEditItem_Branch_EditValueChanged(sender As Object, e As EventArgs) Handles barEditItem_Branch.EditValueChanged
            xuc_Grid_Collection.sBrCode = barEditItem_Branch.EditValue.ToString
            xuc_Grid_Cashiering.sBrCode = barEditItem_Branch.EditValue.ToString
        End Sub

    End Class

End Namespace