using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VolunteerOverseas
{
    public class baseClass : System.Web.UI.Page
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