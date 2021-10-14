using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaSupport.Models
{
	class TicketGroup
	{
		public int ID { get; set; }
		public string Ticket_Group_Code { get; set; }
		public string Ticket_Group { get; set; }
		public string Ticket_Group_Sub { get; set; }
		public string Ticket_Description { get; set; }
		public string Notes { get; set; }
		public string Personnel { get; set; }
		public string Added_By { get; set; }
		public DateTime Added_Date { get; set; }
		public string Modified_By { get; set; }
		public DateTime Modified_Date { get; set; }
	}
}
