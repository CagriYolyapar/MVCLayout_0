using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLayout_0.Areas.Danisman.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Danisman/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}