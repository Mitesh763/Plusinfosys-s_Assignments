using Intranet.Dashboard;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Intranet.Groups
{
    public partial class AddGroup : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        public AddGroup()
        {
            InitializeComponent();
        }

        private void GetUserDetail(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblUserNameSelect";

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
            allUserCombo.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void createGroupBtn_Click(object sender, EventArgs e)
        {
            string groupName = addGroupInp.Text;
            string groupDesc = addDescriptionInp.Text;
            if (string.IsNullOrEmpty(groupName.Trim()) || string.IsNullOrEmpty(groupDesc.Trim()))
            {
                MessageBox.Show("Empty Field can not except!! ");
                return;
            }
            bool status = addTrueStatusInp.Checked;
            int createBy;

            if (allUserCombo.SelectedValue != null)
            {
               createBy = Convert.ToInt32(allUserCombo.SelectedValue);

                using (SqlConnection ObjConn = new SqlConnection(connString))
                {
                    using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                    {
                        ObjCmd.CommandType = CommandType.StoredProcedure;
                        ObjCmd.CommandText = "sp_tblGroupsInsert";
                        ObjCmd.Parameters.AddWithValue("@GroupName", groupName);
                        ObjCmd.Parameters.AddWithValue("@Description", groupDesc);
                        ObjCmd.Parameters.AddWithValue("@IsActive", status);
                        ObjCmd.Parameters.AddWithValue("@CreatedBy", createBy);

                        try
                        {
                            ObjConn.Open();
                            ObjCmd.ExecuteNonQuery();

                            MessageBox.Show("Group Created Successfully!!");
                            this.Hide();
                            new GroupList().ShowDialog();

                            ObjConn.Close();
                        }
                        catch (Exception exce)
                        {
                            MessageBox.Show("Failed, Group Already Exist!");
                        }
                    }
                }
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new GroupList().ShowDialog();
        }
    }
}
