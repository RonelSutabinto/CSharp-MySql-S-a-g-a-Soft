Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace Forms.Accounting

    Public Class frm_Payment_Requests
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If xuc_Payment_Request Is Nothing Then
                Me.xuc_Payment_Request = New Controls.Accounting.xuc_Payment_Request()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, xuc_Payment_Request.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Payment_Requests_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(xuc_Payment_Request.Branch_Code)
            class_Saga_Procedures.Initialize_Branch(RepositoryItemLookUpEdit_Branch)
        End Sub

        Private Sub frm_Payment_Requests_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Payment_Request.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, xuc_Payment_Request.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Payment_Requests_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Payment_Request.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM acc_Payment_Requests WHERE Payee_Name LIKE '%{sSearch}%' OR Payee_Address LIKE '%{sSearch}%' OR Request_Description LIKE '%{sSearch}%' OR Notes LIKE '%{sSearch}%'", "acc_Payment_Requests")
            End If
        End Sub

        Private Sub Data_Load()
            Dim sqlParameters As SqlParameter()
            If xuc_Settings.Toggle_Load_All.IsOn Then
                sqlParameters = {New SqlParameter("@Action_Type", "LOAD_ALL")}
            Else
                sqlParameters = {New SqlParameter("@Branch_Code", xuc_Payment_Request.Branch_Code.EditValue),
                              New SqlParameter("@Action_Type", "LOAD_BRANCH")}
            End If

            class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, gridControl, gridView, "acc_Payment_Request_Procedures", "Payment Requests")
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

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Payment_Request
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colID)
                    .Request_Code.Text = gridView.GetFocusedRowCellDisplayText(colRequest_Code)
                    .Branch_Code.EditValue = gridView.GetFocusedRowCellValue(colBranch_Code)
                    .Request_Type.Text = gridView.GetFocusedRowCellDisplayText(colRequest_Type)
                    .Request_Date.EditValue = gridView.GetFocusedRowCellValue(colRequest_Date)
                    .Request_Amount.EditValue = gridView.GetFocusedRowCellValue(colRequest_Amount)
                    .Payee_Name.Text = gridView.GetFocusedRowCellDisplayText(colPayee_Name)
                    .Payee_Address.Text = gridView.GetFocusedRowCellDisplayText(colPayee_Address)
                    .Request_Description.Text = gridView.GetFocusedRowCellDisplayText(colRequest_Description)
                    .Notes.Text = gridView.GetFocusedRowCellDisplayText(colNotes)
                End With
            End If
        End Sub

        Private Sub gridView_MouseDown(sender As Object, e As MouseEventArgs) Handles gridView.MouseDown
            If gridView.RowCount > 0 AndAlso e.Button.Equals(System.Windows.Forms.MouseButtons.Right) Then
                PopupMenu.ShowPopup(Control.MousePosition)
            End If
        End Sub

        Private Sub gridView_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            If gridView.DataRowCount > 0 AndAlso e.Clicks.Equals(2) Then
                Data_Show()
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gridView.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then Data_Show()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Payment_Request.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Payment_Request.Control_Save() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            'gridView.ShowRibbonPrintPreview()
            Dim xRpt As New Reports.Accounting.xrpt_Payment_Request()
            class_Database.Bind_Report(class_Database.ICSConnection, xRpt, $"SELECT * FROM acc_Payment_Requests WHERE Request_Code LIKE '{gridView.GetFocusedRowCellDisplayText(colRequest_Code)}'", "acc_Payment_Requests")

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 550

                    .Branch_Name.Text = class_Saga_Database.get_Branch_Name(gridView.GetFocusedRowCellValue(colBranch_Code))
                    '.XrTableCell_Request_Date.Text = gridView.GetFocusedRowCellDisplayText(colRequest_Date)

                    .XrTableCell_Payee_Name.Text = gridView.GetFocusedRowCellDisplayText(colPayee_Name)
                    .XrTableCell_Payee_Address.Text = gridView.GetFocusedRowCellDisplayText(colPayee_Address)

                    .XrTableCell_Request_Amount.Text = gridView.GetFocusedRowCellDisplayText(colRequest_Amount)

                    .XrTableCell_Request_Description.Text = gridView.GetFocusedRowCellDisplayText(colRequest_Description)

                    .XrTableCell_Request_Date.Text = Date.Today.ToString("MMMM dd, yyyy")
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            'If xuc_Payment_Request.Control_Delete() Then
            '    gridView.DeleteRow(gridView.FocusedRowHandle)
            'End If
        End Sub
    End Class

End Namespace