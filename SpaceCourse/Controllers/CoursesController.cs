using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceCourse.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult FrontEnd()
        {
            return View();
        }
    }
}