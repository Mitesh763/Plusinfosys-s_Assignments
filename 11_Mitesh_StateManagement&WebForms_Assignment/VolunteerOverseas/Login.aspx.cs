using System;
using System.Configuration;
using System.Data.SqlClient;
using VolunteerOverseas.Models;

namespace VolunteerOverseas
{
    public partial class Login : System.Web.UI.Page
    {
        SessionVariables sessionVariable = new SessionVariables();
        User user = new User();

        protected void Page_Load(object sender, EventArgs e)
        {
            sessionVariable.ClearSession();
        }

        protected void loginBtn(object sender, EventArgs e)
        {
            if (Request.QueryString["username"] != null && Request.QueryString["password"] != null)
            {
                string username = Request.QueryString["username"];
                string password = Request.QueryString["password"];

                if (string.IsNullOrEmpty(username.Trim()) || string.IsNullOrEmpty(password.Trim()))
                {
                    LoginMsg.Text = "Username and Password cannot be empty!";
                    return;
                }

                string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ToString();

                using (SqlConnection ObjConn = new SqlConnection(connectionString))
                {
                    using (SqlCommand ObjComm = ObjConn.CreateCommand())
                    {
                        ObjComm.CommandType = System.Data.CommandType.StoredProcedure;
                        ObjComm.CommandText = "u_validateUser";
                        ObjComm.Parameters.AddWithValue("@username", username);
                        ObjComm.Parameters.AddWithValue("@password", password);

                        ObjConn.Open();
                        SqlDataReader ObjReader = ObjComm.ExecuteReader();

                        while (ObjReader.Read())
                        {
                            user.userId = Convert.ToInt32(ObjReader["UserId"]);
                            user.userName = ObjReader["UserName"].ToString();
                            user.password = ObjReader["Password"].ToString();
                        }
                        ObjConn.Close();
                    }
                }

                if (user.userId != 0 && user.userName != "" && user.password != "")
                {
                    sessionVariable.SetSession(user.userId, user.userName);
                    Response.Redirect("Home/home.aspx");
                }
                else
                {
                    LoginMsg.Text = "Invalid Credentials! Please try again.";
                    return;
                }
            }
        }
    }
}
