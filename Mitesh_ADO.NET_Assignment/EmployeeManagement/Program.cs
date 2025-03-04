using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> employeeData = new Dictionary<string, string>();

            bool valid = true;
            while (valid)
            {
                Console.WriteLine("\n***********************************\n***********************************");
                Console.WriteLine("1. Perform Employee Operation");
                Console.WriteLine("2. Perform Department Operation");
                Console.WriteLine("3. Exit");
                Console.Write("Select Operation: ");
                int.TryParse(Console.ReadLine(), out int option);
                Console.WriteLine("");

                switch (option)
                {
                    case 1:
                        if (Departments.getTotalDepartment()) Utilities.EmployeeOperation();
                        else Console.WriteLine("Atleast One Department Is Required for Employee Operation!");
                        break;

                    case 2:
                        Utilities.DepartmentOperation();
                        break;

                    case 3:
                        Console.WriteLine("\n====================================================================================");
                        Console.WriteLine("\t\t\t\tThank you!");
                        Console.WriteLine("====================================================================================\n");
                        valid = false;
                        break;

                    default:
                        Console.WriteLine("\n========================================================");
                        Console.WriteLine("Invalid Choice, Please Select correct Option!");
                        Console.WriteLine("========================================================\n");
                        break;
                }
            }
        }
    }
}
