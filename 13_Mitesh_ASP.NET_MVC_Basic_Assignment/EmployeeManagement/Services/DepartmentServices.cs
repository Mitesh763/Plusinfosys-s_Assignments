using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Services
{
    public class DepartmentServices : BaseService
    {

        // get all departments
        public List<DepartmentModel> GetDepartments()
        {
            List<DepartmentModel> departments = new List<DepartmentModel>();

            using (SqlConnection ObjConn = new SqlConnection(this.connectDB()))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblDepartmentsSelect";
                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();
                        while (ObjReader.Read())
                        {
                            DepartmentModel department = new DepartmentModel();
                            department.DepartmentId = (Int32)ObjReader["DepartmentId"];
                            department.DepartmentName = ObjReader["DepartmentName"].ToString();
                            departments.Add(department);
                        }
                        ObjConn.Close();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            return departments;
        }

        // get departments by id
        public DepartmentModel GetDepartmentById(int id)
        {
            DepartmentModel department = new DepartmentModel();

            using (SqlConnection ObjConn = new SqlConnection(this.connectDB()))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblDepartmentsSelectById";
                    ObjCmd.Parameters.AddWithValue("@departmentId", id);
                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();
                        while (ObjReader.Read())
                        {
                            department.DepartmentId = (Int32)ObjReader["DepartmentId"];
                            department.DepartmentName = ObjReader["DepartmentName"].ToString();
                        }
                        ObjConn.Close();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            return department;
        }

        // Add, Update department
        public bool EditDepartment(DepartmentModel department)
        {
            using (SqlConnection ObjConn = new SqlConnection(this.connectDB()))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblDepartmentsInsertUpdate";
                    ObjCmd.Parameters.AddWithValue("@departmentId", department.DepartmentId);
                    ObjCmd.Parameters.AddWithValue("@departmentName", department.DepartmentName);
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

        //delete department
        public bool RemoveDepartment(int id)
        {
            using (SqlConnection ObjConn = new SqlConnection(this.connectDB()))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblDepartmentsDelete";
                    ObjCmd.Parameters.AddWithValue("@departmentId", id);
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

        // IsDepartmentExist
        public bool IsDepartmentExist()
        {
            using (SqlConnection ObjConn = new SqlConnection(this.connectDB()))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblDepartmentsExist";
                    try
                    {
                        ObjConn.Open();

                        object Obj = ObjCmd.ExecuteScalar();
                        if ((int)Obj > 0)
                        {
                            ObjConn.Close();
                            return true;
                        }
                        else
                        {
                            ObjConn.Close();
                            return false;
                        }
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
