using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSagaMotors.Models
{
	public class TicketGroup
	{
		public int ID { get; set; }
		public string Group_Code { get; set; }
		public string Group_Name { get; set; }
		public string Group_Sub { get; set; }
		public string Group_Description { get; set; }
		public string Group_Notes { get; set; }
		public string Added_By { get; set; }
		public DateTime Added_Date { get; set; }

	}

	public class Tickets
	{
		public int ID { get; set; }
		public string Ticket_Code { get; set; }
		public string Branch_Code { get; set; }
		public string Report_Type { get; set; }
		public string Communication_Type { get; set; }
		public string Ticket_Group { get; set; }
		public DateTime Incident_Date { get; set; }
		public string Ticket_Name { get; set; }
		public string Ticket_Description { get; set; }
		public string Notes { get; set; }
		public string Ticket_Solution { get; set; }
		public string Ticket_Status { get; set; }
		public string Reported_By { get; set; }
		public string Added_By { get; set; }
		public DateTime Added_Date { get; set; }

	}


}
