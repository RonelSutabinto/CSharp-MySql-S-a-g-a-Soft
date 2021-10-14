Imports MyClassLibrary.Classes
Imports SagaClassLibrary.classes

Friend Module Program

    Sub Main()
        Application.EnableVisualStyles()

        class_Database.Initialize_Connection()
        class_Connections.Initialize_IP("1.1.1.1")

        If class_Saga_Procedures.Show_Login("Application User") Then
            class_Procedures.splash_Show($"{Application.ProductName} {Application.ProductVersion}")
            Application.Run(New MainMenu())
        End If
    End Sub

End Module