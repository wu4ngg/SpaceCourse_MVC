using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpaceCourse.Models;
namespace SpaceCourse.Controllers
{
    public class RegisterController : Controller
    {
        SpaceCourseDB db = new SpaceCourseDB();   
        // GET: Register
        public ActionResult Main()
        {
            return View();
        }
        public ActionResult Complete(User _user)
        {
            return View(_user);
        }
        [HttpPost]
        public ActionResult Main(User _user)
        {
            if (ModelState.IsValid)
            {
                var check = db.Users.Where(m => m.user_name == _user.user_name).FirstOrDefault();
                if(check == null)
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Users.Add(_user);
                    db.SaveChanges();
                    return RedirectToAction("Main", "Register");
                } else
                {
                    ViewBag.ErrMsg = "Người dùng này đã tồn tại.";
                    return View();
                }
            }
            return View();
            
           
        }
    }
}