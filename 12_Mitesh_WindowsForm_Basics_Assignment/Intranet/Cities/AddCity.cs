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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Intranet.Cities
{
    public partial class AddCity: Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public AddCity()
        {
            InitializeComponent();
        }

        private void NewCityHandler(object sender, EventArgs e)
        {
            string cityName = newCityInp.Text.Trim().ToString();
            if (string.IsNullOrEmpty(cityName))
            {
                MessageBox.Show("Empty Field can not except!! ");
                return;
            }

            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblCitiesInsert";
                    ObjCmd.Parameters.AddWithValue("@CityName", cityName);

                    try
                    {
                        ObjConn.Open();
                        int affectRow = ObjCmd.ExecuteNonQuery();

                        MessageBox.Show("City Added Successfully!!");
                        this.Hide();
                        new CityList().ShowDialog();

                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Failed, City Already Exist!");
                    }
                }
            }
        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new CityList().ShowDialog();
        }
    }
}
