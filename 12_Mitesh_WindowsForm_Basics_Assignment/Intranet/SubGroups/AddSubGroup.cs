using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intranet.SubGroups
{
    public partial class AddSubGroup : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        public AddSubGroup()
        {
            InitializeComponent();
        }
        private void getCombodetail(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblGroupNameSelect";

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
            Sub_GroupCombo.DataSource = dt;

            DataTable dt1 = new DataTable();
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

                        dt1.Load(ObjReader);

                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Error Occured : " + exce.Message);
                    }
                }
            }
            sub_UsersCombo.DataSource = dt1;
        }

        private void createSubGroupHandler(object sender, EventArgs e)
        {
            string subGroupName = addSubGroupInp.Text;
            string subgroupDesc = subGroupDescription.Text;
            if (string.IsNullOrEmpty(subGroupName.Trim()) || string.IsNullOrEmpty(subgroupDesc.Trim()))
            {
                MessageBox.Show("Empty Field can not except!! ");
                return;
            }
            bool status = subGroupTrueStatus.Checked;
            int group, createBy;

            if (Sub_GroupCombo.SelectedValue != null)
            {
                group = Convert.ToInt32(Sub_GroupCombo.SelectedValue);

                if (sub_UsersCombo.SelectedValue != null)
                {
                    createBy = Convert.ToInt32(sub_UsersCombo.SelectedValue);

                    using (SqlConnection ObjConn = new SqlConnection(connString))
                    {
                        using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                        {
                            ObjCmd.CommandType = CommandType.StoredProcedure;
                            ObjCmd.CommandText = "sp_tblSubGroupsInsert";
                            ObjCmd.Parameters.AddWithValue("@tblSubGroups", subGroupName);
                            ObjCmd.Parameters.AddWithValue("@Group", group);
                            ObjCmd.Parameters.AddWithValue("@Description", subgroupDesc);
                            ObjCmd.Parameters.AddWithValue("@IsActive", status);
                            ObjCmd.Parameters.AddWithValue("@CreatedBy", createBy);

                            try
                            {
                                ObjConn.Open();
                                ObjCmd.ExecuteNonQuery();

                                MessageBox.Show("SubGroup Created Successfully !!");
                                this.Hide();
                                new SubGroupList().ShowDialog();

                                ObjConn.Close();
                            }
                            catch (Exception exce)
                            {
                                MessageBox.Show("Failed, SubGroup Already Exist!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select User !!");
                }
            }
            else
            {
                MessageBox.Show("There are no any group !!");
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new SubGroupList().ShowDialog();
        }
    }
}
