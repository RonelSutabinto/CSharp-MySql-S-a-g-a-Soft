using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaSupport.Models
{
	class Ticket
	{
		public int ID { get; set; }
		public string Ticket_Code { get; set; }
		public string Branch_Code { get; set; }
		public string Ticket_Group { get; set; }
		public string Report_Type { get; set; }
		public string Communication_Type { get; set; }
		public string Ticket_Impact { get; set; }
		public string Ticket_Urgency { get; set; }
		public bool IsRecurrent { get; set; }
		public string Deffect_Type { get; set; }
		public string Incident_Date { get; set; }
		public string Ticket_Name { get; set; }
		public string Ticket_Description { get; set; }
		public string Ticket_Attachment { get; set; }
		public string Notes { get; set; }
		public string Ticket_Solution { get; set; }
		public string Ticket_Status { get; set; }
		public string Created_By { get; set; }
		public string Assigned_To { get; set; }
		public string Added_By { get; set; }
		public DateTime Added_Date { get; set; }
		public string Modified_By { get; set; }
		public DateTime Modified_Date { get; set; }
		public bool IsOpened { get; set; }
		public string Opened_By { get; set; }
		public DateTime Opened_Date { get; set; }
		public bool IsClosed { get; set; }
		public string Closed_By { get; set; }
		public DateTime Closed_Date { get; set; }
		public bool IsApproved { get; set; }
		public string Approved_By { get; set; }
		public DateTime Approved_Date { get; set; }
		public bool IsDeleted { get; set; }
		public string Deleted_By { get; set; }
		public DateTime Deleted_Date { get; set; }
	}
}
