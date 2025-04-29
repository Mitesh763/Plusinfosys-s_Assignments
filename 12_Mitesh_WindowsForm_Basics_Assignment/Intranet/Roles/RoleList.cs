using Intranet.Cities;
using Intranet.Dashboard;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intranet.Roles
{
    public partial class RoleList: Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public RoleList()
        {
            InitializeComponent();
        }

        private void GetRoleList(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
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

                        dt.Load(ObjReader);

                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Error Occured : " + exce.Message);
                    }
                }
            }

            RoleListGridView.AutoGenerateColumns = false;
            RoleListGridView.DataSource = dt;
        }

        private void AddNewRole(object sender, EventArgs e)
        {
            this.Hide();
            AddRole addRole = new AddRole();
            addRole.ShowDialog();
        }

        private void roleButtonAction(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            String action = RoleListGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int roleId = (int)RoleListGridView.Rows[e.RowIndex].Cells["RoleId"].Value;
            if(action == "Update")
            {
                this.Hide();
                new RoleUpdate(roleId).ShowDialog();
            }
            else if (action == "Delete")
            {
                using (SqlConnection ObjConn = new SqlConnection(connString))
                {
                    using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                    {
                        ObjCmd.CommandType = CommandType.StoredProcedure;
                        ObjCmd.CommandText = "sp_tblRolesDelete";
                        ObjCmd.Parameters.AddWithValue("@RoleId", roleId);

                        try
                        {
                            ObjConn.Open();

                            DialogResult dialogResult = MessageBox.Show("Confirm to delete this role?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (dialogResult == DialogResult.Yes)
                            {
                                ObjCmd.ExecuteNonQuery();
                                MessageBox.Show("Record Deleted Successfully!");
                                this.Hide();
                                new RoleList().ShowDialog();
                            }

                            ObjConn.Close();
                        }
                        catch (Exception exce)
                        {
                            MessageBox.Show("Failed, This role is referred in User!");
                        }
                    }
                }
            }

        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().ShowDialog();
        }
    }
}
