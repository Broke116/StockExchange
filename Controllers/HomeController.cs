using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StockExchange.Models;

namespace StockExchange.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:5000/api/stockapi");
                var model = JsonConvert.DeserializeObject<List<StockModel>>(
                response.Content.ReadAsStringAsync().Result);
                return View(model);
            }            
        }

        [Route("show/{title}")]
        public async Task<ActionResult> Index(string title)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:5000/api/stockapi/"+title);
                var data = JsonConvert.DeserializeObject<StockModel>(
                response.Content.ReadAsStringAsync().Result);
                var model=new List<StockModel>();   
                model.Add(data);             
                return View(model);
            }            
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
