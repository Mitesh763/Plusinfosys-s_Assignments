using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmployeeManagement
{
    public class Departments
    {
        static readonly Regex trimmer = new Regex(@"\s\s+");
        Utilities ObjUtility = new Utilities();

        //insert department
        public void AddDepartment(Dictionary<string, string> employeeData)
        {
            while (true)
            {
                bool valid = false;
                while (!valid)
                {
                    Console.Write("Enter Department Name: ");
                    string userInput = Console.ReadLine();
                    if (ObjUtility.validateField("departmentName", userInput))
                    {
                        userInput = trimmer.Replace(userInput, " ");
                        employeeData["departmentName"] = userInput;
                        valid = true;
                    }
                }

                using (var ObjContext = new EmployeeDocEntities())
                {
                    using (DbContextTransaction objTransaction = ObjContext.Database.BeginTransaction())
                    {
                        try
                        {
                            var newDepartment = new tblDepartment()
                            {
                                DepartmentName = employeeData["departmentName"].Trim()
                            };

                            ObjContext.tblDepartments.Add(newDepartment);
                            ObjContext.SaveChanges();
                            objTransaction.Commit();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n=========================================");
                            Console.WriteLine("Department Added Successfully!!");
                            Console.WriteLine("=========================================");
                            Console.ResetColor();
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n** Failed! Department name already Exist!");
                            Console.ResetColor();
                            objTransaction.Rollback();
                            Console.Write("Want to Exit? ( press 'y' ): ");
                            string continueProcess = Console.ReadLine();
                            if (continueProcess.ToLower() == "y") return;
                            else continue;
                        }
                    }
                }
            }
        }

        //get department
        public void getDepartment()
        {
            if (getTotalDepartment())
            {
                using (var ObjContext = new EmployeeDocEntities())
                {
                    try
                    {
                        ICollection<tblDepartment> department = ObjContext.tblDepartments.OrderBy(e => e.DepartmentId).ToList();

                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("| {0,-15} | {1,-20} |", "Department ID", "Department Name");
                        Console.WriteLine("|----------------------------------------|");

                        foreach (var depart in department)
                        {
                            Console.WriteLine("| {0,-15} | {1,-20} |",
                            depart.DepartmentId.ToString(),
                            depart.DepartmentName.ToString());
                        }
                        Console.WriteLine("------------------------------------------");
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n** Failed! Department Not Exist!");
                        Console.ResetColor();
                    }

                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n** There are no any Department!");
                Console.ResetColor();
            }
        }

        //update Department
        public void updateDepartment(Dictionary<string, string> employeeData)
        {
            if (getTotalDepartment())
            {
                Console.WriteLine("*******Existed Department********");
                getDepartment();

                while (true)
                {
                    Console.Write("Enter Department Id which you want to update: ");
                    int.TryParse(Console.ReadLine(), out int departmentId);

                    if (isDepartmentId(departmentId))
                    {
                        using (var ObjContext = new EmployeeDocEntities())
                        {
                            using (DbContextTransaction objTransaction = ObjContext.Database.BeginTransaction())
                            {
                                try
                                {
                                    bool valid = false;
                                    while (!valid)
                                    {
                                        Console.Write("Enter Department Name: ");
                                        string userInput = Console.ReadLine();
                                        if (ObjUtility.validateField("departmentName", userInput))
                                        {
                                            userInput = trimmer.Replace(userInput, " ");
                                            employeeData["newDepartmentName"] = userInput;
                                            valid = true;
                                        }
                                    }

                                    var updatedepartment = new tblDepartment()
                                    {
                                        DepartmentId = departmentId,
                                        DepartmentName = employeeData["newDepartmentName"].Trim()
                                    };
                                    ObjContext.tblDepartments.AddOrUpdate(updatedepartment);
                                    ObjContext.SaveChanges();

                                    objTransaction.Commit();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\n=========================================");
                                    Console.WriteLine($"Department (ID: {departmentId}) Updated Successfully!!");
                                    Console.WriteLine("=========================================");
                                    Console.ResetColor();
                                    break;
                                }
                                catch (Exception ex)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n** Failed! Department name already Exist!");
                                    Console.ResetColor();
                                    objTransaction.Rollback();
                                    Console.Write("Want to Exit? ( press 'y' ): ");
                                    string continueProcess = Console.ReadLine();
                                    if (continueProcess.ToLower() == "y") return;
                                    else continue;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Department Not Exist!!");
                        Console.ResetColor();
                        Console.Write("Want to Exit? ( press 'y' ): ");
                        string continueProcess = Console.ReadLine();
                        if (continueProcess.ToLower() == "y") return;
                        else continue;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n** There are no any Department!");
                Console.ResetColor();
            }
        }

        //delete department
        public void deleteDepartment()
        {
            if (getTotalDepartment())
            {
                Console.WriteLine("*******Existed Department********");
                getDepartment();

                while (true)
                {
                    Console.Write("Enter Department ID: ");
                    int.TryParse(Console.ReadLine(), out int departmentId);

                    if (isDepartmentId(departmentId))
                    {
                        using (var ObjContext = new EmployeeDocEntities())
                        {
                            using (DbContextTransaction objTransaction = ObjContext.Database.BeginTransaction())
                            {
                                try
                                {
                                    var department = ObjContext.tblDepartments.Where(d => d.DepartmentId == departmentId).First<tblDepartment>();

                                    ObjContext.tblDepartments.Remove(department);
                                    ObjContext.SaveChanges();
                                    objTransaction.Commit();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\n=========================================");
                                    Console.WriteLine($"Department(ID: {departmentId}) Removed Successfully!!");
                                    Console.WriteLine("=========================================");
                                    Console.ResetColor();
                                    break;
                                }
                                catch (Exception ex)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n** Failed! You can not delete, This Department Refered in Employee!");
                                    Console.ResetColor();
                                    objTransaction.Rollback();
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n**Invalid Department ID, Please Enter Valid Department ID!");
                        Console.ResetColor();
                        Console.Write("Want to Exit? ( press 'y' ): ");
                        string continueProcess = Console.ReadLine();
                        if (continueProcess.ToLower() == "y") return;
                        else continue;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n** There are no any Department!");
                Console.ResetColor();
            }
        }

        // Get Highest Salaried employee in department
        public void getHighestSalariedEmployee()
        {
            if (getTotalDepartment())
            {
                Console.WriteLine("*******Existed Department********");
                getDepartment();

                while (true)
                {
                    Console.Write("Enter Department Id for Highest Salaried Employee : ");
                    int.TryParse(Console.ReadLine(), out int departmentId);

                    if (isDepartmentId(departmentId))
                    {
                        using (var ObjContext = new EmployeeDocEntities())
                        {
                            try
                            {
                                var maxSalary = ObjContext.tblEmployees.Where(e => e.Department == departmentId).Max(e => e.Salary);
                                var employee = ObjContext.tblEmployees
                                    .Where(e => (e.Department == departmentId) && (e.Salary == maxSalary))
                                    .OrderByDescending(e => e.Salary)
                                    .ToList();
                                if (maxSalary != null)
                                {
                                    Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("| Employee ID | Name            | Address         | Designation     | Gender  | Salary      | Department           |");
                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

                                    foreach (var emplo in employee)
                                    {
                                        Console.WriteLine("| {0,-11} | {1,-15} | {2,-15} | {3,-15} | {4,-7} | {5,-11} | {6,-20} |",
                                            emplo.EmployeeId,
                                            emplo.Name.ToString(),
                                            emplo.Address.ToString(),
                                            emplo.Designation.ToString(),
                                            emplo.Gender.ToString(),
                                            emplo.Salary,
                                            emplo.tblDepartment.DepartmentName
                                            );
                                    }
                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n");

                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Record not found for highest salaried employee in this department!");
                                    Console.ResetColor();
                                    Console.Write("Want to Exit? ( press 'y' ): ");
                                    string continueProcess = Console.ReadLine();
                                    if (continueProcess.ToLower() == "y") return;
                                    else continue;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Record not found for highest salaried employee in this department!");
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n** Department not exist!!");
                        Console.Write("Want to Exit? ( press 'y' ): ");
                        Console.ResetColor();
                        string continueProcess = Console.ReadLine();
                        if (continueProcess.ToLower() == "y") return;
                        else continue;
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n** There are no any Employee!");
                Console.ResetColor();

            }
        }

        // Get Second Highest Salaried employee in department
        public void getSecondHighestSalariedEmployee()
        {
            if (getTotalDepartment())
            {
                Console.WriteLine("*******Existed Department********");
                getDepartment();

                while (true)
                {
                    Console.Write("Enter Department Id for Highest Salaried Employee : ");
                    int.TryParse(Console.ReadLine(), out int departmentId);

                    if (isDepartmentId(departmentId))
                    {
                        using (var ObjContext = new EmployeeDocEntities())
                        {
                            try
                            {
                                var maxSalary = ObjContext.tblEmployees.Where(e => e.Department == departmentId).Max(e => e.Salary);
                                var SecondMaxSalary = ObjContext.tblEmployees.Where(e => (e.Department == departmentId) && (e.Salary < maxSalary)).Max(e => e.Salary);

                                var employee = ObjContext.tblEmployees
                                    .Where(e => (e.Department == departmentId) && (e.Salary == SecondMaxSalary))
                                    .OrderByDescending(e => e.Salary)
                                    .ToList();

                                if (SecondMaxSalary != null)
                                {
                                    Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("| Employee ID | Name            | Address         | Designation     | Gender  | Salary      | Department           |");
                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

                                    foreach (var emplo in employee)
                                    {
                                        Console.WriteLine("| {0,-11} | {1,-15} | {2,-15} | {3,-15} | {4,-7} | {5,-11} | {6,-20} |",
                                            emplo.EmployeeId,
                                            emplo.Name.ToString(),
                                            emplo.Address.ToString(),
                                            emplo.Designation.ToString(),
                                            emplo.Gender.ToString(),
                                            emplo.Salary,
                                            emplo.tblDepartment.DepartmentName
                                            );
                                    }
                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Record not found for second highest salaried employee in this department!");
                                    Console.ResetColor();
                                    Console.Write("Want to Exit? ( press 'y' ): ");
                                    string continueProcess = Console.ReadLine();
                                    if (continueProcess.ToLower() == "y") return;
                                    else continue;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Error Occured!!");
                                Console.ResetColor();
                            }
                            }
                    }
                    else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n** Department not exist!!");
                            Console.ResetColor();
                            Console.Write("Want to Exit? ( press 'y' ): ");
                            string continueProcess = Console.ReadLine();
                            if (continueProcess.ToLower() == "y") return;
                            else continue;
                        }
                    }
                }
            else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n** There are no any Employee!");
                    Console.ResetColor();
                }
            }

        // get department
        public bool getTotalDepartment()
        {
            using (var ObjContext = new EmployeeDocEntities())
            {
                return ObjContext.tblDepartments.Any();
            }
        }

        //department id Exist
        public bool isDepartmentId(int Id)
        {
            using (var ObjContext = new EmployeeDocEntities())
            {
                return ObjContext.tblDepartments.Any(d => d.DepartmentId == Id);
            }
        }
    }
}