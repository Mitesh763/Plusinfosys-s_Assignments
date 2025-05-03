using EmployeeManagement.Models;
using EmployeeManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeServices employeeService = new EmployeeServices();
        DepartmentServices departmentServices = new DepartmentServices();
        UserModel user = new UserModel();

        // GET : Employees list
        public ActionResult EmployeeList()
        {
            if (Session["UserName"] != null)
            {
                if (departmentServices.IsDepartmentExist())
                {
                    List<EmployeeModel> employees = employeeService.GetEmployeeDetail();
                    return View(employees);
                }
                else
                {
                    TempData["department"] = "failed";
                    return RedirectToAction("../Department/DepartmentList");
                }

            }
            else return RedirectToAction("../login/login");
        }

        // GET : Employee By Id
        public ActionResult EmployeeAddEdit(int? id)
        {
            if (Session["UserName"] != null)
            {
                DepartmentServices departmentServices = new DepartmentServices();

                List<DepartmentModel> departments = departmentServices.GetDepartments();

                ViewBag.Departments = new SelectList(departments, "DepartmentId", "DepartmentName");

                if (id != null && id > 0)
                {
                    ViewBag.header = "Update Employee";
                    EmployeeModel employee = employeeService.GetEmployeeById((int)id);
                    return View(employee);
                }
                else
                {
                    ViewBag.header = "Add Employee";
                    return View(new EmployeeModel());
                }
            }
            else return RedirectToAction("../login/login");
        }

        // Post
        [HttpPost]
        public ActionResult EmployeeAddEdit(EmployeeModel employee)
        {
            if (Session["UserName"] != null)
            {
                if (employeeService.EditEmployee(employee))
                {
                    if(employee.employeeId > 0) TempData["updateMsg"] = "success";
                    else TempData["addMsg"] = "success";
                }
                else
                {
                    if (employee.employeeId > 0) TempData["updateMsg"] = "failed";
                    else TempData["addMsg"] = "failed";
                }
                return RedirectToAction("EmployeeList");
            }
            else return RedirectToAction("../login/login");
        }

        //delete employee
        [HttpGet]
        public ActionResult DeleteEmployee(int id)
        {
            if (employeeService.RemoveEmployee(id)) TempData["deleteMsg"] = "success";
            else TempData["deleteMsg"] = "failed";
            return RedirectToAction("EmployeeList");
        }
    }
}