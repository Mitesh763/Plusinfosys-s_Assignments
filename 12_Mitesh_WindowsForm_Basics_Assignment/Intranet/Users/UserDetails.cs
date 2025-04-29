using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Intranet.Users
{
    public partial class UserDetails : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        int userId;
        public UserDetails(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void getUserDetail(object sender, EventArgs e)
        {
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblUsersSelectById";
                    ObjCmd.Parameters.AddWithValue("@UserId", userId);

                    try
                    {
                        ObjConn.Open();
                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();
                        while (ObjReader.Read())
                        {
                            newUserName.Text = ObjReader["UserName"].ToString();
                            userRoleView.Text = ObjReader["RoleName"].ToString();
                            newEmail.Text = ObjReader["EmailId"].ToString();
                            newPhoneNumber.Text = ObjReader["PhoneNumber"].ToString();
                            birthDateView.Text = ObjReader["BirthDate"].ToString();
                            userCityView.Text = ObjReader["CityName"].ToString();
                            bool status = (bool)ObjReader["IsActive"];
                            if (status == true) newUserActive.Checked = true;
                            else newUserNotActive.Checked = true;
                        }
                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Error Occured : " + exce.Message);
                    }
                }
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new UserList().ShowDialog();
        }

        private void userDeleteHandler(object sender, EventArgs e)
        {
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_UserDelete";
                    ObjCmd.Parameters.AddWithValue("@UserId", userId);

                    try
                    {
                        ObjConn.Open();

                        DialogResult dialogResult = MessageBox.Show("Confirm to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (dialogResult == DialogResult.Yes)
                        {
                            ObjCmd.ExecuteNonQuery();
                            MessageBox.Show("User Deleted Successfully!");
                            this.Hide();
                            new UserList().ShowDialog();
                        }

                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Error Occurred: " + exce.Message);
                    }
                }
            }
        }

    }
}
