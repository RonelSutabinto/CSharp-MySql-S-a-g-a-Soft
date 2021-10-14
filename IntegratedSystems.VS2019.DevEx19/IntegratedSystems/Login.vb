Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Data.SqlClient

Public Class Login
    Friend Sub New()
        InitializeComponent()

        Dim BtnCancel = New DevExpress.XtraEditors.SimpleButton
        AddHandler BtnCancel.Click, AddressOf BtnCancel_Click
        Me.CancelButton = BtnCancel
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form_Close()
    End Sub

    Private Function Form_Close() As Boolean
        Return class_Procedures.Form_Close(Me)
    End Function

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        class_Saga_Variables.sDLLFiles = {"AutoUpdater.NET.dll", "MyClassLibrary.dll", "SagaClassLibrary.dll", "BranchAccounting.dll", "SagaInventory.dll", "SagaSupport.dll", "wSClassLib.dll", "SagaSpareParts.exe"}

        class_Database.Initialize_Connection()

        class_Procedures.Get_Skin()
    End Sub

    Private Sub Login_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Application_Version.Text = Application.ProductVersion

        IP_Address_Local.Text = class_Connections.Get_IP_Local
        IP_Address_Internet.Text = class_Connections.Get_IP_Internet

        User_Name.Text = class_Tools.Decrypt(class_Tools.RegKeyGet(Me.Name, User_Name.Name, String.Empty))

        If class_Procedures.isEmpty(User_Name, False) Then
            User_Name.Focus()
        Else
            Pass_Word.Focus()
        End If
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Login.Click
        Dim sqlParameters As SqlParameter() = {
                New SqlParameter("@Corporation", "SMC"),
                New SqlParameter("@Username", User_Name.Text),
                New SqlParameter("@Password", class_Tools.Encrypt(Pass_Word.Text)),
                New SqlParameter("@IP_Local", class_Connections.Get_IP_Local),
                New SqlParameter("@IP_Address", class_Connections.Get_IP_Internet),
                New SqlParameter("@IP_Location", class_Connections.get_IP_GEO(class_Connections.Get_IP_Internet)),
                New SqlParameter("@MachineName", Environment.MachineName),
                New SqlParameter("@AppName", Application.ProductName),
                New SqlParameter("@AppVersion", Application.ProductVersion),
                New SqlParameter("@Action_Type", "LOGIN")
            }

        Try
            class_Database.Initialize_Connection()

            class_Procedures.splash_Show("Verifying User Profile",, True, class_Procedures.xFormMode.xForm)

            Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_User_Procedures")
                If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                    class_Saga_Variables.bIsLogged_In = True

                    MainMenu.App_User_Name.Caption = User_Name.Text
                    class_Variables.sUserName = User_Name.Text

                    class_Tools.RegKeySet(Me.Name, User_Name.Name, class_Tools.Encrypt(User_Name.Text.Trim))
                Else
                    class_Procedures.splash_Close(True)
                    class_Procedures.Set_Message(Me, class_Procedures.MsgMode.Errorr, "Wrong Username or Password. Please try again.", "Login Error", True)
                    Return
                End If
            End Using
        Catch ex As Exception
            class_Procedures.Show_Error(ex)
        Finally
            class_Procedures.splash_Close(True)
        End Try

        class_Connections.Show_Update(False)

        mg_ShowDeptoRepDays()
        mg_ShowReptoHoDays()
        mg_ShowSPACustDepDueDays()

        AccessRights()

        Me.Visible = False
        MainMenu.Visible = True

        'CountAllTransactions()
        'Frm_Summaries.ShowDialog()
    End Sub

    Private Sub mg_ShowDeptoRepDays()
        Dim sqlParameters As SqlParameter() = {}
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowDeptoRepDays")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MainMenu.iDepoToRepoDays = Convert.ToInt32(myDataReader("NoofDays"))
            End If
        End Using
    End Sub

    Private Sub mg_ShowReptoHoDays()
        Dim sqlParameters As SqlParameter() = {}
        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowReptoHODays")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MainMenu.iRepoToHODays = Convert.ToInt32(myDataReader("NoofDays"))
            End If
        End Using
    End Sub

    Private Sub mg_ShowSPACustDepDueDays()
        Dim sqlParameters As SqlParameter() = {}

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "mg_ShowSPACustDepDays")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                MainMenu.iSPADepoDays = Convert.ToInt32(myDataReader("NoofDays"))
            End If
        End Using
    End Sub

    Private Sub AccessRights()
        Dim sqlParameters As SqlParameter() = {
            New SqlParameter("@UserName", User_Name.Text),
            New SqlParameter("@Action_Type", "RETRIEVE")
        }

        Using myDataReader As SqlDataReader = class_Database.Procedure_Retrieve(class_Database.ICSConnection, sqlParameters, "acc_User_Procedures")
            If myDataReader IsNot Nothing AndAlso myDataReader.HasRows Then
                myDataReader.Read()
                class_Saga_Variables.sBranchCode = myDataReader("branchcode").ToString()

                class_Saga_Variables.Initialize_Branch()
                class_Saga_Procedures.Initialize_Branch(MainMenu.BarEditItem_Branch, MainMenu.RepositoryItemLookUpEdit_Branch, True)
                MainMenu.BarEditItem_Branch.EditValue = class_Saga_Variables.sBranchCode
                MainMenu.BarEditItem_Branch.Enabled = class_Saga_Variables.sBranchCode.Equals("000")

                MainMenu.BarStaticItem_Branch_Code.Caption = class_Saga_Variables.sBranchCode
                MainMenu.BarStaticItem_Branch_Name.Caption = class_Saga_Database.get_Branch_Name(class_Saga_Variables.sBranchCode)

                class_Variables.sUserFullName = myDataReader("fullname").ToString
                MainMenu.User_Full_Name.Caption = class_Variables.sUserFullName

                MainMenu.RibbonPageGroup_Customers.Enabled = Convert.ToBoolean(myDataReader("ISNewAccounts"))
                MainMenu.RibbonPageGroup_Sales.Enabled = Convert.ToBoolean(myDataReader("IsRelease"))

                class_Variables.isAdministrator = Convert.ToBoolean(myDataReader("IsSuperUser"))
                class_Saga_Variables.isAudit = Convert.ToBoolean(myDataReader("IsAudit"))

                class_Saga_Variables.isAdmin = Convert.ToBoolean(myDataReader("IsAdmin"))
                class_Saga_Variables.isCashier = Convert.ToBoolean(myDataReader("IsCashier"))
                class_Saga_Variables.isInventory = Convert.ToBoolean(myDataReader("IsInventory"))
                class_Saga_Variables.isLogistics = Convert.ToBoolean(myDataReader("IsLogistics"))
                class_Saga_Variables.isApprover = Convert.ToBoolean(myDataReader("IsApprover"))

                class_Saga_Variables.isUpdate = Convert.ToBoolean(myDataReader("IsUpdate"))
                class_Saga_Variables.isBetaTester = Convert.ToBoolean(myDataReader("IsBetaTester"))

                MainMenu.RibbonPageGroup_MC.Enabled = Convert.ToBoolean(myDataReader("IsInventory"))
                MainMenu.btn_Purchase_Orders.Enabled = class_Saga_Variables.isLogistics Or class_Saga_Variables.sBranchCode.Equals("006") Or class_Saga_Variables.sBranchCode.Equals("013") Or class_Saga_Variables.sBranchCode.Equals("019")

                MainMenu.RibbonPageGroup_Repricing.Enabled = class_Saga_Variables.isApprover Or class_Saga_Variables.isAudit

                MainMenu.RibbonPageGroup_Expense.Enabled = class_Saga_Variables.isCashier
                MainMenu.RibbonPageGroup_Journal.Enabled = class_Saga_Variables.isCashier

                MainMenu.RibbonPageGroup_Maintenance.Enabled = Convert.ToBoolean(myDataReader("IsMaintenance"))

                MainMenu.RibbonPageGroup_Sales.Visible = class_Saga_Variables.isBetaTester
                MainMenu.RibbonPageGroup_Repo.Enabled = class_Saga_Variables.isLogistics
            End If
        End Using

        'class_Saga_Variables.Initialize_Corporation()
        'class_Saga_Variables.Initialize_Corporation_All()
        class_Saga_Variables.Initialize_Branch()
        class_Saga_Variables.Initialize_Users()
        class_Saga_Variables.Initialize_COA_Summary()
        'class_Saga_Variables.Initialize_Unit_Status()
    End Sub

    Private Sub Configuration_Settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Configuration_Settings.Click
        Show_Server_Connection("SQL Configuration")
    End Sub
End Class