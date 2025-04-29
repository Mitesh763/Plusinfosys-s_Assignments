using Intranet.Dashboard;
using Intranet.Roles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intranet.Cities
{
    public partial class CityList : Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        public CityList()
        {
            InitializeComponent();
        }

        private void GetCityList(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblCitiesSelect";

                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();

                        dt.Load(ObjReader);

                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        Console.WriteLine("Error Occured : " + exce.Message);
                    }
                }
            }
            CityListGridView.AutoGenerateColumns = false;
            CityListGridView.DataSource = dt;
        }

        private void AddNewCity(object sender, EventArgs e)
        {
            this.Hide();
            new AddCity().ShowDialog();
        }

        private void cityButtonAction(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }
            String action = CityListGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int cityId = (int)CityListGridView.Rows[e.RowIndex].Cells["CityId"].Value;
            if (action.ToLower() == "update")
            {
                this.Hide();
                new CityUpdate(cityId).ShowDialog();
            }
            else if (action.ToLower() == "delete")
            {
                using (SqlConnection ObjConn = new SqlConnection(connString))
                {
                    using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                    {
                        ObjCmd.CommandType = CommandType.StoredProcedure;
                        ObjCmd.CommandText = "sp_tblCitiesDelete";
                        ObjCmd.Parameters.AddWithValue("@CityId", cityId);

                        try
                        {
                            ObjConn.Open();

                            DialogResult dialogResult = MessageBox.Show("Confirm to delete this city?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (dialogResult == DialogResult.Yes)
                            {
                                ObjCmd.ExecuteNonQuery();
                                MessageBox.Show("Record Deleted Successfully!");
                                this.Hide();
                                new CityList().ShowDialog();
                            }
                            ObjConn.Close();
                        }
                        catch (Exception exce)
                        {
                            MessageBox.Show("Failed, This City is referred in User!");
                        }
                    }
                }
            }

        }

        private void GoBack(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().ShowDialog();
        }
    }
}
