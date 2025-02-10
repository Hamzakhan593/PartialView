using Microsoft.AspNetCore.Mvc;
using PartialView.Models;
using System.Diagnostics;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            List<Product> products = new List<Product>()
            {
                new Product{ProductId = 1, ProductName = "Watch", Price = 500, Image = "~/Images/watch.jpg", ProductDescription = "watches with affordable price"},
                new Product{ProductId = 2, ProductName = "Glasses", Price = 500, Image = "~/Images/pexels-donaldtong94-39716.jpg", ProductDescription = "Glasses with affordable price"},
                new Product{ProductId = 3, ProductName = "Shoes", Price = 500, Image = "~/Images/pexels-webdonut-19090.jpg", ProductDescription = "Shoes with affordable price"}
            };
            return View(products);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
