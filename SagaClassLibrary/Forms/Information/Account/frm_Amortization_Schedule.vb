Imports MyClassLibrary.Classes

Namespace Forms.Information.Account

    Partial Friend Class frm_Amortization_Schedule
        Inherits DevExpress.XtraEditors.XtraForm

        Public Sub New()
            InitializeComponent()

            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

            class_Procedures.Initialize_Form(Me, gridView, BtnCancel)
        End Sub

        Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
            Form_Close()
        End Sub

        Private Sub frm_Amortization_Schedule_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub frm_Amortization_Schedule_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
            If Not Form_Close() Then e.Cancel = True
        End Sub

        Private Function Form_Close() As Boolean
            Return class_Procedures.Form_Close(Me, gridView)
        End Function

        Friend Sub Control_Load(ByVal sBrCode As String, ByVal sAccount As String, ByVal iLedger As Integer)
            class_Database.Bind_Data(class_Database.ICSConnection, gridControl, gridView, $"SELECT * FROM AmortSched_md WHERE BranchCode LIKE '{sBrCode}' AND AccountNo LIKE '{sAccount}' AND LedgerSetNumber LIKE '{iLedger}'", "AmortSched_md")

        End Sub

    End Class

End Namespace