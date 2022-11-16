using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpaceCourse.Controllers
{
    public class ForumController : Controller
    {
        // GET: Forum
        public ActionResult Home()
        {
            return View();
        }
    }
}