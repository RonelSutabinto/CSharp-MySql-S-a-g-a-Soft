Imports System.Windows.Forms
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Namespace Forms.Logistics
    Public Class wzFrm_MC_Request
        Public Sub New()
            If Me.Xuc_MC_Request Is Nothing Then
                Me.Xuc_MC_Request = New Controls.Logistics.xuc_MC_Request()
            End If

            If Me.xuc_Purchase_Order_Units Is Nothing Then
                Me.xuc_Purchase_Order_Units = New Controls.Logistics.xuc_Purchase_Order_Units()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, Xuc_MC_Request.layoutControl, BtnCancel)
        End Sub

        Private Function Form_Close() As Boolean
            class_Tools.RegKeySet(Me.Name, Supplier_Code.Name, Supplier_Code.EditValue)
            class_Tools.RegKeySet(Me.Name, WHCode.Name, WHCode.EditValue)
            class_Tools.RegKeySet(Me.Name, Request_Description.Name, Request_Description.Text.Trim)

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

        Private Sub frm_Purchase_Orders_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub wzFrm_MC_Request_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            class_Saga_Procedures.Initialize_Warehouse(WHCode)
            class_Saga_Procedures.Initialize_Branch(Supplier_Code)
            Supplier_Code.EditValue = "000"

            Supplier_Code.EditValue = class_Tools.RegKeyGet(Me.Name, Supplier_Code.Name, String.Empty)
            WHCode.EditValue = class_Tools.RegKeyGet(Me.Name, WHCode.Name, String.Empty)
            Request_Description.Text = class_Tools.RegKeyGet(Me.Name, Request_Description.Name, String.Empty)
        End Sub

        Private Sub WizardPage_Supplier_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Supplier.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Supplier_Code) Or Not class_Saga_Variables.sBranchCode.Equals(Supplier_Code.EditValue)

            If e.Valid Then
                With Xuc_MC_Request.Supplier_Code
                    .EditValue = Supplier_Code.EditValue
                    .ReadOnly = True
                End With
            Else
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please select valid Branch/Supplier to continue."
            End If
        End Sub

        Private Sub WizardPage_WHCode_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_WHCode.PageValidating
            e.Valid = Not class_Procedures.isEmpty(WHCode)

            If e.Valid Then
                With Xuc_MC_Request.WHCode
                    .Text = WHCode.EditValue
                    .ReadOnly = True
                End With
            Else
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please select Warehouse Category to continue."
            End If
        End Sub

        Private Sub WizardPage_Reason_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Reason.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Request_Description)

            If e.Valid Then
                With xuc_MC_Request
                    .Control_Initialize()
                    .Control_New(False)
                    .Request_Description.Text = Request_Description.Text.Trim
                End With
            Else
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input any Reason to Request to continue."
            End If
        End Sub

        Private Sub WizardPage_Profile_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Profile.PageValidating
            e.Valid = xuc_MC_Request.Control_Save(True)
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input valid MC Request Information to continue."
            Else
                With xuc_Purchase_Order_Units
                    .OrderCode = xuc_MC_Request.Request_Code.Text.Trim
                    .Status = "PENDING"
                    .AllBrand = True

                    .Load_MC_Orders()
                End With
            End If
        End Sub

        Private Sub WizardPage_MC_Units_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_MC_Units.PageValidating
            e.Valid = xuc_Purchase_Order_Units.gridView.DataRowCount > 0
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input at least one(1) MC Request Unit to continue."
            Else
                With xuc_Purchase_Order_Units
                    .Save_Item_Orders()
                End With
            End If
        End Sub


    End Class
End Namespace