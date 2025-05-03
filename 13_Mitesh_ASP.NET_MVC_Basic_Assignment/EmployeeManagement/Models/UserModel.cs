using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace EmployeeManagement.Models
{
	public class UserModel
	{
		public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter username!")]
		public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter Password!")]
        public string Password { get; set; }

        public void SetSession(string UserName)
        {
            HttpContext.Current.Session["UserName"] = UserName;
        }
    }
}