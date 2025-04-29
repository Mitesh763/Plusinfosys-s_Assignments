using System;
using System.Web.UI;

namespace VolunteerOverseas.Home
{
    public partial class home : BasePage
    {

        SessionVariables sessionVariable = new SessionVariables();

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
            sessionVariable.ClearSession();
            Response.Redirect("../Login.aspx");
        }
    }
}