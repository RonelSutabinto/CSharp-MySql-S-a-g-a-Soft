using MyClassLibrary.Classes;
using System;
using System.Data.SqlClient;

namespace SagaAssets.Modules
{
    class class_Asset_Procedures
    {
        internal static bool Request_Action(string sTicketCode, string sAction, string sActioning)
        {
            var Parameters = new[]
            {
                new SqlParameter("@Request_Code", sTicketCode),
                new SqlParameter("@Modified_By", class_Variables.sUserName),
                new SqlParameter("@Notes", class_Functions.Show_Input_Box($"Input any Notes on {sActioning} this Request", $"Input Notes on Request {sActioning}", string.Empty)),
                new SqlParameter("@Action_Type", sAction.ToUpper())
            };
            return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, Parameters, "inv_Request_Procedures", $"{sAction} Request", true));
        }
    }
}
