Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Public Class frm_Account_Payment
    Friend isCashiering As Boolean

    Public Sub New()
        If Me.xuc_Account_Payment Is Nothing Then
            Me.xuc_Account_Payment = New Controls.Information.Account.xuc_Account_Payment
        End If

        InitializeComponent()

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Customer_Payment_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        If isCashiering Then
            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click
            class_Procedures.Initialize_Form(Me, xuc_Account_Payment.layoutControl, BtnCancel, True, "IB")
        Else
            Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
            AddHandler BtnCancel.Click, AddressOf BtnCancel_Click
            class_Procedures.Initialize_Form(Me, xuc_Account_Payment.layoutControl, BtnCancel)
        End If

        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Function Form_Close() As Boolean
        If WindowState.Equals(FormWindowState.Normal) Then
            If isCashiering Then
                class_Tools.RegKeySet(Me.Name, $"{Me.Name}_IB_Top", Top)
                class_Tools.RegKeySet(Me.Name, $"{Me.Name}_IB_Left", Left)
                class_Tools.RegKeySet(Me.Name, $"{Me.Name}_IB_Width", Width)
                class_Tools.RegKeySet(Me.Name, $"{Me.Name}_IB_Height", Height)
                Return class_Procedures.Form_Close(Me, BarManager, False, True, "IB")
            Else
                class_Tools.RegKeySet(Me.Name, $"{Me.Name}_Top", Top)
                class_Tools.RegKeySet(Me.Name, $"{Me.Name}_Left", Left)
                class_Tools.RegKeySet(Me.Name, $"{Me.Name}_Width", Width)
                class_Tools.RegKeySet(Me.Name, $"{Me.Name}_Height", Height)
                Return class_Procedures.Form_Close(Me, BarManager)
            End If
        End If
        Return False
    End Function

    Private Sub frm_Customer_Payment_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        xuc_Account_Payment.control_Save(isCashiering)
    End Sub

    Private Sub btn_Save_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Close.ItemClick
        If xuc_Account_Payment.control_Save(isCashiering) Then
            Form_Close()
        End If
    End Sub

    Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

End Class