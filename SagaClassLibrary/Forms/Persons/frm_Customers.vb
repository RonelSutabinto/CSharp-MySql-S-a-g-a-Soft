Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Forms.Persons

    Public Class frm_Customers
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If Me.xuc_Customer Is Nothing Then
                Me.xuc_Customer = New Controls.Persons.xuc_Customer()
            End If

            If Me.xuc_Accounts Is Nothing Then
                Me.xuc_Accounts = New Controls.Information.Account.xuc_Accounts()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, dockManager, gridView, BtnCancel, xuc_Customer.LayoutControl, xuc_Settings)

            class_Saga_Procedures.Initialize_BarManager(Me, barManager, xuc_Settings)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Customers_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            class_Saga_Procedures.Initialize_Branch(xuc_Customer.Branch_Code)
            class_Saga_Procedures.Initialize_Branch(barEditItem_Branch, RepositoryItemLookUpEdit_Branch)
            colBranchCode.ColumnEdit = RepositoryItemLookUpEdit_Branch

            class_Procedures.Initialize_gridView(xuc_Accounts.gridView)

            barEditItem_Branch.Enabled = class_Saga_Variables.sBranchCode.Equals("000")
            xuc_Customer.Branch_Code.Enabled = class_Saga_Variables.sBranchCode.Equals("000")

            btn_Delete.Enabled = class_Variables.isAdministrator
        End Sub

        Private Sub frm_Customers_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            If xuc_Settings.Toggle_Auto_Initialize.IsOn Then xuc_Customer.Control_Initialize()
            If xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, barManager, dockManager, gridView, xuc_Customer.LayoutControl, xuc_Settings, Control.ModifierKeys = Keys.Shift, True)
        End Function

        Private Sub frm_Customers_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Initialize_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Customer.Control_Initialize()
        End Sub

        Private Sub btn_Reload_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Reload.ItemClick
            Data_Load()
        End Sub

        Private Sub Data_Load()
            If barEditItem_Branch.EditValue.ToString.Equals("000") OrElse xuc_Settings.Toggle_Load_All.IsOn Then
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, "SELECT * FROM CIFAccounts", "CIFAccounts")
            Else
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM CIFAccounts WHERE BranchCode LIKE '{barEditItem_Branch.EditValue}'", "CIFAccounts")
            End If
        End Sub

        Private Sub Load_Search(ByVal sSearch As String)
            If sSearch.Length > 2 Then
                class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM CIFAccounts WHERE CIFKey LIKE '%{sSearch}%' OR FullName LIKE '%{sSearch}%' OR Occupation LIKE '%{sSearch}%' OR ContactNumber LIKE '%{sSearch}%' OR BusinessName LIKE '%{sSearch}%' OR BusAddress LIKE '%{sSearch}%' OR BusAddress LIKE '%{sSearch}%' OR SpouseLName LIKE '%{sSearch}%' OR SpouseFName LIKE '%{sSearch}%'", "CIFAccounts")
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

        Private Sub btn_Account_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Account.ItemClick
            Dim frm As Forms.Information.Account.frm_Account = New Forms.Information.Account.frm_Account()
            frm.Show()
            frm.xuc_Account.Control_Retrieve($"SELECT * FROM CustAccount WHERE CIFKey LIKE '{xuc_Customer.Customer_Code.Text}'")
            class_Procedures.splash_Close()
        End Sub

        Private Sub Data_Show()
            If gridView.RowCount > 0 Then
                With xuc_Customer
                    .Branch_Code.EditValue = gridView.GetFocusedRowCellValue(colBranchCode)
                    .ID.EditValue = gridView.GetFocusedRowCellDisplayText(colSeqID)
                    .Customer_Code.Text = gridView.GetFocusedRowCellDisplayText(colCIFKey)
                    .Customer_Name.Text = gridView.GetFocusedRowCellDisplayText(colFullName)
                    .Customer_Address.Text = gridView.GetFocusedRowCellDisplayText(colAddress)
                    .Customer_Birth_Date.EditValue = gridView.GetFocusedRowCellDisplayText(colBday)
                    .Gender.Text = gridView.GetFocusedRowCellDisplayText(colGender)
                    .Marital_Status.Text = gridView.GetFocusedRowCellDisplayText(colMStatus)
                    .Contact_Number.Text = gridView.GetFocusedRowCellDisplayText(colContactNumber)
                    .Customer_Occupation.Text = gridView.GetFocusedRowCellDisplayText(colOccupation)
                    .Customer_Business_Name.Text = gridView.GetFocusedRowCellDisplayText(colBusinessName)
                    .Customer_Business_Address.Text = gridView.GetFocusedRowCellDisplayText(colBusAddress)
                    .Spouse_Name.Text = gridView.GetFocusedRowCellDisplayText(colSpouseName)
                    .Spouse_Birth_Date.EditValue = gridView.GetFocusedRowCellDisplayText(colSpouseBday)
                    .Spouse_Occupation.Text = gridView.GetFocusedRowCellDisplayText(colSpouseOccupation)
                    .Spouse_Address.Text = gridView.GetFocusedRowCellDisplayText(colSpouseOccupAddress)
                End With
                xuc_Accounts.Control_Data_Load(gridView.GetFocusedRowCellDisplayText(colCIFKey))
            End If
        End Sub

        Private Sub gridView_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView.FocusedRowChanged
            If xuc_Settings.Toggle_Select.IsOn Then Data_Show()
        End Sub

        Private Sub gridView_RowCellClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles gridView.RowCellClick
            With gridView
                If (.RowCount > 0) AndAlso (e.Clicks.Equals(2)) Then
                    Select Case e.Column.Name
                        Case "colSeqID", "colCIFKey"
                            class_Saga_Procedures.Show_Customer(.GetFocusedRowCellDisplayText(colCIFKey))

                        Case "colContactNumber"
                            'Class_SMS.Show_Sender(.GetFocusedRowCellDisplayText(colFullName), .GetFocusedRowCellDisplayText(colContactNumber))

                        Case Else
                            Data_Show()
                            If e.CellValue Is Nothing Then Return Else class_Procedures.Copy_Clipboard(e.CellValue.ToString)

                    End Select
                End If
            End With
        End Sub

        Private Sub gridView_KeyDown(sender As Object, e As KeyEventArgs) Handles gridView.KeyDown
            If e.KeyCode.Equals(Keys.Enter) Then Data_Show()
        End Sub

        Private Sub btn_New_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_New.ItemClick
            xuc_Customer.Control_New(xuc_Settings.Toggle_Clear_On_Action.IsOn)
        End Sub

        Private Sub btn_Save_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Customer.control_Save() AndAlso xuc_Settings.Toggle_Auto_Reload.IsOn Then Data_Load()
        End Sub

        Private Sub gridView_PrintInitialize(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) Handles gridView.PrintInitialize
            class_Procedures.Initialize_Printing(e)
        End Sub

        Private Sub btn_Preview_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            gridView.ShowRibbonPrintPreview()
        End Sub

        Private Sub btn_Delete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Delete.ItemClick
            If xuc_Customer.Control_Delete() Then gridView.DeleteRow(gridView.FocusedRowHandle)
        End Sub

        Private Sub btn_SMS_Blast_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_SMS_Blast.ItemClick
            'Class_SMS.Show_Sender(gridView, "CIFAccounts", "FullName", "ContactNumber", "Notes")
        End Sub

    End Class

End Namespace