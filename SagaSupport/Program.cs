using MyClassLibrary.Classes;
using SagaClassLibrary.Classes;
using System.Windows.Forms;

namespace SagaSupport
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [System.STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            
            Application.SetCompatibleTextRenderingDefault(false);
            
            DevExpress.UserSkins.BonusSkins.Register();
            
            class_Database.Initialize_Connection();
            
            class_Procedures.Get_Skin();
            
            class_Connections.Initialize_IP("1.1.1.1");
            
            class_Connections.Show_Update(false);
            
            if (class_Saga_Procedures.Show_Login("Application User"))
            {
                class_Procedures.splash_Show($"{Application.ProductName} {Application.ProductVersion}");
                Application.Run(new Form_Main());
            }
        }
    }
}