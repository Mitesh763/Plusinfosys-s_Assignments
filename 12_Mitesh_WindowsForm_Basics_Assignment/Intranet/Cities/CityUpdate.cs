using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Intranet.Cities
{
    public partial class CityUpdate: Form
    {
        string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        int cityId;

        public CityUpdate(int cityId)
        {
            this.cityId = cityId;
            InitializeComponent();
        }

        private void GetCityDetail(object sender, EventArgs e)
        {
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblCitiesSelectById";
                    ObjCmd.Parameters.AddWithValue("@CityId", cityId);

                    try
                    {
                        ObjConn.Open();

                        SqlDataReader ObjReader = ObjCmd.ExecuteReader();

                        while (ObjReader.Read())
                        {
                            roleIdLbl.Text = "City ID: " + ObjReader["CityId"].ToString();
                            roleNameInp.Text = ObjReader["CityName"].ToString();
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

        private void updateCityHandler(object sender, EventArgs e)
        {
            using (SqlConnection ObjConn = new SqlConnection(connString))
            {
                using (SqlCommand ObjCmd = ObjConn.CreateCommand())
                {
                    if (string.IsNullOrEmpty(roleNameInp.Text.Trim()))
                    {
                        MessageBox.Show("Empty Field can not except!! ");
                        return;
                    }

                    ObjCmd.CommandType = CommandType.StoredProcedure;
                    ObjCmd.CommandText = "sp_tblCitiesUpdate";
                    ObjCmd.Parameters.AddWithValue("@CityId", cityId);
                    ObjCmd.Parameters.AddWithValue("@CityName", roleNameInp.Text);

                    try
                    {
                        ObjConn.Open();
                        ObjCmd.ExecuteNonQuery();
                        MessageBox.Show("Updated SuccessFully !");
                        this.Hide();
                        new CityList().ShowDialog();
                        ObjConn.Close();
                    }
                    catch (Exception exce)
                    {
                        MessageBox.Show("Failed, City Already exist !!");
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
