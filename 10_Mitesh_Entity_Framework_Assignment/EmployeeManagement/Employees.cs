using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace EmployeeManagement
{
    public  class Employees
    {
        Departments ObjDepart = new Departments();
        Utilities ObjUtility = new Utilities();

        //Insert
        public void AddEmployee(Dictionary<string, string> employeeData)
        {
            if (ObjDepart.getTotalDepartment())
            {
                List<string> employeeDataList = new List<string>() { "name", "address", "designation" };

                foreach (string field in employeeDataList)
                {
                    bool valid = false;
                    while (!valid)
                    {
                        Console.Write($"Enter Your {field}: ");
                        string userInput = Console.ReadLine();
                        if (ObjUtility.validateField(field, userInput))
                        {
                            employeeData[field] = userInput;
                            valid = true;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\n** Invalid {field}! Please Enter Correct {field}");
                            Console.ResetColor();
                        }
                    }
                }

                bool Gender;
                while (true)
                {
                    Console.Write("Select Your Gender (1. Male 2. Female) : ");
                    string userInput = Console.ReadLine();
                    if (ObjUtility.validateField("gender", userInput))
                    {
                        int.TryParse(userInput, out int gender);
                        if (gender == 1)
                        {
                            Gender = true;
                            break;
                        }
                        else if (gender == 2)
                        {
                            Gender = false;
                            break;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n** Please Select Correct Gender!!");
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n** Please Select Gender!!");
                        Console.ResetColor();
                    }
                }

                float salary;
                while (true)
                {
                    Console.Write("Enter Your Salary: ");
                    string userInput = Console.ReadLine();
                    if (ObjUtility.validateField("Salary", userInput))
                    {
                        float.TryParse(userInput, out salary);
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n** Please Enter Correct Salary!!");
                        Console.ResetColor();
                    }
                }

                Console.WriteLine("*******Existed Department********");
                ObjDepart.getDepartment();


                int department;
                while (true)
                {
                    Console.Write("Enter Your Department: ");
                    string userInput = Console.ReadLine();
                    if (ObjUtility.validateField("department", userInput))
                    {
                        int.TryParse(userInput, out department);
                        if (ObjDepart.isDepartmentId(department)) break;
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n** Invalid department!!");
                            Console.ResetColor();
                        }
                    }
                }

                using (var EmployeeContext = new EmployeeDocEntities())
                {
                    using (DbContextTransaction objTransaction = EmployeeContext.Database.BeginTransaction())
                    {
                        try
                        {
                            var newEmployee = new tblEmployee()
                            {
                                Name = employeeData["name"],
                                Address = employeeData["address"],
                                Designation = employeeData["designation"],
                                Gender = Gender,
                                Salary = Math.Round(salary, 2),
                                Department = department
                            };

                            EmployeeContext.tblEmployees.Add(newEmployee);
                            EmployeeContext.SaveChanges();

                            objTransaction.Commit();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n=========================================");
                            Console.WriteLine("Employee Added Successfully!!");
                            Console.WriteLine("=========================================");
                            Console.ResetColor();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("\n** Failed! Error Occured!!**");
                            objTransaction.Rollback();
                        }
                    }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n** There are no any Department! **");
                Console.ResetColor();
            }
        }

        // Select employee by id
        public void GetEmployeeByID()
        {
            if (getTotalEmployee())
            {
                Console.WriteLine("*******Existed Employee********");
                ExistEmployee();

                while (true)
                {
                    Console.Write("Enter Employee ID: ");
                    int.TryParse(Console.ReadLine(), out int employeeID);
                    if (isEmployeeId(employeeID))
                    {
                        using (var EmployeeContext = new EmployeeDocEntities())
                        {
                            try
                            {
                                ICollection<tblEmployee> employee = EmployeeContext.tblEmployees.OrderBy(e => e.EmployeeId).Where(e => e.EmployeeId == employeeID).ToList();

                                Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("| Employee ID | Name            | Address         | Designation     | Gender  | Salary      | Department           |");
                                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

                                foreach (var emplo in employee)
                                {
                                    string gender;
                                    if (emplo.Gender == true) gender = "Male";
                                    else gender = "Female";
                                    Console.WriteLine("| {0,-11} | {1,-15} | {2,-15} | {3,-15} | {4,-7} | {5,-11} | {6,-20} |",
                                        emplo.EmployeeId,
                                        emplo.Name.ToString(),
                                        emplo.Address.ToString(),
                                        emplo.Designation.ToString(),
                                        gender,
                                        emplo.Salary,
                                        emplo.tblDepartment.DepartmentName
                                        );
                                }
                                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n");

                            }
                            catch (Exception ex)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n** Failed! Data fetching failed!!");
                                Console.ResetColor();
                            }
                        }
                        break;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n** Employee Id not Exist, Please Enter Valid Employee ID!!");
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
                Console.WriteLine("\n** There are no any Employee! **");
                Console.ResetColor();
            }
        }

        //Select all employee
        public void GetEmployee()
        {
            if (getTotalEmployee())
            {
                using (var EmployeeContext = new EmployeeDocEntities())
                {
                    ICollection<tblEmployee> employee = EmployeeContext.tblEmployees.OrderBy(e => e.EmployeeId).ToList();

                    Console.WriteLine("\n--------------------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("| Employee ID | Name            | Address         | Designation     | Gender  | Salary      | Department           |");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");

                    foreach (var emplo in employee)
                    {
                        string gender;
                        if (emplo.Gender == true) gender = "Male";
                        else gender = "Female";
                        Console.WriteLine("| {0,-11} | {1,-15} | {2,-15} | {3,-15} | {4,-7} | {5,-11} | {6,-20} |",
                            emplo.EmployeeId,
                            emplo.Name.ToString(),
                            emplo.Address.ToString(),
                            emplo.Designation.ToString(),
                            gender,
                            emplo.Salary,
                            emplo.tblDepartment.DepartmentName
                            );
                    }
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------------\n");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n** There are no any Employee! **");
                Console.ResetColor();
            }
        }

        // Update
        public void UpdateEmployee(Dictionary<string, string> employeeData)
        {
            if (getTotalEmployee())
            {
                Console.WriteLine("*******Existed Employee********");
                GetEmployee();

                while (true)
                {
                    Console.Write("Enter Employee Id which you want to update: ");
                    int.TryParse(Console.ReadLine(), out int EmployeeID);

                    if (isEmployeeId(EmployeeID))
                    {
                        List<string> employeeDataList = new List<string>() { "Name", "Address", "Designation" };

                        foreach (string field in employeeDataList)
                        {
                            bool valid = false;
                            while (!valid)
                            {
                                Console.Write($"Enter new {field}: ");
                                string userInput = Console.ReadLine();
                                if (ObjUtility.validateField(field, userInput))
                                {
                                    employeeData["new" + field] = userInput;
                                    valid = true;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Invalid new {field}! Please Enter Correct {field}");
                                    Console.ResetColor();
                                }
                            }
                        }

                        bool newGender;
                        while (true)
                        {
                            Console.Write("Select new Gender (1. Male 2. Female) : ");
                            string userInput = Console.ReadLine();
                            if (ObjUtility.validateField("gender", userInput))
                            {
                                int.TryParse(userInput, out int gender);
                                if (gender == 1)
                                {
                                    newGender = true;
                                    break;
                                }
                                else if (gender == 2)
                                {
                                    newGender = false;
                                    break;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n** Invalid Choice!!");
                                    Console.ResetColor();
                                }
                            }
                        }

                        float newSalary;
                        while (true)
                        {
                            Console.Write("Enter new Salary: ");
                            string userInput = Console.ReadLine();
                            if (ObjUtility.validateField("Salary", userInput))
                            {
                                float.TryParse(userInput, out newSalary);
                                break;
                            }
                        }

                        Console.WriteLine("*******Existed Department********");
                        ObjDepart.getDepartment();

                        int newDepartment;
                        while (true)
                        {
                            Console.Write("Enter new Department: ");
                            string userInput = Console.ReadLine();
                            if (ObjUtility.validateField("department", userInput))
                            {
                                int.TryParse(userInput, out newDepartment);
                                if (ObjDepart.isDepartmentId(newDepartment)) break;
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid Department!!");
                                    Console.ResetColor();
                                }
                            }
                        }

                        using (var EmployeeContext = new EmployeeDocEntities())
                        {
                            using (DbContextTransaction objTransaction = EmployeeContext.Database.BeginTransaction())
                            {
                                try
                                {
                                    var updateEmployee = new tblEmployee()
                                    {
                                        EmployeeId = EmployeeID,
                                        Name = employeeData["newName"],
                                        Address = employeeData["newAddress"],
                                        Designation = employeeData["newDesignation"],
                                        Gender = newGender,
                                        Salary = Math.Round(newSalary, 2),
                                        Department = newDepartment
                                    };

                                    EmployeeContext.tblEmployees.AddOrUpdate(updateEmployee);
                                    EmployeeContext.SaveChanges();

                                    objTransaction.Commit();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\n=========================================");
                                    Console.WriteLine($"Employee (ID: {EmployeeID}) Updated Successfully!!");
                                    Console.WriteLine("=========================================");
                                    Console.ResetColor();
                                    break;
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("\n** Failed! **");
                                    objTransaction.Rollback();
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n** Employee Id not Exist, Please Enter Valid Employee ID!!");
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
                Console.WriteLine("\n** There are no any Employee! **");
                Console.ResetColor();
            }
        }

        //Delete
        public void DeleteEmployee(Dictionary<string, string> employeeData)
        {
            if (getTotalEmployee())
            {
                Console.WriteLine("*******Existed Employee********");
                ExistEmployee();

                while (true)
                {
                    Console.Write("Enter Employee Id which you want to delete: ");
                    int.TryParse(Console.ReadLine(), out int EmployeeID);

                    if (isEmployeeId(EmployeeID))
                    {
                        using (var ObjContext = new EmployeeDocEntities())
                        {
                            using (DbContextTransaction objTransaction = ObjContext.Database.BeginTransaction())
                            {
                                try
                                {
                                    var employee = ObjContext.tblEmployees.Where(e => e.EmployeeId == EmployeeID).First<tblEmployee>();

                                    ObjContext.tblEmployees.Remove(employee);
                                    ObjContext.SaveChanges();
                                    objTransaction.Commit();

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\n=========================================");
                                    Console.WriteLine($"Employee(ID: {EmployeeID}) Removed Successfully!!");
                                    Console.WriteLine("=========================================");
                                    Console.ResetColor();
                                    break;
                                }
                                catch (Exception ex)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n** Failed! Department Name Refered in Employee!");
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
                        Console.WriteLine("\n** Employee Id not Exist, Please Enter Valid Employee ID!!");
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
                Console.WriteLine("\n** There are no any Employee! **");
                Console.ResetColor();
            }
        }

        // existed employee
        public void ExistEmployee()
        {
            using (var EmployeeContext = new EmployeeDocEntities())
            {
                ICollection<tblEmployee> employee = EmployeeContext.tblEmployees.ToList();

                Console.WriteLine("\n---------------------------------");
                Console.WriteLine("| Employee ID | Name            |");
                Console.WriteLine("---------------------------------");

                foreach (var emplo in employee)
                {
                    Console.WriteLine("| {0,-11} | {1,-15} |",
                        emplo.EmployeeId,
                        emplo.Name.ToString()
                        );
                }
                Console.WriteLine("---------------------------------");
            }
        }

        //Id exist
        public bool isEmployeeId(int Id)
        {
            using (var ObjContext = new EmployeeDocEntities())
            {
                return ObjContext.tblEmployees.Any(e => e.EmployeeId == Id);
            }
        }

        //employee exist
        public bool getTotalEmployee()
        {
            using (var ObjContext = new EmployeeDocEntities())
            {
                return ObjContext.tblEmployees.Any();
            }
        }
    }
}
