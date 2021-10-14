using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;

namespace Saga_Technician
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            class_Database.Initialize_Connection();
            class_Procedures.Get_Skin();
            class_Connections.Initialize_IP("1.1.1.1");
            class_Saga_Procedures.Show_Update(false);
            if (class_Saga_Procedures.Show_Login("Application User"))
            {
                class_Procedures.splash_Show($"{Application.ProductName} {Application.ProductVersion}");
                Application.Run(new MainView());
            }
        }
    }
}
