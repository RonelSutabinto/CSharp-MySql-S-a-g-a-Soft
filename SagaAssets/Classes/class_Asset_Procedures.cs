using MyClassLibrary.Classes;
using System;
using System.Data.SqlClient;

namespace SagaAssets.Classes
{
    class class_Asset_Procedures
    {
        internal static bool Action_Command(string sTicketCode, string sModule, string sAction, string sActioning)
        {
            SqlParameter[] sqlParameters = new[] {
                new SqlParameter($"@{sModule}_Code", sTicketCode),
                new SqlParameter("@Modified_By", class_Variables.sUserName),
                new SqlParameter("@Notes", class_Functions.Show_Input_Box($"Input any Remarks/Notes on {sActioning} this {sModule}", $"Input Remarks/Notes on {sModule} {sActioning}", string.Empty)),
                new SqlParameter("@Action_Type", sAction.ToUpper())
            };
            return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, $"inv_{sModule}_Procedures", $"{sAction} {sModule}", true));
        }
    }
}
