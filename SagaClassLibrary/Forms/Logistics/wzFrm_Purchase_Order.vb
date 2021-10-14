Imports System.Windows.Forms
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Namespace Forms.Logistics
    Public Class wzFrm_Purchase_Order
        Public Sub New()
            If Me.Xuc_Purchase_Order Is Nothing Then
                Me.Xuc_Purchase_Order = New Controls.Logistics.xuc_Purchase_Order()
            End If

            If Me.xuc_Purchase_Order_Units Is Nothing Then
                Me.xuc_Purchase_Order_Units = New Controls.Logistics.xuc_Purchase_Order_Units()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, Xuc_Purchase_Order.layoutControl, BtnCancel)
        End Sub

        Private Function Form_Close() As Boolean
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

        Private Sub wzFrm_Purchase_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub wzFrm_Purchase_Order_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
            class_Saga_Variables.Initialize_Brands()
            class_Saga_Procedures.Initialize_Brand(Brand_Dealer)
        End Sub

        Private Sub WizardPage_Brand_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Brand.PageValidating
            e.Valid = Not class_Procedures.isEmpty(Brand_Dealer)
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please select Brand/Dealer to continue."
            Else
                With xuc_Purchase_Order
                    .Control_Initialize()

                    .Brand_Code.EditValue = Brand_Dealer.EditValue
                    .Order_Date.EditValue = Date.Today
                    .Freight_Cost.Value = 0
                    .Is_Per_Unit.IsOn = False
                    .Order_Description.EditValue = String.Empty
                    .Notes.EditValue = String.Empty

                    .Control_New(False)
                End With
            End If
        End Sub

        Private Sub WizardPage_Profile_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Profile.PageValidating
            e.Valid = xuc_Purchase_Order.Control_Save(True)
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input valid Purchase Order Information to continue."
            Else
                With xuc_Purchase_Order_Units
                    .OrderCode = xuc_Purchase_Order.Order_Code.Text.Trim
                    .Status = "PENDING"
                    .AllBrand = False
                    .Brand = xuc_Purchase_Order.Brand_Code.Text
                    .FreightCost = xuc_Purchase_Order.Freight_Cost.Value
                    .PerUnit = xuc_Purchase_Order.Is_Per_Unit.EditValue

                    .Load_MC_Orders()
                End With
            End If
        End Sub

        Private Sub WizardPage_MC_Units_PageValidating(sender As Object, e As DevExpress.XtraWizard.WizardPageValidatingEventArgs) Handles WizardPage_Units.PageValidating
            e.Valid = xuc_Purchase_Order_Units.gridView.DataRowCount > 0
            If Not e.Valid Then
                e.ErrorIconType = System.Windows.Forms.MessageBoxIcon.Error
                e.ErrorText = "Please input at least one(1) Purchase Order Unit to continue."
            Else
                With xuc_Purchase_Order_Units
                    .Save_Item_Orders()
                End With
            End If
        End Sub
    End Class
End Namespace