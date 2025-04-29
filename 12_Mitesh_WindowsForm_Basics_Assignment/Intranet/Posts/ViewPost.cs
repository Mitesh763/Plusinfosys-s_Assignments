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
    public partial class ViewPost: Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        int PostId;
        string postBy;
        public ViewPost(int userId, string postBy)
        {
            PostId = userId;
            this.postBy = postBy;
            InitializeComponent();
        }

        private void GetPostData(object sender, EventArgs e)
        {
            byte[] byteImg1, byteImg2;

            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblGroupPostSelect";
                    ObjCmd.Parameters.AddWithValue("@PostId",PostId);

                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();

                        while (ObjReader.Read())
                        {
                            PostByName.Text = postBy;
                            PostTitle.Text = ObjReader["Title"].ToString();
                            GroupPostContent.Text = ObjReader["Content"].ToString();
                            byteImg1 = (byte[])ObjReader["Image1"];
                            byteImg2 = (byte[])ObjReader["Image2"];
                            postedDate.Text = ObjReader["PostedDate"].ToString();
                            viewImage1.Image = Image.FromStream(new MemoryStream(byteImg1));
                            viewImage2.Image = Image.FromStream(new MemoryStream(byteImg2));
                            showLikeCount();
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

        private void showLikeCount()
        {
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblGroupPostsLikePost";
                    ObjCmd.Parameters.AddWithValue("@PostId", PostId);

                    try
                    {
                        ObjConn.Open();
                        object result = ObjCmd.ExecuteScalar();
                        if (result != null)
                        {
                            GroupPostLike.Text = result.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occured : " + ex.Message);
                    }
                }
            }
        }

        private void UpdateLike(int likeCount)
        {
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblGroupPostsUpdateLike";
                    ObjCmd.Parameters.AddWithValue("@LikeCount", likeCount);
                    ObjCmd.Parameters.AddWithValue("@PostId", PostId);

                    try
                    {
                        ObjConn.Open();
                        ObjCmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating likes: " + ex.Message);
                    }
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        bool isLiked = false;
        private void likeBtnHandler(object sender, EventArgs e)
        {
            if (!isLiked)
            {
                int likes = Convert.ToInt32(GroupPostLike.Text) +  1;
                UpdateLike(likes);
                LikeBtn.Text = "Unlike";
                showLikeCount();
                isLiked = true;
            }
            else
            {
                int likes = Convert.ToInt32(GroupPostLike.Text) - 1;
                UpdateLike(likes);
                LikeBtn.Text = "Like";
                showLikeCount();
                isLiked = false;
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new ViewAllPost().ShowDialog();
        }
    }
}
