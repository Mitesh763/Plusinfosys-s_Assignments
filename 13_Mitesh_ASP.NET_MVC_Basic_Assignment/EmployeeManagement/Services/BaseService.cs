using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Services
{
	public class BaseService
	{
		public String connectDB()
		{
           return ConfigurationManager.ConnectionStrings["connString"].ToString();
        }
    }
}