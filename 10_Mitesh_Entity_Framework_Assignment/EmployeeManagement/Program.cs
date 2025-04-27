using System;

namespace EmployeeManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Departments ObjDepart = new Departments();
            EmployeePartial ObjEmployee = new EmployeePartial();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n====================================================================================");
            Console.WriteLine("\t\t\t\tWelCome to Employee Management System");
            Console.WriteLine("====================================================================================\n");
            Console.ResetColor();

            bool valid = true;
            while (valid)
            {
                Console.WriteLine("1. Perform Department Operation");
                Console.WriteLine("2. Perform Employee Operation");
                Console.WriteLine("3. Exit");
                Console.Write("Select Operation: ");
                int.TryParse(Console.ReadLine(), out int option);
                Console.WriteLine("");

                switch (option)
                {
                    case 1:
                        ObjEmployee.DepartmentOperation(); break;

                    case 2:
                        if (ObjDepart.getTotalDepartment()) ObjEmployee.EmployeeOperation();
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Atleast One Department Is Required for Employee Operation!\n");
                            Console.ResetColor();
                        }
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\n====================================================================================");
                        Console.WriteLine("\t\t\t\tThank you!");
                        Console.WriteLine("====================================================================================\n");
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
