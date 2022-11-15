using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using SpaceCourse.Models;

namespace SpaceCourse.Controllers
{
    public class RegisterController : Controller
    {
        SPACECOURSE_DB db = new SPACECOURSE_DB();
        // GET: Register
        public ActionResult Main()
        {
            return View();
        }
        public ActionResult test()
        {
            NGUOIDUNG _user = new NGUOIDUNG();
            return View(_user);
        }
        // GET: Complete
        [HttpGet]
        public ActionResult Complete(string username)
        {
            return View(db.NGUOIDUNGs.Where(m => m.USERNAME == username).First());
        }
        [HttpPost]
        public ActionResult Main(NGUOIDUNG _user)
        {
            if (ModelState.IsValid)
            {
                var check = db.NGUOIDUNGs.Where(s => s.USERNAME == _user.USERNAME).FirstOrDefault();
                if(check == null)
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.NGUOIDUNGs.Add(_user);
                    db.SaveChanges();
                    return RedirectToAction("Complete", "Register", new {username = _user.USERNAME});
                }
                else
                {
                    ViewBag.ErrMsg = "Username này đã tồn tại.";
                    return View();
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult Complete(string username, NGUOIDUNG _user)
        {
            try
            {
                if (_user.ImageUpload != null)
                {
                    string file = Path.GetFileNameWithoutExtension(_user.ImageUpload.FileName);
                    string extenstion = Path.GetExtension(_user.ImageUpload.FileName);
                    file = file + extenstion;
                    _user.PROFILEPIC = "~/Content/img/" + file;
                    _user.ImageUpload.SaveAs(Path.Combine(Server.MapPath("~/Content/img/"), file));
                }
                db.Entry(_user).State = System.Data.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Main", "Register");
            }
            catch
            {
                return View();
            }
        }
    }
}