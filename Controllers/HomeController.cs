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
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            // read all json file contents and put them into the table
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:5000/api/stockapi");
                var model = JsonConvert.DeserializeObject<List<StockModel>>(
                response.Content.ReadAsStringAsync().Result);
                return View(model);
            }            
        }

        [Route("stock/{stockId}")]
        public async Task<StockModel> Index(int stockId){
            // get data with given stockId
            using(var client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:5000/api/stockapi/"+stockId);
                var data = JsonConvert.DeserializeObject<StockModel>(
                response.Content.ReadAsStringAsync().Result);
                return data;
            }            
        }

        [HttpPost]
        public IActionResult Index(StockModel model)
        {
            // read files from json file and change specified stock value by id
            var json = System.IO.File.ReadAllText("Models/stocks.json");
            dynamic jsonObj = JsonConvert.DeserializeObject(json); // first make deserialize it
            
            foreach(var val in jsonObj){
                if(val.StockId == model.StockId){
                    val.StockName = model.StockName;
                }
            }
            var output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented); // finally serialize again
            System.IO.File.WriteAllText("Models/stocks.json", output); // write final values in to the stocks.json

            return RedirectToAction("Index", "Home");
        }

        [Route("show/{title}")]
        public async Task<ActionResult> Index(string title)
        {
            // get data with specified title value
            using (var client = new HttpClient())
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
