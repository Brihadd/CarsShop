using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car
    {
        public int Id { get; set; }
        public DealState DealState { get; set; }
        public int ClientId { get; set; }
        public int ClientCarBuyerId { get; set; }
        public string Comment { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CarRegNumber { get; set; }
        public int CarYear { get; set; }
        public Fuel Fuel { get; set; }
        public double Kilometers { get; set; }
        public Condition Condition { get; set; }  
        public string EngineName { get; set; }
        public double EnginePower { get; set; }
        public double EngineVolume { get; set; }
        public int Discount { get; set; }
        public decimal RequaredPrice { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public bool IsLuxury { get; set; }

    }
    public enum Fuel
    {
        Petrol,
        Diesel,
        LPG,
        CNG,
        Electricity
    }
    public enum Condition
    {
        Excellent,
        Good,
        Bad,
        Pig
    }
    public enum DealState
    {
        New,
        ForPricing,
        NotEnoughInformation,
        Priced,
        Refused,
        Bought,
        Sold,
        Deleted
    }
}
