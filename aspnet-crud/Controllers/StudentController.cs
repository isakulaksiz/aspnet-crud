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
        public ActionResult Student()
        {
            return View();
        }
    }
}