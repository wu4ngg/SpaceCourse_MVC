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
        SPACECOURSE_DB1 db = new SPACECOURSE_DB1();
        // GET: CoursePage
        public ActionResult Home(int id)
        {
            ViewBag.Id = id;
            var test = db.Courses.Where(m => m.id_course == id).FirstOrDefault();
            return View(test);
        }
        public PartialViewResult Lessions(int id)
        {
            var lession = db.Lessons.Where(m => m.id_course == id).ToList();
            return PartialView(lession);
        }
        public PartialViewResult FollowButton(int id, int user)
        {
            if(user == 0)
            {
                return PartialView();
            }
            var follower = db.Followers.Where(m => m.id_course == id && m.id_user == user).FirstOrDefault();
            Follower tmp = new Follower();
            ViewBag.Id = id;
            if (follower == null)
            {
                tmp.id_course = id;
                tmp.id_user = user;
                return PartialView(tmp);
            }
            else
            {
                return PartialView();
            }
        }
        [HttpPost]
        public ActionResult Follow(Follower follower)
        {
            db.Configuration.ValidateOnSaveEnabled = true;
            db.Followers.Add(follower);
            db.SaveChanges();
            return RedirectToAction("FrontEnd", "Course");
        }
    }
}