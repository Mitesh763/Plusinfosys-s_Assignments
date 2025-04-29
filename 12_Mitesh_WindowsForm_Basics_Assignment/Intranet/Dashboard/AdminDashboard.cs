using Intranet.Cities;
using Intranet.Groups;
using Intranet.Roles;
using Intranet.SubGroups;
using Intranet.Users;
using System;
using System.Windows.Forms;

namespace Intranet.Dashboard
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void GetUserDetail(object sender, EventArgs e)
        {
            UserList userList = new UserList();
            this.Hide();
            userList.ShowDialog();
        }

        private void GetRoleDetail(object sender, EventArgs e)
        {
            RoleList roleList = new RoleList();
            this.Hide();
            roleList.ShowDialog();
        }

        private void GetCityDetail(object sender, EventArgs e)
        {
            CityList cityList = new CityList();
            this.Hide();
            cityList.ShowDialog();
        }

        private void GetGroupDetail(object sender, EventArgs e)
        {
            this.Hide();
            new GroupList().ShowDialog();
        }

        private void GetSubGroupDetail(object sender, EventArgs e)
        {
            this.Hide();
            new SubGroupList().ShowDialog();
        }

        private void logout(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().ShowDialog();
        }
    }
}
