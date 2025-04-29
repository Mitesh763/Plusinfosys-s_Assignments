using Intranet.Dashboard;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intranet.Groups
{
    public partial class GroupList: Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public GroupList()
        {
            InitializeComponent();
        }

        private void GetGroupDetail(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblGroupSelect";

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
            GroupDetailGridView.AutoGenerateColumns = false;
            GroupDetailGridView.DataSource = dt;
        }

        private void createGroupHandler(object sender, EventArgs e)
        {
            this.Hide();
            new AddGroup().ShowDialog();
        }

        private void groupActionHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            String action = GroupDetailGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int groupId = (int)GroupDetailGridView.Rows[e.RowIndex].Cells["GroupId"].Value;
            if (action == "Update")
            {
                this.Hide();
                new GroupUpdate(groupId).ShowDialog();
            }
            else if (action == "Delete")
            {
                using (SqlConnection ObjConn = new SqlConnection(connString))
                {
                    using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                    {
                        ObjCmd.CommandType = CommandType.StoredProcedure;
                        ObjCmd.CommandText = "sp_tblGroupDelete";
                        ObjCmd.Parameters.AddWithValue("@GroupId", groupId);

                        try
                        {
                            ObjConn.Open();

                            DialogResult dialogResult = MessageBox.Show("Confirm to delete this group?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (dialogResult == DialogResult.Yes)
                            {
                                ObjCmd.ExecuteNonQuery();
                                MessageBox.Show("Record Deleted Successfully!");
                                this.Hide();
                                new GroupList().ShowDialog();
                            }

                            ObjConn.Close();
                        }
                        catch (Exception exce)
                        {
                            MessageBox.Show("Failed, This Group is referred in SubGroup!");
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
