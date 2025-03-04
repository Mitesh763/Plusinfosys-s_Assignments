using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EmployeeManagementUsingSP
{
    class Utilities
    {
        static Dictionary<string, string> employeeData = new Dictionary<string, string>();
        public static void EmployeeOperation()
        {


            bool valid = true;
            while (valid)
            {
                Console.WriteLine("\n***********************************\n***********************************");
                Console.WriteLine("1. Add New Employee");
                Console.WriteLine("2. Get All Employee Detail");
                Console.WriteLine("3. Get Employee Detail By ID");
                Console.WriteLine("4. Update Employee");
                Console.WriteLine("5. Delete Employee");
                Console.WriteLine("6. Show Main Menu");
                Console.Write("Select Operation: ");
                int.TryParse(Console.ReadLine(), out int option);
                Console.WriteLine("");

                switch (option)
                {
                    case 1:
                        Employees.AddEmployee(employeeData);
                        break;

                    case 2:
                        Employees.GetEmployee();
                        break;

                    case 3:
                        Employees.GetEmployeeByID();
                        break;

                    case 4:
                        Employees.UpdateEmployee(employeeData);
                        break;

                    case 5:
                        Employees.DeleteEmployee(employeeData);
                        break;

                    case 6:
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

        public static void DepartmentOperation()
        {
            bool valid = true;
            while (valid)
            {
                Console.WriteLine("\n***********************************\n***********************************");
                Console.WriteLine("1. Add New Department");
                Console.WriteLine("2. Get All Department");
                Console.WriteLine("3. Delete Department");
                Console.WriteLine("4. Get Highest Salaried Employee in the department.");
                Console.WriteLine("5. Get Second Highest Salaried Employee in the department.");
                Console.WriteLine("6. Show Main Menu");
                Console.Write("Select Operation: ");
                int.TryParse(Console.ReadLine(), out int option);
                Console.WriteLine("");

                switch (option)
                {
                    case 1:
                        Departments.AddDepartment(employeeData);
                        break;

                    case 2:
                        Departments.getDepartment();
                        break;

                    case 3:
                        Departments.deleteDepartment();
                        break;

                    case 4:
                        Departments.getHighestSalariedEmployee();
                        break;

                    case 5:
                        Departments.getSecondHighestSalariedEmployee();
                        break;

                    case 6:
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

        public static bool validateField(string fieldName, string userInput)
        {
            if (string.IsNullOrWhiteSpace(userInput)) return false;

            switch (fieldName.ToLower())
            {
                case "name":
                    if (!Regex.IsMatch(userInput, "^[A-Za-z]+[A-Za-z ]*$"))
                    {
                        return false;
                    }
                    break;

                case "address":
                    if (!Regex.IsMatch(userInput, "^[a-zA-Z0-9 ,:/\\-]*$")) return false;
                    break;

                case "designation":
                    if (Regex.IsMatch(userInput, "^[0-9-]*$") || !Regex.IsMatch(userInput, "^[a-zA-Z0-9 ,:/\\-]*$")) return false;
                    break;

                case "gender":
                    if (!Regex.IsMatch(userInput, "^[0-9-]*$")) return false;
                    break;

                case "salary":
                    if (!Regex.IsMatch(userInput, "([0-9])[0-9]*[.]?[0-9]*"))
                    {
                        Console.WriteLine("Invalid Salary!!");
                        return false;
                    }
                    break;

                case "department":
                    if (!Regex.IsMatch(userInput, "^[0-9-]*$"))
                    {
                        Console.WriteLine("Invalid Department!!");
                        return false;
                    }
                    break;

                case "departmentname":
                    if (Regex.IsMatch(userInput, "^[0-9-]*$"))
                    {
                        Console.WriteLine("Invalid Department!!");
                        return false;
                    }
                    break;
            }
            return true;
        }
    }
}
