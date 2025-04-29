using Intranet.Cities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intranet.Roles
{
    public partial class RoleUpdate: Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        int roleId;

        public RoleUpdate(int roleId)
        {
            InitializeComponent();
            this.roleId = roleId;
        }

        private void GetRoleDetail(object sender, EventArgs e)
        {
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblRolesSelectById";
                    ObjCmd.Parameters.AddWithValue("@RoleId", roleId);

                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();

                        while (ObjReader.Read())
                        {
                            readRoleId.Text = "Role ID: "+ ObjReader["RoleId"].ToString();
                            readRoleName.Text = ObjReader["RoleName"].ToString();
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
        private void RoleUpdateHandler(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(readRoleName.Text.Trim()))
            {
                MessageBox.Show("Empty Field can not except!! ");
                return;
            }
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblRolesUpdate";
                    ObjCmd.Parameters.AddWithValue("@RoleId", roleId);
                    ObjCmd.Parameters.AddWithValue("@RoleName", readRoleName.Text);

                    try
                    {
                        ObjConn.Open();
                        ObjCmd.ExecuteNonQuery();
                        MessageBox.Show("Updated SuccessFully !");
                        this.Hide();
                        new RoleList().ShowDialog();
                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Failed, Role Already exist !!");
                    }
                }
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new RoleList().ShowDialog();
        }
    }
}
