using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeManagement
{
    class Departments
    {
        static string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        //insert department
        public static void AddDepartment(Dictionary<string, string> employeeData)
        {
            while (true)
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    using (SqlCommand objCmd = connection.CreateCommand())
                    {
                        bool valid = false;
                        while (!valid)
                        {
                            Console.Write("Enter Department Name: ");
                            string userInput = Console.ReadLine();
                            if (Utilities.validateField("departmentName", userInput))
                            {
                                employeeData["departmentName"] = userInput.ToUpper();
                                valid = true;
                            }
                        }

                        objCmd.CommandType = CommandType.Text;
                        objCmd.CommandText = "INSERT INTO tblDepartments (DepartmentName) VALUES (@departmentName)";
                        objCmd.Parameters.AddWithValue("@departmentName", employeeData["departmentName"]);

                        connection.Open();

                        try
                        {
                            int insertDepartment = objCmd.ExecuteNonQuery();
                            if (insertDepartment > 0)
                            {
                                Console.WriteLine("\n========================================================");
                                Console.WriteLine($"{insertDepartment} Record Inserted successfully!");
                                Console.WriteLine("========================================================\n");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\n========================================================");
                                Console.WriteLine("\n** Failed! ");
                                Console.WriteLine("========================================================\n");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("\n========================================================");
                            Console.WriteLine("\n** Failed, Department Name alrady Exist!!");
                            Console.WriteLine("========================================================\n");
                        }
                        connection.Close();
                    }
                }
            }
        }

        //get department
        public static void getDepartment()
        {
            if (getTotalDepartment())
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    using (SqlCommand objCmd = connection.CreateCommand())
                    {
                        objCmd.CommandType = CommandType.Text;
                        objCmd.CommandText = "SELECT * FROM tblDepartments ORDER BY DepartmentId";

                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("| {0,-15} | {1,-20} |", "Department ID", "Department Name");
                        Console.WriteLine("-------------------------------------------");

                        connection.Open();
                        SqlDataReader reader = objCmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Console.WriteLine("| {0,-15} | {1,-20} |",
                                reader["DepartmentId"],
                                reader["DepartmentName"]);
                        }

                        Console.WriteLine("-------------------------------------------");
                        connection.Close();
                    }
                }
            }
            else Console.WriteLine("\n** There are no any Department!");
        }

        //delete department
        public static void deleteDepartment()
        {
            if (getTotalDepartment())
            {
                Console.WriteLine("*******Existed Department********");
                getDepartment();

                while (true)
                {
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        using (SqlCommand objCmd = connection.CreateCommand())
                        {
                            Console.Write("Enter Department ID: ");
                            int.TryParse(Console.ReadLine(), out int departmentId);

                            if (existDepartmentId(departmentId))
                            {


                                objCmd.CommandType = CommandType.Text;
                                objCmd.CommandText = "DELETE FROM tblDepartments WHERE DepartmentId = @departmentId";

                                objCmd.Parameters.AddWithValue("@departmentId", departmentId);

                                connection.Open();
                                try
                                {
                                    int affectedRow = objCmd.ExecuteNonQuery();
                                    if (affectedRow > 0)
                                    {
                                        Console.WriteLine("\n========================================================");
                                        Console.WriteLine($"{affectedRow} Department removed Whoose Department ID: {departmentId}");
                                        Console.WriteLine("========================================================\n");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("****** Failed! Please Enter Valid Department ID ******");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("****** Entered Department Id is Refer in Employee Record! Cann't delete! ******");
                                }
                                connection.Close();
                            }
                            else Console.WriteLine("\n** Department ID does not Exist!! Please Enter Correct ID!");
                            Console.Write("Want to Exit? ( press 'n' ): ");
                            string continueProcess = Console.ReadLine();
                            if (continueProcess == "n" || continueProcess == "N") return;
                            else continue;
                        }
                    }
                }
            }
            else Console.WriteLine("\n** There are no any Department!");
        }

        // Get Highest Salaried employee in department
        public static void getHighestSalariedEmployee()
        {
            if (getTotalDepartment() && Employees.getTotalEmployee())
            {
                Console.WriteLine("*******Existed Department********");
                getDepartment();

                while (true)
                {
                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        Console.Write("Enter Department Id for Highest Salaried Employee : ");
                        int.TryParse(Console.ReadLine(), out int departmentId);

                        if (existDepartmentId(departmentId))
                        {
                            using (SqlCommand objCmd = connection.CreateCommand())
                            {
                                objCmd.CommandText = "SELECT * FROM (SELECT *, RANK() OVER (ORDER BY Salary DESC) AS SalaryRank FROM tblEmployees WHERE Department = @departmentId) AS rankedEmployees WHERE SalaryRank = 1;";
                                objCmd.CommandType = CommandType.Text;
                                objCmd.Parameters.AddWithValue("@departmentId", departmentId);

                                connection.Open();

                                SqlDataReader reader = objCmd.ExecuteReader();

                                if (reader.HasRows)
                                {

                                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("| Employee ID | Name           | Address        | Designation      | Gender | Salary     | Department       |");
                                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

                                    while (reader.Read())
                                    {
                                        Console.WriteLine("| {0,-11} | {1,-14} | {2,-14} | {3,-15} | {4,-6} | {5,-10} | {6,-15} |",
                                            reader["EmployeeId"],
                                            reader["Name"],
                                            reader["Address"],
                                            reader["Designation"],
                                            reader["Gender"],
                                            reader["Salary"],
                                            reader["Department"]);
                                    }

                                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                                    connection.Close();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No Record Found!");
                                }
                            }
                        }
                        else Console.WriteLine("\n** Department Id Not exist!!");
                    }
                }
            }
            else Console.WriteLine("\n** There are no any Employee!");
        }


        // Get Second Highest Salaried employee in department
        public static void getSecondHighestSalariedEmployee()
        {
            if (getTotalDepartment() && Employees.getTotalEmployee())
            {
                Console.WriteLine("*******Existed Department********");
                getDepartment();

                while (true)
                {


                    using (SqlConnection connection = new SqlConnection(connString))
                    {
                        Console.Write("Enter Department Id for Second Highest salaried Employee : ");
                        int.TryParse(Console.ReadLine(), out int departmentId);

                        if (existDepartmentId(departmentId))
                        {
                            using (SqlCommand objCmd = connection.CreateCommand())
                            {
                                objCmd.CommandText = "SELECT * FROM (SELECT *, RANK() OVER (ORDER BY Salary DESC) AS SalaryRank FROM tblEmployees WHERE Department = @departmentId) AS rankedEmployees WHERE SalaryRank = 2;";
                                objCmd.CommandType = CommandType.Text;
                                objCmd.Parameters.AddWithValue("@departmentId", departmentId);

                                connection.Open();

                                SqlDataReader reader = objCmd.ExecuteReader();

                                if (reader.HasRows)
                                {
                                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("| Employee ID | Name           | Address        | Designation      | Gender | Salary     | Department       |");
                                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");

                                    while (reader.Read())
                                    {
                                        Console.WriteLine("| {0,-11} | {1,-14} | {2,-14} | {3,-15} | {4,-6} | {5,-10} | {6,-15} |",
                                            reader["EmployeeId"],
                                            reader["Name"],
                                            reader["Address"],
                                            reader["Designation"],
                                            reader["Gender"],
                                            reader["Salary"],
                                            reader["Department"]);
                                    }

                                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
                                    connection.Close();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("No Record Found!");
                                    Console.Write("Want to Exit? ( press 'n' ) : ");
                                    string continueProcess = Console.ReadLine();
                                    if (continueProcess == "n" || continueProcess == "N") return;
                                    else continue;
                                }
                            }
                        }
                        else Console.WriteLine("\n** Department Id Not exist!!");
                    }
                }
            }
            else Console.WriteLine("\n** There are no any Employee!");
        }

        // get department
        public static bool getTotalDepartment()
        {
            int Count = 0;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand objCmd = connection.CreateCommand())
                {
                    objCmd.CommandText = "SELECT DepartmentId FROM tblDepartments";
                    objCmd.CommandType = CommandType.Text;

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

        //department id Exist
        public static bool existDepartmentId(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand objCmd = connection.CreateCommand())
                {
                    objCmd.CommandText = "SELECT DepartmentId FROM tblDepartments WHERE DepartmentId = @id";
                    objCmd.CommandType = CommandType.Text;
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
    }
}
