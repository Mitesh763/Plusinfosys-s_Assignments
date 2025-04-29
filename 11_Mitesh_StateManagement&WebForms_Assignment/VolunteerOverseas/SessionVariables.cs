using System;
using System.Web;

namespace VolunteerOverseas
{
    public class SessionVariables
    {
        public void SetSession(int userId, string userName)
        {
            HttpContext.Current.Session["UserId"] = userId;
            HttpContext.Current.Session["UserName"] = userName;
        }
        public void ClearSession()
        {
            HttpContext.Current.Session.Clear();
        }
    }
}
