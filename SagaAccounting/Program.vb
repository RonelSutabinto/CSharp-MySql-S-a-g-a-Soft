Imports DevExpress.UserSkins
Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes
Imports System.Windows.Forms

Friend Module Program

    Sub Main()
        Application.EnableVisualStyles()

        BonusSkins.Register()

        class_Database.Initialize_Connection()

        class_Procedures.Get_Skin()

        class_Connections.Initialize_IP("1.1.1.1")

        class_Connections.Show_Update(False)

        class_Saga_Variables.sDLLFiles = {"AutoUpdater.NET.dll", "MyClassLibrary.dll", "SagaClassLibrary.dll", "SagaAssets.dll", "SagaSupport.dll", "SagaHR.dll", "SagaSpareParts.exe"}

        class_Variables.bEditAdvancedMode = class_Tools.RegKeyGet("frm_Main", "BarToggleSwitchItem_Edit_Advanced_Mode", False)

        If class_Saga_Procedures.Show_Login("Application User") Then
            class_Procedures.show_SplashScreen("Main Form")
            Application.Run(New frm_Main())
        End If
    End Sub

End Module