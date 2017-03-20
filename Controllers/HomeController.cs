using Microsoft.AspNetCore.Mvc;
using StockExchange.Service;

namespace StockExchange.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var service = new DataService();
            var list = service.GetData();

            return View(list);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
