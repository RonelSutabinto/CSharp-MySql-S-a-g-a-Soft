Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Namespace Forms.Accounting
    Public Class frm_Payment_Request
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            If xuc_Payment_Request Is Nothing Then
                Me.xuc_Payment_Request = New Controls.Accounting.xuc_Payment_Request()
            End If

            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, xuc_Payment_Request.layoutControl, BtnCancel)

            class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Payment_Request_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub frm_Payment_Request_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown

        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, BarManager)
        End Function

        Private Sub frm_Payment_Request_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
            If xuc_Payment_Request.Control_Save() Then
                btn_Save.Enabled = False
            End If
        End Sub

        Private Sub btn_Save_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Close.ItemClick
            If xuc_Payment_Request.Control_Save() Then
                btn_Save.Enabled = False
                Form_Close()
            End If
        End Sub

        Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
            Form_Close()
        End Sub

        Private Sub btn_Preview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Preview.ItemClick
            Dim xRpt As New Reports.Accounting.xrpt_Payment_Request()
            class_Database.Bind_Report(class_Database.ICSConnection, xRpt, $"SELECT * FROM acc_Payment_Requests WHERE Request_Code LIKE '{xuc_Payment_Request.Request_Code.Text}'", "acc_Payment_Requests")

            Try
                With xRpt
                    .PaperKind = System.Drawing.Printing.PaperKind.Custom
                    .PageWidth = 850
                    .PageHeight = 550

                    .Branch_Name.Text = class_Saga_Database.get_Branch_Name(xuc_Payment_Request.Branch_Code.EditValue)
                    .XrTableCell_Request_Date.Text = xuc_Payment_Request.Request_Date.Text

                    .XrTableCell_Payee_Name.Text = xuc_Payment_Request.Payee_Name.Text.Trim
                    .XrTableCell_Payee_Address.Text = xuc_Payment_Request.Payee_Address.Text.Trim

                    .XrTableCell_Request_Amount.Text = xuc_Payment_Request.Request_Amount.Text

                    .XrTableCell_Request_Description.Text = xuc_Payment_Request.Request_Description.Text.Trim

                    .XrTableCell_Request_Date.Text = Date.Today.ToString("MMMM dd, yyyy")
                End With
            Catch ex As Exception
                class_Procedures.Show_Error(ex)
            End Try
        End Sub
    End Class
End Namespace