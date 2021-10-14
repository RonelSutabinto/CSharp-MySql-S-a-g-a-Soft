Imports DevExpress.XtraEditors
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Public Class frm_Accounts_Searched

    Public Sub New()
        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, xuc_Accounts.gridView, BtnCancel)

        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Accounts_Searched_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.xuc_Accounts.gridView.RestoreLayoutFromRegistry("Searched Accounts")
    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me, BarManager, xuc_Accounts.gridView)
    End Function

    Private Sub frm_Chart_Of_Account_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Friend Sub Load_Search(sSearch As String)

        If sSearch.Length > 2 Then class_Database.Bind_Data(class_Database.ICSConnection, Me.xuc_Accounts.gridControl, Me.xuc_Accounts.gridView, $"SELECT * FROM view_Accounts WHERE CIFKey LIKE '%{sSearch}%' OR AccountNumber LIKE '%{sSearch}%' OR AccountName LIKE '%{sSearch}%' OR AccountAddress LIKE '%{sSearch}%' OR Model LIKE '%{sSearch}%' OR EngineNo LIKE '%{sSearch}%' OR ChassisNo LIKE '%{sSearch}%' OR ORNo LIKE '%{sSearch}%' OR CRNo LIKE '%{sSearch}%'", "view_Accounts")
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

End Class