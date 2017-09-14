using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TShirtStore.WebUI.Models;

namespace TShirtStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private List<Product> products;
        public HomeController()
        {
            products = new List<Product>()
            {
             new Product() { ProductID=1,ProductName="White TShirt",ProductPrice=10},
             new Product() { ProductID=2,ProductName="Black TShirt",ProductPrice=11},
             new Product() { ProductID=3,ProductName="Green TShirt",ProductPrice=12}
            };
        }
        public ActionResult Index()
        {

            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult GetProductById(int id)
        {
            var product = products.Where(x => x.ProductID == id).FirstOrDefault();
            return View(product);
        }
    }
}