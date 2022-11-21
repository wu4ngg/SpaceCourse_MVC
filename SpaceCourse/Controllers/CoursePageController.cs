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
        SPACECOURSE_DBEntities1 db = new SPACECOURSE_DBEntities1();
        // GET: CoursePage
        public ActionResult Home(int id)
        {
            ViewBag.Id = id;
            var test = db.Courses.Where(m => m.id_course == id).FirstOrDefault();
            return View(test);
        }
        public PartialViewResult Lesson(int id)
        {
            var test = db.Lessons.Where(m => m.id_course == id).ToList();
            return PartialView(test);
        }
    }
}