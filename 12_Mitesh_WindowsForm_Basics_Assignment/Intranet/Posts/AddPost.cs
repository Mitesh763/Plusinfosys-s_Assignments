using Intranet.SubGroups;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Intranet.Posts
{
    public partial class AddPost : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        byte[] byteImg1, byteImg2;

        public AddPost()
        {
            InitializeComponent();
        }

        private void AddPost_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblSubGroupNameSelect";

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
            subGroupCombo.DataSource = dt;
        }

        private void image1Btn(object sender, EventArgs e)
        {
            OpenFileDialog PostImage1 = new OpenFileDialog();
            if (PostImage1.ShowDialog() == DialogResult.OK)
            {
                string fileName = PostImage1.FileName;
                byteImg1 = File.ReadAllBytes(fileName);
                image1Preview.Image = Image.FromStream(new MemoryStream(byteImg1));
            }
        }

        private void image2Btn(object sender, EventArgs e)
        {
            OpenFileDialog PostImage2 = new OpenFileDialog();
            if (PostImage2.ShowDialog() == DialogResult.OK)
            {
                string fileName = PostImage2.FileName;
                byteImg2 = File.ReadAllBytes(fileName);
                image2Preview.Image = Image.FromStream(new MemoryStream(byteImg2));
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new ViewAllPost().ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void createPostHandler(object sender, EventArgs e)
        {
            string title = postTitle.Text;
            string content = PostContent.Text;
            if (string.IsNullOrEmpty(title.Trim()) || string.IsNullOrEmpty(content.Trim()))
            {
                MessageBox.Show("Empty Field can not except!! ");
                return;
            }
            int postBy;
            if (subGroupCombo.SelectedValue != null)
            {
                postBy = Convert.ToInt32(subGroupCombo.SelectedValue);
                using (SqlConnection ObjConn = new SqlConnection(connString))
                {
                    using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                    {
                        ObjCmd.CommandType = CommandType.StoredProcedure;
                        ObjCmd.CommandText = "sp_tblGroupPostInsert";

                        ObjCmd.Parameters.AddWithValue("@PostedBy", postBy);
                        ObjCmd.Parameters.AddWithValue("@Title", title);
                        ObjCmd.Parameters.AddWithValue("@Content", content);
                        ObjCmd.Parameters.AddWithValue("@Image1", byteImg1);
                        ObjCmd.Parameters.AddWithValue("@Image2", byteImg2);

                        try
                        {
                            ObjConn.Open();

                            ObjCmd.ExecuteNonQuery();
                            MessageBox.Show("Post Create Successfully !!");
                            this.Hide();
                            new ViewAllPost().ShowDialog();
                            ObjConn.Close();
                        }
                        catch (Exception exce)
                        {
                            MessageBox.Show("Post Ceation failed !!");
                        }
                    }
                }
            }
        }
    }
}
