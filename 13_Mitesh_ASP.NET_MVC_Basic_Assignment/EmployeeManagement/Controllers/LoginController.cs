using EmployeeManagement.Models;
using EmployeeManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class LoginController : Controller
    {
        LoginService loginService = new LoginService();

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // POST
        [HttpPost]
        public ActionResult Login(UserModel user)
        {
            if (loginService.LoginUser(user)) 
            {
                return RedirectToAction("../Home/Index");
            }
            else
            {
                TempData["login"] = "failed";
                return RedirectToAction("../Login/login");
            }
        }
    }
}