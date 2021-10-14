using MyClassLibrary.Classes;
using System;
using System.Data.SqlClient;

namespace SagaSupport.Classes
{
    public static class class_Support_Database
    {
        internal static bool Ticket_Action(string sTicketCode, string sAction, string sActioning)
        {
            string sNote = class_Functions.Show_Input_Box($"Input any Notes on {sActioning} this Ticket", $"Input Notes on Ticket {sActioning}", string.Empty);

            if (sNote.Length <= 10)
            {
                class_Procedures.Set_Message(class_Procedures.MsgMode.Errorr, $"Please input detailed {sActioning} remarks for this ticket/incident.", $"{sActioning} Error", true);
                return false;
            }

            SqlParameter[] sqlParameters = new[] {
                new SqlParameter("@Ticket_Code", sTicketCode),
                new SqlParameter("@Modified_By", class_Variables.sUserName),
                new SqlParameter("@Notes", sNote),
                new SqlParameter("@Action_Type", sAction.ToUpper())
            };
            return Convert.ToBoolean(class_Database.Procedure_Execute(class_Database.ICSConnection, sqlParameters, "acc_Ticket_Procedures", $"{sAction} Ticket", true));
        }

       
    }
}