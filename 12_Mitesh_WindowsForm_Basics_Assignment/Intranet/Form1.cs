using Intranet.Dashboard;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intranet
{
    public partial class Form1 : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        User user = new User();

        public Form1()
        {
            InitializeComponent();
            CenterPanel();
        }

        private void CenterPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void LoginHandler(object sender, EventArgs e)
        {
            string Username = username.Text.ToString();
            string Password = password.Text.ToString();

            if (string.IsNullOrEmpty(Username.Trim()) || string.IsNullOrEmpty(Password.Trim()))
            {
                MessageBox.Show("Empty Field can not Except");
                return;
            }

            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_ValidateUse";
                    ObjCmd.Parameters.AddWithValue("@username ", Username);
                    ObjCmd.Parameters.AddWithValue("@password ", Password);

                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();
                        while (ObjReader.Read())
                        {
                            user.userId = Convert.ToInt32(ObjReader["UserId"]);
                            user.userName = ObjReader["UserName"].ToString();
                            user.roleName = ObjReader["RoleName"].ToString();
                        }
                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        Console.WriteLine("Error Occured : " + exce.Message);
                    }
                }
            }

            if (user.userId != 0 && user.userName != "")
            {
                this.Hide();
                if (user.roleName.ToLower() == "admin")
                {
                    AdminDashboard ObjAdmin = new AdminDashboard();
                    MessageBox.Show("Login Successfully!");
                    ObjAdmin.ShowDialog();
                }
                else
                {
                    UserDashboard Objuser = new UserDashboard();
                    MessageBox.Show("Login Successfully!");
                    Objuser.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid Credentials! Please try again.");
                return;
            }
        }
    }
}