using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
	public class DepartmentModel
	{
		public int DepartmentId { get; set; }

		[Required(ErrorMessage = "Please enter valid department!")]
        //[RegularExpression("^[a-zA-Z0-9_]*$", ErrorMessage = "Please Enter valid name!")]
        public string DepartmentName { get; set; }
	}
}