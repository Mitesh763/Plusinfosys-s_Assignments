using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Intranet.SubGroups
{
    public partial class SubGroupUpdate : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        int subGroupId;
        public SubGroupUpdate(int subGroupId)
        {
            InitializeComponent();
            this.subGroupId = subGroupId;
        }

        private void GetSubGroupDetail(object sender, EventArgs e)
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
            newSub_GroupCombo.DataSource = dt;

            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblSubGroupSelectById";
                    ObjCmd.Parameters.AddWithValue("@SubGroupId", subGroupId);

                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();

                        while (ObjReader.Read())
                        {
                            newSubGroupName.Text = ObjReader["SubGroupName"].ToString();
                            newSubGroupDescription.Text = ObjReader["Description"].ToString();
                            bool status = (bool)ObjReader["IsActive"];
                            if (status == true) newSubGrouptrueStatus.Checked = true;
                            else newSubGroupFalseStatus.Checked = true;
                            createdBy.Text = ObjReader["GroupName"].ToString();
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

        private void subGroupUpdateHandler(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newSubGroupName.Text.Trim()) || string.IsNullOrEmpty(newSubGroupDescription.Text.Trim()))
            {
                updateSubGroupMsg.Text = "Empty Field can not except!! ";
                return;
            }
            bool status = newSubGrouptrueStatus.Checked;
            int group, createBy;

            if (newSub_GroupCombo.SelectedValue != null)
            {
                group = Convert.ToInt32(newSub_GroupCombo.SelectedValue);
                using (SqlConnection ObjConn = new SqlConnection(connString))
                {
                    using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                    {
                        ObjCmd.CommandType = CommandType.StoredProcedure;
                        ObjCmd.CommandText = "sp_tblSubGroupUpdate";
                        ObjCmd.Parameters.AddWithValue("@SubGroupId", subGroupId);
                        ObjCmd.Parameters.AddWithValue("@tblSubGroups", newSubGroupName.Text);
                        ObjCmd.Parameters.AddWithValue("@Group", group);
                        ObjCmd.Parameters.AddWithValue("@Description", newSubGroupDescription.Text);
                        ObjCmd.Parameters.AddWithValue("@IsActive", status);

                        try
                        {
                            ObjConn.Open();
                            ObjCmd.ExecuteNonQuery();

                            MessageBox.Show("SubGroup Updated Successfully !!");
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
                MessageBox.Show("There are no any group !!");
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new SubGroupList().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
