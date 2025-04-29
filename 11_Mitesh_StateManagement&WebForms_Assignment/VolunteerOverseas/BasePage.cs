using System;

namespace VolunteerOverseas
{
    public class BasePage : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            if (Session["UserName"] == null)
            {
                Response.Redirect("../Login.aspx");
            }
        }
    }
}