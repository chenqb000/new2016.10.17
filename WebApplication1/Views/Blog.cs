using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Views
{
    public class Blog : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
    }
}