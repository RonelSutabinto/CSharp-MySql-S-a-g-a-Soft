Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes
Imports System.Windows.Forms

Namespace Forms.Logistics
    Public Class wzFrm_MC_Transaction
        Public Sub New()
            If Me.xuc_MC_Transaction Is Nothing Then
                Me.xuc_MC_Transaction = New Controls.Logistics.xuc_MC_Transaction()
            End If

            If Me.xuc_Purchase_Order_Units Is Nothing Then
                Me.xuc_Purchase_Order_Units = New Controls.Logistics.xuc_Purchase_Order_Units()
            End If

            If Me.xuc_MC_Transaction_Units Is Nothing Then
                Me.xuc_MC_Transaction_Units = New Controls.Logistics.xuc_MC_Transaction_Units()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, xuc_MC_Transaction.layoutControl, BtnCancel)
            class_Saga_Procedures.Initialize_BarManager(xuc_Purchase_Order_Units, xuc_Purchase_Order_Units.BarManager)
            class_Saga_Procedures.Initialize_BarManager(xuc_Purchase_Order_Units_Generate, xuc_Purchase_Order_Units_Generate.BarManager)
            class_Saga_Procedures.Initialize_BarManager(xuc_MC_Transaction_Units, xuc_MC_Transaction_Units.BarManager)
        End Sub

        Private Function Form_Close() As Boolean
            Try
                class_Tools.RegKeySet(Me.Name, Transaction_Type.Name, Transaction_Type.EditValue)
                class_Tools.RegKeySet(Me.Name, Branch_From.Name, Branch_From.EditValue)
                class_Tools.RegKeySet(Me.Name, Branch_To.Name, Branch_To.EditValue)
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            Finally
                xuc_Purchase_Order_Units.gridView.SaveLayoutToRegistry(xuc_Purchase_Order_Units.Name)
            End Try

            Return class_Procedures.Form_Close(Me, True)
        End Function

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub WizardControl_CancelClick(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WizardControl.CancelClick
            Form_Close()
        End Sub

        Private Sub WizardControl_FinishClick(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WizardControl.FinishClick
            Form_Close()
        End Sub

        Private Sub wzFrm_MC_Transaction_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub wzFrm_MC_Transaction_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            Branch_From.EditValue = class_Saga_Variables.sBranchCode
            Branch_To.EditValue = class_Saga_Variables.sBranchCode

            class_Saga_Procedures.Initialize_MC_Transaction_Type(Transaction_Type)
            class_Saga_Procedures.Initialize_Branch(Branch_To)
            class_Saga_Procedures.Initialize_Branch(xuc_MC_Transaction.Branch_Code)
            class_Saga_Procedures.Initialize_Branch(xuc_MC_Transaction_Units.RepositoryItemLookUpEdit_Branch)
            class_Saga_Procedures.Initialize_Warehouse(WHCode)
            class_Saga_Procedures.Initialize_Warehouse(xuc_MC_Transaction.WHCode)

            xuc_MC_Transaction.Branch_Code.EditValue = class_Saga_Variables.sBranchCode

            Transaction_Type.EditValue = class_Tools.RegKeyGet(Me.Name, Transaction_Type.Name, String.Empty)
            Branch_From.EditValue = class_Saga_Variables.sBranchCode 'class_Tools.RegKeyGet(Me.Name, Branch_From.Name, String.Empty)
            Branch_To.EditValue = class_Tools.RegKeyGet(Me.Name, Branch_To.Name, String.Empty)

            xuc_Purchase_Order_Units.gridView.RestoreLayoutFromRegistry(xuc_Purchase_Order_Units.Name)
            xuc_Purchase_Order_Units_Generate.gridView.RestoreLayoutFromRegistry(xuc_Purchase_Order_Units.Name)
        End Sub

        Private Sub Transaction_Type_EditValueChanged(sender As Object, e As EventArgs) Handles Transaction_Type.EditValueChanged
            WizardPage_Branch_From.Visible = Transaction_Type.Text.Equals("RECEIVING")
            WizardPage_Branch_To.Visible = Transaction_Type.Text.Equals("TRANSFER")
            WizardPage_Purchase_Order.Visible = Transaction_Type.Text.Equals("RECEIVING") Or Transaction_Type.Text.Equals("TRANSFER")
            WizardPage_WHCode.Visible = Transaction_Type.Text.Equals("TRANSFER")
            WizardPage_Reference.Visible = Transaction_Type.Text.Equals("RECEIVING")
            WizardPage_PO_Generate.Visible = Transaction_Type.Text.Equals("RECEIVING")

            Select Case CType(sender, BaseEdit).EditValue.ToString
                Case "RECEIVING"
                    class_Saga_Procedures.Initialize_Brand(Branch_From, "Account_Code", "Account_Name")
                    Branch_To.EditValue = class_Saga_Variables.sBranchCode

                Case Else
                    class_Saga_Procedures.Initialize_Branch(Branch_From)
                    class_Saga_Procedures.Initialize_Branch(Branch_To)
                    Branch_To.EditValue = Nothing

            End Select
        End Sub

        Private Sub Branch_From_EditValueChanged(sender As Object, e As EventArgs) Handles Branch_From.EditValueChanged
            If Transaction_Type.Text.Equals("RECEIVING") Then
                Dim sBrand As String() = Branch_From.Text.Split(" ")
                class_Saga_Procedures.Initialize_Purchase_Order(Order_Code, sBrand(0))
                xuc_MC_Transaction_Units.Brand = sBrand(0)
            End If
        End Sub

        Private Sub Branch_To_EditValueChanged(sender As Object, e As EventArgs) Handles Branch_To.EditValueChanged
            Try
                If Not Branch_From.EditValue.Equals(Branch_To.EditValue) Then
                    'class_Saga_Variables.Initialize_MC_Requests(class_Saga_Variables.sBranchCode, Branch_To.EditValue)
                    class_Saga_Procedures.Initialize_MC_Request(Order_Code, class_Saga_Variables.sBranchCode, Branch_To.EditValue)
                End If
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub

        Private Sub Order_Code_EditValueChanged(sender As Object, e As EventArgs) Handles Order_Code.EditValueChanged
            With xuc_Purchase_Order_Units
                .OrderCode = Order_Code.EditValue
                .Status = "APPROVED"
                .AllBrand = False
                .Load_MC_Orders()
            End With

            With xuc_Purchase_Order_Units_Generate
                .OrderCode = Order_Code.EditValue
                .Status = "APPROVED"
                .AllBrand = False
                .Load_MC_Orders()
            End With

            xuc_MC_Transaction.Order_Code.EditValue = Order_Code.EditValue
        End Sub

        Private Sub WizardPage_Transaction_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Transaction.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Transaction_Type)
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please select Transaction Type to continue."
            Else
                With xuc_MC_Transaction.Transaction_Type
                    .Text = Transaction_Type.Text
                    .ReadOnly = True
                End With

                Select Case Transaction_Type.Text
                    Case "DEPOSIT", "CONVERT"
                        e.Valid = xuc_MC_Transaction.Control_New(False)
                End Select
            End If
        End Sub

        Private Sub WizardPage_Branch_From_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Branch_From.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Branch_From)
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please select Brand/Dealer to continue."
            Else
                With xuc_MC_Transaction.Branch_From
                    .EditValue = Branch_From.EditValue
                    .ReadOnly = True
                End With
            End If
        End Sub

        Private Sub WizardPage_Purchase_Order_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Purchase_Order.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Order_Code)
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please select Purchase Order to continue."
            Else
                With xuc_MC_Transaction
                    .Order_Code.EditValue = Order_Code.EditValue
                    .Order_Code.ReadOnly = True
                    .Description.Text = Order_Code.GetColumnValue("Request_Description")
                End With
                WHCode.EditValue = Order_Code.GetColumnValue("WHCode")
            End If
        End Sub

        Private Sub WizardPage_Branch_To_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Branch_To.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Branch_To) And Not Branch_From.EditValue.Equals(Branch_To.EditValue)
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please select valid Destination Branch to continue."
                Branch_To.Select()
            Else
                With xuc_MC_Transaction.Branch_Code
                    .EditValue = Branch_To.EditValue
                    .ReadOnly = True
                End With
            End If
        End Sub

        Private Sub WizardPage_Reference_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Reference.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Reference)
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input Reference/Delivery Receipt to continue."
            Else
                With xuc_MC_Transaction.Reference
                    .EditValue = Reference.EditValue
                End With
                e.Valid = xuc_MC_Transaction.Control_New(False)
            End If
        End Sub

        Private Sub WizardPage_WHCode_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_WHCode.PageValidating
            e.Valid = Not class_Procedures.isEmpty(WHCode)
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input Warehouse Inventory Status to continue."
            Else
                With xuc_MC_Transaction.WHCode
                    .EditValue = WHCode.EditValue
                    .ReadOnly = True
                End With
                e.Valid = xuc_MC_Transaction.Control_New(False)
            End If
        End Sub

        Private Sub WizardPage_Profile_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Profile.PageValidating
            e.Valid = xuc_MC_Transaction.Control_Save(True)
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input valid information to continue."
            Else
                With xuc_MC_Transaction_Units
                    .TransactionType = xuc_MC_Transaction.Transaction_Type.Text
                    .TransactionCode = xuc_MC_Transaction.Transaction_Code.Text
                    .OrderCode = xuc_MC_Transaction.Order_Code.Text
                    .Reference = xuc_MC_Transaction.Reference.Text
                    .BranchFrom = xuc_MC_Transaction.Branch_From.EditValue
                    .BranchFromName = xuc_MC_Transaction.Branch_From.Text
                    .BranchTo = xuc_MC_Transaction.Branch_Code.EditValue
                    .WHCode = xuc_MC_Transaction.WHCode.Text
                    .TransactionDate = Date.Today
                    .Status = "PENDING"

                    .Load_MC_Units()
                    .Initialize_MC_Units(Branch_From.EditValue)
                End With
            End If
        End Sub

        Private Sub btn_Generate_Click(sender As Object, e As EventArgs) Handles btn_Generate.Click
            With xuc_Purchase_Order_Units_Generate
                xuc_MC_Transaction_Units.Generate_MC_Units(.gridView.GetFocusedRowCellValue(.colModel_Code), .gridView.GetFocusedRowCellValue(.colQuantity), .gridView.GetFocusedRowCellValue(.colUnit_Received))
            End With
        End Sub

        Private Sub WizardPage_MC_Units_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Units.PageValidating
            e.Valid = xuc_MC_Transaction_Units.gridView.DataRowCount > 0
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input at least one(1) Receive/Transfer/Deposit Unit to continue."
            Else
                With xuc_MC_Transaction_Units
                    .Save_MC_Units()
                End With
            End If
        End Sub




    End Class
End Namespace