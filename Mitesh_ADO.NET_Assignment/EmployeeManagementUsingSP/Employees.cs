using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeManagementUsingSP
{
    class Employees
    {
        static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        //Insert
        public static void AddEmployee(Dictionary<string, string> employeeData)
        {

            if (Departments.getTotalDepartment())
            {
                List<string> employeeDataList = new List<string>() { "name", "address", "designation" };

                foreach (string field in employeeDataList)
                {
                    bool valid = false;
                    while (!valid)
                    {
                        Console.Write($"Enter Your {field}: ");
                        string userInput = Console.ReadLine();
                        if (Utilities.validateField(field, userInput))
                        {
                            employeeData[field] = userInput;
                            valid = true;
                        }
                        else
                        {
                            Console.WriteLine($"\n** Invalid {field}! Please Enter Correct {field}");
                        }
                    }
                }

                while (true)
                {
                    Console.Write("Select Your Gender (1. Male 2. Female) : ");
                    string userInput = Console.ReadLine();
                    if (Utilities.validateField("gender", userInput))
                    {
                        int.TryParse(userInput, out int gender);
                        if (gender == 1)
                        {
                            employeeData["gender"] = "MALE";
                            break;
                        }
                        else if (gender == 2)
                        {
                            employeeData["gender"] = "FEMALE";
                            break;
                        }
                        else Console.WriteLine("\n** Please Select Correct Gender!!");
                    }
                    else Console.WriteLine("\n** Please Select Gender!!");
                }

                float salary;
                while (true)
                {
                    Console.Write("Enter Your Salary: ");
                    string userInput = Console.ReadLine();
                    if (Utilities.validateField("Salary", userInput))
                    {
                        float.TryParse(userInput, out salary);
                        break;
                    }
                    else Console.WriteLine("\n** Please Enter Correct Salary!!");
                }

                Console.WriteLine("*******Existed Department********");
                Departments.getDepartment();


                int department;
                while (true)
                {
                    Console.Write("Enter Your Department: ");
                    string userInput = Console.ReadLine();
                    if (Utilities.validateField("department", userInput))
                    {
                        int.TryParse(userInput, out department);
                        if (Departments.existDepartmentId(department)) break;
                        else Console.WriteLine("\n** Invalid department!!");
                    }
                }

                SqlConnection objConn = new SqlConnection(connString);
                SqlCommand objCmd = objConn.CreateCommand();

                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "sp_tblEmployeesInsert";
                objCmd.Parameters.AddWithValue("@Name", employeeData["name"]);
                objCmd.Parameters.AddWithValue("@Address", employeeData["address"]);
                objCmd.Parameters.AddWithValue("@Designation", employeeData["designation"]);
                objCmd.Parameters.AddWithValue("@Gender", employeeData["gender"]);
                objCmd.Parameters.AddWithValue("@Salary", salary);
                objCmd.Parameters.AddWithValue("@Department", department);

                objConn.Open();
                try
                {
                    int insertEmployee = objCmd.ExecuteNonQuery();
                    if (insertEmployee > 0)
                    {
                        Console.WriteLine("\n========================================================");
                        Console.WriteLine($"{insertEmployee} Record Inserted successfully!");
                        Console.WriteLine("========================================================\n");
                    }
                    else
                    {
                        Console.WriteLine("\n** Failed! Error While in Insertion!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\n** Unexpected Operation! Enterd Department ID Doesn't Exist!");
                }
                objConn.Close();
            }
            else Console.WriteLine("\n** There are no any Department! **");
        }

        // Select employee by id
        public static void GetEmployeeByID()
        {
            if (getTotalEmployee())
            {
                Console.WriteLine("*******Existed Department********");
                ExistEmployee();

                while (true)
                {
                    SqlConnection objConn = new SqlConnection(connString);
                    SqlCommand objCmd = objConn.CreateCommand();


                    Console.Write("Enter Employee ID: ");
                    int.TryParse(Console.ReadLine(), out int employeeID);
                    if (existEmployeeId(employeeID))
                    {

                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "sp_tblEmployeesSelectByID";
                        objCmd.Parameters.AddWithValue("@employeeId", employeeID);

                        objConn.Open();
                        SqlDataReader reader = objCmd.ExecuteReader();

                        Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("| Employee ID | Name            | Address         | Designation     | Gender  | Salary      | Department       |");
                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

                        while (reader.Read())
                        {
                            Console.WriteLine("| {0,-11} | {1,-15} | {2,-15} | {3,-15} | {4,-7} | {5,-10} | {6,-20} |",
                                reader["EmployeeId"],
                                reader["Name"],
                                reader["Address"],
                                reader["Designation"],
                                reader["Gender"],
                                reader["Salary"],
                                reader["DepartmentName"]);
                        }

                        Console.WriteLine("----------------------------------------------------------------------------------------------------------------------\n");
                        break;

                        objConn.Close();
                    }
                    else Console.WriteLine("\n** THere is no any Employee");
                }
            }
            else Console.WriteLine("\n** There are no any Employee! **");
        }

        //Select all employee
        public static void GetEmployee()
        {
            if (getTotalEmployee())
            {
                SqlConnection objConn = new SqlConnection(connString);
                SqlCommand objCmd = objConn.CreateCommand();

                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.CommandText = "sp_tblEmployeesSelect";
                objConn.Open();
                SqlDataReader reader = objCmd.ExecuteReader();

                Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("| Employee ID | Name            | Address         | Designation     | Gender  | Salary      | Department           |");
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");

                while (reader.Read())
                {
                    Console.WriteLine("| {0,-11} | {1,-15} | {2,-15} | {3,-15} | {4,-7} | {5,-11} | {6,-20} |",
                        reader["EmployeeId"],
                        reader["Name"],
                        reader["Address"],
                        reader["Designation"],
                        reader["Gender"],
                        reader["Salary"],
                        reader["DepartmentName"]);
                }

                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------\n");

                objConn.Close();
            }
            else Console.WriteLine("\n** There are no any Employee! **");
        }

        // Update
        public static void UpdateEmployee(Dictionary<string, string> employeeData)
        {
            if (getTotalEmployee())
            {
                Console.WriteLine("*******Existed Employee********");
                ExistEmployee();

                while (true)
                {
                    Console.Write("Enter Employee Id which you want to update: ");
                    int.TryParse(Console.ReadLine(), out int EmployeeID);

                    if (existEmployeeId(EmployeeID))
                    {
                        List<string> employeeDataList = new List<string>() { "Name", "Address", "Designation" };

                        foreach (string field in employeeDataList)
                        {
                            bool valid = false;
                            while (!valid)
                            {
                                Console.Write($"Enter new {field}: ");
                                string userInput = Console.ReadLine();
                                if (Utilities.validateField(field, userInput))
                                {
                                    employeeData["new" + field] = userInput;
                                    valid = true;
                                }
                                else
                                {
                                    Console.WriteLine($"Invalid new {field}! Please Enter Correct {field}");
                                }
                            }
                        }


                        while (true)
                        {
                            Console.Write("Select new Gender (1. Male 2. Female) : ");
                            string userInput = Console.ReadLine();
                            if (Utilities.validateField("gender", userInput))
                            {
                                int.TryParse(userInput, out int gender);
                                if (gender == 1)
                                {
                                    employeeData["newGender"] = "MALE";
                                    break;
                                }
                                else if (gender == 2)
                                {
                                    employeeData["newGender"] = "FEMALE";
                                    break;
                                }
                                else Console.WriteLine("\n** Invalid Choice!!");
                            }
                        }

                        float newSalary;
                        while (true)
                        {
                            Console.Write("Enter new Salary: ");
                            string userInput = Console.ReadLine();
                            if (Utilities.validateField("Salary", userInput))
                            {
                                float.TryParse(userInput, out newSalary);
                                break;
                            }
                        }

                        Console.WriteLine("*******Existed Department********");
                        Departments.getDepartment();

                        int newDepartment;
                        while (true)
                        {
                            Console.Write("Enter new Department: ");
                            string userInput = Console.ReadLine();
                            if (Utilities.validateField("department", userInput))
                            {
                                int.TryParse(userInput, out newDepartment);
                                if (Departments.existDepartmentId(newDepartment)) break;
                            }
                        }

                        SqlConnection objConn = new SqlConnection(connString);
                        SqlCommand objCmd = objConn.CreateCommand();

                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "sp_tblEmployeesUpdate";

                        objCmd.Parameters.AddWithValue("@employeeId", EmployeeID);
                        objCmd.Parameters.AddWithValue("@newName", employeeData["newName"]);
                        objCmd.Parameters.AddWithValue("@newAddress", employeeData["newAddress"]);
                        objCmd.Parameters.AddWithValue("@newDesignation", employeeData["newDesignation"]);
                        objCmd.Parameters.AddWithValue("@newGender", employeeData["newGender"]);
                        objCmd.Parameters.AddWithValue("@newSalary", newSalary);
                        objCmd.Parameters.AddWithValue("@newDepartment", newDepartment);

                        objConn.Open();
                        try
                        {
                            int affectedRow = objCmd.ExecuteNonQuery();
                            if (affectedRow > 0)
                            {
                                Console.WriteLine("\n========================================================");
                                Console.WriteLine($"{affectedRow} Employee Updated Whoose employee ID: {EmployeeID}");
                                Console.WriteLine("========================================================\n");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("\n** Failed! Enterd Employee ID Doesn't Exist");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Unexpected Operation! Enterd Department ID Doesn't Exist");
                        }
                        objConn.Close();
                    }
                    else
                    {
                        Console.WriteLine("Enterd Id Not Exist!!");
                    }
                }
            }
            else Console.WriteLine("\n** There are no any Employee! **");
        }

        //Delete
        public static void DeleteEmployee(Dictionary<string, string> employeeData)
        {
            if (getTotalEmployee())
            {
                Console.WriteLine("*******Existed Employee********");
                ExistEmployee();

                while (true)
                {
                    Console.Write("Enter Employee Id which you want to delete: ");
                    int.TryParse(Console.ReadLine(), out int EmployeeID);

                    if (existEmployeeId(EmployeeID))
                    {
                        SqlConnection objConn = new SqlConnection(connString);
                        SqlCommand objCmd = objConn.CreateCommand();

                        objCmd.CommandType = CommandType.StoredProcedure;
                        objCmd.CommandText = "sp_tblEmployeesDelete";

                        objCmd.Parameters.AddWithValue("@employeeId", EmployeeID);

                        objConn.Open();
                        int affectedRow = objCmd.ExecuteNonQuery();
                        if (affectedRow > 0)
                        {
                            Console.WriteLine("\n========================================================");
                            Console.WriteLine($"{affectedRow} Employee removed Whoose employee ID: {EmployeeID}");
                            Console.WriteLine("========================================================\n");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\tFailed! Please Enter Valid Employee ID");
                        }
                        objConn.Close();
                    }
                    else
                    {
                        Console.WriteLine("\n** Enterd Employee Id Not Exist!!");
                    }
                }
            }
            else Console.WriteLine("\n** There are no any Employee! **");
        }

        // existed employee
        public static void ExistEmployee()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand objCmd = connection.CreateCommand())
                {
                    objCmd.CommandText = "sp_tblEmployeesExistList";
                    objCmd.CommandType = CommandType.StoredProcedure;

                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("| {0,-15} | {1,-20} |", "Employee ID", "Name");
                    Console.WriteLine("-------------------------------------------");

                    connection.Open();
                    SqlDataReader reader = objCmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("| {0,-15} | {1,-20} |",
                            reader["EmployeeId"],
                            reader["Name"]);
                    }

                    Console.WriteLine("-------------------------------------------");
                    connection.Close();
                }
            }
        }

        //Id exist
        public static bool existEmployeeId(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand objCmd = connection.CreateCommand())
                {
                    objCmd.CommandText = "sp_tblEmployeesExistEmployeeID";
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.Parameters.AddWithValue("@id", Id);

                    connection.Open();
                    Object obj = objCmd.ExecuteScalar();
                    if (obj != null)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
        }

        //employee exist
        public static bool getTotalEmployee()
        {
            int Count = 0;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand objCmd = connection.CreateCommand())
                {
                    objCmd.CommandText = "sp_tblEmployeesExistEmployee";
                    objCmd.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    Object obj = objCmd.ExecuteScalar();
                    if (obj != null)
                    {
                        connection.Close();
                        return true;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
            }
        }
    }
}
