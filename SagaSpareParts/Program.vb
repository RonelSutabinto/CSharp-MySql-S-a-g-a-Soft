Imports MyClassLibrary.Classes
Imports SagaClassLibrary.Classes

Friend Module Program
    Sub Main()
        Application.EnableVisualStyles()
        class_Database.Initialize_Connection()
        class_Connections.Initialize_IP("1.1.1.1")
        class_Connections.Show_Update(False)
        class_Saga_Variables.sDLLFiles = {"AutoUpdater.NET.dll", "MyClassLibrary.dll", "SagaClassLibrary.dll", "SagaSupport.dll"}

        If class_Saga_Procedures.Show_Login("Application User") Then
            class_Procedures.splash_Show($"{Application.ProductName} {Application.ProductVersion}")
            Application.Run(New Form_Main())
        End If
    End Sub

End Module
