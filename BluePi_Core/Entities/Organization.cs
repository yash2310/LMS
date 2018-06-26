using System;
using System.Collections.Generic;
using System.Text;

namespace BluePi_Core.Entities
{
    public class Organization
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public virtual Employee Employee { get; set; }
	}
}
