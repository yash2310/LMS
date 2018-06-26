using System;
using System.Collections.Generic;
using System.Text;

namespace BluePi_Core.Entities
{
	public class Employee
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public string Gender { get; set; }

		public virtual Account Account { get; set; }
		public virtual Department Department { get; set; }
		public virtual Designation Designation { get; set; }
		public virtual Organization Organization { get; set; }
		public virtual Branch Branch { get; set; }
		public virtual Role Role { get; set; }
		public virtual Employee Reporting { get; set; }
	}
}