namespace StockExchange.Models
{
    public class StockModel
    {
        public StockModel(){ }

        public int StockId { get; set; }
        public string StockName { get; set; }
        public double LastPrice { get; set; }
        public double BuyingPrice { get; set; }
        public double SalesPrice { get; set; }
        public double DailyLow { get; set; }
        public double DailyHigh { get; set; }
        public double DailyChange { get; set; }
        public double DailyCapacity { get; set; }
    }
}