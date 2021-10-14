Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Namespace Controls.Persons

    Public Class xuc_User
        Inherits DevExpress.XtraEditors.XtraUserControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Friend Sub Control_Initialize()
            class_Saga_Procedures.Initialize_Corporation(Corporation)
            class_Saga_Procedures.Initialize_Branch(user_Branch)
            class_Saga_Variables.Initialize_Employee()
            class_Saga_Procedures.Initialize_Employee(Employee_Code)

            class_Database.Fill_Edit(class_Database.ICSConnection, user_Position, "Users", "designation")
            User_Name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            user_Branch.Select()
        End Sub

        Friend Sub Control_New(Optional ByVal bAsk As Boolean = false)
            If bask AndAlso Not class_Procedures.actionAsk("New Application User Profile", "Initialize new Application User Profile", "You might lose unsaved data") Then Return
            class_Procedures.Initialize_Controls(Me, bask)
            class_Procedures.Set_Message(class_Procedures.MsgMode.Info, "You can now input new or another user profile")
            User_Name.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
            User_Name.Select()
        End Sub

        Friend Function Control_Save(ByVal bSavePassword As Boolean) As Boolean
            If class_Procedures.isEmpty(User_Name) Then Return False
            If class_Procedures.isLength(User_Name, 5) Then Return False

            If bSavePassword AndAlso class_Procedures.isEmpty(User_Password) Then Return False
            If bSavePassword AndAlso class_Procedures.isLength(User_Password, 6) Then Return False

            If class_Procedures.isEmpty(Employee_Code) Then Return False
            If class_Procedures.isEmpty(user_Branch) Then Return False
            If class_Procedures.isEmpty(user_Position) Then Return False

            If Not User_Password.Text.Equals(User_Password2.Text) Then
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, "Password did not match. Please try again")
                XtraTabControl.SelectedTabPageIndex = 0
                User_Password2.Select()
                User_Password2.SelectAll()
                Return False
            End If

            Dim sPasswordEncrypted As String = class_Tools.Encrypt(User_Password.Text.Trim)

            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@ID", ID.EditValue),
                New SqlParameter("@Corporation", Corporation.EditValue),
                New SqlParameter("@Branch_Code", user_Branch.EditValue),
                New SqlParameter("@Username", User_Name.Text.Trim),
                New SqlParameter("@Password", sPasswordEncrypted),
                New SqlParameter("@FName", user_FName.Text.Trim),
                New SqlParameter("@MName", user_MName.Text.Trim),
                New SqlParameter("@LName", user_LName.Text.Trim),
                New SqlParameter("@FullName", user_Full_Name.Text.Trim),
                New SqlParameter("@Employee_Code", Employee_Code.EditValue),
                New SqlParameter("@Designation", user_Position.Text.Trim),
                New SqlParameter("@IsSuperUser", isSuperUser.IsOn),
                New SqlParameter("@IsAdmin", isAdministator.IsOn),
                New SqlParameter("@IsApprover", isApprover.IsOn),
                New SqlParameter("@IsAccounting", isAccounting.IsOn),
                New SqlParameter("@IsAudit", isAudit.IsOn),
                New SqlParameter("@IsLogistics", isLogistics.IsOn),
                New SqlParameter("@IsInventory", isInventory.IsOn),
                New SqlParameter("@IsInventorySP", isSpareParts.IsOn),
                New SqlParameter("@IsCashier", isCashier.IsOn),
                New SqlParameter("@IsBookkeeper", isBookkeeper.IsOn),
                New SqlParameter("@IsReceptionist", isReceptionist.IsOn),
                New SqlParameter("@IsNewAccounts", isNewAccounts.IsOn),
                New SqlParameter("@IsRelease", isRelease.IsOn),
                New SqlParameter("@IsCollection", isCollection.IsOn),
                New SqlParameter("@IsReports", IsReports.IsOn),
                New SqlParameter("@IsUpdate", IsUpdate.IsOn),
                New SqlParameter("@IsBetaTester", IsBetaTester.IsOn),
                New SqlParameter("@User_Description", User_Description.Text.Trim),
                New SqlParameter("@Notes", Notes.Text.Trim),
                New SqlParameter("@PassUpdate", bSavePassword),
                New SqlParameter("@Action_Type", "SAVE")
            }
            Return class_Database.Procedure_Save(class_Database.ICSConnection, sqlParameters, "acc_User_Procedures", "User Profile", User_Name.Text.Trim)
        End Function

        Friend Function Control_Delete(ByVal sUserName As String) As Boolean
            Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@username", sUserName),
                New SqlParameter("@Action_Type", "DELETE")
            }
            Return class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_User_Procedures", "Delete User Account", True)
        End Function

        Private Sub user_Password2_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles User_Password2.EditValueChanged
            progress_Password_Stregnth.EditValue = class_Functions.CheckPasswordStrength(User_Password2.Text)
        End Sub

        Private Sub user_Password2_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles User_Password2.ButtonClick
            class_Procedures.Initialize_Controls(User_Password2)
        End Sub

    End Class

End Namespace