using Intranet.Cities;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intranet.Roles
{
    public partial class AddRole: Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public AddRole()
        {
            InitializeComponent();
        }

        private void AddNewRole(object sender, EventArgs e)
        {
            string roleName = newRole.Text.Trim().ToString();
            if (string.IsNullOrEmpty(roleName))
            {
                MessageBox.Show("Empty Field can not except!! ");
                return;
            }

            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblRolesInsert";
                    ObjCmd.Parameters.AddWithValue("@RoleName", roleName);

                    try
                    {
                        ObjConn.Open();
                        int affectRow = ObjCmd.ExecuteNonQuery();

                        MessageBox.Show("Role Added Successfully!!");
                        this.Hide();
                        new RoleList().ShowDialog();

                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Failed, Role Already Exist!");
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
