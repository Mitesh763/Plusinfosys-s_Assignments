using Intranet.Posts;
using System;
using System.Windows.Forms;

namespace Intranet.Dashboard
{
    public partial class UserDashboard: Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void AddPostBtn(object sender, EventArgs e)
        {
            this.Hide();
            new AddPost().ShowDialog();
        }

        private void ViewPostBtn(object sender, EventArgs e)
        {
            this.Hide();
            new ViewAllPost().ShowDialog();
        }

        private void logout(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }
    }
}
