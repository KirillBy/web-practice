using HW06072020_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW06072020_1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult List()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product
            {
                Id = 1,
                Name = "first product",
                Price = 10,
                Description = "This is first product"


            });
            products.Add(new Product
            {
                Id = 2,
                Name = "second product",
                Price = 15,
                Description = "This is second product"


            });
            products.Add(new Product
            {
                Id = 3,
                Name = "third product",
                Price = 25,
                Description = "This is third product"


            });
            products.Add(new Product
            {
                Id = 4,
                Name = "fouth product",
                Price = 21,
                Description = "This is fourth product"


            });
            return View(products);
        }

        // GET: Product
        public ActionResult Details()
        {
            return View();
        }
    }
}