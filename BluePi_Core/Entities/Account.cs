using System;
using System.Collections.Generic;
using System.Text;

namespace BluePi_Core.Entities
{
    public class Account
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public int Password { get; set; }
		public string HashCode { get; set; }
		public DateTime LoginTime { get; set; }
		public virtual Employee Employee { get; set; }
	}
}
