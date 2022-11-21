using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpaceCourse.Models;
namespace SpaceCourse.Controllers
{
    public class CoursePageController : Controller
    {
        SpaceCourseDB db = new SpaceCourseDB();
        // GET: CoursePage
        public ActionResult Home(int id)
        {
            ViewBag.Id = id;
            var test = db.Lessons.Where(m => m.id_course == id).ToList();
            return View(test);
        }
        public PartialViewResult Header(int id)
        {
            var test = db.Courses.Where(m => m.id_course == id).FirstOrDefault();
            return PartialView(test);
        }
    }
}