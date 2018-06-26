using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BluePi_LMS.Db_Context
{
	public class DataConext
	{
		private static Database dbObject = null;

		private DataConext()
		{
		}

		public static Database Context()
		{
			if (dbObject == null)
			{
				dbObject = new Database();
			}
			return dbObject;
		}
	}
}