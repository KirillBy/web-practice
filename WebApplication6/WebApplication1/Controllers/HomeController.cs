using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product
            {
                ID = 1,
                Name = "first product",
                Price = 10,
                CreationDate = new DateTime(2020, 01, 01)


            });
            products.Add(new Product
            {
                ID = 2,
                Name = "second product",
                Price = 20,
                CreationDate = new DateTime(2020, 01, 02)


            });
            products.Add(new Product
            {
                ID = 3,
                Name = "third product",
                Price = 30,
                CreationDate = new DateTime(2020, 01, 03)


            });
            products.Add(new Product
            {
                ID = 4,
                Name = "fourth product",
                Price = 40,
                CreationDate = new DateTime(2020, 01, 04)


            });
            return View(products);
        }

    }
}