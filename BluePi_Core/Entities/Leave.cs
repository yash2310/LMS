using System;
using System.Collections.Generic;
using System.Text;

namespace BluePi_Core.Entities
{
	public class Leave
	{
		public int Id { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public virtual LeaveType Type { get; set; }
		public virtual LeaveCategory Category { get; set; }
		public virtual LeaveStatus Status { get; set; }
		public string Comment { get; set; }
	}
}