using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Services
{
	public class LoginService : BaseService
	{
		UserModel user = new UserModel();

		public bool LoginUser(UserModel user)
		{
			using (SqlConnection ObjConn = new SqlConnection(this.connectDB()))
			{
				using (SqlCommand ObjCmd = ObjConn.CreateCommand())
				{
					ObjCmd.CommandType = CommandType.StoredProcedure;
					ObjCmd.CommandText = "sp_validateUser";
					ObjCmd.Parameters.AddWithValue("@userName", user.UserName);
                    ObjCmd.Parameters.AddWithValue("@password", user.Password);

					try 
					{
						ObjConn.Open();

						SqlDataReader ObjReader =  ObjCmd.ExecuteReader();
						while (ObjReader.Read())
						{
                            user.SetSession(ObjReader["UserName"].ToString());
							return true;
                        }
						ObjConn.Close();
						return false;
					}
					catch(Exception ex)
                    {
                        return false;
                    }
				}
			}
		}
	}
}