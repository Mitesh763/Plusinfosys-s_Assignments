using System;
using System.Web.UI;

namespace VolunteerOverseas.WorkPage
{
    public partial class work : BasePage
    {
        SessionVariables variable = new SessionVariables();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                if (Session != null && Session["username"] != null)
                {
                    string username = Session["username"].ToString();
                }
                else
                {
                    Response.Redirect("../Login.aspx");
                }
            }
        }

        protected void logout(object sender, EventArgs e)
        {
            variable.ClearSession();
            Response.Redirect("../Login.aspx");
        }
    }
}