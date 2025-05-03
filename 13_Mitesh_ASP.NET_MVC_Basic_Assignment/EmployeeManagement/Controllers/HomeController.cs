using EmployeeManagement.Models;
using EmployeeManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        UserModel user = new UserModel();
        public ActionResult Index()
        {

            if (Session["UserName"] != null)
            {
                return View();
            }
            else return RedirectToAction("../login/login");
        }
        public ActionResult logout()
        {
            Session.Clear();
            return RedirectToAction("../login/login");
        }
    }
}