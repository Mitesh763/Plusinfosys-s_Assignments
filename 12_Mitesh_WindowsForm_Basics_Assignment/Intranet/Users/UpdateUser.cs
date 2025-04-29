using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Intranet.Users
{
    public partial class UpdateUser : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        int userId;
        public UpdateUser(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void getUserDetail(object sender, EventArgs e)
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
                        Console.WriteLine("Error Occured : " + exce.Message);
                    }
                }
            }
            newCityCombo.DataSource = dt1;

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
                        Console.WriteLine("Error Occured : " + exce.Message);
                    }
                }
            }
            newRoleCombo.DataSource = dt2;

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
                            newEmail.Text = ObjReader["EmailId"].ToString();
                            newPhoneNumber.Text = ObjReader["PhoneNumber"].ToString();
                            newPassword.Text = ObjReader["Password"].ToString();
                            newBirthDatePicker.Value = Convert.ToDateTime(ObjReader["BirthDate"].ToString());
                            bool status = (bool)ObjReader["IsActive"];
                            if (status == true) newUserActive.Checked = true;
                            else newUserNotActive.Checked = true;
                        }
                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        Console.WriteLine("Error Occured : " + exce.Message);
                    }
                }
            }
        }

        private void UserUpdateHandler(object sender, EventArgs e)
        {

            long.TryParse(newPhoneNumber.Text, out long newPhoneNum);
            if (string.IsNullOrEmpty(newUserName.Text.Trim()) || string.IsNullOrEmpty(newEmail.Text.Trim()) || string.IsNullOrEmpty(newPhoneNumber.Text.Trim()) || string.IsNullOrEmpty(newPassword.Text.Trim()))
            {
                userUpdateMsg.Text = "Empty Field can not except!! ";
                return;
            }
            bool status = newUserActive.Checked;
            int role, city;
            if (newCityCombo.SelectedValue != null)
            {
                city = Convert.ToInt32(newCityCombo.SelectedValue);
                if (newRoleCombo.SelectedValue != null)
                {
                    role = Convert.ToInt32(newRoleCombo.SelectedValue);

                    using (SqlConnection ObjConn = new SqlConnection(connString))
                    {
                        using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                        {
                            ObjCmd.CommandType = CommandType.StoredProcedure;
                            ObjCmd.CommandText = "sp_tblUsersUpdate";
                            ObjCmd.Parameters.AddWithValue("@UserId", userId);
                            ObjCmd.Parameters.AddWithValue("@UserName", newUserName.Text);
                            ObjCmd.Parameters.AddWithValue("@Role", role);
                            ObjCmd.Parameters.AddWithValue("@EmailId", newEmail.Text);
                            ObjCmd.Parameters.AddWithValue("@PhoneNumber", newPhoneNum);
                            ObjCmd.Parameters.AddWithValue("@Password", newPassword.Text);
                            ObjCmd.Parameters.AddWithValue("@BirthDate", (DateTime)newBirthDatePicker.Value);
                            ObjCmd.Parameters.AddWithValue("@City", city);
                            ObjCmd.Parameters.AddWithValue("@IsActive", status);

                            try
                            {
                                ObjConn.Open();
                                ObjCmd.ExecuteNonQuery();

                                userUpdateMsg.Text = "User Updated Successfully!!";
                                this.Hide();
                                new UserList().ShowDialog();

                                ObjConn.Close();
                            }
                            catch (Exception exce)
                            {
                                userUpdateMsg.Text = "Failed, Email Id and Phone Number Already Exist!";
                            }
                        }
                    }
                }
                else userUpdateMsg.Text = "Please Select City !!";
            }
            else
            {
                userUpdateMsg.Text = "Please Select Role !!";
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new UserDetail(userId).ShowDialog();
        }
    }
}
