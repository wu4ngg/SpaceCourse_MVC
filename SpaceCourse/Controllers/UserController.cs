using SpaceCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceCourse.Controllers
{
    public class UserController : Controller
    {
        SPACECOURSE_DB1 db = new SPACECOURSE_DB1();
        // GET: User
        public PartialViewResult UserArea(int id)
        {
            var usr = db.Users.Where(m => m.id_user == id).FirstOrDefault();
            return PartialView(usr);
        }
        public PartialViewResult UserMenu(int id)
        {
            var usr = db.Users.Where(m => m.id_user == id).FirstOrDefault();
            return PartialView(usr);
        }
    }
}