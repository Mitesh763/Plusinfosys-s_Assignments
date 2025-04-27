using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class EmployeePartial
    {
        Departments ObjDepart = new Departments();
        Employees ObjEmployee = new Employees();

        Dictionary<string, string> employeeData = new Dictionary<string, string>();
        public void EmployeeOperation()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n***************** Employee ****************");
            Console.ResetColor();
            bool valid = true;
            while (valid)
            {
                Console.WriteLine("\n***********************************\n***********************************");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. Get All Employee Detail");
                Console.WriteLine("3. Get Employee Detail By ID");
                Console.WriteLine("4. Edit Employee");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Show Main Menu");
                Console.Write("Select Operation: ");
                int.TryParse(Console.ReadLine(), out int option);
                Console.WriteLine("");

                switch (option)
                {
                    case 1:
                        ObjEmployee.AddEmployee(employeeData);
                        break;

                    case 2:
                        ObjEmployee.GetEmployee();
                        break;

                    case 3:
                        ObjEmployee.GetEmployeeByID();
                        break;

                    case 4:
                        ObjEmployee.UpdateEmployee(employeeData);
                        break;

                    case 5:
                        ObjEmployee.DeleteEmployee(employeeData);
                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n************** Welcome to main menu *****************\n");
                        Console.ResetColor();
                        valid = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n========================================================");
                        Console.WriteLine("Invalid Choice, Please Select correct Option!");
                        Console.WriteLine("========================================================\n");
                        Console.ResetColor();
                        break;
                }
            }
        }

        public void DepartmentOperation()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n************ Department ***********");
            Console.ResetColor();
            bool valid = true;
            while (valid)
            {
                Console.WriteLine("\n***********************************\n***********************************");
                Console.WriteLine("1. Add New Department");
                Console.WriteLine("2. Get All Department");
                Console.WriteLine("3. Edit Department");
                Console.WriteLine("4. Delete Department");
                Console.WriteLine("5. Get Highest Salaried Employee in the department.");
                Console.WriteLine("6. Get Second Highest Salaried Employee in the department.");
                Console.WriteLine("7. Show Main Menu");
                Console.Write("Select Operation: ");
                int.TryParse(Console.ReadLine(), out int option);
                Console.WriteLine("");

                switch (option)
                {
                    case 1:
                        ObjDepart.AddDepartment(employeeData);
                        break;

                    case 2:
                        ObjDepart.getDepartment();
                        break;

                    case 3:
                        ObjDepart.updateDepartment(employeeData);
                        break;

                    case 4:
                        ObjDepart.deleteDepartment();
                        break;

                    case 5:
                        ObjDepart.getHighestSalariedEmployee();
                        break;

                    case 6:
                        ObjDepart.getSecondHighestSalariedEmployee();
                        break;

                    case 7:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n************** Welcome to main menu *****************\n");
                        Console.ResetColor();
                        valid = false;
                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n========================================================");
                        Console.WriteLine("Invalid Choice, Please Select correct Option!");
                        Console.WriteLine("========================================================\n");
                        Console.ResetColor();
                        break;
                }
            }
        }

    }
}
