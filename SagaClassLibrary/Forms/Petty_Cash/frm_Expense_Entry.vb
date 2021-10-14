Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Forms.Petty_Cash

    Public Class frm_Expense_Entry
        Friend ID As Integer

        Sub New()
            If Me.xuc_Expense Is Nothing Then
                Me.xuc_Expense = New Controls.Petty_Cash.xuc_Expense()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, xuc_Expense.layoutControl, BtnCancel)

            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, BarManager)
        End Function

        Private Sub frm_Expense_Entry_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Close_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub Expensesfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            btn_Approve.Enabled = class_Saga_Variables.isAccounting
            btn_DisApprove.Enabled = class_Saga_Variables.isAccounting

            xuc_Expense.Posting_Date.EditValue = class_Tools.RegKeyGet(Me.Name, xuc_Expense.Posting_Date.Name, Date.Today)
        End Sub

        Private Sub Expensesfrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
            class_Tools.RegKeySet(Me.Name, xuc_Expense.Posting_Date.Name, xuc_Expense.Posting_Date.EditValue)

            class_Procedures.Form_Close(Me)
        End Sub

        Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
            xuc_Expense.Control_Initialize()
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            xuc_Expense.Control_Post_Expense()
        End Sub

        Private Sub btn_Save_New_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_New.ItemClick
            With xuc_Expense
                If .Control_Post_Expense() Then
                    .Account_Name.Text = Nothing
                    .Recipient.Text = Nothing
                    .Amount_Paid.Value = Nothing
                    .Particulars.Text = Nothing
                    .Vendor.Text = Nothing
                    .Official_Receipt.Text = Nothing
                    .Engine.EditValue = Nothing
                    .Notes.Text = Nothing
                End If
            End With
        End Sub

        Private Sub btn_Save_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Close.ItemClick
            If xuc_Expense.Control_Post_Expense() Then
                Form_Close()
            End If
        End Sub

        Private Sub btn_Approve_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Approve.ItemClick
            If xuc_Expense.Control_Approve() Then Form_Close()
        End Sub

        Private Sub btn_DisApprove_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_DisApprove.ItemClick
            If xuc_Expense.Control_DisApprove() Then Form_Close()
        End Sub

    End Class

End Namespace