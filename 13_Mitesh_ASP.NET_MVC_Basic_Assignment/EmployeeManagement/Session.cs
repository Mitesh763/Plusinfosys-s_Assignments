using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement
{
	public class Session
	{
		public int userId;
		public string userName;

        // set session
        public void SetSession(int UserId, string UserName) 
        {
            HttpContext.Current.Session[userId] = userId;
            HttpContext.Current.Session[userName] = UserName;
        }

        // clear session
        public void ClearSession()
        {
            HttpContext.Current.Session.Clear();
        }
    }
}