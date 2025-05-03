using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
	public class EmployeeModel
	{
		public int employeeId { get; set; }

        [Required(ErrorMessage ="Please enter name!")]
        [RegularExpression("^[A-Za-z]+[A-Za-z ]*$", ErrorMessage = "Please Enter valid name!")]
        public string firstName { get; set; }

        [RegularExpression("^[A-Za-z]+[A-Za-z ]*$", ErrorMessage = "Please Enter valid name!")]
        public string lastName { get; set; }

		[Required(ErrorMessage = "Please enter email Address!")]
        [RegularExpression(".+@.+\\..+", ErrorMessage = "Please Enter valid name!")]
        public string email { get; set; }
		
		[Required(ErrorMessage = "Please enter address!")]
        public string address { get; set; }

		[Required(ErrorMessage = "Please enter designation!")]
        public string designation { get; set; }

		[Required(ErrorMessage = "Please enter gender!")]
        public bool gender { get; set; }

        [Required(ErrorMessage = "Please enter salary!")]
        [Range(1, double.MaxValue, ErrorMessage = "Please enter Valid salary!")]
		public decimal salary { get; set; }

        public bool IsActive { get; set; }

		[Required(ErrorMessage = "Please select your department!")]
		public int departmentId { get; set; }

		public string department { get; set; }
    }
}