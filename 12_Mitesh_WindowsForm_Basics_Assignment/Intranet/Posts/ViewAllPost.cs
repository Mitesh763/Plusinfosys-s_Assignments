using Intranet.Dashboard;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intranet.Posts
{
    public partial class ViewAllPost : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        public ViewAllPost()
        {
            InitializeComponent();
        }

        private void ViewAllPost_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblGroupPostSelectBySubGroup";

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
            PostGridView.AutoGenerateColumns = false;
            PostGridView.DataSource = dt;
        }

        private void GetGroupPostDetail(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            string action = PostGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int postId = (int)PostGridView.Rows[e.RowIndex].Cells["PostId"].Value;
            string postby = PostGridView.Rows[e.RowIndex].Cells["SubGroupName"].Value.ToString();
            if (action.ToLower() == "get detail")
            {
                this.Hide();
                new ViewPost(postId, postby).ShowDialog();
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new UserDashboard().ShowDialog();
        }
    }
}
