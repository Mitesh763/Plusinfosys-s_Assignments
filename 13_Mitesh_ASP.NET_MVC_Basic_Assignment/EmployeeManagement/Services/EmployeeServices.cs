using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Services
{
	public class EmployeeServices : BaseService
	{

        // get all emloyee
		public List<EmployeeModel> GetEmployeeDetail()
		{
		    List<EmployeeModel> employees = new List<EmployeeModel>();
            using (SqlConnection ObjConn = new SqlConnection(this.connectDB()))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblEmployeesSelect";
                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();
                        while (ObjReader.Read())
                        {
                            EmployeeModel employee = new EmployeeModel();

                            employee.employeeId = (Int32)ObjReader["EmployeeId"];
                            employee.firstName = ObjReader["FirstName"].ToString();
                            employee.lastName = ObjReader["LastName"].ToString();
                            employee.email = ObjReader["Email"].ToString();
                            employee.address = ObjReader["Address"].ToString();
                            employee.designation = ObjReader["Designation"].ToString();
                            employee.gender = (bool)ObjReader["Gender"];
                            employee.salary = Convert.ToDecimal(ObjReader["Salary"]);
                            employee.IsActive = (bool)ObjReader["IsActive"];
                            employee.departmentId = (Int32)ObjReader["DepartmentId"];
                            employee.department = ObjReader["DepartmentName"].ToString();
                            employees.Add(employee);
                        }
                        ObjConn.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return employees;
		}

        // get employee by id
        public EmployeeModel GetEmployeeById(int id) 
        {
            EmployeeModel employee = new EmployeeModel();

            using (SqlConnection ObjConn = new SqlConnection(this.connectDB()))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblEmployeesSelectByID";
                    ObjCmd.Parameters.AddWithValue("@employeeId", id);

                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();
                        while (ObjReader.Read())
                        {
                            employee.employeeId = (Int32)ObjReader["EmployeeId"];
                            employee.firstName = ObjReader["FirstName"].ToString();
                            employee.lastName = ObjReader["LastName"].ToString();
                            employee.email = ObjReader["Email"].ToString();
                            employee.address = ObjReader["Address"].ToString();
                            employee.designation = ObjReader["Designation"].ToString();
                            employee.gender = (bool)ObjReader["Gender"];
                            employee.salary = Convert.ToDecimal(ObjReader["Salary"]);
                            employee.IsActive = (bool)ObjReader["IsActive"];
                            employee.departmentId = (Int32)ObjReader["DepartmentId"];
                            employee.department = ObjReader["DepartmentName"].ToString();
                        }
                        ObjConn.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
            return employee;
        }

        // ADD & UPDATE
        public bool EditEmployee(EmployeeModel employee)
        {
            using (SqlConnection ObjConn = new SqlConnection(this.connectDB()))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    //bool gender = employee.gender == "Male" ? true : false ;
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblEmployeesInsertUpdate";
                    ObjCmd.Parameters.AddWithValue("@employeeId", employee.employeeId);
                    ObjCmd.Parameters.AddWithValue("@firstName", employee.firstName);
                    ObjCmd.Parameters.AddWithValue("@lastName", employee.lastName);
                    ObjCmd.Parameters.AddWithValue("@email", employee.email);
                    ObjCmd.Parameters.AddWithValue("@address", employee.address);
                    ObjCmd.Parameters.AddWithValue("@designation", employee.designation);
                    ObjCmd.Parameters.AddWithValue("@gender",employee.gender);
                    ObjCmd.Parameters.AddWithValue("@isActive",employee.IsActive);
                    ObjCmd.Parameters.AddWithValue("@salary", Math.Round(employee.salary,2));
                    ObjCmd.Parameters.AddWithValue("@department", employee.departmentId);

                    try
                    {
                        ObjConn.Open();

                        ObjCmd.ExecuteNonQuery();

                        ObjConn.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }

        // Delete Employeee
        public bool RemoveEmployee(int id)
        {
            using (SqlConnection ObjConn = new SqlConnection(this.connectDB()))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblEmployeesDelete";
                    ObjCmd.Parameters.AddWithValue("@employeeId", id);
                    try
                    {
                        ObjConn.Open();

                        int result = ObjCmd.ExecuteNonQuery();

                        ObjConn.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
        }
    }
}