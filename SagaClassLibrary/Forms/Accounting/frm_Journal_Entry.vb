Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Public Class frm_Journal_Entry

    Public Sub New()
        If Me.xuc_Journal_Entry Is Nothing Then
            Me.xuc_Journal_Entry = New Controls.Accounting.xuc_Journal_Entry()
        End If

        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click

        class_Procedures.Initialize_Form(Me, BarManager, xuc_Journal_Entry.xuc_Account_Search.gridView, BtnCancel)

        class_Saga_Procedures.Initialize_BarManager(Me, BarManager)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Sub frm_Journal_Entry_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        xuc_Journal_Entry.Journal_Referenceitem.Enabled = False
        xuc_Journal_Entry.LayoutControlItem_New_Reference.Enabled = False

        BarEditItem_Auto_Initialize.EditValue = class_Tools.RegKeyGet(Me.Name, BarEditItem_Auto_Initialize.Name, False)

        If Convert.ToBoolean(BarEditItem_Auto_Initialize.EditValue) Then
            xuc_Journal_Entry.Control_Initialize()
        Else
            xuc_Journal_Entry.Control_Initialize(False)
        End If
    End Sub

    Private Function Form_Close() As Boolean
        class_Tools.RegKeySet(Me.Name, BarEditItem_Auto_Initialize.Name, BarEditItem_Auto_Initialize.EditValue)

        Return class_Procedures.Form_Close(Me, BarManager, xuc_Journal_Entry.xuc_Account_Search.gridView)
    End Function

    Private Sub frm_Journal_Entry_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Form_Close() Then e.Cancel = True
    End Sub

    Private Sub btn_Initialize_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Initialize.ItemClick
        xuc_Journal_Entry.Control_Initialize()
    End Sub

    Private Sub btn_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Journal_Entries.ItemClick
        Show_Journal_Entries()
    End Sub

    Private Sub btn_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save.ItemClick
        xuc_Journal_Entry.Control_Update()
    End Sub

    Private Sub Show_Journal_Entries()
        With xuc_Journal_Entry
            class_Saga_Procedures.Show_Journal_Entries_Reference(Convert.ToInt32(.ID.EditValue), Convert.ToInt32(.Table_ID.EditValue), .Journal_Reference.Text, .Journal_Branch.EditValue.ToString, .Journal_Type.Text, .Journal_Profile.Text, .Account_Code.Text, .Account_Name.Text, convert.todatetime(.Posting_Date.EditValue), class_Saga_Functions.Approver, .COA_Code.EditValue.ToString, .Check_Number.Text, .Journal_Description.Text.Trim)
        End With
    End Sub

    Private Sub btn_Save_Journal_Entries_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Journal_Entries.ItemClick
        If (xuc_Journal_Entry.Control_Update() >= 0) Then Show_Journal_Entries()
        Form_Close()
    End Sub

    Private Sub btn_Save_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Save_Close.ItemClick
        If xuc_Journal_Entry.Control_Update() Then Form_Close()
    End Sub

    Private Sub btn_Close_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btn_Close.ItemClick
        Form_Close()
    End Sub

End Class