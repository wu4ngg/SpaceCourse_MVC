using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpaceCourse.Models;
namespace SpaceCourse.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        SpaceCourseEntities1 db = new SpaceCourseEntities1();
        public ActionResult Main()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Main(User _user)
        {
            var check = db.Users.Where(m => m.emai == _user.emai && m.user_password == _user.user_password).FirstOrDefault();
            if(check == null)
            {
                ViewBag.ErrorInfo = "SaiInfo";
                return View();
            }
            else
            {
                db.Configuration.ValidateOnSaveEnabled = false;
                Session["ID"] = _user.id_user;
                Session["PasswordUser"] = _user.user_password;
                return RedirectToAction("Index", "Home");
            }
        }
    }
}