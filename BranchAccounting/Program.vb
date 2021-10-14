Imports MyClassLibrary.Classes

Friend Module Program

    Sub Main()
        Application.EnableVisualStyles()

        DevExpress.UserSkins.BonusSkins.Register()

        class_Database.Initialize_Connection()

        class_Procedures.Get_Skin()

        class_Connections.Initialize_IP("1.1.1.1")

        class_Connections.Show_Update(False)

        If SagaClassLibrary.Classes.class_Saga_Procedures.Show_Login("Application User") Then
            class_Procedures.splash_Show($"{Application.ProductName} {Application.ProductVersion}")
            Application.Run(New frm_Main())
        End If
    End Sub

End Module