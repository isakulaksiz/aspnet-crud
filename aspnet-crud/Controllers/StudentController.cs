using aspnet_crud.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aspnet_crud.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        dbEntities dbObj = new dbEntities();
        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addStudent(tbl_Student model)
        {
            tbl_Student obj = new tbl_Student();
            obj.Name = model.Name;
            obj.Fname = model.Fname;
            obj.Email = model.Email;
            obj.Mobile = model.Mobile;
            obj.Description = model.Description;

            dbObj.tbl_Student.Add(obj);
            dbObj.SaveChanges();

            return View("Student");
        }
    }
}