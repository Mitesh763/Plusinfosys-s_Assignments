using EmployeeManagement.Models;
using EmployeeManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        DepartmentServices departmentServices = new DepartmentServices();

        // GET : Department List
        public ActionResult DepartmentList()
        {
            if (Session["UserName"] != null)
            {
                List<DepartmentModel> departments = departmentServices.GetDepartments();
                return View(departments);
            }
            else
            {
                TempData["department"] = "failed";
                return RedirectToAction("DepartmentList");
            }
        }

        // Get : Department By Id

        [HttpGet]
        public ActionResult DepartmentAddEdit(int? id)
        {
            if (Session["UserName"] != null)
            {
                if (id != null && id > 0)
                {
                    ViewBag.header = "Update Department";
                    DepartmentModel department = departmentServices.GetDepartmentById((int)id);
                    return View(department);
                }
                else
                {
                    ViewBag.header = "Add Department";
                    return View(new DepartmentModel());
                }
            }
            else return RedirectToAction("../login/login");
        }

        // Post : Department ( ADD, UPDATE )
        [HttpPost]
        public ActionResult DepartmentAddEdit(DepartmentModel department)
        {
            if (Session["UserName"] != null)
            {
                if (departmentServices.EditDepartment(department))
                {
                    if(department.DepartmentId > 0) TempData["updateMsg"] = "success";
                    else TempData["addMsg"] = "success";
                    return RedirectToAction("DepartmentList");  
                }
                else
                {
                    if (department.DepartmentId > 0) TempData["updateMsg"] = "failed";
                    else TempData["addMsg"] = "failed";
                }
                return View();
            }
            else return RedirectToAction("../login/login");
        }

        // Delete Department
        public ActionResult DeleteDepartment(int id)
        {
            if (departmentServices.RemoveDepartment(id)) TempData["deleteMsg"] = "success";
            else TempData["deleteMsg"] = "failed";

            return RedirectToAction("DepartmentList");
        }
    }
}