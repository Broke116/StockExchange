using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StockExchange.Service;
using StockExchange.Models;

namespace StockExchange.API
{
    [Route("api/[controller]")]
    public class StockApiController : Controller
    {
        DataService service;

        public StockApiController()
        {
            service = new DataService();
        }

        [HttpGet]
        public List<StockModel> Get()
        {
            var list = service.GetData();
            return list;
        }

        [HttpGet("{name}")]
        public StockModel Get(string name)
        {
            var list = service.GetData();
            name = name.Replace("-", " ");
            return list.Where(l => l.StockName == name).FirstOrDefault();
        }

        [HttpGet("{stockId:int}")]
        public StockModel Get(int stockId)
        {
            var list = service.GetData();
            return list.Where(l => l.StockId == stockId).FirstOrDefault();
        }
    }
}