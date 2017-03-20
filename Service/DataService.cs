using System.IO;
using System.Collections.Generic;
using StockExchange.Models;
using Newtonsoft.Json;

namespace StockExchange.Service
{
    public class DataService
    {
        public DataService() { }

        public List<StockModel> GetData()
        {
            var stockModel = JsonConvert.DeserializeObject<List<StockModel>>(File.ReadAllText("Models/stocks.json"));  

            return stockModel;
        }        
    }
}