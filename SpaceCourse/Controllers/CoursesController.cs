using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceCourse.Controllers
{
    public class CoursesController : Controller
    {
        public ActionResult BackEnd()
        {
            return View();
        }
        // GET: Courses
        public ActionResult FrontEnd()
        {
            return View();
        }
    }
}