Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports SagaClassLibrary.Forms
Imports System

Namespace Custom

    Public Class frm_Error_Display

        Friend Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, BtnCancel)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            class_Procedures.Form_Close(Me)
        End Sub

        Private Sub frm_Error_Display_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load

        End Sub

        Private Sub frm_Error_Display_Shown(sender As Object, e As System.EventArgs) Handles MyBase.Shown
            'Error_Cancelled_Checks.EditValue = class_Saga_Database.get_Check_Errors
        End Sub

        Private Sub frm_Error_Display_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            class_Procedures.Form_Close(Me)
        End Sub

        Private Function Get_Error_Values(ByVal sErrorControl As String) As Integer
            Select Case sErrorControl
                Case "CHECK"
                    Return class_Saga_Database.get_Check_Errors
            End Select

            Return Nothing
        End Function

        Private Sub Error_ButtonClick(e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs, ByVal sErrorType As String)
            Select Case e.Button.Index
                Case 0
                    Dim frm As Accounting.frm_Check_Numbers = New Accounting.frm_Check_Numbers
                    Show_Form(frm, "Check with Errors")
                Case 1
                    Select Case sErrorType
                        Case "CHECK"
                            Error_Cancelled_Checks.EditValue = Get_Error_Values("CHECK")
                    End Select
            End Select
        End Sub

        Private Sub Error_Cancelled_Checks_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles Error_Cancelled_Checks.ButtonClick
            Error_ButtonClick(e, "CHECK")
        End Sub

        Friend Sub Show_Form(ByVal xFrm As XtraForm, ByVal sTitle As String)
            class_Procedures.splash_Show(sTitle, , True, class_Procedures.xFormMode.xForm)
            Try
                With xFrm
                    .MdiParent = Me.MdiParent
                    .Text = sTitle
                    .Icon = Me.Icon
                    .Show()
                End With
            Catch ex As Exception

            End Try
            class_Procedures.splash_Close(True)
        End Sub

    End Class

End Namespace