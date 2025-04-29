using Intranet.Dashboard;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intranet.SubGroups
{
    public partial class SubGroupList: Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public SubGroupList()
        {
            InitializeComponent();
        }

        private void SubGroupList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblSubGroupSelect";

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
            SubGroupDetailGridView.AutoGenerateColumns = false;
            SubGroupDetailGridView.DataSource = dt;
        }

        private void createSubGroupBtn(object sender, EventArgs e)
        {
            this.Hide();
            new AddSubGroup().ShowDialog();
        }

        private void subGroupActionHandler(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            String action = SubGroupDetailGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int subGroupId = (int)SubGroupDetailGridView.Rows[e.RowIndex].Cells["SubGroupId"].Value;
            if (action == "Update")
            {
                this.Close();
                new SubGroupUpdate(subGroupId).ShowDialog();
            }
            else if (action == "Delete")
            {
                using (SqlConnection ObjConn = new SqlConnection(connString))
                {
                    using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                    {
                        ObjCmd.CommandType = CommandType.StoredProcedure;
                        ObjCmd.CommandText = "sp_tblSubGroupDelete";
                        ObjCmd.Parameters.AddWithValue("@subGroupId", subGroupId);

                        try
                        {
                            ObjConn.Open();

                            DialogResult dialogResult = MessageBox.Show("Confirm to delete this sub-group?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (dialogResult == DialogResult.Yes)
                            {
                                ObjCmd.ExecuteNonQuery();
                                MessageBox.Show("Record Deleted Successfully!");
                                this.Hide();
                                new SubGroupList().ShowDialog();
                            }

                            ObjConn.Close();
                        }
                        catch (Exception exce)
                        {
                            MessageBox.Show("Failed, This Sub Group is referred in Post!");
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
