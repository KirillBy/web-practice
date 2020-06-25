using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Add(int? x, int? y)
        {
            ViewBag.Result = x + y;
            return View();
        }

        public ActionResult Mul(int? x, int? y)
        {
            ViewBag.Result = x - y;
            return View("Add");
        }

        public ActionResult Sub(int? x, int? y)
        {
            ViewBag.Result = x * y;
            return View("Add");
        }

        public ActionResult Div(double x, double y)
        {
            if (y != 0)
                ViewBag.Result = Math.Round(x / y, 2);
            else
                ViewBag.Result = 0;
            return View("Add");
        }
    }
}