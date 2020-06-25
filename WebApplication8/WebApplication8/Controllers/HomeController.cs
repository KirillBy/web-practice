using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
     

        public ActionResult Index(int? id)
        {
            if (id != null)
                return Content($"ID = {id}", "text/plain");
            else
            {
                ViewBag.Message = "Данные не предоставлены";
                return View();
            }
        }
    }
}