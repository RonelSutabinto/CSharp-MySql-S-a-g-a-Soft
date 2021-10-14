using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaSupport.Models
{
	class TicketProgress
	{
		public int ID { get; set; }
		public string Ticket_Code { get; set; }
		public string Ticket_Progress { get; set; }
		public string Notes { get; set; }
		public string Added_By { get; set; }
		public DateTime Added_Date { get; set; }
		public string Modified_By { get; set; }
		public DateTime Modified_Date { get; set; }
		public bool IsDeleted { get; set; }
		public string Deleted_By { get; set; }
		public DateTime Deleted_Date { get; set; }
	}
}
