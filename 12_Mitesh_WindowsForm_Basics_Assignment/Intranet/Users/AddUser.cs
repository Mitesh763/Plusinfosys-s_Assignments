using Intranet.Cities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intranet.Users
{
    public partial class AddUser: Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        public AddUser()
        {
            InitializeComponent();
        }

        private void getCityRole_Details(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblCitiesSelect";

                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();

                        dt1.Load(ObjReader);

                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Error Occured : " + exce.Message);
                    }
                }
            }
            CityCombo.DataSource = dt1;

            DataTable dt2 = new DataTable();
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblRolesSelect";

                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();

                        dt2.Load(ObjReader);

                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Error Occured : " + exce.Message);
                    }
                }
            }
            roleCombo.DataSource = dt2;
        }

        private void AddUserHandler(object sender, EventArgs e)
        {
            string username = userName.Text;
            string emailid = email.Text;
            string password = Password.Text;
            if (string.IsNullOrEmpty(username.Trim()) || string.IsNullOrEmpty(emailid.Trim()) || string.IsNullOrEmpty(PhoneNumber.Text.Trim()) || string.IsNullOrEmpty(password.Trim()))
            {
                MessageBox.Show("Empty Field can not except!! ");
                return;
            }
            long.TryParse(PhoneNumber.Text, out long phoneNum);
            DateTime birthdate = (DateTime)birthDatePicker.Value;
            bool status = userActive.Checked;
            int role, city;

            if (CityCombo.SelectedValue != null)
            {
                city = Convert.ToInt32(CityCombo.SelectedValue);
                if (roleCombo.SelectedValue != null)
                {
                    role = Convert.ToInt32(roleCombo.SelectedValue);

                    using (SqlConnection ObjConn = new SqlConnection(connString))
                    {
                        using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                        {
                            ObjCmd.CommandType = CommandType.StoredProcedure;
                            ObjCmd.CommandText = "sp_tblUsersInsert";
                            ObjCmd.Parameters.AddWithValue("@UserName", username);
                            ObjCmd.Parameters.AddWithValue("@Role", role);
                            ObjCmd.Parameters.AddWithValue("@EmailId", emailid);
                            ObjCmd.Parameters.AddWithValue("@PhoneNumber", phoneNum);
                            ObjCmd.Parameters.AddWithValue("@Password", password);
                            ObjCmd.Parameters.AddWithValue("@BirthDate", birthdate);
                            ObjCmd.Parameters.AddWithValue("@City", city);
                            ObjCmd.Parameters.AddWithValue("@IsActive", status);

                            try
                            {
                                ObjConn.Open();
                                ObjCmd.ExecuteNonQuery();

                                MessageBox.Show("User Added Successfully!!");
                                this.Hide();
                                new UserList().ShowDialog();

                                ObjConn.Close();
                            }
                            catch (Exception exce)
                            {
                                MessageBox.Show("Failed, Email Id and Phone Incorrect!");
                            }
                        }
                    }
                }
                else MessageBox.Show("Please Select City !!");
            }
            else
            {
                MessageBox.Show("Please Select Role !!");
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new UserList().ShowDialog();
        }
    }
}
