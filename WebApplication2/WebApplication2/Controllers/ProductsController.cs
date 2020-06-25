using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult List()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product
            {
                Id = 1,
                Name = "Product 1",
                Price = 10,
                Description = "This is Product 1"
            } ) ;
            products.Add(new Product
            {
                Id = 2,
                Name = "Product 2",
                Price = 20,
                Description = "This is Product 2"
            });
            products.Add(new Product
            {
                Id = 3,
                Name = "Product 3",
                Price = 30,
                Description = "This is Product 3"
            });
            return View(products);
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}