using Intranet.Dashboard;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intranet.Users
{
    public partial class UserList : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public UserList()
        {
            InitializeComponent();
        }

        private void GetUserList(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblUsersSelect";

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
            UserListGridView.AutoGenerateColumns = false;
            UserListGridView.DataSource = dt;
        }

        private void NewUserBtn(object sender, EventArgs e)
        {
            this.Hide();
            new AddUser().ShowDialog();
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().ShowDialog();
        }

        private void ShowUserDetail(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            string action = UserListGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int userId = (int)UserListGridView.Rows[e.RowIndex].Cells["UserId"].Value;
            if (action.ToLower() == "view detail")
            {
                UserDetails userDetails = new UserDetails(userId);
                this.Hide();
                userDetails.ShowDialog();
            }
            else return;
        }
    }
}
