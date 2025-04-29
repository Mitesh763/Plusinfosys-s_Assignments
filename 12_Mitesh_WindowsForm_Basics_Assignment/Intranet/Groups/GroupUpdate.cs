using Intranet.Dashboard;
using Intranet.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Intranet.Groups
{
    public partial class GroupUpdate : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        int groupId;
        public GroupUpdate(int groupId)
        {
            InitializeComponent();
            this.groupId = groupId;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void GroupUpdate_Load(object sender, EventArgs e)
        {
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblGroupSelectById";
                    ObjCmd.Parameters.AddWithValue("@GroupId", groupId);

                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();

                        while (ObjReader.Read())
                        {
                            newGroupName.Text = ObjReader["GroupName"].ToString();
                            newGroupDescription.Text = ObjReader["Description"].ToString();
                            bool status = (bool)ObjReader["IsActive"];
                            if (status == true) newGroupStatus.Checked = true;
                            else newGroupStatus2.Checked = true;
                            createdBy.Text = ObjReader["UserName"].ToString();
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

        private void UpdateGroupBtn(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newGroupName.Text.Trim()) || string.IsNullOrEmpty(newGroupDescription.Text.Trim()))
            {
                MessageBox.Show("Empty Field can not except!! ");
                return;
            }
            bool status = newGroupStatus.Checked;
            int createBy;

            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblGroupsUpdate";
                    ObjCmd.Parameters.AddWithValue("@GroupId", groupId);
                    ObjCmd.Parameters.AddWithValue("@GroupName", newGroupName.Text);
                    ObjCmd.Parameters.AddWithValue("@Description", newGroupDescription.Text);
                    ObjCmd.Parameters.AddWithValue("@IsActive", status);

                    try
                    {
                        ObjConn.Open();
                        ObjCmd.ExecuteNonQuery();

                        MessageBox.Show("Group Updated Successfully!!");
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

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new GroupList().ShowDialog();
        }
    }
}
